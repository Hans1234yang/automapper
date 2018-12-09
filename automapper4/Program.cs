using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automapper4
{
    class Program
    {
        //automapper 4
        static void Main(string[] args)
        {
            //实体包含不同类型属性转换，忽略属性

            //联系列表
            var contacts = new List<TContactInfo>()
            {
             new TContactInfo()
             {
                Blog="hansblog",
                Email="han@qq.com"
             },
             new TContactInfo()
             {
                 Blog="jackblog",
                 Email="jack@qq.com"
             }
            };

            //联系人表
            TAuthor author1 = new TAuthor()
            {
                Description = "小杨的描述",
                Name = "杨先生",
                ContactInfo = contacts
            };

            Mapper.Initialize(m =>
            {
                m.CreateMap<TContactInfo, VM_ContactInfo>();   //不同类型实体转换
                m.CreateMap<TAuthor, VM_Author>().ForMember(x => x.ContactInfo, opt => opt.MapFrom(o => o.ContactInfo));  //制定mapform 是很重要的
            });

            VM_Author authorDto = Mapper.Map<TAuthor, VM_Author>(author1);

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

    //联系人信息
    public class TContactInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Blog { get; set; }
        public string Twitter { get; set; }
    }
}
