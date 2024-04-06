using System.Runtime.InteropServices;

namespace dio_desafio_tdd.Tests
{
    public class AlgoritmosDeOrdenacaoTest
    {
        [Theory]
        [InlineData(new int[] { 5, 2, 4, 6, 1, 3 })]
        [InlineData(new int[] { 9, 8, 7, 6, 5, 4,3,2,1 })]
        [InlineData(new int[] {10,4,1,2,3,5,9,7,8,6})]
        public void ArranjoDesordenado_OrdenarPeloInsertion_DeveSerValido(int[] arranjoDesordenado)
        {
            //Arrange
            //inlineData
            int[] arranjoTest = new int[arranjoDesordenado.Length];
            Array.Copy(arranjoDesordenado, arranjoTest, arranjoDesordenado.Length);

            //Act
            var algoritmosDeOrdenacao = new AlgoritmosDeOrdenacao();
            var arranjoOrdenado = algoritmosDeOrdenacao.InsertionSort(arranjoTest);

            //Assert
            Assert.Equal(arranjoDesordenado.OrderBy(a => a), arranjoOrdenado);
        }

        [Theory]
        [InlineData(new int[] { 2,4,5,7,1,2,3,6 },0, 3,7) ]
        [InlineData(new int[] { 3,4 ,6, 1, 2, 5 },0,2,5)]
        [InlineData(new int[] { 8, 10, 16, 1, 3, 9 },0,2,5)]
        public void ArranjoDesordenado_OrdenarPeloMerge_DeveSerValido(int[] arranjoDesordenado,int p, int q, int r)
        {
            //Arrange
            //inlineData
            int[] arranjoTest = new int[arranjoDesordenado.Length];
            Array.Copy(arranjoDesordenado, arranjoTest, arranjoDesordenado.Length);

            //Act
            var algoritmosDeOrdenacao = new AlgoritmosDeOrdenacao();
            var arranjoOrdenado = algoritmosDeOrdenacao.Merge(arranjoTest, p,q,r);

            //Assert
            Assert.Equal(arranjoDesordenado.OrderBy(a => a), arranjoOrdenado);

        }

        [Theory]
        [InlineData(new int[] { 2, 4, 5, 7, 1, 2, 3, 6 }, 0, 7)]
        [InlineData(new int[] { 3, 4, 6, 1, 2, 5 }, 0, 5)]
        [InlineData(new int[] { 8, 10, 16, 1, 3, 9 }, 0, 5)]
        [InlineData(new int[] { 5, 2, 4, 6, 1, 3 },0,5)]
        [InlineData(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 },0,8)]
        [InlineData(new int[] { 10, 4, 1, 2, 3, 5, 9, 7, 8, 6 },0,9)]
        public void ArranjoDesordenado_OrdenarPeloMergeSort_DeveSerValido(int[] arranjoDesordenado, int p, int r)
        {
            //Arrange
            //inlineData
            int[] arranjoTest = new int[arranjoDesordenado.Length];
            Array.Copy(arranjoDesordenado, arranjoTest, arranjoDesordenado.Length);

            //Act
            var algoritmosDeOrdenacao = new AlgoritmosDeOrdenacao();
            var arranjoOrdenado = algoritmosDeOrdenacao.MergeSort(arranjoTest, p, r);

            //Assert
            Assert.Equal(arranjoDesordenado.OrderBy(a => a), arranjoOrdenado);

        }
    }
}