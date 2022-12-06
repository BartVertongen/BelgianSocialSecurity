//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CompanyVehicleCorrectedPart", Namespace = "", IsNullable = false)]
    public class CompanyVehicleCorrectedPartType
    {
        [XmlElement(DataType = "integer")]
        public string? CompanyVehicleSequenceNbr;

        public string? LicensePlate;

        [XmlElement(DataType = "integer")]
        public string? EcoVehicle;

        [XmlElement(DataType = "integer")]
        public string? CompanyVehicleNewVersionNbr;

        public Action Action;
    }
}