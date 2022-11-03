namespace solid.SRP.Good;

class Pedido
{
    public void CalcularTotal() {/*...*/}
    public void ObterItens() {/*...*/}
    public void ObterTotalItens() {/*...*/}
    public void AddItem(String item) {/*...*/}
    public void DeleteItem(String item) {/*...*/}
}

class PedidoRepository
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}

class PedidoViewer
{
    public void ShowPedido() {/*...*/}
}