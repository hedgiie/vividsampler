﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace wfrmhr
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VehicleAndAccomodationDetails recording.
    /// </summary>
    [TestModule("68b800d0-0566-4a61-ae81-3ee4280a3e47", ModuleType.Recording, 1)]
    public partial class VehicleAndAccomodationDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the wfrmhrRepository repository.
        /// </summary>
        public static wfrmhrRepository repo = wfrmhrRepository.Instance;

        static VehicleAndAccomodationDetails instance = new VehicleAndAccomodationDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VehicleAndAccomodationDetails()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VehicleAndAccomodationDetails Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Assignments' at 35;8.", repo.ApplicationUnderTest.AssignmentsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Assignments.Click("35;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CdkCellCdkColumnTypeMatCellMatCo' at 95;21.", repo.ApplicationUnderTest.CdkCellCdkColumnTypeMatCellMatCoInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.CdkCellCdkColumnTypeMatCellMatCo.Click("95;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RuchiTestManifest' at 65;18.", repo.ApplicationUnderTest.RuchiTestManifestInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.RuchiTestManifest.Click("65;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MatRadioOuterCircle' at 9;10.", repo.ApplicationUnderTest.MatRadioOuterCircleInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.MatRadioOuterCircle.Click("9;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.False' at 139;6.", repo.ApplicationUnderTest.FalseInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.False.Click("139;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ApplicationUnderTest.False' at 152;7.", repo.ApplicationUnderTest.FalseInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.False.MoveTo("152;7");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ApplicationUnderTest.False' at -15;4.", repo.ApplicationUnderTest.FalseInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.False.MoveTo("-15;4");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '33vsadfadfa43rt124343434343433ffffffffffffffffasdf@@@@@@@@@##$%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%@' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("33vsadfadfa43rt124343434343433ffffffffffffffffasdf@@@@@@@@@##$%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%@");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1' at 223;16.", repo.ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1.Click("223;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Value cannot exceed 75 characters') on item 'ApplicationUnderTest.ValueCannotExceed75Characters'.", repo.ApplicationUnderTest.ValueCannotExceed75CharactersInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ValueCannotExceed75CharactersInfo, "InnerText", "Value cannot exceed 75 characters");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1' at 223;16.", repo.ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1Info, new RecordItemIndex(10));
            repo.ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1.Click("223;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '33 @##vvddd##@@@@@@@@@@$ test that any character can be typed in no validatn' with focus on 'ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1'.", repo.ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1Info, new RecordItemIndex(11));
            repo.ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.False1.PressKeys("33 @##vvddd##@@@@@@@@@@$ test that any character can be typed in no validatn");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.False' at 139;6.", repo.ApplicationUnderTest.FalseInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.False.Click("139;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Value cannot exceed 75 characters') on item 'ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.ValueCannotExceed75Characters1'.", repo.ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.ValueCannotExceed75Characters1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FormFlexWrapperNgPristineNgTouched.ValueCannotExceed75Characters1Info, "InnerText", "Value cannot exceed 75 characters");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
