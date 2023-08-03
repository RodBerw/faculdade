package ex_1_pkg;

import java.util.ArrayList;
import java.util.List;

public class GerenciadorVendas {
	
	public List <Venda> vendas;
	
	public GerenciadorVendas() {
		vendas = new ArrayList<>();
	}
	
	public void RegistrarVenda(Venda venda) {
		vendas.add(venda);
	}

}
