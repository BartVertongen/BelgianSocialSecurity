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
SELECT "01017"
        , "2023/2"
        , "25/05/2023"
        , "AANTAL GEPLANDE DAGEN"
        , "PlannedDaysNbr"
        , "Dimona IN aangifte"
        , "Aantal werkdagen die de werkgever heeft gepland in de aangegeven Dimona-periode."
        , "Geheel getal en element van [0,999]In dit bericht : Geheel getal en element van [1,999]"
        , ""
        , "Numeriek"
        , "3"
        , "Verplicht indien de aangifte werd ingediend voor het type werknemer 'STU' en een periode tot en met 31/12/2016.\nVerboden voor de andere types werknemer of voor een periode na 31/12/2016 (exclusief).
          "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01017'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01017"
        , "2023/2"
        , "25/05/2023"
        , "AANTAL GEPLANDE DAGEN"
        , "PlannedDaysNbr"
        , "Dimona wijziging aangifte"
        , "Aantal werkdagen die de werkgever heeft gepland in de aangegeven Dimona-periode."
        , "Geheel getal en element van [0,999]In dit bericht : Geheel getal en element van [1,999]"
        , ""
        , "Numeriek"
        , "3"
        , "Verplicht indien de aangifte werd ingediend voor het type werknemer 'STU' en een periode tot en met 31/12/2016.\nVerboden voor de andere types werknemer of voor een periode na 31/12/2016 (exclusief)"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01017'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01135"
        , "2023/2"
        , "25/05/2023"
        , "AANTAL GEPLANDE UREN"
        , "PlannedHoursNbr"
        , "Dimona IN aangifte"
        , "Aantal werkuren die de werkgever heeft gepland in de aangegeven Dimona-periode."
        , "Geheel getal en element van [1,999]"
        , ""
        , "Numeriek"
        , "3"
        , "Verplicht indien de aangifte uitgevoerd werd voor de types werknemer 'STU', 'O17' en 'S17'. Verboden voor de andere types werknemer."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01135'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01135"
        , "2023/2"
        , "25/05/2023"
        , "AANTAL GEPLANDE UREN"
        , "PlannedHoursNbr"
        , "Dimona wijziging aangifte"
        , "Aantal werkuren die de werkgever heeft gepland in de aangegeven Dimona-periode."
        , "Geheel getal en element van [1,999]"
        , ""
        , "Numeriek"
        , "3"
        , "Verplicht indien de aangifte uitgevoerd werd voor de types werknemer 'STU', 'O17' en 'S17'. Verboden voor de andere types werknemer."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01135'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01254"
        , "2023/2"
        , "25/05/2023"
        , "AANTAL OPEENVOLGENDE DAGCONTRACTEN"
        , "DailyContractNbr"
        , "Gebruikende onderneming"
        , "Aantal opeenvolgende dagcontracten gepresteerd door een student uitzendkracht bij eenzelfde gebruikende onderneming.Deze zone wordt nooit gebruikt wanneer het een Dimona-aangifte is."
        , "[0;999]"
        , ""
        , "Numeriek"
        , "3"
        , "Verboden "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01254'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00655"
        , "2023/2"
        , "25/05/2023"
        , "AARD WERKNEMER"
        , "WorkerType"
        , "Dimona karakteristieken"
        , "Deze zone laat toe het type werknemer te preciseren."
        , "A17 (Artikel 17) = specifieke werknemerscategorie (animator, monitor, sportmanifestatie...) (! Opgelet : vanaf het kwartaal 2022/1 is het niet langer mogelijk om aangiften voor dit type werknemer in te dienen)\nALT (alternerende opleiding) = leerling in alternerende opleiding (vanaf 1 september 2023)\nBCW (Build & Construction Worker) = werknemer in de bouwsector (met uitzondering van IVT, RTA, STU en DWD)\nDWD (Dimona without DmfA) = werknemer niet onderworpen aan bijdragen\nEXT (Extra worker) = gelegenheidswerknemer\nFLX (Flexi-Job) = werknemer die geniet van een flexiloon\nIVT (Individual Vocational Training) = individuele beroepsopleiding\nO17 (Artikel 17) = specifieke categorie van werknemers van de socio-culturele sector en andere (vanaf 2022/1)\nPMP (Parlementair mandaat) = Federaal / regionaal parlements- of regeringslid\nQUA (Quarantaine) = gelegenheidswerknemer in quarantaine (! Opgelet, vanaf 1 januari 2023 is het niet meer mogelijk een aangifte in te voeren van dit type werknemer)\nRTA (Registered Trainees or Assimilated) = erkende leerling of gelijkgestelde in de bouwsector\nS17 (Artikel 17) = specifieke categorie van werknemers van de sportsector (vanaf 2022/1)\nSTG (Stagiair) = stagiair arbeidsongevallenregeling\nSTU (Student) = student\nSTX (Student extra) = gelegenheidswerknemer student (! Opgelet, vanaf het kwartaal 2014/1 is het niet meer mogelijk een aangifte in te voeren van dit type werknemer)\nT17 (Artikel 17) = specifieke categorie van werknemers van de openbare TV (vanaf 2022/1)\nTEA (Teacher) = personeel van de onderwijsinstellingen (code E in DmfAPPL). Code afgeschaft vanaf het kwartaal 1/2022).\nTRI (Transition Internship) = instapstage\nOTH = andereVoor aangiften met betrekking tot een provinciaal of plaatselijk bestuur voor de periode t.e.m. 31/12/2021 zijn enkel de volgende waarden toegelaten : A17, IVT, STU, TEA, TRI, DWD, STG en OTH.\nZoniet zijn alle waarden toegelaten behalve TEA."
        , ""
        , "Alfanumeriek"
        , "3"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00655'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00041"
        , "2023/2"
        , "25/05/2023"
        , "ACTIVITEIT TEN OPZICHTE VAN HET RISICO"
        , "ActivityWithRisk"
        , "Kleine statuten - Informatie"
        , "Code die verwijst naar de nomenclatuur van de generieke risicoklassen gebruikt door de verzekeringsondernemingen om de premies inzake Arbeidsongevallen (AO) te bepalen.\nDe precieze aangiftevoorwaarden worden vermeld in het document met de DMFA-onderrichtingen ten behoeve van de werkgevers.\nEen activiteit wordt meegedeeld op het niveau van een werknemer als zij afwijkt van het hoofddoel van de onderneming en wanneer de facto een bijzondere tarifering voorzien is in de verzekeringspolis Arbeidsongevallen.\nAls de risicoklasse van de werknemer waarop de aangifte betrekking heeft, verandert in de loop van het kwartaal, dan dient men de risicoklasse aan te geven geldig op de laatste dag van het kwartaal of op de laatste dag van tewerkstelling voor het aangegeven statuut.\nZo zal de 'arbeider zonder verplaatsingen' die 'arbeider op de werf' wordt, gekend zijn als een 'arbeider op de werf'.\nEen 'arbeider zonder verplaatsingen' die een 'bediende zonder verplaatsingen' wordt, zal gekend zijn als 'arbeider zonder verplaatsingen' voor de aangifte als arbeider en als 'bediende zonder verplaatsingen' voor de aangifte als bediende.\nZij is eveneens nodig wanneer het een sportbeoefenaar betreft. Zij dient dan ook voor de berekening van het basisloon.\n"
        , "De lijst met de toegelaten waarden bevindt zich in bijlage 6 - Activiteit in verband met het risico."
        , ""
        , "Numeriek"
        , "3"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00041'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00776"
        , "2023/2"
        , "25/05/2023"
        , "BENAMING"
        , "Denomination"
        , "Plaats van tewerkstelling van de student"
        , "Naam van de onderneming of agentschap van de werkplaats van de student indien hij niet op de hoofdzetel werkt."
        , ""
        , ""
        , "Alfanumeriek"
        , "96"
        , "Verplicht indien het type werknemer 'STU' is, en indien de werkplaats van de student niet de hoofdzetel van de onderneming is."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00776'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00153"
        , "2023/2"
        , "25/05/2023"
        , "BENAMING VAN DE GEBRUIKENDE ONDERNEMING"
        , "UsingEmployerName"
        , "Gebruikende onderneming"
        , "Naam en voornaam van de gebruiker indien het een natuurlijke persoon is. Benaming van de onderneming indien het een rechtspersoon is."
        , ""
        , ""
        , "Alfanumeriek"
        , "96"
        , "Verplicht indien de zone 00046 (Paritair comité) van het FB 90374 (Dimona karakteristieken) gelijk is aan '322' en indien het ondernemingsnummer van de gebruikende onderneming (zone 00131) niet aanwezig is.\nVerboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00153'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00519"
        , "2023/2"
        , "25/05/2023"
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
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00032"
        , "2023/2"
        , "25/05/2023"
        , "BRIEVENBUS VAN DE WERKNEMER"
        , "WorkerPostBox"
        , "Natuurlijke persoon"
        , "Nummer van een brievenbus. Busnummer in het adres van de werknemer."
        , ""
        , ""
        , "Alfanumeriek"
        , "4"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00032'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01185"
        , "2023/2"
        , "25/05/2023"
        , "BTW-NUMMER"
        , "VATNbr"
        , "Gebruikende onderneming"
        , "BTW-nummer dat op eenduidige wijze een onderneming identificeert.Deze zone wordt nooit gebruikt wanneer het een Dimona-aangifte is."
        , "De posities 1 en 2 komen overeen met de prefix van het vestigingsland van de onderneming.\nDe posities 3 tot 30 bestaan uit cijfers en/of letters.\nMerk op dat de structuur van een intracommunautair BTW-nummer anders is voor elke EU-lidstaat."
        , ""
        , "Alfanumeriek"
        , "30"
        , "Verboden"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01185'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00663"
        , "2023/2"
        , "25/05/2023"
        , "C3.2A- KAARTNUMMER VAN DE MAAND WAARIN DE DIMONAPERIODE BEGINT"
        , "FirstMonthC32ANbr"
        , "Controlekaarten voor de bouwsector"
        , "Nummer van de controlekaart C3.2A die werd toegekend aan de werknemer voor de maand waarin zijn Dimonaperiode begint."
        , ""
        , ""
        , "Numeriek"
        , "12"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00663'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00664"
        , "2023/2"
        , "25/05/2023"
        , "C3.2A-KAARTNUMMER VAN DE MAAND DIE VOLGT OP DE MAAND WAARIN DE DIMONAPERIODE BEGINT"
        , "NextMonthC32ANbr"
        , "Controlekaarten voor de bouwsector"
        , "Nummer van de controlekaart C3.2A die werd toegekend aan de werknemer voor de maand die volgt op de maand waarin zijn Dimonaperiode begint."
        , ""
        , ""
        , "Numeriek"
        , "12"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00664'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00910"
        , "2023/2"
        , "25/05/2023"
        , "DATUM BEGIN"
        , "StartingDate"
        , "Aangifte dagelijkse registratie"
        , "Begindatum van de Dimonaperiode of van de dagelijkse registratie."
        , "De begindatum van de Dimonaperiode moet vroeger vallen dan het lopende jaar + 10 jaar en later of gelijktijdig dan 1920-01-01.\nEen aangifte voor een werknemer van het type FLX (Flexi-job) kan niet meer dan 31 dagen voor het begin van het kwartaal van indiensttreding gedaan worden.\nIn het geval van een aangifte voor een werknemer van type A17 (artikel 17) kan de aanvangsdatum niet na 2021 liggen.\nIn het geval van een aangifte voor een werknemer van het type O17, S17 of T17 (artikel 17) kan de datum van indiensttreding niet vóór 2022 liggen en mag de aangifte niet meer dan 15 dagen voor het begin van de indiensttreding worden ingediend."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het formulier betrekking heeft op een Dimona-aangifte IN of een aangifte creatie dagelijkse registratie.\nFacultatief indien het een wijzigende Dimona-aangifte of een aangifte wijziging dagelijkse registratie is.\nVerboden als het een wijzigende Dimona-aangifte voor het werknemerstype 'STU' is waarvan de begindatum strikt na 31/12/2016 valt.\nVerboden in de andere gevallen."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00910'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00910"
        , "2023/2"
        , "25/05/2023"
        , "DATUM BEGIN"
        , "StartingDate"
        , "Dimona IN aangifte"
        , "Begindatum van de Dimonaperiode of van de dagelijkse registratie."
        , "De begindatum van de Dimonaperiode moet vroeger vallen dan het lopende jaar + 10 jaar en later of gelijktijdig dan 1920-01-01.\nEen aangifte voor een werknemer van het type FLX (Flexi-job) kan niet meer dan 31 dagen voor het begin van het kwartaal van indiensttreding gedaan worden.\nIn het geval van een aangifte voor een werknemer van type A17 (artikel 17) kan de aanvangsdatum niet na 2021 liggen.\nIn het geval van een aangifte voor een werknemer van het type O17, S17 of T17 (artikel 17) kan de datum van indiensttreding niet vóór 2022 liggen en mag de aangifte niet meer dan 15 dagen voor het begin van de indiensttreding worden ingediend."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het formulier betrekking heeft op een Dimona-aangifte IN of een aangifte creatie dagelijkse registratie.\nFacultatief indien het een wijzigende Dimona-aangifte of een aangifte wijziging dagelijkse registratie is.\nVerboden als het een wijzigende Dimona-aangifte voor het werknemerstype 'STU' is waarvan de begindatum strikt na 31/12/2016 valt.\nVerboden in de andere gevallen."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00910'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00910"
        , "2023/2"
        , "25/05/2023"
        , "DATUM BEGIN"
        , "StartingDate"
        , "Dimona wijziging aangifte"
        , "Begindatum van de Dimonaperiode of van de dagelijkse registratie."
        , "De begindatum van de Dimonaperiode moet vroeger vallen dan het lopende jaar + 10 jaar en later of gelijktijdig dan 1920-01-01.\nEen aangifte voor een werknemer van het type FLX (Flexi-job) kan niet meer dan 31 dagen voor het begin van het kwartaal van indiensttreding gedaan worden.\nIn het geval van een aangifte voor een werknemer van type A17 (artikel 17) kan de aanvangsdatum niet na 2021 liggen.\nIn het geval van een aangifte voor een werknemer van het type O17, S17 of T17 (artikel 17) kan de datum van indiensttreding niet vóór 2022 liggen en mag de aangifte niet meer dan 15 dagen voor het begin van de indiensttreding worden ingediend."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het formulier betrekking heeft op een Dimona-aangifte IN of een aangifte creatie dagelijkse registratie.\nFacultatief indien het een wijzigende Dimona-aangifte of een aangifte wijziging dagelijkse registratie is.\nVerboden als het een wijzigende Dimona-aangifte voor het werknemerstype 'STU' is waarvan de begindatum strikt na 31/12/2016 valt.\nVerboden in de andere gevallen."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00910'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00911"
        , "2023/2"
        , "25/05/2023"
        , "DATUM EINDE"
        , "EndingDate"
        , "Aangifte dagelijkse registratie"
        , "Einddatum van de Dimonaperiode of van de dagelijkse registratie. Om aan te geven dat de Dimonaperiode dat men wenst te wijzigen opnieuw geopend moet worden (zonder einddatum), moet de waarde 9999-12-31 gebruikt worden."
        , "De einddatum moet vroeger vallen dan het lopende jaar + 10 jaar en later of gelijktijdig dan 1999-01-01. De waarde 9999-12-31 wordt enkel toegestaan in een wijzigende Dimona-aangifte.\nVoor een Dimona Horeca met dagforfait, een Dimona Artikel 17 (de type A17 of T17) of een Dimona gelegenheidswerknemer in quarantaine moet de einddatum gelijk zijn aan de begindatum.\nVoor een student (type werknemer = STU) of een Artikel 17 (type werknemer = O17 of S17) moet de einddatum in hetzelfde trimester vallen als de begindatum.\nOm een Dimona voor een Flexi-Job te doen per periode moet de einddatum altijd na de begindatum liggen."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het formulier betrekking heeft op:\n- een Dimona-aangifte OUT\n- of het een Dimona-aangifte IN is van een uitzendkracht (Paritair comitï¿½ = 322), van een gelegenheidswerknemer (Type werknemer = EXT), een student (Type werknemer = STU), een persoon in een beroepsopleiding (Type werknemer = IVT), een persoon in en instapstage (Type werknemer = TRI) of een stagiair (Type werknemer = STG) of een Artikel 17 (Type werknemer = A17, O17, S17 of T17).\n- of een aangifte creatie dagelijkse registratie.\nVerboden in het geval van een aangifte annulatie dagelijkse registratie.\nFacultatief in de andere gevallen."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00911'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00911"
        , "2023/2"
        , "25/05/2023"
        , "DATUM EINDE"
        , "EndingDate"
        , "Dimona IN aangifte"
        , "Einddatum van de Dimonaperiode of van de dagelijkse registratie. Om aan te geven dat de Dimonaperiode dat men wenst te wijzigen opnieuw geopend moet worden (zonder einddatum), moet de waarde 9999-12-31 gebruikt worden."
        , "De einddatum moet vroeger vallen dan het lopende jaar + 10 jaar en later of gelijktijdig dan 1999-01-01. De waarde 9999-12-31 wordt enkel toegestaan in een wijzigende Dimona-aangifte.\nVoor een Dimona Horeca met dagforfait, een Dimona Artikel 17 (de type A17 of T17) of een Dimona gelegenheidswerknemer in quarantaine moet de einddatum gelijk zijn aan de begindatum.\nVoor een student (type werknemer = STU) of een Artikel 17 (type werknemer = O17 of S17) moet de einddatum in hetzelfde trimester vallen als de begindatum.\nOm een Dimona voor een Flexi-Job te doen per periode moet de einddatum altijd na de begindatum liggen."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het formulier betrekking heeft op:\n- een Dimona-aangifte OUT\n- of het een Dimona-aangifte IN is van een uitzendkracht (Paritair comité = 322), van een gelegenheidswerknemer (Type werknemer = EXT), een student (Type werknemer = STU), een persoon in een beroepsopleiding (Type werknemer = IVT), een persoon in en instapstage (Type werknemer = TRI) of een stagiair (Type werknemer = STG) of een Artikel 17 (Type werknemer = A17, O17, S17 of T17).\n- of een aangifte creatie dagelijkse registratie.\nVerboden in het geval van een aangifte annulatie dagelijkse registratie.\nFacultatief in de andere gevallen."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00911'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00911"
        , "2023/2"
        , "25/05/2023"
        , "DATUM EINDE"
        , "EndingDate"
        , "Dimona OUT aangifte"
        , "Einddatum van de Dimonaperiode of van de dagelijkse registratie. Om aan te geven dat de Dimonaperiode dat men wenst te wijzigen opnieuw geopend moet worden (zonder einddatum), moet de waarde 9999-12-31 gebruikt worden."
        , "De einddatum moet vroeger vallen dan het lopende jaar + 10 jaar en later of gelijktijdig dan 1999-01-01. De waarde 9999-12-31 wordt enkel toegestaan in een wijzigende Dimona-aangifte.\nVoor een Dimona Horeca met dagforfait, een Dimona Artikel 17 (de type A17 of T17) of een Dimona gelegenheidswerknemer in quarantaine moet de einddatum gelijk zijn aan de begindatum.\nVoor een student (type werknemer = STU) of een Artikel 17 (type werknemer = O17 of S17) moet de einddatum in hetzelfde trimester vallen als de begindatum.\nOm een Dimona voor een Flexi-Job te doen per periode moet de einddatum altijd na de begindatum liggen."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het formulier betrekking heeft op:\n- een Dimona-aangifte OUT\n- of het een Dimona-aangifte IN is van een uitzendkracht (Paritair comité = 322), van een gelegenheidswerknemer (Type werknemer = EXT), een student (Type werknemer = STU), een persoon in een beroepsopleiding (Type werknemer = IVT), een persoon in en instapstage (Type werknemer = TRI) of een stagiair (Type werknemer = STG) of een Artikel 17 (Type werknemer = A17, O17, S17 of T17).\n- of een aangifte creatie dagelijkse registratie.\nVerboden in het geval van een aangifte annulatie dagelijkse registratie.\nFacultatief in de andere gevallen."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00911'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00911"
        , "2023/2"
        , "25/05/2023"
        , "DATUM EINDE"
        , "EndingDate"
        , "Dimona wijziging aangifte"
        , "Einddatum van de Dimonaperiode of van de dagelijkse registratie. Om aan te geven dat de Dimonaperiode dat men wenst te wijzigen opnieuw geopend moet worden (zonder einddatum), moet de waarde 9999-12-31 gebruikt worden."
        , "De einddatum moet vroeger vallen dan het lopende jaar + 10 jaar en later of gelijktijdig dan 1999-01-01. De waarde 9999-12-31 wordt enkel toegestaan in een wijzigende Dimona-aangifte.\nVoor een Dimona Horeca met dagforfait, een Dimona Artikel 17 (de type A17 of T17) of een Dimona gelegenheidswerknemer in quarantaine moet de einddatum gelijk zijn aan de begindatum.\nVoor een student (type werknemer = STU) of een Artikel 17 (type werknemer = O17 of S17) moet de einddatum in hetzelfde trimester vallen als de begindatum.\nOm een Dimona voor een Flexi-Job te doen per periode moet de einddatum altijd na de begindatum liggen."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het formulier betrekking heeft op:\n- een Dimona-aangifte OUT\n- of het een Dimona-aangifte IN is van een uitzendkracht (Paritair comité = 322), van een gelegenheidswerknemer (Type werknemer = EXT), een student (Type werknemer = STU), een persoon in een beroepsopleiding (Type werknemer = IVT), een persoon in en instapstage (Type werknemer = TRI) of een stagiair (Type werknemer = STG) of een Artikel 17 (Type werknemer = A17, O17, S17 of T17).\n- of een aangifte creatie dagelijkse registratie.\nVerboden in het geval van een aangifte annulatie dagelijkse registratie.\nFacultatief in de andere gevallen."
        , "JJJJ-MM-DD\n- JJJJ is het jaar\n- MM is de maand\n- DD is de dag"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00911'
                          AND Version = '2023/2'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00218"
        , "2023/2"
        , "25/05/2023"
        , "DATUM VAN CREATIE VAN HET FORMULIER"
        , "FormCreationDate"
        , "Formulier"
        , "Datum waarop het formulier gecreërd is."
        , "JJJJ is een element van [lopend jaar -1 ; lopend jaar] ; De datum mag zich niet in de toekomst bevinden."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Onmisbaar"
        , "JJJJ-MM-DD
