using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Base.Operation
{
    public class OperationResult<t>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
        public dynamic? Data { get; set; }

        // Constructores estáticos para claridad al retornar
        public static OperationResult<t> Success(dynamic? data = null, string message = "Operación exitosa.")
        {
            return new OperationResult<t>
            {
                IsSuccess = true,
                Message = message,
                Data = data
            };
        }

        public static OperationResult<t> Failure(string message = "Ocurrió un error.")
        {
            return new OperationResult<t>   
            {
                IsSuccess = false,
                Message = message
            };
        }
    }
}
