

using System.Xml.Serialization;

namespace VertSoft.BelgianHR.Xml.SocialDebts.GenericXmlDocument
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("AddresseeData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class AddresseeDataType
    {
        public string Addressee;

        public string AddresseeType;

        public string AddresseeQuality;

        public string Identification;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class ProcessingDataType { }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class ReferenceDataType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string INSS;

        [XmlElementAttribute("Quarter", DataType = "integer")]
        public string[] Quarter;

        public string GroupName;


        [XmlElementAttribute(DataType = "integer")]
        public string FormSequenceNbr;

        public bool IsLastForm;

        [XmlIgnoreAttribute()]
        public bool IsLastFormSpecified;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class HandledSenderIdentificationType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string CompanyID;

        [XmlElementAttribute(DataType = "integer")]
        public string NOSSRegistrationNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string NOSSLPARegistrationNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string ProvisionalNSSONbr;

        [XmlElementAttribute(DataType = "integer")]
        public string SocialSecretariatNumber;

        [XmlElementAttribute(DataType = "integer")]
        public string INSS;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class HandledOriginalFileType
    {
        [XmlElement(DataType = "integer")]
        public string SenderId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class FormType
    {
        public string Identification;

        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        [XmlElement(DataType = "integer")]
        public string AttestationStatus;

        public TypeForm TypeForm;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum TypeForm
    {
        RE,
        PA,
        FA,
        LA,
        SU,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class EmployerIdType
    {
        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;

        [XmlElementAttribute(DataType = "integer")]
        public string CompanyID;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
        ProvisionalNSSONbr,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DocumentDataType
    {
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime DocumentDate;

        [XmlIgnoreAttribute()]
        public bool DocumentDateSpecified;

        public string DocumentReference;

        [XmlElement(DataType = "integer")]
        public string INSS;

        [XmlElement(DataType = "integer")]
        public string CompanyID;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DestinationDataType
    {
        public DestinationType DestinationType;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DestinationType
    {
        DESTHA,
        DESTHAFOREMPLOYER,
        SUIVIFOREMPLOYER,
        SUIVI,
        CONTRACTUALRELATIONSHIPREGISTRY,
        ENTREPRISE,
        CLC,
        SMALS,
        DOCUMENTSENDINGDATA,
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class MandateCriteriaType
    {
        [XmlElementAttribute("Date", typeof(System.DateTime), DataType = "date")]
        [XmlElementAttribute("MandateType", typeof(MandateType))]
        [XmlElementAttribute("Quarter", typeof(string), DataType = "integer")]
        public object Item;
    }


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum MandateType
    {
        ReferenceData,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public partial class DestinationCriteriaType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string ReferenceType;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class TechnicalDescriptionType
    {
        public MimeType MimeType;

        public CharacterSet CharacterSet;

        [XmlIgnore()]
        public bool CharacterSetSpecified;

        public CharacterFormat CharacterFormat;

        [XmlElement(DataType = "integer")]
        public string Language;

        public string FileName;

        public DocumentType DocumentType;

        [XmlIgnoreAttribute()]
        public bool DocumentTypeSpecified;

        public string AttachmentId;
    }

    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum MimeType
    {
        [XmlEnum("application/pdf")]
        applicationpdf,

        [XmlEnum("application/xml")]
        applicationxml,

        [XmlEnumAttribute("application/msword")]
        applicationmsword,

        [XmlEnumAttribute("application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        applicationvndopenxmlformatsofficedocumentwordprocessingmldocument,

        [XmlEnumAttribute("application/vnd.ms-excel")]
        applicationvndmsexcel,

        [XmlEnumAttribute("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        applicationvndopenxmlformatsofficedocumentspreadsheetmlsheet,

        [XmlEnum("application/zip")]
        applicationzip,

        [XmlEnum("image/jpeg")]
        imagejpeg,

        [XmlEnum("image/tiff")]
        imagetiff,

        [XmlEnumAttribute("text/plain")]
        textplain,

        application,

        [XmlEnum("application/vnd.oasis.opendocument.text")]
        applicationvndoasisopendocumenttext,
    }


    [Serializable()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CharacterSet
    {
        [XmlEnum("UTF-8")]
        UTF8,
    }


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CharacterFormat
    {
        NATIVE, Base64,
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentType
    {
        MAIN, ATTACHMENT,
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DocumentDescriptionType { }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DataType { }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class SpecificIndexDataType { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class CaseDataType
    {
        public NSSOService NSSOService;

        [XmlIgnore()]
        public bool NSSOServiceSpecified;

        [XmlElement(DataType = "date")]
        public System.DateTime CreationDate;

        [XmlIgnoreAttribute()]
        public bool CreationDateSpecified;

        public CaseSubType CaseSubType;


        [XmlIgnoreAttribute()]
        public bool CaseSubTypeSpecified;

        public string CaseId;

        public ProcessType ProcessType;

        [XmlIgnoreAttribute()]
        public bool ProcessTypeSpecified;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum NSSOService
    {
        INNI,
        REJU,
        RIPAD,
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CaseSubType
    {
        TYP_SC_026,
        TYP_SC_119,
        TYP_SC_214,
        TYP_SC_215,
        TYP_SC_216,
        TYP_SC_217,
        TYP_SC_246,
        TYP_SC_247,
        TYP_SC_283,
        TYP_SC_284,
        TYP_SC_502,
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum ProcessType
    {
        SUBMITDOCUMENT,
        SUBMITCASEID,
        SUBMITARCHIVE,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class AssignedUserDataType { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("AssignedUserCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class AssignedUserCriteriaType
    {
        public string AssignedUserType;

        public string AssignedUserId;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class AssignedUserData : AssignedUserDataType
    {
        public AssignedUserCriteriaType AssignedUserCriteria;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CaseData : CaseDataType
    {
        public CaseStatusDataType CaseStatusData;

        [XmlElement("CaseReferenceData")]
        public CaseReferenceDataType[] CaseReferenceData;

        public SpecificIndexData SpecificIndexData;

        public AssignedUserData AssignedUserData;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("CaseStatusData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CaseStatusDataType
    {
        [XmlElement(DataType = "date")]
        public DateTime DueDate;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("CaseReferenceData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CaseReferenceDataType
    {
        public CaseReferenceType CaseReferenceType;

        public string ReferenceNbr;
    }


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CaseReferenceType
    {
        PRODUCER_REF,
        NOSS_REF,
        EXTERNAL_REF,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SpecificIndexData : SpecificIndexDataType
    {
        [XmlElement("SpecificIndexCriteria")]
        public SpecificIndexCriteriaType[] SpecificIndexCriteria;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("SpecificIndexCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SpecificIndexCriteriaType
    {
        public string IndexId;

        public string IndexValue;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("CoordinatesReceiver", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CoordinatesReceiverType
    {
        public string Denomination;

        public string Street;

        public string HouseNbr;

        public string PostBox;

        public string ZIPCode;

        public string City;

        [XmlElement(DataType = "integer")]
        public string Country;

        [XmlElement(DataType = "integer")]
        public string Language;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class Data : DataType
    {
        public DocumentDescription DocumentDescription;

        [XmlElementAttribute("DocumentNonXML", typeof(DocumentNonXMLType))]
        [ XmlElementAttribute("DocumentXML", typeof(System.Xml.XmlElement))]
        public object Item;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentDescription : DocumentDescriptionType
    {
        public TechnicalDescription TechnicalDescription;

        public System.Xml.XmlElement BusinessDescription;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class TechnicalDescription : TechnicalDescriptionType
    {
        public IntegrityCheckType IntegrityCheck;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("IntegrityCheck", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class IntegrityCheckType
    {
        public IntegrityMethod IntegrityMethod;

        [XmlElement(DataType = "hexBinary")]
        public byte[] Value;
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum IntegrityMethod
    {
        [XmlEnum("SHA-256")] SHA256,

        [XmlEnum("SHA-512")] SHA512,

        MD5,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("DocumentNonXML", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentNonXMLType
    {
        [XmlElement(DataType = "base64Binary")]
        public byte[] DocumentBase64;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DestinationCriteria : DestinationCriteriaType
    {
        public AddresseeDataType AddresseeData;

        public MandateCriteria MandateCriteria;

        [XmlElement("DocumentSendingData")]
        public DocumentSendingDataType[] DocumentSendingData;

        [XmlElement("CoordinatesReceiver")]
        public CoordinatesReceiverType[] CoordinatesReceiver;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class MandateCriteria : MandateCriteriaType
    {
        [XmlElement("ObjectCriteria")]
        public ObjectCriteriaType[] ObjectCriteria;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("ObjectCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ObjectCriteriaType
    {
        public string Object;

        public ObjectType ObjectType;
    }


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum ObjectType { SECTOR, GROUP, APPLICATION, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("DocumentSendingData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentSendingDataType
    {
        [XmlElement(DataType = "integer")]
        public string Channel;

        [XmlElement(DataType = "integer")]
        public string AttestationStatus;

        public DocumentSendingModus DocumentSendingModus;

        public string EmailAddress;
    }


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentSendingModus { NORMAL, REGISTERED, }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DestinationData : DestinationDataType
    {
        public DestinationCriteria DestinationCriteria;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentData : DocumentDataType
    {
        [XmlElement("DocumentTitle")]
        public DocumentTitleType[] DocumentTitle;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("DocumentTitle", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentTitleType
    {
        [XmlElement("Denomination", typeof(string))]
        [XmlElement("TitleLongValue", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item;

        [XmlIgnore()]
        public ItemChoiceType ItemElementName;

        [XmlElement(DataType = "integer")]
        public string Language;
    }


    [Serializable()]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        Denomination,
        TitleLongValue,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class EmployerId : EmployerIdType
    {
        [XmlElement("HandledEmployerId")]
        public HandledEmployerIdType[] HandledEmployerId;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("HandledEmployerId", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledEmployerIdType
    {
        public string EmployerDenomination;

        public string EmployerStreet;

        public string EmployerHouseNbr;

        public string EmployerPostBox;

        public string EmployerZIPCode;

        public string EmployerCity;

        [XmlElement(DataType = "integer")]
        public string EmployerCountry;

        [XmlElement(DataType = "integer")]
        public string ImportanceCode;

        public string LegalForm;

        [XmlElement(DataType = "integer")]
        public string Language;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("FileReceptionInformation", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FileReceptionInformationType
    {
        [XmlElement(DataType = "date")]
        public DateTime ReceptionDate;

        [XmlElement(DataType = "time")]
        public DateTime ReceptionHour;

        [XmlElement(DataType = "integer")]
        public string Channel;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("FileReference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FileReferenceType
    {
        public string FileName;

        [XmlElement(DataType = "integer")]
        public string ReferenceOrigin;

        public string ReferenceNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("FinalAddresseeData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FinalAddresseeDataType
    {
        public string Addressee;

        public string AddresseeType;

        public string AddresseeQuality;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class Form : FormType
    {
        [XmlElement("Reference")]
        public ReferenceType[] Reference;

        public HandledOriginalFile HandledOriginalFile;

        public ReferenceData ReferenceData;

        public DocumentData DocumentData;

        public CaseData CaseData;

        [XmlElementAttribute("DestinationData")]
        public DestinationData[] DestinationData;

        public OriginSendingDataType OriginSendingData;

        [XmlElementAttribute("FinalAddresseeData")]
        public FinalAddresseeDataType[] FinalAddresseeData;

        public ProcessingData ProcessingData;

        [XmlElementAttribute("Data")]
        public Data[] Data;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("Reference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ReferenceType
    {
        [XmlElement("ReferenceType", DataType = "integer")]
        public string ReferenceType1;

        [XmlElement(DataType = "integer")]
        public string ReferenceOrigin;

        public string ReferenceNbr;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledOriginalFile : HandledOriginalFileType
    {
        public HandledSenderIdentification HandledSenderIdentification;

        public FileReferenceType FileReference;

        public FileReceptionInformationType FileReceptionInformation;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledSenderIdentification : HandledSenderIdentificationType
    {
        public SenderType Sender;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("Sender", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SenderType
    {
        public string Denomination;

        public string Street;

        public string HouseNbr;

        public string PostBox;

        public string ZIPCode;

        public string City;

        [XmlElement(DataType = "integer")]
        public string Country;

        [XmlElement(DataType = "integer")]
        public string Language;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ReferenceData : ReferenceDataType
    {
        [XmlElement("SubGroupCriteria")]
        public SubGroupCriteriaType[] SubGroupCriteria;

        [XmlElement("EmployerId")]
        public EmployerId[] EmployerId;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("SubGroupCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SubGroupCriteriaType
    {
        public string GroupType;

        public OutputChannel OutputChannel;
    }


    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum OutputChannel { BATCH, PRINT, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("OriginSendingData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class OriginSendingDataType
    {
        public string Addressee;

        public string AddresseeType;

        public string AddresseeQuality;

        [XmlElement(DataType = "date")]
        public DateTime DateSubmission;

        [XmlIgnore()]
        public bool DateSubmissionSpecified;
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ProcessingData : ProcessingDataType
    {
        [XmlElement("ProcessingKeyValue")]
        public ProcessingKeyValueType[] ProcessingKeyValue;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("ProcessingKeyValue", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
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
        [XmlElement("Form")]
        public Form[] Form;
    }
}