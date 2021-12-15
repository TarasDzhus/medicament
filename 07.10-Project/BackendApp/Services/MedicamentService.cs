using BackendApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BackendApp.Interfaces;
using System.Linq;

namespace BackendApp.Services
{
    public class MedicamentService : IMedicamentService
    {
        private readonly DatabaseContext _dbContext;
        public MedicamentService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            if (!_dbContext.Medicaments.Any())
            {
                _dbContext.Medicaments.Add(new Medicament { Name = "Бинт", MedicamentQty = 20 });
                _dbContext.Medicaments.Add(new Medicament { Name = "Серветки з хлоргексидином", MedicamentQty = 10 });
                _dbContext.Medicaments.Add(new Medicament { Name = "Розчин йоду 5%", MedicamentQty = 7 });
                _dbContext.Medicaments.Add(new Medicament { Name = "Нітрогліцерин 1%", MedicamentQty = 8 });
                _dbContext.Medicaments.Add(new Medicament { Name = "Рукавиці медичні", MedicamentQty = 9 });
                _dbContext.Medicaments.Add(new Medicament { Name = "Фіксатор шийного відділу хребта", MedicamentQty = 5 });
                _dbContext.Medicaments.Add(new Medicament { Name = "Портативний апарат для штучної вентиляції легенів АМБУ", MedicamentQty = 12 });
                _dbContext.Medicaments.Add(new Medicament { Name = "Сульфаціл натрію 20%", MedicamentQty = 54 });
                _dbContext.Medicaments.Add(new Medicament { Name = "мінеральна вода 'Лужанська'", MedicamentQty = 8 });
                _dbContext.Medicaments.Add(new Medicament { Name = "Буторфанолу тартрат 0,2%", MedicamentQty = 7 });
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Medicament> GetMedicament()
        {
            var medicament = _dbContext.Medicaments.ToList();
            return medicament;
        }
        public Medicament GetMedicamentById(int id)
        {
            var medicament = _dbContext.Medicaments.FirstOrDefault(x => x.Id == id);
            return medicament;
        }

        public Medicament AddMedicament(Medicament medicament)
        {
            if (medicament != null)
            {
                _dbContext.Medicaments.Add(medicament);
                _dbContext.SaveChanges();
                return medicament;
            }
            return null;
        }
        public Medicament UpdateMedicament(Medicament medicament)
        {
            _dbContext.Entry(medicament).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return medicament;
        }
        public Medicament DeleteMedicament(int id)
        {
            var medicament = _dbContext.Medicaments.FirstOrDefault(x => x.Id == id);
            _dbContext.Entry(medicament).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return medicament;
        }

        /*public async Task CreateMedicament(Medicament medicament)
        {
            await _dbContext.Medicaments.AddAsync(medicament);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Medicament>> ReadMedicaments()
        {
            return await _dbContext.Medicaments.ToListAsync();
        }

        public async Task<Medicament> ReadMedicament(int id)
        {
            var medicament = await _dbContext.Medicaments.FindAsync(id);
            if (medicament == null)
            {
                return NotFound();
            }
            return medicament;
        }

        public async Task UpdateMedicament(Medicament medicament)
        {
            _dbContext.Entry(medicament).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Medicament> DeleteMedicament(int id)
        {
            var medicament = await _dbContext.Medicaments.FindAsync(id);
            if (medicament == null)
            {
                return NotFound();
            }
            _dbContext.Medicaments.Remove(medicament);
            await _dbContext.SaveChangesAsync();
            return medicament;
        }*/

    }
}
