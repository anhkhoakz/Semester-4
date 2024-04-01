from math import sqrt


def isPrime(n):
    if n <= 1:
        return False
    if n <= 3:
        return True

    if n % 2 == 0 or n % 3 == 0:
        return False

    for i in range(5, int(sqrt(n) + 1), 6):
        if n % i == 0 or n % (i + 2) == 0:
            return False

    return True


def printPrime(n):
    for i in range(n + 1):
        if isPrime(i):
            print(i, end=" ")


printPrime(60)
