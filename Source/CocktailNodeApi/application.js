var express = require('express');

var application = express();

var server = application.listen(3000, function() {
    console.log('Server running at http://127.0.0.1:3000/');
});