using AutoMapper;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using DAL.Entities;
using DAL.Repository.Interfaces;

namespace BusinessLayer.Services
{
    public class PerfumeService : IPerfumeService
    {
        private IPerfumeRepository _perfumeRepository;
        private IMapper _mapper;

        public PerfumeService(IPerfumeRepository perfumeRepository, IMapper mapper)
        {
            _perfumeRepository = perfumeRepository;
            _mapper = mapper;
        }

        public IEnumerable<PerfumeViewModel> GetAll()
        {
            List<Perfume> perfumeList = _perfumeRepository.GetAll().ToList();
            List<PerfumeViewModel> perfumeViewModels = _mapper.Map<List<PerfumeViewModel>>(perfumeList);

            return perfumeViewModels;
        }

        public void SavePerfume(PerfumeViewModel perfumeViewModel)
        {
            Perfume perfume = new Perfume();
            perfume.Name = perfumeViewModel.Name;
            _perfumeRepository.Add(perfume);

        }

        public void DeletePerfumeById(Guid id)
        {
            _perfumeRepository.DeleteById(id);
        }

        public PerfumeViewModel GetPerfumeViewModelById(Guid id)
        {
            Perfume perfume = _perfumeRepository.GetById(id);
            PerfumeViewModel perfumeViewModel = _mapper.Map<PerfumeViewModel>(perfume);

            return perfumeViewModel;
        }
        public void UpdatePerfume(PerfumeViewModel perfumeViewModel)
        {
            Perfume perfume = _mapper.Map<Perfume>(perfumeViewModel);
            _perfumeRepository.Update(perfume);
        }
    }
}
