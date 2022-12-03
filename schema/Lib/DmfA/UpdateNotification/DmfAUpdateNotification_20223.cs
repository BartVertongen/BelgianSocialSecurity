

using System.Xml.Serialization;


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Action {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
    
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmployerClass;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string WorkerCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
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
public partial class WorkerDeductionActionType {
    
    private string deductionCodeField;
    
    private string deductionCalculationBasisField;
    
    private string deductionAmountField;
    
    private System.DateTime deductionRightStartingDateField;
    
    private bool deductionRightStartingDateFieldSpecified;
    
    private string managementCostNbrMonthsField;
    
    private string replacedINSSField;
    
    private string applicantINSSField;
    
    private string certificateOriginField;
    
    private Action actionField;

    /// <remarks/>
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
public partial class OccupationDeductionActionType {
    
    private string deductionCodeField;
    
    private string deductionCalculationBasisField;
    
    private string deductionAmountField;
    
    private System.DateTime deductionRightStartingDateField;
    
    private bool deductionRightStartingDateFieldSpecified;
    
    private string managementCostNbrMonthsField;
    
    private string replacedINSSField;
    
    private string applicantINSSField;
    
    private string certificateOriginField;
    
    private Action actionField;

    /// <remarks/>
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
public partial class ScaleSalaryActionType {
    
    private System.DateTime scaleSalaryStartDateField;
    
    private System.DateTime scaleSalaryEndDateField;
    
    private bool scaleSalaryEndDateFieldSpecified;
    
    private string pecuniarySeniorityStartDateField;
    
    private string salaryScaleReferenceField;
    
    private string scaleSalaryAmountField;
    
    private string weekHoursNbrField;
    
    private string scaleSalaryWeekHoursNbrField;
    
    private ReducedScaleSalaryNotion reducedScaleSalaryNotionField;
    
    private bool reducedScaleSalaryNotionFieldSpecified;
    
    private Action actionField;

    /// <remarks/>
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
public class OccupationPSDActionType {
    
    private System.DateTime occupationPSDStartDateField;
    
    private System.DateTime occupationPSDEndDateField;
    
    private bool occupationPSDEndDateFieldSpecified;
    
    private string publicSectorInstitutionTypeField;
    
    private string publicSectorPersonnelCategoryField;
    
    private string gradeOrFunctionField;
    
    private string officialLanguageField;
    
    private string assignmentTypeField;
    
    private string functionNatureField;
    
    private string statutoryRelationEndReasonField;
    
    private Action actionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationPSDStartDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime OccupationPSDEndDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OccupationPSDEndDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
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
public class OccupationUpdateNotificationType {
    
    private string occupationSequenceNbrField;
    
    private System.DateTime occupationStartingDateField;
    
    private bool occupationStartingDateFieldSpecified;
    
    private System.DateTime occupationEndingDateField;
    
    private bool occupationEndingDateFieldSpecified;
    
    private string jointCommissionNbrField;
    
    private string workingDaysSystemField;
    
    private string contractTypeField;
    
    private string refMeanWorkingHoursField;
    
    private string workerStatusField;
    
    private string meanWorkingHoursField;
    
    private string reorganisationMeasureField;
    
    private string employmentPromotionField;
    
    private string retiredField;
    
    private string apprenticeshipField;
    
    private string remunMethodField;
    
    private string positionCodeField;
    
    private string flyingStaffClassField;
    
    private string tenthOrTwelfthField;
    
    private string occupationUserReferenceField;
    
    private DaysJustification daysJustificationField;
    
    private bool daysJustificationFieldSpecified;
    
    private string activityCodeField;
    
    private string occupationVersionNbrField;
    
    private string occupationNewVersionNbrField;
    
    private Action actionField;
    
    private string localUnitIDField;
    
    private string shipIdField;
    
    private string staffCodeField;
    
    private string subsidizedMeanWorkingHoursField;

    /// <remarks/>
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string RefMeanWorkingHours;

    /// <remarks/>
    public string WorkerStatus;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string MeanWorkingHours;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ReorganisationMeasure;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string EmploymentPromotion;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Retired;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Apprenticeship;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string SubsidizedMeanWorkingHours {
        get {
            return this.subsidizedMeanWorkingHoursField;
        }
        set {
            this.subsidizedMeanWorkingHoursField = value;
        }
    }
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EmployerClass {
        get {
            return this.employerClassField;
        }
        set {
            this.employerClassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string WorkerCode {
        get {
            return this.workerCodeField;
        }
        set {
            this.workerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime NOSSQuarterStartingDate {
        get {
            return this.nOSSQuarterStartingDateField;
        }
        set {
            this.nOSSQuarterStartingDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime NOSSQuarterEndingDate {
        get {
            return this.nOSSQuarterEndingDateField;
        }
        set {
            this.nOSSQuarterEndingDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string Border {
        get {
            return this.borderField;
        }
        set {
            this.borderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ActivityWithRisk {
        get {
            return this.activityWithRiskField;
        }
        set {
            this.activityWithRiskField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string LocalUnitID {
        get {
            return this.localUnitIDField;
        }
        set {
            this.localUnitIDField = value;
        }
    }
    
    /// <remarks/>
    public string WorkerRecordUserReference {
        get {
            return this.workerRecordUserReferenceField;
        }
        set {
            this.workerRecordUserReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string WorkerRecordNewVersionNbr {
        get {
            return this.workerRecordNewVersionNbrField;
        }
        set {
            this.workerRecordNewVersionNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CodeSubjected {
        get {
            return this.codeSubjectedField;
        }
        set {
            this.codeSubjectedField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    public BlockDecisionIndicator BlockDecisionIndicator {
        get {
            return this.blockDecisionIndicatorField;
        }
        set {
            this.blockDecisionIndicatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified {
        get {
            return this.blockDecisionIndicatorFieldSpecified;
        }
        set {
            this.blockDecisionIndicatorFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum BlockDecisionIndicator {
    
    /// <remarks/>
    A,
    
    /// <remarks/>
    M,
    
    /// <remarks/>
    R,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class WorkerRecordUpdateNotifType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class NaturalPersonUpdateNotifType {
    
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string NaturalPersonSequenceNbr {
        get {
            return this.naturalPersonSequenceNbrField;
        }
        set {
            this.naturalPersonSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string INSS {
        get {
            return this.iNSSField;
        }
        set {
            this.iNSSField = value;
        }
    }
    
    /// <remarks/>
    public string NaturalPersonUserReference {
        get {
            return this.naturalPersonUserReferenceField;
        }
        set {
            this.naturalPersonUserReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string NaturalPersonPID {
        get {
            return this.naturalPersonPIDField;
        }
        set {
            this.naturalPersonPIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string DeclNaturalPersonPID {
        get {
            return this.declNaturalPersonPIDField;
        }
        set {
            this.declNaturalPersonPIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string DeclNaturalPersonVersionNbr {
        get {
            return this.declNaturalPersonVersionNbrField;
        }
        set {
            this.declNaturalPersonVersionNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string DeclNaturalPersonNewVersionNbr {
        get {
            return this.declNaturalPersonNewVersionNbrField;
        }
        set {
            this.declNaturalPersonNewVersionNbrField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    public BlockDecisionIndicator BlockDecisionIndicator {
        get {
            return this.blockDecisionIndicatorField;
        }
        set {
            this.blockDecisionIndicatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified {
        get {
            return this.blockDecisionIndicatorFieldSpecified;
        }
        set {
            this.blockDecisionIndicatorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public RepaymentDecision RepaymentDecision {
        get {
            return this.repaymentDecisionField;
        }
        set {
            this.repaymentDecisionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RepaymentDecisionSpecified {
        get {
            return this.repaymentDecisionFieldSpecified;
        }
        set {
            this.repaymentDecisionFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum RepaymentDecision {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string Quarter {
        get {
            return this.quarterField;
        }
        set {
            this.quarterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType="integer")]
    [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType="integer")]
    [System.Xml.Serialization.XmlElementAttribute("Trusteeship", typeof(string), DataType="integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public string[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyID {
        get {
            return this.companyIDField;
        }
        set {
            this.companyIDField = value;
        }
    }
    
    /// <remarks/>
    public TransmissionMode TransmissionMode {
        get {
            return this.transmissionModeField;
        }
        set {
            this.transmissionModeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EmployerDeclarationPID {
        get {
            return this.employerDeclarationPIDField;
        }
        set {
            this.employerDeclarationPIDField = value;
        }
    }
    
    /// <remarks/>
    public FaultyCode FaultyCode {
        get {
            return this.faultyCodeField;
        }
        set {
            this.faultyCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FaultyCodeSpecified {
        get {
            return this.faultyCodeFieldSpecified;
        }
        set {
            this.faultyCodeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public CalculationRequestArt54ter CalculationRequestArt54ter {
        get {
            return this.calculationRequestArt54terField;
        }
        set {
            this.calculationRequestArt54terField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CalculationRequestArt54terSpecified {
        get {
            return this.calculationRequestArt54terFieldSpecified;
        }
        set {
            this.calculationRequestArt54terFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public Notion22Quater Notion22Quater {
        get {
            return this.notion22QuaterField;
        }
        set {
            this.notion22QuaterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Notion22QuaterSpecified {
        get {
            return this.notion22QuaterFieldSpecified;
        }
        set {
            this.notion22QuaterFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EmployerDeclarationNewVersionNbr {
        get {
            return this.employerDeclarationNewVersionNbrField;
        }
        set {
            this.employerDeclarationNewVersionNbrField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    NOSSLPARegistrationNbr,
    
    /// <remarks/>
    NOSSRegistrationNbr,
    
    /// <remarks/>
    Trusteeship,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum TransmissionMode {
    
    /// <remarks/>
    WB,
    
    /// <remarks/>
    LO,
    
    /// <remarks/>
    CS,
    
    /// <remarks/>
    OD,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum FaultyCode {
    
    /// <remarks/>
    F,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum CalculationRequestArt54ter {
    
    /// <remarks/>
    S,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Notion22Quater {
    
    /// <remarks/>
    Q,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FormType {
    
    private Identification identificationField;
    
    private System.DateTime formCreationDateField;
    
    private System.DateTime formCreationHourField;
    
    private AttestationStatus attestationStatusField;
    
    private TypeForm typeFormField;
    
    /// <remarks/>
    public Identification Identification {
        get {
            return this.identificationField;
        }
        set {
            this.identificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime FormCreationDate {
        get {
            return this.formCreationDateField;
        }
        set {
            this.formCreationDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
    public System.DateTime FormCreationHour {
        get {
            return this.formCreationHourField;
        }
        set {
            this.formCreationHourField = value;
        }
    }
    
    /// <remarks/>
    public AttestationStatus AttestationStatus {
        get {
            return this.attestationStatusField;
        }
        set {
            this.attestationStatusField = value;
        }
    }
    
    /// <remarks/>
    public TypeForm TypeForm {
        get {
            return this.typeFormField;
        }
        set {
            this.typeFormField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum Identification {
    
    /// <remarks/>
    DMFANOT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum AttestationStatus {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum TypeForm {
    
    /// <remarks/>
    SU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CUNPUpdateNotifType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ComplementaryIndemnityActionType {
    
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EmployerNotion {
        get {
            return this.employerNotionField;
        }
        set {
            this.employerNotionField = value;
        }
    }
    
    /// <remarks/>
    public string JointCommissionNbr {
        get {
            return this.jointCommissionNbrField;
        }
        set {
            this.jointCommissionNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ActivityCode {
        get {
            return this.activityCodeField;
        }
        set {
            this.activityCodeField = value;
        }
    }
    
    /// <remarks/>
    public DebtorType DebtorType {
        get {
            return this.debtorTypeField;
        }
        set {
            this.debtorTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DebtorTypeSpecified {
        get {
            return this.debtorTypeFieldSpecified;
        }
        set {
            this.debtorTypeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime FirstComplIndemnityDate {
        get {
            return this.firstComplIndemnityDateField;
        }
        set {
            this.firstComplIndemnityDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ComplIndemnityAgreementNotion {
        get {
            return this.complIndemnityAgreementNotionField;
        }
        set {
            this.complIndemnityAgreementNotionField = value;
        }
    }
    
    /// <remarks/>
    public string HalfTimeCareerInterruptionNotion {
        get {
            return this.halfTimeCareerInterruptionNotionField;
        }
        set {
            this.halfTimeCareerInterruptionNotionField = value;
        }
    }
    
    /// <remarks/>
    public string ServiceExemptionNotion {
        get {
            return this.serviceExemptionNotionField;
        }
        set {
            this.serviceExemptionNotionField = value;
        }
    }
    
    /// <remarks/>
    public string ReplacementAccordanceWCCNotion {
        get {
            return this.replacementAccordanceWCCNotionField;
        }
        set {
            this.replacementAccordanceWCCNotionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string SubstituteINSS {
        get {
            return this.substituteINSSField;
        }
        set {
            this.substituteINSSField = value;
        }
    }
    
    /// <remarks/>
    public string ResumptionOfWorkMeasure {
        get {
            return this.resumptionOfWorkMeasureField;
        }
        set {
            this.resumptionOfWorkMeasureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ComplIndemnityNbrOfParts {
        get {
            return this.complIndemnityNbrOfPartsField;
        }
        set {
            this.complIndemnityNbrOfPartsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime NoticeDate {
        get {
            return this.noticeDateField;
        }
        set {
            this.noticeDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NoticeDateSpecified {
        get {
            return this.noticeDateFieldSpecified;
        }
        set {
            this.noticeDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion {
        get {
            return this.ailingOrReorgCompanyNotionField;
        }
        set {
            this.ailingOrReorgCompanyNotionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AilingOrReorgCompanyNotionSpecified {
        get {
            return this.ailingOrReorgCompanyNotionFieldSpecified;
        }
        set {
            this.ailingOrReorgCompanyNotionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime AcknowledgementStartDate {
        get {
            return this.acknowledgementStartDateField;
        }
        set {
            this.acknowledgementStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AcknowledgementStartDateSpecified {
        get {
            return this.acknowledgementStartDateFieldSpecified;
        }
        set {
            this.acknowledgementStartDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime AcknowledgementEndDate {
        get {
            return this.acknowledgementEndDateField;
        }
        set {
            this.acknowledgementEndDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AcknowledgementEndDateSpecified {
        get {
            return this.acknowledgementEndDateFieldSpecified;
        }
        set {
            this.acknowledgementEndDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum DebtorType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum AilingOrReorgCompanyNotion {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CompanyVehicleUpdateNotifType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AnomalyReportType {
    
    private string errorIDField;
    
    private string tagNameField;
    
    private string valueField;
    
    private string anomalyClassField;
    
    private string anomalyLabelField;
    
    /// <remarks/>
    public string ErrorID {
        get {
            return this.errorIDField;
        }
        set {
            this.errorIDField = value;
        }
    }
    
    /// <remarks/>
    public string TagName {
        get {
            return this.tagNameField;
        }
        set {
            this.tagNameField = value;
        }
    }
    
    /// <remarks/>
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public string AnomalyClass {
        get {
            return this.anomalyClassField;
        }
        set {
            this.anomalyClassField = value;
        }
    }
    
    /// <remarks/>
    public string AnomalyLabel {
        get {
            return this.anomalyLabelField;
        }
        set {
            this.anomalyLabelField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalScaleSalaryAction", Namespace="", IsNullable=false)]
public partial class AdditionalScaleSalaryActionType {
    
    private System.DateTime additionalScaleSalaryStartDateField;
    
    private System.DateTime additionalScaleSalaryEndDateField;
    
    private bool additionalScaleSalaryEndDateFieldSpecified;
    
    private string additionalScaleSalaryReferenceField;
    
    private string additionalScaleSalaryBasisAmountField;
    
    private string additionalScaleSalaryPercentageField;
    
    private string nbrHoursOrServicesField;
    
    private string additionalScaleSalaryAmountField;
    
    private Action actionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime AdditionalScaleSalaryStartDate {
        get {
            return this.additionalScaleSalaryStartDateField;
        }
        set {
            this.additionalScaleSalaryStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime AdditionalScaleSalaryEndDate {
        get {
            return this.additionalScaleSalaryEndDateField;
        }
        set {
            this.additionalScaleSalaryEndDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdditionalScaleSalaryEndDateSpecified {
        get {
            return this.additionalScaleSalaryEndDateFieldSpecified;
        }
        set {
            this.additionalScaleSalaryEndDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AdditionalScaleSalaryReference {
        get {
            return this.additionalScaleSalaryReferenceField;
        }
        set {
            this.additionalScaleSalaryReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AdditionalScaleSalaryBasisAmount {
        get {
            return this.additionalScaleSalaryBasisAmountField;
        }
        set {
            this.additionalScaleSalaryBasisAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AdditionalScaleSalaryPercentage {
        get {
            return this.additionalScaleSalaryPercentageField;
        }
        set {
            this.additionalScaleSalaryPercentageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string NbrHoursOrServices {
        get {
            return this.nbrHoursOrServicesField;
        }
        set {
            this.nbrHoursOrServicesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AdditionalScaleSalaryAmount {
        get {
            return this.additionalScaleSalaryAmountField;
        }
        set {
            this.additionalScaleSalaryAmountField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class AnomalyReport : AnomalyReportType {
    
    private PathType pathField;
    
    /// <remarks/>
    public PathType Path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string Quarter {
        get {
            return this.quarterField;
        }
        set {
            this.quarterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NOSSLPARegistrationNbr", typeof(string), DataType="integer")]
    [System.Xml.Serialization.XmlElementAttribute("NOSSRegistrationNbr", typeof(string), DataType="integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string Trusteeship {
        get {
            return this.trusteeshipField;
        }
        set {
            this.trusteeshipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyID {
        get {
            return this.companyIDField;
        }
        set {
            this.companyIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedEmployerClass {
        get {
            return this.unrelatedEmployerClassField;
        }
        set {
            this.unrelatedEmployerClassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedWorkerCode {
        get {
            return this.unrelatedWorkerCodeField;
        }
        set {
            this.unrelatedWorkerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string NaturalPersonSequenceNbr {
        get {
            return this.naturalPersonSequenceNbrField;
        }
        set {
            this.naturalPersonSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string INSS {
        get {
            return this.iNSSField;
        }
        set {
            this.iNSSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EmployerClass {
        get {
            return this.employerClassField;
        }
        set {
            this.employerClassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string WorkerCode {
        get {
            return this.workerCodeField;
        }
        set {
            this.workerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string OccupationSequenceNbr {
        get {
            return this.occupationSequenceNbrField;
        }
        set {
            this.occupationSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ReorganisationMeasure {
        get {
            return this.reorganisationMeasureField;
        }
        set {
            this.reorganisationMeasureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ServiceSequenceNbr {
        get {
            return this.serviceSequenceNbrField;
        }
        set {
            this.serviceSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ServiceCode {
        get {
            return this.serviceCodeField;
        }
        set {
            this.serviceCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string RemunSequenceNbr {
        get {
            return this.remunSequenceNbrField;
        }
        set {
            this.remunSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string RemunCode {
        get {
            return this.remunCodeField;
        }
        set {
            this.remunCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string BonusPaymentFrequency {
        get {
            return this.bonusPaymentFrequencyField;
        }
        set {
            this.bonusPaymentFrequencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string PercentagePaid {
        get {
            return this.percentagePaidField;
        }
        set {
            this.percentagePaidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string DeductionCode {
        get {
            return this.deductionCodeField;
        }
        set {
            this.deductionCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string DeductionDetailSequenceNbr {
        get {
            return this.deductionDetailSequenceNbrField;
        }
        set {
            this.deductionDetailSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EmployerNotion {
        get {
            return this.employerNotionField;
        }
        set {
            this.employerNotionField = value;
        }
    }
    
    /// <remarks/>
    public string JointCommissionNbr {
        get {
            return this.jointCommissionNbrField;
        }
        set {
            this.jointCommissionNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ActivityCode {
        get {
            return this.activityCodeField;
        }
        set {
            this.activityCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ComplIndemnityAgreementNotion {
        get {
            return this.complIndemnityAgreementNotionField;
        }
        set {
            this.complIndemnityAgreementNotionField = value;
        }
    }
    
    /// <remarks/>
    public string HalfTimeCareerInterruptionNotion {
        get {
            return this.halfTimeCareerInterruptionNotionField;
        }
        set {
            this.halfTimeCareerInterruptionNotionField = value;
        }
    }
    
    /// <remarks/>
    public string ServiceExemptionNotion {
        get {
            return this.serviceExemptionNotionField;
        }
        set {
            this.serviceExemptionNotionField = value;
        }
    }
    
    /// <remarks/>
    public string ReplacementAccordanceWCCNotion {
        get {
            return this.replacementAccordanceWCCNotionField;
        }
        set {
            this.replacementAccordanceWCCNotionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContributionWorkerCode {
        get {
            return this.contributionWorkerCodeField;
        }
        set {
            this.contributionWorkerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContributionType {
        get {
            return this.contributionTypeField;
        }
        set {
            this.contributionTypeField = value;
        }
    }
    
    /// <remarks/>
    public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion {
        get {
            return this.complIndemnityAmountAdjustNotionField;
        }
        set {
            this.complIndemnityAmountAdjustNotionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ComplIndemnityAmountAdjustNotionSpecified {
        get {
            return this.complIndemnityAmountAdjustNotionFieldSpecified;
        }
        set {
            this.complIndemnityAmountAdjustNotionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContributionSequenceNbr {
        get {
            return this.contributionSequenceNbrField;
        }
        set {
            this.contributionSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EarlyRetirementCode {
        get {
            return this.earlyRetirementCodeField;
        }
        set {
            this.earlyRetirementCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string IndemnityNature {
        get {
            return this.indemnityNatureField;
        }
        set {
            this.indemnityNatureField = value;
        }
    }
    
    /// <remarks/>
    public string IncapacityDegree {
        get {
            return this.incapacityDegreeField;
        }
        set {
            this.incapacityDegreeField = value;
        }
    }
    
    /// <remarks/>
    public string NaturalPersonUserReference {
        get {
            return this.naturalPersonUserReferenceField;
        }
        set {
            this.naturalPersonUserReferenceField = value;
        }
    }
    
    /// <remarks/>
    public string WorkerRecordUserReference {
        get {
            return this.workerRecordUserReferenceField;
        }
        set {
            this.workerRecordUserReferenceField = value;
        }
    }
    
    /// <remarks/>
    public string OccupationUserReference {
        get {
            return this.occupationUserReferenceField;
        }
        set {
            this.occupationUserReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyVehicleSequenceNbr {
        get {
            return this.companyVehicleSequenceNbrField;
        }
        set {
            this.companyVehicleSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    public string NPCalculatedAmount {
        get {
            return this.nPCalculatedAmountField;
        }
        set {
            this.nPCalculatedAmountField = value;
        }
    }
    
    /// <remarks/>
    public string CUNPCalculatedAmount {
        get {
            return this.cUNPCalculatedAmountField;
        }
        set {
            this.cUNPCalculatedAmountField = value;
        }
    }
    
    /// <remarks/>
    public string WorksContractActorId {
        get {
            return this.worksContractActorIdField;
        }
        set {
            this.worksContractActorIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime OccupationPSDStartDate {
        get {
            return this.occupationPSDStartDateField;
        }
        set {
            this.occupationPSDStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OccupationPSDStartDateSpecified {
        get {
            return this.occupationPSDStartDateFieldSpecified;
        }
        set {
            this.occupationPSDStartDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EmployerSequenceNbr {
        get {
            return this.employerSequenceNbrField;
        }
        set {
            this.employerSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CareerElementSequenceNbr {
        get {
            return this.careerElementSequenceNbrField;
        }
        set {
            this.careerElementSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string PublicSectorInstitutionType {
        get {
            return this.publicSectorInstitutionTypeField;
        }
        set {
            this.publicSectorInstitutionTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string PublicSectorPersonnelCategory {
        get {
            return this.publicSectorPersonnelCategoryField;
        }
        set {
            this.publicSectorPersonnelCategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AssignmentType {
        get {
            return this.assignmentTypeField;
        }
        set {
            this.assignmentTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string FunctionNature {
        get {
            return this.functionNatureField;
        }
        set {
            this.functionNatureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ScaleSalarySequenceNbr {
        get {
            return this.scaleSalarySequenceNbrField;
        }
        set {
            this.scaleSalarySequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ScaleSalaryStartDate {
        get {
            return this.scaleSalaryStartDateField;
        }
        set {
            this.scaleSalaryStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ScaleSalaryStartDateSpecified {
        get {
            return this.scaleSalaryStartDateFieldSpecified;
        }
        set {
            this.scaleSalaryStartDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="gYearMonth")]
    public string PecuniarySeniorityStartDate {
        get {
            return this.pecuniarySeniorityStartDateField;
        }
        set {
            this.pecuniarySeniorityStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string SalaryScaleReference {
        get {
            return this.salaryScaleReferenceField;
        }
        set {
            this.salaryScaleReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AdditionalScaleSalarySequenceNbr {
        get {
            return this.additionalScaleSalarySequenceNbrField;
        }
        set {
            this.additionalScaleSalarySequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AdditionalScaleSalaryReference {
        get {
            return this.additionalScaleSalaryReferenceField;
        }
        set {
            this.additionalScaleSalaryReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime AdditionalScaleSalaryStartDate {
        get {
            return this.additionalScaleSalaryStartDateField;
        }
        set {
            this.additionalScaleSalaryStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AdditionalScaleSalaryStartDateSpecified {
        get {
            return this.additionalScaleSalaryStartDateFieldSpecified;
        }
        set {
            this.additionalScaleSalaryStartDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public NonSituableAbsenceCode NonSituableAbsenceCode {
        get {
            return this.nonSituableAbsenceCodeField;
        }
        set {
            this.nonSituableAbsenceCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NonSituableAbsenceCodeSpecified {
        get {
            return this.nonSituableAbsenceCodeFieldSpecified;
        }
        set {
            this.nonSituableAbsenceCodeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CalendarYear {
        get {
            return this.calendarYearField;
        }
        set {
            this.calendarYearField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime StartingDate {
        get {
            return this.startingDateField;
        }
        set {
            this.startingDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool StartingDateSpecified {
        get {
            return this.startingDateFieldSpecified;
        }
        set {
            this.startingDateFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    NOSSLPARegistrationNbr,
    
    /// <remarks/>
    NOSSRegistrationNbr,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum ComplIndemnityAmountAdjustNotion {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("9")]
    Item9,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum NonSituableAbsenceCode {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("31")]
    Item31,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("32")]
    Item32,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("33")]
    Item33,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("41")]
    Item41,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("42")]
    Item42,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("43")]
    Item43,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum CapitalizationNotion {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CompanyVehicleCorrectedPart", Namespace="", IsNullable=false)]
public partial class CompanyVehicleCorrectedPartType {
    
    private string companyVehicleSequenceNbrField;
    
    private string licensePlateField;
    
    private string ecoVehicleField;
    
    private string companyVehicleNewVersionNbrField;
    
    private Action actionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyVehicleSequenceNbr {
        get {
            return this.companyVehicleSequenceNbrField;
        }
        set {
            this.companyVehicleSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    public string LicensePlate {
        get {
            return this.licensePlateField;
        }
        set {
            this.licensePlateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EcoVehicle {
        get {
            return this.ecoVehicleField;
        }
        set {
            this.ecoVehicleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyVehicleNewVersionNbr {
        get {
            return this.companyVehicleNewVersionNbrField;
        }
        set {
            this.companyVehicleNewVersionNbrField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CompanyVehicleDclPart", Namespace="", IsNullable=false)]
public partial class CompanyVehicleDclPartType {
    
    private string companyVehicleSequenceNbrField;
    
    private string licensePlateField;
    
    private string ecoVehicleField;
    
    private string companyVehicleNewVersionNbrField;
    
    private Action actionField;
    
    private BlockDecisionIndicator blockDecisionIndicatorField;
    
    private bool blockDecisionIndicatorFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyVehicleSequenceNbr {
        get {
            return this.companyVehicleSequenceNbrField;
        }
        set {
            this.companyVehicleSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    public string LicensePlate {
        get {
            return this.licensePlateField;
        }
        set {
            this.licensePlateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EcoVehicle {
        get {
            return this.ecoVehicleField;
        }
        set {
            this.ecoVehicleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyVehicleNewVersionNbr {
        get {
            return this.companyVehicleNewVersionNbrField;
        }
        set {
            this.companyVehicleNewVersionNbrField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    public BlockDecisionIndicator BlockDecisionIndicator {
        get {
            return this.blockDecisionIndicatorField;
        }
        set {
            this.blockDecisionIndicatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified {
        get {
            return this.blockDecisionIndicatorFieldSpecified;
        }
        set {
            this.blockDecisionIndicatorFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
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
    public LastSituationCompanyVehicleType LastSituationCompanyVehicle {
        get {
            return this.lastSituationCompanyVehicleField;
        }
        set {
            this.lastSituationCompanyVehicleField = value;
        }
    }
    
    /// <remarks/>
    public CompanyVehicleDclPartType CompanyVehicleDclPart {
        get {
            return this.companyVehicleDclPartField;
        }
        set {
            this.companyVehicleDclPartField = value;
        }
    }
    
    /// <remarks/>
    public CompanyVehicleCorrectedPartType CompanyVehicleCorrectedPart {
        get {
            return this.companyVehicleCorrectedPartField;
        }
        set {
            this.companyVehicleCorrectedPartField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("LastSituationCompanyVehicle", Namespace="", IsNullable=false)]
public partial class LastSituationCompanyVehicleType {
    
    private string companyVehicleSequenceNbrField;
    
    private string licensePlateField;
    
    private string companyVehicleVersionNbrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyVehicleSequenceNbr {
        get {
            return this.companyVehicleSequenceNbrField;
        }
        set {
            this.companyVehicleSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    public string LicensePlate {
        get {
            return this.licensePlateField;
        }
        set {
            this.licensePlateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CompanyVehicleVersionNbr {
        get {
            return this.companyVehicleVersionNbrField;
        }
        set {
            this.companyVehicleVersionNbrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ComplementaryIndemnityAction : ComplementaryIndemnityActionType {
    
    private ComplIndemnityContributionActionType[] complIndemnityContributionActionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ComplIndemnityContributionAction")]
    public ComplIndemnityContributionActionType[] ComplIndemnityContributionAction {
        get {
            return this.complIndemnityContributionActionField;
        }
        set {
            this.complIndemnityContributionActionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("ComplIndemnityContributionAction", Namespace="", IsNullable=false)]
public partial class ComplIndemnityContributionActionType {
    
    private string contributionWorkerCodeField;
    
    private string contributionTypeField;
    
    private string indemnityContributionPeriodCodeField;
    
    private ComplIndemnityAmountAdjustNotion complIndemnityAmountAdjustNotionField;
    
    private string contributionSequenceNbrField;
    
    private string complIndemnityAmountField;
    
    private CapitalizationNotion capitalizationNotionField;
    
    private bool capitalizationNotionFieldSpecified;
    
    private string welfareBenefitTheoreticalAmountField;
    
    private string complIndemnityNbrMonthsField;
    
    private string nbrMonthsDecimalsField;
    
    private string incompleteMonthNbrDaysField;
    
    private string incompleteMonthReasonField;
    
    private string floorApplicationNotionField;
    
    private string contributionAmountField;
    
    private Action actionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContributionWorkerCode {
        get {
            return this.contributionWorkerCodeField;
        }
        set {
            this.contributionWorkerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContributionType {
        get {
            return this.contributionTypeField;
        }
        set {
            this.contributionTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string IndemnityContributionPeriodCode {
        get {
            return this.indemnityContributionPeriodCodeField;
        }
        set {
            this.indemnityContributionPeriodCodeField = value;
        }
    }
    
    /// <remarks/>
    public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion {
        get {
            return this.complIndemnityAmountAdjustNotionField;
        }
        set {
            this.complIndemnityAmountAdjustNotionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContributionSequenceNbr {
        get {
            return this.contributionSequenceNbrField;
        }
        set {
            this.contributionSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ComplIndemnityAmount {
        get {
            return this.complIndemnityAmountField;
        }
        set {
            this.complIndemnityAmountField = value;
        }
    }
    
    /// <remarks/>
    public CapitalizationNotion CapitalizationNotion {
        get {
            return this.capitalizationNotionField;
        }
        set {
            this.capitalizationNotionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CapitalizationNotionSpecified {
        get {
            return this.capitalizationNotionFieldSpecified;
        }
        set {
            this.capitalizationNotionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string WelfareBenefitTheoreticalAmount {
        get {
            return this.welfareBenefitTheoreticalAmountField;
        }
        set {
            this.welfareBenefitTheoreticalAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ComplIndemnityNbrMonths {
        get {
            return this.complIndemnityNbrMonthsField;
        }
        set {
            this.complIndemnityNbrMonthsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string NbrMonthsDecimals {
        get {
            return this.nbrMonthsDecimalsField;
        }
        set {
            this.nbrMonthsDecimalsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string IncompleteMonthNbrDays {
        get {
            return this.incompleteMonthNbrDaysField;
        }
        set {
            this.incompleteMonthNbrDaysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string IncompleteMonthReason {
        get {
            return this.incompleteMonthReasonField;
        }
        set {
            this.incompleteMonthReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string FloorApplicationNotion {
        get {
            return this.floorApplicationNotionField;
        }
        set {
            this.floorApplicationNotionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContributionAmount {
        get {
            return this.contributionAmountField;
        }
        set {
            this.contributionAmountField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CUNPCorrectedPart", Namespace="", IsNullable=false)]
public partial class CUNPCorrectedPartType {
    
    private string unrelatedEmployerClassField;
    
    private string unrelatedWorkerCodeField;
    
    private string unrelatedCalculationBasisField;
    
    private string unrelatedAmountField;
    
    private string contUnrelatedToNPNewVersionNbrField;
    
    private string codeSubjectedField;
    
    private Action actionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedEmployerClass {
        get {
            return this.unrelatedEmployerClassField;
        }
        set {
            this.unrelatedEmployerClassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedWorkerCode {
        get {
            return this.unrelatedWorkerCodeField;
        }
        set {
            this.unrelatedWorkerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedCalculationBasis {
        get {
            return this.unrelatedCalculationBasisField;
        }
        set {
            this.unrelatedCalculationBasisField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedAmount {
        get {
            return this.unrelatedAmountField;
        }
        set {
            this.unrelatedAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContUnrelatedToNPNewVersionNbr {
        get {
            return this.contUnrelatedToNPNewVersionNbrField;
        }
        set {
            this.contUnrelatedToNPNewVersionNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CodeSubjected {
        get {
            return this.codeSubjectedField;
        }
        set {
            this.codeSubjectedField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CUNPDclPart", Namespace="", IsNullable=false)]
public partial class CUNPDclPartType {
    
    private string unrelatedEmployerClassField;
    
    private string unrelatedWorkerCodeField;
    
    private string unrelatedCalculationBasisField;
    
    private string unrelatedAmountField;
    
    private string contUnrelatedToNPNewVersionNbrField;
    
    private string codeSubjectedField;
    
    private Action actionField;
    
    private BlockDecisionIndicator blockDecisionIndicatorField;
    
    private bool blockDecisionIndicatorFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedEmployerClass {
        get {
            return this.unrelatedEmployerClassField;
        }
        set {
            this.unrelatedEmployerClassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedWorkerCode {
        get {
            return this.unrelatedWorkerCodeField;
        }
        set {
            this.unrelatedWorkerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedCalculationBasis {
        get {
            return this.unrelatedCalculationBasisField;
        }
        set {
            this.unrelatedCalculationBasisField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedAmount {
        get {
            return this.unrelatedAmountField;
        }
        set {
            this.unrelatedAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContUnrelatedToNPNewVersionNbr {
        get {
            return this.contUnrelatedToNPNewVersionNbrField;
        }
        set {
            this.contUnrelatedToNPNewVersionNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string CodeSubjected {
        get {
            return this.codeSubjectedField;
        }
        set {
            this.codeSubjectedField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    public BlockDecisionIndicator BlockDecisionIndicator {
        get {
            return this.blockDecisionIndicatorField;
        }
        set {
            this.blockDecisionIndicatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockDecisionIndicatorSpecified {
        get {
            return this.blockDecisionIndicatorFieldSpecified;
        }
        set {
            this.blockDecisionIndicatorFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CUNPUpdateNotif : CUNPUpdateNotifType {
    
    private LastSituationCUNPType lastSituationCUNPField;
    
    private CUNPDclPartType cUNPDclPartField;
    
    private CUNPCorrectedPartType cUNPCorrectedPartField;
    
    private AnomalyReport[] anomalyReportField;
    
    /// <remarks/>
    public LastSituationCUNPType LastSituationCUNP {
        get {
            return this.lastSituationCUNPField;
        }
        set {
            this.lastSituationCUNPField = value;
        }
    }
    
    /// <remarks/>
    public CUNPDclPartType CUNPDclPart {
        get {
            return this.cUNPDclPartField;
        }
        set {
            this.cUNPDclPartField = value;
        }
    }
    
    /// <remarks/>
    public CUNPCorrectedPartType CUNPCorrectedPart {
        get {
            return this.cUNPCorrectedPartField;
        }
        set {
            this.cUNPCorrectedPartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnomalyReport")]
    public AnomalyReport[] AnomalyReport {
        get {
            return this.anomalyReportField;
        }
        set {
            this.anomalyReportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("LastSituationCUNP", Namespace="", IsNullable=false)]
public partial class LastSituationCUNPType {
    
    private string unrelatedEmployerClassField;
    
    private string unrelatedWorkerCodeField;
    
    private string contUnrelatedToNPVersionNbrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedEmployerClass {
        get {
            return this.unrelatedEmployerClassField;
        }
        set {
            this.unrelatedEmployerClassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UnrelatedWorkerCode {
        get {
            return this.unrelatedWorkerCodeField;
        }
        set {
            this.unrelatedWorkerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string ContUnrelatedToNPVersionNbr {
        get {
            return this.contUnrelatedToNPVersionNbrField;
        }
        set {
            this.contUnrelatedToNPVersionNbrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("DeductionDetailAction", Namespace="", IsNullable=false)]
public partial class DeductionDetailActionType {
    
    private string deductionDetailSequenceNbrField;
    
    private string deductionDetailAmountField;
    
    private string workingRegulationsRegistryNbrField;
    
    private System.DateTime workingRegulationsStartingDateField;
    
    private bool workingRegulationsStartingDateFieldSpecified;
    
    private string averageWorkingTimeBeforeReductionField;
    
    private string averageWorkingTimeAfterReductionField;
    
    private Action actionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string DeductionDetailSequenceNbr {
        get {
            return this.deductionDetailSequenceNbrField;
        }
        set {
            this.deductionDetailSequenceNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string DeductionDetailAmount {
        get {
            return this.deductionDetailAmountField;
        }
        set {
            this.deductionDetailAmountField = value;
        }
    }
    
    /// <remarks/>
    public string WorkingRegulationsRegistryNbr {
        get {
            return this.workingRegulationsRegistryNbrField;
        }
        set {
            this.workingRegulationsRegistryNbrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime WorkingRegulationsStartingDate {
        get {
            return this.workingRegulationsStartingDateField;
        }
        set {
            this.workingRegulationsStartingDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WorkingRegulationsStartingDateSpecified {
        get {
            return this.workingRegulationsStartingDateFieldSpecified;
        }
        set {
            this.workingRegulationsStartingDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AverageWorkingTimeBeforeReduction {
        get {
            return this.averageWorkingTimeBeforeReductionField;
        }
        set {
            this.averageWorkingTimeBeforeReductionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string AverageWorkingTimeAfterReduction {
        get {
            return this.averageWorkingTimeAfterReductionField;
        }
        set {
            this.averageWorkingTimeAfterReductionField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("DismissedStatWorkerContAction", Namespace="", IsNullable=false)]
public partial class DismissedStatWorkerContActionType {
    
    private string grossRefRemunAmountField;
    
    private string grossRefRemunContributionAmountField;
    
    private string refNbrDaysField;
    
    private System.DateTime subjectionStartingDateField;
    
    private System.DateTime subjectionEndingDateField;
    
    private Action actionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string GrossRefRemunAmount {
        get {
            return this.grossRefRemunAmountField;
        }
        set {
            this.grossRefRemunAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string GrossRefRemunContributionAmount {
        get {
            return this.grossRefRemunContributionAmountField;
        }
        set {
            this.grossRefRemunContributionAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string RefNbrDays {
        get {
            return this.refNbrDaysField;
        }
        set {
            this.refNbrDaysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime SubjectionStartingDate {
        get {
            return this.subjectionStartingDateField;
        }
        set {
            this.subjectionStartingDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime SubjectionEndingDate {
        get {
            return this.subjectionEndingDateField;
        }
        set {
            this.subjectionEndingDateField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DmfAUpdateNotification {
    
    private Form formField;
    
    /// <remarks/>
    public Form Form {
        get {
            return this.formField;
        }
        set {
            this.formField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Form : FormType {
    
    private ReferenceType[] referenceField;
    
    private EmployerDeclarationUpdateNotif employerDeclarationUpdateNotifField;
    
    private RectificationAmountType rectificationAmountField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Reference")]
    public ReferenceType[] Reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
    
    /// <remarks/>
    public EmployerDeclarationUpdateNotif EmployerDeclarationUpdateNotif {
        get {
            return this.employerDeclarationUpdateNotifField;
        }
        set {
            this.employerDeclarationUpdateNotifField = value;
        }
    }
    
    /// <remarks/>
    public RectificationAmountType RectificationAmount {
        get {
            return this.rectificationAmountField;
        }
        set {
            this.rectificationAmountField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("Reference", Namespace="", IsNullable=false)]
public partial class ReferenceType {
    
    private ReferenceType1 referenceType1Field;
    
    private ReferenceOrigin referenceOriginField;
    
    private string referenceNbrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReferenceType")]
    public ReferenceType1 ReferenceType1 {
        get {
            return this.referenceType1Field;
        }
        set {
            this.referenceType1Field = value;
        }
    }
    
    /// <remarks/>
    public ReferenceOrigin ReferenceOrigin {
        get {
            return this.referenceOriginField;
        }
        set {
            this.referenceOriginField = value;
        }
    }
    
    /// <remarks/>
    public string ReferenceNbr {
        get {
            return this.referenceNbrField;
        }
        set {
            this.referenceNbrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("ReferenceType", Namespace="", IsNullable=false)]
public enum ReferenceType1 {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum ReferenceOrigin {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class EmployerDeclarationUpdateNotif : EmployerDeclarationUpdateNotifType {
    
    private SubGroupInformationType[] subGroupInformationField;
    
    private object[] items1Field;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubGroupInformation")]
    public SubGroupInformationType[] SubGroupInformation {
        get {
            return this.subGroupInformationField;
        }
        set {
            this.subGroupInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CUNPUpdateNotif", typeof(CUNPUpdateNotif))]
    [System.Xml.Serialization.XmlElementAttribute("CompanyVehicleUpdateNotif", typeof(CompanyVehicleUpdateNotif))]
    [System.Xml.Serialization.XmlElementAttribute("NaturalPersonUpdateNotif", typeof(NaturalPersonUpdateNotif))]
    public object[] Items1 {
        get {
            return this.items1Field;
        }
        set {
            this.items1Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("SubGroupInformation", Namespace="", IsNullable=false)]
public partial class SubGroupInformationType {
    
    private string subGroupField;
    
    private SubGroupDecisionIndicator subGroupDecisionIndicatorField;
    
    private bool subGroupDecisionIndicatorFieldSpecified;
    
    private string userQualityField;
    
    private string justificationField;
    
    private string justificationCodeField;
    
    private System.DateTime justificationDateField;
    
    private bool justificationDateFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string SubGroup {
        get {
            return this.subGroupField;
        }
        set {
            this.subGroupField = value;
        }
    }
    
    /// <remarks/>
    public SubGroupDecisionIndicator SubGroupDecisionIndicator {
        get {
            return this.subGroupDecisionIndicatorField;
        }
        set {
            this.subGroupDecisionIndicatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SubGroupDecisionIndicatorSpecified {
        get {
            return this.subGroupDecisionIndicatorFieldSpecified;
        }
        set {
            this.subGroupDecisionIndicatorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string UserQuality {
        get {
            return this.userQualityField;
        }
        set {
            this.userQualityField = value;
        }
    }
    
    /// <remarks/>
    public string Justification {
        get {
            return this.justificationField;
        }
        set {
            this.justificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string JustificationCode {
        get {
            return this.justificationCodeField;
        }
        set {
            this.justificationCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime JustificationDate {
        get {
            return this.justificationDateField;
        }
        set {
            this.justificationDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool JustificationDateSpecified {
        get {
            return this.justificationDateFieldSpecified;
        }
        set {
            this.justificationDateFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum SubGroupDecisionIndicator {
    
    /// <remarks/>
    R,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NaturalPersonUpdateNotif : NaturalPersonUpdateNotifType {
    
    private WorkerRecordUpdateNotif[] workerRecordUpdateNotifField;
    
    private NaturalPersonJustificationType[] naturalPersonJustificationField;
    
    private AnomalyReport[] anomalyReportField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WorkerRecordUpdateNotif")]
    public WorkerRecordUpdateNotif[] WorkerRecordUpdateNotif {
        get {
            return this.workerRecordUpdateNotifField;
        }
        set {
            this.workerRecordUpdateNotifField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NaturalPersonJustification")]
    public NaturalPersonJustificationType[] NaturalPersonJustification {
        get {
            return this.naturalPersonJustificationField;
        }
        set {
            this.naturalPersonJustificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnomalyReport")]
    public AnomalyReport[] AnomalyReport {
        get {
            return this.anomalyReportField;
        }
        set {
            this.anomalyReportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class WorkerRecordUpdateNotif : WorkerRecordUpdateNotifType {
    
    private LastSituationWRType lastSituationWRField;
    
    private WRDclPart wRDclPartField;
    
    private WRCorrectedPart wRCorrectedPartField;
    
    /// <remarks/>
    public LastSituationWRType LastSituationWR {
        get {
            return this.lastSituationWRField;
        }
        set {
            this.lastSituationWRField = value;
        }
    }
    
    /// <remarks/>
    public WRDclPart WRDclPart {
        get {
            return this.wRDclPartField;
        }
        set {
            this.wRDclPartField = value;
        }
    }
    
    /// <remarks/>
    public WRCorrectedPart WRCorrectedPart {
        get {
            return this.wRCorrectedPartField;
        }
        set {
            this.wRCorrectedPartField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("LastSituationWR", Namespace="", IsNullable=false)]
public partial class LastSituationWRType {
    
    private string employerClassField;
    
    private string workerCodeField;
    
    private string workerRecordVersionNbrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EmployerClass {
        get {
            return this.employerClassField;
        }
        set {
            this.employerClassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string WorkerCode {
        get {
            return this.workerCodeField;
        }
        set {
            this.workerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string WorkerRecordVersionNbr {
        get {
            return this.workerRecordVersionNbrField;
        }
        set {
            this.workerRecordVersionNbrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class WRDclPart : WRDclPartType {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ActivationInformationAction", typeof(ActivationInformationActionType))]
    [System.Xml.Serialization.XmlElementAttribute("ComplementaryIndemnityAction", typeof(ComplementaryIndemnityAction))]
    [System.Xml.Serialization.XmlElementAttribute("DismissedStatWorkerContAction", typeof(DismissedStatWorkerContActionType))]
    [System.Xml.Serialization.XmlElementAttribute("EarlyRetirementContAction", typeof(EarlyRetirementContActionType))]
    [System.Xml.Serialization.XmlElementAttribute("IndemnityWAPMAction", typeof(IndemnityWAPMActionType))]
    [System.Xml.Serialization.XmlElementAttribute("OccupationUpdateNotification", typeof(OccupationUpdateNotification))]
    [System.Xml.Serialization.XmlElementAttribute("StudentContributionAction", typeof(StudentContributionActionType))]
    [System.Xml.Serialization.XmlElementAttribute("WorkerContributionAction", typeof(WorkerContributionActionType))]
    [System.Xml.Serialization.XmlElementAttribute("WorkerDeductionAction", typeof(WorkerDeductionAction))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("EarlyRetirementContAction", Namespace="", IsNullable=false)]
public partial class EarlyRetirementContActionType {
    
    private string earlyRetirementCodeField;
    
    private string earlyRetirementNbrMonthsField;
    
    private string earlyRetirementContributionAmountField;
    
    private Action actionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EarlyRetirementCode {
        get {
            return this.earlyRetirementCodeField;
        }
        set {
            this.earlyRetirementCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EarlyRetirementNbrMonths {
        get {
            return this.earlyRetirementNbrMonthsField;
        }
        set {
            this.earlyRetirementNbrMonthsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string EarlyRetirementContributionAmount {
        get {
            return this.earlyRetirementContributionAmountField;
        }
        set {
            this.earlyRetirementContributionAmountField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("IndemnityWAPMAction", Namespace="", IsNullable=false)]
public partial class IndemnityWAPMActionType {
    
    private string indemnityNatureField;
    
    private string incapacityDegreeField;
    
    private string indemnityAmountField;
    
    private Action actionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string IndemnityNature {
        get {
            return this.indemnityNatureField;
        }
        set {
            this.indemnityNatureField = value;
        }
    }
    
    /// <remarks/>
    public string IncapacityDegree {
        get {
            return this.incapacityDegreeField;
        }
        set {
            this.incapacityDegreeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string IndemnityAmount {
        get {
            return this.indemnityAmountField;
        }
        set {
            this.indemnityAmountField = value;
        }
    }
    
    /// <remarks/>
    public Action Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OccupationUpdateNotification : OccupationUpdateNotificationType {
    
    private OccupationInformationsActionType occupationInformationsActionField;
    
    private SecondPillarInformationActionType secondPillarInformationActionField;
    
    private ServiceActionType[] serviceActionField;
    
    private RemunActionType[] remunActionField;
    
    private OccupationPSDAction[] occupationPSDActionField;
    
    private ReorgMeasureInformationActionType[] reorgMeasureInformationActionField;
    
    private OccupationDeductionAction[] occupationDeductionActionField;
    
    /// <remarks/>
    public OccupationInformationsActionType OccupationInformationsAction {
        get {
            return this.occupationInformationsActionField;
        }
        set {
            this.occupationInformationsActionField = value;
        }
    }
    
    /// <remarks/>
    public SecondPillarInformationActionType SecondPillarInformationAction {
        get {
            return this.secondPillarInformationActionField;
        }
        set {
            this.secondPillarInformationActionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ServiceAction")]
    public ServiceActionType[] ServiceAction {
        get {
            return this.serviceActionField;
        }
        set {
            this.serviceActionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RemunAction")]
    public RemunActionType[] RemunAction {
        get {
            return this.remunActionField;
        }
        set {
            this.remunActionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OccupationPSDAction")]
    public OccupationPSDAction[] OccupationPSDAction {
        get {
            return this.occupationPSDActionField;
        }
        set {
            this.occupationPSDActionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReorgMeasureInformationAction")]
    public ReorgMeasureInformationActionType[] ReorgMeasureInformationAction {
        get {
            return this.reorgMeasureInformationActionField;
        }
        set {
            this.reorgMeasureInformationActionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OccupationDeductionAction")]
    public OccupationDeductionAction[] OccupationDeductionAction {
        get {
            return this.occupationDeductionActionField;
        }
        set {
            this.occupationDeductionActionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("OccupationInformationsAction", Namespace="", IsNullable=false)]
public partial class OccupationInformationsActionType {
    
    private HorecaExtra horecaExtraField;
    
    private bool horecaExtraFieldSpecified;
    
    private PostedWorker postedWorkerField;
    
    private bool postedWorkerFieldSpecified;
    
    private string nOSSLPASocialMaribelField;
    
    private string hourRemunField;
    
    private string hourRemunInThousandthOfEuroField;
    
    private System.DateTime sixMonthsIllnessDateField;
    
    private bool sixMonthsIllnessDateFieldSpecified;
    
    private string firstWeekGuaranteedSalaryNbrDaysField;
    
    private string illnessGrossRemunAmountField;
    
    private PSDDclExemption pSDDclExemptionField;
    
    private bool pSDDclExemptionFieldSpecified;
    
    private SupplPensionContributionExemption supplPensionContributionExemptionField;
    
    private bool supplPensionContributionExemptionFieldSpecified;
    
    private ObligationControlInformation obligationControlInformationField;
    
    private bool obligationControlInformationFieldSpecified;
    
    private System.DateTime definitiveNominationDateField;
    
    private bool definitiveNominationDateFieldSpecified;
    
    private System.DateTime newMaribelEmploymentDateField;
    
    private bool newMaribelEmploymentDateFieldSpecified;
    
    private PSPContribCalcBasisDerogation pSPContribCalcBasisDerogationField;
    
    private bool pSPContribCalcBasisDerogationFieldSpecified;
    
    private string careerMeasureField;
    
    private string serviceExemptionNotionField;
    
    private string holidayDaysNumberField;
    
    private string sectorDetailField;
    
    private string mobilityBudgetField;
    
    private string flemishTrainingHolidayHoursNbrField;
    
    private string regionalAidMeasureField;
    
    private Action actionField;
    
    /// <remarks/>
    public HorecaExtra HorecaExtra {
        get {
            return this.horecaExtraField;
        }
        set {
            this.horecaExtraField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HorecaExtraSpecified {
        get {
            return this.horecaExtraFieldSpecified;
        }
        set {
            this.horecaExtraFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public PostedWorker PostedWorker {
        get {
            return this.postedWorkerField;
        }
        set {
            this.postedWorkerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PostedWorkerSpecified {
        get {
            return this.postedWorkerFieldSpecified;
        }
        set {
            this.postedWorkerFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string NOSSLPASocialMaribel {
        get {
            return this.nOSSLPASocialMaribelField;
        }
        set {
            this.nOSSLPASocialMaribelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string HourRemun {
        get {
            return this.hourRemunField;
        }
        set {
            this.hourRemunField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string HourRemunInThousandthOfEuro {
        get {
            return this.hourRemunInThousandthOfEuroField;
        }
        set {
            this.hourRemunInThousandthOfEuroField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime SixMonthsIllnessDate {
        get {
            return this.sixMonthsIllnessDateField;
        }
        set {
            this.sixMonthsIllnessDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SixMonthsIllnessDateSpecified {
        get {
            return this.sixMonthsIllnessDateFieldSpecified;
        }
        set {
            this.sixMonthsIllnessDateFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FirstWeekGuaranteedSalaryNbrDays;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string IllnessGrossRemunAmount;

    /// <remarks/>
    public PSDDclExemption PSDDclExemption;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PSDDclExemptionSpecified;

    /// <remarks/>
    public SupplPensionContributionExemption SupplPensionContributionExemption;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SupplPensionContributionExemptionSpecified;

    /// <remarks/>
    public ObligationControlInformation ObligationControlInformation;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ObligationControlInformationSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime DefinitiveNominationDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DefinitiveNominationDateSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime NewMaribelEmploymentDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NewMaribelEmploymentDateSpecified;

    /// <remarks/>
    public PSPContribCalcBasisDerogation PSPContribCalcBasisDerogation;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PSPContribCalcBasisDerogationSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string CareerMeasure;

    /// <remarks/>
    public string ServiceExemptionNotion;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string HolidayDaysNumber;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SectorDetail;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string MobilityBudget;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FlemishTrainingHolidayHoursNbr;

    /// <remarks/>
    public string RegionalAidMeasure;

    /// <remarks/>
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum PSPContribCalcBasisDerogation {

    [System.Xml.Serialization.XmlEnumAttribute("1")] Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")] Item2,
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("SecondPillarInformationAction", Namespace="", IsNullable=false)]
public partial class SecondPillarInformationActionType
{
    public string ReferenceYearMonth;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string MonthlyScaleSalary;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string MonthlyAdditionalScaleSalary;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string MonthlyHomeIndemnity;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string OfficialLanguage;

    /// <remarks/>
    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("ServiceAction", Namespace="", IsNullable=false)]
public partial class ServiceActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ServiceSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ServiceCode;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ServiceNbrDays;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ServiceNbrHours;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string FlightNbrMinutes;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("RemunAction", Namespace="", IsNullable=false)]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OccupationPSDAction : OccupationPSDActionType
{
    [System.Xml.Serialization.XmlElementAttribute("ScaleSalaryAction")]
    public ScaleSalaryAction[] ScaleSalaryAction;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ScaleSalaryAction : ScaleSalaryActionType
{
    [System.Xml.Serialization.XmlElementAttribute("AdditionalScaleSalaryAction")]
    public AdditionalScaleSalaryActionType[] AdditionalScaleSalaryAction;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("ReorgMeasureInformationAction", Namespace="", IsNullable=false)]
public class ReorgMeasureInformationActionType
{
    [XmlElementAttribute(DataType = "integer")]
    public string ReorganisationMeasure;

    [XmlElementAttribute(DataType = "integer")]
    public string ReorganisationMeasurePercentage;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true)]
[XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OccupationDeductionAction : OccupationDeductionActionType {

    [XmlElementAttribute("OccupationDeductionDetailAction")]
    public OccupationDeductionDetailActionType[] OccupationDeductionDetailAction;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("OccupationDeductionDetailAction", Namespace="", IsNullable=false)]
public class OccupationDeductionDetailActionType {

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string DeductionDetailSequenceNbr;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime WorkingRegulationsStartingDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WorkingRegulationsStartingDateSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime WorkingRegulationsEndingDate;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WorkingRegulationsEndingDateSpecified;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AverageWorkingTimeBeforeReduction;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string AverageWorkingTimeAfterReduction;

    public Action Action;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlRootAttribute("StudentContributionAction", Namespace="", IsNullable=false)]
public class StudentContributionActionType
{
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string StudentRemunAmount;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string StudentContributionAmount;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StudentHoursNbr", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("StudentNbrDays", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string LocalUnitID;

    /// <remarks/>
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionType;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionCalculationBasis;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string ContributionAmount;

    /// <remarks/>
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
    [System.Xml.Serialization.XmlElementAttribute("DeductionDetailAction")]
    public DeductionDetailActionType[] DeductionDetailAction;
}


[System.SerializableAttribute()]
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
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string SubGroup;

    /// <remarks/>
    public string Justification;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string JustificationCode;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime JustificationDate;

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool JustificationDateSpecified;
}


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("RectificationAmount", Namespace="", IsNullable=false)]
public class RectificationAmountType
{
    [System.Xml.Serialization.XmlElementAttribute("CreditAmount", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("DebitAmount", typeof(string), DataType = "integer")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string? Item;

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType2 ItemElementName;
}


[System.SerializableAttribute()]
[XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType2 { CreditAmount, DebitAmount, }
