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
SELECT "90065"
        , "2023/1"
        , "28/02/2023"
        , "Aanduiding van de dagen en uren"
        , "IndicationDaysAndHours"
        , "Functioneel blok dat toelaat de aanduiding van de dagen en uren van het werkrooster op te geven."
        , "0"
        , "28"
        , "Cardinaliteit 7 : VERPLICHT indien de prestaties eenduidig kunnen worden verdeeld in uren volgens werkrooster 1\nCardinaliteit 14 : VERPLICHT indien de prestaties eenduidig kunnen worden verdeeld in uren volgens werkrooster 2\nCardinaliteit 21 : VERPLICHT indien de prestaties eenduidig kunnen worden verdeeld in uren volgens werkrooster 3\nCardinaliteit 28 : VERPLICHT indien de prestaties eenduidig kunnen worden verdeeld in uren volgens werkrooster 4"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90065'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90046"
        , "2023/1"
        , "28/02/2023"
        , "Aangifte einde arbeidsovereenkomst of werkloosheid met bedrijfstoeslag"
        , "DclEndContractOrFTEarlyPension"
        , "Functioneel blok dat toelaat de specifieke gegevens van de aangifte einde arbeidsovereenkomst of werkloosheid met bedrijfstoeslag aan te geven."
        , "0"
        , "1"
        , "VERPLICHT voor de tewerkstelling uit het meest recente jaar-kwartaal waarop het einde van de arbeidsovereenkomst (of werkloosheid met bedrijfstoeslag) betrekking heeft. Dit blok dient m.a.w. precies 1 maal voor te komen in het meest recente kwartaal in de aangifte (aan het tewerkstellingsblok dat de datum van beëindiging van de arbeidsovereenkomst vermeldt).\nUitzondering: voor het arbeidsbewijs is dit blok enkel nodig indien ook een algemene commentaar meegegeven wordt."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90046'
                          AND Version = '2023/1'
);


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
        , "Verplicht indien het blok 'Communicatie' niet aanwezig is"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90022'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90032"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis van de uitkeringen"
        , "CalculationBaseAllowance"
        , "Functioneel blok dat toelaat de gegevens van de berekeningsbasis van de uitkeringen aan te geven."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de identificatie van het risico '001', '002' of '003' is."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90032'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90019"
        , "2023/1"
        , "28/02/2023"
        , "Bezoldiging van de tewerkstelling werknemerslijn"
        , "Remun"
        , "Functioneel blok dat toelaat de bezoldigingen van een werknemer voor een tewerkstelling van de werknemerslijn aan te geven."
        , "0"
        , "99"
        , "FACULTATIEF"
        , "Een gegeven bezoldiging (een combinatie bezoldigingscode / frequentie in maanden van de betaling van de premie / percentage van de bezoldiging op jaarbasis) mag slechts één keer voorkomen per tewerkstelling."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90019'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90005"
        , "2023/1"
        , "28/02/2023"
        , "Bijdrage ontslagen statutaire werknemer"
        , "DismissedStatutoryWorkerContribution"
        , "Functioneel blok dat toelaat de bijdragen verschuldigd voor een ontslagen statutaire werknemer aan te geven."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de werknemerslijn betrekking heeft op een ontslagen statutaire werknemer (zie bijlage 2)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90005'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90003"
        , "2023/1"
        , "28/02/2023"
        , "Bijdrage werknemer-student"
        , "StudentContribution"
        , "Functioneel blok dat toelaat de solidariteitsbijdrage verschuldigd voor een student aan te geven."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de werknemerslijn betrekking heeft op een werknemer-student (zie bijlage 2)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90003'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90340"
        , "2023/1"
        , "28/02/2023"
        , "Collectief ontslag"
        , "CollectiveDismissal"
        , "Functioneel blok dat toelaat de specifieke gegevens met betrekking tot  het collectief ontslag op te geven"
        , "0"
        , "1"
        , "Verplicht indien Aanduiding regime werkloosheid met bedrijfstoeslag = '7' (onderneming erkend als in moeilijkheden of herstructurering)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90340'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90036"
        , "2023/1"
        , "28/02/2023"
        , "Commentaar bij de aangifte"
        , "CommentDeclaration"
        , "Functioneel blok dat toelaat commentaar bij de aangifte op te geven."
        , "0"
        , "1"
        , "FACULTATIEF"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90036'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90037"
        , "2023/1"
        , "28/02/2023"
        , "Commentaar werkrooster"
        , "CommentWorkGrid"
        , "Functioneel blok dat toelaat commentaar bij het werkrooster op te geven."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de prestaties niet duidelijk kunnen worden verdeeld in uren."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90037'
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
        , "Verplicht indien het blok Adres niet aanwezig is"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90258'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90089"
        , "2023/1"
        , "28/02/2023"
        , "Detail vakantie"
        , "HolidayDetail"
        , "Functioneel blok dat toelaat het aantal dagen/uren vakantie aan te geven per vakantiecode."
        , "0"
        , "2"
        , "VERPLICHT INDIEN de vakantieregeling 'privésector' van toepassing is (aanduiding van de vakantiesector = 1)."
        , "Er moet een blok aanwezig zijn met de code vakantie = 1 (indien de vakantieregeling 'privésector' van toepassing is)."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90089'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90344"
        , "2023/1"
        , "28/02/2023"
        , "Dimona-gegevens"
        , "DimonaData"
        , "Functioneel blok dat toelaat de gegevens te specificeren die betrekking hebben op een aanvraag tot afsluiting, wijziging of annulatie van een Dimona-aangifte"
        , "0"
        , "*"
        , "verboden indien  IdentificationOfRisk = 004  of in het geval van een vereenvoudigde annulatie (Status van het attest = 3 en functioneel blok Werknemerslijn niet aanwezig).\nFacultatief in de andere gevallen"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90344'
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
SELECT "90064"
        , "2023/1"
        , "28/02/2023"
        , "Identificatie risico"
        , "RiskIdentification"
        , "Functioneel blok dat toelaat het risico te identificeren."
        , "1"
        , "1"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90064'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90171"
        , "2023/1"
        , "28/02/2023"
        , "Informatie van de aangifte"
        , "DclInformation"
        , "Functioneel blok dat toelaat informatie bij de aangifte te preciseren."
        , "1"
        , "1"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90171'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90404"
        , "2023/1"
        , "28/02/2023"
        , "Kenmerken van de tewerkstelling"
        , "OccupationFeatures"
        , "Bijkomende kenmerken van de tewerkstelling."
        , "0"
        , "1"
        , "Facultatief "
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90404'
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
        , "1"
        , "1"
        , "ONMISBAAR"
        , "Het adres kan ingevuld worden om op de resulterende PDF afgedrukt te worden."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90017'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90189"
        , "2023/1"
        , "28/02/2023"
        , "Onderwijsinrichting"
        , "SchoolEstablishment"
        , "Functioneel blok dat toelaat de specifieke gegevens van de onderwijsinrichting aan te geven."
        , "0"
        , "1"
        , "Kardinaliteit 1 : VERPLICHT indien de identificatie van het risico 003 is. 
