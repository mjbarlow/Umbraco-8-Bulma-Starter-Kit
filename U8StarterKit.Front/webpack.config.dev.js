'use strict';
const merge = require('webpack-merge');
const common = require('./webpack.common.js');
const Webpack = require('webpack');
const VueLoaderPlugin = require('vue-loader/lib/plugin');

module.exports = merge(common, {
  entry:  [
    'webpack-hot-middleware/client?path=/__webpack_hmr',
    './src/index.js'
  ],
  mode: 'development',
  devtool: 'inline-source-map',
  plugins: [
    new Webpack.DefinePlugin({
      'process.env.NODE_ENV': JSON.stringify('development')
    }),
    new Webpack.HotModuleReplacementPlugin(),
    new Webpack.NoEmitOnErrorsPlugin(),
    new VueLoaderPlugin()
  ],
    resolve: {
        alias: {
            'vue$': 'vue/dist/vue.esm.js'
        },
        extensions: ['*', '.js', '.vue', '.json']
    },
  module: {
    rules: [
      {
        test: /\.js$/,
        exclude: /node_modules/,
        use: {
          loader: 'babel-loader'
        }
      },
      {
        test: /\.scss$/,
        use: [
          'style-loader',
          'css-loader',
          'postcss-loader',
          'sass-loader'
        ]
      },
        {
            test: /\.vue$/,
            loader: 'vue-loader',
            options: {
                loaders: {
                }
            }
        }
    ]
  }
});
