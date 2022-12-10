// By Bart Vertongen Dec 2022.

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    /// <summary>
    /// 90244 - Identificatie van de Werkgeversaangifte
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class IDEmployerDeclarationType
    {
        /// <summary>
        /// 00013 - JAAR - KWARTAAL
        /// Het moet gelegen zijn tussen het eerste kwartaal 2003 (20031) en het laatste afgelopen
        /// kalenderkwartaal(lopend JJJJK -1).
        /// </summary>
        /// <remarks>
        /// numeric length 5 
        /// Format YYYYQ
        /// </remarks>
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        /// <summary>
        /// 00011 - RSZ-NUMMER numeric length 9
        /// Formaat 0 of NNNNNNNCC
        ///     NNNNNNN is het nummer
        ///     CC is het controlegetal.
        /// Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een
        /// rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969,
        /// moet ingeschreven zijn bij de RSZ.Het gaat om een definitief RSZ-nummer.
        /// Deze zone wordt nooit vermeld als het gaat om een provinciaal of plaatselijk bestuur.
        /// Geheel getal en element van[100006;199999934] voor de definitieve nummers.
        /// Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer
        /// op de waarde nul gezet worden.
        /// 
        /// 
        /// 00012 - NOTIE CURATELE Trusteeship numeric length 1
        /// Code die aanduidt of de aangifte al dan niet betrekking heeft op een periode onder curatele.
        /// Deze zone wordt nooit vermeld als het gaat omeen provinciaal of plaatselijk bestuur.
        /// 0 =periode niet onder curantele
        /// 1 = periode onder curatele
        /// 
        /// 00109 - PPL NUMMER - NOSSLPARegistrationNb Numeric length 8
        /// Elke lokale of provinciale overheid die personeel in dienst heeft, moet ingeschreven zijn bij de RSZ.
        /// Deze zone wordt nooit vermeld als het gaat om een DmfA.
        /// TOEGELATEN DOMEIN: Geheel getal en element van[00000197;99999926].
        /// Als het uniek ondernemingsnummer gekend is
        /// (zone 00014 verschillend van nul), kan het PPL nummer op de waarde nul gezet worden.
        /// 
        /// Verplicht indien het gaat om een DmfAPPL.
        /// FORMAAT: 0 of NNNNNNCC
        ///     NNNNNN is het nummer
        ///     CC is het controlegetal.
        /// </summary>
        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("Trusteeship", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[]? ItemsElementName;

        /// <summary>
        /// 00014 - ONDERNEMINGSNUMMER
        /// Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een
        /// groepering van natuurlijke personen of een rechtspersoon.
        /// </summary>
        /// <remarks>
        /// Numeric length 10.
        /// de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie
        /// een cijfer gelijk aan nul of 1;
        /// de posities 9 en 10 overeenkomen met een controlegetal.
        /// Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.
        /// </remarks>
        [XmlElement(DataType = "integer")]
        [Required]
        public string? CompanyID;

        /// <summary>
        /// 00534 - PERMANENTE IDENTIFICATIECODE VAN DE WERKGEVERSAANGIFTE
        /// Permanente identificatiecode van de aangifte van de werkgever toegekend door de sociale zekerheid
        /// </summary>
        /// <remarks>
        /// Numeric length 11 [1;99999999999]
        /// </remarks>
        [XmlElement(DataType = "integer")]
        [Required]
        public string? EmployerDeclarationPID;
    }
}