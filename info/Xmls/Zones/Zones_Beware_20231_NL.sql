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
SELECT "00614"
        , "2023/1"
        , "28/02/2023"
        , "AANDUIDING VAN BESLISSING VAN DE SUBGROEP"
        , "SubGroupDecisionIndicator"
        , "Subgroep - Informatie"
        , "Toont de beslissing genomen door de sociale zekerheid bij de weigering van het geheel van de onzekere verbeteringen met betrekking tot een originele aangifte. Deze zone wordt nooit opgenomen in de Beware-notificatie"
        , "'R' (Refused) = het geheel van de onzekere verbeteringen met betrekking tot een originele aangifte wordt geweigerd en de betreffende elementen worden vrijgegeven"
        , ""
        , "Alfanumeriek"
        , "1"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00614'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00878"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL BETROKKEN WERKNEMERS"
        , "NbrOfWorkersInvolved"
        , "Boekhoudkundig overzicht - Verminderingscode"
        , "Aantal werknemers waarop het boekhoudkundig overzicht betrekking heeft."
        , ""
        , ""
        , "Numeriek"
        , "6"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00878'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00878"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL BETROKKEN WERKNEMERS"
        , "NbrOfWorkersInvolved"
        , "Boekhoudkundig overzicht - werknemerskengetal bijdrage"
        , "Aantal werknemers waarop het boekhoudkundig overzicht betrekking heeft."
        , ""
        , ""
        , "Numeriek"
        , "6"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00878'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00846"
        , "2023/1"
        , "28/02/2023"
        , "AANVRAAG VOOR BEREKENING  ARTIKEL 54 TER"
        , "CalculationRequestArt54ter"
        , "Informatie van de Beware-notificatie"
        , "Aanvraag voor berekening van de sanctie artikel 54 ter door een agent of een inspecteur, zonder te oordelen of de sanctie van toepassing is. In dit bericht betekent de aanwezigheid van deze zone dat de Beware-notificatie het resultaat is van de verwerking van verbeteringen waarvoor de berekening van de sanctie artikel 54 ter gevraagd werd, zonder te oordelen of de sanctie van toepassing is."
        , "S = aanvraag voor berekening van de sanctie artikel 54 ter"
        , ""
        , "Alfanumeriek"
        , "1"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00846'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00847"
        , "2023/1"
        , "28/02/2023"
        , "AANVRAAG VOOR BEREKENING - SANCTIE CO2"
        , "CalculationRequestCO2"
        , "Boeking"
        , "Aanvraag voor berekening van de sanctie CO2 door een agent of een inspecteur, zonder te oordelen of de sanctie van toepassing is. Deze zone mag alleen gebruikt worden in combinatie met een boeking met boekhoudkundige referentie '128' en betekent dat deze boeking onderworpen is aan de sanctie CO2."
        , "S = aanvraag voor berekening van de sanctie CO2"
        , ""
        , "Alfanumeriek"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00847'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00884"
        , "2023/1"
        , "28/02/2023"
        , "BEDRAG VAN DE BIJDRAGE NIET GEBONDEN AAN EEN NATUURLIJKE PERSOON (MET TEKEN)"
        , "SignedCUNPAmount"
        , "Boekhoudkundig overzicht - Werknemerskengetal voor een bijdrage die niet gebonden is aan een natuurlijke persoon"
        , "Bedrag (met teken) van de bijdrage die niet gebonden is aan een natuurlijke persoon."
        , "Een positief bedrag wijst op een bedrag in het voordeel van de RSZ.Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00884'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00880"
        , "2023/1"
        , "28/02/2023"
        , "BEDRAG VAN DE BIJDRAGE (MET TEKEN)"
        , "SignedContributionAmount"
        , "Boekhoudkundig overzicht - werknemerskengetal bijdrage"
        , "Bedrag (met teken) van de verschuldigde bijdrage."
        , "Een positief bedrag wijst op een bedrag in het voordeel van de RSZ.Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00880'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01260"
        , "2023/1"
        , ""
        , "BEDRAG VAN DE COMPENSATIE (MET TEKEN)"
        , "SignedCompensationAmount"
        , "Boekhoudkundig overzicht - Werkgeverscompensatie"
        , "Bedrag (met teken) van de compensatie."
        , "Een positief bedrag wijst op een bedrag in het voordeel van de RSZ. Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01260'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00877"
        , "2023/1"
        , "28/02/2023"
        , "BEDRAG VAN DE NOTIFICATIE VAN WIJZIGING"
        , "DmfANotAmount"
        , "Informatie van de multifunctionele aangifte"
        , "Dit bedrag komt overeen hetzij met de zone 'Bedrag in debet van de wijziging', hetzij met de zone 'Bedrag in credit van de wijziging' die voorkomt in de notificatie van wijziging."
        , "Een positief bedrag wijst op een bedrag in het voordeel van de RSZ. Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00877'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00882"
        , "2023/1"
        , "28/02/2023"
        , "BEDRAG VAN DE VERMINDERING (MET TEKEN)"
        , "SignedDeductionAmount"
        , "Boekhoudkundig overzicht - Verminderingscode"
        , "Bedrag (met teken) van de aangevraagde vermindering."
        , "Een positief bedrag wijst op een bedrag in het voordeel van de RSZ. Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00882'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01023"
        , "2023/1"
        , "28/02/2023"
        , "BEDRAG VERBONDEN AAN DE INSTRUCTIE"
        , "InstructionAmount"
        , "Instructie voor de werkgever"
        , "Bedrag verbonden aan de instructie"
        , "[1,999999999999999] Het bedrag wordt uitgedrukt in eurocenten."
        , ""
        , "Alfanumeriek"
        , "15"
        , "Verplicht indien het type instructie = 1, 3 of 4"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01023'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00776"
        , "2023/1"
        , "28/02/2023"
        , "BENAMING"
        , "Denomination"
        , "Gegevens van de mandataris"
        , "In dit bericht gaat het om de benaming van de eventuele mandataris van de werkgever (niet het sociaal secretariaat of de dienstverlener)."
        , ""
        , ""
        , "Alfanumeriek"
        , "96"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00776'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00157"
        , "2023/1"
        , "28/02/2023"
        , "BENAMING VAN DE WERKGEVER"
        , "EmployerDenomination"
        , "Coördinaten werkgever"
        , "De benaming van de werkgever."
        , ""
        , ""
        , "Alfanumeriek"
        , "96"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00157'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00883"
        , "2023/1"
        , "28/02/2023"
        , "BEREKENINGSBASIS VAN DE BIJDRAGE NIET GEBONDEN AAN EEN NATUURLIJKE PERSOON (MET TEKEN)"
        , "SignedCUNPCalcBasis"
        , "Boekhoudkundig overzicht - Werknemerskengetal voor een bijdrage die niet gebonden is aan een natuurlijke persoon"
        , "Basisbedrag (met teken) dat toelaat om het bedrag te berekenen van de bijdrage die verschuldigd is en niet gebonden is aan een natuurlijke persoon."
        , ""
        , ""
        , "Alfanumeriek"
        , "16"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00883'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00879"
        , "2023/1"
        , "28/02/2023"
        , "BEREKENINGSBASIS VAN DE BIJDRAGE (MET TEKEN)"
        , "SignedContributionCalcBasis"
        , "Boekhoudkundig overzicht - werknemerskengetal bijdrage"
        , "Bedrag (met teken) waarop een percentage moet worden toegepast om het bedrag te kennen van de verschuldigde bijdrage."
        , ""
        , ""
        , "Alfanumeriek"
        , "16"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00879'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00881"
        , "2023/1"
        , "28/02/2023"
        , "BEREKENINGSBASIS VAN DE VERMINDERING (MET TEKEN)"
        , "SignedDeductionCalcBasis"
        , "Boekhoudkundig overzicht - Verminderingscode"
        , "Bedrag (met teken) waarop een percentage moet worden toegepast om het bedrag te kennen van de aangevraagde vermindering."
        , ""
        , ""
        , "Alfanumeriek"
        , "16"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00881'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00568"
        , "2023/1"
        , "28/02/2023"
        , "BOEKHOUDKUNDIGE REFERENTIE"
        , "AccountingRef"
        , "Boeking"
        , "Zie bijlage 41 : lijst van de boekhoudkundige referenties"
        , "In dit bericht zijn de enige toegelaten waarden 121, 221, 128, 228, 132, 232, 316 en 356."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00568'
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
        , "Nummer van een brievenbus. Deze zone betreft ofwel de werkgever, ofwel, indien nodig, zijn eventuele mandataris (niet het sociaal secretariaat of de dienstverlener)."
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
SELECT "00867"
        , "2023/1"
        , "28/02/2023"
        , "CLASSIFICATIE VAN DE VERBETERING"
        , "CorrectionClassification"
        , "Sectie wijzigend bericht"
        , ""
        , "1 = Verbetering van de socialezekerheids-bijdragen (met uitsluiting van de bijdragen die deelnemen aan het debetbericht van de jaarlijkse vakantie).\n2 = Sanctie\n3 = Verbetering van de bijdragen die deelnemen aan het debetbericht van de jaarlijkse vakantie"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00867'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00887"
        , "2023/1"
        , "28/02/2023"
        , "COMMENTAAR"
        , "Comment"
        , "Instructie voor de werkgever"
        , "Commentaarzone. Door de rekeningbeheerder ingebrachte commentaar die uitleg geeft over de instructies indien nodig"
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
SELECT "00872"
        , "2023/1"
        , "28/02/2023"
        , "DATUM - BOEKHOUDKUNDIGE DATUM"
        , "AccountingDate"
        , "Bericht van wijziging der bijdragen"
        , "Datum waarop het bericht van wijziging der bijdragen geboekt is."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar"
        , "JJJJ-MM-DD\n - JJJJ is het jaar\n- MM is de maand\n - DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00872'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01024"
        , "2023/1"
        , "28/02/2023"
        , "DATUM - VERVALDATUM"
        , "DueDate"
        , "Instructie voor de werkgever"
        , "Datum waarop de werkgever het bedrag verbonden aan de instructie dient te betalen"
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het type instructie = 1"
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01024'
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
        , "JJJJ is een element van [lopend jaar -1 ; lopend jaar] ;\nDe datum mag zich niet in de toekomst bevinden."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar"
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00218'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00537"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VAN DE STAVING"
        , "JustificationDate"
        , "Subgroep - Informatie"
        , "Datum die de stavingscode eventueel vervolledigt."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Facultatief"
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00537'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00870"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VERWERKINGSDATUM"
        , "ProcessingDate"
        , "Informatie van de Beware-notificatie"
        , "Datum waarop de verbeteringen aangebracht in de multifunctionele aangifte van de werkgever werden verwerkt en gegroepeerd om te worden opgenomen in de Beware-notificatie."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar"
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00870'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01025"
        , "2023/1"
        , "28/02/2023"
        , "DATUM WAAROP DE REKENING GESALDEERD IS"
        , "BalancingDate"
        , "Instructie voor de werkgever"
        , "Datum waarop de rekening gesaldeerd is"
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het type instructie = 5"
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01025'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00874"
        , "2023/1"
        , "28/02/2023"
        , "DEELNAME AAN EEN WIJZIGEND BERICHT"
        , "AccountUpdateReportParticipation"
        , "Sectie verwerkte verbeteringen"
        , "Aanduiding die aangeeft of de verbeteringen van een kwartaal deelnemen aan de opstelling van een bericht van wijziging der bijdragen, op grond van de tolerantieregels gedefinieerd door de RSZ."
        , "0 = de verbeteringen nemen niet deel aan de opstelling van een wijzigend bericht\n1 = de verbeteringen nemen deel aan de opstelling van een wijzigend bericht"
        , ""
        , "Alfanumeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00874'
                          AND Version = '2023/1'
);


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
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00637'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00678"
        , "2023/1"
        , "28/02/2023"
        , "FAXNUMMER"
        , "FaxNbr"
        , "Communicatie"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00678'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00535"
        , "2023/1"
        , "28/02/2023"
        , "FOUTIEVE CODE"
        , "FaultyCode"
        , "Informatie van de Beware-notificatie"
        , "Code toegekend door de sociale zekerheid in het geval van een wijziging waarbij de werkgever als foutief beschouwd wordt vanuit het standpunt van de penaliteiten.In dit bericht betekent de aanwezigheid van deze zone dat de Beware-notificatie het resultaat is van verbeteringen waarbij de werkgever als foutief beschouwd wordt vanuit het standpunt van de penaliteiten."
        , "'F' = de werkgever wordt als foutief beschouwd vanuit het standpunt van de penaliteiten."
        , ""
        , "Alfanumeriek"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00535'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00873"
        , "2023/1"
        , "28/02/2023"
        , "GEBOEKT BEDRAG"
        , "AccountingAmount"
        , "Boeking"
        , "Bedrag geboekt als wijziging voor het betrokken kwartaal."
        , "Een positief bedrag wijst op een bedrag in het voordeel van de RSZ.\nEen negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00873'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00631"
        , "2023/1"
        , "28/02/2023"
        , "GEBRUIKERS COMMENTAAR"
        , "UserComment"
        , "Informatie van de multifunctionele aangifte"
        , "In de Beware-notificatie bevat deze zone de referentie die eventueel gebruikt werd door de aangever."
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00631'
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
        , "Naam van een gemeente. Deze zone betreft ofwel de werkgever, ofwel, indien nodig, zijn eventuele mandataris (niet het sociaal secretariaat of de dienstverlener)."
        , ""
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
        , "Deze zone wordt nooit opgenomen in de Beware-notificatie."
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00636'
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
        , "Waarde die de authentieke bron van een referentienummer aanduidt."
        , "1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal secretariaat, een softwareontwikkelaar, ...)\n2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een antwoord op eenduidige wijze identificeert\n3 = het referentienummer is toegekend door een sector van de sociale zekerheid\n4 = het referentienummer is toegekend door de dienst ePost\n5 = het referentienummer is toegekend door de KSZ\n6 = het referentienummer is toegekend door het archiveringssysteem (DOC-ID)\n7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend (DSP-ID)\nDe mogelijke waarden in dit bericht zijn '2' en '3'."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00298'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00486"
        , "2023/1"
        , "28/02/2023"
        , "HOEDANIGHEID VAN DE AANGEVER"
        , "UserQuality"
        , "Subgroep - Informatie"
        , "Kenmerkt de hoedanigheid van de persoon of de instelling Kenmerkt de hoedanigheid van de persoon of de instelling die aan de oorsprong ligt van de wijziging of de verbetering aangebracht aan de wijziging."
        , "Zie bijlage 39 - Identificatie van de hoedanigheid van de aangever."
        , ""
        , "Numeriek"
        , "2"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00486'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00871"
        , "2023/1"
        , "28/02/2023"
        , "HOEDANIGHEIDSKLASSE VAN DE AANGEVER"
        , "UserQualityClass"
        , "Informatie van de Beware-notificatie"
        , "De waarde van deze zone wordt toegekend op basis van het aangegeven deel van de verbetering."
        , "01: RSZ in de brede zin; 02:  werkgever in de brede zin"
        , ""
        , "Numeriek"
        , "2"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00871'
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
        , "Zie bijlage 11 - Identificatie van het formulier. De enige mogelijke waarde in dit bericht is 'BEWARE'."
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
SELECT "00013"
        , "2023/1"
        , "28/02/2023"
        , "JAAR - KWARTAAL"
        , "Quarter"
        , "Sectie verwerkte verbeteringen"
        , "Bepaling van het jaar en het kwartaal. Bepaling van het jaar en het kwartaal van de aangifte."
        , "Het moet gelegen zijn tussen het eerste kwartaal 2003 (20031) en het laatste afgelopen kalenderkwartaal (lopend JJJJK -1)."
        , ""
        , "Numeriek"
        , "5"
        , "Onmisbaar"
        , "JJJJK\n- JJJJ is het jaar\n- K is het kwartaal"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00013'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01026"
        , "2023/1"
        , "28/02/2023"
        , "JAAR - KWARTAAL VERBONDEN AAN DE INSTRUCTIE"
        , "InstructionQuarter"
        , "Instructie voor de werkgever"
        , "Bepaling van het jaar en het kwartaal.\nAls er een bedrag in mindering gebracht moet worden bij de eerstvolgende betaling (instructietype = 4), dan is dit het kwartaal waarin de storting plaatsvindt.\nIn het geval van een gesaldeerde rekening (instructietype = 5), is dit het kwartaal waarvoor de rekening gesaldeerd is."
        , ""
        , ""
        , "Numeriek"
        , "5"
        , "Verplicht indien het type instructie = 4 of 5"
        , "JJJJK\n- JJJJ is het jaar\n- K is het kwartaal"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01026'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00470"
        , "2023/1"
        , "28/02/2023"
        , "KANTOORNUMMER"
        , "OfficeNumber"
        , "Informatie over de sector"
        , "RSZ-kantoornummer (Controledienst)"
        , ""
        , ""
        , "Alfanumeriek"
        , "3"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00470'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00866"
        , "2023/1"
        , "28/02/2023"
        , "KWARTAAL VAN BOEKING"
        , "AccountingQuarter"
        , "Sectie wijzigend bericht"
        , "Deze zone bevat het kwartaal van de boeking."
        , "Het moet gelegen zijn tussen het eerste kwartaal 2003 (20031) en het laatste afgelopen kalenderkwartaal (lopend JJJJK -1)."
        , ""
        , "Numeriek"
        , "5"
        , "Onmisbaar"
        , "JJJJK\n- JJJJ is het jaar\n- K is het kwartaal"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00866'
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
        , "Code die toelaat een land te identificeren. Deze zone betreft ofwel de werkgever, ofwel, indien nodig, zijn eventuele mandataris (niet het sociaal secretariaat of de dienstverlener)."
        , "Zie Bijlage 5 - Lijst met landcodes."
        , ""
        , "Numeriek"
        , "5"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00523'
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
        , "Familienaam van een natuurlijk persoon.\nMen moet de naam vermelden die op het paspoort of de identiteitskaart staat.\nVoor vrouwen van Belgische nationaliteit gaat het om de meisjesnaam.\nIn dit bericht gaat het om de familienaam van de contactpersoon van de RSZ (Controledienst)."
        , ""
        , ""
        , "Alfanumeriek"
        , "48"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00726'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00917"
        , "2023/1"
        , "28/02/2023"
        , "NOTIE 22 QUATER"
        , "Notion22Quater"
        , "Informatie van de Beware-notificatie"
        , "Code toegekend door een agent van de RSZ om te melden dat de aangifte betrekking heeft op een solidariteitsbijdrage krachtens Art. 22 Quater.De aanwezigheid van deze zone in dit bericht betekent dat de Beware-notificatie het resultaat is van de verwerking van correcties betreffende de solidariteitsbijdrage Art. 22 Quater."
        , "'Q' = De wijzigende aangifte heeft betrekking op de solidariteitsbijdrage Art. 22 Quater voor ontbrekende DIMONA"
        , ""
        , "Alfanumeriek"
        , "1"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00917'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01027"
        , "2023/1"
        , "28/02/2023"
        , "NOTIE WAAR HET REKENINGNUMMER VAN DE WERKGEVER WORDT GEVRAAGD"
        , "AskAccountNotion"
        , "Instructie voor de werkgever"
        , "Notie waarin aan de werkgever wordt gevraagd aan de RSZ het rekeningnummer mee te delen waarop de terugbetaling kan gebeuren"
        , "0 = De werkgever dient het rekeningnummer niet mee te delen aan de RSZ; 1 = De werkgever dient zijn rekeningnummer mee te delen aan de RSZ"
        , ""
        , "Alfanumeriek"
        , "1"
        , "Verplicht indien het type instructie = 3"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01027'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00150"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN ERKEND SOCIAAL SECRETARIAAT BIJKANTOOR"
        , "FilialSecSocNbr"
        , "Gegevens van het sociaal secretariaat"
        , "Deze zone wordt  in dit bericht nooit gebruikt."
        , ""
        , ""
        , "Numeriek"
        , "3"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00150'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00518"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN HET ADRES"
        , "HouseNbr"
        , "Adres"
        , "Deze zone betreft ofwel de werkgever, ofwel, indien nodig, zijn eventuele mandataris (niet het sociaal secretariaat of de dienstverlener)."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00518'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00479"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN SOCIAAL SECRETARIAAT"
        , "SocialSecretariatNumber"
        , "Gegevens van het sociaal secretariaat"
        , "In het functioneel blok 'CoordinatesSocialSecretariat' komt deze zone overeen met het filiaalnummer van het sociaal secretariaat waarbij de werkgever aangesloten is op het ogenblik dat de Beware-notificatie wordt aangemaakt.\nIn het functioneel blok 'DmfAInformation' komt deze zone overeen met het filiaalnummer van het sociaal secretariaat dat aan de oorsprong ligt van de betreffende verbetering."
        , ""
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar in het FB 'CoordinatesSocialSecretariat'. Elders facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00479'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00479"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN SOCIAAL SECRETARIAAT"
        , "SocialSecretariatNumber"
        , "Informatie van de multifunctionele aangifte"
        , "In het functioneel blok 'CoordinatesSocialSecretariat' komt deze zone overeen met het filiaalnummer van het sociaal secretariaat waarbij de werkgever aangesloten is op het ogenblik dat de Beware-notificatie wordt aangemaakt.\nIn het functioneel blok 'DmfAInformation' komt deze zone overeen met het filiaalnummer van het sociaal secretariaat dat aan de oorsprong ligt van de betreffende verbetering."
        , ""
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar in het FB 'CoordinatesSocialSecretariat'. Elders facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00479'
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
        , "Informatie van de Beware-notificatie"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon."
        , "Getal van 10 cijfers waarvan :
