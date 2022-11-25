//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.PersonnelFileConsultationRequest223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DataOption", Namespace = "", IsNullable = false)]
    public class DataOptionType
    {
        public Location Location;

        public string? Value;
    }
}