if not exists (select 1 from INFORMATION_SCHEMA.TABLES 
               where TABLE_NAME = N'User')
begin
    create table [User]
    (
        Email nvarchar(255) primary key,
        Password nvarchar(20)
    )
    insert into [user]
    values ('muster@muster.de', 'muster')
end