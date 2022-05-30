function ex_01(){
    var nome = document.getElementById("nome").value;
    document.getElementById("info").innerText = nome;
}

function ex_02(){
    var dc = document.getElementById("text").value;
    document.getElementById("resto").innerText = 150 - dc.length;
}

function ex_final(){
    var nome = document.getElementById("nome").value + document.getElementById("sobrenome").value;
    var gen = document.getElementById("genero").value;
    var estado = document.getElementById("estado").value;
    var senha = document.getElementById("senha").value;
    var senhaConf = document.getElementById("confirmarsenha").value;

    if(senha == senhaConf){
        document.getElementById("nome_completo").innerHTML = nome;
        document.getElementById("gen").innerHTML = gen;
        document.getElementById("estado_r").innerHTML = estado;
    }else{
        alert("A senhas não correspondem!");
    }
}