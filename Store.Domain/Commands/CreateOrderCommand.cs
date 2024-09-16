using Flunt.Notifications;
using Flunt.Validations;
using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Commands
{
    public class CreateOrderCommand : Notifiable, ICommand
    {

        public CreateOrderCommand()
        {
            Items = [];
        }

        public CreateOrderCommand(string customer, string zipCode, string promoCode, IList<CreateOrdemItemCommand> items)
        {
            Customer = customer;
            ZipCode = zipCode;
            PromoCode = promoCode;
            Items = items;
        }

        public string Customer { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string PromoCode { get; set; } = string.Empty;
        public IList<CreateOrdemItemCommand> Items { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasLen(Customer, 11, "Customer", "Cliente Inválido")
                .HasLen(ZipCode, 8, "ZipCode", "CEP inválido"));
        }
    }
}
