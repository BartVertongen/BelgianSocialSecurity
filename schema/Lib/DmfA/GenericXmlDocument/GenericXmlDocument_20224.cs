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
    public class Data : DataType
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
    public class DocumentDescription : DocumentDescriptionType
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
        public IntegrityCheckType IntegrityCheck;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("IntegrityCheck", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class IntegrityCheckType
    {
        public IntegrityMethod IntegrityMethod;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "hexBinary")]
        public byte[] Value;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum IntegrityMethod
    {
        [XmlEnumAttribute("SHA-256")] SHA256,

        [XmlEnumAttribute("SHA-512")] SHA512,

        MD5,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentNonXML", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentNonXMLType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DocumentBase64;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DestinationCriteria : DestinationCriteriaType
    {
        public AddresseeDataType AddresseeData;

        /// <remarks/>
        public MandateCriteria MandateCriteria;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentSendingData")]
        public DocumentSendingDataType[] DocumentSendingData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoordinatesReceiver")]
        public CoordinatesReceiverType[] CoordinatesReceiver;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class MandateCriteria : MandateCriteriaType
    {
        [System.Xml.Serialization.XmlElementAttribute("ObjectCriteria")]
        public ObjectCriteriaType[] ObjectCriteria;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("ObjectCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ObjectCriteriaType
    {
        public string Object;

        /// <remarks/>
        public ObjectType ObjectType;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum ObjectType
    {
        SECTOR, GROUP, APPLICATION,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentSendingData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DocumentSendingDataType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Channel;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AttestationStatus;

        /// <remarks/>
        public DocumentSendingModus DocumentSendingModus;

        /// <remarks/>
        public string EmailAddress;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentSendingModus
    {
        NORMAL,
        REGISTERED,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DestinationData : DestinationDataType
    {
        public DestinationCriteria DestinationCriteria;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentData : DocumentDataType
    {
        [System.Xml.Serialization.XmlElementAttribute("DocumentTitle")]
        public DocumentTitleType[] DocumentTitle;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentTitle", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentTitleType
    {
        [System.Xml.Serialization.XmlElementAttribute("Denomination", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TitleLongValue", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Language;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IncludeInSchema = false)]
    public enum ItemChoiceType { Denomination, TitleLongValue, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class EmployerId : EmployerIdType
    {
        [XmlElementAttribute("HandledEmployerId")]
        public HandledEmployerIdType[] HandledEmployerId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("HandledEmployerId", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledEmployerIdType
    {
        public string EmployerDenomination;

        public string EmployerStreet;

        public string EmployerHouseNbr;

        public string EmployerPostBox;

        public string EmployerZIPCode;

        public string EmployerCity;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmployerCountry;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ImportanceCode;

        public string LegalForm;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Language;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("FileReceptionInformation", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class FileReceptionInformationType
    {
        [XmlElementAttribute(DataType = "date")]
        public DateTime ReceptionDate;

        [XmlElementAttribute(DataType = "time")]
        public DateTime ReceptionHour;

        [XmlElementAttribute(DataType = "integer")]
        public string Channel;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("FileReference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FileReferenceType
    {
        public string FileName;

        [XmlElementAttribute(DataType = "integer")]
        public string ReferenceOrigin;

        public string ReferenceNbr;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("FinalAddresseeData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FinalAddresseeDataType
    {
        public string Addressee;

        public string AddresseeType;

        public string AddresseeQuality;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class Form : FormType
    {
        [XmlElement("Reference")]
        public ReferenceType[] Reference;

        public HandledOriginalFile HandledOriginalFile;

        public ReferenceData ReferenceData;

        public DocumentData DocumentData;

        public CaseData CaseData;

        [XmlElement("DestinationData")]
        public DestinationData[] DestinationData;

        public OriginSendingDataType OriginSendingData;

        [XmlElementAttribute("FinalAddresseeData")]
        public FinalAddresseeDataType[] FinalAddresseeData;

        public ProcessingData ProcessingData;

        [XmlElementAttribute("Data")]
        public Data[] Data;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("Reference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ReferenceType
    {
        [XmlElementAttribute("ReferenceType", DataType = "integer")]
        public string? ReferenceType1;

        [XmlElementAttribute(DataType = "integer")]
        public string? ReferenceOrigin;

        public string? ReferenceNbr;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledOriginalFile : HandledOriginalFileType
    {
        public HandledSenderIdentification HandledSenderIdentification;

        public FileReferenceType FileReference;

        public FileReceptionInformationType FileReceptionInformation;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class HandledSenderIdentification : HandledSenderIdentificationType
    {
        public SenderType Sender;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
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

        public string ZIPCode;

        public string City;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Country;

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