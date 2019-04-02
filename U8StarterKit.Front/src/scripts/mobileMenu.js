function mobileMenu () {

    // returns a screen eg.. 'ss',
    const getCurrentScreenSize = require('./getCurrentScreenSize');
    const navActiveClass = 'is-active';

    const $navbarBurgers = Array.prototype.slice.call(document.querySelectorAll('.navbar-burger'), 0);
    if($navbarBurgers.length > 0){
        $navbarBurgers.forEach( el => {
            el.addEventListener('click', () => {
      
              // Get the target from the "data-target" attribute
              const target = el.dataset.target;
              const $target = document.getElementById(target);
      
              // Toggle the "is-active" class on both the "navbar-burger" and the "navbar-menu"
              el.classList.toggle(navActiveClass);
              $target.classList.toggle(navActiveClass);
      
            });
          });
    }

    function resetNavs(){
        console.log('reset navs');

    }
 
    window.addEventListener('resize', (event) => {
        let currSs = getCurrentScreenSize();
        if(currSs === 'ls' || currSs === 'xls') {
            resetNavs();
        }
    });
}
module.exports = mobileMenu;