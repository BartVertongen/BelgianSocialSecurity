
CREATE TABLE functional_blocks (
    Id          INTEGER PRIMARY KEY
    , NameNL    TEXT UNIQUE NOT NULL
    , NameFR    TEXT
    , XmlLabel  TEXT UNIQUE NOT NULL
);

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90017, "Natuurlijke persoon", "NaturalPerson");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90022, "Adres", "Address");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90059, "Formulier", "Form");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90082, "Referentie", "Reference");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90107, "Gebruikende onderneming", "UsingEmployer");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90256, "Identificatie van de werkgever", "EmployerId");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90372, "Dimona", "Dimona");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90373, "Dimona IN aangifte", "DimonaIn");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90374, "Dimona karakteristieken", "DimonaFeatures");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90375, "Controlekaarten voor de bouwsector", "ConstructionControlCards");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90376, "Plaats van tewerkstelling van de student", "StudentPlaceOfWork");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90377, "Dimona OUT aangifte", "DimonaOut");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90378, "Dimona wijzigen aangifte", "DimonaUpdate");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90379, "Dimona annulatie aangifte", "DimonaCancel");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90384, "Identificatie van de opdrachtgever", "WorksGlobalProjectOwnerId");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90382, "Identificatie van de tijdelijke handelsvennootschap", "TempComCompanyID");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90383, "Project dat de werken omvat", "WorksGlobalProject");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90387, "Contract met betrekking tot de werken", "WorksContract");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90388, "Identificatie van de onderaannemer", "SubcontractorId");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90389, "Informatie van de activiteit van de onderaannemer", "SubcontractorActivityInfo");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90480, "Aangifte dagelijkse registratie", "DailyRegistrationDeclaration");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90573, "Werkgevende onderneming", "SubContractorEmployerId");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90594, "Kleine statuten - Informatie", "SmallStatutesInformation");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90181, "Ontvangstbewijs van het bestand", "ACRF");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90102, "Referentie van het ontvangen bestand", "FileReference");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90167, "Resultaat van de ontvangstverwerking", "ReceptionResult");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90074, "Aard van de dag", "NatureOfDay");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90030, "Berekeningsbasis bijzondere omstandigheden", "ExceptSituationCalculBase");

INSERT INTO functional_blocks (Id, NameNL, XmlLabel)
VALUES (90405, "Berekeningsbasis - Referteperiode", "CalculBaseRefPeriod");


