

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX231
{
    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("EmployerId", Namespace = "", IsNullable = false)]
    public class EmployerIdType
    {
        [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        [XmlElementAttribute(DataType = "integer")]
        public string CompanyID;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
        ProvisionalNSSONbr,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class IdfluxInformationType
    {
        public JustificationCode JustificationCode;

        [XmlElement(DataType = "date")]
        public DateTime EffectiveStartingDate;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum JustificationCode
    {
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,

        [System.Xml.Serialization.XmlEnumAttribute("91")]
        Item91,

        [System.Xml.Serialization.XmlEnumAttribute("92")]
        Item92,

        [System.Xml.Serialization.XmlEnumAttribute("93")]
        Item93,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class FormType
    {
        public Identification Identification;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FormCreationDate;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime FormCreationHour;

        public AttestationStatus AttestationStatus;


        public TypeForm TypeForm;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum Identification { IDFLUX, }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Form : FormType
    {
        public ReferenceType Reference;

        public IdfluxInformation IdfluxInformation;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class IdfluxInformation : IdfluxInformationType
    {
        public EmployerIdType EmployerId;

        public ValidSituationType ValidSituation;

        public OutdatedSituationType OutdatedSituation;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ValidSituation", Namespace = "", IsNullable = false)]
    public class ValidSituationType
    {
        [XmlElementAttribute("INSS", typeof(string), DataType = "integer")]
        [XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("WorkerBirthdate", typeof(string))]
        [XmlElementAttribute("WorkerFirstName", typeof(string))]
        [XmlElementAttribute("WorkerName", typeof(string))]
        [XmlElementAttribute("WorkerSex", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName;
    }


    [SerializableAttribute()]
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


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("OutdatedSituation", Namespace = "", IsNullable = false)]
    public class OutdatedSituationType
    {
        [XmlElementAttribute("INSS", typeof(string), DataType = "integer")]
        [XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("WorkerBirthdate", typeof(string))]
        [XmlElementAttribute("WorkerFirstName", typeof(string))]
        [XmlElementAttribute("WorkerName", typeof(string))]
        [XmlElementAttribute("WorkerSex", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType1[] ItemsElementName;
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

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class IDFLUX
    {
        public Form Form;
    }
}