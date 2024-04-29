using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.User;
using MidasAPI.Services;

namespace MidasAPI.Controllers
{

    [ApiController]
    [Route("api/v1/user")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet("GetAllCustomers")]
        public IActionResult GetCustomers(int pageNumber = 1, int pageSize = 5, string fullName ="", 
            string nik = "")
        {
            try
            {
                var res = _service.GetAllCustomer(pageNumber, pageSize, fullName, nik);
                if (res.Count == 0)
                    return NotFound(new ResponseDTO<string[]>()
                    {
                        Message = ConstantConfigs.MESSAGE_NOT_FOUND("Customer"),
                        Status = ConstantConfigs.STATUS_NOT_FOUND,
                        Data = Array.Empty<string>()
                    });

                return Ok(new ResponseWithPaginationDTO<List<UserResponseDTO>>()
                {
                    Message = ConstantConfigs.MESSAGE_GET("Customer"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = res,
                    Pagination = new PaginationDTO()
                    {
                        Page = pageNumber,
                        PageSize = pageSize,
                        TotalData = _service.CountAllCustomers(fullName, nik)
                    }
                });
            }
            catch (System.Exception)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = ConstantConfigs.MESSAGE_FAILED,
                    Status = ConstantConfigs.STATUS_FAILED,
                });
            }
        }

        [HttpGet("GetAllEmployees")]
        public IActionResult GetEmployees(int pageNumber = 1, int pageSize = 5, string fullName = "", 
            string nip = "", string role = "")
        {
            try
            {
                var res = _service.GetAllEmployee(pageNumber, pageSize, fullName, nip, role);
                if (res.Count == 0)
                    return NotFound(new ResponseDTO<string[]>()
                    {
                        Message = ConstantConfigs.MESSAGE_NOT_FOUND("Customer"),
                        Status = ConstantConfigs.STATUS_NOT_FOUND,
                        Data = Array.Empty<string>()
                    });

                return Ok(new ResponseWithPaginationDTO<List<UserResponseDTO>>()
                {
                    Message = ConstantConfigs.MESSAGE_GET("Customer"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = res,
                    Pagination = new PaginationDTO()
                    {
                        Page = pageNumber,
                        PageSize = pageSize,
                        TotalData = _service.CountAllEmployee(fullName, nip, role)
                    }
                });
            }
            catch (System.Exception)
            {
                return BadRequest(new ResponseDTO<string>()
                {
                    Message = ConstantConfigs.MESSAGE_FAILED,
                    Status = ConstantConfigs.STATUS_FAILED,
                });
            }
        }
    }
}
