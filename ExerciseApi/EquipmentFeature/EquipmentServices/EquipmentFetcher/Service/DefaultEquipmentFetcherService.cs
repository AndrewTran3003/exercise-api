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
        private readonly IEquipmentFetcherRepository _repo;
        public DefaultEquipmentFetcherService(IEquipmentFetcherRepository repo)
        {
            _repo = repo;
        }
        public async Task<OperationResult<EquipmentEntity>> GetEquipmentByIdAsync(string equipmentId)
        {
            return await _repo.GetAsync(equipmentId);
        }

        public async Task<OperationResult<List<EquipmentEntity>>> GetAllEquipmentsAsync()
        {
            return await _repo.GetAllAsync();
        }
    }
}