// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ContributionUnrelatedToNPUpdate : ContributionUnrelatedToNPUpdateType
    {
        public LastSituationCUNPType? LastSituationCUNP;

        public CUNPUpdateActionType? CUNPUpdateAction;
    }
}