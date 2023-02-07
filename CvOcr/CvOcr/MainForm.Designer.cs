namespace CvOcr
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.messageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureList = new System.Windows.Forms.ListView();
            this.fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureListRemoveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureListRemoveAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureGroup = new System.Windows.Forms.GroupBox();
            this.extractText = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.targetPicture = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.pictureListContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pictureGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(944, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // messageStatusLabel
            // 
            this.messageStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.messageStatusLabel.Name = "messageStatusLabel";
            this.messageStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.messageStatusLabel.Text = "#";
            // 
            // pictureList
            // 
            this.pictureList.AllowDrop = true;
            this.pictureList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameHeader,
            this.pathHeader});
            this.pictureList.ContextMenuStrip = this.pictureListContextMenu;
            this.pictureList.FullRowSelect = true;
            this.pictureList.GridLines = true;
            this.pictureList.HideSelection = false;
            this.pictureList.Location = new System.Drawing.Point(12, 57);
            this.pictureList.Name = "pictureList";
            this.pictureList.Size = new System.Drawing.Size(397, 507);
            this.pictureList.TabIndex = 3;
            this.pictureList.UseCompatibleStateImageBehavior = false;
            this.pictureList.View = System.Windows.Forms.View.Details;
            this.pictureList.VirtualMode = true;
            this.pictureList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.OnPictureListRetrieveVirtualItem);
            this.pictureList.SelectedIndexChanged += new System.EventHandler(this.OnPictureListSelectedIndexChanged);
            this.pictureList.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnPictureListDragDrop);
            this.pictureList.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnPictureListDragEnter);
            // 
            // fileNameHeader
            // 
            this.fileNameHeader.Text = "ファイル名";
            this.fileNameHeader.Width = 129;
            // 
            // pathHeader
            // 
            this.pathHeader.Text = "パス";
            this.pathHeader.Width = 316;
            // 
            // pictureListContextMenu
            // 
            this.pictureListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureListRemoveMenu,
            this.pictureListRemoveAllMenu});
            this.pictureListContextMenu.Name = "pictureListContextMenu";
            this.pictureListContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // pictureListRemoveMenu
            // 
            this.pictureListRemoveMenu.Enabled = false;
            this.pictureListRemoveMenu.Name = "pictureListRemoveMenu";
            this.pictureListRemoveMenu.Size = new System.Drawing.Size(180, 22);
            this.pictureListRemoveMenu.Text = "除外(&R)";
            this.pictureListRemoveMenu.Click += new System.EventHandler(this.OnPictureListClearMenuClick);
            // 
            // pictureListRemoveAllMenu
            // 
            this.pictureListRemoveAllMenu.Name = "pictureListRemoveAllMenu";
            this.pictureListRemoveAllMenu.Size = new System.Drawing.Size(180, 22);
            this.pictureListRemoveAllMenu.Text = "全て除外(&A)";
            this.pictureListRemoveAllMenu.Click += new System.EventHandler(this.OnPictureListClearAllMenuClick);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureGroup);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.messageLabel);
            this.splitContainer.Panel2.Controls.Add(this.pictureList);
            this.splitContainer.Panel2.Controls.Add(this.headerLabel);
            this.splitContainer.Panel2.Controls.Add(this.chooseButton);
            this.splitContainer.Size = new System.Drawing.Size(944, 579);
            this.splitContainer.SplitterDistance = 520;
            this.splitContainer.TabIndex = 0;
            // 
            // pictureGroup
            // 
            this.pictureGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureGroup.Controls.Add(this.extractText);
            this.pictureGroup.Controls.Add(this.executeButton);
            this.pictureGroup.Controls.Add(this.targetPicture);
            this.pictureGroup.Location = new System.Drawing.Point(12, 4);
            this.pictureGroup.Name = "pictureGroup";
            this.pictureGroup.Size = new System.Drawing.Size(504, 572);
            this.pictureGroup.TabIndex = 0;
            this.pictureGroup.TabStop = false;
            this.pictureGroup.Text = "Picture";
            // 
            // extractText
            // 
            this.extractText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extractText.Location = new System.Drawing.Point(0, 260);
            this.extractText.Multiline = true;
            this.extractText.Name = "extractText";
            this.extractText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.extractText.Size = new System.Drawing.Size(498, 306);
            this.extractText.TabIndex = 2;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.Location = new System.Drawing.Point(398, 226);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(100, 28);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "OCR実行(&E)";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.OnExecuteClick);
            // 
            // targetPicture
            // 
            this.targetPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.targetPicture.Location = new System.Drawing.Point(6, 24);
            this.targetPicture.Name = "targetPicture";
            this.targetPicture.Size = new System.Drawing.Size(492, 196);
            this.targetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.targetPicture.TabIndex = 0;
            this.targetPicture.TabStop = false;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Blue;
            this.messageLabel.Location = new System.Drawing.Point(9, 36);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(365, 18);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "リストに対してドラッグ && ドロップでもファイルを追加できます.";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(9, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(104, 18);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "画像ファイル選択";
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(119, 4);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(100, 28);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "選択(&C)";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.OnPictureChooseClick);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "MainForm";
            this.Text = "CvOcr";
            this.Shown += new System.EventHandler(this.OnShown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pictureListContextMenu.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pictureGroup.ResumeLayout(false);
            this.pictureGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ListView pictureList;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox pictureGroup;
        private System.Windows.Forms.TextBox extractText;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.PictureBox targetPicture;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.ColumnHeader fileNameHeader;
        private System.Windows.Forms.ColumnHeader pathHeader;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ToolStripStatusLabel messageStatusLabel;
        private System.Windows.Forms.ContextMenuStrip pictureListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pictureListRemoveAllMenu;
        private System.Windows.Forms.ToolStripMenuItem pictureListRemoveMenu;
    }
}

