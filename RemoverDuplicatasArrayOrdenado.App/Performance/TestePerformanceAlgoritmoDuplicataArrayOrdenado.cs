using BenchmarkDotNet.Attributes;
using RemoverDuplicatasArrayOrdenado.App.Algoritmos;

namespace RemoverDuplicatasArrayOrdenado.App.Performance
{
    [MemoryDiagnoser]
    [RankColumn]
    public class TestePerformanceAlgoritmoDuplicataArrayOrdenado
    {
        [Params(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 1, 4, 7, 9, 9, 20, 21, 23, 25, 25 }, new int[] { 4, 4, 4, 4, 10, 12, 15, 17, 17, 19, 29, 30, 31, 31, 50, 50, 57 })]
        public int[] Array { get; set; }

        [Benchmark]
        public void MedirPerformanceRemoverDuplicatasUsandoEspaçoConstante()
        {
            _ = AlgoritmoDuplicataArrayOrdenado.RemoverDuplicatasUsandoEspaçoConstante(Array, Array.Length);
        }

        [Benchmark]
        public void MedirPerformanceRemoverDuplicatasUsandoEspaçoExtra()
        {
            _ = AlgoritmoDuplicataArrayOrdenado.RemoverDuplicatasUsandoEspaçoExtra(Array, Array.Length);
        }
    }
}