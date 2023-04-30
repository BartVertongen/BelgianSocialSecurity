

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.SocialDebts.FinancialSituation
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("Communication", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class CommunicationType
    {
        public string PhoneNbr;

        public string GSMNbr;

        public string FaxNbr;

        public string EmailAddress;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    public class ReceiverInformationType { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    public class FinancialSituationDetailType { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    public class EmployerInformationType
    {
        public string EmployerDenomination;

        [XmlElement(DataType = "integer")]
        public string LegalDistrict;

        public string LegalForm;

        [XmlElement(DataType = "integer")]
        public string ImportanceCode;

        [XmlElement("ActivityCode", DataType = "integer")]
        public string[] ActivityCode;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    public class CoordinatesContactPersonType
    {
        public string Name;

        public string FirstName;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    public class ApplicationDataType { }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("Address", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class AddressType
    {
        public string Street;

        public string HouseNbr;

        public string PostBox;

        public string ZIPCode;

        public string City;

        [XmlElement(DataType = "integer")]
        public string Country;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class ApplicationData : ApplicationDataType
    {
        [XmlAnyElement()]
        public System.Xml.XmlElement Any;
    }


    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class CoordinatesContactPerson : CoordinatesContactPersonType
    {
        public CommunicationType Communication;

        public SectorInformationType SectorInformation;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("SectorInformation", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class SectorInformationType
    {
        public string OfficeNumber;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("CoordinatesEmployer", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class CoordinatesEmployerType
    {
        public string EmployerDenomination;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("CoordinatesRepresentative", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class CoordinatesRepresentativeType
    {
        public string Denomination;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("CoordinatesSocialSecretariat", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class CoordinatesSocialSecretariatType
    {
        [XmlElement(DataType = "integer")]
        public string SocialSecretariatNumber;

        [XmlElement(DataType = "integer")]
        public string FilialSecSocNbr;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("EmployerActivityPeriod", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class EmployerActivityPeriodType
    {
        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlElement(DataType = "integer")]
        public string StartingQuarter;

        [XmlElement(DataType = "date")]
        public DateTime DueDate;

        [XmlIgnore()]
        public bool DueDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;


        [XmlIgnore()]
        public bool EndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string EndingQuarter;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("EmployerClassInformation", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class EmployerClassInformationType
    {
        [XmlElement(DataType = "integer")]
        public string EmployerClass;

        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class EmployerInformation : EmployerInformationType
    {
        public CoordinatesRepresentativeType CoordinatesRepresentative;

        public EmployerActivityPeriodType EmployerActivityPeriod;

        public AddressType Address;

        [XmlElement("EmployerClassInformation")]
        public EmployerClassInformationType[] EmployerClassInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class FinancialSituation
    {
        public FinancialSituationInformationType FinancialSituationInformation;

        public FinancialSituationDetail FinancialSituationDetail;

        [XmlElement("CoordinatesContactPerson")]
        public CoordinatesContactPerson[] CoordinatesContactPerson;

        public ReceiverInformation ReceiverInformation;

        public EmployerInformation EmployerInformation;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot("FinancialSituationInformation", Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class FinancialSituationInformationType
    {
        public string ReferenceNbr;

        [XmlElement(DataType = "integer")]
        public string FinancialNoteInitiator;

        [XmlElement(DataType = "integer")]
        public string FinancialTransactionDomain;

        [XmlElement(DataType = "integer")]
        public string NOSSRegistrationNbr;

        [XmlElement(DataType = "integer")]
        public string CompanyID;

        [XmlElement(DataType = "date")]
        public DateTime DateSubmission;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class FinancialSituationDetail : FinancialSituationDetailType
    {
        public ApplicationData ApplicationData;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://socialsecurity.be/xml/ns/financialsituation")]
    [XmlRoot(Namespace = "http://socialsecurity.be/xml/ns/financialsituation", IsNullable = false)]
    public class ReceiverInformation : ReceiverInformationType
    {
        public CoordinatesSocialSecretariatType CoordinatesSocialSecretariat;

        [XmlElement("CoordinatesContactPerson", typeof(CoordinatesContactPerson))]
        [XmlElement("CoordinatesEmployer", typeof(CoordinatesEmployerType))]
        public object[] Items;

        public CoordinatesRepresentativeType CoordinatesRepresentative;

        public AddressType Address;
    }
}