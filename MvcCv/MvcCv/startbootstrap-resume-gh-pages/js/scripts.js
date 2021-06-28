/*!
* Start Bootstrap - Resume v7.0.1 (https://startbootstrap.com/theme/resume)
* Copyright 2013-2021 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-resume/blob/master/LICENSE)
*/
//
// Scripts
// 

window.addEventListener('DOMContentLoaded', event => {

    // Activate Bootstrap scrollspy on the main nav element
    const sideNav = document.body.querySelector('#sideNav');
    if (sideNav) {
        new bootstrap.ScrollSpy(document.body, {
            target: '#sideNav',
            offset: 74,
        });
    };

    // Collapse responsive navbar when toggler is visible
    const navbarToggler = document.body.querySelector('.navbar-toggler');
    const responsiveNavItems = [].slice.call(
        document.querySelectorAll('#navbarResponsive .nav-link')
    );
    responsiveNavItems.map(function (responsiveNavItem) {
        responsiveNavItem.addEventListener('click', () => {
            if (window.getComputedStyle(navbarToggler).display !== 'none') {
                navbarToggler.click();
            }
        });
    });

});




class Typewritter {
    constructor({ text, time = 30 }) {
        this.texts = text.split(",");
        this.sT = document.querySelector(".secondary__title");
        this.realTime = time; // tiempo real
        this.wait = time + 1000; // tiempo de espera
        this.changeTime = 0; // tiempo que usara el intervalo
        this.length = this.texts.length; // cantidad de letras
        this.countChar = 0; // contador de letras escritas
        this.current = 0;
        this.flag = false;

        this.cutText();
    }

    cutText() {
        const text = this.texts[this.current];
        const tLength = this.texts[this.current].length;

        // tiempo de espera al finalizar la palabra
        if (this.countChar === tLength) {
            this.changeTime = this.wait;
        }

        // cambio de tiempo de retorno
        if (this.flag && this.countChar === tLength - 1) {
            this.changeTime = this.realTime / 4;
        }

        // tiempo real para cada letra desde que comienza la palabra
        if (this.countChar === 0) {
            this.changeTime = this.realTime;
        }

        this.drawText(text.substr(0, this.countChar));

        // Si flag es false aumenta el contador para seguir escribiendo
        if (!this.flag) {
            this.countChar++;
            if (this.countChar === tLength) {
                this.flag = true;
            }

            // Si flag es true disminuye el contador para eliminar letras  
        } else if (this.flag) {
            this.countChar--;
            if (this.countChar === 0) {
                this.flag = false;
                this.current = ++this.current % this.length;
            }
        }

        setTimeout(() => this.cutText(), this.changeTime);
    }

    drawText(chars) {
        this.sT.innerHTML = chars;
    }
}

new Typewritter({
    text: "C#,Python,Java,Windows Server, Yapay Zeka", // palabras usadas para el typewritter
    time: 300 // velocidad de escritura
});
