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
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90059'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90326"
        , "2023/1"
        , "28/02/2023"
        , "Geldige situatie"
        , "ValidSituation"
        , "Functioneel blok met de geldige informatie (nieuwe situatie) "
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90326'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90328"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie-informatie IDFLUX"
        , "IdfluxInformation"
        , "Functioneel blok met de identificatie-informatie vervoerd door IDFLUX"
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90328'
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
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90256'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90323"
        , "2023/1"
        , "28/02/2023"
        , "IDFLUX"
        , "IDFLUX"
        , "Root van de IDFLUX XML-boodschap"
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90323'
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
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90327"
        , "2023/1"
        , "28/02/2023"
        , "Verouderde situatie"
        , "OutdatedSituation"
        , "Functioneel blok met de verouderde informatie (vorige situatie)."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90327'
                          AND Version = '2023/1'
);
