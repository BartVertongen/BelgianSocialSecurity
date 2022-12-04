
using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class OccupationUpdateType
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
        public string? FlyingStaffClass;

        public TenthOrTwelfth TenthOrTwelfth;

        [XmlIgnore()]
        public bool TenthOrTwelfthSpecified;

        public string? OccupationUserReference;

        public DaysJustification DaysJustification;

        [XmlIgnore()]
        public bool DaysJustificationSpecified;

        [XmlElement(DataType = "integer")]
        public string? ActivityCode;

        [XmlElement(DataType = "integer")]
        public string? OccupationVersionNbr;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        [XmlElement(DataType = "integer")]
        public string? ShipId;

        [XmlElement(DataType = "integer")]
        public string? StaffCode;

        [XmlElement(DataType = "integer")]
        public string? SubsidizedMeanWorkingHours;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class WorkerRecordUpdateActionType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? EmployerClass;

        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerCode;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime NOSSQuarterStartingDate;

        [XmlIgnoreAttribute()]
        public bool NOSSQuarterStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public System.DateTime NOSSQuarterEndingDate;

        [XmlIgnore()]
        public bool NOSSQuarterEndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? Border;

        [XmlElement(DataType = "integer")]
        public string? ActivityWithRisk;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        public string? WorkerRecordUserReference;

        public UpdateAction UpdateAction;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum UpdateAction
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("3")] Item3,

        [XmlEnum("9")] Item9,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class WorkerRecordUpdateType
    { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class NaturalPersonUpdateType
    {
        [XmlElement(DataType = "integer")]
        public string? NaturalPersonSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? INSS;

        [XmlElementAttribute(DataType = "integer")]
        public string? SIS;

        public string? WorkerName;

        public string? WorkerFirstName;

        public string? WorkerInitial;

        public string? WorkerBirthdate;

        public string? WorkerBirthplace;

        [XmlElement(DataType = "integer")]
        public string WorkerBirthplaceCountry;

        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerSex;

        public string? WorkerStreet;

        public string? WorkerHouseNbr;

        public string? WorkerPostBox;

        public string? WorkerZIPCode;

        public string? WorkerCity;

        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerCountry;

        [XmlElementAttribute(DataType = "integer")]
        public string? Nationality;

        public string? NaturalPersonUserReference;

        [XmlElementAttribute(DataType = "integer")]
        public string? NaturalPersonPID;

        [XmlElementAttribute(DataType = "integer")]
        public string? DeclNaturalPersonPID;

        [XmlElementAttribute(DataType = "integer")]
        public string? DeclNaturalPersonVersionNbr;

        public string? Justification;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class EmployerDeclarationUpdateType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? Quarter;

        [XmlElementAttribute(DataType = "integer")]
        public string? NOSSRegistrationNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string? Trusteeship;

        [XmlElementAttribute(DataType = "integer")]
        public string? CompanyID;

        [XmlElementAttribute(DataType = "integer")]
        public string? System5;

        [XmlElementAttribute(DataType = "date")]
        public DateTime HolidayStartingDate;

        [XmlIgnoreAttribute()]
        public bool HolidayStartingDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string? EmployerDeclarationPID;

        public string? Justification;
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


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum Identification { DMFAUPD, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    { [XmlEnum("1")] Item1, }


    [SerializableAttribute()]
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
        [XmlElementAttribute(DataType = "integer")]
        public string EmployerNotion;

        public string JointCommissionNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string ActivityCode;

        public DebtorType DebtorType;

        [XmlIgnoreAttribute()]
        public bool DebtorTypeSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime FirstComplIndemnityDate;

        [XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityAgreementNotion;

        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion;

        public ServiceExemptionNotion ServiceExemptionNotion;

        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion;

        [XmlElementAttribute(DataType = "integer")]
        public string SubstituteINSS;

        public ResumptionOfWorkMeasure ResumptionOfWorkMeasure;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResumptionOfWorkMeasureSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityNbrOfParts;

        [XmlElement(DataType = "date")]
        public System.DateTime NoticeDate;

        [XmlIgnoreAttribute()]
        public bool NoticeDateSpecified;

        public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion;

        [XmlIgnore()]
        public bool AilingOrReorgCompanyNotionSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime AcknowledgementStartDate;

        [XmlIgnoreAttribute()]
        public bool AcknowledgementStartDateSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime AcknowledgementEndDate;

        [XmlIgnoreAttribute()]
        public bool AcknowledgementEndDateSpecified;
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
        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
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
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
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
        [XmlElementAttribute(DataType = "integer")]
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
        [XmlElement("WorkerRecordUpdate")]
        public WorkerRecordUpdate[]? WorkerRecordUpdate;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerRecordUpdate : WorkerRecordUpdateType
    {
        public LastSituationWRType? LastSituationWR;

        public WorkerRecordUpdateAction? WorkerRecordUpdateAction;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("LastSituationWR", Namespace = "", IsNullable = false)]
    public class LastSituationWRType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? EmployerClass;

        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "integer")]
        public string? WorkerRecordVersionNbr;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerRecordUpdateAction : WorkerRecordUpdateActionType
    {
        [XmlElement("ActivationInformation", typeof(ActivationInformationType))]
        [XmlElement("ComplementaryIndemnity", typeof(ComplementaryIndemnity))]
        [XmlElement("DismissedStatutoryWorkerContribution", typeof(DismissedStatutoryWorkerContributionType))]
        [XmlElement("EarlyRetirementContribution", typeof(EarlyRetirementContributionType))]
        [XmlElement("IndemnityWAPM", typeof(IndemnityWAPMType))]
        [XmlElement("OccupationUpdate", typeof(OccupationUpdate))]
        [XmlElement("StudentContribution", typeof(StudentContributionType))]
        [XmlElement("WorkerContribution", typeof(WorkerContributionType))]
        [XmlElement("WorkerDeduction", typeof(WorkerDeduction))]
        public object[]? Items;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EarlyRetirementContribution", Namespace = "", IsNullable = false)]
    public class EarlyRetirementContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementCode;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementContributionAmount;
    }


    [Serializable()]
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
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

        [XmlIgnoreAttribute()]
        public bool NOSSLPASocialMaribelSpecified;

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
        public System.DateTime NewMaribelEmploymentDate;

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

        [XmlIgnoreAttribute()]
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
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ObligationControlInformation { FWT, }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PSPContribCalcBasisDerogation
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum RegionalAidMeasure { B, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("SecondPillarInformation", Namespace = "", IsNullable = false)]
    public class SecondPillarInformationType
    {
        public string? ReferenceYearMonth;

        [XmlElement(DataType = "integer")]
        public string? MonthlyScaleSalary;

        [XmlElementAttribute(DataType = "integer")]
        public string? MonthlyAdditionalScaleSalary;

        [XmlElement(DataType = "integer")]
        public string? MonthlyHomeIndemnity;

        [XmlElement(DataType = "integer")]
        public string? OfficialLanguage;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Service", Namespace = "", IsNullable = false)]
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


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Remun", Namespace = "", IsNullable = false)]
    public class RemunType
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
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationPublicServiceData : OccupationPublicServiceDataType
    {
        [XmlElement("ScaleSalary")]
        public ScaleSalary[]? ScaleSalary;
    }

    [Serializable()]
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
    public class DmfAUpdate
    {
        [XmlElement("Form")]
        public Form[]? Form;
    }
}