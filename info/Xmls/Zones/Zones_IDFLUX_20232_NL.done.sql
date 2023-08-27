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
SELECT "00813"
        , "2023/2"
        , "25/05/2023"
        , "DATUM INGANGSDATUM"
        , "EffectiveStartingDate"
        , "Identificatie-informatie IDFLUX"
        , "Datum vanaf wanneer de in het bericht opgenomen informatie geldig is."
        , "De datum mag zich niet in de toekomst bevinden."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar"
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00813'
                          AND Version = '2023/2'
);


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
        , "Onmisbaar"
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00218'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00028"
        , "2023/2"
        , "25/05/2023"
        , "DATUM WAAROP DE WERKNEMER GEBOREN IS"
        , "WorkerBirthdate"
        , "Geldige situatie"
        , "Geboortedatum van de natuurlijke persoon."
        , " JJJJ is een element van [jaar van de aangifte -120; jaar van de aangifte]."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar in de geldige situatie. In de verouderde versie verplicht als de datum waarop de werknemer geboren is gewijzigd is."
        , "JJJJ-MM-DD (geldige datum) -- JJJJ-00-00"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00028'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00028"
        , "2023/2"
        , "25/05/2023"
        , "DATUM WAAROP DE WERKNEMER GEBOREN IS"
        , "WorkerBirthdate"
        , "Verouderde situatie"
        , "Geboortedatum van de natuurlijke persoon."
        , " JJJJ is een element van [jaar van de aangifte -120; jaar van de aangifte]."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar in de geldige situatie. In de verouderde versie verplicht als de datum waarop de werknemer geboren is gewijzigd is."
        , "JJJJ-MM-DD (geldige datum)
