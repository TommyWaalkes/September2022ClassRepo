function calcExponents(){
    clearTable();
    //Grab the value of the input field 
    //Use that to create our table 
    let node = document.getElementById("NumsInput");
    let num = node.value;

    for(let i = 0; i <= num; i++){
        // console.log("Number: " + i);
        // console.log("Square: "+ (i * i));
        // console.log("Cube: "+ (i * i *i));
        // console.log();
        //for each value of i this should put in a new row with the square and cube. 
        document.getElementById("ExpTable").innerHTML += `<tr> <td> ${i} </td> <td> ${i*i} </td> <td> ${i*i*i} </td>  </tr>`;
    }
}

function clearTable(){
    //we want to rest the table to just being the header row and no others
    document.getElementById("ExpTable").innerHTML = "<tr><th>Num</th><th>Square</th><th>Cube</th></tr>";
}