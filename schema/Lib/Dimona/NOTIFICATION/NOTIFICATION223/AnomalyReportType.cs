// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;


namespace Schemas.Lib.Dimona.NOTIFICATION.NOTIFICATION223
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