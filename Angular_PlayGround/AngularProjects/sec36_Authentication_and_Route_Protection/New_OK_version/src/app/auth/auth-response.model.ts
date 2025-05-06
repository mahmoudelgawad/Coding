/*
for both firebase signup and signin response object
Response Payload
Property Name	    Type	    Description
idToken	            string	    A Firebase Auth ID token for the newly created user.
email	            string	    The email for the newly created user.
refreshToken	    string	    A Firebase Auth refresh token for the newly created user.
expiresIn	        string	    The number of seconds in which the ID token expires.
localId	            string	    The uid of the newly created user.
*/
export interface AuthResponse{
    idToken:string,
    email:string,
    refreshToken:string,
    expiresIn:string,
    localId:string,
    registered?:boolean; //for signin
}