
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using BeautyLibrary.Databases;
using BeautyLibrary.Models;

namespace BeautyLibrary.Data
{
    public class SqlData : ISqlDataConnect
    {
        public readonly ISqlDataAccess _database;
        private const string myBeautyconnectionString = "BeautyConnection";
        public SqlData(ISqlDataAccess database)
        {
            _database = database;
        }

        //******************Discount*******************

        public List<DiscountModel> DiscountGetList()
        {
            List<DiscountModel> discountList;

            discountList = _database.LaodData<DiscountModel, dynamic>("dbo.spDiscount_GetListDiscount",
                                                                      new { },
                                                                      myBeautyconnectionString,
                                                                      true);

            return discountList;
        }

        //Get Info of One discount

        public DiscountModel DiscountGetById(int idDiscount)
        {
            DiscountModel theOneDiscountList;

            theOneDiscountList = _database.LaodData<DiscountModel, dynamic>("dbo.spDiscount_GetListOneDiscount",
                                                                            new { theIdDiscount = idDiscount },
                                                                            myBeautyconnectionString,
                                                                            true).FirstOrDefault();

            return theOneDiscountList;
        }


        public void DiscountInsert(string theTitleDisc, float theRateDisc, decimal theCostDisc)
        {

           _database.SaveData("dbo.spDiscount_AddDiscount",
                               new { TitleDiscount = theTitleDisc, RateDiscount = theRateDisc, CostDiscount = theCostDisc },
                               myBeautyconnectionString,
                               true);
        }

        public void DiscountModify(int idDiscount, string titleDiscount, float rateDiscount, Decimal costDiscount)
        {
            _database.SaveData("dbo.spDiscount_ModifyDiscount",
                               new { IdDiscount = idDiscount, TitleDiscount = titleDiscount, RateDiscount = rateDiscount, CostDiscount = costDiscount },
                               myBeautyconnectionString,
                               true);
        }

        public void DiscountDelete(int idDiscount)
        {
            _database.SaveData("dbo.spDiscount_DeleteDiscount",
                               new { idDiscount },
                               myBeautyconnectionString,
                               true);
        }


        //**************Lenght****************************
        public void ExtratAdd(string TitleExtrat)
        {
            string TextSql = @"insert into EXTRAT(TitleExtrat) values (@TitleExtrat)";

            _database.SaveData(TextSql,
                               new { TitleExtrat },
                               myBeautyconnectionString,
                               false);
        }

        public void ExtratModify(int idExtrat, string titleExtrat)
        {
            string sqlText = @"Update EXTRAT set TitleExtrat = @titleExtrat where IDExtrat = @idExtrat;";
            _database.SaveData(sqlText,
                               new { IdExtrat = idExtrat, TitleExtrat = titleExtrat },
                               myBeautyconnectionString,
                               false);
        }

        //delete 
        public void ExtratDelete(int TheIdLength)
        {
            string SqlText = @"DELETE FROM EXTRAT where IDExtrat = @IDExtrat";

            _database.SaveData(SqlText,
                               new { IDExtrat = TheIdLength },
                               myBeautyconnectionString,
                               false);
        }


        //List
        public List<ExtratModel> ExtratGetListAllExtrat()
        {
            List<ExtratModel> extratAllList;
            string textSql = @"select IdExtrat,TitleExtrat from EXTRAT";
            extratAllList = _database.LaodData<ExtratModel, dynamic>(textSql,
                                                                     new { },
                                                                     myBeautyconnectionString,
                                                                     false);

            return extratAllList;
        }


        //get Info One extra
        public ExtratModel ExtratGetOneExtrat(int TheIdExtrat)
        {
            ExtratModel theExtrat;
            string textSql = @"select IdExtrat, TitleExtrat from EXTRAT where IdExtrat = @IdExtrat";
            theExtrat = _database.LaodData<ExtratModel, dynamic>(textSql,
                                                                     new { IdExtrat = TheIdExtrat },
                                                                     myBeautyconnectionString,
                                                                     false).FirstOrDefault();
            return theExtrat;
        }

        //list one Extra
        public List<ExtratModel> LengthGetLenghtPerStyle(int iDStyle)
        {
            List<ExtratModel> theLengthPerStyle;

            theLengthPerStyle = _database.LaodData<ExtratModel, dynamic>("dbo.spExtrat_GetListExtratPerStyle",
                                                                         new { iDStyle },
                                                                         myBeautyconnectionString,
                                                                         true);
            return theLengthPerStyle;
        }
        //************************************************

