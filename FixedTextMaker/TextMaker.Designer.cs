namespace FixedTextMaker
{
    partial class TextMaker
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.Windows.Forms.Panel panelTop;
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnOpenDataFile = new System.Windows.Forms.Button();
            this.btnOpenDefinitionFile = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.MyTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            panelTop = new System.Windows.Forms.Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(this.btnAddRow);
            panelTop.Controls.Add(this.btnOpenDataFile);
            panelTop.Controls.Add(this.btnOpenDefinitionFile);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(724, 66);
            panelTop.TabIndex = 2;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(313, 4);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "行の挿入";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnOpenDataFile
            // 
            this.btnOpenDataFile.Location = new System.Drawing.Point(152, 4);
            this.btnOpenDataFile.Name = "btnOpenDataFile";
            this.btnOpenDataFile.Size = new System.Drawing.Size(143, 23);
            this.btnOpenDataFile.TabIndex = 1;
            this.btnOpenDataFile.Text = "データファイル読み込み";
            this.btnOpenDataFile.UseVisualStyleBackColor = true;
            this.btnOpenDataFile.Click += new System.EventHandler(this.btnOpenDataFile_Click);
            // 
            // btnOpenDefinitionFile
            // 
            this.btnOpenDefinitionFile.Location = new System.Drawing.Point(4, 4);
            this.btnOpenDefinitionFile.Name = "btnOpenDefinitionFile";
            this.btnOpenDefinitionFile.Size = new System.Drawing.Size(141, 23);
            this.btnOpenDefinitionFile.TabIndex = 0;
            this.btnOpenDefinitionFile.Text = "定義ファイル読み込み";
            this.btnOpenDefinitionFile.UseVisualStyleBackColor = true;
            this.btnOpenDefinitionFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MyTextBox);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(724, 612);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(720, 291);
            this.tabControlMain.TabIndex = 0;
            // 
            // MyTextBox
            // 
            this.MyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MyTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MyTextBox.Location = new System.Drawing.Point(3, 3);
            this.MyTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.MyTextBox.Name = "MyTextBox";
            this.MyTextBox.Size = new System.Drawing.Size(714, 303);
            this.MyTextBox.TabIndex = 0;
            this.MyTextBox.Text = "";
            this.MyTextBox.WordWrap = false;
            this.MyTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // TextMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 678);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(panelTop);
            this.Name = "TextMaker";
            this.Text = "固定テキストメーカー";
            panelTop.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button btnOpenDefinitionFile;
        private System.Windows.Forms.Button btnOpenDataFile;
        private System.Windows.Forms.RichTextBox MyTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnAddRow;
    }
}

