using AutoMapper;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Models.Equipment;
using ExerciseApi.Data;
using ExerciseApi.Helpers;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher
{
    public class DefaultEquipmentFetcherService : IEquipmentFetcherService
    {
        private readonly IMapper _mapper;
        public DefaultEquipmentFetcherService()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaseEquipment, EquipmentEntity>());
            _mapper = config.CreateMapper();
        }
        public OperationResult<EquipmentEntity> GetEquipmentById(string equipmentId)
        {
            var result = _mapper.Map<EquipmentEntity>(DataSeeding.Towel());
            return new OperationResult<EquipmentEntity>(OperationStatus.Success, String.Empty, result);

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