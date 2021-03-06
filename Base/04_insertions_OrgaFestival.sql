-- ====================================================================
-- Auteur : Antoine de Choudens
-- Script : 04_insertions_OrgaFestival.sql
-- Objet  : Insertions de donn�es sur les tables OrgaFestival 
-- ====================================================================

SET DEFINE OFF

-- ====================================================
-- Drop sequence
-- ====================================================
DROP SEQUENCE sq_org_utilisateur;
DROP SEQUENCE sq_org_festival;
DROP SEQUENCE sq_org_artiste;
DROP SEQUENCE sq_org_genre;
DROP SEQUENCE sq_org_scene;
DROP SEQUENCE sq_org_joue;


-- ====================================================
-- Initialisation des sequences
-- ====================================================
CREATE SEQUENCE sq_org_utilisateur
       MINVALUE 1
       START WITH 1;
       
CREATE SEQUENCE sq_org_festival
       MINVALUE 1
       START WITH 1;
       
CREATE SEQUENCE sq_org_artiste
       MINVALUE 1
       START WITH 1;
       
CREATE SEQUENCE sq_org_genre
       MINVALUE 1
       START WITH 1;
       
CREATE SEQUENCE sq_org_scene
       MINVALUE 1
       START WITH 1;
       
CREATE SEQUENCE sq_org_joue
       MINVALUE 1
       START WITH 1;
       
-- ====================================================
-- Insertion Table : org_utilisateur
-- ====================================================
INSERT INTO org_utilisateur VALUES(sq_org_utilisateur.NEXTVAL, 'admin', '123', 'DE CHOUDENS', 'Antoine', '7 ch. de Bonne, 1233 Bernex', '0763823991');
INSERT INTO org_utilisateur VALUES(sq_org_utilisateur.NEXTVAL, 'georgb', '1234', 'Benedicte', 'George', '8 ch. de la tour, 1213 Onex', '077582565');
INSERT INTO org_utilisateur VALUES(sq_org_utilisateur.NEXTVAL, 'fredec', '12345', 'Chavez', 'Frederic', '7 ch. de Bonne, 1233 Bernex', '0722824321');
INSERT INTO org_utilisateur VALUES(sq_org_utilisateur.NEXTVAL, 'test', '123', 'test', 'test', '0 ch de test', '545455');

COMMIT;

-- ====================================================
-- Insertion Table : org_festival
-- ====================================================
INSERT INTO org_festival VALUES(sq_org_festival.NEXTVAL, 'Paleo', 'Nyon, Switzerland', '01.06.2016', '08.06.2016', 1);
INSERT INTO org_festival VALUES(sq_org_festival.NEXTVAL, 'Burning Man', 'Black Rock Desert, Nevada, United States', '12.07.2016', '24.07.2016', 2);
INSERT INTO org_festival VALUES(sq_org_festival.NEXTVAL, 'Coachella', 'Indio, California, United States', '07.08.2016', '14.08.2016', 3);

COMMIT;

-- ====================================================
-- Insertion Table : org_genre
-- ====================================================

INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Hip-Hop');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Rock');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Indie rock');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Pop');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Indie pop');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Jazz');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Techno');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Trance');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Blues');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Metal');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Hard Rock');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Dubstep');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Classique');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Folk');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Punk rock');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Dancehall');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Death metal');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Drum & Bass');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Dub');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Reggae');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Electro house');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Electro swing');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Jazz fusion');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Disco');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Rap');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Reggaet�n');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Pop rock');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'R&B');
INSERT INTO org_genre VALUES(sq_org_genre.NEXTVAL, 'Ska');
COMMIT;

-- ====================================================
-- Insertion Table : org_artiste
-- ====================================================

INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'JayZ', 'Jay Z, anciennement Jay-Z de son vrai nom Shawn Corey Carter, n� le 4 d�cembre 1969 � New York, est un rappeur et homme d''affaires am�ricain. Il est l''un des artistes de hip-hop les mieux r�mun�r�s d''Am�rique', 1);
INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Muse', 'Muse est un groupe de rock britannique originaire de Teignmouth, dans le Devon, en Angleterre. Apparu sur la sc�ne musicale en 1994, le trio est compos� de Matthew Bellamy (chant, guitare, piano), Christopher Wolstenholme (basse, harmonica, chant, ch�urs) et Dominic Howard', 2);
INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Alt-J', 'alt-J est un groupe de rock ind�pendant alternatif anglais originaire de Leeds compos� de quatre musiciens et form� en 2007.', 16);                                                                        

INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Metronomy', 'Metronomy est un groupe de musique �lectronique et alternative form� en 1999 par Joseph Mount � Totnes, ville du sud du Devon en Angleterre. Le groupe actuel est compos� de Joseph Mount (compositions, au chant, claviers et guitare), d''Anna Prior (batterie et au chant), d''Oscar Cash (saxophone, claviers, guitare et ch�urs) et d''Olugbenga Adelekan (basse et ch�urs).', 15);

INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Skrilex', 'Sonny John Moore, known professionally as Skrillex, is an American electronic music producer, DJ, singer and songwriter.', 12);
INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Whitechapel', 'Whitechapel est un groupe de deathcore am�ricain fond� en 2006.', 17);
INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Damian Marley', 'Damian Marley est un artiste musicien, producteur de disques et reggaeman n� � Kingston, le 21 juillet 1978. Il est le fils de Bob Marley, d�o� son surnom de � Junior Gong � qui lui vient de son p�re surnomm� � Tuff Gong �', 20);
INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Caravan Palace', 'Caravan Palace est un groupe fran�ais de musique �lectronique dont le premier album est sorti en octobre 2008 chez Wagram Music.', 22);
INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Usher', 'Usher Terry Raymond IV n� le 14 octobre 1978 � Dallas au Texas, est un chanteur de RnB, danseur, parolier, et acteur am�ricain.', 28);
INSERT INTO org_artiste VALUES(sq_org_artiste.NEXTVAL, 'Michael Douglas', null, null);

-- ====================================================
-- Insertion Table : org_scene
-- ====================================================
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Grande sc�ne', 'C''est une grande sc�ne', 10000, 150, 100, TO_DATE('08:00', 'hh24:mi'), TO_DATE('23:00', 'hh24:mi'), 1);
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Petite sc�ne', 'C''est une petite sc�ne', 5000, 90, 80, TO_DATE('08:00', 'hh24:mi'), TO_DATE('23:00', 'hh24:mi'), 1);
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Chapiteau', 'C''est un chapiteau', 2000, 100, 70, TO_DATE('08:00', 'hh24:mi'), TO_DATE('22:00', 'hh24:mi'), 1);
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'EthnScene', 'Sc�ne du monde', 1000, 100, 60, TO_DATE('08:00', 'hh24:mi'), TO_DATE('19:00', 'hh24:mi'), 1);

INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Sc�ne Rouge', 'Genre : rock, metal', 2000, 100, 70, TO_DATE('08:00', 'hh24:mi'), TO_DATE('23:00', 'hh24:mi'), 2);
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Sc�ne Bleue', 'Electro', 5000, 90, 80, TO_DATE('08:00', 'hh24:mi'), TO_DATE('23:00', 'hh24:mi'), 2);
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Sc�ne Principal', 'C''est un chapiteau', 10000, 150, 100, TO_DATE('08:00', 'hh24:mi'), TO_DATE('23:00', 'hh24:mi'), 2);
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Sc�ne Verte', 'Jazz', 1000, 100, 60, TO_DATE('08:00', 'hh24:mi'), TO_DATE('23:00', 'hh24:mi'), 2);

INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Main stage', 'Sc�ne principale', 2000, 50, 60, TO_DATE('08:00', 'hh24:mi'), TO_DATE('23:00', 'hh24:mi'), 3);
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Little one', 'Pour les nouveaux groupe', 2000, 100, 70, TO_DATE('08:00', 'hh24:mi'), TO_DATE('18:00', 'hh24:mi'), 3);
INSERT INTO org_scene VALUES(sq_org_scene.NEXTVAL, 'Discovery', 'Musique du monde', 5000, 100, 70, TO_DATE('08:00', 'hh24:mi'), TO_DATE('23:00', 'hh24:mi'), 3);

COMMIT;

-- ====================================================
-- Insertion Table : org_administre
-- ====================================================
INSERT INTO org_administre VALUES(1, 1); 
INSERT INTO org_administre VALUES(1, 2); 
INSERT INTO org_administre VALUES(2, 3); 

COMMIT;

-- ====================================================
-- Insertion Table : org_participe
-- ====================================================
INSERT INTO org_participe VALUES(1, 1);
INSERT INTO org_participe VALUES(1, 2);
INSERT INTO org_participe VALUES(1, 3);
INSERT INTO org_participe VALUES(2, 1);
INSERT INTO org_participe VALUES(3, 1);
INSERT INTO org_participe VALUES(4, 2);
INSERT INTO org_participe VALUES(5, 2);
INSERT INTO org_participe VALUES(6, 2);
INSERT INTO org_participe VALUES(7, 3);
INSERT INTO org_participe VALUES(8, 3);
INSERT INTO org_participe VALUES(8, 2);
INSERT INTO org_participe VALUES(9, 3);
INSERT INTO org_participe VALUES(9, 2);
INSERT INTO org_participe VALUES(9, 1);

COMMIT;

-- ====================================================
-- Insertion Table : org_joue
-- ====================================================
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('01.06.2016 08:00', 'dd.mm.yyyy hh24:mi'), 1, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('02.06.2016 09:00', 'dd.mm.yyyy hh24:mi'), 1, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('02.06.2016 10:00', 'dd.mm.yyyy hh24:mi'), 1, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('02.06.2016 11:00', 'dd.mm.yyyy hh24:mi'), 1, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('02.06.2016 12:00', 'dd.mm.yyyy hh24:mi'), 1, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('03.06.2016 13:00', 'dd.mm.yyyy hh24:mi'), 2, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('03.06.2016 14:00', 'dd.mm.yyyy hh24:mi'), 2, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('03.06.2016 15:00', 'dd.mm.yyyy hh24:mi'), 2, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('03.06.2016 16:00', 'dd.mm.yyyy hh24:mi'), 2, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('01.06.2016 17:00', 'dd.mm.yyyy hh24:mi'), 2, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('01.06.2016 18:00', 'dd.mm.yyyy hh24:mi'), 2, 1);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('01.06.2016 19:00', 'dd.mm.yyyy hh24:mi'), 3, 1);

INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('08:00', 'hh24:mi'), 1, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('09:00', 'hh24:mi'), 4, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('10:00', 'hh24:mi'), 4, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('11:00', 'hh24:mi'), 4, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('12:00', 'hh24:mi'), 4, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('13:00', 'hh24:mi'), 4, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('14:00', 'hh24:mi'), 5, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('15:00', 'hh24:mi'), 5, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('16:00', 'hh24:mi'), 5, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('17:00', 'hh24:mi'), 5, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('18:00', 'hh24:mi'), 7, 2);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('19:00', 'hh24:mi'), 6, 2);


INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('08:00', 'hh24:mi'), 7, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('09:00', 'hh24:mi'), 7, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('10:00', 'hh24:mi'), 7, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('11:00', 'hh24:mi'), 7, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('12:00', 'hh24:mi'), 7, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('13:00', 'hh24:mi'), 7, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('14:00', 'hh24:mi'), 8, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('15:00', 'hh24:mi'), 8, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('16:00', 'hh24:mi'), 8, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('17:00', 'hh24:mi'), 9, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('18:00', 'hh24:mi'), 9, 3);
INSERT INTO org_joue VALUES(sq_org_joue.NEXTVAL, TO_DATE('19:00', 'hh24:mi'), 9, 3);

COMMIT;

