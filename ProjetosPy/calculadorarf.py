from tkinter import *
import os
from tkinter import messagebox
import tkinter as tk

def calculadorarf():
    try:
       valor_inv = float(entry_valor.get())
       juros = float(entry_juro.get())/100
       tempo = int(entry_tmp.get())
       vf = valor_inv*(1+juros)**tempo
       imposto = vf*0.15
       label_resultado.config(text=f"Valor Futuro: R$ {vf:,.2f}")
       label_resultado2.config(text=f"O Valor do Imposto será de R$ {imposto:,.2f}")
    except ValueError:
        messagebox.showerror("Erro favor Informar valores validos")
    
root = tk.Tk()
root.title("Bem vindo a calculadora de renda fixa")
root.geometry("300x450")

label_valor = tk.Label(root,text="Valor Investido em R$:")
label_valor.pack(pady=5)
entry_valor=tk.Entry(root)
entry_valor.pack(pady=5)

label_juro = tk.Label(root,text="Taxa de Juros")
label_juro.pack(pady=5)
entry_juro=tk.Entry(root)
entry_juro.pack(pady=5)

label_tmp = tk.Label(root,text="Vencimento do cupom")
label_tmp.pack(pady=5)
entry_tmp=tk.Entry(root)
entry_tmp.pack(pady=5)

botao_calc = tk.Button(root,text="Calcular",command=calculadorarf)
botao_calc.pack(pady=20)

label_resultado = tk.Label(root,text="Valor no Vencimento será R$",font=("Arial", 12, "bold"))
label_resultado.pack(pady=10)

label_resultado2 = tk.Label(root,text="O Imposto a pagar será R$",font=("Arial", 12, "bold"))
label_resultado2.pack(pady=10)

root.mainloop()

