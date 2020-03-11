﻿namespace tabuleiro
{
	class Peca
	{
		public Posicao Posicao { get; set; }
		public Cor Cor { get; protected set; }
		public int Movimentos { get; protected set; }
		public Tabuleiro Tab { get; protected set; }

		public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
		{
			Posicao = posicao;
			Cor = cor;
			Movimentos = 0;
			Tab = tab;
		}
	}
}
