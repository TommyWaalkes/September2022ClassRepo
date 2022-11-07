class Product{
    name;
    cost; 

    constructor(name, cost){
        this.name = name; 
        this.cost = cost;
    }
}

//This inits an empty array, remember in JS arrays are loosely typed, anything can go in, anything can come out 
//They are also dynamically sized like C# lists 
//JS really only has arrays for collections, they are meant to fill every role collections would
cart = [];

products = [new Product("spam", 3.99), new Product("bananas", 1.99), new Product("cabbage", .89)];

function addToCart(index){
    let selected = products[index];

    //Push is the same as Add in C# lists, push is a method for adding to a stack, JS has push and pops functions to allow you 
    //to simulate Stacks
    cart.push(selected);
    console.log(cart);
}

function checkout(){
    let total = 0; 
    //this should override what was there with the empty string 
    //this is so we can remove what was there previously 
    document.getElementById("SubTotal").innerHTML ="";
    for(let i = 0; i < cart.length; i++){
        let p = cart[i]; 
        console.log(p);
        total += p.cost;
        //We use += to add onto the element and NOT overwrite it 
        document.getElementById("SubTotal").innerHTML += `<p>Item: ${p.name} Cost: ${p.cost} </p> 
        <button onClick="removeItem( ${i})"> Remove ${p.name}  </button>`;

    }

    console.log(total);

    //There are many dom methods, but this is the most commonly used. Ids are meant to appear once per page so this grabs only one element 
    //You may also grabs by HTML tag (IE all p tags ) or by css class name, but both will return arrays as they are able to appear more than once
    //The class name and HTML tag calls tend to be used more for altering CSS, where Id is useful for inputting and outputting data.

    //There are 2 properties availiable to perform DOM manipulation, 
    //innerHTML and innerText - innerHTML allows for editing/overriding of the HTML, innerText only changes the text and leaves the HTML alone

    let outputTotal = Math.round(total *100)/100;
    document.getElementById("Total").innerHTML = `<h2>Total: $ ${outputTotal}</h2>`;
}

function removeItem( index){
    cart.splice(index, 1);

    //To redisplay the cart and it's new subtotal recall checkout 
    checkout();
}