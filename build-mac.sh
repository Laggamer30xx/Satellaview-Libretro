#!/bin/bash
# Build for macOS

dotnet build -c Release -f net6.0-macos -p:Platform=x64
