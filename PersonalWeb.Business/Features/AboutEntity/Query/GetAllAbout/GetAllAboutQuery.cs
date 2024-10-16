using MediatR;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Query.GetAllAbout
{
    public record GetAllAboutQuery() : IRequest<Result<List<About>>>;
}
