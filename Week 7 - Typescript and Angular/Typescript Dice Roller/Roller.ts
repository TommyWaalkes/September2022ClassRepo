//We plan on output to the HTML DOM, so we don't need a return type here
function Roll( ) : void{

    //If you wish to turn loose typing back on use the any datatype 
    let sides : string = (<HTMLInputElement> document.getElementById("Sides")).value;
    console.log(sides);

    let min:number = 1;
    let roll1 = Math.floor(Math.random() * parseInt(sides)) + min;
    let roll2 = Math.floor(Math.random() * parseInt( sides)) + min;

    document.getElementById("RollResults").innerHTML = `<p>Roll 1: ${roll1} </p> <p>Roll 2: ${roll2} </p>`;
}