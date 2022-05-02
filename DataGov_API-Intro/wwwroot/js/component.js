// JavaScript source code
function SomeDeleteRowFunction(o) {

    var p = o.parentNode.parentNode;
    p.parentNode.removeChild(p);
}
let ComponentZinc = [{ component: 'Oysters', dailyvalue: '74mg' },
{ component: 'Beef', dailyvalue: '7mg' },
{ component: 'Yogurt', dailyvalue: '1mg' },
{ component: 'Pumpkin', dailyvalue: '2mg' },
{ component: 'Chickpeas', dailyvalue: ' 1.3mg' },
{ component: 'Protein', dailyvalue: '1.3 mg' }];

let ComponentCalcium = [{ component: 'Milk', dailyvalue: '325mg' },
{ component: 'Seed', dailyvalue: '127mg' },
{ component: 'Cheese', dailyvalue: '242mg' },
{ component: 'Beans', dailyvalue: '244mg' },
{ component: 'Chickpeas', dailyvalue: ' 1.3mg' },
{ component: 'Protein', dailyvalue: '1.3 mg' }];

let ComponentProtein = [{ component: 'Milk', dailyvalue: '325mg' },
{ component: 'Seed', dailyvalue: '127mg' },
{ component: 'Cheese', dailyvalue: '242mg' },
{ component: 'Beans', dailyvalue: '244mg' },
{ component: 'Chickpeas', dailyvalue: ' 1.3mg' },
{ component: 'Protein', dailyvalue: '1.3 mg' }];

var input = document.getElementById("componentInput");


input.addEventListener("keyup", function (event) {

    if (event.keyCode === 13) {

        event.preventDefault();

        document.getElementById("componentBtn").click();
    }
});
componentBtn.addEventListener('click', function () {
    document.getElementById('Componenttb').style.display = "";
    document.getElementById('norecord').style.display = "none";
    var search = document.getElementById('componentInput').value
    console.log(search);
    if (search.toLowerCase() == 'zinc') {
        loadTableData(ComponentZinc);
    } else if (search.toLowerCase() == 'calcium') {
        loadTableData(ComponentCalcium);
    } else if (search.toLowerCase() == 'protein') {
        loadTableData(ComponentProtein);
    } else {
        document.getElementById('norecord').style.display = "";
        document.getElementById('Componenttb').style.display = "none";
    }
});
function loadTableData(FoodData) {
    const tableBody = document.getElementById('ComponentData');
    let dataHtml = '';
    for (let food of FoodData) {
        dataHtml += `<tr><td>${food.component}</td><td>${food.dailyvalue}</td></tr>`;
    }
    tableBody.innerHTML = dataHtml;
}
