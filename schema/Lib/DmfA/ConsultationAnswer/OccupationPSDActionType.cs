//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ConsultationAnswer224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class OccupationPSDActionType
    {
        [XmlElement(DataType = "date")]
        public DateTime OccupationPSDStartDate;

        [XmlElement(DataType = "date")]
        public DateTime OccupationPSDEndDate;

        [XmlIgnoreAttribute()]
        public bool OccupationPSDEndDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? PublicSectorInstitutionType;

        [XmlElement(DataType = "integer")]
        public string? PublicSectorPersonnelCategory;

        public string? GradeOrFunction;

        [XmlElement(DataType = "integer")]
        public string? OfficialLanguage;

        [XmlElement(DataType = "integer")]
        public string? AssignmentType;

        [XmlElement(DataType = "integer")]
        public string FunctionNature;

        [XmlElement(DataType = "integer")]
        public string StatutoryRelationEndReason;

        public Action Action;
    }
}
