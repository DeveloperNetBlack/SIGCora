using MediatR;
using SIGCora.DomainModel.Model;
using SIGCora.DomainService.IRepositories.ICategoryRepositories;
using SIGCora.DomainService.IServices;
using SIGCora.Infrastructure.CrossCutting.Constants;
using SIGCora.Infrastructure.CrossCutting.Wrappers;

namespace SIGCora.ApplicationService.Features.CategoryFeatures.Commands.CategoryCreate
{
    internal class CategoryCreateCommandHandler(
        ICategoryCreateRepository CategoryCreateRepository,
        ICategoryValidateRepository CategoryValidateRepository,
        IMessageService MessageService,
        ICurrentSessionService CurrentSessionService
    ) : IRequestHandler<CategoryCreateCommandRequest, MsgResponse<object>>
    {
        public async Task<MsgResponse<object>> Handle(CategoryCreateCommandRequest Request, CancellationToken CancellationToken)
        {
            var MsgResponse = new MsgResponse<object>();
            try
            {
                var Model = Category.Create(
                        Request.CategoryName,
                        Request.StateId,
                        CurrentSessionService.UserID
                    );

                var Validate = await CategoryValidateRepository.ValidateAsync(Model, CancellationToken);
                if (Validate == VerifyRegistryConst.Category.OK)
                {
                    int RecordAffected = await CategoryCreateRepository.CreateAsync(Model, CancellationToken);
                    if (RecordAffected > 0)
                    {
                        MsgResponse.Type = MessageTypeConst.SUCCESS;
                        MsgResponse.Message = MessageService.GetMessageResult(MessageDescriptionConst.SATISFACTORY_INSERT);
                        MsgResponse.Data = new
                        {
                            Model.CategoryId,
                            Model.CategoryName,
                            Model.StateID,
                            Model.CreateDate,
                        };
                    }
                    else
                    {
                        MsgResponse.Type = MessageTypeConst.ERROR;
                        MsgResponse.Message = MessageService.GetMessageResult(MessageDescriptionConst.ERROR_INSERT);
                    }
                }
                else
                {
                    MsgResponse.Type = MessageTypeConst.WARNING;
                    MsgResponse.Message = MessageService.GetMessageResult(MessageDescriptionConst.EXIST_CATEGORY_CATEGORYNAME);
                }
            }
            catch (Exception ex)
            {
                MsgResponse.Type = MessageTypeConst.ERROR;
                MsgResponse.Message = $"{MessageService.GetMessageResult(MessageDescriptionConst.ERROR_OPERATION)}:{ex.Message}";

            }
            return MsgResponse;
        }
    }
}
