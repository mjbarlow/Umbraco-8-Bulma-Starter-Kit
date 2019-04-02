const path = require('path');

module.exports = {
  entry: './src/index.js',
  output: {
    path: path.resolve(__dirname, '../U8StarterKit.Web/scripts'),
    filename: 'bundle.js'
  }
};