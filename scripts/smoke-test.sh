#!/usr/bin/env bash
set -euo pipefail

solution="AirBaruch.sln"

if command -v msbuild >/dev/null 2>&1; then
  msbuild "${solution}" /p:Configuration=Release /t:Rebuild
elif command -v dotnet >/dev/null 2>&1; then
  dotnet msbuild "${solution}" /p:Configuration=Release /t:Rebuild
else
  echo "Error: msbuild or dotnet is required to build ${solution}." >&2
  exit 1
fi
