//https://www.hackerrank.com/challenges/js10-class/problem
function Polygon (length) {
    this.length = length;
    this.perimeter = function getPerimeter(){
        var perimeter = 0;

        for(var side of length){
            perimeter += side;
        }

        return perimeter;
    };
}


const rectangle = new Polygon([10, 20, 10, 20]);
const square = new Polygon([10, 10, 10, 10]);
const pentagon = new Polygon([10, 20, 30, 40, 43]);

console.log(rectangle.perimeter());
console.log(square.perimeter());
console.log(pentagon.perimeter());