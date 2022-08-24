function carregar(){
    var msg = document.getElementById('msg')
    var img = document.getElementById('imagem')
    var data = new Date()
    var hora = data.getHours()
    msg.innerHTML = `Agora são ${hora} horas.`
    if (hora >= 0 && hora < 12){
        img.src = "IMAGEM/manha.png"
        document.body.style.background = '#c5d0cc'
    } else if (hora >= 12 && hora < 18) {
        img.src = "IMAGEM/tarde.png"
        document.body.style.background = '#ffcb23'
    } else {
        img.src = "IMAGEM/noite.png"
        document.body.style.background = '#362943'
    }

}