using System;

namespace PointsOfSale
{
    public class Barcode
    {
        private readonly string _barcode;

        public Barcode(string barcode)
            => _barcode = barcode;
        
        public string Scan()
        {
            if (_barcode == "12345")
                return "$7.25";

            if (_barcode == "23456")
                return "$12.50";

                    
            return "";

        }
    }
}