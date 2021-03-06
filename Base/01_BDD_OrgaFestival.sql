-- ====================================================================
-- Auteur : Antoine de Choudens
-- Script : 01_OrgaFestival.sql
-- Objet  : Cr�ation BDD OrgaFestival sur SGBD Oracle en Local (HEGLOCAL) 
-- ====================================================================

SET ECHO ON
SET LINESIZE 200
SET PAGESIZE 60

-- Cr�ation des utilisateurs en tant que System
SPOOL .\Logs\02_utilisateurs_OrgaFestival.log
@.\02_utilisateurs_OrgaFestival.sql
SPOOL OFF

-- Connexion � HEGLOCAL en tant que OrgaFestival_data (propir�taires des objets de sch�ma)
CONNECT OrgaFestival_data/OrgaFestival_data@XE
--CONNECT OrgaFestival_data/OrgaFestival_data@HEGLOCAL
-- Cr�ation des tables
SPOOL .\Logs\03_tables_OrgaFestival.log
@.\03_tables_OrgaFestival.sql
SPOOL OFF

-- Chargement des donn�es
SPOOL .\Logs\04_insertions_OrgaFestival.log
@.\04_insertions_OrgaFestival.sql;
SPOOL OFF

-- Cr�ation des vues
SPOOL .\Logs\05_vues_OrgaFestival.log
@.\05_vues_OrgaFestival.sql
SPOOL OFF

-- Cr�ation des triggers pour les clefs primaires
SPOOL .\Logs\06_triggers_OrgaFestival.log
@.\06_triggers_OrgaFestival.sql;
SPOOL OFF

-- Cr�ation des packages
SPOOL .\Logs\07_package_OrgaFestival.log
@.\07_package_OrgaFestival.sql;
SPOOL OFF

-- Connexion � HEGLOCAL en tant que system
CONNECT system/manager@XE
--CONNECT system/manager@HEGLOCAL

-- Cr�ation des synonymes
SPOOL .\Logs\08_synonymes_OrgaFestival.log
@.\08_synonymes_OrgaFestival.sql;
SPOOL OFF

SET ECHO OFF

EXIT;
