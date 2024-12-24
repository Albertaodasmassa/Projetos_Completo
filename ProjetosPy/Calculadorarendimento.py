from tkinter import *
import os
from tkinter import messagebox
import tkinter as tk

def calculadorarf():
    try:
       valor_inv = float(entry_valor.get())
       juros = float(entry_juro.get())
       vf = (juros*100)
       vf2 = vf/valor_inv
       label_resultado.config(text=f"A taxa de rendimento atual é: {vf2:,.2f}")
    except ValueError:
        messagebox.showerror("Erro favor Informar valores validos")
    
root = tk.Tk()
root.title("Bem vindo a calculadora de renda fixa")
root.geometry("300x450")

label_juro = tk.Label(root,text="Rendimento até o momento")
label_juro.pack(pady=5)
entry_juro=tk.Entry(root)
entry_juro.pack(pady=5)

label_valor = tk.Label(root,text="Valor Inicial de Investimento")
label_valor.pack(pady=5)
entry_valor=tk.Entry(root)
entry_valor.pack(pady=5)

botao_calc = tk.Button(root,text="Calcular",command=calculadorarf)
botao_calc.pack(pady=20)

label_resultado = tk.Label(root,text="Valor no Vencimento será R$",font=("Arial", 10, "bold"))
label_resultado.pack(pady=10)

root.mainloop()

