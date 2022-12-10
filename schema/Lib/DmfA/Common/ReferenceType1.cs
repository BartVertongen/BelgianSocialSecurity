// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    /// <summary>
    /// 00221 -- TYPE VAN DE REFERENTIE
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1
    {
        /// <summary>
        /// de referentie heeft betrekking op een eerder uitgewisseld formulier dat niet dezelfde identificatie
        ///  heeft (zie bijlagen 11/302), dat verband houdt met het huidige formulier
        /// </summary>
        [XmlEnum("0")] Item0,

        /// <summary>
        /// de referentie verwijst naar dit formulier
        /// </summary>
        [XmlEnum("1")] Item1,

        /// <summary>
        /// de referentie is een dossiernummer en verwijst naar het dossier (= verzameling van aangiften)
        /// waartoe deze aangifte behoort of waartoe dit formulier behoort
        /// </summary>
        [XmlEnum("2")] Item2,

        /// <summary>
        /// de referentie heeft betrekking op een eerder uitgewisseld formulier dat dezelfde identificatie heeft
        /// (zie bijlagen 11/302) en dat verband houdt met dit formulier, bijvoorbeeld: de referentie heeft betrekking
        /// op de aangifte die geannuleerd moet worden door deze aangifte, of op de aangifte die vervangen moet
        /// worden door deze aangifte, of op de aangifte die gewijzigd moet worden, of op de aangifte die aan de
        /// oorsprong ligt van dit formulier..
        /// </summary>
        [XmlEnum("3")] Item3,

        /// <summary>
        /// de referentie verwijst naar een aangifte in een ander scenario die verwant is met deze aangifte
        /// </summary>
        [XmlEnum("4")] Item4,

        /// <summary>
        /// referentie verwijst naar een aanvraag
        /// </summary>
        [XmlEnum("5")] Item5,

        /// <summary>
        /// de referentie verwijst naar een geweigerde aangifte
        /// </summary>
        [XmlEnum("6")] Item6,

        /// <summary>
        /// de referentie verwijst naar de werkgever die in deze aangifte wordt vermeld
        /// </summary>
        [XmlEnum("7")] Item7,

        /// <summary>
        /// de referentie verwijst naar de werknemer die in deze aangifte wordt vermeld
        /// </summary>
        [XmlEnum("8")] Item8,

        /// <summary>
        /// de referentie is een gestructureerde mededeling die moet worden gebruikt in het kader van een
        /// betaling en verwijst naar dit formulier
        /// </summary>
        [XmlEnum("9")] Item9,
    }
}