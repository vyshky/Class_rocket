namespace Class_rocket
{
    public class Military_missiles : Rocket
    {
        public string Guided_missile_class { get; set; }
        public string Guidance_system { get; set; }

        public Military_missiles()
        {
        }
        
        public Military_missiles(ref string Guided_missile_class,ref string Guidance_system, 
            ref string Name,ref int Speed,ref double Fuel,ref string Type_of_fuel,ref double Range_of_action)
            : base(ref Name,ref Speed,ref Fuel,ref Type_of_fuel,ref Range_of_action)
        {
            this.Guided_missile_class = Guided_missile_class;
            this.Guidance_system = Guidance_system;
        }
        
        public Military_missiles(Rocket rocket)
        {
            Name = rocket.Name;
            Speed = rocket.Speed;
            Fuel = rocket.Fuel;
            Type_of_fuel = rocket.Type_of_fuel;
            Range_of_action = rocket.Range_of_action;
            count++;
        }
    }
}