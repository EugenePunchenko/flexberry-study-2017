﻿/*flexberryautogenerated="false"*/
namespace IIS.BusinessCalendar
{
    using System;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Security;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class CalendarL : BaseListForm<Calendar>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public CalendarL() : base(Calendar.Views.CalendarL)
        {
            EditPage = CalendarE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Calendar/CalendarL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
            var sm = DataServiceProvider.DataService.SecurityManager;
            if (!(sm.AccessObjectCheck(typeof(Calendar),tTypeAccess.Update,false) || sm.AccessObjectCheck(typeof(Calendar), tTypeAccess.Full, false)))
            {
                WebObjectListView1.Operations.New = false;
                WebObjectListView1.Operations.NewByExampleInRow = false;
                WebObjectListView1.Operations.Delete = false;
                WebObjectListView1.Operations.DeleteInRow = false;
            }
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}