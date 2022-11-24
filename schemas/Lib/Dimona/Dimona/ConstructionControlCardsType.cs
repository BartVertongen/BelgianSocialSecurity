//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ConstructionControlCards", Namespace = "", IsNullable = false)]
    public class ConstructionControlCardsType
    {
        [XmlElement(DataType = "integer")]
        public string? FirstMonthC32ANbr;

        [XmlElement(DataType = "integer")]
        public string? NextMonthC32ANbr;
    }
}
