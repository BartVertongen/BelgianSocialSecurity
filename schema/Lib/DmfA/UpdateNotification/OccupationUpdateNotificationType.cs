//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class OccupationUpdateNotificationType
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

        [XmlElement(DataType = "integer")]
        public string? ReorganisationMeasure;

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

        [XmlElement(DataType = "integer")]
        public string? TenthOrTwelfth;

        public string? OccupationUserReference;

        public DaysJustification DaysJustification;

        [XmlIgnore()]
        public bool DaysJustificationSpecified;

        [XmlElement(DataType = "integer")]
        public string? ActivityCode;

        [XmlElement(DataType = "integer")]
        public string? OccupationVersionNbr;

        [XmlElement(DataType = "integer")]
        public string? OccupationNewVersionNbr;

        public Action Action;

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