// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Communication", Namespace = "", IsNullable = false)]
    public class CommunicationType
    {
        public string? PhoneNbr;

        public string? GSMNbr;

        public string? FaxNbr;

        public string? EmailAddress;
    }
}
