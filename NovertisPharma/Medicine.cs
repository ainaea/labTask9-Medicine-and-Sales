namespace NovertisPharma
{
    public class Medicine : MedicineBase
    {
        private string medicineName;
        private string manufacturerName;
        private decimal unitPrice;
        private int quantityInStock;
        private Date manufactureDate;
        private Date expiryDate;
        private string batchNumber;
        public Medicine(string medCode, string medName, string manName, decimal price, int quantity, Date manDate, Date expDate, string batchNum) : base(medCode)
        {
            MedicineName = medName;
            ManufacturerName = manName;
            UnitPrice = price;
            QuantityInStock = quantity;
            ManufactureDate = manDate;
            ExpiryDate = expDate;
            BatchNumber = batchNum;
        }
        public string BatchNumber
        {
            get { return batchNumber; }
            set { batchNumber = value; }
        }
        
        public Date ExpiryDate
        {
            get { return expiryDate; }
            private set { expiryDate = value; }
        }
        
        public Date ManufactureDate
        {
            get { return manufactureDate; }
            private set { manufactureDate = value; }
        }
        
        public int QuantityInStock
        {
            get { return quantityInStock; }
            private set { 
                    if (value >=0)
                    {
                        quantityInStock = value; 
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException();                    
                    }
                }
        }
        
        public decimal UnitPrice
        {
            get { return unitPrice; }
            private set { 
                    if (value > 0)
                    {
                        unitPrice = value;
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException();
                    } 
                }
        }

        public string ManufacturerName
        {
            get { return manufacturerName; }
            private set { manufacturerName = value; }
        }
        
        public string MedicineName
        {
            get { return medicineName; }
            private set { medicineName = value; }
        }

        public void Print()
        {
            System.Console.Write($"Medicine Code: {MedicineCode}\nMedicine name: {MedicineName}\nManufacturer name: {ManufacturerName}\nUnit price: {UnitPrice:C}\nQuantity in Stock: {QuantityInStock}\nManufacture date: {ManufactureDate}\nExpiry date: {ExpiryDate}\nBatch number: {BatchNumber}");
        }

        public void Print(string medCode)
        {   if (medCode == MedicineCode)
            {
                System.Console.Write($"Quantity in Stock: {QuantityInStock}");           
            }else
            {
                System.Console.Write($"Medicine code not a match");            
            }
        }

        public void Print(string medCode, string medName)
        {   if (medCode == MedicineCode && medName == MedicineName)
            {
                System.Console.Write($"Manufacture date: {ManufactureDate}\nExpiry date: {ExpiryDate}");           
            }else
            {
                System.Console.Write($"Medicine code and name not a match");            
            }
        }

        public void Restock()
        {
            if (QuantityInStock == 0)
            {
                QuantityInStock = 50;
                System.Console.Write($"{QuantityInStock} {MedicineName} now in stock");                

            }else
            {
                System.Console.Write($"{QuantityInStock} {MedicineName} still in stock");                       
            }
        }
        
    }
}