        //******************Style***********************
        public void StyleAdd(string desigStyle, string descriptStyle, bool hairProvStyle,
                             decimal costStyle, decimal priceTakeOffHair, decimal costTouchUp, string pictureStyle)
        {
            _database.SaveData("dbo.spStyle_AddStyle",
                               new
                               {
                                   desigStyle,
                                   descriptStyle,
                                   hairProvStyle,
                                   costStyle,
                                   priceTakeOffHair,
                                   costTouchUp,
                                   pictureStyle
                               },
                               myBeautyconnectionString,
                               true);
        }

        public void StyleModify(int idStyle, string desigStyle, string descriptStyle, bool hairProvStyle,
                             decimal costStyle, decimal priceTakeOffHair, decimal costTouchUp, string pictureStyle)
        {
            _database.SaveData("dbo.spStyle_ModifyStyle",
                               new
                               {
                                   idStyle,
                                   desigStyle,
                                   descriptStyle,
                                   hairProvStyle,
                                   costStyle,
                                   priceTakeOffHair,
                                   costTouchUp,
                                   pictureStyle
                               },
                               myBeautyconnectionString,
                               true);
        }

        public List<StyleModel> StyleGetList()
        {
            List<StyleModel> theStyleList;

            string TextSql = "select IDStyle,DesigStyle,DescriptStyle,HairProvStyle,CostStyle,CostTouchUp,PriceTakeOffHair,PictureStyle from STYLE";

            theStyleList = _database.LaodData<StyleModel, dynamic>(TextSql,
                                                                   new { },
                                                                   myBeautyconnectionString,
                                                                   false);
            return theStyleList.ToList();
        }

        public StyleModel StyleGetInfoById(int idStyle)
        {
            StyleModel theOneStyleList;

            theOneStyleList = _database.LaodData<StyleModel, dynamic>("dbo.spStyle_GetInfoStyleById",
                                                                   new { idStyle },
                                                                   myBeautyconnectionString,
                                                                   true).FirstOrDefault();
            return theOneStyleList;
        }

        public StyleModel StyleGetInfoByTitle(string TitleStyle)
        {
            StyleModel theOneStyleList;

            theOneStyleList = _database.LaodData<StyleModel, dynamic>("dbo.spStyle_GetInfoStyleByTitle",
                                                                   new { TitleStyle },
                                                                   myBeautyconnectionString,
                                                                   true).FirstOrDefault();
            return theOneStyleList;
        }
        //******************************************************
        
        //****************Type Operation *****************
        public List<TypeOperationModel> GetListTypeOperat()
        {
            List<TypeOperationModel> typeOperatList;

            typeOperatList = _database.LaodData<TypeOperationModel, dynamic>("dbo.spTypeOperat_GetListTypeOperat",
                                                           new { },
                                                           myBeautyconnectionString,
                                                           true);

            return typeOperatList;
        }

        //*************************Length per STYLE*********************

        public void CreateLengthToStyle(int IdStyle, int IdLength, decimal CostLength, decimal CostTouchUp)
        {
            string TextSql = @"insert into EXTRATSTYLE(IDStyle,IDExtrat,CostExtra,CostTouchUpExtra) 
                                values (@IDStyle,@IDExtrat,@CostExtra,@CostTouchUpExtra)";

            _database.SaveData(TextSql,
                               new { IDStyle = IdStyle, IDExtrat = IdLength, CostExtra = CostLength, CostTouchUpExtra = CostTouchUp },
                               myBeautyconnectionString,
                               false);
        }

        //LengthPerStyle - Get All List
        public List<ExtratStyleModel> LengthStyleGetAllLengthPerStyle(int TheIdStyle)
        {
            List<ExtratStyleModel> AllLenghtForAStyle;

            string TextSql = @"select IDExtratStyle, IDStyle, IDExtrat, CostExtra, CostTouchUpExtra
                               from EXTRATSTYLE where IDStyle = @IDStyle";
            
            AllLenghtForAStyle = _database.LaodData<ExtratStyleModel, dynamic>(TextSql,
                                                                   new { IDStyle = TheIdStyle },
                                                                   myBeautyconnectionString,
                                                                   false);
            return AllLenghtForAStyle.ToList();
        }

        public ExtratStyleModel LengthGetOneLengthPerStyleFinanceInfo(int iDStyle, int iDLength)
        {
            ExtratStyleModel theOneLengthFinanceInfo;

            theOneLengthFinanceInfo = _database.LaodData<ExtratStyleModel, dynamic>("dbo.spExtrat_GetOneExtratInfoFinance",
                                                                         new { iDStyle, iDLength },
                                                                         myBeautyconnectionString,
                                                                         true).FirstOrDefault();

            return theOneLengthFinanceInfo;
        }

