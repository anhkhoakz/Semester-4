def DecimalToBinary(decimal):
    binary = ""

    if decimal == 0:
        binary = "0"

    while decimal > 0:
        binary = str(decimal % 2) + binary
        decimal //= 2

    return binary


print(DecimalToBinary(5))
print(DecimalToBinary(15))
