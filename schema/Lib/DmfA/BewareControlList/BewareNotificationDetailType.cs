//By Bart Vertongen Dec 2022.

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareControlList224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class BewareNotificationDetailType
    {
        /// <summary>
        /// NUMMER VAN ERKEND SOCIAAL SECRETARIAAT BIJKANTOOR (numeriek 3 lang)
        /// </summary>
        [Required]
        [XmlElement(DataType = "integer")]
        public string? FilialSecSocNbr;

        /// <summary>
        /// DATUM - BOEKHOUDKUNDIGE DATUM
        /// Alfanumeriek LENGTE: 10
        /// </summary>
        /// <remarks>Facultatief   FORMAAT: JJJJ-MM-DD</remarks>
        [XmlElement(DataType = "date")]
        public DateTime AccountingDate;

        [XmlIgnore()]
        public bool AccountingDateSpecified = false;

        /// <summary>
        /// Definitief RSZ-NUMMER
        /// Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een
        ///  rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969,
        ///  moet ingeschreven zijn bij de RSZ.Het gaat om een definitief RSZ-nummer.
        /// </summary>
        /// <remarks>
        /// Geheel getal en element van [100006;199999934] voor de definitieve nummers.
        /// 0 of NNNNNNNCC
        ///     NNNNNNN is het nummer
        ///     CC is het controlegetal.
        /// </remarks>
        [XmlElement(DataType = "integer")]
        public string? NOSSRegistrationNbr = "0";

        /// <summary>
        /// ONDERNEMINGSNUMMER (numeriek 10 lang)
        /// Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een
        /// groepering van natuurlijke personen of een rechtspersoon.
        /// </summary>
        /// <remarks>
        /// Getal van 10 cijfers waarvan :
        ///     de posities 1 tot 8 overeenkomen met een volgnummer, 
        ///     met op de eerste positie een cijfer gelijk aan nul of 1;
        ///     de posities 9 en 10 overeenkomen met een controlegetal.
        ///     Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.
        /// </remarks>
        [XmlElement(DataType = "integer")]
        public string? CompanyID = "0";
    }
}