using System;
public partial class Usuario
{
    public int Codigo;
    public string Nome;
    public string Senha;
    public Usuario(int codigo, string nome, string senha)
    {
        Codigo = codigo;
        Nome = nome;
        Senha = senha;
    }
    public Usuario()
    {

    }
}
