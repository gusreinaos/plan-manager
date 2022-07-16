using MediatR;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Domain.Services.Validations;

public class ValidateUserServiceHandler : IRequestHandler<ValidateUserService, bool>
{

    private readonly IUserRepository _userRepository;

    public ValidateUserServiceHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<bool> Handle(ValidateUserService request, CancellationToken cancellationToken)
    {
        var user = _userRepository.GetUserById(request.Id);
        return user != null;
    }
}