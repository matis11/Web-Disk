﻿using WebDisk.Database.DatabaseModel.Types;

namespace WebDisk.BusinessLogic.ViewModels
{
    public class FieldBusinessLogicViewModel
    {
        public string Name { get; set; }
        //public string Extension
        //{
        //    get
        //    {
        //        if (Type != FieldType.File)
        //        {
        //            return string.Empty;
        //        }

        //    }
        //    set;
        //}
        public FieldType Type { get; set; }
        public bool IsShared { get; set; }

    }
}
