﻿/*flexberryautogenerated="true"*/
namespace NewPlatform.RecordBook
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ЛичностьL : BaseListForm<Личность>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ЛичностьL() : base(Личность.Views.ЛичностьL)
        {
            EditPage = ЛичностьE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Lichnost/LichnostL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