        public bool IsLengthInExtraStyle(int TheIdExtrat)
        {
            ExtratStyleModel theExtratStyle;
            string textSql = @"select * from EXTRATSTYLE where IdExtrat = @IdExtrat";
            theExtratStyle = _database.LaodData<ExtratStyleModel, dynamic>(textSql,
                                                                     new { IdExtrat = TheIdExtrat },
                                                                     myBeautyconnectionString,
                                                                     false).FirstOrDefault();
            if (theExtratStyle.IDExtratStyle > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //***********************************************************************

        //***********Appointment *************************
        public void SetUpAppointment(int IDClientAppoint,
                                     int IDStyleAppoint,
                                     int IDLenghtstyle,
                                     DateTime DateAppoint,
                                     DateTime BeginTimeAppoint,
                                     bool AddTakeOffAppoint,
                                     char StateAppoint,
                                     char Typeservice)
        {


            _database.SaveData("dbo.spAppointment_AddAppointment",
                               new { IDClientAppoint, IDStyleAppoint, IDLenghtstyle, DateAppoint, BeginTimeAppoint, AddTakeOffAppoint, StateAppoint, Typeservice },
                               myBeautyconnectionString,
                               true);


        }

        //Get list appoint for A client for a specific date, in regard to the state of the appointment
        public List<AppointmentModel> AppointGetListPerDate(DateTime TheBeginDate, int TheIdClient, char TheStateAppoint)
        {
            string TextSql;
            List <AppointmentModel> theAppointmList;

            TextSql = @"select * from APPOINTMENT WHERE StateAppoint where DateAppoint = @DateAppoint";

            if (!TheStateAppoint.Equals('E')) // E = Nothing enterred
            {
                TextSql += " and StateAppoint = @StateAppoint";
            }

            if (TheIdClient > 0)
            {
                TextSql += " and IdClientAppoint = @IdClientAppoint";
            }

            theAppointmList = _database.LaodData< AppointmentModel, dynamic> (TextSql,
                                                                    new { DateAppoint = TheBeginDate, IdClientAppoint = TheIdClient, StateAppoint = TheStateAppoint },
                                                                    myBeautyconnectionString,
                                                                   false);


            return theAppointmList.ToList();
        }

        //************************************************************************

        //***************************CLIENT***************************************
        public void CreateClient(string TheFnameClient, string TheMnameClient, string TheLnameClient, string TheCelClient, string ThePhoneClient, DateTime TheDOBClient, string TheStreetClient,
                                 string TheCountyClient, string TheZipCodeClient, string TheStateClient, string TheEmailClient, int TheIDUserClient)
        {


        string TextSql = @"insert into CLIENT(FnameClient,MnameClient,LnameClient,CelClient,PhoneClient, DOBClient, StreetClient, 
                                                CountyClient, ZipCodeClient, StateClient, EmailClient, IDUserClient) 
                                values (@FnameClient, @MnameClient, @LnameClient, @CelClient, PhoneClient, DOBClient, StreetClient, 
                                        CountyClient, ZipCodeClient, StateClient, EmailClient, IDUserClient)";

            _database.SaveData(TextSql,
                               new { FnameClient = TheFnameClient,
                                   MnameClient = TheMnameClient,
                                   LnameClient = TheLnameClient,
                                   CelClient = TheCelClient,
                                   PhoneClient = ThePhoneClient,
                                   DOBClient = TheDOBClient,
                                   StreetClient = TheStreetClient,
                                   CountyClient = TheCountyClient,
                                   ZipCodeClient = TheZipCodeClient,
                                   StateClient = TheStateClient,
                                   EmailClient = TheEmailClient,
                                   IDUserClient = TheIDUserClient
                               },
                               myBeautyconnectionString,
                               false);
        }

        //**************************END CLIENT


        //****************Job Done *****************
        /*
        public void AddJobDone(int iDJobDone, int iDAppoint, DateTime dateJobDone,
                               DateTime begintimeJob, DateTime timeEndJob, string directfeedback,
                               int iDStyleJob, char typeserviceJob, bool addTakeoffJob, int iDDiscount,
                               int idExtraJobDone, string clientBehaviourNote, string idBraiderOwnerRelate)
        {

            _database.SaveData("dbo.spJobDone_AddJobDone",
                               new { },
                               myBeautyconnectionString,
                               true);
        }
        */
    }
}
