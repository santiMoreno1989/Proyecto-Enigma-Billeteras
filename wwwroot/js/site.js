let menu = document.querySelector('#navBarra');

window.addEventListener('scroll', () => {
    let scrollSuperior = document.documentElement.scrollTop || window.pageYOffset;
    if (scrollSuperior !== 0) {
        menu.style.backgroundColor = 'black';
        menu.style.position = 'fixed';
    } else {
        menu.style.backgroundColor = 'transparent';
        menu.style.position = 'relative';
    }
});
