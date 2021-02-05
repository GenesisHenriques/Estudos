function enviar(){
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