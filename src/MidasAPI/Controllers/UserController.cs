using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MidasAPI.DTOs.User;
using MidasAPI.Services;
using MidasDataAccess.Models;
using System.Security.Claims;

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

        [Authorize(Roles ="Admin")]
        [HttpGet("get-all-customers")]
        public IActionResult GetCustomers(int page = 1, int pageSize = 5, string fullName ="", 
            string nik = "")
        {
            try
            {
                var res = _service.GetAllCustomer(page, pageSize, fullName, nik);
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
                        Page = page,
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

        [Authorize(Roles = "Admin")]
        [HttpGet("get-all-employees")]
        public IActionResult GetEmployees(int page = 1, int pageSize = 5, string fullName = "", 
            string nip = "", string role = "")
        {
            try
            {
                var res = _service.GetAllEmployee(page, pageSize, fullName, nip, role);
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
                        Page = page,
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

        [Authorize(Roles = "Admin")]
        [HttpGet("get-user-detail")]
        public IActionResult GetUserDetail(string id)
        {
            try
            {
                return Ok(new ResponseDTO<UserDetailDTO>()
                {
                    Message = ConstantConfigs.MESSAGE_GET("User"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = _service.GetById(id)
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

        [HttpPost("add-customer")]
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

        [Authorize(Roles ="Admin")]
        [HttpPost("add-employee")]
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

                _service.AddEmployee(employeeRegisterDTO, User.FindFirstValue("userId")??"");

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

        [Authorize(Roles = "Customer")]
        [HttpPut("update-customer/{userId}")]
        public IActionResult UpdateCustomer(CustomerUpdateDTO customerUpdateDTO)
        {
            try
            {
                if (customerUpdateDTO.IdentityNumber.Length != 16)
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "NIK harus berjumlah 16 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = customerUpdateDTO.IdentityNumber
                    });
                else if (customerUpdateDTO.PhoneNumber.Length < 10 ||
                    customerUpdateDTO.PhoneNumber.Length > 13)
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "Nomor telepon harus berjumlah 10-13 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = customerUpdateDTO.PhoneNumber
                    });

                _service.UpdateCustomer(customerUpdateDTO, User.FindFirstValue("userId") ?? "");

                return Ok(new ResponseDTO<CustomerUpdateDTO>()
                {
                    Message = ConstantConfigs.MESSAGE_POST("Customer"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = customerUpdateDTO
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

        [Authorize]
        [HttpPut("update-employee/{userId}")]
        public IActionResult UpdateEmployee(EmployeeUpdateDTO employeeUpdateDTO)
        {
            try
            {
                if (employeeUpdateDTO.IdentityNumber.Length > 20)
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "NIP hanya diperbolehkan maksimal 20 digit",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = employeeUpdateDTO.IdentityNumber
                    });

                _service.UpdateEmployee(employeeUpdateDTO, User.FindFirstValue("userId") ?? "");

                return Ok(new ResponseDTO<EmployeeUpdateDTO>()
                {
                    Message = ConstantConfigs.MESSAGE_POST("Karyawan"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = employeeUpdateDTO
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

        [Authorize(Roles = "Admin")]
        [HttpPatch("reset-password/{userId}")]
        public IActionResult ResetPassword(string userId)
        {
            try
            {
                _service.ResetPassword(userId);

                return Ok(new ResponseDTO<string>()
                {
                    Message = ConstantConfigs.MESSAGE_PUT("User"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = userId
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

        [Authorize]
        [HttpPatch("change-password")]
        public IActionResult ChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            try
            {
                if (changePasswordDTO.newPassword == changePasswordDTO.oldPassword)
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "Password baru tidak bisa sama dengan password lama",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = changePasswordDTO.newPassword
                    });

                bool isChanged = _service.ChangePassword(changePasswordDTO, User.FindFirstValue("userId") ?? "");

                if(!isChanged)
                    return BadRequest(new ResponseDTO<string>()
                    {
                        Message = "Password lama tidak sesuai",
                        Status = ConstantConfigs.STATUS_FAILED,
                        Data = changePasswordDTO.oldPassword
                    });

                return Ok(new ResponseDTO<string>()
                {
                    Message = ConstantConfigs.MESSAGE_PUT("User"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = changePasswordDTO.newPassword
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

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete-user/{userId}")]
        public IActionResult DeleteUser(string userId)
        {
            try
            {
                _service.DeleteUser(userId, User.FindFirstValue("userId") ?? "");

                return Ok(new ResponseDTO<string>()
                {
                    Message = ConstantConfigs.MESSAGE_DELETE("User"),
                    Status = ConstantConfigs.STATUS_OK,
                    Data = userId
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
