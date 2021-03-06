if not exists(select * from sys.columns where object_id = object_id('users') and name = 'X509CertificateThumbprint')
	alter table users add X509CertificateThumbprint nvarchar(max)
go

IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUsers]'))
DROP VIEW [dbo].[vwUsers]
GO

create view vwUsers as
select u.*, cast( case when isnull(u.isdeleted,0) = 1 or isnull(o.isdeleted,0) = 1 then 1 else 0 end as bit ) as EffectiveIsDeleted
from users u inner join organizations o on u.organizationid = o.organizationid
go