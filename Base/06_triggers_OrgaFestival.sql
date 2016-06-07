-- ====================================================================
-- Auteur : Antoine de Choudens
-- Script : 06_triggers_OrgaFestival.sql
-- Objet  : Création des triggers OrgaFestival sur SGBD Oracle en Local (HEGLOCAL) 

-- ====================================================
-- Trigger Artiste
-- ====================================================
CREATE OR REPLACE TRIGGER  tr_artiste 
  before insert on org_artiste             
  for each row  
begin   
    select sq_org_artiste.nextval into :NEW.art_no from dual; 
end; 

/
ALTER TRIGGER  tr_artiste ENABLE
/

-- ====================================================
-- Trigger Scene
-- ====================================================
CREATE OR REPLACE TRIGGER  tr_scene
  before insert on org_scene             
  for each row  
begin   
    select sq_org_scene.nextval into :NEW.sce_no from dual; 
end; 

/
ALTER TRIGGER  tr_scene ENABLE
/
-- ====================================================
-- Trigger Festival
-- ====================================================
CREATE OR REPLACE TRIGGER  tr_festival 
  before insert on org_festival              
  for each row  
begin   
    select sq_org_festival.nextval into :NEW.fes_no from dual; 
end; 

/
ALTER TRIGGER  tr_festival ENABLE
/

-- ====================================================
-- Trigger Joue
-- ====================================================
CREATE OR REPLACE TRIGGER  tr_joue
  before insert on org_joue              
  for each row  
begin   
    select sq_org_joue.nextval into :NEW.joue_no from dual; 
end; 

/
ALTER TRIGGER  tr_joue ENABLE
/

-- ====================================================
-- Trigger Utilisateur
-- ====================================================
CREATE OR REPLACE TRIGGER  tr_utilisateur
  before insert on org_utilisateur              
  for each row  
begin   
    select sq_org_utilisateur.nextval into :NEW.uti_no from dual; 
end; 

/
ALTER TRIGGER  tr_utilisateur ENABLE
/


