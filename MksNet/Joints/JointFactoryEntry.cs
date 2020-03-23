﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MksNet.Joints
{
    internal class JointFactoryEntry
    {

        internal string Name;

        internal string Author;

        internal string Description;

        internal string Url;

        internal List<DOF> LockedDofs;

        internal List<DOF> FreeDofs;

    }
}
