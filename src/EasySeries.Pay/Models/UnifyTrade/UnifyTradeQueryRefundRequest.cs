﻿namespace EasySeries.Pay.Models.UnifyTrade;

/// <summary>
/// 中信全付通查询退款.
/// </summary>
public class UnifyTradeQueryRefundRequest : UnifyTradeSign
{
    /// <summary>
    /// 服务.
    /// </summary>
    [JsonProperty("service")]
    public string Service { get; } = "unified.trade.refundquery";

    /// <summary>
    /// 商户号.
    /// </summary>
    [JsonProperty("mch_id")]
    public string MchId { get; set; }

    /// <summary>
    /// 商户单号.
    /// </summary>
    [JsonProperty("out_trade_no")]
    public string OutTradeNo { get; set; }

    /// <summary>
    /// 退款单号.
    /// </summary>
    [JsonProperty("out_refund_no")]
    public string OutRefundNo { get; set; }
}