export interface ToDo {
    //We want to mirror the JSON properties of our C# api 
    //meaning all our properties should be lowercased 
    id: number;
    description: string;
    iscompleted:boolean;
}
