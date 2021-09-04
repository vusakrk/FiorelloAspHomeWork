using FiorelloAsp.Models;
using FiorelloAsp.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.ViewModel
{
    public class HomeViewModel
    {
        public List<Slide> Slides { get; set; }
        public Introduction Introduction { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public About About { get; set; }
        public List<AboutInfo> AboutInfos { get; set; }
        public List<Expert> Experts { get; set; }
        public List<Role> Roles { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Tastimonial> Tastimonials { get; set; }
        public List<Instagram> Instagrams { get; set; }
        public InstagramHashtag instagramHashtag { get; set; }
        public Subscribe Subscribe { get; set; }
        public FooterSocial FooterSocial { get; set; }

    }
}
