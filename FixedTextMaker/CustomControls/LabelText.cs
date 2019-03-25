using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixedTextMaker.CustomControls
{
    /// <summary>
    /// キャプションとテキストボックスが対になったユーザーコントロール
    /// </summary>
    public partial class LabelText : UserControl
    {
        public LabelText()
        {
            InitializeComponent();
        }

        /// <summary>
        /// そのレコードを識別するキー項目か否かを取得または設定します。
        /// </summary>
        public bool IsKey
        {
            get { return this.IsKeyMark.Visible; }
            set { this.IsKeyMark.Visible = value; }
        }

        /// <summary>
        /// 固定行のスタート位置を取得または設定します。
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// アイテムの長さを取得または設定します。
        /// </summary>
        public int ItemLength { get; set; }

        /// <summary>
        /// パディングする指定文字列を取得または設定します。
        /// </summary>
        public string PaddingChar { get; set; }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            PadChar();
        }

        public void PadChar()
        {
            if (string.IsNullOrEmpty(PaddingChar)) return;
            TextBox.Text = TextBox.Text.PadLeft(TextBox.MaxLength, PaddingChar[0]);
        }

    }
}
