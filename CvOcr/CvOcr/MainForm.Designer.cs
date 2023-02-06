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
            this.targetPicture = new System.Windows.Forms.PictureBox();
            this.pathText = new System.Windows.Forms.TextBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.pathGroup = new System.Windows.Forms.GroupBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.extractedText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).BeginInit();
            this.pathGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetPicture
            // 
            this.targetPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPicture.Location = new System.Drawing.Point(318, 12);
            this.targetPicture.Name = "targetPicture";
            this.targetPicture.Size = new System.Drawing.Size(614, 564);
            this.targetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetPicture.TabIndex = 1;
            this.targetPicture.TabStop = false;
            // 
            // pathText
            // 
            this.pathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathText.BackColor = System.Drawing.SystemColors.Control;
            this.pathText.ForeColor = System.Drawing.Color.Blue;
            this.pathText.Location = new System.Drawing.Point(6, 24);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(288, 25);
            this.pathText.TabIndex = 0;
            this.pathText.Text = "#";
            // 
            // chooseButton
            // 
            this.chooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseButton.Location = new System.Drawing.Point(194, 55);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(100, 28);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "選択(&C)";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.OnPictureChooseClick);
            // 
            // pathGroup
            // 
            this.pathGroup.Controls.Add(this.pathText);
            this.pathGroup.Controls.Add(this.chooseButton);
            this.pathGroup.Location = new System.Drawing.Point(12, 12);
            this.pathGroup.Name = "pathGroup";
            this.pathGroup.Size = new System.Drawing.Size(300, 92);
            this.pathGroup.TabIndex = 0;
            this.pathGroup.TabStop = false;
            this.pathGroup.Text = "Path";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(181, 110);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(125, 28);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "実行(&E)";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.OnExecuteClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(944, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // extractedText
            // 
            this.extractedText.BackColor = System.Drawing.SystemColors.Control;
            this.extractedText.Location = new System.Drawing.Point(12, 144);
            this.extractedText.Multiline = true;
            this.extractedText.Name = "extractedText";
            this.extractedText.ReadOnly = true;
            this.extractedText.Size = new System.Drawing.Size(294, 166);
            this.extractedText.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.extractedText);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.pathGroup);
            this.Controls.Add(this.targetPicture);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "MainForm";
            this.Text = "CvOcr";
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).EndInit();
            this.pathGroup.ResumeLayout(false);
            this.pathGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox targetPicture;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.GroupBox pathGroup;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox extractedText;
    }
}

