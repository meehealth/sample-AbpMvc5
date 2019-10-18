using Abp.Web.Mvc.Views;

namespace AbpMvc5.Web.Views
{
    public abstract class AbpMvc5WebViewPageBase : AbpMvc5WebViewPageBase<dynamic>
    {

    }

    public abstract class AbpMvc5WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpMvc5WebViewPageBase()
        {
            LocalizationSourceName = AbpMvc5Consts.LocalizationSourceName;
        }
    }
}