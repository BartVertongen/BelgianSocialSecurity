
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


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01144"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL BIJKOMENDE MAANDEN (CAO)"
        , "CLAAddedMonths"
        , "Collectieve arbeidsovereenkomst"
        , "Aantal bijkomende maanden voorzien in een sectoriÃ«le of ondernemings-cao die het recht van de werknemer op voltijds of halftijds tijdskrediet uitbreidt"
        , "Aantal maanden tussen [12 ; 60]"
        , ""
        , "Numeriek"
        , "2"
        , "Verplicht indien een tijdskrediet voor motief 1, 2, 3 of 4 (InterruptionType = 5001, 5002, 5003 of 5004), met uitzondering van de 1/5 onderbrekingen, wordt aangevraagd dat gereglementeerd is door de collectieve arbeidsovereenkomst nr. 103."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01144'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00975"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL UREN PER WEEK"
        , "WeekHoursNbr"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Gemiddeld aantal uren per week (uitgedrukt in honderdsten van uren) tijdens dewelke de werknemer geacht wordt arbeid uit te voeren tijdens de gevraagde onderbreking."
        , "De uren worden uitgedrukt in honderdsten van uren.\nGeheel getal gelegen tussen [0;4800].\nVoorbeelden:\n - 38 uren 20 min. wordt uitgedrukt in de vorm: 3833\n - 38 uren wordt uitgedrukt in de vorm: 3800\nVoor een werknemer in volledige loopbaanonderbreking is dit aantal gelijk aan nul.\nBij een aanvraag om vermindering van de prestaties moet de werknemer de arbeidsregeling die voortvloeit uit de gekozen breuk respecteren.\nIn de sector onderwijs, na de vermindering, al naargelang het geval, de helft of 4/5 van een voltijdse aanstelling blijven presteren."
        , ""
        , "Numeriek"
        , "4"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00975'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01055"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL WERKNEMERS"
        , "NbrOfWorkers"
        , "Informatie over de drempel van het aantal werknemers in onderbreking"
        , "Aantal werknemers in dienst bij de werkgever."
        , "Positief geheel getal en element van [0;9999999].Voor de aangiftes tijdskrediet en loopbaanonderbreking: [1; 9999999]."
        , ""
        , "Numeriek"
        , "7"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01055'
                          AND Version = '2023/1'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00996"
        , "2023/1"
        , "28/02/2023"
        , "AARD VAN DE ARBEIDSRELATIE - OVERHEIDSSECTOR"
        , "PSEmploymentRelationshipNature"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Code die de aard van de arbeidsrelatie van een werknemer uit de overheidssector aangeeft."
        , "1 : Statutair - definitief
     2 : Statutair - stagiair
     3 : Statutair - tijdelijk
     4 : Contractueel - gewoon
     5 : Contractueel - precair statuut"
        , ""
        , "Numeriek"
        , "1"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00996'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01140"
        , "2023/1"
        , "28/02/2023"
        , "ANTWOORD - LOOPBAANONDERBREKING"
        , "InterruptionQuestionAnswer"
        , "Vraag - Loopbaanonderbreking"
        , "Antwoord op de vraag betreffende de loopbaanonderbreking of het tijdskrediet"
        , "0 = Neen
     1 = Ja"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01140'
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
        , "Nummer van een brievenbus.
     "
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
SELECT "01143"
        , "2023/1"
        , "28/02/2023"
        , "CODE COLLECTIEVE ARBEIDSOVEREENKOMST"
        , "CLACode"
        , "Collectieve arbeidsovereenkomst"
        , "Code die de cao bepaalt die het recht op tijdskrediet van de werknemer reglementeert"
        , "CLA77 = Tijdskrediet gereglementeerd door de collectieve arbeidsovereenkomst nr. 77bis
     CLA103 = Tijdskrediet gereglementeerd door de collectieve arbeidsovereenkomst nr. 103
     CLA118 = Tijdskrediet eindeloopbaan gereglementeerd door de collectieve arbeidsovereenkomst nr. 118
     CLA127 = Tijdskrediet eindeloopbaan gereglementeerd door de collectieve arbeidsovereenkomst nr. 127
     CLA137 = Tijdskrediet eindeloopbaan gereglementeerd door de collectieve arbeidsovereenkomst nr. 137"
        , ""
        , "Alfanumeriek"
        , "6"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01143'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01139"
        , "2023/1"
        , "28/02/2023"
        , "CODE VRAAG - LOOPBAANONDERBREKING"
        , "InterruptionQuestionCode"
        , "Vraag - Loopbaanonderbreking"
        , "Code van de vraag met betrekking tot de loopbaanonderbreking of het tijdskrediet"
        , "Zie Bijlage LOIC001_3 - Code Vraag"
        , ""
        , "Alfanumeriek"
        , "4"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01139'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00910"
        , "2023/1"
        , "28/02/2023"
        , "DATUM BEGIN"
        , "StartingDate"
        , "Collectieve arbeidsovereenkomst"
        , "In het blok 90530 (InterruptionInformation): begindatum van de periode loopbaanonderbreking of tijdskrediet.
     In het blok 90535 (CollectiveLabourAgreement): begindatum van inwerkingtreding van de collectieve arbeidsovereenkomst."
        , "De begindatum van de onderbreking moet minstens gelijk zijn aan de datum van de kennisgeving door de werknemer (01086 - DocumentDate).
     De onderbreking mag maximaal 6 maanden na de datum van de aangifte beginnen (00218 - FormCreationDate).
     Indien een onderbreking "Thematisch verlof - mantelzorg" wordt aangevraagd, moet de begindatum van de onderbreking groter zijn dan of gelijk zijn aan 01/09/2020."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar in het blok 90530 InterruptionInformation.
     Verplicht in het blok 90535 CollectiveLabourAgreement indien het registratienummer van de CAO niet bestaat (ondernemings-cao)."
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00910'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00910"
        , "2023/1"
        , "28/02/2023"
        , "DATUM BEGIN"
        , "StartingDate"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "In het blok 90530 (InterruptionInformation): begindatum van de periode loopbaanonderbreking of tijdskrediet.
     In het blok 90535 (CollectiveLabourAgreement): begindatum van inwerkingtreding van de collectieve arbeidsovereenkomst."
        , "De begindatum van de onderbreking moet minstens gelijk zijn aan de datum van de kennisgeving door de werknemer (01086 - DocumentDate).
     De onderbreking mag maximaal 6 maanden na de datum van de aangifte beginnen (00218 - FormCreationDate).
     Indien een onderbreking "Thematisch verlof - mantelzorg" wordt aangevraagd, moet de begindatum van de onderbreking groter zijn dan of gelijk zijn aan 01/09/2020."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar in het blok 90530 InterruptionInformation.
     Verplicht in het blok 90535 CollectiveLabourAgreement indien het registratienummer van de CAO niet bestaat (ondernemings-cao)."
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00910'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00911"
        , "2023/1"
        , "28/02/2023"
        , "DATUM EINDE"
        , "EndingDate"
        , "Collectieve arbeidsovereenkomst"
        , "In het blok 90530 (InterruptionInformation): einddatum van de periode loopbaanonderbreking of tijdskrediet.
     In het blok 90535 (CollectiveLabourAgreement): einddatum van inwerkingtreding van de collectieve arbeidsovereenkomst."
        , "De einddatum van de loopbaaonderbreking moet na de begindatum van de onderbreking vallen.
     De einddatum van de geldigheidsperiode moet na de begindatum van de inwerkingtreding van de collectieve arbeidsovereenkomst vallen."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar in het blok 90530 InterruptionInformation.
     Mag aanwezig zijn in het blok 90535 CollectiveLabourAgreement als de begindatum aanwezig is in het blok."
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00911'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00911"
        , "2023/1"
        , "28/02/2023"
        , "DATUM EINDE"
        , "EndingDate"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "In het blok 90530 (InterruptionInformation): einddatum van de periode loopbaanonderbreking of tijdskrediet.
     In het blok 90535 (CollectiveLabourAgreement): einddatum van inwerkingtreding van de collectieve arbeidsovereenkomst."
        , "De einddatum van de loopbaaonderbreking moet na de begindatum van de onderbreking vallen.
     De einddatum van de geldigheidsperiode moet na de begindatum van de inwerkingtreding van de collectieve arbeidsovereenkomst vallen."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar in het blok 90530 InterruptionInformation.
     Mag aanwezig zijn in het blok 90535 CollectiveLabourAgreement als de begindatum aanwezig is in het blok."
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00911'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01142"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VAN DE OVEREENKOMST"
        , "AgreementDate"
        , "Informatie over de drempel van het aantal werknemers in onderbreking"
        , "
     Datum van de overeenkomstDatum van de overeenkomst waarmee de maximumdrempel van het aantal werknemers die gelijktijdig een tijdskrediet kunnen nemen, werd gewijzigd."
        , "De datum moet kleiner of gelijk zijn aan de begindatum van onderbreking."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien de drempel overschreden is en werd gewijzigd door de cao of door het arbeidsreglement."
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01142'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01086"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VAN HET DOCUMENT"
        , "DocumentDate"
        , "Rubriek werkgever van het aanvraagformulier op onderbreking"
        , "In dit formulier gaat het over de datum waarop de werknemer de werkgever schriftelijk heeft verwittigd dat hij een loopbaanonderbreking of een tijdskrediet wil nemen."
        , "De datum van de kennisgeving (01086 - DocumentDate) moet ten laatste op de dag van de creatie van de aangifte vallen (00218 - FormCreationDate)."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01086'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01141"
        , "2023/1"
        , "28/02/2023"
        , "DREMPEL WERKNEMERS IN TIJDSKREDIET"
        , "InterruptionWorkersThreshold"
        , "Informatie over de drempel van het aantal werknemers in onderbreking"
        , "Zone die preciseringen geeft over de drempel van werknemers in tijdskrediet"
        , "1 = De afwijkende drempel die juridisch gezien is vastgelegd, wordt overschreden
     2 = De drempel van 5% is overschreden en werd gewijzigd door de cao of door het arbeidsreglement
     3 = De drempel van 5% wordt overschreden
     4 = De drempel van 5% wordt niet overschreden
     9 = De onderneming telt maximum 10 werknemers"
        , ""
        , "Numeriek"
        , "2"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01141'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01225"
        , "2023/1"
        , "28/02/2023"
        , "DUUR"
        , "Duration"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Duur van de cyclus tijdens dewelke de arbeidsregeling vast is of duur van de referteperiode van de variabele arbeidsregeling."
        , "Geheel getal en element van [1; 99]"
        , ""
        , "Numeriek"
        , "3"
        , "Verplicht indien het een gedeeltelijke onderbreking betreft.
     Verboden indien het een voltijds onderbreking betreft."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01225'
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
        , "Onmisbaar "
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
        , "Naam van een gemeente.
     "
        , ""
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
SELECT "00049"
        , "2023/1"
        , "28/02/2023"
        , "GEMIDDELD AANTAL UREN PER WEEK VAN DE MAATPERSOON"
        , "RefMeanWorkingHours"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Gemiddeld aantal uren per week (uitgedrukt in honderdsten van uren) tijdens dewelke de maatpersoon verondersteld wordt arbeid te verrichten.
     Het gaat om het aantal uren per week van een persoon die voltijds tewerkgesteld is in dezelfde onderneming, of, bij gebrek hieraan, in dezelfde activiteitstak, in een functie analoog.
     Het gemiddeld aantal uren per week van de werknemer gedeeld door het gemiddeld aantal uren per week van de maatpersoon bepaalt de prestatiebreuk van de werknemer."
        , "[1;4800]voor alle werknemers, met uitzondering van de hierna vermelde.
     [1;5000] voor een thuiswerker - onthaalouder - Vlaamse Gemeenschap (werknemersstatuut = D1).
     [1;6000] voor een geneesheer-specialist in opleiding vanaf 2022/4 (werkgeverscategorien 072, 272, 372 of 772) of voor een thuiswerker - onthaalouder - Franse Gemeenschap (werknemersstatuut = D2).
     3800 voor een federaal / regionaal parlements- of regeringslid of een lokale mandataris.
     Aandacht : De uren worden uitgedrukt in honderdsten van uren.
     Voorbeelden: 
     . 38 uren 20 min. wordt uitgedrukt onder de vorm : 3833
     . 38 uren wordt uitgedrukt onder de vorm : 3800
     Voor een onthaalouder moet het gemiddelde aantal uren per week van de maatpersoon altijd gelijk zijn aan 38 uur per week (3800)In deze aangifte moet het gemiddelde aantal uren per week van de maatpersoon een waarde tussen [100; 4800] hebben."
        , ""
        , "Numeriek"
        , "4"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00049'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00048"
        , "2023/1"
        , "28/02/2023"
        , "GEMIDDELD AANTAL UREN PER WEEK VAN DE WERKNEMER"
        , "MeanWorkingHours"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Gemiddeld aantal uren per week (uitgedrukt in honderdsten van uren) tijdens dewelke de werknemer geacht wordt arbeid uit te voeren overeenkomstig zijn arbeidsovereenkomst, een eventuele schorsing van de overeenkomst buiten beschouwing gelaten.
     Het gemiddeld aantal uren per week van de werknemer gedeeld door het gemiddeld aantal uren per week van de maatpersoon bepaalt de prestatiebreuk van de werknemer.
     Onder maatpersoon verstaan we de persoon die voltijds tewerkgesteld is in dezelfde onderneming, of, bij gebrek hieraan, in dezelfde activiteitstak, in een functie analoog aan die van de werknemer.In dit formulier gaat het om het aantal uren dat de werknemer per week werkte vï¿½ï¿½r de aanvraag om loopbaanonderbreking of tijdskrediet."
        , "[1;4800] voor alle werknemers, met uitzondering van de hierna vermelde. 
     0 indien de werknemer in volledige loopbaanonderbreking is of als het gaat om een statutaire werknemer tewerkgesteld in het kader van een maatregel tot reorganisatie van de arbeidstijd waarvoor hij geen enkele prestatie verricht (maatregel tot reorganisatie = 513, 516, 517, 542, 543, 545, 546 of 599).
     [0;4800] voor een werknemer die in de loop van de periode waarop de aangifte betrekking heeft, geen enkele prestatie heeft moeten leveren (verantwoording van de dagen = 7) of als het gaat om een statutaire werknemer tewerkgesteld in het kader van een maatregel tot reorganisatie van de arbeidstijd waarvoor hij prestaties mag verrichten (maatregel tot reorganisatie = 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 515, 531, 541 of 544).
     [0;5000] voor een thuiswerker - onthaalouder - Vlaamse Gemeenschap (werknemersstatuut = D1).
     [0;6000] voor een geneesheer-specialist in opleiding vanaf 2022/4 (werkgeverscategorien 072, 272, 372 of 772) of voor een thuiswerker - onthaalouder - Franse Gemeenschap (werknemersstatuut = D2).
     3800 voor een federaal / regionaal parlements- of regeringslid of een lokale mandataris die prestaties levert.
     Indien het aantal dagen per week van de arbeidsregeling gelijk is aan nul, moet het gemiddeld aantal uren per week van de werknemer gelijk zijn aan nul, en omgekeerd.
     Aandacht : De uren worden uitgedrukt in honderdsten van uren.
     Voorbeelden : 
     . 38 uren 20 min. wordt uitgedrukt onder de vorm : 3833
     . 38 uren wordt uitgedrukt onder de vorm : 3800In deze aangifte moet het gemiddelde aantal uren per week van de werknemer een waarde tussen [100; 4800] hebben."
        , ""
        , "Numeriek"
        , "4"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00048'
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
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Facultatief .
     Een telefoonnummer of een Gsm-nummer is verplicht."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00636'
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
        , "Code die toelaat een land te identificeren.
     "
        , "Zie Bijlage 5 - Lijst met landcodes.
     "
        , ""
        , "Numeriek"
        , "5"
        , "Onmisbaar "
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
        , "Familienaam van een natuurlijk persoon.
     Men moet de naam vermelden die op het paspoort of de identiteitskaart staat.
     Voor vrouwen van Belgische nationaliteit gaat het om de meisjesnaam.
     "
        , ""
        , ""
        , "Alfanumeriek"
        , "48"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00726'
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
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00518'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00046"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN PARITAIR COMITï¿½"
        , "JointCommissionNbr"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Nummer van het paritair comitï¿½ waaronder de werknemer valt in het kader van de aangegeven tewerkstelling of op het moment waarop de aanvullende vergoeding voor het eerst werd toegekend.
     "
        , "- CCC : De paritaire comitï¿½s ; reeks van 3 cijfers, links uitgelijnd. 
     - CCC.CC : De paritaire subcomitï¿½s ; reeks van 3 cijfers gevolgd door een punt en 2 cijfers, links uitgelijnd.
     - CCC.CC.CC : De paritaire sub-subcomitï¿½s ;  reeks van 3 cijfers gevolgd door een punt en 2 cijfers nogmaals gevolgd door een punt en 2 cijfers.
     - Als de werknemer onder geen enkel paritair comitï¿½ of subcomitï¿½ of sub-subcomitï¿½ valt, dan is de in te vullen waarde 999.
     "
        , ""
        , "Alfanumeriek"
        , "9"
        , "Onmisbaar "
        , "CCC of CCC.CC of CCC.CC.CC"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00046'
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
        , ""
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
SELECT "01137"
        , "2023/1"
        , "28/02/2023"
        , "REGELING VAN DE ONDERBREKING"
        , "InterruptionRegime"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Regeling van de loopbaanonderbreking of het tijdskrediet"
        , "1 = Voltijds
     2 = Halftijds
     3 = 1/3-tijds
     4 = 1/4-tijds
     5 = 1/5-tijds
     10 = 1/10-tijds"
        , ""
        , "Numeriek"
        , "2"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01137'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00740"
        , "2023/1"
        , "28/02/2023"
        , "REGISTRATIENUMMER VAN DE CAO"
        , "CLARegistrationNbr"
        , "Collectieve arbeidsovereenkomst"
        , "Nummer waaronder de CAO geregistreerd staat bij de griffie van de dienst Collectieve Arbeidsbetrekkingen van de FOD Werkgelegenheid, Arbeid en Sociaal Overleg
     Aan de hand van het registratienummer kunnen op meta.fgov.be de sectoriï¿½le CAO's worden geconsulteerd. In dit geval moet de werknemer geen kopie meer indienen van de CAO. Registratienummer van de sectoriï¿½le CAO die het mogelijk maakt 
     - in functie van de bepalingen van CAO 103 het recht op halftijds of voltijds tijdskrediet met motief uit te breiden
     - in functie van de bepalingen van CAO nr. 118 of CAO nr. 127 het recht op het tijdskrediet met uitkeringen vï¿½ï¿½r de wettelijke leeftijd te openen."
        , "Geheel getal van 5 of 6 posities."
        , ""
        , "Numeriek"
        , "6"
        , "Verplicht indien het een sectoriï¿½le CAO betreft."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00740'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01138"
        , "2023/1"
        , "28/02/2023"
        , "SECTORCODE - LOOPBAANONDERBREKING OF TIJDSKREDIET"
        , "InterruptionSectorCode"
        , "Rubriek werkgever van het aanvraagformulier op onderbreking"
        , "Code die aangeeft tot welke sector de werkgever van de werknemer voor wie de loopbaanonderbreking of het tijdskrediet wordt aangevraagd behoort."
        , "Zie Bijlage LOIC001_2 - Sectorcode"
        , ""
        , "Alfanumeriek"
        , "2"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01138'
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
        , "Openbare weg.
     "
        , ""
        , ""
        , "Alfanumeriek"
        , "42"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00517'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00156"
        , "2023/1"
        , "28/02/2023"
        , "TAALKEUZE PDF"
        , "LanguageCodePdf"
        , "Informatie van de aangifte"
        , "De keuze van de taal van het afdrukbare document (pdf)."
        , "1 = Nederlands
     2 = Frans
     3 = Duits"
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00156'
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
        , ""
        , ""
        , ""
        , "Alfanumeriek"
        , "20"
        , "Facultatief .
     Een telefoonnummer of een Gsm-nummer is verplicht."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00677'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01226"
        , "2023/1"
        , "28/02/2023"
        , "TIJDSEENHEID"
        , "TimeUnit"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Code die een tijdseenheid aanduidt.
     Tijdseenheid van de cyclus tijdens dewelke de arbeidsregeling vast is of tijdseenheid van de referteperiode waarin de arbeidsregeling variabel is."
        , "1 = uur
     2 = dag
     3 = week
     4 = maand
     5 = kwartaal
     6 = jaar
     Enkel de waarden 2, 3 en 4 zijn toegelaten voor dit formulier."
        , ""
        , "Numeriek"
        , "1"
        , "Verplicht indien het een gedeeltelijke onderbreking betreft.
     Verboden indien het een voltijds onderbreking betreft."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01226'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01224"
        , "2023/1"
        , "28/02/2023"
        , "TYPE ARBEIDSREGELING"
        , "WorkingSystemType"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Het gaat om het type van de arbeidsregeling (regeling over de arbeidsduur) gezien de onderbroken uren voor de loopbaanonderbreking of het tijdskrediet."
        , "F = Vaste arbeidsregeling
     V = Variabel arbeidsregeling"
        , ""
        , "Alfanumeriek"
        , "1"
        , "Verplicht indien het een gedeeltelijke onderbreking betreft.
     Verboden indien het een voltijds onderbreking betreft."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01224'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01136"
        , "2023/1"
        , "28/02/2023"
        , "TYPE ONDERBREKING"
        , "InterruptionType"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Type loopbaanonderbreking of tijdskrediet"
        , "Zie Bijlage LOIC001_1 -Type onderbreking"
        , ""
        , "Numeriek"
        , "4"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01136'
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
        , "Eerste voornaam van een natuurlijk persoon.
     "
        , ""
        , ""
        , "Alfanumeriek"
        , "24"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00727'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00096"
        , "2023/1"
        , "28/02/2023"
        , "WETTELIJKE BASIS"
        , "LegalBasis"
        , "Informatie over de loopbaanonderbreking of het tijdskrediet"
        , "Code die verwijst naar een wettelijke bepaling.Vermelding van de wettelijke bepaling waarop de onderbreking gebaseerd is."
        , "1 = Herstructureringsplan goedgekeurd door de Minister van Werk. Art. 29, ï¿½ 2, 1ï¿½, d van het KB van 25.11.1991.

     2 = Bedrijfsplan tot herverdeling van de arbeid in de privÃ©sector gesloten in overeenstemming met de bepalingen van titel IV van het KB van 24.12.1993 tot uitvoering van de wet van 06.01.1989 tot vrijwaring van 's lands concurrentievermogen.

     3 = Tewerkstellingsakkoord voor de periode 1995-1996 gesloten in overeenstemming met de bepalingen van de wet van 03.04.1995 houdende maatregelen ter bevordering van de tewerkstelling, en met de bepalingen van de collectieve arbeidsovereenkomst nr. 60 van 20.12.1994 gesloten in de Nationale Arbeidsraad.

     4 = Tewerkstellingsakkoord voor de periode 1997-1998 gesloten in overeenstemming met de bepalingen van het KB van 24.02.1997 houdende nadere voorwaarden met betrekking tot de tewerkstellingsakkoorden in toepassing van de artikelen 7, ï¿½ 2, 30, ï¿½ 2, en 33 van de wet van 26.07.1996 tot bevordering van de werkgelegenheid en tot preventieve vrijwaring van het concurrentievermogen.

     5 = cao met arbeidsduurvermindering in ondernemingen in moeilijkheden en in herstructurering ("het defensieve plan Vande Lanotte"), overeenkomstig de bepalingen van artikel 9, ï¿½ 1 van voornoemd KB van 24.02.1997.

     6 = cao met arbeidsduurvermindering in een aantal andere ondernemingen ("het offensieve plan Vande Lanotte") afgesloten in overeenstemming met de bepalingen van het KB van 24.11.1997, gewijzigd door de wet van 26.03.1999 en opgeheven bij wet van 10.08.2001.

     7 = Bedrijfsplan tot herverdeling van de arbeid in de openbare sector dat beantwoordt aan de bepalingen bedoeld in de wet van 10.04.1995 betreffende de herverdeling van de arbeid in de openbare sector.

     8 = cao nr 103 - oude reglementering (collectieve arbeidsovereenkomst nr 103 tot invoering van een stelsel van tijdskrediet, loopbaanvermindering en landingsbanen, gesloten in de NAR op 27.06.2012, KB 25.08.2012).

     9 = cao nr 103 - nieuwe reglementering (KB van 30.12.014).

     10 = cao nr 103ter (datum van de kennisgeving vanaf 01/04/2017).In dit formulier worden alleen de waarden 8, 9 en 10 toegelaten."
        , ""
        , "Numeriek"
        , "2"
        , "Verplicht indien een tijdskrediet wordt aangevraagd."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00096'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00126"
        , "2023/1"
        , "28/02/2023"
        , "ZONE VRIJE TEKST"
        , "CommentOfDeclaration"
        , "Commentaar bij de aangifte"
        , "Deze zone laat toe alle informatie toe te voegen die noodzakelijk is voor dit formulier."
        , ""
        , ""
        , "Alfanumeriek"
        , "200"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00126'
                          AND Version = '2023/1'
);
        