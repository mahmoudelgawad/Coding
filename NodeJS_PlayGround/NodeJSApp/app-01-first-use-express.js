//#no need after using express library
//const http = require('http');

const express = require('express');
const bodyParser = require('body-parser');

const app = express();


//#for auto parsing global/any requests body
//#'extended = false' to parse url with querystring
app.use(bodyParser.urlencoded({extended:false}));

//#limited for app.post, app.get, app.put,...etc
app.post('/product',(req,res,next)=>{
    console.log({body:req.body});
    res.redirect('/');
});

app.use('/add-product',(req,res,next)=>{
    res.send(`
        <form action='/product' method='POST'>
         <label for='title'>Title:</label>
         <input type='text' name='title'/>
         <button type='submit'>Add</button>
        </form>
        `);
});

//#match url 'http://localhost:3001/message'
app.use('/message',(req,res,next)=>{
    console.log({match:'/message'})
    res.send('Hi Mahmoud !!');
});

//#match default URL without send(),
app.use('/',(req,res,next)=>{
    console.log({match:'/',msg:'this should alwyas run'});
    res.send('<h1>Hello from Express!</h1><h1>please write specific directory name !</h1>');
    next();
}); 

//# match 'http://localhost:3001/' , match default url like 'app.use()' without url
app.use('/',(red,res,next) =>{
    console.log({match:'/'});  
    next();
});

//#starting from here , act as default middleware and will match any/all requests if in call chain 'next()'  
//# match 'http://localhost:3001/'
app.use((req, res, next) => {
    console.log({match:'/',msg:'In the frist default middleware!'});
    //Allows the request to continue to the next middleware in line
    //# and without 'next()' the request keep stuck/spining loading
    next();
});

//# match 'http://localhost:3001/'
app.use((req, res, next) => {
    console.log({match:'/',msg:'In another second default middleware!'});

    //#only allow one call for 'send()' in pipeline  'next()' calls
    //#from behind the scene 'expressJS/express' / 'response.js'
    //  #res.send = function send(body){} 
    //#send automatically 'content-type' 'text/html'
    //#ignored after added above matching url to avoid error send() two times
    //res.send('<h1>Hello from Express!</h1>');
});

//#native nodejs codes
//const server = http.createServer(app);
//server.listen(3001);

app.listen(3001)
