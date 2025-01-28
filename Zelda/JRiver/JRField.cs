using System;
using System.Xml;
using System.Xml.Serialization;

namespace Zelda
{
    [XmlRoot("Response")]
    public class JRFieldList
    {
        [XmlArrayItem(),
        XmlArrayItem(typeof(JRField), ElementName = "Field")]
        public JRField[] Fields { get; set; }

        public JRFieldList() { }
    }

    public class JRField
    {
        [XmlAttribute] public string Name { get; set; }
        [XmlAttribute] public string DisplayName { get; set; }
        [XmlAttribute] public string Expression { get; set; }
        [XmlAttribute] public string DataType { get; set; }
        [XmlAttribute] public string EditType { get; set; }
        [XmlAttribute("Type")] public string FieldType { get; set; }
        [XmlAttribute] public string Description { get; set; }

        [XmlIgnore] public string Value { get; set; }
        [XmlIgnore] public bool isCalculated => !string.IsNullOrEmpty(Expression);

        public JRField() { }

        public JRField(string name, string displayName, string value = null)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.Value = value;
        }

        public static JRField[] Parse(string xml)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(JRFieldList));
                var xmlReader = new XmlTextReader(xml, XmlNodeType.Document, null);
                var fields = (JRFieldList)xmlSerializer.Deserialize(xmlReader);
                return fields?.Fields;
            }
            catch (Exception ex) { 
                Console.WriteLine(ex); }
            return null;
        }

        public override string ToString()
        {
            return $"{Name}{(isCalculated?" [Calculated]: " : ": ")} Type={FieldType}, Data={DataType}, Edit={EditType}, Expr={Expression}";
        }
    }
}
