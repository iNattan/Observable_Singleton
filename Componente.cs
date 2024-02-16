using System.Dynamic;

class Componente: IObservador{
    public String nome{get;}
    public String evento{get;}
    public Componente(String nome, String evento){
        this.nome = nome;
        this.evento = evento;
    }

    public void Atualizar(){
        Console.WriteLine($"O {nome} foi notificado.");
    }
}