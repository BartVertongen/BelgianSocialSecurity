

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00988"
        , "2023/1"
        , "28/02/2023"
        , "AANDUIDING BELGISCH DIPLOMA"
        , "BelgianDegree"
        , "Titels en diploma's"
        , "Zone waarin aangegeven kan worden of het diploma of de titel in kwestie Belgisch of buitenlands is."
        , "
               0 : buitenlands diploma
               1 : Belgisch diploma
          "
        , ""
        , "numeric"
        , "1"
        , "required"
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00988'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01003"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL DAGEN"
        , "DaysNbr"
        , "Niet-situeerbaar afwezigheid"
        , "Voor de opgegeven afwezigheidscode is dit het aantal dagen afwezigheid van de werknemer in de loop van het betreffende kalenderjaar."
        , "Geheel getal en element van [0,999]In dit bericht geheel getal en element van [1,366]"
        , ""
        , "numeric"
        , "3"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01003'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00982"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL UREN OF PRESTATIES"
        , "NbrHoursOrServices"
        , "Weddebijslag - historische gegevens"
        , "Voor een per uur of per prestatie betaald supplement komt het aantal opgegeven in deze zone overeen met het aantal uren 
               of het aantal prestaties geleverd tijdens de in aanmerking genomen periode.
          "
        , "
               Geheel getal en element van [1;9999999].
               De uren worden uitgedrukt in honderdsten van uren. 
               Het aantal prestaties of eenheden wordt uitgedrukt in honderdsten. 
               Voorbeelden:
               . 38 uren 20 min. wordt uitgedrukt in de vorm: 3833 
               . 38 uren wordt uitgedrukt in de vorm: 3800 
               . 1 prestatie/eenheid wordt uitgedrukt in de vorm : 100
          "
        , ""
        , "numeric"
        , "7"
        , "Verplicht indien de referentie van de weddebijslag dit vereist."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00982'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00975"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL UREN PER WEEK"
        , "WeekHoursNbr"
        , "Baremieke wedde - historische gegevens"
        , "
               Dit is het aantal uren op basis van het welke de wedde van de werknemer berekend wordt of
               , als die werknemer een afwezigheid geniet, op basis van het welke zijn wedde zou berekend worden als hij die afwezigheid niet zou genieten.
          "
        , "
               De uren worden uitgedrukt in honderdsten van uren.
               Geheel getal gelegen tussen [0;4800].
               Voorbeelden:
               . 38 uren 20 min. wordt uitgedrukt in de vorm: 3833
               . 38 uren wordt uitgedrukt in de vorm: 3800
          "
        , ""
        , "numeric"
        , "4"
        , "Verplicht indien de lijn "Baremieke wedde" (FB 90420) samenvalt met ten minste ï¿½ï¿½n andere lijn "Baremieke wedde" (FB 90420).
     Verplicht indien de zone 00976 "Aantal uren per week - volledige baremieke wedde" aanwezig is."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00975'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00976"
        , "2023/1"
        , "28/02/2023"
        , "AANTAL UREN PER WEEK - VOLLEDIGE BAREMIEKE WEDDE"
        , "ScaleSalaryWeekHoursNbr"
        , "Baremieke wedde ï¿½ historische gegevens"
        , "Dit is het aantal uren dat met een volledige baremieke wedde overeenstemt voor de door de werknemer uitgeoefende functie."
        , "De uren worden uitgedrukt in honderdsten van uren.
     Geheel getal gelegen tussen [1;4800]."
        , ""
        , "numeric"
        , "4"
        , "Verplicht indien de zone 00975 "Aantal uren per week" aanwezig is.
     Verplicht indien de waarde verschilt van die in de zone 00049 "Gemiddeld aantal uren per week van de maatpersoon"."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00976'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00925"
        , "2023/1"
        , "28/02/2023"
        , "AANVULLENDE ADRESGEGEVENS"
        , "AddressDetails"
        , "Aanvullende contactgegevens"
        , ""
        , "In dit bericht is de toegelaten lengte voor deze zone 200 tekens."
        , ""
        , "Alfanumeric"
        , "1000"
        , "Verplicht indien het attest gegevens voor de contactpersoon bevat en hierbij geen van de zones 00637 (E-MAILADRES) en 00677 (TELEFOONNUMMER) is ingevuld."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00925'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00996"
        , "2023/1"
        , "28/02/2023"
        , "AARD VAN DE ARBEIDSRELATIE - OVERHEIDSSECTOR"
        , "PSEmploymentRelationshipNature"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die de aard van de arbeidsrelatie van een werknemer uit de overheidssector aangeeft."
        , "1 : Statutair - definitief
     2 : Statutair - stagiair
     3 : Statutair - tijdelijk
     4 : Contractueel - gewoon
     5 : Contractueel - precair statuut"
        , ""
        , "numeric"
        , "1"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00996'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00967"
        , "2023/1"
        , "28/02/2023"
        , "AARD VAN DE DIENST"
        , "AssignmentType"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die voor de werknemer titularis van een betrekking - vermeld in de tabel bij de wet van 21/07/1844 - aanduidt of hij al dan niet in actieve dienst is."
        , "0 = binnendienst
     1 = actieve dienst"
        , ""
        , "numeric"
        , "1"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00967'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00968"
        , "2023/1"
        , "28/02/2023"
        , "AARD VAN DE FUNCTIE"
        , "FunctionNature"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die de aard aanduidt van de door de werknemer uitgeoefende functie."
        , "1 = hoofdambt
     2 = bijbetrekking
     3 = bijbetrekking in het onderwijs met beperkt leerplan"
        , ""
        , "numeric"
        , "1"
        , "Verplicht indien de werknemer een functie uitoefent in het onderwijs, dit wil zeggen indien de zone 00961 "Type instelling van de overheidssector" ingevuld is en gelijk is aan ï¿½ï¿½n van de volgende waarden: 25, 26, 27, 52, 53, 54, 62, 63 of 64."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00968'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00980"
        , "2023/1"
        , "28/02/2023"
        , "BASISBEDRAG VAN DE WEDDEBIJSLAG"
        , "AdditionalScaleSalaryBasisAmount"
        , "Weddebijslag ï¿½ historische gegevens"
        , "Dit is het forfaitaire basisbedrag voor een weddebijslag aangegeven onder de vorm van een aantal uren of prestaties."
        , "Positief geheel getal en element van [1; 99999999999].
     Het basisbedrag wordt uitgedrukt in eurocenten."
        , ""
        , "numeric"
        , "11"
        , "Facultatief . Verplicht voor validatie indien de zone 00982 "Aantal uren of prestaties" ingevuld is."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00980'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00974"
        , "2023/1"
        , "28/02/2023"
        , "BEDRAG VAN DE BAREMIEKE WEDDE"
        , "ScaleSalaryAmount"
        , "Baremieke wedde ï¿½ historische gegevens"
        , "Baremieke wedde (gekoppeld aan de spilindex 138,01) waarop de werknemer, rekening houdend met zijn geldelijke anciï¿½nniteit, recht heeft of recht zou hebben indien hij in dienst was gebleven."
        , "Positief geheel getal en element van [1; 99999999999].
     Het bedrag wordt uitgedrukt in eurocenten."
        , ""
        , "numeric"
        , "11"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00974'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00983"
        , "2023/1"
        , "28/02/2023"
        , "BEDRAG VAN DE WEDDEBIJSLAG"
        , "AdditionalScaleSalaryAmount"
        , "Weddebijslag ï¿½ historische gegevens"
        , "Dit is het bedrag van de weddebijslag (gekoppeld aan de spilindex 138,01) waarop de werknemer recht heeft of recht zou hebben indien hij in dienst was gebleven."
        , "Positief geheel getal en element van [1; 99999999999].
     Het bedrag wordt uitgedrukt in eurocenten."
        , ""
        , "numeric"
        , "11"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00983'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00776"
        , "2023/1"
        , "28/02/2023"
        , "BENAMING"
        , "Denomination"
        , "Aanvullende contactgegevens"
        , ""
        , ""
        , ""
        , "Alfanumeric"
        , "96"
        , "Verplicht indien de zone 01029 (TYPE HISTORISCH ATTEST) gelijk is aan "5" (attest voor de regularisatie van de loopbaangeschiedenis van de werknemer)."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00776'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00991"
        , "2023/1"
        , "28/02/2023"
        , "BESCHRIJVING VAN DE WERKGEVER"
        , "EmployerDescription"
        , "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"
        , ""
        , ""
        , ""
        , "Alfanumeric"
        , "96"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00991'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00032"
        , "2023/1"
        , "28/02/2023"
        , "BRIEVENBUS VAN DE WERKNEMER"
        , "WorkerPostBox"
        , "Natuurlijke persoon"
        , "Nummer van een brievenbus.
     Busnummer in het adres van de werknemer.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , ""
        , ""
        , "Alfanumeric"
        , "4"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00032'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01002"
        , "2023/1"
        , "28/02/2023"
        , "CODE VOOR NIET-SITUEERBARE AFWEZIGHEID"
        , "NonSituableAbsenceCode"
        , "Niet-situeerbaar afwezigheid"
        , "Code die toelaat de niet-situeerbare afwezigheid te omschrijven"
        , "Zie Bijlage 8 - Codificatie van arbeidstijdgegevens.
     Alleen de codes 31, 32, 33, 41, 42 en 43 zijn van toepassing om een niet-situeerbare afwezigheid aan te geven."
        , ""
        , "numeric"
        , "2"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01002'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00970"
        , "2023/1"
        , "28/02/2023"
        , "DATUM BEGIN - BAREMIEKE WEDDE"
        , "ScaleSalaryStartDate"
        , "Baremieke wedde ï¿½ historische gegevens"
        , "
     Dit is de begindatum van de periode waarop de gegevens van de baremieke wedde betrekking hebben.Indien die gegevens onveranderd zijn, gaat het om de begindatum van het element van de loopbaangeschiedenis waarvan die gegevens afhangen."
        , ""
        , ""
        , "Alfanumeric"
        , "10"
        , "required "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00970'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00978"
        , "2023/1"
        , "28/02/2023"
        , "DATUM BEGIN - WEDDEBIJSLAG"
        , "AdditionalScaleSalaryStartDate"
        , "Weddebijslag ï¿½ historische gegevens"
        , "
     Dit is de begindatum van de periode waarop de gegevens van de weddebijslag betrekking hebben.Indien die gegevens onveranderd zijn, gaat het om de begindatum van de baremieke wedde waarvan die gegevens afhangen."
        , ""
        , ""
        , "Alfanumeric"
        , "10"
        , "required "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00978'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00994"
        , "2023/1"
        , "28/02/2023"
        , "DATUM BEGIN VAN HET ELEMENT VAN DE LOOPBAANGESCHIEDENIS"
        , "CareerElementStartDate"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "
     Dit is de begindatum van het element uit de loopbaan van de werknemer.
     Als dit element niet veranderd is sedert de indiensttreding van de werknemer bij de werkgever, dan komt deze datum overeen met de datum van indiensttreding bij de werkgever.
     Als dit element gewijzigd werd (bijvoorbeeld: de aard van de arbeidsrelatie is veranderd, de werknemer is afwezig geweest, zijn tewerkstellingsbreuk werd gewijzigd, enz.), dan komt deze datum overeen met het begin van de periode waarop de nieuwe gegevens van het element uit de loopbaan van de werknemer betrekking hebben."
        , "
     Jaar gelegen tussen [jaar van de aangifte - 100 ; jaar van de aangifte]"
        , ""
        , "Alfanumeric"
        , "10"
        , "required "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00994'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00971"
        , "2023/1"
        , "28/02/2023"
        , "DATUM EIND - BAREMIEKE WEDDE"
        , "ScaleSalaryEndDate"
        , "Baremieke wedde ï¿½ historische gegevens"
        , "
     Dit is de einddatum van de periode waarop de gegevens van de baremieke wedde betrekking hebben.Indien die gegevens onveranderd zijn, gaat het om de einddatum van het element van de loopbaangeschiedenis waarvan die gegevens afhangen."
        , "
     De einddatum van de baremieke wedde is kleiner dan of gelijk aan de einddatum van de lijn "Gegevens van de tewerkstelling met betrekking tot de overheidssector" of van de lijn "Element van de loopbaangeschiedenis van de werknemer" waarvan de lijn "Baremieke wedde" afhangt."
        , ""
        , "Alfanumeric"
        , "10"
        , "required "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00971'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00979"
        , "2023/1"
        , "28/02/2023"
        , "DATUM EIND - WEDDEBIJSLAG"
        , "AdditionalScaleSalaryEndDate"
        , "Weddebijslag ï¿½ historische gegevens"
        , "
     Dit is de einddatum van de periode waarop de gegevens van de weddebijslag betrekking hebben.Indien die gegevens onveranderd zijn, gaat het om de einddatum van de baremieke wedde waarvan die gegevens afhangen."
        , "
     De einddatum van de weddebijslag is kleiner dan of gelijk aan de einddatum van de wedde van de lijn "Baremieke wedde" waarvan de lijn "Weddebijslag" afhangt."
        , ""
        , "Alfanumeric"
        , "10"
        , "required "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00979'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00995"
        , "2023/1"
        , "28/02/2023"
        , "DATUM EIND VAN HET ELEMENT VAN DE LOOPBAANGESCHIEDENIS"
        , "CareerElementEndDate"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "
     Dit is de einddatum van het element uit de loopbaan van de werknemer.
     Deze datum sluit elke periode af waarin de elementen uit de loopbaan onveranderd zijn gebleven.
     Als de periode in kwestie overeenkomt met het laatste element uit de loopbaan van de werknemer, dan wijst deze datum op het einde van de tewerkstelling van de werknemer bij de betreffende werkgever."
        , ""
        , ""
        , "Alfanumeric"
        , "10"
        , "required "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00995'
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
        , "
     Datum waarop het formulier gecreï¿½erd is."
        , "
     JJJJ is een element van [lopend jaar -1 ; lopend jaar] ;
     De datum mag zich niet in de toekomst bevinden."
        , ""
        , "Alfanumeric"
        , "10"
        , "required "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00218'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00972"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VAN RANGINNEMING IN DE GELDELIJKE ANCIï¿½NNITEIT"
        , "PecuniarySeniorityStartDate"
        , "Baremieke wedde ï¿½ historische gegevens"
        , "Dit is de datum, uitgedrukt in jaar en maand, vanaf wanneer de door de werknemer opgebouwde geldelijke anciï¿½nniteit telt zonder onderbreking. De geldelijke anciï¿½nniteit laat toe om de trap van de weddeschaal te bepalen waarmee de basiswedde van de werknemer overeenstemt. De datum van ranginneming wijzigt enkel wanneer de geldelijke anciï¿½nniteit van de werknemer opnieuw moet worden berekend."
        , "Geldelijke anciï¿½nniteit.
     Jaar gelegen tussen [jaar van de aangifte - 100 ; jaar van de aangifte en laatste maand van het kalenderkwartaal].
     Om aan te duiden dat de geldelijke anciï¿½nniteit niet van toepassing is, zal men "9999-12" opgeven. "
        , ""
        , "Alfanumeric"
        , "7"
        , "required "
        , "JJJJ-MM
     . JJJJ is het jaar
     . MM is de maand")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00972'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00987"
        , "2023/1"
        , "28/02/2023"
        , "DATUM VAN UITREIKING VAN DE TITEL OF HET DIPLOMA"
        , "DegreeGrantingDate"
        , "Titels en diploma's"
        , "
     Datum waarop het diploma of de titel werd uitgereikt"
        , "De datum moet gelegen zijn tussen 01/01/1950 en 31/12/2010."
        , ""
        , "Alfanumeric"
        , "10"
        , "required "
        , "JJJJ-MM-DD
     ï¿½ JJJJ is het jaar
     ï¿½ MM is de maand
     . DD is de dag")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00987'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00028"
        , "2023/1"
        , "28/02/2023"
        , "DATUM WAAROP DE WERKNEMER GEBOREN IS"
        , "WorkerBirthdate"
        , "Natuurlijke persoon"
        , "Geboortedatum van de natuurlijke persoon.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , " JJJJ is een element van [jaar van de aangifte -120; jaar van de aangifte]."
        , ""
        , "Alfanumeric"
        , "10"
        , "Facultatief "
        , "JJJJ-MM-DD (geldige datum)
     JJJJ-00-00")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00028'
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
        , "Alfanumeric"
        , "60"
        , "Verplicht indien het attest gegevens voor de contactpersoon bevat en hierbij geen van de zones 00677 (TELEFOONNUMMER) en 00925 (AANVULLENDE ADRESGEGEVENS) is ingevuld (voorwaarden geldig wanneer de zone gebruikt wordt in het FB 90258 (Communicatie));
     facultatief indien de zone behoort tot het FB 90437 (Informatie over het historisch attest)."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00637'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00637"
        , "2023/1"
        , "28/02/2023"
        , "E-MAILADRES"
        , "EmailAddress"
        , "Informatie over het historisch attest"
        , ""
        , ""
        , ""
        , "Alfanumeric"
        , "60"
        , "Verplicht indien het attest gegevens voor de contactpersoon bevat en hierbij geen van de zones 00677 (TELEFOONNUMMER) en 00925 (AANVULLENDE ADRESGEGEVENS) is ingevuld (voorwaarden geldig wanneer de zone gebruikt wordt in het FB 90258 (Communicatie));
     facultatief indien de zone behoort tot het FB 90437 (Informatie over het historisch attest)."
        , "")
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
        , "Alfanumeric"
        , "20"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00678'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00990"
        , "2023/1"
        , "28/02/2023"
        , "FPD-NUMMER VAN DE WERKGEVER"
        , "PSPSEmployerNbr"
        , "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"
        , "Nummer dat een werkgever eenduidig identificeert binnen de FPD.
     Deze identificatie wordt gebruikt voor bepaalde werkgevers die niet meer bestaan en die in het kader van de samenstelling van het pensioendossier geï¿½dentificeerd moeten worden aan de hand van een uniek nummer geleverd door de FPD."
        , "Geheel getal en element van [1;99999]"
        , ""
        , "numeric"
        , "5"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00990'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00168"
        , "2023/1"
        , "28/02/2023"
        , "GEMEENTE - GEBOORTEPLAATS VAN DE WERKNEMER"
        , "WorkerBirthplace"
        , "Natuurlijke persoon"
        , "Naam van een gemeente.
     Naam van de gemeente waar de natuurlijke persoon geboren is.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , ""
        , ""
        , "Alfanumeric"
        , "40"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00168'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00034"
        , "2023/1"
        , "28/02/2023"
        , "GEMEENTE VAN DE WERKNEMER"
        , "WorkerCity"
        , "Natuurlijke persoon"
        , "Naam van een gemeente.
     Naam van de gemeente waar de werknemer gedomicilieerd is.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "
     Indien het gaat om een Belgische gemeente, moet de waarde verwijzen naar ï¿½ï¿½n van de namen die in bijlage 23 overeenstemmen met de in zone 00033 (postcode van de werknemer) opgegeven postcode."
        , ""
        , "Alfanumeric"
        , "40"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00034'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00997"
        , "2023/1"
        , "28/02/2023"
        , "GEMIDDELD AANTAL UREN PER WEEK IN HET BASISUURROOSTER VAN DE WERKNEMER"
        , "BasicMeanWorkingHours"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Gemiddeld aantal uren per week (uitgedrukt in honderdsten van uren) tijdens dewelke de werknemer geacht wordt arbeid te verrichten overeenkomstig zijn arbeidsovereenkomst. 
     Voor een werknemer die voltijds of deeltijds afwezig is (vakantie, disponibiliteit, loopbaanonderbrekingï¿½) blijft dit aantal gelijk aan het aantal uren voorzien in de arbeidsovereenkomst van de werknemer.
     Het gemiddel aantal uren per week in het uurrooster van de werknemer gedeeld door het gemiddeld aantal uren per week van de maatpersoon bepaalt de tewerkstellingsbreuk van de werknemer, en ingeval hij afwezig is, ook de tewerkstellingsbreuk die van toepassing zou zijn als de werknemer niet afwezig was.
     Met maatpersoon bedoelt men de voltijds tewerkgestelde persoon in dezelfde onderneming of, bij gebrek hieraan, in dezelfde activiteitensector, in een analoge functie."
        , "[1;4800]
     Let op: De uren worden uitgedrukt in honderdsten van uren.
     Voorbeelden: 
     . 38 uren 20 min. wordt uitgedrukt in de vorm: 3833
     . 38 uren wordt uitgedrukt in de vorm: 3800
     Voor een onthaalouder moet het gemiddeld aantal uren per week van de maatpersoon gelijk zijn aan 38 uur per week (3800)"
        , ""
        , "numeric"
        , "4"
        , "Verplicht indien de waarde van de zone 00050 "Type arbeidsovereenkomst" gelijk is aan "1" (deeltijds) en er een maatregel tot reorganisatie van de arbeidstijd bestaat (zone 00051)."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00997'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00049"
        , "2023/1"
        , "28/02/2023"
        , "GEMIDDELD AANTAL UREN PER WEEK VAN DE MAATPERSOON"
        , "RefMeanWorkingHours"
        , "Element van de loopbaangeschiedenis van de werknemer"
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
     Voor een onthaalouder moet het gemiddelde aantal uren per week van de maatpersoon altijd gelijk zijn aan 38 uur per week (3800)"
        , ""
        , "numeric"
        , "4"
        , "required "
        , "")
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
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Gemiddeld aantal uren per week (uitgedrukt in honderdsten van uren) tijdens dewelke de werknemer geacht wordt arbeid uit te voeren overeenkomstig zijn arbeidsovereenkomst, een eventuele schorsing van de overeenkomst buiten beschouwing gelaten.
     Het gemiddeld aantal uren per week van de werknemer gedeeld door het gemiddeld aantal uren per week van de maatpersoon bepaalt de prestatiebreuk van de werknemer.
     Onder maatpersoon verstaan we de persoon die voltijds tewerkgesteld is in dezelfde onderneming, of, bij gebrek hieraan, in dezelfde activiteitstak, in een functie analoog aan die van de werknemer."
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
     . 38 uren wordt uitgedrukt onder de vorm : 3800"
        , ""
        , "numeric"
        , "4"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00048'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00029"
        , "2023/1"
        , "28/02/2023"
        , "GESLACHT VAN DE WERKNEMER"
        , "WorkerSex"
        , "Natuurlijke persoon"
        , "Geslacht van een natuurlijk persoon.
     Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "1 = man
     2 = vrouw
     "
        , ""
        , "numeric"
        , "1"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00029'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00999"
        , "2023/1"
        , "28/02/2023"
        , "GESUBSIDIEERDE VESTIGING"
        , "GrantAidedSchool"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die aangeeft of de onderwijsvestiging gesubsidieerd wordt"
        , "0 : de vestiging wordt niet gesubsidieerd
     1 : de vestiging wordt gesubsidieerd"
        , ""
        , "numeric"
        , "1"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00999'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00963"
        , "2023/1"
        , "28/02/2023"
        , "GRAAD- OF FUNCTIEBENAMING"
        , "GradeOrFunction"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Tekst die ofwel de graad van de werknemer vermeldt ofwel de functie die hij uitoefent"
        , ""
        , ""
        , "Alfanumeric"
        , "100"
        , "Verplicht indien de aangevende werkgever Defensie is."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00963'
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
        , "Alfanumeric"
        , "20"
        , "Facultatief "
        , "")
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
        , "Waarde die de authentieke bron van een referentienummer aanduidt.
     "
        , "1 = het referentienummer is toegekend door een aangever of aanvrager (een bedrijf, een sociaal secretariaat, een softwareontwikkelaar, ...)
     2 = het ticketnummer toegekend door de sociale zekerheid, dat een aangifte, een aanvraag of een antwoord op eenduidige wijze identificeert
     3 = het referentienummer is toegekend door een sector van de sociale zekerheid
     4 = het referentienummer is toegekend door de dienst ePost
     5 = het referentienummer is toegekend door de KSZ
     6 = het referentienummer is toegekend door het archiveringssysteem (DOC-ID)
     7 = het referentienummer is door de DSP aan een gearchiveerd document toegekend (DSP-ID)
     De toegelaten waarden zijn: '1', '2' en '3'."
        , ""
        , "numeric"
        , "1"
        , "required "
        , "")
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
        , "Zone die de inhoud van een formulier beschrijft.
     "
        , "Zie bijlage 11 - Identificatie van het formulier.
     Deze zone moet als waarde "CDHG001" hebben."
        , ""
        , "Alfanumeric"
        , "7"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00296'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00024"
        , "2023/1"
        , "28/02/2023"
        , "IDENTIFICATIENUMMER BIJ DE SOCIALE ZEKERHEID - INSZ"
        , "INSS"
        , "Natuurlijke persoon"
        , "Identificatienummer van een natuurlijk persoon binnen de sociale zekerheid. Dit is het identificatienummer van de natuurlijke persoon in het rijksregister of in het bisregister van de natuurlijke personen.
     "
        , ""
        , ""
        , "numeric"
        , "11"
        , "required "
        , "0 of NNNNNNNNNCC
     ï¿½ NNNNNNNNN is het nummer
     ï¿½ CC is het controlegetal.")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00024'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00027"
        , "2023/1"
        , "28/02/2023"
        , "INITIAAL VAN DE TWEEDE VOORNAAM VAN DE WERKNEMER"
        , "WorkerInitial"
        , "Natuurlijke persoon"
        , "Initiaal van de tweede voornaam van een natuurlijk persoon.
     Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "Een letter uit het alfabet.
     "
        , ""
        , "Alfanumeric"
        , "1"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00027'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01004"
        , "2023/1"
        , "28/02/2023"
        , "KALENDERJAAR"
        , "CalendarYear"
        , "Niet-situeerbaar afwezigheid"
        , "Kalenderjaar waarin de werknemer afwezig was omwille van de opgegeven code. Dat jaar moet gelegen zijn in een jaar opgenomen in een loopbaanelement."
        , "[1900,9999]"
        , ""
        , "numeric"
        , "4"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01004'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00992"
        , "2023/1"
        , "28/02/2023"
        , "KARAKTER VAN DE LOOPBAAN VAN DE WERKNEMER BIJ DE WERKGEVER"
        , "CareerNature"
        , "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"
        , "Zone die toelaat het karakter van de loopbaan van de werknemer bij de werkgever aan te duiden. Zij biedt een antwoord op de bijzondere situatie waarbij de werknemer tegelijk twee verschillende loopbanen uitoefent bij dezelfde werkgever, de ene wordt beschouwd als "hoofdloopbaan" en de andere als "bijloopbaan". Deze situatie is specifiek voor het onderwijs."
        , "1 = Hoofdloopbaan
     2 = Bijloopbaan"
        , ""
        , "numeric"
        , "1"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00992'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00059"
        , "2023/1"
        , "28/02/2023"
        , "KLASSE VAN HET VLIEGEND PERSONEEL"
        , "FlyingStaffClass"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Deze code, die voornamelijk bestemd is voor luchtvaartmaatschappijen, laat toe de categorie te bepalen waartoe een werknemer behoort die tewerkgesteld is aan boord van een vliegtuig. Het bijbehorende aantal vliegminuten moet aangegeven worden.
     Deze code moet ook gebruikt worden om militaire piloten aan te duiden.
     "
        , "1 = piloot
     2 = cabinepersoneel
     3 = andere
     "
        , ""
        , "numeric"
        , "1"
        , "Verplicht indien de werknemer deel uitmaakt van het vliegend personeel van een luchtvaartmaatschappij of als het om een militaire piloot gaat."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00059'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00169"
        , "2023/1"
        , "28/02/2023"
        , "LANDCODE VAN DE GEBOORTEPLAATS VAN DE WERKNEMER"
        , "WorkerBirthplaceCountry"
        , "Natuurlijke persoon"
        , "Code die toelaat een land te identificeren.
     Code om het land van de geboorteplaats van de natuurlijke persoon op een unieke wijze te identificeren.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "Zie Bijlage 5 - Lijst met landcodes.
     "
        , ""
        , "numeric"
        , "5"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00169'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00035"
        , "2023/1"
        , "28/02/2023"
        , "LANDCODE VAN DE WERKNEMER"
        , "WorkerCountry"
        , "Natuurlijke persoon"
        , "Code die toelaat een land te identificeren.
     Code waarmee men het land kan identificeren waar de werknemer gedomicilieerd is.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "Zie Bijlage 5 - Lijst met landcodes.
     "
        , ""
        , "numeric"
        , "5"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00035'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00051"
        , "2023/1"
        , "28/02/2023"
        , "MAATREGEL TOT REORGANISATIE VAN DE ARBEIDSTIJD"
        , "ReorganisationMeasure"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die aangeeft dat de werknemer tewerkgesteld is in het kader van een maatregel tot vermindering van de arbeidstijd, los van het feit of een eventuele bij de maatregel horende vermindering van de bijdragen wordt gevraagd.
     Deze code wordt ook gebruikt om aan te duiden dat de werknemer effectieve arbeidsprestaties levert waarvoor hij een verminderd loon ontvangt."
        , "Zie bijlage 44 : Maatregelen tot reorganisatie van de arbeidstijd."
        , ""
        , "numeric"
        , "3"
        , "Verplicht indien de waarde van de zone 00050 "Type arbeidsovereenkomst" gelijk is aan "0" (voltijds) en de verhouding "Gemiddeld aantal uren per week van de werknemer" (zone 00048) / "Gemiddeld aantal uren per week van de maatpersoon" (zone 00049) < 1.
     Verplicht indien de waarde van de zone 00048 "Gemiddeld aantal uren per week van de werknemer" gelijk is aan "0"."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00051'
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
        , "Alfanumeric"
        , "48"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00726'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00025"
        , "2023/1"
        , "28/02/2023"
        , "NAAM VAN DE WERKNEMER"
        , "WorkerName"
        , "Natuurlijke persoon"
        , "Familienaam van een natuurlijk persoon.
     Men moet de naam vermelden die op het paspoort of de identiteitskaart staat.
     Voor vrouwen van Belgische nationaliteit gaat het om de meisjesnaam.
     "
        , ""
        , ""
        , "Alfanumeric"
        , "48"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00025'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00119"
        , "2023/1"
        , "28/02/2023"
        , "NATIONALITEIT VAN DE WERKNEMER"
        , "Nationality"
        , "Natuurlijke persoon"
        , "Code die de nationaliteit van de werknemer aanduidt.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "Zie Bijlage 5 - Lijst met landcodes."
        , ""
        , "numeric"
        , "5"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00119'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00167"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN DE SOCIALE IDENTITEITSKAART"
        , "SIS"
        , "Natuurlijke persoon"
        , "Nummer van de sociale identiteitskaart van een natuurlijk persoon (SIS).
     Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "Getal van 10 cijfers.
     "
        , ""
        , "numeric"
        , "10"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00167'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00031"
        , "2023/1"
        , "28/02/2023"
        , "NUMMER VAN HET ADRES VAN DE WERKNEMER"
        , "WorkerHouseNbr"
        , "Natuurlijke persoon"
        , "
     Nummer van de woonplaats van de werknemer.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , ""
        , ""
        , "Alfanumeric"
        , "10"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00031'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00985"
        , "2023/1"
        , "28/02/2023"
        , "OFFICIï¿½LE BENAMING VAN DE TITEL OF HET DIPLOMA"
        , "DegreeDenomination"
        , "Titels en diploma's"
        , "Officiï¿½le benaming die op de titel of het diploma staat"
        , ""
        , ""
        , "Alfanumeric"
        , "100"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00985'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00986"
        , "2023/1"
        , "28/02/2023"
        , "OFFICIï¿½LE DUUR VAN DE STUDIES"
        , "StudiesDuration"
        , "Titels en diploma's"
        , "Wettelijke duur van de studies, uitgedrukt in jaren, die geleid hebben tot het behalen van de titel of het diploma in kwestie op de datum van de aflevering."
        , "Geheel getal en element van [1,20]"
        , ""
        , "numeric"
        , "2"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00986'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00014"
        , "2023/1"
        , "28/02/2023"
        , "ONDERNEMINGSNUMMER"
        , "CompanyID"
        , "Identificatie van de werkgever"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
     "
        , "
     Getal van 10 cijfers waarvan :
     de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
     de posities 9 en 10 overeenkomen met een controlegetal.
     Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden."
        , ""
        , "numeric"
        , "10"
        , "Verplicht indien de zone zich bevindt in het FB 90256 "Identificatie van de werkgever".
     Facultatief indien de zone zich bevindt in het FB 90418 "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"."
        , "")
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
        , "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"
        , "Nummer dat een werkgever eenduidig identificeert, of het nu gaat om een natuurlijk persoon, een groepering van natuurlijke personen of een rechtspersoon.
     "
        , "
     Getal van 10 cijfers waarvan :
     de posities 1 tot 8 overeenkomen met een volgnummer, met op de eerste positie een cijfer gelijk aan nul of 1;
     de posities 9 en 10 overeenkomen met een controlegetal.
     Als het ondernemingsnummer niet gekend is, dient de waarde nul meegedeeld te worden."
        , ""
        , "numeric"
        , "10"
        , "Verplicht indien de zone zich bevindt in het FB 90256 "Identificatie van de werkgever".
     Facultatief indien de zone zich bevindt in het FB 90418 "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00014'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00060"
        , "2023/1"
        , "28/02/2023"
        , "ONDERWIJS - BETALINGSWIJZE"
        , "TenthOrTwelfth"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die de betalingswijze aangeeft van een werknemer in het onderwijs."
        , "
     10 = betaling in tienden
     12 = betaling in twaalfden
     20 = Hervorming schooljaar 2022 - Franstalig onderwijsIn het kader van een aangifte van het attest Loopbaangeschiedenis, de enige toegelaten waarden zijn 10 en 12."
        , ""
        , "numeric"
        , "2"
        , "Verplicht indien de zone 00999 "Gesubsidieerde vestiging" aanwezig is.
     Verplicht indien de werknemer een functie uitoefent in het onderwijs, dit wil zeggen indien de zone 00961 "Type instelling van de overheidssector" ingevuld is en gelijk is aan ï¿½ï¿½n van de volgende waarden: 25, 26, 27, 52, 53, 54, 62, 63, of 64."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00060'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00981"
        , "2023/1"
        , "28/02/2023"
        , "PERCENTAGE VAN DE WEDDEBIJSLAG"
        , "AdditionalScaleSalaryPercentage"
        , "Weddebijslag ï¿½ historische gegevens"
        , "Dit is een variabel percentage van de wedde."
        , "Geheel getal en element van [1;99999].
     Percentage uitgedrukt in honderdste percent (bv.: 21,52%  => 2152)."
        , ""
        , "numeric"
        , "5"
        , "Verplicht indien de referentie van de weddebijslag dit vereist."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00981'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00962"
        , "2023/1"
        , "28/02/2023"
        , "PERSONEELSCATEGORIE VAN DE OVERHEIDSSECTOR"
        , "PublicSectorPersonnelCategory"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die aanduidt tot welke personeelscategorie de werknemer behoort voor het in aanmerking nemen van de diensten in de berekening van het rustpensioen (tantiï¿½me)."
        , "Zie bijlage 43 - Nomenclatuur van de personeelscategorieï¿½n van de overheidssector voor de lijst met de toegelaten waarden voor de personeelscategorie."
        , ""
        , "numeric"
        , "2"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00962'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00033"
        , "2023/1"
        , "28/02/2023"
        , "POSTCODE VAN DE WERKNEMER"
        , "WorkerZIPCode"
        , "Natuurlijke persoon"
        , "Postnummer van een gemeente.
     Postnummer van het adres waar de werknemer gedomicilieerd is.
     Voor de in Belgiï¿½ gedomicilieerde werknemers moet men de officiï¿½le lijst met Belgische postcodenummers gebruiken.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , ""
        , ""
        , "Alfanumeric"
        , "9"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00033'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00109"
        , "2023/1"
        , "28/02/2023"
        , "PPL NUMMER"
        , "NOSSLPARegistrationNbr"
        , "Identificatie van de werkgever"
        , " Elke lokale of provinciale overheid die personeel in dienst heeft, moet ingeschreven zijn bij de RSZ."
        , "Geheel getal en element van [00000197;99999926]. Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het PPL nummer op de waarde nul gezet worden."
        , ""
        , "numeric"
        , "8"
        , "Verplicht indien de zone zich bevindt in het FB 90256 "Identificatie van de werkgever".
     Facultatief indien de zone zich bevindt in het FB 90418 "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"."
        , "0 of NNNNNNCC
     ï¿½ NNNNNN is het nummer
     ï¿½ CC is het controlegetal.")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00109'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00109"
        , "2023/1"
        , "28/02/2023"
        , "PPL NUMMER"
        , "NOSSLPARegistrationNbr"
        , "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"
        , " Elke lokale of provinciale overheid die personeel in dienst heeft, moet ingeschreven zijn bij de RSZ."
        , "Geheel getal en element van [00000197;99999926]. Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het PPL nummer op de waarde nul gezet worden."
        , ""
        , "numeric"
        , "8"
        , "Verplicht indien de zone zich bevindt in het FB 90256 "Identificatie van de werkgever".
     Facultatief indien de zone zich bevindt in het FB 90418 "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"."
        , "0 of NNNNNNCC
     ï¿½ NNNNNN is het nummer
     ï¿½ CC is het controlegetal.")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00109'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00998"
        , "2023/1"
        , "28/02/2023"
        , "PRECAIR CONTRACT"
        , "TempOrShortFixedContract"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die aanduidt of de tewerkstelling van de werknemer uitgevoerd wordt in het kader van een precair contract"
        , "Zie bijlage capelodhgs01 ï¿½ Lijst van precaire contracten"
        , ""
        , "numeric"
        , "3"
        , "Verplicht indien de waarde van de zone 00996 "Aard van de arbeidsrelatie - overheidssector" gelijk is aan "5" (Contractueel - precair statuut)."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00998'
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
        , "Tijdstip, uitgedrukt in uren, minuten, seconden en milliseconden.
     "
        , "UU is een element van [00;23]
     MM is een element van [00;59]
     SS is een element van [00;59]
     SSS is een element van [000;999]
     "
        , ""
        , "Alfanumeric"
        , "12"
        , "required "
        , "UU:MM:SS.SSS
     . UU zijn de uren
     . MM zijn de minuten
     . SS zijn de seconden
     . SSS zijn de milliseconden")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00299'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00969"
        , "2023/1"
        , "28/02/2023"
        , "REDEN VAN HET EINDE VAN DE STATUTAIRE RELATIE"
        , "StatutoryRelationEndReason"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die voor een vast benoemde of een daarmee gelijkgestelde werknemer aanduidt op welke wijze het statutair verband met de werkgever werd beï¿½indigd of gewijzigd."
        , "1 = pensioen
     2 = vrijwillig vertrek
     3 = ontslag opgelegd door de werkgever
     4 = overlijden
     5 = verandering van werkgever (overheidssector)
     6 = wijziging van statuut
     7 =  einde van aansluiting aan een Belgisch pensioenregime
     8 = militair overgedragen met behoud van pensioenrechten
     9 = einde van lokaal mandaat
     10 = afzetting van een lokale mandatarisIn het kader van een aangifte van het attest Loopbaangeschiedenis, de enige toegelaten waarden zijn 1, 2, 3, 4, 5, 9 en 10."
        , ""
        , "numeric"
        , "2"
        , "Verplicht indien het statutaire verband met betrekking tot dit loopbaanelement beï¿½indigd wordt."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00969'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00615"
        , "2023/1"
        , "28/02/2023"
        , "REFERENTIE GEBRUIKER - NATUURLIJKE PERSOON"
        , "NaturalPersonUserReference"
        , "Natuurlijke persoon"
        , "Referentie.
     Referentie van de natuurlijke persoon gebruikt door de werkgever of een erkend sociaal secretariaat.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "In dit bericht is de toegelaten lengte voor deze zone 20 tekens."
        , ""
        , "Alfanumeric"
        , "200"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00615'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00977"
        , "2023/1"
        , "28/02/2023"
        , "REFERENTIE VAN DE WEDDEBIJSLAG"
        , "AdditionalScaleSalaryReference"
        , "Weddebijslag ï¿½ historische gegevens"
        , "Dit is de referentie naar een unieke weddebijslag bij iedere werkgever van de overheidssector."
        , "Getal door de FPD toegekend en aan de werkgever medegedeeld."
        , ""
        , "numeric"
        , "12"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00977'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00973"
        , "2023/1"
        , "28/02/2023"
        , "REFERENTIE VAN DE WEDDESCHAAL"
        , "SalaryScaleReference"
        , "Baremieke wedde ï¿½ historische gegevens"
        , "Dit is de referentie naar een unieke weddeschaal bij iedere werkgever van de overheidssector."
        , "Getal door de FPD toegekend en aan de werkgever medegedeeld."
        , ""
        , "numeric"
        , "12"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00973'
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
        , "Alfanumeric"
        , "64"
        , "required "
        , "")
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
        , "Identificatie van de werkgever"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ. Het gaat om een definitief RSZ-nummer.
     "
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers.
     Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden.
     "
        , ""
        , "numeric"
        , "9"
        , "Verplicht indien de zone zich bevindt in het FB 90256 "Identificatie van de werkgever".
     Facultatief indien de zone zich bevindt in het FB 90418 "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"."
        , "0 of NNNNNNNCC
     ï¿½ NNNNNNN is het nummer
     ï¿½ CC is het controlegetal.")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00011'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00011"
        , "2023/1"
        , "28/02/2023"
        , "RSZ-NUMMER"
        , "NOSSRegistrationNbr"
        , "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ. Het gaat om een definitief RSZ-nummer.
     "
        , "Geheel getal en element van [100006;199999934] voor de definitieve nummers.
     Als het uniek ondernemingsnummer gekend is (zone 00014 verschillend van nul), kan het RSZ-nummer op de waarde nul gezet worden.
     "
        , ""
        , "numeric"
        , "9"
        , "Verplicht indien de zone zich bevindt in het FB 90256 "Identificatie van de werkgever".
     Facultatief indien de zone zich bevindt in het FB 90418 "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"."
        , "0 of NNNNNNNCC
     ï¿½ NNNNNNN is het nummer
     ï¿½ CC is het controlegetal.")
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
     8 = KopieEnkel de waarde "0" is toegelaten."
        , ""
        , "numeric"
        , "1"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00110'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00030"
        , "2023/1"
        , "28/02/2023"
        , "STRAAT VAN DE WERKNEMER"
        , "WorkerStreet"
        , "Natuurlijke persoon"
        , "Openbare weg.
     Openbare weg waar zich de woonplaats van de werknemer bevindt.
     De notie " verdieping " kan vermeld worden in deze zone als dat nodig is.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , ""
        , ""
        , "Alfanumeric"
        , "35"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00030'
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
        , "Alfanumeric"
        , "20"
        , "Verplicht indien  het attest gegevens voor de contactpersoon bevat en hierbij geen van de zones 00637 (E-MAILADRES) en 00925 (AANVULLENDE ADRESGEGEVENS) is ingevuld."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00677'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00050"
        , "2023/1"
        , "28/02/2023"
        , "TYPE ARBEIDSOVEREENKOMST"
        , "ContractType"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die aanduidt of de tewerkstelling plaatsvindt in het kader van een voltijds of een deeltijds contract.
     "
        , "0 = voltijds
     1 = deeltijds
     1 indien de aangifte een onthaalouder betreft (werknemerskengetal 497 (bijlage 2) en 761 (bijlage 28)), tot en met 2/2005.
     0 indien de aangifte betrekking heeft op een lokale mandataris."
        , ""
        , "numeric"
        , "1"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00050'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01029"
        , "2023/1"
        , "28/02/2023"
        , "TYPE HISTORISCH ATTEST"
        , "HistoricalAttestationType"
        , "Informatie over het historisch attest"
        , "Zone waarin het type historisch attest gepreciseerd wordt."
        , "0 = attest voor een werknemer werkzaam in de overheidssector op 01/01/2011
     1 = attest volgend op een aanvraag voor een uitgesteld rustpensioen
     2 = attest volgend op een aanvraag voor een uitgesteld overlevingspensioen
     3 = attest voor een werknemer die in functie treedt in de overheidssector na 01/01/2011
     4 = attest ingegeven door een werkgever toegevoegd aan het Capelo toepassingsveld na 01/01/2011
     5 = attest voor de regularisatie van de loopbaangeschiedenis van de werknemer
     8 = attest voor een lokale politieke mandataris
     9 = uitzonderingen"
        , ""
        , "numeric"
        , "1"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01029'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00989"
        , "2023/1"
        , "28/02/2023"
        , "TYPE ONDERWIJS"
        , "EducationType"
        , "Titels en diploma's"
        , "Code die het gevolgde type onderwijs aangeeft"
        , "1 : onderwijs met volledig leerplan ï¿½ normaal uurrooster
     2 : onderwijs met volledig leerplan ï¿½ verschoven uurrooster (inbegrepen centrale examenjury)"
        , ""
        , "numeric"
        , "1"
        , "Verplicht indien de waarde van de zone 00988 "Aanduiding Belgisch diploma" gelijk is aan "1" (Belgisch diploma).
     Facultatief indien de waarde van de zone 00988 "Aanduiding Belgisch diploma" gelijk is aan "0" (buitenlands diploma)."
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00989'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00961"
        , "2023/1"
        , "28/02/2023"
        , "TYPE VAN DE INSTELLING VAN DE OVERHEIDSSECTOR"
        , "PublicSectorInstitutionType"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Code die aanduidt tot welk beleidsniveau de werknemer behoort."
        , "Zie bijlage 42 - Nomenclatuur van de types van instellingen van de overheidssector voor de lijst met de toegelaten waarden voor het beleidsniveau."
        , ""
        , "numeric"
        , "2"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00961'
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
     9 = de referentie is een gestructureerde mededeling die moet worden gebruikt in het kader van een betaling en verwijst naar dit formulierIn dit bericht is de waarde '0' niet toegelaten."
        , ""
        , "numeric"
        , "1"
        , "required "
        , "")
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
     De enige waarde in dit bericht is "SU"."
        , ""
        , "Alfanumeric"
        , "2"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00297'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00023"
        , "2023/1"
        , "28/02/2023"
        , "VOLGNUMMER NATUURLIJKE PERSOON"
        , "NaturalPersonSequenceNbr"
        , "Natuurlijke persoon"
        , "Volgnummer van de natuurlijke personen binnen een aangifte.
     Dit nummer moet uniek zijn binnen een aangifte.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "Positief geheel getal en element van [1;9999999]."
        , ""
        , "numeric"
        , "7"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00023'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01000"
        , "2023/1"
        , "28/02/2023"
        , "VOLGNUMMER VAN DE BAREMIEKE WEDDE"
        , "ScaleSalarySequenceNbr"
        , "Baremieke wedde ï¿½ historische gegevens"
        , "Volgnummer van de baremieke wedde. Dit is een volgnummer toegekend door de werkgever.
     Dit nummer moet uniek zijn binnen een lijn "Element van de loopbaangeschiedenis van de werknemer"."
        , "Geheel getal en element van [1;99]"
        , ""
        , "numeric"
        , "2"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01000'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01001"
        , "2023/1"
        , "28/02/2023"
        , "VOLGNUMMER VAN DE WEDDEBIJSLAG"
        , "AdditionalScaleSalarySequenceNbr"
        , "Weddebijslag ï¿½ historische gegevens"
        , "Volgnummer van de weddebijslag. Dit is een volgnummer toegekend door de werkgever.
     Dit nummer moet uniek zijn binnen een lijn "Baremieke wedde - historische gegevens"."
        , "Geheel getal en element van [1;99]"
        , ""
        , "numeric"
        , "2"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01001'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00993"
        , "2023/1"
        , "28/02/2023"
        , "VOLGNUMMER VAN HET ELEMENT VAN DE LOOPBAANGESCHIEDENIS"
        , "CareerElementSequenceNbr"
        , "Element van de loopbaangeschiedenis van de werknemer"
        , "Volgnummer van de elementen van de loopbaangeschiedenis. Dit is een volgnummer toegekend door de werkgever.
     Dit nummer moet uniek zijn binnen een lijn "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"."
        , "Geheel getal en element van [1;9999]"
        , ""
        , "numeric"
        , "4"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00993'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "01006"
        , "2023/1"
        , "28/02/2023"
        , "VOLGNUMMER WERKGEVER"
        , "EmployerSequenceNbr"
        , "Identificatie van een werkgever in de loopbaangeschiedenis van de werknemer"
        , "Volgnummer van een werkgever. Dit is een volgnummer toegekend door de aangever.
     Dit nummer moet uniek zijn binnen een aangifte."
        , "Geheel getal en element van [1;99]"
        , ""
        , "numeric"
        , "2"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '01006'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00984"
        , "2023/1"
        , "28/02/2023"
        , "VOLLEDIG"
        , "IsCompleted"
        , "Eigenschappen van het attest"
        , "Laat toe aan te duiden of het element dat met deze zone geassocieerd is, al dan niet volledig is."
        , "0 = onvolledig
     1 = volledig"
        , ""
        , "numeric"
        , "1"
        , "required "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00984'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00948"
        , "2023/1"
        , "28/02/2023"
        , "VOORLOPIG RSZ-NUMMER"
        , "ProvisionalNSSONbr"
        , "Identificatie van de werkgever"
        , "Iedere werkgever, of het nu een natuurlijke persoon, een groepering van natuurlijke personen of een rechtspersoon betreft, die personeel in dienst heeft dat onderworpen is aan de wet van 27 juni 1969, moet ingeschreven zijn bij de RSZ. 
     Het gaat om een voorlopig RSZ-nummer dat aan de nieuwe werkgever toegekend is.
     Dit voorlopig nummer mag niet meer gebruikt worden zodra de RSZ het definitieve nummer heeft meegedeeld.Deze zone wordt nooit gebruikt wanneer het gaat om een aangifte voor een attest Loopbaangeschiedenis."
        , "Geheel getal en element van [5000000120;5999999989]"
        , ""
        , "numeric"
        , "10"
        , "Facultatief "
        , "0 of NNNNNNNNCC
     ï¿½ NNNNNNNN is het nummer
     ï¿½ CC is het controlegetal.")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00948'
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
        , "Eerste voornaam van een natuurlijk persoon."
        , ""
        , ""
        , "Alfanumeric"
        , "24"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00727'
                          AND Version = '2023/1'
);
        

INSERT OR REPLACE INTO zones(Code, Version, PublicationDay, Title, XmlLabel, FunctionalBlock
    , DescriptionNL, DomainNL, Reference, Type, Length, Presence, Format)
SELECT "00026"
        , "2023/1"
        , "28/02/2023"
        , "VOORNAAM VAN DE WERKNEMER"
        , "WorkerFirstName"
        , "Natuurlijke persoon"
        , "Eerste voornaam van een natuurlijk persoon."
        , ""
        , ""
        , "Alfanumeric"
        , "24"
        , "Facultatief "
        , "")
WHERE NOT EXISTS (SELECT * FROM zones
                    WHERE Code = '00026'
                          AND Version = '2023/1'
);
        