// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    /// <summary>
    /// Formulier (90059)
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class FormType
    {
        /// <summary>
        /// 00296 - IDENTIFICATIE VAN HET FORMULIER
        /// </summary>
        public Identification Identification;

        /// <summary>
        /// 00218 - DATUM VAN CREATIE VAN HET FORMULIER
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime FormCreationDate;

        /// <summary>
        /// 00299 - PRECIES UUR VAN CREATIE VAN HET FORMULIER
        /// </summary>
        [XmlElement(DataType = "time")]
        public DateTime FormCreationHour;

        /// <summary>
        /// 00110 - STATUS VAN HET ATTEST
        /// </summary>
        [XmlElement(DataType = "integer")]
        public string? AttestationStatus;

        /// <summary>
        /// 00297 - TYPE VAN HET FORMULIER
        /// </summary>
        public TypeForm TypeForm;
    }
}