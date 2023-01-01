# oauth
OAuth and OpenID Connect

Earlier in 2010's:

Identity/User Use Cases:

1. Simple Login - Using Forms and Cookies:

 Classic simple Authentication in Web App:
    Web Application -> Through Forms takes UserName and PWD -> Hashes and stores the digest in database against that user.
    User logged in through the forms -> Server compares the login credentials against the Hash stored for that user in DB.

    If the credentials matches, creates a session Id for that user and returns the same as Cookies in HTTP response header. The browser stores this session Id and uses this for the subsequent request to the server. 

    What is Cookies? 
    https://www.youtube.com/watch?v=V0pzXU6FbQA

    What is Session, Cookies and Tokens? 
    https://www.youtube.com/watch?v=GhrvZ5nUWNg
    
Drawbacks: Security and Maintenance to be handled by the Web Server.

2. Single Sign On - Using SAML

New Use Case 

3. Mobile app login - new use case: To login and remains logged in even if app runs background.

4. Delegated Authorization - has problems?

Delegated Authorization with OAuth:
- User Access a Web App which wants to access user contacts.
- Web App asks user for permission to read user contacts in GMail
- User wishes to grant access to Yelp to access ONLY GMail contacts.

When User clicks "Connect to Google" in Web App page, OAuth flow begins:








 
