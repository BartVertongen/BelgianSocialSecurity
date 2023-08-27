/*
CREATE TABLE zones(
   Code                 TEXT NOT NULL
   , Version            TEXT NOT NULL
   , PublicationDay     TEXT NOT NULL
   , Title              TEXT NOT NULL
   , XmlLabel           TEXT NOT NULL
   , FunctionalBlock    TEXT NOT NULL
   , DescriptionNL      TEXT NOT NULL
   , DomainNL           TEXT NOT NULL
   , Reference          TEXT
   , Type               TEXT NOT NULL
   , Length             INTEGER
   , Presence           TEXT NOT NULL
   , Format             TEXT NOT NULL
   , PRIMARY KEY (Code, Version)
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00872"
        , "2023/1"
        , "28/02/2023"
        , "DATUM - BOEKHOUDKUNDIGE DATUM"
        , "AccountingDate"
        , "Detail van de Beware-notificatie"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Facultatief "
        , "JJJJ-MM-DD -- JJJJ is het jaar -- MM is de maand -- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00872'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01032"
        , "2023/1"
        , "28/02/2023"
        , "DATUM - REFERENTIEDATUM"
        , "ReferenceDate"
        , "Detail van de Beware-controlelijst"
        , "Datum waarop de notificaties vermeld in deze controlelijst verzonden werden."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar "
        , "JJJJ-MM-DD -- JJJJ is het jaar -- MM is de maand -- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01032'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00218"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VAN CREATIE VAN HET FORMULIER"
        , "FormCreationDate"
        , "Formulier"
        , "Datum waarop het formulier gecreëerd is."
        , "JJJJ is een element van [lopend jaar -1 ; lopend jaar] ; De datum mag zich niet in de toekomst bevinden."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar "
        , "JJJJ-MM-DD -- JJJJ is het jaar -- MM is de maand -- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00218'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00805"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VERZENDING"
        , "DateSubmission"
        , "Detail van de Beware-controlelijst"
        , "Datum van de verzendingDatum waarop het formulier verzonden is."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar"
        , "JJJJ-MM-DD -- JJJJ is het jaar -- MM is de maand -- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00805'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00298"
        , "2023/1"
        , "28/02/2023"
        , "HERKOMST VAN DE REFERENTIE"
        , "ReferenceOrigin"
        , "Referentie"
        , "Waarde die de authentieke bron van een referentienummer aanduidt"
        , "1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal secretariaat, een softwareontwikkelaar, ...)\n2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een antwoord op eenduidige wijze identificeert\n3 = het referentienummer is toegekend door een sector van de sociale zekerheid\n4 = het referentienummer is toegekend door de dienst ePost\n5 = het referentienummer is toegekend door de KSZ\n6 = het referentienummer is toegekend door het archiveringssysteem (DOC-ID)\n7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend (DSP-ID)\nDe mogelijke waarden in dit bericht zijn '2' en '3'.\n"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00298'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00296"
        , "2023/1"
        , "28/02/2023"
        , "IDENTIFICATIE VAN HET FORMULIER"
        , "Identification"
        , "Formulier"
        , "Zone die de inhoud van een formulier beschrijft."
        , "Zie bijlage 11 - Identificatie van het formulier.\nDe enige mogelijke waarde in dit bericht is 'BEWLST'."
        , ""
        , "Alfanumeriek"
        , "7"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00296'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00150"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN ERKEND SOCIAAL SECRETARIAAT BIJKANTOOR"
        , "FilialSecSocNbr"
        , "Detail van de Beware-notificatie"
        , ""
        , ""
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00150'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00479"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN SOCIAAL SECRETARIAAT"
        , "SocialSecretariatNumber"
        , "Detail van de Beware-controlelijst"
        , ""
        , ""
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00479'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/1"
        , "28/02/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Detail van de Beware-notificatie"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon."
        , "Getal van 10 cijfers waarvan :\nde posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;\nde posities 9 en 10 overeenkomen met een controlegetal.\nAls het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.\n"
        , ""
        , "Numeriek"
        , "10"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00299"
        , "2023/1"
        , "28/02/2023"
        , "PRECIES UUR VAN CREATIE VAN HET FORMULIER"
        , "FormCreationHour"
        , "Formulier"
        , "Tijdstip, uitgedrukt in uren, minuten, seconden en milliseconden."
        , "UU is een element van [00;23]\nMM is een element van [00;59]\nSS is een element van [00;59]\nSSS is een element van [000;999]\n"
        , ""
        , "Alfanumeriek"
        , "12"
        , "Onmisbaar"
        , "UU:MM:SS.SSS\n- UU zijn de uren\n- MM zijn de minuten\n- SS zijn de seconden\n- SSS zijn de milliseconden"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00299'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00222"
        , "2023/1"
        , "28/02/2023"
        , "REFERENTIENUMMER"
        , "ReferenceNbr"
        , "Referentie"
        , "Het referentienummer."
        , "In dit bericht is de toegelaten lengte voor deze zone 20 tekens."
        , ""
        , "Alfanumeriek"
        , "64"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00222'
                          AND Version = '2023/1'
);



INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00011"
        , "2023/1"
        , "28/02/2023"
        , "RSZ-NUMMER"
        , "NOSSRegistrationNbr"
        , "Detail van de Beware-notificatie"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ.\nHet gaat om een definitief RSZ-nummer."
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers. Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden."
        , ""
        , "Numeriek"
        , "9"
        , "Onmisbaar"
        , "0 of NNNNNNNCC --NNNNNNN is het nummer -- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00011'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00110"
        , "2023/1"
        , "28/02/2023"
        , "STATUS VAN HET ATTEST"
        , "AttestationStatus"
        , "Formulier"
        , ""
        , "0 = Origineel\n1 = Wijziging\n2 = Duplicaat\n3 = Annulatie\n4 = Herziening\n5 = Herinnering\n6 = Afsluiting\n7 = Wijziging van papieren origineel\n8 = Kopie\nDe enige mogelijke waarde in dit bericht is '0'."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00110'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01033"
        , "2023/1"
        , "28/02/2023"
        , "TOTAAL AANTAL NOTIFICATIES"
        , "TotalNbrNotifications"
        , "Detail van de Beware-controlelijst"
        , "Totaal aantal Beware-notificaties dat ontvangen werd voor een bepaalde datum."
        , "[0,999999]"
        , ""
        , "Numeriek"
        , "6"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01033'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00221"
        , "2023/1"
        , "28/02/2023"
        , "TYPE VAN DE REFERENTIE"
        , "ReferenceType"
        , "Referentie"
        , "Duidt aan naar waar de referentie (00222 Referentienummer) verwijst: naar deze aangifte, naar een aangifte die verwant is met deze aangifte of naar een verzameling aangiften (= een dossier) waar deze aangifte toe behoort, op deze aanvraag, op dit formulier"
        , "0 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat niet dezelfde identificatie heeft (zie bijlagen 11/302), dat verband houdt met het huidige formulier\n1 = de referentie verwijst naar dit formulier\n2 = de referentie is een dossiernummer en verwijst naar het dossier (= verzameling van aangiften) waartoe deze aangifte behoort of waartoe dit formulier behoort\n3 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat dezelfde identificatie heeft (zie bijlagen 11/302) en dat verband houdt met dit formulier, bijvoorbeeld: de referentie heeft betrekking op de aangifte die geannuleerd moet worden door deze aangifte, of op de aangifte die vervangen moet worden door deze aangifte, of op de aangifte die gewijzigd moet worden, of op de aangifte die aan de oorsprong ligt van dit formulier...\n4 = de referentie verwijst naar een aangifte in een ander scenario die verwant is met deze aangifte\n5 = de referentie verwijst naar een aanvraag\n6 = de referentie verwijst naar een geweigerde aangifte\n7 = de referentie verwijst naar de werkgever die in deze aangifte wordt vermeld\n8 = de referentie verwijst naar de werknemer die in deze aangifte wordt vermeld\n9 = de referentie is een gestructureerde mededeling die moet worden gebruikt in het kader van een betaling en verwijst naar dit formulier."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00221'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00297"
        , "2023/1"
        , "28/02/2023"
        , "TYPE VAN HET FORMULIER"
        , "TypeForm"
        , "Formulier"
        , "Het type wijst de aard van het elektronisch formulier aan."
        , "RE = REQUEST - het formulier vraagt inlichtingen\nPA = PROVISIONAL ANSWER - het formulier is een tijdelijk antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nFA = FINAL ANSWER - het formulier is een definitief antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nLA = LIMITED ANSWER - het formulier is een beperkt antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nSU = SUBMISSION - het formulier deelt inlichtingen mee\nDe enige mogelijke waarde in dit bericht is 'SU'."
        , ""
        , "Alfanumeriek"
        , "2"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00297'
                          AND Version = '2023/1'
);
