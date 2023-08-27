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
SELECT "00218"
        , "2023/2"
        , "25/05/2023"
        , "DATUM VAN CREATIE VAN HET FORMULIER"
        , "FormCreationDate"
        , "Formulier"
        , "Datum waarop het formulier gecreëerd is."
        , "JJJJ is een element van [lopend jaar -1 ; lopend jaar] ; De datum mag zich niet in de toekomst bevinden."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar "
        , "JJJJ-MM-DD;\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00218'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00074"
        , "2023/2"
        , "25/05/2023"
        , "DATUM WAAROP DE REFERTEPERIODE BEGINT"
        , "RefStartingDate"
        , "Referteperiode"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien de 'Datum waarop de referteperiode eindigt' (00075) niet aanwezig is."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00074'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00075"
        , "2023/2"
        , "25/05/2023"
        , "DATUM WAAROP DE REFERTEPERIODE EINDIGT"
        , "RefEndingDate"
        , "Referteperiode"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien de 'Datum waarop de referteperiode begint' (00074) niet aanwezig is."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00075'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00298"
        , "2023/2"
        , "25/05/2023"
        , "HERKOMST VAN DE REFERENTIE"
        , "ReferenceOrigin"
        , "Referentie"
        , "Waarde die de authentieke bron van een referentienummer aanduidt."
        , "1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal secretariaat, een softwareontwikkelaar, ...)\n2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een antwoord op eenduidige wijze identificeert\n3 = het referentienummer is toegekend door een sector van de sociale zekerheid\n4 = het referentienummer is toegekend door de dienst ePost\n5 = het referentienummer is toegekend door de KSZ\n6 = het referentienummer is toegekend door het archiveringssysteem (DOC-ID)\n7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend (DSP-ID)\nDe enige waarde in dit bericht is '1'."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00298'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00296"
        , "2023/2"
        , "25/05/2023"
        , "IDENTIFICATIE VAN HET FORMULIER"
        , "Identification"
        , "Formulier"
        , "Zone die de inhoud van een formulier beschrijft."
        , "Zie bijlage 11 - Identificatie van het formulier. De enige waarde in dit bericht is 'PFREQ'."
        , ""
        , "Alfanumeriek"
        , "7"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00296'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00295"
        , "2023/2"
        , "25/05/2023"
        , "LOKALISATIE VAN EEN ELEMENT IN DE BOOMSTRUCTUUR"
        , "Location"
        , "Gegevens van de optie"
        , "Informatie die toelaat om een element te lokaliseren in de boomstructuur."
        , "Gebruikt met de waarde 'QuotaFeatures', met deze zone kan u aanduiden of u al dan niet de karakteristieken van het contingent van elke periode wil recupereren (zie blok 'QuotaFeatures' (90432) in het glossarium PersonnelFileConsultationAnswer). In dit geval moet de zone 'Waarde' (00236) niet ingevuld worden."
        , ""
        , "Alfanumeriek"
        , "200"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00295'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/2"
        , "25/05/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Identificatie van de werkgever"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.\nIn het geval van een aanvraag voor een werkgever (uitgezonderd provinciale en plaatselijke besturen), heeft het 'RSZ-nummer' (00011) voorrang op het ondernemingsnummer."
        , "Getal van 10 cijfers waarvan :\nde posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;\nde posities 9 en 10 overeenkomen met een controlegetal.\nAls het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden."
        , ""
        , "Numeriek"
        , "10"
        , "Verplicht indien het RSZ-nummer of PPL nummer niet aanwezig zijn."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00109"
        , "2023/2"
        , "25/05/2023"
        , "PPL NUMMER"
        , "NOSSLPARegistrationNbr"
        , "Identificatie van de werkgever"
        , "Elke lokale of provinciale overheid die personeel in dienst heeft, moet ingeschreven zijn bij de RSZ."
        , "Geheel getal en element van [00000197;99999926]. Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het PPL nummer op de waarde nul gezet worden."
        , ""
        , "Numeriek"
        , "8"
        , "Verplicht indien de werkgever een PPL nummer bezit en indien het 'Ondernemingsnummer' (00014) niet aanwezig is."
        , "0 of NNNNNNCC\n- NNNNNN is het nummer\n- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00109'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00299"
        , "2023/2"
        , "25/05/2023"
        , "PRECIES UUR VAN CREATIE VAN HET FORMULIER"
        , "FormCreationHour"
        , "Formulier"
        , "Tijdstip, uitgedrukt in uren, minuten, seconden en milliseconden."
        , "UU is een element van [00;23]\nMM is een element van [00;59]\nSS is een element van [00;59]\nSSS is een element van [000;999]"
        , ""
        , "Alfanumeriek"
        , "12"
        , "Onmisbaar "
        , "UU:MM:SS.SSS\n- UU zijn de uren\n- MM zijn de minuten\n- SS zijn de seconden\n- SSS zijn de milliseconden"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00299'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00222"
        , "2023/2"
        , "25/05/2023"
        , "REFERENTIENUMMER"
        , "ReferenceNbr"
        , "Referentie"
        , "Het referentienummer."
        , "In dit bericht is de toegelaten lengte voor deze zone 20 tekens."
        , ""
        , "Alfanumeriek"
        , "64"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00222'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00011"
        , "2023/2"
        , "25/05/2023"
        , "RSZ-NUMMER"
        , "NOSSRegistrationNbr"
        , "Identificatie van de werkgever"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ.\n Het gaat om een definitief RSZ-nummer.\nIndien het 'Ondernemingsnummer' (00014) ook aanwezig is, dan heeft het RSZ-nummer voorrang."
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers.\nAls het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden."
        , ""
        , "Numeriek"
        , "9"
        , "Verplicht indien de werkgever een definitief RSZ-nummer bezit en indien het 'Ondernemingsnummer' (00014) niet aanwezig is."
        , "0 of NNNNNNNCC\n- NNNNNNN is het nummer\n- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00011'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00110"
        , "2023/2"
        , "25/05/2023"
        , "STATUS VAN HET ATTEST"
        , "AttestationStatus"
        , "Formulier"
        , ""
        , "0 = Origineel\n1 = Wijziging\n2 = Duplicaat\n3 = Annulatie\n4 = Herziening\n5 = Herinnering\n6 = Afsluiting\n7 = Wijziging van papieren origineel\n8 = Kopie\nEnkel de waarde '0' is toegelaten."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00110'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00221"
        , "2023/2"
        , "25/05/2023"
        , "TYPE VAN DE REFERENTIE"
        , "ReferenceType"
        , "Referentie"
        , "Duidt aan naar waar de referentie (00222 Referentienummer) verwijst: naar deze aangifte, naar een aangifte die verwant is met deze aangifte of naar een verzameling aangiften (= een dossier) waar deze aangifte toe behoort, op deze aanvraag, op dit formulier."
        , "0 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat niet dezelfde identificatie heeft (zie bijlagen 11/302), dat verband houdt met het huidige formulier\n1 = de referentie verwijst naar dit formulier\n2 = de referentie is een dossiernummer en verwijst naar het dossier (= verzameling van aangiften) waartoe deze aangifte behoort of waartoe dit formulier behoort\n3 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat dezelfde identificatie heeft (zie bijlagen 11/302) en dat verband houdt met dit formulier, bijvoorbeeld: de referentie heeft betrekking op de aangifte die geannuleerd moet worden door deze aangifte, of op de aangifte die vervangen moet worden door deze aangifte, of op de aangifte die gewijzigd moet worden, of op de aangifte die aan de oorsprong ligt van dit formulier...\n"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00221'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00297"
        , "2023/2"
        , "25/05/2023"
        , "TYPE VAN HET FORMULIER"
        , "TypeForm"
        , "Formulier"
        , "Het type wijst de aard van het elektronisch formulier aan."
        , "RE = REQUEST - het formulier vraagt inlichtingen\nPA = PROVISIONAL ANSWER - het formulier is een tijdelijk antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nFA = FINAL ANSWER - het formulier is een definitief antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nLA = LIMITED ANSWER - het formulier is een beperkt antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nSU = SUBMISSION - het formulier deelt inlichtingen mee\n De enige waarde in dit bericht is 'RE'."
        , ""
        , "Alfanumeriek"
        , "2"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00297'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00948"
        , "2023/2"
        , "25/05/2023"
        , "VOORLOPIG RSZ-NUMMER"
        , "ProvisionalNSSONbr"
        , "Identificatie van de werkgever"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ.\nHet gaat om een voorlopig RSZ-nummer dat aan de nieuwe werkgever toegekend is.\nDit voorlopig nummer mag niet meer gebruikt worden zodra de RSZ het definitieve nummer heeft meegedeeld.Deze zone wordt niet gebruikt voor in de aanvraag tot massale consultatie."
        , "Geheel getal en element van [5000000120;5999999989]"
        , ""
        , "Numeriek"
        , "10"
        , "Facultatief"
        , "0 of NNNNNNNNCC\n- NNNNNNNN is het nummer\n- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00948'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00236"
        , "2023/2"
        , "25/05/2023"
        , "WAARDE"
        , "Value"
        , "Gegevens van de optie"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "999999999999999"
        , "Verboden"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00236'
                          AND Version = '2023/2'
);
