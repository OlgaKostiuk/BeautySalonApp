var womenPricesToggleBtnSelector = '#womenPricesToggleBtn';
var menPricesToggleBtnSelector = '#menPricesToggleBtn';

var womenPricesMenuContainerSelector = '#womenPricesMenuContainer';
var menPricesMenuContainerSelector = '#menPricesMenuContainer';

function init() {
    showWomenPrices();
    var womenPricesToggleBtn = document.querySelector(womenPricesToggleBtnSelector);
    womenPricesToggleBtn.addEventListener('click', showWomenPrices);

    var menPricesToggleBtn = document.querySelector(menPricesToggleBtnSelector);
    menPricesToggleBtn.addEventListener('click', showMenPrices);
}

function showWomenPrices() {
    var womenPricesToggleBtn = document.querySelector(womenPricesToggleBtnSelector);
    womenPricesToggleBtn.classList.add('isSelected');
    var menPricesToggleBtn = document.querySelector(menPricesToggleBtnSelector);
    menPricesToggleBtn.classList.remove('isSelected');
    var womenPricesMenuContainer = document.querySelector(womenPricesMenuContainerSelector);
    womenPricesMenuContainer.style.display = 'block';
    var menPricesMenuContainer = document.querySelector(menPricesMenuContainerSelector);
    menPricesMenuContainer.style.display = 'none';
}
function showMenPrices() {
    var womenPricesToggleBtn = document.querySelector(womenPricesToggleBtnSelector);
    womenPricesToggleBtn.classList.remove('isSelected');
    var menPricesToggleBtn = document.querySelector(menPricesToggleBtnSelector);
    menPricesToggleBtn.classList.add('isSelected');
    var womenPricesMenuContainer = document.querySelector(womenPricesMenuContainerSelector);
    womenPricesMenuContainer.style.display = 'none';
    var menPricesMenuContainer = document.querySelector(menPricesMenuContainerSelector);
    menPricesMenuContainer.style.display = 'block';
}

document.addEventListener('DOMContentLoaded', init);