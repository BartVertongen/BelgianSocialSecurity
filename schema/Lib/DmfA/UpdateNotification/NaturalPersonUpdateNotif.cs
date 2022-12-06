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
    public class NaturalPersonUpdateNotif : NaturalPersonUpdateNotifType
    {
        [XmlElement("WorkerRecordUpdateNotif")]
        public WorkerRecordUpdateNotif[]? WorkerRecordUpdateNotif;

        [XmlElement("NaturalPersonJustification")]
        public NaturalPersonJustificationType[]? NaturalPersonJustification;

        [XmlElement("AnomalyReport")]
        public AnomalyReport[]? AnomalyReport;
    }
}