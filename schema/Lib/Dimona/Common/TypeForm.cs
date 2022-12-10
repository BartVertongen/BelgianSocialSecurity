//By Bart Vertongen Dec 2022

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Common
{
    /// <summary>
    /// 00297 -- TYPE VAN HET FORMULIER
    /// </summary>
    /// <remarks>Alphanumeric length </remarks>
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm {
        FA, //Final Answer
        PA, //Provisional Answer
        LA, //Mimited Answer
        RE, //Request
        SU, //Submission 
    }
}