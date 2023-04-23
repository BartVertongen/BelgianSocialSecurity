//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;

namespace Schemas.Lib.Dimona.PersonnelFileConsultationRequest.PersonnelFileConsultationRequest223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Reference", Namespace = "", IsNullable = false)]
    public class ReferenceType
    {
        [XmlElement("ReferenceType")]
        public ReferenceType1 ReferenceType1;

        public ReferenceOrigin ReferenceOrigin;

        public string? ReferenceNbr;
    }
}
