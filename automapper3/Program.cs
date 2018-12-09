using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace automapper3
{
    class Program
    {
        static void Main(string[] args)
        {

            //3.集合转换
            TAddress address1 = new TAddress()
            {
                Country="中国",
                City="深圳"
            };

            TAddress address2 = new TAddress()
            {
                Country = "中国",
                City = "成都"
            };


            List<TAddress> addressesList = new List<TAddress>()
            {
                address1,
                address2
            };

            Mapper.Initialize(m => m.CreateMap<TAddress, VM_Address>());  //仅仅需要配置 实体间转化，而非集合转化

            List<VM_Address> AddressDto = Mapper.Map<List<TAddress>, List<VM_Address>>(addressesList);

            Console.ReadLine();
        }
    }


    public class VM_Address
    {
        public string Country { get; set; }
        public string City { get; set; }

        public string City666 { get; set; }
    }
    public class VM_Author
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<VM_ContactInfo> ContactInfo { get; set; }
    }

    public class VM_ContactInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Blog { get; set; }
        public string Twitter { get; set; }
    }

    public class TAddress
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string CreateTime { get; set; }
        public int CreateUserId { get; set; }
    }

    public class TAuthor
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public List<TContactInfo> ContactInfo { get; set; }

    }
    public class TContactInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Blog { get; set; }
        public string Twitter { get; set; }
    }
}
