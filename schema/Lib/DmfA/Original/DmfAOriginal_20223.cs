//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DismissedStatutoryWorkerContribution", Namespace = "", IsNullable = false)]
    public class DismissedStatutoryWorkerContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? GrossRefRemunAmount;

        [XmlElement(DataType = "integer")]
        public string? GrossRefRemunContributionAmount;

        [XmlElement(DataType = "integer")]
        public string? RefNbrDays;

        [XmlElement(DataType = "date")]
        public DateTime SubjectionStartingDate;

        [XmlElement(DataType = "date")]
        public DateTime SubjectionEndingDate;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Form : FormType
    {
        public ReferenceType? Reference;

        public EmployerDeclaration? EmployerDeclaration;
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
    public enum ReferenceType1 { [XmlEnum("1")] Item1, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin { [XmlEnum("1")] Item1, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class EmployerDeclaration : EmployerDeclarationType
    {
        [XmlElement("CompanyVehicle", typeof(CompanyVehicleType))]
        [XmlElement("ContributionUnrelatedToNP", typeof(ContributionUnrelatedToNPType))]
        [XmlElement("NaturalPerson", typeof(NaturalPerson))]
        public object[]? Items;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class NaturalPerson : NaturalPersonType
    {
        [XmlElement("WorkerRecord")]
        public WorkerRecord[]? WorkerRecord;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerRecord : WorkerRecordType
    {
        [XmlElement("ActivationInformation", typeof(ActivationInformationType))]
        [XmlElement("ComplementaryIndemnity", typeof(ComplementaryIndemnity))]
        [XmlElement("DismissedStatutoryWorkerContribution", typeof(DismissedStatutoryWorkerContributionType))]
        [XmlElement("EarlyRetirementContribution", typeof(EarlyRetirementContributionType))]
        [XmlElement("IndemnityWAPM", typeof(IndemnityWAPMType))]
        [XmlElement("Occupation", typeof(Occupation))]
        [XmlElement("StudentContribution", typeof(StudentContributionType))]
        [XmlElement("WorkerContribution", typeof(WorkerContributionType))]
        [XmlElement("WorkerDeduction", typeof(WorkerDeduction))]
        public object[]? Items;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EarlyRetirementContribution", Namespace = "", IsNullable = false)]
    public class EarlyRetirementContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementCode;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementContributionAmount;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("IndemnityWAPM", Namespace = "", IsNullable = false)]
    public class IndemnityWAPMType
    {
        [XmlElement(DataType = "integer")]
        public string? IndemnityNature;

        public string? IncapacityDegree;

        [XmlElement(DataType = "integer")]
        public string? IndemnityAmount;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Occupation : OccupationType
    {
        public OccupationInformationsType? OccupationInformations;

        public SecondPillarInformationType? SecondPillarInformation;

        [XmlElement("Service")]
        public ServiceType[]? Service;

        [XmlElement("Remun")]
        public RemunType[]? Remun;

        [XmlElement("OccupationPublicServiceData")]
        public OccupationPublicServiceData[]? OccupationPublicServiceData;

        [XmlElement("ReorgMeasureInformation")]
        public ReorgMeasureInformationType[]? ReorgMeasureInformation;

        [XmlElement("OccupationDeduction")]
        public OccupationDeduction[]? OccupationDeduction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationInformations", Namespace = "", IsNullable = false)]
    public class OccupationInformationsType
    {
        public HorecaExtra HorecaExtra;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HorecaExtraSpecified;

        public PostedWorker PostedWorker;

        [XmlIgnoreAttribute()]
        public bool PostedWorkerSpecified;

        public NOSSLPASocialMaribel NOSSLPASocialMaribel;

        [XmlIgnoreAttribute()]
        public bool NOSSLPASocialMaribelSpecified;

        [XmlElement(DataType = "integer")]
        public string? HourRemun;

        [XmlElement(DataType = "integer")]
        public string? HourRemunInThousandthOfEuro;

        [XmlElement(DataType = "date")]
        public System.DateTime SixMonthsIllnessDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SixMonthsIllnessDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? FirstWeekGuaranteedSalaryNbrDays;

        [XmlElement(DataType = "integer")]
        public string? IllnessGrossRemunAmount;

        public PSDDclExemption PSDDclExemption;

        [XmlIgnoreAttribute()]
        public bool PSDDclExemptionSpecified;

        public SupplPensionContributionExemption SupplPensionContributionExemption;

        [XmlIgnoreAttribute()]
        public bool SupplPensionContributionExemptionSpecified;

        public ObligationControlInformation ObligationControlInformation;

        [XmlIgnoreAttribute()]
        public bool ObligationControlInformationSpecified;

        [XmlElement(DataType = "date")]
        public System.DateTime DefinitiveNominationDate;

        [XmlIgnoreAttribute()]
        public bool DefinitiveNominationDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime NewMaribelEmploymentDate;

        [XmlIgnoreAttribute()]
        public bool NewMaribelEmploymentDateSpecified;

        public PSPContribCalcBasisDerogation PSPContribCalcBasisDerogation;

        [XmlIgnoreAttribute()]
        public bool PSPContribCalcBasisDerogationSpecified;

        public CareerMeasure CareerMeasure;

        [XmlIgnoreAttribute()]
        public bool CareerMeasureSpecified;

        public ServiceExemptionNotion ServiceExemptionNotion;

        [XmlIgnoreAttribute()]
        public bool ServiceExemptionNotionSpecified;

        [XmlElement(DataType = "integer")]
        public string? HolidayDaysNumber;

        [XmlElement(DataType = "integer")]
        public string? SectorDetail;

        [XmlElement(DataType = "integer")]
        public string? MobilityBudget;

        [XmlElement(DataType = "integer")]
        public string? FlemishTrainingHolidayHoursNbr;

        public RegionalAidMeasure RegionalAidMeasure;

        [XmlIgnore()]
        public bool RegionalAidMeasureSpecified;
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum HorecaExtra  { E, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PostedWorker
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [System.Serializable()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum NOSSLPASocialMaribel
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,

        [XmlEnum("4")] Item4,

        [XmlEnum("5")] Item5,

        [XmlEnum("6")] Item6,

        [XmlEnum("7")] Item7,

        [XmlEnum("8")] Item8,

        [XmlEnum("9")] Item9,

        [XmlEnum("10")] Item10,

        [XmlEnum("11")] Item11,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PSDDclExemption
    {
        [XmlEnum("1")] Item1,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum SupplPensionContributionExemption
    {
        [XmlEnum("1")] Item1,
    }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ObligationControlInformation { FWT, }


    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum PSPContribCalcBasisDerogation
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,
    }


    [Serializable()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum RegionalAidMeasure { B, }


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("SecondPillarInformation", Namespace = "", IsNullable = false)]
    public class SecondPillarInformationType
    {
        public string? ReferenceYearMonth;

        [XmlElement(DataType = "integer")]
        public string? MonthlyScaleSalary;

        [XmlElement(DataType = "integer")]
        public string? MonthlyAdditionalScaleSalary;

        [XmlElement(DataType = "integer")]
        public string? MonthlyHomeIndemnity;

        [XmlElement(DataType = "integer")]
        public string? OfficialLanguage;
    }


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Service", Namespace = "", IsNullable = false)]
    public class ServiceType
    {
        [XmlElement(DataType = "integer")]
        public string? ServiceSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? ServiceCode;

        [XmlElement(DataType = "integer")]
        public string? ServiceNbrDays;

        [XmlElement(DataType = "integer")]
        public string? ServiceNbrHours;

        [XmlElement(DataType = "integer")]
        public string? FlightNbrMinutes;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Remun", Namespace = "", IsNullable = false)]
    public class RemunType
    {
        [XmlElement(DataType = "integer")]
        public string? RemunSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? RemunCode;

        [XmlElement(DataType = "integer")]
        public string? BonusPaymentFrequency;

        [XmlElement(DataType = "integer")]
        public string? PercentagePaid;

        [XmlElement(DataType = "integer")]
        public string? RemunAmount;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationPublicServiceData : OccupationPublicServiceDataType
    {
        [XmlElement("ScaleSalary")]
        public ScaleSalary[]? ScaleSalary;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ScaleSalary : ScaleSalaryType
    {
        [XmlElement("AdditionalScaleSalary")]
        public AdditionalScaleSalaryType[]? AdditionalScaleSalary;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ReorgMeasureInformation", Namespace = "", IsNullable = false)]
    public class ReorgMeasureInformationType
    {
        public ReorganisationMeasure ReorganisationMeasure;

        [XmlElement(DataType = "integer")]
        public string? ReorganisationMeasurePercentage;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationDeduction : OccupationDeductionType
    {
        public OccupationDeductionDetailType? OccupationDeductionDetail;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationDeductionDetail", Namespace = "", IsNullable = false)]
    public class OccupationDeductionDetailType
    {
        [XmlElement(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsStartingDate;

        [XmlIgnore()]
        public bool WorkingRegulationsStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsEndingDate;

        [XmlIgnore()]
        public bool WorkingRegulationsEndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeBeforeReduction;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeAfterReduction;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("StudentContribution", Namespace = "", IsNullable = false)]
    public class StudentContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? StudentRemunAmount;


        [XmlElement(DataType = "integer")]
        public string? StudentContributionAmount;

        [XmlElement("StudentHoursNbr", typeof(string), DataType = "integer")]
        [XmlElement("StudentNbrDays", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;
    }


    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType { StudentHoursNbr, StudentNbrDays, }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("WorkerContribution", Namespace = "", IsNullable = false)]
    public class WorkerContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionType;

        [XmlElement(DataType = "integer")]
        public string? ContributionCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? ContributionAmount;

        [XmlElement(DataType = "date")]
        public DateTime FirstHiringDate;

        [XmlIgnore()]
        public bool FirstHiringDateSpecified;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerDeduction : WorkerDeductionType
    {
        [XmlElement("DeductionDetail")]
        public DeductionDetailType[]? DeductionDetail;
    }


    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DmfAOriginal
    {
        [XmlElement("Form")]
        public Form[]? Form;
    }
}