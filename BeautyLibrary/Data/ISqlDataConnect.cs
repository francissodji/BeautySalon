using BeautyLibrary.Models;
using BeautyLibrary.OtherClasses;
using System;
using System.Collections.Generic;

namespace BeautyLibrary.Data
{
    public interface ISqlDataConnect
    {
        List<AppointmentModel> AppointGetListPerDate(DateTime TheBeginDate, int TheIdClient, char TheStateAppoint);
        void CreateClient(string TheFnameClient, string TheMnameClient, string TheLnameClient, string TheCelClient, string ThePhoneClient, DateTime TheDOBClient, string TheStreetClient, string TheCountyClient, string TheZipCodeClient, string TheStateClient, string TheEmailClient, int TheIDUserClient);
        void CreateLengthToStyle(int IdStyle, int IdLength, decimal CostLength, decimal CostTouchUp);
        void DiscountDelete(int idDiscount);
        DiscountModel DiscountGetById(int idDiscount);
        List<DiscountModel> DiscountGetList();
        void DiscountAdd(string theTitleDisc, float theRateDisc, decimal theCostDisc);
        void DiscountModify(int idDiscount, string titleDiscount, float rateDiscount, decimal costDiscount);
        void ExtratAdd(string titleExtrat);
        void ExtratDelete(int TheIdLength);
        List<ExtratModel> ExtratGetListAllExtrat();
        ExtratModel ExtratGetOneExtrat(int IdExtrat);
        void ExtratModify(int idExtrat, string titleExtrat);
        List<TypeOperationModel> GetListTypeOperat();
        bool IsLengthInExtraStyle(int TheIdExtrat);
        ExtratStyleModel LengthGetOneLengthPerStyleFinanceInfo(int iDStyle, int iDLength);
        List<ExtratStyleModel> LengthStyleGetAllLengthPerStyle(int TheIdStyle);
        void StyleAdd(string desigStyle, string descriptStyle, bool hairProvStyle, decimal costStyle, decimal priceTakeOffHair, decimal costTouchUp, string chargeType, float timeDoneStyle, bool modifyCostManu, decimal costHairDeducted, string uniqueFileName);
        
        StyleModel StyleGetInfoById(int idStyle);
        StyleModel StyleGetInfoByTitle(string TitleStyle);
        List<StyleModel> StyleGetList();
        void StyleModify(int idStyle, string desigStyle, string descriptStyle, bool hairProvStyle, decimal costStyle, decimal priceTakeOffHair, decimal costTouchUp, string pictureStyle);
        void SetNewAppointment(int TheIDClientAppoint, int TheIDStyleAppoint, int TheIDLenghtstyle, DateTime TheDateAppoint, DateTime TheBeginTimeAppoint, bool TheAddTakeOffAppoint, char TheStateAppoint, char TheTypeservice, int TheNumberTrack, int TheIDBraiderAppoint, int TheIdSizeAppoint, int TheIdBraiderOwner);
        List<ExtratStyleModel> SizeStyleGetAllSizePerStyle(int theIdStyle);
        List<SizeModel> SizeGetAllList();
        List<SizeModel> SizePerStyleGetAllList(int theIdStyle);
        List<ExtratModel> LengthPerStyleAndSizeGetAllList(int theIdStyle, int theIdSize);
        List<ExtratModel> LengthPerStyleAllList(int theIdSize);
        UsersModel UserGetAUserFromUsername(string theUserName);
        void CreateTheWord(int TheIdUser, string theUserPassword, int theNumConnect, DateTime theDateBeginPw, DateTime theDateEndPw);
        void CreateUser(string TheUserName, int theIdProfil, bool TheConnectState);
        bool IsClientEmailExist(string TheClientEmail);
        List<USAStates> GetListOfAllUSAStates();
        bool VerifyUserName(string theUserName);
        string FindUserPassword(int theIdUser);
        bool VerifyUserPassWord(string theUsername, string thePassword);
    }
}