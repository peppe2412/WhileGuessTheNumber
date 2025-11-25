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

// Conteggio dei tentativi
int counter = 0;



while(addNumber != numberToBeGuess)
{
    // Numero di tentativi
    counter++;

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
        if(counter == 1)
        {
            Console.WriteLine($"Hai indovinato! Al primo colpo{emojiForWin}");
        }
        else
        {
            Console.WriteLine($"Hai indovinato!{emojiForWin}\nCi sono voluti {counter} tentativi");
        }
            
    }
}
