string messaggio = "";
string parolaCif = "";
char lettCif = 'A';
int asciiLettera = 0;
int asciiLettCif = 0;
int k = 0;
Console.WriteLine("Inserisci il messaggio che vuoi cifrare");
messaggio = Console.ReadLine();
Console.WriteLine("Inserisci la chiave del cifrario");
k = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < messaggio.Length; i++)
{

    asciiLettera = (int) messaggio[i];
    if((asciiLettera < 65 || asciiLettera > 90)&&(asciiLettera < 97 || asciiLettera > 122))
    {
        lettCif = messaggio[i];
    }
    else
    {
        asciiLettCif = asciiLettera + k;
        if (asciiLettCif > 122 || (asciiLettCif > 90 && asciiLettCif < 97 ))
        {
            asciiLettCif = asciiLettCif - 26;
        }
        lettCif = (char)asciiLettCif;
    }
    parolaCif = parolaCif + lettCif;
}
Console.WriteLine(parolaCif);
