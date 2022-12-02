
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ActivationInformation", Namespace = "", IsNullable = false)]
    public class ActivationInformationType
    {
        [XmlElement(DataType = "date")]
        public DateTime ServiceExemptionStartDate;

        [XmlElement(DataType = "date")]
        public DateTime TrainingSituationStartDate;

        [XmlElement(DataType = "integer")]
        public string? TrainingSituation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class WorkerDeductionType
    {
        [XmlElement(DataType = "integer")]
        public string? DeductionCode;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? DeductionCalculationBasis;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? DeductionAmount;

        [XmlElement(DataType = "date")]
        public System.DateTime DeductionRightStartingDate;

        [XmlIgnoreAttribute()]
        public bool DeductionRightStartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? ManagementCostNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? ReplacedINSS;

        [XmlElement(DataType = "integer")]
        public string? ApplicantINSS;

        [XmlElement(DataType = "integer")]
        public string? CertificateOrigin;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class OccupationDeductionType
    {
        [XmlElement(DataType = "integer")]
        public string? DeductionCode;

        [XmlElement(DataType = "integer")]
        public string? DeductionCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? DeductionAmount;

        [XmlElement(DataType = "date")]
        public System.DateTime DeductionRightStartingDate;

        [XmlIgnore()]
        public bool DeductionRightStartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? ManagementCostNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? ReplacedINSS;

        [XmlElement(DataType = "integer")]
        public string? ApplicantINSS;

        [XmlElement(DataType = "integer")]
        public string? CertificateOrigin;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ScaleSalaryType
    {
        [XmlElement(DataType = "date")]
        public DateTime ScaleSalaryStartDat;

        [XmlElement(DataType = "date")]
        public DateTime ScaleSalaryEndDate;

        [XmlIgnoreAttribute()]
        public bool ScaleSalaryEndDateSpecified;

        [XmlElement(DataType = "gYearMonth")]
        public string? PecuniarySeniorityStartDate;

        [XmlElement(DataType = "integer")]
        public string? SalaryScaleReference;

        [XmlElement(DataType = "integer")]
        public string? ScaleSalaryAmount;

        [XmlElement(DataType = "integer")]
        public string? WeekHoursNbr;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? ScaleSalaryWeekHoursNbr;

        public ReducedScaleSalaryNotion ReducedScaleSalaryNotion;

        [XmlIgnoreAttribute()]
        public bool ReducedScaleSalaryNotionSpecified;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReducedScaleSalaryNotion
    {
        [XmlEnum("1")] Item1,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class OccupationPublicServiceDataType
    {
        [XmlElement(DataType = "date")]
        public DateTime OccupationPSDStartDate;

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime OccupationPSDEndDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccupationPSDEndDateSpecified;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? PublicSectorInstitutionType;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? PublicSectorPersonnelCategory;

        /// <remarks/>
        public string? GradeOrFunction;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? OfficialLanguage;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? AssignmentType;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? FunctionNature;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? StatutoryRelationEndReason;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class OccupationType
    {
        [XmlElement(DataType = "integer")]
        public string? OccupationSequenceNbr;

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public System.DateTime OccupationStartingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool OccupationStartingDateSpecified;

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public System.DateTime OccupationEndingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool OccupationEndingDateSpecified;

        /// <remarks/>
        public string? JointCommissionNbr;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? WorkingDaysSystem;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? ContractType;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? RefMeanWorkingHours;

        /// <remarks/>
        public string? WorkerStatus;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? MeanWorkingHours;

        /// <remarks/>
        public ReorganisationMeasure ReorganisationMeasure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReorganisationMeasureSpecified;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? EmploymentPromotion;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? Retired;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? Apprenticeship;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? RemunMethod;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? PositionCode;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? FlyingStaffClass;

        /// <remarks/>
        public TenthOrTwelfth TenthOrTwelfth;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TenthOrTwelfthSpecified;

        /// <remarks/>
        public string? OccupationUserReference;

        /// <remarks/>
        public DaysJustification DaysJustification;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DaysJustificationSpecified;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? ActivityCode;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? ShipId;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? StaffCode;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? SubsidizedMeanWorkingHours;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReorganisationMeasure
    {
        [XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        [System.Xml.Serialization.XmlEnumAttribute("501")]
        Item501,

        [XmlEnumAttribute("502")]
        Item502,

        [XmlEnumAttribute("503")]
        Item503,

        [XmlEnumAttribute("504")]
        Item504,

        [XmlEnumAttribute("505")]
        Item505,

        [XmlEnumAttribute("506")]
        Item506,

        [XmlEnumAttribute("507")]
        Item507,

        [System.Xml.Serialization.XmlEnumAttribute("508")]
        Item508,

        [System.Xml.Serialization.XmlEnumAttribute("509")]
        Item509,

        [System.Xml.Serialization.XmlEnumAttribute("510")]
        Item510,

        [System.Xml.Serialization.XmlEnumAttribute("511")]
        Item511,

        [System.Xml.Serialization.XmlEnumAttribute("512")]
        Item512,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("513")]
        Item513,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("514")]
        Item514,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("515")]
        Item515,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("516")]
        Item516,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("517")]
        Item517,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("531")]
        Item531,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("541")]
        Item541,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("542")]
        Item542,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("543")]
        Item543,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("544")]
        Item544,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("545")]
        Item545,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("546")]
        Item546,

        /// <remarks/>
        [XmlEnumAttribute("599")]
        Item599,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum TenthOrTwelfth
    {
        [XmlEnumAttribute("10")]
        Item10,

        [XmlEnumAttribute("12")]
        Item12,

        [XmlEnumAttribute("20")]
        Item20,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum DaysJustification
    {
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        [XmlEnumAttribute("7")]
        Item7,

        [XmlEnumAttribute("8")]
        Item8,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class WorkerRecordType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "date")]
        public System.DateTime NOSSQuarterStartingDate;

        [XmlElement(DataType = "date")]
        public DateTime NOSSQuarterEndingDate;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? Border;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? ActivityWithRisk;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        /// <remarks/>
        public string? WorkerRecordUserReference;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class NaturalPersonType
    {
        [XmlElement(DataType = "integer")]
        public string? NaturalPersonSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? INSS;

        [XmlElement(DataType = "integer")]
        public string? SIS;

        public string? WorkerName;

        public string? WorkerFirstName;

        public string? WorkerInitial;

        public string? WorkerBirthdate;

        public string? WorkerBirthplace;

        [XmlElement(DataType = "integer")]
        public string? WorkerBirthplaceCountry;

        [XmlElement(DataType = "integer")]
        public string? WorkerSex;

        public string? WorkerStreet;

        public string? WorkerHouseNbr;

        public string? WorkerPostBox;

        public string? WorkerZIPCode;

        public string? WorkerCity;

        [XmlElement(DataType = "integer")]
        public string? WorkerCountry;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? Nationality;

        /// <remarks/>
        public string? NaturalPersonUserReference;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class EmployerDeclarationType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        [XmlElement(DataType = "integer")]
        public string? NOSSRegistrationNbr;

        [XmlElement(DataType = "integer")]
        public string? Trusteeship;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "integer")]
        public string? NetOwedAmount;

        [XmlElement(DataType = "integer")]
        public string? System5;

        [XmlElement(DataType = "date")]
        public DateTime HolidayStartingDate;

        [XmlIgnore()]
        public bool HolidayStartingDateSpecified;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class FormType
    {
        public Identification Identification;

        [XmlElement(DataType = "date")]
        public System.DateTime FormCreationDate;

        [XmlElement(DataType = "time")]
        public System.DateTime FormCreationHour;

        public AttestationStatus AttestationStatus;

        public TypeForm TypeForm;
    }


    [System.SerializableAttribute()]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum Identification { DMFA, }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum AttestationStatus { [XmlEnum("0")] Item0, }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum TypeForm { SU, }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class ComplementaryIndemnityType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerNotion;

        public string? JointCommissionNbr;

        [XmlElement(DataType = "integer")]
        public string? ActivityCode;

        public DebtorType DebtorType;

        [XmlIgnoreAttribute()]
        public bool DebtorTypeSpecified;

        [XmlElement(DataType = "date")]
        public System.DateTime FirstComplIndemnityDate;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityAgreementNotion;

        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion;

        public ServiceExemptionNotion ServiceExemptionNotion;

        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion;

        [XmlElement(DataType = "integer")]
        public string? SubstituteINSS;

        public ResumptionOfWorkMeasure ResumptionOfWorkMeasure;

        [XmlIgnoreAttribute()]
        public bool ResumptionOfWorkMeasureSpecified;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityNbrOfParts;

        [XmlElement(DataType = "date")]
        public DateTime NoticeDate;

        [XmlIgnoreAttribute()]
        public bool NoticeDateSpecified;

        public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion;

        [XmlIgnoreAttribute()]
        public bool AilingOrReorgCompanyNotionSpecified;

        [XmlElement(DataType = "date")]
        public DateTime AcknowledgementStartDate;

        [XmlIgnore()]
        public bool AcknowledgementStartDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime AcknowledgementEndDate;

        [XmlIgnore()]
        public bool AcknowledgementEndDateSpecified;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum DebtorType
    {
        [XmlEnumAttribute("0")]
        Item0,

        [XmlEnumAttribute("1")]
        Item1,

        [XmlEnumAttribute("2")]
        Item2,

        [XmlEnumAttribute("3")]
        Item3,

        [XmlEnumAttribute("4")]
        Item4,

        [XmlEnumAttribute("5")]
        Item5,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum HalfTimeCareerInterruptionNotion
    {
        [XmlEnumAttribute("0")]
        Item0,

        [XmlEnumAttribute("1")]
        Item1,

        [XmlEnumAttribute("9")]
        Item9,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ServiceExemptionNotion
    {
        [XmlEnumAttribute("0")]
        Item0,

        [XmlEnumAttribute("1")]
        Item1,

        [XmlEnumAttribute("2")]
        Item2,

        [XmlEnumAttribute("3")]
        Item3,

        [XmlEnumAttribute("4")]
        Item4,

        [XmlEnumAttribute("5")]
        Item5,

        [XmlEnumAttribute("6")]
        Item6,

        [XmlEnumAttribute("9")]
        Item9,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReplacementAccordanceWCCNotion
    {
        [XmlEnumAttribute("0")]
        Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ResumptionOfWorkMeasure
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [XmlEnumAttribute("9")]
        Item9,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum AilingOrReorgCompanyNotion
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRootAttribute("AdditionalScaleSalary", Namespace = "", IsNullable = false)]
    public partial class AdditionalScaleSalaryType
    {
        [XmlElement(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryStartDate;

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryEndDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalScaleSalaryEndDateSpecified;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryReference;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryBasisAmount;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryPercentage;

        [XmlElement(DataType = "integer")]
        public string? NbrHoursOrServices;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryAmount;
    }


    [SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum CapitalizationNotion
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum CareerMeasure
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CompanyVehicle", Namespace = "", IsNullable = false)]
    public partial class CompanyVehicleType
    {
        [XmlElement(DataType = "integer")]
        public string? CompanyVehicleSequenceNbr;

        public string? LicensePlate;

        [XmlElement(DataType = "integer")]
        public string? EcoVehicle;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class ComplementaryIndemnity : ComplementaryIndemnityType
    {
        [XmlElement("ComplIndemnityContribution")]
        public ComplIndemnityContributionType[]? ComplIndemnityContribution;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ComplIndemnityContribution", Namespace = "", IsNullable = false)]
    public class ComplIndemnityContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionType;

        [XmlElement(DataType = "integer")]
        public string? IndemnityContributionPeriodCode;

        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        [XmlElement(DataType = "integer")]
        public string? ContributionSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityAmount;

        public CapitalizationNotion CapitalizationNotion;

        [XmlIgnore()]
        public bool CapitalizationNotionSpecified;

        [XmlElement(DataType = "integer")]
        public string? WelfareBenefitTheoreticalAmount;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? NbrMonthsDecimals;

        [XmlElement(DataType = "integer")]
        public string? IncompleteMonthNbrDays;

        [XmlElement(DataType = "integer")]
        public string? IncompleteMonthReason;

        [XmlElement(DataType = "integer")]
        public string? FloorApplicationNotion;

        [XmlElement(DataType = "integer")]
        public string? ContributionAmount;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ComplIndemnityAmountAdjustNotion
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,

        [XmlEnumAttribute("4")] Item4,

        [XmlEnumAttribute("9")] Item9,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ContributionUnrelatedToNP", Namespace = "", IsNullable = false)]
    public class ContributionUnrelatedToNPType
    {
        [XmlElement(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedAmount;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRootAttribute("DeductionDetail", Namespace = "", IsNullable = false)]
    public class DeductionDetailType
    {
        [XmlElement(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? DeductionDetailAmount;

        public string? WorkingRegulationsRegistryNbr;

        [XmlElement(DataType = "date")]
        public System.DateTime WorkingRegulationsStartingDate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WorkingRegulationsStartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeBeforeReduction;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeAfterReduction;
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRootAttribute("DismissedStatutoryWorkerContribution", Namespace = "", IsNullable = false)]
    public class DismissedStatutoryWorkerContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? GrossRefRemunAmount;

        [XmlElement(DataType = "integer")]
        public string? GrossRefRemunContributionAmount;

        [XmlElement(DataType = "integer")]
        public string? RefNbrDays;

        [XmlElement(DataType = "date")]
        public System.DateTime SubjectionStartingDate;

        [XmlElement(DataType = "date")]
        public System.DateTime SubjectionEndingDate;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class DmfAOriginal
    {
        [XmlElement("Form")]
        public Form[]? Form;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Form : FormType
    {
        public ReferenceType? Reference;

        public EmployerDeclaration? EmployerDeclaration;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRootAttribute("Reference", Namespace = "", IsNullable = false)]
    public partial class ReferenceType
    {
        [XmlElement("ReferenceType")]
        public ReferenceType1 ReferenceType1;

        public ReferenceOrigin ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class EmployerDeclaration : EmployerDeclarationType
    {
        [XmlElement("CompanyVehicle", typeof(CompanyVehicleType))]
        [XmlElement("ContributionUnrelatedToNP", typeof(ContributionUnrelatedToNPType))]
        [XmlElement("NaturalPerson", typeof(NaturalPerson))]
        public object[]? Items;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class NaturalPerson : NaturalPersonType
    {
        [XmlElement("WorkerRecord")]
        public WorkerRecord[]? WorkerRecord;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerRecord : WorkerRecordType
    {
        [XmlElement("ActivationInformation", typeof(ActivationInformationType))]
        [XmlElement("ComplementaryIndemnity", typeof(ComplementaryIndemnity))]
        [XmlElement("DismissedStatutoryWorkerContribution", typeof(DismissedStatutoryWorkerContributionType))]
        [XmlElement("EarlyRetirementContribution", typeof(EarlyRetirementContributionType))]
        [XmlElement("IndemnityWAPM", typeof(IndemnityWAPMType))]
        [XmlElement("Occupation", typeof(Occupation))]
        [XmlElement("StudentContribution", typeof(StudentContributionType))]
        [XmlElement("WorkerContribution", typeof(WorkerContributionType))]
        [XmlElement("WorkerDeduction", typeof(WorkerDeduction))]
        public object[]? Items;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EarlyRetirementContribution", Namespace = "", IsNullable = false)]
    public partial class EarlyRetirementContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementCode;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementNbrMonths;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementContributionAmount;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("IndemnityWAPM", Namespace = "", IsNullable = false)]
    public class IndemnityWAPMType
    {
        [XmlElement(DataType = "integer")]
        public string? IndemnityNature;

        public string? IncapacityDegree;

        [XmlElement(DataType = "integer")]
        public string? IndemnityAmount;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Occupation : OccupationType
    {
        public OccupationInformationsType? OccupationInformations;

        /// <remarks/>
        public SecondPillarInformationType? SecondPillarInformation;

        /// <remarks/>
        [XmlElement("Service")]
        public ServiceType[]? Service;

        /// <remarks/>
        [XmlElement("Remun")]
        public RemunType[]? Remun;

        /// <remarks/>
        [XmlElement("OccupationPublicServiceData")]
        public OccupationPublicServiceData[]? OccupationPublicServiceData;

        /// <remarks/>
        [XmlElement("ReorgMeasureInformation")]
        public ReorgMeasureInformationType[]? ReorgMeasureInformation;

        /// <remarks/>
        [XmlElement("OccupationDeduction")]
        public OccupationDeduction[]? OccupationDeduction;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRootAttribute("OccupationInformations", Namespace = "", IsNullable = false)]
    public partial class OccupationInformationsType
    {
        public HorecaExtra HorecaExtra;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HorecaExtraSpecified;

        public PostedWorker PostedWorker;

        [XmlIgnoreAttribute()]
        public bool PostedWorkerSpecified;

        public NOSSLPASocialMaribel NOSSLPASocialMaribel;

        [XmlIgnoreAttribute()]
        public bool NOSSLPASocialMaribelSpecified;

        [XmlElement(DataType = "integer")]
        public string? HourRemun;

        [XmlElement(DataType = "integer")]
        public string? HourRemunInThousandthOfEuro;

        [XmlElement(DataType = "date")]
        public System.DateTime SixMonthsIllnessDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SixMonthsIllnessDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? FirstWeekGuaranteedSalaryNbrDays;

        [XmlElement(DataType = "integer")]
        public string? IllnessGrossRemunAmount;

        public PSDDclExemption PSDDclExemption;

        [XmlIgnoreAttribute()]
        public bool PSDDclExemptionSpecified;

        public SupplPensionContributionExemption SupplPensionContributionExemption;

        [XmlIgnoreAttribute()]
        public bool SupplPensionContributionExemptionSpecified;

        public ObligationControlInformation ObligationControlInformation;

        [XmlIgnoreAttribute()]
        public bool ObligationControlInformationSpecified;

        [XmlElement(DataType = "date")]
        public System.DateTime DefinitiveNominationDate;

        [XmlIgnoreAttribute()]
        public bool DefinitiveNominationDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime NewMaribelEmploymentDate;

        [XmlIgnoreAttribute()]
        public bool NewMaribelEmploymentDateSpecified;

        public PSPContribCalcBasisDerogation PSPContribCalcBasisDerogation;

        [XmlIgnoreAttribute()]
        public bool PSPContribCalcBasisDerogationSpecified;

        public CareerMeasure CareerMeasure;

        [XmlIgnoreAttribute()]
        public bool CareerMeasureSpecified;

        public ServiceExemptionNotion ServiceExemptionNotion;

        [XmlIgnoreAttribute()]
        public bool ServiceExemptionNotionSpecified;

        [XmlElement(DataType = "integer")]
        public string? HolidayDaysNumber;

        [XmlElement(DataType = "integer")]
        public string? SectorDetail;

        [XmlElement(DataType = "integer")]
        public string? MobilityBudget;

        [XmlElement(DataType = "integer")]
        public string? FlemishTrainingHolidayHoursNbr;

        public RegionalAidMeasure RegionalAidMeasure;

        [XmlIgnore()]
        public bool RegionalAidMeasureSpecified;
    }


    [SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum HorecaExtra  { E, }


    [SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PostedWorker
    {
        [XmlEnumAttribute("1")] Item1,

        [XmlEnumAttribute("2")] Item2,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum NOSSLPASocialMaribel
    {
        [XmlEnumAttribute("1")]
        Item1,

        [XmlEnumAttribute("2")]
        Item2,

        [XmlEnumAttribute("3")]
        Item3,

        [XmlEnumAttribute("4")]
        Item4,

        [XmlEnumAttribute("5")]
        Item5,

        [XmlEnumAttribute("6")]
        Item6,

        [XmlEnumAttribute("7")]
        Item7,

        [XmlEnumAttribute("8")]
        Item8,

        [XmlEnumAttribute("9")]
        Item9,

        [XmlEnumAttribute("10")]
        Item10,

        [XmlEnumAttribute("11")]
        Item11,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PSDDclExemption
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum SupplPensionContributionExemption
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ObligationControlInformation { FWT, }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PSPContribCalcBasisDerogation
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum RegionalAidMeasure { B, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRootAttribute("SecondPillarInformation", Namespace = "", IsNullable = false)]
    public class SecondPillarInformationType
    {
        public string? ReferenceYearMonth;

        [XmlElement(DataType = "integer")]
        public string? MonthlyScaleSalary;

        [XmlElement(DataType = "integer")]
        public string? MonthlyAdditionalScaleSalary;

        [XmlElement(DataType = "integer")]
        public string? MonthlyHomeIndemnity;

        [XmlElement(DataType = "integer")]
        public string? OfficialLanguage;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRootAttribute("Service", Namespace = "", IsNullable = false)]
    public class ServiceType
    {
        [XmlElement(DataType = "integer")]
        public string? ServiceSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? ServiceCode;

        [XmlElement(DataType = "integer")]
        public string? ServiceNbrDays;

        [XmlElement(DataType = "integer")]
        public string? ServiceNbrHours;

        [XmlElement(DataType = "integer")]
        public string? FlightNbrMinutes;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRootAttribute("Remun", Namespace = "", IsNullable = false)]
    public class RemunType
    {
        [XmlElement(DataType = "integer")]
        public string? RemunSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? RemunCode;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? BonusPaymentFrequency;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? PercentagePaid;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? RemunAmount;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class OccupationPublicServiceData : OccupationPublicServiceDataType
    {
        [XmlElement("ScaleSalary")]
        public ScaleSalary[]? ScaleSalary;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ScaleSalary : ScaleSalaryType
    {
        [XmlElement("AdditionalScaleSalary")]
        public AdditionalScaleSalaryType[]? AdditionalScaleSalary;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ReorgMeasureInformation", Namespace = "", IsNullable = false)]
    public class ReorgMeasureInformationType
    {
        public ReorganisationMeasure ReorganisationMeasure;

        [XmlElement(DataType = "integer")]
        public string? ReorganisationMeasurePercentage;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationDeduction : OccupationDeductionType
    {
        public OccupationDeductionDetailType? OccupationDeductionDetail;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationDeductionDetail", Namespace = "", IsNullable = false)]
    public class OccupationDeductionDetailType
    {
        [XmlElement(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsStartingDate;

        [XmlIgnore()]
        public bool WorkingRegulationsStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsEndingDate;

        [XmlIgnore()]
        public bool WorkingRegulationsEndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeBeforeReduction;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeAfterReduction;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("StudentContribution", Namespace = "", IsNullable = false)]
    public class StudentContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? StudentRemunAmount;


        [XmlElement(DataType = "integer")]
        public string? StudentContributionAmount;

        [XmlElement("StudentHoursNbr", typeof(string), DataType = "integer")]
        [XmlElement("StudentNbrDays", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;
    }


    [SerializableAttribute()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType { StudentHoursNbr, StudentNbrDays, }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("WorkerContribution", Namespace = "", IsNullable = false)]
    public class WorkerContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionType;

        [XmlElement(DataType = "integer")]
        public string? ContributionCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? ContributionAmount;

        [XmlElement(DataType = "date")]
        public DateTime FirstHiringDate;

        [XmlIgnore()]
        public bool FirstHiringDateSpecified;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerDeduction : WorkerDeductionType
    {
        [XmlElement("DeductionDetail")]
        public DeductionDetailType[]? DeductionDetail;
    }
}