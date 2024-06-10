$(document).ready(function () {
    $("img").click(function () {
        let angle = (($(this).data("angle") || 0) + 90) % 360;
        $(this).css("transform", `rotate(${angle}deg)`);
        $(this).data("angle", angle);
    });
});

function startDragging(event) {
    let imageID = event.target.id;
    event.dataTransfer.setData("imageID", imageID);
}

function allowDropping(event, reciever) {
    if (reciever.childElementCount === 0) {
        event.preventDefault();
    }
}

function dataReceiving(event) {
    event.preventDefault();
    let imageID = event.dataTransfer.getData("imageID");
    let image = document.getElementById(imageID);
    event.target.appendChild(image);
}
