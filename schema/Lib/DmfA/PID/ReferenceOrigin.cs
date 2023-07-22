// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        ///<summary>
        ///het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal
        ///  secretariaat, een softwareontwikkelaar, ...)
        ///</summary>
        [XmlEnum("1")] Item1,

        /// <summary>
        /// het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een
        /// antwoord op eenduidige wijze identificeert
        /// </summary>
        [XmlEnum("2")] Item2,

        /// <summary>
        /// het referentienummer is toegekend door een sector van de sociale zekerheid
        /// </summary>
        [XmlEnum("3")] Item3,

        /// <summary>
        /// het referentienummer is toegekend door de dienst ePost 
        /// </summary>
        [XmlEnum("4")] Item4,

        /// <summary>
        /// het referentienummer is toegekend door de KSZ
        /// </summary>
        [XmlEnum("5")] Item5,

        /// <summary>
        /// het referentienummer is toegekend door het archiveringssysteem(DOC-ID)
        /// </summary>
        [XmlEnum("6")] Item6,

        /// <summary>
        /// het referentienummer is door de DSP aan een gearchiveerd document toegekend(DSP-ID)
        /// </summary>
        [XmlEnum("7")] Item7,
    }
}
