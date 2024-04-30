using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.User;
using MidasAPI.Services;
using MidasDataAccess.Models;

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

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(CustomerRegisterDTO customerRegisterDTO)
        {
            try
            {
                if (customerRegisterDTO.IdentityNumber.Length != 16)
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "NIK harus berjumlah 16 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = customerRegisterDTO.IdentityNumber
                    });
                else if (customerRegisterDTO.PhoneNumber.Length < 10 ||
                    customerRegisterDTO.PhoneNumber.Length > 13)
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "Nomor telepon harus berjumlah 10-13 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = customerRegisterDTO.PhoneNumber
                    });

                _service.AddCustomer(customerRegisterDTO);

                return Ok(new ResponseDTO<CustomerRegisterDTO>()
                {
                    Message = ConstantConfigs.MESSAGE_POST("Customer"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = customerRegisterDTO
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

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(EmployeeRegisterDTO employeeRegisterDTO)
        {
            try
            {
                if (employeeRegisterDTO.IdentityNumber.Length > 20)
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "NIP hanya diperbolehkan maksimal 20 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = employeeRegisterDTO.IdentityNumber
                    });

                _service.AddEmployee(employeeRegisterDTO);

                return Ok(new ResponseDTO<EmployeeRegisterDTO>()
                {
                    Message = ConstantConfigs.MESSAGE_POST("Karyawan"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = employeeRegisterDTO
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
