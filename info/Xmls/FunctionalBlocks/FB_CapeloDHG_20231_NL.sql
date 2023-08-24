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
SELECT "90416"
        , "2023/1"
        , "28/02/2023"
        , "Aangifte van de werkgever over de loopbaangeschiedenis van de werknemer"
        , "CareerHistoryEmployerDeclaration"
        , "Functioneel blok dat toelaat informatie over de loopbaangeschiedenis van een werknemer aan te geven."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90416'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90433"
        , "2023/1"
        , "28/02/2023"
        , "Aanvullende contactgegevens"
        , "ContactCoordinatesDetails"
        , "Functioneel blok dat toelaat de contactgegevens te specificeren."
        , "0"
        , "1"
        , "Kardinaliteit 0. Kardinaliteit 1 indien de zone 01029 (TYPE HISTORISCH ATTEST) gelijk is aan '5' (attest voor de regularisatie van de loopbaangeschiedenis van de werknemer)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90433'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90414"
        , "2023/1"
        , "28/02/2023"
        , "Attest - Loopbaangeschiedenis"
        , "CareerHistory"
        , "Root-element van het XML-bericht dat toelaat een attest Loopbaangeschiedenis mee te delen. Het attest Loopbaangeschiedenis bevat de loopbaangegevens van een werknemer van voor 31/12/2010."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90414'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90420"
        , "2023/1"
        , "28/02/2023"
        , "Baremieke wedde - historische gegevens"
        , "ScaleSalaryHD"
        , "Functioneel blok dat toelaat de gegevens te vermelden die betrekking hebben op de baremieke wedde die in aanmerking komt voor de berekening van het rustpensioen in de overheidssector."
        , "0"
        , "99"
        , "Facultatief"
        , "Verplicht voor de periodes na 01/01/2006 en voor dewelke de werknemer voor de aangevende werkgever heeft gewerkt."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90420'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90258"
        , "2023/1"
        , "28/02/2023"
        , "Communicatie"
        , "Communication"
        , "Functioneel blok dat toelaat de informatie inzake communicatie aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90258'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90415"
        , "2023/1"
        , "28/02/2023"
        , "Eigenschappen van het attest"
        , "AttestationProperties"
        , "Functioneel blok dat toelaat informatie over de eigenschappen van het attest mee te delen."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90415'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90419"
        , "2023/1"
        , "28/02/2023"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "CareerHistoryElement"
        , "Functioneel blok dat toelaat de gegevens in verband met een element uit de loopbaan van de werknemer aan te geven."
        , "1"
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90419'
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
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90059'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90257"
        , "2023/1"
        , "28/02/2023"
        , "Gegevens van de contactpersoon"
        , "CoordinatesContactPerson"
        , "Functioneel blok dat toelaat de gegevens van de contactpersoon aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90257'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90256"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de werkgever"
        , "EmployerId"
        , "Functioneel blok dat toelaat de werkgever te identificeren."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90256'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90418"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"
        , "CareerHistoryEmployerId"
        , "Functioneel blok dat toelaat een werkgever te identificeren waarvoor de werknemer op een bepaald moment van zijn loopbaan gewerkt heeft."
        , "1"
        , "99"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90418'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90437"
        , "2023/1"
        , "28/02/2023"
        , "Informatie over het historisch attest"
        , "HistoricalAttestationInformation"
        , "Functioneel blok waarin informatie over het historisch attest ingevoerd kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90437'
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
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90017'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90422"
        , "2023/1"
        , "28/02/2023"
        , "Niet-situeerbaar afwezigheid"
        , "NonSituableAbsence"
        , "Functioneel blok dat toelaat de gegevens in verband met de niet in de tijd situeerbare afwezigheden mee te delen.
De informatie moet gegroepeerd worden per jaar."
        , "0"
        , "99"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90422'
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
        , "2"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90417"
        , "2023/1"
        , "28/02/2023"
        , "Titels en diploma's"
        , "Degree"
        , "Functioneel blok dat toelaat de gegevens in verband met de titel(s) en/of diploma(s) van de persoon aan te geven."
        , "0"
        , "99"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90417'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90421"
        , "2023/1"
        , "28/02/2023"
        , "Weddebijslag - historische gegevens"
        , "AdditionalScaleSalaryHD"
        , "Functioneel blok waarin de elementen worden vermeld die betrekking hebben op de weddebijslagen die aanneembaar zijn voor de berekening van het rustpensioen of voor de perequatie van de pensioenen van de overheidssector."
        , "0"
        , "99"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90421'
                          AND Version = '2023/1'
);
