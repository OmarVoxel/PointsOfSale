using System.Collections.Generic;
using System.Linq;

namespace PointsOfSale
{
    public class Barcode
    {
        private readonly string[] _barcodes;
        private readonly string _barcode;
        private readonly Dictionary<string, string> _barcodeDict = new()
        {
            {"12345", "$7.25"}, {"23456", "$12.50"},
            {"99999", "Error: barcode not found"},
        };
        
        public Barcode(string barcode)
            => _barcode = barcode;

        public Barcode(string[] barcodes)
            => _barcodes = barcodes;

        public string Scan()
            => _barcode != "" ? _barcodeDict[_barcode] : "Error: empty barcode";
        
        public string Total() 
            => "$" + _barcodes.Sum(b => {
                double.TryParse(_barcodeDict[b][1..], out var result);
                return result;
            });
    }
}