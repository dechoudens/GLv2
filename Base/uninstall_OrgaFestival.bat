REM Fichier		: BDD_OrgaFestival.bat
REM Objet		: Désinstallation de la BDD OrgaFestival 

mkdir .\Logs

REM Lancement du script uninstall_OrgaFestival.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
 sqlplus SYSTEM/manager@XE @uninstall_OrgaFestival.sql
REM sqlplus SYSTEM/manager@HEGLOCAL @uninstall_OrgaFestival.sql
