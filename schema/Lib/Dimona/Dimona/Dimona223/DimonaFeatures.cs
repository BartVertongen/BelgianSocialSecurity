//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;

namespace Schemas.Lib.Dimona.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DimonaFeatures : DimonaFeaturesType
    {
        public UsingEmployer? UsingEmployer;
    }
}
