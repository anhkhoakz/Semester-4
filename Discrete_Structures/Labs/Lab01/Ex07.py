def mSum(A, B):
    if len(A) != len(B) or len(A[0]) != len(B[0]):
        print("Matrix dimension error")
        return None

    C = [[0] * len(A[0]) for _ in range(len(A))]

    for i in range(len(A)):
        for j in range(len(A[0])):
            C[i][j] = A[i][j] + B[i][j]

    return C


A = [[1, 2, 3], [4, 5, 6]]
B = [[7, 8, 9], [10, 11, 12]]

result = mSum(A, B)

for row in result:
    print(row)
