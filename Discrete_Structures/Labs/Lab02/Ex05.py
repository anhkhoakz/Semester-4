import itertools
from Ex02 import lLImplies


def checkEquivalent(count, table):
    if count == len(table):
        print("Equivalent")
    else:
        print("Inequivalent")


table_1 = list(itertools.product([False, True], repeat=1))
table_2 = list(itertools.product([False, True], repeat=2))
table_3 = list(itertools.product([False, True], repeat=3))

# p ≡ ¬(¬p)
print("1. p ≡ ¬(¬p)")
count_1 = sum(1 for item in table_1 if item[0] == (not (not item[0])))
checkEquivalent(count_1, table_1)

# ¬(¬q ∧ p) ∧ (q v p) ≡ q
print("2. ¬(¬q ∧ p) ∧ (q v p) ≡ q")
count_2 = sum(
    1
    for item in table_2
    if (not ((not item[1]) and item[0])) and (item[1] or item[0]) == item[1]
)
checkEquivalent(count_2, table_2)

# ¬(p v q) ≡ (¬p v ¬q)
print("3. ¬(p v q) ≡ (¬p v ¬q)")
count_3 = sum(
    1
    for item in table_2
    if not (item[0] or item[1]) == ((not item[0]) or (not item[1]))
)
checkEquivalent(count_3, table_2)

# (p v q) → r ≡ (p → r) ∧ (q → r)
print("4. (p v q) → r ≡ (p → r) ∧ (q → r)")
count_4 = sum(
    1
    for item in table_3
    if lLImplies(item[0] or item[1], item[2]) == lLImplies(item[0], item[2])
    and lLImplies(item[1], item[2])
)

checkEquivalent(count_4, table_3)

# ¬(p ∧ q) ≡ (¬p ∧ ¬q)
print("5. ¬(p ∧ q) ≡ (¬p ∧ ¬q)")
count_5 = sum(
    1
    for item in table_2
    if not (item[0] and item[1]) == ((not item[0]) and (not item[1]))
)
checkEquivalent(count_5, table_2)

# (p v ¬q) → ¬p ≡ (p v (¬q)) → ¬p
print("6. (p v ¬q) → ¬p ≡ (p v (¬q)) → ¬p")
count_6 = sum(
    1
    for item in table_2
    if lLImplies(item[0] or (not item[1]), (not item[0]))
    == lLImplies(item[0] or (not item[1]), (not item[0]))
)
checkEquivalent(count_6, table_2)

# ¬(p v q) ≡ (¬p ∧ ¬q)
print("7. ¬(p v q) ≡ (¬p ∧ ¬q)")
count_7 = sum(
    1
    for item in table_2
    if not (item[0] or item[1]) == ((not item[0]) and (not item[1]))
)
checkEquivalent(count_7, table_2)
