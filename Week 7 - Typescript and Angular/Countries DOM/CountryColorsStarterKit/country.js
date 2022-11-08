class Country {
    constructor(name, lang, greeting, colors, flagURL) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
        this.flagURL = flagURL;
    }
}
let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"], "USAFlag.webp");
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"], "Flag-Mexico.webp");
// let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["blue", "yellow", "red"]);
// let france = new Country("France", "French", "Bon Jour", ["blue", "yellow"]);


function SwitchCountry() {
    
    
    let input = document.getElementById("CountryList").value; 
    let country;

    if (input === "USA") {
        //set country to usa 
        country = usa;
    }
    else if (input === "Mexico") {
        country = mexico;
    }
    else if (input === "Algeria") {
        country = algeria;
    }
    else if(input === "France"){
        country = france;
    }

    document.getElementById("CountryName").innerText = country.name; 
    document.getElementById("OfficialLanguage").innerText = country.lang; 
    document.getElementById("HelloWorld").innerText = country.greeting; 

    document.getElementById("Color1").style = "background-color: "+ country.colors[0];

    if(country.colors.length === 2){
        document.getElementById("Color2").style = "background-color: "+ country.colors[1];
        document.getElementById("Color3").style = "background-color: "+ country.colors[1];
    }
    else if(country.colors.length === 3){
        document.getElementById("Color2").style = "background-color: "+ country.colors[1];
        document.getElementById("Color3").style = "background-color: "+ country.colors[2];
    }

    document.getElementById("FlagImage").setAttribute("src", country.flagURL);
}


