using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto_Beauty365.Models
{
    public class InitializerDB : DropCreateDatabaseIfModelChanges<DB365Context>
    {

        protected override void Seed(DB365Context context)
        {
            // Agrega código aquí para inicializar la base de datos con datos de prueba
        }

    }
}