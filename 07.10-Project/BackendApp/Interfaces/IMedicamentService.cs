using BackendApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BackendApp.Interfaces
{
    public interface IMedicamentService
    {
        public IEnumerable<Medicament> GetMedicament();
        public Medicament GetMedicamentById(int id);
        public Medicament AddMedicament(Medicament medicament);
        public Medicament UpdateMedicament(Medicament medicament);
        public Medicament DeleteMedicament(int id);

        /*public Task CreateMedicament(Medicament medicament);
        public Task <List<Medicament>> ReadMedicaments();
        public Task<Medicament> ReadMedicament(int id);
        public Task UpdateMedicament(Medicament medicament);
        public Task<Medicament> DeleteMedicament(int id);*/
    }
}
