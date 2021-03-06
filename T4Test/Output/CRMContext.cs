 
 

////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////






using System.Collections.Generic;
using CRM.Entities;
using CRM.Repositories;
using Core.Infrastructure;

namespace CRM.Repositories
{

    public class CRMContext : DbContext
    {
        public CRMContext () : base("CRMConnectionString")
        {
            Database.SetInitializer<CRMContext>(new DropCreateDatabaseIfModelChanges<CRMContext>());
        }

				public virtual DbSet<Account> Accounts { get; set; }
				public virtual DbSet<Ball> Balls { get; set; }
				public virtual DbSet<Activity> Activitys { get; set; }
				public virtual DbSet<ActivityType> ActivityTypes { get; set; }
				public virtual DbSet<Address> Addresss { get; set; }
				public virtual DbSet<AddressType> AddressTypes { get; set; }
				public virtual DbSet<Campaign> Campaigns { get; set; }
				public virtual DbSet<Case> Cases { get; set; }
				public virtual DbSet<Contact> Contacts { get; set; }
				public virtual DbSet<Country> Countrys { get; set; }
				public virtual DbSet<Email> Emails { get; set; }
				public virtual DbSet<Engagement> Engagements { get; set; }
				public virtual DbSet<EngagementType> EngagementTypes { get; set; }
				public virtual DbSet<Enquiry> Enquirys { get; set; }
				public virtual DbSet<Incident> Incidents { get; set; }
				public virtual DbSet<Oppertunity> Oppertunitys { get; set; }
				public virtual DbSet<Role> Roles { get; set; }
				public virtual DbSet<Stage> Stages { get; set; }
				public virtual DbSet<State> States { get; set; }
				public virtual DbSet<Suburb> Suburbs { get; set; }
				public virtual DbSet<Task> Tasks { get; set; }
				public virtual DbSet<Todo> Todos { get; set; }
				public virtual DbSet<User> Users { get; set; }
				public virtual DbSet<WebPresense> WebPresenses { get; set; }
	
	}
 }

