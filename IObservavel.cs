public interface IObservavel
{
    public void Inscrever(IObservador observador);
    public void Desinscrever(IObservador observador);
    public void Notificar(String evento);
}