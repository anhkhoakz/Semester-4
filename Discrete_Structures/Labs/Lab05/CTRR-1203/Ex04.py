p = "Phong has Visa"
q = "Phong can fly"
r = "Phong can speak"
t = "Phong goes to America"

S1 = "If Phong can fly, Phong will go to America"
S2 = "If Phong has Visa, Phong will go to America"
S3 = "If Phong can speak English, Phong will go to America"
C = "Phong goes to America"

print("Scenario 1:")
print(p, "\n", q, "\n", r, "\n", t)
print(S1, "\n", S2, "\n", S3, "\n", C)

S2a = "p implies t"
print("a. Valid because", S2a, "and we have", p)

p = "An wakes up late"
q = "The traffic is flowing smoothly"
not_q = "The traffic is heavy"
r = "It's a school day"
s = "An has to go to school"
v = "An is late for school"
t = "An wakes up late"

S1 = "The traffic is always heavy on school days"
S2 = "If An wakes up late, he will be late for school on school days"
S3 = "An only has to go to school on school days"
S4 = "If An doesn't have to go to school, he can't be late for school"
C = "An is late for school"

print("\nScenario 2:")
print(p, "\n", q, "\n", r, "\n", s, "\n", t)
print(S1, "\n", S2, "\n", S3, "\n", S4, "\n", C)

# Justification for invalidity
S1b = "~t and r"
print("b. Invalid because", S1b, "but we have", q)
