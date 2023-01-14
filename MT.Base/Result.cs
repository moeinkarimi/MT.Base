using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Base
{
    public class Result<T> 
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public IEnumerable<Error> Errors { get; set; } = Array.Empty<Error>();

        public Result()
        {
            Success = true;
            Errors = Array.Empty<Error>();
            Data = default(T);
        }

        public Result(T data)
        {
            Success = true;
            Errors = Array.Empty<Error>();
            Data = data;
        }

        public Result(bool success)
        {
            Success = success;
            Errors = Array.Empty<Error>();
            Data = default(T);
        }

        public Result(Error error)
        {
            Success = false;
            Errors = new Error[1] { error };
            Data = default(T);
        }

        public Result(IEnumerable<Error> errors)
        {
            Success = false;
            Errors = errors;
            Data = default(T);
        }

        public Result(bool success, Error error)
        {
            Success = success;
            Errors = new Error[1] { error };
            Data = default(T);
        }

        public Result(bool success, IEnumerable<Error> errors)
        {
            Success = success;
            Errors = errors;
            Data = default(T);
        }

        public Result(T data, bool success)
        {
            Success = success;
            Errors = Array.Empty<Error>();
            Data = data;
        }

        public Result(T data, bool success, Error error)
        {
            Success = success;
            Errors = new Error[1] { error };
            Data = data;
        }

        public Result(T data, bool success, IEnumerable<Error> errors)
        {
            Success = success;
            Errors = errors;
            Data = data;
        }


    }
}
