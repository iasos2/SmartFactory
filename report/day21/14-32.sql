--14-32 제약에 이름을 넣자
CREATE TABLE TABLE_PK2(
LOGIN_ID VARCHAR2(20) CONSTRAINT TBLPK2_LGNID_PK PRIMARY KEY,
LOGIN_PWD VARCHAR2(20) CONSTRAINT TBLPK2_LGNPW_PK NOT NULL,
TEL VARCHAR2(20)
);

DESC TABLE_PK2;