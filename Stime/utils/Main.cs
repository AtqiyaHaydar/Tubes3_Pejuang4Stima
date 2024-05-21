using KMP;

class Main
{
    static void Main()
    {
        
        string P = "ABABABABCABABABAB"; //String tempat pencarian
        string Q = "ABABABAB"; //String yang mau dicari
        KMP(P,Q); // Hasil dibandingin dengan https://cmps-people.ok.ubc.ca/ylucet/DS/KnuthMorrisPratt.html

        // cara ngerun :
        // csc src\KMP.cs
        // ./KMP.exe
    }
}