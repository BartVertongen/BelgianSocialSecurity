//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class AnomalyReportType
    {
        public string? ErrorID;

        public string? TagName;

        public string? Value;

        public string? AnomalyClass;

        public string? AnomalyLabel;
    }
}