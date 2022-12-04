

using System.Xml.Serialization;


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Action {

    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,

    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,

    [System.Xml.Serialization.XmlEnumAttribute("6")]
    Item6,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("7")]
    Item7,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("9")]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string LocalUnitID;

    /// <remarks/>
    public string WorkerRecordUserReference;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerRecordNewVersionNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CodeSubjected;

    /// <remarks/>
    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class WorkerDeductionActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCalculationBasis;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionAmount;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DeductionRightStartingDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DeductionRightStartingDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ManagementCostNbrMonths;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ReplacedINSS;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ApplicantINSS;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CertificateOrigin;

    /// <remarks/>
    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class OccupationDeductionActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionCalculationBasis;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionAmount;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DeductionRightStartingDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DeductionRightStartingDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ManagementCostNbrMonths;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ReplacedINSS;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ApplicantINSS;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CertificateOrigin;

    /// <remarks/>
    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class ScaleSalaryActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ScaleSalaryStartDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ScaleSalaryEndDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ScaleSalaryEndDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "gYearMonth")]
    public string PecuniarySeniorityStartDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SalaryScaleReference;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ScaleSalaryAmount;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WeekHoursNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ScaleSalaryWeekHoursNbr;

    /// <remarks/>
    public ReducedScaleSalaryNotion ReducedScaleSalaryNotion;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ReducedScaleSalaryNotionSpecified;

    /// <remarks/>
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

    /// <remarks/>
    [XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationPSDEndDate;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool OccupationPSDEndDateSpecified;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string PublicSectorInstitutionType;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string PublicSectorPersonnelCategory;

    /// <remarks/>
    public string GradeOrFunction;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OfficialLanguage;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AssignmentType;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FunctionNature;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string StatutoryRelationEndReason;

    /// <remarks/>
    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class OccupationUpdateNotificationType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OccupationSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationStartingDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OccupationStartingDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationEndingDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OccupationEndingDateSpecified;

    /// <remarks/>
    public string JointCommissionNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkingDaysSystem;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContractType;

    /// <remarks/>
    [XmlElement(DataType = "integer")]
    public string RefMeanWorkingHours;

    /// <remarks/>
    public string WorkerStatus;

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string MeanWorkingHours;

    /// <remarks/>
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

    /// <remarks/>
    [XmlElementAttribute(DataType = "integer")]
    public string RemunMethod;

    /// <remarks/>
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string LocalUnitID;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ShipId;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string StaffCode;

    /// <remarks/>
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("6")]
    Item6,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("7")]
    Item7,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("8")]
    Item8,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class WRDclPartType {
    
    private string employerClassField;
    
    private string workerCodeField;
    
    private System.DateTime nOSSQuarterStartingDateField;
    
    private System.DateTime nOSSQuarterEndingDateField;
    
    private string borderField;
    
    private string activityWithRiskField;
    
    private string localUnitIDField;
    
    private string workerRecordUserReferenceField;
    
    private string workerRecordNewVersionNbrField;
    
    private string codeSubjectedField;
    
    private Action actionField;
    
    private BlockDecisionIndicator blockDecisionIndicatorField;
    
    private bool blockDecisionIndicatorFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerClass;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime NOSSQuarterStartingDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime NOSSQuarterEndingDate;

    /// <remarks/>
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerRecordNewVersionNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CodeSubjected;

    /// <remarks/>
    public Action Action;

    /// <remarks/>
    public BlockDecisionIndicator BlockDecisionIndicator;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum BlockDecisionIndicator {
    A,
    M,
    R,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class WorkerRecordUpdateNotifType {
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class NaturalPersonUpdateNotifType {
    
    private string naturalPersonSequenceNbrField;
    
    private string iNSSField;
    
    private string naturalPersonUserReferenceField;
    
    private string naturalPersonPIDField;
    
    private string declNaturalPersonPIDField;
    
    private string declNaturalPersonVersionNbrField;
    
    private string declNaturalPersonNewVersionNbrField;
    
    private Action actionField;
    
    private BlockDecisionIndicator blockDecisionIndicatorField;
    
    private bool blockDecisionIndicatorFieldSpecified;
    
    private RepaymentDecision repaymentDecisionField;
    
    private bool repaymentDecisionFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NaturalPersonSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string INSS;

    /// <remarks/>
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
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class EmployerDeclarationUpdateNotifType {
    
    private string quarterField;
    
    private string[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    private string companyIDField;
    
    private TransmissionMode transmissionModeField;
    
    private string employerDeclarationPIDField;
    
    private FaultyCode faultyCodeField;
    
    private bool faultyCodeFieldSpecified;
    
    private CalculationRequestArt54ter calculationRequestArt54terField;
    
    private bool calculationRequestArt54terFieldSpecified;
    
    private Notion22Quater notion22QuaterField;
    
    private bool notion22QuaterFieldSpecified;
    
    private string employerDeclarationNewVersionNbrField;
    
    private Action actionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Quarter;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("Trusteeship", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public string[] Items;

    /// <remarks/>
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

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FaultyCodeSpecified;

    /// <remarks/>
    public CalculationRequestArt54ter CalculationRequestArt54ter;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CalculationRequestArt54terSpecified;

    /// <remarks/>
    public Notion22Quater Notion22Quater;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Notion22QuaterSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerDeclarationNewVersionNbr;

    /// <remarks/>
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum FaultyCode { F, }


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum CalculationRequestArt54ter {
    S,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Notion22Quater {
    Q,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class FormType {
    
    private Identification identificationField;
    
    private System.DateTime formCreationDateField;
    
    private System.DateTime formCreationHourField;
    
    private AttestationStatus attestationStatusField;
    
    private TypeForm typeFormField;

    /// <remarks/>
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Identification {
    DMFANOT,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum AttestationStatus {
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum TypeForm {
    SU,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CUNPUpdateNotifType {
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class ComplementaryIndemnityActionType {
    
    private string employerNotionField;
    
    private string jointCommissionNbrField;
    
    private string activityCodeField;
    
    private DebtorType debtorTypeField;
    
    private bool debtorTypeFieldSpecified;
    
    private System.DateTime firstComplIndemnityDateField;
    
    private string complIndemnityAgreementNotionField;
    
    private string halfTimeCareerInterruptionNotionField;
    
    private string serviceExemptionNotionField;
    
    private string replacementAccordanceWCCNotionField;
    
    private string substituteINSSField;
    
    private string resumptionOfWorkMeasureField;
    
    private string complIndemnityNbrOfPartsField;
    
    private System.DateTime noticeDateField;
    
    private bool noticeDateFieldSpecified;
    
    private AilingOrReorgCompanyNotion ailingOrReorgCompanyNotionField;
    
    private bool ailingOrReorgCompanyNotionFieldSpecified;
    
    private System.DateTime acknowledgementStartDateField;
    
    private bool acknowledgementStartDateFieldSpecified;
    
    private System.DateTime acknowledgementEndDateField;
    
    private bool acknowledgementEndDateFieldSpecified;
    
    private Action actionField;

    /// <remarks/>
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

    /// <remarks/>
    public string ServiceExemptionNotion;

    /// <remarks/>
    public string ReplacementAccordanceWCCNotion;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SubstituteINSS;

    /// <remarks/>
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AcknowledgementStartDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AcknowledgementStartDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AcknowledgementEndDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AcknowledgementEndDateSpecified;

    /// <remarks/>
    public Action Action;
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum DebtorType {

    [System.Xml.Serialization.XmlEnumAttribute("0")]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum AilingOrReorgCompanyNotion {
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
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
public class AnomalyReportType {
    
    private string errorIDField;
    
    private string tagNameField;
    
    private string valueField;
    
    private string anomalyClassField;
    
    private string anomalyLabelField;

    /// <remarks/>
    public string ErrorID;

    /// <remarks/>
    public string TagName;

    /// <remarks/>
    public string Value;

    /// <remarks/>
    public string AnomalyClass;

    /// <remarks/>
    public string AnomalyLabel;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalScaleSalaryAction", Namespace="", IsNullable=false)]
public class AdditionalScaleSalaryActionType {
    
    private DateTime additionalScaleSalaryStartDateField;
    
    private DateTime additionalScaleSalaryEndDateField;
    
    private bool additionalScaleSalaryEndDateFieldSpecified;
    
    private string additionalScaleSalaryReferenceField;
    
    private string additionalScaleSalaryBasisAmountField;
    
    private string additionalScaleSalaryPercentageField;
    
    private string nbrHoursOrServicesField;
    
    private string additionalScaleSalaryAmountField;
    
    private Action actionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AdditionalScaleSalaryStartDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime AdditionalScaleSalaryEndDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdditionalScaleSalaryEndDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryReference;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryBasisAmount;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryPercentage;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NbrHoursOrServices;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AdditionalScaleSalaryAmount;

    /// <remarks/>
    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class AnomalyReport : AnomalyReportType
{
    public PathType Path;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("Path", Namespace="", IsNullable=false)]
public partial class PathType {
    
    private string quarterField;
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    private string trusteeshipField;
    
    private string companyIDField;
    
    private string unrelatedEmployerClassField;
    
    private string unrelatedWorkerCodeField;
    
    private string naturalPersonSequenceNbrField;
    
    private string iNSSField;
    
    private string employerClassField;
    
    private string workerCodeField;
    
    private string occupationSequenceNbrField;
    
    private string reorganisationMeasureField;
    
    private string serviceSequenceNbrField;
    
    private string serviceCodeField;
    
    private string remunSequenceNbrField;
    
    private string remunCodeField;
    
    private string bonusPaymentFrequencyField;
    
    private string percentagePaidField;
    
    private string deductionCodeField;
    
    private string deductionDetailSequenceNbrField;
    
    private string employerNotionField;
    
    private string jointCommissionNbrField;
    
    private string activityCodeField;
    
    private string complIndemnityAgreementNotionField;
    
    private string halfTimeCareerInterruptionNotionField;
    
    private string serviceExemptionNotionField;
    
    private string replacementAccordanceWCCNotionField;
    
    private string contributionWorkerCodeField;
    
    private string contributionTypeField;
    
    private ComplIndemnityAmountAdjustNotion complIndemnityAmountAdjustNotionField;
    
    private bool complIndemnityAmountAdjustNotionFieldSpecified;
    
    private string contributionSequenceNbrField;
    
    private string earlyRetirementCodeField;
    
    private string indemnityNatureField;
    
    private string incapacityDegreeField;
    
    private string naturalPersonUserReferenceField;
    
    private string workerRecordUserReferenceField;
    
    private string occupationUserReferenceField;
    
    private string companyVehicleSequenceNbrField;
    
    private string nPCalculatedAmountField;
    
    private string cUNPCalculatedAmountField;
    
    private string worksContractActorIdField;
    
    private System.DateTime occupationPSDStartDateField;
    
    private bool occupationPSDStartDateFieldSpecified;
    
    private string employerSequenceNbrField;
    
    private string careerElementSequenceNbrField;
    
    private string publicSectorInstitutionTypeField;
    
    private string publicSectorPersonnelCategoryField;
    
    private string assignmentTypeField;
    
    private string functionNatureField;
    
    private string scaleSalarySequenceNbrField;
    
    private System.DateTime scaleSalaryStartDateField;
    
    private bool scaleSalaryStartDateFieldSpecified;
    
    private string pecuniarySeniorityStartDateField;
    
    private string salaryScaleReferenceField;
    
    private string additionalScaleSalarySequenceNbrField;
    
    private string additionalScaleSalaryReferenceField;
    
    private System.DateTime additionalScaleSalaryStartDateField;
    
    private bool additionalScaleSalaryStartDateFieldSpecified;
    
    private NonSituableAbsenceCode nonSituableAbsenceCodeField;
    
    private bool nonSituableAbsenceCodeFieldSpecified;
    
    private string calendarYearField;
    
    private System.DateTime startingDateField;
    
    private bool startingDateFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Quarter;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Trusteeship;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyID;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedEmployerClass;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedWorkerCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string NaturalPersonSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string INSS;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerClass;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OccupationSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ReorganisationMeasure;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ServiceSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ServiceCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string RemunSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string RemunCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string BonusPaymentFrequency;

    /// <remarks/>
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

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdditionalScaleSalaryStartDateSpecified;

    /// <remarks/>
    public NonSituableAbsenceCode NonSituableAbsenceCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NonSituableAbsenceCodeSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CalendarYear;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime StartingDate;

    /// <remarks/>
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

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,

    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,

    [System.Xml.Serialization.XmlEnumAttribute("9")]
    Item9,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum NonSituableAbsenceCode
{
    [System.Xml.Serialization.XmlEnumAttribute("31")]
    Item31,

    [System.Xml.Serialization.XmlEnumAttribute("32")]
    Item32,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("33")]
    Item33,

    [System.Xml.Serialization.XmlEnumAttribute("41")]
    Item41,

    [System.Xml.Serialization.XmlEnumAttribute("42")]
    Item42,

    [System.Xml.Serialization.XmlEnumAttribute("43")]
    Item43,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum CapitalizationNotion {

    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CompanyVehicleCorrectedPart", Namespace="", IsNullable=false)]
public class CompanyVehicleCorrectedPartType {
    
    private string companyVehicleSequenceNbrField;
    
    private string licensePlateField;
    
    private string ecoVehicleField;
    
    private string companyVehicleNewVersionNbrField;
    
    private Action actionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleSequenceNbr;

    /// <remarks/>
    public string LicensePlate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EcoVehicle;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleNewVersionNbr;

    /// <remarks/>
    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("CompanyVehicleDclPart", Namespace="", IsNullable=false)]
public partial class CompanyVehicleDclPartType {

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleSequenceNbr;

    /// <remarks/>
    public string LicensePlate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EcoVehicle;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleNewVersionNbr;

    /// <remarks/>
    public Action Action;

    /// <remarks/>
    public BlockDecisionIndicator BlockDecisionIndicator;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CompanyVehicleUpdateNotif : CompanyVehicleUpdateNotifType {
    
    private LastSituationCompanyVehicleType lastSituationCompanyVehicleField;
    
    private CompanyVehicleDclPartType companyVehicleDclPartField;
    
    private CompanyVehicleCorrectedPartType companyVehicleCorrectedPartField;

    /// <remarks/>
    public LastSituationCompanyVehicleType LastSituationCompanyVehicle;

    /// <remarks/>
    public CompanyVehicleDclPartType CompanyVehicleDclPart;

    /// <remarks/>
    public CompanyVehicleCorrectedPartType CompanyVehicleCorrectedPart;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("LastSituationCompanyVehicle", Namespace="", IsNullable=false)]
public partial class LastSituationCompanyVehicleType {
    
    private string companyVehicleSequenceNbrField;
    
    private string licensePlateField;
    
    private string companyVehicleVersionNbrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleSequenceNbr;

    /// <remarks/>
    public string LicensePlate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CompanyVehicleVersionNbr;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ComplementaryIndemnityAction : ComplementaryIndemnityActionType {

    [System.Xml.Serialization.XmlElementAttribute("ComplIndemnityContributionAction")]
    public ComplIndemnityContributionActionType[] ComplIndemnityContributionAction;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("ComplIndemnityContributionAction", Namespace="", IsNullable=false)]
public partial class ComplIndemnityContributionActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionWorkerCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionType;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IndemnityContributionPeriodCode;

    /// <remarks/>
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

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IncompleteMonthNbrDays;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IncompleteMonthReason;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FloorApplicationNotion;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionAmount;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CUNPCorrectedPart", Namespace="", IsNullable=false)]
public class CUNPCorrectedPartType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedEmployerClass;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedWorkerCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedCalculationBasis;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContUnrelatedToNPNewVersionNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CodeSubjected;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("CUNPDclPart", Namespace="", IsNullable=false)]
public class CUNPDclPartType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
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


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
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
[System.Xml.Serialization.XmlRootAttribute("LastSituationCUNP", Namespace="", IsNullable=false)]
public class LastSituationCUNPType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedEmployerClass;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string UnrelatedWorkerCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContUnrelatedToNPVersionNbr;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("DeductionDetailAction", Namespace="", IsNullable=false)]
public partial class DeductionDetailActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionDetailSequenceNbr;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionDetailAmount;

    /// <remarks/>
    public string WorkingRegulationsRegistryNbr;
    
    /// <remarks/>
    [XmlElementAttribute(DataType = "date")]
    public DateTime WorkingRegulationsStartingDate;

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool WorkingRegulationsStartingDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AverageWorkingTimeBeforeReduction;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AverageWorkingTimeAfterReduction;

    /// <remarks/>
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string GrossRefRemunContributionAmount;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string RefNbrDays;
    
    /// <remarks/>
    [XmlElementAttribute(DataType = "date")]
    public DateTime SubjectionStartingDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime SubjectionEndingDate;

    /// <remarks/>
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


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("Reference", Namespace="", IsNullable=false)]
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
public enum ReferenceType1 {

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

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SubGroupDecisionIndicatorSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
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

    /// <remarks/>
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

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PSDDclExemptionSpecified;

    public SupplPensionContributionExemption SupplPensionContributionExemption;

    [XmlIgnoreAttribute()]
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

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CareerMeasure;

    public string ServiceExemptionNotion;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string HolidayDaysNumber;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SectorDetail;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string MobilityBudget;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
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


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum PSDDclExemption {
    [XmlEnumAttribute("1")] Item1,
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum SupplPensionContributionExemption {

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
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

    [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")] Item2,
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionWorkerCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionType;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionCalculationBasis;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionAmount;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime FirstHiringDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
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
