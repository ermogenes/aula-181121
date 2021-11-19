document.addEventListener('DOMContentLoaded', async () => {
    const response = await fetch('/escola');
    const dadosEscola = await response.json();
    
    const lista = document.querySelector('#dados-escola');
    lista.insertAdjacentHTML('beforeend', `<li>A ${dadosEscola.nome}, fundada em ${dadosEscola.anoFundacao} fica em ${dadosEscola.cidade}.</li>`);
});