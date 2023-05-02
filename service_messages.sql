CREATE TABLE service_messages (
    ServiceId  INTEGER NOT NULL
    , MessageId INTEGER NOT NULL
    , PRIMARY KEY (ServiceId, MessageId)
);

-- AANGIFTE VAN WERKEN
-- Aangifte van werken & Originele aangifte
INSERT INTO service_messages
VALUES(1, 1);

-- Aangifte van werken & Wijzigende aangifte
INSERT INTO service_messages
VALUES(1, 7);

-- Aangifte van werken & Ontvangstbewijs
INSERT INTO service_messages
VALUES(1, 5);

-- Aangifte van werken & Notificatie
INSERT INTO service_messages
VALUES(1, 6);



-- ASR WERKLOOSHEID
-- ASR-Werkloosheid & Scenario1: Aangifte einde arbeidsovereenkomst of werloosheid...
INSERT INTO service_messages
VALUES(41, 8);

-- ASR-Werkloosheid & Scenario2: Aangifte vaststellen recht tijdelijke werkloosheid of schorsing bedienden
INSERT INTO service_messages
VALUES(41, 9);

-- ASR-Werkloosheid & Scenario3: Aangifte aanvang deeltijdse arbeid
INSERT INTO service_messages
VALUES(41, 10);

-- ASR-Werkloosheid & Scenario5: Maandelijkse aangifte van de uren tijdelijke werkloosheid of uren schorsing bedienden
INSERT INTO service_messages
VALUES(41, 11);

-- ASR-Werkloosheid & Scenario6: Maandelijkse aangifte van deeltijdse arbeid voor de berekening van de inkomensgarantie-uitkering
INSERT INTO service_messages
VALUES(41, 12);

-- ASR-Werkloosheid & Scenario7: Maandelijkse aangifte van arbeid als werknemer tewerkgesteld in een beschermde werkplaats
INSERT INTO service_messages
VALUES(41, 13);

-- ASR-Werkloosheid & Scenario8: Maandelijkse aangifte van arbeid in het kader van een activeringsprogramma
INSERT INTO service_messages
VALUES(41, 14);

-- ASR-Werkloosheid & Scenario9: Aangifte voor het vaststellen van het recht op jeugd-of seniorvakantie
INSERT INTO service_messages
VALUES(41, 15);

-- ASR-Werkloosheid & Scenario 10: Maandelijkse aangifte van de uren jeugd-of seniorvakantie
INSERT INTO service_messages
VALUES(41, 16);

-- ASR-Werkloosheid & Scenario 11: Maandelijkse aangifte havenarbeid(werkloosheid en bestaanszekerheid)
INSERT INTO service_messages
VALUES(41, 17);

-- ASR-Werkloosheid & Identificatiestroom(IDFLUX)
INSERT INTO service_messages
VALUES(41, 4);

-- ASR-Werkloosheid & Ontvangstbewijs
INSERT INTO service_messages
VALUES(41, 5);

-- ASR-Werkloosheid & Notificatie
INSERT INTO service_messages
VALUES(41, 6);



-- ASR- UITKERINGEN
-- ASR- Uitkeringen & Scenario1: Inlichtingsblad
INSERT INTO service_messages
VALUES(42, 18);

-- ASR- Uitkeringen & Scenario2: Maandelijkse aangifte aangepaste arbeid
INSERT INTO service_messages
VALUES(42, 19);

-- ASR- Uitkeringen & Scenario3: attest met het oog op de vergoeding van de borstvoedingspauzes
INSERT INTO service_messages
VALUES(42, 20);

-- ASR- Uitkeringen & Scenario5: Jaarlijkse vakantieaangifte
INSERT INTO service_messages
VALUES(42, 21);

-- ASR- Uitkeringen & Scenario6: Aangifte van werkhervatting
INSERT INTO service_messages
VALUES(42, 22);

-- ASR- Uitkeringen & Scenario7: Aanvraagformulier
INSERT INTO service_messages
VALUES(42, 23);

-- ASR- Uitkeringen & Identificatiestroom (IDFLUX)
INSERT INTO service_messages
VALUES(42, 4);

-- ASR- Uitkeringen & Ontvangstbewijs
INSERT INTO service_messages
VALUES(42, 5);

-- ASR- Uitkeringen & Notificatie
INSERT INTO service_messages
VALUES(42, 6);


