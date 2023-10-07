using FMSS.Application.Configuration.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using FMSS.Domain.Entities.UserApplication;
using FMSS.Application.Configuration.Data;

namespace FMSS.Application.UserApplications.Commands.CreateUser
{
    public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepo _userRepo;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IUserRepo userRepo, IUnitOfWork unitOfWork)
        {
            _userRepo = userRepo;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user =UserApplication.CreateRegistered(request.Email, request.Department,request.Region,request.Password,request.RoleId, request.Username);
            await this._userRepo.Insert(user);
            await this._unitOfWork.SaveChangesAsync();
            return user.Id.Value;
        }
    }
}
