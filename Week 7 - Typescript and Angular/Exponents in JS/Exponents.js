function calcExponents(){
    //Grab the value of the input field 
    //Use that to create our table 
    let node = document.getElementById("NumsInput");
    let num = node.value;

    for(let i = 0; i <= num; i++){
        console.log("Number: " + i);
        console.log("Square: "+ (i * i));
        console.log("Cube: "+ (i * i *i));
        console.log();

        document.getElementById("ExpTable").innerHTML;
    }

}