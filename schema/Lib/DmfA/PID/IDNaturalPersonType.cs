// By Bart Vertongen Dec 2022.

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    /// <summary>
    /// 90245 - Identificatie van de natuurlijke persoon
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class IDNaturalPersonType
    {
        /// <summary>
        /// 00024 - IDENTIFICATIENUMMER BIJ DE SOCIALE ZEKERHEID - INSZ
        /// Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het
        /// identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke
        //// personen.
        /// </summary>
        /// <remarks>
        /// Numeric length 11
        /// 0 of NNNNNNNNNCC
        ///     NNNNNNNNN is het nummer
        ///     CC is het controlegetal.
        /// </remarks>
        [XmlElement(DataType = "integer")]
        [Required]
        public string? INSS;

        /// <summary>
        /// 00615 - REFERENTIE GEBRUIKER - NATUURLIJKE PERSOON
        /// Referentie van de natuurlijke persoon gebruikt door de werkgever of een erkend sociaal secretariaat.
        /// </summary>
        /// <remarks>alphanumeric length 200</remarks>
        public string? NaturalPersonUserReference;

        /// <summary>
        /// 00549 - PERMANENTE IDENTIFICATIECODE VAN DE NATUURLIJKE PERSOON
        /// </summary>
        /// <remarks>Numeric length 11  [1;99999999999]</remarks>
        [XmlElement(DataType = "integer")]
        [Required]
        public string? NaturalPersonPID;

        /// <summary>
        /// 00548 - PERMANENTE IDENTIFICATIECODE VAN DE AANGEGEVEN NATUURLIJKE PERSOON
        /// Permanente identificatiecode van de natuurlijke persoon binnen een aangifte toegekend door de sociale
        /// zekerheid.
        /// </summary>
        /// <remarks>Numeric 11  [1;99999999999]</remarks>
        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonPID;

        /// <summary>
        /// 00620 - VERSIENUMMER VAN DE AANGEGEVEN NATUURLIJKE PERSOON
        /// </summary>
        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonVersionNbr;

        /// <summary>
        /// 00493 - NAAM VAN DE WERKNEMER ZOALS GEDECLAREERD IN DE ORIGINELE AANGIFTE
        /// Familienaam van een natuurlijk persoon zoals opgegeven in de oorspronkelijk aangift
        /// </summary>
        /// <remarks>alphanumeric length 48</remarks>
        public string? OriginalDeclaredWorkerName;

        /// <summary>
        /// 00494 - VOORNAAM VAN DE WERKNEMER ZOALS GEDECLAREERD IN DE ORIGINELE AANGIFTE
        /// Eerste voornaam van een natuurlijk persoon zoals opgegeven in de oorspronkelijk aangifte
        /// </summary>
        /// <remarks>Alphanumeric length 24</remarks>
        public string? OriginalDeclaredWorkerFirstName;
    }
}
