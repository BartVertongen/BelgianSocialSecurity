//By Bart Vertongen Dec 2022.

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareControlList224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class BewareControlListDetailType
    {
        /// <summary>
        /// Totaal aantal Beware-notificaties dat ontvangen werd voor een bepaalde datum.
        /// TOEGELATEN DOMEIN: [0,999999]   Numeriek LENGTE: 6
        /// </summary>
        [Required]
        [XmlElement(DataType = "integer")]
        public string? TotalNbrNotifications;

        /// <summary>
        /// NUMMER VAN SOCIAAL SECRETARIAAT (Numeriek 3 lang)
        /// </summary>
        [Required]
        [XmlElement(DataType = "integer")]
        public string? SocialSecretariatNumber;

        /// <summary>
        /// Datum waarop het formulier verzonden is. (Alfanumeriek LENGTE: 10)
        /// Formaat JJJJ-MM-DD
        /// </summary>
        [Required]
        [XmlElement(DataType = "date")]
        public DateTime DateSubmission;

        /// <summary>
        /// Datum waarop de notificaties vermeld in deze controlelijst verzonden werden.
        /// (Alfanumeriek LENGTE: 10) Formaat JJJJ-MM-DD
        /// </summary>
        [Required]
        [XmlElement(DataType = "date")]
        public DateTime ReferenceDate;
    }
}
