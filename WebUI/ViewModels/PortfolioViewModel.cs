using Microsoft.AspNetCore.Http;
using System;

namespace WebUI.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ProjectImg { get; set; }
        public string Url { get; set; }
        public IFormFile File { get; set; }
    }
}
