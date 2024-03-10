# ==== Statement A ====
print("\nStatement A")
print("∃x∈Z, 0 <= x <= 100, x^3 < x")
for x in range(100 + 1):
    if x**3 < x:
        print(str(x) + " is valid")

print("The given statement is incorrect for all values x within the given domain.")


def isPrime(n):
    if n > 1:
        for i in range(2, int(n / 2) + 1):
            if (n % i) == 0:
                return False
        else:
            return True
    else:
        return False


# ==== Statement B ====
print("\nStatement B")
print("∃x∈Z, 0 <= x <= 100 and x is even, x * 3 + 1 is not a prime number")
for x in range(100 + 1):
    if x % 2 == 0 and not isPrime(3 * x + 1):
        print(str(x) + " is valid")

print(
    "The given statement is correct when x = [0, 8, 16, 18, 28, 30, 38, 40, 44, 48, 56, 58, 62, 68, 72, 78, 82, 84, 86, 88, 96, 98, 100] ."
)

# ==== Statement C ====
print("\nStatement C")
print("∃x∈Z, 1 <= x, y <= 100 and x is even, 6 * x + 3 is not a prime number")
for x in range(1, 100 + 1):
    if x % 2 == 0 and not isPrime(6 * x + 3):
        print(str(x) + " is valid")

print(
    "The given statement is correct when x = [2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98, 100]."
)

# ==== Statement D ====
print("\nStatement D")
print("∃c∈Z, 0 < c <= 100, c % 4 = 0, ∀a, b ∈ Z+, c^2 != a^2 + b^2")
for c in range(0 + 1, 100 + 1):
    if c % 4 == 0:
        for a in range(100 + 1):
            for b in range(100 + 1):
                if c**2 == a**2 + b**2:
                    print(f"{a}, {b}, and {c} are invalid")

print(
    "The given statement is incorrect for some values a, b, c within the given domain."
)


# ==== Statement A ====
print("\nStatement E")
print("∃c∈Z, 0 < c <= 100, c % 5 = 0, ∀a, b ∈ Z+, c^2 != a^2 + b^2")
for c in range(0 + 1, 100 + 1):
    if c % 5 == 0:
        for a in range(100 + 1):
            for b in range(100 + 1):
                if c**2 == a**2 + b**2:
                    print(f"{a}, {b}, and {c} are invalid")
print(
    "The given statement is incorrect for some values a, b, c within the given domain."
)

# ==== Statement F ====
print("\nStatement F")
print("∀c∈Z, 0 < c <= 100, c^2 > c")
for c in range(0 + 1, 100 + 1):
    if c**2 <= c:
        print(f"{c} is invalid")
print("The given statement is incorrect for value c = 1.")
