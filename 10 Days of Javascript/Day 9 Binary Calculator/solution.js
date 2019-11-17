//https://www.hackerrank.com/challenges/js10-binary-calculator/problem
var btnClr = document.getElementById("btnClr");
var btn1 = document.getElementById("btn1");
var btn0 = document.getElementById("btn0");
var btnSum = document.getElementById("btnSum");
var btnSub = document.getElementById("btnSub");
var btnMul = document.getElementById("btnMul");
var btnDiv = document.getElementById("btnDiv");
var btnEql = document.getElementById("btnEql");
var res = document.getElementById("res");

btnEql.addEventListener("click", function(){
    let [num1, op, num2] = res.innerHTML.split(/\b/);
    let n1 = parseInt(num1, 2); 
    let n2 = parseInt(num2, 2);
    switch(op){
        case "+": res.innerHTML = (n1 + n2).toString(2); break;
        case "-": res.innerHTML = (n1 - n2).toString(2); break;
        case "*": res.innerHTML = (n1 * n2).toString(2); break;
        case "/": res.innerHTML = (n1 / n2).toString(2); break;
    }
});

btnClr.addEventListener("click", function(){
    res.innerHTML = "";
});

btn1.addEventListener("click", function(){
   res.innerHTML += "1"; 
});

btn0.addEventListener("click", function(){
    res.innerHTML += "0";
});

btnSum.addEventListener("click", function(){
    res.innerHTML += "+";
});

btnSub.addEventListener("click", function(){
    res.innerHTML += "-";
});

btnMul.addEventListener("click", function(){
    res.innerHTML += "*"
});

btnDiv.addEventListener("click", function(){
    res.innerHTML += "/";
});

