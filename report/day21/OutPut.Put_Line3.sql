--PL/SQL 변수의 기본값을 설정할 수 있다.

DECLARE
    V_DEPTNO NUMBER(2) DEFAULT 10;
BEGIN
    --V_DEPTNO := 50;
    DBMS_OUTPUT.PUT_LINE(V_DEPTNO);
END;
/
