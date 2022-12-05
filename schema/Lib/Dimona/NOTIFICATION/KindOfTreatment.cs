// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.NOTIFICATION223
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum KindOfTreatment { M, }
}