-- ASR ARBEIDSONGEVALLEN
-- ASR-Arbeidsongevallen & Scenario1- Aangifte van een arbeidsongeval
INSERT INTO service_messages
VALUES(43, 24);

-- ASR-Arbeidsongevallen & Scenario2- Maandelijks rapport
INSERT INTO service_messages
VALUES(43, 25);

-- ASR-Arbeidsongevallen & Scenario3- Aangifte van werkhervatting
INSERT INTO service_messages
VALUES(43, 26);

-- ASR-Arbeidsongevallen & Identificatiestroom (IDFLUX)
INSERT INTO service_messages
VALUES(43, 4);

-- ASR-Arbeidsongevallen & Ontvangstbewijs
INSERT INTO service_messages
VALUES(43, 5);

-- ASR-Arbeidsongevallen & Notificatie
INSERT INTO service_messages
VALUES(43, 6);


-- CAPELO
-- Capelo & scenario1: aangifte van een arbeidsongeval
INSERT INTO service_messages
VALUES(3, 24);

-- Capelo & scenario2: Maandelijks rapport
INSERT INTO service_messages
VALUES(3, 25);

-- Capelo & scenario3: Aangifte van een werkhervatting
INSERT INTO service_messages
VALUES(3, 26);

-- Capelo & Identificatiestroom (IDFLUX)
INSERT INTO service_messages
VALUES(3, 4);

-- Capelo & Ontvangstbewijs
INSERT INTO service_messages
VALUES(3, 5);

-- Capelo & Notificatie
INSERT INTO service_messages
VALUES(3, 6);



-- CAREERPRO DOCUMENTS
-- CareerPro Documents & Specifieke uitwisseling
INSERT INTO service_messages
VALUES(5, 27);

-- CareerPro Documents & Generieke uitwisseling
INSERT INTO service_messages
VALUES(5, 28);



-- CONSULTATIE FACTUREN WERKGEVERS
-- Consultatie facturen werkgevers & Beware-Notificatie
INSERT INTO service_messages
VALUES(7, 29);

-- Consultatie facturen werkgevers & Beware-Controlelijst
INSERT INTO service_messages
VALUES(7, 30);

-- Consultatie facturen werkgevers & Betalingsnota
INSERT INTO service_messages
VALUES(7, 31);

-- Consultatie facturen werkgevers & Voorschotten
INSERT INTO service_messages
VALUES(7, 32);

-- Consultatie facturen werkgevers & Raadpleging van de proactieve acties ...
INSERT INTO service_messages
VALUES(7, 33);

-- Consultatie facturen werkgevers & Aanmaning
INSERT INTO service_messages
VALUES(7, 34);

-- Consultatie facturen werkgevers & Financiële situatie
INSERT INTO service_messages
VALUES(7, 35);

-- Consultatie facturen werkgevers & Financiële toestand
INSERT INTO service_messages
VALUES(7, 36);

-- Consultatie facturen werkgevers & Generieke  uitwisseling
INSERT INTO service_messages
VALUES(7, 28);

-- Consultatie facturen werkgevers & Ontvangstbewijs
INSERT INTO service_messages
VALUES(7, 5);

-- Consultatie facturen werkgevers & Notificatie
INSERT INTO service_messages
VALUES(7, 6);



-- DIMONA
-- Dimona & Originele aangifte
INSERT INTO service_messages
VALUES(11, 1);

-- Dimona & Aanvraag tot consultatie - Personeelsbestand
INSERT INTO service_messages
VALUES(11, 2);

-- Dimona & Antwoord op een aanvraag tot consultatie - Personeelsbestand
INSERT INTO service_messages
VALUES(11, 3);

-- Dimona & Identificatiestroom (IDFLUX)
INSERT INTO service_messages
VALUES(11, 4);

-- Dimona & Ontvangstbewijs
INSERT INTO service_messages
VALUES(11, 5);

-- Dimona & Notificatie
INSERT INTO service_messages
VALUES(11, 6);



-- DMFA
-- DmfA & Originele aangifte
INSERT INTO service_messages
VALUES(12, 1);

-- DmfA & Wijzigende aangifte
INSERT INTO service_messages
VALUES(12, 7);

-- DmfA & Notificatie van wijziging
INSERT INTO service_messages
VALUES(12, 37);

