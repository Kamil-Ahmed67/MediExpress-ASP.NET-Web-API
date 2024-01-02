using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password)
        {
            var res= DataAccessFactory.AuthData().Authenticate(username, password);
            if (res)
            {
                var token = new Token();
                token.UserId = username;
                token.CreatedAt = DateTime.Now;
                token.TokenKey =Guid.NewGuid().ToString();
                var ret=DataAccessFactory.TokenData().Create(token);
                if (ret != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                       c.CreateMap<Token,TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(ret);
                }
            }
            return null;
        }

    }
}
