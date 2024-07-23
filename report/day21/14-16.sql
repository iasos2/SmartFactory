--14-16

SELECT * FROM TABLE_UNIQUE;
INSERT INTO TABLE_UNIQUE (LOGIN_ID, LOGIN_PWD, TEL)
VALUES ('TEST_ID_02', 'PWD01', '010-1234-5678');

INSERT INTO TABLE_UNIQUE (LOGIN_ID, LOGIN_PWD, TEL)
VALUES ('TEST_ID_04', NULL, '010-1234-5678');

CREATE TABLE TABLE_UNIQUE2(
LOGIN_ID    VARCHAR2(20) CONSTRAINT TBLUNQ2_LGNID_UNQ UNIQUE,
LOGIN_PWD   VARCHAR2(20) CONSTRAINT TBLUNQ2_LGNPW_NN  NOT NULL,
TEL         VARCHAR2(20)
);
DROP TABLE TABLE_UNIQUE2;
SELECT OWNER, CONSTRAINT_NAME, CONSTRAINT_TYPE, TABLE_NAME
FROM USER_CONSTRAINTS
WHERE TABLE_NAME LIKE 'TABLE_UNIQUE%';
