/*
CREATE TABLE functional_blocks(
   Code                     TEXT NOT NULL
   , Version                TEXT NOT NULL
   , PublicationDay         TEXT NOT NULL
   , Name                   TEXT NOT NULL
   , XmlLabel               TEXT NOT NULL
   , DescriptionNL          TEXT NOT NULL
   , MinimalCardinality     TEXT NOT NULL
   , MaximumCardinality     TEXT NOT NULL
   , Presence               TEXT NOT NULL
   , ExtraRestrictions      TEXT NOT NULL
   , PRIMARY KEY (Code, Version)
);
*/

INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90022"
        , "2023/1"
        , "28/02/2023"
        , "Adres"
        , "Address"
        , "Functioneel blok dat toelaat een adres volledig te specifiëren."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90022'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90375"
        , "2023/1"
        , "28/02/2023"
        , "Controlekaarten voor de bouwsector"
        , "ConstructionControlCards"
        , "Functioneel blok dat toelaat de gegevens met betrekking tot de controlekaarten C3.2A-bouwsector aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90375'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90374"
        , "2023/1"
        , "28/02/2023"
        , "Dimona karakteristieken"
        , "DimonaFeatures"
        , "Functioneel blok dat toelaat de karakteristieken van de Dimona-periode aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90374'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90393"
        , "2023/1"
        , "28/02/2023"
        , "Dimonaperiode"
        , "DimonaPeriod"
        , "Functioneel blok waar informatie gegeven kan worden over een Dimonaperiode die in het personeelsregister werd ingevoerd."
        , "0"
        , "*"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90393'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90059"
        , "2023/1"
        , "28/02/2023"
        , "Formulier"
        , "Form"
        , "Functioneel blok dat toelaat een formulier aan te geven."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90059'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90107"
        , "2023/1"
        , "28/02/2023"
        , "Gebruikende onderneming"
        , "UsingEmployer"
        , "Functioneel blok voor de identificatiegegevens van de gebruikende onderneming waar de getroffene als uitzendkracht tewerkgesteld is."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90107'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90432"
        , "2023/1"
        , "28/02/2023"
        , "Karakteristieken van het contingent"
        , "QuotaFeatures"
        , "Functioneel blok dat toelaat de karakteristieken van het contingent aan te geven."
        , "0"
        , "*"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90432'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90594"
        , "2023/1"
        , "28/02/2023"
        , "Kleine statuten - Informatie"
        , "SmallStatutesInformation"
        , "Functionele blok waarmee gegevens aangeven kunnen worden die nodig zijn voor de berekening van risicopremies van 'kleine statuten' (stage en beroepsopleiding)."
        , "0"
        , "1"
        , "Verplicht voor de werknemerstypes IVT, TRI en STG voor periodes beginnend vanaf 1 januari 2020."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90594'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90017"
        , "2023/1"
        , "28/02/2023"
        , "Natuurlijke persoon"
        , "NaturalPerson"
        , "Functioneel blok dat toelaat de identificatiegegevens van een natuurlijke persoon aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90017'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90428"
        , "2023/1"
        , "28/02/2023"
        , "Personeelsbestand - Consultatie"
        , "PersonnelFileConsult"
        , "Functioneel blok dat toelaat de gegevens in verband met een raadpleging van het personeelsbestand aan te geven, namelijk de identificatie van de betreffende werkgever en de periode waarop de opzoeking betrekking heeft. De resultaatcode duidt aan of de opzoeking goed verlopen is."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90428'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90427"
        , "2023/1"
        , "28/02/2023"
        , "PersonnelFileConsultationAnswer"
        , "PersonnelFileConsultationAnswer"
        , "Root-element van het XML-bericht dat toelaat het antwoord op een aanvraag tot raadpleging van het personeelsbestand voor een bepaalde werkgever mee te delen"
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90427'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90376"
        , "2023/1"
        , "28/02/2023"
        , "Plaats van tewerkstelling van de student"
        , "StudentPlaceOfWork"
        , "Functioneel blok dat toelaat informatie aan te geven in verband met de plaats van tewerkstelling van een student."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90376'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90082"
        , "2023/1"
        , "28/02/2023"
        , "Referentie"
        , "Reference"
        , "Functioneel blok dat toelaat referenties te preciseren in verband met één of meer formulieren; een formulier kan een originele DmfA-aangifte zijn, een wijzigende DmfA-aangifte, een ASR, een aanvraag van inlichtingen, een Dimona aangifte, enz."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90102"
        , "2023/1"
        , "28/02/2023"
        , "Referentie van het ontvangen bestand"
        , "FileReference"
        , "Functioneel blok dat toelaat een referentie naar het ontvangen bestand op te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90102'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90580"
        , "2023/1"
        , "28/02/2023"
        , "Tewerkstellingsmaatregel"
        , "EmploymentMeasureInfo"
        , "Functioneel blok dat informatie verschaft over de werkgelegenheidsmaatregelen die van kracht zijn."
        , "0"
        , "*"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90580'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90154"
        , "2023/1"
        , "28/02/2023"
        , "Verrijkt blok origineel formulier"
        , "HandledOriginalForm"
        , "Functioneel blok dat toelaat verrijkte informatie over het originele formulier op te geven."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90154'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90155"
        , "2023/1"
        , "28/02/2023"
        , "Verrijkt blok referentie"
        , "HandledReference"
        , "Functioneel blok dat toelaat informatie aan te geven omtrent de verrijkte referentie."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90155'
                          AND Version = '2023/1'
);
