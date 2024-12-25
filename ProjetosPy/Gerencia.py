from tkinter import *
from tkinter import messagebox
import tkinter as tk

def calc_veiculo():
    try:
       valor_prin = float(entry_valor.get())
       parcela = int(entry_parcela.get())
       FormaPag = str(entry_forma.get())
       debito = valor_prin*0.10
       credito = valor_prin/parcela+0.80
       label_resultado.config(text=f"O Valor total no debito com desconto :{debito:,.2f}")
       label_resultado2.config(text=f"O Valor total no credito será: R$ {credito:,.2f}")
       label_parcela.config(text=f"Quantidade de Parcelas{parcela}")
       label_principal.config(text=f"O Valor Total do veiculo é: {valor_prin:,.2f}")
       label_formapag.config(text=f"A forma de pagamento selecionada: {FormaPag}")
       if FormaPag == 'Pix':
           deb = debito
       elif FormaPag == 'Debito':
           deb = debito
       elif FormaPag == 'Crediario':
           crediario = credito
       else:
           label_formapag.config(text=f"Forma de Pagamento Selecionada Invalida") 
    except ValueError:
        messagebox.showerror("Erro favor Informar valores validos")
    
root = tk.Tk()
root.title("Bem vindo")
root.geometry("500x500")

label_valor = tk.Label(root,text="Valor Inicial do Veiculo")
label_valor.pack(pady=5)
entry_valor=tk.Entry(root)
entry_valor.pack(pady=5)

label_parcela = tk.Label(root,text="Quantidade de parcelas")
label_parcela.pack(pady=5)
entry_parcela=tk.Entry(root)
entry_parcela.pack(pady=5)

label_forma = tk.Label(root,text="Forma de Pagamento")
label_forma.pack(pady=5)
entry_forma=tk.Entry(root)
entry_forma.pack(pady=5)

botao_calc = tk.Button(root,text="Calcular",command=calc_veiculo)
botao_calc.pack(pady=20)

label_parcela = tk.Label(root,text="Quantidade de parcelas",font=("Arial", 12, "bold"))
label_parcela.pack(pady=10)

label_principal = tk.Label(root,text="Valor do Veiculo",font=("Arial", 12, "bold"))
label_principal.pack(pady=10)

label_resultado = tk.Label(root,text="Valor Total No debito R$",font=("Arial", 12, "bold"))
label_resultado.pack(pady=10)

label_resultado2 = tk.Label(root,text=" Valor no credito R$",font=("Arial", 12, "bold"))
label_resultado2.pack(pady=10)

label_formapag = tk.Label(root,text="Forma de Pagamento",font=("Arial", 12, "bold"))
label_formapag.pack(pady=10)

root.mainloop()
