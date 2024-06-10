<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">

    <style>
        #panel div {
            width: 30px;
            height: 30px;
            border: 1px solid black;
            float: left;
            box-sizing: border-box;
        }

        #panel {
            width: 300px;
            height: 300px;
            margin: auto;
            /* display: flex;
            flex-wrap: wrap; */
        }
    </style>
</head>

<body>

    <?php
    $panel = '<div id="panel">';
    for ($i = 1; $i <= 100; $i++) {
        $r = rand(0, 255);
        $g = rand(0, 255);
        $b = rand(0, 255);
        $panel .= "<div style='background-color: rgb($r,$g,$b)'></div>";
    }
    $panel .= '</div>';

    $color = 'rgb(255,255,255)';
    echo "<h3 id='color-value' class='text-center rounded-4 bg-secondary text-light mx-auto my-5 p-3' style='width:300px'>$color</h3>";
    echo $panel;
    echo "<div style='display:none' id='my-alert' class='alert alert-success text-center mx-auto w-75 mt-5'>The background color has been changed</div>";
    ?>


    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(() => {
            var color = 'rgb(255,255,255)';

            $('#panel div').on('mouseover', function() {
                let colorHover = $(this).css('background-color');
                $('body').css("background-color", colorHover);
                $('#color-value').html(colorHover);
            });

            $('#panel').on('mouseleave', function() {
                $('body').css("background-color", color);
                $('#color-value').html(color);
            });

            $('#panel div').on('click', function() {
                color = $(this).css('background-color');
                $('body').css("background-color", color);
                $('#my-alert').fadeIn(1500);
                setTimeout(function() {
                    $('#my-alert').fadeOut(1500);
                }, 3000);
            });
        });
    </script>
</body>

</html>