// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class AccountUpdateReportType
    {
        [XmlElement(DataType = "date")]
        public DateTime AccountingDate;

        public string? ContributionTotalAmount;

        public string? SanctionsTotalAmount;

        public string? AnnualHolidaysContribTotalAmount;

        public string? AccountUpdateReportTotalAmount;
    }
}
