namespace CvOcr;

using Tesseract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


/// <summary></summary>
public partial class MainForm : Form
{
    private ListViewItem[]? _pictureItems = null;


    /// <summary></summary>
    public MainForm()
    {
        InitializeComponent();
    }


#region private Events
    /// <summary></summary>
    private void OnShown(object source, EventArgs e) { }

    /// <summary></summary>
    private void OnPictureListDragEnter(object source, DragEventArgs e)
    {
        e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
            ? DragDropEffects.Copy
            : DragDropEffects.None;
    }

    /// <summary></summary>
    private void OnPictureListRetrieveVirtualItem(
            object source,
            RetrieveVirtualItemEventArgs e)
    {
        if(! (_pictureItems?.Any() ?? false) || e.ItemIndex > _pictureItems.Count())
        {
            return;
        }

        e.Item = _pictureItems[e.ItemIndex];
    }

    /// <summary></summary>
    private void OnPictureListDragDrop(object source, DragEventArgs e)
    {
        var obj = e.Data.GetData(DataFormats.FileDrop);

        if(obj != null
                && obj is IEnumerable<string> filePaths
                && filePaths.Any())
        {
            AddPictureListItems(filePaths);
        }
    }

    /// <summary></summary>
    private void OnPictureListSelectedIndexChanged(object source, EventArgs e)
    {
        targetPicture.Image?.Dispose();
        targetPicture.Image = null;

        if(pictureList.SelectedIndices.Count == 0)
        {
            return;
        }

        if(_pictureItems != null
                && _pictureItems[pictureList.SelectedIndices[0]].Tag != null
                && _pictureItems[pictureList.SelectedIndices[0]].Tag is string path)
        {
            targetPicture.Image = Bitmap.FromFile(filename: path);
            var size = targetPicture.Image.Size;
            messageStatusLabel.Text = $"Size: {size.Width}x{size.Height}";
        }
    }

    /// <summary></summary>
    private void OnPictureChooseClick(object source, EventArgs e)
    {
        using(var dlg = new OpenFileDialog())
        {
            dlg.Filter = "画像ファイル(*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|全てのファイル(*.*)|*.*";
            dlg.FilterIndex      = 0;
            dlg.RestoreDirectory = true;
            dlg.Multiselect      = true;

            if(DialogResult.OK == dlg.ShowDialog(this))
            {
                AddPictureListItems(dlg.FileNames);
            }
        }
    }

    /// <summary></summary>
    private void OnPictureListClearMenuClick(object source, EventArgs e)
    {
    }

    /// <summary></summary>
    private void OnPictureListClearAllMenuClick(object source, EventArgs e)
    {
        _pictureItems = null;
        pictureList.VirtualListSize = 0;
    }

    /// <summary></summary>
    private void OnExecuteClick(object source, EventArgs e)
    {
        if(_pictureItems == null
                || ! _pictureItems.Any()
                || pictureList.SelectedIndices.Count == 0)
        {
            MessageBox.Show(
                    caption: "警告",
                    text:    "処理対象の画像が選択されていません.",
                    icon:    MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.OK);

            return;
        }

        var tag = _pictureItems[pictureList.SelectedIndices[0]].Tag;
        executeButton.Enabled = false;
        extractText.Enabled   = false;
        if(tag != null && tag is string path)
        {
            using var bmp = new Bitmap(filename: path);
            messageStatusLabel.Text = "処理中...";

            string? text = null;
            try
            {
                text = ExecuteOcr(bmp);
            }
            catch(Exception ex)
            {
#if DEBUG
                Debug.WriteLine($"ERROR | {ex.GetType().FullName} {ex.Message}");
                Debug.WriteLine(ex.StackTrace);
#endif

                MessageBox.Show(
                        caption: "エラー",
                        text:    "テキスト抽出失敗.\n" + ex.Message,
                        icon:    MessageBoxIcon.Error,
                        buttons: MessageBoxButtons.OK);
            }
            finally
            {
                messageStatusLabel.Text = "処理終了";

                extractText.Text      = text ?? "(失敗)";
                extractText.ForeColor = (text != null) ? Color.Blue : Color.Coral;

                executeButton.Enabled = true;
                extractText.Enabled   = true;
            }
        }
    }
#endregion private Events
    /// <summary></summary>
    private void AddPictureListItems(IEnumerable<string> filePaths)
    {
        List<ListViewItem> items = new ();
        if(_pictureItems?.Any() ?? false)
            items.AddRange(_pictureItems);

        // 重複確認はしない.
        foreach(var filePath in filePaths)
        {
            items.Add(new ListViewItem(
                        new string[] { Path.GetFileName(filePath), filePath }) { Name = filePath, Tag = filePath });
        }

        _pictureItems = items.ToArray();
        pictureList.VirtualListSize = _pictureItems.Length;
        pictureList.Refresh();
    }

    /// <summary></summary>
    private string? ExecuteOcr(Bitmap bitmap)
    {
        var local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        using var tesseract = new TesseractEngine(
                datapath: Path.Combine(local, "Programs", "Tesseract-OCR", "tessdata"),
                language: "jpn");

        //tesseract.SetVariable(name: "tessedit_char_whitelist", "");

        var page = tesseract.Process(bitmap);

        return page.GetText();
    }
}
