namespace NovertisPharma
{
    public class MedicineBase
    {
        private string medicineCode;
        public MedicineBase(string medcode)
        {
            MedicineCode = medcode;
        }
        public string MedicineCode
        {
            get { return medicineCode; }
            private set { medicineCode = value; }
        }
        
    }
}