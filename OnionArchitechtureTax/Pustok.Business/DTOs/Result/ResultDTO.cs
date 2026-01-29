using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pustok.Business.DTOs;

public class ResultDTO
{
    public bool IsSucced { get; set; }
    public int StatusCode { get; set; }
    public string Message { get; set; } = string.Empty;

    public ResultDTO()
    {
        IsSucced = true;
        StatusCode = 200;
        Message = "Successfully";
    }

    public ResultDTO(string message):this()
    {
        Message = message;
    }

    public ResultDTO(string message,int statusCode) : this(message)
    {
        StatusCode = statusCode;
    }
    public ResultDTO(string message, int statusCode,bool isSucced) : this(message,statusCode)
    {
        IsSucced = isSucced;
    }
}
