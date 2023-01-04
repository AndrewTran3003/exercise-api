using AutoMapper;
using ExerciseApi.Data;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;
using ExerciseApi.Models.Equipment;
using Microsoft.EntityFrameworkCore;

namespace ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Repository
{
    public class DefaultEquipmentFetcherRepository : IEquipmentFetcherRepository
    {
        private readonly ExerciseApiDbContext _context;
        private readonly IMapper _mapper;

        public DefaultEquipmentFetcherRepository(ExerciseApiDbContext context)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaseEquipment, EquipmentEntity>());
            _mapper = config.CreateMapper();
            _context = context;
        }
        public async Task<OperationResult<EquipmentEntity>> GetAsync(string equipmentId)
        {
            var result = await _context.BaseEquipments.FirstOrDefaultAsync(e => e.Id.ToString() == equipmentId);
            return result == null
                ? new OperationResult<EquipmentEntity>(OperationStatus.NotFound, $"Cannot find equipment with Id {equipmentId}", null)
                : new OperationResult<EquipmentEntity>(OperationStatus.Success, string.Empty, _mapper.Map<EquipmentEntity>(result));
        }
    }
}