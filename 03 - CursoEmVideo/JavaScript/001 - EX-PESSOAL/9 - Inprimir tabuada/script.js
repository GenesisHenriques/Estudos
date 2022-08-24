function calcular(){
    let num = document.getElementById('num').value;
    let tabuada = document.querySelector('select#tabuada');

    for (let i = 0; i <= 10; i++){
        let item = document.createElement('option');
        item.text = `${num} x ${i} = ${num*i}`
        tabuada.appendChild(item)

        let item2 = document.createElement('option');
        item2.text = `----------------`
        tabuada.appendChild(item2)
    }
}