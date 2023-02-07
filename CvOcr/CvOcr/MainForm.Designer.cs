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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pictureList = new System.Windows.Forms.ListView();
            this.fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureGroup = new System.Windows.Forms.GroupBox();
            this.extractText = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.targetPicture = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(944, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
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
            this.pictureList.FullRowSelect = true;
            this.pictureList.GridLines = true;
            this.pictureList.HideSelection = false;
            this.pictureList.Location = new System.Drawing.Point(12, 12);
            this.pictureList.Name = "pictureList";
            this.pictureList.Size = new System.Drawing.Size(602, 552);
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
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureGroup);
            this.splitContainer.Panel1.Controls.Add(this.headerLabel);
            this.splitContainer.Panel1.Controls.Add(this.chooseButton);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pictureList);
            this.splitContainer.Size = new System.Drawing.Size(944, 579);
            this.splitContainer.SplitterDistance = 315;
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
            this.pictureGroup.Location = new System.Drawing.Point(12, 65);
            this.pictureGroup.Name = "pictureGroup";
            this.pictureGroup.Size = new System.Drawing.Size(299, 511);
            this.pictureGroup.TabIndex = 5;
            this.pictureGroup.TabStop = false;
            this.pictureGroup.Text = "Picture";
            // 
            // extractText
            // 
            this.extractText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extractText.Location = new System.Drawing.Point(0, 224);
            this.extractText.Multiline = true;
            this.extractText.Name = "extractText";
            this.extractText.Size = new System.Drawing.Size(293, 281);
            this.extractText.TabIndex = 2;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.Location = new System.Drawing.Point(193, 190);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(100, 28);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "実行(&E)";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.OnExecuteClick);
            // 
            // targetPicture
            // 
            this.targetPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPicture.Location = new System.Drawing.Point(6, 24);
            this.targetPicture.Name = "targetPicture";
            this.targetPicture.Size = new System.Drawing.Size(287, 160);
            this.targetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.targetPicture.TabIndex = 0;
            this.targetPicture.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(188, 18);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "##################";
            // 
            // chooseButton
            // 
            this.chooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseButton.Location = new System.Drawing.Point(206, 31);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(100, 28);
            this.chooseButton.TabIndex = 4;
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
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
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
    }
}

