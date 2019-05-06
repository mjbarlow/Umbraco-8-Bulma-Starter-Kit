var path = require("path");
var express = require("express");

var DIST_DIR = path.join(__dirname, "dist");
var VIEWS_PATH = './src/views';

console.log('http://localhost:3000');

var PORT = 3000;
var app = express();

//Serving the files on the dist folder
app.use(express.static(DIST_DIR));
app.set('view engine', 'ejs');
app.set('views', VIEWS_PATH);

(function() {

  // HOT RELOAD FOR DEVELOPMENT
  // Create & configure a webpack compiler
  var webpack = require('webpack');
  var webpackConfig = require('./webpack.config.dev');
  var compiler = webpack(webpackConfig);

  // Attach the dev middleware to the compiler & the server
  app.use(require("webpack-dev-middleware")(compiler, {
    logLevel: 'warn', publicPath: webpackConfig.output.publicPath
  }));

  // Attach the hot middleware to the compiler & the server
  app.use(require("webpack-hot-middleware")(compiler, {
    log: console.log, path: '/__webpack_hmr', heartbeat: 10 * 1000
  }));
})();

//Send index.html when the user access the web
app.get("/", function (req, res) {
  res.render('index');
});
app.listen(PORT);