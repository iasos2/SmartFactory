--기본 LOOP 사용하기(반복문) 

DECLARE
    V_NUM NUMBER := 0;
BEGIN
    LOOP
        DBMS_OUTPUT.PUT_LINE(V_NUM);
        V_NUM := V_NUM + 1;
        EXIT WHEN V_NUM > 4;
     END LOOP;
END;
/        
