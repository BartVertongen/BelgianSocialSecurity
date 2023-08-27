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
SELECT "90074"
        , "2023/1"
        , "28/02/2023"
        , "Aard van de dag"
        , "NatureOfDay"
        , "Functioneel blok dat toelaat de gegevens over de aard van de dagen aan te geven."
        , "0"
        , "62"
        , "Kardinaliteit 1: 0..62 VERPLICHT INDIEN de identificatie van het risico 002 is en de werknemer tijdens de referteperiode vakantie genomen heeft of tijdelijk werkloos was of arbeidsongeschikt was ten gevolge van een arbeidsongeval of een beroepsziekte."
        , "VERBODEN indien de identificatie van het risico 001 is."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90074'
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
        , "Verplicht indien het blok 'Communicatie' niet aanwezig is"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90022'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90030"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis - bijzondere omstandigheden"
        , "ExceptSituationCalculBase"
        , "Functioneel blok dat toelaat informatie te geven over situaties die afwijken van de tewerkstellingsgegevens."
        , "1"
        , "1"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90030'
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
        , "Kardinaliteit 1: 0..1 FACULTATIEF"
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
SELECT "90085"
        , "2023/1"
        , "28/02/2023"
        , "Exact loon"
        , "ExactSalary"
        , "Functioneel blok dat toelaat de gegevens over het exact loon aan te geven."
        , "0"
        , "*"
        , "Kardinaliteit 1: 1..* VERPLICHT INDIEN de identificatie van het risico 002 is."
        , "VERBODEN INDIEN de identificatie van het risico 001."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90085'
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
        , "Kardinaliteit 1: 1..* ONMISBAAR"
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
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90257'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90064"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie risico"
        , "RiskIdentification"
        , "Functioneel blok dat toelaat het risico te identificeren."
        , "1"
        , "1"
        , "Kardinaliteit 1: 1 ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90064'
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
        , "1"
        , "1"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90171'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90067"
        , "2023/1"
        , "28/02/2023"
        , "Link met aangifte werkgever"
        , "EmployerDeclarationLink"
        , "Functioneel blok dat toelaat de gegevens van de link met de werkgeversaangifte aan te geven."
        , "0"
        , "1"
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN de aangifte een werkgever aangesloten bij RSZ betreft, de provinciale en plaatselijke besturen inbegrepen indien het kwartaal van de aangifte groter of gelijk is aan 20221."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90067'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90068"
        , "2023/1"
        , "28/02/2023"
        , "Link met tewerkstelling werknemerslijn"
        , "OccupationLink"
        , "Functioneel blok dat toelaat de gegevens in verband met de link met een tewerkstelling aan te geven."
        , "1"
        , "*"
        , "Kardinaliteit 1: 1..* ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90068'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90168"
        , "2023/1"
        , "28/02/2023"
        , "Link met werkgeversaangifte PPL"
        , "NOSSLPAEmployerDeclarationLink"
        , "Functioneel blok dat toelaat de gegevens van de link met de werkgeversaangifte PPL aan te geven."
        , "0"
        , "1"
        , "Kardinaliteit 1: 1 VERPLICHT indien de aangifte een provinciaal en/of plaatselijk bestuur tot en met 20214 betreft."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90168'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90063"
        , "2023/1"
        , "28/02/2023"
        , "Link met werknemerslijn"
        , "WorkerRecordLink"
        , "Functioneel blok dat toelaat de gegevens in verband met de link met een werknemerslijn aan te geven."
        , "0"
        , "*"
        , "Verplicht indien geen annulatie. Verboden in het geval van een annulatie."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90063'
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
        , "Kardinaliteit 1: 1 ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90017'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90018"
        , "2023/1"
        , "28/02/2023"
        , "Prestatie van de tewerkstelling werknemerslijn"
        , "Service"
        , "Functioneel blok dat toelaat de prestaties van een werknemer voor een tewerkstelling van de werknemerslijn aan te geven."
        , "0"
        , "99"
        , "Kardinaliteit 1: 1..99 VERPLICHT INDIEN de identificatie van het risico 001 is en er ten minste één prestatie aangegeven moet worden."
        , "VERBODEN indien de identificatie van het risico 002 is.
Een gegeven prestatie (een prestatiecode) mag slechts één keer voorkomen per tewerkstelling."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90018'
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
        , "3"
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN de aangifte een wijziging of een annulatie betreft."
        , "- Per referentietype mag slechts één blok 'Referentie' dat een ticketnummer is, aangegeven worden.\n- Indien het type formulier 'SU' betreft, zijn alle waarden overeenkomstig het glossarium.\n- Indien de 'status van het attest' een 'wijziging van een papieren origineel' is, mag geen enkel blok 'Referentie' met een ticketnummer aangegeven worden.\n- Indien de 'status van het attest' een 'wijziging' of een 'annulatie' is, moet juist één blok 'Referentie' met een ticketnummer en referentietype '3' aangegeven worden. In geen enkele andere situatie mag soortgelijke referentie aangegeven worden."
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
        , "1"
        , "1"
        , "Kardinaliteit 1: 1 ONMISBAAR"
        , "De referteperiode moet betrekking hebben op dezelfde maand en hetzelfde jaar voor alle tewerkstellingen."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90077'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90524"
        , "2023/1"
        , "28/02/2023"
        , "Verbrekingsvergoeding"
        , "SeverancePayment"
        , "Functioneel blok dat toelaat informatie over de verbrekingsvergoeding aan te geven."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de beëindiging van de tewerkstelling leidt tot een verbrekingsvergoeding."
        , "Het blok wordt gelinkt aan de tewerkstelling van ontslag.\nHet blok mag niet aanwezig zijn indien geen einddatum van tewerkstelling werd ingevuld of indien voor de combinatie werkgeverscategorie / werknemerskengetal geen verbrekingsvergoeding mogelijk is."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90524'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90139"
        , "2023/1"
        , "28/02/2023"
        , "ZIMA002"
        , "ZIMA002"
        , "Root van de XML-boodschap die toelaat aangiften van dit scenario te doen."
        , "1"
        , "1"
        , "Kardinaliteit 1:1;  ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90139'
                          AND Version = '2023/1'
);
