using FolioApp.Domain.DbModels;
using Microsoft.EntityFrameworkCore;

namespace FolioApp.Domain.DataTransfer
{
    public class StorageContext
    {
        DbSet<DbPicture> Pictures { get; set; }
    }
}
