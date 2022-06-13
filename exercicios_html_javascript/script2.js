function ex_02(){
    document.getElementById("texto").style.color = document.getElementById("cor").value;
}

function ex_03(){
    var radio = document.getElementsByName("cor");
    for(var i = 0; i < radio.length; i++){
        if(radio[i].checked){
            document.getElementById("texto").style.color = radio[i].value;
        }
    }
}


var lista = document.getElementById("lista");

function ex_04_add(){
    var li = document.createElement("li");
    li.innerHTML = document.getElementById("text").value;
    lista.appendChild(li);
}

function ex_04_dest(){
    lista.childNodes[document.getElementById("destacar").value].style.color = "red";
}

function ex_04_rem(){
    lista.childNodes[document.getElementById("remover").value].remove();
}


function ex_05(){
    var lista = document.getElementById("lista");
    var cidade = document.createElement("option"); 
    cidade.value = document.getElementById("cidade").value;
    cidade.innerHTML = document.getElementById("cidade").value;

    lista.appendChild(cidade);
    document.getElementById("cidade").value = "";
}