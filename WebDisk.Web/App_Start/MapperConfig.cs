﻿using System.Web;
using WebDisk.BusinessLogic.ViewModels;
using WebDisk.Database.DatabaseModel;
using WebDisk.Web.Models.Home;

namespace WebDisk.Web.App_Start
{
    public static class MapperConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(n =>
            {
                n.CreateMap<Field, FieldViewModel>();
                n.CreateMap<HttpPostedFileBase, FileViewModel>();
            });
        }
    }
}