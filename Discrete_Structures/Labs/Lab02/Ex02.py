def lLImplies(P, Q):
    if P:
        return Q
    else:
        return True


def lLAnd(P, Q):
    return P and Q


def lLOr(P, Q):
    return P or Q


def lLXor(P, Q):
    return (P and not Q) or (not P and Q)


def lLNot(P):
    return not P


def lLEquivalent(P, Q):
    return lLAnd(lLImplies(P, Q), lLImplies(Q, P))


P = [True, True, False, False]
Q = [True, False, True, False]

truthTable = zip(P, Q)
print("Implies")
for i in truthTable:
    print(i, lLImplies(i[0], i[1]))
print()

truthTable = zip(P, Q)
print("And")
for i in truthTable:
    print(i, lLAnd(i[0], i[1]))
print()

truthTable = zip(P, Q)
print("Or")
for i in truthTable:
    print(i, lLOr(i[0], i[1]))
print()

truthTable = zip(P, Q)
print("Xor")
for i in truthTable:
    print(i, lLXor(i[0], i[1]))
print()

truthTable = zip(P, Q)
print("Not")
for i in truthTable:
    print(i, lLNot(i[0]))
print()

truthTable = zip(P, Q)
print("Equivalent")
for i in truthTable:
    print(i, lLEquivalent(i[0], i[1]))
print()
