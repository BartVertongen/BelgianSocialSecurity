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
SELECT "01202"
        , "2023/1"
        , "28/02/2023"
        , "AANDUIDING NATUURLIJKE PERSOON"
        , "IsNaturalPerson"
        , "Identificatie van de opdrachtgever"
        , "Zone waarin u kunt aangeven dat het om een natuurlijk persoon gaat.Geeft aan, bij een aangifte van werken, dat de opdrachtgever een natuurlijk persoon is die privédoeleinden nastreeft."
        , "0 = Is geen natuurlijk persoon; 1 = Is een natuurlijk persoon"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01202'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00925"
        , "2023/1"
        , "28/02/2023"
        , "AANVULLENDE ADRESGEGEVENS"
        , "AddressDetails"
        , "Project dat de werken omvat"
        , "Deze zone laat toe de plaats via een korte beschrijving te bepalen. Deze beschrijving is verplicht indien het adres niet precies vermeld kan worden via een volledige adresplaat. Ze moet duidelijk vermelden hoe men tot de plaats geraakt."
        , ""
        , ""
        , "Alfanumeriek"
        , "1000"
        , "Verplicht indien de straat van de plaats (zone 00517) of het nummer van het adres van de plaats (zone 00518) niet aanwezig zijn, of indien de notie mobiliteit van het project dat de werken omvat (zone 00923) gelijk is aan '1'. Zoniet, facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00925'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01083"
        , "2023/1"
        , "28/02/2023"
        , "AARD VAN DE GEVAARLIJKE WERKEN"
        , "DangerousConstrWorkNature"
        , "Informatie over de activiteit van de onderaannemer"
        , "Vermeldt de aard van de uit te voeren gevaarlijke werken.Deze zone is enkel van toepassing als de zone WorksGlobalProjectSector (01093) gelijk is aan 1 (Werken in onroerende staat)."
        , "0 = Geen asbest; 1 = Asbest; 9 = Andere gevaarlijke werken zoals vermeld in het Koninklijk Besluit van 25 januari 2001 betreffende de tijdelijke of mobiele bouwplaatsen"
        , ""
        , "Numeriek"
        , "1"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01083'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01083"
        , "2023/1"
        , "28/02/2023"
        , "AARD VAN DE GEVAARLIJKE WERKEN"
        , "DangerousConstrWorkNature"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Vermeldt de aard van de uit te voeren gevaarlijke werken.Deze zone is enkel van toepassing als de zone WorksGlobalProjectSector (01093) gelijk is aan 1 (Werken in onroerende staat)."
        , "0 = Geen asbest; 1 = Asbest; 9 = Andere gevaarlijke werken zoals vermeld in het Koninklijk Besluit van 25 januari 2001 betreffende de tijdelijke of mobiele bouwplaatsen"
        , ""
        , "Numeriek"
        , "1"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01083'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00920"
        , "2023/1"
        , "28/02/2023"
        , "AARD VAN HET PROJECT DAT DE WERKEN OMVAT"
        , "WorksGlobalProjectType"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Vermeldt de aard van de uitgevoerde werken/ diensten."
        , "1 = Bouw\n2 = Inrichten\n3 = Afbraak\n4 = Verbouwing\n5 = Herstelling\n6 = Afwerking\n7 = Onderhoud\n8 = Reiniging\n99 = Andere"
        , ""
        , "Numeriek"
        , "2"
        , "Verplicht indien de zone 'WorksGlobalProjectSector' 01093 = 1 (Werken in onroerende staat) is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00920'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00920"
        , "2023/1"
        , "28/02/2023"
        , "AARD VAN HET PROJECT DAT DE WERKEN OMVAT"
        , "WorksGlobalProjectType"
        , "Project dat de werken omvat"
        , "Vermeldt de aard van de uitgevoerde werken/ diensten."
        , "1 = Bouw\n2 = Inrichten\n3 = Afbraak\n4 = Verbouwing\n5 = Herstelling\n6 = Afwerking\n7 = Onderhoud\n8 = Reiniging\n99 = Andere"
        , ""
        , "Numeriek"
        , "2"
        , "Verplicht indien de zone 'WorksGlobalProjectSector' 01093 = 1 (Werken in onroerende staat) is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00920'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00934"
        , "2023/1"
        , "28/02/2023"
        , "ACTIVITEIT VAN DE ONDERAANNEMER"
        , "SubcontractorActivity"
        , "Informatie over de activiteit van de onderaannemer"
        , "Duidt de activiteiten aan die uitgevoerd worden door een onderaannemer voor precieze werkzaamheden/ diensten."
        , "Cf. specifieke bijlage AVWDDTs01: lijst van activiteiten"
        , ""
        , "Numeriek"
        , "2"
        , "Verplicht indien de zone 'WorksGlobalProjectSector' 01093 = 1 (Werken in onroerende staat) is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00934'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00929"
        , "2023/1"
        , "28/02/2023"
        , "BEGRIP 'CONTRACT IN REGIE'"
        , "CostPlusContractNotion"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Zone waar men kan vermelden of de aangegeven contracten met betrekking tot de werken/ diensten contracten in regie zijn of niet."
        , "0 = geen contracten in regie; 1 = contracten in regie"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00929'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00923"
        , "2023/1"
        , "28/02/2023"
        , "BEGRIP 'MOBILITEIT' VAN HET PROJECT DAT DE WERKEN OMVAT"
        , "WorksGlobalProjectMobilityNotion"
        , "Project dat de werken omvat"
        , "Een project waaraan het begrip Mobiliteit is toegevoegd, is een project waarvan een deel of de totaliteit van de werken/diensten niet uitgevoerd is op een vaste geografische plek tijdens de hele duur van dit project.\nVoorbeeld van een tijdelijke bouwplaats: plaatsing van elektriciteitspalen langs een weg, bescherming van een pantserwagen"
        , "0 = geen tijdelijke bouwplaats; 1 = tijdelijke bouwplaats"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00923'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00776"
        , "2023/1"
        , "28/02/2023"
        , "BENAMING"
        , "Denomination"
        , "Identificatie van de onderaannemer"
        , "In het FB SubcontractorEmployerId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan. Moet identiek zijn aan de benaming van deze rechtstreekse werkgever.\nHet kan ofwel gaan om de aangever, ofwel om een tijdelijke handelsvennootschap, ofwel om een onderaannemer.\nIn het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , ""
        , ""
        , "Alfanumeriek"
        , "96"
        , "Verplicht indien de benaming betrekking heeft op een tijdelijke handelsvennootschap (FB 90382), een opdrachtgever (FB 90384), een onderaannemer (FB 90388) of een andere actor (FB 90477) en dat het ondernemingsnummer (00014) van dit andere actor niet aanwezig is.\nVerplicht indien het nummer van de rechtstreekse werkgever van de onderaannemer (BF 90573) niet aanwezig is.\nFacultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00776'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00776"
        , "2023/1"
        , "28/02/2023"
        , "BENAMING"
        , "Denomination"
        , "Identificatie van de opdrachtgever"
        , "In het FB SubcontractorEmployerId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan.\nMoet identiek zijn aan de benaming van deze rechtstreekse werkgever. Het kan ofwel gaan om de aangever, ofwel om een tijdelijke handelsvennootschap, ofwel om een onderaannemer.\nIn het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , ""
        , ""
        , "Alfanumeriek"
        , "96"
        , "Verplicht indien de benaming betrekking heeft op een tijdelijke handelsvennootschap (FB 90382), een opdrachtgever (FB 90384), een onderaannemer (FB 90388) of een andere actor (FB 90477) en dat het ondernemingsnummer (00014) van dit andere actor niet aanwezig is.\nVerplicht indien het nummer van de rechtstreekse werkgever van de onderaannemer (BF 90573) niet aanwezig is.\nFacultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00776'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00776"
        , "2023/1"
        , "28/02/2023"
        , "BENAMING"
        , "Denomination"
        , "Identificatie van de tijdelijke handelsvennootschap"
        , "In het FB SubcontractorEmployerId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan.\nMoet identiek zijn aan de benaming van deze rechtstreekse werkgever.\nHet kan ofwel gaan om de aangever, ofwel om een tijdelijke handelsvennootschap, ofwel om een onderaannemer.\nIn het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , ""
        , ""
        , "Alfanumeriek"
        , "96"
        , "Verplicht indien de benaming betrekking heeft op een tijdelijke handelsvennootschap (FB 90382), een opdrachtgever (FB 90384), een onderaannemer (FB 90388) of een andere actor (FB 90477) en dat het ondernemingsnummer (00014) van dit andere actor niet aanwezig is.\nVerplicht indien het nummer van de rechtstreekse werkgever van de onderaannemer (BF 90573) niet aanwezig is.\nFacultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00776'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00776"
        , "2023/1"
        , "28/02/2023"
        , "BENAMING"
        , "Denomination"
        , "Werkgevende onderneming"
        , "In het FB SubcontractorEmployerId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan. Moet identiek zijn aan de benaming van deze rechtstreekse werkgever.\nHet kan ofwel gaan om de aangever, ofwel om een tijdelijke handelsvennootschap, ofwel om een onderaannemer.\nIn het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , ""
        , ""
        , "Alfanumeriek"
        , "96"
        , "Verplicht indien de benaming betrekking heeft op een tijdelijke handelsvennootschap (FB 90382), een opdrachtgever (FB 90384), een onderaannemer (FB 90388) of een andere actor (FB 90477) en dat het ondernemingsnummer (00014) van dit andere actor niet aanwezig is.\nVerplicht indien het nummer van de rechtstreekse werkgever van de onderaannemer (BF 90573) niet aanwezig is.\nFacultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00776'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01016"
        , "2023/1"
        , "28/02/2023"
        , "BESTEMMING VAN HET BOUWWERK"
        , "BuildingUsage"
        , "Project dat de werken omvat"
        , "Zone die toelaat de bestemming van het bouwwerk aan te duiden."
        , "Cf. specifieke bijlage AVWDDTs02 : lijst van bestemmingen van het bouwwerk"
        , ""
        , "Numeriek"
        , "2"
        , "Verplicht indien de zone 'WorksGlobalProjectSector' 01093 = 1 (Werken in onroerende staat) is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01016'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00519"
        , "2023/1"
        , "28/02/2023"
        , "BRIEVENBUS"
        , "PostBox"
        , "Adres"
        , "Nummer van een brievenbus."
        , ""
        , ""
        , "Alfanumeriek"
        , "4"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00519'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01185"
        , "2023/1"
        , "28/02/2023"
        , "BTW-NUMMER"
        , "VATNbr"
        , "Identificatie van de onderaannemer"
        , "BTW-nummer dat op eenduidige wijze een onderneming identificeert.\nNummer dat op eenduidige wijze ondernemingen binnen de Europese Unie (buiten België) identificeert, ongeacht of het gaat om een onderaannemer of buitenlandse opdrachtgever."
        , "De posities 1 en 2 komen overeen met de prefix van het vestigingsland van de onderneming.\nDe posities 3 tot 30 bestaan uit cijfers en/of letters.\nMerk op dat de structuur van een intracommunautair BTW-nummer anders is voor elke EU-lidstaat."
        , ""
        , "Alfanumeriek"
        , "30"
        , "Verplicht indien het nummer betrekking heeft op een opdrachtgever\n- Onderneming (FB 90384), of een onderaannemer (FB 90388), of een werkgevende onderneming (FB 90573) waarvan het land van vestiging lid is van de EU en indien de benaming van deze opdrachtgever, onderaannemer en werkgevende onderneming niet aanwezig zijn.\nVerplicht indien het nummer van de rechtstreekse werkgever van de onderaannemer (FB 90573) bekend is.\nFacultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01185'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01185"
        , "2023/1"
        , "28/02/2023"
        , "BTW-NUMMER"
        , "VATNbr"
        , "Identificatie van de opdrachtgever"
        , "BTW-nummer dat op eenduidige wijze een onderneming identificeert.\nNummer dat op eenduidige wijze ondernemingen binnen de Europese Unie (buiten België) identificeert, ongeacht of het gaat om een onderaannemer of buitenlandse opdrachtgever."
        , "De posities 1 en 2 komen overeen met de prefix van het vestigingsland van de onderneming.\nDe posities 3 tot 30 bestaan uit cijfers en/of letters.\nMerk op dat de structuur van een intracommunautair BTW-nummer anders is voor elke EU-lidstaat."
        , ""
        , "Alfanumeriek"
        , "30"
        , "Verplicht indien het nummer betrekking heeft op een opdrachtgever - Onderneming (FB 90384), of een onderaannemer (FB 90388), of een werkgevende onderneming (FB 90573) waarvan het land van vestiging lid is van de EU en indien de benaming van deze opdrachtgever, onderaannemer en werkgevende onderneming niet aanwezig zijn.\nVerplicht indien het nummer van de rechtstreekse werkgever van de onderaannemer (FB 90573) bekend is.\nFacultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01185'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01186"
        , "2023/1"
        , "28/02/2023"
        , "BUITENLANDS ONDERNEMINGSNUMMER"
        , "ForeignCompanyID"
        , "Identificatie van de onderaannemer"
        , "Unique nummer dat de ondernemingen buiten de EU identificeert.\nHet gaat ofwel om een onderaannemer, ofwel om een buitenlandse opdrachtgever."
        , ""
        , ""
        , "Alfanumeriek"
        , "256"
        , "Verplicht indien het nummer betrekking heeft op een opdrachtgever (FB 90384), of een onderaannemer (FB 90388), of een werkgevende onderneming (FB 90573) waarvan het land van vestiging geen lid is van de EU.\nVerplicht indien het nummer van de rechtstreekse werkgever van de onderaannemer (FB 90573) bekend is.\nFacultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01186'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00887"
        , "2023/1"
        , "28/02/2023"
        , "COMMENTAAR"
        , "Comment"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Commentaarzone"
        , ""
        , ""
        , "Alfanumeriek"
        , "200"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00887'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00932"
        , "2023/1"
        , "28/02/2023"
        , "DATUM BEGIN VAN DE TUSSENKOMST"
        , "InterventionStartDate"
        , "Informatie over de activiteit van de onderaannemer"
        , "Begindatum van de interventie van de onderaannemer op de site."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Facultatief "
        , "JJJJ-MM-DD ; -- JJJJ is het jaar -- MM is de maand -- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00932'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00927"
        , "2023/1"
        , "28/02/2023"
        , "DATUM BEGIN VAN HET CONTRACT MET BETREKKING TOT DE WERKEN"
        , "WorksContractStartDate"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Datum waarop de werken/diensten, uitgevoerd door de aannemer die de aangifte doet, effectief op de site beginnen."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar "
        , "JJJJ-MM-DD; JJJJ is het jaar -- MM is de maand -- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00927'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00933"
        , "2023/1"
        , "28/02/2023"
        , "DATUM EINDE VAN DE TUSSENKOMST"
        , "InterventionEndDate"
        , "Informatie over de activiteit van de onderaannemer"
        , "Einddatum van de interventie van de onderaannemer op de site."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Facultatief"
        , "JJJJ-MM-DD; JJJJ is het jaar -- MM is de maand -- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00933'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00928"
        , "2023/1"
        , "28/02/2023"
        , "DATUM EINDE VAN HET CONTRACT MET BETREKKING TOT DE WERKEN"
        , "WorksContractEndDate"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Voor werken met een specifiek einddoel moet de einddatum van de werken/diensten overeenstemmen met de voorlopige ontvangstdatum of met de werkelijke einddatum.
