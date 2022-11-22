

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.NOTIFICATION
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum Action
    {
        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("9")]
        Item9,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Address", Namespace = "", IsNullable = false)]
    public partial class AddressType
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
    public partial class DailyRegistrationDclImpactReportType
    {
        [XmlElement(DataType = "integer")]
        public string? DailyRegistrationId;


        [XmlElement(DataType = "integer")]
        public string? AttestationStatus;


        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class AVWDDTImpactReportType
    {
        [XmlElement("CompanyID", typeof(string), DataType = "integer")]
        [XmlElement("ForeignCompanyID", typeof(string))]
        [XmlElement("VATNbr", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType8 ItemElementName;

        public string? Denomination;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType8 { CompanyID, ForeignCompanyID, VATNbr, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class DimonaImpactReportType
    {
        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElement(DataType = "integer")]
        public string? IsLocked;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class ImpactReportType
    {
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class StudentPlaceOfWorkType
    {
        public string? Denomination;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class UsingEmployerType
    {
        public string? JointCommissionNbr;

        public string? UsingEmployerName;

        [XmlElement(DataType = "integer")]
        public string? UsingEmployerCompanyID;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DimonaFeaturesType
    {

        public string? JointCommissionNbr;

        public WorkerType WorkerType;

        [XmlIgnore()]
        public bool WorkerTypeSpecified;

        [XmlElement(DataType = "integer")]
        public string? SubEntityNbr;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum WorkerType { A17, BCW, DWD, EXT, FLX, IVT, O17, PMP,
        QUA, RTA, S17, STU, STX, T17, TEA, TRI, STG, OTH, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class DimonaPeriodType
    {
        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElementAttribute(DataType = "integer")]
        public string? IsLocked;

        [XmlElementAttribute(DataType = "integer")]
        public string? IsCancelled;

        public bool IsLate;

        [XmlIgnoreAttribute()]
        public bool IsLateSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime StartingDate;

        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? StartingHour;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string EndingHour;

        [XmlElement(DataType = "integer")]
        public string ServiceType;

        [XmlElementAttribute("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName;

        [XmlElement(DataType = "date")]
        public DateTime LastUpdateDate;

        [XmlElementAttribute(DataType = "time")]
        public DateTime LastUpdateHour;

        [XmlElementAttribute("ErrorID")]
        public string[]? ErrorID;

        public string? AnomalyClass;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType6 { PlannedDaysNbr, PlannedHoursNbr }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AnomalyComplInformationType
    {
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BlockActionType
    {
        public Action Action;

        public string? BlockName;


        [XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? Trusteeship;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? Quarter;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? NaturalPersonSequenceNbr;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? INSS;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? EmployerClass;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? OccupationSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? ServiceSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? ServiceCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? RemunSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? RemunCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? BonusPaymentFrequency;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? PercentagePaid;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? EarlyRetirementCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? EmployerNotion;

        /// <remarks/>
        public string? JointCommissionNbr;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? ActivityCode;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? ComplIndemnityAgreementNotion;

        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion;

        [XmlIgnoreAttribute()]
        public bool HalfTimeCareerInterruptionNotionSpecified;

        /// <remarks/>
        public ServiceExemptionNotion ServiceExemptionNotion;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ServiceExemptionNotionSpecified;

        /// <remarks/>
        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ReplacementAccordanceWCCNotionSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? ContributionWorkerCode;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? ContributionType;

        /// <remarks/>
        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ComplIndemnityAmountAdjustNotionSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? ContributionSequenceNbr;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? DeductionCode;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? IndemnityNature;

        /// <remarks/>
        public string? IncapacityDegree;

        /// <remarks/>
        public string? NaturalPersonUserReference;

        /// <remarks/>
        public string? WorkerRecordUserReference;

        /// <remarks/>
        public string? OccupationUserReference;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? CompanyVehicleSequenceNbr;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType4 { NOSSLPARegistrationNbr, NOSSRegistrationNbr }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum HalfTimeCareerInterruptionNotion
    {
        [XmlEnumAttribute("0")]
        Item0,

        [XmlEnumAttribute("1")]
        Item1,

        [XmlEnumAttribute("9")]
        Item9,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ServiceExemptionNotion
    {
        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("5")]
        Item5,

        [XmlEnum("6")]
        Item6,

        [XmlEnum("9")]
        Item9,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReplacementAccordanceWCCNotion
    {
        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,

        [XmlEnum("9")]
        Item9,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ComplIndemnityAmountAdjustNotion
    {
        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("9")]
        Item9,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class SystemCorrectionType
    {
        public CorrectionType CorrectionType;
    }


    [Serializable()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum CorrectionType { RC, UC, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class AnomalyReportType
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
    public partial class HandlingResultType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? ResultCode;

        /// <remarks/>
        [XmlElement("Diagnosis", DataType = "integer")]
        public string[]? Diagnosis;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CoordinatesContactPersonType
    {
        public string? Name;

        public string? FirstName;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DetailReturnCodeType
    {
        public string? AnomalyClass;

        [XmlElement(DataType = "integer")]
        public string? ReasonCodeCBSS;

        public string? Justification;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HandledCBSSInformationType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? ResultCode;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class CBSSInformationType
    {
        public KindOfTreatment? KindOfTreatment;

        public string? InternalRefCBSS;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum KindOfTreatment { M, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WorkerRecordIdentificationType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? Quarter;

        /// <remarks/>
        [XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? CompanyID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? NaturalPersonSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? INSS;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? EmployerClass;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerCode;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType3
    {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
        ProvisionalNSSONbr,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class HandledOriginalFileType
    {
        [XmlElement(DataType = "integer")]
        public string? SenderId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FormType
    {
        public string? Identification;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime FormCreationDate;

        /// <remarks/>
        [XmlElementAttribute(DataType = "time")]
        public DateTime FormCreationHour;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? AttestationStatus;

        /// <remarks/>
        public TypeForm TypeForm;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { RE, PA, FA, LA, SU, }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("AnomalyLocation", Namespace = "", IsNullable = false)]
    public partial class AnomalyLocationType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? LineNbr;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? ColumnNbr;

        /// <remarks/>
        public string? Location;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("CapeloImpactReport", Namespace = "", IsNullable = false)]
    public partial class CapeloImpactReportType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? ResultCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? Diagnosis;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("Communication", Namespace = "", IsNullable = false)]
    public partial class CommunicationType
    {
        public string? PhoneNbr;

        public string? GSMNbr;

        public string? FaxNbr;

        public string? EmailAddress;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ConcernedQuarter", Namespace = "", IsNullable = false)]
    public partial class ConcernedQuarterType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? Quarter;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ConstructionControlCards", Namespace = "", IsNullable = false)]
    public partial class ConstructionControlCardsType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? FirstMonthC32ANbr;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? NextMonthC32ANbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("DailyRegistration", Namespace = "", IsNullable = false)]
    public partial class DailyRegistrationType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? DailyRegistrationId;

        [XmlElementAttribute(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElementAttribute(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string? StartingHour;

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public System.DateTime EndingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EndingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? EndingHour;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? IsCancelled;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime LastUpdateDate;

        /// <remarks/>
        [XmlElementAttribute(DataType = "time")]
        public System.DateTime LastUpdateHour;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("DailyRegistrationAfter", Namespace = "", IsNullable = false)]
    public partial class DailyRegistrationAfterType
    {
        [XmlElementAttribute(DataType = "date")]
        public DateTime StartingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? StartingHour;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime EndingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EndingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? EndingHour;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DailyRegistrationBefore", Namespace = "", IsNullable = false)]
    public partial class DailyRegistrationBeforeType
    {
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime StartingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? StartingHour;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime EndingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EndingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? EndingHour;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("DataValue", Namespace = "", IsNullable = false)]
    public partial class DataValueType
    {
        public string? FieldName;

        public string? NewValue;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DeclarationComplInformations", Namespace = "", IsNullable = false)]
    public partial class DeclarationComplInformationsType
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
    public partial class DimonaPeriodAfterType
    {
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime StartingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? StartingHour;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime EndingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EndingDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? EndingHour;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? ServiceType;

        /// <remarks/>
        [XmlElementAttribute("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElement("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string? Item;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType { PlannedDaysNbr, PlannedHoursNbr }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("DimonaPeriodBefore", Namespace = "", IsNullable = false)]
    public partial class DimonaPeriodBeforeType
    {
        [XmlElementAttribute(DataType = "date")]
        public DateTime StartingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? StartingHour;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime EndingDate;

        [XmlIgnoreAttribute()]
        public bool EndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? EndingHour;

        [XmlElement(DataType = "integer")]
        public string? ServiceType;


        [XmlElementAttribute("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string? Item;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType1 { PlannedDaysNbr, PlannedHoursNbr, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("DmfADimonaConfrontation", Namespace = "", IsNullable = false)]
    public partial class DmfADimonaConfrontationType
    {
        [XmlElementAttribute("InQuotaPlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("StudentHoursNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("StudentNbrDays", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[]? Items;

        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType[]? ItemsElementName;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    { InQuotaPlannedHoursNbr, PlannedDaysNbr, StudentHoursNbr, StudentNbrDays, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("EmployerId", Namespace = "", IsNullable = false)]
    public partial class EmployerIdType
    {
        [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;

        [XmlElementAttribute(DataType = "integer")]
        public string? CompanyID;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType2
    { NOSSLPARegistrationNbr, NOSSRegistrationNbr, ProvisionalNSSONbr, }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum EmploymentNatur { EMPLOYEE, WORKER, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("FieldInformation", Namespace = "", IsNullable = false)]
    public partial class FieldInformationType
    {
        public string? FieldName;

        public string? Value;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("FileReceptionInformation", Namespace = "", IsNullable = false)]
    public partial class FileReceptionInformationType
    {
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime ReceptionDate;

        [XmlElementAttribute(DataType = "time")]
        public System.DateTime ReceptionHour;

        [XmlElementAttribute(DataType = "integer")]
        public string? Channel;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("FileReference", Namespace = "", IsNullable = false)]
    public partial class FileReferenceType
    {
        public string? FileName;

        [XmlElementAttribute(DataType = "integer")]
        public string? ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("HandledOriginalForm", Namespace = "", IsNullable = false)]
    public partial class HandledOriginalFormType
    {
        public string? Identification;

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FormCreationDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime FormCreationHour;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormCreationHourSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? AttestationStatus;

        public TypeForm TypeForm;

        [XmlIgnoreAttribute()]
        public bool TypeFormSpecified;
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("HandledReference", Namespace = "", IsNullable = false)]
    public partial class HandledReferenceType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? ReferenceType;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? ReferenceOrigin;

        /// <remarks/>
        public string? ReferenceNbr;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("HandledSenderIdentification", Namespace = "", IsNullable = false)]
    public partial class HandledSenderIdentificationType
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


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("InvolvedPartner", Namespace = "", IsNullable = false)]
    public partial class InvolvedPartnerType
    {
        public PartnerRole PartnerRole;

        public SectorCode SectorCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? InstitutionType;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? KindOfDossierCBSS;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? INSSUser;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime DateSubmission;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DateSubmissionSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "time")]
        public System.DateTime HourSubmission;

        [XmlIgnoreAttribute()]
        public bool HourSubmissionSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime StartingDateRepository;

        [XmlIgnoreAttribute()]
        public bool StartingDateRepositorySpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime EndingDateRepository;

        [XmlIgnoreAttribute()]
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
        [XmlEnum("018")]
        Item018,

        [XmlEnum("025")]
        Item025,

        [XmlEnum("031")]
        Item031,

        [XmlEnum("053")]
        Item053,

        [XmlEnum("054")]
        Item054,

        [XmlEnum("055")]
        Item055,

        [XmlEnum("056")]
        Item056,
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("NaturalPerson", Namespace = "", IsNullable = false)]
    public partial class NaturalPersonType
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

        [XmlElementAttribute(DataType = "integer")]
        public string? Nationality;

        public string? NaturalPersonUserReference;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum NonSituableAbsenceCode
    {
        [XmlEnum("31")]
        Item31,

        [XmlEnum("32")]
        Item32,

        [XmlEnumAttribute("33")]
        Item33,

        [XmlEnumAttribute("41")]
        Item41,

        [XmlEnumAttribute("42")]
        Item42,

        [XmlEnumAttribute("43")]
        Item43,
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NOTIFICATION
    {
        [XmlElementAttribute("Form")]
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

        /// <remarks/>
        public FileReceptionInformationType? FileReceptionInformation;

        /// <remarks/>
        public HandledOriginalFile? HandledOriginalFile;

        /// <remarks/>
        public HandledOriginalFormType? HandledOriginalForm;

        [XmlElement("Reference")]
        public ReferenceType[]? Reference;

        public EmployerIdType? EmployerId;

        public NaturalPersonType? NaturalPerson;

        public ConcernedQuarterType? ConcernedQuarter;

        public HandledReferenceType? HandledReference;

        [XmlElementAttribute("WorkerRecordIdentification")]
        public WorkerRecordIdentification[]? WorkerRecordIdentification;

        /// <remarks/>
        public CBSSInformation? CBSSInformation;

        /// <remarks/>
        public DeclarationComplInformationsType? DeclarationComplInformations;

        /// <remarks/>
        public CoordinatesContactPerson? CoordinatesContactPerson;

        /// <remarks/>
        public HandlingResult? HandlingResult;

        /// <remarks/>
        public System.Xml.XmlElement? ApplicationData;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class HandledOriginalFile : HandledOriginalFileType
    {
        public HandledSenderIdentificationType? HandledSenderIdentification;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public partial class ReferenceType
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
    public partial class WorkerRecordIdentification : WorkerRecordIdentificationType
    {
        [XmlElement("OccupationReference")]
        public OccupationReferenceType[]? OccupationReference;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationReference", Namespace = "", IsNullable = false)]
    public partial class OccupationReferenceType
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
    public partial class CBSSInformation : CBSSInformationType
    {
        [XmlElement("InvolvedPartner")]
        public InvolvedPartnerType[]? InvolvedPartner;

        public HandledCBSSInformation? HandledCBSSInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class HandledCBSSInformation : HandledCBSSInformationType
    {
        [System.Xml.Serialization.XmlElementAttribute("DetailReturnCode")]
        public DetailReturnCode[]? DetailReturnCode;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class DetailReturnCode : DetailReturnCodeType
    {
        [XmlElement("FieldInformation")]
        public FieldInformationType[]? FieldInformation;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class CoordinatesContactPerson : CoordinatesContactPersonType
    {
        public CommunicationType? Communication;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class HandlingResult : HandlingResultType
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
    public partial class AnomalyReport : AnomalyReportType
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
    public partial class SystemCorrection : SystemCorrectionType
    {
        [XmlElement("BlockAction")]
        public BlockAction[]? BlockAction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class BlockAction : BlockActionType
    {
        [XmlElement("DataValue")]
        public DataValueType[]? DataValue;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Path", Namespace = "", IsNullable = false)]
    public partial class PathType
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


        public string JointCommissionNbr;


        [XmlElement(DataType = "integer")]
        public string? ActivityCode;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityAgreementNotion;

        /// <remarks/>
        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool HalfTimeCareerInterruptionNotionSpecified;

        /// <remarks/>
        public ServiceExemptionNotion ServiceExemptionNotion;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceExemptionNotionSpecified;

        /// <remarks/>
        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReplacementAccordanceWCCNotionSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionWorkerCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionType;

        /// <remarks/>
        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ComplIndemnityAmountAdjustNotionSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? EarlyRetirementCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? IndemnityNature;

        /// <remarks/>
        public string? IncapacityDegree;

        /// <remarks/>
        public string? NaturalPersonUserReference;

        /// <remarks/>
        public string? WorkerRecordUserReference;

        /// <remarks/>
        public string? OccupationUserReference;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? CompanyVehicleSequenceNbr;

        /// <remarks/>
        public string? NPCalculatedAmount;

        /// <remarks/>
        public string? CUNPCalculatedAmount;

        /// <remarks/>
        public string? WorksContractActorId;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationPSDStartDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccupationPSDStartDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? EmployerSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? CareerElementSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? PublicSectorInstitutionType;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? PublicSectorPersonnelCategory;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? AssignmentType;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? FunctionNature;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? ScaleSalarySequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ScaleSalaryStartDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleSalaryStartDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "gYearMonth")]
        public string? PecuniarySeniorityStartDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? SalaryScaleReference;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? AdditionalScaleSalarySequenceNbr;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? AdditionalScaleSalaryReference;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryStartDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool AdditionalScaleSalaryStartDateSpecified;

        /// <remarks/>
        public NonSituableAbsenceCode NonSituableAbsenceCode;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool NonSituableAbsenceCodeSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string? CalendarYear;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime StartingDate;


        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType5
    {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AnomalyComplInformation : AnomalyComplInformationType
    {
        public DmfADimonaConfrontationType? DmfADimonaConfrontation;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DimonaPeriod")]
        public DimonaPeriod[]? DimonaPeriod;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QuotaFeatures")]
        public QuotaFeaturesType[]? QuotaFeatures;

        /// <remarks/>
        public DailyRegistrationType? DailyRegistration;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DimonaPeriod : DimonaPeriodType
    {
        public DimonaFeatures? DimonaFeatures;

        public ConstructionControlCardsType? ConstructionControlCards;

        public StudentPlaceOfWork? StudentPlaceOfWork;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DimonaFeatures : DimonaFeaturesType
    {
        public UsingEmployer? UsingEmployer;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class UsingEmployer : UsingEmployerType
    {
        public AddressType? Address;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class StudentPlaceOfWork : StudentPlaceOfWorkType
    {
        public AddressType? Address;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("QuotaFeatures", Namespace = "", IsNullable = false)]
    public partial class QuotaFeaturesType
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
        A17_PUBTV,
        A17_YEAR_SPORT,
        A17_QUARTER_SPORT,
        A17_STUDENT_SPORT,
        A17_YEAR_OTHER,
        A17_QUARTER_OTHER,
        A17_STUDENT_OTHER,
        ARTICLE17,
        STUDENT,
        HORECA_EMPLOYER,
        HORECA_WORKER,
    }

    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType7
    {
        ExceedingDaysNbr,
        ExceedingHoursNbr,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class ImpactReport : ImpactReportType
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
    public partial class DimonaImpactReport : DimonaImpactReportType
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
    public partial class SmallStatutesInformationType
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
    public partial class AVWDDTImpactReport : AVWDDTImpactReportType
    {
        public AddressType? Address;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class DailyRegistrationDclImpactReport : DailyRegistrationDclImpactReportType
    {
        public DailyRegistrationBeforeType DailyRegistrationBefore;

        public DailyRegistrationAfterType DailyRegistrationAfter;
    }
}