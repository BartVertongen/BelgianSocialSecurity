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
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90022'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90349"
        , "2023/1"
        , "28/02/2023"
        , "Bericht van wijziging der bijdragen"
        , "AccountUpdateReport"
        , "Functioneel blok dat toelaat de informatie in verband met het bericht van wijziging der bijdragen mee te delen"
        , "0"
        , "1"
        , "Kardinaliteit 0 als de verwerking van de verbeteringen opgenomen in het bericht een financiële impact nul heeft, of binnen de tolerantiegrenzen gedefinieerd door de RSZ, en dit voor alle betrokken kwartalen.\nKardinaliteit 1 als de verwerking van de verbeteringen opgenomen in het bericht een significante financiÃ«le impact heeft, boven de tolerantiegrenzen gedefinieerd door de RSZ, en dit voor ten minste één kwartaal."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90349'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90351"
        , "2023/1"
        , "28/02/2023"
        , "BewareNotification"
        , "BewareNotification"
        , "Root-element van het XML-bericht. Functioneel blok dat de communicatie mogelijk maakt van:\n- de boekhoudkundige informatie in verband met de wijzigingen van een DmfA;\n- eventueel, de gegevens in verband met het bericht van wijziging der bijdragen dat hieruit resulteert.\nOpmerking: met de term 'Beware-notificatie' wordt verwezen naar het XML-bericht bestemd voor technisch gebruik.\nDe officiële documenten (in een eerste fase in papieren vorm) blijven de vermelding 'bericht van wijziging der bijdragen' behouden."
        , "1"
        , "1"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90351'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90358"
        , "2023/1"
        , "28/02/2023"
        , "Boekhoudkundig overzicht - Verminderingscode"
        , "DeductionAccountingOverview"
        , "Functioneel blok dat toelaat een globaal overzicht mee te delen van de aanwezige verminderingscodes."
        , "0"
        , "*"
        , "Kardinaliteit 0 als er geen verminderingscode aanwezig is Kardinaliteit 1-* als er één of meer verminderingscodes aanwezig zijn."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90358'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90606"
        , "2023/1"
        , ""
        , "Boekhoudkundig overzicht - Werkgeverscompensatie"
        , "EmployerCompensationOverview"
        , "Functioneel blok dat toelaat een globaal overzicht mee te delen van de compensaties."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90606'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90357"
        , "2023/1"
        , "28/02/2023"
        , "Boekhoudkundig overzicht - werknemerskengetal bijdrage"
        , "WorkerContAccountingOverview"
        , "Functioneel blok dat toelaat een globaal overzicht mee te delen van de aanwezige werknemerskengetallen bijdragen."
        , "0"
        , "*"
        , "Kardinaliteit 0 als er geen werknemerskengetal bijdrage aanwezig is Kardinaliteit 1-* als er één of meer werknemerskengetallen bijdragen aanwezig zijn."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90357'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90359"
        , "2023/1"
        , "28/02/2023"
        , "Boekhoudkundig overzicht - Werknemerskengetal voor een bijdrage die niet gebonden is aan een natuurlijke persoon"
        , "CUNPAccountingOverview"
        , "Functioneel blok dat toelaat een globaal overzicht mee te delen van de aanwezige werknemerskengetallen voor een bijdrage die niet gebonden is aan een natuurlijke persoon"
        , "0"
        , "*"
        , "Kardinaliteit 0 als er geen werknemerskengetal aanwezig is voor een bijdrage die niet gebonden is aan een natuurlijk persoon Kardinaliteit 1-* als er een of meer werknemerskengetallen aanwezig zijn voor een bijdrage die niet gebonden is aan een natuurlijk persoon ."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90359'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90353"
        , "2023/1"
        , "28/02/2023"
        , "Boeking"
        , "AccountingEntry"
        , "Functioneel blok dat toelaat de gegevens mee te delen met betrekking tot een wijziging vastgesteld in de kwartaalrekening van de werkgever."
        , "1"
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90353'
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
SELECT "90265"
        , "2023/1"
        , "28/02/2023"
        , "Coördinaten werkgever"
        , "CoordinatesEmployer"
        , "Functioneel blok dat toelaat de coördinaten van een werkgever aan te geven."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90265'
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
SELECT "90369"
        , "2023/1"
        , "28/02/2023"
        , "Gegevens van de mandataris"
        , "CoordinatesRepresentative"
        , "Functioneel blok dat toelaat de gegevens van een mandataris mee te delen"
        , "0"
        , "1"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90369'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90368"
        , "2023/1"
        , "28/02/2023"
        , "Gegevens van het sociaal secretariaat"
        , "CoordinatesSocialSecretariat"
        , "Functioneel blok dat toelaat de gegevens van een sociaal secretariaat aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90368'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90367"
        , "2023/1"
        , "28/02/2023"
        , "Informatie over de bestemmeling"
        , "ReceiverInformation"
        , "Functioneel blok dat toelaat informatie over de bestemmeling te communiceren."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90367'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90366"
        , "2023/1"
        , "28/02/2023"
        , "Informatie over de sector"
        , "SectorInformation"
        , "Functioneel blok dat toelaat informatie over de sector aan te geven."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90366'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90352"
        , "2023/1"
        , "28/02/2023"
        , "Informatie van de Beware-notificatie"
        , "BewareInformation"
        , "Functioneel blok dat toelaat de algemene informatie in verband met de Beware-notificatie mee te delen."
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90352'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90356"
        , "2023/1"
        , "28/02/2023"
        , "Informatie van de multifunctionele aangifte"
        , "DmfAInformation"
        , "Functioneel blok dat toelaat de informatie in verband met een (originele of wijzigende) multifunctionele aangifte mee te delen."
        , "1"
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90356'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90434"
        , "2023/1"
        , "28/02/2023"
        , "Instructie voor de werkgever"
        , "EmployerInstruction"
        , "Functioneel blok met de instructie aan de werkgever i.v.m. de betaling of terugbetaling van het in de notificatie opgenomen bedrag."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90434'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90354"
        , "2023/1"
        , "28/02/2023"
        , "Lijst van de verwerkte verbeteringen"
        , "ProcessedCorrectionsReport"
        , "Functioneel blok dat toelaat de lijst van de verwerkte verbeteringen mee te delen in het bericht"
        , "1"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90354'
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
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90435"
        , "2023/1"
        , "28/02/2023"
        , "Rekeningstand"
        , "AccountSituation"
        , "Functioneel blok dat de gegevens van de rekeningstand bevat als hij aanwezig is."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90435'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90355"
        , "2023/1"
        , "28/02/2023"
        , "Sectie verwerkte verbeteringen"
        , "ProcessedCorrectionsSection"
        , "Functioneel blok dat toelaat de kwartalen van de verwerkte verbeteringen mee te delen en een aanduiding die aangeeft of deze verbeteringen aanleiding hebben gegeven tot een bericht van wijziging der bijdragen."
        , "1"
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90355'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90350"
        , "2023/1"
        , "28/02/2023"
        , "Sectie wijzigend bericht"
        , "AccountUpdateSection"
        , "Functioneel blok dat toelaat de kwartalen en classificaties mee te delen van verbeteringen die deelnemen aan de opstelling van het wijzigend bericht."
        , "1"
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90350'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90240"
        , "2023/1"
        , "28/02/2023"
        , "Subgroep - Informatie"
        , "SubGroupInformation"
        , "Functioneel blok dat toelaat het verwerkte deel van de aangifte te kenmerken en eventueel het deel in verband met de diverse verbeteringen waartoe dit geleid zou hebben."
        , "1"
        , "*"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90240'
                          AND Version = '2023/1'
);
