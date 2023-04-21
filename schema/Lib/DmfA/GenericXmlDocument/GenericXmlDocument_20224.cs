//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum MandateType{ ReferenceData }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DestinationCriteriaType
    {
        [XmlElement(DataType = "integer")]
        public string ReferenceType;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
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


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum MimeType
    {
        [XmlEnum("application/pdf")]
        applicationpdf,

        [XmlEnum("application/xml")]
        applicationxml,

        [XmlEnum("application/msword")]
        applicationmsword,

        [XmlEnum("application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        applicationvndopenxmlformatsofficedocumentwordprocessingmldocument,

        [XmlEnum("application/vnd.ms-excel")]
        applicationvndmsexcel,

        [XmlEnum("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        applicationvndopenxmlformatsofficedocumentspreadsheetmlsheet,

        [XmlEnum("application/zip")]
        applicationzip,

        [XmlEnum("image/jpeg")]
        imagejpeg,

        [XmlEnum("image/tiff")]
        imagetiff,

        [XmlEnum("text/plain")]
        textplain,

        application,

        [XmlEnum("application/vnd.oasis.opendocument.text")]
        applicationvndoasisopendocumenttext,
    }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CharacterSet
    {
        [XmlEnum("UTF-8")] UTF8,
    }


    [Serializable()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CharacterFormat { NATIVE, Base64, }


    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentType { MAIN, ATTACHMENT, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DocumentDescriptionType
    { }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class DataType
    { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class SpecificIndexDataType
    { }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class CaseDataType
    {

        /*private NSSOService nSSOServiceField;

        private bool nSSOServiceFieldSpecified;

        private System.DateTime creationDateField;

        private bool creationDateFieldSpecified;

        private CaseSubType caseSubTypeField;

        private bool caseSubTypeFieldSpecified;

        private string caseIdField;

        private ProcessType processTypeField;

        private bool processTypeFieldSpecified;*/

        public NSSOService NSSOService;

        [XmlIgnore()]
        public bool NSSOServiceSpecified;

        [XmlElement(DataType = "date")]
        public DateTime CreationDate;

        [XmlIgnore()]
        public bool CreationDateSpecified;

        public CaseSubType CaseSubType;

        [XmlIgnore()]
        public bool CaseSubTypeSpecified;

        public string CaseId;

        public ProcessType ProcessType;

        [XmlIgnore()]
        public bool ProcessTypeSpecified;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum NSSOService { INNI, REJU, RIPAD }


    [System.SerializableAttribute()]
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
    public enum ProcessType { SUBMITDOCUMENT, SUBMITCASEID, SUBMITARCHIVE }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    public class AssignedUserDataType
    { }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class AssignedUserData : AssignedUserDataType
    {
        private AssignedUserCriteriaType assignedUserCriteriaField;

        public AssignedUserCriteriaType AssignedUserCriteria;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CaseData : CaseDataType
    {
        [XmlElement("CaseReferenceData")]
        public CaseReferenceDataType[] CaseReferenceData;

        public SpecificIndexData SpecificIndexData;

        public AssignedUserData AssignedUserData;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("CaseStatusData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class CaseStatusDataType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DueDate;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("CaseReferenceData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class CaseReferenceDataType
    {
        public string ReferenceNbr;
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum CaseReferenceType { PRODUCER_REF, NOSS_REF, EXTERNAL_REF }


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
    public partial class SpecificIndexCriteriaType
    {
        public string IndexId;

        public string IndexValue;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class Data : DataType
    {
        public DocumentDescription DocumentDescription;

        [XmlElementAttribute("DocumentNonXML", typeof(DocumentNonXMLType))]
        [XmlElementAttribute("DocumentXML", typeof(System.Xml.XmlElement))]
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


    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum IntegrityMethod
    {
        [XmlEnum("SHA-256")] SHA256,

        [XmlEnum("SHA-512")] SHA512,

        MD5,
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("DocumentNonXML", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentNonXMLType
    {
        [XmlElement(DataType = "base64Binary")]
        public byte[] DocumentBase64;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public partial class DestinationCriteria : DestinationCriteriaType
    {
        public AddresseeDataType AddresseeData;

        public MandateCriteria MandateCriteria;

        [XmlElement("DocumentSendingData")]
        public DocumentSendingDataType[] DocumentSendingData;

        [XmlElement("CoordinatesReceiver")]
        public CoordinatesReceiverType[] CoordinatesReceiver;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class MandateCriteria : MandateCriteriaType
    {
        [XmlElement("ObjectCriteria")]
        public ObjectCriteriaType[] ObjectCriteria;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("ObjectCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ObjectCriteriaType
    {
        public string Object;

        public ObjectType ObjectType;
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum ObjectType { SECTOR, GROUP, APPLICATION, }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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


    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum DocumentSendingModus
    {
        NORMAL,
        REGISTERED,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentTitle")]
        public DocumentTitleType[] DocumentTitle;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRootAttribute("DocumentTitle", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class DocumentTitleType
    {
        [XmlElement("Denomination", typeof(string))]
        [XmlElement("TitleLongValue", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        [XmlElement(DataType = "integer")]
        public string Language;
    }


    [SerializableAttribute()]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IncludeInSchema = false)]
    public enum ItemChoiceType { Denomination, TitleLongValue, }


    [SerializableAttribute()]
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

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("FileReceptionInformation", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FileReceptionInformationType
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
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("FileReference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FileReferenceType
    {
        public string FileName;

        [XmlElement(DataType = "integer")]
        public string ReferenceOrigin;

        public string ReferenceNbr;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("FinalAddresseeData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class FinalAddresseeDataType
    {
        public string Addressee;

        public string AddresseeType;

        public string AddresseeQuality;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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

        [XmlElement("DestinationData")]
        public DestinationData[] DestinationData;

        public OriginSendingDataType OriginSendingData;

        [XmlElement("FinalAddresseeData")]
        public FinalAddresseeDataType[] FinalAddresseeData;

        public ProcessingData ProcessingData;

        [XmlElement("Data")]
        public Data[] Data;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("Reference", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
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
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledOriginalFile : HandledOriginalFileType
    {
        public HandledSenderIdentification HandledSenderIdentification;

        public FileReferenceType FileReference;

        public FileReceptionInformationType FileReceptionInformation;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class HandledSenderIdentification : HandledSenderIdentificationType
    {
        public SenderType Sender;
    }


    [SerializableAttribute()]
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


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ReferenceData : ReferenceDataType
    {
        [XmlElement("SubGroupCriteria")]
        public SubGroupCriteriaType[] SubGroupCriteria;

        [XmlElement("EmployerId")]
        public EmployerId[] EmployerId;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("SubGroupCriteria", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class SubGroupCriteriaType
    {
        public string GroupType;

        public OutputChannel OutputChannel;
    }


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public enum OutputChannel { BATCH, PRINT }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("OriginSendingData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
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


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot("ProcessingKeyValue", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class ProcessingKeyValueType
    {
        public string ProcessingKey;

        public string ProcessingValue;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
    [XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
    public class GenericXmlDocument
    {
        [XmlElement("Form")]
        public Form[] Form;
    }
}