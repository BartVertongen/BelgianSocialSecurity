// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CoordinatesSocialSecretariat", Namespace = "", IsNullable = false)]
    public class CoordinatesSocialSecretariatType
    {
        [XmlElement(DataType = "integer")]
        public string? SocialSecretariatNumber;

        [XmlElement(DataType = "integer")]
        public string? FilialSecSocNbr;
    }
}