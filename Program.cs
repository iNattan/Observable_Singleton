
GerenciadorNotificacao gerenciador = GerenciadorNotificacao.getInstancia();
var comp1 = new Componente("Natan", "Evento Fasoft");
var comp2 = new Componente("João", "Passeio");
var comp3 = new Componente("Pedro", "Evento Fasoft");
var comp4 = new Componente("Higor", "Aula");

gerenciador.Inscrever(comp1);
gerenciador.Inscrever(comp2);
gerenciador.Inscrever(comp3);
gerenciador.Inscrever(comp4);

Console.WriteLine("Escreva o nome do evento para ser notificado:");
string evento = Console.ReadLine();

gerenciador.Notificacao(evento);