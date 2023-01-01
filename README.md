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

4. Delegated Authorization - Earlier implementation's problems?

Delegated Authorization with OAuth:
- User uses a WebApp(Ex-yelp.com) which wants to access user contacts.
- WebApp asks user for permission to read user contacts in GMail
- User wishes to grant access to Yelp to access ONLY GMail contacts.
- User hits Connect With Google, to give yelp permission to access google contacts.
Yelp will launch Google's login screen for user. Here, yelp will specify Google what Info should it needs access to.
- When the user given the credentials, Google will explicitly inform the user that the app needs access to Google contacts. 
Should it allow or block.
- If user allows, then the yelp is authorized to access only the Contacts from Google. Please be noted, that yelp will have access to get data from 
only Google's Contacts API. 

When User clicks "Connect to Google" in Web App page, OAuth flow begins:

![Yelp Calling Google's Contacts API](https://user-images.githubusercontent.com/21195523/210166648-30758380-b588-433b-8a57-89ddeb3c3cdf.png)

OAuth Flow 2.0 Participants :

![Yelp Calling Google's Contacts API - With OAuth terminologies](https://user-images.githubusercontent.com/21195523/210167852-e88a53b0-8fdb-4b6e-badb-df2a94af8141.png)

1. Resource Owner: Owner of the data that the application wants to access. Ex: User.

2. Client: Application that wants to get the data. Ex: Yelp

3. Authorization server: System to which we say to give permission to client. Ex: Google

Resource Server: API/Server which has the data. Ex: google.contacts.com
Authorization Server and Resource Server can be the same. And it can also be different. todo:Find Ex?

4. Authorization grant: OAuth communication flow, 
        "Yelp -> Google -> Yelp" : "Yelp asks permission for something -> Google asks user(Yes or No) -> Yelp may (or may not) gets permission"  
In this flow, user's permission to Yelp's request to access (only)google contacts is granted via a token called "Authorization Grant" by Google.
(todo. Find what happens if user says no? ie. What is Google's response back to yelp when the user clicks no?).

  Authorization Grant Types:


5. Redirect URI: When user grants permission, Authorization Server along with Authorization token gives (URI)information about where it needs to look for the requested data to the client. It is called Redirect URI/Callback. Yelp uses this URI to access the requested data.

6. Access token: Client needs Access Token - a "Key", which client uses to access data from the Resource Server.

7. Scope:

8. Consent:










 
