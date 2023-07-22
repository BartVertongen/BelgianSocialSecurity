// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.NOTIFICATION.NOTIFICATION223
{
    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType3 { NOSSLPARegistrationNbr, NOSSRegistrationNbr, ProvisionalNSSONbr, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class HandledOriginalFileType
    {
        [XmlElement(DataType = "integer")]
        public string? SenderId;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class FormType
    {
        public string? Identification;

        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        [XmlElement(DataType = "integer")]
        public string? AttestationStatus;

        public TypeForm TypeForm;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { RE, PA, FA, LA, SU, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("AnomalyLocation", Namespace = "", IsNullable = false)]
    public class AnomalyLocationType
    {
        [XmlElement(DataType = "integer")]
        public string? LineNbr;

        [XmlElement(DataType = "integer")]
        public string? ColumnNbr;

        public string? Location;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CapeloImpactReport", Namespace = "", IsNullable = false)]
    public class CapeloImpactReportType
    {
        [XmlElement(DataType = "integer")]
        public string? ResultCode;

        [XmlElement(DataType = "integer")]
        public string? Diagnosis;
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
    [XmlRoot("ConcernedQuarter", Namespace = "", IsNullable = false)]
    public class ConcernedQuarterType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ConstructionControlCards", Namespace = "", IsNullable = false)]
    public class ConstructionControlCardsType
    {
        [XmlElement(DataType = "integer")]
        public string? FirstMonthC32ANbr;

        [XmlElement(DataType = "integer")]
        public string? NextMonthC32ANbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DailyRegistration", Namespace = "", IsNullable = false)]
    public class DailyRegistrationType
    {
        [XmlElement(DataType = "integer")]
        public string? DailyRegistrationId;

        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnore()]
        public bool StartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? StartingHour;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? EndingHour;

        [XmlElement(DataType = "integer")]
        public string? IsCancelled;

        [XmlElement(DataType = "date")]
        public DateTime LastUpdateDate;

        [XmlElement(DataType = "time")]
        public DateTime LastUpdateHour;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DailyRegistrationAfter", Namespace = "", IsNullable = false)]
    public class DailyRegistrationAfterType
    {
        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnore()]
        public bool StartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? StartingHour;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? EndingHour;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DailyRegistrationBefore", Namespace = "", IsNullable = false)]
    public class DailyRegistrationBeforeType
    {
        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnore()]
        public bool StartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? StartingHour;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? EndingHour;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DataValue", Namespace = "", IsNullable = false)]
    public class DataValueType
    {
        public string? FieldName;

        public string? NewValue;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DeclarationComplInformations", Namespace = "", IsNullable = false)]
    public class DeclarationComplInformationsType
    {
        [XmlElement(DataType = "integer")]
        public string? DMFAWorkersNbr;

        [XmlElement(DataType = "integer")]
        public string? DIMONAWorkersNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DimonaPeriodAfter", Namespace = "", IsNullable = false)]
    public class DimonaPeriodAfterType
    {
        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnore()]
        public bool StartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? StartingHour;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? EndingHour;

        [XmlElement(DataType = "integer")]
        public string? ServiceType;

        [XmlElement("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElement("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType ItemElementName;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType { PlannedDaysNbr, PlannedHoursNbr }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DimonaPeriodBefore", Namespace = "", IsNullable = false)]
    public class DimonaPeriodBeforeType
    {
        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnore()]
        public bool StartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? StartingHour;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? EndingHour;

        [XmlElement(DataType = "integer")]
        public string? ServiceType;


        [XmlElement("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElement("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType1 { PlannedDaysNbr, PlannedHoursNbr, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DmfADimonaConfrontation", Namespace = "", IsNullable = false)]
    public partial class DmfADimonaConfrontationType
    {
        [XmlElement("InQuotaPlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlElement("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElement("StudentHoursNbr", typeof(string), DataType = "integer")]
        [XmlElement("StudentNbrDays", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[]? ItemsElementName;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType
    { InQuotaPlannedHoursNbr, PlannedDaysNbr, StudentHoursNbr, StudentNbrDays, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EmployerId", Namespace = "", IsNullable = false)]
    public partial class EmployerIdType
    {
        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType2 ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType2
    { NOSSLPARegistrationNbr, NOSSRegistrationNbr, ProvisionalNSSONbr, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum EmploymentNatur { EMPLOYEE, WORKER, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("FieldInformation", Namespace = "", IsNullable = false)]
    public class FieldInformationType
    {
        public string? FieldName;

        public string? Value;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("FileReceptionInformation", Namespace = "", IsNullable = false)]
    public partial class FileReceptionInformationType
    {
        [XmlElement(DataType = "date")]
        public DateTime ReceptionDate;

        [XmlElement(DataType = "time")]
        public DateTime ReceptionHour;

        [XmlElement(DataType = "integer")]
        public string? Channel;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("FileReference", Namespace = "", IsNullable = false)]
    public partial class FileReferenceType
    {
        public string? FileName;

        [XmlElement(DataType = "integer")]
        public string? ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("HandledOriginalForm", Namespace = "", IsNullable = false)]
    public class HandledOriginalFormType
    {
        public string? Identification;

        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        [XmlIgnore()]
        public bool FormCreationDateSpecified;

        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        [XmlIgnore()]
        public bool FormCreationHourSpecified;

        [XmlElement(DataType = "integer")]
        public string? AttestationStatus;

        public TypeForm TypeForm;

        [XmlIgnore()]
        public bool TypeFormSpecified;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("HandledReference", Namespace = "", IsNullable = false)]
    public class HandledReferenceType
    {
        [XmlElement(DataType = "integer")]
        public string? ReferenceType;

        [XmlElement(DataType = "integer")]
        public string? ReferenceOrigin;

        public string? ReferenceNbr;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("HandledSenderIdentification", Namespace = "", IsNullable = false)]
    public class HandledSenderIdentificationType
    {
        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "integer")]
        public string? NOSSRegistrationNbr;


        [XmlElement(DataType = "integer")]
        public string? NOSSLPARegistrationNbr;


        [XmlElement(DataType = "integer")]
        public string? ProvisionalNSSONbr;


        [XmlElement(DataType = "integer")]
        public string? SocialSecretariatNumber;

        [XmlElement(DataType = "integer")]
        public string? INSS;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("InvolvedPartner", Namespace = "", IsNullable = false)]
    public class InvolvedPartnerType
    {
        public PartnerRole PartnerRole;

        public SectorCode SectorCode;

        [XmlElement(DataType = "integer")]
        public string? InstitutionType;

        [XmlElement(DataType = "integer")]
        public string? KindOfDossierCBSS;

        [XmlElement(DataType = "integer")]
        public string? INSSUser;

        [XmlElement(DataType = "date")]
        public DateTime DateSubmission;

        [XmlIgnore()]
        public bool DateSubmissionSpecified;

        [XmlElement(DataType = "time")]
        public DateTime HourSubmission;

        [XmlIgnore()]
        public bool HourSubmissionSpecified;

        [XmlElement(DataType = "date")]
        public DateTime StartingDateRepository;

        [XmlIgnore()]
        public bool StartingDateRepositorySpecified;

        [XmlElement(DataType = "date")]
        public DateTime EndingDateRepository;

        [XmlIgnore()]
        public bool EndingDateRepositorySpecified;
    }

    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PartnerRole
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum SectorCode
    {
        [XmlEnum("018")] Item018,

        [XmlEnum("025")] Item025,

        [XmlEnum("031")] Item031,

        [XmlEnum("053")] Item053,

        [XmlEnum("054")] Item054,

        [XmlEnum("055")] Item055,

        [XmlEnum("056")] Item056,
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("NaturalPerson", Namespace = "", IsNullable = false)]
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

        [XmlElement(DataType = "integer")]
        public string? Nationality;

        public string? NaturalPersonUserReference;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum NonSituableAbsenceCode
    {
        [XmlEnum("31")] Item31,

        [XmlEnum("32")] Item32,

        [XmlEnum("33")] Item33,

        [XmlEnum("41")] Item41,

        [XmlEnum("42")] Item42,

        [XmlEnum("43")] Item43,
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class NOTIFICATION
    {
        [XmlElement("Form")]
        public Form[]? Form;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Form : FormType
    {
        public FileReferenceType? FileReference;

        public FileReceptionInformationType? FileReceptionInformation;

        public HandledOriginalFile? HandledOriginalFile;

        public HandledOriginalFormType? HandledOriginalForm;

        [XmlElement("Reference")]
        public ReferenceType[]? Reference;

        public EmployerIdType? EmployerId;

        public NaturalPersonType? NaturalPerson;

        public ConcernedQuarterType? ConcernedQuarter;

        public HandledReferenceType? HandledReference;

        [XmlElement("WorkerRecordIdentification")]
        public WorkerRecordIdentification[]? WorkerRecordIdentification;

        public CBSSInformation? CBSSInformation;

        public DeclarationComplInformationsType? DeclarationComplInformations;

        public CoordinatesContactPerson? CoordinatesContactPerson;

        public HandlingResult? HandlingResult;

        public System.Xml.XmlElement? ApplicationData;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class HandledOriginalFile : HandledOriginalFileType
    {
        public HandledSenderIdentificationType? HandledSenderIdentification;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class ReferenceType
    {
        [XmlElement("ReferenceType", DataType = "integer")]
        public string? ReferenceType1;

        [XmlElement(DataType = "integer")]
        public string? ReferenceOrigin;

        public string? ReferenceNbr;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerRecordIdentification : WorkerRecordIdentificationType
    {
        [XmlElement("OccupationReference")]
        public OccupationReferenceType[]? OccupationReference;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationReference", Namespace = "", IsNullable = false)]
    public class OccupationReferenceType
    {
        [XmlElement("InternalOccupationNbr", typeof(string))]
        [XmlElement("OccupationSequenceNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType1[]? ItemsElementName;
    }

    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType1 { InternalOccupationNbr, OccupationSequenceNbr, }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class CBSSInformation : CBSSInformationType
    {
        [XmlElement("InvolvedPartner")]
        public InvolvedPartnerType[]? InvolvedPartner;

        public HandledCBSSInformation? HandledCBSSInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class HandledCBSSInformation : HandledCBSSInformationType
    {
        [XmlElement("DetailReturnCode")]
        public DetailReturnCode[]? DetailReturnCode;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DetailReturnCode : DetailReturnCodeType
    {
        [XmlElement("FieldInformation")]
        public FieldInformationType[]? FieldInformation;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class CoordinatesContactPerson : CoordinatesContactPersonType
    {
        public CommunicationType? Communication;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class HandlingResult : HandlingResultType
    {
        [XmlElement("AnomalyReport")]
        public AnomalyReport[]? AnomalyReport;

        public ImpactReport? ImpactReport;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AnomalyReport : AnomalyReportType
    {
        public SystemCorrection? SystemCorrection;

        public AnomalyLocationType? AnomalyLocation;

        public PathType? Path;

        public AnomalyComplInformation? AnomalyComplInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class SystemCorrection : SystemCorrectionType
    {
        [XmlElement("BlockAction")]
        public BlockAction[]? BlockAction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class BlockAction : BlockActionType
    {
        [XmlElement("DataValue")]
        public DataValueType[]? DataValue;
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

        [XmlIgnore()]
        public ItemChoiceType5 ItemElementName;


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

        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion;

        [XmlIgnore()]
        public bool HalfTimeCareerInterruptionNotionSpecified;

        public ServiceExemptionNotion ServiceExemptionNotion;

        [XmlIgnore()]
        public bool ServiceExemptionNotionSpecified;

        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion;

        [XmlIgnore()]
        public bool ReplacementAccordanceWCCNotionSpecified;

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
        public DateTime OccupationPSDStartDate;

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


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType5
    {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class AnomalyComplInformation : AnomalyComplInformationType
    {
        public DmfADimonaConfrontationType? DmfADimonaConfrontation;

        [XmlElement("DimonaPeriod")]
        public DimonaPeriod[]? DimonaPeriod;

        [XmlElement("QuotaFeatures")]
        public QuotaFeaturesType[]? QuotaFeatures;

        public DailyRegistrationType? DailyRegistration;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DimonaPeriod : DimonaPeriodType
    {
        public DimonaFeatures? DimonaFeatures;

        public ConstructionControlCardsType? ConstructionControlCards;

        public StudentPlaceOfWork? StudentPlaceOfWork;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DimonaFeatures : DimonaFeaturesType
    {
        public UsingEmployer? UsingEmployer;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class UsingEmployer : UsingEmployerType
    {
        public AddressType? Address;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class StudentPlaceOfWork : StudentPlaceOfWorkType
    {
        public AddressType? Address;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("QuotaFeatures", Namespace = "", IsNullable = false)]
    public class QuotaFeaturesType
    {
        public QuotaType QuotaType;

        [XmlElement("ExceedingDaysNbr", typeof(string), DataType = "integer")]
        [XmlElement("ExceedingHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType7 ItemElementName;
    }

    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum QuotaType
    {
        A17_PUBTV, A17_YEAR_SPORT, A17_QUARTER_SPORT, A17_STUDENT_SPORT,
        A17_YEAR_OTHER, A17_QUARTER_OTHER, A17_STUDENT_OTHER,
        ARTICLE17, STUDENT, HORECA_EMPLOYER, HORECA_WORKER,
    }

    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType7 { ExceedingDaysNbr, ExceedingHoursNbr, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ImpactReport : ImpactReportType
    {
        public DimonaImpactReport? DimonaImpactReport;

        [XmlElement("AVWDDTImpactReport")]
        public AVWDDTImpactReport[]? AVWDDTImpactReport;

        public DailyRegistrationDclImpactReport? DailyRegistrationDclImpactReport;

        public CapeloImpactReportType? CapeloImpactReport;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DimonaImpactReport : DimonaImpactReportType
    {
        public DimonaFeatures? DimonaFeatures;

        public ConstructionControlCardsType? ConstructionControlCards;

        public StudentPlaceOfWork? StudentPlaceOfWork;

        public SmallStatutesInformationType? SmallStatutesInformation;

        public DimonaPeriodBeforeType? DimonaPeriodBefore;

        public DimonaPeriodAfterType? DimonaPeriodAfter;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("SmallStatutesInformation", Namespace = "", IsNullable = false)]
    public class SmallStatutesInformationType
    {
        public EmploymentNature EmploymentNature;

        [XmlIgnore()]
        public bool EmploymentNatureSpecified;

        [XmlElement(DataType = "integer")]
        public string? ActivityWithRisk;

        public string? WorkerStatus;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AVWDDTImpactReport : AVWDDTImpactReportType
    {
        public AddressType? Address;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DailyRegistrationDclImpactReport : DailyRegistrationDclImpactReportType
    {
        public DailyRegistrationBeforeType? DailyRegistrationBefore;

        public DailyRegistrationAfterType? DailyRegistrationAfter;
    }
}