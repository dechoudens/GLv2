--------------------------------------------------------------------------------------------
--Auteur : Antoine de Choudens
--Script : uninstall_OrgaFestival.sql
--Objet  : Création des synonymes de la BDD démonstration sur SGBD Oracle en Local (HEGLOCAL)

-- Suppression des utilisateurs (CASCADE), rôles et profil
SPOOL .\Logs\uninstall_OrgaFestival.log

--=============================================
--Suppression des rôles, utilisateurs et profil
--=============================================
--Suppression des utilisateurs
DROP USER OrgaFestival_data CASCADE;
DROP USER OrgaFestival_user CASCADE;

--Suppression des rôles
DROP ROLE role_OrgaFestival_data CASCADE;
DROP ROLE role_OrgaFestival_user CASCADE;

--Suppression du profil
DROP PROFILE OrgaFestival_profil;

SPOOL OFF

EXIT;
