function verificar(){
    var data = new Date()
    var ano = data.getFullYear()
    var fano = document.getElementById('txtano')
    var res = document.querySelector('div#res')
    if (fano.value.length == 0 || fano.value > ano){
        window.alert('[ERRO] Verifique os dados e tente novamente')
    } else {
        var fsex = document.getElementsByName('radsex')
        var idade = ano - Number(fano.value)
        var genero = ''
        var img = document.createElement('img')
        img.setAttribute('id','foto')
        if (fsex[0].checked){
            genero = 'Homem'
            if (idade >= 0 && idade < 10){
                img.setAttribute('src', 'fotos/homem-criança.png')
            } else if (idade < 21){
                img.setAttribute('src', 'fotos/homem-jovem.png')
            } else if (idade < 50){
                img.setAttribute('src', 'fotos/homem-adulto.png')
            } else {
                img.setAttribute('src', 'fotos/homem-idoso.png')
            }
        } else if (fsex[1].checked){
            genero = 'Mulher'
            if (idade >= 0 && idade < 10){
                img.setAttribute('src', 'fotos/mulher-criança.png')
            } else if (idade < 21){
                img.setAttribute('src', 'fotos/mulher-jovem.png')
            } else if (idade < 50){
                img.setAttribute('src', 'fotos/mulher-adulta.png')
            } else {
                img.setAttribute('src', 'fotos/mulher-idosa.png')
            }
        }
        res.style.textAlign = 'center'
        if (idade >= 0 && idade < 10){
            res.innerHTML = `Detectamos uma criança com ${idade} anos`
        } else if (idade < 21){
            res.innerHTML = `Detectamos um jovem com ${idade} anos`
        } else if (idade < 50){
            res.innerHTML = `Detectamos um adulto com ${idade} anos`
        } else {
            res.innerHTML = `Detectamos um idoso com ${idade} anos`
        }
        res.appendChild(img)
    }

}
