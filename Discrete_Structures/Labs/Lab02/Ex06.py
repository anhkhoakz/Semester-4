from itertools import product
from Ex02 import lLImplies as implies


def exp1():
    Table = list(product([True, False], repeat=4))
    for table in Table:
        p = table[0]
        q = table[1]
        r = table[2]
        s = table[3]
        if implies(p, r) and implies(not p, q) and implies(q, s):
            if implies(not r, s):
                continue
            else:
                return False
    return True


def exp2():
    Table = list(product([True, False], repeat=5))

    for table in Table:
        p = table[0]
        q = table[1]
        r = table[2]
        s = table[3]
        t = table[4]
        if implies(p, implies(q, r)) and (p or s) and implies(t, q) and (not s):
            if implies(not r, not t):
                continue
            else:
                return False
    return True


def exp3():
    Table = list(product([True, False], repeat=4))
    for table in Table:
        p = table[0]
        q = table[1]
        r = table[2]
        s = table[3]
        if implies(p, q) and ((not r) or s) and (p or r):
            if implies(not q, s):
                continue
            else:
                return False
    return True


def exp4():
    Table = list(product([True, False], repeat=4))
    for table in Table:
        p = table[0]
        q = table[1]
        r = table[2]
        s = table[3]
        if p and implies(p, r) and implies(p, q or (not r)) and ((not q) or (not s)):
            if s:
                continue
            else:
                return False
    return True


for i in range(1, 5):
    exp_function = locals().get("exp" + str(i))

    if exp_function is not None and exp_function():
        print("VALID\n")
    else:
        print("INVALID\n")
