create or replace package pkg_horaire
AS
       FUNCTION isFreeShift(sce_no IN NUMBER, i_heure IN DATE)RETURN BOOLEAN;
               
END pkg_horaire;
/
create or replace package body pkg_horaire
AS

FUNCTION isFreeShift(i_sce_nom IN VARCHAR2, i_heure IN DATE)RETURN BOOLEAN
AS
         v_Hdebut org_scene.sce_heuredebut%TYPE;
         v_Hfin   org_scene.sce_heuredebut%TYPE;
         CURSOR cur_planning_scene     
         IS
                SELECT * FROM vw_planning_scene   
                WHERE Nom LIKE i_sce_nom
BEGIN
         SELECT sce_heuredebut, sce_heuredebut INTO v_Hdebut, v_Hfin FROM org_scene;
         
        FOR planning_rec
          IN cur_planning_scene
          LOOP
            IF i_heure = planning_rec.Heure THEN
              RETURN FALSE;
          END LOOP;
          
         RETURN TRUE;
         
END isFreeShift;

END pkg_horaire;
/
GRANT EXECUTE ON pkg_horaire TO role_OrgaFestival_user;


