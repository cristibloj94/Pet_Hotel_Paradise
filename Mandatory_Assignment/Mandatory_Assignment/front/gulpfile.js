'use strict';

// REQUISITES

var

gulp		= require('gulp'),
watch		= require('gulp-watch'),
sass		= require('gulp-sass'),
minify      = require('gulp-minify-css'),
uglify		= require('gulp-uglify'),
concat		= require('gulp-concat'),
gulpif      = require('gulp-if')
;

// PATHS

var

CSS			= 'css/',
JS 			= 'js/'
;

// BUILD VARIABLES

var ugly 		= true;

// TASKS

gulp.task('default', ['css', 'js'], function(){
	gulp.watch(CSS + '**/*.scss', ['css']);
	gulp.watch(JS + '*.js', ['js']);
})

gulp.task('js', function() {
	var FILES = [
		JS + '*.js'
	];
	gulp.src(FILES)
		.pipe(concat('main.js'))
		.pipe(uglify())
		.pipe(gulp.dest('dist'))
})

gulp.task('css', function() {
	var FILES = [
		CSS + '*.scss'
	];
	gulp.src(FILES)
	    .pipe(sass({ errLogToConsole: true }))
//	    .pipe(prefix("last 1 version", "> 1%", "ie 9"))	// to place prefixes for more suport (not used, hence the custom mixins)
	    .pipe(gulpif(ugly, minify().on('error', function (error) { console.warn(error.message); })))	// to minify (remove comments and shit)
		.pipe(sass())
			.on('error', sass.logError)
		.pipe(gulp.dest('dist'))
})