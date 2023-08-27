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
SELECT "90529"
        , "2023/1"
        , "28/02/2023"
        , "Aanvraagformulier loopbaanonderbreking of tijdskrediet"
        , "LOIC001"
        , "Root-element van het XML-bericht dat toelaat aanvragen loopbaanonderbreking of tijdskrediet te maken."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90529'
                          AND Version = '2023/1'
);


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
SELECT "90535"
        , "2023/1"
        , "28/02/2023"
        , "Collectieve arbeidsovereenkomst"
        , "CollectiveLabourAgreement"
        , "Functioneel blok waarmee informatie kan worden gegeven over de cao."
        , "0"
        , "1"
        , "Verplicht indien een tijdskrediet wordt aangevraagd."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90535'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90036"
        , "2023/1"
        , "28/02/2023"
        , "Commentaar bij de aangifte"
        , "CommentDeclaration"
        , "Functioneel blok dat toelaat commentaar bij de aangifte op te geven."
        , "0"
        , "1"
        , "Facultatief indien geen annulerende formulier is. Verboden in alle andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90036'
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
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90258'
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
        , "Verplicht indien geen annulerende formulier is. Verboden in alle andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90257'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90534"
        , "2023/1"
        , "28/02/2023"
        , "Informatie over de drempel van het aantal werknemers in onderbreking"
        , "InterruptionThresholdInformation"
        , "Functioneel blok waarmee informatie kan worden gegeven over de drempel van het aantal werknemers in tijdskrediet."
        , "0"
        , "1"
        , "Verplicht indien een tijdskrediet wordt aangevraagd, met uitzondering van de werknemers die een tijdskrediet 1/5 aanvragen en die op de begindatum van de onderbreking 55+ zijn."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90534'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90530"
        , "2023/1"
        , "28/02/2023"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "InterruptionInformation"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet."
        , "0"
        , "1"
        , "Verplicht indien geen annulerende formulier is. Verboden in alle andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90530'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90171"
        , "2023/1"
        , "28/02/2023"
        , "Informatie van de aangifte"
        , "DclInformation"
        , "Functioneel blok dat toelaat informatie bij de aangifte te preciseren."
        , "0"
        , "1"
        , "Verplicht indien geen annulerende formulier is. Verboden in alle andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90171'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90531"
        , "2023/1"
        , "28/02/2023"
        , "Rubriek werkgever van het aanvraagformulier op onderbreking"
        , "EmployerInterruptionForm"
        , "Rubriek werkgever van het aanvraagformulier loopbaanonderbreking of tijdskrediet."
        , "0"
        , "1"
        , "Verplicht indien geen annulerende formulier is. Verboden in alle andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90531'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90533"
        , "2023/1"
        , "28/02/2023"
        , "Vraag - Loopbaanonderbreking"
        , "InterruptionQuestion"
        , "Functioneel blok met een bepaalde vraag en het antwoord erop."
        , "1"
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90533'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90532"
        , "2023/1"
        , "28/02/2023"
        , "Vragenlijst"
        , "Questionnaire"
        , "Fonctioneel blok dat de vragen met betrekking tot dit formulier omvat."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90532'
                          AND Version = '2023/1'
);
