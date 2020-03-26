﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MksNet.Elements.Xml.Operations.Scalar
{
    internal class Deg2RadOperation : IScalarOperation
    {
        private IScalarOperation operation;

        internal Deg2RadOperation(IScalarOperation operation)
        {
            this.operation = operation;
        }

        public double Resolve(ElementParameter parameter) => Math.PI / 180.0 * operation.Resolve(parameter);
    }
}
