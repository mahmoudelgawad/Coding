const express = require('express');
const path = require("path");
const bodyParser = require('body-parser');
const adminRoutes = require('./routers/admin');
const shopRouters = require('./routers/shop');

const app = express();

//#middlewar
//#for inject static folders/files from specific root directory,all in "public"  
app.use(express.static(path.join(__dirname,'public')));

//#for auto parsing global/any requests body
//#'extended = false' to parse url with querystring
app.use(bodyParser.urlencoded({extend:false}));

app.use('/admin',adminRoutes);
app.use(shopRouters);

app.use('',(req,res,next)=>{
    //res.status(404).send('<h1>No Page Found. Please Enter Correct Path</h1>');
    res.status(404).sendFile(path.join(__dirname,'views','404.html'));
});

app.listen(3001);