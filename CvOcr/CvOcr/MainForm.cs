namespace CvOcr;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using Tesseract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary></summary>
public partial class MainForm : Form
{
    private Mat? _targetMat = null;


    /// <summary></summary>
    public MainForm()
    {
        InitializeComponent();
    }


#region private Events
    /// <summary></summary>
    private void OnShown(object source, EventArgs e)
    {
    }

    /// <summary></summary>
    private void OnPictureChooseClick(object source, EventArgs e)
    {
        using(var dlg = new OpenFileDialog())
        {
            dlg.Filter = "画像ファイル(*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|全てのファイル(*.*)|*.*";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            dlg.Multiselect = false;

            if(DialogResult.OK == dlg.ShowDialog(this))
            {
                _targetMat?.Dispose();
                _targetMat = null;

                pathText.Text = dlg.FileName;

                try
                {
                    _targetMat = Cv2.ImRead(fileName: pathText.Text);
                    targetPicture.Image = BitmapConverter.ToBitmap(src: _targetMat);
                }
                catch(Exception ex)
                {
#if DEBUG
                    Debug.WriteLine($"ERROR | {ex.GetType().FullName} {ex.Message}");
                    Debug.WriteLine(ex.StackTrace);
                    
                    if(ex.InnerException != null)
                    {
                        Debug.WriteLine($"\t{ex.InnerException.Message}");
                    }
#endif
                }
            }
        }
    }

    /// <summary></summary>
    private void OnExecuteClick(object source, EventArgs e)
    {
        try
        {
            if(targetPicture.Image is Bitmap bitmap)
            {
                extractedText.Text = ExecuteOcr(bitmap) ?? string.Empty;
            }
        }
        catch(Exception ex)
        {
#if DEBUG
            Debug.WriteLine($"ERROR | {ex.GetType().FullName} {ex.Message}");
            Debug.WriteLine(ex.StackTrace);
#endif
        }
    }
#endregion private Events

    /// <summary></summary>
    private string? ExecuteOcr(Bitmap bitmap)
    {
        using var tesseract = new TesseractEngine(
                datapath: @"C:\Users\mynah\AppData\Local\Programs\Tesseract-OCR\tessdata",
                language: "jpn");

        //tesseract.SetVariable(name: "tessedit_char_whitelist", "");

        var page = tesseract.Process(bitmap);

        return page.GetText();
    }
}
