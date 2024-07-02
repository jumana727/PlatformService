test:
	echo "Hello world!"

run-migrations:
	dotnet ef migrations add $(name) -s $(solution-path) -p $(project-path)

run:
	dotnet run