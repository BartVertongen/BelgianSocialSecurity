//By Bart Vertongen Dec 2022.

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareControlList224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class FormType
    {
        /// <summary>
        /// Identificatie van het formulier.
        /// Zone die de inhoud van een formulier beschrijft.
        /// </summary>
        /// <see cref="00296"/>
        [Required]
        public Identification Identification = Identification.BEWLST;

        /// <summary>
        /// Datum van creatie van het formulier
        /// </summary>
        /// <remarks>Format JJJJ-MM-DD alfanumeric</remarks>
        /// <see cref="00218"/>
        [Required]
        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        /// <summary>
        /// Precies uur van creatie van het formulier.
        /// Tijdstip, uitgedrukt in uren, minuten, seconden en milliseconden.
        /// </summary>
        /// <remarks>
        /// Alfanumeriek LENGTE: 12
        /// FORMAAT: UU:MM:SS.SSS
        ///     UU zijn de uren
        ///     MM zijn de minuten
        ///     SS zijn de seconden
        ///     SSS zijn de milliseconden
        /// </remarks>
        /// <see cref="00299"/>
        [Required]
        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        /// <summary>
        /// Status van het attest
        /// </summary>
        /// <see cref="00110"/>
        [Required]
        public AttestationStatus AttestationStatus = AttestationStatus.Original;

        /// <summary>
        /// Type van het formulier.
        /// Het type wijst de aard van het elektronisch formulier aan.
        /// De enige mogelijke waarde in dit bericht is "SU".
        /// </summary>
        /// <remarks>
        /// Possible values are:
        /// RE = REQUEST - het formulier vraagt inlichtingen
        /// PA = PROVISIONAL ANSWER - het formulier is een tijdelijk antwoord op een aanvraag van inlichtingen
        ///     of een mededeling van inlichtingen
        /// FA = FINAL ANSWER - het formulier is een definitief antwoord op een aanvraag van inlichtingen of een
        ///     mededeling van inlichtingen
        /// LA = LIMITED ANSWER - het formulier is een beperkt antwoord op een aanvraag van inlichtingen of
        ///     een mededeling van inlichtingen
        /// SU = SUBMISSION - het formulier deelt inlichtingen mee
        /// </remarks>
        /// <see cref="00297"/>
        [Required]
        public TypeForm TypeForm;
    }
}