- JJJJ is het jaar
- MM is de maand
- DD is de dag"
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
        , "Natuurlijke persoon"
        , "Geboortedatum van de natuurlijke persoon."
        , " JJJJ is een element van [jaar van de aangifte -120; jaar van de aangifte]."
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , "JJJJ-MM-DD (geldige datum)
- JJJJ-00-00"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00028'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00522"
        , "2023/2"
        , "25/05/2023"
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
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00168"
        , "2023/2"
        , "25/05/2023"
        , "GEMEENTE - GEBOORTEPLAATS VAN DE WERKNEMER"
        , "WorkerBirthplace"
        , "Natuurlijke persoon"
        , "Naam van een gemeente. Naam van de gemeente waar de natuurlijke persoon geboren is."
        , ""
        , ""
        , "Alfanumeriek"
        , "40"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00168'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00034"
        , "2023/2"
        , "25/05/2023"
        , "GEMEENTE VAN DE WERKNEMER"
        , "WorkerCity"
        , "Natuurlijke persoon"
        , "Naam van een gemeente. Naam van de gemeente waar de werknemer gedomicilieerd is."
        , "Indien het gaat om een Belgische gemeente, moet de waarde verwijzen naar één van de namen die in bijlage 23 overeenstemmen met de in zone 00033 (postcode van de werknemer) opgegeven postcode."
        , ""
        , "Alfanumeriek"
        , "40"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00034'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00029"
        , "2023/2"
        , "25/05/2023"
        , "GESLACHT VAN DE WERKNEMER"
        , "WorkerSex"
        , "Natuurlijke persoon"
        , "Geslacht van een natuurlijk persoon."
        , "1 = man; 2 = vrouw"
        , ""
        , "Numeriek"
        , "1"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
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
        , "1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal secretariaat, een softwareontwikkelaar, ...)
     2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een antwoord op eenduidige wijze identificeert
     3 = het referentienummer is toegekend door een sector van de sociale zekerheid
     4 = het referentienummer is toegekend door de dienst ePost
     5 = het referentienummer is toegekend door de KSZ
     6 = het referentienummer is toegekend door het archiveringssysteem (DOC-ID)
     7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend (DSP-ID)
     "1" voor de Dimona-aangiften."
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
        , "Zie bijlage 11 - Identificatie van het formulier. Deze zone moet als waarde "DIMONA" hebben."
        , ""
        , "Alfanumeriek"
        , "7"
        , "Onmisbaar "
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
        , "Dimona annulatie aangifte"
        , "Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke personen.
     "
        , ""
        , ""
        , "Numeriek"
        , "11"
        , "Verplicht indien het een Dimona-aangifte IN is en dat ze betrekking heeft op een gelegenheidswerknemer is (type werknemer "EXT"). Zoniet, facultatief.
     Verboden in het blok "UsingEmployer" (90107) in Dimona."
        , "0 of NNNNNNNNNCC
