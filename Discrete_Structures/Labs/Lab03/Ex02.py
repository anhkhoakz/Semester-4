def formalConvert(S):
    D, P = S.split(", ")

    condition = ["For all", "Exist", "There is at least one"]
    if any(cond in P for cond in condition):
        D, P = P, D

    F = None

    if condition[0] in D:
        D = D[len(condition[0]) + 1 :]

    P = P.split(maxsplit=1)[1]

    if condition[0] in D:
        F = "For all x in D"
    if condition[1] in D:
        F = "Exist x in D"

    return D, P, F


# Test cases
A = "For all fishes, they need water to survive."
D, P, F = formalConvert(A)
print(D)
print(P)
print(F)

B = "Exist a person, whose hair is black but is a westerner."
D, P, F = formalConvert(B)
print(D)
print(P)
print(F)

C = "For all students, if they study correctly then they have high score."
D, P, F = formalConvert(C)
print(D)
print(P)
print(F)

G = "For every mammal, if they live in the sea, they are either dolphins or whales."
# D, P, F = formalConvert(G)
print(D)
print(P)
print(F)

H = "For every bird, if they don't have wings and can swim then they are penguins."
D, P, F = formalConvert(H)
print(D)
print(P)
print(F)

J = "Exist a bird, who have wing but can't fly."
D, P, F = formalConvert(J)
print(D)
print(P)
print(F)
