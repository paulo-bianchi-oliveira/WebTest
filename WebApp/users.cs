using System.Collections.Generic;

namespace WebApp
{
    public class users
    {
        public List<Models.User> GetName(Models.Search P_NAME)
        {
            List<Models.User> ret = new List<Models.User>();
            BdUtil bdUtil = new BdUtil();
            System.Data.Common.DbDataReader rs = bdUtil.Qry("select ID,NAME,AGE,ADDRESS from USERS where upper(name) like '%" + P_NAME.Name.ToUpperInvariant() + "%' order by NAME", null);
            while (rs.Read())
            {
                ret.Add(new Models.User { Id = rs.GetInt32(0), Name = rs.GetString(1), Age = rs.GetInt32(2), Address = rs.GetString(3) });
            }

            return ret;
        }

        public List<Models.User> GetAll()
        {
            List<Models.User> ret = new List<Models.User>();
            BdUtil bdUtil = new BdUtil();
            System.Data.Common.DbDataReader rs = bdUtil.Qry("select ID,NAME,AGE,ADDRESS from USERS order by NAME", null);
            while (rs.Read())
            {
                ret.Add(new Models.User { Id = rs.GetInt32(0), Name = rs.GetString(1), Age = rs.GetInt32(2), Address = rs.GetString(3) });
            }

            return ret;
        }

        public Models.User GetId(int P_ID)
        {
            Models.User ret = new Models.User();
            BdUtil bdUtil = new BdUtil();
            System.Data.Common.DbDataReader rs = bdUtil.Qry("select ID,NAME,AGE,ADDRESS from USERS where ID = " + P_ID, null);
            while (rs.Read())
            {
                ret.Id = rs.GetInt32(0);
                ret.Name = rs.GetString(1);
                ret.Age = rs.GetInt32(2);
                ret.Address = rs.GetString(3);
            }

            return ret;
        }
        public string AddEditUser(Models.User P_User)
        {
            string sRet = ""; string sSQL = "";
            BdUtil bdUtil = new BdUtil(); 

            if (P_User.Id==0)
                sSQL = "Insert Into USERS(NAME,AGE,ADDRESS) values ('" + P_User.Name.Replace("'"," ") + "'," + P_User.Age + ",'" + P_User.Address.Replace("'", " ") + "')";
            else
                sSQL = "Update USERS set NAME = '" + P_User.Name.Replace("'", " ") + "', AGE = " + P_User.Age + ",ADDRESS = '" + P_User.Address.Replace("'", " ") + "' where ID = " + P_User.Id;

            try
            {
                if (bdUtil.ExecuteNonQuery(sSQL, null) == 1) sRet = "OK";
            }
            catch (System.Exception ex)
            {   
                //ex.Message;
                
            }
            
            return sRet;
        }

        public string DelUser(int P_ID)
        {
            string sRet = "";
            BdUtil bdUtil = new BdUtil();
            string sSQL = "Delete from USERS where ID = " + P_ID.ToString();
            try
            {
                if (bdUtil.ExecuteNonQuery(sSQL, null) == 1) sRet = "OK";
            }
            catch (System.Exception ex)
            {
                //ex.Message;

            }

            return sRet;
        }
    }
}
