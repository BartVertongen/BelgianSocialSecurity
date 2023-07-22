
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class EmployerDeclarationType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        [XmlElement(DataType = "integer")]
        public string? NOSSRegistrationNbr;

        [XmlElement(DataType = "integer")]
        public string? Trusteeship;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "integer")]
        public string? NetOwedAmount;

        [XmlElement(DataType = "integer")]
        public string? System5;

        [XmlElement(DataType = "date")]
        public DateTime HolidayStartingDate;

        [XmlIgnore()]
        public bool HolidayStartingDateSpecified;
    }
}
