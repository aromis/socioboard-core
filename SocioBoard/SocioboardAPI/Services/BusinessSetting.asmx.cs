﻿using Api.Socioboard.Helper;
using Api.Socioboard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace Api.Socioboard.Services
{
    /// <summary>
    /// Summary description for Group
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [ScriptService]
    public class BusinessSetting : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public static string AddBusinessSetting(Guid userId, Guid groupsId, string groupsGroupName)
        {
            Domain.Socioboard.Domain.BusinessSetting objbsnssetting = new Domain.Socioboard.Domain.BusinessSetting();
            BusinessSettingRepository busnrepo = new BusinessSettingRepository();

            if (!busnrepo.checkBusinessExists(userId, groupsGroupName))
            {
                objbsnssetting.Id = Guid.NewGuid();
                objbsnssetting.BusinessName = groupsGroupName;
                objbsnssetting.GroupId = groupsId;
                objbsnssetting.AssigningTasks = false;
                objbsnssetting.AssigningTasks = false;
                objbsnssetting.TaskNotification = false;
                objbsnssetting.TaskNotification = false;
                objbsnssetting.FbPhotoUpload = 0;
                objbsnssetting.UserId = userId;
                objbsnssetting.EntryDate = DateTime.Now;
                busnrepo.AddBusinessSetting(objbsnssetting);

                return new JavaScriptSerializer().Serialize(objbsnssetting);
            }
            return null;
        }



        [WebMethod]
        //IsNotificationTaskEnable
        public string IsNotificationTaskEnable(Guid groupsId)
        {
            Domain.Socioboard.Domain.BusinessSetting objbsnssetting = new Domain.Socioboard.Domain.BusinessSetting();
            BusinessSettingRepository busnrepo = new BusinessSettingRepository();
            objbsnssetting = busnrepo.IsNotificationTaskEnable(groupsId);
            return new JavaScriptSerializer().Serialize(objbsnssetting);
        }


    }
}
