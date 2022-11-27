
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ActivationInformation", Namespace = "", IsNullable = false)]
    public partial class ActivationInformationType
    {

        private System.DateTime serviceExemptionStartDateField;

        private System.DateTime trainingSituationStartDateField;

        private string trainingSituationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ServiceExemptionStartDate
        {
            get
            {
                return this.serviceExemptionStartDateField;
            }
            set
            {
                this.serviceExemptionStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TrainingSituationStartDate
        {
            get
            {
                return this.trainingSituationStartDateField;
            }
            set
            {
                this.trainingSituationStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string TrainingSituation
        {
            get
            {
                return this.trainingSituationField;
            }
            set
            {
                this.trainingSituationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WorkerDeductionType
    {

        private string deductionCodeField;

        private string deductionCalculationBasisField;

        private string deductionAmountField;

        private System.DateTime deductionRightStartingDateField;

        private bool deductionRightStartingDateFieldSpecified;

        private string managementCostNbrMonthsField;

        private string replacedINSSField;

        private string applicantINSSField;

        private string certificateOriginField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeductionCode
        {
            get
            {
                return this.deductionCodeField;
            }
            set
            {
                this.deductionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeductionCalculationBasis
        {
            get
            {
                return this.deductionCalculationBasisField;
            }
            set
            {
                this.deductionCalculationBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeductionAmount
        {
            get
            {
                return this.deductionAmountField;
            }
            set
            {
                this.deductionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DeductionRightStartingDate
        {
            get
            {
                return this.deductionRightStartingDateField;
            }
            set
            {
                this.deductionRightStartingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeductionRightStartingDateSpecified
        {
            get
            {
                return this.deductionRightStartingDateFieldSpecified;
            }
            set
            {
                this.deductionRightStartingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ManagementCostNbrMonths
        {
            get
            {
                return this.managementCostNbrMonthsField;
            }
            set
            {
                this.managementCostNbrMonthsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ReplacedINSS
        {
            get
            {
                return this.replacedINSSField;
            }
            set
            {
                this.replacedINSSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ApplicantINSS
        {
            get
            {
                return this.applicantINSSField;
            }
            set
            {
                this.applicantINSSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CertificateOrigin
        {
            get
            {
                return this.certificateOriginField;
            }
            set
            {
                this.certificateOriginField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OccupationDeductionType
    {

        private string deductionCodeField;

        private string deductionCalculationBasisField;

        private string deductionAmountField;

        private System.DateTime deductionRightStartingDateField;

        private bool deductionRightStartingDateFieldSpecified;

        private string managementCostNbrMonthsField;

        private string replacedINSSField;

        private string applicantINSSField;

        private string certificateOriginField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeductionCode
        {
            get
            {
                return this.deductionCodeField;
            }
            set
            {
                this.deductionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeductionCalculationBasis
        {
            get
            {
                return this.deductionCalculationBasisField;
            }
            set
            {
                this.deductionCalculationBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeductionAmount
        {
            get
            {
                return this.deductionAmountField;
            }
            set
            {
                this.deductionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DeductionRightStartingDate
        {
            get
            {
                return this.deductionRightStartingDateField;
            }
            set
            {
                this.deductionRightStartingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeductionRightStartingDateSpecified
        {
            get
            {
                return this.deductionRightStartingDateFieldSpecified;
            }
            set
            {
                this.deductionRightStartingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ManagementCostNbrMonths
        {
            get
            {
                return this.managementCostNbrMonthsField;
            }
            set
            {
                this.managementCostNbrMonthsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ReplacedINSS
        {
            get
            {
                return this.replacedINSSField;
            }
            set
            {
                this.replacedINSSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ApplicantINSS
        {
            get
            {
                return this.applicantINSSField;
            }
            set
            {
                this.applicantINSSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CertificateOrigin
        {
            get
            {
                return this.certificateOriginField;
            }
            set
            {
                this.certificateOriginField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScaleSalaryType
    {

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ScaleSalaryStartDate
        {
            get
            {
                return this.scaleSalaryStartDateField;
            }
            set
            {
                this.scaleSalaryStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ScaleSalaryEndDate
        {
            get
            {
                return this.scaleSalaryEndDateField;
            }
            set
            {
                this.scaleSalaryEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleSalaryEndDateSpecified
        {
            get
            {
                return this.scaleSalaryEndDateFieldSpecified;
            }
            set
            {
                this.scaleSalaryEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "gYearMonth")]
        public string PecuniarySeniorityStartDate
        {
            get
            {
                return this.pecuniarySeniorityStartDateField;
            }
            set
            {
                this.pecuniarySeniorityStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SalaryScaleReference
        {
            get
            {
                return this.salaryScaleReferenceField;
            }
            set
            {
                this.salaryScaleReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ScaleSalaryAmount
        {
            get
            {
                return this.scaleSalaryAmountField;
            }
            set
            {
                this.scaleSalaryAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WeekHoursNbr
        {
            get
            {
                return this.weekHoursNbrField;
            }
            set
            {
                this.weekHoursNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ScaleSalaryWeekHoursNbr
        {
            get
            {
                return this.scaleSalaryWeekHoursNbrField;
            }
            set
            {
                this.scaleSalaryWeekHoursNbrField = value;
            }
        }

        /// <remarks/>
        public ReducedScaleSalaryNotion ReducedScaleSalaryNotion
        {
            get
            {
                return this.reducedScaleSalaryNotionField;
            }
            set
            {
                this.reducedScaleSalaryNotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReducedScaleSalaryNotionSpecified
        {
            get
            {
                return this.reducedScaleSalaryNotionFieldSpecified;
            }
            set
            {
                this.reducedScaleSalaryNotionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReducedScaleSalaryNotion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OccupationPublicServiceDataType
    {

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationPSDStartDate
        {
            get
            {
                return this.occupationPSDStartDateField;
            }
            set
            {
                this.occupationPSDStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationPSDEndDate
        {
            get
            {
                return this.occupationPSDEndDateField;
            }
            set
            {
                this.occupationPSDEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccupationPSDEndDateSpecified
        {
            get
            {
                return this.occupationPSDEndDateFieldSpecified;
            }
            set
            {
                this.occupationPSDEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string PublicSectorInstitutionType
        {
            get
            {
                return this.publicSectorInstitutionTypeField;
            }
            set
            {
                this.publicSectorInstitutionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string PublicSectorPersonnelCategory
        {
            get
            {
                return this.publicSectorPersonnelCategoryField;
            }
            set
            {
                this.publicSectorPersonnelCategoryField = value;
            }
        }

        /// <remarks/>
        public string GradeOrFunction
        {
            get
            {
                return this.gradeOrFunctionField;
            }
            set
            {
                this.gradeOrFunctionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string OfficialLanguage
        {
            get
            {
                return this.officialLanguageField;
            }
            set
            {
                this.officialLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AssignmentType
        {
            get
            {
                return this.assignmentTypeField;
            }
            set
            {
                this.assignmentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string FunctionNature
        {
            get
            {
                return this.functionNatureField;
            }
            set
            {
                this.functionNatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string StatutoryRelationEndReason
        {
            get
            {
                return this.statutoryRelationEndReasonField;
            }
            set
            {
                this.statutoryRelationEndReasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OccupationUpdateType
    {

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

        private ReorganisationMeasure reorganisationMeasureField;

        private bool reorganisationMeasureFieldSpecified;

        private string employmentPromotionField;

        private string retiredField;

        private string apprenticeshipField;

        private string remunMethodField;

        private string positionCodeField;

        private string flyingStaffClassField;

        private TenthOrTwelfth tenthOrTwelfthField;

        private bool tenthOrTwelfthFieldSpecified;

        private string occupationUserReferenceField;

        private DaysJustification daysJustificationField;

        private bool daysJustificationFieldSpecified;

        private string activityCodeField;

        private string occupationVersionNbrField;

        private string localUnitIDField;

        private string shipIdField;

        private string staffCodeField;

        private string subsidizedMeanWorkingHoursField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string OccupationSequenceNbr
        {
            get
            {
                return this.occupationSequenceNbrField;
            }
            set
            {
                this.occupationSequenceNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationStartingDate
        {
            get
            {
                return this.occupationStartingDateField;
            }
            set
            {
                this.occupationStartingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccupationStartingDateSpecified
        {
            get
            {
                return this.occupationStartingDateFieldSpecified;
            }
            set
            {
                this.occupationStartingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OccupationEndingDate
        {
            get
            {
                return this.occupationEndingDateField;
            }
            set
            {
                this.occupationEndingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccupationEndingDateSpecified
        {
            get
            {
                return this.occupationEndingDateFieldSpecified;
            }
            set
            {
                this.occupationEndingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string JointCommissionNbr
        {
            get
            {
                return this.jointCommissionNbrField;
            }
            set
            {
                this.jointCommissionNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkingDaysSystem
        {
            get
            {
                return this.workingDaysSystemField;
            }
            set
            {
                this.workingDaysSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContractType
        {
            get
            {
                return this.contractTypeField;
            }
            set
            {
                this.contractTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string RefMeanWorkingHours
        {
            get
            {
                return this.refMeanWorkingHoursField;
            }
            set
            {
                this.refMeanWorkingHoursField = value;
            }
        }

        /// <remarks/>
        public string WorkerStatus
        {
            get
            {
                return this.workerStatusField;
            }
            set
            {
                this.workerStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string MeanWorkingHours
        {
            get
            {
                return this.meanWorkingHoursField;
            }
            set
            {
                this.meanWorkingHoursField = value;
            }
        }

        /// <remarks/>
        public ReorganisationMeasure ReorganisationMeasure
        {
            get
            {
                return this.reorganisationMeasureField;
            }
            set
            {
                this.reorganisationMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReorganisationMeasureSpecified
        {
            get
            {
                return this.reorganisationMeasureFieldSpecified;
            }
            set
            {
                this.reorganisationMeasureFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmploymentPromotion
        {
            get
            {
                return this.employmentPromotionField;
            }
            set
            {
                this.employmentPromotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Retired
        {
            get
            {
                return this.retiredField;
            }
            set
            {
                this.retiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Apprenticeship
        {
            get
            {
                return this.apprenticeshipField;
            }
            set
            {
                this.apprenticeshipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string RemunMethod
        {
            get
            {
                return this.remunMethodField;
            }
            set
            {
                this.remunMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string PositionCode
        {
            get
            {
                return this.positionCodeField;
            }
            set
            {
                this.positionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string FlyingStaffClass
        {
            get
            {
                return this.flyingStaffClassField;
            }
            set
            {
                this.flyingStaffClassField = value;
            }
        }

        /// <remarks/>
        public TenthOrTwelfth TenthOrTwelfth
        {
            get
            {
                return this.tenthOrTwelfthField;
            }
            set
            {
                this.tenthOrTwelfthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TenthOrTwelfthSpecified
        {
            get
            {
                return this.tenthOrTwelfthFieldSpecified;
            }
            set
            {
                this.tenthOrTwelfthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string OccupationUserReference
        {
            get
            {
                return this.occupationUserReferenceField;
            }
            set
            {
                this.occupationUserReferenceField = value;
            }
        }

        /// <remarks/>
        public DaysJustification DaysJustification
        {
            get
            {
                return this.daysJustificationField;
            }
            set
            {
                this.daysJustificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DaysJustificationSpecified
        {
            get
            {
                return this.daysJustificationFieldSpecified;
            }
            set
            {
                this.daysJustificationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ActivityCode
        {
            get
            {
                return this.activityCodeField;
            }
            set
            {
                this.activityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string OccupationVersionNbr
        {
            get
            {
                return this.occupationVersionNbrField;
            }
            set
            {
                this.occupationVersionNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string LocalUnitID
        {
            get
            {
                return this.localUnitIDField;
            }
            set
            {
                this.localUnitIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ShipId
        {
            get
            {
                return this.shipIdField;
            }
            set
            {
                this.shipIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string StaffCode
        {
            get
            {
                return this.staffCodeField;
            }
            set
            {
                this.staffCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SubsidizedMeanWorkingHours
        {
            get
            {
                return this.subsidizedMeanWorkingHoursField;
            }
            set
            {
                this.subsidizedMeanWorkingHoursField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReorganisationMeasure
    {

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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("501")]
        Item501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("502")]
        Item502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("503")]
        Item503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("504")]
        Item504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("505")]
        Item505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("506")]
        Item506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("507")]
        Item507,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("508")]
        Item508,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("509")]
        Item509,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("510")]
        Item510,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("511")]
        Item511,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("512")]
        Item512,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("513")]
        Item513,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("514")]
        Item514,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("515")]
        Item515,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("516")]
        Item516,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("517")]
        Item517,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("531")]
        Item531,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("541")]
        Item541,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("542")]
        Item542,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("543")]
        Item543,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("544")]
        Item544,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("545")]
        Item545,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("546")]
        Item546,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("599")]
        Item599,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum TenthOrTwelfth
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum DaysJustification
    {

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
    public partial class WorkerRecordUpdateActionType
    {

        private string employerClassField;

        private string workerCodeField;

        private System.DateTime nOSSQuarterStartingDateField;

        private bool nOSSQuarterStartingDateFieldSpecified;

        private System.DateTime nOSSQuarterEndingDateField;

        private bool nOSSQuarterEndingDateFieldSpecified;

        private string borderField;

        private string activityWithRiskField;

        private string localUnitIDField;

        private string workerRecordUserReferenceField;

        private UpdateAction updateActionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmployerClass
        {
            get
            {
                return this.employerClassField;
            }
            set
            {
                this.employerClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkerCode
        {
            get
            {
                return this.workerCodeField;
            }
            set
            {
                this.workerCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime NOSSQuarterStartingDate
        {
            get
            {
                return this.nOSSQuarterStartingDateField;
            }
            set
            {
                this.nOSSQuarterStartingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NOSSQuarterStartingDateSpecified
        {
            get
            {
                return this.nOSSQuarterStartingDateFieldSpecified;
            }
            set
            {
                this.nOSSQuarterStartingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime NOSSQuarterEndingDate
        {
            get
            {
                return this.nOSSQuarterEndingDateField;
            }
            set
            {
                this.nOSSQuarterEndingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NOSSQuarterEndingDateSpecified
        {
            get
            {
                return this.nOSSQuarterEndingDateFieldSpecified;
            }
            set
            {
                this.nOSSQuarterEndingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Border
        {
            get
            {
                return this.borderField;
            }
            set
            {
                this.borderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ActivityWithRisk
        {
            get
            {
                return this.activityWithRiskField;
            }
            set
            {
                this.activityWithRiskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string LocalUnitID
        {
            get
            {
                return this.localUnitIDField;
            }
            set
            {
                this.localUnitIDField = value;
            }
        }

        /// <remarks/>
        public string WorkerRecordUserReference
        {
            get
            {
                return this.workerRecordUserReferenceField;
            }
            set
            {
                this.workerRecordUserReferenceField = value;
            }
        }

        /// <remarks/>
        public UpdateAction UpdateAction
        {
            get
            {
                return this.updateActionField;
            }
            set
            {
                this.updateActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum UpdateAction
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WorkerRecordUpdateType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NaturalPersonUpdateType
    {

        private string naturalPersonSequenceNbrField;

        private string iNSSField;

        private string sISField;

        private string workerNameField;

        private string workerFirstNameField;

        private string workerInitialField;

        private string workerBirthdateField;

        private string workerBirthplaceField;

        private string workerBirthplaceCountryField;

        private string workerSexField;

        private string workerStreetField;

        private string workerHouseNbrField;

        private string workerPostBoxField;

        private string workerZIPCodeField;

        private string workerCityField;

        private string workerCountryField;

        private string nationalityField;

        private string naturalPersonUserReferenceField;

        private string naturalPersonPIDField;

        private string declNaturalPersonPIDField;

        private string declNaturalPersonVersionNbrField;

        private string justificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NaturalPersonSequenceNbr
        {
            get
            {
                return this.naturalPersonSequenceNbrField;
            }
            set
            {
                this.naturalPersonSequenceNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string INSS
        {
            get
            {
                return this.iNSSField;
            }
            set
            {
                this.iNSSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SIS
        {
            get
            {
                return this.sISField;
            }
            set
            {
                this.sISField = value;
            }
        }

        /// <remarks/>
        public string WorkerName
        {
            get
            {
                return this.workerNameField;
            }
            set
            {
                this.workerNameField = value;
            }
        }

        /// <remarks/>
        public string WorkerFirstName
        {
            get
            {
                return this.workerFirstNameField;
            }
            set
            {
                this.workerFirstNameField = value;
            }
        }

        /// <remarks/>
        public string WorkerInitial
        {
            get
            {
                return this.workerInitialField;
            }
            set
            {
                this.workerInitialField = value;
            }
        }

        /// <remarks/>
        public string WorkerBirthdate
        {
            get
            {
                return this.workerBirthdateField;
            }
            set
            {
                this.workerBirthdateField = value;
            }
        }

        /// <remarks/>
        public string WorkerBirthplace
        {
            get
            {
                return this.workerBirthplaceField;
            }
            set
            {
                this.workerBirthplaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkerBirthplaceCountry
        {
            get
            {
                return this.workerBirthplaceCountryField;
            }
            set
            {
                this.workerBirthplaceCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkerSex
        {
            get
            {
                return this.workerSexField;
            }
            set
            {
                this.workerSexField = value;
            }
        }

        /// <remarks/>
        public string WorkerStreet
        {
            get
            {
                return this.workerStreetField;
            }
            set
            {
                this.workerStreetField = value;
            }
        }

        /// <remarks/>
        public string WorkerHouseNbr
        {
            get
            {
                return this.workerHouseNbrField;
            }
            set
            {
                this.workerHouseNbrField = value;
            }
        }

        /// <remarks/>
        public string WorkerPostBox
        {
            get
            {
                return this.workerPostBoxField;
            }
            set
            {
                this.workerPostBoxField = value;
            }
        }

        /// <remarks/>
        public string WorkerZIPCode
        {
            get
            {
                return this.workerZIPCodeField;
            }
            set
            {
                this.workerZIPCodeField = value;
            }
        }

        /// <remarks/>
        public string WorkerCity
        {
            get
            {
                return this.workerCityField;
            }
            set
            {
                this.workerCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WorkerCountry
        {
            get
            {
                return this.workerCountryField;
            }
            set
            {
                this.workerCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }

        /// <remarks/>
        public string NaturalPersonUserReference
        {
            get
            {
                return this.naturalPersonUserReferenceField;
            }
            set
            {
                this.naturalPersonUserReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NaturalPersonPID
        {
            get
            {
                return this.naturalPersonPIDField;
            }
            set
            {
                this.naturalPersonPIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeclNaturalPersonPID
        {
            get
            {
                return this.declNaturalPersonPIDField;
            }
            set
            {
                this.declNaturalPersonPIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeclNaturalPersonVersionNbr
        {
            get
            {
                return this.declNaturalPersonVersionNbrField;
            }
            set
            {
                this.declNaturalPersonVersionNbrField = value;
            }
        }

        /// <remarks/>
        public string Justification
        {
            get
            {
                return this.justificationField;
            }
            set
            {
                this.justificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EmployerDeclarationUpdateType
    {

        private string quarterField;

        private string nOSSRegistrationNbrField;

        private string trusteeshipField;

        private string companyIDField;

        private string system5Field;

        private System.DateTime holidayStartingDateField;

        private bool holidayStartingDateFieldSpecified;

        private string employerDeclarationPIDField;

        private string justificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Quarter
        {
            get
            {
                return this.quarterField;
            }
            set
            {
                this.quarterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NOSSRegistrationNbr
        {
            get
            {
                return this.nOSSRegistrationNbrField;
            }
            set
            {
                this.nOSSRegistrationNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Trusteeship
        {
            get
            {
                return this.trusteeshipField;
            }
            set
            {
                this.trusteeshipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string System5
        {
            get
            {
                return this.system5Field;
            }
            set
            {
                this.system5Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime HolidayStartingDate
        {
            get
            {
                return this.holidayStartingDateField;
            }
            set
            {
                this.holidayStartingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HolidayStartingDateSpecified
        {
            get
            {
                return this.holidayStartingDateFieldSpecified;
            }
            set
            {
                this.holidayStartingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmployerDeclarationPID
        {
            get
            {
                return this.employerDeclarationPIDField;
            }
            set
            {
                this.employerDeclarationPIDField = value;
            }
        }

        /// <remarks/>
        public string Justification
        {
            get
            {
                return this.justificationField;
            }
            set
            {
                this.justificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FormType
    {

        private Identification identificationField;

        private System.DateTime formCreationDateField;

        private System.DateTime formCreationHourField;

        private AttestationStatus attestationStatusField;

        private TypeForm typeFormField;

        /// <remarks/>
        public Identification Identification
        {
            get
            {
                return this.identificationField;
            }
            set
            {
                this.identificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FormCreationDate
        {
            get
            {
                return this.formCreationDateField;
            }
            set
            {
                this.formCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime FormCreationHour
        {
            get
            {
                return this.formCreationHourField;
            }
            set
            {
                this.formCreationHourField = value;
            }
        }

        /// <remarks/>
        public AttestationStatus AttestationStatus
        {
            get
            {
                return this.attestationStatusField;
            }
            set
            {
                this.attestationStatusField = value;
            }
        }

        /// <remarks/>
        public TypeForm TypeForm
        {
            get
            {
                return this.typeFormField;
            }
            set
            {
                this.typeFormField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum Identification
    {

        /// <remarks/>
        DMFAUPD,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum TypeForm
    {

        /// <remarks/>
        SU,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ContributionUnrelatedToNPUpdateType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ComplementaryIndemnityType
    {

        private string employerNotionField;

        private string jointCommissionNbrField;

        private string activityCodeField;

        private DebtorType debtorTypeField;

        private bool debtorTypeFieldSpecified;

        private System.DateTime firstComplIndemnityDateField;

        private string complIndemnityAgreementNotionField;

        private HalfTimeCareerInterruptionNotion halfTimeCareerInterruptionNotionField;

        private ServiceExemptionNotion serviceExemptionNotionField;

        private ReplacementAccordanceWCCNotion replacementAccordanceWCCNotionField;

        private string substituteINSSField;

        private ResumptionOfWorkMeasure resumptionOfWorkMeasureField;

        private bool resumptionOfWorkMeasureFieldSpecified;

        private string complIndemnityNbrOfPartsField;

        private System.DateTime noticeDateField;

        private bool noticeDateFieldSpecified;

        private AilingOrReorgCompanyNotion ailingOrReorgCompanyNotionField;

        private bool ailingOrReorgCompanyNotionFieldSpecified;

        private System.DateTime acknowledgementStartDateField;

        private bool acknowledgementStartDateFieldSpecified;

        private System.DateTime acknowledgementEndDateField;

        private bool acknowledgementEndDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EmployerNotion
        {
            get
            {
                return this.employerNotionField;
            }
            set
            {
                this.employerNotionField = value;
            }
        }

        /// <remarks/>
        public string JointCommissionNbr
        {
            get
            {
                return this.jointCommissionNbrField;
            }
            set
            {
                this.jointCommissionNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ActivityCode
        {
            get
            {
                return this.activityCodeField;
            }
            set
            {
                this.activityCodeField = value;
            }
        }

        /// <remarks/>
        public DebtorType DebtorType
        {
            get
            {
                return this.debtorTypeField;
            }
            set
            {
                this.debtorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DebtorTypeSpecified
        {
            get
            {
                return this.debtorTypeFieldSpecified;
            }
            set
            {
                this.debtorTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FirstComplIndemnityDate
        {
            get
            {
                return this.firstComplIndemnityDateField;
            }
            set
            {
                this.firstComplIndemnityDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityAgreementNotion
        {
            get
            {
                return this.complIndemnityAgreementNotionField;
            }
            set
            {
                this.complIndemnityAgreementNotionField = value;
            }
        }

        /// <remarks/>
        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion
        {
            get
            {
                return this.halfTimeCareerInterruptionNotionField;
            }
            set
            {
                this.halfTimeCareerInterruptionNotionField = value;
            }
        }

        /// <remarks/>
        public ServiceExemptionNotion ServiceExemptionNotion
        {
            get
            {
                return this.serviceExemptionNotionField;
            }
            set
            {
                this.serviceExemptionNotionField = value;
            }
        }

        /// <remarks/>
        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion
        {
            get
            {
                return this.replacementAccordanceWCCNotionField;
            }
            set
            {
                this.replacementAccordanceWCCNotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SubstituteINSS
        {
            get
            {
                return this.substituteINSSField;
            }
            set
            {
                this.substituteINSSField = value;
            }
        }

        /// <remarks/>
        public ResumptionOfWorkMeasure ResumptionOfWorkMeasure
        {
            get
            {
                return this.resumptionOfWorkMeasureField;
            }
            set
            {
                this.resumptionOfWorkMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResumptionOfWorkMeasureSpecified
        {
            get
            {
                return this.resumptionOfWorkMeasureFieldSpecified;
            }
            set
            {
                this.resumptionOfWorkMeasureFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityNbrOfParts
        {
            get
            {
                return this.complIndemnityNbrOfPartsField;
            }
            set
            {
                this.complIndemnityNbrOfPartsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime NoticeDate
        {
            get
            {
                return this.noticeDateField;
            }
            set
            {
                this.noticeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoticeDateSpecified
        {
            get
            {
                return this.noticeDateFieldSpecified;
            }
            set
            {
                this.noticeDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion
        {
            get
            {
                return this.ailingOrReorgCompanyNotionField;
            }
            set
            {
                this.ailingOrReorgCompanyNotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AilingOrReorgCompanyNotionSpecified
        {
            get
            {
                return this.ailingOrReorgCompanyNotionFieldSpecified;
            }
            set
            {
                this.ailingOrReorgCompanyNotionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AcknowledgementStartDate
        {
            get
            {
                return this.acknowledgementStartDateField;
            }
            set
            {
                this.acknowledgementStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcknowledgementStartDateSpecified
        {
            get
            {
                return this.acknowledgementStartDateFieldSpecified;
            }
            set
            {
                this.acknowledgementStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AcknowledgementEndDate
        {
            get
            {
                return this.acknowledgementEndDateField;
            }
            set
            {
                this.acknowledgementEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcknowledgementEndDateSpecified
        {
            get
            {
                return this.acknowledgementEndDateFieldSpecified;
            }
            set
            {
                this.acknowledgementEndDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum DebtorType
    {

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum HalfTimeCareerInterruptionNotion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ServiceExemptionNotion
    {

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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReplacementAccordanceWCCNotion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ResumptionOfWorkMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum AilingOrReorgCompanyNotion
    {

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
    [System.Xml.Serialization.XmlRootAttribute("AdditionalScaleSalary", Namespace = "", IsNullable = false)]
    public partial class AdditionalScaleSalaryType
    {

        private System.DateTime additionalScaleSalaryStartDateField;

        private System.DateTime additionalScaleSalaryEndDateField;

        private bool additionalScaleSalaryEndDateFieldSpecified;

        private string additionalScaleSalaryReferenceField;

        private string additionalScaleSalaryBasisAmountField;

        private string additionalScaleSalaryPercentageField;

        private string nbrHoursOrServicesField;

        private string additionalScaleSalaryAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryStartDate
        {
            get
            {
                return this.additionalScaleSalaryStartDateField;
            }
            set
            {
                this.additionalScaleSalaryStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryEndDate
        {
            get
            {
                return this.additionalScaleSalaryEndDateField;
            }
            set
            {
                this.additionalScaleSalaryEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalScaleSalaryEndDateSpecified
        {
            get
            {
                return this.additionalScaleSalaryEndDateFieldSpecified;
            }
            set
            {
                this.additionalScaleSalaryEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AdditionalScaleSalaryReference
        {
            get
            {
                return this.additionalScaleSalaryReferenceField;
            }
            set
            {
                this.additionalScaleSalaryReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AdditionalScaleSalaryBasisAmount
        {
            get
            {
                return this.additionalScaleSalaryBasisAmountField;
            }
            set
            {
                this.additionalScaleSalaryBasisAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AdditionalScaleSalaryPercentage
        {
            get
            {
                return this.additionalScaleSalaryPercentageField;
            }
            set
            {
                this.additionalScaleSalaryPercentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NbrHoursOrServices
        {
            get
            {
                return this.nbrHoursOrServicesField;
            }
            set
            {
                this.nbrHoursOrServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AdditionalScaleSalaryAmount
        {
            get
            {
                return this.additionalScaleSalaryAmountField;
            }
            set
            {
                this.additionalScaleSalaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum CapitalizationNotion
    {

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum CareerMeasure
    {

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
    [System.Xml.Serialization.XmlRootAttribute("CompanyVehicleUpdateAction", Namespace = "", IsNullable = false)]
    public partial class CompanyVehicleUpdateActionType
    {

        private string companyVehicleSequenceNbrField;

        private string licensePlateField;

        private string ecoVehicleField;

        private string companyVehicleVersionNbrField;

        private UpdateAction updateActionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CompanyVehicleSequenceNbr
        {
            get
            {
                return this.companyVehicleSequenceNbrField;
            }
            set
            {
                this.companyVehicleSequenceNbrField = value;
            }
        }

        /// <remarks/>
        public string LicensePlate
        {
            get
            {
                return this.licensePlateField;
            }
            set
            {
                this.licensePlateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EcoVehicle
        {
            get
            {
                return this.ecoVehicleField;
            }
            set
            {
                this.ecoVehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CompanyVehicleVersionNbr
        {
            get
            {
                return this.companyVehicleVersionNbrField;
            }
            set
            {
                this.companyVehicleVersionNbrField = value;
            }
        }

        /// <remarks/>
        public UpdateAction UpdateAction
        {
            get
            {
                return this.updateActionField;
            }
            set
            {
                this.updateActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ComplementaryIndemnity : ComplementaryIndemnityType
    {

        private ComplIndemnityContributionType[] complIndemnityContributionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComplIndemnityContribution")]
        public ComplIndemnityContributionType[] ComplIndemnityContribution
        {
            get
            {
                return this.complIndemnityContributionField;
            }
            set
            {
                this.complIndemnityContributionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ComplIndemnityContribution", Namespace = "", IsNullable = false)]
    public partial class ComplIndemnityContributionType
    {

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionWorkerCode
        {
            get
            {
                return this.contributionWorkerCodeField;
            }
            set
            {
                this.contributionWorkerCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionType
        {
            get
            {
                return this.contributionTypeField;
            }
            set
            {
                this.contributionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IndemnityContributionPeriodCode
        {
            get
            {
                return this.indemnityContributionPeriodCodeField;
            }
            set
            {
                this.indemnityContributionPeriodCodeField = value;
            }
        }

        /// <remarks/>
        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion
        {
            get
            {
                return this.complIndemnityAmountAdjustNotionField;
            }
            set
            {
                this.complIndemnityAmountAdjustNotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionSequenceNbr
        {
            get
            {
                return this.contributionSequenceNbrField;
            }
            set
            {
                this.contributionSequenceNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityAmount
        {
            get
            {
                return this.complIndemnityAmountField;
            }
            set
            {
                this.complIndemnityAmountField = value;
            }
        }

        /// <remarks/>
        public CapitalizationNotion CapitalizationNotion
        {
            get
            {
                return this.capitalizationNotionField;
            }
            set
            {
                this.capitalizationNotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapitalizationNotionSpecified
        {
            get
            {
                return this.capitalizationNotionFieldSpecified;
            }
            set
            {
                this.capitalizationNotionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string WelfareBenefitTheoreticalAmount
        {
            get
            {
                return this.welfareBenefitTheoreticalAmountField;
            }
            set
            {
                this.welfareBenefitTheoreticalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityNbrMonths
        {
            get
            {
                return this.complIndemnityNbrMonthsField;
            }
            set
            {
                this.complIndemnityNbrMonthsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NbrMonthsDecimals
        {
            get
            {
                return this.nbrMonthsDecimalsField;
            }
            set
            {
                this.nbrMonthsDecimalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IncompleteMonthNbrDays
        {
            get
            {
                return this.incompleteMonthNbrDaysField;
            }
            set
            {
                this.incompleteMonthNbrDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IncompleteMonthReason
        {
            get
            {
                return this.incompleteMonthReasonField;
            }
            set
            {
                this.incompleteMonthReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string FloorApplicationNotion
        {
            get
            {
                return this.floorApplicationNotionField;
            }
            set
            {
                this.floorApplicationNotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContributionAmount
        {
            get
            {
                return this.contributionAmountField;
            }
            set
            {
                this.contributionAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ComplIndemnityAmountAdjustNotion
    {

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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ContributionUnrelatedToNPUpdate : ContributionUnrelatedToNPUpdateType
    {

        private LastSituationCUNPType lastSituationCUNPField;

        private CUNPUpdateActionType cUNPUpdateActionField;

        /// <remarks/>
        public LastSituationCUNPType LastSituationCUNP
        {
            get
            {
                return this.lastSituationCUNPField;
            }
            set
            {
                this.lastSituationCUNPField = value;
            }
        }

        /// <remarks/>
        public CUNPUpdateActionType CUNPUpdateAction
        {
            get
            {
                return this.cUNPUpdateActionField;
            }
            set
            {
                this.cUNPUpdateActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("LastSituationCUNP", Namespace = "", IsNullable = false)]
    public partial class LastSituationCUNPType
    {

        private string unrelatedEmployerClassField;

        private string unrelatedWorkerCodeField;

        private string contUnrelatedToNPVersionNbrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedEmployerClass
        {
            get
            {
                return this.unrelatedEmployerClassField;
            }
            set
            {
                this.unrelatedEmployerClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedWorkerCode
        {
            get
            {
                return this.unrelatedWorkerCodeField;
            }
            set
            {
                this.unrelatedWorkerCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ContUnrelatedToNPVersionNbr
        {
            get
            {
                return this.contUnrelatedToNPVersionNbrField;
            }
            set
            {
                this.contUnrelatedToNPVersionNbrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("CUNPUpdateAction", Namespace = "", IsNullable = false)]
    public partial class CUNPUpdateActionType
    {

        private string unrelatedEmployerClassField;

        private string unrelatedWorkerCodeField;

        private string unrelatedCalculationBasisField;

        private string unrelatedAmountField;

        private UpdateAction updateActionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedEmployerClass
        {
            get
            {
                return this.unrelatedEmployerClassField;
            }
            set
            {
                this.unrelatedEmployerClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedWorkerCode
        {
            get
            {
                return this.unrelatedWorkerCodeField;
            }
            set
            {
                this.unrelatedWorkerCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedCalculationBasis
        {
            get
            {
                return this.unrelatedCalculationBasisField;
            }
            set
            {
                this.unrelatedCalculationBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string UnrelatedAmount
        {
            get
            {
                return this.unrelatedAmountField;
            }
            set
            {
                this.unrelatedAmountField = value;
            }
        }

        /// <remarks/>
        public UpdateAction UpdateAction
        {
            get
            {
                return this.updateActionField;
            }
            set
            {
                this.updateActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DeductionDetail", Namespace = "", IsNullable = false)]
    public partial class DeductionDetailType
    {

        private string deductionDetailSequenceNbrField;

        private string deductionDetailAmountField;

        private string workingRegulationsRegistryNbrField;

        private System.DateTime workingRegulationsStartingDateField;

        private bool workingRegulationsStartingDateFieldSpecified;

        private string averageWorkingTimeBeforeReductionField;

        private string averageWorkingTimeAfterReductionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeductionDetailSequenceNbr
        {
            get
            {
                return this.deductionDetailSequenceNbrField;
            }
            set
            {
                this.deductionDetailSequenceNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string DeductionDetailAmount
        {
            get
            {
                return this.deductionDetailAmountField;
            }
            set
            {
                this.deductionDetailAmountField = value;
            }
        }

        /// <remarks/>
        public string WorkingRegulationsRegistryNbr
        {
            get
            {
                return this.workingRegulationsRegistryNbrField;
            }
            set
            {
                this.workingRegulationsRegistryNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime WorkingRegulationsStartingDate
        {
            get
            {
                return this.workingRegulationsStartingDateField;
            }
            set
            {
                this.workingRegulationsStartingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WorkingRegulationsStartingDateSpecified
        {
            get
            {
                return this.workingRegulationsStartingDateFieldSpecified;
            }
            set
            {
                this.workingRegulationsStartingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AverageWorkingTimeBeforeReduction
        {
            get
            {
                return this.averageWorkingTimeBeforeReductionField;
            }
            set
            {
                this.averageWorkingTimeBeforeReductionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AverageWorkingTimeAfterReduction
        {
            get
            {
                return this.averageWorkingTimeAfterReductionField;
            }
            set
            {
                this.averageWorkingTimeAfterReductionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DismissedStatutoryWorkerContribution", Namespace = "", IsNullable = false)]
    public partial class DismissedStatutoryWorkerContributionType
    {

        private string grossRefRemunAmountField;

        private string grossRefRemunContributionAmountField;

        private string refNbrDaysField;

        private System.DateTime subjectionStartingDateField;

        private System.DateTime subjectionEndingDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string GrossRefRemunAmount
        {
            get
            {
                return this.grossRefRemunAmountField;
            }
            set
            {
                this.grossRefRemunAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string GrossRefRemunContributionAmount
        {
            get
            {
                return this.grossRefRemunContributionAmountField;
            }
            set
            {
                this.grossRefRemunContributionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string RefNbrDays
        {
            get
            {
                return this.refNbrDaysField;
            }
            set
            {
                this.refNbrDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime SubjectionStartingDate
        {
            get
            {
                return this.subjectionStartingDateField;
            }
            set
            {
                this.subjectionStartingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime SubjectionEndingDate
        {
            get
            {
                return this.subjectionEndingDateField;
            }
            set
            {
                this.subjectionEndingDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DmfAUpdate
    {

        private Form[] formField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Form")]
        public Form[] Form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Form : FormType
    {

        private ReferenceType referenceField;

        private EmployerDeclarationUpdate employerDeclarationUpdateField;

        /// <remarks/>
        public ReferenceType Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public EmployerDeclarationUpdate EmployerDeclarationUpdate
        {
            get
            {
                return this.employerDeclarationUpdateField;
            }
            set
            {
                this.employerDeclarationUpdateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Reference", Namespace = "", IsNullable = false)]
    public partial class ReferenceType
    {

        private ReferenceType1 referenceType1Field;

        private ReferenceOrigin referenceOriginField;

        private string referenceNbrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceType")]
        public ReferenceType1 ReferenceType1
        {
            get
            {
                return this.referenceType1Field;
            }
            set
            {
                this.referenceType1Field = value;
            }
        }

        /// <remarks/>
        public ReferenceOrigin ReferenceOrigin
        {
            get
            {
                return this.referenceOriginField;
            }
            set
            {
                this.referenceOriginField = value;
            }
        }

        /// <remarks/>
        public string ReferenceNbr
        {
            get
            {
                return this.referenceNbrField;
            }
            set
            {
                this.referenceNbrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class EmployerDeclarationUpdate : EmployerDeclarationUpdateType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompanyVehicleUpdateAction", typeof(CompanyVehicleUpdateActionType))]
        [System.Xml.Serialization.XmlElementAttribute("ContributionUnrelatedToNPUpdate", typeof(ContributionUnrelatedToNPUpdate))]
        [System.Xml.Serialization.XmlElementAttribute("NaturalPersonUpdate", typeof(NaturalPersonUpdate))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NaturalPersonUpdate : NaturalPersonUpdateType
    {
        [XmlElementAttribute("WorkerRecordUpdate")]
        public WorkerRecordUpdate[] WorkerRecordUpdate;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class WorkerRecordUpdate : WorkerRecordUpdateType
    {
        public LastSituationWRType LastSituationWR;

        public WorkerRecordUpdateAction WorkerRecordUpdateAction;
    }

    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("LastSituationWR", Namespace = "", IsNullable = false)]
    public partial class LastSituationWRType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string EmployerClass;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string WorkerCode;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string WorkerRecordVersionNbr;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class WorkerRecordUpdateAction : WorkerRecordUpdateActionType
    {
        [System.Xml.Serialization.XmlElementAttribute("ActivationInformation", typeof(ActivationInformationType))]
        [System.Xml.Serialization.XmlElementAttribute("ComplementaryIndemnity", typeof(ComplementaryIndemnity))]
        [System.Xml.Serialization.XmlElementAttribute("DismissedStatutoryWorkerContribution", typeof(DismissedStatutoryWorkerContributionType))]
        [System.Xml.Serialization.XmlElementAttribute("EarlyRetirementContribution", typeof(EarlyRetirementContributionType))]
        [System.Xml.Serialization.XmlElementAttribute("IndemnityWAPM", typeof(IndemnityWAPMType))]
        [System.Xml.Serialization.XmlElementAttribute("OccupationUpdate", typeof(OccupationUpdate))]
        [System.Xml.Serialization.XmlElementAttribute("StudentContribution", typeof(StudentContributionType))]
        [System.Xml.Serialization.XmlElementAttribute("WorkerContribution", typeof(WorkerContributionType))]
        [System.Xml.Serialization.XmlElementAttribute("WorkerDeduction", typeof(WorkerDeduction))]
        public object[] Items;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("EarlyRetirementContribution", Namespace = "", IsNullable = false)]
    public partial class EarlyRetirementContributionType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EarlyRetirementCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EarlyRetirementNbrMonths;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string EarlyRetirementContributionAmount;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("IndemnityWAPM", Namespace = "", IsNullable = false)]
    public class IndemnityWAPMType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IndemnityNature;

        /// <remarks/>
        public string IncapacityDegree;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IndemnityAmount;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class OccupationUpdate : OccupationUpdateType
    {
        public OccupationInformationsType OccupationInformations;

        /// <remarks/>
        public SecondPillarInformationType SecondPillarInformation;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service")]
        public ServiceType[] Service;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remun")]
        public RemunType[] Remun;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OccupationPublicServiceData")]
        public OccupationPublicServiceData[] OccupationPublicServiceData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReorgMeasureInformation")]
        public ReorgMeasureInformationType[] ReorgMeasureInformation;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OccupationDeduction")]
        public OccupationDeduction[] OccupationDeduction;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("OccupationInformations", Namespace = "", IsNullable = false)]
    public class OccupationInformationsType
    {
        public HorecaExtra HorecaExtra;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HorecaExtraSpecified;

        /// <remarks/>
        public PostedWorker PostedWorker;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostedWorkerSpecified;

        /// <remarks/>
        public NOSSLPASocialMaribel NOSSLPASocialMaribel;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NOSSLPASocialMaribelSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string HourRemun;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string HourRemunInThousandthOfEuro;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime SixMonthsIllnessDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SixMonthsIllnessDateSpecified;

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
        public CareerMeasure CareerMeasure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CareerMeasureSpecified;

        /// <remarks/>
        public ServiceExemptionNotion ServiceExemptionNotion;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceExemptionNotionSpecified;

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
        public RegionalAidMeasure RegionalAidMeasure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegionalAidMeasureSpecified;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum HorecaExtra { E, }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PostedWorker
    {
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum NOSSLPASocialMaribel
    {
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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PSDDclExemption
    {
        [XmlEnumAttribute("1")] Item1,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum SupplPensionContributionExemption
    {
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ObligationControlInformation { FWT, }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PSPContribCalcBasisDerogation
    {
        [XmlEnumAttribute("1")] Item1,

        [XmlEnumAttribute("2")] Item2,
    }


    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum RegionalAidMeasure { B, }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("SecondPillarInformation", Namespace = "", IsNullable = false)]
    public class SecondPillarInformationType
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
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Service", Namespace = "", IsNullable = false)]
    public partial class ServiceType
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ServiceSequenceNbr;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ServiceCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ServiceNbrDays;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ServiceNbrHours;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string FlightNbrMinutes;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Remun", Namespace = "", IsNullable = false)]
    public partial class RemunType
    {
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
        public string RemunAmount;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class OccupationPublicServiceData : OccupationPublicServiceDataType
    {
        [System.Xml.Serialization.XmlElementAttribute("ScaleSalary")]
        public ScaleSalary[] ScaleSalary;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ScaleSalary : ScaleSalaryType
    {
        [System.Xml.Serialization.XmlElementAttribute("AdditionalScaleSalary")]
        public AdditionalScaleSalaryType[] AdditionalScaleSalary;
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ReorgMeasureInformation", Namespace = "", IsNullable = false)]
    public partial class ReorgMeasureInformationType
    {
        public ReorganisationMeasure ReorganisationMeasure;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ReorganisationMeasurePercentage;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class OccupationDeduction : OccupationDeductionType
    {
        public OccupationDeductionDetailType OccupationDeductionDetail;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("OccupationDeductionDetail", Namespace = "", IsNullable = false)]
    public class OccupationDeductionDetailType
    {
        [XmlElement(DataType = "integer")]
        public string DeductionDetailSequenceNbr;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime WorkingRegulationsStartingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool WorkingRegulationsStartingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime WorkingRegulationsEndingDate;

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool WorkingRegulationsEndingDateSpecified;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string AverageWorkingTimeBeforeReduction;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string AverageWorkingTimeAfterReduction;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("StudentContribution", Namespace = "", IsNullable = false)]
    public class StudentContributionType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string StudentRemunAmount;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string StudentContributionAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StudentHoursNbr", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("StudentNbrDays", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string LocalUnitID;
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType { StudentHoursNbr, StudentNbrDays, }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("WorkerContribution", Namespace = "", IsNullable = false)]
    public partial class WorkerContributionType
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FirstHiringDateSpecified;
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class WorkerDeduction : WorkerDeductionType
    {
        [System.Xml.Serialization.XmlElementAttribute("DeductionDetail")]
        public DeductionDetailType[]? DeductionDetail;
    }
}