// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.IDFLUX223
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    {
        [XmlEnum("0")]
        Item0,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,
    };


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EmployerId", Namespace = "", IsNullable = false)]
    public class EmployerIdType
    {
        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
        ProvisionalNSSONbr,
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class IdfluxInformationType
    {
        public JustificationCode JustificationCode;

        [XmlElement(DataType = "date")]
        public DateTime EffectiveStartingDate;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum JustificationCode
    {
        [XmlEnum("90")] Item90,

        [XmlEnum("91")] Item91,

        [XmlEnum("92")] Item92,

        [XmlEnum("93")] Item93,
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
    public enum Identification { IDFLUX, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { SU, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Form : FormType
    {
        public ReferenceType? Reference;

        public IdfluxInformation? IdfluxInformation;
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
    { [XmlEnum("1")] Item1, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnum("2")]
        Item2,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class IdfluxInformation : IdfluxInformationType
    {
        public EmployerIdType? EmployerId;

        public ValidSituationType? ValidSituation;

        public OutdatedSituationType? OutdatedSituation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ValidSituation", Namespace = "", IsNullable = false)]
    public class ValidSituationType
    {
        [XmlElement("INSS", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("WorkerBirthdate", typeof(string))]
        [XmlElement("WorkerFirstName", typeof(string))]
        [XmlElement("WorkerName", typeof(string))]
        [XmlElement("WorkerSex", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;


        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[]? ItemsElementName;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        INSS,
        NOSSRegistrationNbr,
        WorkerBirthdate,
        WorkerFirstName,
        WorkerName,
        WorkerSex,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OutdatedSituation", Namespace = "", IsNullable = false)]
    public class OutdatedSituationType
    {
        [XmlElement("INSS", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("WorkerBirthdate", typeof(string))]
        [XmlElement("WorkerFirstName", typeof(string))]
        [XmlElement("WorkerName", typeof(string))]
        [XmlElement("WorkerSex", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType1[]? ItemsElementName;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        INSS,
        NOSSRegistrationNbr,
        WorkerBirthdate,
        WorkerFirstName,
        WorkerName,
        WorkerSex,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class IDFLUX
    {
        public Form? Form;
    }
}