Voor werken met een doorlopend einddoel kan de einddatum 5 jaar in de toekomst liggen. Deze datum dient beheerd en aangepast te worden aan de vervaldatum."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar "
        , "JJJJ-MM-DD
- JJJJ is het jaar
- MM is de maand
- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00928'
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
        , "JJJJ-MM-DD
- JJJJ is het jaar
- MM is de maand
- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00218'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00926"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VAN ONDERTEKENING VAN DE OVEREENKOMST"
        , "ContractSignatureDate"
        , "Luik "Contract met betrekking tot de werken""
        , "Datum waarop het contract ondertekend werd tussen de aangever en de opdrachtgever voor de uitvoering van de betrokken werken.\nDe ondertekeningsdatum moet vóór de begindatum van de werken (00927) liggen."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar "
        , "JJJJ-MM-DD
- JJJJ is het jaar
- MM is de maand
- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00926'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00637"
        , "2023/1"
        , "28/02/2023"
        , "E-MAILADRES"
        , "EmailAddress"
        , "Communicatie"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "60"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00637'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01096"
        , "2023/1"
        , "28/02/2023"
        , "EINDDOEL VAN HET PROJECT DAT DE WERKEN OMVAT"
        , "WorksGlobalProjectPurpose"
        , "Project dat de werken omvat"
        , "Zone waarin het einddoel van het project dat de werken omvat gedefinieerd kan worden.Werken met een specifiek einddoel: project, verzameling van werken/diensten die verbonden zijn en die als doel hebben om te voldoen aan een bepaalde behoefte (voor de opdrachtgever) binnen de vastgelegde termijnen (met de opdrachtgever) en binnen de vastgelegde prijslimiet of een contract in regie.
