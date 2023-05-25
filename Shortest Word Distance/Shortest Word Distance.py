def shortestDistance(words, word1, word2):
    shortestDistance = len(words)
    pos1, pos2 = -1, -1

    for i, word in enumerate(words):
        if word == word1:
            pos1 = i
        if word == word2:
            pos2 = i

        if pos1 != -1 and pos2 != -1:
            shortestDistance = min(shortestDistance, abs(pos1 - pos2))
    
    return shortestDistance

# Time Complexity: O(n)
# Space Complexit: O(1)