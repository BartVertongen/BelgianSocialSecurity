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


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AccountingRef
    {
        [XmlEnum("121")] Item121,

        [XmlEnum("221")] Item221,

        [XmlEnum("128")] Item128,

        [XmlEnum("228")] Item228,

        [XmlEnum("132")] Item132,

        [XmlEnum("232")] Item232,

        [XmlEnum("316")] Item316,

        [XmlEnum("356")] Item356,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum CalculationRequestCO2 { S, }


    [SerializableAttribute()]
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
    public enum Identification { BEWARE }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("2")] Item2,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { S }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class SubGroupInformationType
    {
        [XmlElement(DataType = "integer")]
        public string? SubGroup;

        public SubGroupDecisionIndicator SubGroupDecisionIndicator;

        [XmlIgnore()]
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
    public enum SubGroupDecisionIndicator { R }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DmfAInformationType
    {
        public string? DmfATicketNbr;

        public string? DmfANotTicketNbr;

        public string? DmfANotAmount;

        public string? UserComment;

        [XmlElement(DataType = "integer")]
        public string? SocialSecretariatNumber;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ProcessedCorrectionsSectionType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        public string? ContributionTotalAmount;

        public AccountUpdateReportParticipation AccountUpdateReportParticipation;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AccountUpdateReportParticipation
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ProcessedCorrectionsReportType
    { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ReceiverInformationType
    { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class CoordinatesContactPersonType
    {
        public string? Name;

        public string? FirstName;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class BewareInformationType
    {
        [XmlElement(DataType = "integer")]
        public string? NOSSRegistrationNbr;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElementAttribute(DataType = "date")]
        public DateTime ProcessingDate;

        public UserQualityClass UserQualityClass;

        public CalculationRequestArt54ter CalculationRequestArt54ter;

        [XmlIgnore()]
        public bool CalculationRequestArt54terSpecified;

        public FaultyCode FaultyCode;

        [XmlIgnore()]
        public bool FaultyCodeSpecified;

        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? JustificationCode;

        public Notion22Quater Notion22Quater;

        [XmlIgnore()]
        public bool Notion22QuaterSpecified;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum UserQualityClass
    {
        [XmlEnum("01")] Item01,

        [XmlEnum("02")] Item02,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum CalculationRequestArt54ter { S }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum FaultyCode { F }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum Notion22Quater { Q }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class EmployerInstructionType
    {
        [XmlElement(DataType = "integer")]
        public string? InstructionType;

        public string? InstructionAmount;

        [XmlElement(DataType = "date")]
        public DateTime DueDate;

        [XmlIgnore()]
        public bool DueDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime BalancingDate;

        [XmlIgnore()]
        public bool BalancingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? InstructionQuarter;

        public string? AskAccountNotion;

        public string? Comment;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class AccountUpdateSectionType
    {
        [XmlElement(DataType = "integer")]
        public string? AccountingQuarter;

        [XmlElement(DataType = "integer")]
        public string? CorrectionClassification;
    }


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


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("AccountSituation", Namespace = "", IsNullable = false)]
    public class AccountSituationType
    {
        public string? AccountSituationReference;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AccountUpdateReport : AccountUpdateReportType
    {
        [XmlElement("AccountUpdateSection")]
        public AccountUpdateSection[]? AccountUpdateSection;

        public EmployerInstruction? EmployerInstruction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AccountUpdateSection : AccountUpdateSectionType
    {
        [XmlElement("AccountingEntry")]
        public AccountingEntryType[]? AccountingEntry;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class EmployerInstruction : EmployerInstructionType
    {
        public AccountSituationType? AccountSituation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Address", Namespace = "", IsNullable = false)]
    public class AddressType
    {
        public string? Street;

        public string? HouseNbr;

        public string? PostBox;

        public string? ZIPCode;

        public string? City;

        [XmlElement(DataType = "integer")]
        public string? Country;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class BewareInformation : BewareInformationType
    {
        public CoordinatesContactPerson? CoordinatesContactPerson;

        public ReceiverInformation? ReceiverInformation;

        public AccountUpdateReport? AccountUpdateReport;

        public ProcessedCorrectionsReport? ProcessedCorrectionsReport;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class CoordinatesContactPerson : CoordinatesContactPersonType
    {
        public CommunicationType? Communication;

        public SectorInformationType? SectorInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Communication", Namespace = "", IsNullable = false)]
    public class CommunicationType
    {
        public string? PhoneNbr;

        public string? GSMNbr;

        public string? FaxNbr;

        public string? EmailAddress;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("SectorInformation", Namespace = "", IsNullable = false)]
    public class SectorInformationType
    {
        public string? OfficeNumber;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ReceiverInformation : ReceiverInformationType
    {
        public CoordinatesSocialSecretariatType? CoordinatesSocialSecretariat;

        public CoordinatesEmployerType? CoordinatesEmployer;

        public CoordinatesRepresentativeType? CoordinatesRepresentative;

        public AddressType? Address;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CoordinatesSocialSecretariat", Namespace = "", IsNullable = false)]
    public class CoordinatesSocialSecretariatType
    {
        [XmlElement(DataType = "integer")]
        public string? SocialSecretariatNumber;

        [XmlElement(DataType = "integer")]
        public string? FilialSecSocNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CoordinatesEmployer", Namespace = "", IsNullable = false)]
    public class CoordinatesEmployerType
    {
        public string? EmployerDenomination;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("CoordinatesRepresentative", Namespace = "", IsNullable = false)]
    public class CoordinatesRepresentativeType
    {
        public string? Denomination;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ProcessedCorrectionsReport : ProcessedCorrectionsReportType
    {

        [XmlElement("ProcessedCorrectionsSection")]
        public ProcessedCorrectionsSection[]? ProcessedCorrectionsSection;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ProcessedCorrectionsSection : ProcessedCorrectionsSectionType
    {
        [XmlElement("DmfAInformation")]
        public DmfAInformation[]? DmfAInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DmfAInformation : DmfAInformationType
    {
        [XmlElement("SubGroupInformation")]
        public SubGroupInformation[]? SubGroupInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class SubGroupInformation : SubGroupInformationType
    {
        [XmlElement("WorkerContAccountingOverview")]
        public WorkerContAccountingOverviewType[]? WorkerContAccountingOverview;

        [XmlElement("DeductionAccountingOverview")]
        public DeductionAccountingOverviewType[]? DeductionAccountingOverview;

        [XmlElement("CUNPAccountingOverview")]
        public CUNPAccountingOverviewType[]? CUNPAccountingOverview;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("WorkerContAccountingOverview", Namespace = "", IsNullable = false)]
    public class WorkerContAccountingOverviewType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionType;

        [XmlElement(DataType = "integer")]
        public string? NbrOfWorkersInvolved;

        public string? SignedContributionCalcBasis;

        public string? SignedContributionAmount;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DeductionAccountingOverview", Namespace = "", IsNullable = false)]
    public class DeductionAccountingOverviewType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "integer")]
        public string? DeductionCode;

        [XmlElement(DataType = "integer")]
        public string? NbrOfWorkersInvolved;

        public string? SignedDeductionCalcBasis;

        public string? SignedDeductionAmount;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CUNPAccountingOverview", Namespace = "", IsNullable = false)]
    public class CUNPAccountingOverviewType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        public string? SignedCUNPCalcBasis;

        public string? SignedCUNPAmount;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class BewareNotification
    {
        [XmlElement("Form")]
        public Form[]? Form;
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

        public BewareInformation? BewareInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

        [XmlEnum("9")] Item9,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,
    }
}