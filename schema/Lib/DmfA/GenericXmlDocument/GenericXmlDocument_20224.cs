//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("AddresseeData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class AddresseeDataType
    {
        public string? Addressee;

        public string? AddresseeType;

        public string? AddresseeQuality;

        public string? Identification;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class ProcessingDataType
    { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class ReferenceDataType
    {
        [XmlElement(DataType = "integer")]
        public string? INSS;

        [XmlElementAttribute("Quarter", DataType = "integer")]
        public string[]? Quarter;

        public string? GroupName;

        [XmlElement(DataType = "integer")]
        public string? FormSequenceNbr;

        public bool IsLastForm;

        [XmlIgnore()]
        public bool IsLastFormSpecified;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class HandledSenderIdentificationType
    {
        [XmlElement(DataType = "integer")]
        public string CompanyID;

        [XmlElement(DataType = "integer")]
        public string NOSSRegistrationNbr;

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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public  class HandledOriginalFileType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? SenderId;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class FormType
    {
        public string? Identification;

        [XmlElement(DataType = "date")]
        public System.DateTime FormCreationDate;

        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        [XmlElement(DataType = "integer")]
        public string? AttestationStatus;

        public TypeForm TypeForm;
    }


    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum TypeForm { RE, PA, FA, LA, SU }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class EmployerIdType
    {

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        private string companyIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CompanyID;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IncludeInSchema = false)]
    public enum ItemChoiceType1 { NOSSLPARegistrationNbr, NOSSRegistrationNbr, ProvisionalNSSONbr }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DocumentDataType
    {

        private System.DateTime documentDateField;

        private bool documentDateFieldSpecified;

        private string documentReferenceField;

        private string iNSSField;

        private string companyIDField;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime DocumentDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DocumentDateSpecified;

        /// <remarks/>
        public string DocumentReference;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string INSS;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CompanyID;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DestinationDataType
    {
        public DestinationType DestinationType;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DestinationType {
        DESTHA, DESTHAFOREMPLOYER, SUIVIFOREMPLOYER, SUIVI,
        CONTRACTUALRELATIONSHIPREGISTRY, ENTREPRISE, CLC,
        SMALS, DOCUMENTSENDINGDATA, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class MandateCriteriaType
    {
        [System.Xml.Serialization.XmlElementAttribute("Date", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("MandateType", typeof(MandateType))]
        [System.Xml.Serialization.XmlElementAttribute("Quarter", typeof(string), DataType = "integer")]
        public object Item;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum MandateType { ReferenceData }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public partial class DestinationCriteriaType
    {
        [XmlElement(DataType = "integer")]
        public string ReferenceType;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class TechnicalDescriptionType
    {
        public MimeType MimeType;

        public CharacterSet CharacterSet;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharacterSetSpecified;

        public CharacterFormat CharacterFormat;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Language;

        public string FileName;

        public DocumentType DocumentType;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentTypeSpecified;

        public string AttachmentId;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum MimeType
    {
        [System.Xml.Serialization.XmlEnumAttribute("application/pdf")]
        applicationpdf,

        [System.Xml.Serialization.XmlEnumAttribute("application/xml")]
        applicationxml,

        [System.Xml.Serialization.XmlEnumAttribute("application/msword")]
        applicationmsword,

        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        applicationvndopenxmlformatsofficedocumentwordprocessingmldocument,

        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-excel")]
        applicationvndmsexcel,

        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        applicationvndopenxmlformatsofficedocumentspreadsheetmlsheet,

        [System.Xml.Serialization.XmlEnumAttribute("application/zip")]
        applicationzip,

        [System.Xml.Serialization.XmlEnumAttribute("image/jpeg")]
        imagejpeg,

        [System.Xml.Serialization.XmlEnumAttribute("image/tiff")]
        imagetiff,

        [System.Xml.Serialization.XmlEnumAttribute("text/plain")]
        textplain,

        application,

        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.oasis.opendocument.text")]
        applicationvndoasisopendocumenttext,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CharacterSet
    {
        [XmlEnumAttribute("UTF-8")] UTF8,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CharacterFormat { NATIVE, Base64, }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentType { MAIN, ATTACHMENT, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DocumentDescriptionType
    { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DataType
    { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class SpecificIndexDataType
    { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class CaseDataType
    {

        private NSSOService nSSOServiceField;

        private bool nSSOServiceFieldSpecified;

        private System.DateTime creationDateField;

        private bool creationDateFieldSpecified;

        private CaseSubType caseSubTypeField;

        private bool caseSubTypeFieldSpecified;

        private string caseIdField;

        private ProcessType processTypeField;

        private bool processTypeFieldSpecified;

        /// <remarks/>
        public NSSOService NSSOService;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NSSOServiceSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime CreationDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationDateSpecified;

        /// <remarks/>
        public CaseSubType CaseSubType;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CaseSubTypeSpecified;

        /// <remarks/>
        public string CaseId;

        /// <remarks/>
        public ProcessType ProcessType;

        [XmlIgnoreAttribute()]
        public bool ProcessTypeSpecified;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum NSSOService { INNI, REJU, RIPAD }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CaseSubType
    {
        TYP_SC_026,
        TYP_SC_119,
        TYP_SC_214,

        /// <remarks/>
        TYP_SC_215,

        /// <remarks/>
        TYP_SC_216,

        /// <remarks/>
        TYP_SC_217,

        /// <remarks/>
        TYP_SC_246,

        /// <remarks/>
        TYP_SC_247,

        /// <remarks/>
        TYP_SC_283,

        /// <remarks/>
        TYP_SC_284,

        /// <remarks/>
        TYP_SC_502,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum ProcessType { SUBMITDOCUMENT, SUBMITCASEID, SUBMITARCHIVE }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class AssignedUserDataType
    { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("AssignedUserCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class AssignedUserCriteriaType
    {
        public string AssignedUserType;

        /// <remarks/>
        public string AssignedUserId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class AssignedUserData : AssignedUserDataType
    {

        private AssignedUserCriteriaType assignedUserCriteriaField;

        /// <remarks/>
        public AssignedUserCriteriaType AssignedUserCriteria;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class CaseData : CaseDataType
    {

        private CaseStatusDataType caseStatusDataField;

        private CaseReferenceDataType[] caseReferenceDataField;

        private SpecificIndexData specificIndexDataField;

        private AssignedUserData assignedUserDataField;

        /// <remarks/>
        public CaseStatusDataType CaseStatusData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseReferenceData")]
        public CaseReferenceDataType[] CaseReferenceData;

        /// <remarks/>
        public SpecificIndexData SpecificIndexData;

        /// <remarks/>
        public AssignedUserData AssignedUserData;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("CaseStatusData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CaseStatusDataType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DueDate;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("CaseReferenceData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class CaseReferenceDataType
    {
        public string ReferenceNbr;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CaseReferenceType { PRODUCER_REF, NOSS_REF, EXTERNAL_REF }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SpecificIndexData : SpecificIndexDataType
    {
        [System.Xml.Serialization.XmlElementAttribute("SpecificIndexCriteria")]
        public SpecificIndexCriteriaType[] SpecificIndexCriteria;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("SpecificIndexCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class SpecificIndexCriteriaType
    {
        public string IndexId;

        /// <remarks/>
        public string IndexValue;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("CoordinatesReceiver", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class CoordinatesReceiverType
    {
        public string Denomination;

        public string Street;

        /// <remarks/>
        public string HouseNbr;

        /// <remarks/>
        public string PostBox;

        /// <remarks/>
        public string ZIPCode;

        /// <remarks/>
        public string City;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Country;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Language;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class Data : DataType
    {
        public DocumentDescription DocumentDescription;

        [System.Xml.Serialization.XmlElementAttribute("DocumentNonXML", typeof(DocumentNonXMLType))]
        [System.Xml.Serialization.XmlElementAttribute("DocumentXML", typeof(System.Xml.XmlElement))]
        public object Item;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DocumentDescription : DocumentDescriptionType
    {
        public TechnicalDescription TechnicalDescription;

        public System.Xml.XmlElement BusinessDescription;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class TechnicalDescription : TechnicalDescriptionType
    {

        private IntegrityCheckType integrityCheckField;

        /// <remarks/>
        public IntegrityCheckType IntegrityCheck
        {
            get
            {
                return this.integrityCheckField;
            }
            set
            {
                this.integrityCheckField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("IntegrityCheck", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class IntegrityCheckType
    {

        private IntegrityMethod integrityMethodField;

        private byte[] valueField;

        /// <remarks/>
        public IntegrityMethod IntegrityMethod;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "hexBinary")]
        public byte[] Value;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum IntegrityMethod
    {
        [XmlEnumAttribute("SHA-256")]
        SHA256,

        [XmlEnumAttribute("SHA-512")]
        SHA512,

        MD5,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentNonXML", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentNonXMLType
    {

        private byte[] documentBase64Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DocumentBase64
        {
            get
            {
                return this.documentBase64Field;
            }
            set
            {
                this.documentBase64Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DestinationCriteria : DestinationCriteriaType
    {

        private AddresseeDataType addresseeDataField;

        private MandateCriteria mandateCriteriaField;

        private DocumentSendingDataType[] documentSendingDataField;

        private CoordinatesReceiverType[] coordinatesReceiverField;

        /// <remarks/>
        public AddresseeDataType AddresseeData
        {
            get
            {
                return this.addresseeDataField;
            }
            set
            {
                this.addresseeDataField = value;
            }
        }

        /// <remarks/>
        public MandateCriteria MandateCriteria
        {
            get
            {
                return this.mandateCriteriaField;
            }
            set
            {
                this.mandateCriteriaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentSendingData")]
        public DocumentSendingDataType[] DocumentSendingData
        {
            get
            {
                return this.documentSendingDataField;
            }
            set
            {
                this.documentSendingDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoordinatesReceiver")]
        public CoordinatesReceiverType[] CoordinatesReceiver
        {
            get
            {
                return this.coordinatesReceiverField;
            }
            set
            {
                this.coordinatesReceiverField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class MandateCriteria : MandateCriteriaType
    {

        private ObjectCriteriaType[] objectCriteriaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObjectCriteria")]
        public ObjectCriteriaType[] ObjectCriteria
        {
            get
            {
                return this.objectCriteriaField;
            }
            set
            {
                this.objectCriteriaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("ObjectCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class ObjectCriteriaType
    {

        private string objectField;

        private ObjectType objectTypeField;

        /// <remarks/>
        public string Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        public ObjectType ObjectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum ObjectType
    {

        /// <remarks/>
        SECTOR,

        /// <remarks/>
        GROUP,

        /// <remarks/>
        APPLICATION,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentSendingData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DocumentSendingDataType
    {

        private string channelField;

        private string attestationStatusField;

        private DocumentSendingModus documentSendingModusField;

        private string emailAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AttestationStatus
        {
            get
            {
                return this.attestationStatusField;
            }
            set
            {
                this.attestationStatusField = value;
            }
        }

        /// <remarks/>
        public DocumentSendingModus DocumentSendingModus
        {
            get
            {
                return this.documentSendingModusField;
            }
            set
            {
                this.documentSendingModusField = value;
            }
        }

        /// <remarks/>
        public string EmailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentSendingModus
    {

        /// <remarks/>
        NORMAL,

        /// <remarks/>
        REGISTERED,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DestinationData : DestinationDataType
    {

        private DestinationCriteria destinationCriteriaField;

        /// <remarks/>
        public DestinationCriteria DestinationCriteria
        {
            get
            {
                return this.destinationCriteriaField;
            }
            set
            {
                this.destinationCriteriaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DocumentData : DocumentDataType
    {

        private DocumentTitleType[] documentTitleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentTitle")]
        public DocumentTitleType[] DocumentTitle
        {
            get
            {
                return this.documentTitleField;
            }
            set
            {
                this.documentTitleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentTitle", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DocumentTitleType
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string languageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Denomination", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TitleLongValue", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        Denomination,

        /// <remarks/>
        TitleLongValue,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class EmployerId : EmployerIdType
    {

        private HandledEmployerIdType[] handledEmployerIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandledEmployerId")]
        public HandledEmployerIdType[] HandledEmployerId
        {
            get
            {
                return this.handledEmployerIdField;
            }
            set
            {
                this.handledEmployerIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("HandledEmployerId", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class HandledEmployerIdType
    {

        private string employerDenominationField;

        private string employerStreetField;

        private string employerHouseNbrField;

        private string employerPostBoxField;

        private string employerZIPCodeField;

        private string employerCityField;

        private string employerCountryField;

        private string importanceCodeField;

        private string legalFormField;

        private string languageField;

        /// <remarks/>
        public string EmployerDenomination
        {
            get
            {
                return this.employerDenominationField;
            }
            set
            {
                this.employerDenominationField = value;
            }
        }

        /// <remarks/>
        public string EmployerStreet
        {
            get
            {
                return this.employerStreetField;
            }
            set
            {
                this.employerStreetField = value;
            }
        }

        /// <remarks/>
        public string EmployerHouseNbr
        {
            get
            {
                return this.employerHouseNbrField;
            }
            set
            {
                this.employerHouseNbrField = value;
            }
        }

        /// <remarks/>
        public string EmployerPostBox
        {
            get
            {
                return this.employerPostBoxField;
            }
            set
            {
                this.employerPostBoxField = value;
            }
        }

        /// <remarks/>
        public string EmployerZIPCode
        {
            get
            {
                return this.employerZIPCodeField;
            }
            set
            {
                this.employerZIPCodeField = value;
            }
        }

        /// <remarks/>
        public string EmployerCity
        {
            get
            {
                return this.employerCityField;
            }
            set
            {
                this.employerCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmployerCountry
        {
            get
            {
                return this.employerCountryField;
            }
            set
            {
                this.employerCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ImportanceCode
        {
            get
            {
                return this.importanceCodeField;
            }
            set
            {
                this.importanceCodeField = value;
            }
        }

        /// <remarks/>
        public string LegalForm
        {
            get
            {
                return this.legalFormField;
            }
            set
            {
                this.legalFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("FileReceptionInformation", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class FileReceptionInformationType
    {

        private System.DateTime receptionDateField;

        private System.DateTime receptionHourField;

        private string channelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ReceptionDate
        {
            get
            {
                return this.receptionDateField;
            }
            set
            {
                this.receptionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime ReceptionHour
        {
            get
            {
                return this.receptionHourField;
            }
            set
            {
                this.receptionHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("FileReference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class FileReferenceType
    {

        private string fileNameField;

        private string referenceOriginField;

        private string referenceNbrField;

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ReferenceOrigin
        {
            get
            {
                return this.referenceOriginField;
            }
            set
            {
                this.referenceOriginField = value;
            }
        }

        /// <remarks/>
        public string ReferenceNbr
        {
            get
            {
                return this.referenceNbrField;
            }
            set
            {
                this.referenceNbrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("FinalAddresseeData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class FinalAddresseeDataType
    {

        private string addresseeField;

        private string addresseeTypeField;

        private string addresseeQualityField;

        /// <remarks/>
        public string Addressee
        {
            get
            {
                return this.addresseeField;
            }
            set
            {
                this.addresseeField = value;
            }
        }

        /// <remarks/>
        public string AddresseeType
        {
            get
            {
                return this.addresseeTypeField;
            }
            set
            {
                this.addresseeTypeField = value;
            }
        }

        /// <remarks/>
        public string AddresseeQuality
        {
            get
            {
                return this.addresseeQualityField;
            }
            set
            {
                this.addresseeQualityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class Form : FormType
    {

        private ReferenceType[] referenceField;

        private HandledOriginalFile handledOriginalFileField;

        private ReferenceData referenceDataField;

        private DocumentData documentDataField;

        private CaseData caseDataField;

        private DestinationData[] destinationDataField;

        private OriginSendingDataType originSendingDataField;

        private FinalAddresseeDataType[] finalAddresseeDataField;

        private ProcessingData processingDataField;

        private Data[] dataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public ReferenceType[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public HandledOriginalFile HandledOriginalFile
        {
            get
            {
                return this.handledOriginalFileField;
            }
            set
            {
                this.handledOriginalFileField = value;
            }
        }

        /// <remarks/>
        public ReferenceData ReferenceData;

        /// <remarks/>
        public DocumentData DocumentData;

        /// <remarks/>
        public CaseData CaseData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DestinationData")]
        public DestinationData[] DestinationData;

        /// <remarks/>
        public OriginSendingDataType OriginSendingData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinalAddresseeData")]
        public FinalAddresseeDataType[] FinalAddresseeData;

        /// <remarks/>
        public ProcessingData ProcessingData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Data")]
        public Data[] Data;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("Reference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ReferenceType
    {
        [System.Xml.Serialization.XmlElementAttribute("ReferenceType", DataType = "integer")]
        public string ReferenceType1;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ReferenceOrigin;

        /// <remarks/>
        public string ReferenceNbr;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledOriginalFile : HandledOriginalFileType
    {
        public HandledSenderIdentification HandledSenderIdentification;

        public FileReferenceType FileReference;

        public FileReceptionInformationType FileReceptionInformation;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class HandledSenderIdentification : HandledSenderIdentificationType
    {
        public SenderType Sender;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("Sender", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SenderType
    {
        public string Denomination;

        /// <remarks/>
        public string Street;

        /// <remarks/>
        public string HouseNbr;

        /// <remarks/>
        public string PostBox;

        /// <remarks/>
        public string ZIPCode;

        /// <remarks/>
        public string City;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Country;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Language;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ReferenceData : ReferenceDataType
    {
        [System.Xml.Serialization.XmlElementAttribute("SubGroupCriteria")]
        public SubGroupCriteriaType[] SubGroupCriteria;

        [System.Xml.Serialization.XmlElementAttribute("EmployerId")]
        public EmployerId[] EmployerId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("SubGroupCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SubGroupCriteriaType
    {
        public string GroupType;

        /// <remarks/>
        public OutputChannel OutputChannel;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum OutputChannel
    {
        BATCH,
        PRINT,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("OriginSendingData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class OriginSendingDataType
    {
        public string Addressee;

        /// <remarks/>
        public string AddresseeType;

        /// <remarks/>
        public string AddresseeQuality;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateSubmission;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSubmissionSpecified;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ProcessingData : ProcessingDataType
    {
        [XmlElementAttribute("ProcessingKeyValue")]
        public ProcessingKeyValueType[] ProcessingKeyValue;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("ProcessingKeyValue", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ProcessingKeyValueType
    {
        public string ProcessingKey;

        public string ProcessingValue;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class GenericXmlDocument
    {
        [XmlElementAttribute("Form")]
        public Form[] Form;
    }
}