
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


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90074"
        , "2023/1"
        , "28/02/2023"
        , "Aard van de dag"
        , "NatureOfDay"
        , "Functioneel blok dat toelaat de gegevens over de aard van de dagen aan te geven."
        , "1"
        , "182"
        , "ONMISBAAR\nKardinaliteit 1..182 indien het risico gelijk is aan '001', '002', '003', '005', '007' of '008'.\nKardinaliteit 1..10 indien het risico gelijk is aan '006' en de begindatum van het risico voor 01/01/2021 gelegen is\nKardinaliteit 1..15 indien het risico gelijk is aan '006' en de begindatum van het risico na 31/12/2020 gelegen is\n(en indien de dag van de bevalling na 31/12/2020 gelegen is).\nKardinaliteit 1..20 indien het risico gelijk is aan '006' en de begindatum van het risico na 31/12/2022 gelegen is\n(en indien de dag van de bevalling na 31/12/2022 gelegen is)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90074'
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
        , "Kardinaliteit 0 ..1: Verplicht indien het blok 'Communicatie' niet aanwezig is bij het blok 90257 - Coordinaten van de contactpersoon.\nKardinaliteit 0.. 1: Facultatief indien het blok de adresgegevens van het blok 90257 - Coordinaten van de contactpersoon onder het blok 90564 - Preventiedienst betreft."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90022'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90030"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis - bijzondere omstandigheden"
        , "ExceptSituationCalculBase"
        , "Functioneel blok dat toelaat informatie te geven over situaties die afwijken van de tewerkstellingsgegevens."
        , "0"
        , "1"
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN de werkne(e)m(st)er met halftijds brugpensioen is, in (volledige of gedeeltelijke) loopbaanonderbreking is of het werk heeft onderbroken om te rusten,\nten vroegste vanaf de vijfde maand van de zwangerschap, of onderworpen is aan een maatregel van tijdelijke arbeidsduurvermindering in het kader van de COVID-19-pandemie of de Brexit en bezoldigd wordt per uur of per dag."
        , "Dit blok mag niet ingevuld worden als de werkne(e)m(st)er niet per uur en niet per dag wordt bezoldigd."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90030'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90405"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis - Referteperiode"
        , "CalculBaseRefPeriod"
        , "Functioneel blok dat toelaat de referteperiode van de berekeningsbasis van de uitkeringen aan te geven voor werknemers met een bijzonder statuut."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de bezoldigingswijze 1 of 2 bedraagt of indien het een vrijwillige brandweerman (statuut van de werknemer: B), een vrijwillige ambulancier (statuut van de werknemer: VA) of een vrijwilliger van de civiele bescherming (statuut van de werknemer: VA) betreft of indien het een arbeidsongeschiktheid (= 'Identificatie van het risico' 001) van een onthaalouder betreft."
        , "Indien de begindatum van het risico gelegen is vóór 01/01/2012, mag dit blok niet ingevuld worden voor de werknemer gebonden door een industriële leerovereenkomst bedoeld in de wet van 19 juli 1983 op het leerlingwezen voor beroepen uitgeoefend door werknemers in loondienst die niet onderworpen is aan alle sectoren van de sociale zekerheid (tot 31 december van het jaar waarin hij de leeftijd van 18 bereikt - industriële leerling met het werknemerskengetal 035 of 439)."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90405'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90013"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis deeltijds"
        , "PartTimeCalculBase"
        , "Functioneel blok dat toelaat de gegevens aan te geven in verband met de deeltijdse bezoldiging (op de eerste dag van het risico of de laatste dag van het tweede kwartaal vóór het kwartaal van het risico), voor de arbeiders met halftijds brugpensioen en de werknemers (arbeiders en bedienden) in deeltijdse loopbaanonderbreking."
        , "0"
        , "1"
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN het een arbeid(st)er met halftijds brugpensioen betreft of een werkne(e)m(st)er (arbeid(st)er en bediende) in gedeeltelijke loopbaanonderbreking"
        , "Dit blok mag niet ingevuld worden als de werkne(e)m(st)er niet in gedeeltelijke loopbaanonderbreking is en als de werkne(e)m(st)er geen arbeid(st)er met halftijds brugpensioen betreft."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90013'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90552"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis Overuren - Horeca"
        , "HorecaSupplHoursCalculBase"
        , "Functioneel blok dat toelaat de overuren in de Horecasector aan te geven."
        , "0"
        , "1"
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN de werkne(e)ms(t)er tewerkgesteld is in de horecasector en overuren presteert volgens het artikel 3,5§ van de wet van 16 november 2015 houdende diverse bepalingen inzake sociale zaken (niet recupereerbaar en niet onderworpen aan sociale zekerheidsbijdragen).\nEnkel voor risico's die vanaf 30 december 2016 aanvangen.\nVerboden voor de risico's die voor 30 december 2016 aanvangen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90552'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90553"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis Overuren - Niet-Horeca"
        , "NonHorecaSupplHoursCalculBase"
        , "Functioneel blok dat toelaat de gegevens aan te geven van de overuren\n, andere dan deze in de Horecasector\n, voor zover het loon van de overuren minstens 10% van het totale loon van de referteperiode bedraagt."
        , "0"
        , "1"
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN het loon van de overuren minstens 10% van het totale loon van de referteperiode bedraagt en het bedrag ervan niet binnen het functioneel blok 90552\n(Berekeningsbasis Overuren - Horeca) aangegeven mag worden.\nEnkel voor risico's die vanaf 30 december 2016 aanvangen.\nVerboden voor de risico's die voor 30 december 2016 aanvangen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90553'
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
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN de bezoldiging wordt bepaald in functie van een tijdseenheid"
        , "Dit blok mag niet ingevuld worden voor de werknemer die een stuk- of taakloon ontvangt of die per taak\n(= prestatie) betaald wordt of die geheel of gedeeltelijk met een commissieloon betaald wordt\n, voor de vrijwillige brandweerman, de vrijwillige ambulancier, de vrijwilliger van de civiele bescherming\n, voor de onthaalouders en indien de begindatum van het risico gelegen is vóór 01/01/2012\n, ook niet voor de werknemer gebonden door een industriële leerovereenkomst bedoeld in de wet van 19 juli 1983\n op het leerlingwezen voor beroepen uitgeoefend door werknemers in loondienst die niet onderworpen\n is aan alle sectoren van de sociale zekerheid (tot 31 december van het jaar waarin hij de leeftijd van 18 bereikt\n - industriële leerling met het werknemerskengetal 035 of 439)."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90032'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90406"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis van de uitkeringen - Bijzondere bezoldigingswijze"
        , "ExceptRemunMethodCalculBase"
        , "Functioneel blok dat toelaat de gegevens van de berekeningsbasis van de uitkeringen aan te geven van werknemers een stuk- of taakloon ontvangen of per taak (= prestatie) betaald worden of geheel of gedeeltelijk met een commissieloon worden betaald, van vrijwillige brandweerlieden, van vrijwillige ambulanciers of van vrijwilligers van de civiele bescherming."
        , "0"
        , "1"
        , "VERPLICHT INDIEN de bezoldigingswijze 1 of 2 bedraagt of indien het statuut van de werknemer 'B' of 'VA' is."
        , "Dit blok mag niet ingevuld worden voor een onthaalouder."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90406'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90407"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis van de uitkeringen - Onthaalouders"
        , "ChildsitterCalculBase"
        , "Functioneel blok dat toelaat de gegevens van de berekeningsbasis van de uitkeringen voor arbeidsongeschiktheid aan te geven van onthaalouders, zoals bedoeld in artikel 3, 9§ van het KB van 28 november 1969 ter uitvoering van de wet van 27 juni 1969 (sociale zekerheid van werknemers)"
        , "0"
        , "1"
        , "VERPLICHT INDIEN het werknemerskengetal een onthaalouder betreft."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90407'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90014"
        , "2023/1"
        , "28/02/2023"
        , "Berekeningsbasis van overuren"
        , "SupplHoursCalculBase"
        , "Functioneel blok dat toelaat het bedrag aan te geven van de bezoldiging van de op regelmatige basis gepresteerde overuren of van de overuren gepresteerd in de horecasector, alsook de periode waarop deze bezoldiging betrekking heeft."
        , "0"
        , "1"
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN de werkne(e)m(st)er op regelmatige basis overuren presteert of overuren in de horecasector presteert (zie instructies). Enkel voor de risico's die voor 30 december 2016 aanvangen. Verboden voor de risico's die vanaf 30 december 2016 aanvangen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90014'
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
        , "Kardinaliteit 1: 1..99 VERPLICHT INDIEN ten minste aan bezoldiging aangegeven moet worden"
        , "Een gegeven bezoldiging (een combinatie bezoldigingscode / frequentie in maanden van de betaling van de premie / percentage van de bezoldiging op jaarbasis) mag slechts Ã©Ã©n keer voorkomen per tewerkstelling. Indien de aangifte geen gegevens m.b.t. de MiniDmfA bevat, mogen de bezoldigingen niet opgegeven worden behalve bij een verbrekingsvergoeding."
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
        , "Kardinaliteit 1:  1 VERPLICHT INDIEN de werknemerslijn betrekking heeft op een ontslagen statutaire werknemer (zie bijlage 2)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90005'
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
        , "Kardinaliteit 1: 0..1 FACULTATIEF"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90036'
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
        , "Kardinaliteit 1: Onmisbaar indien het blok de communicatiegegevens van het blok 90257 - Coordinaten van de contactpersoon voor de ASR onder het blok 90059 - Formulier betreft betreft. Kardinaliteit 0..1: Facultatief indien het blok de communicatiegegevens van het blok 90257 - Coordinaten van de contactpersoon onder het blok 90564 - Preventiedienst betreft."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90258'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90252"
        , "2023/1"
        , "28/02/2023"
        , "Detail risico"
        , "RiskDetail"
        , "Functioneel blok dat toelaat de begindatum van het risico aan te geven."
        , "0"
        , "1"
        , "0..1 VERPLICHT INDIEN  deze aangifte de aangifte van een risico betreft."
        , "Het blok mag niet aanwezig zijn bij een aangifte ZIMA001 - beperkt tot MiniDmfA, behalve indien het het onvolledige kwartaal voorafgaand aan het risico betreft."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90252'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90006"
        , "2023/1"
        , "28/02/2023"
        , "Detail tewerkstelling vÃ³Ã³r het risico"
        , "RiskDetailOccupation"
        , "Functioneel blok dat toelaat de datum aan te geven van de laatste werkdag (of gelijkgestelde dag) die voorafgaat aan het begin van het risico."
        , "0"
        , "1"
        , "Kardinaliteit 0..1 VERPLICHT INDIEN het de lopende tewerkstelling op de datum - aanvang van het risico betreft en, als geen enkele tewerkstelling lopend is bij aanvang van het risico, indien het de laatste tewerkstelling betreft die beëindigd werd binnen een periode van 14 dagen (risico's voorafgaand aan 01/01/2012) of 30 dagen (risico's vanaf 01/01/2012) voorafgaand aan de datum - aanvang van het risico."
        , "Het blok mag niet aanwezig zijn als deze aangifte alleen een mini-DmfA betreft."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90006'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90279"
        , "2023/1"
        , "28/02/2023"
        , "Detail van de relatie werkgever-werknemer"
        , "ServiceData"
        , "Functioneel blok dat toelaat informatie te geven over de relatie werkgever-werknemer."
        , "0"
        , "1"
        , "Verboden in het geval van een annulatie (Status van het attest = 3).\nIn de andere gevallen, verplicht indien de identificatie van het risico gelijk is aan '001' (arbeidsongeschiktheid)\nof '003' (volledige werkverwijdering - maatregel inzake moederschapsbescherming) of '007' (adoptieverlof)\nof '008' (pleegouderverlof) en indien het over het meest recente kwartaal gaat en indien de datum van uitdiensttreding groter\nof gelijk aan is dan de begindatum van het risico en niet meegedeeld werd bij de aangifte van indiensttreding (DIMONA IN)."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90279'
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
        , "Kardinaliteit 1: 1..* ONMISBAAR"
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
        , "Kardinaliteit 1: Onmisbaar indien het blok de contactpersoon voor de ASR onder het blok 90059 - Formulier betreft.\nKardinaliteit 0..1: Facultatief indien het blok de contactpersoon onder het blok 90564 - Preventiedienst betreft."
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
        , "0"
        , "1"
        , "Kardinaliteit: 0..1 VERPLICHT INDIEN  deze aangifte de aangifte van een risico betreft."
        , "Het blok mag niet aanwezig zijn als deze aangifte alleen een MiniDmfA betreft.\nEen aangifte ZIMA001 - beperkt tot MiniDmfA is alleen toegelaten als antwoord op een aanvraag."
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
SELECT "90017"
        , "2023/1"
        , "28/02/2023"
        , "Natuurlijke persoon"
        , "NaturalPerson"
        , "Functioneel blok dat toelaat de identificatiegegevens van een natuurlijke persoon aan te geven."
        , "1"
        , "1"
        , "Kardinaliteit 1: 1 ONMISBAAR"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90017'
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
        , "Kardinaliteit 1: 1..99 VERPLICHT INDIEN ten minste één prestatie aangegeven moet worden"
        , "Een gegeven prestatie (een prestatiecode) mag slechts één keer voorkomen per tewerkstelling.\nIndien de aangifte geen gegevens m.b.t. de MiniDmfA bevat, mogen de prestaties niet opgegeven worden."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90018'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90564"
        , "2023/1"
        , "28/02/2023"
        , "Preventiedienst"
        , "PreventionService"
        , "Functioneel blok dat toelaat de gegevens over de dienst voor preventie en bescherming op het werk aan te geven."
        , "0"
        , "5"
        , "Verboden in het geval van een annulatie (Status van het attest = 3).\nIn de andere gevallen, verplicht indien de identificatie van het risico gelijk is aan '001' (arbeidsongeschiktheid) en indien gekend en correct.\n Enkel voor risico's die vanaf 1 december 2016 aanvangen.\n Verboden voor de risico's die voor 1 december 2016 aanvangen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90564'
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
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN de aangifte een antwoord op een aanvraag is of een wijziging of een annulatie betreft"
        , "- Per referentietype mag slechts één blok 'Referentie' dat een ticketnummer is, aangegeven worden.\n- Indien het type formulier 'SU' betreft, zijn alle waarden overeenkomstig het glossarium, behalve de waarde '5' voor de zone 00221 Type van de referentie toegelaten als de 'Referentie' een ticketnummer betreft.\n- Indien het type formulier 'FA' betreft, is alleen de waarde '5' voor de zone 00221 Type van de referentie toegelaten als de 'Referentie' een ticketnummer betreft.\n- Indien de 'status van het attest' een 'wijziging van een papieren origineel' is, mag geen enkel blok 'Referentie' met een ticketnummer aangegeven worden.\n- Indien de 'status van het attest' een 'wijziging' of een 'annulatie' is, moet juist één blok 'Referentie' met een ticketnummer en referentietype '3' aangegeven worden.\nIn geen enkele andere situatie mag soortgelijke referentie aangegeven worden."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90082'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90077"
        , "2023/1"
        , "28/02/2023"
        , "Referteperiode"
        , "ReferencePeriod"
        , "Functioneel blok dat toelaat de referteperiode aan te geven."
        , "0"
        , "1"
        , "Kardinaliteit 1: 0..1 VERPLICHT INDIEN het risico gelijk is aan '001', '002', '003', '005', '006', '007' of '008' (zie instructies)."
        , "Het blok mag niet aanwezig zijn als de identificatie van het risico gelijk is aan '004'."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90077'
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
        , "Kardinaliteit 1: 1..99 VERPLICHT INDIEN de de ASR-aangifte een werkgever anders dan een provinciaal of plaatselijk bestuur betreft."
        , "Het blok mag niet aanwezig zijn indien de werknemerslijn (blok 90012) een ontslagen statutaire werknemer (werknemerskengetal 876) betreft.\nIn dit geval wordt de tewerkstelling, die juist voorafgaat aan het ontslag, immers gekoppeld aan de werknemerslijn waarvoor het werknemerskengetal met '6' begint"
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
        , "Kardinaliteit 1: 1..99 VERPLICHT indien de aangifte een provinciaal en/of plaatselijk bestuur betreft"
        , "Het blok mag niet aanwezig zijn indien de werknemerslijn (blok 90012) een ontslagen statutaire werknemer (werknemerskengetal 671) betreft.\nIn dit geval wordt de tewerkstelling, die juist voorafgaat aan het ontslag\n, immers gekoppeld aan de werknemerslijn waarvoor het werknemerskengetal gelijk is aan '601' of '602'"
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90196'
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
SELECT "90029"
        , "2023/1"
        , "28/02/2023"
        , "Voordelen in natura en vergoedingen voor de overdracht van auteursrechten"
        , "NatureAdvantage"
        , "Functioneel blok dat toelaat de periode aan te geven tijdens dewelke de werknemer voordelen in natura en vergoedingen voor de overdracht van auteursrechten blijft genieten gedurende het risico\n, alsook het bedrag van deze voordelen per werkdag."
        , "0"
        , "10"
        , "Kardinaliteit 1: 1..10 VERPLICHT INDIEN de werknemer voordelen in natura en/of vergoedingen voor de overdracht van auteursrechten blijft ontvangen gedurende een risico '001', '002', '003, '005', '006', '007' of '008'."
        , "Het blok mag niet aanwezig zijn als de identificatie van het risico gelijk is aan '004'. Er mag slechts één blok per toekenningsperiode ingevuld worden."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90029'
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
        , "Kardinaliteit 1: 1 VERPLICHT INDIEN de aangifte een werkgever aangesloten bij RSZ betreft, de provinciale en plaatselijke besturen inbegrepen indien het kwartaal van de aangifte groter of gelijk is aan 20221."
        , "Het blok mag slechts 1 maal voorkomen in het geval van een annulatie (Status van het attest = 3)"
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
        , "Kardinaliteit 1: 1 VERPLICHT indien de aangifte een provinciaal en/of plaatselijk bestuur tot en met 20214 betreft."
        , "Het blok mag slechts 1 maal voorkomen in het geval van een annulatie (Status van het attest = 3)"
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90187'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90016"
        , "2023/1"
        , "28/02/2023"
        , "Werkhervatting"
        , "WorkRecovery"
        , "Functioneel blok dat toelaat informatie over werkhervatting aan te geven"
        , "0"
        , "1"
        , "Verboden in het geval van een annulatie (Status van het attest = 3). Facultatief in de andere gevallen."
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90016'
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
        , "Verplicht indien geen annulatie. Verboden in het geval van een annulatie."
        , "Een gegeven combinatie werkgeverscategorie / werknemerskengetal mag slechts Ã©Ã©n keer voorkomen per natuurlijk persoon."
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90012'
                          AND Version = '2023/1'
);


INSERT OR REPLACE INTO functional_blocks(Code, Version, PublicationDay, Name, XmlLabel
    , DescriptionNL, MinimalCardinality, MaximumCardinality, Presence, ExtraRestrictions)
SELECT "90138"
        , "2023/1"
        , "28/02/2023"
        , "ZIMA001"
        , "ZIMA001"
        , "Root van de XML-boodschap die toelaat aangiften van dit scenario te doen."
        , "1"
        , "1"
        , "Kardinaliteit 1 : 1 Onmisbaar"
        , ""
WHERE NOT EXISTS (SELECT * FROM functional_blocks
                    WHERE Code = '90138'
                          AND Version = '2023/1'
);
