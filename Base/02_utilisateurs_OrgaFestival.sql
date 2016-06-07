-- ====================================================================
-- Auteur : Antoine de Choudens
-- Script : 02_utilisateurs_OrgaFestival.sql
-- Objet  : Création des utilisateurs BDD OrgaFestival sur SGBD Oracle en Local (HEGLOCAL)
-- ====================================================================

-- =============================================================================================
-- Suppression des rôles, utilisateurs et profil
-- =============================================================================================
-- Suppression des utilisateurs
DROP USER OrgaFestival_data CASCADE;
DROP USER OrgaFestival_user CASCADE;

-- Suppression des rôles
DROP ROLE role_OrgaFestival_data CASCADE;
DROP ROLE role_OrgaFestival_user CASCADE;

-- Suppression du profil
DROP PROFILE OrgaFestival_profil;

-- =============================================================================================
-- Création du profil
-- =============================================================================================
-- Creation du profil OrgaFestival_profil
CREATE PROFILE OrgaFestival_profil LIMIT
  SESSIONS_PER_USER 3
  FAILED_LOGIN_ATTEMPTS 3 
  PASSWORD_LOCK_TIME 1/24
  PASSWORD_LIFE_TIME 180 
  PASSWORD_REUSE_TIME 180 
  PASSWORD_REUSE_MAX UNLIMITED
  PASSWORD_GRACE_TIME 7;

-- =============================================================================================
-- Création du rôle role_OrgaFestival_data (rôle de l'utilisateur propriétaire des objets de la base)
-- =============================================================================================
-- Creation du rôle role_OrgaFestival_data
CREATE ROLE role_OrgaFestival_data;

-- droit de se connecter à la BDD
GRANT CONNECT TO role_OrgaFestival_data;

-- droit de créer des triggers, séquence, tables, packages, ...
GRANT RESOURCE TO role_OrgaFestival_data;

-- droit de créer des vues
GRANT CREATE VIEW TO role_OrgaFestival_data;


-- ===============================
-- Création du rôle role_OrgaFestival_user (rôle de l'utilisateur de l'application)
-- ===============================
-- Creation du rôle role_OrgaFestival_user
CREATE ROLE role_OrgaFestival_user;

-- droit de se connecter à la BDD
GRANT CREATE SESSION TO role_OrgaFestival_user;

-- ===================================
-- Création de l'utilisateur OrgaFestival_data (propriétaire des objets de schéma de la base)
-- ===================================
-- Creation de l'utilisateur OrgaFestival_data 
CREATE USER OrgaFestival_data
  PROFILE OrgaFestival_profil
  IDENTIFIED BY OrgaFestival_data
  DEFAULT TABLESPACE USERS
  TEMPORARY TABLESPACE TEMP
;
GRANT role_OrgaFestival_data TO OrgaFestival_data;
ALTER USER OrgaFestival_data quota unlimited ON USERS;

--===================================
--Création de l'utilisateur OrgaFestival_user (utilisateur de l'application)
--===================================
CREATE USER OrgaFestival_user
  PROFILE OrgaFestival_profil
  IDENTIFIED BY OrgaFestival_user
;
GRANT role_OrgaFestival_user TO OrgaFestival_user;
