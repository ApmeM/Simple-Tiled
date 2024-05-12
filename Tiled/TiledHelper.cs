namespace SimpleTiled
{
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    public class TiledHelper
    {
        public static void Write(TmxMap map, Stream destination)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TmxMap));
            var xml = string.Empty;
            using (var stringWriter = new Utf8StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true, Encoding = Encoding.UTF8 }))
                {
                    serializer.Serialize(xmlWriter, map);
                    xml = stringWriter.ToString();
                }
            }

            using (var sw = new StreamWriter(destination))
            {
                sw.Write(xml);
            }
        }

        public static TmxMap Read(Stream source)
        {
            XmlSerializer ser = new XmlSerializer(typeof(TmxMap));
            return (TmxMap)ser.Deserialize(source);
        }

        private class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return new UTF8Encoding(false); }
            }
        }
    }
}