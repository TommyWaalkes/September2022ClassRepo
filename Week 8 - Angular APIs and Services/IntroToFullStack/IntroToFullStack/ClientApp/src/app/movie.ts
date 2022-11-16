export interface Movie {
    //The properties need to match what the JSON returns in our C# API 
    //and NOT the C# model 
    //Generally the JSON from C# lowercases all of the property names 
    id : number;
    title: string;
    genre:string;
    runtime:number;
}
