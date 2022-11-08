//We plan on output to the HTML DOM, so we don't need a return type here
function Roll( ) : void{

    //If you wish to turn loose typing back on use the any datatype 
    let sides : string = (<HTMLInputElement> document.getElementById("Sides")).value;
    console.log(sides);

    let min:number = 1;
    //Random number generation is weird, Math.Random only returns decimal values between 0 and 1 
    //so we have to multiply and round. 
    let roll1 = Math.floor(Math.random() * parseInt(sides)) + min;
    let roll2 = Math.floor(Math.random() * parseInt(sides)) + min;
    
    if(sides === "6"){
        let result:string = GetSpecialRoll(roll1, roll2);
        document.getElementById("SpecialRollResult").innerHTML = "Special Roll: "+result;
        console.log(result);
    }
    document.getElementById("RollResults").innerHTML = `<p>Roll 1: ${roll1} </p> <p>Roll 2: ${roll2} </p>`;
}

// For 6-sided dice, the application recognizes the following dice combinations and displays a message for each. It should not output this for any other size of dice.
// Snake Eyes: Two 1s
// Ace Deuce: A 1 and 2
// Box Cars: Two 6s
// Win: A total of 7 or 11
// Craps: A total of 2, 3, or 12 (will also generate another message!)
function GetSpecialRoll( roll1:number, roll2: number) : string{
    let total : number = roll2 + roll1;
    
    if(roll1 === 1 && roll2 === 1){
        return "Snake Eyes and Craps";
    }
    else if( (roll1 === 1 && roll2 ==2) || (roll1 === 2 && roll2 ===1) ){
        return "Ace Duece";
    }
    else if(roll1 === 6 && roll2 === 6 ){
        return "Box Cars and Craps";
    }
    else if(total === 7 || total === 11){
        return "Win!!"
    }
    else if( total === 3 ){
        return "Craps";
    }
    else{
        return "Not Special";
    }

}