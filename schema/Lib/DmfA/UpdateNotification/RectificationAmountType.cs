//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("RectificationAmount", Namespace = "", IsNullable = false)]
    public class RectificationAmountType
    {
        [XmlElement("CreditAmount", typeof(string), DataType = "integer")]
        [XmlElement("DebitAmount", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType2 ItemElementName;
    }
}