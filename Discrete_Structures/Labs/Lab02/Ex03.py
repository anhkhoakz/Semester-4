from Ex02 import lLAnd, lLImplies
from itertools import product

numberOfRepeat = 3
truthTable = list(product([True, False], repeat=numberOfRepeat))

print("p^q -> r")
for i in truthTable:
    print(i, lLImplies(lLAnd(i[0], i[1]), i[2]))
print()

print("r -> p^q")
for i in truthTable:
    print(i, lLImplies(i[2], lLAnd(i[0], i[1])))
