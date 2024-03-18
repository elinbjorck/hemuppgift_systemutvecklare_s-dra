bool HasUniqueCharacters(string text) {
    for( int i = 0; i < text.Length; i++) {
        for ( int j = i + 1; j < text.Length; j++) {
            if(text[i] == text[j]) {
                return false;
            }
        }
    }
    return true;
}

Console.WriteLine(HasUniqueCharacters("Södra"));

Console.WriteLine(HasUniqueCharacters("Södra Skogsägarna"));