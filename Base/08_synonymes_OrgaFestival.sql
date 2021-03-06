-- ======================================================================
--  Script: 07_synonymes_OrgaFestival.sql 
--  Objet : Cr�ation des synonymes de la base OrgaFestival 
-- ======================================================================

CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_scene FOR OrgaFestival_data.vw_scene;
CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_artistes FOR OrgaFestival_data.vw_artistes;
CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_planning_scene FOR OrgaFestival_data.vw_planning_scene;
CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_artiste_festival FOR OrgaFestival_data.vw_artiste_festival;
CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_festivals FOR OrgaFestival_data.vw_festivals;
CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_utilisateurs FOR OrgaFestival_data.vw_utilisateurs;
CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_ObjScene FOR OrgaFestival_data.vw_ObjScene;
CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_genres FOR OrgaFestival_data.vw_genres;
CREATE OR REPLACE SYNONYM OrgaFestival_user.vw_joue FOR OrgaFestival_data.vw_joue;

CREATE OR REPLACE SYNONYM OrgaFestival_user.sq_org_utilisateur FOR OrgaFestival_data.sq_org_utilisateur;
CREATE OR REPLACE SYNONYM OrgaFestival_user.sq_org_festival FOR OrgaFestival_data.sq_org_festival;
CREATE OR REPLACE SYNONYM OrgaFestival_user.sq_org_artiste FOR OrgaFestival_data.sq_org_artiste;
CREATE OR REPLACE SYNONYM OrgaFestival_user.sq_org_genre FOR OrgaFestival_data.sq_org_genre;
CREATE OR REPLACE SYNONYM OrgaFestival_user.sq_org_scene FOR OrgaFestival_data.sq_org_scene;
CREATE OR REPLACE SYNONYM OrgaFestival_user.sq_org_joue FOR OrgaFestival_data.sq_org_joue;
