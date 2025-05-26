const http = require('http'); // it's shortcut for './http.js' 
const routes = require("./routes");


//original syntax for createServer method
// function requestListener(incomingMessage,serverResponse){}

const server = http.createServer(routes.handler);

server.listen(3000); //localhost:3000
console.log(routes.message);