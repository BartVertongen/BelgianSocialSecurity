// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DmfAInformationType
    {
        public string? DmfATicketNbr;

        public string? DmfANotTicketNbr;

        public string? DmfANotAmount;

        public string? UserComment;

        [XmlElement(DataType = "integer")]
        public string? SocialSecretariatNumber;
    }
}