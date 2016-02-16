var express = require('express'),
    mongoose = require('mongoose'),
    bodyParse = require('body-parser');

var application = express();

application.get('/', function(req, res){
    res.send('Welcome to Cocktail NodeJS API!');
});

application.get('/HealthCheck', function(req, res){
    res.send('Cocktail NodeJS API -> Health Check is Good!');
});

var server = application.listen(3000, function() {
    console.log('Server running at http://127.0.0.1:3000/');
});