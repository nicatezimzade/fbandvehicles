namespace vehicles
{
    class Car : MotoredVehicle
    {

        public bool IsOn;
        public Car(string make, string model, int year):base(make,model,year)
        { }

        public string GetDetailedInfo(double fuelamount)
        {
            FuelAmount = fuelamount;
            return $"{GetDetailedInfo()}, {FuelAmount}";
        }
        public Car() { }

        public string Go(int distance)
        {
            if (IsOn)
            {
            if (FuelUsedPer100Km * distance / 100 <= FuelAmount)
                {
                return $"{distance} km mesafe qet edildi ! ";
                }
                else
                {
                return $"kifayet qeder yanacaq yoxdur ! ";
                }
            }
            else
            {
                return $"masin ise salinmayib";
            }
        }

        public bool TurnOn()
        {
            return IsOn = true;
        }

        public bool TurnOff()
        {
            return IsOn = false;
        }
    }
}
