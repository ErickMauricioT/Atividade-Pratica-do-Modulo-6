using AgenciaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AgenciaAPI.Data
{
    public class ReservaContext : DbContext
    {
        public ReservaContext(DbContextOptions<ReservaContext> options) : base(options)
        {
        }



        public DbSet<Reserva> Reservas { get; set; }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reserva>()
       .Property(r => r.CheckIn)
       .HasColumnType("datetime");

            modelBuilder.Entity<Reserva>().HasData(
                new Reserva { Id = 1, Nome = "Bruce Dickinson", CPF = 09988890098, Numero = 81988880099,CheckIn = new DateTime(2024, 02, 19, 10, 30, 0), Pessoas = 4, Destino = "Alagoas", Valor = 1.582, DestinoURL = "https://images.unsplash.com/photo-1625841028984-5a4c1a657e19?q=80&w=1473&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                 new Reserva { Id = 2, Nome = "Steve Harris", CPF = 88876543212, Numero = 83977890000, CheckIn = new DateTime(2024, 02, 10, 23, 58, 0), Pessoas = 7, Destino = "Recife", Valor = 1.666, DestinoURL = "https://images.unsplash.com/photo-1612383892465-153167840470?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                  new Reserva { Id = 3, Nome = "Adrian Smith", CPF = 12354376598, Numero = 82977768896, CheckIn = new DateTime(2024, 02, 22, 17, 50,0), Pessoas = 3, Destino = "Paraiba", Valor = 1.288, DestinoURL = "https://images.unsplash.com/photo-1604978472078-5a067d2d0426?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                   new Reserva { Id = 4, Nome = "Nicko McBlain", CPF = 09867823465, Numero = 78976556565, CheckIn = new DateTime(2024, 02, 15, 18, 30, 0), Pessoas = 6, Destino = "Maranhão", Valor = 1.950, DestinoURL = "https://images.unsplash.com/photo-1663641023872-00b4cfae9751?q=80&w=1404&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                   new Reserva { Id = 5, Nome = "Dave Murray", CPF = 99777533101, Numero = 21988800987, CheckIn = new DateTime(2024, 02, 12, 20, 35,0), Pessoas = 5, Destino = "Natal", Valor = 1.489, DestinoURL = "https://images.unsplash.com/photo-1516242981651-2ee338449dea?q=80&w=1374&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                   new Reserva { Id = 6, Nome = "Janick Gers", CPF = 87699088765, Numero = 11988890987, CheckIn = new DateTime(2024, 02, 18, 22, 45,0), Pessoas = 3, Destino = "Sergipe", Valor = 1.899, DestinoURL = "https://images.unsplash.com/photo-1573484770405-d78bb704e7db?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" }

                );

        }

    }
}
