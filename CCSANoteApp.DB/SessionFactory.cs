using CCSANoteApp.DB.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSANoteApp.DB
{
    public class SessionFactory
    {
        public SessionFactory()
        {

        }

        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008
                        .ConnectionString(
                            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\Phase II\Asp.Net Api\Notes_Users\NoteAppDB.mdf;Integrated Security=True;Connect Timeout=30")
                        .ShowSql()
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NoteMap>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildSessionFactory();
        }
    }
}