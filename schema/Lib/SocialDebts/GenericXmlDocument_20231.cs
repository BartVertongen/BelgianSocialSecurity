

using System.Xml.Serialization;

namespace VertSoft.BelgianHR.Xml.SocialDebts.GenericXmlDocument
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("AddresseeData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class AddresseeDataType
    {
        public string Addressee;

        public string AddresseeType;

        public string AddresseeQuality;

        public string Identification;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class ProcessingDataType { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class HandledSenderIdentificationType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CompanyID;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NOSSRegistrationNbr;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NOSSLPARegistrationNbr;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ProvisionalNSSONbr;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SocialSecretariatNumber;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string INSS;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class HandledOriginalFileType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string SenderId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class FormType
    {
        public string Identification;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime FormCreationDate;

        [XmlElementAttribute(DataType = "time")]
        public System.DateTime FormCreationHour;

        [XmlElementAttribute(DataType = "integer")]
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


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class EmployerIdType
    {
        [XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElementAttribute("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
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


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DocumentDataType
    {
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime DocumentDate;

        [XmlIgnoreAttribute()]
        public bool DocumentDateSpecified;

        public string DocumentReference;

        [XmlElementAttribute(DataType = "integer")]
        public string INSS;

        [XmlElementAttribute(DataType = "integer")]
        public string CompanyID;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DestinationDataType
    {
        public DestinationType DestinationType;
    }

    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
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
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class MandateCriteriaType
    {
        [XmlElementAttribute("Date", typeof(System.DateTime), DataType = "date")]
        [XmlElementAttribute("MandateType", typeof(MandateType))]
        [XmlElementAttribute("Quarter", typeof(string), DataType = "integer")]
        public object Item;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
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

        [XmlIgnoreAttribute()]
        public bool CharacterSetSpecified;

        public CharacterFormat CharacterFormat;

        [XmlElementAttribute(DataType = "integer")]
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
        [XmlEnumAttribute("application/pdf")]
        applicationpdf,

        [XmlEnumAttribute("application/xml")]
        applicationxml,

        [XmlEnumAttribute("application/msword")]
        applicationmsword,

        [XmlEnumAttribute("application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        applicationvndopenxmlformatsofficedocumentwordprocessingmldocument,

        [XmlEnumAttribute("application/vnd.ms-excel")]
        applicationvndmsexcel,

        [XmlEnumAttribute("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        applicationvndopenxmlformatsofficedocumentspreadsheetmlsheet,

        [XmlEnumAttribute("application/zip")]
        applicationzip,

        [XmlEnumAttribute("image/jpeg")]
        imagejpeg,

        [XmlEnumAttribute("image/tiff")]
        imagetiff,

        [XmlEnumAttribute("text/plain")]
        textplain,

        application,

        [XmlEnumAttribute("application/vnd.oasis.opendocument.text")]
        applicationvndoasisopendocumenttext,
    }


    [SerializableAttribute()]
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
        NATIVE,
        Base64,
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentType
    {
        MAIN,
        ATTACHMENT,
    }

    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
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

        [XmlIgnoreAttribute()]
        public bool NSSOServiceSpecified;

        [XmlElementAttribute(DataType = "date")]
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


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum NSSOService
    {
        INNI,
        REJU,
        RIPAD,
    }

    [Serializable()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
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


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("AssignedUserCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class AssignedUserCriteriaType
    {
        public string AssignedUserType;

        public string AssignedUserId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class AssignedUserData : AssignedUserDataType
    {
        public AssignedUserCriteriaType AssignedUserCriteria;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("CaseStatusData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CaseStatusDataType
    {
        [XmlElementAttribute(DataType = "date")]
        public DateTime DueDate;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("CaseReferenceData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class CaseReferenceDataType
    {
        public CaseReferenceType CaseReferenceType;

        public string ReferenceNbr;
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CaseReferenceType
    {
        PRODUCER_REF,
        NOSS_REF,
        EXTERNAL_REF,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SpecificIndexData : SpecificIndexDataType
    {
        [XmlElementAttribute("SpecificIndexCriteria")]
        public SpecificIndexCriteriaType[] SpecificIndexCriteria;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("SpecificIndexCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SpecificIndexCriteriaType
    {
        public string IndexId;

        public string IndexValue;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("CoordinatesReceiver", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CoordinatesReceiverType
    {
        public string Denomination;

        public string Street;

        public string HouseNbr;

        public string PostBox;

        public string ZIPCode;

        public string City;

        [XmlElementAttribute(DataType = "integer")]
        public string Country;

        [XmlElementAttribute(DataType = "integer")]
        public string Language;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [ XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [ XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class Data : DataType
    {
        public DocumentDescription DocumentDescription;

        [XmlElementAttribute("DocumentNonXML", typeof(DocumentNonXMLType))]
        [ XmlElementAttribute("DocumentXML", typeof(System.Xml.XmlElement))]
        public object Item;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentDescription : DocumentDescriptionType
    {
        public TechnicalDescription TechnicalDescription;

        public System.Xml.XmlElement BusinessDescription;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class TechnicalDescription : TechnicalDescriptionType
    {
        public IntegrityCheckType IntegrityCheck;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("IntegrityCheck", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class IntegrityCheckType
    {
        public IntegrityMethod IntegrityMethod;

        [XmlElementAttribute(DataType = "hexBinary")]
        public byte[] Value;
    }

    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
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
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("DocumentNonXML", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentNonXMLType
    {
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DocumentBase64;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DestinationCriteria : DestinationCriteriaType
    {
        public AddresseeDataType AddresseeData;

        public MandateCriteria MandateCriteria;

        [XmlElementAttribute("DocumentSendingData")]
        public DocumentSendingDataType[] DocumentSendingData;

        [XmlElementAttribute("CoordinatesReceiver")]
        public CoordinatesReceiverType[] CoordinatesReceiver;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class MandateCriteria : MandateCriteriaType
    {
        [XmlElementAttribute("ObjectCriteria")]
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


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum ObjectType
    {
        SECTOR,
        GROUP,
        APPLICATION,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("DocumentSendingData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentSendingDataType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string Channel;

        [XmlElementAttribute(DataType = "integer")]
        public string AttestationStatus;

        public DocumentSendingModus DocumentSendingModus;

        public string EmailAddress;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentSendingModus
    {
        NORMAL,
        REGISTERED,
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DestinationData : DestinationDataType
    {
        public DestinationCriteria DestinationCriteria;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentData : DocumentDataType
    {
        [XmlElementAttribute("DocumentTitle")]
        public DocumentTitleType[] DocumentTitle;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("DocumentTitle", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentTitleType
    {
        [XmlElementAttribute("Denomination", typeof(string))]
        [XmlElementAttribute("TitleLongValue", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        [XmlElementAttribute(DataType = "integer")]
        public string Language;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        Denomination,
        TitleLongValue,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class EmployerId : EmployerIdType
    {
        [XmlElementAttribute("HandledEmployerId")]
        public HandledEmployerIdType[] HandledEmployerId;
    }


    [SerializableAttribute()]
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

        [XmlElementAttribute(DataType = "integer")]
        public string EmployerCountry;

        [XmlElementAttribute(DataType = "integer")]
        public string ImportanceCode;

        public string LegalForm;

        [XmlElementAttribute(DataType = "integer")]
        public string Language;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("FileReceptionInformation", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FileReceptionInformationType
    {
        [XmlElementAttribute(DataType = "date")]
        public DateTime ReceptionDate;

        [XmlElementAttribute(DataType = "time")]
        public DateTime ReceptionHour;

        [XmlElementAttribute(DataType = "integer")]
        public string Channel;
    }


    [Serializable()]
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

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class Form : FormType
    {
        [XmlElementAttribute("Reference")]
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


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("Reference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ReferenceType
    {
        [XmlElement("ReferenceType", DataType = "integer")]
        public string ReferenceType1;

        [XmlElement(DataType = "integer")]
        public string ReferenceOrigin;

        public string ReferenceNbr;
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledOriginalFile : HandledOriginalFileType
    {
        public HandledSenderIdentification HandledSenderIdentification;

        public FileReferenceType FileReference;

        public FileReceptionInformationType FileReceptionInformation;
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledSenderIdentification : HandledSenderIdentificationType
    {
        public SenderType Sender;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("Sender", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SenderType
    {
        public string Denomination;

        public string Street;

        public string HouseNbr;

        public string PostBox;

        public string ZIPCode;

        public string City;

        [XmlElementAttribute(DataType = "integer")]
        public string Country;

        [XmlElementAttribute(DataType = "integer")]
        public string Language;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ReferenceData : ReferenceDataType
    {
        [XmlElementAttribute("SubGroupCriteria")]
        public SubGroupCriteriaType[] SubGroupCriteria;

        [XmlElementAttribute("EmployerId")]
        public EmployerId[] EmployerId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("SubGroupCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SubGroupCriteriaType
    {
        public string GroupType;

        public OutputChannel OutputChannel;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum OutputChannel
    {
        BATCH,
        PRINT,
    }


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