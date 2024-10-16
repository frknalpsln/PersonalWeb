using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Command.UpdateAbout
{
    public record UpdateAboutCommand(
        string Id,
        string Name,
        string Description): IRequest<Result<string>>;
}
