class GerenciadorNotificacao: IObservavel{
    private static GerenciadorNotificacao _instancia;
    List<IObservador> observadores = new List<IObservador>();

    public static GerenciadorNotificacao getInstancia(){
        if (_instancia == null)
            _instancia = new GerenciadorNotificacao();
        return _instancia;
    } 

    public void Inscrever(IObservador observador){
        this.observadores.Add(observador);
    }

    public void Desinscrever(IObservador observador){
        this.observadores.Remove(observador);
    }

    public void Notificacao(string evento){
        this.Notificar(evento);
    }

    public void Notificar(string evento){
        foreach(var ob in observadores){
            if (ob.evento == evento)
                ob.Atualizar();
        }
    }
}