JJJJ-00-00"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00028'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00029"
        , "2023/2"
        , "25/05/2023"
        , "GESLACHT VAN DE WERKNEMER"
        , "WorkerSex"
        , "Geldige situatie"
        , "Geslacht van een natuurlijk persoon."
        , "1 = man; 2 = vrouw"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar in de geldige situatie. In de verouderde versie verplicht als het geslacht van de werknemer gewijzigd is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00029'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00029"
        , "2023/2"
        , "25/05/2023"
        , "GESLACHT VAN DE WERKNEMER"
        , "WorkerSex"
        , "Verouderde situatie"
        , "Geslacht van een natuurlijk persoon."
        , "1 = man; 2 = vrouw"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar in de geldige situatie. In de verouderde versie verplicht als het geslacht van de werknemer gewijzigd is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00029'
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
        , "1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal secretariaat, een softwareontwikkelaar, ...)\n2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een antwoord op eenduidige wijze identificeert\n3 = het referentienummer is toegekend door een sector van de sociale zekerheid\n4 = het referentienummer is toegekend door de dienst ePost\n5 = het referentienummer is toegekend door de KSZ\n6 = het referentienummer is toegekend door het archiveringssysteem (DOC-ID)\n7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend (DSP-ID)\nIn IDFLUX is '2' de toegelaten waarde"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
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
        , "Zie bijlage 11 - Identificatie van het formulier. Deze zone heeft de waarde IDFLUX."
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
SELECT "00024"
        , "2023/2"
        , "25/05/2023"
        , "IDENTIFICATIENUMMER BIJ DE SOCIALE ZEKERHEID - INSZ"
        , "INSS"
        , "Geldige situatie"
        , "Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke personen."
        , ""
        , ""
        , "Numeriek"
        , "11"
        , "Onmisbaar in de geldige situatie.  In de verouderde versie verplicht als het identificatienummer bij de sociale zekerheid - INSZ gewijzigd is."
        , "0 of NNNNNNNNNCC\n- NNNNNNNNN is het nummer\n- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00024'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00024"
        , "2023/2"
        , "25/05/2023"
        , "IDENTIFICATIENUMMER BIJ DE SOCIALE ZEKERHEID - INSZ"
        , "INSS"
        , "Verouderde situatie"
        , "Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke personen."
        , ""
        , ""
        , "Numeriek"
        , "11"
        , "Onmisbaar in de geldige situatie.  In de verouderde versie verplicht als het identificatienummer bij de sociale zekerheid - INSZ gewijzigd is."
        , "0 of NNNNNNNNNCC\n- NNNNNNNNN is het nummer\n- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00024'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00025"
        , "2023/2"
        , "25/05/2023"
        , "NAAM VAN DE WERKNEMER"
        , "WorkerName"
        , "Geldige situatie"
        , "Familienaam van een natuurlijk persoon.\nMen moet de naam vermelden die op het paspoort of de identiteitskaart staat.\nVoor vrouwen van Belgische nationaliteit gaat het om de meisjesnaam."
        , ""
        , ""
        , "Alfanumeriek"
        , "48"
        , "Onmisbaar in de geldige situatie. In de verouderde versie verplicht als de naam van de werknemer gewijzigd is"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00025'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00025"
        , "2023/2"
        , "25/05/2023"
        , "NAAM VAN DE WERKNEMER"
        , "WorkerName"
        , "Verouderde situatie"
        , "Familienaam van een natuurlijk persoon.\nMen moet de naam vermelden die op het paspoort of de identiteitskaart staat.\nVoor vrouwen van Belgische nationaliteit gaat het om de meisjesnaam."
        , ""
        , ""
        , "Alfanumeriek"
        , "48"
        , "Onmisbaar in de geldige situatie. In de verouderde versie verplicht als de naam van de werknemer gewijzigd is"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00025'
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
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon."
        , "Getal van 10 cijfers waarvan :\nde posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;\nde posities 9 en 10 overeenkomen met een controlegetal.\nAls het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden."
        , ""
        , "Numeriek"
        , "10"
        , "Onmisbaar"
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
        , " Elke lokale of provinciale overheid die personeel in dienst heeft, moet ingeschreven zijn bij de RSZ."
        , "Geheel getal en element van [00000197;99999926]. Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het PPL nummer op de waarde nul gezet worden.In IDFLUX staat het PPL nummer nooit op nul."
        , ""
        , "Numeriek"
        , "8"
        , "Verplicht indien IDFLUX een een provinciaal of plaatselijk bestuur betreft."
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
        , "Onmisbaar"
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
        , "Geldige situatie"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ. Het gaat om een definitief RSZ-nummer."
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers.\nAls het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden.\nIn IDFLUX zal het RSZ-nummer nooit op nul worden gezet."
        , ""
        , "Numeriek"
        , "9"
        , "Verplicht indien IDFLUX een werkgever anders dan een provinciaal of plaatselijk bestuur betreft"
        , "0 of NNNNNNNCC\n- NNNNNNN is het nummer\n- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00011'
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
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ. Het gaat om een definitief RSZ-nummer."
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers.\nAls het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden.\nIn IDFLUX zal het RSZ-nummer nooit op nul worden gezet."
        , ""
        , "Numeriek"
        , "9"
        , "Verplicht indien IDFLUX een werkgever anders dan een provinciaal of plaatselijk bestuur betreft "
        , "0 of NNNNNNNCC\n- NNNNNNN is het nummer\n- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00011'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00011"
        , "2023/2"
        , "25/05/2023"
        , "RSZ-NUMMER"
        , "NOSSRegistrationNbr"
        , "Verouderde situatie"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ. Het gaat om een definitief RSZ-nummer."
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers.\nAls het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden.\nIn IDFLUX zal het RSZ-nummer nooit op nul worden gezet."
        , ""
        , "Numeriek"
        , "9"
        , "Verplicht indien IDFLUX een werkgever anders dan een provinciaal of plaatselijk bestuur betreft "
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
        , "0 = Origineel\n1 = Wijziging\n2 = Duplicaat\n3 = Annulatie\n4 = Herziening\n5 = Herinnering\n6 = Afsluiting\n7 = Wijziging van papieren origineel\n8 = KopieIn IDFLUX de toegelaten waarden zijn '0', '2' of '3'."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00110'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00536"
        , "2023/2"
        , "25/05/2023"
        , "STAVINGSCODE"
        , "JustificationCode"
        , "Identificatie-informatie IDFLUX"
        , "Beschrijft, onder de vorm van een code, de staving van de wijziging doorgevoerd door de Sociale zekerheid."
        , "Zie bijlage 40 - Stavingscode.Voor IDFLUX liggen de toegelaten waarden tussen 90 en 93"
        , ""
        , "Numeriek"
        , "2"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00536'
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
        , "0 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat niet dezelfde identificatie heeft (zie bijlagen 11/302), dat verband houdt met het huidige formulier\n1 = de referentie verwijst naar dit formulier\n2 = de referentie is een dossiernummer en verwijst naar het dossier (= verzameling van aangiften) waartoe deze aangifte behoort of waartoe dit formulier behoort\n3 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat dezelfde identificatie heeft (zie bijlagen 11/302) en dat verband houdt met dit formulier, bijvoorbeeld: de referentie heeft betrekking op de aangifte die geannuleerd moet worden door deze aangifte, of op de aangifte die vervangen moet worden door deze aangifte, of op de aangifte die gewijzigd moet worden, of op de aangifte die aan de oorsprong ligt van dit formulier...\n4 = de referentie verwijst naar een aangifte in een ander scenario die verwant is met deze aangifte\n5 = de referentie verwijst naar een aanvraag\n6 = de referentie verwijst naar een geweigerde aangifte\n7 = de referentie verwijst naar de werkgever die in deze aangifte wordt vermeld\n8 = de referentie verwijst naar de werknemer die in deze aangifte wordt vermeld\n9 = de referentie is een gestructureerde mededeling die moet worden gebruikt in het kader van een betaling en verwijst naar dit formulierIn IDFLUX is '1' de toegelaten waarde"
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
        , "RE = REQUEST - het formulier vraagt inlichtingen\nPA = PROVISIONAL ANSWER - het formulier is een tijdelijk antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nFA = FINAL ANSWER - het formulier is een definitief antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nLA = LIMITED ANSWER - het formulier is een beperkt antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen\nSU = SUBMISSION - het formulier deelt inlichtingen mee\nIn IDFLUX is 'SU' de toegelaten waarde"
        , ""
        , "Alfanumeriek"
        , "2"
        , "Onmisbaar"
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
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ.\nHet gaat om een voorlopig RSZ-nummer dat aan de nieuwe werkgever toegekend is.\nDit voorlopig nummer mag niet meer gebruikt worden zodra de RSZ het definitieve nummer heeft meegedeeld.Deze zone wordt  in dit bericht nooit gebruikt."
        , "Geheel getal en element van [5000000120;5999999989]"
        , ""
        , "Numeriek"
        , "10"
        , "Facultatief "
        , "0 of NNNNNNNNCC\n- NNNNNNNN is het nummer\n- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00948'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00026"
        , "2023/2"
        , "25/05/2023"
        , "VOORNAAM VAN DE WERKNEMER"
        , "WorkerFirstName"
        , "Geldige situatie"
        , "Eerste voornaam van een natuurlijk persoon."
        , ""
        , ""
        , "Alfanumeriek"
        , "24"
        , "Onmisbaar in de geldige situatie. In de verouderde versie verplicht als de voornaam gewijzigd is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00026'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00026"
        , "2023/2"
        , "25/05/2023"
        , "VOORNAAM VAN DE WERKNEMER"
        , "WorkerFirstName"
        , "Verouderde situatie"
        , "Eerste voornaam van een natuurlijk persoon."
        , ""
        , ""
        , "Alfanumeriek"
        , "24"
        , "Onmisbaar in de geldige situatie. In de verouderde versie verplicht als de voornaam gewijzigd is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00026'
                          AND Version = '2023/2'
);
