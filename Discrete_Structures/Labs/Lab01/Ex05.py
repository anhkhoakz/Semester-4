def operation(a):
    a = a.split()
    firstNumber = int(a[0])
    secondNumber = int(a[2])
    operator = a[1]
    if operator == "+":
        return firstNumber + secondNumber
    elif operator == "-":
        return firstNumber - secondNumber
    elif operator == "*":
        return firstNumber * secondNumber
    elif operator == "/":
        return firstNumber / secondNumber
    elif operator == "%":
        return firstNumber % secondNumber
    elif operator == "^":
        return firstNumber**secondNumber
    else:
        return "Invalid parameter"


print(operation("1 + 2"))
print(operation("1 - 2"))
print(operation("1 * 2"))
print(operation("1 / 2"))
print(operation("1 % 2"))
print(operation("1 ^ 2"))
