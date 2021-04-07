namespace NovertisPharma
{
    public class Sales : MedicineBase
    {
        private int quantitySold;
        private int plannedSales;
        private int actualSales;
        private string region;
        public Sales(string medCode, int quantitySold, int plannedSales, int actualSales, string region) : base(medCode)
        {
            QuantitySold = quantitySold;
            PlannedSales = plannedSales;
            ActualSales = actualSales;
            Region = region;
        }
        public string Region
        {
            get { return region; }
            private set { region = value; }
        }
        
        public int ActualSales
        {
            get { return actualSales; }
            private set {
                    if (value >= 0)
                    {
                        actualSales = value;  
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
        }
        
        public int PlannedSales
        {
            get { return plannedSales; }
            private set {
                    if (value >= 0)
                    {
                        plannedSales = value; 
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
        }
        
        public int QuantitySold
        {
            get { return quantitySold; }
            private set {
                    if (value >= 0)
                    {
                        quantitySold = value; 
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
        }

        public void Display()
        {
            System.Console.Write($"Medicine Code: {MedicineCode}\nQuantity sold: {QuantitySold}\nPlanned sales: {PlannedSales}\nActual sales: {ActualSales}\nRegion: {Region}");
        }

        public void Display(string medCode)
        {
            if (medCode == MedicineCode)
            {
                System.Console.Write($"Difference between actual sales and planned sales: {System.Math.Abs(PlannedSales - ActualSales)}");
            }else
            {
                System.Console.Write("Match not found");
            }
            
        }
        
    }
}