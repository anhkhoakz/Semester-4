def formalConvertPQ(S):
    exp = S.split(", ")
    if "For all" in exp[0]:
        D = "D is " + exp[0][len("For all") + 1 :]
        exp_2 = exp[1].split("then")
        P = "P is " + exp_2[0][len("if they ") :]
        Q = "Q is " + exp_2[1][len("they ") + 1 :]
        F = "For all x in D, P(x) -> Q(x)"

    elif "Exist" in exp[0]:
        D = "D: " + exp[0][len("Exist") + 1 :]
        exp_2 = exp[1].split("but")

        P = "P: " + exp_2[0][exp_2[0].find(" ") + 1 :]
        Q = "Q: " + exp_2[1][:]
        F = "Exist x in D, P(x) then Q(x)"

    elif "For every" in exp[0]:
        D = "D is " + exp[0][len("For every") + 1 :]
        exp_2 = exp[1].split("then")
        P = "P is " + exp_2[0][len("if they ") :]
        Q = "Q is " + exp_2[1][len("they ") :]
        F = "For every x in D, P(x) -> Q(x)"
    return D, P, Q, F


a = "For all people, if they are blond then they are westerners"
b = "Exist a person, whose hair is black but is a westerner"
c = "For all students, if they study correctly then they have high score"
e = "For every bird, if they don't have wings and can swim then they are penguins"
f = "Exist a bird, who have wing but can't fly"

print(formalConvertPQ(a))

print(formalConvertPQ(b))

print(formalConvertPQ(c))

print(formalConvertPQ(e))

print(formalConvertPQ(f))