de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
de posities 9 en 10 overeenkomen met een controlegetal.
Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden."
        , ""
        , "Numeriek"
        , "10"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
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
        , "Adres"
        , "Postnummer van een gemeente. Deze zone betreft ofwel de werkgever, ofwel, indien nodig, zijn eventuele mandataris (niet het sociaal secretariaat of de dienstverlener)."
        , ""
        , ""
        , "Alfanumeriek"
        , "9"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00520'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00299"
        , "2023/1"
        , "28/02/2023"
        , "PRECIES UUR VAN CREATIE VAN HET FORMULIER"
        , "FormCreationHour"
        , "Formulier"
        , "Tijdstip, uitgedrukt in uren, minuten, seconden en milliseconden."
        , "UU is een element van [00;23]
MM is een element van [00;59]
SS is een element van [00;59]
SSS is een element van [000;999]"
        , ""
        , "Alfanumeriek"
        , "12"
        , "Onmisbaar "
        , "UU:MM:SS.SSS
. UU zijn de uren
. MM zijn de minuten
. SS zijn de seconden
. SSS zijn de milliseconden"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00299'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01028"
        , "2023/1"
        , "28/02/2023"
        , "REFERENTIE VAN DE REKENINGSTAND"
        , "AccountSituationReference"
        , "Rekeningstand"
        , "Geeft de referentie van het document dat de rekeningstand bevat. Het document wordt via de post verstuurd."
        , ""
        , ""
        , "Alfanumeriek"
        , "25"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01028'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00222"
        , "2023/1"
        , "28/02/2023"
        , "REFERENTIENUMMER"
        , "ReferenceNbr"
        , "Referentie"
        , "Het referentienummer.Als de zone "Herkomst van de referentie" de waarde 2 heeft, dan bevat de zone "Referentienummer" het ticketnummer dat werd toegewezen aan het bericht bij de elektronische verzending ervan.
