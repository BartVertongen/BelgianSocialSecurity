// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    /// <summary>
    /// 90246 - Identificatie van de tewerkstelling
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("IDOccupation", Namespace = "", IsNullable = false)]
    public class IDOccupationType
    {
        /// <summary>
        /// 00043 - TEWERKSTELLINGSNUMMER 
        /// </summary>
        [XmlElement(DataType = "integer")]
        public string? OccupationSequenceNbr;

        /// <summary>
        /// 00619 - VERSIENUMMER VAN DE TEWERKSTELLING VAN DE WERKNEMERSLIJN
        /// </summary>
        [XmlElement(DataType = "integer")]
        public string? OccupationVersionNbr;

        /// <summary>
        /// 00617 - REFERENTIE GEBRUIKER - TEWERKSTELLING VAN DE WERKNEMERSLIJN
        /// </summary>
        public string? OccupationUserReference;
    }
}
