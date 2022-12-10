// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    /// <summary>
    /// 90247 - Identificatie van de bijdrage niet gebonden aan een natuurlijke persoon
    /// </summary>
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("IDContUnrelatedToNP", Namespace = "", IsNullable = false)]
    public class IDContUnrelatedToNPType
    {
        /// <summary>
        /// 00019 - WERKGEVERSCATEGORIE WAARVOOR EEN BIJDRAGE VERSCHULDIGD IS DIE NIET GEBONDEN IS AAN
        /// EEN NATUURLIJKE PERSOON
        /// </summary>
        [XmlElement(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        /// <summary>
        /// 00020 - WERKNEMERSKENGETAL VOOR EEN BIJDRAGE DIE NIET GEBONDEN IS AAN EEN NATUURLIJKE
        /// PERSOON
        /// </summary>
        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        /// <summary>
        /// 00611 - VERSIENUMMER BIJDRAGE NIET GEBONDEN AAN EEN NATUURLIJKE PERSOON
        /// </summary>
        [XmlElement(DataType = "integer")]
        public string? ContUnrelatedToNPVersionNbr;
    }
}