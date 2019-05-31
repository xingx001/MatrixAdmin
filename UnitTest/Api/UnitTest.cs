using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Core.Api.Controllers;
using Core.Entity;
using Core.Extension;
using Core.Extension.Dapper;
using Core.Model;
using Core.Model.Administration.Menu;
using Core.Model.Administration.Role;
using Core.Model.Administration.User;
using Core.Model.Log;
using Core.Mvc.Framework;
using Core.UnitTest.Resource.Areas;
using Dapper;
using NUnit.Framework;

namespace Core.UnitTest.Api
{
    /// <summary>
    /// Api unit test.
    /// </summary>
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public async Task TestGetUserDataListAsync()
        {
            var url = new Url(typeof(DataListController), nameof(DataListController.GetUserDataList));
            ResponseModel model = await HttpClientAsync.GetAsync<IList<UserModel>>(url);
            IList<UserModel> users = (IList<UserModel>)model.Data;

            Assert.GreaterOrEqual(users.Count, 0);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK, UnitTestResource.TestGetUserDataList);
        }

        [Test]
        public async Task TestGetRoleDataListAsync()
        {
            var url = new Url(typeof(DataListController), nameof(DataListController.GetRoleDataList));
            ResponseModel model = await HttpClientAsync.GetAsync<IList<RoleModel>>(url);
            IList<RoleModel> roles = (IList<RoleModel>)model.Data;

            Assert.GreaterOrEqual(roles.Count, 0);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK, UnitTestResource.TestGetRoleDataList);
        }

        [Test]
        public async Task TestGetMenuDataListAsync()
        {
            var url = new Url(typeof(DataListController), nameof(DataListController.GetMenuDataList));
            ResponseModel model = await HttpClientAsync.GetAsync<IList<MenuModel>>(url);
            IList<MenuModel> menus = (IList<MenuModel>)model.Data;

            Assert.GreaterOrEqual(menus.Count, 0);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK, UnitTestResource.TestGetMenuDataList);
        }

        [Test]
        public async Task TestUserIndexAsync()
        {
            var url = new Url(typeof(UserController), nameof(UserController.Index));
            ResponseModel model = await HttpClientAsync.GetAsync<IList<UserModel>>(url);
            IList<UserModel> menus = (IList<UserModel>)model.Data;

            Assert.GreaterOrEqual(menus.Count, 0);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
        }

        [Test]
        public async Task TestRoleIndexAsync()
        {
            var url = new Url(typeof(RoleController), nameof(RoleController.Index));
            ResponseModel model = await HttpClientAsync.GetAsync<IList<RoleModel>>(url);
            IList<RoleModel> menus = (IList<RoleModel>)model.Data;

            Assert.GreaterOrEqual(menus.Count, 0);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
        }

        [Test]
        public async Task TestMenuIndexAsync()
        {
            var url = new Url(typeof(MenuController), nameof(MenuController.Index));
            ResponseModel model = await HttpClientAsync.GetAsync<IList<MenuModel>>(url);
            IList<MenuModel> menus = (IList<MenuModel>)model.Data;

            Assert.GreaterOrEqual(menus.Count, 0);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
        }

        [Test]
        public async Task TestLogIndexAsync()
        {
            var url = new Url(typeof(LogController), nameof(LogController.Index));
            ResponseModel model = await HttpClientAsync.GetAsync<IList<LogModel>>(url);
            IList<LogModel> menus = (IList<LogModel>)model.Data;

            Assert.GreaterOrEqual(menus.Count, 0);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
        }

        [Test]
        public async Task TestUserFindByIdAsync()
        {
            var url = new Url(typeof(UserController), nameof(UserController.FindById));
            ResponseModel model = await HttpClientAsync.GetAsync<UserModel>(url, 1);
            UserModel user = (UserModel)model.Data;

            Assert.IsNotNull(user);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
        }

        [Test]
        public async Task TestMenuFindByIdAsync()
        {
            var url = new Url(typeof(MenuController), nameof(MenuController.FindById));
            ResponseModel model = await HttpClientAsync.GetAsync<MenuModel>(url, 1);
            MenuModel user = (MenuModel)model.Data;

            Assert.IsNotNull(user);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
        }

        [Test]
        public async Task TestRoleFindByIdAsync()
        {
            var url = new Url(typeof(RoleController), nameof(RoleController.FindById));
            ResponseModel model = await HttpClientAsync.GetAsync<RoleModel>(url, 1);
            RoleModel user = (RoleModel)model.Data;

            Assert.IsNotNull(user);
            Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
        }

        /// <summary>
        /// Test enable user.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestEnableUserAsync()
        {
            User user = DapperExtension.Connection.QueryFirst<User>(o => o.IsEnable, true);
            if (user != null)
            {
                var url = new Url(typeof(UserController), nameof(UserController.Disable));
                ResponseModel model = await HttpClientAsync.DeleteAsync(url, user.Id);
                Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
                user = DapperExtension.Connection.QueryFirst<User>(o => o.Id, user.Id);
                Assert.IsFalse(user.IsEnable, UnitTestResource.DisableFail);

                url = new Url(typeof(UserController), nameof(UserController.Enable));
                model = await HttpClientAsync.DeleteAsync(url, user.Id);
                Assert.AreEqual(model.Code, (int)HttpStatusCode.OK);
                user = DapperExtension.Connection.QueryFirst<User>(o => o.Id, user.Id);
                Assert.IsTrue(user.IsEnable, UnitTestResource.EnableFail);
            }
        }
    }
}
