# oauth
OAuth and OpenID Connect

Classic simple Authentication:

Web Application -> Through Forms takes UserName and PWD -> Hashes and stores the digest in database against that user.
User logged in through the forms -> Server compares the login credentials against the Hash stored for that user in DB.

If the credentials matches, creates a session Id for that user and returns the same as Cookies in HTTP response header. The browser stores this session Id and uses this for the subsequent request to the server. 

    What is Cookies? 
    https://www.youtube.com/watch?v=V0pzXU6FbQA

    What is Session, Cookies and Tokens? 
    https://www.youtube.com/watch?v=GhrvZ5nUWNg
    
Drawbacks: 
1. Security
2. Maintenance
