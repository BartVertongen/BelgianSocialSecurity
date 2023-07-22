// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    /// <summary>
    /// 90297 - Identificatie van het bedrijfsvoertuig
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CompanyVehicleID", Namespace = "", IsNullable = false)]
    public class CompanyVehicleIDType
    {
        /// <summary>
        /// bedrijfsvoertuig
        /// </summary>
        public string? LicensePlate;

        /// <summary>
        /// 00782 - VERSIENUMMER BEDRIJFSVOERTUIG
        /// </summary>
        [XmlElement(DataType = "integer")]
        public string? CompanyVehicleVersionNbr;
    }
}
