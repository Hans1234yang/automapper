using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace automapper2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.单个实体不同属性的转换
            VM_Address dto2 = new VM_Address
            {
                Country="中国",
                City666="重庆"
            };
                                                                                  //类的城市               //dto的类
            Mapper.Initialize(m=>m.CreateMap<VM_Address,TAddress>().ForMember(x=>x.City,opt=>opt.MapFrom(o=>o.City666)));

            TAddress address2 = Mapper.Map<VM_Address,TAddress>(dto2);
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
