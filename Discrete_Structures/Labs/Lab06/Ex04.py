def contestAlgorithm(n):
    if n < 2:
        return []
    o = [2]
    i = 3
    while i + 2 <= n:
        flag = True
        j = 0
        while j < len(o):
            if i % o[j] == 0:
                flag = False
                break
            j += 1
        if flag:
            o.append(i)
        i += 2
    return o


n_values = [10, 20, 5]
for n in n_values:
    result = contestAlgorithm(n)
    print(result)
# print(contestAlgorithm(5))
