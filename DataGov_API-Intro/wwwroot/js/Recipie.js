function SomeDeleteRowFunction(o) {

    var p = o.parentNode.parentNode;
    p.parentNode.removeChild(p);
}
// JavaScript source code
let Applepie = [{ component: 'apple', dailyvalue: '95' },
{ component: 'sugar', dailyvalue: '9' },
{ component: 'flour', dailyvalue: '80' },
{ component: 'butter', dailyvalue: '102' },

];

let pasta = [{ component: 'flour', dailyvalue: '80' },
{ component: 'butter', dailyvalue: '102' },
{ component: 'Cheese', dailyvalue: '242' },
{ component: 'tomato', dailyvalue: '40' },
];



var input = document.getElementById("recipieInput");


input.addEventListener("keyup", function (event) {

    if (event.keyCode === 13) {

        event.preventDefault();

        document.getElementById("recipeBtn").click();
    }
});
recipeBtn.addEventListener('click', function () {
    document.getElementById('recipiettb').style.display = "";
    document.getElementById('norecord').style.display = "none";
    var search = document.getElementById('recipieInput').value
    console.log(search);
    if (search.toLowerCase() == 'apple sugar flour butter') {
        loadTableData(Applepie);
    } else if (search.toLowerCase() == 'flour butter cheese tomato') {
        loadTableData(pasta);
    } else {
        document.getElementById('norecord').style.display = "";
        document.getElementById('recipiettb').style.display = "none";
    }
});
function loadTableData(FoodData) {
    const tableBody = document.getElementById('RecipieData');
    let dataHtml = '';
    for (let food of FoodData) {
        dataHtml += `<tr><td>${food.component}</td><td>${food.dailyvalue}</td></tr>`;
    }
    tableBody.innerHTML = dataHtml;
}

