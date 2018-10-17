create procedure update_empleados (@id bigint,@nom varchar(50),@ape varchar(50))
as
begin

update empleados set nombres = @nom, apelli = @ape where id_empl = @id
end