function calcular(){
    let F = document.getElementById('F').value;
    let res = document.getElementById('res');
    let lista = document.getElementById('lista');
    let C = (parseInt(F) - 32) * (5/9);

    let item = document.createElement('option');
    item.text = `Fahrenheit ${F} = Centigrados ${C}`
    lista.appendChild(item)

    res.innerHTML = ``

}