const express = require('express');
const path = require('path');
const rootDir = require('../util/path');
const router = express.Router();

const products = [];

//# changed to add prefix url in 'app.js' as '/admin/add-product' with 'POST' method
//router.post('/product',(req,res,next)=>{
router.post('/add-product',(req,res,next)=>{
    //#{title:'valuetitle'}
    //console.log({body:req.body});
    products.push({title:req.body.title})
    res.redirect('/');
});

//# Match url '/admin/add-product' with 'GET' method, 'admin' is prefix
router.get('/add-product',(req,res,next)=>{
    /*
    res.send(`
        <form action='/admin/add-product' method='POST'>
         <label for='title'>Title:</label>
         <input type='text' name='title'/>
         <button type='submit'>Add</button>
        </form>
        `);
    */

   //#send file instead send text HTML
   //res.sendFile(path.join(__dirname,'../','views','add-product.html'));

   //#using util path better
   //res.sendFile(path.join(rootDir, 'views','add-product.html'));

   //#using pug template view by just name, and passed template parameters 
   res.render('add-product',{pageTitle:'Add Product',path:'/admin/add-product',
    formCSS:true,
    productCSS:true,
    activeAddProduct:true
   });
});

//#different syntax to export needed global 'variables/objects'
//module.exports = router;
exports.routers = router;
exports.products = products;