- NNNNNNNNN is het nummer
- CC is het controlegetal."
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
        , "Dimona OUT aangifte"
        , "Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke personen.
     "
        , ""
        , ""
        , "Numeriek"
        , "11"
        , "Verplicht indien het een Dimona-aangifte IN is en dat ze betrekking heeft op een gelegenheidswerknemer is (type werknemer "EXT"). Zoniet, facultatief.
     Verboden in het blok "UsingEmployer" (90107) in Dimona."
        , "0 of NNNNNNNNNCC\n
- NNNNNNNNN is het nummer\n
- CC is het controlegetal."
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
        , "Dimona wijziging aangifte"
        , "Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke personen.
     "
        , ""
        , ""
        , "Numeriek"
        , "11"
        , "Verplicht indien het een Dimona-aangifte IN is en dat ze betrekking heeft op een gelegenheidswerknemer is (type werknemer "EXT"). Zoniet, facultatief.
     Verboden in het blok "UsingEmployer" (90107) in Dimona."
        , "0 of NNNNNNNNNCC
- NNNNNNNNN is het nummer
-CC is het controlegetal."
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
        , "Gebruikende onderneming"
        , "Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke personen."
        , ""
        , ""
        , "Numeriek"
        , "11"
        , "Verplicht indien het een Dimona-aangifte IN is en dat ze betrekking heeft op een gelegenheidswerknemer is (type werknemer "EXT"). Zoniet, facultatief.
