//By Bart Vertongen Nov 2022.

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Common
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class FormType
    {
        /// <summary>
        /// Zone die de inhoud van een formulier beschrijft.
        /// 00296 (alphanumeric length 7
        /// Values coming from structured message 11
        /// </summary>
        [Required]
        public Identification Identification;

        /// <summary>
        /// 00218 (alphanumeric length 10)
        /// Format YYYY-MM-DD
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        /// <summary>
        /// 00299 -- PRECIES UUR VAN CREATIE VAN HET FORMULIER
        /// </summary>
        /// <remarks>
        /// alphanumeriek length 12.
        /// Formaat UU:MM:SS.SSS
        /// </remarks>
        [Required]
        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        public AttestationStatus AttestationStatus;

        public TypeForm TypeForm;
    }
}
