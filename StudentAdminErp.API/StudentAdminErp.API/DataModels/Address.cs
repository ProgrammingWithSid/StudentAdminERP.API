using System;

namespace StudentAdminErp.API.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }

        public string Physicaladdress { get; set; }

        public string PostalAddress { get; set; }

        //Navigation Property

        public Guid StudentId { get; set; }
    }
}
