

using System.Xml.Serialization;


[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("Address", Namespace="", IsNullable=false)]
public partial class AddressType
{
    public string? Street;

    /// <remarks/>
    public string? HouseNbr;

    /// <remarks/>
    public string? PostBox;

    /// <remarks/>
    public string? ZIPCode;

    /// <remarks/>
    public string? City;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string? Country;
}

[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PersonnelFileConsultType
{
    [XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType="integer")]
    [XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType="integer")]
    [XmlElementAttribute("ProvisionalNSSONbr", typeof(string), DataType="integer")]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string? Item;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public ItemChoiceType2? ItemElementName;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? CompanyID;

    /// <remarks/>
    [XmlElementAttribute(DataType = "date")]
    public System.DateTime? RefStartingDate;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool RefStartingDateSpecified;

    /// <remarks/>
    [XmlElementAttribute(DataType = "date")]
    public System.DateTime RefEndingDate;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool RefEndingDateSpecified;

    /// <remarks/>
    public ResultCodeResearch ResultCodeResearch;
}


[System.SerializableAttribute()]
[XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType2 {
    NOSSLPARegistrationNbr,
    NOSSRegistrationNbr,
    ProvisionalNSSONbr,
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum ResultCodeResearch {
    [XmlEnumAttribute("0")]
    Item0,

    [XmlEnumAttribute("1")]
    Item1,

    [XmlEnumAttribute("5")]
    Item5,
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FormType
{
    public Identification Identification;
    
    /// <remarks/>
    [XmlElementAttribute(DataType = "date")]
    public System.DateTime FormCreationDate;
    
    /// <remarks/>
    [XmlElementAttribute(DataType = "time")]
    public System.DateTime FormCreationHour;

    /// <remarks/>
    public AttestationStatus AttestationStatus;

    /// <remarks/>
    public TypeForm TypeForm;
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Identification { PFANS, PFREQ, }


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum AttestationStatus {
    [XmlEnumAttribute("0")]
    Item0,
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum TypeForm { FA, RE, }


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class StudentPlaceOfWorkType
{
    public string? Denomination;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DimonaPeriodType
{
    [XmlElementAttribute(DataType = "integer")]
    public string? DimonaPeriodId;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? IsLocked;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? IsCancelled;
    
    /// <remarks/>
    public bool IsLate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsLateSpecified;

    /// <remarks/>
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

    [XmlElementAttribute(DataType = "integer")]
    public string? EndingHour;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? ServiceType;

    /// <remarks/>
    [XmlElementAttribute("PlannedDaysNbr", typeof(string), DataType = "integer")]
    [XmlElementAttribute("PlannedHoursNbr", typeof(string), DataType = "integer")]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string? Item;
    
    /// <remarks/>
    [XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")] 
    public System.DateTime LastUpdateDate;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime LastUpdateHour;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ErrorID")]
    public string[]? ErrorID;

    /// <remarks/>
    public string? AnomalyClass;
}


[SerializableAttribute()]
[XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType { PlannedDaysNbr, PlannedHoursNbr }


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class UsingEmployerType
{
    public JointCommissionNbr JointCommissionNbr;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool JointCommissionNbrSpecified;

    /// <remarks/>
    public string? UsingEmployerName;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? UsingEmployerCompanyID;
}


[Serializable()]
[XmlType(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum JointCommissionNbr
{
    [XmlEnumAttribute("124")]
    Item124,
    
    [XmlEnumAttribute("140")]
    Item140,
    
    [XmlEnumAttribute("144")] Item144,
    
    [XmlEnumAttribute("145")] Item145,
    
    [XmlEnumAttribute("149")] Item149,
    
    [XmlEnumAttribute("302")] Item302,
    
    [XmlEnumAttribute("320")] Item320,
    
    [XmlEnumAttribute("322")] Item322,
    
    XXX,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DimonaFeaturesType
{
    public JointCommissionNbr JointCommissionNbr;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool JointCommissionNbrSpecified;

    /// <remarks/>
    public WorkerType WorkerType;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool WorkerTypeSpecified;

    [XmlElementAttribute(DataType = "integer")]
    public string? SubEntityNbr;
}


[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum WorkerType { A17, BCW, DWD, EXT, FLX, IVT, O17
        , PMP, QUA, RTA, S17, STU, STX, T17, TEA, TRI, STG, OTH }


[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum CareerMeasure {
    [XmlEnum("2")]
    Item2,

    [XmlEnum("99")]
    Item99,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("ConstructionControlCards", Namespace="", IsNullable=false)]
public partial class ConstructionControlCardsType 
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string? FirstMonthC32ANbr;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? NextMonthC32ANbr;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DimonaFeatures : DimonaFeaturesType
{
    public UsingEmployer? UsingEmployer;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public partial class UsingEmployer : UsingEmployerType
{
    public AddressType? Address;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DimonaPeriod : DimonaPeriodType
{
    public NaturalPersonType? NaturalPerson;

    public DimonaFeatures? DimonaFeatures;

    public ConstructionControlCardsType? ConstructionControlCards;

    public StudentPlaceOfWork? StudentPlaceOfWork;

    public SmallStatutesInformationType? SmallStatutesInformation;

    [XmlElementAttribute("QuotaFeatures")]
    public QuotaFeaturesType[]? QuotaFeatures;

    [XmlElementAttribute("EmploymentMeasureInfo")]
    public EmploymentMeasureInfoType[]? EmploymentMeasureInfo;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("NaturalPerson", Namespace="", IsNullable=false)]
public partial class NaturalPersonType
{
    [XmlElementAttribute(DataType = "integer")]
    public string? NaturalPersonSequenceNbr;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? INSS;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? SIS;

    /// <remarks/>
    public string? WorkerName;

    /// <remarks/>
    public string? WorkerFirstName;

    /// <remarks/>
    public string? WorkerInitial;

    /// <remarks/>
    public string? WorkerBirthdate;

    /// <remarks/>
    public string? WorkerBirthplace;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? WorkerBirthplaceCountry;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string? WorkerSex;

    /// <remarks/>
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
}


[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public partial class StudentPlaceOfWork : StudentPlaceOfWorkType
{
    public AddressType? Address;
}


[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlRoot("SmallStatutesInformation", Namespace="", IsNullable=false)]
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
[XmlType(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public enum EmploymentNature { EMPLOYEE, WORKER }


[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlRoot("QuotaFeatures", Namespace="", IsNullable=false)]
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
[XmlType(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public enum QuotaType {
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
[XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType1 { ExceedingDaysNbr, ExceedingHoursNbr, }


[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlRoot("EmploymentMeasureInfo", Namespace="", IsNullable=false)]
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
[XmlType(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public enum ResultCode {
    [XmlEnum("0")]
    Item0,

    [XmlEnum("1")]
    Item1,
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategory("code")]
[XmlRoot("FileReference", Namespace="", IsNullable=false)]
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
[XmlType(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public partial class Form : FormType
{
    public FileReferenceType? FileReference;

    public HandledOriginalFormType? HandledOriginalForm;

    public ReferenceType? Reference;

    public HandledReferenceType? HandledReference;

    public PersonnelFileConsult? PersonnelFileConsult;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("HandledOriginalForm", Namespace="", IsNullable=false)]
public partial class HandledOriginalFormType
{
    public Identification Identification;

    [XmlElement(DataType = "date")]
    public DateTime FormCreationDate;

    [XmlElementAttribute(DataType = "time")]
    public DateTime FormCreationHour;

    public AttestationStatus AttestationStatus;
    
    public TypeForm TypeForm;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRoot("Reference", Namespace="", IsNullable=false)]
public partial class ReferenceType
{
    [XmlElementAttribute("ReferenceType")]
    public ReferenceType1 ReferenceType1;

    [XmlElementAttribute(DataType = "integer")]
    public string? ReferenceOrigin;

    public string? ReferenceNbr;
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute("ReferenceType", Namespace="", IsNullable=false)]
public enum ReferenceType1 {
    [XmlEnum("1")]
    Item1,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRoot("HandledReference", Namespace="", IsNullable=false)]
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
[XmlType(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public class PersonnelFileConsult : PersonnelFileConsultType
{
    [XmlElement("DimonaPeriod")]
    public DimonaPeriod[]? DimonaPeriod;
}


[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public class PersonnelFileConsultationAnswer
{
    public Form? Form;
}
