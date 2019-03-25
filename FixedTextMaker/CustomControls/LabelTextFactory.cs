using FixedTextMaker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedTextMaker.CustomControls
{
    class LabelTextFactory
    {
        /// <summary>
        /// 定義情報からLabelTextを作成します
        /// </summary>
        /// <param name="lBox"></param>
        /// <returns></returns>
        public static LabelText Generate( FixedTextRecordItems lBox, int startIndex)
        {
            var lt = new LabelText();
            //ラベル部
            lt.Caption.Text = lBox.Name;

            //テキストボックス部
            lt.TextBox.MaxLength = lBox.Length;
            lt.TextBox.Text = lBox.FixedText;
            lt.TextBox.Enabled = string.IsNullOrEmpty(lBox.FixedText);
            lt.IsKey = lBox.Recognition;
            lt.PaddingChar = lBox.Padchar;
            lt.PadChar();
            lt.StartIndex = startIndex;
            lt.ItemLength = lBox.Length;
            return lt;
        }

    }
}
