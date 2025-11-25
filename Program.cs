/* 
 * Un'applicazione, dove si deve indovinare il numero.
 * Si userà il ciclo while
 */

// Convertire output in utf-8
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Emoji in caso di numero indovinato
string emojiForWin = char.ConvertFromUtf32(0x0001F389);

// Numero da indovinare
int numberToBeGuess = 25;

// numero inserito
int addNumber = 0;



while(addNumber != numberToBeGuess)
{
    Console.WriteLine("Indovina il numero");

    // Input
    addNumber = int.Parse(Console.ReadLine());

    // Se il numero inserito è troppo piccolo
    if (addNumber < numberToBeGuess)
    {
        Console.WriteLine("Numero troppo piccolo, riprova!");
    }

    // Se il numero inserito è troppo grande
    else if(addNumber > numberToBeGuess)
    {
        Console.WriteLine("Numero troppo grande, riprova!");
    }

    // Numero indovinato
    else
    {
        Console.WriteLine($"Hai indovinato!{emojiForWin}");
    }
}
