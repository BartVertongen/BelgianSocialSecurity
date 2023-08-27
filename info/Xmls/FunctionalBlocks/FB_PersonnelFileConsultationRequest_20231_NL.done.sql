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
SELECT "90493"
        , "2023/1"
        , "28/02/2023"
        , "Gegevens van de optie"
        , "DataOption"
        , "Functioneel blok dat toelaat om een optie van een element te beschrijven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90493'
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
SELECT "90426"
        , "2023/1"
        , "28/02/2023"
        , "PersonnelFileConsultationRequest"
        , "PersonnelFileConsultationRequest"
        , "Root-element van het XML-bericht dat toelaat een aanvraag tot raadpleging van het personeelsbestand voor een bepaalde werkgever mee te delen"
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90426'
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
SELECT "90077"
        , "2023/1"
        , "28/02/2023"
        , "Referteperiode"
        , "ReferencePeriod"
        , "Functioneel blok dat toelaat de referteperiode aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90077'
                          AND Version = '2023/1'
);