Verboden in het blok "UsingEmployer" (90107) in Dimona."
        , "0 of NNNNNNNNNCC
- NNNNNNNNN is het nummer
- CC is het controlegetal."
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
        , "Natuurlijke persoon"
        , "Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke personen.
     "
        , ""
        , ""
        , "Numeriek"
        , "11"
        , "Verplicht indien het een Dimona-aangifte IN is en dat ze betrekking heeft op een gelegenheidswerknemer is (type werknemer "EXT"). Zoniet, facultatief.
     Verboden in het blok "UsingEmployer" (90107) in Dimona."
        , "0 of NNNNNNNNNCC
- NNNNNNNNN is het nummer
- CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00024'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01085"
        , "2023/2"
        , "25/05/2023"
        , "IDENTIFICATIENUMMER VAN DE DAGELIJKSE REGISTRATIE"
        , "DailyRegistrationId"
        , "Aangifte dagelijkse registratie"
        , "Nummer dat op eenduidige wijze een dagelijkse registratie identificeert. Dit nummer wordt automatisch toegekend aan de aangifte die deze dagelijkse registratie genereert."
        , ""
        , ""
        , "Numeriek"
        , "12"
        , "Verplicht indien het formulier betrekking heeft op een aangifte wijziging of annulatie dagelijkse registratie.
Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01085'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00913"
        , "2023/2"
        , "25/05/2023"
        , "IDENTIFICATIENUMMER VAN DIMONAPERIODE"
        , "DimonaPeriodId"
        , "Aangifte dagelijkse registratie"
        , "Nummer dat op een unieke wijze de Dimonaperiode identificeert. Dit nummer wordt automatisch toegekend aan een Dimona IN die deze periode genereert."
        , "Getal in 12 posities (waarbij de laatste twee posities overeenkomen met een controlegetal)."
        , ""
        , "Numeriek"
        , "12"
        , "Onmisbaar indien het formulier betrekking heeft op een Dimona wijziging aangifte, een Dimona OUT aangifte, een Dimona annulatie aangifte of een aangifte creatie dagelijkse registratie.

     Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00913'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00913"
        , "2023/2"
        , "25/05/2023"
        , "IDENTIFICATIENUMMER VAN DIMONAPERIODE"
        , "DimonaPeriodId"
        , "Dimona annulatie aangifte"
        , "Nummer dat op een unieke wijze de Dimonaperiode identificeert. Dit nummer wordt automatisch toegekend aan een Dimona IN die deze periode genereert."
        , "Getal in 12 posities (waarbij de laatste twee posities overeenkomen met een controlegetal)."
        , ""
        , "Numeriek"
        , "12"
        , "Onmisbaar indien het formulier betrekking heeft op een Dimona wijziging aangifte, een Dimona OUT aangifte, een Dimona annulatie aangifte of een aangifte creatie dagelijkse registratie.

     Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00913'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00913"
        , "2023/2"
        , "25/05/2023"
        , "IDENTIFICATIENUMMER VAN DIMONAPERIODE"
        , "DimonaPeriodId"
        , "Dimona OUT aangifte"
        , "Nummer dat op een unieke wijze de Dimonaperiode identificeert. Dit nummer wordt automatisch toegekend aan een Dimona IN die deze periode genereert."
        , "Getal in 12 posities (waarbij de laatste twee posities overeenkomen met een controlegetal)."
        , ""
        , "Numeriek"
        , "12"
        , "Onmisbaar indien het formulier betrekking heeft op een Dimona wijziging aangifte, een Dimona OUT aangifte, een Dimona annulatie aangifte of een aangifte creatie dagelijkse registratie.

     Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00913'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00913"
        , "2023/2"
        , "25/05/2023"
        , "IDENTIFICATIENUMMER VAN DIMONAPERIODE"
        , "DimonaPeriodId"
        , "Dimona wijziging aangifte"
        , "Nummer dat op een unieke wijze de Dimonaperiode identificeert. Dit nummer wordt automatisch toegekend aan een Dimona IN die deze periode genereert."
        , "Getal in 12 posities (waarbij de laatste twee posities overeenkomen met een controlegetal)."
        , ""
        , "Numeriek"
        , "12"
        , "Onmisbaar indien het formulier betrekking heeft op een Dimona wijziging aangifte, een Dimona OUT aangifte, een Dimona annulatie aangifte of een aangifte creatie dagelijkse registratie.

     Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00913'
                          AND Version = '2023/2'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00027"
        , "2023/2"
        , "25/05/2023"
        , "INITIAAL VAN DE TWEEDE VOORNAAM VAN DE WERKNEMER"
        , "WorkerInitial"
        , "Natuurlijke persoon"
        , "Initiaal van de tweede voornaam van een natuurlijk persoon."
        , "Een letter uit het alfabet."
        , ""
        , "Alfanumeriek"
        , "1"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00027'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00523"
        , "2023/2"
        , "25/05/2023"
        , "LANDCODE"
        , "Country"
        , "Adres"
        , "Code die toelaat een land te identificeren."
        , "Zie Bijlage 5 - Lijst met landcodes."
        , ""
        , "Numeriek"
        , "5"
        , "Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00523'
                          AND Version = '2023/2'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00169"
        , "2023/2"
        , "25/05/2023"
        , "LANDCODE VAN DE GEBOORTEPLAATS VAN DE WERKNEMER"
        , "WorkerBirthplaceCountry"
        , "Natuurlijke persoon"
        , "Code die toelaat een land te identificeren.
     Code om het land van de geboorteplaats van de natuurlijke persoon op een unieke wijze te identificeren."
        , "Zie Bijlage 5 - Lijst met landcodes.
     "
        , ""
        , "Numeriek"
        , "5"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00169'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00035"
        , "2023/2"
        , "25/05/2023"
        , "LANDCODE VAN DE WERKNEMER"
        , "WorkerCountry"
        , "Natuurlijke persoon"
        , "Code die toelaat een land te identificeren.
     Code waarmee men het land kan identificeren waar de werknemer gedomicilieerd is."
        , "Zie Bijlage 5 - Lijst met landcodes.
     "
        , ""
        , "Numeriek"
        , "5"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00035'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00025"
        , "2023/2"
        , "25/05/2023"
        , "NAAM VAN DE WERKNEMER"
        , "WorkerName"
        , "Natuurlijke persoon"
        , "Familienaam van een natuurlijk persoon.
     Men moet de naam vermelden die op het paspoort of de identiteitskaart staat.
     Voor vrouwen van Belgische nationaliteit gaat het om de meisjesnaam.
     "
        , ""
        , ""
        , "Alfanumeriek"
        , "48"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00025'
                          AND Version = '2023/2'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00119"
        , "2023/2"
        , "25/05/2023"
        , "NATIONALITEIT VAN DE WERKNEMER"
        , "Nationality"
        , "Natuurlijke persoon"
        , "Code die de nationaliteit van de werknemer aanduidt."
        , "Zie Bijlage 5 - Lijst met landcodes."
        , ""
        , "Numeriek"
        , "5"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00119'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00167"
        , "2023/2"
        , "25/05/2023"
        , "NUMMER VAN DE SOCIALE IDENTITEITSKAART"
        , "SIS"
        , "Natuurlijke persoon"
        , "Nummer van de sociale identiteitskaart van een natuurlijk persoon (SIS). Deze zone wordt nooit gebruikt wanneer het een Dimona-aangifte is."
        , "Getal van 10 cijfers."
        , ""
        , "Numeriek"
        , "10"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00167'
                          AND Version = '2023/2'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00652"
        , "2023/2"
        , "25/05/2023"
        , "NUMMER VAN DEELENTITEIT"
        , "SubEntityNbr"
        , "Dimona karakteristieken"
        , "Nummer toegekend ï¿½ na akkoord van de RSZ - aan de deelentiteit van een werkgever van de publieke sector."
        , "Moet behoren tot de lijst van de geldige deelentiteiten voor de betrokken werkgever."
        , ""
        , "Numeriek"
        , "10"
        , "Verplicht indien de werkgever betrokken is bij het systeem van deelentiteiten. Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00652'
                          AND Version = '2023/2'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00518"
        , "2023/2"
        , "25/05/2023"
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
                          AND Version = '2023/2'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00031"
        , "2023/2"
        , "25/05/2023"
        , "NUMMER VAN HET ADRES VAN DE WERKNEMER"
        , "WorkerHouseNbr"
        , "Natuurlijke persoon"
        , "
     Nummer van de woonplaats van de werknemer."
        , ""
        , ""
        , "Alfanumeriek"
        , "10"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00031'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00046"
        , "2023/2"
        , "25/05/2023"
        , "NUMMER VAN PARITAIR COMITï¿½"
        , "JointCommissionNbr"
        , "Dimona karakteristieken"
        , "Nummer van het paritair comitï¿½ waaronder de werknemer valt in het kader van de aangegeven tewerkstelling of op het moment waarop de aanvullende vergoeding voor het eerst werd toegekend.
     Wanneer deze zone bij het FB 90374 (Dimona karakteristieken) staat, geeft ze het paritair comitï¿½ weer waaronder de werknemer valt.

     Wanneer deze zone bij het FB 90107 (Gebruikende onderneming) staat, geeft ze het paritair comitï¿½ van de gebruiker van de uitzendkracht weer.

     Een officiï¿½le lijst met de paritaire comitï¿½s wordt ieder jaar gepubliceerd in het Belgische Staatsblad. Enkel de in Dimona toegelaten nummers zijn van toepassing."
        , "- CCC : De paritaire comitï¿½s ; reeks van 3 cijfers, links uitgelijnd. 
     - CCC.CC : De paritaire subcomitï¿½s ; reeks van 3 cijfers gevolgd door een punt en 2 cijfers, links uitgelijnd.
     - CCC.CC.CC : De paritaire sub-subcomitï¿½s ;  reeks van 3 cijfers gevolgd door een punt en 2 cijfers nogmaals gevolgd door een punt en 2 cijfers.
     - Als de werknemer onder geen enkel paritair comitï¿½ of subcomitï¿½ of sub-subcomitï¿½ valt, dan is de in te vullen waarde 999.
     De enige waarden die in dit bericht zijn toegelaten zijn:
     124 = Paritair Comitï¿½ van het bouwbedrijf
     140 = Paritair comitï¿½ van transport en logistiek
     144 = Paritair comitï¿½ voor landbouw
     145 = Paritair comitï¿½ voor tuinbouwbedrijven
     149 = Paritair Comitï¿½ voor Elektriciens: installatie en distributie
     302 = Paritair comitï¿½ voor hotelnijverheid
     320 = Paritair Comitï¿½ voor de begrafenisondernemingen
     322 = Paritair comitï¿½ voor uitzendarbeid en erkende ondernemingen die nabijheidswerken of diensten leveren
     XXX = andere sectoren

     Eerste opmerking: in dit bericht moeten enkel uitzendkrachten aangegeven worden met het Paritair comitï¿½ 322. Werknemers van erkende ondernemingen die nabijheidswerken of -diensten leveren moeten aangegeven worden met de waarde XXX (andere sectoren).

     Tweede opmerking: de waarde 322 is niet toegelaten wanneer de zone bij het blok 90107 (Gebruikende onderneming) hoort.

     Derde opmerking : De prestaties van toepassing voor het Paritair comitï¿½ 149 moeten verplicht aangegeven worden onder dit paritair comitï¿½ voor alle periodes vanaf 01/10/2017.

     Vierde opmerking: gelegenheidsarbeid van toepassing voor paritair comitï¿½ 320 moet verplicht aangegeven worden onder dit paritair comitï¿½ voor alle periodes vanaf 01/04/2019."
        , ""
        , "Alfanumeriek"
        , "9"
        , "Verplicht indien de zone zich in het FB 90374 (Dimona karakteristieken) bevindt en het formulier betrekking heeft op een werkgever (uitgezonderd provinciale en plaatselijke besturen).
     Verplicht indien de zone zich in het FB 90107 (Gebruikende onderneming) bevindt en het paritair comitï¿½ (BF 90374) 322 is.
     Verboden in de andere gevallen."
        , "CCC of CCC.CC of CCC.CC.CC"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00046'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00046"
        , "2023/2"
        , "25/05/2023"
        , "NUMMER VAN PARITAIR COMITï¿½"
        , "JointCommissionNbr"
        , "Gebruikende onderneming"
        , "Nummer van het paritair comitï¿½ waaronder de werknemer valt in het kader van de aangegeven tewerkstelling of op het moment waarop de aanvullende vergoeding voor het eerst werd toegekend.
     Wanneer deze zone bij het FB 90374 (Dimona karakteristieken) staat, geeft ze het paritair comitï¿½ weer waaronder de werknemer valt.

     Wanneer deze zone bij het FB 90107 (Gebruikende onderneming) staat, geeft ze het paritair comitï¿½ van de gebruiker van de uitzendkracht weer.

     Een officiï¿½le lijst met de paritaire comitï¿½s wordt ieder jaar gepubliceerd in het Belgische Staatsblad. Enkel de in Dimona toegelaten nummers zijn van toepassing."
        , "- CCC : De paritaire comitï¿½s ; reeks van 3 cijfers, links uitgelijnd. 
     - CCC.CC : De paritaire subcomitï¿½s ; reeks van 3 cijfers gevolgd door een punt en 2 cijfers, links uitgelijnd.
     - CCC.CC.CC : De paritaire sub-subcomitï¿½s ;  reeks van 3 cijfers gevolgd door een punt en 2 cijfers nogmaals gevolgd door een punt en 2 cijfers.
     - Als de werknemer onder geen enkel paritair comitï¿½ of subcomitï¿½ of sub-subcomitï¿½ valt, dan is de in te vullen waarde 999.
     De enige waarden die in dit bericht zijn toegelaten zijn:
     124 = Paritair Comitï¿½ van het bouwbedrijf
     140 = Paritair comitï¿½ van transport en logistiek
     144 = Paritair comitï¿½ voor landbouw
     145 = Paritair comitï¿½ voor tuinbouwbedrijven
     149 = Paritair Comitï¿½ voor Elektriciens: installatie en distributie
     302 = Paritair comitï¿½ voor hotelnijverheid
     320 = Paritair Comitï¿½ voor de begrafenisondernemingen
     322 = Paritair comitï¿½ voor uitzendarbeid en erkende ondernemingen die nabijheidswerken of diensten leveren
     XXX = andere sectoren

     Eerste opmerking: in dit bericht moeten enkel uitzendkrachten aangegeven worden met het Paritair comitï¿½ 322. Werknemers van erkende ondernemingen die nabijheidswerken of -diensten leveren moeten aangegeven worden met de waarde XXX (andere sectoren).

     Tweede opmerking: de waarde 322 is niet toegelaten wanneer de zone bij het blok 90107 (Gebruikende onderneming) hoort.

     Derde opmerking : De prestaties van toepassing voor het Paritair comitï¿½ 149 moeten verplicht aangegeven worden onder dit paritair comitï¿½ voor alle periodes vanaf 01/10/2017.

     Vierde opmerking: gelegenheidsarbeid van toepassing voor paritair comitï¿½ 320 moet verplicht aangegeven worden onder dit paritair comitï¿½ voor alle periodes vanaf 01/04/2019."
        , ""
        , "Alfanumeriek"
        , "9"
        , "Verplicht indien de zone zich in het FB 90374 (Dimona karakteristieken) bevindt en het formulier betrekking heeft op een werkgever (uitgezonderd provinciale en plaatselijke besturen).
     Verplicht indien de zone zich in het FB 90107 (Gebruikende onderneming) bevindt en het paritair comitï¿½ (BF 90374) 322 is.
     Verboden in de andere gevallen."
        , "CCC of CCC.CC of CCC.CC.CC"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00046'
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
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
     In het geval van een aangifte voor een provinciaal of plaatselijk bestuur, heeft het Ondernemingsnummer voorrang, zoniet heeft het RSZ-identificatienummer (zone 00011) of het voorlopig RSZ-nummer (zone 00948) voorrang op het ondernemingsnummer."
        , "
     Getal van 10 cijfers waarvan :
     de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
     de posities 9 en 10 overeenkomen met een controlegetal.
     Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden.De waarde 0 is nooit toegelaten wanneer het een Dimona-aangifte is."
        , ""
        , "Numeriek"
        , "10"
        , "Verplicht indien het gaat om een provinciaal of plaatselijk bestuur of een andere werkgever die onder de RSZ valt en indien het "RSZ-nummer" (zone 00011) en het "voorlopig RSZ-nummer" (zone 00948) geen van beide aanwezig zijn."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00131"
        , "2023/2"
        , "25/05/2023"
        , "ONDERNEMINGSNUMMER VAN DE GEBRUIKENDE ONDERNEMING"
        , "UsingEmployerCompanyID"
        , "Gebruikende onderneming"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
     Het ondernemingsnummer is onmisbaar, tenzij de onderneming die gebruik maakt van de uitzendkracht er geen heeft omdat ze in het buitenland gevestigd is."
        , "
     Getal van 10 cijfers waarvan :
     de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
     de posities 9 en 10 overeenkomen met een controlegetal.
     Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden."
        , ""
        , "Numeriek"
        , "10"
        , "Verplicht indien de zone 00046 (Paritair comitï¿½) = 322 en indien de uitzendgebruiker een ondernemingsnummer heeft dat bekend is bij de Kruispuntbank van ondernemingen. Verboden in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00131'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00520"
        , "2023/2"
        , "25/05/2023"
        , "POSTCODE"
        , "ZIPCode"
        , "Adres"
        , "Postnummer van een gemeente.
     "
        , "Indien het een Belgische postcode is, moet de waarde betrekking hebben op ï¿½ï¿½n van de codes die in de bijlage 23 staan."
        , ""
        , "Alfanumeriek"
        , "9"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00520'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00033"
        , "2023/2"
        , "25/05/2023"
        , "POSTCODE VAN DE WERKNEMER"
        , "WorkerZIPCode"
        , "Natuurlijke persoon"
        , "Postnummer van een gemeente.
     Postnummer van het adres waar de werknemer gedomicilieerd is.
     Voor de in Belgiï¿½ gedomicilieerde werknemers moet men de officiï¿½le lijst met Belgische postcodenummers gebruiken."
        , "Indien het een Belgische postcode is, moet de waarde betrekking hebben op ï¿½ï¿½n van de codes die in de bijlage 23 staan."
        , ""
        , "Alfanumeriek"
        , "9"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00033'
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
        , " Elke lokale of provinciale overheid die personeel in dienst heeft, moet ingeschreven zijn bij de RSZ.Deze zone wordt nooit gebruikt wanneer het een Dimona-aangifte is."
        , "Geheel getal en element van [00000197;99999926]. Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het PPL nummer op de waarde nul gezet worden."
        , ""
        , "Numeriek"
        , "8"
        , "Facultatief "
        , "0 of NNNNNNCC
     ï¿½ NNNNNN is het nummer
     ï¿½ CC is het controlegetal."
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
        , "Tijdstip, uitgedrukt in uren, minuten, seconden en milliseconden.
     "
        , "UU is een element van [00;23]
     MM is een element van [00;59]
     SS is een element van [00;59]
     SSS is een element van [000;999]
     "
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
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00615"
        , "2023/2"
        , "25/05/2023"
        , "REFERENTIE GEBRUIKER - NATUURLIJKE PERSOON"
        , "NaturalPersonUserReference"
        , "Natuurlijke persoon"
        , "Referentie.
     Referentie van de natuurlijke persoon gebruikt door de werkgever of een erkend sociaal secretariaat.Deze zone wordt nooit gebruikt wanneer het een Dimona-aangifte is."
        , "In dit bericht is de toegelaten lengte voor deze zone 20 tekens."
        , ""
        , "Alfanumeriek"
        , "200"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00615'
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
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ. Het gaat om een definitief RSZ-nummer.
     Indien de zone 00014 "Ondernemingsnummer" ook aanwezig is, dan heeft het RSZ-nummer voorrang."
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers.
     Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden.
     De waarde 0 is nooit toegelaten wanneer het een Dimona-aangifte is."
        , ""
        , "Numeriek"
        , "9"
        , "Verplicht indien de werkgever een definitief RSZ-nummer bezit en indien het "Ondernemingsnummer" (zone 00014) niet aanwezig is."
        , "0 of NNNNNNNCC
     ï¿½ NNNNNNN is het nummer
     ï¿½ CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00011'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01231"
        , "2023/2"
        , "25/05/2023"
        , "SOORT WERK"
        , "EmploymentNature"
        , "Kleine statuten - Informatie"
        , "Met deze zone kan het soort werk gespecificeerd worden.Te specificeren in het kader van een stage of beroepsopleiding."
        , "EMPLOYEE = bediende
     WORKER = arbeider"
        , ""
        , "Alfanumeriek"
        , "8"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01231'
                          AND Version = '2023/2'
);


INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00110"
        , "2023/2"
        , "25/05/2023"
        , "STATUS VAN HET ATTEST"
        , "AttestationStatus"
        , "Aangifte dagelijkse registratie"
        , "In deze zone kan, deel uitmakend van het blok "Aangifte dagelijkse registratie" (90480), gespecifieerd worden of het gaat om een aangifte van creatie, wijziging of annulering."
        , "0 = Origineel
     1 = Wijziging
     2 = Duplicaat
     3 = Annulatie
     4 = Herziening
     5 = Herinnering
     6 = Afsluiting
     7 = Wijziging van papieren origineel
     8 = KopieEnkel waarde "0" wordt toegelaten als de zone deel uitmaakt van het blok "Formulier" (90059).
     Als de zone deel uitmaakt van het blok "Aangifte dagelijkse registratie" (90480) dan zijn waardes "0" (creatie van een dagelijkse registratie), "1" (wijziging van een dagelijkse registratie) en "3" (annulering van een dagelijkse registratie) toegelaten."
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
SELECT "00110"
        , "2023/2"
        , "25/05/2023"
        , "STATUS VAN HET ATTEST"
        , "AttestationStatus"
        , "Formulier"
        , "In deze zone kan, deel uitmakend van het blok "Aangifte dagelijkse registratie" (90480), gespecifieerd worden of het gaat om een aangifte van creatie, wijziging of annulering."
        , "0 = Origineel
     1 = Wijziging
     2 = Duplicaat
     3 = Annulatie
     4 = Herziening
     5 = Herinnering
     6 = Afsluiting
     7 = Wijziging van papieren origineel
     8 = KopieEnkel waarde "0" wordt toegelaten als de zone deel uitmaakt van het blok "Formulier" (90059).
     Als de zone deel uitmaakt van het blok "Aangifte dagelijkse registratie" (90480) dan zijn waardes "0" (creatie van een dagelijkse registratie), "1" (wijziging van een dagelijkse registratie) en "3" (annulering van een dagelijkse registratie) toegelaten."
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
SELECT "00053"
        , "2023/2"
        , "25/05/2023"
        , "STATUUT VAN DE WERKNEMER"
        , "WorkerStatus"
        , "Kleine statuten - Informatie"
        , "Code die aanduidt of de tewerkstelling gebeurt in het kader van een bijzonder contract.
     Specificeert de dekkings- en schadevergoedingsregeling."
        , "Zie bijlage 21 - Lijst codes werknemersstatuut.
     F1 = is van toepassing op personen die werk verrichten als onderdeel van een opleiding voor betaald werk, zoals vastgelegd in de LAT voor leerlingen.
     F2 = is van toepassing op leercontracten met een specifieke dekkings- en schadevergoedingsregeling."
        , ""
        , "Alfanumeriek"
        , "2"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00053'
                          AND Version = '2023/2'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00517"
        , "2023/2"
        , "25/05/2023"
        , "STRAAT"
        , "Street"
        , "Adres"
        , "Openbare weg."
        , ""
        , ""
        , "Alfanumeriek"
        , "42"
        , "Onmisbaar "
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00517'
                          AND Version = '2023/2'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00030"
        , "2023/2"
        , "25/05/2023"
        , "STRAAT VAN DE WERKNEMER"
        , "WorkerStreet"
        , "Natuurlijke persoon"
        , "Openbare weg.
     Openbare weg waar zich de woonplaats van de werknemer bevindt.
     De notie " verdieping " kan vermeld worden in deze zone als dat nodig is."
        , ""
        , ""
        , "Alfanumeriek"
        , "35"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00030'
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
        , "0 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat niet dezelfde identificatie heeft (zie bijlagen 11/302), dat verband houdt met het huidige formulier
     1 = de referentie verwijst naar dit formulier
     2 = de referentie is een dossiernummer en verwijst naar het dossier (= verzameling van aangiften) waartoe deze aangifte behoort of waartoe dit formulier behoort
     3 = de referentie heeft betrekking op een eerder uitgewisseld formulier dat dezelfde identificatie heeft (zie bijlagen 11/302) en dat verband houdt met dit formulier, bijvoorbeeld: de referentie heeft betrekking op de aangifte die geannuleerd moet worden door deze aangifte, of op de aangifte die vervangen moet worden door deze aangifte, of op de aangifte die gewijzigd moet worden, of op de aangifte die aan de oorsprong ligt van dit formulier...
     4 = de referentie verwijst naar een aangifte in een ander scenario die verwant is met deze aangifte
     5 = de referentie verwijst naar een aanvraag
     6 = de referentie verwijst naar een geweigerde aangifte
     7 = de referentie verwijst naar de werkgever die in deze aangifte wordt vermeld
     8 = de referentie verwijst naar de werknemer die in deze aangifte wordt vermeld
     9 = de referentie is een gestructureerde mededeling die moet worden gebruikt in het kader van een betaling en verwijst naar dit formulierDeze zone moet als waarde "1", "6", "7" of "8" hebben."
        , ""
        , "Numeriek"
        , "1"
        , "Onmisbaar "
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
        , "Het type wijst de aard van het elektronisch formulier aan.
     "
        , "RE = REQUEST - het formulier vraagt inlichtingen
     PA = PROVISIONAL ANSWER - het formulier is een tijdelijk antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
     FA = FINAL ANSWER - het formulier is een definitief antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
     LA = LIMITED ANSWER - het formulier is een beperkt antwoord op een aanvraag van inlichtingen of een mededeling van inlichtingen
     SU = SUBMISSION - het formulier deelt inlichtingen mee
     De enige waarde in dit bericht is "SU"."
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
SELECT "00777"
        , "2023/2"
        , "25/05/2023"
        , "UUR - BEGINUUR"
        , "StartingHour"
        , "Aangifte dagelijkse registratie"
        , "Tijdstip, uitgedrukt in uren en minuten.
     Precies moment dat het begin bepaalt van de prestatie van de Dimonaperiode van een gelegenheidswerknemer of van een dagelijkse registratie."
        , "UU is een element van [00 ;23]
     MM is een element van [00 ;59]
     "
        , ""
        , "Numeriek"
        , "4"
        , "Verplicht indien het formulier betrekking heeft op een Dimona-aangifte IN voor een gelegenheidswerknemer (Type werknemer = EXT), een prestatie Flexi-Job van een dag (Type werknemer = FLX) of een aangifte creatie dagelijkse registratie. 
     Facultatief indien het een wijzigende Dimona-aangifte is en dat de periode betrekking heeft op een gelegenheidswerknemer, een prestatie Flexi-Job van een dag of indien het een aangifte wijziging dagelijkse registratie is.
     Verboden in de andere gevallen."
        , "UUMM
     ï¿½ UU zijn de uren 
     ï¿½ MM zijn de minuten"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00777'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00777"
        , "2023/2"
        , "25/05/2023"
        , "UUR - BEGINUUR"
        , "StartingHour"
        , "Dimona IN aangifte"
        , "Tijdstip, uitgedrukt in uren en minuten.
     Precies moment dat het begin bepaalt van de prestatie van de Dimonaperiode van een gelegenheidswerknemer of van een dagelijkse registratie."
        , "UU is een element van [00 ;23]
     MM is een element van [00 ;59]
     "
        , ""
        , "Numeriek"
        , "4"
        , "Verplicht indien het formulier betrekking heeft op een Dimona-aangifte IN voor een gelegenheidswerknemer (Type werknemer = EXT), een prestatie Flexi-Job van een dag (Type werknemer = FLX) of een aangifte creatie dagelijkse registratie. 
     Facultatief indien het een wijzigende Dimona-aangifte is en dat de periode betrekking heeft op een gelegenheidswerknemer, een prestatie Flexi-Job van een dag of indien het een aangifte wijziging dagelijkse registratie is.
     Verboden in de andere gevallen."
        , "UUMM
     ï¿½ UU zijn de uren 
     ï¿½ MM zijn de minuten"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00777'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00777"
        , "2023/2"
        , "25/05/2023"
        , "UUR - BEGINUUR"
        , "StartingHour"
        , "Dimona wijziging aangifte"
        , "Tijdstip, uitgedrukt in uren en minuten.
     Precies moment dat het begin bepaalt van de prestatie van de Dimonaperiode van een gelegenheidswerknemer of van een dagelijkse registratie."
        , "UU is een element van [00 ;23]
     MM is een element van [00 ;59]
     "
        , ""
        , "Numeriek"
        , "4"
        , "Verplicht indien het formulier betrekking heeft op een Dimona-aangifte IN voor een gelegenheidswerknemer (Type werknemer = EXT), een prestatie Flexi-Job van een dag (Type werknemer = FLX) of een aangifte creatie dagelijkse registratie. 
     Facultatief indien het een wijzigende Dimona-aangifte is en dat de periode betrekking heeft op een gelegenheidswerknemer, een prestatie Flexi-Job van een dag of indien het een aangifte wijziging dagelijkse registratie is.
     Verboden in de andere gevallen."
        , "UUMM
     ï¿½ UU zijn de uren 
     ï¿½ MM zijn de minuten"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00777'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00778"
        , "2023/2"
        , "25/05/2023"
        , "UUR - EINDUUR"
        , "EndingHour"
        , "Aangifte dagelijkse registratie"
        , "Tijdstip, uitgedrukt in uren en minuten.
     Precies moment dat het begin bepaalt van de prestatie van de Dimonaperiode van een gelegenheidswerknemer of van een dagelijkse registratie."
        , "UU is een element van [00 ;23]
     MM is een element van [00 ;59]
     "
        , ""
        , "Numeriek"
        , "4"
        , "Verplicht indien het formulier betrekking heeft op een Dimona IN-aangifte voor een Flexi-jobprestatie van een dag (type werknemer = FLX) of voor een gelegenheidswerknemer (type werknemer = EXT), met uitzondering van een gelegenheidwerknemer in de horeca voor een dagforfait.
     Facultatief wanneer het gaat om een wijzigende Dimona-aangifte en wanneer de periode een Flexi-jobprestatie van een dag of een gelegenheidswerknemer betreft, behalve wanneer u gekozen heeft voor een dagforfait voor een gelegenheidswerknemer in de horeca, of wanneer het gaat om een aangifte creatie of wijziging dagelijkse registratie.
     Verboden in de andere gevallen."
        , "UUMM
     ï¿½ UU zijn de uren 
     ï¿½ MM zijn de minuten"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00778'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00778"
        , "2023/2"
        , "25/05/2023"
        , "UUR - EINDUUR"
        , "EndingHour"
        , "Dimona IN aangifte"
        , "Tijdstip, uitgedrukt in uren en minuten.
     Precies moment dat het begin bepaalt van de prestatie van de Dimonaperiode van een gelegenheidswerknemer of van een dagelijkse registratie."
        , "UU is een element van [00 ;23]
     MM is een element van [00 ;59]
     "
        , ""
        , "Numeriek"
        , "4"
        , "Verplicht indien het formulier betrekking heeft op een Dimona IN-aangifte voor een Flexi-jobprestatie van een dag (type werknemer = FLX) of voor een gelegenheidswerknemer (type werknemer = EXT), met uitzondering van een gelegenheidwerknemer in de horeca voor een dagforfait.
     Facultatief wanneer het gaat om een wijzigende Dimona-aangifte en wanneer de periode een Flexi-jobprestatie van een dag of een gelegenheidswerknemer betreft, behalve wanneer u gekozen heeft voor een dagforfait voor een gelegenheidswerknemer in de horeca, of wanneer het gaat om een aangifte creatie of wijziging dagelijkse registratie.
     Verboden in de andere gevallen."
        , "UUMM
     ï¿½ UU zijn de uren 
     ï¿½ MM zijn de minuten"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00778'
                          AND Version = '2023/2'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00778"
        , "2023/2"
        , "25/05/2023"
        , "UUR - EINDUUR"
        , "EndingHour"
        , "Dimona wijziging aangifte"
        , "Tijdstip, uitgedrukt in uren en minuten.
     Precies moment dat het begin bepaalt van de prestatie van de Dimonaperiode van een gelegenheidswerknemer of van een dagelijkse registratie."
        , "UU is een element van [00 ;23]
     MM is een element van [00 ;59]
     "
        , ""
        , "Numeriek"
        , "4"
        , "Verplicht indien het formulier betrekking heeft op een Dimona IN-aangifte voor een Flexi-jobprestatie van een dag (type werknemer = FLX) of voor een gelegenheidswerknemer (type werknemer = EXT), met uitzondering van een gelegenheidwerknemer in de horeca voor een dagforfait.
     Facultatief wanneer het gaat om een wijzigende Dimona-aangifte en wanneer de periode een Flexi-jobprestatie van een dag of een gelegenheidswerknemer betreft, behalve wanneer u gekozen heeft voor een dagforfait voor een gelegenheidswerknemer in de horeca, of wanneer het gaat om een aangifte creatie of wijziging dagelijkse registratie.
     Verboden in de andere gevallen."
        , "UUMM
     ï¿½ UU zijn de uren 
     ï¿½ MM zijn de minuten"
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00778'
                          AND Version = '2023/2'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00023"
        , "2023/2"
        , "25/05/2023"
        , "VOLGNUMMER NATUURLIJKE PERSOON"
        , "NaturalPersonSequenceNbr"
        , "Natuurlijke persoon"
        , "Volgnummer van de natuurlijke personen binnen een aangifte. Dit nummer moet uniek zijn binnen een aangifte.Deze zone wordt nooit gebruikt wanneer het een Dimona-aangifte is."
        , "Positief geheel getal en element van [1;9999999]."
        , ""
        , "Numeriek"
        , "7"
        , "Facultatief"
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00023'
                          AND Version = '2023/2'
);

