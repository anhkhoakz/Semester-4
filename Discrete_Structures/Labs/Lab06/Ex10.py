def convertbase(a, base1, base2):
    num = 0
    for digit in a:
        num = num * base1 + digit

    result = []
    while num > 0:
        digit = num % base2
        result.insert(0, digit)
        num = num // base2

    return result


print(convertbase([1, 5, 3], 10, 16))
print(convertbase([1, 1, 1], 10, 16))
