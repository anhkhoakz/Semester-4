var slideshowInterval = null;

function changePicture(picture) {
    let imageField = document.querySelector("img");
    imageField.src = "images/" + picture;
    let textField = document.querySelector("p");
    textField.textContent = picture;
}

function nextButton() {
    let imageField = document.querySelector("p");
    let currentImage = imageField.textContent;
    let currentImageIndex = parseInt(currentImage.split("_")[1]);
    let nextImageIndex = (currentImageIndex % 10) + 1;
    let nextImage =
        "pic_" + (nextImageIndex < 10 ? "00" : "0") + nextImageIndex + ".jpg";
    changePicture(nextImage);
}

function backButton() {
    let imageField = document.querySelector("p");
    let currentImage = imageField.textContent;
    let currentImageIndex = parseInt(currentImage.split("_")[1]);

    let backImageIndex = ((currentImageIndex + 8) % 10) + 1;
    let backImage =
        "pic_" + (backImageIndex < 10 ? "00" : "0") + backImageIndex + ".jpg";
    changePicture(backImage);
}

function slideShow() {
    let slideShowButton = document.getElementsByTagName("button")[1];
    let backBtn = document.getElementsByTagName("button")[0];
    let nextBtn = document.getElementsByTagName("button")[2];

    if (!slideshowInterval) {
        slideshowInterval = setInterval(nextButton, 500);
        slideShowButton.textContent = "Stop slideshow";
        backBtn.disabled = true;
        nextBtn.disabled = true;
    } else {
        clearInterval(slideshowInterval);
        slideshowInterval = null;
        slideShowButton.textContent = "Start slideshow";
        backBtn.disabled = false;
        nextBtn.disabled = false;
    }
}
