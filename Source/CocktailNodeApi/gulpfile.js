'use strict';

var gulp = require('gulp'),
    gulpNodemon = require('gulp-nodemon'),
    env = require('gulp-env');
    
gulp.task('default', function(){
    gulpNodemon({
        script: 'application.js',
        ext: 'js',
        env: {
            PORT: 8080,
            ENV: 'development'
        },
        ignore: ['./node_modules/**']
    })
    .on('restart', function(){
        console.log('Restarting Node JS Web API ....');
    });
});    