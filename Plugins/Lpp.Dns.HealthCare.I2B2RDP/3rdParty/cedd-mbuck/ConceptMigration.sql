/*Concept Migration script
Michael Buck, PhD
mbuck@health.nyc.gov
July 28, 2012
*/

/*Migrates CEDD into CONCEPT_DIMENSION
*/

DELETE FROM NYC_I2B2DATA.dbo.CONCEPT_DIMENSION WHERE CONCEPT_PATH like '%\CEDD\%'
;

INSERT INTO NYC_I2B2DATA.dbo.CONCEPT_DIMENSION
SELECT DISTINCT a.C_FULLNAME as CONCEPT_PATH, a.C_BASECODE as CONCEPT_CD, a.C_NAME as NAME_CHAR, NULL as CONCEPT_BLOB, getdate() as UPDATE_DATE, GETDATE() as DOWNLOAD_DATE, GETDATE() as IMPORT_DATE, 'QUERYHEALTH' as SOURCESYSTEM_CD, 1 as UPLOAD_ID 
FROM cedd_ont.dbo.CEDD a
WHERE a.M_APPLIED_PATH = '@'
and a.C_SYNONYM_CD = 'N'  /*Don't add synonyms; the C_FULLNAME has to be unique in CONCEPT_DIMENSION*/
and a.C_FULLNAME not in (SELECT DISTINCT CONCEPT_PATH FROM NYC_I2B2DATA.dbo.CONCEPT_DIMENSION) /*Don't reinsert the same rows.*/
and a.C_BASECODE is not null
;
