var i = 0;
var images = ['/web-sablon/canyon.jpg/', '/web-sablon/fransayaveda.jpg','pubgh.jpeg']

var duration = 3000;
function slideImg() {
    document.slide.src = images[i];

    if (i < images.length - 1) {
        i++;
    }
    else {
        i = 0;
    }
    setTimeout("slideImg()", duration);
}
window.onload = slideImg;

