namespace SIGCora.Presentation.Areas.Security.Models.Ubigeo
{
    public record struct UbigeoListByClassAndCodeAndLenCodeRequestModel
    (
        int UbigeoClass,
        string UbigeoCode,
        int LenUbigeoCode
    );
}
