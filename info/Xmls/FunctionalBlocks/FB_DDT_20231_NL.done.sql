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
        , "Functioneel blok dat toelaat een adres volledig te specifiÃ«ren."
        , "0"
        , "1"
        , "Verplicht indien het ondernemingsnummer (00014) van de actor gelinkt met het FB Adres niet aanwezig is.Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90022'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90488"
        , "2023/1"
        , "28/02/2023"
        , "Adres van de site"
        , "SiteAddress"
        , "Functioneel blok dat toelaat een adres van de site te specifiëren."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90488'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90477"
        , "2023/1"
        , "28/02/2023"
        , "Andere actor"
        , "OtherParticipant"
        , "Functioneel blok waarmee een andere actor dan de opdrachtgever geïdentificeerd kan worden."
        , "0"
        , "4"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90477'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90489"
        , "2023/1"
        , "28/02/2023"
        , "AVWDDT"
        , "AVWDDT"
        , "Brongegeven van het XML-bericht dat toelaat Aangiftes Van Werken (AVW) te genereren."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90489'
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
        , "Verplicht indien het FB Communicatie gelinkt is met het FB 90257 (Contactpersoon). Facultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90258'
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
SELECT "90381"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de aangever van het contract met betrekking tot de werken"
        , "WorksContractDeclarantId"
        , "Functioneel blok waar de informatie over de aangever van het contract met betrekking tot de werken/ diensten gegeven kan worden."
        , "1"
        , "1"
        , "Onmisbaar"
        , "In het geval dat de ondernemer die de aangifte doet aangenomen voor de werken/diensten een tijdelijke vennootschap is, moeten het FB 90381 (Identificatie van de aangever van een contract met betrekking tot de werken) en het FB 90382 (Identificatie van de tijdelijke handelsvennootschap) beide aanwezig zijn.\nHet FB 90381 (Identificatie van de aangever van het contract met betrekking tot de werken) zal dan de vennoot verantwoordelijk voor de aangifte moeten vermelden in opdracht van deze tijdelijke vennootschap."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90381'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90388"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de onderaannemer"
        , "SubcontractorId"
        , "Functioneel blok waar de informatie over een onderaannemer vermeld kan worden."
        , "0"
        , "*"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90388'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90384"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de opdrachtgever"
        , "WorksGlobalProjectOwnerId"
        , "Functioneel blok waar de informatie over de opdrachtgever aangegeven kan worden."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90384'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90382"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de tijdelijke handelsvennootschap"
        , "TempComCompanyID"
        , "Functioneel blok waar informatie over een tijdelijke handelsvennootschap gegeven kan worden.\nDe tijdelijke handelsvennootschap is een vennootschap die zonder een gemeenschappelijke naam te voeren, één of meer bepaalde handelsverrichtingen tot doel heeft.\nDe tijdelijke handelsvennootschappen worden gevormd onder vennoten die zelf het doel en de vorm ervan bepalen volgens de belangenverhouding en tegen de voorwaarden die zij onderling overeenkomen."
        , "0"
        , "1"
        , "Facultatief"
        , "In het geval dat de aannemer die aangenomen wordt voor de werken een tijdelijke handelsvennootschap is, dan moeten het FB 90381 (Identificatie van de aangever van het contract met betrekking tot de werken) en het FB 90382 (Identificatie van de tijdelijke handelsvennootschap) beide aanwezig zijn.\nHet FB 90381 (Identificatie van de aangever van het contract met betrekking tot de werken) zal dan de geassocieerde verantwoordelijke van de aangifte moeten aangeven voor deze tijdelijke handelsvennootschap."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90382'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90389"
        , "2023/1"
        , "28/02/2023"
        , "Informatie over de activiteit van de onderaannemer"
        , "SubcontractorActivityInfo"
        , "Functioneel blok waar bepaalde informatie over de activiteiten van de onderaannemer gepreciseerd kan worden."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90389'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90387"
        , "2023/1"
        , "28/02/2023"
        , "Luik 'Contract met betrekking tot de werken'"
        , "WorksContract"
        , "Functioneel blok waar de informatie over de aangever van het contract met betrekking tot de werken/ diensten vermeld kan worden."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90387'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90383"
        , "2023/1"
        , "28/02/2023"
        , "Project dat de werken omvat"
        , "WorksGlobalProject"
        , "Functioneel blok waar informatie over het project dat de werken/ diensten omvat kan aangegeven worden."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90383'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90082"
        , "2023/1"
        , "28/02/2023"
        , "Referentie"
        , "Reference"
        , "Functioneel blok dat toelaat referenties te preciseren in verband met Ã©Ã©n of meer formulieren; een formulier kan een originele DmfA-aangifte zijn, een wijzigende DmfA-aangifte, een ASR, een aanvraag van inlichtingen, een Dimona aangifte, enz."
        , "1"
        , "2"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90573"
        , "2023/1"
        , "28/02/2023"
        , "Werkgevende onderneming"
        , "SubcontractorEmployerId"
        , "Functioneel blok dat toelaat de rechtstreekse werkgever van de onderaannemer te identificeren."
        , "1"
        , "1"
        , "Onmisbaar"
        , "De rechtstreekse werkgever van de onderaannemer is de aangever of de onderaannemer.\nIn dit laatste geval moet deze onderaannemer aanwezig zijn in hetzelfde bericht, zelfs als het om een toevoeging gaat en de onderaannemer-werkgever al eerder werd aangegeven.\nIn het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90573'
                          AND Version = '2023/1'
);
