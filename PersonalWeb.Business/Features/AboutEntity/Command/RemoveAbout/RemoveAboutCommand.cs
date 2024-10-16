using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Command.RemoveAbout
{
    public record RemoveAboutCommand(
       string Id) : IRequest<Result<string>>;
}
