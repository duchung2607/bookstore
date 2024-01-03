﻿using BookStore.Service.VNPayService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VnPayController : ControllerBase
    {
        private readonly IVNPayService _vnPayService;
        public VnPayController(IVNPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUrlPayment(int orderId, double total)
        {
            var resData = await _vnPayService.CreateUrlPayment(orderId, total);
            return StatusCode(resData.Code, resData);
        }
        [HttpGet()]
        public async Task<IActionResult> ReturnPayment()
        {
            var vnpayData = Request.Query;
            var resData = await _vnPayService.ReturnPayment(vnpayData);
            return StatusCode(resData.Code, resData);
        }
    }
}
