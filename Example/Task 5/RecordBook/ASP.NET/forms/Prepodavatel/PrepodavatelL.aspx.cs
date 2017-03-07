﻿/*flexberryautogenerated="true"*/
namespace NewPlatform.RecordBook
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ПреподавательL : BaseListForm<Преподаватель>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ПреподавательL() : base(Преподаватель.Views.ПреподавательL)
        {
            EditPage = ПреподавательE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Prepodavatel/PrepodavatelL.aspx"; }
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
