﻿using BookStore.DTOs.Response;

namespace BookStore.Service.VNPayService
{
    public interface IVNPayService
    {
        Task<ResponseDTO> CreateUrlPayment(int orderId, double total);
        Task<ResponseDTO> ReturnPayment(IQueryCollection vnpayData);
    }
}
