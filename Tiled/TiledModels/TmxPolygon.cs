namespace SimpleTiled
{
    using System.Xml.Serialization;

    public class TmxPolygon
    {
        [XmlAttribute( DataType = "string", AttributeName = "points" )]
        public string Points { get; set; }
    }
}