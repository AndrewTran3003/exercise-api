using AutoMapper;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Models.Equipment;
using ExerciseApi.Data;
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
        public EquipmentEntity GetEquipmentById(string equipmentId)
        {
            return _mapper.Map<EquipmentEntity>(DataSeeding.Towel());
        }

        public List<EquipmentEntity> GetAllEquipments()
        {
            return new List<EquipmentEntity>{
                _mapper.Map<EquipmentEntity>(DataSeeding.Towel()),
                _mapper.Map<EquipmentEntity>(DataSeeding.Treadmill())
            };
        }
    }
}