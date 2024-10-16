using MediatR;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Entities.Concrete;
using TS.Result;

namespace PersonalWeb.Business.Features.EducationEntity.Query.GetByIdEducation
{
    internal class GetByIdEducationQueryHandler(IEducationServices _educationServices) : IRequestHandler<GetByIdEducationQuery, Result<GetByIdEducationQueryResponse>>
    {
        public async Task<Result<GetByIdEducationQueryResponse>> Handle(GetByIdEducationQuery request, CancellationToken cancellationToken)
        {
            Education education = await _educationServices.GetById(request.Id);

            if (education is null)
            {
                return Result<GetByIdEducationQueryResponse>.Failure("Education Bulunamadı");
            }
            return new GetByIdEducationQueryResponse(
                   education.Name,
                   education.Department,
                   education.StartDate,
                   education.EndDate);
        }
    }

}
