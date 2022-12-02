// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.IDFLUX223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ValidSituation", Namespace = "", IsNullable = false)]
    public class ValidSituationType
    {
        [XmlElement("INSS", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("WorkerBirthdate", typeof(string))]
        [XmlElement("WorkerFirstName", typeof(string))]
        [XmlElement("WorkerName", typeof(string))]
        [XmlElement("WorkerSex", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[]? ItemsElementName;
    }
}
