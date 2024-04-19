﻿
namespace ShippingProAPICollection.Models.Error
{
    public enum ShippingErrorCode
    {
        UNKNOW = 9999,
        UNAUTHORIZED,
        TO_MANY_REQUESTS,
        INTERNAL_SERVER_ERROR,
        BAD_REQUEST_ERROR,
        CANNOT_CONVERT_RESPONSE,
        DPD_LOGIN_ERROR,
        DPD_SHIPMENT_REQUEST_ERROR,
        NOT_AVAILABLE,
        GLS_INCOTERM_ERROR,
        GLS_PRODUCT_CANNOT_USE_ERROR,
        GLS_NEXT_DAY_NOT_SATURDAY_ERROR,
        GLS_ROUTING_ERROR,
        GLS_POSTCODE_ERROR,
        GLS_WEIGHT_ERROR,
        GLS_ARTICLE_COMBINATIONS_ERROR,
        GLS_COMMON_ERROR,
        GLS_ARTICLE_DESTINATION_EXCLUSION_ERROR,
    }
}
