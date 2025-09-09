# CheckPoint 1 – Fundamentos de C# (3ESPR)

Repositório criado para entrega do **Checkpoint 1** da disciplina **Desenvolvimento em C#**.  
Turma: **3ESPR**  
Aluno: **Kaio Meireles**  
RM: **553282**

---

## 📌 Sobre o projeto
Este projeto tem como objetivo avaliar a compreensão dos conceitos fundamentais de C# por meio da implementação de diversos métodos práticos que utilizam estruturas condicionais, laços de repetição, manipulação de arrays e conversão de tipos.

Todo o código foi desenvolvido no arquivo **`Program.cs`**, localizado em `3ESPR/CheckPoint1SLN/`.

---

## 🛠️ Funcionalidades implementadas

1. **DemonstrarTiposDados**  
   Demonstra diferentes tipos de dados em C# (`int`, `double`, `bool`, `char`, `string`, `var`).

2. **CalculadoraBasica**  
   Calculadora simples implementada com `switch`, suportando as operações: soma, subtração, multiplicação e divisão (com tratamento de divisão por zero).

3. **ValidarIdade**  
   Classifica a idade em categorias: Criança, Adolescente, Adulto, Idoso ou Idade Inválida, utilizando `if/else`.

4. **ConverterString**  
   Converte uma string para `int`, `double` ou `bool` usando `TryParse`, retornando mensagens de sucesso ou falha.

5. **ClassificarNota**  
   Classifica notas de acordo com a faixa:
   - 9.0 a 10.0 → **Excelente**  
   - 7.0 a 8.9 → **Bom**  
   - 5.0 a 6.9 → **Regular**  
   - 0.0 a 4.9 → **Insuficiente**  
   - Fora da faixa → **Nota inválida**

6. **GerarTabuada**  
   Gera a tabuada de 1 até 10 para um número informado, utilizando `for`.

7. **JogoAdivinhacao**  
   Simula um jogo de adivinhação com tentativas limitadas, usando `while`.

8. **ValidarSenha**  
   Valida se uma senha atende aos critérios de segurança (mínimo de 8 caracteres, número, letra maiúscula e caractere especial), utilizando `do-while`.

9. **AnalisarNotas**  
   Analisa um conjunto de notas de alunos com `foreach`, calculando: média, aprovados, maior nota, menor nota e distribuição por faixa (A, B, C, D, F).

10. **ProcessarVendas**  
    Processa vendas por categoria, aplicando percentuais de comissão específicos, utilizando múltiplos `foreach`.

---

## ✅ Estruturas utilizadas
- **IF/ELSE** → Validação de idade  
- **SWITCH** → Calculadora e classificação de notas  
- **FOR** → Tabuada  
- **WHILE** → Jogo de adivinhação  
- **DO-WHILE** → Validação de senha  
- **FOREACH** → Análise de notas e processamento de vendas  

---

## ▶️ Como executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/Kaiomeireles/CheckPoint1.git
