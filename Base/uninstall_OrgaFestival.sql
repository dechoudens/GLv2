--------------------------------------------------------------------------------------------
--Auteur : Antoine de Choudens
--Script : uninstall_OrgaFestival.sql
--Objet  : Cr�ation des synonymes de la BDD d�monstration sur SGBD Oracle en Local (HEGLOCAL)

-- Suppression des utilisateurs (CASCADE), r�les et profil
SPOOL .\Logs\uninstall_OrgaFestival.log

--=============================================
--Suppression des r�les, utilisateurs et profil
--=============================================
--Suppression des utilisateurs
DROP USER OrgaFestival_data CASCADE;
DROP USER OrgaFestival_user CASCADE;

--Suppression des r�les
DROP ROLE role_OrgaFestival_data CASCADE;
DROP ROLE role_OrgaFestival_user CASCADE;

--Suppression du profil
DROP PROFILE OrgaFestival_profil;

SPOOL OFF

EXIT;
