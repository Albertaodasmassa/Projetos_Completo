using UnityEngine;

class Program
{
   private int vida;
   private int armadura;
   private int dano;
   private int xp;
   private int level;
   
   //Função para chamar status inicial do player como vida por exemplo, exemplo(public int vida vou chamar vida = 100;)
   //Sempre usar o Update para atualizar o TMP Quando for atualizar chamar a função em outro script
   //TMP não precisa ter o nome colocado aqui
   //TMP precisa ser .text
   //Criar um script para ponto de tiro
   //Criar um script para o playerstatus pode ser playerinfo ou qualquer nome
    void Start()
    {
        vida = 10;
        level = 0;
        xp = 0;
        dano = 2;
        armadura = 5;
    }

    void Update()
    {

    }

}
