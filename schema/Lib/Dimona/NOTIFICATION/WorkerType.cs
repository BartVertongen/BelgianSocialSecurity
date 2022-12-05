// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.NOTIFICATION223
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum WorkerType
    { A17, BCW, DWD, EXT, FLX, IVT, O17, PMP,
        QUA, RTA, S17, STU, STX, T17, TEA, TRI, STG, OTH, }
}