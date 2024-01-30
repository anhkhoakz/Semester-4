def sumN(n):
    if n >= 0:
        return sum(range(n + 1))
    return sum(range(n, 0))


print(sumN(-5))
