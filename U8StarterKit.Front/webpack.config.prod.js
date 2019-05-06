
'use strict';

const merge = require('webpack-merge');
const common = require('./webpack.common.js');
const Webpack = require('webpack');
const Path = require('path');

const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const VueLoaderPlugin = require('vue-loader/lib/plugin');
const FileManagerPlugin = require('filemanager-webpack-plugin');

module.exports = merge(common, {
  entry: {main: './src/index.js'},
  mode: 'production',
  plugins: [
    new Webpack.DefinePlugin({
      'process.env.NODE_ENV': JSON.stringify('production')
    }),
    new MiniCssExtractPlugin({ filename: 'bundle.css' }),
    new Webpack.optimize.ModuleConcatenationPlugin(),
    new FileManagerPlugin({
      onEnd: [
        {
          copy: [
            { source: "./dist/main.bundle.js", destination: "/dist/js/main.bundle.js" },
            { source: "./dist/main.bundle.js.map", destination: "/dist/js/main.bundle.js.map" },
            { source: "./dist/styles/bundle.css", destination: "/dist/css/bundle.css" },
            { source: "./dist/styles/bundle.css.map", destination: "/dist/css/bundle.css.map" }
          ]
        }
      ]
    })
  ],
  resolve: {
    alias: {
      '~': Path.resolve(__dirname, '../src'),
        vue: 'vue/dist/vue.min.js'
    }
  },
  module: {
    rules: [ 
        {
            test: /\.(js)$/,
            exclude: /(node_modules|bower_components)/,
            use: 'babel-loader'
        },
        {
            test:/\.css$/,
            use:[
                {
                    loader:MiniCssExtractPlugin.loader,
                    options:{
                        publicPath:(resourcePath, context) => {
                            console.log( Path.relative(Path.dirname(resourcePath), context) + '/');
                            return Path.relative(Path.dirname(resourcePath), context) + '/';
                        }
                    }
                },
                'css-loader'
            ]

        },
        {
            test: /\.(sa|sc)ss$/,
            use: [
                {
                    loader: "css-loader",
                },
                "sass-loader" // compiles Sass to CSS
            ]
        }
      ]
    }
  }
);
