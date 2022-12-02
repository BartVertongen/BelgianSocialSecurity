//By Bart Vertongen Nov 2022

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.ACRF223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("FileReference", Namespace = "", IsNullable = false)]
    public class FileReferenceType
    {
        public string? FileName;

        [XmlElement(DataType = "integer")]
        public string? ReferenceOrigin;

        public string? ReferenceNbr;
    }
}