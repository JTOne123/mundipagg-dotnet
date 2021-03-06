﻿using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Merchant manager
    /// </summary>
    public interface IMerchantResource : IResource
    {
        /// <summary>
        /// Get merchant info
        /// </summary>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, ErrorsResponse> GetMerchant(string merchantId);

        /// <summary>
        /// Cretes a new merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, ErrorsResponse> CreateMerchant(CreateMerchantRequest request);

        /// <summary>
        /// Update a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, ErrorsResponse> UpdateMerchant(string merchantId, UpdateMerchantRequest request);

        /// <summary>
        /// Update status of a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, ErrorsResponse> UpdateMerchantStatus(string merchantId, UpdateMerchantStatusRequest request);
    }
}