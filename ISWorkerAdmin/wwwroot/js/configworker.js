const bottonTest = document.getElementById('btnTest');
const bottonSave = document.getElementById('btnSave');

bottonTest.addEventListener('click', TestConnection);
bottonSave.addEventListener('click', SaveAndRedirection);


function TestConnection(){

    console.log('Testou');

}

function SaveAndRedirection(){

    console.log('Salvou');

}