using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automapper1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. automapper 单个模型转化
            VM_Address dtoAddress = new VM_Address
            {
                Country = "中国",
                City = "深圳"
            };

            //初始化automapper规则
            Mapper.Initialize(m => m.CreateMap<VM_Address, TAddress>());

            TAddress address1 = Mapper.Map<VM_Address, TAddress>(dtoAddress);


            Console.ReadLine();

        }
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
}