-- DmfA & Beware-Notificatie
INSERT INTO service_messages
VALUES(12, 6);

-- DmfA & Beware-Controlelijst
INSERT INTO service_messages
VALUES(12, 30);

-- DmfA & Aanvraag tot consultatie
INSERT INTO service_messages
VALUES(12, 38);

-- DmfA & Antwoord op aanvraag tot consultatie
INSERT INTO service_messages
VALUES(12, 39);

-- DmfA & Permanente Identificatiegegevens
INSERT INTO service_messages
VALUES(12, 40);

-- DmfA & Vraag tot consultatie van de DmfA gegevens verminderingen eerste aanwervingen: Generieke uitwisseling
INSERT INTO service_messages
VALUES(12, 41);

-- DmfA & Antwoord op een aanvraag tot consultatie verminderingen eerste aanwervingen
INSERT INTO service_messages
VALUES(12, 48);

-- DmfA & Vraag tot consultatie van economische werkloosheidsdagen buiten de bouwsector: generieke uitwisseling
INSERT INTO service_messages
VALUES(12, 43);

-- DmfA & Antwoord op een aanvraag tot consultatie van economische werkloosheidsdagen buiten de bouwsector
INSERT INTO service_messages
VALUES(12, 44);

-- DmfA & Ontvangstbewijs
INSERT INTO service_messages
VALUES(12, 5);



-- DOSSIER LOOPBAANONDERBREKING EN TIJDSKREDIET
-- Dossier Loopbaanonderbreking en tijdskrediet & Originale aangifte
/*INSERT INTO service_messages
VALUES(13, 5);*/

-- Dossier Loopbaanonderbreking en tijdskrediet & Generieke aangifte
/*INSERT INTO service_messages
VALUES(13, 5);*/

-- Dossier Loopbaanonderbreking en tijdskrediet & Ontvangstbewijs
/*INSERT INTO service_messages
VALUES(13, 5);*/

-- Dossier Loopbaanonderbreking en tijdskrediet & Notificatie
/*INSERT INTO service_messages
VALUES(13, 5);*/



-- ECARO
-- Ecaro & Vraag tot consultatie Ecaro gegevens
/*INSERT INTO service_messages
VALUES(16, 5);*/

-- Ecaro & Antwoord op een aanvraag tot consultatie Ecaro gegevens
/*INSERT INTO service_messages
VALUES(16, 5);*/

-- Ecaro & Generieke uitwisseling
/*INSERT INTO service_messages
VALUES(16, 5);*/

-- Ecaro & Ontvangstbewijs
/*INSERT INTO service_messages
VALUES(16, 5);*/

-- Ecaro & Notificatie
/*INSERT INTO service_messages
VALUES(16, 5);*/



-- PUBLIATO
--Publiato & Generieke uitwisseling
/*INSERT INTO service_messages
VALUES(25, 5);*/

--Publiato & Ontvangstbewijs
/*INSERT INTO service_messages
VALUES(25, 5);*/



-- SOCIALE SCHULDEN
-- Sociale schulden & Financiële situatie
/*INSERT INTO service_messages
VALUES(44, 5);*/

-- Sociale schulden & Berekening van sociale schulden
/*INSERT INTO service_messages
VALUES(44, 5);*/

-- Sociale schulden & Generieke uitwisseling
/*INSERT INTO service_messages
VALUES(44, 5);*/

-- Sociale schulden & Ontvangstbewijs
/*INSERT INTO service_messages
VALUES(44, 5);*/



-- TIJDELIJKE WERKLOOSHEID
-- Tijdelijke werkloosheid & Originele aangifte
/*INSERT INTO service_messages
VALUES(31, 5);*/

-- Tijdelijke werkloosheid & Eindbeslissing (DEFI)
/*INSERT INTO service_messages
VALUES(31, 5);*/

-- Tijdelijke werkloosheid & Generieke uitwisseling
/*INSERT INTO service_messages
VALUES(31, 5);*/

-- Tijdelijke werkloosheid & Ontvangstbewijs
/*INSERT INTO service_messages
VALUES(31, 5);*/



-- VALIDATIEBOEK
-- Validatieboek & Originele aangifte
/*INSERT INTO service_messages
VALUES(35, 5);*/

-- Validatieboek & Ontvangstbewijs
/*INSERT INTO service_messages
VALUES(35, 5);*/
