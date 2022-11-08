//We plan on output to the HTML DOM, so we don't need a return type here
function Roll() {
    //If you wish to turn loose typing back on use the any datatype 
    var sides = document.getElementById("Sides").value;
    console.log(sides);
    var min = 1;
    var roll1 = Math.floor(Math.random() * parseInt(sides)) + min;
    var roll2 = Math.floor(Math.random() * parseInt(sides)) + min;
    document.getElementById("RollResults").innerHTML = "<p>Roll 1: ".concat(roll1, " </p> <p>Roll 2: ").concat(roll2, " </p>");
}
