function login(){
    let password = document.getElementById("Password").value;

    let longEnough = password.length >= 7;
    let hasNum = false; 
    for(let i = 0; i < 10; i++){
        if(password.includes(i)){
            hasNum = true; 
            break; 
        }
    }
    let passOrWord = password.includes("pass") || password.includes("word");

    if(longEnough && hasNum && passOrWord){
        console.log("Validation worked");

        //I use the = and not += so as to overwrite any previous errors we saw.
        document.getElementById("Output").innerHTML = "<p> Login Successful! </p>";
    }
    else{
        document.getElementById("Output").innerHTML = "<p> Login Failed! See below for details </p>";
    }

    if(!longEnough){
        document.getElementById("Output").innerHTML += `<p> your Password was not long enough at ${password.length} characers, the minimum is 7, I know typing is very difficult</p>`;
    }
    if(!hasNum){
        document.getElementById("Output").innerHTML += `<p> Your password lacks numbers, it is ${password} and is pretty lame </p>`;
    }
    if(!passOrWord){
        document.getElementById("Output").innerHTML += `<p> You don't have pass or word in your lame password of ${password}</p>`;
    }


}