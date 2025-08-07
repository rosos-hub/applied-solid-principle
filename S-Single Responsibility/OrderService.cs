namespace AppliedSOLIDPrinciple.SRP
{
    /// <summary>
    /// Single Responsibility: Orchestrating the order process
    /// This new class orchestrates the process, delegating each specific task to the appropriate class. 
    /// This class's single responsibility is to coordinate the order processing workflow.
    /// </summary>
    public class OrderService
    {
        private readonly OrderValidator _orderValidator;
        private readonly OrderRepository _orderRepository;
        private readonly EmailService _emailService;
        public OrderService(
            OrderValidator orderValidator,
            OrderRepository orderRepository,
            EmailService emailService)
        {
            _orderValidator = orderValidator;
            _orderRepository = orderRepository;
            _emailService = emailService;
        }

        public void ProcessOrder(OrderModel orderModel)
        {
            if (_orderValidator.Validate(orderModel))
            {
                _orderRepository.Save(orderModel);
                _emailService.Send(orderModel);
            }
        }
    }
}
