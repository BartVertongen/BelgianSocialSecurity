
CREATE TABLE anomalous_events (
        Code                    TEXT NOT NULL PRIMARY KEY
        , DescriptionNL         TEXT NOT NULL
        , DescriptionFR         TEXT NOT NULL
        , BeginValidation       TEXT NOT NULL
        , EndValidation         TEXT NOT NULL
);


INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("0"
        , "Geen informatie"
        , "Pas d'information"
        , "1900/1" , "9999/4");


INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("10"
        , "Afwijkende gebeurtenis als gevolg van een elektrische storing, explosie, brand - niet gespecificeerd"
        , "Déviation par problème électrique, explosion, feu - Non précisé"
        , "1900/1" , "9999/4");


INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("11"
        , "Elektrische storing door een defect in de installatie - met indirect contact als gevolg"
        , "Problème électrique par défaillance dans l'installation - entraînant un contact indirect"
        , "1900/1" , "9999/4");


INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("12"
        , "Elektrische storing - met direct contact als gevolg"
        , "Problème électrique - entraînant un contact direct"
        , "1900/1" , "9999/4");

/*
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("13"
        , "Explosie"
        , "Explosion"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("14"
        , "Brand, vuurzee"
        , "Incendie, embrasement"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("19"
        , "Overige afwijkende gebeurtenissen, behorend tot groep 10, hierboven niet vermeld"
        , "Autre déviation connue du groupe 10 mais non listée ci-dessus"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("20"
        , "
                Afwijkende gebeurtenis door overlopen, kantelen, lekken, leeglopen, verdampen,
                vrijkomen - niet gespecificeerd
            "
        , "Déviation par débordement, renversement, fuite, écoulement, vaporisation, dégagement - Non précisé"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("21"
        , "In vaste toestand - overlopen, kantelen"
        , "A l'état de solide - débordement, renversement"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("22"
        , "In vloeibare toestand - lekken, sijpelen, leeglopen, spatten, sproeien"
        , "A l'état de liquide - fuite, suintement, écoulement, éclaboussure, aspersion"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("23"
        , "In gasvormige toestand - verdampen, aérosolvorming, gasvorming"
        , "A l'état gazeux - vaporisation, formation d'aérosol, formation de gaz"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("24"
        , "In poedervorm - rookontwikkeling, stof, deeltjes"
        , "Pulvérulent - génération de fumée, émission de poussières, particules"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("29"
        , "Overige afwijkende gebeurtenissen, behorend tot groep 20, hierboven niet vermeld"
        , "Autre déviation connue du groupe 20 mais non listée ci-dessus"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("30"
        , "Breken, barsten, glijden, vallen, instorten van het betrokken voorwerp - niet gespecificeerd"
        , "Rupture, bris, éclatement, glissade, chute, effondrement d'Agent matériel - Non précise"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("31"
        , "Breken van materiaal, op de voegen of verbindingen"
        , "Rupture de matériel, aux joints, aux connexions"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("32"
        , "Breken, barsten, waarbij scherven/spanen ontstaan (hout, glas, metaal, steen, kunststof, overige)"
        , "Rupture, éclatement, causant des éclats (bois, verre, métal, pierre, plastique, autres)"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("33"
        , "Glijden, vallen, instorten van het betrokken voorwerp - hoger gelegen (op het slachtoffer vallend)"
        , "Glissade, chute, effondrement d'agent matériel - supérieur (tombant sur la victime)"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("34"
        , "Glijden, vallen, instorten van het betrokken voorwerp - lager gelegen (het slachtoffer meeslepend)"
        , "Glissade, chute, effondrement d'agent matériel - inférieur (entra�nant la victime)"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("35"
        , "Glijden, vallen, instorten van het betrokken voorwerp - op gelijke hoogte gelegen"
        , "Glissade, chute, effondrement d'Agent matériel - de plain-pied"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("39"
        , "Overige afwijkende gebeurtenissen, behorend tot groep 30, hierboven niet vermeld"
        , "Autre déviation connue du groupe 30 mais non listée ci-dessus"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("40"
        , "
                Verlies van controle (geheel of gedeeltelijk) over een machine, vervoer- of transportmiddel,
                handgereedschap, voorwerp, dier - niet gespecificeerd
            "
        , "
                Perte, totale ou partielle, de controle de machine, moyen de transport - équipement de 
                manutention, outil à main, objet, animal - Non précise
            "
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("41"
        , "
                Verlies van controle (geheel of gedeeltelijk) - over een machine (inclusief onbedoeld starten)
                en over het met de machine bewerkte materiaal
            "
        , "
                 Perte, totale ou partielle, de controle - de machine (y compris le démarrage intempestif) ainsi 
                 que de la matière travaillée par la machine
            "
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("42"
        , "
                Verlies van controle (geheel of gedeeltelijk) - over een vervoer- of transportmiddel
                (al dan niet gemotoriseerd)
            "
        , "
                 Perte, totale ou partielle, de controle de moyen de transport - d'équipement de 
                 manutention (motorisé ou non)
            "
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("43"
        , "
                Verlies van controle (geheel of gedeeltelijk) - over een handgereedschap
                (al dan niet gemotoriseerd) en over het met het gereedschap bewerkte materiaal
            "
        , " 
                Perte, totale ou partielle, de controle d'outil à main (motorisé ou non) ainsi que de la
                 matière travaillée par l'outil
            "
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("44"
        , "
                Verlies van controle (geheel of gedeeltelijk) - over een voorwerp
                (dat wordt gedragen, verplaatst, gehanteerd enz.)
            "
        , "Perte, totale ou partielle, de controle d'objet (porté, déplacé, manipulé, etc.)"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("45"
        , "Verlies van controle (geheel of gedeeltelijk) - over een dier"
        , "Perte, totale ou partielle, de controle d'animal"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("49"
        , "Overige afwijkende gebeurtenissen, behorend tot groep 40, hierboven niet vermeld"
        , "Autre déviation connue du groupe 40 mais non listée ci-dessus"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("50"
        , "Uitglijden of struikelen met val, vallen van personen - niet gespecificeerd"
        , "Glissade ou trébuchement avec chute, chute de personne - Non précisé"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("51"
        , "Vallen van personen - van hoogte"
        , "Chute de personne - de hauteur"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("52"
        , "Uitglijden of struikelen met val, vallen van personen - op dezelfde hoogte"
        , "Glissade ou trébuchement avec chute, chute de personne - de plain-pied"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("59"
        , "Overige afwijkende gebeurtenissen, behorend tot groep 50, hierboven niet vermeld"
        , "Autre déviation connue du groupe 50 mais non listée ci-dessus"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("60"
        , "Bewegen van het lichaam zonder fysieke belasting (doorgaans leidend tot uitwendig letsel)- niet gespecificeerd"
        , "Mouvement du corps sans contrainte physique (conduisant généralement à une blessure externe) - Non précise"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("61"
        , "Op een snijdend voorwerp stappen"
        , "En marchant sur un objet coupant"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("62"
        , "Knielen, gaan zitten, tegen iets leunen"
        , "En s'agenouillant, s'asseyant, s'appuyant contre"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("63"
        , "Door een voorwerp of de vaart daarvan gegrepen of meegesleept worden"
        , "En étant attrapé, entra�n�, par quelque chose ou par son élan"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("64"
        , "Ongecoördineerde, onbeheerste of verkeerde bewegingen"
        , "Mouvements non coordonnés, gestes intempestifs, inopportuns"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("69"
        , "Overige afwijkende gebeurtenissen, behorend tot groep 60, hierboven niet vermeld"
        , "Autre déviation connue du groupe 60 mais non listée ci-dessus"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("70"
        , "Bewegen van het lichaam met of zonder fysieke belasting (doorgaans leidend tot inwendig letsel)- niet gespecificeerd"
        , "Mouvement du corps sous ou avec contrainte physique (conduisant généralement à une blessure interne) - Non précise"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("71"
        , "Optillen, dragen, opstaan"
        , "En soulevant, en portant, en se levant"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("72"
        , "Duwen, trekken"
        , "En poussant, en tractant"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("73"
        , "Neerzetten, bukken"
        , "En déposant, en se baissant"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("74"
        , "Buigen, draaien, zich omdraaien"
        , "En torsion, en rotation, en se tournant"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("75"
        , "Zwaarbeladen lopen, misstap of uitglijden zonder vallen"
        , "En marchant lourdement, faux pas, glissade - sans chute"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("79"
        , "Overige afwijkende gebeurtenissen, behorend tot groep 70, hierboven niet vermeld"
        , "Autre déviation connue du groupe 70 mais non listée ci-dessus"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("80"
        , "Verrassing, schrik, geweldpleging, agressie, bedreiging, aanwezig zijn - niet gespecificeerd"
        , "Surprise, frayeur, violence, agression, menace, présence - Non précisé"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("81"
        , "Verrassing, schrik"
        , "Surprise, fayeur"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("82"
        , "Geweldpleging, agressie, bedreiging tussen personeelsleden van de werkgever"
        , "Violence, agression, menace entre membres de l'entreprise soumis à l'autorité de l'employeur"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("83"
        , "
                Geweldpleging, agressie, bedreiging - door buitenstaanders jegens de
                slachtoffers in het kader van hun beroepsuitoefening (bankoverval, buschauffeurs)
            "
        , "
                Violence, agression, menace - provenant de personnes externes à l'entreprise envers 
                les victimes dans le cadre de leur fonction (attaque de banque, chauffeurs de bus, etc.)
            "
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("84"
        , "Aangevallen, omvergelopen worden - door een dier"
        , "Agression, bousculade - par animal"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("85"
        , "
                Aanwezig zijn van het slachtoffer of van een ander waardoor gevaar voor
                de persoon zelf en eventueel ook voor anderen ontstaat
            "
        , "
                Présence de la victime ou d'un tiers créant en soi un danger pour elle/lui-même
                et le cas échéant pour autrui
            "
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("89"
        , "Overige afwijkende gebeurtenissen, behorend tot groep 80, hierboven niet vermeld"
        , "Autre déviation connue du groupe 80 mais non listée ci-dessus"
        , "1900/1" , "9999/4");
        
INSERT INTO anomalous_events(Code, DescriptionNL, DescriptionFR, BeginValidity, EndValidity)
VALUES("99"
        , "Overige afwijkende gebeurtenissen, niet in deze lijst vermeld"
        , "Autre Déviation non listée dans cette classification"
        , "1900/1" , "9999/4");
*/