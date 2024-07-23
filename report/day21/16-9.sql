--스칼라형 변수
--참조형 변수(16-9)
--참조형의 변수에 값을 대입한 후 출력하기

DECLARE
    V_DEPTNO DEPT.DEPTNO%TYPE DEFAULT 50;
BEGIN
DBMS_OUTPUT.PUT_LINE('V_DEPTNO : ' || V_DEPTNO);
END;
