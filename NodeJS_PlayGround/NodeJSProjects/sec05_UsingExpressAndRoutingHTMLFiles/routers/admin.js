const express = require('express');
const path = require('path');
const rootDir = require('../util/path');
const router = express.Router();

//# changed to add prefix url in 'app.js' as '/admin/add-product' with 'POST' method
//router.post('/product',(req,res,next)=>{
router.post('/add-product',(req,res,next)=>{
    console.log({body:req.body});
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
   //res.sendFile(path.join(__dirname,'../','views','add-product.html'));

   //#using util path better
   res.sendFile(path.join(rootDir, 'views','add-product.html'));
});

module.exports = router;