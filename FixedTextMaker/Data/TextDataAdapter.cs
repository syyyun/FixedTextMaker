using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixedTextMaker.Model;

namespace FixedTextMaker.Data
{
    /// <summary>
    /// 定義モデルと読み込みデータのバインドに関する処理を提供します
    /// </summary>
    class TextDataAdapter
    {
        private readonly FixedTextDefines TextDefines;
        private readonly List<string> DataRecords;
        private readonly int KeyLength;
        public bool HasCrLf { get; private set; }

        private TextDataAdapter() { }

        public TextDataAdapter(FixedTextDefines defines) : this(defines, "")
        {
            
        }

        public TextDataAdapter(FixedTextDefines defines, string dataText)
        {
            TextDefines = defines;
            //TODO：テキストが挿入された状態と合わせなければならない、もしくはテキストボックス側を直計算する
            DataRecords = new List<string>();
            //最初の文字からレコード識別を読み込んで、内部情報として保持していく
            KeyLength = TextDefines.Records.First().Items.Where(v => v.Recognition).First().Length;

            HasCrLf = dataText.IndexOf("\r\n") > 0;
            if (string.IsNullOrEmpty(dataText)) return;
            var firstKeyValue = dataText.Substring(0, KeyLength);
            int textIndex = 0;
            while (true)
            {
                try
                {
                    var kind = GetRecordKind(firstKeyValue);
                    var sb = new StringBuilder();
                    foreach (var item in kind.Items)
                    {
                        sb.Append(dataText.Substring(textIndex, item.Length));
                        textIndex += item.Length;
                    }
                    DataRecords.Add(sb.ToString());
                }
                catch (ArgumentOutOfRangeException)
                {
                    //テキストがなくなったら終わり
                    break;
                }
            }
        }

        public string GetParsedText() {
            var sb = new StringBuilder();
            foreach (var textLine in DataRecords)
            {
                if (HasCrLf)
                {
                    sb.Append(textLine);
                } else
                {
                    sb.AppendLine(textLine);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 【バグるから利用禁止】指定された行数と列インデックスを元に、指定項目の値を取得します
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public TextDataInfo GetTextItem( int rowIndex, int cursorIndex )
        {
            //TODO：テキストが挿入された状態と合わせなければならない、もしくはテキストボックス側を直計算する
            var info = new TextDataInfo();
            var recordKind = GetRecordKind(GetKey(DataRecords[rowIndex]));
            int indexSummary = 0;
            foreach (var item in recordKind.Items)
            {
                var future = indexSummary + item.Length;
                if (future > cursorIndex)
                {
                    info.StartIndex = indexSummary;
                    info.ItemLength = item.Length;
                    break;
                }
                indexSummary += item.Length;
            }
            info.TextValue = DataRecords[rowIndex].Substring(info.StartIndex, info.ItemLength);
            return info;
        }

        /// <summary>
        /// レコードキーを取得します。
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string GetKey( string line )
        {
            if (line.Length < KeyLength) return "";
            return line.Substring(0, KeyLength);
        }

        /// <summary>
        /// 指定キーからレコードタイプを取得します
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public FixedTextRecord GetRecordKind( string key )
        {
            foreach (var record in TextDefines.Records)
            {
                if (record.Items.Where(v=> v.Recognition).Where(item => item.FixedText == key).Any())
                {
                    return record;
                }
            }
            throw new ArgumentException("キー情報から定義レコード情報を取得することができませんでした");
        }

    }

    /// <summary>
    /// レコード定義情報を提供します
    /// </summary>
    class TextDataInfo
    {
        public int StartIndex;
        public string TextValue;
        public int ItemLength;
    }


}
