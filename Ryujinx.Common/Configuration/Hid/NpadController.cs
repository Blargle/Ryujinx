﻿namespace Ryujinx.Common.Configuration.Hid
{
    public class NpadController
    {
        /// <summary>
        /// Controller Device Index
        /// </summary>
        public int Index;

        /// <summary>
        ///  Controller's Type
        /// </summary>
        public ControllerType ControllerType;

        /// <summary>
        ///  Controller's ID
        /// </summary>
        public ControllerId ControllerId;

        /// <summary>
        /// Controller Analog Stick Deadzone
        /// </summary>
        public float Deadzone;

        /// <summary>
        /// Controller Trigger Threshold
        /// </summary>
        public float TriggerThreshold;

        /// <summary>
        /// Left JoyCon Controller Bindings
        /// </summary>
        public NpadControllerLeft LeftJoycon;

        /// <summary>
        /// Right JoyCon Controller Bindings
        /// </summary>
        public NpadControllerRight RightJoycon;
    }
}
