const path = require('path');

//# 'path.direname' get directory/path for specific file equivalent to '(__dirname,'../')' 
//# 'process.mainModule' = 'app.js'
//# use 'require.main' instead, keep refer to the same main dir if changed in runtime
module.exports = path.dirname(process.mainModule.filename);
//module.exports = path.dirname(require.main.filename);