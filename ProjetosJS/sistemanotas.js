let opcao = prompt("1-Cadastrar Aluno\n2-Listar Alunos\n3-Cadastrar notas\n4-Sair\nEscolha Uma opcao:")
let notas = []

//Menu de Opção 
while(opcao!=='3'){
    switch(opcao){
      case '1':
      cadfun()
      break
      case '2':
      listarAluno()
      case '3':
      alert('Sair')
      break
      default:
      alert('Opção Invalida!!!!')
      break
    }
    opcao = prompt("1-Cadastrar Abrigo\n2-Listar Abrigo\n3-procurar abrigo\n4-Sair\nEscolha Uma opcao:")
    }

//Função de cadastro
function cadfun(){
    let nomeAluno= prompt("Qual O Nome do aluno que gostaria de cadastrar ?")
    let alunoNota= Number(prompt("Qual a Nota da prova N1?"))
    let alunoNota2= Number(prompt("Qual a Nota da prova N2?"))
    let alunoNota3= Number(prompt("Qual a Nota da prova N3?"))
    let id = nomeAluno

    listAluno={
        alunonome: nomeAluno,
        nota1: alunoNota,
        nota2: alunoNota2,
        nota3: alunoNota3,
        resultado: (alunoNota+ alunoNota2 + alunoNota3)/3
    }
    notas.push(listAluno)
}
//Função para listar aluno
function listarAluno(){
    for(let i=0;i<notas.length; i++){
    alert(`==Listar Aluno Cadastrado==\nNome do Aluno: ${notas[i].alunonome}  A media do aluno é: ${notas[i].resultado} \n=======`)
 }
 }
