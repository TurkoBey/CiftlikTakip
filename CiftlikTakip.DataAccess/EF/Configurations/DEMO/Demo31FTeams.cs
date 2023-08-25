using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
	public class Demo31FTeams
	{
		public static void Data(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<FTeam>().HasData(new FTeam
			{
				Id = new Guid("C89B92F0-C38D-4B6A-8CC2-2D8753495080"),
				FullName = "TurkoBEY",
				Twitter = "elonmusk",
				Facebook = "zuck",
				Instagram = "zuck",
				LinkedIn = "company/spacex",
				PhotoPath = "/assets/img/team/23bcacad-b9e5-4e31-bdc4-e6c04bbcdf75.jpg",
				Role = "Front-End Developer",
				Description = "Aliquam iure quaerat voluptatem praesentium possimus unde laudantium vel dolorum distinctio dire flow",
				CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
				CreationDate = DateTime.Now,
				UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
				UpdateDate = DateTime.Now,
				IsActive = true,
				Version = BitConverter.GetBytes(DateTime.Now.Ticks)
			}, new FTeam
			{
				Id = new Guid("B89B92F0-C38D-4B6A-8CC2-2D8753495080"),
				FullName = "TurkoBEY",
				Twitter = "elonmusk",
				Facebook = "zuck",
				Instagram = "zuck",
				LinkedIn = "company/spacex",
				PhotoPath = "/assets/img/team/f6c718cc-f271-4180-92fc-ab32f9239f60.jpg",
				Role = "Back-End Developer",
				Description = "Aliquam iure quaerat voluptatem praesentium possimus unde laudantium vel dolorum distinctio dire flow",
				CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
				CreationDate = DateTime.Now,
				UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
				UpdateDate = DateTime.Now,
				IsActive = true,
				Version = BitConverter.GetBytes(DateTime.Now.Ticks)
			}, new FTeam
			{
				Id = new Guid("A89B92F0-C38D-4B6A-8CC2-2D8753495080"),
				FullName = "TurkoBEY",
				Twitter = "elonmusk",
				Facebook = "zuck",
				Instagram = "zuck",
				LinkedIn = "company/spacex",
				PhotoPath = "/assets/img/team/0c999885-f92d-4193-8909-460f2f773fec.jpg",
				Role = "Chief Executive Officer",
				Description = "Aliquam iure quaerat voluptatem praesentium possimus unde laudantium vel dolorum distinctio dire flow",
				CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
				CreationDate = DateTime.Now,
				UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
				UpdateDate = DateTime.Now,
				IsActive = true,
				Version = BitConverter.GetBytes(DateTime.Now.Ticks)
			});
		}
	}
}
