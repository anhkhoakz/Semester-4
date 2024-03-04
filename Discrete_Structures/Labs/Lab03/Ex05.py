def nega(A):
    if "For all" in A:
        A = A.replace("For all", "There exist")
    elif "Exist" in A:
        A = A.replace("Exist", "For all")

    # Negate main clause
    if "not " in A:
        A = A.replace("not ", "")
    else:
        A = A.replace("is ", "is not ")
        A = A.replace("are ", "are not ")
        A = A.replace("they", "they not")

    return A


A = "For all fishes, they need water to survive."
B = "Exist a person, who is left handed"
C = "Exist an employee in the company, who is late to work everyday."
D = "For all fishes in this pond, they are Koi fish."
E = "There is at least one creature in the ocean, it can live on land"
F = "Every students in class A did not pass the test"

print(nega(A))
print(nega(B))
print(nega(C))
print(nega(D))
print(nega(E))
print(nega(F))
