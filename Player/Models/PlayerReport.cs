using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.Models
{
    public class PlayerReport
    {
        ObservableCollection<Players> players;
        public PlayerReport()
        {
            this.players = new ObservableCollection<Players>()
            {
                new Players{Id=1, Name="Pele",Age=81,Picture="Assets/Pele.jpg",Country="Brazil",Email="pele@gmail.com",ClubName="Santos",JoinDate=new DateTime(1974,07,11)},
                new Players{Id=2, Name="Christiano Ronaldo",Age=37,Picture="Assets/Ronaldo.jpg",Country="Portugal",Email="ron@gmail.com",ClubName="Manchester United",JoinDate=new DateTime(2021,06,01),isContinuing=true},
                new Players{Id=3, Name="Marcelo Vieira",Age=34,Picture="Assets/Marcelo.jpg",Country="Brazil",Email="marcelo@gmail.com",ClubName="Real Madrid",JoinDate=new DateTime(2009,06,11),isContinuing=true},
                new Players{Id=4, Name="Karim Benzema",Age=34,Picture="Assets/Benzama.jpg",Country="France",Email="benzema@gmail.com",ClubName="Real Madrid",JoinDate=new DateTime(2011,05,11),isContinuing=true},
                new Players{Id=5, Name="Mesut Özil",Age=33,Picture="Assets/Ozil.jpg",Country="Germany",Email="ozil@gmail.com",ClubName="Arsenal",JoinDate=new DateTime(2013,06,05)},
                new Players{Id=6, Name="Zinedine Zidane",Age=49,Picture="Assets/Zidane.jpg",Country="France",Email="zidane@gmail.com",ClubName="Real Madrid",JoinDate=new DateTime(2003,07,11)},
                new Players{Id=7, Name="Ronaldinho",Age=42,Picture="Assets/Ronaldinho.jpg",Country="Brazil",Email="ronaldinho@gmail.com",ClubName="Flamengo",JoinDate=new DateTime(2011,07,11)},
                new Players{Id=8, Name="Kaka",Age=40,Picture="Assets/Kaka.jpg",Country="Brazil",Email="kaka@gmail.com",ClubName="Orlando City",JoinDate=new DateTime(2014,07,11)},
                new Players{Id=9, Name="Mohamed Salah",Age=29,Picture="Assets/Salah.jpg",Country="Egypt",Email="salah@gmail.com",ClubName="Liverpool",JoinDate=new DateTime(2017,06,10),isContinuing=true},
                new Players{Id=10, Name="Kylian Mbappé",Age=23,Picture="Assets/Mbappe.jpg",Country="France",Email="mbappe@gmail.com",ClubName="PSG",JoinDate=new DateTime(2019,07,01),isContinuing=true},
                new Players{Id=11, Name="Luca Modric",Age=36,Picture="Assets/Luca.jpg",Country="Croatia",Email="modric@gmail.com",ClubName="Real Madrid",JoinDate=new DateTime(2012,07,01),isContinuing=true},
                new Players{Id=12, Name="Earling Haaland",Age=21,Picture="Assets/Haaland.jpg",Country="Norwegian",Email="haaland@gmail.com",ClubName="Brussia Dortmund",JoinDate=new DateTime(2020,07,01),isContinuing=true},
                new Players{Id=13, Name="Virgil van Dijk",Age=30,Picture="Assets/Dijk.jpg",Country="Netherland",Email="dijk@gmail.com",ClubName="LiverPool",JoinDate=new DateTime(2017,07,01),isContinuing=true},
                new Players{Id=14, Name="Angel Di Maria",Age=34,Picture="Assets/Di Maria.jpg",Country="Argentina",Email="dimaria@gmail.com",ClubName="PSG",JoinDate=new DateTime(2016,06,10),isContinuing=true},
                new Players{Id=15, Name="Sergio Agüero",Age=33,Picture="Assets/Aguero.jpg",Country="Argentina",Email="aguero@gmail.com",ClubName="Manchester City",JoinDate=new DateTime(2016,06,01),isContinuing=true},
            };
        }
        public ObservableCollection<Players> Get()
        {
            return this.players;
        }
        public Players Get (int id)
        {
            return this.players.FirstOrDefault(t => t.Id == id);
        }
    }
}
