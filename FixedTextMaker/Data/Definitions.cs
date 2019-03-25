using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixedTextMaker.Model;
using System.Xml.Serialization;
using System.IO;

namespace FixedTextMaker.Data
{
    class Definitions
    {
        /// <summary>
        /// 定義ファイルを読み込みます
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static FixedTextDefines Load( string path )
        {
            var xmlSerializer = new XmlSerializer(typeof(FixedTextDefines));
            FixedTextDefines result;
            var xmlSettings = new System.Xml.XmlReaderSettings();
            using (var streamReader = new StreamReader(path, Encoding.UTF8))
            using (var xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings))
            {
                result = (FixedTextDefines)xmlSerializer.Deserialize(xmlReader);
            }
            return result;
        }
    }
}
