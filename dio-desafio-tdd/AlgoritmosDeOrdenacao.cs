using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dio_desafio_tdd
{
    public class AlgoritmosDeOrdenacao
    {
        public int[] InsertionSort(int[] A)
        {
            for (int j = 1; j < A.Length; j++)
            {
                var chave = A[j];
                var i = j - 1;

                while (i > -1 && A[i] > chave)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }

                A[i + 1] = chave;

            }


            return A;
        }

        public int[] Merge(int[] A,int p,int q, int r)
        {
            int n1 = q-p +1; //calcula o comprimento do subarranjo A[p..q]
            int n2 = r - q; //calcula o comprimento do subarranjo A[q+1 ..r]

            int[] L = new int[n1 + 1]; //cria arranjo da esquerda + posição extra para sentinela
            int[] R = new int[n2 + 1]; //cria o arranjo da direita + posição extra para sentinela

            //copiando o subarranjo da esquerda
            for (int _i = 0; _i < n1; _i++)
                L[_i] = A[p + _i];

            //copiando o subarranjo da direita
            for (int _j = 0; _j < n2; _j++)
                R[_j] = A[q+1 + _j];

            //acrescentando um valor grande para a posição de sentinela
            L[n1] = int.MaxValue;
            R[n2] = int.MaxValue;

            int i = 0;
            int j = 0;

            for (int k = p; k <= r; k++)
            {
                if (L[i] <= R[j])
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
            }

            return A;
        
        }

        public int[] MergeSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = (int)(Decimal.Truncate((p + r) / 2));
                A=MergeSort(A, p, q);
                A=MergeSort(A, q + 1, r);
                A = Merge(A, p, q, r);
            }

            return A;
        }

    }
}
