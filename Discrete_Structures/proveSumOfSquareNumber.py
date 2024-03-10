def sum_of_squares(num):
    # Function to check if a number is a perfect square
    def is_perfect_square(n):
        return int(n**0.5) ** 2 == n

    # Try all possible combinations of perfect squares
    for a in range(int(num**0.5) + 1):
        for b in range(int(num**0.5) + 1):
            for c in range(int(num**0.5) + 1):
                if a**2 + b**2 + c**2 == num:
                    return (
                        a,
                        b,
                        c,
                    )  # If sum of three squares equals num, return the values of a, b, and c

    return None  # If no combination found, return None


# Check even numbers less than 26
for i in range(2, 26, 2):
    expression = sum_of_squares(i)
    if expression:
        a, b, c = expression
        print(f"{i} = {a}^2 + {b}^2 + {c}^2")
    else:
        print(f"{i} cannot be expressed as a sum of three or fewer perfect squares.")
