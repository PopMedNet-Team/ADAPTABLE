IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[security_tuple1]')) drop view security_tuple1
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[security_tuple2]')) drop view security_tuple2
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[security_tuple3]')) drop view security_tuple3
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[security_tuple4]')) drop view security_tuple4
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[security_tuple5]')) drop view security_tuple5
go

IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[_vwAclEntries]')) DROP VIEW [dbo].[_vwAclEntries]
GO

if not exists( select * from sys.tables where object_id = object_id( 'securityobjects' ) )
create table SecurityObjects( [Id] uniqueidentifier not null, [ParentId] uniqueidentifier not null, LeftIndex int not null, RightIndex int not null, TreeTag uniqueidentifier not null )
go

set ansi_padding on
go

create view _vwAclEntries
with schemabinding
as 
	select t.Arity, t.ObjectId1, t.ObjectId2, t.ObjectId3, t.ObjectId4, t.ObjectId5, t.ObjectId6, t.ObjectId7, t.ObjectId8, t.ObjectId9, t.ObjectId10,
	       e.PrivilegeId, e.SubjectId, e.Allow, e.[Order], e.Id
	from dbo.AclEntries e
	inner join dbo.SecurityTargets t
	on e.TargetId = t.Id
go
	
create unique clustered index ix on _vwAclEntries(
		Arity, 
		ObjectId1, ObjectId2, ObjectId3, ObjectId4, ObjectId5, ObjectId6, ObjectId7, ObjectId8, ObjectId9, ObjectId10,
		PrivilegeId, SubjectId, [Order], Allow, Id
		)
go

create view Security_Tuple1 as
select * from
(
	select ROW_NUMBER() over(
			partition by 
				isnull(o1.id,e.ObjectId1), e.SubjectId, e.PrivilegeId 
			order by 
				po1.LeftIndex desc, e.[Order]
		   ) as idx,
		   isnull(o1.Id,e.ObjectId1) as Id1, 
		   e.ObjectId1 as ParentId1,
		   e.SubjectId, e.PrivilegeId, e.Allow
	from _vwAclEntries e with(noexpand)
	
		left join SecurityObjects po1 on po1.Id = e.ObjectId1
		left join securityobjects o1 on o1.TreeTag = po1.TreeTag and o1.leftindex >= po1.LeftIndex and o1.rightindex <= po1.RightIndex
	
	where e.Arity = 1
) e
where e.idx = 1
GO

create view Security_Tuple2 as
select * from
(
	select ROW_NUMBER() over(
			partition by 
				isnull(o1.id,e.ObjectId1), isnull(o2.id,e.ObjectId2), e.SubjectId, e.PrivilegeId 
			order by 
				po1.LeftIndex desc, po2.LeftIndex desc, e.[Order]
		   ) as idx,
		   isnull(o1.Id,e.ObjectId1) as Id1, isnull(o2.Id,e.ObjectId2) as Id2, 
		   e.ObjectId1 as ParentId1, e.ObjectId2 as ParentId2,
		   e.SubjectId, e.PrivilegeId, e.Allow
	from _vwAclEntries e with(noexpand)
	
		left join SecurityObjects po1 on po1.Id = e.ObjectId1
		left join securityobjects o1 on o1.TreeTag = po1.TreeTag and o1.leftindex >= po1.LeftIndex and o1.rightindex <= po1.RightIndex
	
		left join SecurityObjects po2 on po2.Id = e.ObjectId2
		left join securityobjects o2 on o2.TreeTag = po2.TreeTag and o2.leftindex >= po2.LeftIndex and o2.rightindex <= po2.RightIndex
	
	where e.Arity = 2
) e
where e.idx = 1
GO

create view Security_Tuple3 as
select * from
(
	select ROW_NUMBER() over(
			partition by 
				isnull(o1.id,e.ObjectId1), isnull(o2.id,e.ObjectId2), isnull(o3.id,e.ObjectId3), e.SubjectId, e.PrivilegeId 
			order by 
				po1.LeftIndex desc, po2.LeftIndex desc, po3.LeftIndex desc, e.[Order]
		   ) as idx,
		   isnull(o1.Id,e.ObjectId1) as Id1, isnull(o2.Id,e.ObjectId2) as Id2, isnull(o3.Id,e.ObjectId3) as Id3, 
		   e.ObjectId1 as ParentId1, e.ObjectId2 as ParentId2, e.ObjectId3 as ParentId3,
		   e.SubjectId, e.PrivilegeId, e.Allow
	from _vwAclEntries e with(noexpand)
	
		left join SecurityObjects po1 on po1.Id = e.ObjectId1
		left join securityobjects o1 on o1.TreeTag = po1.TreeTag and o1.leftindex >= po1.LeftIndex and o1.rightindex <= po1.RightIndex
	
		left join SecurityObjects po2 on po2.Id = e.ObjectId2
		left join securityobjects o2 on o2.TreeTag = po2.TreeTag and o2.leftindex >= po2.LeftIndex and o2.rightindex <= po2.RightIndex
	
		left join SecurityObjects po3 on po3.Id = e.ObjectId3
		left join securityobjects o3 on o3.TreeTag = po3.TreeTag and o3.leftindex >= po3.LeftIndex and o3.rightindex <= po3.RightIndex
	
	where e.Arity = 3
) e
where e.idx = 1
GO

