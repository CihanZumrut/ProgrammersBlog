﻿using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IMailService
    {
        IResult Send(EmailSendDto emailSendDto); // chnzmrt@gmail.com
        IResult SendContactEmail(EmailSendDto emailSendDto); // chnzmrt@gmail.com info@programmersblog.com iletisim@programmersblog.com
    }
}
