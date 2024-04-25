Andersen = {
    "The Emperor's New Clothes",
    "The Little Mermaid",
    "The Little Match Girl",
    "The Snow Queen",
}

Shakespeare = {
    "Romeo and Juliet",
    "Hamlet",
    "King Lear",
    "Macbeth",
    "A Midsummer Night's Dream",
    "A Comedy of Errors",
}

Tragedy = {
    "Romeo and Juliet",
    "Hamlet",
    "King Lear",
    "Macbeth",
    "Medea",
    "Octavia",
    "Oedipus",
    "Ur-Hamlet",
}

Comedy = {
    "A Midsummer Night's Dream",
    "A Comedy of Errors",
    "The Three Musketeer",
    "The Clouds",
}

Uncategory = {"Don Quixote", "Rapunzel", "Cinderella"}

Shakespeare_Tragedy = Shakespeare - Comedy

Andersen_Comedy = Andersen & Comedy

is_Andersen_Comedy_subset_of_Andersen = Andersen_Comedy.issubset(Andersen)
is_Andersen_Comedy_superset_of_Comedy = Andersen_Comedy.issuperset(Comedy)
is_Andersen_Comedy_disjoint_with_Shakespeare_Tragedy = Andersen_Comedy.isdisjoint(
    Shakespeare_Tragedy
)

Work = Andersen | Shakespeare | Tragedy | Comedy | Uncategory

Author = {"Han Christian Andersen", "Shakespeare", "Unknown"}

Author_Of = {
    "The Emperor's New Clothes": "Han Christian Andersen",
    "The Little Mermaid": "Han Christian Andersen",
    "The Little Match Girl": "Han Christian Andersen",
    "The Snow Queen": "Han Christian Andersen",
    "Romeo and Juliet": "Shakespeare",
    "Hamlet": "Shakespeare",
    "King Lear": "Shakespeare",
    "Macbeth": "Shakespeare",
    "A Midsummer Night's Dream": "Shakespeare",
    "A Comedy of Errors": "Shakespeare",
    "Medea": "Unknown",
    "Octavia": "Unknown",
    "Oedipus": "Unknown",
    "Ur-Hamlet": "Unknown",
    "The Three Musketeer": "Unknown",
    "The Clouds": "Unknown",
    "Don Quixote": "Unknown",
    "Rapunzel": "Unknown",
    "Cinderella": "Unknown",
}

Written_By = {work: author for author, work in Author_Of.items()}

Work_Count = {work: 0 for work in Work}
for work in Work_Count:
    for key, value in Author_Of.items():
        if value == work:
            Work_Count[work] += 1

exercise_content = """Tasks 5 through 13 focus on various operations and analyses involving sets, dictionaries, and word counting in Python."""
word_count_exercise = len(exercise_content.split())

word_frequency = {}
words = exercise_content.split()
for word in words:
    word_frequency[word] = word_frequency.get(word, 0) + 1

sorted_word_frequency = sorted(word_frequency.items(), key=lambda x: x[1], reverse=True)

print("Andersen_Comedy:", Andersen_Comedy)
print("Relationship with Andersen:", is_Andersen_Comedy_subset_of_Andersen)
print("Relationship with Comedy:", is_Andersen_Comedy_superset_of_Comedy)
print(
    "Relationship with Shakespeare_Tragedy:",
    is_Andersen_Comedy_disjoint_with_Shakespeare_Tragedy,
)
print("Work:", Work)
print("Author:", Author)
print("Author_Of:", Author_Of)
print("Written_By:", Written_By)
print("Work_Count:", Work_Count)
print("Word count in Exercise section:", word_count_exercise)
print("Word frequency:", sorted_word_frequency)
