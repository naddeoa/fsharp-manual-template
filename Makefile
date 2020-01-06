package_dir = ./packages
nuget = nuget.exe

.PHONY: dependencies build run default

default: build

build:
	dotnet build

run:
	dotnet run

dependencies:
	$(nuget) install FSharp.Data -Version 3.3.2 -OutputDirectory $(package_dir)