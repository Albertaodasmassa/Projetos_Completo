from tkinter import *
from tkinter import messagebox
import tkinter as tk
#Bibliotecas Do PY para instalar verificar se esta instalado o tkinter.
#Se não estiver instalado pip install nome da biblioteca.
#Nome é string poderia ser colocado outro tipo de variavel.
#O label de resultado da o resultado da soma das 3 notas e divide por 3.
#O Label nome aluno vai imprimir o nome do aluno, o nota aluno verifica em um if se ele esta aprovado ou reprovado.
def calculadora():
    try:
       nome = str (entry_nm.get())
       n2 = float(entry_nota2.get())
       n3 = float(entry_nota2.get())
       n1 = float(entry_nota1.get())
       res = (n1+n2+n3)/3
       label_resultado.config(text=f"A nota do aluno é: {res:,.2f}")
       label_nomeAluno.config(text=f"Aluno: {nome}")
       if res > 5:
        label_nota_aluno.config(text=f"Aluno Aprovado") 
       else:
        label_nota_aluno.config(text=f"Aluno reprovado")   
       
    except ValueError:
        messagebox.showerror("Erro favor Informar valores validos")
    
root = tk.Tk()
root.title("Bem vindo a calculadora")
root.geometry("300x450")

label_nm = tk.Label(root,text="Nome do Aluno")
label_nm.pack(pady=5)
entry_nm=tk.Entry(root)
entry_nm.pack(pady=5)

label_nota1 = tk.Label(root,text="Nota da primeira avaliação")
label_nota1.pack(pady=5)
entry_nota1=tk.Entry(root)
entry_nota1.pack(pady=5)

label_nota2 = tk.Label(root,text="Nota da Segunda avaliação")
label_nota2.pack(pady=5)
entry_nota2=tk.Entry(root)
entry_nota2.pack(pady=5)

label_nota3 = tk.Label(root,text="Nota da Terceira avaliação")
label_nota3.pack(pady=5)
entry_nota3=tk.Entry(root)
entry_nota3.pack(pady=5)

botao_calc = tk.Button(root,text="Calcular",command=calculadora)
botao_calc.pack(pady=20)

label_resultado = tk.Label(root,text="A nota atual do aluno é",font=("Arial", 10, "bold"))
label_resultado.pack(pady=10)

label_nota_aluno = tk.Label(root,text="A nota atual do aluno é",font=("Arial", 10, "bold"))
label_nota_aluno.pack(pady=10)

label_nomeAluno = tk.Label(root,text="Nome",font=("Arial", 10, "bold"))
label_nomeAluno.pack(pady=10)

root.mainloop()

