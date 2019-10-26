using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vlerx.Es.StoryBroker;
using Vlerx.InternalMessaging;
using Vlerx.SampleService.Customers.Commands;
using Vlerx.SampleService.Web.Customers;

namespace Vlerx.SampleService.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IStories _stories;
        readonly IQueryReader<CustomerViewModel> _queryReader;
        public CustomerController(IStories stories, IQueryReader<CustomerViewModel> queryReader)
        {
            _stories = stories;
            _queryReader = queryReader;
        }

        public IActionResult Register()
        {
            return View(new RegistrationViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrationViewModel viewModel)
        {
            var customerId = Guid.NewGuid().ToString();
            await _stories.Tell(new RegisterCustomer(
                customerId
                , viewModel.FirstName
                , viewModel.LastName
                , viewModel.Address
                , viewModel.PhoneNumber
            ));
            return RedirectToAction(nameof(All));
        }

        [HttpGet("Customer/Relocate/customerId")]
        public IActionResult Relocate(string customerId)
        {
            if (null == customerId)
                throw new ArgumentNullException(nameof(customerId));

            return View(new RelocationViewModel
            {
                CustomerId = customerId
            });
        }

        [HttpPost]
        public async Task<IActionResult> Relocate(RelocationViewModel viewModel)
        {
            await _stories.Tell(new RelocateCustomer(
                viewModel.CustomerId
                , viewModel.NewAddress
                , viewModel.NewPhoneNumber
            ));
            return RedirectToAction(nameof(All));
        }
        [HttpGet]
        public IActionResult All()
        {
            List<CustomerViewModel> Customers =
                _queryReader.Get(Queries.All).ToList();
            return View(Customers);
        }
    }
}