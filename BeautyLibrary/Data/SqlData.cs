
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using BeautyLibrary.Databases;
using BeautyLibrary.Models;
using BeautyLibrary.OtherClasses;

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


        public void DiscountAdd(string theTitleDisc, float theRateDisc, decimal theCostDisc)
        {
            string TextSql = @"insert into DISCOUNT(TitleDiscount,RateDiscount,CostDiscount) values (@TitleDiscount,@RateDiscount,@CostDiscount)";
            _database.SaveData(TextSql,
                               new { TitleDiscount = theTitleDisc, RateDiscount = theRateDisc, CostDiscount = theCostDisc },
                               myBeautyconnectionString,
                               false);
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
        public List<ExtratModel> LengthPerStyleAndSizeGetAllList(int theIdStyle, int theIdSize)
        {
            List<ExtratModel> lengthPerStyleAndSize;
            string textSQL;
            textSQL = @"select distinct T.IDExtrat, TitleExtrat from EXTRATSTYLE AS E 
                        INNER JOIN EXTRAT AS T ON E.IDExtrat = T.IDExtrat
                        where IDStyle = @IDStyle and IdSize = @IdSize";

            lengthPerStyleAndSize = _database.LaodData<ExtratModel, dynamic>(textSQL,
                                                                         new { IDStyle = theIdStyle, IdSize = theIdSize },
                                                                         myBeautyconnectionString,
                                                                         false);
            return lengthPerStyleAndSize.ToList();
        }

        public List<ExtratModel> LengthPerStyleAllList(int theIdSize)
        {
            List<ExtratModel> lengthPerStyleAndSize;
            string textSQL;
            textSQL = @"select distinct T.IDExtrat, TitleExtrat from EXTRATSTYLE AS E 
                        INNER JOIN EXTRAT AS T ON E.IDExtrat = T.IDExtrat
                        where IdSize = @IdSize";

            lengthPerStyleAndSize = _database.LaodData<ExtratModel, dynamic>(textSQL,
                                                                         new { IdSize = theIdSize },
                                                                         myBeautyconnectionString,
                                                                         false);
            return lengthPerStyleAndSize.ToList();
        }
        //************************************************

        //******************Style***********************
        public void StyleAdd(string desigStyle, string descriptStyle, bool hairProvStyle,
                             decimal costStyle, decimal priceTakeOffHair, decimal costTouchUp, 
                             string chargeType, float timeDoneStyle, bool modifyCostManu, 
                             decimal costHairDeducted, string pictureStyle)
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
                                   chargeType,
                                   timeDoneStyle,
                                   modifyCostManu,
                                   costHairDeducted,
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

        //********************Size********************************
        public List<SizeModel> SizeGetAllList()
        {
            List<SizeModel> allSizeFromDB;
            string textSQL = @"select IdSize, TitleSize from SIZE";

            allSizeFromDB = _database.LaodData<SizeModel, dynamic>(textSQL, new { }, myBeautyconnectionString, false);

            return allSizeFromDB.ToList();
        }

        public List<SizeModel> SizePerStyleGetAllList(int theIdStyle)
        {
            List<SizeModel> allSizeFromDB;
            string textSQL = @"select distinct E.idsize, TitleSize from EXTRATSTYLE AS E INNER JOIN SIZE AS S ON E.IdSize = S.IdSize where IDStyle = @IDStyle";

            allSizeFromDB = _database.LaodData<SizeModel, dynamic>(textSQL, new { IDStyle = theIdStyle }, myBeautyconnectionString, false);

            return allSizeFromDB.ToList();
        }
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
        //*********************Size per Style********************************
        public List<ExtratStyleModel> SizeStyleGetAllSizePerStyle(int theIdStyle)
        {
            List<ExtratStyleModel> allSizePerStyle;

            string textSQL = @"select distinct idsize from EXTRATSTYLE E, SIZE S where IdStyle = @IdStyle";

            allSizePerStyle = _database.LaodData<ExtratStyleModel, dynamic>(textSQL,
                                                                            new { IdStyle  = theIdStyle },
                                                                            myBeautyconnectionString,
                                                                            false);
            return allSizePerStyle;
        }

        //******************************************************************
        //***********Appointment *************************
        public void SetNewAppointment(int TheIDClientAppoint,
                                     int TheIDStyleAppoint,
                                     int TheIDLenghtstyle,
                                     DateTime TheDateAppoint,
                                     DateTime TheBeginTimeAppoint,
                                     bool TheAddTakeOffAppoint,
                                     char TheStateAppoint,
                                     char TheTypeservice,
                                     int TheNumberTrack,
                                     int TheIDBraiderAppoint,
                                     int TheIdSizeAppoint,
                                     int TheIdBraiderOwner)
        {


            string textSql = @"insert into APPOINTMENT
                             (IDClientAppoint,IDStyleAppoint,IDLenghtstyle,DateAppoint,BeginTimeAppoint,AddTakeOffAppoint,StateAppoint,Typeservice,NumberTrack,IDBraiderAppoint,IdSizeAppoint,IdBraiderOwner)
                            values(@IDClientAppoint, @IDStyleAppoint, @IDLenghtstyle, @DateAppoint, @BeginTimeAppoint, @AddTakeOffAppoint, 
                            @StateAppoint, @Typeservice, @NumberTrack, @IDBraiderAppoint, @IdSizeAppoint, @IdBraiderOwner";
                        
            _database.SaveData(textSql,
                               new { TheIDClientAppoint, TheIDStyleAppoint, TheIDLenghtstyle, TheDateAppoint, TheBeginTimeAppoint, TheAddTakeOffAppoint, TheStateAppoint, TheTypeservice, TheNumberTrack, TheIDBraiderAppoint, TheIdSizeAppoint, TheIdBraiderOwner },
                               myBeautyconnectionString,
                               false);


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

        //GET TYPE OF SERVICE


        //************************************************************************

        //***************************CLIENT***************************************
        public void CreateClient(string TheFnameClient, string TheMnameClient, string TheLnameClient, string TheCelClient, string ThePhoneClient, DateTime TheDOBClient, string TheStreetClient,
                                 string TheCountyClient, string TheZipCodeClient, string TheStateClient, string TheEmailClient, int TheIDUserClient)
        {


        string TextSql = @"insert into CLIENT(FnameClient,MnameClient,LnameClient,CelClient,PhoneClient, DOBClient, StreetClient, 
                                                CountyClient, ZipCodeClient, StateClient, EmailClient, IDUserClient) 
                                values (@FnameClient, @MnameClient, @LnameClient, @CelClient, @PhoneClient, @DOBClient, @StreetClient, 
                                        @CountyClient, @ZipCodeClient, @StateClient, @EmailClient, @IDUserClient)";

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


        public bool IsClientEmailExist(string TheClientEmail)
        {
            bool itExist = false;
            ClientModel theCLient;
            string textSQL = @"select EmailClient from CLIENT where EmailClient = @EmailClient";
            theCLient = _database.LaodData<ClientModel,dynamic>(textSQL, new { EmailClient = TheClientEmail }, myBeautyconnectionString, false).FirstOrDefault();

            if (theCLient != null)
            {
                itExist = true;
            }
            return itExist;
        }
        //**************************END CLIENT

        //***************************USER***************************
        public void CreateUser(string TheUserName, int theIdProfil, bool TheConnectState)
        {
            string testSQL = @"insert into USERS(Username,IdProfil,ConnectState) values(@Username,@IdProfil,@ConnectState)";
            _database.SaveData(testSQL,
                               new { Username = TheUserName, IdProfil = theIdProfil, ConnectState = TheConnectState },
                               myBeautyconnectionString,
                               false);
        }

        public UsersModel UserGetAUserFromUsername(string theUserName)
        {
            UsersModel theUserfromDB;
            string TextSQL = @"select IDUser from USERS where Username = @Username";
            theUserfromDB = _database.LaodData<UsersModel, dynamic>(TextSQL, new { Username = theUserName }, myBeautyconnectionString, false).FirstOrDefault();

            return theUserfromDB;
        }

        public bool VerifyUserName(string theUserName)
        {
            bool ItExist = false;
            UsersModel theUserfromDB;
            string TextSQL = @"select IDUser from USERS where Username = @Username";
            theUserfromDB = _database.LaodData<UsersModel, dynamic>(TextSQL, new { Username = theUserName }, myBeautyconnectionString, false).FirstOrDefault();

            if (theUserfromDB.IDUser > 0)
            {
                ItExist = true;
            }
            return ItExist;
        }

        //************************END USERS***********************

        //*************************PASSWORD**************************
        public void CreateTheWord(int TheIdUser, string theUserPassword, int theNumConnect, DateTime theDateBeginPw, DateTime theDateEndPw)
        {
            string TestSQL = @"insert into THEWORDS(IDUser,UserPassword,NumConnection,DateBeginPw,DateEndPw) values(@IDUser,@UserPassword,@NumConnection,@DateBeginPw,@DateEndPw)";
            
            _database.SaveData(TestSQL,
                               new { IDUser = TheIdUser, UserPassword = theUserPassword, NumConnection = theNumConnect, DateBeginPw = theDateBeginPw, DateEndPw = theDateEndPw },
                               myBeautyconnectionString,
                               false);
        }

        public string FindUserPassword(int theIdUser)
        {
            string thePw, textSQL;
            textSQL = @"select * from THEWORDS where IDUser = @IDUser";
            TheWordsModel theword = _database.LaodData<TheWordsModel,dynamic>(textSQL,new { IDUser = theIdUser },myBeautyconnectionString,false).FirstOrDefault();
            thePw = theword.UserPassword;
            return thePw;
        }

        public bool VerifyUserPassWord(string theUsername, string thePassword)
        {
            bool pwMatched = false;
            string existingPwCrypted, enteredPwCrypted;


            UsersModel theUser = UserGetAUserFromUsername(theUsername);//This Get the user Id 

            if (theUser.IDUser > 0)
            {
                try
                {
                    existingPwCrypted = FindUserPassword(theUser.IDUser);//This get the user existing crypted pw

                    enteredPwCrypted = Cryptograph.Hash(thePassword);//This encrypt the password entered

                    if (existingPwCrypted != null && enteredPwCrypted != null)
                    {
                        if (existingPwCrypted.Equals(enteredPwCrypted))
                        {
                            pwMatched = true;
                        }
                        else
                        {
                            pwMatched = false;
                        }
                    }
                    else
                    {
                        pwMatched = false;
                    }
                    
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
       
            return pwMatched;
        }
        //*************************END PASSWORD***************



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


        //***************************** USA STATES ******************************
        public List<USAStates> GetListOfAllUSAStates()
        {
            List<USAStates> allUsaStates = new List<USAStates>
            {
                new USAStates { IdState = "AL", NameState = "Alabama"},
                new USAStates { IdState = "AK", NameState = "Alaska"},
                new USAStates { IdState = "AZ", NameState = "Arizona"},
                new USAStates { IdState = "AR", NameState = "Arkansas"},
                new USAStates { IdState = "CA", NameState = "California"},
                new USAStates { IdState = "CO", NameState = "Colorado"},
                new USAStates { IdState = "CT", NameState = "Connecticut"},
                new USAStates { IdState = "DE", NameState = "Dalaware"},
                new USAStates { IdState = "DC", NameState = "District of Columbia"},
                new USAStates { IdState = "FL", NameState = "Florida"},
                new USAStates { IdState = "GA", NameState = "Georgia"},
                new USAStates { IdState = "GU", NameState = "Guam"},
                new USAStates { IdState = "HI", NameState = "Hawaii"},
                new USAStates { IdState = "IL", NameState = "Illinois"},
                new USAStates { IdState = "IN", NameState = "Indiana"},
                new USAStates { IdState = "IA", NameState = "Iowa"},
                new USAStates { IdState = "KS", NameState = "Kansas"},
                new USAStates { IdState = "KY", NameState = "Kentucky"},
                new USAStates { IdState = "LA", NameState = "Louisiana"},
                new USAStates { IdState = "ME", NameState = "Maine"},
                new USAStates { IdState = "MD", NameState = "Maryland"},
                new USAStates { IdState = "MA", NameState = "Massachusetts"},
                new USAStates { IdState = "MI", NameState = "Michigan"},
                new USAStates { IdState = "MN", NameState = "Minnesato"},
                new USAStates { IdState = "MS", NameState = "Mississippi"},
                new USAStates { IdState = "MO", NameState = "Missouri"},
                new USAStates { IdState = "MT", NameState = "Montana"},
                new USAStates { IdState = "NE", NameState = "Nebraska"},
                new USAStates { IdState = "NH", NameState = "New Hampshire"},
                new USAStates { IdState = "NJ", NameState = "New Jersey"},
                new USAStates { IdState = "NM", NameState = "New Mexico"},
                new USAStates { IdState = "NY", NameState = "New York"},
                new USAStates { IdState = "NC", NameState = "North Carolina"},
                new USAStates { IdState = "ND", NameState = "North Dakota"},
                new USAStates { IdState = "OH", NameState = "Ohio"},
                new USAStates { IdState = "OK", NameState = "Oklahoma"},
                new USAStates { IdState = "OR", NameState = "Oregon"},
                new USAStates { IdState = "PA", NameState = "Pennsylvania"},
                new USAStates { IdState = "RI", NameState = "Rhode Island"},
                new USAStates { IdState = "SC", NameState = "South Carolina"},
                new USAStates { IdState = "SD", NameState = "South Dakota"},
                new USAStates { IdState = "TN", NameState = "Tennessee"},
                new USAStates { IdState = "TX", NameState = "Texas"},
                new USAStates { IdState = "UT", NameState = "Utah"},
                new USAStates { IdState = "VA", NameState = "Virginia"},
                new USAStates { IdState = "VI", NameState = "Virgin Islands"},
                new USAStates { IdState = "WA", NameState = "Washington"},
                new USAStates { IdState = "WV", NameState = "West Virginia"},
                new USAStates { IdState = "WI", NameState = "Wisconsin"},
                new USAStates { IdState = "WY", NameState = "Wyoming"}
            };

            return allUsaStates.ToList();
        }
        //************************************************************************
    }
}
