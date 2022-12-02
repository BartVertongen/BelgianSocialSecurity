// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.IDFLUX223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class IdfluxInformationType
    {
        public JustificationCode JustificationCode;

        [XmlElement(DataType = "date")]
        public DateTime EffectiveStartingDate;
    }
}
