namespace vehicles
{
    class MotoredVehicle
    {
        public string Make;
        public string Model;
        public int ProductionYear;
        public double MotorSize;
        public int FuelTankSize;
        public double FuelAmount;
        public double FuelUsedPer100Km;
        public string Colour;
        public string Transmission;
        public double HorsePower;
        public int PassangerCount;

        public MotoredVehicle() { }

        public MotoredVehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            ProductionYear = year;
        }

        public string GetInfo()
        {
            return $"{Make}, {Model}, {ProductionYear}";
        }

        public string GetDetailedInfo()
        {
            return $"{GetInfo()}, {MotorSize}, {FuelTankSize}, {FuelUsedPer100Km}, {Colour}, {Transmission}, {HorsePower}, {PassangerCount}";
        }

    }

}
