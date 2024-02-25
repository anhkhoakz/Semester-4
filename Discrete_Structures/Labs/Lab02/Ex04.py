from itertools import product
from Ex02 import lLAnd, lLImplies, lLOr, lLXor, lLNot, lLEquivalent

numberOfRepeat = 2
truthTable = list(product([True, False], repeat=numberOfRepeat))

print("p v q → p ∧ q → ¬p  ¬q")

for i in truthTable:
    p = i[0]
    q = i[1]
    print(i, lLImplies(lLImplies(lLOr(p, q), lLAnd(p, q)), lLOr(lLNot(p), lLNot(q))))

numberOfRepeat = 3
truthTable = list(product([True, False], repeat=numberOfRepeat))

print("¬p v (q ∧ r) → r")
for i in truthTable:
    p = i[0]
    q = i[1]
    r = i[2]
    print(i, lLImplies(lLOr(lLNot(p), lLAnd(q, r)), r))

print("(p → q) ∧ (q → r)")
for i in truthTable:
    p = i[0]
    q = i[1]
    r = i[2]
    print(i, lLAnd(lLImplies(p, q), lLImplies(q, r)))

print("(p v (q ∧ r)) ↔ ((p v q) ∧ (p v r))")
for i in truthTable:
    p = i[0]
    q = i[1]
    r = i[2]
    print(i, lLEquivalent(lLOr(p, lLAnd(q, r)), lLAnd(lLOr(p, q), lLOr(p, r))))

numberOfRepeat = 4
truthTable = list(product([True, False], repeat=numberOfRepeat))

print("p v q → ¬r v t")
for i in truthTable:
    p = i[0]
    q = i[1]
    r = i[2]
    t = i[3]
    print(i, lLImplies(lLOr(p, q), lLOr(lLNot(r), t)))

print("")
print("p v t → q → (r → t)")
for i in truthTable:
    p = i[0]
    q = i[1]
    r = i[2]
    t = i[3]
    print(i, lLImplies(lLOr(p, t), lLImplies(q, lLImplies(r, t))))
    # print(
    #     i,lLImplies(lLImplies(lLOr(p, t), q), lLImplies(r, t)),
    # )

print("(p v (q ∧ r)) ↔ (((p v q) ∧ (p v r)) ∧ (t v ¬t))")
for i in truthTable:
    p = i[0]
    q = i[1]
    r = i[2]
    t = i[3]
    print(
        i,
        lLEquivalent(
            lLOr(p, lLAnd(q, r)),
            lLAnd(lLAnd(lLOr(p, q), lLOr(p, r)), lLOr(t, lLNot(t))),
        ),
    )
