// By Bart Vertongen Dec 2022.
// Functional blocks have a number starting with 9

//Important structured messages are:
//  2 - Lijst der werknemerskengetallen waarvoor de bijdragen van toepassing zijn
//  11 - Identificatie van het formulier
//  28 - Lijst der werknemerskengetallen waarvoor de bijdragen van toepassing zijn PPO
//  29 - Lijst van de werkgeverscategorieën PPO

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    /// <summary>
    /// Dit gestructureerd bericht deelt de permanente identificatie-gegevens mee voor de
    /// originele multifunctionele aangiften.
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DmfAPID
    {
        [XmlElement("Form")]
        public Form[]? Form;
    }
}