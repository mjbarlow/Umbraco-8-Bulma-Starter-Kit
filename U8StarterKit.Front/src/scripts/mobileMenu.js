function mobileMenu () {
    const navActiveClass = 'is-active';
    const $navbarBurgers = Array.prototype.slice.call(document.querySelectorAll('.navbar-burger'), 0);
    const $navbarMenu = document.querySelector('#navbarMenu');

    if($navbarBurgers.length > 0){
        $navbarBurgers.forEach( el => {
            el.addEventListener('click', () => {
              const target = el.dataset.target;
              const $target = document.getElementById(target);
              el.classList.toggle(navActiveClass);
              $target.classList.toggle(navActiveClass);
            });
        });
    }

    function resetNavs(){
        for (var i = 0; i < $navbarBurgers.length; i++) {
            $navbarBurgers[i].classList.remove(navActiveClass);
         }
        $navbarMenu.classList.remove(navActiveClass);
    }
 
    window.addEventListener('resize', (event) => {
            resetNavs();
    });
}
module.exports = mobileMenu;