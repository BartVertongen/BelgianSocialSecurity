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
SELECT "90176"
        , "2023/1"
        , "28/02/2023"
        , "Anomalierapport"
        , "AnomalyReport"
        , "Functioneel blok dat toelaat een foutenrapport op te stellen."
        , "0"
        , "*"
        , "ONMISBAAR ALS RESULTCODE = 0"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90176'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90293"
        , "2023/1"
        , "28/02/2023"
        , "Betreffend kwartaal"
        , "ConcernedQuarter"
        , "Functioneel blok dat toelaat het betreffende kwartaal te identificeren"
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90293'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90322"
        , "2023/1"
        , "28/02/2023"
        , "Betrokken partner"
        , "InvolvedPartner"
        , "Gegevens van de partner die betrokken is bij de gegevensuitwisseling"
        , "1"
        , "3"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90322'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90341"
        , "2023/1"
        , "28/02/2023"
        , "Bijkomende informatie omtrent de aangifte"
        , "DeclarationComplInformations"
        , "Functioneel blok dat toelaat bijkomende informatie omtrent de aangifte aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90341'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90391"
        , "2023/1"
        , "28/02/2023"
        , "Bijkomende informatie over de anomalie"
        , "AnomalyComplInformation"
        , "Functioneel blok waar bijkomende informatie over de gesignaleerde anomalie gecommuniceerd kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90391'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90243"
        , "2023/1"
        , "28/02/2023"
        , "Blok actie"
        , "BlockAction"
        , "Bevat de informatie in verband met de acties die ondernomen moeten worden."
        , "1"
        , "*"
        , "Onmisbar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90243'
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
SELECT "90481"
        , "2023/1"
        , "28/02/2023"
        , "Dagelijkse registratie"
        , "DailyRegistration"
        , "Functioneel blok waarmee de situatie van de dagelijkse registratie na de verwerking van de aangifte in het personeelsbestand vermeld kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90481'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90484"
        , "2023/1"
        , "28/02/2023"
        , "Dagelijkse registratie na de aangifte"
        , "DailyRegistrationAfter"
        , "Functioneel blok waarmee de situatie van de dagelijkse registratie na de verwerking van de aangifte in het personeelsbestand vermeld kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90484'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90483"
        , "2023/1"
        , "28/02/2023"
        , "Dagelijkse registratie voor de aangifte"
        , "DailyRegistrationBefore"
        , "Functioneel blok waarmee de situatie van de dagelijkse registratie voor de verwerking van de aangifte in het personeelsbestand vermeld kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90483'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90325"
        , "2023/1"
        , "28/02/2023"
        , "Details over de returncode"
        , "DetailReturnCode"
        , "Functioneel blok met detail van de antwoordcode"
        , "0"
        , "5"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90325'
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
SELECT "90396"
        , "2023/1"
        , "28/02/2023"
        , "Dimonaperiode na de aangifte"
        , "DimonaPeriodAfter"
        , "Functioneel blok waar de situatie na de verwerking van de aangifte in het personeelsbestand vermeld kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90396'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90395"
        , "2023/1"
        , "28/02/2023"
        , "Dimonaperiode voor de aangifte"
        , "DimonaPeriodBefore"
        , "Functioneel blok waar de situatie voor de verwerking van de aangifte in het personeelsbestand vermeld kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90395'
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
        , "ONMISBAAR"
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
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90256'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90173"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie van de werknemerslijn"
        , "WorkerRecordIdentification"
        , "Functioneel blok dat toelaat informatie over de werknemerslijn op te geven."
        , "0"
        , "*"
        , "VERPLICHT INDIEN het formulier waarop de notificatie betrekking heeft, ten minste één van de zones van dit geldige blok bevat"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90173'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90392"
        , "2023/1"
        , "28/02/2023"
        , "Impactrapport"
        , "ImpactReport"
        , "Functioneel blok waar de informatie over het impactreport van een aangifte gecommuniceerd kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90392'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90491"
        , "2023/1"
        , "28/02/2023"
        , "Impactrapport van Capelo"
        , "CapeloImpactReport"
        , "Functioneel blok waarmee de gegevens over het resultaat van de verwerkingen van een attest 'Loopbaangeschiedenis' kan meegedeeld worden."
        , "0"
        , "1"
        , "FACULTATIEF"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90491'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90482"
        , "2023/1"
        , "28/02/2023"
        , "Impactrapport van de aangifte dagelijkse registratie"
        , "DailyRegistrationDclImpactReport"
        , "Functioneel blok waar de impact van een aangifte dagelijkse registratie op het personeelsbestand van de werkgever gecommuniceerd kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90482'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90581"
        , "2023/1"
        , "28/02/2023"
        , "Impactrapport van de aangifte van werken"
        , "AVWDDTImpactReport"
        , "Functioneel blok dat toelaat de verschillende identificatienummers mee te delen die aangemaakt zijn door een originele of wijzigende aangifte van werken."
        , "0"
        , "*"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90581'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90394"
        , "2023/1"
        , "28/02/2023"
        , "Impactrapport van de Dimona aangifte"
        , "DimonaImpactReport"
        , "Functioneel blok waar de impact van een Dimona-aangifte op het personeelsbestand van de werkgever gecommuniceerd kunnen worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90394'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90403"
        , "2023/1"
        , "28/02/2023"
        , "Impactrapport van de unieke werfmelding"
        , "UWMDUCImpactReport"
        , "Functioneel blok dat toelaat de verschillende identificatienummers mee te delen die aangemaakt zijn door een originele of wijzigende unieke werfmelding."
        , "0"
        , "*"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90403'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90320"
        , "2023/1"
        , "28/02/2023"
        , "Informatie KSZ"
        , "CBSSInformation"
        , "Gegevens met betrekking tot de verwerking door de Kruispuntbank"
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90320'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90390"
        , "2023/1"
        , "28/02/2023"
        , "Informatie over de ontvangst van het bestand"
        , "FileReceptionInformation"
        , "Functioneel blok waar de informatie over de ontvangst van het bestand aangegeven kan worden."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90390'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90329"
        , "2023/1"
        , "28/02/2023"
        , "Informatie over het veld"
        , "FieldInformation"
        , "Functioneel blok met informatie over het betrokken veld"
        , "0"
        , "5"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90329'
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
SELECT "90177"
        , "2023/1"
        , "28/02/2023"
        , "Lokalisatie van de anomalie"
        , "AnomalyLocation"
        , "Functioneel blok dat toelaat de plaats van de fout aan te duiden."
        , "0"
        , "1"
        , "VERPLICHT INDIEN als men de lijn of de kolom of de plaats kent van de fout die men wenst te melden"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90177'
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
SELECT "90180"
        , "2023/1"
        , "28/02/2023"
        , "Notificatie"
        , "NOTIFICATION"
        , "Root van de XML-boodschap Notificatie."
        , "1"
        , "1"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90180'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90178"
        , "2023/1"
        , "28/02/2023"
        , "Pad"
        , "Path"
        , "Functioneel blok dat toelaat informatie over het pad naar de fouten op te geven."
        , "0"
        , "1"
        , "VERPLICHT INDIEN het formulier waarop de notificatie betrekking heeft, ten minste één van de zones van dit geldige blok bevat"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90178'
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
        , "4"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90174"
        , "2023/1"
        , "28/02/2023"
        , "Referentie tewerkstelling"
        , "OccupationReference"
        , "Functioneel blok dat toelaat een referentie naar de tewerkstelling op te geven."
        , "0"
        , "*"
        , "VERPLICHT INDIEN het formulier waarop de notificatie betrekking heeft, ten minste één van de zones van dit geldige blok bevat"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90174'
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
        , "VERPLICHT INDIEN het formulier waarop de notificatie betrekking heeft, verzonden werd per bestand"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90102'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90175"
        , "2023/1"
        , "28/02/2023"
        , "Resultaat van de verwerkingen van het formulier"
        , "HandlingResult"
        , "Functioneel blok dat toelaat informatie aan te geven omtrent de resultaten van de behandeling van het formulier."
        , "1"
        , "1"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90175'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90410"
        , "2023/1"
        , "28/02/2023"
        , "Specifieke gegevens voor de gebruikende toepassing"
        , "ApplicationData"
        , "Functioneel blok dat toelaat om via een notificatie informatie mee te delen in verband met een origineel bericht, namelijk:\nhet originele bericht zelf EN/OF het verrijkte originele bericht  EN/OF het impactrapport van dit originele bericht."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90410'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90215"
        , "2023/1"
        , "28/02/2023"
        , "Systeemverbeteringen"
        , "SystemCorrection"
        , "Functioneel blok dat bevat informatie in verband met de verbeteringen voorgesteld door het systeem op het formulier waarnaar deze notificatie verwijst."
        , "0"
        , "1"
        , "Verplicht indien het formulier waarnaar deze notificatie verwijst, een DmfA is die systeemverbeteringen ondergaan zou hebben."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90215'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90436"
        , "2023/1"
        , "28/02/2023"
        , "Vergelijking DMFA/DIMONA"
        , "DmfADimonaConfrontation"
        , "Functioneel blok dat toelaat de gegevens ingevuld in DmfA en in Dimona met elkaar te vergelijken."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90436'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90324"
        , "2023/1"
        , "28/02/2023"
        , "Verrijkt blok informatie KSZ"
        , "HandledCBSSInformation"
        , "Functioneel blok met verrijkte informatie KSZ."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90324'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90511"
        , "2023/1"
        , "28/02/2023"
        , "Verrijkt blok origineel bestand"
        , "HandledOriginalFile"
        , "Dit functionele blok maakt het mogelijk om de identificatie van de afzender door te sturen naar de toepassing of instelling van de sociale zekerheid waarop het formulier betrekking heeft. Dit blok bevindt zich eveneens in de antwoorden voor de aangevers zoals ACRF, de melding, ... Dit functioneel blok kan toegevoegd worden door de informaticatoepassing die de bestanden, verstuurd door de aangevers, ontvangt."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90511'
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
        , "0"
        , "1"
        , "VERPLICHT INDIEN het formulier waarop de notificatie betrekking heeft, een blok FORM bevat met al zijn geldige zones"
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
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90155'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90560"
        , "2023/1"
        , "28/02/2023"
        , "Verrijkte identificatie van de verzender"
        , "HandledSenderIdentification"
        , "Functioneel blok dat toelaat de verrijkte identificatie van de verzender aan te geven."
        , "0"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90560'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90242"
        , "2023/1"
        , "28/02/2023"
        , "Waarde van het gegeven"
        , "DataValue"
        , "Functioneel blok dat alle waarden die geassocieerd worden met een verbetering bevat."
        , "0"
        , "*"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90242'
                          AND Version = '2023/1'
);
