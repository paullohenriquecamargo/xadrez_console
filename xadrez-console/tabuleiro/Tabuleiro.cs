﻿namespace tabuleiro
{
	public class Tabuleiro
	{
		public int Linhas { get; set; }
		public int Colunas { get; set; }
		private Peca[,] Pecas;

		public Tabuleiro(int linhas, int colunas)
		{
			Linhas = linhas;
			Colunas = colunas;
			Pecas = new Peca[Linhas, Colunas];
		}

		public Peca peca(int linha, int coluna)
		{
			return Pecas[linha, coluna];
		}

		public Peca peca(Posicao pos)
		{
			return Pecas[pos.Linha, pos.Coluna];
		}

		public bool ExistePeca(Posicao pos)
		{
			validarPosicao(pos);
			return peca(pos) != null;
		}

		public void colocarPeca(Peca p, Posicao pos)
		{
			if (ExistePeca(pos))
			{
				throw new TabuleiroException("Já existe uma peca nessa posição !");
			}
			Pecas[pos.Linha, pos.Coluna] = p;
			p.Posicao = pos;
		}

		public bool posicaoValida(Posicao pos)
		{
			if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna>= Colunas)
			{
				return false;
			}
			return true;
		}

		public void validarPosicao(Posicao pos)
		{
			if (!posicaoValida(pos))
			{
				throw new TabuleiroException("Posição inválida !");
			}
		}
	}
}