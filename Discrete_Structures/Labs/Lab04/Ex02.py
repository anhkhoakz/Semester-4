import math

# ==== sentence A ====
print("Sentense A")
for x in range(100 + 1):
    if x**2 == 15**2 + 16**2:
        print(str(x) + "is invalid")

print("The given statement is inccorect for all values x within the given domain.\n")

# ==== sentence B ====
print("Sentense B")
for x in range(100 + 1):
    if x**2 == 12**2 + 16**2:
        print(str(x) + " is valid")

print("The given statement is correct when x equal to 20")

# ==== sentence C ====
print("Sentense C")
for x in range(-50, 50 + 1):
    if x**2 >= 99 * x:
        print(str(x) + " is valid")

print("The given statement is correct when x in range [-50; 0].")

# ==== sentence D ====
print("Sentense D")
for x in range(50, 100 + 1):
    if (x * (x + 1) * (x + 2)) % 6 != 0:
        print(str(x) + " is valid")

print("The given statement is inccorect for all values x within the given domain.\n")

# ==== sentence E ====
print("Sentense E")
for x in range(0, 100 + 1):
    for y in range(0, 999):
        if math.sqrt(x + y) == math.sqrt(x) + math.sqrt(y):
            print(str(x), str(y) + " are valid")

print(
    "The given statment is correct when x = 0 and y = [0, +∞] , or x = [1, 100] and y = 0"
)
