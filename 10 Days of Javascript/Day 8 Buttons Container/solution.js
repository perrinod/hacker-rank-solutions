//https://www.hackerrank.com/challenges/js10-buttons-container/problem
var btn5 = document.getElementById("btn5");
btn5.addEventListener("click", function(){
    const ids=[1,4,7,8,9,6,3];
    const nums=[4,7,8,9,6,3,2];
    let temp = document.getElementById("btn1").innerHTML;
    for(i = 0; i < ids.length; i++){
        document.getElementById("btn" + ids[i]).innerHTML = document.getElementById("btn" + nums[i]).innerHTML;
    }
    document.getElementById("btn2").innerHTML = temp;
});