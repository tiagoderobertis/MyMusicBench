using Microsoft.EntityFrameworkCore;
using MyMusicBench.Connection;
using MyMusicBench.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBench.DataAccess.ModelsRepo.SongsRepo
{
    public class SongsRepository
    {
        private readonly MyMusicBenchContext _context;

        public SongsRepository(MyMusicBenchContext context)
        {
            _context = context;
        }
        public async Task<List<Song>> GetAll()
        {
            return await _context.Songs.ToListAsync();
        }

        public async Task AddSong(string songName, string songAuthor)
        {
            var newSong = new Song()
            {
                SongAuthor = songAuthor,
                SongName = songName,
            };
            await _context.Songs.AddAsync(newSong);
            await _context.SaveChangesAsync();
        }
        public async Task RemoveSong(int id)
        {
            try
            {
                var songToRemove = await _context.Songs.FirstOrDefaultAsync(s => s.Id == id);
                if (songToRemove != null)
                {
                    _context.Remove(songToRemove);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task EditSong(int songId, string newSongName, string newAuthorName)
        {
            var songExists = await _context.Songs.FirstOrDefaultAsync(s => s.Id == songId);
            try
            {
                if (songExists != null)
                {
                    songExists.SongName = newSongName;
                    songExists.SongAuthor = newAuthorName;
                    await _context.SaveChangesAsync();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task<List<Song>> GetSongByName(string songName)
        {
            string toLowerSongName = songName.ToLower();
            var verificacion =  _context.Songs.Any(x => x.SongName.ToLower().Contains(toLowerSongName));
            
            if (verificacion)
            {
                var resultado = await _context.Songs.Where(x => x.SongName.ToLower().Contains(toLowerSongName)).ToListAsync();
                return resultado;
            }
            else return new List<Song>();

        }
        
        public async Task<List<Song>> GetAllSongsOrderByAuthorAToZ()
        {
            var songsList = await GetAll();
            return songsList.OrderBy(x => x.SongAuthor).ToList();
        }

        public async Task<List<Song>> GetAllSongsOrderByAuthorZToA()
        {
            var songsList = await GetAll();
            return songsList.OrderByDescending(x => x.SongAuthor).ToList();
        }

        public async Task<List<Song>> GetAllSongsOrderByNameAToZ()
        {
            var songsList = await GetAll();
            return songsList.OrderBy(x => x.SongName).ToList();
        }

        public async Task<List<Song>> GetAllSongsOrderByNameZToA()
        {
            var songsList = await GetAll();
            return songsList.OrderByDescending(x => x.SongName).ToList();
        }

        public async Task<List<Song>> GetAllSongsFromAuthor(string songAuthor)
        {
            return await _context.Songs.Where(x => x.SongAuthor == songAuthor).ToListAsync();
        }
    }
    
}