Als de zone "Herkomst van de referentie" de waarde 3 heeft, dan bevat de zone "Referentienummer" het uniek identificatienummer van de Beware-notificatie (ook zendingsnummer-ingangsnummer genoemd)."
        , "In dit bericht is de toegelaten lengte voor deze zone 20 tekens.

Als de zone "Herkomst van de referentie" de waarde 3 heeft, dan heeft de zone "Referentienummer" het formaat JJKXX-YYYYY waarbij
- JJ het lopende jaar is en groter is dan of gelijk aan 07
- K het lopende kwartaal is en een element van [1..4]
 - XX een volgnummer is in JJK en een element van [01..99]
(JJKXX wordt "zendingsnummer" genoemd)
- YYYYY een volgnummer is in JJKXX en een element van [00001..99999]
(YYYYY wordt "ingangsnummer" genoemd)"
        , ""
        , "Alfanumeriek"
        , "64"
        , "Onmisbaar "
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
        , "Informatie van de Beware-notificatie"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ. Het gaat om een definitief RSZ-nummer."
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers.\nAls het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden.\nIn dit bericht is de waarde '0' niet toegelaten."
        , ""
        , "Numeriek"
        , "9"
        , "Onmisbaar"
        , "0 of NNNNNNNCC\n
- NNNNNNN is het nummer\n
- CC is het controlegetal."
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
        , "0 = Origineel
