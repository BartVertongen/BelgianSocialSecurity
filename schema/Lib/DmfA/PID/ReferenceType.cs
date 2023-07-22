// By Bart Vertongen Dec 2022.

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    /// <summary>
    /// 90082 - Referentie
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class ReferenceType
    {
        /// <summary>
        /// 00221 - TYPE VAN DE REFERENTIE
        /// </summary>
        [XmlElement("ReferenceType")]
        public ReferenceType1 ReferenceType1;

        /// <summary>
        /// 00298 - HERKOMST VAN DE REFERENTIE
        /// 1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal
        ///  secretariaat, een softwareontwikkelaar, ...)
        /// 2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een
        /// antwoord op eenduidige wijze identificeert
        /// 3 = het referentienummer is toegekend door een sector van de sociale zekerheid
        /// 4 = het referentienummer is toegekend door de dienst ePost
        /// 5 = het referentienummer is toegekend door de KSZ
        /// 6 = het referentienummer is toegekend door het archiveringssysteem(DOC-ID)
        /// 7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend(DSP-ID)
        /// </summary>
        /// <remarks> Numeric length 1 </remarks>
        [Required]
        public ReferenceOrigin ReferenceOrigin;

        /// <summary>
        /// 00222 - REFERENTIENUMMER
        /// </summary>
        /// <remarks>Alphanumeric length 64</remarks>
        [Required]
        public string? ReferenceNbr;
    }
}