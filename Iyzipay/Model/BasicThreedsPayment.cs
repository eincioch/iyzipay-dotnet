using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class BasicThreedsPayment : BasicPaymentResource
    {
        public static BasicThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
