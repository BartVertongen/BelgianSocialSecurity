// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ReceiverInformation : ReceiverInformationType
    {
        public CoordinatesSocialSecretariatType? CoordinatesSocialSecretariat;

        public CoordinatesEmployerType? CoordinatesEmployer;

        public CoordinatesRepresentativeType? CoordinatesRepresentative;

        public AddressType? Address;


    }
}
