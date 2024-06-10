$(document).ready(() => {
    let pannel = $('<div id="pannel">');
    for (let i = 0; i < 100; i++) {
        let r = Math.floor(Math.random() * 256);
        let g = Math.floor(Math.random() * 256);
        let b = Math.floor(Math.random() * 256);

        let cell = $(
            `<div style="background-color: rgb(${r}, ${g}, ${b})"></div>`
        );

        pannel.append(cell);
    }

    $("body").append(pannel);
    $("body").append(
        '<div class="alert alert-success w-50 text-center mx-auto" id="my-alert" style="display:none"> The background color has been changed</div>'
    );

    $("#pannel div").on("mouseover", function () {
        let color = $(this).css("background-color");
        $("body").css("background-color", color);
    });

    $("#pannel div").on("click", function () {
        $("#my-alert").fadeIn(1000);

        setTimeout(() => {
            $("#my-alert").fadeOut(2000);
        }, 5000);
    });

    $("#pannel").on("mouseleave", function () {
        $("body").css("background-color", "white");
    });
});
