using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CheckPoint1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== CHECKPOINT 1 - FUNDAMENTOS C# - Turma  3ESPY ===\n");

            // ENTREGA ATÉ DIA 08/09 AS 23:59
            // Você deve criar um repositório público ou branch no github e me enviar o link pelo
            // teams antes do fim do prazo.

            Console.WriteLine("1. Testando DemonstrarTiposDados...");
            Console.WriteLine(DemonstrarTiposDados());

            Console.WriteLine("\n2. Testando CalculadoraBasica (SWITCH)...");
            Console.WriteLine(CalculadoraBasica(10, 5, '+'));
            Console.WriteLine(CalculadoraBasica(10, 5, '-'));
            Console.WriteLine(CalculadoraBasica(10, 5, '*'));
            Console.WriteLine(CalculadoraBasica(10, 0, '/'));
            Console.WriteLine(CalculadoraBasica(10, 5, '?')); // operador inválido

            Console.WriteLine("\n3. Testando ValidarIdade (IF/ELSE)...");
            Console.WriteLine(ValidarIdade(-1));
            Console.WriteLine(ValidarIdade(5));
            Console.WriteLine(ValidarIdade(15));
            Console.WriteLine(ValidarIdade(30));
            Console.WriteLine(ValidarIdade(70));
            Console.WriteLine(ValidarIdade(130));

            Console.WriteLine("\n4. Testando ConverterString...");
            Console.WriteLine(ConverterString("123", "int"));
            Console.WriteLine(ConverterString("3,14", "double")); // atenção à cultura
            Console.WriteLine(ConverterString("true", "bool"));
            Console.WriteLine(ConverterString("abc", "int"));

            Console.WriteLine("\n5. Testando ClassificarNota (SWITCH)...");
            Console.WriteLine(ClassificarNota(9.5));
            Console.WriteLine(ClassificarNota(8.5));
            Console.WriteLine(ClassificarNota(6.0));
            Console.WriteLine(ClassificarNota(3.2));
            Console.WriteLine(ClassificarNota(11));

            Console.WriteLine("\n6. Testando GerarTabuada (FOR)...");
            Console.WriteLine(GerarTabuada(5));
            Console.WriteLine(GerarTabuada(0));

            Console.WriteLine("\n7. Testando JogoAdivinhacao (WHILE)...");
            Console.WriteLine(JogoAdivinhacao(63, new int[] { 50, 75, 63 }));

            Console.WriteLine("\n8. Testando ValidarSenha (DO-WHILE)...");
            Console.WriteLine(ValidarSenha("MinhaSenh@123"));
            Console.WriteLine(ValidarSenha("fraca"));

            Console.WriteLine("\n9. Testando AnalisarNotas (FOREACH)...");
            Console.WriteLine(AnalisarNotas(new double[] { 8.5, 7.0, 9.2, 6.5, 10.0, 4.8, 8.1, 7.9 }));

            Console.WriteLine("\n10. Testando ProcessarVendas (FOREACH múltiplo)...");
            double[] vendas = { 500.0, 1000.0, 750.0, 300.0, 1200.0 };
            string[] categorias = { "A", "B", "A", "C", "B" };
            double[] comissoes = { 0.10, 0.07, 0.05 }; // A=10%, B=7%, C=5%
            string[] nomesCategorias = { "A", "B", "C" };
            Console.WriteLine(ProcessarVendas(vendas, categorias, comissoes, nomesCategorias));

            Console.WriteLine("\n=== RESUMO: TODAS AS ESTRUTURAS FORAM TESTADAS ===");
            Console.WriteLine("✅ IF/ELSE: Testado na validação de idade");
            Console.WriteLine("✅ SWITCH: Testado na calculadora e classificação de notas");
            Console.WriteLine("✅ FOR: Testado na tabuada");
            Console.WriteLine("✅ WHILE: Testado no jogo de adivinhação");
            Console.WriteLine("✅ DO-WHILE: Testado na validação de senha");
            Console.WriteLine("✅ FOREACH: Testado na análise de notas e processamento de vendas");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        // =====================================================================
        // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
        // =====================================================================
        private static string DemonstrarTiposDados()
        {
            int inteiro = 42;
            double decimalz = 3.14;
            bool booleano = true;
            char caractere = 'A';
            string texto = "Olá";
            var inferido = 99; // inferência de tipo (int)

            return $"Inteiro: {inteiro}, Decimal: {decimalz}, Booleano: {booleano}, Caractere: {caractere}, Texto: {texto}, Inferido: {inferido}";
        }

        // =====================================================================
        // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
        // =====================================================================
        private static double CalculadoraBasica(double num1, double num2, char operador)
        {
            switch (operador)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': return num2 == 0 ? 0 : num1 / num2;
                default: return -1;
            }
        }

        // =====================================================================
        // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)
        // =====================================================================
        private static string ValidarIdade(int idade)
        {
            if (idade < 0 || idade > 120)
                return "Idade inválida";
            else if (idade < 12)
                return "Criança";
            else if (idade >= 12 && idade < 18)
                return "Adolescente";
            else if (idade >= 18 && idade <= 65)
                return "Adulto";
            else
                return "Idoso";
        }

        // =====================================================================
        // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
        // =====================================================================
        private static string ConverterString(string valor, string tipoDesejado)
        {
            if (tipoDesejado == null) return "Conversão impossível para [tipo]";

            switch (tipoDesejado.Trim().ToLowerInvariant())
            {
                case "int":
                    if (int.TryParse(valor, out int i))
                        return $"int: {i}";
                    return "Conversão impossível para int";

                case "double":
                    // Tenta com cultura PT-BR e en-US
                    if (double.TryParse(valor, NumberStyles.Any, new CultureInfo("pt-BR"), out double d) ||
                        double.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out d))
                        return $"double: {d}";
                    return "Conversão impossível para double";

                case "bool":
                    if (bool.TryParse(valor, out bool b))
                        return $"bool: {b}";
                    return "Conversão impossível para bool";

                default:
                    return "Tipo desejado inválido";
            }
        }

        // =====================================================================
        // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
        // =====================================================================
        private static string ClassificarNota(double nota)
        {
            if (nota < 0.0 || nota > 10.0)
                return "Nota inválida";

            switch (nota)
            {
                case var n when n >= 9.0 && n <= 10.0: return "Excelente";
                case var n when n >= 7.0 && n <= 8.9: return "Bom";
                case var n when n >= 5.0 && n <= 6.9: return "Regular";
                case var n when n >= 0.0 && n <= 4.9: return "Insuficiente";
                default: return "Nota inválida";
            }
        }

        // =====================================================================
        // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
        // =====================================================================
        private static string GerarTabuada(int numero)
        {
            if (numero <= 0) return "Número inválido";

            var sb = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }
            return sb.ToString();
        }

        // =====================================================================
        // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
        // =====================================================================
        private static string JogoAdivinhacao(int numeroSecreto, int[] tentativas)
        {
            if (tentativas == null || tentativas.Length == 0)
                return "Sem tentativas";

            var sb = new StringBuilder();
            int i = 0;
            bool acertou = false;

            while (i < tentativas.Length && !acertou)
            {
                int palpite = tentativas[i];
                string resultado;

                if (palpite == numeroSecreto)
                {
                    resultado = "correto!";
                    acertou = true;
                }
                else if (palpite < numeroSecreto)
                {
                    resultado = "muito baixo";
                }
                else
                {
                    resultado = "muito alto";
                }

                sb.AppendLine($"Tentativa {i + 1}: {palpite} - {resultado}");
                i++;
            }

            if (!acertou)
                sb.AppendLine("Fim das tentativas. Não foi dessa vez!");

            return sb.ToString();
        }

        // =====================================================================
        // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
        // =====================================================================
        private static string ValidarSenha(string senha)
        {
            var erros = new StringBuilder();

            bool tamanhoOk = !string.IsNullOrEmpty(senha) && senha.Length >= 8;
            bool temNumero = false;
            bool temMaiuscula = false;
            bool temEspecial = false;
            string especiais = "!@#$%&*";

            if (!string.IsNullOrEmpty(senha))
            {
                int i = 0;
                do
                {
                    char c = senha[i];
                    if (char.IsDigit(c)) temNumero = true;
                    if (char.IsUpper(c)) temMaiuscula = true;
                    if (especiais.Contains(c)) temEspecial = true;

                    i++;
                } while (i < senha.Length);
            }

            if (!tamanhoOk) erros.AppendLine("- Mínimo de 8 caracteres");
            if (!temNumero) erros.AppendLine("- Pelo menos 1 número");
            if (!temMaiuscula) erros.AppendLine("- Pelo menos 1 letra maiúscula");
            if (!temEspecial) erros.AppendLine("- Pelo menos 1 caractere especial (!@#$%&*)");

            return erros.Length == 0 ? "Senha válida" : $"Senha inválida:\n{erros}";
        }

        // =====================================================================
        // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
        // =====================================================================
        private static string AnalisarNotas(double[] notas)
        {
            if (notas == null || notas.Length == 0)
                return "Nenhuma nota para analisar";

            double soma = 0;
            int aprovados = 0;
            double maior = double.MinValue;
            double menor = double.MaxValue;

            int faixaA = 0; // 9-10
            int faixaB = 0; // 8-8.9
            int faixaC = 0; // 7-7.9
            int faixaD = 0; // 5-6.9
            int faixaF = 0; // <5

            foreach (var n in notas)
            {
                soma += n;
                if (n >= 7.0) aprovados++;
                if (n > maior) maior = n;
                if (n < menor) menor = n;

                if (n >= 9.0 && n <= 10.0) faixaA++;
                else if (n >= 8.0 && n < 9.0) faixaB++;
                else if (n >= 7.0 && n < 8.0) faixaC++;
                else if (n >= 5.0 && n < 7.0) faixaD++;
                else if (n < 5.0) faixaF++;
            }

            double media = soma / notas.Length;

            var sb = new StringBuilder();
            sb.AppendLine($"Média: {media:F2}");
            sb.AppendLine($"Aprovados: {aprovados}");
            sb.AppendLine($"Maior: {maior:F1}");
            sb.AppendLine($"Menor: {menor:F1}");
            sb.AppendLine($"A: {faixaA}, B: {faixaB}, C: {faixaC}, D: {faixaD}, F: {faixaF}");

            return sb.ToString();
        }

        // =====================================================================
        // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
        // =====================================================================
        private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
        {
            if (vendas == null || categorias == null || comissoes == null || nomesCategorias == null)
                return "Dados inválidos";

            if (vendas.Length != categorias.Length)
                return "Tamanhos de vendas e categorias não correspondem";

            // Acumuladores por categoria
            double[] totalPorCat = new double[nomesCategorias.Length];
            double[] comissaoPorCat = new double[nomesCategorias.Length];

            // Percorre vendas e categorias simultaneamente (FOREACH múltiplo via Zip)
            foreach (var par in vendas.Zip(categorias, (v, c) => new { Valor = v, Cat = c }))
            {
                string catAtual = (par.Cat ?? "").Trim().ToUpperInvariant();
                int idxCategoria = -1;

                // Localiza índice da categoria nos nomesCategorias (FOREACH separado)
                int idxTemp = 0;
                foreach (var nome in nomesCategorias)
                {
                    if ((nome ?? "").Trim().ToUpperInvariant() == catAtual)
                    {
                        idxCategoria = idxTemp;
                        break;
                    }
                    idxTemp++;
                }

                if (idxCategoria == -1) continue; // categoria desconhecida, ignora

                // Descobre comissão da categoria (FOREACH separado)
                double percentual = 0.0;
                int i = 0;
                foreach (var nome in nomesCategorias)
                {
                    if ((nome ?? "").Trim().ToUpperInvariant() == catAtual)
                    {
                        percentual = (i >= 0 && i < comissoes.Length) ? comissoes[i] : 0.0;
                        break;
                    }
                    i++;
                }

                totalPorCat[idxCategoria] += par.Valor;
                comissaoPorCat[idxCategoria] += par.Valor * percentual;
            }

            var cultura = new CultureInfo("pt-BR");
            var sb = new StringBuilder();
            for (int i = 0; i < nomesCategorias.Length; i++)
            {
                string nome = nomesCategorias[i];
                string totalFmt = totalPorCat[i].ToString("C", cultura);
                string comissaoFmt = comissaoPorCat[i].ToString("C", cultura);
                double perc = (i < comissoes.Length ? comissoes[i] : 0.0) * 100.0;
                sb.AppendLine($"Categoria {nome}: Vendas {totalFmt}, Comissão ({perc:0.#}%) {comissaoFmt}");
            }

            return sb.ToString();
        }

        // =====================================================================
        // MÉTODOS AUXILIARES (NÃO ALTERAR - APENAS PARA REFERÊNCIA)
        // =====================================================================
        private static void ExemploMetodoEstatico()
        {
            Console.WriteLine("Sou um método estático - chamado direto da classe");
        }

        /*
        void ExemploMetodoInstancia()
        {
            Console.WriteLine("Sou um método de instância - preciso de um objeto para ser chamado");
        }
        */
    }
}
