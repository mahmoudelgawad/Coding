const express = require('express');
const path = require("path");
const bodyParser = require('body-parser');
const adminRouter = require('./routers/admin');
const shopRouters = require('./routers/shop');
//# require for handlebars engine only
//const expressHbs = require('express-handlebars');

const app = express();

//#set special key name with value
//#https://expressjs.com/en/api.html#app.set

//#detect which templating engine will used

//#3- using ejs engine
app.set("view engine","ejs");

//#2-using express-handlebars engine
//#with detect default layout path and page
/*
app.engine('hbs',expressHbs({layoutDir:'views/layout',
                            defaultLayout:'main-layout',
                            extname:'hbs'}));
app.set("view engine","hbs");
*/

//#1-using PUG engine
//app.set("view engine","pug");

//# detect where path the views html files 
app.set("views","views")

//#middlewar
//#for inject static folders/files from specific root directory,all in "public"  
app.use(express.static(path.join(__dirname,'public')));

//#for auto parsing global/any requests body
//#'extended = false' to parse url with querystring
app.use(bodyParser.urlencoded({extend:false}));

app.use('/admin',adminRouter.routers);
app.use(shopRouters);

app.use('',(req,res,next)=>{
    //res.status(404).send('<h1>No Page Found. Please Enter Correct Path</h1>');
    //res.status(404).sendFile(path.join(__dirname,'views','404.html'));

    //#send 404 configured (pug, handlebars,ejs) templating view
    res.status(404).render('404',{pageTitle:'Page Not Found'});
});

app.listen(3001);