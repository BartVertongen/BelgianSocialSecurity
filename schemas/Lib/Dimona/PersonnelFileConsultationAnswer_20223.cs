﻿

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.PersonnelFileConsultationAnswer
{
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
    public partial class PersonnelFileConsultType
    {
        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType2? ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "date")]
        public DateTime? RefStartingDate;

        [XmlIgnore()]
        public bool RefStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime RefEndingDate;

        [XmlIgnore()]
        public bool RefEndingDateSpecified;

        public ResultCodeResearch ResultCodeResearch;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType2
    { NOSSLPARegistrationNbr, NOSSRegistrationNbr, ProvisionalNSSONbr, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ResultCodeResearch
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("5")] Item5,
    }


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
    public enum Identification { PFANS, PFREQ, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    {
        [XmlEnum("0")] Item0,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { FA, RE, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class StudentPlaceOfWorkType
    {
        public string? Denomination;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DimonaPeriodType
    {
        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElement(DataType = "integer")]
        public string? IsLocked;

        [XmlElement(DataType = "integer")]
        public string? IsCancelled;

        public bool IsLate;

        [XmlIgnore()]
        public bool IsLateSpecified;

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

        [XmlElement(DataType = "date")]
        public DateTime LastUpdateDate;

        [XmlElement(DataType = "time")]
        public DateTime LastUpdateHour;

        [XmlElement("ErrorID")]
        public string[]? ErrorID;

        public string? AnomalyClass;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType { PlannedDaysNbr, PlannedHoursNbr }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class UsingEmployerType
    {
        public JointCommissionNbr JointCommissionNbr;

        [XmlIgnore()]
        public bool JointCommissionNbrSpecified;

        public string? UsingEmployerName;

        [XmlElement(DataType = "integer")]
        public string? UsingEmployerCompanyID;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum JointCommissionNbr
    {
        [XmlEnum("124")] Item124,

        [XmlEnum("140")] Item140,

        [XmlEnum("144")] Item144,

        [XmlEnum("145")] Item145,

        [XmlEnum("149")] Item149,

        [XmlEnum("302")] Item302,

        [XmlEnum("320")] Item320,

        [XmlEnum("322")] Item322,

        XXX,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DimonaFeaturesType
    {
        public JointCommissionNbr JointCommissionNbr;

        [XmlIgnore()]
        public bool JointCommissionNbrSpecified;

        public WorkerType WorkerType;

        [XmlIgnore()]
        public bool WorkerTypeSpecified;

        [XmlElement(DataType = "integer")]
        public string? SubEntityNbr;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum WorkerType { A17, BCW, DWD, EXT, FLX, IVT, O17
            , PMP, QUA, RTA, S17, STU, STX, T17, TEA, TRI, STG, OTH }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum CareerMeasure
    {
        [XmlEnum("2")] Item2,

        [XmlEnum("99")] Item99,
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
    public partial class UsingEmployer : UsingEmployerType
    {
        public AddressType? Address;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class DimonaPeriod : DimonaPeriodType
    {
        public NaturalPersonType? NaturalPerson;

        public DimonaFeatures? DimonaFeatures;

        public ConstructionControlCardsType? ConstructionControlCards;

        public StudentPlaceOfWork? StudentPlaceOfWork;

        public SmallStatutesInformationType? SmallStatutesInformation;

        [XmlElement("QuotaFeatures")]
        public QuotaFeaturesType[]? QuotaFeatures;

        [XmlElement("EmploymentMeasureInfo")]
        public EmploymentMeasureInfoType[]? EmploymentMeasureInfo;
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

        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerBirthplaceCountry;

        [XmlElementAttribute(DataType = "integer")]
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
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum EmploymentNature { EMPLOYEE, WORKER }


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
        public ItemChoiceType1 ItemElementName;
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
    public enum ItemChoiceType1 { ExceedingDaysNbr, ExceedingHoursNbr, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EmploymentMeasureInfo", Namespace = "", IsNullable = false)]
    public partial class EmploymentMeasureInfoType
    {
        public CareerMeasure CareerMeasure;

        [XmlIgnore()]
        public bool CareerMeasureSpecified;

        public ResultCode ResultCode;

        [XmlIgnore()]
        public bool ResultCodeSpecified;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ResultCode
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,
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
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Form : FormType
    {
        public FileReferenceType? FileReference;

        public HandledOriginalFormType? HandledOriginalForm;

        public ReferenceType? Reference;

        public HandledReferenceType? HandledReference;

        public PersonnelFileConsult? PersonnelFileConsult;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("HandledOriginalForm", Namespace = "", IsNullable = false)]
    public partial class HandledOriginalFormType
    {
        public Identification Identification;

        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        public AttestationStatus AttestationStatus;

        public TypeForm TypeForm;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public partial class ReferenceType
    {
        [XmlElementAttribute("ReferenceType")]
        public ReferenceType1 ReferenceType1;

        [XmlElementAttribute(DataType = "integer")]
        public string? ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1
    {
        [XmlEnum("1")]
        Item1,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("HandledReference", Namespace = "", IsNullable = false)]
    public partial class HandledReferenceType
    {
        public ReferenceType1 ReferenceType;

        [XmlElement(DataType = "integer")]
        public string? ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class PersonnelFileConsult : PersonnelFileConsultType
    {
        [XmlElement("DimonaPeriod")]
        public DimonaPeriod[]? DimonaPeriod;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class PersonnelFileConsultationAnswer
    {
        public Form? Form;
    }

}