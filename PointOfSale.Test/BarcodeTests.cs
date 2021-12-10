using System;
using Xunit;
using FluentAssertions;
using PointsOfSale;

namespace PointOfSale.Test
{
    public class BarcodeTests
    {
        [Fact]
        public void Barcode12345display725dollars()
        {
            Barcode barcode = new Barcode("12345");

            barcode.Scan();
            
            barcode.Should().Be("$7.25");
        }
    }
}