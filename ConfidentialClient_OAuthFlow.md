Use Case: Create a clinet app with web server and get access token from OAuth server to retrieve data from API.

Implementation:
- Client Front End App 
- Client Web Server
- OAuth Server
- Resource Server?

Client Front End App : SPA
                        - Register with OAuth server and get Client ID and Client Secret.
                        - Get OAuth's authorize and access token endpoint?
                        - Register redirects URI with OAuth Server.
Client Web Server: ASP .NET Core REST API
                   - LogIn Action, redirects user to OAuth Server URI
                   - [GET]Access token, exchange OAuth Code and get access token from server.
OAuth Server: ??
