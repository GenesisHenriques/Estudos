let num = document.querySelector('input#fnum')
let lista = document.querySelector('select#flista')
let res = document.querySelector('div#res')
let valores = []

function isNumero(n) {
    if (Number(n) >= 1 && Number(n) <= 100){
        return true
    } else {
        return false
    }
}

function inLista(n, l){
    if(l.indexOf(Number(n)) != -1){
        return true
    } else {
        return false
    }
}


function adicionar() {
    if (isNumero(num.value) && !inLista(num.value, valores)) {
        valores.push(Number(num.value)) // valor adicionado no vetor "valores"--push coloca na ultima posição--resto transforma o "let num" em numero
        let item = document.createElement('option') // cria um "option" no meu selection
        item.text = `Valor ${num.value} adicionado` // coloca um texto no option "texto = oq vai aparecer na tela"
        lista.appendChild(item) // adiciona o "item" na "lista"
        res.innerHTML = ""
    } else {
        window.alert('Valor inválido ou já encontrado na lista')
    }

    num.value = ""
    num.focus()
}

function finalizar(){
    if (valores.length == 0){
        window.alert('Adicione valores antes de finalizar')
    } else {
        let tot = valores.length
        let maior = valores[0]
        let menor = valores[0]
        let soma = 0
        let media = 0
        
        for (let pos in valores){
            if (valores[pos] > maior){
                maior = valores[pos]
            }
            if (valores[pos] < menor){
                menor = valores[pos]
            }
            soma += valores[pos]
        }
        media = soma / tot
        res.innerHTML = ""
        res.innerHTML += `<p>Ao todo, temos ${tot} números cadastrados.</p>`
        res.innerHTML += `<p>O maior numero cadastrado é: ${maior}</p>`
        res.innerHTML += `<p>O menor numero cadastrado é: ${menor}</p>`
        res.innerHTML += `<p>A soma dos numeros digitados é: ${soma}</p>`
        res.innerHTML += `<p>A media dos numeros digitados é: ${media}</p>`
    }

}







/*
function adicionar(){
    let num = document.querySelector('input#txtnum')
    let tab = document.getElementById('numD')

    if (num.value.length == 0){
        window.alert('Por favor, digite um numero!')
    } else {
            let item = document.createElement(`option`)
            item.text = `${num}`
            item.value = `tab${num}`
            tab.appendChild(item)
         }   

    }
}
*/



/*
if (num.value.length == 0){
        window.alert('Por favor, digite um numero!')
    } else{
        let n = Number(num.value)
        let c = 1
        tab.innerHTML = ''
        while (c <= 10){
            let item = document.createElement(`option`)
            item.text = `${n} + ${c} = ${n*c}`
            item.value = `tab${c}`
            tab.appendChild(item)
            c++
        }
    }
*/