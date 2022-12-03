
using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class OccupationType
    {
        [XmlElement(DataType = "integer")]
        public string? OccupationSequenceNbr;

        [XmlElement(DataType = "date")]
        public DateTime OccupationStartingDate;

        [XmlIgnore()]
        public bool OccupationStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime OccupationEndingDate;

        [XmlIgnore()]
        public bool OccupationEndingDateSpecified;

        public string? JointCommissionNbr;

        [XmlElement(DataType = "integer")]
        public string? WorkingDaysSystem;

        [XmlElement(DataType = "integer")]
        public string? ContractType;

        [XmlElement(DataType = "integer")]
        public string? RefMeanWorkingHours;

        public string? WorkerStatus;

        [XmlElement(DataType = "integer")]
        public string? MeanWorkingHours;

        public ReorganisationMeasure ReorganisationMeasure;

        [XmlIgnore()]
        public bool ReorganisationMeasureSpecified;

        [XmlElement(DataType = "integer")]
        public string? EmploymentPromotion;

        [XmlElement(DataType = "integer")]
        public string? Retired;

        [XmlElement(DataType = "integer")]
        public string? Apprenticeship;

        [XmlElement(DataType = "integer")]
        public string? RemunMethod;

        [XmlElement(DataType = "integer")]
        public string? PositionCode;

        [XmlElement(DataType = "integer")]
        public string? FlyingStaffClass;

        public TenthOrTwelfth TenthOrTwelfth;

        [XmlIgnoreAttribute()]
        public bool TenthOrTwelfthSpecified;

        public string? OccupationUserReference;

        public DaysJustification DaysJustification;

        [XmlIgnore()]
        public bool DaysJustificationSpecified;

        [XmlElement(DataType = "integer")]
        public string? ActivityCode;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        [XmlElement(DataType = "integer")]
        public string? ShipId;

        [XmlElement(DataType = "integer")]
        public string? StaffCode;

        [XmlElement(DataType = "integer")]
        public string? SubsidizedMeanWorkingHours;
    }
}
