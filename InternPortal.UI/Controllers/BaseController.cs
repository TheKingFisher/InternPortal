﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace InternPortal.UI.Controllers
{
    public abstract partial class BaseController : Controller
    {
        /// <summary>
        /// Protected IUnitOfWork _unitOfWork;
        /// </summary>
        protected BaseController()
        {
            //_unitOfWork = unitOfWork;
        }

    }
}