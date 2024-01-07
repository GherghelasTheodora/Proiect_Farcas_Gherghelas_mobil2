using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Proiect_Farcas_Gherghelas_mobil.Models;

namespace Proiect_Farcas_Gherghelas_mobil.Data
{

    //contine cod pentru creare, citire, scriere si stergere
    public class PartiiDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public PartiiDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Partie>().Wait();
            _database.CreateTableAsync<Inchiriere>().Wait();
            _database.CreateTableAsync<Produs>().Wait();
            _database.CreateTableAsync<Programare>().Wait();
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<User> GetUserAsync(int ID)
        {
            return _database.Table<User>()
                .Where(i => i.ID == ID)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            if (user.ID!=0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }

        public Task<int> DeleteUserAsync(User user)
        {
            return _database.DeleteAsync(user);
        }


        public Task<List<Programare>> GetProgramariAsync()
        {
            return _database.Table<Programare>().ToListAsync();
        }

        public Task<Programare> GetProgramareAsync(int ID)
        {
            return _database.Table<Programare>()
                .Where(i => i.ID == ID)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveProgramareAsync(Programare programare)
        {
            if (programare.ID != 0)
            {
                return _database.UpdateAsync(programare);
            }
            else
            {
                return _database.InsertAsync(programare);
            }
        }

        public Task<int> DeleteProgramareAsync(Programare programare)
        {
            return _database.DeleteAsync(programare);
        }

        public Task<List<Produs>> GetProduseAsync()
        {
            return _database.Table<Produs>().ToListAsync();
        }

        public Task<Produs> GetProdusAsync(int ID)
        {
            return _database.Table<Produs>()
                .Where(i => i.ID == ID)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveProdusAsync(Produs produs)
        {
            if (produs.ID !=0)
            {
                return _database.UpdateAsync(produs);
            }
            else
            {
                return _database.InsertAsync(produs);
            }
        }

        public Task<int> DeleteProdusAsync(Produs produs)
        {
            return _database.DeleteAsync(produs);
        }


        public Task<List<Inchiriere>>GetInchirieriAsync()
        {
            return _database.Table<Inchiriere>().ToListAsync();
        }

        public Task<Inchiriere> GetInchiriereAsync(int ID)
        {
            return _database.Table<Inchiriere>()
                .Where(i=> i.ID ==ID)
                .FirstOrDefaultAsync();
            //AICI TRB FIRST OR DEFAULT???
        }

        public Task<int> SaveInchiriereAsync(Inchiriere inchiriere)
        {
            if (inchiriere.ID!=0)
            {
                return _database.UpdateAsync(inchiriere);
            }
            else
            {
                return _database.InsertAsync(inchiriere);
            }
        }

        public Task<int> DeleteInchiriereAsync(Inchiriere inchiriere)
        {
            return _database.DeleteAsync(inchiriere);
        }

        public Task<List<Partie>> GetPartiiAsync()
        {
            return _database.Table<Partie>().ToListAsync();
        }

        public Task<Partie> GetPartieAsync(int ID)
        {
            return _database.Table<Partie>()
                .Where(i => i.ID == ID)
                .FirstOrDefaultAsync();
        }

        public Task<int> SavePartieAsync(Partie partie)
        {
            if (partie.ID!=0)
            {
                return _database.UpdateAsync(partie);
            }
            else
            {
                return _database.InsertAsync(partie);
            }
        }

        public Task<int> DeletePartieAsync(Partie partie)
        {
            return _database.DeleteAsync(partie);
        }

    }
}
