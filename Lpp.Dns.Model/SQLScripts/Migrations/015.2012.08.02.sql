if not exists( select * from sys.columns where name='id' and object_id = object_id('userpasswordtrace') )
begin
	alter table userpasswordtrace add Id int not null identity
	alter table userpasswordtrace add constraint UserPasswordTrace_PK primary key(Id)
end