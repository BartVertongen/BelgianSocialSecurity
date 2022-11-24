//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class UsingEmployerType
    {
        public JointCommissionNbr JointCommissionNbr;

        [XmlIgnore()]
        public bool JointCommissionNbrSpecified;

        public string? UsingEmployerName;

        [XmlElement(DataType = "integer")]
        public string? UsingEmployerCompanyID;
    }
}
