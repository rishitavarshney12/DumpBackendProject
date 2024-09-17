using AutoMapper;
using Employee.Domain.Contracts;
using Employee.Domain.Model.Dtos;
using Employee.Domain.Model.Entities;

namespace Employee.Service
{
    public class EmpService : IEmpService
    {
        private readonly IMapper _mapper;
        private readonly IEmpTableRepository _empTableRepository;
        public EmpService(IMapper mapper, IEmpTableRepository empTableRepository)
        {
            _empTableRepository = empTableRepository;
            _mapper = mapper;
        }
        public async Task<List<EmpTableDto>> GetBy(int id)
        {
            return _mapper.Map<List<EmpTableDto>>(await _empTableRepository.FetchBy(id));
        }
        public async Task<List<EmpTableDto>> GetAll()
        {
            return _mapper.Map<List<EmpTableDto>>(await _empTableRepository.FetchAll());
        }


        public async Task<short> Save(EmpTableDto empTableDto)
        {

            EmpTable empTable = _mapper.Map<EmpTable>(empTableDto);
            short empId = await _empTableRepository.Create(empTable);

            return empId;
        }

    }
}
