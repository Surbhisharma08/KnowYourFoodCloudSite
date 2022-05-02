// JavaScript source code
function SomeDeleteRowFunction(o) {
   
    var p = o.parentNode.parentNode;
    p.parentNode.removeChild(p);
}

let FoodDataB = [{ component: 'Total Fat', dailyvalue: '0.4g' },
{ component: 'Cholesterol', dailyvalue: '0g' },
{ component: 'Sodium', dailyvalue: '1mg' },
{ component: 'Potassium', dailyvalue: '422mg' },
{ component: 'Carbohydrate', dailyvalue: '27 g' },
{ component: 'Protein', dailyvalue: '1.3 g' }];

let FoodDataMilk = [{ component: 'Total Fat', dailyvalue: '0.4g' },
{ component: 'Cholesterol', dailyvalue: '0g' },
{ component: 'Sodium', dailyvalue: '1mg' },
{ component: 'Potassium', dailyvalue: '422mg' },
{ component: 'Carbohydrate', dailyvalue: '27 g' },
{ component: 'Protein', dailyvalue: '1.3 g' }];
let FoodDataMeat = [{ component: 'Total Fat', dailyvalue: '0.4g' },
{ component: 'Cholesterol', dailyvalue: '0g' },
{ component: 'Sodium', dailyvalue: '1mg' },
{ component: 'Potassium', dailyvalue: '422mg' },
{ component: 'Carbohydrate', dailyvalue: '27 g' },
{ component: 'Protein', dailyvalue: '1.3 g' }];





var input = document.getElementById("foodInput");


input.addEventListener("keyup", function (event) {

    if (event.keyCode === 13) {

        event.preventDefault();

        document.getElementById("foodBtn").click();
    }
});
foodBtn.addEventListener('click', function () {
    document.getElementById('foodtb').style.display = "";
    document.getElementById('norecord').style.display = "none";
    var search = document.getElementById('foodInput').value
    console.log(search);
    if (search.toLowerCase() == 'banana') {
        loadTableData(FoodDataB);
    } else if (search.toLowerCase() == 'milk') {
        loadTableData(FoodDataMilk);
    } else if (search.toLowerCase() == 'meat') {
        loadTableData(FoodDataMeat);
    } else {
        document.getElementById('norecord').style.display = "";
        document.getElementById('foodtb').style.display = "none";
    }
});
function loadTableData(FoodData) {
    const tableBody = document.getElementById('FoodData');
    let dataHtml = '';
    for (let food of FoodData) {
        dataHtml += `<tr><td>${food.component}</td><td>${food.dailyvalue}</td></tr>`;
    }
    tableBody.innerHTML = dataHtml;
}