1 = Wijziging
2 = Duplicaat
3 = Annulatie
4 = Herziening
5 = Herinnering
6 = Afsluiting
7 = Wijziging van papieren origineel
8 = KopieDe enige mogelijke waarden in dit bericht zijn "0" en "2"."
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
        , "Subgroep - Informatie"
        , "Staving: Beschrijft het voorwerp van de wijziging onder de vorm van vrije tekst."
        , "In dit bericht is de toegelaten lengte voor deze zone 560 tekens."
        , ""
        , "Alfanumeriek"
        , "5000"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00545'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00536"
        , "2023/1"
        , "28/02/2023"
        , "STAVINGSCODE"
        , "JustificationCode"
        , "Informatie van de Beware-notificatie"
        , "Beschrijft, onder de vorm van een code, de staving van de wijziging doorgevoerd door de Sociale zekerheid.- In het blok "BewareInformation" is de enige mogelijke waarde "05". Zij betekent dat de Beware-notificatie het resultaat is van de groepering van verbeteringen ingevoerd op vraag van het FSO.
- In het blok "SubGroupInformation" zijn alle waarden van bijlage 40 mogelijk"
        , "Zie bijlage 40 - Stavingscode."
        , ""
        , "Numeriek"
        , "2"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00536'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00536"
        , "2023/1"
        , "28/02/2023"
        , "STAVINGSCODE"
        , "JustificationCode"
        , "Subgroep - Informatie"
        , "Beschrijft, onder de vorm van een code, de staving van de wijziging doorgevoerd door de Sociale zekerheid.- In het blok "BewareInformation" is de enige mogelijke waarde "05". Zij betekent dat de Beware-notificatie het resultaat is van de groepering van verbeteringen ingevoerd op vraag van het FSO.
