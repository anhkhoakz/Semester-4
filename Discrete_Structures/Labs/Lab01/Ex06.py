def operation(a):
    a = a.split()
    startNumber = int(a[0])
    secondNumber = int(a[2])
    operator = a[1]

    operators = {
        "+": lambda x, y: x + y,
        "-": lambda x, y: x - y,
        "*": lambda x, y: x * y,
        "/": lambda x, y: x / y if y != 0 else "Error: Division by zero",
        "%": lambda x, y: x % y if y != 0 else "Error: Modulus by zero",
        "^": lambda x, y: x**y,
    }

    return operators.get(operator, lambda x, y: "Invalid parameter")(
        startNumber, secondNumber
    )


print(operation("1 + 2"))
print(operation("1 - 2"))
print(operation("1 * 2"))
print(operation("1 / 2"))
print(operation("1 % 2"))
print(operation("1 ^ 2"))
