﻿using System;
using System.Collections.Generic;
using XComponent.Common.Helper;
using XComponent.Engine.Execution.HashCode;

namespace XComponent.SwaggerPetstore.Common.StateHashCodeCalculator.UploadFileOperation
{
    public class SuccessResponseReceivedStateHashCodeCalculator : IStateHashCodeCalculator<XComponent.SwaggerPetstore.UserObject.UploadFileOperation, Object>
    {
        public ISet<int> Calculate(XComponent.SwaggerPetstore.UserObject.UploadFileOperation publicMember, Object internalMember)
        {
            var hashcodes = new HashSet<int>();
            return hashcodes;
        }
    }
}
