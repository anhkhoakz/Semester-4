<!DOCTYPE html>
<html lang="en">

<head>
  <title>Multiplication Table</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
  <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</head>

<body>

  <div class="container">
    <table class="table table-bordered mt-5 text-center ">
      <thead>
        <tr>
          <th colspan="10" class="bg-secondary">MULTIPLICATION TABLE</th>
        </tr>
      </thead>
      <tbody>
        <?php for ($i = 1; $i <= 10; $i++) { ?>
          <tr>
            <?php for ($j = 1; $j <= 10; $j++) { ?>
              <td>
                <?php echo "$j x $i = " . ($i * $j) ?>
              </td>
            <?php } ?>
          </tr>
        <?php } ?>
      </tbody>
    </table>
  </div>

</body>

</html>