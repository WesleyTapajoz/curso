using System;
public partial class Usuario
{
    public bool Autenticar()
    {
        return ((Nome == "Wesley") && (Senha == "qualquer"));
    }
}
