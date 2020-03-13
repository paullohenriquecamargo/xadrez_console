namespace tabuleiro
{
	public class Peca
	{
		public Posicao Posicao { get; set; }
		public Cor Cor { get; protected set; }
		public int Movimentos { get; protected set; }
		public Tabuleiro Tab { get; protected set; }

		public Peca(Tabuleiro tab, Cor cor)
		{
			Posicao = null;
			Cor = cor;
			Movimentos = 0;
			Tab = tab;
		}
	}
}
