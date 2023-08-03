package ex_1_pkg;

public class Produto {
	public String codigo;
	public String nome;
	public Double preco;
	public Integer qntEstoque;
	
	public Integer calcularValorTotal(Double _preco, Integer _qntEstoque) {
        return (int)(_preco * _qntEstoque);
    }
}
