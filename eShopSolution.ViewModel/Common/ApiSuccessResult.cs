using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T result)
        {
            IsSuccessed = true;
            ResultObject = result;
        }

        public ApiSuccessResult()
        {
            IsSuccessed = true;
        }
    }
}