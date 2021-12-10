using System;
using Xunit;
using FluentAssertions;
using PointsOfSale;

namespace PointOfSale.Test
{
    public class BarcodeTests
    {
        [Fact]
        public void Barcode12345display7_25dollars()
        {
            Barcode barcode = new Barcode("12345");
            
            barcode.Scan().Should().Be("$7.25");
        }
        

        [Fact]
        public void Barcode23456display12_50dollars()
        {
            Barcode barcode = new Barcode("23456");
            
            barcode.Scan().Should().Be("$12.50");
        }
        
        [Fact]
        public void Barcode99999displayErrorBarcodeNotFound()
        {
            Barcode barcode = new Barcode("99999");
            
            barcode.Scan().Should().Be("Error: barcode not found");
        }

        
        [Fact]
        public void EmptyBarcodeDisplayErrorEmptyBarcode()
        {
            Barcode barcode = new Barcode("");
            
            barcode.Scan().Should().Be("Error: empty barcode");
        }

    }
}