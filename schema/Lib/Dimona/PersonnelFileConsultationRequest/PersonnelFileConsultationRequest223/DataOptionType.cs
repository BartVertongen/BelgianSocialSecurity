//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace Schemas.Lib.Dimona.PersonnelFileConsultationRequest.PersonnelFileConsultationRequest223
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