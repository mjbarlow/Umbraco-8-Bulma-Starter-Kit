require ("@babel/polyfill");
import "./scss/main.scss";
const $ = require('jquery');
const $navbarMenu = document.querySelector('#navbarMenu');
const $newsletterApp = document.querySelector('#newsletterForm');

$(document).ready(function(){
  
  if($navbarMenu){
    const mobileMenu = require('./scripts/mobileMenu');
    mobileMenu();
  };

  if($newsletterApp)
  {
    const newsletterApp = require('./scripts/newsletterApp')
    newsletterApp();
  };


});

document.addEventListener('DOMContentLoaded', () => {
  console.log('Umbraco Bulma Starter Kit - Started.');
});