Werken met een doorlopend einddoel: we voorzien hier de werken/contracten van bepaalde of onbepaalde duur in het kader waarvan de regelmatige of herhaalde prestaties voorzien zijn; het einddoel van de werken/diensten verzameld in een aangifte moet hetzelfde zijn; er dient een onderscheid gemaakt te worden in de verschillende aangiften van werken/diensten die op onafhankelijke wijze uitgevoerd worden. De realisatie van een activiteit hangt niet af van een andere om het einddoel te bereiken."
        , "1 = werken met een specifiek einddoel; 2 = werken met een doorlopend einddoel"
        , ""
        , "Alfanumeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01096'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00678"
        , "2023/1"
        , "28/02/2023"
        , "FAXNUMMER"
        , "FaxNbr"
        , "Communicatie"
        , "Deze zone wordt in dit bericht nooit gebruikt."
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00678'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00522"
        , "2023/1"
        , "28/02/2023"
        , "GEMEENTE"
        , "City"
        , "Adres"
        , "Naam van een gemeente."
        , "Indien het een Belgische gemeente is moet de waarde verwijzen naar één van de namen die in de bijlage 23 overeenkomen met de postcode die aangeduid staat in de zone 00520 (postcode)."
        , ""
        , "Alfanumeriek"
        , "40"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00522'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00522"
        , "2023/1"
        , "28/02/2023"
        , "GEMEENTE"
        , "City"
        , "Adres van de site"
        , "Naam van een gemeente."
        , "Indien het een Belgische gemeente is moet de waarde verwijzen naar één van de namen die in de bijlage 23 overeenkomen met de postcode die aangeduid staat in de zone 00520 (postcode)."
        , ""
        , "Alfanumeriek"
        , "40"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00522'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00636"
        , "2023/1"
        , "28/02/2023"
        , "GSM-NUMMER"
        , "GSMNbr"
        , "Communicatie"
        , "Deze zone wordt in dit bericht nooit gebruikt."
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00636'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00298"
        , "2023/1"
        , "28/02/2023"
        , "HERKOMST VAN DE REFERENTIE"
        , "ReferenceOrigin"
        , "Referentie"
        , "Waarde die de authentieke bron van een referentienummer aanduidt.
