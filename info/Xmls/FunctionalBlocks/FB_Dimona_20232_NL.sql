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
SELECT "90480"
        , "2023/2"
        , "25/05/2023"
        , "Aangifte dagelijkse registratie"
        , "DailyRegistrationDeclaration"
        , "Functioneel blok dat toelaat de informatie te geven die nodig is voor een aangifte van het type dagelijkse registratie."
        , "0"
        , "1"
        , "Verplicht indien het een aangifte dagelijkse registratie betreft. Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90480'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90022"
        , "2023/2"
        , "25/05/2023"
        , "Adres"
        , "Address"
        , "Functioneel blok dat toelaat een adres volledig te specifiëren."
        , "0"
        , "1"
        , "Verplicht indien de aangifte een gebruikende onderneming vermeldt (dus indien het paritair comité = 322 voor een Dimona IN) en indien de zone 'Ondernemingsnummer van een gebruikende onderneming' niet aanwezig is. Verplicht indien de aangifte de werkplaats van een student vermeldt (dus indien het type werknemer 'STU' is en dat de benaming aanwezig is (de werknemer werkt niet op de hoofdzetel van de werkgever))."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90022'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90375"
        , "2023/2"
        , "25/05/2023"
        , "Controlekaarten voor de bouwsector"
        , "ConstructionControlCards"
        , "Functioneel blok dat toelaat de gegevens met betrekking tot de controlekaarten C3.2A-bouwsector aan te geven."
        , "0"
        , "1"
        , "Verplicht indien het paritair comité (zone 00046 die bij het BF 90374 staat) of het paritair comité van de gebruikende onderneming (zone 00046 die bij het BF 90107 staat) '124' is OF indien het paritair comité '322' is, het paritair comité van de gebruikende onderneming afwezig is en het werknemer type 'BCW' is.\nFacultatief indien het paritair comité '322' is, het paritair comité van de gebruikende onderneming afwezig is en het werknemer type 'DWD', 'IVT', 'TRI' of 'STU' is. Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90375'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90372"
        , "2023/2"
        , "25/05/2023"
        , "Dimona"
        , "Dimona"
        , "Root van de XML-boodschap die toelaat Dimona-aangiften te genereren"
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90372'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90379"
        , "2023/2"
        , "25/05/2023"
        , "Dimona annulatie aangifte"
        , "DimonaCancel"
        , "Functioneel blok dat toelaat de informatie te geven die nodig is voor een Dimona annulatie aangifte."
        , "1"
        , "1"
        , "Verplicht indien het een Dimona-aangifte van annulatie is. Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90379'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90373"
        , "2023/2"
        , "25/05/2023"
        , "Dimona IN aangifte"
        , "DimonaIn"
        , "Functioneel blok dat toelaat de informatie te geven die nodig is voor een Dimona IN aangifte."
        , "1"
        , "1"
        , "Verplicht indien het een Dimona-aangifte IN is."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90373'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90374"
        , "2023/2"
        , "25/05/2023"
        , "Dimona karakteristieken"
        , "DimonaFeatures"
        , "Functioneel blok dat toelaat de karakteristieken van de Dimona-periode aan te geven."
        , "0"
        , "1"
        , "Verplicht indien het formulier betrekking heeft op een Dimona-aangifte IN. Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90374'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90377"
        , "2023/2"
        , "25/05/2023"
        , "Dimona OUT aangifte"
        , "DimonaOut"
        , "Functioneel blok dat toelaat de informatie te geven die nodig is voor een Dimona OUT aangifte."
        , "1"
        , "1"
        , "Verplicht indien het een Dimona-aangifte OUT is."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90377'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90378"
        , "2023/2"
        , "25/05/2023"
        , "Dimona wijziging aangifte"
        , "DimonaUpdate"
        , "Functioneel blok dat toelaat de informatie te geven die nodig is voor een Dimona wijziging aangifte."
        , "1"
        , "1"
        , "Verplicht indien het een wijzigende Dimona-aangifte is. Verboden in de andere gevallen."
        , "Het is niet meer mogelijk om een wijzigende Dimona-aangifte in te voeren voor een periode betreffende een type werknemer STX of een periode Horeca met forfait full of light."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90378'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90059"
        , "2023/2"
        , "25/05/2023"
        , "Formulier"
        , "Form"
        , "Functioneel blok dat toelaat een formulier aan te geven."
        , "1"
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90059'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90107"
        , "2023/2"
        , "25/05/2023"
        , "Gebruikende onderneming"
        , "UsingEmployer"
        , "Functioneel blok voor de identificatiegegevens van de gebruikende onderneming waar de getroffene als uitzendkracht tewerkgesteld is."
        , "0"
        , "1"
        , "Verplicht indien het formulier betrekking heeft op een Dimona-aangifte IN voor een werknemer van de uitzendsector (Paritair comité = 322). Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90107'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90256"
        , "2023/2"
        , "25/05/2023"
        , "Identificatie van de werkgever"
        , "EmployerId"
        , "Functioneel blok dat toelaat de werkgever te identificeren."
        , "0"
        , "1"
        , "Verplicht indien het een Dimona-aangifte IN is."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90256'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90594"
        , "2023/2"
        , "25/05/2023"
        , "Kleine statuten - Informatie"
        , "SmallStatutesInformation"
        , "Functionele blok waarmee gegevens aangeven kunnen worden die nodig zijn voor de berekening van risicopremies van 'kleine statuten' (stage en beroepsopleiding)."
        , "0"
        , "1"
        , "Verplicht voor de werknemerstypes IVT, TRI en STG vanaf het deployment van de nieuwe versie van Dimona in december 2019."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90594'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90017"
        , "2023/2"
        , "25/05/2023"
        , "Natuurlijke persoon"
        , "NaturalPerson"
        , "Functioneel blok dat toelaat de identificatiegegevens van een natuurlijke persoon aan te geven."
        , "1"
        , "1"
        , "Onmisbaar"
        , "Blokkerende (B) anomalie 369 in de gevallen T17, O17 en S17."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90017'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90376"
        , "2023/2"
        , "25/05/2023"
        , "Plaats van tewerkstelling van de student"
        , "StudentPlaceOfWork"
        , "Functioneel blok dat toelaat informatie aan te geven in verband met de plaats van tewerkstelling van een student."
        , "0"
        , "1"
        , "Verplicht indien het type werknemer 'STU' is, en indien de werkplaats van de student niet de hoofdzetel van de onderneming is. Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90376'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90082"
        , "2023/2"
        , "25/05/2023"
        , "Referentie"
        , "Reference"
        , "Functioneel blok dat toelaat referenties te preciseren in verband met één of meer formulieren; een formulier kan een originele DmfA-aangifte zijn, een wijzigende DmfA-aangifte, een ASR, een aanvraag van inlichtingen, een Dimona aangifte, enz."
        , "0"
        , "4"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/2'
);
