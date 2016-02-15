var mongoose = require('mongoose'),
    Schema = mongoose.Schema;
    
var productModel = new Schema({
    id: {type: String},
    manufacturer: {type: String}
});

module.exports = mongoose.model( 'Product', productModel);  
