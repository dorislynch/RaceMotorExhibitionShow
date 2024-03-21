using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Race.Motor.Exhibition.Show.RNRaceMotorExhibitionShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRaceMotorExhibitionShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRaceMotorExhibitionShowModule"/>.
        /// </summary>
        internal RNRaceMotorExhibitionShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRaceMotorExhibitionShow";
            }
        }
    }
}
