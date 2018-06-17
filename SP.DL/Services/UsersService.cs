using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using SP.DAL.Models;
using SP.DL.Models;
using Microsoft.AspNetCore.Identity;

namespace SP.DL.Services
{
    public class UsersService : IUsersService
    {
        
        private readonly IMapper _mapper;
        private readonly IUserValidator<SPUser> _userValidator;
        private readonly IPasswordValidator<SPUser> _passwordValidator;
        private readonly IPasswordHasher<SPUser> _passwordHasher;
        private readonly SignInManager<SPUser> _signInManager;


        public UsersService(IMapper mapper, IUserValidator<SPUser> userValidator, IPasswordValidator<SPUser> passwordValidator, IPasswordHasher<SPUser> passwordHasher, SignInManager<SPUser> signInManager)
        {
            _mapper = mapper;
            _userValidator = userValidator;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
            _signInManager = signInManager;
        }

        public IQueryable<UserVM> Get()
        {

            var returnedList = new List<UserVM>();
            _repository.Get().ToList().ForEach(u =>
            {
                returnedList.Add(_mapper.Map<SPUser, UserVM>(u));
            });

            return returnedList.AsQueryable();
        }

        public UserVM GetByEmail(string email)
        {
            return _mapper.Map<SPUser, UserVM>(_repository.GetByEmail(email));
        }

        public Task<IdentityResult> Create(UserVM user, string password)
        {
            return _repository.Create(_mapper.Map<SPUser, UserVM>(user), password);
        }

        public async Task<IdentityResult> Delete(UserVM user)
        {
            return await _repository.Delete(_mapper.Map<SPUser, UserVM>(user));
        }

        public  async Task<IdentityResult> Update(UserVM user)
        {
            return await _repository.Update(_mapper.Map<SPUser, UserVM>(user));
        }

        public async Task<IdentityResult> ValidatePassword(UserVM user, string password)
        {
            var SPUser = _mapper.Map<SPUser, UserVM>(user);
           return await _passwordValidator.ValidateAsync(_repository.GetUserManager(), SPUser, password);
        }

        public async Task<IdentityResult> ValidateUser(UserVM user)
        {
            var SPUser = _mapper.Map<SPUser, UserVM>(user);
            return await _userValidator.ValidateAsync(_repository.GetUserManager(), SPUser);
        }

        public  string HashPassword(UserVM user, string password)
        {
            var SPUser = _mapper.Map<SPUser, UserVM>(user);
            return  _passwordHasher.HashPassword( SPUser, password);
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<SignInResult> PasswordSignInAsync(UserVM user, string password, bool lockoutOnFailure, bool isPersistent)
        {
            var SPUser = _mapper.Map<SPUser, UserVM>(user);
           return  await _signInManager.PasswordSignInAsync(SPUser, password,  isPersistent, lockoutOnFailure);
        }

    }

    public interface IUsersService
    {
        IQueryable<UserVM> Get();
        UserVM GetByEmail(string email);
        Task<IdentityResult> Create(UserVM user, string password);
        Task<IdentityResult> Delete(UserVM user);
        Task<IdentityResult> Update(UserVM user);
        Task<IdentityResult> ValidatePassword(UserVM user, string password);
        Task<IdentityResult> ValidateUser(UserVM user);
        string HashPassword(UserVM user, string password);
        Task SignOutAsync();
        Task<SignInResult> PasswordSignInAsync(UserVM user, string password, bool lockoutOnFailure, bool isPersistent);
    }
}
