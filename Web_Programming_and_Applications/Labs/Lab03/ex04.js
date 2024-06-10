/*
Requirements:
- By default, the site will display the first image in the list.
- When a user clicks on the Next or Back button, the corresponding image will be displayed.
- If a user clicks on the Next button when the last image is showing, the first image will be displayed (and vice versa).
- If the user presses the Start slideshow button, the image will be changed automatically after 1 second.
- If the web page is in slideshow mode, the Next, Back buttons will be disabled and the "Start slideshow" button will be changed to "Stop slideshow".
- When the user presses the "Stop slideshow", the state of the buttons is back to the original.
*/

document.addEventListener("DOMContentLoaded", function () {
    let imageList = document.getElementById("imageList");
    let displayedImage = document.getElementById("displayedImage");
    let imageInfo = document.getElementById("imageInfo");
    let backButton = document.getElementById("backButton");
    let slideshowButton = document.getElementById("slideshowButton");
    let nextButton = document.getElementById("nextButton");

    let currentIndex = 0;
    let slideshowInterval;

    function updateImage() {
        let selectedImage = imageList.options[currentIndex].value;
        displayedImage.src = "images/" + selectedImage;
        imageInfo.textContent =
            selectedImage +
            " (" +
            (currentIndex + 1) +
            "/" +
            imageList.options.length +
            ")";
    }

    backButton.addEventListener("click", function () {
        currentIndex =
            (currentIndex - 1 + imageList.options.length) %
            imageList.options.length;
        updateImage();
    });

    nextButton.addEventListener("click", function () {
        currentIndex = (currentIndex + 1) % imageList.options.length;
        updateImage();
    });

    slideshowButton.addEventListener("click", function () {
        if (slideshowButton.textContent === "Start slideshow") {
            slideshowButton.textContent = "Stop slideshow";
            backButton.disabled = true;
            nextButton.disabled = true;
            slideshowInterval = setInterval(function () {
                currentIndex = (currentIndex + 1) % imageList.options.length;
                updateImage();
            }, 1000);
        } else {
            slideshowButton.textContent = "Start slideshow";
            backButton.disabled = false;
            nextButton.disabled = false;
            clearInterval(slideshowInterval);
        }
    });

    imageList.addEventListener("change", function () {
        currentIndex = imageList.selectedIndex;
        updateImage();
    });

    updateImage();
});