"
        , "1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal secretariaat, een softwareontwikkelaar, ...)
2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een antwoord op eenduidige wijze identificeert
3 = het referentienummer is toegekend door een sector van de sociale zekerheid
4 = het referentienummer is toegekend door de dienst ePost
5 = het referentienummer is toegekend door de KSZ
6 = het referentienummer is toegekend door het archiveringssysteem (DOC-ID)
7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend (DSP-ID)
Deze zone moet de waarde "1" hebben."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00298'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01081"
        , "2023/1"
        , "28/02/2023"
        , "HOEDANIGHEID VAN DE ACTOR"
        , "ParticipantQuality"
        , "Andere actor"
        , "Karakteriseert de hoedanigheid van de actor."
        , "1 = De bouwdirectie belast met het ontwerp\n2 = De bouwdirectie belast met de controle op de uitvoering\n3 = Coördinator van het project\n4 = Coördinator van de realisatie"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01081'
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
        , "Zie bijlage 11 - Identificatie van het formulier. Deze zone moet de waarde 'AVWDDT' hebben."
        , ""
        , "Alfanumeriek"
        , "7"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00296'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00523"
        , "2023/1"
        , "28/02/2023"
        , "LANDCODE"
        , "Country"
        , "Adres"
        , "Code die toelaat een land te identificeren."
        , "Zie Bijlage 5 - Lijst met landcodes."
        , ""
        , "Numeriek"
        , "5"
        , "Verplicht indien de zone in het blok Adres (90022) ligt. Facultatief indien de zone in het blok Adres van de site (90488) ligt."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00523'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00523"
        , "2023/1"
        , "28/02/2023"
        , "LANDCODE"
        , "Country"
        , "Adres van de site"
        , "Code die toelaat een land te identificeren."
        , "Zie Bijlage 5 - Lijst met landcodes."
        , ""
        , "Numeriek"
        , "5"
        , "Verplicht indien de zone in het blok Adres (90022) ligt. Facultatief indien de zone in het blok Adres van de site (90488) ligt."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00523'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00726"
        , "2023/1"
        , "28/02/2023"
        , "NAAM"
        , "Name"
        , "Andere actor"
        , "Familienaam van een natuurlijk persoon.