Kardinaliteit 0 : VERBODEN in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90189'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90018"
        , "2023/1"
        , "28/02/2023"
        , "Prestatie van de tewerkstelling werknemerslijn"
        , "Service"
        , "Functioneel blok dat toelaat de prestaties van een werknemer voor een tewerkstelling van de werknemerslijn aan te geven."
        , "0"
        , "99"
        , "VERPLICHT INDIEN ten minste één prestatie aangegeven moet worden én er een onderbreking in de tewerkstelling optrad in de loop van dit kwartaal of het een deeltijdse tewerkstelling betreft tijdens dewelke de effectieve arbeidsduur voor dit kwartaal niet overeenstemt met de gemiddelde wekelijkse arbeidsduur (factor Q) van de werknemer."
        , "- Van zodra u bezoldigingen opgeeft, moeten de aan te geven prestaties ook opgegeven worden (ongeacht het feit of er een onderbreking optrad of de arbeidsduur overschreden werd).\n- Een gegeven prestatie (een prestatiecode) mag slechts één keer voorkomen per tewerkstelling."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90018'
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
        , "3"
        , "Kardinaliteit 0 ... 2 indien 00110 Status van het attest = '0' (Origineel)\nKardinaliteit 1 ... 3 indien 00110 Status van het attest = '1' (Wijziging) of '3' (Annulatie).\nIn dit geval is alleen één blok referentie nodig met als waarde '3' voor de zone 00221 - TYPE VAN DE REFERENTIE en met als waarde '2' voor de zone 00298 - HERKOMST VAN DE REFERENTIE."
        , "- Per referentietype mag slechts één blok 'Referentie' dat een ticketnummer is, aangegeven worden.\n- Indien de 'status van het attest' een 'wijziging van een papieren origineel' is, mag geen enkel blok 'Referentie' met een ticketnummer aangegeven worden.\n- Indien de 'status van het attest' een 'wijziging' of een 'annulatie' is, moet juist één blok 'Referentie' met een ticketnummer en referentietype '3' aangegeven worden. In geen enkele andere situatie mag soortgelijke referentie aangegeven worden."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90141"
        , "2023/1"
        , "28/02/2023"
        , "Stelsel werkloosheid met bedrijfstoeslag"
        , "EarlyRetirementRegime"
        , "Dit gegevensblok laat toe bijkomende informatie op te geven over de werkloosheid met bedrijfstoeslag."
        , "0"
        , "1"
        , "Verplicht indien Aanduiding stelsel werkloosheid met bedrijfstoeslag = 2, 3, 4, 7, 9 of 10."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90141'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90015"
        , "2023/1"
        , "28/02/2023"
        , "Tewerkstelling van de werknemerslijn"
        , "Occupation"
        , "Functioneel blok dat toelaat de gegevens in verband met een tewerkstelling aan te geven."
        , "0"
        , "99"
        , "VERPLICHT INDIEN de ASR-aangifte een werkgever anders dan een provinciaal of plaatselijk bestuur betreft."
        , "Het blok mag niet aanwezig zijn indien het werknemerskengetal betrekking heeft op een ontslagen statutaire werknemer."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90015'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90196"
        , "2023/1"
        , "28/02/2023"
        , "Tewerkstelling van de werknemerslijn PPL"
        , "NOSSLPAOccupation"
        , "Functioneel blok dat toelaat aan de werkgevers PPL om de gegevens in verband met een tewerkstelling aan te geven."
        , "0"
        , "99"
        , "VERPLICHT indien de aangifte een provinciaal en/of plaatselijk bestuur betreft"
        , "Het blok mag niet aanwezig zijn indien het werknemerskengetal betrekking heeft op een ontslagen statutaire werknemer"
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90196'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90083"
        , "2023/1"
        , "28/02/2023"
        , "Vakantiesector"
        , "HolidaysSector"
        , "Functioneel blok dat toelaat de gegevens over de vakantiesector aan te geven."
        , "0"
        , "1"
        , "Verplicht indien de identificatie van het risico '001' of '002' is."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90083'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90524"
        , "2023/1"
        , "28/02/2023"
        , "Verbrekingsvergoeding"
        , "SeverancePayment"
        , "Functioneel blok dat toelaat informatie over de verbrekingsvergoeding aan te geven."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de beëindiging van de tewerkstelling leidt tot een verbrekingsvergoeding."
        , "Het blok wordt gelinkt aan de tewerkstelling van ontslag.\nHet blok mag niet aanwezig zijn indien geen einddatum van tewerkstelling werd ingevuld of indien voor de combinatie werkgeverscategorie / werknemerskengetal geen verbrekingsvergoeding mogelijk is."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90524'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90148"
        , "2023/1"
        , "28/02/2023"
        , "Vervanger"
        , "Substitute"
        , "Identificeert de persoon die instaat voor de vervanging."
        , "0"
        , "2"
        , "Verplicht indien de werkgever niet is vrijgesteld van vervangingsplicht (Aanduiding vrijstelling van vervangingsplicht = 0) en de identiteit van de vervanger reeds gekend is (Kennis identiteit van de vervanger(s) = 1)"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90148'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90144"
        , "2023/1"
        , "28/02/2023"
        , "Vervangingsplicht"
        , "ReplacementObligation"
        , "Deze gegevens behandelen de vervangingsplicht van de werkgever."
        , "0"
        , "1"
        , "Verplicht indien de identificatie van het risico = '002' (Aangifte van einde arbeidsovereenkomst in het kader van werkloosheid met bedrijfstoeslag) en de aanduiding stelsel werkloosheid met bedrijfstoeslag (zone 00739) niet '1' is en, als het arbeidscontract eindigt voor 01/01/2015, de werknemer nog geen 60 jaar is op datum einde tewerkstelling of als het arbeidscontract eindigt na 31/12/2014, de werknemer nog geen 60 jaar is op 31/12/2014."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90144'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90103"
        , "2023/1"
        , "28/02/2023"
        , "WECH001"
        , "WECH001"
        , "Root van de XML-boodschap die toelaat aangiften van dit scenario te doen."
        , "1"
        , "1"
        , "ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90103'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90007"
        , "2023/1"
        , "28/02/2023"
        , "Werkgeversaangifte"
        , "EmployerDeclaration"
        , "Functioneel blok dat toelaat de gegevens van de aangifte aan te geven."
        , "0"
        , "*"
        , "VERPLICHT INDIEN de aangifte een werkgever aangesloten bij RSZ betreft, de provinciale en plaatselijke besturen inbegrepen indien het kwartaal van de aangifte groter of gelijk is aan 20221."
        , "Het blok mag slechts 1 maal voorkomen in het geval van een vereenvoudigde annulatie (Status van het attest = 3 en functioneel blok Werknemerslijn niet aanwezig)"
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90007'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90187"
        , "2023/1"
        , "28/02/2023"
        , "Werkgeversaangifte PPL"
        , "NOSSLPAEmployerDeclaration"
        , "Functioneel blok dat de gegevens omvat van de werkgever voor dewelke de aangifte is doorgegeven."
        , "0"
        , "*"
        , "VERPLICHT indien de aangifte een provinciaal en/of plaatselijk bestuur tot en met 20214 betreft."
        , "Het blok mag slechts 1 maal voorkomen in het geval van een vereenvoudigde annulatie (Status van het attest = 3 en functioneel blok Werknemerslijn niet aanwezig)"
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90187'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90012"
        , "2023/1"
        , "28/02/2023"
        , "Werknemerslijn"
        , "WorkerRecord"
        , "Functioneel blok dat toelaat de gegevens in verband met een werknemerslijn aan te geven."
        , "0"
        , "*"
        , "VERPLICHT INDIEN geen annulerende aangifte. VERBODEN in in alle andere gevallen."
        , "Een gegeven combinatie werkgeverscategorie / werknemerskengetal mag slechts één keer voorkomen per natuurlijk persoon"
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90012'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90060"
        , "2023/1"
        , "28/02/2023"
        , "Werkrooster"
        , "WorkGrid"
        , "Functioneel blok dat toelaat de gegevens van het werkrooster aan te geven."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de datum van de beëindiging van de arbeidsovereenkomst vóór 2016 ligt en de identificatie van het risico '001' of '002' is. VERBODEN in alle andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90060'
                          AND Version = '2023/1'
);
