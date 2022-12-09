

using System.Xml.Serialization;

namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CompanyVehicleID", Namespace = "", IsNullable = false)]
    public class CompanyVehicleIDType
    {
        public string? LicensePlate;

        [XmlElement(DataType = "integer")]
        public string? CompanyVehicleVersionNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class IDWorkerRecordType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "integer")]
        public string? WorkerRecordVersionNbr;

        public string? WorkerRecordUserReference;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class IDNaturalPersonType
    {
        [XmlElement(DataType = "integer")]
        public string? INSS;

        public string? NaturalPersonUserReference;

        [XmlElement(DataType = "integer")]
        public string? NaturalPersonPID;

        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonPID;

        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonVersionNbr;

        public string? OriginalDeclaredWorkerName;

        public string? OriginalDeclaredWorkerFirstName;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class IDEmployerDeclarationType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("Trusteeship", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[]? ItemsElementName;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "integer")]
        public string? EmployerDeclarationPID;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType { NOSSLPARegistrationNbr, NOSSRegistrationNbr, Trusteeship }


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

        [XmlElement(DataType = "integer")]
        public string? AttestationStatus;

        public TypeForm TypeForm;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum Identification { DMFAPID }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { SU }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DmfAPID
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

        public IDEmployerDeclaration? IDEmployerDeclaration;
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


    [SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    [XmlRoot("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("3")] Item3,
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnumAttribute("1")] Item1,

        [XmlEnumAttribute("2")] Item2,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class IDEmployerDeclaration : IDEmployerDeclarationType
    {
        [XmlElementAttribute("IDNaturalPerson")]
        public IDNaturalPerson[]? IDNaturalPerson;

        [XmlElementAttribute("IDContUnrelatedToNP")]
        public IDContUnrelatedToNPType[]? IDContUnrelatedToNP;

        [XmlElementAttribute("CompanyVehicleID")]
        public CompanyVehicleIDType[]? CompanyVehicleID;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IDNaturalPerson : IDNaturalPersonType
    {
        [System.Xml.Serialization.XmlElementAttribute("IDWorkerRecord")]
        public IDWorkerRecord[]? IDWorkerRecord;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IDWorkerRecord : IDWorkerRecordType
    {
        [System.Xml.Serialization.XmlElementAttribute("IDOccupation")]
        public IDOccupationType[] IDOccupation;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("IDOccupation", Namespace = "", IsNullable = false)]
    public class IDOccupationType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? OccupationSequenceNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string? OccupationVersionNbr;

        public string? OccupationUserReference;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("IDContUnrelatedToNP", Namespace = "", IsNullable = false)]
    public class IDContUnrelatedToNPType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        [XmlElementAttribute(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? ContUnrelatedToNPVersionNbr;
    }
}