Men moet de naam vermelden die op het paspoort of de identiteitskaart staat.
Voor vrouwen van Belgische nationaliteit gaat het om de meisjesnaam.
In het blok "Andere actor" (90477) gaat het om de naam van de contactpersoon bij de vernoemde onderneming die toegewezen wordt aan de werken onder de aangegeven hoedanigheid."
        , ""
        , ""
        , "Alfanumeriek"
        , "48"
        , "Onmisbaar in alle blokken van het glossarium behalve in het blok "Andere actor" (90477) waar de zone facultatief is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00726'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00726"
        , "2023/1"
        , "28/02/2023"
        , "NAAM"
        , "Name"
        , "Gegevens van de contactpersoon"
        , "Familienaam van een natuurlijk persoon.
Men moet de naam vermelden die op het paspoort of de identiteitskaart staat.
Voor vrouwen van Belgische nationaliteit gaat het om de meisjesnaam.
In het blok "Andere actor" (90477) gaat het om de naam van de contactpersoon bij de vernoemde onderneming die toegewezen wordt aan de werken onder de aangegeven hoedanigheid."
        , ""
        , ""
        , "Alfanumeriek"
        , "48"
        , "Onmisbaar in alle blokken van het glossarium behalve in het blok "Andere actor" (90477) waar de zone facultatief is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00726'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00518"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN HET ADRES"
        , "HouseNbr"
        , "Adres"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien de zone in het blok Adres (90022) ligt. Facultatief indien de zone in het blok Adres van de site (90488) ligt."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00518'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00518"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN HET ADRES"
        , "HouseNbr"
        , "Adres van de site"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien de zone in het blok Adres (90022) ligt. Facultatief indien de zone in het blok Adres van de site (90488) ligt."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00518'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/1"
        , "28/02/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Andere actor"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
In het FB SubcontractorCompanyId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan. Moet identiek zijn aan de identificatie
(ondernemingsnummer, RSZ-nummer of identificatienummer van de betrokkene verbonden aan het contract met betrekking tot de werken) van deze rechtstreekse werkgever. 
Het kan ofwel gaan om de aangever ofwel om een onderaannemer. In dit laatste geval moet deze onderaannemer aanwezig zijn in hetzelfde bericht, zelfs als het om een toevoeging gaat en de onderaannemer-werkgever al eerder werd aangegeven. 
In het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , "
Getal van 10 cijfers waarvan :
de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
de posities 9 en 10 overeenkomen met een controlegetal.
Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.De waarde 0 is niet toegelaten in dit bericht."
        , ""
        , "Numeriek"
        , "10"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/1"
        , "28/02/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Identificatie van de aangever van het contract met betrekking tot de werken"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
In het FB SubcontractorCompanyId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan. Moet identiek zijn aan de identificatie
(ondernemingsnummer, RSZ-nummer of identificatienummer van de betrokkene verbonden aan het contract met betrekking tot de werken) van deze rechtstreekse werkgever. 
Het kan ofwel gaan om de aangever ofwel om een onderaannemer. In dit laatste geval moet deze onderaannemer aanwezig zijn in hetzelfde bericht, zelfs als het om een toevoeging gaat en de onderaannemer-werkgever al eerder werd aangegeven. 
In het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , "
Getal van 10 cijfers waarvan :
de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
de posities 9 en 10 overeenkomen met een controlegetal.
Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.De waarde 0 is niet toegelaten in dit bericht."
        , ""
        , "Numeriek"
        , "10"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/1"
        , "28/02/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Identificatie van de onderaannemer"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
In het FB SubcontractorCompanyId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan. Moet identiek zijn aan de identificatie
(ondernemingsnummer, RSZ-nummer of identificatienummer van de betrokkene verbonden aan het contract met betrekking tot de werken) van deze rechtstreekse werkgever. 
Het kan ofwel gaan om de aangever ofwel om een onderaannemer. In dit laatste geval moet deze onderaannemer aanwezig zijn in hetzelfde bericht, zelfs als het om een toevoeging gaat en de onderaannemer-werkgever al eerder werd aangegeven. 
In het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , "
Getal van 10 cijfers waarvan :
de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
de posities 9 en 10 overeenkomen met een controlegetal.
Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.De waarde 0 is niet toegelaten in dit bericht."
        , ""
        , "Numeriek"
        , "10"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/1"
        , "28/02/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Identificatie van de opdrachtgever"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
In het FB SubcontractorCompanyId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan. Moet identiek zijn aan de identificatie
(ondernemingsnummer, RSZ-nummer of identificatienummer van de betrokkene verbonden aan het contract met betrekking tot de werken) van deze rechtstreekse werkgever. 
Het kan ofwel gaan om de aangever ofwel om een onderaannemer. In dit laatste geval moet deze onderaannemer aanwezig zijn in hetzelfde bericht, zelfs als het om een toevoeging gaat en de onderaannemer-werkgever al eerder werd aangegeven. 
In het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , "
Getal van 10 cijfers waarvan :
de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
de posities 9 en 10 overeenkomen met een controlegetal.
Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.De waarde 0 is niet toegelaten in dit bericht."
        , ""
        , "Numeriek"
        , "10"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/1"
        , "28/02/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Identificatie van de tijdelijke handelsvennootschap"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
