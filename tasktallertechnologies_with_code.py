def tasktallertechnologies(s):
    n = len(s)
    char_index = {} 
    start = 0  
    max_length = 0  
    
    for end in range(n):
        if s[end] in char_index and char_index[s[end]] >= start:
            start = char_index[s[end]] + 1
        char_index[s[end]] = end
        max_length = max(max_length, end - start + 1)
    
    return max_length

# Use Case from Exemple Sent by Intervier
input_str = "BBBB"
print("Length of the longest substring for BBBB:", tasktallertechnologies(input_str))
input_str = "ABDEFGABEF"
print("Length of the longest substring for ABDEFGABEF:", tasktallertechnologies(input_str))
input_str = "GEEKSFORGEEKS"
print("Length of the longest substring for GEEKSFORGEEKS:", tasktallertechnologies(input_str))

# Ask the user for input
input_str = input("Enter a string: ")
print("Length of the longest substring inserted by User:", tasktallertechnologies(input_str))
