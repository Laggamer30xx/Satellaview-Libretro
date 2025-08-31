@echo off
REM Build for Windows

dotnet build -c Release -f net6.0-windows -p:Platform=AnyCPU
