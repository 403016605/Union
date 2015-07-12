using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Union.Admin;
using Union.Admin.Entities;
using Union.FixedAssets;
using Union.FixedAssets.Entities;
using Union.Share.Extension;

namespace Union.Test
{
    [TestClass]
    public class UnitTestAdminEntities
    {
        /// <summary>
        ///     测试：创建AdminEntities数据库
        /// </summary>
        [TestMethod]
        public void TestMethodCreateDb()
        {
            using (var db = new FixedAssetsEntities())
            {
                var a = new AssetInfo
                {
                    Name = "测试",
                    Code = "001"
                };

                db.Set<AssetInfo>().Add(a);

                var cnt = db.SaveChanges();
                Assert.AreEqual(cnt, 1);
            }

            using (var db = new AdminEntities())
            {
                var c = new Department
                {
                    CreatePerson = "Admin",
                    Sort = 0,
                    UpdatePerson = "Admin",
                    UpdateTime = DateTime.Now.CurrentNow(),
                    Name = "研发部",
                    Code = "001"
                };

                db.Set<Department>().Add(c);

                var cnt = db.SaveChanges();
                Assert.AreEqual(cnt, 1);
            }
        }
    }
}