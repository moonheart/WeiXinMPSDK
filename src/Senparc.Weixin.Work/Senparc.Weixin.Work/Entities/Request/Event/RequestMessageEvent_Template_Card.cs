using System.Collections.Generic;
using Senparc.NeuChar.Entities;

namespace Senparc.Weixin.Work.Entities
{
    /// <summary>
    /// 模板卡片事件推送
    /// </summary>
    public class RequestMessageEvent_Template_Card : RequestMessageEventBase, IRequestMessageEventKey
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event => Event.TEMPLATE_CARD_EVENT;


        /// <summary>
        /// 事件KEY值，与自定义菜单接口中KEY值对应
        /// </summary>
        public string EventKey { get; set; }

        /// <summary>
        /// 与发送模板卡片消息时指定的task_id相同
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// 通用模板卡片的类型，类型有"text_notice", "news_notice", "button_interaction", "vote_interaction", "multiple_interaction"五种
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// 用于调用更新卡片接口的ResponseCode，72小时内有效，且只能使用一次
        /// </summary>
        public string ResponseCode { get; set; }
        
        /// <summary>
        /// 用户选择项
        /// </summary>
        public List<SelectedItem> SelectedItems { get; set; }
    }
}