const express = require("express");
const path = require("path");
const rootDir = require('../util/path');

const router = express.Router();

router.use('/shop',(req,res,next)=>{
    //#ignored for send html file instead send text
    // res.send('<h1>Hello From Shop !!</h1>');

    //'path.join()' used to handle both linux '/' and windows '\' file systems
    //#'__direname' = 'routers' folder,the home directory of current file 'shop.js'
    //#'../' or '..' = App home directory
    //res.sendFile(path.join(__dirname,'../','views','shop.html'));

    //# using util path better
    res.sendFile(path.join(rootDir, 'views','shop.html'));
});

module.exports = router;