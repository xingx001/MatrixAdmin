﻿using System.Collections.Generic;
using Core.Entity.Enums;
using Core.Extension;
using Core.Model.Administration.User;
using Core.Mvc.Areas.Administration.Controllers;
using Core.Web.Button;
using Core.Web.Dialog;
using Core.Web.Enums;
using Core.Web.Html;
using Core.Web.TextBox;
using Resources = Core.Resource.Areas.Administration.ViewConfiguration.EditUserDialogConfigurationResource;

namespace Core.Mvc.Areas.Administration.ViewConfiguration.User
{
    public class EditUserDialogConfiguration<TPostModel, TModel> : DialogConfiguration<TPostModel, TModel>
        where TPostModel : UserEditPostModel
        where TModel : UserModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditUserDialogConfiguration{TPostModel, TModel}"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public EditUserDialogConfiguration(TModel user) : base(UserIdentifiers.EditUserDialogIdentifier, user)
        {
        }

        public override string Title => Resources.Title;

        protected override void CreateHiddenValues(IList<ITextRender<TPostModel, TModel>> textBoxes)
        {
            textBoxes.Add(new HiddenTextBox<TPostModel, TModel>(o => o.Id, this.Model.Id));
        }

        protected override void CreateBody(IList<ITextRender<TPostModel, TModel>> textBoxes)
        {
            textBoxes.Add(new LabeledTextBox<TPostModel, TModel>(Resources.LoginName, o => o.LoginName, o => o.LoginName));
            textBoxes.Add(new LabeledTextBox<TPostModel, TModel>(Resources.DisplayName, o => o.DisplayName, o => o.DisplayName));

            var dropDown = new DropDownTextBox<TPostModel, TModel>(Resources.UserRole, o => o.UserRole, false);
            dropDown.AddOption((int)UserRoleEnum.GeneralUser, Resources.GeneralUser, this.Model.UserRole == UserRoleEnum.GeneralUser);
            dropDown.AddOption((int)UserRoleEnum.Admin, Resources.Admin, this.Model.UserRole == UserRoleEnum.Admin);
            dropDown.AddOption((int)UserRoleEnum.SuperAdministrator, Resources.SuperAdministrator, this.Model.UserRole == UserRoleEnum.SuperAdministrator);
            textBoxes.Add(dropDown);
            textBoxes.Add(new LabeledTextBox<TPostModel, TModel>(Resources.Password, o => o.Password, o => o.Password, TextBoxTypeEnum.Password));
        }

        protected override void CreateButtons(IList<StandardButton> buttons)
        {
            Url saveEditUrl = new Url(nameof(Administration), typeof(UserController), nameof(UserController.SaveEdit));

            buttons.Add(new StandardButton(Resources.Submit, "index.submit", saveEditUrl));
            buttons.Add(new StandardButton(Resources.Cancel, "core.cancel"));
        }
    }
}