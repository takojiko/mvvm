using System;
using System.Windows.Threading;
using AndersonMvvm.BindHelpers;
using AndersonMvvm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AndersonMvvmTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IMessageService>();
            mock.Setup(x => x.QuestionOKCancel("保存しますか？")).Returns(
                 System.Windows.Forms.DialogResult.OK);

            var vm = new MainViewModel(
                Dispatcher.CurrentDispatcher, mock.Object, null);
            vm.BBBTextBoxText = "123";
            vm.SaveExecute();
            Assert.AreEqual("SAVE!!", vm.AAALabelText);
        }
    }
}
