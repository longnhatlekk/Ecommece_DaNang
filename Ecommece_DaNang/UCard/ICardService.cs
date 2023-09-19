using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;

namespace Ecommece_DaNang.UCard
{
    public interface ICardService
    {
        public void Addtocard(CardModel card,int UserId);
        public Task<List<ViewCart>> ViewCard(int UserId);
        public void updateCard(Updatequantity update, int UserId);
        
    }
}
