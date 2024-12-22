//Variaveis de entrada
let opcao = prompt("1-Cadastrar Abrigo\n2-Listar Abrigo\n3-procurar abrigo\n4-Sair\nEscolha Uma opcao:")
let listabrigo = []
//Menu de ações
while(opcao!=='4'){
switch(opcao){
  case '1':
  cadfun()
  break
  case '2':
  infoabrigo()
  break
  case '3':
  procurabrigo()
  break
  case '4':
  alert('Sair')
  break
  default:
  alert('Opção Invalida!!!!')
  break
}
opcao = prompt("1-Cadastrar Abrigo\n2-Listar Abrigo\n3-procurar abrigo\n4-Sair\nEscolha Uma opcao:")
}
//Funcao de cadastro!!
function cadfun(){
    let nomecid = prompt("Qual e o nome da cidade que gostaria de cadastrar ?")
    let enderecocid = prompt("Qual e endereco da cidade que gostaria de cadastrar? ")
    let telefone = Number(prompt("Qual e o telefone do abrigo?"))
    let lotacao = Number(prompt("Qual é a lotacao do abrigo em pessoas?"))
    listeste={
        Cidade: nomecid,
        Endereco: enderecocid,
        Telefone: telefone,
        Capacidade:lotacao
        
    }
    listabrigo.push(listeste)
   
}
//Função de listar Abrigo
function infoabrigo(){
   for(let i=0;i<listabrigo.length; i++){
   alert(`==Listar de Abrigos cadastrados==\nNome da Cidade:${listabrigo[i].Cidade}\nEndereço:${listabrigo[i].Endereco}\nTelefone do Abrigo:${listabrigo[i].Telefone}\nCapacidade do Abrigo:${listabrigo[i].Capacidade}\n=======`)
}
}
//Função de Procurar Abrigo
function procurabrigo(){
const cidcadastrada = prompt("Por favor insira a cidade que quer procurar:")
const novo = []
for(let i=0;i<listabrigo.length; i++){
 if(cidcadastrada===listabrigo[i].Cidade ){
     novo.push(listabrigo[i])
}
}
if(novo.length===0){
    alert("Cidade não cadastrada.")
}else{
for(let i=0;i<novo.length; i++){
alert(`==Listar de Abrigos cadastrados==\nNome da Cidade:${novo[i].Cidade}\nEndereço:${novo[i].Endereco}\nTelefone do Abrigo:${novo[i].Telefone}\nCapacidade do Abrigo:${novo[i].Capacidade}\n=======`)
}
}
}


