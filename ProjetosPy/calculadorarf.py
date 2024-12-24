from tkinter import *
import os
from tkinter import messagebox
import tkinter as tk

def calculadorarf():
    try:
       valor_inv = float(entry_valor.get())
       juros = float(entry_valor.get())/100
       tempo = int(entry_valor.get())
       vf = valor_inv*(1+juros)**tempo
       label_resultado.config(text=f"Valor Futuro: R$ {vf:,.2f}")
    except ValueError:
        messagebox.showerror("Erro favor Informar valores validos")
    
root = tk.Tk()
root.title("Bem vindo a calculadora de renda fixa")
root.geometry("600x600")

label_valor = tk.Label(root,text="Valor Investido em R$:")
label_valor.pack(pady=5)
entry_valor=tk.Entry(root)
entry_valor.pack(pady=5)

label_taxa = tk.Label(root,text="Taxa de Juros")
label_taxa.pack(pady=5)
entry_taxa=tk.Entry(root)
entry_taxa.pack(pady=5)

label_tempo = tk.Label(root,text="Vencimento do cupom")
label_tempo.pack(pady=5)
entry_tempo=tk.Entry(root)
entry_tempo.pack(pady=5)

botao_calc = tk.Button(root,text="Calcular",command=calculadorarf)
botao_calc.pack(pady=20)

label_resultado = tk.Label(root,text="Valor no Vencimento será",font=("Arial", 12, "bold"))
label_resultado.pack(pady=10)
root.mainloop()

