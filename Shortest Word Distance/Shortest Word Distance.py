def shortestDistance(words, word1, word2):
    end = words.index(word2)
    indices1 = []
    distances = []
    for i in range(len(words)):
        if words[i] == word1:
            indices1.append(i)
    
    for i in range(len(indices1)):
        if indices1[i] < end:
            distances.append(end - indices1[i])
        if indices1[i] > end:
            distances.append(indices1[i] - end)

    return min(distances)

print(shortestDistance(["a", "c", "d", "b", "a"], "a", "b"))