/*
INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00948"
        , "2023/2"
        , "25/05/2023"
        , "VOORLOPIG RSZ-NUMMER"
        , "ProvisionalNSSONbr"
        , "Identificatie van de werkgever"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft
               , die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ.\n
               Het gaat om een voorlopig RSZ-nummer dat aan de nieuwe werkgever toegekend is.\n
               Dit voorlopig nummer mag niet meer gebruikt worden zodra de RSZ het definitieve nummer heeft meegedeeld.
               Deze zone mag alleen gebruikt worden als de werkgever niet beschikt over een definitief RSZ-nummer (zone 00011).
               Indien de zone 00014 "Ondernemingsnummer" ook aanwezig is, dan heeft het voorlopig RSZ-nummer voorrang.
          "
        , "Geheel getal en element van [5000000120;5999999989]"
        , ""
        , "Numeriek"
        , "10"
        , "Verplicht indien de werkgever een voorlopig RSZ-nummer bezit en indien het "Ondernemingsnummer" (zone 00014) niet aanwezig is."
        , "0 of NNNNNNNNCC;  - NNNNNNNN is het nummer - CC is het controlegetal."
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00948'
                          AND Version = '2023/2'
);
*/

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00026"
        , "2023/2"
        , "25/05/2023"
        , "VOORNAAM VAN DE WERKNEMER"
        , "WorkerFirstName"
        , "Natuurlijke persoon"
        , "Eerste voornaam van een natuurlijk persoon."
        , ""
        , ""
        , "Alfanumeriek"
        , "24"
        , "Verplicht indien het identificatienummer bij de sociale zekerheid (zone 00024) niet aanwezig is. Zoniet, facultatief."
        , ""
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00026'
                          AND Version = '2023/2'
);
