// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Address", Namespace = "", IsNullable = false)]
    public class AddressType
    {
        public string? Street;

        public string? HouseNbr;

        public string? PostBox;

        public string? ZIPCode;

        public string? City;

        [XmlElement(DataType = "integer")]
        public string? Country;
    }
}
