using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace PersonalWeb.Business.Features.AboutEntity.Command.CreateAbout
{
    public record CreateAboutCommand(
        string Name,
        string Description) : IRequest<Result<string>>;


}
