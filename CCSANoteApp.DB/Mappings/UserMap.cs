using CCSANoteApp.Domain;
using FluentNHibernate.Mapping;

namespace CCSANoteApp.DB.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(user => user.Id);
            Map(user => user.Username);
            Map(user => user.Password);
            Map(user => user.Email);
            HasMany(user => user.Notes);
        }
    }
}
