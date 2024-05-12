namespace SimpleTiled
{
    using System.Xml.Serialization;

    public class TmxImageLayer : TmxLayer
    {
        [XmlElement( ElementName = "image" )]
        public TmxImage Image;
    }
}