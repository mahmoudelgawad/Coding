const fs = require("fs");

const requestHandler = (incomingMessage,serverResponse) =>{
     console.log('#############################START server request listener#####################');
    //# Handling Request object/parts
    const {url,method,headers} = incomingMessage; //destructing important request objects
   // console.log(incomingMessage);
    console.log({url:url,method:method,headers:headers});

    //process.exit(); //to kill the server immediately, like ctrl+C

    //# Handling Response
    serverResponse.setHeader('content-type','text/html');

    if(url === '/'){
        serverResponse.write(`
            <html>
            <header>
                <title>Enter Message</title>
            </header>
            <body>
                <body>
                    <h1>Enter Message:</h1>
                    <form action="/message" method="POST">
                    <input type="text" name="message" />
                    <button type="submit">Send</button>
                    </form>
                </body>
            </body>
            </html>
            `);
       //# should use 'return' to avoid runtime error if you tried 'res.setHeader' later 
       return serverResponse.end();
    }

    if(url === '/message' && method === 'POST'){
        const body = [];

        incomingMessage.on('data',(chunk) => {
            console.log({chunk:chunk});
            body.push(chunk);
        });

        //event listener 'end', refer to when call 'serverResponse.end()'
        //should called with return to prevent error when set header 2 times,
        //  specially when call last default res.write() text/html lines
       return incomingMessage.on("end",() =>{
            //NodeJs Buffer
            const parsedBody = Buffer.concat(body).toString();
            console.log({parsedBody:parsedBody});
            const message = parsedBody.split('=')[1];
            console.log({messageBody:message,note:'need parse space'});

            // fs.writeFileSync("message.txt",message); //blocking code
            fs.writeFile('message.txt',message,(err)=>{
                //callback when done write file ,recieve error if exist

                // serverResponse.writeHeader(302,{location:'/'});
                serverResponse.statusCode = 302; // found

                //will redirect to main url
                serverResponse.setHeader('location','/');
                // tell NodeJs 'createServer' you must end, and must implement the current 'end' event code
                //we but 'res.end()' here , to not run before "res.on.('end')"" event listener
                return serverResponse.end();
            });

        
        });
        
        
    }

    serverResponse.write(`
        <html>
        <header>
            <title>Hello NodeJS</title>
        </header>
        <body>
            <body>
                <h1>Hello from my NodeJs App !</h1>
            </body>
        </body>
        </html>
        `);


    serverResponse.end();
};

//export modules with different ways/syntax

//(1)
// module.exports = requestHandler;

//(2)
// module.exports = {
//     handler:requestHandler,
//     message:"Now Server Start, listin at http://localhost:3000"
// };

//(3)
module.exports.handler = requestHandler;
module.exports.message = "Now Server Start, listin at http://localhost:3000";