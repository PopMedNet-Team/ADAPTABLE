-- WORKPLANTYPE UPDATE FOR M-S QUERYTOOL
-- Daniel Dee, 5/6/15
-- This will happen less often than Code Update, probably every 6 months or so, so we're turning to a manual process right now.
-- The code here is written for PMNMAINT-1073 (4/29/15).
-- Going forward, HPHCI should supply an XLS document containing changes necessary and MSP should update this file to conform.
-- The SQL is wrapped in a transaction and rolled back at the end so that MSP can verify before running.
-- To actually apply it, the ROLLBACK statement should commented and the COMMIT statement should be uncommented.

BEGIN TRANSACTION

USE [DNS3_QA_STARTER]

-- Output WorkplanTypes table as it exists.
SELECT * FROM [WorkplanTypes]

-- ADDITIONS
INSERT INTO [WorkplanTypes] (workplantypeid, name, networkid) VALUES(28, 'Modular Program Level 2 Request', '20850001-2AEA-4F88-A04A-A2F201228231')
INSERT INTO [WorkplanTypes] (workplantypeid, name, networkid) VALUES(29, 'Modular Program Level 2 Request Beta', '20850001-2AEA-4F88-A04A-A2F201228231')

-- DELETIONS
DELETE FROM [WorkplanTypes] WHERE name='PROMPT Development'
DELETE FROM [WorkplanTypes] WHERE name='PROMPT Development Beta'
DELETE FROM [WorkplanTypes] WHERE name='Workgroup Request'
DELETE FROM [WorkplanTypes] WHERE name='Workgroup Request Beta'

-- UPDATES
UPDATE [WorkplanTypes] SET name='Ad Hoc Development Beta' WHERE name='Workgroup Development Beta'
UPDATE [WorkplanTypes] SET name='Modular Program Development Beta' WHERE name='Modular Program  Dev Beta'
UPDATE [WorkplanTypes] SET name='Modular Program Level 1 Request' WHERE name='Modular Program Request'
UPDATE [WorkplanTypes] SET name='Modular Program Level 1 Request Beta' WHERE name='Modular Program Request Beta'
UPDATE [WorkplanTypes] SET name='Modular Program Level 3 Request' WHERE name='PROMPT Request'
UPDATE [WorkplanTypes] SET name='Modular Program Level 3 Request Beta' WHERE name='PROMPT Request Beta'

-- Output WorkplanTypes after changes.
SELECT * FROM [WorkplanTypes]

ROLLBACK;
-- COMMIT;

