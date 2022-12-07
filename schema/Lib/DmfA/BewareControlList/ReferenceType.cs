//By Bart Vertongen Dec 2022.

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareControlList224
{
    /// <summary>
    /// Duidt aan naar waar de referentie (00222 Referentienummer) verwijst: naar deze aangifte, naar een
    /// aangifte die verwant is met deze aangifte of naar een verzameling aangiften(= een dossier) waar deze
    /// aangifte toe behoort, op deze aanvraag, op dit formulier.
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class ReferenceType
    {
        /// <summary>
        /// 0 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat niet dezelfde identificatie
        ///     heeft(zie bijlagen 11/302), dat verband houdt met het huidige formulier
        /// 1 = de referentie verwijst naar dit formulier
        /// 2 = de referentie is een dossiernummer en verwijst naar het dossier(= verzameling van aangiften)
        ///     waartoe deze aangifte behoort of waartoe dit formulier behoort
        /// 3 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat dezelfde identificatie heeft
        ///     (zie bijlagen 11/302) en dat verband houdt met dit formulier, bijvoorbeeld: de referentie heeft betrekking
        ///     op de aangifte die geannuleerd moet worden door deze aangifte, of op de aangifte die vervangen moet
        ///     worden door deze aangifte, of op de aangifte die gewijzigd moet worden, of op de aangifte die aan de
        ///     oorsprong ligt van dit formulier...
        /// 4 = de referentie verwijst naar een aangifte in een ander scenario die verwant is met deze aangifte
        /// 5 = de referentie verwijst naar een aanvraag
        /// 6 = de referentie verwijst naar een geweigerde aangifte
        /// 7 = de referentie verwijst naar de werkgever die in deze aangifte wordt vermeld
        /// 8 = de referentie verwijst naar de werknemer die in deze aangifte wordt vermeld
        /// 9 = de referentie is een gestructureerde mededeling die moet worden gebruikt in het kader van een
        ///     betaling en verwijst naar dit formulier
        /// </summary>
        [Required]
        [XmlElement("ReferenceType", DataType = "integer")]
        public string? ReferenceType1;

        /// <summary>
        /// Waarde die de authentieke bron van een referentienummer aanduidt.
        /// 1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal
        ///     secretariaat, een softwareontwikkelaar, ...)
        /// 2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een
        ///     antwoord op eenduidige wijze identificeert
        /// 3 = het referentienummer is toegekend door een sector van de sociale zekerheid
        /// 4 = het referentienummer is toegekend door de dienst ePost
        /// 5 = het referentienummer is toegekend door de KSZ
        /// 6 = het referentienummer is toegekend door het archiveringssysteem(DOC-ID)
        /// 7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend(DSP-ID)
        /// </summary>
        /// <remarks>De mogelijke waarden in dit bericht zijn "2" en “3”.</remarks>
        [Required]
        public ReferenceOrigin ReferenceOrigin;

        /// <summary>
        /// Het referentienummer
        /// </summary>
        /// <remarks>
        /// In dit bericht is de toegelaten lengte voor deze zone 20 tekens.
        /// Alfanumeriek LENGTE: 64 in het algemeen
        /// </remarks>
        [Required]
        public string? ReferenceNbr;
    }
}
