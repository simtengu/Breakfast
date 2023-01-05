
namespace Breakfast.Models
{
    public record BreakfastM (
            string Name,
            string Description,
            DateTime StartDateTime,
            DateTime EndDateTime,
            Uri Image,
            List<string> Savory,
            List<string> Sweet
            );


        
}
