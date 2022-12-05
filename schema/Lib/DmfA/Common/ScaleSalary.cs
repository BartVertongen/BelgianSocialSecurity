//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ScaleSalary : ScaleSalaryType
    {
        [XmlElement("AdditionalScaleSalary")]
        public AdditionalScaleSalaryType[]? AdditionalScaleSalary;
    }
}