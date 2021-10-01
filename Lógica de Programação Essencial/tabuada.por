programa
{
	
	funcao inicio()
	{
		inteiro numero, contador, resultado, limite
		escreva("Entre com um número para realizar a tabuada e o limite \n")
		leia(numero, limite)

		contador = 0

		se (numero > 0){
			faca{
				resultado = numero * contador
				escreva(numero + " * " + contador + " = " + resultado + "\n")
				contador++
			}enquanto(contador <= limite)
			
		}senao{
			escreva("Não é possível fazer tabuada com número nulo ou negativo.")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 9; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */