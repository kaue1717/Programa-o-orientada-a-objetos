using System;

public class Imovel
{
    #region CamposPropriedades 

    private int numComodos = 0;

    private string nomeEmpreendimento = "senac";

    private static String nomeIncorporadora = "GAFISA";
    private static int NumInstancias = 0;

    public int NumSuites { get; set; } = 1;
    public String int Endereco { get; set; }

    public bool Alugado { get; set; } = false;

    private int metragem = 30;

    public int Metragem

    {
        set
        {
            if (value > 5)
            {
                this.metragem = value;
            }
            get
            {
                return this.metragem;
            }

        }
    }

    public intt GetNumComodos()
    {
        return this.numComodos;
}



}