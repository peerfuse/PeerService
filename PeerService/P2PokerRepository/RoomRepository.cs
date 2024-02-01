using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using P2PokerBean;
using P2PokerContext;
using P2PokerEntitys;
using P2PokerEnums;
using P2PokerExceptions;
using P2pokerInterface;

namespace P2PokerRepository;

    public class RoomRepository : IP2PokerRepository
    {
        P2pokerDbContext _catalogDb;

        public RoomRepository(P2pokerDbContext dbContext)
            => _catalogDb = dbContext;

        public async Task Insert(Room room)
        {
            _catalogDb._rooms.Add(room.UUID,room);
            await Task.CompletedTask;
        }

        public async Task InsertUser(Guid romId, Client client)
        {
            await Task.CompletedTask;
        }

        public Room Get(Guid Id)
        =>_catalogDb._rooms.GetValueOrDefault(Id)!;

        public async Task Delete(Guid Id)
        {
            _catalogDb._rooms.Remove(Id);
            Room? room = _catalogDb._rooms.GetValueOrDefault(Id);
            if (room is null) await Task.CompletedTask;
        }

        public async Task Update(Room _room)
        {
            Room? room = _catalogDb._rooms.GetValueOrDefault(_room.UUID);
            NotFoundException.ThrowIfNull(room, $"Room '{_room.UUID}' not found.");
            room = _room;
            await Task.CompletedTask;
        }
        public async Task<Room> Search(Guid input)
            => await Task.FromResult(new Room());

        public List<Room> GetRooms()
        {
            List<Room> r = new List<Room>();
            foreach (var _room in _catalogDb._rooms)
            {
                r.Add(_room.Value);
            }

            return r;
        }
    }