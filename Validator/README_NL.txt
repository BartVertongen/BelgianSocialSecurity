1. Uitpakken van xmlvalidator
=============================
Pak het xmlvalidator.zip bestand uit naar een folder op uw harde schijf. Bijvoorbeeld 
	
	c:\xmlvalidator



2. Installatie java virtual machine
================================
Installeer de java virtual machine versie 1.6. De java virtual machine is beschikbaar op http://java.com/download

U kan de versie van de installatie van java controleren door van de dos prompt het commando

	java -version

uit te voeren. Dit levert een resultaat gelijkaardig aan

	java version "1.6.0_05"
	Java(TM) SE Runtime Environment (build 1.6.0_05-b13)
	Java HotSpot(TM) Client VM (build 10.0-b19, mixed mode)



3. Uitvoeren van het programma
==============================
Voor uw gemak werden een aantal batch (*.bat) bestanden voorzien bij het programma.

	xmlvalidator.bat : start het programma met de standaard taalinstelling van uw computer
	xmlvalidator_nl.bat : start het programma met Nederlands als taalinstelling
	xmlvalidator_fr.bat : start het programma met Frans als taalinstelling
	xmlvalidator_en.bat : start het programma met Engels als taalinstelling

	Paragraaf 5 beschrijft hoe u het de xml validator kan gebruike voor een geautomatiseerde controle.


4. Gebruik van het programma via de grafische interface
=======================================================
U kunt een aangifte selecteren door de volledige naam van de aangifte in te tikken of door de aangifte op te zoeken. Van zodra een aangifte werd geselecteerd, wordt de knop "Controleer aangifte" beschikbaar. Met een druk op de knop start u het controle proces van de aangifte.
De controle van de aangifte gebeurt in 4 stappen.


STAP 1 :
In een eerste stap wordt het bestandsformaat gecontroleerd van de aangifte. Een aangifte moet immers een geldig xml document zijn. Is dit niet het geval worden de volgende controle stappen niet verder uitgevoerd.
Bvb.
		STAP 1 : Controle of de aangifte conform de XML specificatie is
		------------------------------------------------------------------------
		The element type "WorkerRecord" must be terminated by the matching end-tag "</WorkerRecord>".


STAP 2 :
In een volgende stap wordt de aangifte getoetst aan de regels die werden gedefinieerd in het xml schema. Het xml schema dat van toepassing is op de aangifte moet zich bevinden in de installatie directory van het programma. 
Eventuele fouten met betrekking tot het schema worden vermeld in het volgende formaat

	[zone,veld][lijn,kolom] Vermelding van de fout


		STAP 1 : Controle of de aangifte conform de XML specificatie is
		------------------------------------------------------------------------
		OK

		STAP 2 : Controle of de aangifte conform het XML schema is
		------------------------------------------------------------------------
		[WorkerContribution:ContributionAmount][2,69665] FOUT : cvc-complex-type.2.4.d: Invalid content starting with element 'ContributionWorkerCode'. No child element is expected at this point.

	
STAP 3 :
In een derde stap wordt gecontroleerd of een persoon slechts eenmaal voorkomt in de aangifte. De personen die meerdere keren voorkomen in de aangifte worden afgebeeld.

		STAP 1 : Controle of de aangifte conform de XML specificatie is
		------------------------------------------------------------------------
		OK

		STAP 2 : Controle of de aangifte conform het XML schema is
		------------------------------------------------------------------------

		STAP 3 : Controle dubbele rijksregisternummers
		------------------------------------------------------------------------
		Document bevat meerdere natuurlijke personen met rijksregisternummer 42091221480



STAP 4 (ENKEL RSZ DmfA) :
In de laatste stap wordt het totaal te betalen bedrag vergeleken met de som van alle bijdragen verminderd met de som van alle verminderingen. Indien deze twee bedragen niet corresponderen, verschijnen het totaal bedrag en het berekend bedrag. Deze stap wordt niet uitgevoerd voor aangiftes RSZ DmfAPPL.

		STAP 1 : Controle of de aangifte conform de XML specificatie is
		------------------------------------------------------------------------
		OK

		STAP 2 : Controle of de aangifte conform het XML schema is
		------------------------------------------------------------------------

		STAP 3 : Controle dubbele rijksregisternummers
		------------------------------------------------------------------------
		OK

		STAP 4 : Controle netto verschuldigd bedrag
		------------------------------------------------------------------------
		Bedrag in declaratie : 39280567
		Berekend bedrag : 39280568



5. Automatische verwerking van aangiftes
========================================

De xml validator laat ook een geautomatiseerde controle van aangiftes toe.
Hierbij kan via de opdrachtregel het de te controleren aangifte worden opgegeven.
De uitvoer van de controles die in paragraaf 4 wordt beschreven
, wordt dan naar een op te geven uitvoer bestand weggeschreven.
Voor deze manier van werken moet de xmlvalidator opgestart worden via batch-bestand "xmlvalidatorbatch.bat"

	xmlvalidatorbatch.bat invoerbestand [uitvoerbestand]

Waarbij

	invoerbestand:	De te valideren DmfA-aangifte.
	uitvoerbestand:	Het bestand waarnaar de uitvoer wordt weggeschreven.

o	Indien geen uitvoerbestand wordt opgegeven, zal xmlvalidator zelf een uitvoerbestand aanmaken
        met als naam "invoerbestand.out". 
o	Indien het uitvoerbestand reeds bestaat, wordt de nieuwe uitvoer toegevoegd aan het bestaande bestand. 
o	Om het onderscheid te maken tussen verschillende bestanden wordt bij elke controle de naam van het invoerbestand ook weggeschreven naar het uitvoerbestand. 




