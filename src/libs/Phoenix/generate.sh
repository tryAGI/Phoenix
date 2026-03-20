dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -sL "https://raw.githubusercontent.com/Arize-ai/phoenix/main/schemas/openapi.json" -o openapi.json

# Fix: Add servers section (Phoenix is self-hosted, default localhost:6006)
jq '. + {"servers": [{"url": "http://localhost:6006", "description": "Local Phoenix instance"}]}' openapi.json > tmp.json && mv tmp.json openapi.json

# Fix: Add Bearer auth security scheme
jq '.components.securitySchemes = {"BearerAuth": {"type": "http", "scheme": "bearer"}} | .security = [{"BearerAuth": []}]' openapi.json > tmp.json && mv tmp.json openapi.json

autosdk generate openapi.json \
  --namespace Phoenix \
  --clientClassName PhoenixClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