In het FB SubcontractorCompanyId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan. Moet identiek zijn aan de identificatie
(ondernemingsnummer, RSZ-nummer of identificatienummer van de betrokkene verbonden aan het contract met betrekking tot de werken) van deze rechtstreekse werkgever. 
Het kan ofwel gaan om de aangever ofwel om een onderaannemer. In dit laatste geval moet deze onderaannemer aanwezig zijn in hetzelfde bericht, zelfs als het om een toevoeging gaat en de onderaannemer-werkgever al eerder werd aangegeven. 
In het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , "
Getal van 10 cijfers waarvan :
de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
de posities 9 en 10 overeenkomen met een controlegetal.
Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.De waarde 0 is niet toegelaten in dit bericht."
        , ""
        , "Numeriek"
        , "10"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/1"
        , "28/02/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Werkgevende onderneming"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
In het FB SubcontractorCompanyId (90573) dit zone duidt de rechtstreekse werkgever van de onderaannemer aan. Moet identiek zijn aan de identificatie
(ondernemingsnummer, RSZ-nummer of identificatienummer van de betrokkene verbonden aan het contract met betrekking tot de werken) van deze rechtstreekse werkgever. 
Het kan ofwel gaan om de aangever ofwel om een onderaannemer. In dit laatste geval moet deze onderaannemer aanwezig zijn in hetzelfde bericht, zelfs als het om een toevoeging gaat en de onderaannemer-werkgever al eerder werd aangegeven. 
In het bericht moet de onderaannemer-werkgever bovendien altijd voor de onderaannemer-werknemer staan."
        , "
Getal van 10 cijfers waarvan :
de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
de posities 9 en 10 overeenkomen met een controlegetal.
Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.De waarde 0 is niet toegelaten in dit bericht."
        , ""
        , "Numeriek"
        , "10"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00520"
        , "2023/1"
        , "28/02/2023"
        , "POSTCODE"
        , "ZIPCode"
        , "Adres"
        , "Postnummer van een gemeente.
"
        , "Indien het een Belgische postcode is, moet de waarde betrekking hebben op één van de codes die in de bijlage 23 staan."
        , ""
        , "Alfanumeriek"
        , "9"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00520'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00520"
        , "2023/1"
        , "28/02/2023"
        , "POSTCODE"
        , "ZIPCode"
        , "Adres van de site"
        , "Postnummer van een gemeente."
        , "Indien het een Belgische postcode is, moet de waarde betrekking hebben op één van de codes die in de bijlage 23 staan."
        , ""
        , "Alfanumeriek"
        , "9"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00520'
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
        , "UU is een element van [00;23]; MM is een element van [00;59] -- SS is een element van [00;59] -- SSS is een element van [000;999]"
        , ""
        , "Alfanumeriek"
        , "12"
        , "Onmisbaar "
        , "UU:MM:SS.SSS; UU zijn de uren; MM zijn de minuten; SS zijn de seconden; SSS zijn de milliseconden"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00299'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00931"
        , "2023/1"
        , "28/02/2023"
        , "REDEN VOOR LAATTIJDIGE AANGIFTE VAN HET CONTRACT MET BETREKKING TOT DE WERKEN"
        , "LateWorksContractDeclReason"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Zone waarin de aangever zijn situatie kan vermelden ten opzichte van de verplichtingen voor de aangifte van het contract met betrekking tot werken/diensten in geval van laattijdige aangifte."
        , "0 = De werken moesten vanaf hun begin aangegeven worden. De voorwaarden die bepalen dat de werken aangegeven moeten worden, waren voldaan.\n1 = De werken moesten niet vanaf hun begin aangegeven worden.. De voorwaarden die bepalen dat de werken aangegeven moeten worden, waren toen nog niet voldaan."
        , ""
        , "Numeriek"
        , "1"
        , "Verplicht indien de begindatum van het contract met betrekking tot de werken (zone 00927) vroeger valt dan de datum van aangifte (zone 00218)."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00931'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00222"
        , "2023/1"
        , "28/02/2023"
        , "REFERENTIENUMMER"
        , "ReferenceNbr"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Het referentienummer.Geeft de interne referentie van de onderneming aan voor de aangegeven werken/diensten.\nIn het functioneel blok 'Luik contract met betrekking tot de werken' (90387) staat de interne referentie van het contract."
        , "In dit bericht is de toegelaten lengte voor deze zone 20 tekens."
        , ""
        , "Alfanumeriek"
        , "64"
        , "Verplicht indien de zone in het blok 'Referentie' (90082) ligt.\nFacultatief indien de zone in het blok 'Luik contract met betrekking tot de werken' (90387) ligt."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00222'
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
        , "Het referentienummer.Geeft de interne referentie van de onderneming aan voor de aangegeven werken/diensten.\nIn het functioneel blok 'Luik contract met betrekking tot de werken' (90387) staat de interne referentie van het contract."
        , "In dit bericht is de toegelaten lengte voor deze zone 20 tekens."
        , ""
        , "Alfanumeriek"
        , "64"
        , "Verplicht indien de zone in het blok 'Referentie' (90082) ligt.\n Facultatief indien de zone in het blok 'Luik contract met betrekking tot de werken' (90387) ligt."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00222'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01093"
        , "2023/1"
        , "28/02/2023"
        , "SECTOR VAN HET PROJECT DAT DE WERKEN OMVAT"
        , "WorksGlobalProjectSector"
        , "Project dat de werken omvat"
        , ""
        , "1 = Werken in onroerende staat; 2 = Bewaking en/of toezicht; 3 = Vleesverwerkende nijverheid (bepaalde activiteiten)"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01093'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00110"
        , "2023/1"
        , "28/02/2023"
        , "STATUS VAN HET ATTEST"
        , "AttestationStatus"
        , "Formulier"
        , ""
        , "0 = Origineel
