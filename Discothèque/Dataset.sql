-- Clean the database
TRUNCATE TABLE EMPRUNTER
DELETE FROM ABONNÉS




-- Variable declaration
DECLARE @marc AS int
DECLARE @victor AS int
DECLARE @william AS int
DECLARE @napoléon AS int
DECLARE @valerie AS int




-- Marc Antoine (marc antoine)
INSERT INTO ABONNÉS (CODE_PAYS, NOM_ABONNÉ, PRÉNOM_ABONNÉ, LOGIN_ABONNÉ, PASSWORD_ABONNÉ)
VALUES (4, 'Antoine', 'Marc', 'marc', 'antoine')

-- Victor Hugo (victor hugo)
INSERT INTO ABONNÉS (CODE_PAYS, NOM_ABONNÉ, PRÉNOM_ABONNÉ, LOGIN_ABONNÉ, PASSWORD_ABONNÉ)
VALUES (1, 'Hugo', 'Victor', 'victor', 'hugo')

-- William Shakespeare (william shakespeare)
INSERT INTO ABONNÉS (CODE_PAYS, NOM_ABONNÉ, PRÉNOM_ABONNÉ, LOGIN_ABONNÉ, PASSWORD_ABONNÉ)
VALUES (5, 'Shakespeare', 'William', 'william', 'shakespeare')

-- Napoléon Bonnaparte (napoléon bonnaparte)
INSERT INTO ABONNÉS (CODE_PAYS, NOM_ABONNÉ, PRÉNOM_ABONNÉ, LOGIN_ABONNÉ, PASSWORD_ABONNÉ)
VALUES (1, 'Bonnaparte', 'Napoléon', 'napoléon', 'bonnaparte')

-- Valérie Damido (valérie damido)
INSERT INTO ABONNÉS (CODE_PAYS, NOM_ABONNÉ, PRÉNOM_ABONNÉ, LOGIN_ABONNÉ, PASSWORD_ABONNÉ)
VALUES (1, 'Damido', 'Valérie', 'valérie', 'damido')





-- Variable initialization
SELECT @marc = ABONNÉS.CODE_ABONNÉ FROM ABONNÉS WHERE LOGIN_ABONNÉ = 'marc'
SELECT @victor = ABONNÉS.CODE_ABONNÉ FROM ABONNÉS WHERE LOGIN_ABONNÉ = 'victor'
SELECT @william = ABONNÉS.CODE_ABONNÉ FROM ABONNÉS WHERE LOGIN_ABONNÉ = 'william'
SELECT @napoléon = ABONNÉS.CODE_ABONNÉ FROM ABONNÉS WHERE LOGIN_ABONNÉ = 'napoléon'
SELECT @valerie = ABONNÉS.CODE_ABONNÉ FROM ABONNÉS WHERE LOGIN_ABONNÉ = 'valérie'




-- Loan late by 11 days
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@victor, 1, DATEADD(MM, -1, GETDATE()), DATEADD(DD, -11, GETDATE()))

-- Loan late by 8 days (not displayed)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@victor, 2, DATEADD(MM, -1, GETDATE()), DATEADD(DD, -8, GETDATE()))

-- Loan late by 30 days
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@marc, 3, DATEADD(MM, -2, GETDATE()), DATEADD(DD, -30, GETDATE()))




-- Extended loan
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@marc, 4, GETDATE(), DATEADD(MM, 2, GETDATE()))

-- Extended loan
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@victor, 5, GETDATE(), DATEADD(MM, 5, GETDATE()))




-- Regular loan
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@marc, 6, GETDATE(), DATEADD(DD, 2, GETDATE()))

-- Regular loan
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE,DATE_RETOUR)
VALUES (@marc, 7, GETDATE(), DATEADD(DD, 2, GETDATE()),GETDATE())



-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@marc, 442, DATEADD(MM, -3, GETDATE()), DATEADD(MM, -2, GETDATE()))

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@william, 9, DATEADD(YYYY, -3, GETDATE()), DATEADD(YYYY, -2, GETDATE()))

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@william, 10, DATEADD(YYYY, -3, GETDATE()), DATEADD(YYYY, -2, GETDATE()))

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@william, 11, DATEADD(YYYY, -3, GETDATE()), DATEADD(YYYY, -2, GETDATE()))

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@william, 12, DATEADD(YYYY, -3, GETDATE()), DATEADD(YYYY, -2, GETDATE()))

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@william, 13, DATEADD(YYYY, -3, GETDATE()), DATEADD(YYYY, -2, GETDATE()))

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@william, 255, DATEADD(MM, -3, GETDATE()), DATEADD(MM, -2, GETDATE()))


-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@william, 14, DATEADD(YYYY, -3, GETDATE()), DATEADD(YYYY, -2, GETDATE()))

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE)
VALUES (@william, 15, DATEADD(YYYY, -3, GETDATE()), DATEADD(YYYY, -2, GETDATE()))

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE, DATE_RETOUR)
VALUES (@valerie, 17, DATEADD(YYYY, -3, GETDATE()), DATEADD(YYYY, -2, GETDATE()),GETDATE()-2)

-- inactive subscriber (Not deleted)
INSERT INTO EMPRUNTER (CODE_ABONNÉ, CODE_ALBUM, DATE_EMPRUNT, DATE_RETOUR_ATTENDUE, DATE_RETOUR)
VALUES (@valerie, 18, DATEADD(YYYY, -4, GETDATE()), DATEADD(YYYY, -2, GETDATE()),DATEADD(YYYY, -3, GETDATE()))


-- Loan display
SELECT * FROM EMPRUNTER
