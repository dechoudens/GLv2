-- ====================================================================
-- Auteur : Antoine de Choudens
-- Script : 04_insertions_OrgaFestival.sql
-- Objet  : Insertions de données sur les tables OrgaFestival 
-- ====================================================================
-- ==================================================== 
-- Drop table
-- ====================================================
DROP TABLE org_artiste CASCADE CONSTRAINT;
DROP TABLE org_scene CASCADE CONSTRAINT;
DROP TABLE org_joue CASCADE CONSTRAINT;
DROP TABLE org_festival CASCADE CONSTRAINT;
DROP TABLE org_utilisateur CASCADE CONSTRAINT;
DROP TABLE org_participe CASCADE CONSTRAINT;
DROP TABLE org_administre CASCADE CONSTRAINT;
DROP TABLE org_genre CASCADE CONSTRAINT;


-- ==================================================== 
-- Table : org_artiste
-- ====================================================
CREATE TABLE org_artiste(
       art_no            NUMBER(8) CONSTRAINT pk_art_no PRIMARY KEY,
       art_nom           VARCHAR2(255) CONSTRAINT nn_art_nom NOT NULL,
       art_biographie    VARCHAR2(1000),
       art_gen_no        NUMBER(8)
);

-- ====================================================
-- Table : org_scene
-- ====================================================
CREATE TABLE org_scene (
       sce_no          NUMBER(8) CONSTRAINT pk_sce_no PRIMARY KEY,
       sce_nom         VARCHAR2(255) CONSTRAINT nn_sce_nom NOT NULL,
       sce_description VARCHAR2(1000),
       sce_capacite    NUMBER(8),
       sce_dimensionX  NUMBER(8),
       sce_dimensionY  NUMBER(8),
       sce_heureDebut  DATE CONSTRAINT nn_sce_heureDebut NOT NULL,
       sce_heureFin    DATE CONSTRAINT nn_sce_heureFin NOT NULL,
       sce_fes_no      NUMBER(8)
);

-- ====================================================
-- Table : org_festival
-- ====================================================
CREATE TABLE org_festival (
       fes_no          NUMBER(8) CONSTRAINT pk_fes_no PRIMARY KEY,
       fes_nom         VARCHAR2(255) CONSTRAINT nn_fes_nom NOT NULL,
       fes_location    VARCHAR2(255) CONSTRAINT nn_fes_location NOT NULL,
       fes_dateDebut   DATE,
       fes_dateFin     DATE,
       fes_uti_no      NUMBER(8)
);     

-- ====================================================
-- Table : org_joue
-- ====================================================
CREATE TABLE org_joue (
       joue_no                  NUMBER(8),
       joue_heure               DATE CONSTRAINT nn_joue_heure NOT NULL,
       joue_art_no              NUMBER(8) NOT NULL CONSTRAINT fk_org_joue_art REFERENCES org_artiste (art_no),
       joue_sce_no              NUMBER(8) NOT NULL CONSTRAINT fk_org_joue_sce REFERENCES org_scene(sce_no)
);

-- ====================================================
-- Table : org_utilisateur
-- ====================================================
CREATE TABLE org_utilisateur (
       uti_no                NUMBER(8) CONSTRAINT pk_uti_no PRIMARY KEY,
       uti_identifiant       VARCHAR2(30) CONSTRAINT nn_uti_identifiant NOT NULL,
       uti_mdp               VARCHAR2(30) CONSTRAINT nn_uti_mdp NOT NULL,
       uti_nom               VARCHAR2(255),
       uti_prenom            VARCHAR2(255),
       uti_adresse           VARCHAR2(255),
       uti_telephone         VARCHAR2(20)
);

-- ====================================================
-- Table : org_participe
-- ====================================================
CREATE TABLE org_participe (
       par_art_no              NUMBER(8) NOT NULL CONSTRAINT fk_org_par_art REFERENCES org_artiste (art_no),
       par_fes_no              NUMBER(8) NOT NULL CONSTRAINT fk_org_par_fes REFERENCES org_festival(fes_no),
       CONSTRAINT pk_org_participe PRIMARY KEY (par_art_no, par_fes_no)
);

-- ====================================================
-- Table : org_possede
-- ====================================================
CREATE TABLE org_administre (
       adm_uti_no              NUMBER(8) NOT NULL CONSTRAINT fk_org_adm_uti REFERENCES org_utilisateur (uti_no),
       adm_fes_no              NUMBER(8) NOT NULL CONSTRAINT fk_org_adm_fes REFERENCES org_festival(fes_no),
       CONSTRAINT pk_org_administre PRIMARY KEY (adm_uti_no, adm_fes_no)
);

-- ====================================================
-- Table : org_genre
-- ====================================================
CREATE TABLE org_genre ( 
       gen_no          NUMBER(8) CONSTRAINT pk_gen_no PRIMARY KEY,
       gen_nom         VARCHAR2(30)
);

-- Ajout des foreign key
ALTER TABLE org_artiste ADD CONSTRAINT fk_org_art_gen FOREIGN KEY (art_gen_no) REFERENCES org_genre (gen_no);
ALTER TABLE org_scene ADD CONSTRAINT fk_org_sce_fes FOREIGN KEY (sce_fes_no) REFERENCES org_festival (fes_no);
ALTER TABLE org_festival ADD CONSTRAINT fk_org_fes_uti FOREIGN KEY (fes_uti_no) REFERENCES org_utilisateur (uti_no);

