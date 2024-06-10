# declare variables
name = "Tong Nguyen Gia Huy"
name = name.upper().replace(" ", "")

gamma = []
delta = ["A", "C", "D", "G", "H", "N", "O", "T", "U"]

# get unique element in name
for letter in name:
    if letter not in gamma:
        gamma.append(letter)

# convert array to set
gamma_set = set(gamma)
delta_set = set(delta)

# mathematical resolve
union = gamma_set.union(delta_set)
intersection = gamma_set.intersection(delta_set)
non_symmetric_diff = gamma_set.difference(delta_set)
symmetric_diff = gamma_set.symmetric_difference(delta_set)

# print out the result
print(symmetric_diff)
