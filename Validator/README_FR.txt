1. Decompression du fichier xmlvalidator
========================================
Decompresser le fichier xmlvalidator.zip vers le répertoire du disque dur.
Par exemple
	
	c:\xmlvalidator



2. Installation de la machine virtuelle java
============================================
Installer la version 1.6 de la machine virtuelle java. La version est disponible sur http://java.com/download

Controller la version installée en encodant la commande suivante dans un dos prompt.

	java -version

Le résultat doit se raproché de

	java version "1.6.0_05"
	Java(TM) SE Runtime Environment (build 1.6.0_05-b13)
	Java HotSpot(TM) Client VM (build 10.0-b19, mixed mode)



3. Execution de l'application
=============================
Pour votre facilité, des batch (*.bat) accompagnent l'application.

	xmlvalidator.bat : démarre l'application dans la langue par défaut de votre ordinateur.
	xmlvalidator_nl.bat : démarre l'application en Neerlandais
	xmlvalidator_fr.bat : démarre l'application en Français
	xmlvalidator_en.bat : démarre l'application en Anglais



4. Utilisation de l'application
===============================
Vous pouvez chercher une déclaration en encodant directement son nom de fichier ou vous pouvez selectionner la déclaration en utilisant une boite de dialogue recherche. Dès qu'une déclaration est choisie, le bouton "Controler le fichier XML" est disponible. En appuyant sur ce bouton l'application démare le controle de la déclaration. 
Le controle de la déclaration s'opère en 4 étapes:

ETAPE 1: 
Lors de la première étape, l'application vérifie que le fichier contient un XML bien formé. En cas d'erreur, l'application n'exécutera pas les autres étapes.


		ETAPE 1 : Validation de la conformité par rapport au standard XML 
		------------------------------------------------------------------------
		The element type "WorkerRecord" must be terminated by the matching end-tag "</WorkerRecord>".


ETAPE 2: 
Lors de la seconde étape, la règles du schéma XML sont appliquées. Le fichier du schéma XML doit se trouver dans le répertoire d'installation de l'application. Pour votre facilité un schéma pour chaque trimestre de 2003 est livré avec l'application. 
Des erreurs éventuelle générée par l'application du schéma sur la déclaration sont produit sous le format suivant:
	[zone, champ] [ligne, colonne] Description de l'erreur.  

		ETAPE 1 : Validation de la conformité par rapport au standard XML 
		------------------------------------------------------------------------
		OK

		ETAPE 2 : Validation de la conformité par rapport au schéma
		------------------------------------------------------------------------
		[WorkerContribution:ContributionAmount][2,69665] ERREUR : cvc-complex-type.2.4.d: Invalid content starting with element 'ContributionWorkerCode'. No child element is expected at this point.


	
ETAPE 3: 
Lors de la troisième étape, l'application vérifie que chaque personne n'est présente qu'une seule fois dans la déclaration. Chaque personne qui serait présente plus d'une fois sont signalées à l'utilisateur.

		ETAPE 1 : Validation de la conformité par rapport au standard XML 
		------------------------------------------------------------------------
		OK

		ETAPE 2 : Validation de la conformité par rapport au schéma
		------------------------------------------------------------------------

		ETAPE 3 : Double constaté au niveau du NISS
		------------------------------------------------------------------------
		Le document contient plusieurs personnes physiques ayant le même NISS  42091221480


ETAPE 4 (SEULEMENT ONSS DmfA):  
Lors de la dernière étape, le montant déclaré est comparé au montant du résultat de la somme des contributions moins la somme des déductions. Si ces deux montants ne correspondent pas, les deux montants sont signalés à l'utilisateur. Cette étape n'est pas effectué pour les déclarations de l'ONSS DmfaPPL.

		ETAPE 1 : Validation de la conformité par rapport au standard XML 
		------------------------------------------------------------------------
		OK
	
		ETAPE 2 : Validation de la conformité par rapport au schéma
		------------------------------------------------------------------------

		ETAPE 3 : Double constaté au niveau du NISS
		------------------------------------------------------------------------
		OK

		ETAPE 4 : Contrôle du Net A Payer
		------------------------------------------------------------------------
		Montant déclaré : 39280567
		Montant calculé : 39280568



5. Traitement automatique de déclarations
========================================

Le validateur xml permet également un contrôle automatisé des déclarations. Ceci permet d'introduire la déclaration à contrôler par le biais de l'invite de commande. L'output des contrôles décrite au paragraphe 4 est alors sauvegardée dans un fichier à indiquer. Pour cette méthode de travail, le validateur xml doit ëtre lancé par fichier batch "xmlvalidatorbatch.bat"

	xmlvalidatorbatch.bat fichierinput [fichieroutput]

	fichierinput:	la déclaration DmfA à valider.
	fichieroutput:	le fichier dans lequel l'output est sauvegardé.

o	Si aucun fichier output n'est indiqué, le validateur xml créera lui-même un fichier output portant le nom 'fichierinput.out'. 
o	Si le fichier output existe déjà, le nouvel output est ajouté au fichier existant. 
o	Afin de faire une distinction entre les différents fichiers, le nom du fichier input est également sauvegardé dans le fichier output lors de chaque contrôle. 

