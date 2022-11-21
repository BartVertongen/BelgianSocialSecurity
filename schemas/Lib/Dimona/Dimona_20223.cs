﻿//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;

namespace VertSoft.BelgianHR.Xml.Dimona
{ 
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

        [XmlElementAttribute(DataType = "integer")]
        public string? Country;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class DimonaCancelType
    {
        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElement(DataType = "integer")]
        public string? INSS;

    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class DimonaUpdateType
    {
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
        public string? INSS;

        [XmlElement("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElement("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType2 ItemElementName;
    }

    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType2 { PlannedDaysNbr, PlannedHoursNbr, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class DimonaOutType
    {
        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlElement(DataType = "integer")]
        public string? INSS;
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
        [XmlEnum("124")]
        Item124,

        [XmlEnum("140")]
        Item140,

        [XmlEnum("144")]
        Item144,

        [XmlEnum("145")]
        Item145,

        [XmlEnumAttribute("149")]
        Item149,

        [XmlEnumAttribute("302")]
        Item302,

        [XmlEnumAttribute("320")]
        Item320,

        [XmlEnum("322")]
        Item322,

        XXX,
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DimonaFeaturesType
    {
        public JointCommissionNbr JointCommissionNbr;

        [XmlIgnoreAttribute()]
        public bool JointCommissionNbrSpecified;

        public WorkerType WorkerType;

        [XmlElement(DataType = "integer")]
        public string? SubEntityNbr;
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum WorkerType
    {
        A17,
        BCW,
        DWD,
        EXT,
        FLX,
        IVT,
        O17,
        PMP,
        QUA,
        RTA,
        S17,
        STU,
        T17,
        TEA,
        TRI,
        STG,
        OTH,
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DimonaInType
    {
        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlElementAttribute(DataType = "integer")]
        public string? StartingHour;

        [XmlElementAttribute(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnoreAttribute()]
        public bool EndingDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string? EndingHour;

        [XmlElementAttribute("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string? Item;


        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType { PlannedDaysNbr, PlannedHoursNbr, }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FormType
    {
        public Identification Identification;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FormCreationDate;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime FormCreationHour;

        public AttestationStatus AttestationStatus;

        public TypeForm TypeForm;
    }

    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum Identification { DIMONA, }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    {
        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,

        [XmlEnum("3")]
        Item3,
    }

    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { SU, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ConstructionControlCards", Namespace = "", IsNullable = false)]
    public partial class ConstructionControlCardsType
    {
        [XmlElement(DataType = "integer")]
        public string? FirstMonthC32ANbr;

        [XmlElement(DataType = "integer")]
        public string? NextMonthC32ANbr;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("DailyRegistrationDeclaration", Namespace = "", IsNullable = false)]
    public partial class DailyRegistrationDeclarationType
    {
        public AttestationStatus AttestationStatus;

        [XmlElementAttribute(DataType = "integer")]
        public string? DailyRegistrationId;

        [XmlElementAttribute(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime StartingDate;

        [XmlIgnoreAttribute()]
        public bool StartingDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string? StartingHour;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;


        [XmlElement(DataType = "integer")]
        public string? EndingHour;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Dimona
    {
        [XmlElementAttribute("Form")]
        public Form[]? Form;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Form : FormType
    {
        [XmlElement("Reference")]
        public ReferenceType[]? Reference;

        [XmlElement("DailyRegistrationDeclaration", typeof(DailyRegistrationDeclarationType))]
        [XmlElement("DimonaCancel", typeof(DimonaCancel))]
        [XmlElement("DimonaIn", typeof(DimonaIn))]
        [XmlElement("DimonaOut", typeof(DimonaOut))]
        [XmlElement("DimonaUpdate", typeof(DimonaUpdate))]
        public object? Item;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
        [XmlEnumAttribute("1")]
        Item1,

        [XmlEnumAttribute("6")]
        Item6,

        [XmlEnumAttribute("7")]
        Item7,

        [XmlEnumAttribute("8")]
        Item8,
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnum("1")]
        Item1,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class DimonaCancel : DimonaCancelType
    {
        public EmployerIdType? EmployerId;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("EmployerId", Namespace = "", IsNullable = false)]
    public partial class EmployerIdType
    {
        [XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string? Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;

        [XmlElementAttribute(DataType = "integer")]
        public string? CompanyID;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType1
    {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
        ProvisionalNSSONbr,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class DimonaIn : DimonaInType
    {
        public EmployerIdType? EmployerId;

        public NaturalPersonType? NaturalPerson;

        public DimonaFeatures? DimonaFeatures;

        public ConstructionControlCardsType? ConstructionControlCards;

        public StudentPlaceOfWork? StudentPlaceOfWork;

        public SmallStatutesInformationType? SmallStatutesInformation;
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

        [XmlElement(DataType = "integer")]
        public string? Nationality;

        public string? NaturalPersonUserReference;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
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


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class StudentPlaceOfWork : StudentPlaceOfWorkType
    {
        public AddressType? Address;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("SmallStatutesInformation", Namespace = "", IsNullable = false)]
    public partial class SmallStatutesInformationType
    {
        public EmploymentNature EmploymentNature;

        [XmlElement(DataType = "integer")]
        public string? ActivityWithRisk;

        public WorkerStatus WorkerStatus;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum EmploymentNature
    {EMPLOYEE, WORKER,}


    [SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum WorkerStatus { F1, F2, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class DimonaOut : DimonaOutType
    {
        public EmployerIdType? EmployerId;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class DimonaUpdate : DimonaUpdateType
    {
        public EmployerIdType? EmployerId;
    }
}