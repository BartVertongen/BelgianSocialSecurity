//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;

namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Path", Namespace = "", IsNullable = false)]
    public class PathType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? Trusteeship;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? NaturalPersonSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? INSS;

        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "integer")]
        public string? OccupationSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? ReorganisationMeasure;

        [XmlElement(DataType = "integer")]
        public string? ServiceSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? ServiceCode;

        [XmlElement(DataType = "integer")]
        public string? RemunSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? RemunCode;

        [XmlElement(DataType = "integer")]
        public string? BonusPaymentFrequency;

        [XmlElement(DataType = "integer")]
        public string? PercentagePaid;

        [XmlElement(DataType = "integer")]
        public string? DeductionCode;

        [XmlElement(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? EmployerNotion;

        public string? JointCommissionNbr;

        [XmlElement(DataType = "integer")]
        public string? ActivityCode;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityAgreementNotion;

        public string? HalfTimeCareerInterruptionNotion;

        public string? ServiceExemptionNotion;

        public string? ReplacementAccordanceWCCNotion;

        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionType;

        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        [XmlIgnore()]
        public bool ComplIndemnityAmountAdjustNotionSpecified;

        [XmlElement(DataType = "integer")]
        public string? ContributionSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementCode;

        [XmlElement(DataType = "integer")]
        public string? IndemnityNature;

        public string? IncapacityDegree;

        public string? NaturalPersonUserReference;

        public string? WorkerRecordUserReference;

        public string? OccupationUserReference;

        [XmlElement(DataType = "integer")]
        public string? CompanyVehicleSequenceNbr;

        public string? NPCalculatedAmount;

        public string? CUNPCalculatedAmount;

        public string? WorksContractActorId;

        [XmlElement(DataType = "date")]
        public System.DateTime OccupationPSDStartDate;

        [XmlIgnore()]
        public bool OccupationPSDStartDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? EmployerSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? CareerElementSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? PublicSectorInstitutionType;

        [XmlElement(DataType = "integer")]
        public string? PublicSectorPersonnelCategory;

        [XmlElement(DataType = "integer")]
        public string? AssignmentType;

        [XmlElement(DataType = "integer")]
        public string? FunctionNature;

        [XmlElement(DataType = "integer")]
        public string? ScaleSalarySequenceNbr;

        [XmlElement(DataType = "date")]
        public DateTime ScaleSalaryStartDate;

        [XmlIgnore()]
        public bool ScaleSalaryStartDateSpecified;

        [XmlElement(DataType = "gYearMonth")]
        public string? PecuniarySeniorityStartDate;

        [XmlElement(DataType = "integer")]
        public string? SalaryScaleReference;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalarySequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryReference;

        [XmlElement(DataType = "date")]
        public DateTime AdditionalScaleSalaryStartDate;

        [XmlIgnore()]
        public bool AdditionalScaleSalaryStartDateSpecified;

        public NonSituableAbsenceCode NonSituableAbsenceCode;

        [XmlIgnore()]
        public bool NonSituableAbsenceCodeSpecified;

        [XmlElement(DataType = "integer")]
        public string? CalendarYear;

        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnore()]
        public bool StartingDateSpecified;
    }
}