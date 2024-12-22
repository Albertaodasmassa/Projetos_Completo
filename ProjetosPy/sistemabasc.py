# Definindo algumas funções de exemplo
def opcao1():
    insira_info()
def opcao2():
    cadastra_info()

def sair():
    print("Saindo do programa...")
    exit()

# Criando o menu
def menu():
    print("Escolha uma opção:")
    print("1 - Opção 1")
    print("2 - Opção 2")
    print("3 - Sair")
    
    # Lê a escolha do usuário
    escolha = input("Digite o número da opção: ")
    
    # Usando um dicionário para simular o switch case
    #Chama a função simular ao js, porem em py, usa essa imundicia toda, em vez de um switch case simples como no js.
    #que imundicia HAHAHA
    switch = {
        '1': insira_info,
        '2': cadastra_info,
        '3': sair
    }
    
    # Chama a função correspondente à escolha ou exibe mensagem de erro
    func = switch.get(escolha)
    if func:
        func()
    else:
        print("Opção inválida!")

# Chamando o menu
def insira_info():
    nome = input("Olá Insira seu nome: ")
    idade = int(input("Oá Insira sua idade: "))
    user = input("Por favor insira seu usuario: ")
    ensinomedio = input("Voce completou o ensino medio?S/N")
    print("Olá" ,nome,"Idade",idade,"usuario é",user)
    if idade>18:
        print("Voce pode fazer carteira de motora!")
    else:
       print("Voce não pode fazer carteira de motora!")
    if ensinomedio == "s":
        print("Voce completou o ensino medio!")
    else:
        print("Voce não completou o ensino medio!")
def cadastra_info():
    nome_abrigo = input("Insira o Nome")
    id_abrigo = int(input("Insira o numero do abrigo"))
    array_abrigo = []
    array_abrigo.insert(nome_abrigo[i])
    array_abrigo.insert(id_abrigo[i])
menu()

