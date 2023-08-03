package ex_1_pkg;

import java.util.ArrayList;
import java.util.List;

public class Estoque {
	public List <Produto> produtos;
	
	public Estoque() {
		produtos = new ArrayList<>();
	}
	
	public void AdicionarProduto(Produto produto) {
		produtos.add(produto);
	}
	
	public Produto buscarProdutoPorCodigo(String codigo) {
        for (Produto produto : produtos) {
            if (produto.codigo == codigo) {
                return produto;
            }
        }
        return null;
    }
}
