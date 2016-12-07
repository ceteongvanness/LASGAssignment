using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ass5.Entities;
using Ass5.Business;
using System.Reflection;
using Ass5.Data;

namespace Ass5.Test
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes

        public static void SetEntryAssembly(Assembly assembly)
        {
            AppDomainManager manager = new AppDomainManager();
            FieldInfo entryAssemblyfield = manager.GetType().GetField("m_entryAssembly", BindingFlags.Instance | BindingFlags.NonPublic);
            entryAssemblyfield.SetValue(manager, assembly);

            AppDomain domain = AppDomain.CurrentDomain;
            FieldInfo domainManagerField = domain.GetType().GetField("_domainManager", BindingFlags.Instance | BindingFlags.NonPublic);
            domainManagerField.SetValue(domain, manager);
        }
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            SetEntryAssembly(Assembly.GetCallingAssembly());
        }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

    

        [TestMethod]
        public void ApproveTest()
        {
            Task task = new Task();
            task.StartDate = Convert.ToDateTime("2017-10-12");
            task.EndDate = Convert.ToDateTime("2017-11-12");
            task.TaskNo = "TA1001";
            task.TaskStatus = "Approve";
            task.TaskName = "Task Testing";
            task.CorrelationID = Guid.NewGuid();

            var taskComponent = new TaskComponent();
            var newTask = new Task();
            newTask = taskComponent.Apply(task);

            Assert.IsTrue(!string.IsNullOrWhiteSpace(task.TaskStatus), "No Task Assign");
        }

        [TestMethod]
        public void UserApplyHRApproveTest()
        {
            // Step 1 - User submit detail.
            Task task = new Task();
            task.StartDate = Convert.ToDateTime("2017-10-12");
            task.EndDate = Convert.ToDateTime("2017-11-12");
            task.TaskStatus = "Pending";
            task.TaskName = "Task Testing";
            task.CorrelationID = Guid.NewGuid();
           
            var taskComponent = new TaskComponent();
            task = taskComponent.Apply(task);

            // Step 2 - Retrieve the detail from database.
            var tasks = taskComponent.ListTask();

            Assert.IsTrue(tasks.Exists(t => t.TaskID == task.TaskID));

            // Step 3 - HR Approve.
            taskComponent.Approve(task);

            // Step 4 - [Verification] - Verify the status is approved.
            var result = taskComponent.GetTask(task.TaskID);

            Assert.AreEqual("Approve", result.TaskStatus);
        }

        [TestMethod]
        public void HRRejectTest()
        {
            Task task = new Task();
            task.StartDate = Convert.ToDateTime("2017-10-12");
            task.EndDate = Convert.ToDateTime("2017-11-12");
            task.TaskStatus = "Pending";
            task.TaskName = "Task Testing";
            task.CorrelationID = Guid.NewGuid();

            var taskComponent = new TaskComponent();
            task = taskComponent.Apply(task);
            var tasks = taskComponent.ListTask();
            Assert.IsTrue(tasks.Exists(t => t.TaskID == task.TaskID));

            taskComponent.Reject(task);

            var result = taskComponent.GetTask(task.TaskID);

            Assert.AreEqual("Rejected", result.TaskStatus);
        }

        [TestMethod]
        public void UserCancelTest()
        {
            Task task = new Task();
            task.StartDate = Convert.ToDateTime("2017-10-12");
            task.EndDate = Convert.ToDateTime("2017-11-12");
            task.TaskStatus = "Canceled";
            task.TaskName = "Task Testing";
            task.CorrelationID = Guid.NewGuid();

            var taskComponent = new TaskComponent();
            task = taskComponent.Apply(task);
            var tasks = taskComponent.ListTask();
            Assert.IsTrue(tasks.Exists(t => t.TaskID == task.TaskID));

            taskComponent.Cancel(task);

            var result = taskComponent.GetTask(task.TaskID);

            Assert.AreEqual("Canceled", result.TaskStatus);
        }

        [TestMethod]
        public void TaskUnattendedTest()
        {
            Task task = new Task();

            task.StartDate = Convert.ToDateTime("5-12-2016");
            task.EndDate = Convert.ToDateTime("6-12-2016");
            task.TaskName = "Task Delay";
            task.TaskStatus = "Pending";
            task.CorrelationID = Guid.NewGuid();

            var taskComponent = new TaskComponent();
            task = taskComponent.Apply(task);
            var tasks = taskComponent.ListTask();
            Assert.IsTrue(tasks.Exists(t => t.TaskID == task.TaskID));
            taskComponent.Update(task, null);

            var result = taskComponent.GetTask(task.TaskID);
            Assert.AreEqual("Unattended",result.TaskStatus );
        }

        [TestMethod]
        public void CreateTest()
        {
            Task task = new Task();
            task.TaskID = task.TaskID;
            task.TaskNo = task.TaskNo;
            task.StartDate = Convert.ToDateTime("2017-10-12");
            task.EndDate = Convert.ToDateTime("2017-11-12");
            task.TaskStatus = "Pending";
            task.TaskName = "Task Testing";
            task.CorrelationID = Guid.NewGuid();

            var taskComponent = new TaskComponent();
            var newTask = new Task();
            newTask = taskComponent.Apply(task);

            Assert.IsTrue(!string.IsNullOrWhiteSpace(task.TaskNo), "No Task No");
        }

    }
}
