from math import factorial

# ==== Statement A ====
print("\nStatement A")
for x in range(10 + 1):
    for y in range(0, 10 + 1):
        if (x + y) ** 2 > (x + 2 * y) ** 2:
            print(f"{x}, and {y} are valid")

print(
    "The given statement is incorrect for all values x, and y within the given domain."
)

# ==== Statement B ====
print("\nStatement B")
for x in range(10 + 1):
    if factorial(20) < factorial(x):
        print(f"{x} is valid")
print("The given statement is incorrect for all values x within the given domain.")


# ==== Statement C ====
print("\nStatement C")
for x in range(10 + 1):
    if 3 * x**2 >= 10**3:
        print(f"{x} is valid")

print("The given statement is incorrect for all values x within the given domain.")

# ==== Statement D ====
print("\nStatement D")
for x in range(5, 10 + 1):
    if 4 * x**3 + 6 * x**2 + 2 * x > 10**4 + 2 * 10**3 + 10**2 - 5**4 - 2 * 5**3 - 5**2:
        print(f"{x} is valid")

print("The given statement is incorrect for all values x within the given domain.")
