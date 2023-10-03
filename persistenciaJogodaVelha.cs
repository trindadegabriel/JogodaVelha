using sqoClassLibraryAI0502Biblio;
using System;

namespace Jogo_da_Velha
{
    public class persistenciaJogodaVelha
    {
		private String sNome = "";
		[ColunaAttribute("Nome", "NOME", TIPO_COLUNA.tcString, -1)]
		public String Nome
		{
			get { return sNome; }
			set { sNome = value; }
		}

		private int nPontos = 0;
		[ColunaAttribute("Pontos", "PONTOS", TIPO_COLUNA.tcInt, -1)]
		public int Pontos
		{
			get { return nPontos; }
			set { nPontos = value; }
		}

    }
}
