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
SELECT "90488"
        , "2023/1"
        , "28/02/2023"
        , "Adres van de site"
        , "SiteAddress"
        , "Functioneel blok dat toelaat een adres van de site te specifiëren."
        , "0"
        , "1"
        , "Verplicht indien de waarde van de actiecode van het FB 90400 (Project dat de werken omvat- Wijziging) gelijk is aan '2' (toevoeging)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90488'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90478"
        , "2023/1"
        , "28/02/2023"
        , "Andere actor - Wijziging"
        , "OtherParticipantUpdate"
        , "Functioneel blok waarmee een actor die aangifte doet geïdentificeerd kan worden in het kader van een aangifte van wijziging."
        , "0"
        , "4"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90478'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90490"
        , "2023/1"
        , "28/02/2023"
        , "AVWDDT Update"
        , "AVWDDTUpdate"
        , "Brongegeven van het XML-bericht dat toelaat wijzigingen uit te voeren op een Aangifte Van Werken (AVW)."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90490'
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
        , "Verplicht indien het FB Communicatie verbonden is met een FB Identificatie van de aangever van het contract met betrekking tot de werken\n- Wijziging (90398) of met een FB Identificatie van de tijdelijke handelsvennootschap\n- Wijziging (90399) waarin de waarde van de actiecode gelijk is aan '2' (toevoeging).\nVerplicht indien het FB Communicatie verbonden is met het FB Gegevens van de contactpersoon (90257), dat zelf verbonden is met een FB  Project dat de werken omvat - Wijziging (90400) of met een FB Luik contract met betrekking tot de werken - Wijziging (90401) waarin de waarde van de actiecode gelijk is aan '2' (toevoeging).\nFacultatief in de andere gevallen."
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
        , "0"
        , "1"
        , "Verplicht indien de waarde van de actiecode van het FB 90401 (Luik contract met betrekking tot de werken - Wijziging)
verbonden met het FB (Gegevens van de contactpersoon) gelijk is aan '2' (toevoeging)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90257'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90398"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de aangever van het contract met betrekking tot de werken - Wijziging"
        , "WorksContractDeclarantIdUpdate"
        , "Functioneel blok waarin informatie gegeven kan worden over de aangever van het contract met betrekking tot de werken/ diensten in het kader van een wijzigende aangifte."
        , "1"
        , "1"
        , "Onmisbaar"
        , "In het geval dat de aannemer die aangenomen wordt voor de werken een tijdelijke handelsvennootschap is, dan moeten de blokken 'Identificatie van de aangever van het contract met betrekking tot de werken' en 'Identificatie van de tijdelijke handelsvennootschap' beide aanwezig zijn.\nDe aangever van het contract met betrekking tot de werken moet dan de vennoot vermelden die verantwoordelijk is voor de aangifte in opdracht van deze tijdelijke handelsvennootschap in het blok 'Identificatie van de aangever van het contract met betrekking tot de werken' (90381)."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90398'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90402"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de onderaannemer - Wijziging"
        , "SubcontractorIdUpdate"
        , "Functioneel blok waarin informatie gegeven kan worden over een onderaannemer in het kader van een wijzigende aangifte."
        , "0"
        , "*"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90402'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90399"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de tijdelijke handelsvennootschap - Wijziging"
        , "TempComCompanyIDUpdate"
        , "Functioneel blok waarin informatie gegeven kan worden over een tijdelijke handelsvennootschap in het kader van een wijzigende aangifte.\nDe tijdelijke handelsvennootschap is een vennootschap die zonder een gemeenschappelijke naam te voeren, één of meer bepaalde handelsverrichtingen tot doel heeft.\nDe tijdelijke handelsvennootschappen worden gevormd onder vennoten die zelf het doel en de vorm ervan bepalen volgens de belangenverhouding en tegen de voorwaarden die zij onderling overeenkomen."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90399'
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
        , "0"
        , "1"
        , "Verplicht indien de waarde van de actiecode van het FB 90402 (Identificatie van de onderaannemer - Wijziging) gelijk is aan '2' (toevoeging).\nFacultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90389'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90401"
        , "2023/1"
        , "28/02/2023"
        , "Luik 'contract met betrekking tot de werken - Wijziging'"
        , "WorksContractUpdate"
        , "Functioneel blok waarin informatie gegeven kan worden over een contract met betrekking tot de werken/ diensten in het kader van een wijzigende aangifte."
        , "0"
        , "1"
        , "Verplicht indien de waarde van de actiecode in het FB 90398 'Identificatie van de aangever van het contract met betrekking tot de werken - Wijziging' gelijk is aan '2' (toevoeging)., '1' (wijziging) of '7' (wijziging van de subboom). Facultatief in de andere gevallen."
        , "De waarde '9' (ACTIECODE - 00411) is niet toegelaten voor dit blok."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90401'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90400"
        , "2023/1"
        , "28/02/2023"
        , "Project dat de werken omvat - Wijziging"
        , "WorksGlobalProjectUpdate"
        , "Functioneel blok waarin informatie gegeven kan worden over het project dat de werken/ diensten omvat in het kader van een wijzigende aangifte."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90400'
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
