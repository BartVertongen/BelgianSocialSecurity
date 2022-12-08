// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("AccountingEntry", Namespace = "", IsNullable = false)]
    public class AccountingEntryType
    {
        public string? AccountingAmount;

        public AccountingRef AccountingRef;

        public CalculationRequestCO2 CalculationRequestCO2;

        [XmlIgnore()]
        public bool CalculationRequestCO2Specified;

        [XmlElement(DataType = "integer")]
        public string? EmployerClass;
    }
}