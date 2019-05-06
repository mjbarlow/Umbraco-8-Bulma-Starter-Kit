'use strict';
const Path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const CleanWebpackPlugin = require('clean-webpack-plugin');
const CopyWebpackPlugin = require('copy-webpack-plugin');

module.exports = {
  output: {
    filename: '[name].bundle.js',
    chunkFilename: '[name].bundle.js',
    path: Path.resolve(__dirname, 'dist')
  },
  plugins: [
    new CleanWebpackPlugin(),
    new HtmlWebpackPlugin({
      inject: false,
      hash: true,
      template: './src/views/index.ejs',
      filename: 'index.html'
    }),
    new CopyWebpackPlugin([
      { from: Path.resolve(__dirname, './src/assets/images'), to: 'images' },
      { from: Path.resolve(__dirname, './src/assets/fonts'), to: 'fonts' }
    ]),
  ],
  resolve: {
    alias: {
      vue: 'vue/dist/vue.js'
    }
  },
  module: {
    rules: [
      {
        test: /\.ejs$/,
        loader: 'compile-ejs-loader',
        options: {
          'htmlmin': true,
          'htmlminOptions': {
            removeComments: true
          },
        },
      },
      {
        test: /\.(ico|jpg|jpeg|png|gif|eot|otf|webp|svg|ttf|woff|woff2)(\?.*)?$/,
        use: {
          loader: 'file-loader',
          options: {
            name: '[path][name].[ext]',
            emitFile: true
          }
        }
      }
    ]
  }
};
