//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
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
    public class Form : FormType
    {
        [XmlElement("Reference")]
        public ReferenceType[]? Reference;

        public EmployerDeclarationUpdateNotif? EmployerDeclarationUpdateNotif;

        public RectificationAmountType? RectificationAmount;
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
    public enum ReferenceType1
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("3")] Item3,
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
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class EmployerDeclarationUpdateNotif : EmployerDeclarationUpdateNotifType
    {
        [XmlElement("SubGroupInformation")]
        public SubGroupInformationType[]? SubGroupInformation;

        [XmlElement("CUNPUpdateNotif", typeof(CUNPUpdateNotif))]
        [XmlElement("CompanyVehicleUpdateNotif", typeof(CompanyVehicleUpdateNotif))]
        [XmlElement("NaturalPersonUpdateNotif", typeof(NaturalPersonUpdateNotif))]
        public object[]? Items1;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("SubGroupInformation", Namespace = "", IsNullable = false)]
    public class SubGroupInformationType
    {
        [XmlElement(DataType = "integer")]
        public string? SubGroup;

        public SubGroupDecisionIndicator SubGroupDecisionIndicator;

        [XmlIgnoreAttribute()]
        public bool SubGroupDecisionIndicatorSpecified;

        [XmlElement(DataType = "integer")]
        public string? UserQuality;

        public string? Justification;

        [XmlElement(DataType = "integer")]
        public string? JustificationCode;

        [XmlElement(DataType = "date")]
        public DateTime JustificationDate;

        [XmlIgnore()]
        public bool JustificationDateSpecified;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum SubGroupDecisionIndicator { R, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class NaturalPersonUpdateNotif : NaturalPersonUpdateNotifType
    {
        [XmlElement("WorkerRecordUpdateNotif")]
        public WorkerRecordUpdateNotif[]? WorkerRecordUpdateNotif;

        [XmlElement("NaturalPersonJustification")]
        public NaturalPersonJustificationType[]? NaturalPersonJustification;

        [XmlElement("AnomalyReport")]
        public AnomalyReport[]? AnomalyReport;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerRecordUpdateNotif : WorkerRecordUpdateNotifType
    {
        public LastSituationWRType? LastSituationWR;

        public WRDclPart? WRDclPart;

        public WRCorrectedPart? WRCorrectedPart;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("LastSituationWR", Namespace = "", IsNullable = false)]
    public class LastSituationWRType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "integer")]
        public string? WorkerRecordVersionNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WRDclPart : WRDclPartType
    {
        [XmlElement("ActivationInformationAction", typeof(ActivationInformationActionType))]
        [XmlElement("ComplementaryIndemnityAction", typeof(ComplementaryIndemnityAction))]
        [XmlElement("DismissedStatWorkerContAction", typeof(DismissedStatWorkerContActionType))]
        [XmlElement("EarlyRetirementContAction", typeof(EarlyRetirementContActionType))]
        [XmlElement("IndemnityWAPMAction", typeof(IndemnityWAPMActionType))]
        [XmlElement("OccupationUpdateNotification", typeof(OccupationUpdateNotification))]
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
        public string? EarlyRetirementCode;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementContributionAmount;

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
    public class OccupationUpdateNotification : OccupationUpdateNotificationType
    {
        public OccupationInformationsActionType? OccupationInformationsAction;

        public SecondPillarInformationActionType? SecondPillarInformationAction;

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


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum SupplPensionContributionExemption
    {
        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ObligationControlInformation { FWT, }


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
        public string? ReorganisationMeasure;

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
        [XmlElement("OccupationDeductionDetailAction")]
        public OccupationDeductionDetailActionType[]? OccupationDeductionDetailAction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationDeductionDetailAction", Namespace = "", IsNullable = false)]
    public class OccupationDeductionDetailActionType
    {

        [XmlElement(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsStartingDate;

        [XmlIgnore()]
        public bool WorkingRegulationsStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsEndingDate;

        [XmlIgnoreAttribute()]
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
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        public Action Action;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType1 { StudentHoursNbr, StudentNbrDays, }


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

        [XmlIgnoreAttribute()]
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


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WRCorrectedPart : WRCorrectedPartType
    {
        [XmlElement("ActivationInformationAction", typeof(ActivationInformationActionType))]
        [XmlElement("ComplementaryIndemnityAction", typeof(ComplementaryIndemnityAction))]
        [XmlElement("DismissedStatWorkerContAction", typeof(DismissedStatWorkerContActionType))]
        [XmlElement("EarlyRetirementContAction", typeof(EarlyRetirementContActionType))]
        [XmlElement("IndemnityWAPMAction", typeof(IndemnityWAPMActionType))]
        [XmlElement("OccupationUpdateNotification", typeof(OccupationUpdateNotification))]
        [XmlElement("StudentContributionAction", typeof(StudentContributionActionType))]
        [XmlElement("WorkerContributionAction", typeof(WorkerContributionActionType))]
        [XmlElement("WorkerDeductionAction", typeof(WorkerDeductionAction))]
        public object[]? Items;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("NaturalPersonJustification", Namespace = "", IsNullable = false)]
    public class NaturalPersonJustificationType
    {
        [XmlElement(DataType = "integer")]
        public string? SubGroup;

        public string? Justification;

        [XmlElement(DataType = "integer")]
        public string? JustificationCode;

        [XmlElement(DataType = "date")]
        public DateTime JustificationDate;

        [XmlIgnore()]
        public bool JustificationDateSpecified;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("RectificationAmount", Namespace = "", IsNullable = false)]
    public class RectificationAmountType
    {
        [XmlElement("CreditAmount", typeof(string), DataType = "integer")]
        [XmlElement("DebitAmount", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType2 ItemElementName;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType2 { CreditAmount, DebitAmount, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DmfAUpdateNotification
    {
        public Form? Form;
    }
}