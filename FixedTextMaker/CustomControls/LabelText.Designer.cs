namespace FixedTextMaker.CustomControls
{
    partial class LabelText
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Caption = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.IsKeyMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Caption.Location = new System.Drawing.Point(3, 4);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(128, 18);
            this.Caption.TabIndex = 0;
            this.Caption.Text = "XXXXXXXXXXXXXXX";
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBox.Location = new System.Drawing.Point(137, 4);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(248, 20);
            this.TextBox.TabIndex = 1;
            this.TextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // IsKeyMark
            // 
            this.IsKeyMark.AutoSize = true;
            this.IsKeyMark.BackColor = System.Drawing.SystemColors.Control;
            this.IsKeyMark.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IsKeyMark.ForeColor = System.Drawing.Color.DarkRed;
            this.IsKeyMark.Location = new System.Drawing.Point(391, 7);
            this.IsKeyMark.Name = "IsKeyMark";
            this.IsKeyMark.Size = new System.Drawing.Size(15, 18);
            this.IsKeyMark.TabIndex = 2;
            this.IsKeyMark.Text = "*";
            this.IsKeyMark.Visible = false;
            // 
            // LabelText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IsKeyMark);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Caption);
            this.Name = "LabelText";
            this.Size = new System.Drawing.Size(415, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Caption;
        public System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label IsKeyMark;
    }
}
