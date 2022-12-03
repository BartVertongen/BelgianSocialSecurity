
using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReducedScaleSalaryNotion
    {
        [XmlEnum("1")] Item1,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class OccupationPublicServiceDataType
    {
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationPSDStartDate;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationPSDEndDate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccupationPSDEndDateSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? PublicSectorInstitutionType;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? PublicSectorPersonnelCategory;

        public string? GradeOrFunction;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? OfficialLanguage;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? AssignmentType;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? FunctionNature;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? StatutoryRelationEndReason;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class OccupationUpdateType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? OccupationSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationStartingDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccupationStartingDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationEndingDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccupationEndingDateSpecified;

        public string JointCommissionNbr;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkingDaysSystem;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContractType;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string RefMeanWorkingHours;

        public string WorkerStatus;

        [XmlElementAttribute(DataType = "integer")]
        public string MeanWorkingHours;

        public ReorganisationMeasure ReorganisationMeasure;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReorganisationMeasureSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmploymentPromotion;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Retired;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Apprenticeship;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string RemunMethod;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string PositionCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string FlyingStaffClass;

        /// <remarks/>
        public TenthOrTwelfth TenthOrTwelfth;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TenthOrTwelfthSpecified;

        /// <remarks/>
        public string OccupationUserReference;

        /// <remarks/>
        public DaysJustification DaysJustification;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DaysJustificationSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ActivityCode;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string OccupationVersionNbr;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string LocalUnitID;

        [XmlElementAttribute(DataType = "integer")]
        public string ShipId;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string StaffCode;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SubsidizedMeanWorkingHours;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReorganisationMeasure
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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("501")]
        Item501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("502")]
        Item502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("503")]
        Item503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("504")]
        Item504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("505")]
        Item505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("506")]
        Item506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("507")]
        Item507,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("508")]
        Item508,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("509")]
        Item509,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("510")]
        Item510,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("511")]
        Item511,

        /// <remarks/>
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

        [System.Xml.Serialization.XmlEnumAttribute("599")]
        Item599,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum DaysJustification
    {
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class WorkerRecordUpdateActionType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmployerClass;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkerCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime NOSSQuarterStartingDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NOSSQuarterStartingDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime NOSSQuarterEndingDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NOSSQuarterEndingDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Border;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ActivityWithRisk;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string LocalUnitID;

        /// <remarks/>
        public string WorkerRecordUserReference;

        /// <remarks/>
        public UpdateAction UpdateAction;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum UpdateAction
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [XmlEnumAttribute("3")]
        Item3,

        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class WorkerRecordUpdateType
    { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class NaturalPersonUpdateType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string NaturalPersonSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string INSS;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SIS;

        /// <remarks/>
        public string WorkerName;

        /// <remarks/>
        public string WorkerFirstName;

        /// <remarks/>
        public string WorkerInitial;

        /// <remarks/>
        public string WorkerBirthdate;

        /// <remarks/>
        public string WorkerBirthplace;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkerBirthplaceCountry;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkerSex;

        /// <remarks/>
        public string WorkerStreet;

        /// <remarks/>
        public string WorkerHouseNbr;

        /// <remarks/>
        public string WorkerPostBox;

        /// <remarks/>
        public string WorkerZIPCode;

        /// <remarks/>
        public string WorkerCity;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkerCountry;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Nationality;

        /// <remarks/>
        public string NaturalPersonUserReference;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NaturalPersonPID;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeclNaturalPersonPID;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeclNaturalPersonVersionNbr;

        public string Justification;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class EmployerDeclarationUpdateType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Quarter;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NOSSRegistrationNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Trusteeship;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CompanyID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string System5;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime HolidayStartingDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HolidayStartingDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmployerDeclarationPID;

        /// <remarks/>
        public string Justification;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class FormType
    {
        public Identification Identification;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime FormCreationDate;

        [XmlElementAttribute(DataType = "time")]
        public System.DateTime FormCreationHour;

        public AttestationStatus AttestationStatus;

        public TypeForm TypeForm;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum Identification { DMFAUPD, }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    { [System.Xml.Serialization.XmlEnumAttribute("1")] Item1, }


    //[System.SerializableAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    //public enum TypeForm { SU, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class ContributionUnrelatedToNPUpdateType
    {
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class ComplementaryIndemnityType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmployerNotion;

        public string JointCommissionNbr;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ActivityCode;

        public DebtorType DebtorType;

        [XmlIgnoreAttribute()]
        public bool DebtorTypeSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime FirstComplIndemnityDate;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityAgreementNotion;

        /// <remarks/>
        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion;

        /// <remarks/>
        public ServiceExemptionNotion ServiceExemptionNotion;

        /// <remarks/>
        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SubstituteINSS;

        /// <remarks/>
        public ResumptionOfWorkMeasure ResumptionOfWorkMeasure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResumptionOfWorkMeasureSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityNbrOfParts;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime NoticeDate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoticeDateSpecified;

        public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AilingOrReorgCompanyNotionSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AcknowledgementStartDate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcknowledgementStartDateSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AcknowledgementEndDate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcknowledgementEndDateSpecified;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum DebtorType
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")] Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")] Item2,

        [System.Xml.Serialization.XmlEnumAttribute("3")] Item3,

        [System.Xml.Serialization.XmlEnumAttribute("4")] Item4,

        [System.Xml.Serialization.XmlEnumAttribute("5")] Item5,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum HalfTimeCareerInterruptionNotion
    {
        [XmlEnumAttribute("0")] Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

        [System.Xml.Serialization.XmlEnumAttribute("9")] Item9,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ServiceExemptionNotion
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")] Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")] Item2,

        [System.Xml.Serialization.XmlEnumAttribute("3")] Item3,

        [System.Xml.Serialization.XmlEnumAttribute("4")] Item4,

        [System.Xml.Serialization.XmlEnumAttribute("5")] Item5,

        [System.Xml.Serialization.XmlEnumAttribute("6")] Item6,

        [System.Xml.Serialization.XmlEnumAttribute("9")] Item9,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReplacementAccordanceWCCNotion
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")] Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

        [System.Xml.Serialization.XmlEnumAttribute("9")] Item9,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ResumptionOfWorkMeasure
    {

        [System.Xml.Serialization.XmlEnumAttribute("0")] Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

        [System.Xml.Serialization.XmlEnumAttribute("9")] Item9,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum AilingOrReorgCompanyNotion
    {
        [XmlEnumAttribute("0")]
        Item0,

        [XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        [XmlEnumAttribute("3")]
        Item3,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("AdditionalScaleSalary", Namespace = "", IsNullable = false)]
    public class AdditionalScaleSalaryType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryStartDate;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryEndDate;

        [XmlIgnoreAttribute()]
        public bool AdditionalScaleSalaryEndDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string AdditionalScaleSalaryReference;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AdditionalScaleSalaryBasisAmount;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AdditionalScaleSalaryPercentage;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NbrHoursOrServices;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AdditionalScaleSalaryAmount;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum CapitalizationNotion
    {
        [XmlEnumAttribute("0")] Item0,

        [XmlEnumAttribute("1")] Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")] Item2,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum CareerMeasure
    {
        [XmlEnumAttribute("1")] Item1,

        [XmlEnumAttribute("2")] Item2,
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CompanyVehicleUpdateAction", Namespace = "", IsNullable = false)]
    public class CompanyVehicleUpdateActionType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? CompanyVehicleSequenceNbr;

        public string? LicensePlate;

        [XmlElement(DataType = "integer")]
        public string? EcoVehicle;

        [XmlElementAttribute(DataType = "integer")]
        public string? CompanyVehicleVersionNbr;

        public UpdateAction UpdateAction;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class ComplementaryIndemnity : ComplementaryIndemnityType
    {
        [XmlElementAttribute("ComplIndemnityContribution")]
        public ComplIndemnityContributionType[] ComplIndemnityContribution;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ComplIndemnityContribution", Namespace = "", IsNullable = false)]
    public class ComplIndemnityContributionType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionWorkerCode;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionType;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IndemnityContributionPeriodCode;

        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityAmount;

        public CapitalizationNotion CapitalizationNotion;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapitalizationNotionSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WelfareBenefitTheoreticalAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityNbrMonths;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NbrMonthsDecimals;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IncompleteMonthNbrDays;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IncompleteMonthReason;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string FloorApplicationNotion;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionAmount;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ComplIndemnityAmountAdjustNotion
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")] Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")] Item2,

        [System.Xml.Serialization.XmlEnumAttribute("3")] Item3,

        [System.Xml.Serialization.XmlEnumAttribute("4")] Item4,

        [XmlEnumAttribute("9")] Item9,
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ContributionUnrelatedToNPUpdate : ContributionUnrelatedToNPUpdateType
    {
        public LastSituationCUNPType LastSituationCUNP;

        public CUNPUpdateActionType CUNPUpdateAction;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("LastSituationCUNP", Namespace = "", IsNullable = false)]
    public class LastSituationCUNPType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? ContUnrelatedToNPVersionNbr;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CUNPUpdateAction", Namespace = "", IsNullable = false)]
    public class CUNPUpdateActionType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedEmployerClass;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedWorkerCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedCalculationBasis;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedAmount;

        public UpdateAction UpdateAction;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("DeductionDetail", Namespace = "", IsNullable = false)]
    public class DeductionDetailType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? DeductionDetailAmount;

        public string? WorkingRegulationsRegistryNbr;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime WorkingRegulationsStartingDate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WorkingRegulationsStartingDateSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? AverageWorkingTimeBeforeReduction;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? AverageWorkingTimeAfterReduction;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DismissedStatutoryWorkerContribution", Namespace = "", IsNullable = false)]
    public class DismissedStatutoryWorkerContributionType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? GrossRefRemunAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? GrossRefRemunContributionAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? RefNbrDays;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime SubjectionStartingDate;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime SubjectionEndingDate;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class DmfAUpdate
    {
        [System.Xml.Serialization.XmlElementAttribute("Form")]
        public Form[]? Form;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Form : FormType
    {
        public ReferenceType? Reference;

        public EmployerDeclarationUpdate? EmployerDeclarationUpdate;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("Reference", Namespace = "", IsNullable = false)]
    public class ReferenceType
    {
        [XmlElementAttribute("ReferenceType")]
        public ReferenceType1 ReferenceType1;

        public ReferenceOrigin ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class EmployerDeclarationUpdate : EmployerDeclarationUpdateType
    {
        [System.Xml.Serialization.XmlElementAttribute("CompanyVehicleUpdateAction", typeof(CompanyVehicleUpdateActionType))]
        [System.Xml.Serialization.XmlElementAttribute("ContributionUnrelatedToNPUpdate", typeof(ContributionUnrelatedToNPUpdate))]
        [XmlElementAttribute("NaturalPersonUpdate", typeof(NaturalPersonUpdate))]
        public object[]? Items;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class NaturalPersonUpdate : NaturalPersonUpdateType
    {
        [XmlElementAttribute("WorkerRecordUpdate")]
        public WorkerRecordUpdate[]? WorkerRecordUpdate;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class WorkerRecordUpdate : WorkerRecordUpdateType
    {
        public LastSituationWRType? LastSituationWR;

        public WorkerRecordUpdateAction? WorkerRecordUpdateAction;
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("LastSituationWR", Namespace = "", IsNullable = false)]
    public class LastSituationWRType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? EmployerClass;

        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerRecordVersionNbr;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class WorkerRecordUpdateAction : WorkerRecordUpdateActionType
    {
        [XmlElement("ActivationInformation", typeof(ActivationInformationType))]
        [XmlElement("ComplementaryIndemnity", typeof(ComplementaryIndemnity))]
        [XmlElement("DismissedStatutoryWorkerContribution", typeof(DismissedStatutoryWorkerContributionType))]
        [XmlElement("EarlyRetirementContribution", typeof(EarlyRetirementContributionType))]
        [XmlElement("IndemnityWAPM", typeof(IndemnityWAPMType))]
        [System.Xml.Serialization.XmlElementAttribute("OccupationUpdate", typeof(OccupationUpdate))]
        [System.Xml.Serialization.XmlElementAttribute("StudentContribution", typeof(StudentContributionType))]
        [System.Xml.Serialization.XmlElementAttribute("WorkerContribution", typeof(WorkerContributionType))]
        [XmlElementAttribute("WorkerDeduction", typeof(WorkerDeduction))]
        public object[]? Items;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("EarlyRetirementContribution", Namespace = "", IsNullable = false)]
    public class EarlyRetirementContributionType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? EarlyRetirementCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? EarlyRetirementNbrMonths;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? EarlyRetirementContributionAmount;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("IndemnityWAPM", Namespace = "", IsNullable = false)]
    public class IndemnityWAPMType
    {
        [XmlElement(DataType = "integer")]
        public string? IndemnityNature;

        public string? IncapacityDegree;

        [XmlElementAttribute(DataType = "integer")]
        public string? IndemnityAmount;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class OccupationUpdate : OccupationUpdateType
    {
        public OccupationInformationsType? OccupationInformations;

        public SecondPillarInformationType? SecondPillarInformation;

        [XmlElementAttribute("Service")]
        public ServiceType[]? Service;

        [XmlElementAttribute("Remun")]
        public RemunType[]? Remun;

        [XmlElementAttribute("OccupationPublicServiceData")]
        public OccupationPublicServiceData[]? OccupationPublicServiceData;

        [XmlElementAttribute("ReorgMeasureInformation")]
        public ReorgMeasureInformationType[]? ReorgMeasureInformation;

        [XmlElementAttribute("OccupationDeduction")]
        public OccupationDeduction[]? OccupationDeduction;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("OccupationInformations", Namespace = "", IsNullable = false)]
    public class OccupationInformationsType
    {
        public HorecaExtra HorecaExtra;

        [XmlIgnoreAttribute()]
        public bool HorecaExtraSpecified;

        public PostedWorker PostedWorker;

        [XmlIgnoreAttribute()]
        public bool PostedWorkerSpecified;

        public NOSSLPASocialMaribel NOSSLPASocialMaribel;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NOSSLPASocialMaribelSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? HourRemun;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? HourRemunInThousandthOfEuro;

        [XmlElementAttribute(DataType = "date")]
        public DateTime SixMonthsIllnessDate;

        [XmlIgnoreAttribute()]
        public bool SixMonthsIllnessDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string? FirstWeekGuaranteedSalaryNbrDays;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? IllnessGrossRemunAmount;

        public PSDDclExemption PSDDclExemption;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PSDDclExemptionSpecified;

        public SupplPensionContributionExemption SupplPensionContributionExemption;

        [XmlIgnoreAttribute()]
        public bool SupplPensionContributionExemptionSpecified;

        public ObligationControlInformation ObligationControlInformation;

        [XmlIgnoreAttribute()]
        public bool ObligationControlInformationSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DefinitiveNominationDate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefinitiveNominationDateSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime NewMaribelEmploymentDate;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewMaribelEmploymentDateSpecified;

        public PSPContribCalcBasisDerogation PSPContribCalcBasisDerogation;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PSPContribCalcBasisDerogationSpecified;

        public CareerMeasure CareerMeasure;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CareerMeasureSpecified;

        public ServiceExemptionNotion ServiceExemptionNotion;

        [XmlIgnoreAttribute()]
        public bool ServiceExemptionNotionSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? HolidayDaysNumber;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? SectorDetail;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? MobilityBudget;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? FlemishTrainingHolidayHoursNbr;

        public RegionalAidMeasure RegionalAidMeasure;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegionalAidMeasureSpecified;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum HorecaExtra { E, }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PostedWorker
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum NOSSLPASocialMaribel
    {
        [XmlEnum("1")] Item1,

        [XmlEnumAttribute("2")] Item2,

        [XmlEnumAttribute("3")] Item3,

        [XmlEnumAttribute("4")] Item4,

        [XmlEnumAttribute("5")] Item5,

        [XmlEnumAttribute("6")] Item6,

        [XmlEnumAttribute("7")] Item7,

        [XmlEnumAttribute("8")] Item8,

        [XmlEnumAttribute("9")] Item9,

        [XmlEnum("10")] Item10,

        [XmlEnumAttribute("11")] Item11,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PSDDclExemption
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum SupplPensionContributionExemption
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [SerializableAttribute()]
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


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum RegionalAidMeasure { B, }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("SecondPillarInformation", Namespace = "", IsNullable = false)]
    public class SecondPillarInformationType
    {
        public string? ReferenceYearMonth;

        [XmlElementAttribute(DataType = "integer")]
        public string? MonthlyScaleSalary;

        [XmlElementAttribute(DataType = "integer")]
        public string? MonthlyAdditionalScaleSalary;

        [XmlElement(DataType = "integer")]
        public string? MonthlyHomeIndemnity;

        [XmlElement(DataType = "integer")]
        public string? OfficialLanguage;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("Service", Namespace = "", IsNullable = false)]
    public class ServiceType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? ServiceSequenceNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string? ServiceCode;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? ServiceNbrDays;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? ServiceNbrHours;

        [XmlElementAttribute(DataType = "integer")]
        public string? FlightNbrMinutes;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("Remun", Namespace = "", IsNullable = false)]
    public class RemunType
    {
        [XmlElement(DataType = "integer")]
        public string? RemunSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? RemunCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? BonusPaymentFrequency;

        [XmlElementAttribute(DataType = "integer")]
        public string? PercentagePaid;

        [XmlElementAttribute(DataType = "integer")]
        public string? RemunAmount;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationPublicServiceData : OccupationPublicServiceDataType
    {
        [XmlElementAttribute("ScaleSalary")]
        public ScaleSalary[]? ScaleSalary;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ScaleSalary : ScaleSalaryType
    {
        [XmlElementAttribute("AdditionalScaleSalary")]
        public AdditionalScaleSalaryType[]? AdditionalScaleSalary;
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ReorgMeasureInformation", Namespace = "", IsNullable = false)]
    public class ReorgMeasureInformationType
    {
        public ReorganisationMeasure ReorganisationMeasure;

        [XmlElementAttribute(DataType = "integer")]
        public string? ReorganisationMeasurePercentage;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationDeduction : OccupationDeductionType
    {
        public OccupationDeductionDetailType? OccupationDeductionDetail;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("OccupationDeductionDetail", Namespace = "", IsNullable = false)]
    public class OccupationDeductionDetailType
    {
        [XmlElement(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime WorkingRegulationsStartingDate;

        [XmlIgnoreAttribute()]
        public bool WorkingRegulationsStartingDateSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime WorkingRegulationsEndingDate;

        [XmlIgnoreAttribute()]
        public bool WorkingRegulationsEndingDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string? AverageWorkingTimeBeforeReduction;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeAfterReduction;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("StudentContribution", Namespace = "", IsNullable = false)]
    public class StudentContributionType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? StudentRemunAmount;

        [XmlElementAttribute(DataType = "integer")]
        public string? StudentContributionAmount;

        [XmlElement("StudentHoursNbr", typeof(string), DataType = "integer")]
        [XmlElement("StudentNbrDays", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        [XmlElementAttribute(DataType = "integer")]
        public string? LocalUnitID;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType { StudentHoursNbr, StudentNbrDays, }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("WorkerContribution", Namespace = "", IsNullable = false)]
    public class WorkerContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? ContributionType;

        [XmlElementAttribute(DataType = "integer")]
        public string? ContributionCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? ContributionAmount;

        [XmlElementAttribute(DataType = "date")]
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