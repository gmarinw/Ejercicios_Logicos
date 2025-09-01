metodo();
static void metodo()
{
    int x = 12321;
    string str = x.ToString();
    for (int i = 0; i < (str.Count() / 2); i++)
    {
        int n = str[str.Count() - 1 - i];
        if (str[i] != str[str.Count() - 1 - i])
        {
            Console.Write("No es palindromo");
        }
    }
    Console.Write("Es palindromo");
}