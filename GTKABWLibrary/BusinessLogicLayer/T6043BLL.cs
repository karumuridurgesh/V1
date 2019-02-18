using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{

  public  class T6043BLL 
    
    {
      T6043DAL clsT6043DAL = new T6043DAL();

      public DataSet Open_PagingGrid()
      {
          try
          {
              return clsT6043DAL.Open_PagingGrid();
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }


      public DataSet Fetch_ABWT6043(string strMode, string xmlData)
      {
          try
          {
              return clsT6043DAL.Fetch_ABWT6043(strMode, xmlData);
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }


      public DataSet T6043Action(string sMode, string sval1)
      {
          try
          {
              return clsT6043DAL.T6043Action(sMode, sval1);
          }
          catch (Exception ex)
          {

              throw ex;


          }
      }   

      public DataSet Save_ABWT6043(string strMode, string xmlData)
      {
          try
          {
              return clsT6043DAL.Save_ABWT6043(strMode, xmlData);
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }


      public DataSet Fetch_ABWT6043Products(string Mode, string PrdCds, string Locid)
      {
          try
          {
              return clsT6043DAL.Fetch_ABWT6043Products(Mode, PrdCds, Locid);
          }
          catch (Exception ex)
          {

              throw ex;
          }
      }

    }
}
