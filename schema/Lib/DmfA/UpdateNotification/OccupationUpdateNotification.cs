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
    public class OccupationUpdateNotification : OccupationUpdateNotificationType
    {
        public OccupationInformationsActionType? OccupationInformationsAction;

        public SecondPillarInformationActionType? SecondPillarInformationAction;

        [XmlElement("ServiceAction")]
        public ServiceActionType[]? ServiceAction;

        [XmlElement("RemunAction")]
        public RemunActionType[]? RemunAction;

        [XmlElement("OccupationPSDAction")]
        public OccupationPSDAction[]? OccupationPSDAction;

        [XmlElement("ReorgMeasureInformationAction")]
        public ReorgMeasureInformationActionType[]? ReorgMeasureInformationAction;

        [XmlElement("OccupationDeductionAction")]
        public OccupationDeductionAction[]? OccupationDeductionAction;
    }
}
