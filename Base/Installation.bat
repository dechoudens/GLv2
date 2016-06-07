REM Fichier		: Installation.bat
REM Objet		: Création de la BDD OrgaFestival

mkdir .\Logs

REM Lancement du script 01_BDD_OrgaFestival.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
 sqlplus SYSTEM/manager@XE @01_BDD_OrgaFestival.sql
REMsqlplus SYSTEM/manager@HEGLOCAL @01_BDD_OrgaFestival.sql
