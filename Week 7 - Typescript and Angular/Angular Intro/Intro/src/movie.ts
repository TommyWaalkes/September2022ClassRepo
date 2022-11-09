//Export is similar to public in C#, it makes it availiable for the rest of the project to import 
//Models in Angular are mostly a series of properties, you maybe will put in a conversion function or two
export interface Movie{
    id : number;
    title :string;
    runTime :number;
    genre:string;
    isKidFriendly:boolean;
}