- In het blok "SubGroupInformation" zijn alle waarden van bijlage 40 mogelijk"
        , "Zie bijlage 40 - Stavingscode."
        , ""
        , "Numeriek"
        , "2"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00536'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00517"
        , "2023/1"
        , "28/02/2023"
        , "STRAAT"
        , "Street"
        , "Adres"
        , "Openbare weg. Deze zone betreft ofwel de werkgever, ofwel, indien nodig, zijn eventuele mandataris (niet het sociaal secretariaat of de dienstverlener)."
        , ""
        , ""
        , "Alfanumeriek"
        , "42"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00517'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00481"
        , "2023/1"
        , "28/02/2023"
        , "SUBGROEP"
        , "SubGroup"
        , "Subgroep - Informatie"
        , "Kenmerkt de verschillende delen van eenzelfde aangifte (zelfde ticketnummer)."
        , "1 = deel dat de aangegeven en aanvaarde elementen bevat
2 = deel dat de systeemverbeteringen bevat
3 = deel dat de ter validatie voorgelegde elementen bevat
4 = deel dat de verbeteringen bevat van de ter validatie voorgelegde en gecontroleerde elementen"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00481'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00677"
        , "2023/1"
        , "28/02/2023"
        , "TELEFOONNUMMER"
        , "PhoneNbr"
        , "Communicatie"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00677'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00876"
        , "2023/1"
        , "28/02/2023"
        , "TICKETNUMMER VAN DE NOTIFICATIE VAN WIJZIGING"
        , "DmfANotTicketNbr"
        , "Informatie van de multifunctionele aangifte"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "13"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00876'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00875"
        , "2023/1"
        , "28/02/2023"
        , "TICKETNUMMER VAN EEN (ORIGINELE OF WIJZIGENDE) MULTIFUNCTIONELE AANGIFTE"
        , "DmfATicketNbr"
        , "Informatie van de multifunctionele aangifte"
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "13"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00875'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00426"
        , "2023/1"
        , "28/02/2023"
        , "TOTAALBEDRAG VAN DE BIJDRAGEN"
        , "ContributionTotalAmount"
        , "Bericht van wijziging der bijdragen"
        , "In het functioneel blok "AccountUpdateReport" bevat deze zone het totale bedrag van de socialezekerheidsbijdragen en de verminderingen waarmee rekening werd gehouden bij de opstelling van het wijzigend bericht (met uitsluiting van de bijdragen die deelnemen aan het debetbericht van de jaarlijkse vakantie).
