// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ConsultationRequest224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Form : FormType
    {
        public ReferenceType? Reference;

        public EmployerDeclarationId? EmployerDeclarationId;
    }
}
