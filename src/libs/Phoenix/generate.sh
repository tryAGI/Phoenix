#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L "https://raw.githubusercontent.com/Arize-ai/phoenix/main/schemas/openapi.json" -o openapi.json

# Fix 1: Add servers section (Phoenix is self-hosted, default localhost:6006)
jq '. + {"servers": [{"url": "http://localhost:6006", "description": "Local Phoenix instance"}]}' openapi.json > tmp.json && mv tmp.json openapi.json

# Auth: --security-scheme overrides the spec's missing auth with standard HTTP bearer.
autosdk generate openapi.json \
  --namespace Phoenix \
  --clientClassName PhoenixClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
