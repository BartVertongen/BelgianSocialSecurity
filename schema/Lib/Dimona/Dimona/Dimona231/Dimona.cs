
using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DimonaUpdateType
    {
        [XmlElement(DataType = "integer")]
        public string DimonaPeriodId;


        [XmlElement(DataType = "date")]
        public DateTime StartingDate;


        [XmlIgnore()]
        public bool StartingDateSpecified;


        [XmlElement(DataType = "integer")]
        public string StartingHour;


        [XmlElement(DataType = "date")] public DateTime EndingDate;


        [XmlIgnore()] public bool EndingDateSpecified;


        [XmlElement(DataType = "integer")]
        public string EndingHour;


        [XmlElement(DataType = "integer")]
        public string INSS;


        [XmlElement("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElement("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item;

        [XmlIgnore()] public ItemChoiceType2 ItemElementName;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DimonaOutType
    {
        [XmlElement(DataType = "integer")]
        public string DimonaPeriodId;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlElement(DataType = "integer")]
        public string INSS;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class StudentPlaceOfWorkType
    {
        public string Denomination;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class UsingEmployerType
    {
        public JointCommissionNbr JointCommissionNbr;
        [XmlIgnoreAttribute()]
        public bool JointCommissionNbrSpecified;

        public string UsingEmployerName;

        [XmlElement(DataType = "integer")]
        public string UsingEmployerCompanyID;

        public string VATNbr;

        [XmlElement(DataType = "integer")]
        public string INSS;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DailyContractNbr;
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


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class DimonaFeaturesType
    {
        public JointCommissionNbr JointCommissionNbr;

        [XmlIgnore()] public bool JointCommissionNbrSpecified;

        public WorkerType WorkerType;

        [XmlElement(DataType = "integer")]
        public string SubEntityNbr;
    }


    /*[System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public enum WorkerType
    {
        A17,
        ALT,
        BCW,
        DWD,
        EXT,
        FLX,
        IVT,
        O17,
        PMP,
        RTA,
        S17,
        STU,
        T17,
        TEA,
        TRI,
        STG,
        OTH,
    }*/

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class DimonaInType
    {
        [XmlElementAttribute(DataType = "date")]
        public DateTime StartingDate;

        [XmlElementAttribute(DataType = "integer")]
        public string StartingHour;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime EndingDate;

        [XmlIgnoreAttribute()]
        public bool EndingDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string EndingHour;

        [XmlElementAttribute("PlannedDaysNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("PlannedHoursNbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;


        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }


    /*[System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("ConstructionControlCards", Namespace = "", IsNullable = false)]
    public class ConstructionControlCardsType
    {
        [XmlElement(DataType = "integer")]
        public string FirstMonthC32ANbr;

        [XmlElement(DataType = "integer")]
        public string NextMonthC32ANbr;
    }*/


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Dimona
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
        [XmlElement("Reference")]
        public ReferenceType[] Reference;

        [XmlElementAttribute("DailyRegistrationDeclaration", typeof(DailyRegistrationDeclarationType))]
        [XmlElementAttribute("DimonaCancel", typeof(DimonaCancel))]
        [XmlElementAttribute("DimonaIn", typeof(DimonaIn))]
        [XmlElementAttribute("DimonaOut", typeof(DimonaOut))]
        [XmlElementAttribute("DimonaUpdate", typeof(DimonaUpdate))]
        public object Item;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EmployerId", Namespace = "dimona231", IsNullable = false)]
    public class EmployerIdType
    {
        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item;

        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName;

        [XmlElement(DataType = "integer")]
        public string CompanyID;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DimonaIn : DimonaInType
    {
        public EmployerIdType EmployerId;

        public NaturalPersonType NaturalPerson;

        public DimonaFeatures DimonaFeatures;

        public ConstructionControlCardsType ConstructionControlCards;

        public StudentPlaceOfWork StudentPlaceOfWork;

        public SmallStatutesInformationType SmallStatutesInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("NaturalPerson", Namespace = "", IsNullable = false)]
    public class NaturalPersonType
    {
        [XmlElement(DataType = "integer")]
        public string NaturalPersonSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string INSS;

        [XmlElement(DataType = "integer")]
        public string SIS;

        public string WorkerName;

        public string WorkerFirstName;

        public string WorkerInitial;

        public string WorkerBirthdate;

        public string WorkerBirthplace;

        [XmlElement(DataType = "integer")]
        public string WorkerBirthplaceCountry;

        [XmlElement(DataType = "integer")]
        public string WorkerSex;

        public string WorkerStreet;

        public string WorkerHouseNbr;

        public string WorkerPostBox;

        public string WorkerZIPCode;

        public string WorkerCity;

        [XmlElement(DataType = "integer")]
        public string WorkerCountry;

        [XmlElement(DataType = "integer")]
        public string Nationality;

        public string NaturalPersonUserReference;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DimonaFeatures : DimonaFeaturesType
    {
        public UsingEmployer UsingEmployer;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class UsingEmployer : UsingEmployerType
    {
        public AddressType Address;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class StudentPlaceOfWork : StudentPlaceOfWorkType
    {
        public AddressType Address;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("SmallStatutesInformation", Namespace = "", IsNullable = false)]
    public class SmallStatutesInformationType
    {
        public EmploymentNature EmploymentNature;

        [XmlElement(DataType = "integer")]
        public string ActivityWithRisk;

        public WorkerStatus WorkerStatus;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum EmploymentNature
    {
        EMPLOYEE,
        WORKER,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum WorkerStatus { F1, F2 }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DimonaUpdate : DimonaUpdateType
    {
        public EmployerIdType EmployerId;
    }
}