In het functioneel blok "ProcessedCorrectionsSection" bevat deze zone het bedrag van de socialezekerheidsbijdragen en de verminderingen per kwartaal verwerkt in de Beware-notificatie (met uitsluiting van de bijdragen die deelnemen aan het debetbericht van de jaarlijkse vakantie). Het is op basis van dit bedrag dat de door de RSZ gedefinieerde tolerantieregels worden toegepast om te bepalen welke kwartalen al dan niet deelnemen aan de opstelling van het wijzigend bericht."
        , "Het bedrag wordt uitgedrukt in eurocenten.Een positief bedrag wijst op een bedrag in het voordeel van de RSZ.
Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00426'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00426"
        , "2023/1"
        , "28/02/2023"
        , "TOTAALBEDRAG VAN DE BIJDRAGEN"
        , "ContributionTotalAmount"
        , "Sectie verwerkte verbeteringen"
        , "In het functioneel blok "AccountUpdateReport" bevat deze zone het totale bedrag van de socialezekerheidsbijdragen en de verminderingen waarmee rekening werd gehouden bij de opstelling van het wijzigend bericht (met uitsluiting van de bijdragen die deelnemen aan het debetbericht van de jaarlijkse vakantie).
In het functioneel blok "ProcessedCorrectionsSection" bevat deze zone het bedrag van de socialezekerheidsbijdragen en de verminderingen per kwartaal verwerkt in de Beware-notificatie (met uitsluiting van de bijdragen die deelnemen aan het debetbericht van de jaarlijkse vakantie). Het is op basis van dit bedrag dat de door de RSZ gedefinieerde tolerantieregels worden toegepast om te bepalen welke kwartalen al dan niet deelnemen aan de opstelling van het wijzigend bericht."
        , "Het bedrag wordt uitgedrukt in eurocenten.Een positief bedrag wijst op een bedrag in het voordeel van de RSZ.
Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00426'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00864"
        , "2023/1"
        , "28/02/2023"
        , "TOTAALBEDRAG VAN DE BIJDRAGEN DIE DEELNEMEN AAN HET DEBETBERICHT VAN DE JAARLIJKSE VAKANTIE"
        , "AnnualHolidaysContribTotalAmount"
        , "Bericht van wijziging der bijdragen"
        , "Totaalbedrag van de wijzigingen van bijdragen die deelnemen aan het debetbericht van de jaarlijkse vakantie, berekend bij de opstelling van het wijzigend bericht."
        , "Een positief bedrag wijst op een bedrag in het voordeel van de RSZ. Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00864'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00863"
        , "2023/1"
        , "28/02/2023"
        , "TOTAALBEDRAG VAN DE SANCTIES"
        , "SanctionsTotalAmount"
        , "Bericht van wijziging der bijdragen"
        , "Totaalbedrag van de sancties (54TER en CO2) berekend "
        , "Deze zone is altijd positief. Een positief bedrag wijst op een bedrag in het voordeel van de RSZ."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00863'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00865"
        , "2023/1"
        , "28/02/2023"
        , "TOTAALBEDRAG VAN HET WIJZIGEND BERICHT"
        , "AccountUpdateReportTotalAmount"
        , "Bericht van wijziging der bijdragen"
        , ""
        , "Een positief bedrag wijst op een bedrag in het voordeel van de RSZ. Een negatief bedrag wijst op een bedrag in het voordeel van de werkgever."
        , ""
        , "Alfanumeriek"
        , "16"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00865'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00083"
        , "2023/1"
        , "28/02/2023"
        , "TYPE BIJDRAGE"
        , "ContributionType"
        , "Boekhoudkundig overzicht - werknemerskengetal bijdrage"
        , "Het type bijdrage laat toe, in combinatie met het werknemerskengetal bijdrage, de aangegeven bijdrage te identificeren, te bepalen of de bijdrage verschuldigd is en het percentage of het forfait van de bijdrage te kennen."
        , "De toegelaten waarden in functie van het werknemerskengetal bijdrage bevinden zich in bijlage 3 - Toegelaten waarden voor het "type bijdrage" in functie van de werknemerskengetallen bijdragen."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00083'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01022"
        , "2023/1"
        , "28/02/2023"
        , "TYPE INSTRUCTIE"
        , "InstructionType"
        , "Instructie voor de werkgever"
        , "Type instructie die de werkgever moet volgen met betrekking tot het bedrag verbonden aan deze instructie"
        , "1 = Bedrag door de werkgever te betalen aan de RSZ
2 = Bedrag reeds door de werkgever betaald aan de RSZ
3 = Bedrag door de RSZ terug te betalen aan de werkgever
4 = Bedrag door de werkgever in mindering te brengen bij zijn eerstvolgende betaling
5 = Rekening gesaldeerd"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01022'
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
        , "Duidt aan naar waar de referentie (00222 Referentienummer) verwijst: naar deze aangifte, naar een aangifte die verwant is met deze aangifte of naar een verzameling aangiften (= een dossier) waar deze aangifte toe behoort, op deze aanvraag, op dit formulier."
        , "0 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat niet dezelfde identificatie heeft (zie bijlagen 11/302), dat verband houdt met het huidige formulier
1 = de referentie verwijst naar dit formulier
2 = de referentie is een dossiernummer en verwijst naar het dossier (= verzameling van aangiften) waartoe deze aangifte behoort of waartoe dit formulier behoort
3 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat dezelfde identificatie heeft (zie bijlagen 11/302) en dat verband houdt met dit formulier, bijvoorbeeld: de referentie heeft betrekking op de aangifte die geannuleerd moet worden door deze aangifte, of op de aangifte die vervangen moet worden door deze aangifte, of op de aangifte die gewijzigd moet worden, of op de aangifte die aan de oorsprong ligt van dit formulier...
4 = de referentie verwijst naar een aangifte in een ander scenario die verwant is met deze aangifte
5 = de referentie verwijst naar een aanvraag
6 = de referentie verwijst naar een geweigerde aangifte
7 = de referentie verwijst naar de werkgever die in deze aangifte wordt vermeld
8 = de referentie verwijst naar de werknemer die in deze aangifte wordt vermeld
9 = de referentie is een gestructureerde mededeling die moet worden gebruikt in het kader van een betaling en verwijst naar dit formulierDe enige mogelijke waarden in dit bericht zijn "1" en "9"."
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
        , "Het type wijst de aard van het elektronisch formulier aan.
"
        , "RE = REQUEST - het formulier vraagt inlichtingen
