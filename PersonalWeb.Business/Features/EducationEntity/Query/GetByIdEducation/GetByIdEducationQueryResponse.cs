namespace PersonalWeb.Business.Features.EducationEntity.Query.GetByIdEducation
{
    public record GetByIdEducationQueryResponse(
         string Name,
         string Department,
         DateTime StartDate,
         DateTime EndDate);
}
