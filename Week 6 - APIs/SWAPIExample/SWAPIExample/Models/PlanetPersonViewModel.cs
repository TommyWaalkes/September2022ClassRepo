namespace SWAPIExample.Models
{
    //A viewmodel exists purely to perform an action on a view, we are allowed only 1 at once per each view 
    //Or a collection of models where they're all the same. So view models are what you use when you need 2 totally unrelated models 
    //In the same page. 

    //In the view simply dump them into the same object and put in a property foreach model we want to look at. 
    public class PlanetPersonViewModel
    {
        public Planet World { get; set; }
        public SWPerson Person { get; set; }

        public int PlanetId { get; set; }
    }
}
