// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CUNPUpdateAction", Namespace = "", IsNullable = false)]
    public class CUNPUpdateActionType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        [XmlElementAttribute(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        [XmlElementAttribute(DataType = "integer")]
        public string? UnrelatedCalculationBasis;

        [XmlElementAttribute(DataType = "integer")]
        public string? UnrelatedAmount;

        public UpdateAction UpdateAction;
    }
}