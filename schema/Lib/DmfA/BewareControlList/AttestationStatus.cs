//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareControlList224
{
    /// <summary>
    /// Possible values 
    ///     0 = Origineel
    ///     1 = Wijziging
    ///     2 = Duplicaat
    ///     3 = Annulatie
    ///     4 = Herziening
    ///     5 = Herinnering
    ///     6 = Afsluiting
    ///     7 = Wijziging van papieren origineel
    ///     8 = Kopie
    ///     For BewareControlList224 the only possible value is "0".
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AttestationStatus { [XmlEnum("0")] Original }
}