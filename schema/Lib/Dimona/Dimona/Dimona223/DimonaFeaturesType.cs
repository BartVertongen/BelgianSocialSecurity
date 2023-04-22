//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;

namespace Schemas.Lib.Dimona.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class DimonaFeaturesType
    {
        public JointCommissionNbr JointCommissionNbr;

        [XmlIgnore()]
        public bool JointCommissionNbrSpecified;

        public WorkerType WorkerType;

        [XmlElement(DataType = "integer")]
        public string? SubEntityNbr;
    }
}
