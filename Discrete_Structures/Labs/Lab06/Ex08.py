def decimalToBinary(n):
    whole_n = int(n)
    fract = n - whole_n

    bin = ""
    if whole_n == 0:
        bin = "0"

    while whole_n > 0:
        bin = str(whole_n % 2) + bin
        whole_n //= 2

    bin_fract = ""
    precision = 0

    while fract > 0 and precision < 10:
        fract *= 2
        bit = int(fract)
        bin_fract += str(bit)
        fract -= bit
        precision += 1

    if bin_fract:
        binary = bin + "." + bin_fract
    else:
        binary = bin

    return binary


print(decimalToBinary(5.5))
print(decimalToBinary(5.25))
print(decimalToBinary(12.345))
