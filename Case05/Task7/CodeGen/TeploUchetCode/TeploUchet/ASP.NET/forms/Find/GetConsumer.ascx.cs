﻿using ICSSoft.STORMNET;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using ICSSoft.STORMNET.FunctionalLanguage;
using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
using System;
using System.Linq;
using TeploCorp.TeploUchet;

namespace Web
{
    public partial class GetConsumer : System.Web.UI.UserControl
    {
        //private object _Inspector;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            PanelConsumer.Visible = false;
            PanelConsumerNotFound.Visible = false;
            LabelName.Text = string.Empty;
            LabelDateReg.Text = string.Empty;
            LabelAccount.Text = string.Empty;
            */
        }

        protected void ButtonFind_OnClick(object sender, EventArgs e)
        {
            //var  = ГенерацияКода.generateCode(TextBoxCode.Text);
            string codeFromForm = TextBoxCode.Text;
            var _dataService = (SQLDataService)DataServiceProvider.DataService; //сервис для получения объекта
            var _consumer = _dataService.Query<Объект>(Объект.Views.ОбъектL)
                    .Count(x => x.КодОбъекта == codeFromForm); // получаем объект инспектор по логину

            if ( _consumer > 0)
            {
                SQLWhereLanguageDef langdef = SQLWhereLanguageDef.LanguageDef;
                //string strDistrictName = _Inspector.Район.Название; //название района инспектора

                Function lf = langdef.GetFunction(langdef.funcEQ,
                                        new VariableDef(langdef.StringType, Information.ExtractPropertyPath<Объект>(x => x.КодОбъекта)),
                                        codeFromForm);
                WebObjectListView1.LimitFunction = lf;
            }
            else
            {
                //WebObjectListView1.Visible = false;
                ErrorLabel.Visible = true;
            }
            
        }
    }
}