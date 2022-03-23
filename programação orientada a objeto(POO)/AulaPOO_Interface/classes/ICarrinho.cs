namespace POO_inerfaces.classes
{
    public interface ICarrinho
    {
        void Listar();
        void Cadastrar(Produto produto);
        void Deletar(Produto produto);
        void Alterar(int codigo, Produto produto);

    }
}