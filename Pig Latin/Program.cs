


using System.Diagnostics.Tracing;

bool ContTranslation = true;


while (ContTranslation)
{
    Console.WriteLine("Pig Latin Translator");
    Console.WriteLine();

    Console.Write("Please enter word: ");
    string setence = Console.ReadLine();

    string PigLatinWord = "";
    string[] Words = setence.Split(' ');

    for (int i = 0; i < Words.Length; i++)
    {
        PigLatinWord += PigLatin(Words[i]);
    }

    Console.WriteLine(PigLatinWord);
    Console.WriteLine();
    

    Console.Write("Translate another line? y/n: ");
    string Continue = Console.ReadLine().Trim().ToLower();

    if (Continue == "y")
    {
        ContTranslation = true;
    }
    else if (Continue == "n")
    {
        ContTranslation = false;
    }
    else
    {
        ContTranslation = false;
    }
    
}










//Method
static string PigLatin(string Sentence)
{
    string word;
    char[] chars = {'a','e','i','o','u','y','A','E','I','O','U','Y'};
    int Vowelposition = Sentence.IndexOfAny(chars);
    int FirstPosition = Sentence.Length - Vowelposition;
   string  BeforeWord = Sentence.Substring(Vowelposition, FirstPosition);
    string AfterWord = Sentence.Substring(Vowelposition);

   if(Vowelposition > 0) 
    {
       word = AfterWord + BeforeWord + "ay" + " ";

    }
    else
    {
        word = Sentence + "way" + " ";
    }

       return word;
}





//Method
static string UserInput(string input)
{
    if(input == input)
    {
        return input;

    }
    else
    {
        return "Please enter text";
    }

}
Console.WriteLine(UserInput("Hello"));



Console.ReadLine();
