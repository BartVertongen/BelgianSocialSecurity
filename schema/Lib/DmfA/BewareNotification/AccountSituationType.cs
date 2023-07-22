// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("AccountSituation", Namespace = "", IsNullable = false)]
    public class AccountSituationType
    {
        public string? AccountSituationReference;
    }
}
