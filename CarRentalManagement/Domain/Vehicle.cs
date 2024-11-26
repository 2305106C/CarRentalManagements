namespace CarRentalManagement.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int RoleId { get; set; }
        public int ColourId { get; set; }

    }
}
