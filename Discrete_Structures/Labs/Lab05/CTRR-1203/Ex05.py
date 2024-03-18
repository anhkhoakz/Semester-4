from itertools import product


def implies(p, q):
    return (not p) or q


ex5 = list(product([True, False], repeat=4))
print("p \t q \t q -> r \t p -> q \t ∴p -> r")
for item in ex5:
    p, q, r, t = item

    s1 = implies(q, t)
    s2 = implies(p, q)
    s3 = implies(p, t)
    print(p, "\t", q, "\t", r, "\t", t, "\t", s1, "\t\t", s2, "\t\t", s3)
