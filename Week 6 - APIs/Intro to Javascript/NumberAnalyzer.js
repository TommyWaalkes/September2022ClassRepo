//Javascript has 3 1/2 loops 
//1) For - useful for arrays most common loop 
//2) while - same behavior as C# 
//3) do...while 

//4) foreach, but its a method and not a loop <-tends to be cumbersome, I prefer avoiding esp coming C# 

let goOn = true; 

while(goOn === true){
    console.log("Welcome to the number analyzer"); 
    let input = prompt("please input a number between 1 and 100"); 

    if(input >= 1 && input <= 100){
        let isEven = input % 2 === 0; 

        if(isEven == true){
            if(input >= 2 && input <= 24)
            {
                console.log("Even and less than 25.");
            }
            else if(input <=60){
                console.log("Even and between 26 and 60 inclusive.")
            }
            else{
                console.log("Even and greater than 60.")
            }
        }
        else{
            //this'll be for our odd nums
            if(input < 60){
                console.log( "Odd and less than 60.");
            }
            else if(input >60){
                console.log( "Odd and greater than  60.");
            }
        }
    }
    else{
        console.log("That number was outside our range, please input another number between 1 and 100");
    }  

    goOn = keepRunning();
}

//in Javascript all identifiers - variable names, method names, and class names are in camelCase
function keepRunning(){
    let answer = prompt("Would you like to input another number? Y/N"); 

    if(answer.toLowerCase() === "n"){
       return false;
    }
    else if(answer === "y"){
        return true;
    }
    else{
        console.log("I'm sorry I didn't understand that let's try again");
        return keepRunning();
    }
}