using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Query.GetByIdAbout
{
    public record GetByIdAboutQuery(
        string Id) : IRequest<Result<GetByIdAboutQueryResponse>>;
}