1 = Wijziging
2 = Duplicaat
3 = Annulatie
4 = Herziening
5 = Herinnering
6 = Afsluiting
7 = Wijziging van papieren origineel
8 = KopieAlleen de waarde 0 (origineel) is toegelaten in dit bericht."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00110'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00545"
        , "2023/1"
        , "28/02/2023"
        , "STAVING"
        , "Justification"
        , "Identificatie van de onderaannemer"
        , "Staving\nStaving van de afwezigheid van een intracommunautair btw-nummer.\nDeze zone moet verplicht ingevuld worden als de opdrachtgever of onderaannemer (waarvan het land van vestiging lid is van de Europese Unie) niet over een intracommunautaire btw-nummer beschikt."
        , "In dit bericht is de toegelaten lengte voor deze zone tussen 10 en 320 tekens."
        , ""
        , "Alfanumeriek"
        , "5000"
        , "Verplicht indien in het blok Opdrachtgever  (FB 90384), of een onderaannemer (FB 90388), het intracommunautair BTW-nummer (zone 01185) niet aanwezig is, en als het land van vestiging lid is van de EU."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00545'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00545"
        , "2023/1"
        , "28/02/2023"
        , "STAVING"
        , "Justification"
        , "Identificatie van de opdrachtgever"
        , "Staving\nStaving van de afwezigheid van een intracommunautair btw-nummer.\nDeze zone moet verplicht ingevuld worden als de opdrachtgever of onderaannemer (waarvan het land van vestiging lid is van de Europese Unie) niet over een intracommunautaire btw-nummer beschikt."
        , "In dit bericht is de toegelaten lengte voor deze zone tussen 10 en 320 tekens."
        , ""
        , "Alfanumeriek"
        , "5000"
        , "Verplicht indien in het blok Opdrachtgever  (FB 90384), of een onderaannemer (FB 90388), het intracommunautair BTW-nummer (zone 01185) niet aanwezig is, en als het land van vestiging lid is van de EU."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00545'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00517"
        , "2023/1"
        , "28/02/2023"
        , "STRAAT"
        , "Street"
        , "Adres"
        , "Openbare weg."
        , ""
        , ""
        , "Alfanumeriek"
        , "42"
        , "Verplicht indien de zone in het blok Adres (90022) ligt. Facultatief indien de zone in het blok Adres van de site (90488) ligt."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00517'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00517"
        , "2023/1"
        , "28/02/2023"
        , "STRAAT"
        , "Street"
        , "Adres van de site"
        , "Openbare weg."
        , ""
        , ""
        , "Alfanumeriek"
        , "42"
        , "Verplicht indien de zone in het blok Adres (90022) ligt. Facultatief indien de zone in het blok Adres van de site (90488) ligt."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00517'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00919"
        , "2023/1"
        , "28/02/2023"
        , "TAALKEUZE"
        , "LanguagePreference"
        , "Identificatie van de onderaannemer"
        , ""
        , "1 = Nederlands; 2 = Frans; 3 = Duits; 4 = Engels\nHet gebruik van het Engels is alleen toegelaten voor:\n
- buitenlandse opdrachtgevers  (BF 90384 - WorksGlobalProjectOwnerId) met een BTW-nummer (zone 01185 - VATNbr) of een buitenlands ondernemingsnummer (zone 01186 - ForeignCompanyID),
- buitenlandse opdrachtgevers zonder BTW-nummer, gevestigd in een land dat lid is van de EU-lid,\n
- buitenlandse onderaannemers met een BTW-nummer of een  buitenlands ondernemingsnummer, en\n
- buitenlandse onderaannemers zonder BTW-nummer, gevestigd in een land dat lid is van de EU-lid."
        , ""
        , "Numeriek"
        , "1"
        , "Verplicht indien de zone 00014 'Ondernemingsnummer' niet aanwezig is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00919'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00919"
        , "2023/1"
        , "28/02/2023"
        , "TAALKEUZE"
        , "LanguagePreference"
        , "Identificatie van de opdrachtgever"
        , ""
        , "1 = Nederlands\n2 = Frans\n3 = Duits\n4 = Engels\nHet gebruik van het Engels is alleen toegelaten voor:\n- buitenlandse opdrachtgevers  (BF 90384 - WorksGlobalProjectOwnerId) met een BTW-nummer (zone 01185 - VATNbr) of een buitenlands ondernemingsnummer (zone 01186 - ForeignCompanyID),\n- buitenlandse opdrachtgevers zonder BTW-nummer, gevestigd in een land dat lid is van de EU-lid,\n- buitenlandse onderaannemers met een BTW-nummer of een  buitenlands ondernemingsnummer, en\n- buitenlandse onderaannemers zonder BTW-nummer, gevestigd in een land dat lid is van de EU-lid."
        , ""
        , "Numeriek"
        , "1"
        , "Verplicht indien de zone 00014 'Ondernemingsnummer' niet aanwezig is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00919'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00919"
        , "2023/1"
        , "28/02/2023"
        , "TAALKEUZE"
        , "LanguagePreference"
        , "Identificatie van de tijdelijke handelsvennootschap"
        , ""
        , "1 = Nederlands\n2 = Frans\n3 = Duits\n4 = Engels\nHet gebruik van het Engels is alleen toegelaten voor:\n- buitenlandse opdrachtgevers  (BF 90384 - WorksGlobalProjectOwnerId) met een BTW-nummer (zone 01185 - VATNbr) of een buitenlands ondernemingsnummer (zone 01186 - ForeignCompanyID),\n- buitenlandse opdrachtgevers zonder BTW-nummer, gevestigd in een land dat lid is van de EU-lid,\n- buitenlandse onderaannemers met een BTW-nummer of een  buitenlands ondernemingsnummer, en\n- buitenlandse onderaannemers zonder BTW-nummer, gevestigd in een land dat lid is van de EU-lid."
        , ""
        , "Numeriek"
        , "1"
        , "Verplicht indien de zone 00014 'Ondernemingsnummer' niet aanwezig is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00919'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00677"
        , "2023/1"
        , "28/02/2023"
        , "TELEFOONNUMMER"
        , "PhoneNbr"
        , "Communicatie"
        , "Het telefoonnummer kan het nummer van een vaste lijn zijn of een GSM-nummer.\nHet telefoonnummer is verplicht als het FB Communicatie (90258) onder het FB CoordinatesContactPerson (90257) staat.\nDeze zone is niet van toepassing als het FB Communicatie (90258) onder het FB WorksContractDeclarantId (90381) staat."
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00677'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00930"
        , "2023/1"
        , "28/02/2023"
        , "TOTAALBEDRAG VAN HET CONTRACT MET BETREKKING TOT DE WERKEN"
        , "WorksContractTotalCost"
        , "Luik 'Contract met betrekking tot de werken'"
        , "Totaalbedrag in euro's van de werken/ diensten gefactureerd door de hoofdaannemer die de aangifte doet.Voor de werken met een doorlopend einddoel moet het bedrag berekend worden op basis van de prijzen van de werken/diensten per jaar en het kan opnieuw geëvalueerd worden bij elke vernieuwing van de einddatum van de werken."
        , ""
        , ""
        , "Numeriek"
        , "12"
        , "Onmisbaar zelfs voor de contracten in regie (met werken met een specifiek einddoel)"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00930'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00221"
        , "2023/1"
        , "28/02/2023"
        , "TYPE VAN DE REFERENTIE"
        , "ReferenceType"
        , "Referentie"
        , "Duidt aan naar waar de referentie (00222 Referentienummer) verwijst: naar deze aangifte, naar een aangifte die verwant is met deze aangifte of naar een verzameling aangiften (= een dossier) waar deze aangifte toe behoort, op deze aanvraag, op dit formulier.Geeft de interne referentie van de onderneming aan voor de aangegeven werken/diensten."
        , "0 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat niet dezelfde identificatie heeft (zie bijlagen 11/302), dat verband houdt met het huidige formulier
