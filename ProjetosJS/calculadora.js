function calculadora() {
    // Obter os valores dos campos de entrada
    const valorInvestido = Number(document.getElementById("valorInvestido").value);// Valor inicial investido
    const taxaJuros = Number(document.getElementById("taxaJuros").value) / 100; // O dividir por 100, porque e % se divide por 100 lembrar mais tarde
    const periodo = Number(document.getElementById("periodo").value); //Periodo de tempo Investido
    const ipcaAtual = Number(document.getElementById("ipca").value) / 100;
    const soma = taxaJuros+ipcaAtual;

    // Verificar se os campos estão preenchidos corretamente
    if (isNaN(valorInvestido) || isNaN(taxaJuros) || isNaN(periodo)|| isNaN(ipcaAtual)) {
        document.getElementById("resultado").innerText = "Por favor, preencha todos os campos corretamente";
    }

    // Fórmula dos Juros Compostos: M = P * (1 + i)^n
    // Formula usada para verificar o monante final o comando mathpow pode ser substituido por **
    let montante = valorInvestido * Math.pow((1 + taxaJuros), periodo);
    let calculo = valorInvestido*(1+soma)**periodo;

    // Exibir o resultado
    document.getElementById("resultado").innerText = `O Valor Aplicado será de R$: ${montante.toFixed(2)}`;
    document.getElementById("resultado2").innerText = `O Valor Aplicado será de R$: ${calculo.toFixed(2)}`;
}
