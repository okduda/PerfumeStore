using BusinessLayer.ViewModels;

namespace BusinessLayer.Services.Interfaces
{
    public interface IPerfumeService
    {
        public IEnumerable<PerfumeViewModel> GetAll();

        void SavePerfume(PerfumeViewModel perfumeViewModel);
        void DeletePerfumeById(Guid id);
        PerfumeViewModel GetPerfumeViewModelById(Guid id);
        void UpdatePerfume(PerfumeViewModel perfumeViewModel);
    }
}
