--P.444 숫자 1부터 10까지의 숫자 중 홀수만 출력하는 PL/SQL프로그램을 작성하세요.
--FOR문으로 만들기

DECLARE
BEGIN
    FOR i IN 0..10 LOOP
       IF MOD(i,2) = 1 THEN    
       DBMS_OUTPUT.PUT_LINE('현재 i의 값: '|| i);
       END IF;
    END LOOP;
END;
/

--WHILE문으로 만들기

DECLARE
    V_NUM NUMBER := 0;
BEGIN
    WHILE V_NUM < 10 LOOP
        IF MOD(V_NUM,2) = 1 THEN
            DBMS_OUTPUT.PUT_LINE('현재 i의 값: '|| V_NUM);
        END IF;
        V_NUM := V_NUM + 1;
    END LOOP;
END;
/   
