def mProd(A, B):
    if len(A[0]) != len(B):
        print("Matrix dimension error")
        return None

    m = len(A)
    n = len(A[0])
    q = len(B[0])
    C = [[0] * q for _ in range(m)]

    for i in range(m):
        for j in range(q):
            for k in range(n):
                C[i][j] += A[i][k] * B[k][j]

    return C


A = [[1, 2, 3], [4, 5, 6]]
B = [[7, 8], [9, 10], [11, 12]]

result = mProd(A, B)
if result is not None:
    for row in result:
        print(row)
