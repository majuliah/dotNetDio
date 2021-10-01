programa
{
	
	funcao inicio()
	{
		real nota1, nota2, nota3, nota4, media
		escreva("Entre com as 4 notas ")
		leia(nota1, nota2, nota3, nota4)

		media = (nota1 + nota2 + nota3 + nota4)/ 4
		escreva("\n" + " Sua média foi: " + media)

		se (media >= 7.0){
			escreva("\n" + "Parabéns! Aprovado!")
		}senao{
			escreva("Puxa, reprovado :(")	
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 281; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */