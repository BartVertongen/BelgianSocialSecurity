// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class OccupationUpdate : OccupationUpdateType
    {
        public OccupationInformationsType? OccupationInformations;

        public SecondPillarInformationType? SecondPillarInformation;

        [XmlElement("Service")]
        public ServiceType[]? Service;

        [XmlElement("Remun")]
        public RemunType[]? Remun;

        [XmlElement("OccupationPublicServiceData")]
        public OccupationPublicServiceData[]? OccupationPublicServiceData;

        [XmlElement("ReorgMeasureInformation")]
        public ReorgMeasureInformationType[]? ReorgMeasureInformation;

        [XmlElement("OccupationDeduction")]
        public OccupationDeduction[]? OccupationDeduction;
    }
}