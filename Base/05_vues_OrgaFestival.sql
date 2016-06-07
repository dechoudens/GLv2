-- ======================================================================
--  Auteur : Antoine de Choudens
--  Script: 05_vues_OrgaFestival.sql 
--  Objet : Création des vues schéma de la base OrgaFestival
-- ======================================================================

-- ====================================================
-- Création des VUES
-- ====================================================
-- ====================================================
-- Vue d'affichage des scene
--                 + le nom de leur festival
-- ====================================================
CREATE OR REPLACE VIEW vw_scene
(Festival, Nom, Descriptions, Capacite, Dimensions) 
AS
       SELECT fes_nom, sce_nom, sce_description, sce_capacite, sce_dimensionX || 'X' || sce_dimensionY
       FROM org_scene 
       JOIN org_festival ON sce_fes_no = fes_no
       ORDER BY fes_nom
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_scene TO OrgaFestival_user;


-- ====================================================
-- Vue d'affichage des scenes
-- ====================================================
CREATE OR REPLACE VIEW vw_ObjScene
(Numero, Nom, DescriptionScene, Capacite, DimensionX, DimensionY, HeureDebut, HeureFin, Festival) 
AS
       SELECT *
       FROM org_scene 
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_ObjScene TO OrgaFestival_user;


-- ====================================================
-- Vue d'affichage des artistes
-- ====================================================
CREATE OR REPLACE VIEW vw_artistes
(Numero, Nom, Biographie, Genre)
AS
       SELECT art_no, art_nom, art_biographie, art_gen_no
       FROM org_artiste
       JOIN org_genre ON art_gen_no = gen_no
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_artistes TO OrgaFestival_user;


-- ====================================================
-- Vue d'affichage des utilistateurs
-- ====================================================
CREATE OR REPLACE VIEW vw_utilisateurs
(Numero, Identifiant, MDP, Nom, Prenom, Adresse, Telephone) 
AS
         SELECT *
         FROM org_utilisateur
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_utilisateurs TO OrgaFestival_user;


-- ====================================================
-- Vue d'affichage des festivals
-- ====================================================
CREATE OR REPLACE VIEW vw_festivals
(Numero, Nom, Location, dateDebut, dateFin, utilisateur) 
AS
       SELECT *
       FROM org_festival
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_festivals TO OrgaFestival_user;


-- ====================================================
-- Vue d'affichage du planning des artistes
--               - par artistes
--               - par scène
--               - par heure
-- ====================================================
CREATE OR REPLACE VIEW vw_planning_scene
(Artiste, Scene, Heure, Festival) 
AS
       SELECT art_nom, sce_nom, TO_CHAR(joue_heure, 'DD-MM-YYYY HH24:MI'), fes_nom
       FROM org_artiste 
       JOIN org_joue ON art_no = joue_art_no
       JOIN org_scene ON sce_no = joue_sce_no
       JOIN org_festival ON fes_no = sce_fes_no
       ORDER BY sce_nom, joue_heure, art_nom, fes_nom
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_planning_scene TO OrgaFestival_user;

-- ====================================================
-- Vue de la participation des artistes aux festivals
-- ====================================================
CREATE OR REPLACE VIEW vw_artiste_festival
(Nom, Festival) 
AS
       SELECT art_nom, fes_nom 
       FROM org_participe 
       JOIN org_artiste ON par_art_no = art_no 
       JOIN org_festival ON fes_no = par_fes_no
       ORDER BY fes_nom, art_nom
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_artiste_festival TO OrgaFestival_user;

-- ====================================================
-- Vue d'affichage des genres
-- ====================================================
CREATE OR REPLACE VIEW vw_genres
(Numero, Nom) 
AS
       SELECT *
       FROM org_genre
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_genres TO OrgaFestival_user;


-- ====================================================
-- Vue de l'horaire de chaque artiste par festival
-- ====================================================
CREATE OR REPLACE VIEW vw_joue
(Numero, Heure, Artiste, Scene) 
AS
       SELECT * 
       FROM org_joue
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_joue TO OrgaFestival_user;





