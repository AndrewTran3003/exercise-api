using AutoMapper;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Models.Equipment;
using ExerciseApi.Data;
using ExerciseApi.Helpers;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Repository;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service
{
    public class DefaultEquipmentFetcherService : IEquipmentFetcherService
    {
        private readonly IMapper _mapper;
        private readonly IEquipmentFetcherRepository _repo;
        public DefaultEquipmentFetcherService(IEquipmentFetcherRepository repo)
        {
            _repo = repo;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaseEquipment, EquipmentEntity>());
            _mapper = config.CreateMapper();
        }
        public async Task<OperationResult<EquipmentEntity>> GetEquipmentByIdAsync(string equipmentId)
        {
            return await _repo.GetAsync(equipmentId);
        }

        public OperationResult<List<EquipmentEntity>> GetAllEquipments()
        {
            var result = new List<EquipmentEntity>{
                _mapper.Map<EquipmentEntity>(DataSeeding.Towel()),
                _mapper.Map<EquipmentEntity>(DataSeeding.Treadmill())
            };
            return new OperationResult<List<EquipmentEntity>>(OperationStatus.Success, String.Empty, result);
        }
    }
}