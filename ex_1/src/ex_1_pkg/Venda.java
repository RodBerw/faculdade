package ex_1_pkg;

import java.util.ArrayList;
import java.util.List;

public class Venda {
	public List <Produto> produtosVendidos;
	
	public Venda() {
		produtosVendidos = new ArrayList<>();
	}
	
	public Double CalcularValorTotalVenda() {
		Double valorTotal = 0.0;
		for(Produto produto : produtosVendidos) {
			valorTotal += produto.preco;
		}
		return valorTotal;
	}
	
	private void AdicionarProdutoVendido(Produto produto) {
		produtosVendidos.add(produto);
	}
	
	private void ImprimirDetalhesVenda() {
		System.out.println(produtosVendidos);
		System.out.println(CalcularValorTotalVenda());
	}
}
