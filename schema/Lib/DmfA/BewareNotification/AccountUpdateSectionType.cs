// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class AccountUpdateSectionType
    {
        [XmlElement(DataType = "integer")]
        public string? AccountingQuarter;

        [XmlElement(DataType = "integer")]
        public string? CorrectionClassification;
    }
}
