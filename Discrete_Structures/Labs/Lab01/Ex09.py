def ithCombine(p, q):
    return f"if {p}, then {q}"


def panqCombine(p, q):
    return f"{p}, and not {q}"


def npodCombine(p, q):
    return f"not {p}, or {q}"


p = "it's sunny"
q = "I go camping"
print(ithCombine(p, q))
print(panqCombine(p, q))
print(npodCombine(p, q))
