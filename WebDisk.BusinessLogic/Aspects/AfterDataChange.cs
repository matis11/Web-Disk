﻿using PostSharp.Aspects;
using System;
using WebDisk.BusinessLogic.Interfaces;

namespace WebDisk.BusinessLogic.Aspects
{
    [Serializable]
    public class AfterDataChange : OnMethodBoundaryAspect
    {
        public override void OnExit(MethodExecutionArgs args)
        {
            ((ServiceBase)args.Instance).Save();
            base.OnExit(args);
        }
    }
}
