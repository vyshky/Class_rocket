namespace Class_rocket
{
    public partial class Rocket
    {
        static Rocket()
        {
            Class = "Ракета";
        }

        public Rocket()
        {
            Name = "Null";
            Speed = 0;
            Fuel = 0;
            Type_of_fuel = "Null";
            Range_of_action = 0;
            count++;
        }

        public Rocket(ref string name)
        {
            Name = name;
            Speed = 0;
            Fuel = 0;
            Type_of_fuel = "Null";
            Range_of_action = 0;
            count++;
        }

        public Rocket(ref string name, ref int speed, ref double fuel, ref string type_of_fuel,
            ref double range_of_action)
        {
            Speed = speed;
            Fuel = fuel;
            Type_of_fuel = type_of_fuel;
            Range_of_action = range_of_action;
            count++;
        }

        public Rocket(Rocket rocket)
        {
            Name = rocket.Name;
            Speed = rocket.Speed;
            Fuel = rocket.Fuel;
            Type_of_fuel = rocket.Type_of_fuel;
            Range_of_action = rocket.Range_of_action;
            count++;
        }

        public string get_Class
        {
            get => Class;
        }
        public int get_Count
        {
            get => count;
        }
    }
}