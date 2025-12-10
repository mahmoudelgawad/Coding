const express = require("express");
const path = require("path");
const rootDir = require('../util/path');
const adminData = require('./admin');

const router = express.Router();

router.get('/',(req,res,next)=>{
    //#ignored for send html file instead send text
    // res.send('<h1>Hello From Shop !!</h1>');

    //'path.join()' used to handle both linux '/' and windows '\' file systems
    //#'__direname' = 'routers' folder,the home directory of current file 'shop.js'
    //#'../' or '..' = App home directory
    //res.sendFile(path.join(__dirname,'../','views','shop.html'));

    //#access admin data which not good here
    console.log({products:adminData.products});

    //#const'rootDir' using util path better 
    //res.sendFile(path.join(rootDir, 'views','shop.html'));

    //#use render pug,handlebars, ejs template instead of return html file
    //# passing variable to the template to render dynamic UI
    res.render('shop',{prods: adminData.products,
                       pageTitle:'My Shop',
                       path:'/shop',
                       hasProducts : adminData.products.length > 0,
                       productCSS:true,
                       activeShop:true
                      }
                    ); 
});

module.exports = router;