PA = PROVISIONAL ANSWER - het formulier is een tijdelijk antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
FA = FINAL ANSWER - het formulier is een definitief antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
LA = LIMITED ANSWER - het formulier is een beperkt antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
SU = SUBMISSION - het formulier deelt inlichtingen mee
De enige mogelijke waarde in dit bericht is "SU"."
        , ""
        , "Alfanumeriek"
        , "2"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00297'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01250"
        , "2023/1"
        , ""
        , "TYPE WERKGEVERSCOMPENSATIE"
        , "CompensationCode"
        , "Boekhoudkundig overzicht - Werkgeverscompensatie"
        , "Zone die aanduidt welk type compensatie de werkgever geniet."
        , "01 = Competitiviteit"
        , ""
        , "Numeriek"
        , "2"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01250'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00086"
        , "2023/1"
        , "28/02/2023"
        , "VERMINDERINGSCODE"
        , "DeductionCode"
        , "Boekhoudkundig overzicht - Verminderingscode"
        , "Code die de aangevraagde vermindering aanduidt."
        , "De codes DmfA vermeld in bijlage 4 - Lijst van de verminderingscodes."
        , ""
        , "Numeriek"
        , "4"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00086'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00727"
        , "2023/1"
        , "28/02/2023"
        , "VOORNAAM"
        , "FirstName"
        , "Gegevens van de contactpersoon"
        , "Eerste voornaam van een natuurlijk persoon. In dit bericht gaat het om de voornaam van de contactpersoon van de RSZ (Controledienst)."
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

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00036"
        , "2023/1"
        , "28/02/2023"
        , "WERKGEVERSCATEGORIE"
        , "EmployerClass"
        , "Boekhoudkundig overzicht - Verminderingscode"
        , "Het categoriekengetal laat toe een onderscheid te maken tussen de werkgevers naargelang hun verplichtingen in functie van de bijzondere kenmerken die eigen zijn aan de uitgeoefende activiteit. Het wordt toegekend door de RSZ.
Voor een provinciaal of plaatselijk bestuur bepaalt deze categorie-aanduiding de bijdrageverplichtingen van de besturen in functie van de vakantieregeling die zij op hun contractuele personeelsleden toepassen of van de pensioenregeling waarbij hun vastbenoemde personeelsleden aangesloten zijn."
        , "Getal van 3 cijfers toegekend door de RSZ.
- In het functioneel blok "BewareInformation" is de enige mogelijke waarde "021". Zij betekent dat de Beware-notificatie het resultaat is van de groepering van verbeteringen met betrekking tot de categorie 021.
- In het functioneel blok "AccountingEntry" is de enige mogelijke waarde "021". Zij betekent dat de boeking alleen betrekking heeft op elementen van categorie 021.
- In de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview" zijn alle waarden van bijlage 27 mogelijk."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar in de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview". Anders facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00036'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00036"
        , "2023/1"
        , "28/02/2023"
        , "WERKGEVERSCATEGORIE"
        , "EmployerClass"
        , "Boekhoudkundig overzicht - werknemerskengetal bijdrage"
        , "Het categoriekengetal laat toe een onderscheid te maken tussen de werkgevers naargelang hun verplichtingen in functie van de bijzondere kenmerken die eigen zijn aan de uitgeoefende activiteit. Het wordt toegekend door de RSZ.
Voor een provinciaal of plaatselijk bestuur bepaalt deze categorie-aanduiding de bijdrageverplichtingen van de besturen in functie van de vakantieregeling die zij op hun contractuele personeelsleden toepassen of van de pensioenregeling waarbij hun vastbenoemde personeelsleden aangesloten zijn."
        , "Getal van 3 cijfers toegekend door de RSZ.
- In het functioneel blok "BewareInformation" is de enige mogelijke waarde "021". Zij betekent dat de Beware-notificatie het resultaat is van de groepering van verbeteringen met betrekking tot de categorie 021.
- In het functioneel blok "AccountingEntry" is de enige mogelijke waarde "021". Zij betekent dat de boeking alleen betrekking heeft op elementen van categorie 021.
- In de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview" zijn alle waarden van bijlage 27 mogelijk."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar in de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview". Anders facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00036'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00036"
        , "2023/1"
        , "28/02/2023"
        , "WERKGEVERSCATEGORIE"
        , "EmployerClass"
        , "Boekhoudkundig overzicht - Werknemerskengetal voor een bijdrage die niet gebonden is aan een natuurlijke persoon"
        , "Het categoriekengetal laat toe een onderscheid te maken tussen de werkgevers naargelang hun verplichtingen in functie van de bijzondere kenmerken die eigen zijn aan de uitgeoefende activiteit. Het wordt toegekend door de RSZ.
Voor een provinciaal of plaatselijk bestuur bepaalt deze categorie-aanduiding de bijdrageverplichtingen van de besturen in functie van de vakantieregeling die zij op hun contractuele personeelsleden toepassen of van de pensioenregeling waarbij hun vastbenoemde personeelsleden aangesloten zijn."
        , "Getal van 3 cijfers toegekend door de RSZ.
- In het functioneel blok "BewareInformation" is de enige mogelijke waarde "021". Zij betekent dat de Beware-notificatie het resultaat is van de groepering van verbeteringen met betrekking tot de categorie 021.
- In het functioneel blok "AccountingEntry" is de enige mogelijke waarde "021". Zij betekent dat de boeking alleen betrekking heeft op elementen van categorie 021.
- In de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview" zijn alle waarden van bijlage 27 mogelijk."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar in de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview". Anders facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00036'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00036"
        , "2023/1"
        , "28/02/2023"
        , "WERKGEVERSCATEGORIE"
        , "EmployerClass"
        , "Boeking"
        , "Het categoriekengetal laat toe een onderscheid te maken tussen de werkgevers naargelang hun verplichtingen in functie van de bijzondere kenmerken die eigen zijn aan de uitgeoefende activiteit. Het wordt toegekend door de RSZ.
Voor een provinciaal of plaatselijk bestuur bepaalt deze categorie-aanduiding de bijdrageverplichtingen van de besturen in functie van de vakantieregeling die zij op hun contractuele personeelsleden toepassen of van de pensioenregeling waarbij hun vastbenoemde personeelsleden aangesloten zijn."
        , "Getal van 3 cijfers toegekend door de RSZ.
