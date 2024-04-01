def gcd(a, b):
    if a == 0:
        return b

    return gcd(b % a, a)


def lcm(a, b):
    return (a // gcd(a, b)) * b


def print_lcm(a, b):
    print(f"lcm({a}, {b}) = {lcm(a, b)}")


a = 15
b = 20
print_lcm(a, b)

a = 10
b = 15
print_lcm(a, b)

a = 35
b = 10
print_lcm(a, b)

a = 31
b = 2
print_lcm(a, b)
