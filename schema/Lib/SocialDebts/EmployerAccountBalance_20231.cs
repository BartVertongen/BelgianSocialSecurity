

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.SocialDebts.AccountBalance
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("AttestationInformation", Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class AttestationInformationType
    {
        public string Justification;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    public class ResponseType { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    public class RequestDetailType { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    public class RequestInformationType
    {
        public DateTime Timestamp;

        [XmlIgnore()]
        public bool TimestampSpecified;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    public class RequestType { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    public class ConsumerType
    {
        public string Denomination;

        [XmlElement(DataType = "integer")]
        public string LocalUnitID;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    public class BalanceAnalysisResultType
    {
        public string CDSDocumentId;

        [XmlElement(DataType = "date")]
        public DateTime ClosingDate;

        [XmlElement(DataType = "integer")]
        public string ClosingQuarter;

        [XmlElement(DataType = "integer")]
        public string IsPaymentPlanFollowed;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("BalanceAmounts", Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class BalanceAmountsType
    {
        public string ContributionTotalAmount;

        [XmlElement(DataType = "integer")]
        public string TotalIncreases;

        [XmlElementAttribute(DataType = "integer")]
        public string TotalInterests;

        [XmlElementAttribute(DataType = "integer")]
        public string TotalLegalCosts;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class BalanceAnalysisResult : BalanceAnalysisResultType
    {
        public BalanceAmountsType BalanceAmounts;

        public DisputeType Dispute;

        [XmlArrayItem("Quarter", DataType = "integer", IsNullable = false)]
        public string[] MissingDeclarationQuarters;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("Dispute", Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class DisputeType
    {
        [XmlElement("DisputeType", DataType = "integer")]
        public string DisputeType1;

        [XmlElement(DataType = "integer")]
        public string Amount;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class Consumer : ConsumerType
    {
        public PersonIdentificationType PersonIdentification;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("PersonIdentification", Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class PersonIdentificationType
    {
        [XmlElement("CompanyID", typeof(string), DataType = "integer")]
        [XmlElement("INSS", typeof(string), DataType = "integer")]
        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlElement("SocialSecretariatNumber", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item;

        [XmlIgnore()]
        public ItemChoiceType ItemElementName;
    }


    [Serializable()]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        CompanyID,
        INSS,
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
        ProvisionalNSSONbr,
        SocialSecretariatNumber,
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class EmployerAccountBalance
    {
        public Request Request;

        public Response Response;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class Request : RequestType
    {
        public RequestInformation RequestInformation;

        public RequestDetail RequestDetail;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class RequestInformation : RequestInformationType
    {
        public Consumer Consumer;

        public LegalContextInformationType LegalContextInformation;

        public ReferenceType Reference;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("LegalContextInformation", Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class LegalContextInformationType
    {
        [XmlElement(DataType = "integer")]
        public string LegalContext;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("Reference", Namespace="http://socialsecurity.be/xml/ns/accountbalance", IsNullable=false)]
    public class ReferenceType
    {
        [XmlElement("ReferenceType", DataType="integer")]
        public string ReferenceType1;

        public ReferenceOrigin ReferenceOrigin;

        public string ReferenceNbr;
    }


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("5")] Item5,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class RequestDetail : RequestDetailType
    {
        public EmployerIdType EmployerId;

        [XmlElement("Reference")]
        public ReferenceType[] Reference;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("EmployerId", Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
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


    [Serializable()]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {
        NOSSLPARegistrationNbr,
        NOSSRegistrationNbr,
        ProvisionalNSSONbr,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class Response : ResponseType
    {
        public ExecutionResultType ExecutionResult;

        public BalanceAnalysisResult BalanceAnalysisResult;

        public AttestationInformationType AttestationInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("ExecutionResult", Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class ExecutionResultType
    {
        public ResultCode ResultCode;

        public string ErrorID;
    }


    [SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public enum ResultCode
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("3")] Item3,

        [XmlEnum("4")] Item4,
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/accountbalance")]
    [XmlRoot("MissingDeclarationQuarters", Namespace = "http://socialsecurity.be/xml/ns/accountbalance", IsNullable = false)]
    public class MissingDeclarationQuartersType
    {
        [XmlElement("Quarter", DataType = "integer")]
        public string[] Quarter;
    }
}