- In het functioneel blok "BewareInformation" is de enige mogelijke waarde "021". Zij betekent dat de Beware-notificatie het resultaat is van de groepering van verbeteringen met betrekking tot de categorie 021.
- In het functioneel blok "AccountingEntry" is de enige mogelijke waarde "021". Zij betekent dat de boeking alleen betrekking heeft op elementen van categorie 021.
- In de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview" zijn alle waarden van bijlage 27 mogelijk."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar in de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview". Anders facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00036'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00036"
        , "2023/1"
        , "28/02/2023"
        , "WERKGEVERSCATEGORIE"
        , "EmployerClass"
        , "Informatie van de Beware-notificatie"
        , "Het categoriekengetal laat toe een onderscheid te maken tussen de werkgevers naargelang hun verplichtingen in functie van de bijzondere kenmerken die eigen zijn aan de uitgeoefende activiteit. Het wordt toegekend door de RSZ.
Voor een provinciaal of plaatselijk bestuur bepaalt deze categorie-aanduiding de bijdrageverplichtingen van de besturen in functie van de vakantieregeling die zij op hun contractuele personeelsleden toepassen of van de pensioenregeling waarbij hun vastbenoemde personeelsleden aangesloten zijn."
        , "Getal van 3 cijfers toegekend door de RSZ.
- In het functioneel blok "BewareInformation" is de enige mogelijke waarde "021". Zij betekent dat de Beware-notificatie het resultaat is van de groepering van verbeteringen met betrekking tot de categorie 021.
- In het functioneel blok "AccountingEntry" is de enige mogelijke waarde "021". Zij betekent dat de boeking alleen betrekking heeft op elementen van categorie 021.
- In de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview" zijn alle waarden van bijlage 27 mogelijk."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar in de functionele blokken "WorkerContAccountingOverview", "DeductionAccountingOverview" en "CUNPAccountingOverview". Anders facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00036'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00037"
        , "2023/1"
        , "28/02/2023"
        , "WERKNEMERSKENGETAL"
        , "WorkerCode"
        , "Boekhoudkundig overzicht - Verminderingscode"
        , "Deze code laat toe het type werknemer te bepalen waarvoor een specifieke bijdrage vereist is (gewone bijdrage, Fedris bijdrage, bijzondere bijdrage bruggepensioneerde, bijzondere bijdrage ontslagen statutair personeel, bijzondere bijdrage student of bijzondere bijdrage aanvullende vergoedingen)."
        , "Zie bijlage 2 - Lijst der werknemerskengetallen waarvoor de bijdragen van toepassing zijn ; alleen de werknemerskengetallen waarvoor de aanwezigheid gelijk is aan 1 of 3.
Voor een provinciaal of plaatselijk bestuur, zie bijlage 28 - Lijst der werknemerskengetallen waarvoor de bijdragen van toepassing zijn PPO; alleen de werknemerskengetallen waarvoor de aanwezigheid gelijk is aan 1 of 3."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00037'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00037"
        , "2023/1"
        , "28/02/2023"
        , "WERKNEMERSKENGETAL"
        , "WorkerCode"
        , "Boekhoudkundig overzicht - werknemerskengetal bijdrage"
        , "Deze code laat toe het type werknemer te bepalen waarvoor een specifieke bijdrage vereist is (gewone bijdrage, Fedris bijdrage, bijzondere bijdrage bruggepensioneerde, bijzondere bijdrage ontslagen statutair personeel, bijzondere bijdrage student of bijzondere bijdrage aanvullende vergoedingen)."
        , "Zie bijlage 2 - Lijst der werknemerskengetallen waarvoor de bijdragen van toepassing zijn ; alleen de werknemerskengetallen waarvoor de aanwezigheid gelijk is aan 1 of 3.
Voor een provinciaal of plaatselijk bestuur, zie bijlage 28 - Lijst der werknemerskengetallen waarvoor de bijdragen van toepassing zijn PPO; alleen de werknemerskengetallen waarvoor de aanwezigheid gelijk is aan 1 of 3."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00037'
                          AND Version = '2023/1'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00082"
        , "2023/1"
        , "28/02/2023"
        , "WERKNEMERSKENGETAL BIJDRAGE"
        , "ContributionWorkerCode"
        , "Boekhoudkundig overzicht - werknemerskengetal bijdrage"
        , "Het werknemerskengetal bijdrage laat toe, in combinatie met het type bijdrage, de aangeven bijdrage te identificeren, te bepalen of de bijdrage verschuldigd is en het percentage of het forfait van de bijdrage te kennen."
        , "De werknemerskengetallen voor een gewone bijdrage, een Fedris bijdrage, een supplementaire bijdrage of een bijzondere bijdrage aanvullende vergoedingen (zie bijlage 2 ;  voor een provinciaal of plaatselijk bestuur, zie bijlage 28 - Lijst der werknemerskengetallen waarvoor de bijdragen van toepassing zijn - aanwezigheid = 2, 3 ou 5)."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00020"
        , "2023/1"
        , "28/02/2023"
        , "WERKNEMERSKENGETAL VOOR EEN BIJDRAGE DIE NIET GEBONDEN IS AAN EEN NATUURLIJKE PERSOON"
        , "UnrelatedWorkerCode"
        , "Boekhoudkundig overzicht - Werknemerskengetal voor een bijdrage die niet gebonden is aan een natuurlijke persoon"
        , "Dit werknemerskengetal laat het identificeren toe van een bijdrage die niet gebonden is aan een natuurlijke persoon maar die verschuldigd is op niveau van de werkgeverscategorie."
        , "De werknemerskengetallen die overeenstemmen met een bijdrage die niet gebonden is aan een natuurlijke persoon (zie bijlage 2 -  Lijst der werknemerskengetallen waarvoor de bijdragen van toepassing zijn)."
        , ""
        , "Numeriek"
        , "3"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00020'
                          AND Version = '2023/1'
);
