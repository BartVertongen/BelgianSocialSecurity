// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.NOTIFICATION.NOTIFICATION223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DimonaFeaturesType
    {
        public string? JointCommissionNbr;

        public WorkerType WorkerType;

        [XmlIgnore()]
        public bool WorkerTypeSpecified;

        [XmlElement(DataType = "integer")]
        public string? SubEntityNbr;
    }
}