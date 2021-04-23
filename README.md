# CalastoneCodeChallenge

*This application covers the following points below with some assumptions:

1.) Read from a txt file

2.) Create and apply the following 3 filters:
    – Filter1 – filter out all the words that contains a vowel in the middle of the word – the centre 1 or 2 letters
    ("clean" middle is ‘e’, "what" middle is ‘ha’, "currently" middle is ‘e’ and should be filtered, "the", "rather" 
    should not be)
    – Filter2 – filter out words that have length less than 3
    – Filter3 – filter out words that contains the letter ‘t’

*Assumption
I made an assumption to only handle words that has more than 3 letters for when I am filter out all the words that contains a vowel
this is because words like: "is" has no middle as its just to letters, however words like: "was" has middle letter "a"
*End of assumption

3.) After all filters have completed display the resulted text in the console;

*Tech and principles using
I used .NET core 3.1.

Code implementation followed some SOLID principles as it makes it easier to add more filters in the future.
Added Moq nuget package

*Future possible implement.
Using appSetting to load the textInput file.
Using Regx to split the words when reading them from text file.
