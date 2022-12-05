// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ComplIndemnityContribution", Namespace = "", IsNullable = false)]
    public class ComplIndemnityContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionType;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? IndemnityContributionPeriodCode;

        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? ContributionSequenceNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string? ComplIndemnityAmount;

        public CapitalizationNotion CapitalizationNotion;

        [XmlIgnoreAttribute()]
        public bool CapitalizationNotionSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string? WelfareBenefitTheoreticalAmount;

        [XmlElementAttribute(DataType = "integer")]
        public string? ComplIndemnityNbrMonths;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? NbrMonthsDecimals;

        [XmlElementAttribute(DataType = "integer")]
        public string? IncompleteMonthNbrDays;

        [XmlElementAttribute(DataType = "integer")]
        public string? IncompleteMonthReason;

        [XmlElementAttribute(DataType = "integer")]
        public string? FloorApplicationNotion;

        [XmlElementAttribute(DataType = "integer")]
        public string? ContributionAmount;
    }
}