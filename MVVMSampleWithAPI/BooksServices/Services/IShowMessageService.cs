﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksServices.Services
{
    public interface IShowMessageService
    {
        Task ShowMessageAsync(string message);
    }
}
