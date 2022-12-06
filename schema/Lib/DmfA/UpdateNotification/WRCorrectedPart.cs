//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WRCorrectedPart : WRCorrectedPartType
    {
        [XmlElement("ActivationInformationAction", typeof(ActivationInformationActionType))]
        [XmlElement("ComplementaryIndemnityAction", typeof(ComplementaryIndemnityAction))]
        [XmlElement("DismissedStatWorkerContAction", typeof(DismissedStatWorkerContActionType))]
        [XmlElement("EarlyRetirementContAction", typeof(EarlyRetirementContActionType))]
        [XmlElement("IndemnityWAPMAction", typeof(IndemnityWAPMActionType))]
        [XmlElement("OccupationUpdateNotification", typeof(OccupationUpdateNotification))]
        [XmlElement("StudentContributionAction", typeof(StudentContributionActionType))]
        [XmlElement("WorkerContributionAction", typeof(WorkerContributionActionType))]
        [XmlElement("WorkerDeductionAction", typeof(WorkerDeductionAction))]
        public object[]? Items;
    }
}