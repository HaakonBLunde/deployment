using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace sykeplayer_1.Models
{
    public class gameModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            throw new System.NotImplementedException();
        }
    }
}