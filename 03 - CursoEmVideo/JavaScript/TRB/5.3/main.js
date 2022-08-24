const divUm = document.getElementById('divUm');
const divDois = document.getElementById('divDois');
const divTres = document.getElementById('divTres');
const input = document.getElementById('input');
const myWebpage = document.getElementById('mySpotrybefy');

// Copie esse arquivo e edite apenas ele;
 //Crie uma função que adicione a classe 'tech' ao elemento selecionado;
 window.onload = function(){
  //1. Deve existir apenas um elemento com a classe 'tech'. Como você faz isso?
  // Crie uma função que, ao digitar na caixa de texto, altere o texto do elemento
  //com a classe 'tech';
  divUm.addEventListener('click', function(){
    let antigoTech = document.querySelectorAll('.tech')[0];
    antigoTech.className = '';
    divUm.className = 'tech';
  });
  divDois.addEventListener('click', function(){
    let antigoTech = document.querySelectorAll('.tech')[0];
    antigoTech.className = '';
    divDois.className = 'tech';
  });
   divTres.addEventListener('click', function(){
    let antigoTech = document.querySelectorAll('.tech')[0];
    antigoTech.className = '';
    divTres.className = 'tech';
  });
   //Crie uma função que, ao clicar duas vezes em 'Meu top 3 do Spotrybefy', ele
  //redirecione para alguma página;
  //1. Que tal redirecionar para seu portifólio?
  myWebpage.addEventListener('dblclick', function(){
    window.open('https://www.primevideo.com/');
  });

  //Crie uma função que, ao passar o mouse sobre 'Meu top 3 do Spotrybefy', altere
  //a cor do mesmo;
  myWebpage.addEventListener('mouseover', function(){
    myWebpage.style.backgroundColor = 'red';

    myWebpage.addEventListener('mouseout', function(){
    myWebpage.style.backgroundColor = '';
    });
  });
 }
 




//Segue abaixo um exemplo do uso de event.target:


function resetText(event) {
  // O Event é passado como um parâmetro para a função.
  event.target.innerText = 'Opção reiniciada';
  // O event possui várias propriedades, porém a mais usada é o event.target,
  // que retorna o objeto que disparou o evento.
}

divUm.addEventListener('dblclick', resetText);
// Não precisa passar o parâmetro dentro do addEventListener. O próprio
// navegador fará esse trabalho por você, não é legal? Desse jeito, o
// event.target na nossa função retornará o objeto 'divUm'.