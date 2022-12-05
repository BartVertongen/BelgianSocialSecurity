

using System.Xml.Serialization;


[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Action {

    [XmlEnumAttribute("0")]
    Item0,

    [XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,

    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,

    [System.Xml.Serialization.XmlEnumAttribute("6")]
    Item6,

    [XmlEnumAttribute("7")]
    Item7,

    [XmlEnumAttribute("9")]
    Item9,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("ActivationInformationAction", Namespace="", IsNullable=false)]
public class ActivationInformationActionType
{
    [XmlElementAttribute(DataType = "date")]
    public System.DateTime ServiceExemptionStartDate;

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime TrainingSituationStartDate;

    [XmlElementAttribute(DataType = "integer")]
    public string? TrainingSituation;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class WRCorrectedPartType
{
    [XmlElement(DataType = "integer")]
    public string EmployerClass;

    [XmlElement(DataType = "integer")]
    public string WorkerCode;

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime NOSSQuarterStartingDate;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime NOSSQuarterEndingDate;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Border;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ActivityWithRisk;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string LocalUnitID;

    public string WorkerRecordUserReference;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerRecordNewVersionNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CodeSubjected;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class WorkerDeductionActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCalculationBasis;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DeductionRightStartingDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DeductionRightStartingDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ManagementCostNbrMonths;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ReplacedINSS;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ApplicantINSS;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CertificateOrigin;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class OccupationDeductionActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCalculationBasis;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DeductionRightStartingDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DeductionRightStartingDateSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ManagementCostNbrMonths;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ReplacedINSS;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ApplicantINSS;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CertificateOrigin;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class ScaleSalaryActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ScaleSalaryStartDate;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ScaleSalaryEndDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ScaleSalaryEndDateSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "gYearMonth")]
    public string PecuniarySeniorityStartDate;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SalaryScaleReference;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ScaleSalaryAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WeekHoursNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ScaleSalaryWeekHoursNbr;

    public ReducedScaleSalaryNotion ReducedScaleSalaryNotion;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ReducedScaleSalaryNotionSpecified;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum ReducedScaleSalaryNotion { [System.Xml.Serialization.XmlEnumAttribute("1")] Item1, }


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class OccupationPSDActionType
{
    [XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationPSDStartDate;

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationPSDEndDate;

    [XmlIgnoreAttribute()]
    public bool OccupationPSDEndDateSpecified;

    [XmlElementAttribute(DataType = "integer")]
    public string PublicSectorInstitutionType;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PublicSectorPersonnelCategory;

    public string GradeOrFunction;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OfficialLanguage;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AssignmentType;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FunctionNature;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string StatutoryRelationEndReason;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class OccupationUpdateNotificationType
{
    [XmlElementAttribute(DataType = "integer")]
    public string OccupationSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationStartingDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OccupationStartingDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationEndingDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OccupationEndingDateSpecified;

    public string JointCommissionNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkingDaysSystem;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContractType;

    /// <remarks/>
    [XmlElement(DataType = "integer")]
    public string RefMeanWorkingHours;

    public string WorkerStatus;

    [XmlElementAttribute(DataType = "integer")]
    public string MeanWorkingHours;

    [XmlElementAttribute(DataType = "integer")]
    public string ReorganisationMeasure;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmploymentPromotion;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Retired;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string Apprenticeship;

    [XmlElementAttribute(DataType = "integer")]
    public string RemunMethod;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PositionCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FlyingStaffClass;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string TenthOrTwelfth;

    /// <remarks/>
    public string OccupationUserReference;

    /// <remarks/>
    public DaysJustification DaysJustification;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DaysJustificationSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ActivityCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OccupationVersionNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OccupationNewVersionNbr;

    /// <remarks/>
    public Action Action;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string LocalUnitID;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ShipId;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string StaffCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SubsidizedMeanWorkingHours;
}

[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum DaysJustification {

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,

    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,

    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,

    [System.Xml.Serialization.XmlEnumAttribute("6")]
    Item6,

    [System.Xml.Serialization.XmlEnumAttribute("7")]
    Item7,

    [System.Xml.Serialization.XmlEnumAttribute("8")]
    Item8,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class WRDclPartType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerClass;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime NOSSQuarterStartingDate;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime NOSSQuarterEndingDate;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Border;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ActivityWithRisk;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string LocalUnitID;

    /// <remarks/>
    public string WorkerRecordUserReference;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerRecordNewVersionNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CodeSubjected;

    public Action Action;

    /// <remarks/>
    public BlockDecisionIndicator BlockDecisionIndicator;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum BlockDecisionIndicator { A, M, R, }


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class WorkerRecordUpdateNotifType { }


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class NaturalPersonUpdateNotifType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NaturalPersonSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string INSS;

    public string NaturalPersonUserReference;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NaturalPersonPID;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeclNaturalPersonPID;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeclNaturalPersonVersionNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeclNaturalPersonNewVersionNbr;

    /// <remarks/>
    public Action Action;

    /// <remarks/>
    public BlockDecisionIndicator BlockDecisionIndicator;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified;

    /// <remarks/>
    public RepaymentDecision RepaymentDecision;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RepaymentDecisionSpecified;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum RepaymentDecision {
    [XmlEnumAttribute("0")]
    Item0,

    [XmlEnumAttribute("1")]
    Item1,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class EmployerDeclarationUpdateNotifType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Quarter;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("Trusteeship", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public string[] Items;

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyID;

    /// <remarks/>
    public TransmissionMode TransmissionMode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerDeclarationPID;

    /// <remarks/>
    public FaultyCode FaultyCode;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FaultyCodeSpecified;

    public CalculationRequestArt54ter CalculationRequestArt54ter;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CalculationRequestArt54terSpecified;

    public Notion22Quater Notion22Quater;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Notion22QuaterSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerDeclarationNewVersionNbr;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemsChoiceType {
    NOSSLPARegistrationNbr,
    NOSSRegistrationNbr,
    Trusteeship,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum TransmissionMode { WB, LO, CS, OD, }


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum FaultyCode { F, }


[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum CalculationRequestArt54ter { S, }


[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Notion22Quater { Q, }


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class FormType
{
    public Identification Identification;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime FormCreationDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime FormCreationHour;

    /// <remarks/>
    public AttestationStatus AttestationStatus;

    /// <remarks/>
    public TypeForm TypeForm;
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Identification {
    DMFANOT,
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum AttestationStatus {
    [XmlEnumAttribute("0")]
    Item0,

    [XmlEnumAttribute("2")]
    Item2,
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum TypeForm { SU, }


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class CUNPUpdateNotifType {
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class ComplementaryIndemnityActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerNotion;

    /// <remarks/>
    public string JointCommissionNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ActivityCode;

    /// <remarks/>
    public DebtorType DebtorType;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DebtorTypeSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime FirstComplIndemnityDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ComplIndemnityAgreementNotion;

    /// <remarks/>
    public string HalfTimeCareerInterruptionNotion;

    public string ServiceExemptionNotion;

    public string ReplacementAccordanceWCCNotion;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SubstituteINSS;

    public string ResumptionOfWorkMeasure;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ComplIndemnityNbrOfParts;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime NoticeDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NoticeDateSpecified;

    /// <remarks/>
    public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AilingOrReorgCompanyNotionSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AcknowledgementStartDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AcknowledgementStartDateSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AcknowledgementEndDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AcknowledgementEndDateSpecified;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum DebtorType {

    [XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum AilingOrReorgCompanyNotion {
    [XmlEnumAttribute("0")]
    Item0,

    [XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class CompanyVehicleUpdateNotifType {
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class AnomalyReportType
{
    public string ErrorID;

    public string TagName;

    public string Value;

    public string AnomalyClass;

    public string AnomalyLabel;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalScaleSalaryAction", Namespace="", IsNullable=false)]
public class AdditionalScaleSalaryActionType
{
    [XmlElementAttribute(DataType = "date")]
    public System.DateTime AdditionalScaleSalaryStartDate;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AdditionalScaleSalaryEndDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdditionalScaleSalaryEndDateSpecified;

    [XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryReference;

    [XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryBasisAmount;

    [XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryPercentage;

    [XmlElementAttribute(DataType = "integer")]
    public string NbrHoursOrServices;

    [XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryAmount;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public class AnomalyReport : AnomalyReportType
{
    public PathType Path;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("Path", Namespace="", IsNullable=false)]
public class PathType
{
    [XmlElementAttribute(DataType = "integer")]
    public string Quarter;

    [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Trusteeship;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyID;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedEmployerClass;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedWorkerCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NaturalPersonSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string INSS;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerClass;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OccupationSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ReorganisationMeasure;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ServiceSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ServiceCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string RemunSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string RemunCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string BonusPaymentFrequency;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PercentagePaid;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionDetailSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerNotion;

    /// <remarks/>
    public string JointCommissionNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ActivityCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ComplIndemnityAgreementNotion;

    /// <remarks/>
    public string HalfTimeCareerInterruptionNotion;

    /// <remarks/>
    public string ServiceExemptionNotion;

    /// <remarks/>
    public string ReplacementAccordanceWCCNotion;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionWorkerCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionType;

    /// <remarks/>
    public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ComplIndemnityAmountAdjustNotionSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EarlyRetirementCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IndemnityNature;

    /// <remarks/>
    public string IncapacityDegree;

    /// <remarks/>
    public string NaturalPersonUserReference;

    /// <remarks/>
    public string WorkerRecordUserReference;

    /// <remarks/>
    public string OccupationUserReference;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleSequenceNbr;

    /// <remarks/>
    public string NPCalculatedAmount;

    /// <remarks/>
    public string CUNPCalculatedAmount;

    /// <remarks/>
    public string WorksContractActorId;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationPSDStartDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OccupationPSDStartDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CareerElementSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PublicSectorInstitutionType;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PublicSectorPersonnelCategory;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AssignmentType;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FunctionNature;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ScaleSalarySequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ScaleSalaryStartDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ScaleSalaryStartDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "gYearMonth")]
    public string PecuniarySeniorityStartDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SalaryScaleReference;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalarySequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryReference;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AdditionalScaleSalaryStartDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdditionalScaleSalaryStartDateSpecified;

    public NonSituableAbsenceCode NonSituableAbsenceCode;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NonSituableAbsenceCodeSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CalendarYear;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime StartingDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool StartingDateSpecified;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType {
    NOSSLPARegistrationNbr,

    NOSSRegistrationNbr,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum ComplIndemnityAmountAdjustNotion {

    [XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    [XmlEnumAttribute("3")]
    Item3,

    [XmlEnumAttribute("4")]
    Item4,

    [XmlEnumAttribute("9")]
    Item9,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum NonSituableAbsenceCode
{
    [XmlEnumAttribute("31")]
    Item31,

    [XmlEnumAttribute("32")]
    Item32,

    [XmlEnumAttribute("33")]
    Item33,

    [XmlEnumAttribute("41")]
    Item41,

    [XmlEnumAttribute("42")]
    Item42,

    [XmlEnumAttribute("43")]
    Item43,
}


[SerializableAttribute()]
[XmlType(AnonymousType=true)]
[XmlRoot(Namespace="", IsNullable=false)]
public enum CapitalizationNotion {

    [XmlEnumAttribute("0")] Item0,

    [XmlEnumAttribute("1")] Item1,

    [XmlEnumAttribute("2")] Item2,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("CompanyVehicleCorrectedPart", Namespace="", IsNullable=false)]
public class CompanyVehicleCorrectedPartType
{
    [XmlElementAttribute(DataType = "integer")]
    public string? CompanyVehicleSequenceNbr;

    public string? LicensePlate;

    [XmlElementAttribute(DataType = "integer")]
    public string EcoVehicle;

    [XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleNewVersionNbr;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("CompanyVehicleDclPart", Namespace="", IsNullable=false)]
public partial class CompanyVehicleDclPartType {

    [XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleSequenceNbr;

    public string LicensePlate;

    [XmlElementAttribute(DataType = "integer")]
    public string EcoVehicle;

    [XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleNewVersionNbr;

    public Action Action;

    public BlockDecisionIndicator BlockDecisionIndicator;

    [XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CompanyVehicleUpdateNotif : CompanyVehicleUpdateNotifType
{
    public LastSituationCompanyVehicleType LastSituationCompanyVehicle;

    public CompanyVehicleDclPartType CompanyVehicleDclPart;

    public CompanyVehicleCorrectedPartType CompanyVehicleCorrectedPart;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("LastSituationCompanyVehicle", Namespace="", IsNullable=false)]
public partial class LastSituationCompanyVehicleType
{
    [XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleSequenceNbr;

    public string LicensePlate;

    [XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleVersionNbr;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public class ComplementaryIndemnityAction : ComplementaryIndemnityActionType {

    [XmlElementAttribute("ComplIndemnityContributionAction")]
    public ComplIndemnityContributionActionType[] ComplIndemnityContributionAction;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("ComplIndemnityContributionAction", Namespace="", IsNullable=false)]
public partial class ComplIndemnityContributionActionType
{
    [XmlElementAttribute(DataType = "integer")]
    public string ContributionWorkerCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionType;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IndemnityContributionPeriodCode;

    public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ComplIndemnityAmount;

    public CapitalizationNotion CapitalizationNotion;

    [XmlIgnoreAttribute()]
    public bool CapitalizationNotionSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WelfareBenefitTheoreticalAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ComplIndemnityNbrMonths;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NbrMonthsDecimals;

    [XmlElementAttribute(DataType = "integer")]
    public string IncompleteMonthNbrDays;

    [XmlElementAttribute(DataType = "integer")]
    public string IncompleteMonthReason;

    [XmlElement(DataType = "integer")]
    public string FloorApplicationNotion;

    [XmlElement(DataType = "integer")]
    public string ContributionAmount;

    public Action Action;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRoot("CUNPCorrectedPart", Namespace="", IsNullable=false)]
public class CUNPCorrectedPartType
{
    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedEmployerClass;

    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedWorkerCode;

    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedCalculationBasis;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedAmount;

    [XmlElementAttribute(DataType = "integer")]
    public string ContUnrelatedToNPNewVersionNbr;

    [XmlElementAttribute(DataType = "integer")]
    public string CodeSubjected;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("CUNPDclPart", Namespace="", IsNullable=false)]
public class CUNPDclPartType
{
    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedEmployerClass;

    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedWorkerCode;

    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedCalculationBasis;

    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedAmount;

    [XmlElementAttribute(DataType = "integer")]
    public string ContUnrelatedToNPNewVersionNbr;

    [XmlElementAttribute(DataType = "integer")]
    public string CodeSubjected;

    public Action Action;

    public BlockDecisionIndicator BlockDecisionIndicator;

    [XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public class CUNPUpdateNotif : CUNPUpdateNotifType {

    public LastSituationCUNPType LastSituationCUNP;

    public CUNPDclPartType CUNPDclPart;

    public CUNPCorrectedPartType CUNPCorrectedPart;

    [XmlElementAttribute("AnomalyReport")]
    public AnomalyReport[] AnomalyReport;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("LastSituationCUNP", Namespace="", IsNullable=false)]
public class LastSituationCUNPType
{
    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedEmployerClass;

    [XmlElementAttribute(DataType = "integer")]
    public string UnrelatedWorkerCode;

    [XmlElementAttribute(DataType = "integer")]
    public string ContUnrelatedToNPVersionNbr;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("DeductionDetailAction", Namespace="", IsNullable=false)]
public class DeductionDetailActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionDetailSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionDetailAmount;

    public string WorkingRegulationsRegistryNbr;

    [XmlElementAttribute(DataType = "date")]
    public DateTime WorkingRegulationsStartingDate;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool WorkingRegulationsStartingDateSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AverageWorkingTimeBeforeReduction;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AverageWorkingTimeAfterReduction;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("DismissedStatWorkerContAction", Namespace="", IsNullable=false)]
public class DismissedStatWorkerContActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string GrossRefRemunAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string GrossRefRemunContributionAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string RefNbrDays;

    [XmlElementAttribute(DataType = "date")]
    public DateTime SubjectionStartingDate;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime SubjectionEndingDate;

    public Action Action;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public class DmfAUpdateNotification
{
    public Form? Form;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Form : FormType
{
    [XmlElement("Reference")]
    public ReferenceType[] Reference;

    public EmployerDeclarationUpdateNotif EmployerDeclarationUpdateNotif;

    public RectificationAmountType RectificationAmount;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("Reference", Namespace="", IsNullable=false)]
public partial class ReferenceType
{
    [XmlElementAttribute("ReferenceType")]
    public ReferenceType1 ReferenceType1;

    public ReferenceOrigin ReferenceOrigin;

    public string ReferenceNbr;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("ReferenceType", Namespace="", IsNullable=false)]
public enum ReferenceType1
{

    [XmlEnumAttribute("1")]
    Item1,

    [XmlEnumAttribute("3")]
    Item3,
}


[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum ReferenceOrigin {

    [XmlEnumAttribute("1")]
    Item1,

    [XmlEnumAttribute("2")]
    Item2,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class EmployerDeclarationUpdateNotif : EmployerDeclarationUpdateNotifType
{
    [XmlElementAttribute("SubGroupInformation")]
    public SubGroupInformationType[] SubGroupInformation;

    [System.Xml.Serialization.XmlElementAttribute("CUNPUpdateNotif", typeof(CUNPUpdateNotif))]
    [System.Xml.Serialization.XmlElementAttribute("CompanyVehicleUpdateNotif", typeof(CompanyVehicleUpdateNotif))]
    [XmlElementAttribute("NaturalPersonUpdateNotif", typeof(NaturalPersonUpdateNotif))]
    public object[] Items1;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("SubGroupInformation", Namespace="", IsNullable=false)]
public partial class SubGroupInformationType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string? SubGroup;

    public SubGroupDecisionIndicator SubGroupDecisionIndicator;

    [XmlIgnoreAttribute()]
    public bool SubGroupDecisionIndicatorSpecified;

    [XmlElementAttribute(DataType = "integer")]
    public string UserQuality;

    public string Justification;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string JustificationCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime JustificationDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool JustificationDateSpecified;
}


[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum SubGroupDecisionIndicator { R, }


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public class NaturalPersonUpdateNotif : NaturalPersonUpdateNotifType
{
    [XmlElementAttribute("WorkerRecordUpdateNotif")]
    public WorkerRecordUpdateNotif[] WorkerRecordUpdateNotif;

    [System.Xml.Serialization.XmlElementAttribute("NaturalPersonJustification")]
    public NaturalPersonJustificationType[] NaturalPersonJustification;

    [System.Xml.Serialization.XmlElementAttribute("AnomalyReport")]
    public AnomalyReport[] AnomalyReport;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class WorkerRecordUpdateNotif : WorkerRecordUpdateNotifType
{
    public LastSituationWRType LastSituationWR;

    public WRDclPart WRDclPart;

    public WRCorrectedPart WRCorrectedPart;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("LastSituationWR", Namespace="", IsNullable=false)]
public class LastSituationWRType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerClass;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerRecordVersionNbr;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class WRDclPart : WRDclPartType {

    [System.Xml.Serialization.XmlElementAttribute("ActivationInformationAction", typeof(ActivationInformationActionType))]
    [System.Xml.Serialization.XmlElementAttribute("ComplementaryIndemnityAction", typeof(ComplementaryIndemnityAction))]
    [System.Xml.Serialization.XmlElementAttribute("DismissedStatWorkerContAction", typeof(DismissedStatWorkerContActionType))]
    [System.Xml.Serialization.XmlElementAttribute("EarlyRetirementContAction", typeof(EarlyRetirementContActionType))]
    [System.Xml.Serialization.XmlElementAttribute("IndemnityWAPMAction", typeof(IndemnityWAPMActionType))]
    [System.Xml.Serialization.XmlElementAttribute("OccupationUpdateNotification", typeof(OccupationUpdateNotification))]
    [System.Xml.Serialization.XmlElementAttribute("StudentContributionAction", typeof(StudentContributionActionType))]
    [System.Xml.Serialization.XmlElementAttribute("WorkerContributionAction", typeof(WorkerContributionActionType))]
    [System.Xml.Serialization.XmlElementAttribute("WorkerDeductionAction", typeof(WorkerDeductionAction))]
    public object[]? Items;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("EarlyRetirementContAction", Namespace="", IsNullable=false)]
public class EarlyRetirementContActionType
{
    [XmlElementAttribute(DataType = "integer")]
    public string EarlyRetirementCode;

    [XmlElementAttribute(DataType = "integer")]
    public string EarlyRetirementNbrMonths;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EarlyRetirementContributionAmount;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("IndemnityWAPMAction", Namespace="", IsNullable=false)]
public class IndemnityWAPMActionType
{
    [XmlElementAttribute(DataType = "integer")]
    public string IndemnityNature;

    public string IncapacityDegree;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IndemnityAmount;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OccupationUpdateNotification : OccupationUpdateNotificationType
{
    public OccupationInformationsActionType OccupationInformationsAction;

    public SecondPillarInformationActionType SecondPillarInformationAction;

    [System.Xml.Serialization.XmlElementAttribute("ServiceAction")]
    public ServiceActionType[] ServiceAction;

    [System.Xml.Serialization.XmlElementAttribute("RemunAction")]
    public RemunActionType[] RemunAction;

    [System.Xml.Serialization.XmlElementAttribute("OccupationPSDAction")]
    public OccupationPSDAction[] OccupationPSDAction;

    [System.Xml.Serialization.XmlElementAttribute("ReorgMeasureInformationAction")]
    public ReorgMeasureInformationActionType[] ReorgMeasureInformationAction;

    [System.Xml.Serialization.XmlElementAttribute("OccupationDeductionAction")]
    public OccupationDeductionAction[] OccupationDeductionAction;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("OccupationInformationsAction", Namespace="", IsNullable=false)]
public partial class OccupationInformationsActionType
{
    public HorecaExtra HorecaExtra;

    [XmlIgnoreAttribute()]
    public bool HorecaExtraSpecified;

    public PostedWorker PostedWorker;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PostedWorkerSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NOSSLPASocialMaribel;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string HourRemun;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string HourRemunInThousandthOfEuro;

    [XmlElement(DataType = "date")]
    public DateTime SixMonthsIllnessDate;

    [XmlIgnoreAttribute()]
    public bool SixMonthsIllnessDateSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FirstWeekGuaranteedSalaryNbrDays;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IllnessGrossRemunAmount;

    public PSDDclExemption PSDDclExemption;

    [XmlIgnoreAttribute()]
    public bool PSDDclExemptionSpecified;

    public SupplPensionContributionExemption SupplPensionContributionExemption;

    [XmlIgnore()]
    public bool SupplPensionContributionExemptionSpecified;

    public ObligationControlInformation ObligationControlInformation;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ObligationControlInformationSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DefinitiveNominationDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DefinitiveNominationDateSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime NewMaribelEmploymentDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NewMaribelEmploymentDateSpecified;

    public PSPContribCalcBasisDerogation PSPContribCalcBasisDerogation;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PSPContribCalcBasisDerogationSpecified;

    [XmlElementAttribute(DataType = "integer")]
    public string CareerMeasure;

    public string ServiceExemptionNotion;

    [XmlElementAttribute(DataType = "integer")]
    public string HolidayDaysNumber;

    [XmlElementAttribute(DataType = "integer")]
    public string SectorDetail;

    [XmlElementAttribute(DataType = "integer")]
    public string MobilityBudget;

    [XmlElementAttribute(DataType = "integer")]
    public string FlemishTrainingHolidayHoursNbr;

    public string RegionalAidMeasure;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum HorecaExtra { E, }


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum PostedWorker {

    [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")] Item2,
}


[SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum PSDDclExemption {
    [XmlEnumAttribute("1")] Item1,
}


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum SupplPensionContributionExemption {

    [XmlEnumAttribute("1")]
    Item1,

    [XmlEnumAttribute("2")]
    Item2,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum ObligationControlInformation { FWT, }


[System.SerializableAttribute()]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public enum PSPContribCalcBasisDerogation {

    [XmlEnumAttribute("1")] Item1,

    [XmlEnumAttribute("2")] Item2,
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("SecondPillarInformationAction", Namespace="", IsNullable=false)]
public  class SecondPillarInformationActionType
{
    public string ReferenceYearMonth;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string MonthlyScaleSalary;

    [XmlElementAttribute(DataType = "integer")]
    public string MonthlyAdditionalScaleSalary;

    [XmlElementAttribute(DataType = "integer")]
    public string MonthlyHomeIndemnity;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OfficialLanguage;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("ServiceAction", Namespace="", IsNullable=false)]
public class ServiceActionType
{
    [XmlElementAttribute(DataType = "integer")]
    public string ServiceSequenceNbr;

    [XmlElementAttribute(DataType = "integer")]
    public string ServiceCode;

    [XmlElementAttribute(DataType = "integer")]
    public string ServiceNbrDays;

    [XmlElementAttribute(DataType = "integer")]
    public string ServiceNbrHours;

    [XmlElementAttribute(DataType = "integer")]
    public string FlightNbrMinutes;

    public Action Action;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlRoot("RemunAction", Namespace="", IsNullable=false)]
public partial class RemunActionType
{
    [XmlElementAttribute(DataType = "integer")]
    public string RemunSequenceNbr;

    [XmlElementAttribute(DataType = "integer")]
    public string RemunCode;

    [XmlElementAttribute(DataType = "integer")]
    public string BonusPaymentFrequency;

    [XmlElementAttribute(DataType = "integer")]
    public string PercentagePaid;

    [XmlElementAttribute(DataType = "integer")]
    public string RemunAmount;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OccupationPSDAction : OccupationPSDActionType
{
    [XmlElementAttribute("ScaleSalaryAction")]
    public ScaleSalaryAction[] ScaleSalaryAction;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public class ScaleSalaryAction : ScaleSalaryActionType
{
    [XmlElementAttribute("AdditionalScaleSalaryAction")]
    public AdditionalScaleSalaryActionType[] AdditionalScaleSalaryAction;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("ReorgMeasureInformationAction", Namespace="", IsNullable=false)]
public class ReorgMeasureInformationActionType
{
    [XmlElementAttribute(DataType = "integer")]
    public string ReorganisationMeasure;

    [XmlElementAttribute(DataType = "integer")]
    public string ReorganisationMeasurePercentage;

    public Action Action;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OccupationDeductionAction : OccupationDeductionActionType {

    [XmlElementAttribute("OccupationDeductionDetailAction")]
    public OccupationDeductionDetailActionType[] OccupationDeductionDetailAction;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlRoot("OccupationDeductionDetailAction", Namespace="", IsNullable=false)]
public class OccupationDeductionDetailActionType {

    [XmlElementAttribute(DataType = "integer")]
    public string DeductionDetailSequenceNbr;

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime WorkingRegulationsStartingDate;

    [XmlIgnoreAttribute()]
    public bool WorkingRegulationsStartingDateSpecified;

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime WorkingRegulationsEndingDate;

    [XmlIgnoreAttribute()]
    public bool WorkingRegulationsEndingDateSpecified;

    [XmlElementAttribute(DataType = "integer")]
    public string AverageWorkingTimeBeforeReduction;

    [XmlElementAttribute(DataType = "integer")]
    public string AverageWorkingTimeAfterReduction;

    public Action Action;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("StudentContributionAction", Namespace="", IsNullable=false)]
public class StudentContributionActionType
{
    [XmlElement(DataType = "integer")]
    public string StudentRemunAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string StudentContributionAmount;

    [System.Xml.Serialization.XmlElementAttribute("StudentHoursNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("StudentNbrDays", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string LocalUnitID;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType1 { StudentHoursNbr, StudentNbrDays, }


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("WorkerContributionAction", Namespace="", IsNullable=false)]
public partial class WorkerContributionActionType
{
    [XmlElementAttribute(DataType = "integer")]
    public string ContributionWorkerCode;

    [XmlElementAttribute(DataType = "integer")]
    public string ContributionType;

    [XmlElementAttribute(DataType = "integer")]
    public string ContributionCalculationBasis;

    [XmlElementAttribute(DataType = "integer")]
    public string ContributionAmount;

    [XmlElementAttribute(DataType = "date")]
    public DateTime FirstHiringDate;

    [XmlIgnoreAttribute()]
    public bool FirstHiringDateSpecified;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class WorkerDeductionAction : WorkerDeductionActionType
{    
    [XmlElementAttribute("DeductionDetailAction")]
    public DeductionDetailActionType[] DeductionDetailAction;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public class WRCorrectedPart : WRCorrectedPartType
{
    [XmlElementAttribute("ActivationInformationAction", typeof(ActivationInformationActionType))]
    [XmlElementAttribute("ComplementaryIndemnityAction", typeof(ComplementaryIndemnityAction))]
    [XmlElementAttribute("DismissedStatWorkerContAction", typeof(DismissedStatWorkerContActionType))]
    [System.Xml.Serialization.XmlElementAttribute("EarlyRetirementContAction", typeof(EarlyRetirementContActionType))]
    [System.Xml.Serialization.XmlElementAttribute("IndemnityWAPMAction", typeof(IndemnityWAPMActionType))]
    [System.Xml.Serialization.XmlElementAttribute("OccupationUpdateNotification", typeof(OccupationUpdateNotification))]
    [System.Xml.Serialization.XmlElementAttribute("StudentContributionAction", typeof(StudentContributionActionType))]
    [System.Xml.Serialization.XmlElementAttribute("WorkerContributionAction", typeof(WorkerContributionActionType))]
    [System.Xml.Serialization.XmlElementAttribute("WorkerDeductionAction", typeof(WorkerDeductionAction))]
    public object[]? Items;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("NaturalPersonJustification", Namespace="", IsNullable=false)]
public class NaturalPersonJustificationType
{
    [XmlElementAttribute(DataType = "integer")]
    public string SubGroup;

    public string Justification;

    [XmlElementAttribute(DataType = "integer")]
    public string JustificationCode;

    [XmlElementAttribute(DataType = "date")]
    public System.DateTime JustificationDate;

    [XmlIgnoreAttribute()]
    public bool JustificationDateSpecified;
}


[SerializableAttribute()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlRoot("RectificationAmount", Namespace="", IsNullable=false)]
public class RectificationAmountType
{
    [XmlElement("CreditAmount", typeof(string), DataType = "integer")]
    [XmlElement("DebitAmount", typeof(string), DataType = "integer")]
    [XmlChoiceIdentifier("ItemElementName")]
    public string? Item;

    [XmlIgnore()]
    public ItemChoiceType2 ItemElementName;
}


[Serializable()]
[XmlType(IncludeInSchema=false)]
public enum ItemChoiceType2 { CreditAmount, DebitAmount, }
