using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public class RentalModel
    {
        public string LandlordName { get; set; } = string.Empty;
        public string LandlordAddrLine1 { get; set; } = string.Empty;
        public string LandlordAddrLine2 { get; set; } = string.Empty;
        public string LandlordAddrCity { get; set; } = string.Empty;
        public string LandlordAddrState { get; set; } = string.Empty;
        public string LandlordAddrPostal { get; set; } = string.Empty;
        public string LandlordPhone { get; set; } = string.Empty;
        public string TenantName { get; set; } = string.Empty;
        public string TenantEmail { get; set; } = string.Empty;
        public string TenantPhone { get; set; } = string.Empty;
        public string TenantOccupants { get; set; } = string.Empty;


    }
    public class Rentallist
    {
        public static List<RentalModel> objListData = new List<RentalModel>()
            {
                 new RentalModel
            {
                LandlordName = "John Doe",
                LandlordAddrLine1 = "123 Elm Street",
                LandlordAddrLine2 = "Apt 4B",
                LandlordAddrCity = "Springfield",
                LandlordAddrState = "IL",
                LandlordAddrPostal = "62701",
                LandlordPhone = "555-123-4567",
                TenantName = "Jane Smith",
                TenantEmail = "jane.smith@example.com",
                TenantPhone = "555-987-6543",
                TenantOccupants = "2"
            },
            new RentalModel
            {
                LandlordName = "Emily Johnson",
                LandlordAddrLine1 = "456 Oak Avenue",
                LandlordAddrLine2 = "",
                LandlordAddrCity = "Shelbyville",
                LandlordAddrState = "IL",
                LandlordAddrPostal = "62565",
                LandlordPhone = "555-234-5678",
                TenantName = "Michael Brown",
                TenantEmail = "michael.brown@example.com",
                TenantPhone = "555-876-5432",
                TenantOccupants = "3"
            },
            new RentalModel
            {
                LandlordName = "Robert Davis",
                LandlordAddrLine1 = "789 Pine Road",
                LandlordAddrLine2 = "Unit 12",
                LandlordAddrCity = "Capital City",
                LandlordAddrState = "IL",
                LandlordAddrPostal = "62704",
                LandlordPhone = "555-345-6789",
                TenantName = "Sarah Wilson",
                TenantEmail = "sarah.wilson@example.com",
                TenantPhone = "555-765-4321",
                TenantOccupants = "1"
            }
            };

    }
}
