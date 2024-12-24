let menu = prompt("Informe uma opção de 1 a 4:")
while(menu!=='4'){
switch(menu){
    case '1':
    calc()
    break
    case '2':
    calc2()
    break
    case '3':
    calc3()
    break
    case '4':
    console.log("Sair")
    default:
    console.log("Opção Invalida")
    break
}
menu = prompt("Informa a opção 1 ou 4:")
}

function calc(){
const valorIni= Number(prompt("Favor Informar o Valor Inicial R$: "))
const juros = Number(prompt("Favor Informar o juros do cupom % "))
const tempo = Number(prompt("Favor Informar o Tempo em Anos "))
const juros2 = juros/100
const calculo = valorIni*(1+juros2)**tempo
console.log("O Valor Total será R$:",Math.floor(calculo))
}
function calc2(){
const valorIni= Number(prompt("Favor Informar o Valor Inicial R$: "))
const juros = Number(prompt("Favor Informar o juros do cupom %: "))
const tempo = Number(prompt("Favor Informar o Tempo em Meses "))
const juros2 = juros/100
const mes = tempo/12
const calculo2 = valorIni*(1+juros2)**mes
console.log("O Valor Total será R$:",Math.floor(calculo2))
}
function calc3(){
const valorIni= Number(prompt("Favor Informar o Valor Inicial R$:"))
const juros = Number(prompt("Favor Informar o juros do cupom % : "))
const ipcaAtual = Number(prompt("Favor Informe o ipca atual:"))
const tempo = Number(prompt("Favor Informar o Tempo em Anos "))
const juros2 = juros/100
const ipcaAtual2 = ipcaAtual/100
const somajuros = juros2+ipcaAtual2
const calculo3 = valorIni*(1+somajuros)**tempo
const calc4 = calculo3 - valorIni
console.log("O valor total em R$",Math.floor(calculo3))
console.log("O valor do juros total será",Math.floor(calc4))
if(tempo>=10){
   const calculo4 = calculo3*0.15
   console.log("O Valor será do IR será de 15%:",Math.floor(calculo4))
}else if(tempo=>1){
    const calculo5 = calculo3*0.20
    console.log("O Valor será do IR será de 17,5%:",Math.floor(calculo5))
}
}
