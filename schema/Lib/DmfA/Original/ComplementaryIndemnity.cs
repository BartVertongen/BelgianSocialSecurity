//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ComplementaryIndemnity : ComplementaryIndemnityType
    {
        [XmlElement("ComplIndemnityContribution")]
        public ComplIndemnityContributionType[]? ComplIndemnityContribution;
    }
}