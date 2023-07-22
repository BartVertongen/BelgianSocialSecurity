//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ConsultationAnswer224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class OccupationConsultationType
    {
        [XmlElement(DataType = "integer")]
        public string? OccupationSequenceNbr;

        [XmlElement(DataType = "date")]
        public DateTime OccupationStartingDate;

        [XmlIgnore()]
        public bool OccupationStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime OccupationEndingDate;

        [XmlIgnore()]
        public bool OccupationEndingDateSpecified;

        public string? JointCommissionNbr;

        [XmlElement(DataType = "integer")]
        public string? WorkingDaysSystem;

        [XmlElement(DataType = "integer")]
        public string? ContractType;

        [XmlElement(DataType = "integer")]
        public string? RefMeanWorkingHours;

        public string? WorkerStatus;

        [XmlElement(DataType = "integer")]
        public string? MeanWorkingHours;

        public ReorganisationMeasure ReorganisationMeasure;

        [XmlIgnore()]
        public bool ReorganisationMeasureSpecified;

        [XmlElement(DataType = "integer")]
        public string? EmploymentPromotion;

        [XmlElement(DataType = "integer")]
        public string? Retired;

        [XmlElement(DataType = "integer")]
        public string? Apprenticeship;

        [XmlElement(DataType = "integer")]
        public string? RemunMethod;

        [XmlElement(DataType = "integer")]
        public string? PositionCode;

        [XmlElement(DataType = "integer")]
        public string FlyingStaffClass;

        [XmlElement(DataType = "integer")]
        public string TenthOrTwelfth;

        public string OccupationUserReference;

        public string DaysJustification;

        [XmlElement(DataType = "integer")]
        public string ActivityCode;

        [XmlElement(DataType = "integer")]
        public string OccupationVersionNbr;

        public Action Action;

        [XmlElement(DataType = "integer")]
        public string LocalUnitID;

        [XmlElement(DataType = "integer")]
        public string ShipId;

        [XmlElement(DataType = "integer")]
        public string StaffCode;

        [XmlElement(DataType = "integer")]
        public string SubsidizedMeanWorkingHours;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReorganisationMeasure
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,

        [XmlEnum("4")] Item4,

        [XmlEnum("5")] Item5,

        [XmlEnum("6")] Item6,

        [XmlEnum("7")] Item7,

        [XmlEnum("8")] Item8,

        [XmlEnum("107")] Item107,

        [XmlEnum("501")] Item501,

        [XmlEnum("502")] Item502,

        [XmlEnum("503")] Item503,

        [XmlEnum("504")] Item504,

        [XmlEnumAttribute("505")] Item505,

        [XmlEnumAttribute("506")] Item506,

        [XmlEnumAttribute("507")] Item507,

        [XmlEnumAttribute("508")] Item508,

        [XmlEnumAttribute("509")] Item509,

        [XmlEnumAttribute("510")] Item510,

        [XmlEnumAttribute("511")] Item511,

        [XmlEnumAttribute("512")] Item512,

        [XmlEnum("513")] Item513,

        [XmlEnum("514")] Item514,

        [XmlEnum("515")] Item515,

        [XmlEnum("516")] Item516,

        [XmlEnum("517")] Item517,

        [XmlEnum("531")] Item531,

        [XmlEnum("541")] Item541,

        [XmlEnum("542")] Item542,

        [XmlEnum("543")] Item543,

        [XmlEnum("544")] Item544,

        [XmlEnum("545")] Item545,

        [XmlEnum("546")] Item546,

        [XmlEnum("599")] Item599,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class WorkerRecordConsultType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "date")]
        public DateTime NOSSQuarterStartingDate;

        [XmlElement(DataType = "date")]
        public DateTime NOSSQuarterEndingDate;

        [XmlElement(DataType = "integer")]
        public string? Border;

        [XmlElement(DataType = "integer")]
        public string? ActivityWithRisk;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        public string? WorkerRecordUserReference;

        [XmlElement(DataType = "integer")]
        public string? WorkerRecordPID;

        [XmlElement(DataType = "integer")]
        public string? WorkerRecordVersionNbr;

        [XmlElement(DataType = "integer")]
        public string? CodeSubjected;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class NaturalPersonConsultType
    {
        [XmlElement(DataType = "integer")]
        public string? NaturalPersonSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? INSS;

        public string? WorkerName;

        public string? WorkerFirstName;

        public string? NaturalPersonUserReference;

        [XmlElement(DataType = "integer")]
        public string? NaturalPersonPID;

        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonPID;

        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonVersionNbr;

        [XmlElement(DataType = "integer")]
        public string? ResultCodeResearch;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class EmployerDeclarationConsultType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("Trusteeship", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[]? ItemsElementName;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "integer")]
        public string? System5;

        [XmlElement(DataType = "integer")]
        public string? EmployerDeclarationPID;

        [XmlElement(DataType = "integer")]
        public string? EmployerDeclarationVersionNbr;

        [XmlElement(DataType = "integer")]
        public string? ResultCodeResearch;

        public AnomalySubmission AnomalySubmission;

        [XmlIgnore()]
        public bool AnomalySubmissionSpecified;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
        Trusteeship,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AnomalySubmission { [XmlEnum("1")] Item1 }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class FormType
    {
        public Identification Identification;

        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        public AttestationStatus AttestationStatus;

        public TypeForm TypeForm;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum Identification { DMFADB, DMFAREQ }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AttestationStatus {
        [XmlEnum("0")] Item0,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { FA, RE }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class ContributionUnrelatedToNPConsultType
    {
        [XmlElement(DataType = "integer")]
        public string UnrelatedEmployerClass;

        [XmlElement(DataType = "integer")]
        public string UnrelatedWorkerCode;

        [XmlElement(DataType = "integer")]
        public string UnrelatedCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string UnrelatedAmount;

        [XmlElement(DataType = "integer")]
        public string ContUnrelatedToNPVersionNbr;

        [XmlElement(DataType = "integer")]
        public string CodeSubjected;

        [XmlElement(DataType = "integer")]
        public string ResultCodeResearch;

        public Action Action;

        [XmlIgnore()]
        public bool ActionSpecified;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ComplementaryIndemnityActionType
    {
        [XmlElement(DataType = "integer")]
        public string EmployerNotion;

        public string JointCommissionNbr;

        [XmlElement(DataType = "integer")]
        public string ActivityCode;

        public DebtorType DebtorType;

        [XmlIgnore()]
        public bool DebtorTypeSpecified;

        [XmlElement(DataType = "date")]
        public DateTime FirstComplIndemnityDate;

        [XmlElement(DataType = "integer")]
        public string ComplIndemnityAgreementNotion;

        public string HalfTimeCareerInterruptionNotion;

        public string ServiceExemptionNotion;

        public string ReplacementAccordanceWCCNotion;

        [XmlElement(DataType = "integer")]
        public string SubstituteINSS;

        public string ResumptionOfWorkMeasure;

        [XmlElement(DataType = "integer")]
        public string ComplIndemnityNbrOfParts;

        [XmlElement(DataType = "date")]
        public DateTime NoticeDate;

        [XmlIgnore()]
        public bool NoticeDateSpecified;

        public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion;

        [XmlIgnore()]
        public bool AilingOrReorgCompanyNotionSpecified;

        [XmlElement(DataType = "date")]
        public DateTime AcknowledgementStartDate;

        [XmlIgnore()]
        public bool AcknowledgementStartDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime AcknowledgementEndDate;

        [XmlIgnore()]
        public bool AcknowledgementEndDateSpecified;

        public Action Action;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum DebtorType {

        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,

        [XmlEnum("4")] Item4,

        [XmlEnum("5")] Item5,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AilingOrReorgCompanyNotion
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class AnomalyReportType
    {
        public string? ErrorID;

        public string? TagName;

        public string? Value;

        public string? AnomalyClass;

        public string? AnomalyLabel;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("AdditionalScaleSalaryAction", Namespace = "", IsNullable = false)]
    public class AdditionalScaleSalaryActionType
    {
        [XmlElement(DataType = "date")]
        public DateTime AdditionalScaleSalaryStartDate;

        [XmlElement(DataType = "date")]
        public DateTime AdditionalScaleSalaryEndDate;

        [XmlIgnore()]
        public bool AdditionalScaleSalaryEndDateSpecified;

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

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AnomalyReport : AnomalyReportType
    {
        public PathType? Path;
    }


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
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnoreAttribute()]
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

        public ReorganisationMeasure ReorganisationMeasure;

        [XmlIgnore()]
        public bool ReorganisationMeasureSpecified;

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

        public string JointCommissionNbr;

        [XmlElement(DataType = "integer")]
        public string ActivityCode;

        [XmlElement(DataType = "integer")]
        public string ComplIndemnityAgreementNotion;

        public string HalfTimeCareerInterruptionNotion;

        public string ServiceExemptionNotion;

        public string ReplacementAccordanceWCCNotion;

        [XmlElement(DataType = "integer")]
        public string ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string ContributionType;

        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        [XmlIgnore()]
        public bool ComplIndemnityAmountAdjustNotionSpecified;

        [XmlElement(DataType = "integer")]
        public string? ContributionSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementCode;

        [XmlElement(DataType = "integer")]
        public string? IndemnityNature;

        public string IncapacityDegree;

        public string NaturalPersonUserReference;

        public string WorkerRecordUserReference;

        public string OccupationUserReference;

        [XmlElement(DataType = "integer")]
        public string CompanyVehicleSequenceNbr;

        public string NPCalculatedAmount;

        public string CUNPCalculatedAmount;

        public string WorksContractActorId;

        [XmlElement(DataType = "date")]
        public DateTime OccupationPSDStartDate;

        [XmlIgnore()]
        public bool OccupationPSDStartDateSpecified;

        [XmlElement(DataType = "integer")]
        public string EmployerSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string CareerElementSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string PublicSectorInstitutionType;

        [XmlElement(DataType = "integer")]
        public string PublicSectorPersonnelCategory;

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
        public string PecuniarySeniorityStartDate;

        [XmlElement(DataType = "integer")]
        public string SalaryScaleReference;

        [XmlElement(DataType = "integer")]
        public string AdditionalScaleSalarySequenceNbr;

        [XmlElement(DataType = "integer")]
        public string AdditionalScaleSalaryReference;

        [XmlElement(DataType = "date")]
        public DateTime AdditionalScaleSalaryStartDate;

        [XmlIgnore()]
        public bool AdditionalScaleSalaryStartDateSpecified;

        public NonSituableAbsenceCode NonSituableAbsenceCode;

        [XmlIgnore()]
        public bool NonSituableAbsenceCodeSpecified;

        [XmlElement(DataType = "integer")]
        public string CalendarYear;

        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ComplIndemnityAmountAdjustNotion {

        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,

        [XmlEnum("4")] Item4,

        [XmlEnum("9")] Item9,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum NonSituableAbsenceCode {

        [XmlEnum("31")] Item31,

        [XmlEnum("32")] Item32,

        [XmlEnum("33")] Item33,

        [XmlEnum("41")] Item41,

        [XmlEnum("42")] Item42,

        [XmlEnum("43")] Item43,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum CapitalizationNotion {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CompanyVehicleAction", Namespace = "", IsNullable = false)]
    public class CompanyVehicleActionType
    {
        [XmlElement(DataType = "integer")]
        public string? CompanyVehicleSequenceNbr;

        public string? LicensePlate;

        [XmlElement(DataType = "integer")]
        public string? EcoVehicle;

        [XmlElement(DataType = "integer")]
        public string? CompanyVehicleVersionNbr;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ComplementaryIndemnityAction : ComplementaryIndemnityActionType
    {
        [XmlElement("ComplIndemnityContributionAction")]
        public ComplIndemnityContributionActionType[] ComplIndemnityContributionAction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ComplIndemnityContributionAction", Namespace = "", IsNullable = false)]
    public class ComplIndemnityContributionActionType
    {
        [XmlElement(DataType = "integer")]
        public string ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string ContributionType;

        [XmlElement(DataType = "integer")]
        public string IndemnityContributionPeriodCode;

        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        [XmlElement(DataType = "integer")]
        public string ContributionSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string ComplIndemnityAmount;

        public CapitalizationNotion CapitalizationNotion;

        [XmlIgnore()]
        public bool CapitalizationNotionSpecified;

        [XmlElement(DataType = "integer")]
        public string WelfareBenefitTheoreticalAmount;

        [XmlElement(DataType = "integer")]
        public string ComplIndemnityNbrMonths;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string NbrMonthsDecimals;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string IncompleteMonthNbrDays;

        [XmlElement(DataType = "integer")]
        public string IncompleteMonthReason;

        [XmlElement(DataType = "integer")]
        public string FloorApplicationNotion;

        [XmlElement(DataType = "integer")]
        public string ContributionAmount;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ContributionUnrelatedToNPConsult : ContributionUnrelatedToNPConsultType
    {
        [XmlElement("AnomalyReport")]
        public AnomalyReport[] AnomalyReport;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DeductionDetailAction", Namespace = "", IsNullable = false)]
    public class DeductionDetailActionType
    {
        [XmlElement(DataType = "integer")]
        public string DeductionDetailSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? DeductionDetailAmount;

        public string? WorkingRegulationsRegistryNbr;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsStartingDate;

        [XmlIgnore()]
        public bool WorkingRegulationsStartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeBeforeReduction;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeAfterReduction;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DismissedStatWorkerContAction", Namespace = "", IsNullable = false)]
    public class DismissedStatWorkerContActionType
    {
        [XmlElement(DataType = "integer")]
        public string? GrossRefRemunAmount;

        [XmlElement(DataType = "integer")]
        public string? GrossRefRemunContributionAmount;

        [XmlElement(DataType = "integer")]
        public string? RefNbrDays;

        [XmlElement(DataType = "date")]
        public DateTime SubjectionStartingDate;

        [XmlElement(DataType = "date")]
        public DateTime SubjectionEndingDate;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DmfAConsultationAnswer
    {
        [XmlElement("Form")]
        public Form[] Form;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Form : FormType
    {
        public FileReferenceType FileReference;

        public HandledOriginalFormType HandledOriginalForm;

        public ReferenceType Reference;

        public HandledReferenceType HandledReference;

        public EmployerDeclarationConsult EmployerDeclarationConsult;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("FileReference", Namespace = "", IsNullable = false)]
    public class FileReferenceType
    {
        public string FileName;

        public ReferenceOrigin ReferenceOrigin;

        public string ReferenceNbr;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("HandledOriginalForm", Namespace = "", IsNullable = false)]
    public class HandledOriginalFormType
    {
        public Identification Identification;

        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        public AttestationStatus AttestationStatus;

        public TypeForm TypeForm;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class ReferenceType
    {
        [XmlElement("ReferenceType")]
        public ReferenceType1 ReferenceType1;

        public ReferenceOrigin ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1 { [XmlEnum("1")] Item1 }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("HandledReference", Namespace = "", IsNullable = false)]
    public class HandledReferenceType
    {
        public ReferenceType1 ReferenceType;

        public ReferenceOrigin ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class EmployerDeclarationConsult : EmployerDeclarationConsultType
    {
        [XmlElement("CompanyVehicleAction", typeof(CompanyVehicleActionType))]
        [XmlElement("ContributionUnrelatedToNPConsult", typeof(ContributionUnrelatedToNPConsult))]
        [XmlElement("NaturalPersonConsult", typeof(NaturalPersonConsult))]
        public object[]? Items1;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class NaturalPersonConsult : NaturalPersonConsultType
    {
        [XmlElement("WorkerRecordConsult")]
        public WorkerRecordConsult[] WorkerRecordConsult;

        [XmlElement("AnomalyReport")]
        public AnomalyReport[] AnomalyReport;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerRecordConsult : WorkerRecordConsultType
    {
        [XmlElement("ActivationInformationAction", typeof(ActivationInformationActionType))]
        [XmlElement("ComplementaryIndemnityAction", typeof(ComplementaryIndemnityAction))]
        [XmlElement("DismissedStatWorkerContAction", typeof(DismissedStatWorkerContActionType))]
        [XmlElement("EarlyRetirementContAction", typeof(EarlyRetirementContActionType))]
        [XmlElement("IndemnityWAPMAction", typeof(IndemnityWAPMActionType))]
        [XmlElement("OccupationConsultation", typeof(OccupationConsultation))]
        [XmlElement("StudentContributionAction", typeof(StudentContributionActionType))]
        [XmlElement("WorkerContributionAction", typeof(WorkerContributionActionType))]
        [XmlElement("WorkerDeductionAction", typeof(WorkerDeductionAction))]
        public object[]? Items;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EarlyRetirementContAction", Namespace = "", IsNullable = false)]
    public class EarlyRetirementContActionType
    {
        [XmlElement(DataType = "integer")]
        public string EarlyRetirementCode;

        [XmlElement(DataType = "integer")]
        public string EarlyRetirementNbrMonths;

        [XmlElement(DataType = "integer")]
        public string EarlyRetirementContributionAmount;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("IndemnityWAPMAction", Namespace = "", IsNullable = false)]
    public class IndemnityWAPMActionType
    {
        [XmlElement(DataType = "integer")]
        public string? IndemnityNature;

        public string? IncapacityDegree;

        [XmlElement(DataType = "integer")]
        public string? IndemnityAmount;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationConsultation : OccupationConsultationType
    {
        public OccupationInformationsActionType? OccupationInformationsAction;

        public SecondPillarInformationActionType SecondPillarInformationAction;

        [XmlElement("ServiceAction")]
        public ServiceActionType[]? ServiceAction;

        [XmlElement("RemunAction")]
        public RemunActionType[]? RemunAction;

        [XmlElement("OccupationPSDAction")]
        public OccupationPSDAction[]? OccupationPSDAction;

        [XmlElement("ReorgMeasureInformationAction")]
        public ReorgMeasureInformationActionType[]? ReorgMeasureInformationAction;

        [XmlElement("OccupationDeductionAction")]
        public OccupationDeductionAction[]? OccupationDeductionAction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationInformationsAction", Namespace = "", IsNullable = false)]
    public class OccupationInformationsActionType
    {
        public string HorecaExtra;

        public PostedWorker PostedWorker;

        [XmlIgnore()]
        public bool PostedWorkerSpecified;

        [XmlElement(DataType = "integer")]
        public string NOSSLPASocialMaribel;

        [XmlElement(DataType = "integer")]
        public string HourRemun;

        [XmlElement(DataType = "integer")]
        public string HourRemunInThousandthOfEuro;

        [XmlElement(DataType = "date")]
        public DateTime SixMonthsIllnessDate;

        [XmlIgnore()]
        public bool SixMonthsIllnessDateSpecified;

        [XmlElement(DataType = "integer")]
        public string FirstWeekGuaranteedSalaryNbrDays;

        [XmlElement(DataType = "integer")]
        public string IllnessGrossRemunAmount;

        public PSDDclExemption PSDDclExemption;

        [XmlIgnore()]
        public bool PSDDclExemptionSpecified;

        public SupplPensionContributionExemption SupplPensionContributionExemption;

        [XmlIgnore()]
        public bool SupplPensionContributionExemptionSpecified;

        public ObligationControlInformation ObligationControlInformation;

        [XmlIgnore()]
        public bool ObligationControlInformationSpecified;

        [XmlElement(DataType = "date")]
        public DateTime DefinitiveNominationDate;

        [XmlIgnore()]
        public bool DefinitiveNominationDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime NewMaribelEmploymentDate;

        [XmlIgnore()]
        public bool NewMaribelEmploymentDateSpecified;

        public PSPContribCalcBasisDerogation PSPContribCalcBasisDerogation;

        [XmlIgnore()]
        public bool PSPContribCalcBasisDerogationSpecified;

        [XmlElement(DataType = "integer")]
        public string CareerMeasure;

        public string ServiceExemptionNotion;

        [XmlElement(DataType = "integer")]
        public string HolidayDaysNumber;

        [XmlElement(DataType = "integer")]
        public string SectorDetail;
        
        [XmlElement(DataType = "integer")]
        public string? MobilityBudget;

        [XmlElement(DataType = "integer")]
        public string? FlemishTrainingHolidayHoursNbr;

        public string? RegionalAidMeasure;

        public Action Action;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PostedWorker
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PSDDclExemption
{
        [XmlEnum("1")] Item1,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum SupplPensionContributionExemption
    {
        [XmlEnumAttribute("1")] Item1,

        [XmlEnumAttribute("2")] Item2,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ObligationControlInformation { FWT }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PSPContribCalcBasisDerogation
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("SecondPillarInformationAction", Namespace = "", IsNullable = false)]
    public class SecondPillarInformationActionType
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

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ServiceAction", Namespace = "", IsNullable = false)]
    public class ServiceActionType
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

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("RemunAction", Namespace = "", IsNullable = false)]
    public class RemunActionType
    {
        [XmlElement(DataType = "integer")]
        public string? RemunSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? RemunCode;

        [XmlElement(DataType = "integer")]
        public string? BonusPaymentFrequency;

        [XmlElement(DataType = "integer")]
        public string? PercentagePaid;

        [XmlElement(DataType = "integer")]
        public string? RemunAmount;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationPSDAction : OccupationPSDActionType
    {
        [XmlElement("ScaleSalaryAction")]
        public ScaleSalaryAction[]? ScaleSalaryAction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ScaleSalaryAction : ScaleSalaryActionType
    {
        [XmlElement("AdditionalScaleSalaryAction")]
        public AdditionalScaleSalaryActionType[]? AdditionalScaleSalaryAction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ReorgMeasureInformationAction", Namespace = "", IsNullable = false)]
    public class ReorgMeasureInformationActionType
    {
        [XmlElement(DataType = "integer")]
        public string? ReorganisationMeasurePercentage;

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationDeductionAction : OccupationDeductionActionType
    {
        public OccupationDeductionDetailActionType? OccupationDeductionDetailAction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationDeductionDetailAction", Namespace = "", IsNullable = false)]
    public partial class OccupationDeductionDetailActionType
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

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("StudentContributionAction", Namespace = "", IsNullable = false)]
    public class StudentContributionActionType
    {
        [XmlElement(DataType = "integer")]
        public string? StudentRemunAmount;

        [XmlElement(DataType = "integer")]
        public string? StudentContributionAmount;

        [XmlElement("StudentHoursNbr", typeof(string), DataType = "integer")]
        [XmlElement("StudentNbrDays", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        public Action Action;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType1 { StudentHoursNbr, StudentNbrDays }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("WorkerContributionAction", Namespace = "", IsNullable = false)]
    public class WorkerContributionActionType
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

        public Action Action;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerDeductionAction : WorkerDeductionActionType
    {
        [XmlElement("DeductionDetailAction")]
        public DeductionDetailActionType[]? DeductionDetailAction;
    }
}