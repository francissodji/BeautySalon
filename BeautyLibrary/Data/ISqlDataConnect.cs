using BeautyLibrary.Models;
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
        void DiscountInsert(string theTitleDisc, float theRateDisc, decimal theCostDisc);
        void DiscountModify(int idDiscount, string titleDiscount, float rateDiscount, decimal costDiscount);
        void ExtratAdd(string titleExtrat);
        void ExtratDelete(int TheIdLength);
        List<ExtratModel> ExtratGetListAllExtrat();
        ExtratModel ExtratGetOneExtrat(int IdExtrat);
        void ExtratModify(int idExtrat, string titleExtrat);
        List<TypeOperationModel> GetListTypeOperat();
        bool IsLengthInExtraStyle(int TheIdExtrat);
        List<ExtratModel> LengthGetLenghtPerStyle(int iDStyle);
        ExtratStyleModel LengthGetOneLengthPerStyleFinanceInfo(int iDStyle, int iDLength);
        List<ExtratStyleModel> LengthStyleGetAllLengthPerStyle(int TheIdStyle);
        void SetUpAppointment(int IDClientAppoint, int IDStyleAppoint, int IDLenghtstyle, DateTime DateAppoint, DateTime BeginTimeAppoint, bool AddTakeOffAppoint, char StateAppoint, char Typeservice);
        void StyleAdd(string desigStyle, string descriptStyle, bool hairProvStyle, decimal costStyle, decimal priceTakeOffHair, decimal costTouchUp, string pictureStyle);
        StyleModel StyleGetInfoById(int idStyle);
        StyleModel StyleGetInfoByTitle(string TitleStyle);
        List<StyleModel> StyleGetList();
        void StyleModify(int idStyle, string desigStyle, string descriptStyle, bool hairProvStyle, decimal costStyle, decimal priceTakeOffHair, decimal costTouchUp, string pictureStyle);
    }
}