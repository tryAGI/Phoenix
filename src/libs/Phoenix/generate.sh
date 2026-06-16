#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/Arize-ai/phoenix/main/schemas/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L "https://raw.githubusercontent.com/Arize-ai/phoenix/main/schemas/openapi.json" -o openapi.json

# Fix 1: Add servers section (Phoenix is self-hosted, default localhost:6006)
jq '. + {"servers": [{"url": "http://localhost:6006", "description": "Local Phoenix instance"}]}' openapi.json > tmp.json && mv tmp.json openapi.json

# Auth: --security-scheme overrides the spec's missing auth with standard HTTP bearer.
autosdk generate openapi.json \
  --namespace Phoenix \
  --clientClassName PhoenixClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer \
  --auth-env-var PHOENIX_API_KEY