1 = de referentie verwijst naar dit formulier
2 = de referentie is een dossiernummer en verwijst naar het dossier (= verzameling van aangiften) waartoe deze aangifte behoort of waartoe dit formulier behoort
3 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat dezelfde identificatie heeft (zie bijlagen 11/302) en dat verband houdt met dit formulier, bijvoorbeeld: de referentie heeft betrekking op de aangifte die geannuleerd moet worden door deze aangifte, of op de aangifte die vervangen moet worden door deze aangifte, of op de aangifte die gewijzigd moet worden, of op de aangifte die aan de oorsprong ligt van dit formulier...
4 = de referentie verwijst naar een aangifte in een ander scenario die verwant is met deze aangifte
5 = de referentie verwijst naar een aanvraag
6 = de referentie verwijst naar een geweigerde aangifte
7 = de referentie verwijst naar de werkgever die in deze aangifte wordt vermeld
8 = de referentie verwijst naar de werknemer die in deze aangifte wordt vermeld
9 = de referentie is een gestructureerde mededeling die moet worden gebruikt in het kader van een betaling en verwijst naar dit formulierDeze zone moet de waarde 1 hebben."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
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
        , "Het type wijst de aard van het elektronisch formulier aan.
"
        , "RE = REQUEST - het formulier vraagt inlichtingen
PA = PROVISIONAL ANSWER - het formulier is een tijdelijk antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
FA = FINAL ANSWER - het formulier is een definitief antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
LA = LIMITED ANSWER - het formulier is een beperkt antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
SU = SUBMISSION - het formulier deelt inlichtingen mee
De enige mogelijke waarde in dit bericht is SU."
        , ""
        , "Alfanumeriek"
        , "2"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00297'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01082"
        , "2023/1"
        , "28/02/2023"
        , "VERPLICHT OM ZICH TE REGISTREREN"
        , "IsObligedToRegister"
        , "Project dat de werken omvat"
        , "Zone waarin kan aangegeven worden of de aanwezigheden op de werf al dan niet geregistreerd moeten worden.Het globaal bedrag van de werken is de som van al de contracten met de opdrachtgever voor al de ondernemingen-aangevers voor deze aangifte van werken. Indien ongekend kan deze informatie gevraagd worden aan de opdrachtgever (klant)."
        , "0 = Is niet verplicht zich te registreren. Aanvankelijk voorzien globaal bedrag van de werken lager dan of gelijk aan het drempelbedrag van de aanwezigheidsregistratie op de werkplaats (Checkin@work).
1 = Is verplicht zich te registreren. Aanvankelijk voorzien globaal bedrag van de werken hoger dan het drempelbedrag van de aanwezigheidsregistratie op de werkplaats (Checkin@work)."
        , ""
        , "Numeriek"
        , "2"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01082'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00727"
        , "2023/1"
        , "28/02/2023"
        , "VOORNAAM"
        , "FirstName"
        , "Gegevens van de contactpersoon"
        , "Eerste voornaam van een natuurlijk persoon."
        , ""
        , ""
        , "Alfanumeriek"
        , "24"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00727'
                          AND Version = '2023/1'
);
