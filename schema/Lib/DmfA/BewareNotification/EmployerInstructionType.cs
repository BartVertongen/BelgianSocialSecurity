// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class EmployerInstructionType
    {
        [XmlElement(DataType = "integer")]
        public string? InstructionType;

        public string? InstructionAmount;

        [XmlElement(DataType = "date")]
        public DateTime DueDate;

        [XmlIgnore()]
        public bool DueDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime BalancingDate;

        [XmlIgnore()]
        public bool BalancingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? InstructionQuarter;

        public string? AskAccountNotion;

        public string? Comment;
    }
}