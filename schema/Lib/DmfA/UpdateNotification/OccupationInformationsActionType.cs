//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationInformationsAction", Namespace = "", IsNullable = false)]
    public class OccupationInformationsActionType
    {
        public HorecaExtra HorecaExtra;

        [XmlIgnore()]
        public bool HorecaExtraSpecified;

        public PostedWorker PostedWorker;

        [XmlIgnore()]
        public bool PostedWorkerSpecified;

        [XmlElement(DataType = "integer")]
        public string? NOSSLPASocialMaribel;

        [XmlElement(DataType = "integer")]
        public string? HourRemun;

        [XmlElement(DataType = "integer")]
        public string? HourRemunInThousandthOfEuro;

        [XmlElement(DataType = "date")]
        public DateTime SixMonthsIllnessDate;

        [XmlIgnore()]
        public bool SixMonthsIllnessDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? FirstWeekGuaranteedSalaryNbrDays;

        [XmlElement(DataType = "integer")]
        public string? IllnessGrossRemunAmount;

        public PSDDclExemption PSDDclExemption;

        [XmlIgnore()]
        public bool PSDDclExemptionSpecified;

        public SupplPensionContributionExemption SupplPensionContributionExemption;

        [XmlIgnore()]
        public bool SupplPensionContributionExemptionSpecified;

        public ObligationControlInformation ObligationControlInformation;

        [XmlIgnoreAttribute()]
        public bool ObligationControlInformationSpecified;

        [XmlElement(DataType = "date")]
        public DateTime DefinitiveNominationDate;

        [XmlIgnore()]
        public bool DefinitiveNominationDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime NewMaribelEmploymentDate;

        [XmlIgnoreAttribute()]
        public bool NewMaribelEmploymentDateSpecified;

        public PSPContribCalcBasisDerogation PSPContribCalcBasisDerogation;

        [XmlIgnore()]
        public bool PSPContribCalcBasisDerogationSpecified;

        [XmlElement(DataType = "integer")]
        public string? CareerMeasure;

        public string? ServiceExemptionNotion;

        [XmlElement(DataType = "integer")]
        public string? HolidayDaysNumber;

        [XmlElement(DataType = "integer")]
        public string? SectorDetail;

        [XmlElement(DataType = "integer")]
        public string? MobilityBudget;

        [XmlElement(DataType = "integer")]
        public string? FlemishTrainingHolidayHoursNbr;

        public string? RegionalAidMeasure;

        public Action Action;

    }
}