create view Security_Tuple4 as
select * from
(
	select ROW_NUMBER() over(
			partition by 
				isnull(o1.id,e.ObjectId1), isnull(o2.id,e.ObjectId2), isnull(o3.id,e.ObjectId3), isnull(o4.id,e.ObjectId4), e.SubjectId, e.PrivilegeId 
			order by 
				po1.LeftIndex desc, po2.LeftIndex desc, po3.LeftIndex desc, po4.LeftIndex desc, e.[Order]
		   ) as idx,
		   isnull(o1.Id,e.ObjectId1) as Id1, isnull(o2.Id,e.ObjectId2) as Id2, isnull(o3.Id,e.ObjectId3) as Id3, isnull(o4.Id,e.ObjectId4) as Id4, 
		   e.ObjectId1 as ParentId1, e.ObjectId2 as ParentId2, e.ObjectId3 as ParentId3, e.ObjectId4 as ParentId4,
		   e.SubjectId, e.PrivilegeId, e.Allow
	from _vwAclEntries e with(noexpand)
	
		left join SecurityObjects po1 on po1.Id = e.ObjectId1
		left join securityobjects o1 on o1.TreeTag = po1.TreeTag and o1.leftindex >= po1.LeftIndex and o1.rightindex <= po1.RightIndex
	
		left join SecurityObjects po2 on po2.Id = e.ObjectId2
		left join securityobjects o2 on o2.TreeTag = po2.TreeTag and o2.leftindex >= po2.LeftIndex and o2.rightindex <= po2.RightIndex
	
		left join SecurityObjects po3 on po3.Id = e.ObjectId3
		left join securityobjects o3 on o3.TreeTag = po3.TreeTag and o3.leftindex >= po3.LeftIndex and o3.rightindex <= po3.RightIndex
	
		left join SecurityObjects po4 on po4.Id = e.ObjectId4
		left join securityobjects o4 on o4.TreeTag = po4.TreeTag and o4.leftindex >= po4.LeftIndex and o4.rightindex <= po4.RightIndex
	
	where e.Arity = 4
) e
where e.idx = 1
GO

create view Security_Tuple5 as
select * from
(
	select ROW_NUMBER() over(
			partition by 
				isnull(o1.id,e.ObjectId1), isnull(o2.id,e.ObjectId2), isnull(o3.id,e.ObjectId3), isnull(o4.id,e.ObjectId4), isnull(o5.id,e.ObjectId5), e.SubjectId, e.PrivilegeId 
			order by 
				po1.LeftIndex desc, po2.LeftIndex desc, po3.LeftIndex desc, po4.LeftIndex desc, po5.LeftIndex desc, e.[Order]
		   ) as idx,
		   isnull(o1.Id,e.ObjectId1) as Id1, isnull(o2.Id,e.ObjectId2) as Id2, isnull(o3.Id,e.ObjectId3) as Id3, isnull(o4.Id,e.ObjectId4) as Id4, isnull(o5.Id,e.ObjectId5) as Id5, 
		   e.ObjectId1 as ParentId1, e.ObjectId2 as ParentId2, e.ObjectId3 as ParentId3, e.ObjectId4 as ParentId4, e.ObjectId5 as ParentId5,
		   e.SubjectId, e.PrivilegeId, e.Allow
	from _vwAclEntries e with(noexpand)
	
		left join SecurityObjects po1 on po1.Id = e.ObjectId1
		left join securityobjects o1 on o1.TreeTag = po1.TreeTag and o1.leftindex >= po1.LeftIndex and o1.rightindex <= po1.RightIndex
	
		left join SecurityObjects po2 on po2.Id = e.ObjectId2
		left join securityobjects o2 on o2.TreeTag = po2.TreeTag and o2.leftindex >= po2.LeftIndex and o2.rightindex <= po2.RightIndex
	
		left join SecurityObjects po3 on po3.Id = e.ObjectId3
		left join securityobjects o3 on o3.TreeTag = po3.TreeTag and o3.leftindex >= po3.LeftIndex and o3.rightindex <= po3.RightIndex
	
		left join SecurityObjects po4 on po4.Id = e.ObjectId4
		left join securityobjects o4 on o4.TreeTag = po4.TreeTag and o4.leftindex >= po4.LeftIndex and o4.rightindex <= po4.RightIndex
	
		left join SecurityObjects po5 on po5.Id = e.ObjectId5
		left join securityobjects o5 on o5.TreeTag = po5.TreeTag and o5.leftindex >= po5.LeftIndex and o5.rightindex <= po5.RightIndex
	
	where e.Arity = 5
) e
where e.idx = 1
GO