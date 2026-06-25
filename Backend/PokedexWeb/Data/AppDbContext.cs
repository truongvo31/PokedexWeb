using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokedexWeb.Models;

namespace PokedexWeb.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ability> Abilities { get; set; }

    public virtual DbSet<Abilitychange> Abilitychanges { get; set; }

    public virtual DbSet<Abilitychangeeffecttext> Abilitychangeeffecttexts { get; set; }

    public virtual DbSet<Abilityeffecttext> Abilityeffecttexts { get; set; }

    public virtual DbSet<Abilityflavortext> Abilityflavortexts { get; set; }

    public virtual DbSet<Abilityname> Abilitynames { get; set; }

    public virtual DbSet<AuthGroup> AuthGroups { get; set; }

    public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }

    public virtual DbSet<AuthPermission> AuthPermissions { get; set; }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }

    public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; }

    public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; }

    public virtual DbSet<Berry> Berries { get; set; }

    public virtual DbSet<Berryfirmness> Berryfirmnesses { get; set; }

    public virtual DbSet<Berryfirmnessname> Berryfirmnessnames { get; set; }

    public virtual DbSet<Berryflavor> Berryflavors { get; set; }

    public virtual DbSet<Berryflavormap> Berryflavormaps { get; set; }

    public virtual DbSet<Berryflavorname> Berryflavornames { get; set; }

    public virtual DbSet<Characteristic> Characteristics { get; set; }

    public virtual DbSet<Characteristicdescription> Characteristicdescriptions { get; set; }

    public virtual DbSet<Contestcombo> Contestcombos { get; set; }

    public virtual DbSet<Contesteffect> Contesteffects { get; set; }

    public virtual DbSet<Contesteffecteffecttext> Contesteffecteffecttexts { get; set; }

    public virtual DbSet<Contesteffectflavortext> Contesteffectflavortexts { get; set; }

    public virtual DbSet<Contesttype> Contesttypes { get; set; }

    public virtual DbSet<Contesttypename> Contesttypenames { get; set; }

    public virtual DbSet<Egggroup> Egggroups { get; set; }

    public virtual DbSet<Egggroupname> Egggroupnames { get; set; }

    public virtual DbSet<Encounter> Encounters { get; set; }

    public virtual DbSet<Encountercondition> Encounterconditions { get; set; }

    public virtual DbSet<Encounterconditionname> Encounterconditionnames { get; set; }

    public virtual DbSet<Encounterconditionvalue> Encounterconditionvalues { get; set; }

    public virtual DbSet<Encounterconditionvaluemap> Encounterconditionvaluemaps { get; set; }

    public virtual DbSet<Encounterconditionvaluename> Encounterconditionvaluenames { get; set; }

    public virtual DbSet<Encountermethod> Encountermethods { get; set; }

    public virtual DbSet<Encountermethodname> Encountermethodnames { get; set; }

    public virtual DbSet<Encounterslot> Encounterslots { get; set; }

    public virtual DbSet<Evolutionchain> Evolutionchains { get; set; }

    public virtual DbSet<Evolutiontrigger> Evolutiontriggers { get; set; }

    public virtual DbSet<Evolutiontriggername> Evolutiontriggernames { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Generation> Generations { get; set; }

    public virtual DbSet<Generationname> Generationnames { get; set; }

    public virtual DbSet<Growthrate> Growthrates { get; set; }

    public virtual DbSet<Growthratedescription> Growthratedescriptions { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Itemattribute> Itemattributes { get; set; }

    public virtual DbSet<Itemattributedescription> Itemattributedescriptions { get; set; }

    public virtual DbSet<Itemattributemap> Itemattributemaps { get; set; }

    public virtual DbSet<Itemattributename> Itemattributenames { get; set; }

    public virtual DbSet<Itemcategory> Itemcategories { get; set; }

    public virtual DbSet<Itemcategoryname> Itemcategorynames { get; set; }

    public virtual DbSet<Itemeffecttext> Itemeffecttexts { get; set; }

    public virtual DbSet<Itemflavortext> Itemflavortexts { get; set; }

    public virtual DbSet<Itemflingeffect> Itemflingeffects { get; set; }

    public virtual DbSet<Itemflingeffecteffecttext> Itemflingeffecteffecttexts { get; set; }

    public virtual DbSet<Itemgameindex> Itemgameindices { get; set; }

    public virtual DbSet<Itemname> Itemnames { get; set; }

    public virtual DbSet<Itempocket> Itempockets { get; set; }

    public virtual DbSet<Itempocketname> Itempocketnames { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Languagename> Languagenames { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Locationarea> Locationareas { get; set; }

    public virtual DbSet<Locationareaencounterrate> Locationareaencounterrates { get; set; }

    public virtual DbSet<Locationareaname> Locationareanames { get; set; }

    public virtual DbSet<Locationgameindex> Locationgameindices { get; set; }

    public virtual DbSet<Locationname> Locationnames { get; set; }

    public virtual DbSet<Machine> Machines { get; set; }

    public virtual DbSet<Move> Moves { get; set; }

    public virtual DbSet<Moveattribute> Moveattributes { get; set; }

    public virtual DbSet<Moveattributedescription> Moveattributedescriptions { get; set; }

    public virtual DbSet<Moveattributemap> Moveattributemaps { get; set; }

    public virtual DbSet<Moveattributename> Moveattributenames { get; set; }

    public virtual DbSet<Movebattlestyle> Movebattlestyles { get; set; }

    public virtual DbSet<Movebattlestylename> Movebattlestylenames { get; set; }

    public virtual DbSet<Movechange> Movechanges { get; set; }

    public virtual DbSet<Movedamageclass> Movedamageclasses { get; set; }

    public virtual DbSet<Movedamageclassdescription> Movedamageclassdescriptions { get; set; }

    public virtual DbSet<Movedamageclassname> Movedamageclassnames { get; set; }

    public virtual DbSet<Moveeffect> Moveeffects { get; set; }

    public virtual DbSet<Moveeffectchange> Moveeffectchanges { get; set; }

    public virtual DbSet<Moveeffectchangeeffecttext> Moveeffectchangeeffecttexts { get; set; }

    public virtual DbSet<Moveeffecteffecttext> Moveeffecteffecttexts { get; set; }

    public virtual DbSet<Moveflavortext> Moveflavortexts { get; set; }

    public virtual DbSet<Movelearnmethod> Movelearnmethods { get; set; }

    public virtual DbSet<Movelearnmethoddescription> Movelearnmethoddescriptions { get; set; }

    public virtual DbSet<Movelearnmethodname> Movelearnmethodnames { get; set; }

    public virtual DbSet<Movemetaailment> Movemetaailments { get; set; }

    public virtual DbSet<Movemetaailmentname> Movemetaailmentnames { get; set; }

    public virtual DbSet<Movemetacategory> Movemetacategories { get; set; }

    public virtual DbSet<Movemetacategorydescription> Movemetacategorydescriptions { get; set; }

    public virtual DbSet<Movemetastatchange> Movemetastatchanges { get; set; }

    public virtual DbSet<Movemetum> Movemeta { get; set; }

    public virtual DbSet<Movename> Movenames { get; set; }

    public virtual DbSet<Movetarget> Movetargets { get; set; }

    public virtual DbSet<Movetargetdescription> Movetargetdescriptions { get; set; }

    public virtual DbSet<Movetargetname> Movetargetnames { get; set; }

    public virtual DbSet<Nature> Natures { get; set; }

    public virtual DbSet<Naturebattlestylepreference> Naturebattlestylepreferences { get; set; }

    public virtual DbSet<Naturename> Naturenames { get; set; }

    public virtual DbSet<Naturepokeathlonstat> Naturepokeathlonstats { get; set; }

    public virtual DbSet<Palpark> Palparks { get; set; }

    public virtual DbSet<Palparkarea> Palparkareas { get; set; }

    public virtual DbSet<Palparkareaname> Palparkareanames { get; set; }

    public virtual DbSet<Pokeathlonstat> Pokeathlonstats { get; set; }

    public virtual DbSet<Pokeathlonstatname> Pokeathlonstatnames { get; set; }

    public virtual DbSet<Pokedex> Pokedices { get; set; }

    public virtual DbSet<Pokedexdescription> Pokedexdescriptions { get; set; }

    public virtual DbSet<Pokedexname> Pokedexnames { get; set; }

    public virtual DbSet<Pokedexversiongroup> Pokedexversiongroups { get; set; }

    public virtual DbSet<Pokemon> Pokemons { get; set; }

    public virtual DbSet<Pokemonability> Pokemonabilities { get; set; }

    public virtual DbSet<Pokemonabilitypast> Pokemonabilitypasts { get; set; }

    public virtual DbSet<Pokemoncolor> Pokemoncolors { get; set; }

    public virtual DbSet<Pokemoncolorname> Pokemoncolornames { get; set; }

    public virtual DbSet<Pokemoncry> Pokemoncries { get; set; }

    public virtual DbSet<Pokemondexnumber> Pokemondexnumbers { get; set; }

    public virtual DbSet<Pokemonegggroup> Pokemonegggroups { get; set; }

    public virtual DbSet<Pokemonevolution> Pokemonevolutions { get; set; }

    public virtual DbSet<Pokemonform> Pokemonforms { get; set; }

    public virtual DbSet<Pokemonformgeneration> Pokemonformgenerations { get; set; }

    public virtual DbSet<Pokemonformname> Pokemonformnames { get; set; }

    public virtual DbSet<Pokemonformtype> Pokemonformtypes { get; set; }

    public virtual DbSet<Pokemongameindex> Pokemongameindices { get; set; }

    public virtual DbSet<Pokemonhabitat> Pokemonhabitats { get; set; }

    public virtual DbSet<Pokemonhabitatname> Pokemonhabitatnames { get; set; }

    public virtual DbSet<Pokemonitem> Pokemonitems { get; set; }

    public virtual DbSet<Pokemonmove> Pokemonmoves { get; set; }

    public virtual DbSet<Pokemonshape> Pokemonshapes { get; set; }

    public virtual DbSet<Pokemonshapename> Pokemonshapenames { get; set; }

    public virtual DbSet<Pokemonspeciesdescription> Pokemonspeciesdescriptions { get; set; }

    public virtual DbSet<Pokemonspeciesflavortext> Pokemonspeciesflavortexts { get; set; }

    public virtual DbSet<Pokemonspeciesname> Pokemonspeciesnames { get; set; }

    public virtual DbSet<Pokemonspecy> Pokemonspecies { get; set; }

    public virtual DbSet<Pokemonstat> Pokemonstats { get; set; }

    public virtual DbSet<Pokemonstatpast> Pokemonstatpasts { get; set; }

    public virtual DbSet<Pokemontype> Pokemontypes { get; set; }

    public virtual DbSet<Pokemontypepast> Pokemontypepasts { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Regionname> Regionnames { get; set; }

    public virtual DbSet<Stat> Stats { get; set; }

    public virtual DbSet<Statname> Statnames { get; set; }

    public virtual DbSet<Supercontestcombo> Supercontestcombos { get; set; }

    public virtual DbSet<Supercontesteffect> Supercontesteffects { get; set; }

    public virtual DbSet<Supercontesteffectflavortext> Supercontesteffectflavortexts { get; set; }

    public virtual DbSet<Models.Type> Types { get; set; }

    public virtual DbSet<Typeefficacy> Typeefficacies { get; set; }

    public virtual DbSet<Typeefficacypast> Typeefficacypasts { get; set; }

    public virtual DbSet<Typegameindex> Typegameindices { get; set; }

    public virtual DbSet<Typename> Typenames { get; set; }

    public virtual DbSet<Models.Version> Versions { get; set; }

    public virtual DbSet<Versiongroup> Versiongroups { get; set; }

    public virtual DbSet<Versiongroupmovelearnmethod> Versiongroupmovelearnmethods { get; set; }

    public virtual DbSet<Versiongroupregion> Versiongroupregions { get; set; }

    public virtual DbSet<Versionname> Versionnames { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ability>(entity =>
        {
            entity.ToTable("ability");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_ability_generation_id_225aa68a");

            entity.HasIndex(e => e.Name, "pokemon_v2_ability_name_744d1800");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.IsMainSeries)
                .HasColumnType("bool")
                .HasColumnName("is_main_series");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Generation).WithMany(p => p.Abilities).HasForeignKey(d => d.GenerationId);
        });

        modelBuilder.Entity<Abilitychange>(entity =>
        {
            entity.ToTable("abilitychange");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_abilitychange_ability_id_b263505f");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_abilitychange_version_group_id_04bcdf19");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Ability).WithMany(p => p.Abilitychanges).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Abilitychanges).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Abilitychangeeffecttext>(entity =>
        {
            entity.ToTable("abilitychangeeffecttext");

            entity.HasIndex(e => e.AbilityChangeId, "pokemon_v2_abilitychangeeffecttext_ability_change_id_7b10479d");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_abilitychangeeffecttext_language_id_ed14bf34");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityChangeId).HasColumnName("ability_change_id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.AbilityChange).WithMany(p => p.Abilitychangeeffecttexts).HasForeignKey(d => d.AbilityChangeId);

            entity.HasOne(d => d.Language).WithMany(p => p.Abilitychangeeffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Abilityeffecttext>(entity =>
        {
            entity.ToTable("abilityeffecttext");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_abilityeffecttext_ability_id_9fe65f70");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_abilityeffecttext_language_id_9a3fc9eb");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.ShortEffect)
                .HasColumnType("varchar(300)")
                .HasColumnName("short_effect");

            entity.HasOne(d => d.Ability).WithMany(p => p.Abilityeffecttexts).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Language).WithMany(p => p.Abilityeffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Abilityflavortext>(entity =>
        {
            entity.ToTable("abilityflavortext");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_abilityflavortext_ability_id_8c20d4bf");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_abilityflavortext_language_id_91dfb962");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_abilityflavortext_version_group_id_a379dd5d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Ability).WithMany(p => p.Abilityflavortexts).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Language).WithMany(p => p.Abilityflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Abilityflavortexts).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Abilityname>(entity =>
        {
            entity.ToTable("abilityname");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_abilityname_ability_id_2753864d");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_abilityname_language_id_e64c37fb");

            entity.HasIndex(e => e.Name, "pokemon_v2_abilityname_name_8db2ae39");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Ability).WithMany(p => p.Abilitynames).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Language).WithMany(p => p.Abilitynames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<AuthGroup>(entity =>
        {
            entity.ToTable("auth_group");

            entity.HasIndex(e => e.Name, "IX_auth_group_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(150)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthGroupPermission>(entity =>
        {
            entity.ToTable("auth_group_permissions");

            entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

            entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq").IsUnique();

            entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AuthPermission>(entity =>
        {
            entity.ToTable("auth_permission");

            entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

            entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codename)
                .HasColumnType("varchar(100)")
                .HasColumnName("codename");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(255)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthUser>(entity =>
        {
            entity.ToTable("auth_user");

            entity.HasIndex(e => e.Username, "IX_auth_user_username").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateJoined)
                .HasColumnType("datetime")
                .HasColumnName("date_joined");
            entity.Property(e => e.Email)
                .HasColumnType("varchar(254)")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasColumnType("varchar(150)")
                .HasColumnName("first_name");
            entity.Property(e => e.IsActive)
                .HasColumnType("bool")
                .HasColumnName("is_active");
            entity.Property(e => e.IsStaff)
                .HasColumnType("bool")
                .HasColumnName("is_staff");
            entity.Property(e => e.IsSuperuser)
                .HasColumnType("bool")
                .HasColumnName("is_superuser");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasColumnType("varchar(150)")
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasColumnType("varchar(128)")
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasColumnType("varchar(150)")
                .HasColumnName("username");
        });

        modelBuilder.Entity<AuthUserGroup>(entity =>
        {
            entity.ToTable("auth_user_groups");

            entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

            entity.HasIndex(e => e.UserId, "auth_user_groups_user_id_6a12ed8b");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AuthUserUserPermission>(entity =>
        {
            entity.ToTable("auth_user_user_permissions");

            entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

            entity.HasIndex(e => e.UserId, "auth_user_user_permissions_user_id_a95ead1b");

            entity.HasIndex(e => new { e.UserId, e.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Berry>(entity =>
        {
            entity.ToTable("berry");

            entity.HasIndex(e => e.BerryFirmnessId, "pokemon_v2_berry_berry_firmness_id_780e6268");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_berry_item_id_72a1ed81");

            entity.HasIndex(e => e.Name, "pokemon_v2_berry_name_4eaa4d0f");

            entity.HasIndex(e => e.NaturalGiftTypeId, "pokemon_v2_berry_natural_gift_type_id_7d76f035");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BerryFirmnessId).HasColumnName("berry_firmness_id");
            entity.Property(e => e.GrowthTime).HasColumnName("growth_time");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MaxHarvest).HasColumnName("max_harvest");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.NaturalGiftPower).HasColumnName("natural_gift_power");
            entity.Property(e => e.NaturalGiftTypeId).HasColumnName("natural_gift_type_id");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Smoothness).HasColumnName("smoothness");
            entity.Property(e => e.SoilDryness).HasColumnName("soil_dryness");

            entity.HasOne(d => d.BerryFirmness).WithMany(p => p.Berries).HasForeignKey(d => d.BerryFirmnessId);

            entity.HasOne(d => d.Item).WithMany(p => p.Berries).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.NaturalGiftType).WithMany(p => p.Berries).HasForeignKey(d => d.NaturalGiftTypeId);
        });

        modelBuilder.Entity<Berryfirmness>(entity =>
        {
            entity.ToTable("berryfirmness");

            entity.HasIndex(e => e.Name, "pokemon_v2_berryfirmness_name_13b8b31d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Berryfirmnessname>(entity =>
        {
            entity.ToTable("berryfirmnessname");

            entity.HasIndex(e => e.BerryFirmnessId, "pokemon_v2_berryfirmnessname_berry_firmness_id_905d4dcf");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_berryfirmnessname_language_id_7e7f395e");

            entity.HasIndex(e => e.Name, "pokemon_v2_berryfirmnessname_name_2a74382f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BerryFirmnessId).HasColumnName("berry_firmness_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.BerryFirmness).WithMany(p => p.Berryfirmnessnames).HasForeignKey(d => d.BerryFirmnessId);

            entity.HasOne(d => d.Language).WithMany(p => p.Berryfirmnessnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Berryflavor>(entity =>
        {
            entity.ToTable("berryflavor");

            entity.HasIndex(e => e.ContestTypeId, "IX_berryflavor_contest_type_id").IsUnique();

            entity.HasIndex(e => e.Name, "pokemon_v2_berryflavor_name_b33ebfb3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ContestType).WithOne(p => p.Berryflavor).HasForeignKey<Berryflavor>(d => d.ContestTypeId);
        });

        modelBuilder.Entity<Berryflavormap>(entity =>
        {
            entity.ToTable("berryflavormap");

            entity.HasIndex(e => e.BerryFlavorId, "pokemon_v2_berryflavormap_berry_flavor_id_65cf6f73");

            entity.HasIndex(e => e.BerryId, "pokemon_v2_berryflavormap_berry_id_e4a753e4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BerryFlavorId).HasColumnName("berry_flavor_id");
            entity.Property(e => e.BerryId).HasColumnName("berry_id");
            entity.Property(e => e.Potency).HasColumnName("potency");

            entity.HasOne(d => d.BerryFlavor).WithMany(p => p.Berryflavormaps).HasForeignKey(d => d.BerryFlavorId);

            entity.HasOne(d => d.Berry).WithMany(p => p.Berryflavormaps).HasForeignKey(d => d.BerryId);
        });

        modelBuilder.Entity<Berryflavorname>(entity =>
        {
            entity.ToTable("berryflavorname");

            entity.HasIndex(e => e.BerryFlavorId, "pokemon_v2_berryflavorname_berry_flavor_id_1dd899da");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_berryflavorname_language_id_fa96a7af");

            entity.HasIndex(e => e.Name, "pokemon_v2_berryflavorname_name_c499b01c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BerryFlavorId).HasColumnName("berry_flavor_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.BerryFlavor).WithMany(p => p.Berryflavornames).HasForeignKey(d => d.BerryFlavorId);

            entity.HasOne(d => d.Language).WithMany(p => p.Berryflavornames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Characteristic>(entity =>
        {
            entity.ToTable("characteristic");

            entity.HasIndex(e => e.StatId, "pokemon_v2_characteristic_stat_id_cf62870d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GeneMod5).HasColumnName("gene_mod_5");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Stat).WithMany(p => p.Characteristics).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<Characteristicdescription>(entity =>
        {
            entity.ToTable("characteristicdescription");

            entity.HasIndex(e => e.CharacteristicId, "pokemon_v2_characteristicdescription_characteristic_id_a943ddcf");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_characteristicdescription_language_id_48d9a020");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharacteristicId).HasColumnName("characteristic_id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.Characteristic).WithMany(p => p.Characteristicdescriptions).HasForeignKey(d => d.CharacteristicId);

            entity.HasOne(d => d.Language).WithMany(p => p.Characteristicdescriptions).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Contestcombo>(entity =>
        {
            entity.ToTable("contestcombo");

            entity.HasIndex(e => e.FirstMoveId, "pokemon_v2_contestcombo_first_move_id_e86fe950");

            entity.HasIndex(e => e.SecondMoveId, "pokemon_v2_contestcombo_second_move_id_5bf6f920");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstMoveId).HasColumnName("first_move_id");
            entity.Property(e => e.SecondMoveId).HasColumnName("second_move_id");

            entity.HasOne(d => d.FirstMove).WithMany(p => p.ContestcomboFirstMoves).HasForeignKey(d => d.FirstMoveId);

            entity.HasOne(d => d.SecondMove).WithMany(p => p.ContestcomboSecondMoves).HasForeignKey(d => d.SecondMoveId);
        });

        modelBuilder.Entity<Contesteffect>(entity =>
        {
            entity.ToTable("contesteffect");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appeal).HasColumnName("appeal");
            entity.Property(e => e.Jam).HasColumnName("jam");
        });

        modelBuilder.Entity<Contesteffecteffecttext>(entity =>
        {
            entity.ToTable("contesteffecteffecttext");

            entity.HasIndex(e => e.ContestEffectId, "pokemon_v2_contesteffecteffecttext_contest_effect_id_523f86e5");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_contesteffecteffecttext_language_id_0e98da56");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.ContestEffect).WithMany(p => p.Contesteffecteffecttexts).HasForeignKey(d => d.ContestEffectId);

            entity.HasOne(d => d.Language).WithMany(p => p.Contesteffecteffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Contesteffectflavortext>(entity =>
        {
            entity.ToTable("contesteffectflavortext");

            entity.HasIndex(e => e.ContestEffectId, "pokemon_v2_contesteffectflavortext_contest_effect_id_73bd43b4");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_contesteffectflavortext_language_id_a584e527");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.ContestEffect).WithMany(p => p.Contesteffectflavortexts).HasForeignKey(d => d.ContestEffectId);

            entity.HasOne(d => d.Language).WithMany(p => p.Contesteffectflavortexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Contesttype>(entity =>
        {
            entity.ToTable("contesttype");

            entity.HasIndex(e => e.Name, "pokemon_v2_contesttype_name_18e75f76");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Contesttypename>(entity =>
        {
            entity.ToTable("contesttypename");

            entity.HasIndex(e => e.ContestTypeId, "pokemon_v2_contesttypename_contest_type_id_08e7cb9d");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_contesttypename_language_id_2113d494");

            entity.HasIndex(e => e.Name, "pokemon_v2_contesttypename_name_270b053a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasColumnType("varchar(10)")
                .HasColumnName("color");
            entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");
            entity.Property(e => e.Flavor)
                .HasColumnType("varchar(10)")
                .HasColumnName("flavor");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ContestType).WithMany(p => p.Contesttypenames).HasForeignKey(d => d.ContestTypeId);

            entity.HasOne(d => d.Language).WithMany(p => p.Contesttypenames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Egggroup>(entity =>
        {
            entity.ToTable("egggroup");

            entity.HasIndex(e => e.Name, "pokemon_v2_egggroup_name_452dc3a4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Egggroupname>(entity =>
        {
            entity.ToTable("egggroupname");

            entity.HasIndex(e => e.EggGroupId, "pokemon_v2_egggroupname_egg_group_id_0e05a091");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_egggroupname_language_id_b233cbf3");

            entity.HasIndex(e => e.Name, "pokemon_v2_egggroupname_name_4ae8920c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EggGroupId).HasColumnName("egg_group_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EggGroup).WithMany(p => p.Egggroupnames).HasForeignKey(d => d.EggGroupId);

            entity.HasOne(d => d.Language).WithMany(p => p.Egggroupnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Encounter>(entity =>
        {
            entity.ToTable("encounter");

            entity.HasIndex(e => e.EncounterSlotId, "pokemon_v2_encounter_encounter_slot_id_67f269af");

            entity.HasIndex(e => e.LocationAreaId, "pokemon_v2_encounter_location_area_id_fa408e67");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_encounter_pokemon_id_a4a76f85");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_encounter_version_id_46932476");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterSlotId).HasColumnName("encounter_slot_id");
            entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.MinLevel).HasColumnName("min_level");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.EncounterSlot).WithMany(p => p.Encounters).HasForeignKey(d => d.EncounterSlotId);

            entity.HasOne(d => d.LocationArea).WithMany(p => p.Encounters).HasForeignKey(d => d.LocationAreaId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Encounters).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Version).WithMany(p => p.Encounters).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<Encountercondition>(entity =>
        {
            entity.ToTable("encountercondition");

            entity.HasIndex(e => e.Name, "pokemon_v2_encountercondition_name_6825a841");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Encounterconditionname>(entity =>
        {
            entity.ToTable("encounterconditionname");

            entity.HasIndex(e => e.EncounterConditionId, "pokemon_v2_encounterconditionname_encounter_condition_id_07da9a9c");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_encounterconditionname_language_id_15462dd7");

            entity.HasIndex(e => e.Name, "pokemon_v2_encounterconditionname_name_9140f29e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterConditionId).HasColumnName("encounter_condition_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EncounterCondition).WithMany(p => p.Encounterconditionnames).HasForeignKey(d => d.EncounterConditionId);

            entity.HasOne(d => d.Language).WithMany(p => p.Encounterconditionnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Encounterconditionvalue>(entity =>
        {
            entity.ToTable("encounterconditionvalue");

            entity.HasIndex(e => e.EncounterConditionId, "pokemon_v2_encounterconditionvalue_encounter_condition_id_e246ac97");

            entity.HasIndex(e => e.Name, "pokemon_v2_encounterconditionvalue_name_fd9a9104");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterConditionId).HasColumnName("encounter_condition_id");
            entity.Property(e => e.IsDefault)
                .HasColumnType("bool")
                .HasColumnName("is_default");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EncounterCondition).WithMany(p => p.Encounterconditionvalues).HasForeignKey(d => d.EncounterConditionId);
        });

        modelBuilder.Entity<Encounterconditionvaluemap>(entity =>
        {
            entity.ToTable("encounterconditionvaluemap");

            entity.HasIndex(e => e.EncounterConditionValueId, "pokemon_v2_encounterconditionvaluemap_encounter_condition_value_id_aea7c219");

            entity.HasIndex(e => e.EncounterId, "pokemon_v2_encounterconditionvaluemap_encounter_id_07cf7d14");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterConditionValueId).HasColumnName("encounter_condition_value_id");
            entity.Property(e => e.EncounterId).HasColumnName("encounter_id");

            entity.HasOne(d => d.EncounterConditionValue).WithMany(p => p.Encounterconditionvaluemaps).HasForeignKey(d => d.EncounterConditionValueId);

            entity.HasOne(d => d.Encounter).WithMany(p => p.Encounterconditionvaluemaps).HasForeignKey(d => d.EncounterId);
        });

        modelBuilder.Entity<Encounterconditionvaluename>(entity =>
        {
            entity.ToTable("encounterconditionvaluename");

            entity.HasIndex(e => e.EncounterConditionValueId, "pokemon_v2_encounterconditionvaluename_encounter_condition_value_id_30a8cc50");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_encounterconditionvaluename_language_id_759f2aa7");

            entity.HasIndex(e => e.Name, "pokemon_v2_encounterconditionvaluename_name_09aada74");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterConditionValueId).HasColumnName("encounter_condition_value_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EncounterConditionValue).WithMany(p => p.Encounterconditionvaluenames).HasForeignKey(d => d.EncounterConditionValueId);

            entity.HasOne(d => d.Language).WithMany(p => p.Encounterconditionvaluenames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Encountermethod>(entity =>
        {
            entity.ToTable("encountermethod");

            entity.HasIndex(e => e.Name, "pokemon_v2_encountermethod_name_807a7363");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<Encountermethodname>(entity =>
        {
            entity.ToTable("encountermethodname");

            entity.HasIndex(e => e.EncounterMethodId, "pokemon_v2_encountermethodname_encounter_method_id_f0b81197");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_encountermethodname_language_id_df10978f");

            entity.HasIndex(e => e.Name, "pokemon_v2_encountermethodname_name_c50b0da6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EncounterMethod).WithMany(p => p.Encountermethodnames).HasForeignKey(d => d.EncounterMethodId);

            entity.HasOne(d => d.Language).WithMany(p => p.Encountermethodnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Encounterslot>(entity =>
        {
            entity.ToTable("encounterslot");

            entity.HasIndex(e => e.EncounterMethodId, "pokemon_v2_encounterslot_encounter_method_id_b9a4d963");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_encounterslot_version_group_id_de2e9658");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");
            entity.Property(e => e.Rarity).HasColumnName("rarity");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.EncounterMethod).WithMany(p => p.Encounterslots).HasForeignKey(d => d.EncounterMethodId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Encounterslots).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Evolutionchain>(entity =>
        {
            entity.ToTable("evolutionchain");

            entity.HasIndex(e => e.BabyTriggerItemId, "pokemon_v2_evolutionchain_baby_trigger_item_id_8341ae6a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BabyTriggerItemId).HasColumnName("baby_trigger_item_id");

            entity.HasOne(d => d.BabyTriggerItem).WithMany(p => p.Evolutionchains).HasForeignKey(d => d.BabyTriggerItemId);
        });

        modelBuilder.Entity<Evolutiontrigger>(entity =>
        {
            entity.ToTable("evolutiontrigger");

            entity.HasIndex(e => e.Name, "pokemon_v2_evolutiontrigger_name_5e94bd81");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Evolutiontriggername>(entity =>
        {
            entity.ToTable("evolutiontriggername");

            entity.HasIndex(e => e.EvolutionTriggerId, "pokemon_v2_evolutiontriggername_evolution_trigger_id_9d66b90d");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_evolutiontriggername_language_id_9a05e0c7");

            entity.HasIndex(e => e.Name, "pokemon_v2_evolutiontriggername_name_8119ef67");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EvolutionTriggerId).HasColumnName("evolution_trigger_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EvolutionTrigger).WithMany(p => p.Evolutiontriggernames).HasForeignKey(d => d.EvolutionTriggerId);

            entity.HasOne(d => d.Language).WithMany(p => p.Evolutiontriggernames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.ToTable("experience");

            entity.HasIndex(e => e.GrowthRateId, "pokemon_v2_experience_growth_rate_id_42dcd743");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Experience1).HasColumnName("experience");
            entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");
            entity.Property(e => e.Level).HasColumnName("level");

            entity.HasOne(d => d.GrowthRate).WithMany(p => p.Experiences).HasForeignKey(d => d.GrowthRateId);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.ToTable("gender");

            entity.HasIndex(e => e.Name, "pokemon_v2_gender_name_40507af4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Generation>(entity =>
        {
            entity.ToTable("generation");

            entity.HasIndex(e => e.RegionId, "IX_generation_region_id").IsUnique();

            entity.HasIndex(e => e.Name, "pokemon_v2_generation_name_6e9940f4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");

            entity.HasOne(d => d.Region).WithOne(p => p.Generation).HasForeignKey<Generation>(d => d.RegionId);
        });

        modelBuilder.Entity<Generationname>(entity =>
        {
            entity.ToTable("generationname");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_generationname_generation_id_9f22cdbb");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_generationname_language_id_4e855215");

            entity.HasIndex(e => e.Name, "pokemon_v2_generationname_name_f79c2051");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Generation).WithMany(p => p.Generationnames).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Language).WithMany(p => p.Generationnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Growthrate>(entity =>
        {
            entity.ToTable("growthrate");

            entity.HasIndex(e => e.Name, "pokemon_v2_growthrate_name_1926e11a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Formula)
                .HasColumnType("varchar(500)")
                .HasColumnName("formula");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Growthratedescription>(entity =>
        {
            entity.ToTable("growthratedescription");

            entity.HasIndex(e => e.GrowthRateId, "pokemon_v2_growthratedescription_growth_rate_id_2e126dd5");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_growthratedescription_language_id_5bbe9b57");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.GrowthRate).WithMany(p => p.Growthratedescriptions).HasForeignKey(d => d.GrowthRateId);

            entity.HasOne(d => d.Language).WithMany(p => p.Growthratedescriptions).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.ToTable("item");

            entity.HasIndex(e => e.ItemCategoryId, "pokemon_v2_item_item_category_id_9f55b7ca");

            entity.HasIndex(e => e.ItemFlingEffectId, "pokemon_v2_item_item_fling_effect_id_8e7cefaa");

            entity.HasIndex(e => e.Name, "pokemon_v2_item_name_5597f95e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.FlingPower).HasColumnName("fling_power");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.ItemFlingEffectId).HasColumnName("item_fling_effect_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.Items).HasForeignKey(d => d.ItemCategoryId);

            entity.HasOne(d => d.ItemFlingEffect).WithMany(p => p.Items).HasForeignKey(d => d.ItemFlingEffectId);
        });

        modelBuilder.Entity<Itemattribute>(entity =>
        {
            entity.ToTable("itemattribute");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemattribute_name_7e365d21");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Itemattributedescription>(entity =>
        {
            entity.ToTable("itemattributedescription");

            entity.HasIndex(e => e.ItemAttributeId, "pokemon_v2_itemattributedescription_item_attribute_id_cdd96fff");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemattributedescription_language_id_5385b04c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.ItemAttributeId).HasColumnName("item_attribute_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.ItemAttribute).WithMany(p => p.Itemattributedescriptions).HasForeignKey(d => d.ItemAttributeId);

            entity.HasOne(d => d.Language).WithMany(p => p.Itemattributedescriptions).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Itemattributemap>(entity =>
        {
            entity.ToTable("itemattributemap");

            entity.HasIndex(e => e.ItemAttributeId, "pokemon_v2_itemattributemap_item_attribute_id_e6cd252f");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemattributemap_item_id_e6dba1a6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemAttributeId).HasColumnName("item_attribute_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");

            entity.HasOne(d => d.ItemAttribute).WithMany(p => p.Itemattributemaps).HasForeignKey(d => d.ItemAttributeId);

            entity.HasOne(d => d.Item).WithMany(p => p.Itemattributemaps).HasForeignKey(d => d.ItemId);
        });

        modelBuilder.Entity<Itemattributename>(entity =>
        {
            entity.ToTable("itemattributename");

            entity.HasIndex(e => e.ItemAttributeId, "pokemon_v2_itemattributename_item_attribute_id_85acc7f5");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemattributename_language_id_e36a7fe1");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemattributename_name_3e2ccd4a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemAttributeId).HasColumnName("item_attribute_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemAttribute).WithMany(p => p.Itemattributenames).HasForeignKey(d => d.ItemAttributeId);

            entity.HasOne(d => d.Language).WithMany(p => p.Itemattributenames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Itemcategory>(entity =>
        {
            entity.ToTable("itemcategory");

            entity.HasIndex(e => e.ItemPocketId, "pokemon_v2_itemcategory_item_pocket_id_8ebf7645");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemcategory_name_54594288");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemPocketId).HasColumnName("item_pocket_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemPocket).WithMany(p => p.Itemcategories).HasForeignKey(d => d.ItemPocketId);
        });

        modelBuilder.Entity<Itemcategoryname>(entity =>
        {
            entity.ToTable("itemcategoryname");

            entity.HasIndex(e => e.ItemCategoryId, "pokemon_v2_itemcategoryname_item_category_id_10412a45");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemcategoryname_language_id_6a5424db");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemcategoryname_name_b0889e22");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.Itemcategorynames).HasForeignKey(d => d.ItemCategoryId);

            entity.HasOne(d => d.Language).WithMany(p => p.Itemcategorynames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Itemeffecttext>(entity =>
        {
            entity.ToTable("itemeffecttext");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemeffecttext_item_id_2fb7601c");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemeffecttext_language_id_53e95659");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.ShortEffect)
                .HasColumnType("varchar(300)")
                .HasColumnName("short_effect");

            entity.HasOne(d => d.Item).WithMany(p => p.Itemeffecttexts).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Language).WithMany(p => p.Itemeffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Itemflavortext>(entity =>
        {
            entity.ToTable("itemflavortext");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemflavortext_item_id_f2575960");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemflavortext_language_id_dee91cde");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_itemflavortext_version_group_id_20b07485");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Item).WithMany(p => p.Itemflavortexts).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Language).WithMany(p => p.Itemflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Itemflavortexts).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Itemflingeffect>(entity =>
        {
            entity.ToTable("itemflingeffect");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemflingeffect_name_bcd91c57");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Itemflingeffecteffecttext>(entity =>
        {
            entity.ToTable("itemflingeffecteffecttext");

            entity.HasIndex(e => e.ItemFlingEffectId, "pokemon_v2_itemflingeffecteffecttext_item_fling_effect_id_31f3ddda");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemflingeffecteffecttext_language_id_7c369333");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.ItemFlingEffectId).HasColumnName("item_fling_effect_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.ItemFlingEffect).WithMany(p => p.Itemflingeffecteffecttexts).HasForeignKey(d => d.ItemFlingEffectId);

            entity.HasOne(d => d.Language).WithMany(p => p.Itemflingeffecteffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Itemgameindex>(entity =>
        {
            entity.ToTable("itemgameindex");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_itemgameindex_generation_id_a182ee37");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemgameindex_item_id_518e20fd");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.Itemgameindices).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Item).WithMany(p => p.Itemgameindices).HasForeignKey(d => d.ItemId);
        });

        modelBuilder.Entity<Itemname>(entity =>
        {
            entity.ToTable("itemname");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemname_item_id_cf942d90");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemname_language_id_69bf5660");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemname_name_4b3fc446");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Item).WithMany(p => p.Itemnames).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Language).WithMany(p => p.Itemnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Itempocket>(entity =>
        {
            entity.ToTable("itempocket");

            entity.HasIndex(e => e.Name, "pokemon_v2_itempocket_name_d30e337a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Itempocketname>(entity =>
        {
            entity.ToTable("itempocketname");

            entity.HasIndex(e => e.ItemPocketId, "pokemon_v2_itempocketname_item_pocket_id_2856f7ba");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itempocketname_language_id_bd18485d");

            entity.HasIndex(e => e.Name, "pokemon_v2_itempocketname_name_c3e53fd6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemPocketId).HasColumnName("item_pocket_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemPocket).WithMany(p => p.Itempocketnames).HasForeignKey(d => d.ItemPocketId);

            entity.HasOne(d => d.Language).WithMany(p => p.Itempocketnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("language");

            entity.HasIndex(e => e.Name, "pokemon_v2_language_name_012b2a8c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Iso3166)
                .HasColumnType("varchar(2)")
                .HasColumnName("iso3166");
            entity.Property(e => e.Iso639)
                .HasColumnType("varchar(10)")
                .HasColumnName("iso639");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Official)
                .HasColumnType("bool")
                .HasColumnName("official");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<Languagename>(entity =>
        {
            entity.ToTable("languagename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_languagename_language_id_75856281");

            entity.HasIndex(e => e.LocalLanguageId, "pokemon_v2_languagename_local_language_id_b09a9c7d");

            entity.HasIndex(e => e.Name, "pokemon_v2_languagename_name_6597eeaa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.LanguagenameLanguages).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.LocalLanguage).WithMany(p => p.LanguagenameLocalLanguages).HasForeignKey(d => d.LocalLanguageId);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("location");

            entity.HasIndex(e => e.Name, "pokemon_v2_location_name_09fe9462");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_location_region_id_fd1b5904");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");

            entity.HasOne(d => d.Region).WithMany(p => p.Locations).HasForeignKey(d => d.RegionId);
        });

        modelBuilder.Entity<Locationarea>(entity =>
        {
            entity.ToTable("locationarea");

            entity.HasIndex(e => e.LocationId, "pokemon_v2_locationarea_location_id_a62c4737");

            entity.HasIndex(e => e.Name, "pokemon_v2_locationarea_name_8b427914");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Location).WithMany(p => p.Locationareas).HasForeignKey(d => d.LocationId);
        });

        modelBuilder.Entity<Locationareaencounterrate>(entity =>
        {
            entity.ToTable("locationareaencounterrate");

            entity.HasIndex(e => e.EncounterMethodId, "pokemon_v2_locationareaencounterrate_encounter_method_id_631902d6");

            entity.HasIndex(e => e.LocationAreaId, "pokemon_v2_locationareaencounterrate_location_area_id_78fab47d");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_locationareaencounterrate_version_id_67e1bbb9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");
            entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.EncounterMethod).WithMany(p => p.Locationareaencounterrates).HasForeignKey(d => d.EncounterMethodId);

            entity.HasOne(d => d.LocationArea).WithMany(p => p.Locationareaencounterrates).HasForeignKey(d => d.LocationAreaId);

            entity.HasOne(d => d.Version).WithMany(p => p.Locationareaencounterrates).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<Locationareaname>(entity =>
        {
            entity.ToTable("locationareaname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_locationareaname_language_id_82f198e4");

            entity.HasIndex(e => e.LocationAreaId, "pokemon_v2_locationareaname_location_area_id_99f07edf");

            entity.HasIndex(e => e.Name, "pokemon_v2_locationareaname_name_36edcff1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Locationareanames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.LocationArea).WithMany(p => p.Locationareanames).HasForeignKey(d => d.LocationAreaId);
        });

        modelBuilder.Entity<Locationgameindex>(entity =>
        {
            entity.ToTable("locationgameindex");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_locationgameindex_generation_id_15ae87aa");

            entity.HasIndex(e => e.LocationId, "pokemon_v2_locationgameindex_location_id_4eadd886");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.Locationgameindices).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Location).WithMany(p => p.Locationgameindices).HasForeignKey(d => d.LocationId);
        });

        modelBuilder.Entity<Locationname>(entity =>
        {
            entity.ToTable("locationname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_locationname_language_id_9c042035");

            entity.HasIndex(e => e.LocationId, "pokemon_v2_locationname_location_id_b4de5b51");

            entity.HasIndex(e => e.Name, "pokemon_v2_locationname_name_0dc028d2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Locationnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Location).WithMany(p => p.Locationnames).HasForeignKey(d => d.LocationId);
        });

        modelBuilder.Entity<Machine>(entity =>
        {
            entity.ToTable("machine");

            entity.HasIndex(e => e.GrowthRateId, "pokemon_v2_machine_growth_rate_id_d67448d0");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_machine_item_id_4c870846");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_machine_move_id_965a6a38");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_machine_version_group_id_d69b6064");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MachineNumber).HasColumnName("machine_number");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.GrowthRate).WithMany(p => p.Machines).HasForeignKey(d => d.GrowthRateId);

            entity.HasOne(d => d.Item).WithMany(p => p.Machines).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Move).WithMany(p => p.Machines).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Machines).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Move>(entity =>
        {
            entity.ToTable("move");

            entity.HasIndex(e => e.ContestEffectId, "pokemon_v2_move_contest_effect_id_2e4d04a1");

            entity.HasIndex(e => e.ContestTypeId, "pokemon_v2_move_contest_type_id_8da106eb");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_move_generation_id_d18da2f9");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_move_move_damage_class_id_6f60c380");

            entity.HasIndex(e => e.MoveEffectId, "pokemon_v2_move_move_effect_id_e12d5c62");

            entity.HasIndex(e => e.MoveTargetId, "pokemon_v2_move_move_target_id_47f917eb");

            entity.HasIndex(e => e.Name, "pokemon_v2_move_name_b3558818");

            entity.HasIndex(e => e.SuperContestEffectId, "pokemon_v2_move_super_contest_effect_id_c0efdaf5");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_move_type_id_a2b25a4c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accuracy).HasColumnName("accuracy");
            entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");
            entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");
            entity.Property(e => e.MoveEffectChance).HasColumnName("move_effect_chance");
            entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");
            entity.Property(e => e.MoveTargetId).HasColumnName("move_target_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Power).HasColumnName("power");
            entity.Property(e => e.Pp).HasColumnName("pp");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.SuperContestEffectId).HasColumnName("super_contest_effect_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.ContestEffect).WithMany(p => p.Moves).HasForeignKey(d => d.ContestEffectId);

            entity.HasOne(d => d.ContestType).WithMany(p => p.Moves).HasForeignKey(d => d.ContestTypeId);

            entity.HasOne(d => d.Generation).WithMany(p => p.Moves).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.Moves).HasForeignKey(d => d.MoveDamageClassId);

            entity.HasOne(d => d.MoveEffect).WithMany(p => p.Moves).HasForeignKey(d => d.MoveEffectId);

            entity.HasOne(d => d.MoveTarget).WithMany(p => p.Moves).HasForeignKey(d => d.MoveTargetId);

            entity.HasOne(d => d.SuperContestEffect).WithMany(p => p.Moves).HasForeignKey(d => d.SuperContestEffectId);

            entity.HasOne(d => d.Type).WithMany(p => p.Moves).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Moveattribute>(entity =>
        {
            entity.ToTable("moveattribute");

            entity.HasIndex(e => e.Name, "pokemon_v2_moveattribute_name_3a5f5200");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Moveattributedescription>(entity =>
        {
            entity.ToTable("moveattributedescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveattributedescription_language_id_3cc96a2c");

            entity.HasIndex(e => e.MoveAttributeId, "pokemon_v2_moveattributedescription_move_attribute_id_26fa4593");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveAttributeId).HasColumnName("move_attribute_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Moveattributedescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveAttribute).WithMany(p => p.Moveattributedescriptions).HasForeignKey(d => d.MoveAttributeId);
        });

        modelBuilder.Entity<Moveattributemap>(entity =>
        {
            entity.ToTable("moveattributemap");

            entity.HasIndex(e => e.MoveAttributeId, "pokemon_v2_moveattributemap_move_attribute_id_4bdcbae4");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_moveattributemap_move_id_8e9353e9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MoveAttributeId).HasColumnName("move_attribute_id");
            entity.Property(e => e.MoveId).HasColumnName("move_id");

            entity.HasOne(d => d.MoveAttribute).WithMany(p => p.Moveattributemaps).HasForeignKey(d => d.MoveAttributeId);

            entity.HasOne(d => d.Move).WithMany(p => p.Moveattributemaps).HasForeignKey(d => d.MoveId);
        });

        modelBuilder.Entity<Moveattributename>(entity =>
        {
            entity.ToTable("moveattributename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveattributename_language_id_f0fdbb0e");

            entity.HasIndex(e => e.MoveAttributeId, "pokemon_v2_moveattributename_move_attribute_id_06b2d536");

            entity.HasIndex(e => e.Name, "pokemon_v2_moveattributename_name_9d7c4e1e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveAttributeId).HasColumnName("move_attribute_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Moveattributenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveAttribute).WithMany(p => p.Moveattributenames).HasForeignKey(d => d.MoveAttributeId);
        });

        modelBuilder.Entity<Movebattlestyle>(entity =>
        {
            entity.ToTable("movebattlestyle");

            entity.HasIndex(e => e.Name, "pokemon_v2_movebattlestyle_name_0257848e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movebattlestylename>(entity =>
        {
            entity.ToTable("movebattlestylename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movebattlestylename_language_id_6dd407cd");

            entity.HasIndex(e => e.MoveBattleStyleId, "pokemon_v2_movebattlestylename_move_battle_style_id_0216e7a5");

            entity.HasIndex(e => e.Name, "pokemon_v2_movebattlestylename_name_4470754a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveBattleStyleId).HasColumnName("move_battle_style_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Movebattlestylenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveBattleStyle).WithMany(p => p.Movebattlestylenames).HasForeignKey(d => d.MoveBattleStyleId);
        });

        modelBuilder.Entity<Movechange>(entity =>
        {
            entity.ToTable("movechange");

            entity.HasIndex(e => e.MoveEffectId, "pokemon_v2_movechange_move_effect_id_d0711cd2");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_movechange_move_id_56b40d0f");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_movechange_type_id_07064588");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_movechange_version_group_id_d98e7e4b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accuracy).HasColumnName("accuracy");
            entity.Property(e => e.MoveEffectChance).HasColumnName("move_effect_chance");
            entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.Power).HasColumnName("power");
            entity.Property(e => e.Pp).HasColumnName("pp");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.MoveEffect).WithMany(p => p.Movechanges).HasForeignKey(d => d.MoveEffectId);

            entity.HasOne(d => d.Move).WithMany(p => p.Movechanges).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.Type).WithMany(p => p.Movechanges).HasForeignKey(d => d.TypeId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Movechanges).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Movedamageclass>(entity =>
        {
            entity.ToTable("movedamageclass");

            entity.HasIndex(e => e.Name, "pokemon_v2_movedamageclass_name_8c1669d6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movedamageclassdescription>(entity =>
        {
            entity.ToTable("movedamageclassdescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movedamageclassdescription_language_id_984a7058");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_movedamageclassdescription_move_damage_class_id_4624e8c3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Movedamageclassdescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.Movedamageclassdescriptions).HasForeignKey(d => d.MoveDamageClassId);
        });

        modelBuilder.Entity<Movedamageclassname>(entity =>
        {
            entity.ToTable("movedamageclassname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movedamageclassname_language_id_b66d9a02");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_movedamageclassname_move_damage_class_id_8d041412");

            entity.HasIndex(e => e.Name, "pokemon_v2_movedamageclassname_name_e38f4f0f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Movedamageclassnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.Movedamageclassnames).HasForeignKey(d => d.MoveDamageClassId);
        });

        modelBuilder.Entity<Moveeffect>(entity =>
        {
            entity.ToTable("moveeffect");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Moveeffectchange>(entity =>
        {
            entity.ToTable("moveeffectchange");

            entity.HasIndex(e => e.MoveEffectId, "pokemon_v2_moveeffectchange_move_effect_id_83bb0e24");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_moveeffectchange_version_group_id_ad5675d0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.MoveEffect).WithMany(p => p.Moveeffectchanges).HasForeignKey(d => d.MoveEffectId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Moveeffectchanges).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Moveeffectchangeeffecttext>(entity =>
        {
            entity.ToTable("moveeffectchangeeffecttext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveeffectchangeeffecttext_language_id_f616622c");

            entity.HasIndex(e => e.MoveEffectChangeId, "pokemon_v2_moveeffectchangeeffecttext_move_effect_change_id_c4e6b8f2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveEffectChangeId).HasColumnName("move_effect_change_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Moveeffectchangeeffecttexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveEffectChange).WithMany(p => p.Moveeffectchangeeffecttexts).HasForeignKey(d => d.MoveEffectChangeId);
        });

        modelBuilder.Entity<Moveeffecteffecttext>(entity =>
        {
            entity.ToTable("moveeffecteffecttext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveeffecteffecttext_language_id_4e202686");

            entity.HasIndex(e => e.MoveEffectId, "pokemon_v2_moveeffecteffecttext_move_effect_id_e834153e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");
            entity.Property(e => e.ShortEffect)
                .HasColumnType("varchar(300)")
                .HasColumnName("short_effect");

            entity.HasOne(d => d.Language).WithMany(p => p.Moveeffecteffecttexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveEffect).WithMany(p => p.Moveeffecteffecttexts).HasForeignKey(d => d.MoveEffectId);
        });

        modelBuilder.Entity<Moveflavortext>(entity =>
        {
            entity.ToTable("moveflavortext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveflavortext_language_id_cad665e7");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_moveflavortext_move_id_e694b553");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_moveflavortext_version_group_id_acb46240");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Moveflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Move).WithMany(p => p.Moveflavortexts).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Moveflavortexts).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Movelearnmethod>(entity =>
        {
            entity.ToTable("movelearnmethod");

            entity.HasIndex(e => e.Name, "pokemon_v2_movelearnmethod_name_d6294fe9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movelearnmethoddescription>(entity =>
        {
            entity.ToTable("movelearnmethoddescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movelearnmethoddescription_language_id_a6bac991");

            entity.HasIndex(e => e.MoveLearnMethodId, "pokemon_v2_movelearnmethoddescription_move_learn_method_id_09ec6a7b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveLearnMethodId).HasColumnName("move_learn_method_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Movelearnmethoddescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveLearnMethod).WithMany(p => p.Movelearnmethoddescriptions).HasForeignKey(d => d.MoveLearnMethodId);
        });

        modelBuilder.Entity<Movelearnmethodname>(entity =>
        {
            entity.ToTable("movelearnmethodname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movelearnmethodname_language_id_aa17010f");

            entity.HasIndex(e => e.MoveLearnMethodId, "pokemon_v2_movelearnmethodname_move_learn_method_id_04b9abfa");

            entity.HasIndex(e => e.Name, "pokemon_v2_movelearnmethodname_name_b665e82d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveLearnMethodId).HasColumnName("move_learn_method_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Movelearnmethodnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveLearnMethod).WithMany(p => p.Movelearnmethodnames).HasForeignKey(d => d.MoveLearnMethodId);
        });

        modelBuilder.Entity<Movemetaailment>(entity =>
        {
            entity.ToTable("movemetaailment");

            entity.HasIndex(e => e.Name, "pokemon_v2_movemetaailment_name_7e8b85b0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movemetaailmentname>(entity =>
        {
            entity.ToTable("movemetaailmentname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movemetaailmentname_language_id_c536b83b");

            entity.HasIndex(e => e.MoveMetaAilmentId, "pokemon_v2_movemetaailmentname_move_meta_ailment_id_3166201a");

            entity.HasIndex(e => e.Name, "pokemon_v2_movemetaailmentname_name_a286e4d0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveMetaAilmentId).HasColumnName("move_meta_ailment_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Movemetaailmentnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveMetaAilment).WithMany(p => p.Movemetaailmentnames).HasForeignKey(d => d.MoveMetaAilmentId);
        });

        modelBuilder.Entity<Movemetacategory>(entity =>
        {
            entity.ToTable("movemetacategory");

            entity.HasIndex(e => e.Name, "pokemon_v2_movemetacategory_name_2d508cb0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movemetacategorydescription>(entity =>
        {
            entity.ToTable("movemetacategorydescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movemetacategorydescription_language_id_feacc726");

            entity.HasIndex(e => e.MoveMetaCategoryId, "pokemon_v2_movemetacategorydescription_move_meta_category_id_4b604073");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveMetaCategoryId).HasColumnName("move_meta_category_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Movemetacategorydescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveMetaCategory).WithMany(p => p.Movemetacategorydescriptions).HasForeignKey(d => d.MoveMetaCategoryId);
        });

        modelBuilder.Entity<Movemetastatchange>(entity =>
        {
            entity.ToTable("movemetastatchange");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_movemetastatchange_move_id_b8528bde");

            entity.HasIndex(e => e.StatId, "pokemon_v2_movemetastatchange_stat_id_7bbd0200");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Change).HasColumnName("change");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Move).WithMany(p => p.Movemetastatchanges).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.Stat).WithMany(p => p.Movemetastatchanges).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<Movemetum>(entity =>
        {
            entity.ToTable("movemeta");

            entity.HasIndex(e => e.MoveId, "IX_movemeta_move_id").IsUnique();

            entity.HasIndex(e => e.MoveMetaAilmentId, "pokemon_v2_movemeta_move_meta_ailment_id_d261d5e1");

            entity.HasIndex(e => e.MoveMetaCategoryId, "pokemon_v2_movemeta_move_meta_category_id_5fc2f4b6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AilmentChance).HasColumnName("ailment_chance");
            entity.Property(e => e.CritRate).HasColumnName("crit_rate");
            entity.Property(e => e.Drain).HasColumnName("drain");
            entity.Property(e => e.FlinchChance).HasColumnName("flinch_chance");
            entity.Property(e => e.Healing).HasColumnName("healing");
            entity.Property(e => e.MaxHits).HasColumnName("max_hits");
            entity.Property(e => e.MaxTurns).HasColumnName("max_turns");
            entity.Property(e => e.MinHits).HasColumnName("min_hits");
            entity.Property(e => e.MinTurns).HasColumnName("min_turns");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.MoveMetaAilmentId).HasColumnName("move_meta_ailment_id");
            entity.Property(e => e.MoveMetaCategoryId).HasColumnName("move_meta_category_id");
            entity.Property(e => e.StatChance).HasColumnName("stat_chance");

            entity.HasOne(d => d.Move).WithOne(p => p.Movemetum)
                .HasForeignKey<Movemetum>(d => d.MoveId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.MoveMetaAilment).WithMany(p => p.Movemeta).HasForeignKey(d => d.MoveMetaAilmentId);

            entity.HasOne(d => d.MoveMetaCategory).WithMany(p => p.Movemeta).HasForeignKey(d => d.MoveMetaCategoryId);
        });

        modelBuilder.Entity<Movename>(entity =>
        {
            entity.ToTable("movename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movename_language_id_9c478512");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_movename_move_id_f28e6bef");

            entity.HasIndex(e => e.Name, "pokemon_v2_movename_name_8f60338a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Movenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Move).WithMany(p => p.Movenames).HasForeignKey(d => d.MoveId);
        });

        modelBuilder.Entity<Movetarget>(entity =>
        {
            entity.ToTable("movetarget");

            entity.HasIndex(e => e.Name, "pokemon_v2_movetarget_name_af0c75ad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Movetargetdescription>(entity =>
        {
            entity.ToTable("movetargetdescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movetargetdescription_language_id_85ac7390");

            entity.HasIndex(e => e.MoveTargetId, "pokemon_v2_movetargetdescription_move_target_id_1afb9b51");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveTargetId).HasColumnName("move_target_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Movetargetdescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveTarget).WithMany(p => p.Movetargetdescriptions).HasForeignKey(d => d.MoveTargetId);
        });

        modelBuilder.Entity<Movetargetname>(entity =>
        {
            entity.ToTable("movetargetname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movetargetname_language_id_05d3b8b8");

            entity.HasIndex(e => e.MoveTargetId, "pokemon_v2_movetargetname_move_target_id_61f56365");

            entity.HasIndex(e => e.Name, "pokemon_v2_movetargetname_name_ae888d7a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveTargetId).HasColumnName("move_target_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.Movetargetnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveTarget).WithMany(p => p.Movetargetnames).HasForeignKey(d => d.MoveTargetId);
        });

        modelBuilder.Entity<Nature>(entity =>
        {
            entity.ToTable("nature");

            entity.HasIndex(e => e.DecreasedStatId, "pokemon_v2_nature_decreased_stat_id_d89610fc");

            entity.HasIndex(e => e.HatesFlavorId, "pokemon_v2_nature_hates_flavor_id_d9c22d5d");

            entity.HasIndex(e => e.IncreasedStatId, "pokemon_v2_nature_increased_stat_id_949bb3bd");

            entity.HasIndex(e => e.LikesFlavorId, "pokemon_v2_nature_likes_flavor_id_475f0a7d");

            entity.HasIndex(e => e.Name, "pokemon_v2_nature_name_a7f453b0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DecreasedStatId).HasColumnName("decreased_stat_id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.HatesFlavorId).HasColumnName("hates_flavor_id");
            entity.Property(e => e.IncreasedStatId).HasColumnName("increased_stat_id");
            entity.Property(e => e.LikesFlavorId).HasColumnName("likes_flavor_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.DecreasedStat).WithMany(p => p.NatureDecreasedStats).HasForeignKey(d => d.DecreasedStatId);

            entity.HasOne(d => d.HatesFlavor).WithMany(p => p.NatureHatesFlavors).HasForeignKey(d => d.HatesFlavorId);

            entity.HasOne(d => d.IncreasedStat).WithMany(p => p.NatureIncreasedStats).HasForeignKey(d => d.IncreasedStatId);

            entity.HasOne(d => d.LikesFlavor).WithMany(p => p.NatureLikesFlavors).HasForeignKey(d => d.LikesFlavorId);
        });

        modelBuilder.Entity<Naturebattlestylepreference>(entity =>
        {
            entity.ToTable("naturebattlestylepreference");

            entity.HasIndex(e => e.MoveBattleStyleId, "pokemon_v2_naturebattlestylepreference_move_battle_style_id_f1dd2e92");

            entity.HasIndex(e => e.NatureId, "pokemon_v2_naturebattlestylepreference_nature_id_03c37bf2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HighHpPreference).HasColumnName("high_hp_preference");
            entity.Property(e => e.LowHpPreference).HasColumnName("low_hp_preference");
            entity.Property(e => e.MoveBattleStyleId).HasColumnName("move_battle_style_id");
            entity.Property(e => e.NatureId).HasColumnName("nature_id");

            entity.HasOne(d => d.MoveBattleStyle).WithMany(p => p.Naturebattlestylepreferences).HasForeignKey(d => d.MoveBattleStyleId);

            entity.HasOne(d => d.Nature).WithMany(p => p.Naturebattlestylepreferences).HasForeignKey(d => d.NatureId);
        });

        modelBuilder.Entity<Naturename>(entity =>
        {
            entity.ToTable("naturename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_naturename_language_id_7b3bb981");

            entity.HasIndex(e => e.Name, "pokemon_v2_naturename_name_d0bfe13a");

            entity.HasIndex(e => e.NatureId, "pokemon_v2_naturename_nature_id_e6043d64");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.NatureId).HasColumnName("nature_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Naturenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Nature).WithMany(p => p.Naturenames).HasForeignKey(d => d.NatureId);
        });

        modelBuilder.Entity<Naturepokeathlonstat>(entity =>
        {
            entity.ToTable("naturepokeathlonstat");

            entity.HasIndex(e => e.NatureId, "pokemon_v2_naturepokeathlonstat_nature_id_11b4efea");

            entity.HasIndex(e => e.PokeathlonStatId, "pokemon_v2_naturepokeathlonstat_pokeathlon_stat_id_0d042f0d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaxChange).HasColumnName("max_change");
            entity.Property(e => e.NatureId).HasColumnName("nature_id");
            entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

            entity.HasOne(d => d.Nature).WithMany(p => p.Naturepokeathlonstats).HasForeignKey(d => d.NatureId);

            entity.HasOne(d => d.PokeathlonStat).WithMany(p => p.Naturepokeathlonstats).HasForeignKey(d => d.PokeathlonStatId);
        });

        modelBuilder.Entity<Palpark>(entity =>
        {
            entity.ToTable("palpark");

            entity.HasIndex(e => e.PalParkAreaId, "pokemon_v2_palpark_pal_park_area_id_8df4fce8");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_palpark_pokemon_species_id_639ae7f1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseScore).HasColumnName("base_score");
            entity.Property(e => e.PalParkAreaId).HasColumnName("pal_park_area_id");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");
            entity.Property(e => e.Rate).HasColumnName("rate");

            entity.HasOne(d => d.PalParkArea).WithMany(p => p.Palparks).HasForeignKey(d => d.PalParkAreaId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.Palparks).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<Palparkarea>(entity =>
        {
            entity.ToTable("palparkarea");

            entity.HasIndex(e => e.Name, "pokemon_v2_palparkarea_name_d27212e7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Palparkareaname>(entity =>
        {
            entity.ToTable("palparkareaname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_palparkareaname_language_id_1961595b");

            entity.HasIndex(e => e.Name, "pokemon_v2_palparkareaname_name_1fef3377");

            entity.HasIndex(e => e.PalParkAreaId, "pokemon_v2_palparkareaname_pal_park_area_id_9732132d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PalParkAreaId).HasColumnName("pal_park_area_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Palparkareanames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PalParkArea).WithMany(p => p.Palparkareanames).HasForeignKey(d => d.PalParkAreaId);
        });

        modelBuilder.Entity<Pokeathlonstat>(entity =>
        {
            entity.ToTable("pokeathlonstat");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokeathlonstat_name_dfd410d4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Pokeathlonstatname>(entity =>
        {
            entity.ToTable("pokeathlonstatname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokeathlonstatname_language_id_053b296b");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokeathlonstatname_name_21dff6f1");

            entity.HasIndex(e => e.PokeathlonStatId, "pokemon_v2_pokeathlonstatname_pokeathlon_stat_id_95163495");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokeathlonstatnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokeathlonStat).WithMany(p => p.Pokeathlonstatnames).HasForeignKey(d => d.PokeathlonStatId);
        });

        modelBuilder.Entity<Pokedex>(entity =>
        {
            entity.ToTable("pokedex");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokedex_name_d3054d11");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_pokedex_region_id_d894ac3e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsMainSeries)
                .HasColumnType("bool")
                .HasColumnName("is_main_series");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");

            entity.HasOne(d => d.Region).WithMany(p => p.Pokedices).HasForeignKey(d => d.RegionId);
        });

        modelBuilder.Entity<Pokedexdescription>(entity =>
        {
            entity.ToTable("pokedexdescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokedexdescription_language_id_908fbcc8");

            entity.HasIndex(e => e.PokedexId, "pokemon_v2_pokedexdescription_pokedex_id_6519a3de");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokedexdescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Pokedex).WithMany(p => p.Pokedexdescriptions).HasForeignKey(d => d.PokedexId);
        });

        modelBuilder.Entity<Pokedexname>(entity =>
        {
            entity.ToTable("pokedexname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokedexname_language_id_97285e07");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokedexname_name_9e582b7c");

            entity.HasIndex(e => e.PokedexId, "pokemon_v2_pokedexname_pokedex_id_e31703e5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokedexnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Pokedex).WithMany(p => p.Pokedexnames).HasForeignKey(d => d.PokedexId);
        });

        modelBuilder.Entity<Pokedexversiongroup>(entity =>
        {
            entity.ToTable("pokedexversiongroup");

            entity.HasIndex(e => e.PokedexId, "pokemon_v2_pokedexversiongroup_pokedex_id_e9aaac37");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_pokedexversiongroup_version_group_id_2fbd3e54");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Pokedex).WithMany(p => p.Pokedexversiongroups).HasForeignKey(d => d.PokedexId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Pokedexversiongroups).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Pokemon>(entity =>
        {
            entity.ToTable("pokemon");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemon_name_b4719884");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemon_pokemon_species_id_e3dbafe1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseExperience).HasColumnName("base_experience");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.IsDefault)
                .HasColumnType("bool")
                .HasColumnName("is_default");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.Pokemons).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<Pokemonability>(entity =>
        {
            entity.ToTable("pokemonability");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_pokemonability_ability_id_e6de97cc");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonability_pokemon_id_2d9f606f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.IsHidden)
                .HasColumnType("bool")
                .HasColumnName("is_hidden");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Slot).HasColumnName("slot");

            entity.HasOne(d => d.Ability).WithMany(p => p.Pokemonabilities).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemonabilities).HasForeignKey(d => d.PokemonId);
        });

        modelBuilder.Entity<Pokemonabilitypast>(entity =>
        {
            entity.ToTable("pokemonabilitypast");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_pokemonabilitypast_ability_id_27ce43f2");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemonabilitypast_generation_id_7c49a4a1");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonabilitypast_pokemon_id_1f8eef75");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.IsHidden)
                .HasColumnType("bool")
                .HasColumnName("is_hidden");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Slot).HasColumnName("slot");

            entity.HasOne(d => d.Ability).WithMany(p => p.Pokemonabilitypasts).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Generation).WithMany(p => p.Pokemonabilitypasts).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemonabilitypasts).HasForeignKey(d => d.PokemonId);
        });

        modelBuilder.Entity<Pokemoncolor>(entity =>
        {
            entity.ToTable("pokemoncolor");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemoncolor_name_be656ffc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Pokemoncolorname>(entity =>
        {
            entity.ToTable("pokemoncolorname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemoncolorname_language_id_640a8271");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemoncolorname_name_21cdd894");

            entity.HasIndex(e => e.PokemonColorId, "pokemon_v2_pokemoncolorname_pokemon_color_id_33a759e5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonColorId).HasColumnName("pokemon_color_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokemoncolornames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonColor).WithMany(p => p.Pokemoncolornames).HasForeignKey(d => d.PokemonColorId);
        });

        modelBuilder.Entity<Pokemoncry>(entity =>
        {
            entity.ToTable("pokemoncries");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemoncries_pokemon_id_f4f1bdc4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cries).HasColumnName("cries");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemoncries).HasForeignKey(d => d.PokemonId);
        });

        modelBuilder.Entity<Pokemondexnumber>(entity =>
        {
            entity.ToTable("pokemondexnumber");

            entity.HasIndex(e => e.PokedexId, "pokemon_v2_pokemondexnumber_pokedex_id_5f882d27");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemondexnumber_pokemon_species_id_0b92eca5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");
            entity.Property(e => e.PokedexNumber).HasColumnName("pokedex_number");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

            entity.HasOne(d => d.Pokedex).WithMany(p => p.Pokemondexnumbers).HasForeignKey(d => d.PokedexId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.Pokemondexnumbers).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<Pokemonegggroup>(entity =>
        {
            entity.ToTable("pokemonegggroup");

            entity.HasIndex(e => e.EggGroupId, "pokemon_v2_pokemonegggroup_egg_group_id_cd305d10");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemonegggroup_pokemon_species_id_d0fc6e47");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EggGroupId).HasColumnName("egg_group_id");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

            entity.HasOne(d => d.EggGroup).WithMany(p => p.Pokemonegggroups).HasForeignKey(d => d.EggGroupId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.Pokemonegggroups).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<Pokemonevolution>(entity =>
        {
            entity.ToTable("pokemonevolution");

            entity.HasIndex(e => e.BaseFormId, "pokemon_v2_pokemonevolution_base_form_id_2e16360f");

            entity.HasIndex(e => e.EvolutionItemId, "pokemon_v2_pokemonevolution_evolution_item_id_afdb70a5");

            entity.HasIndex(e => e.EvolutionTriggerId, "pokemon_v2_pokemonevolution_evolution_trigger_id_7d6a5102");

            entity.HasIndex(e => e.EvolvedSpeciesId, "pokemon_v2_pokemonevolution_evolved_species_id_bcbf43a3");

            entity.HasIndex(e => e.GenderId, "pokemon_v2_pokemonevolution_gender_id_ccbf258a");

            entity.HasIndex(e => e.HeldItemId, "pokemon_v2_pokemonevolution_held_item_id_ef69a719");

            entity.HasIndex(e => e.KnownMoveId, "pokemon_v2_pokemonevolution_known_move_id_301dfc54");

            entity.HasIndex(e => e.KnownMoveTypeId, "pokemon_v2_pokemonevolution_known_move_type_id_de1a6bf4");

            entity.HasIndex(e => e.LocationId, "pokemon_v2_pokemonevolution_location_id_fb0e2aa2");

            entity.HasIndex(e => e.PartySpeciesId, "pokemon_v2_pokemonevolution_party_species_id_aa57f0d1");

            entity.HasIndex(e => e.PartyTypeId, "pokemon_v2_pokemonevolution_party_type_id_6af7cb68");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_pokemonevolution_region_id_4eb7c62d");

            entity.HasIndex(e => e.TradeSpeciesId, "pokemon_v2_pokemonevolution_trade_species_id_6eefecdc");

            entity.HasIndex(e => e.UsedMoveId, "pokemon_v2_pokemonevolution_used_move_id_e8700b43");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseFormId).HasColumnName("base_form_id");
            entity.Property(e => e.EvolutionItemId).HasColumnName("evolution_item_id");
            entity.Property(e => e.EvolutionTriggerId).HasColumnName("evolution_trigger_id");
            entity.Property(e => e.EvolvedSpeciesId).HasColumnName("evolved_species_id");
            entity.Property(e => e.GenderId).HasColumnName("gender_id");
            entity.Property(e => e.HeldItemId).HasColumnName("held_item_id");
            entity.Property(e => e.KnownMoveId).HasColumnName("known_move_id");
            entity.Property(e => e.KnownMoveTypeId).HasColumnName("known_move_type_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.MinAffection).HasColumnName("min_affection");
            entity.Property(e => e.MinBeauty).HasColumnName("min_beauty");
            entity.Property(e => e.MinDamageTaken).HasColumnName("min_damage_taken");
            entity.Property(e => e.MinHappiness).HasColumnName("min_happiness");
            entity.Property(e => e.MinLevel).HasColumnName("min_level");
            entity.Property(e => e.MinMoveCount).HasColumnName("min_move_count");
            entity.Property(e => e.MinSteps).HasColumnName("min_steps");
            entity.Property(e => e.NeedsMultiplayer)
                .HasColumnType("bool")
                .HasColumnName("needs_multiplayer");
            entity.Property(e => e.NeedsOverworldRain)
                .HasColumnType("bool")
                .HasColumnName("needs_overworld_rain");
            entity.Property(e => e.PartySpeciesId).HasColumnName("party_species_id");
            entity.Property(e => e.PartyTypeId).HasColumnName("party_type_id");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.RelativePhysicalStats).HasColumnName("relative_physical_stats");
            entity.Property(e => e.TimeOfDay)
                .HasColumnType("varchar(10)")
                .HasColumnName("time_of_day");
            entity.Property(e => e.TradeSpeciesId).HasColumnName("trade_species_id");
            entity.Property(e => e.TurnUpsideDown)
                .HasColumnType("bool")
                .HasColumnName("turn_upside_down");
            entity.Property(e => e.UsedMoveId).HasColumnName("used_move_id");

            entity.HasOne(d => d.BaseForm).WithMany(p => p.Pokemonevolutions).HasForeignKey(d => d.BaseFormId);

            entity.HasOne(d => d.EvolutionItem).WithMany(p => p.PokemonevolutionEvolutionItems).HasForeignKey(d => d.EvolutionItemId);

            entity.HasOne(d => d.EvolutionTrigger).WithMany(p => p.Pokemonevolutions).HasForeignKey(d => d.EvolutionTriggerId);

            entity.HasOne(d => d.EvolvedSpecies).WithMany(p => p.PokemonevolutionEvolvedSpecies).HasForeignKey(d => d.EvolvedSpeciesId);

            entity.HasOne(d => d.Gender).WithMany(p => p.Pokemonevolutions).HasForeignKey(d => d.GenderId);

            entity.HasOne(d => d.HeldItem).WithMany(p => p.PokemonevolutionHeldItems).HasForeignKey(d => d.HeldItemId);

            entity.HasOne(d => d.KnownMove).WithMany(p => p.PokemonevolutionKnownMoves).HasForeignKey(d => d.KnownMoveId);

            entity.HasOne(d => d.KnownMoveType).WithMany(p => p.PokemonevolutionKnownMoveTypes).HasForeignKey(d => d.KnownMoveTypeId);

            entity.HasOne(d => d.Location).WithMany(p => p.Pokemonevolutions).HasForeignKey(d => d.LocationId);

            entity.HasOne(d => d.PartySpecies).WithMany(p => p.PokemonevolutionPartySpecies).HasForeignKey(d => d.PartySpeciesId);

            entity.HasOne(d => d.PartyType).WithMany(p => p.PokemonevolutionPartyTypes).HasForeignKey(d => d.PartyTypeId);

            entity.HasOne(d => d.Region).WithMany(p => p.Pokemonevolutions).HasForeignKey(d => d.RegionId);

            entity.HasOne(d => d.TradeSpecies).WithMany(p => p.PokemonevolutionTradeSpecies).HasForeignKey(d => d.TradeSpeciesId);

            entity.HasOne(d => d.UsedMove).WithMany(p => p.PokemonevolutionUsedMoves).HasForeignKey(d => d.UsedMoveId);
        });

        modelBuilder.Entity<Pokemonform>(entity =>
        {
            entity.ToTable("pokemonform");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonform_name_fe094947");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonform_pokemon_id_f1307072");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_pokemonform_version_group_id_88573ce7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FormName)
                .HasColumnType("varchar(30)")
                .HasColumnName("form_name");
            entity.Property(e => e.FormOrder).HasColumnName("form_order");
            entity.Property(e => e.IsBattleOnly)
                .HasColumnType("bool")
                .HasColumnName("is_battle_only");
            entity.Property(e => e.IsDefault)
                .HasColumnType("bool")
                .HasColumnName("is_default");
            entity.Property(e => e.IsMega)
                .HasColumnType("bool")
                .HasColumnName("is_mega");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemonforms).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Pokemonforms).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Pokemonformgeneration>(entity =>
        {
            entity.ToTable("pokemonformgeneration");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemonformgeneration_generation_id_2f4d5474");

            entity.HasIndex(e => e.PokemonFormId, "pokemon_v2_pokemonformgeneration_pokemon_form_id_63610ed9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.Pokemonformgenerations).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.PokemonForm).WithMany(p => p.Pokemonformgenerations).HasForeignKey(d => d.PokemonFormId);
        });

        modelBuilder.Entity<Pokemonformname>(entity =>
        {
            entity.ToTable("pokemonformname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonformname_language_id_2570013b");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonformname_name_4496fca6");

            entity.HasIndex(e => e.PokemonFormId, "pokemon_v2_pokemonformname_pokemon_form_id_7c4f1fb5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");
            entity.Property(e => e.PokemonName)
                .HasColumnType("varchar(60)")
                .HasColumnName("pokemon_name");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokemonformnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonForm).WithMany(p => p.Pokemonformnames).HasForeignKey(d => d.PokemonFormId);
        });

        modelBuilder.Entity<Pokemonformtype>(entity =>
        {
            entity.ToTable("pokemonformtype");

            entity.HasIndex(e => e.PokemonFormId, "pokemon_v2_pokemonformtype_pokemon_form_id_bff24ddc");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_pokemonformtype_type_id_10672412");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.PokemonForm).WithMany(p => p.Pokemonformtypes).HasForeignKey(d => d.PokemonFormId);

            entity.HasOne(d => d.Type).WithMany(p => p.Pokemonformtypes).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Pokemongameindex>(entity =>
        {
            entity.ToTable("pokemongameindex");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemongameindex_pokemon_id_d1278b45");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_pokemongameindex_version_id_2f3cda39");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemongameindices).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Version).WithMany(p => p.Pokemongameindices).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<Pokemonhabitat>(entity =>
        {
            entity.ToTable("pokemonhabitat");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonhabitat_name_e36918ba");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Pokemonhabitatname>(entity =>
        {
            entity.ToTable("pokemonhabitatname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonhabitatname_language_id_b247fa35");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonhabitatname_name_0b8b38c3");

            entity.HasIndex(e => e.PokemonHabitatId, "pokemon_v2_pokemonhabitatname_pokemon_habitat_id_8bb656e6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonHabitatId).HasColumnName("pokemon_habitat_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokemonhabitatnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonHabitat).WithMany(p => p.Pokemonhabitatnames).HasForeignKey(d => d.PokemonHabitatId);
        });

        modelBuilder.Entity<Pokemonitem>(entity =>
        {
            entity.ToTable("pokemonitem");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_pokemonitem_item_id_f2d37afe");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonitem_pokemon_id_d5dd8083");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_pokemonitem_version_id_4f5c2a1c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Rarity).HasColumnName("rarity");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Item).WithMany(p => p.Pokemonitems).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemonitems).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Version).WithMany(p => p.Pokemonitems).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<Pokemonmove>(entity =>
        {
            entity.ToTable("pokemonmove");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_pokemonmove_move_id_b5f71cf7");

            entity.HasIndex(e => e.MoveLearnMethodId, "pokemon_v2_pokemonmove_move_learn_method_id_f7503746");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonmove_pokemon_id_ca9e0e55");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_pokemonmove_version_group_id_ca4c374c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Mastery).HasColumnName("mastery");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.MoveLearnMethodId).HasColumnName("move_learn_method_id");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Move).WithMany(p => p.Pokemonmoves).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.MoveLearnMethod).WithMany(p => p.Pokemonmoves).HasForeignKey(d => d.MoveLearnMethodId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemonmoves).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Pokemonmoves).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Pokemonshape>(entity =>
        {
            entity.ToTable("pokemonshape");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonshape_name_d7251478");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Pokemonshapename>(entity =>
        {
            entity.ToTable("pokemonshapename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonshapename_language_id_e094373f");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonshapename_name_224dc527");

            entity.HasIndex(e => e.PokemonShapeId, "pokemon_v2_pokemonshapename_pokemon_shape_id_69bb934f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AwesomeName)
                .HasColumnType("varchar(30)")
                .HasColumnName("awesome_name");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonShapeId).HasColumnName("pokemon_shape_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokemonshapenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonShape).WithMany(p => p.Pokemonshapenames).HasForeignKey(d => d.PokemonShapeId);
        });

        modelBuilder.Entity<Pokemonspeciesdescription>(entity =>
        {
            entity.ToTable("pokemonspeciesdescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonspeciesdescription_language_id_75b5e267");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemonspeciesdescription_pokemon_species_id_c62bce07");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(2000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokemonspeciesdescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.Pokemonspeciesdescriptions).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<Pokemonspeciesflavortext>(entity =>
        {
            entity.ToTable("pokemonspeciesflavortext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonspeciesflavortext_language_id_725fcf28");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemonspeciesflavortext_pokemon_species_id_345e9c6c");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_pokemonspeciesflavortext_version_id_67eb47ad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokemonspeciesflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.Pokemonspeciesflavortexts).HasForeignKey(d => d.PokemonSpeciesId);

            entity.HasOne(d => d.Version).WithMany(p => p.Pokemonspeciesflavortexts).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<Pokemonspeciesname>(entity =>
        {
            entity.ToTable("pokemonspeciesname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonspeciesname_language_id_1a5acda5");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonspeciesname_name_e53fa719");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemonspeciesname_pokemon_species_id_6566cdc8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Genus)
                .HasColumnType("varchar(30)")
                .HasColumnName("genus");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Pokemonspeciesnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.Pokemonspeciesnames).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<Pokemonspecy>(entity =>
        {
            entity.ToTable("pokemonspecies");

            entity.HasIndex(e => e.EvolutionChainId, "pokemon_v2_pokemonspecies_evolution_chain_id_d94981c6");

            entity.HasIndex(e => e.EvolvesFromSpeciesId, "pokemon_v2_pokemonspecies_evolves_from_species_id_6e40aea2");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemonspecies_generation_id_57b5b3ef");

            entity.HasIndex(e => e.GrowthRateId, "pokemon_v2_pokemonspecies_growth_rate_id_78ff36e3");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonspecies_name_f1ec390b");

            entity.HasIndex(e => e.PokemonColorId, "pokemon_v2_pokemonspecies_pokemon_color_id_27cb23c7");

            entity.HasIndex(e => e.PokemonHabitatId, "pokemon_v2_pokemonspecies_pokemon_habitat_id_61d7914c");

            entity.HasIndex(e => e.PokemonShapeId, "pokemon_v2_pokemonspecies_pokemon_shape_id_9420bbbf");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseHappiness).HasColumnName("base_happiness");
            entity.Property(e => e.CaptureRate).HasColumnName("capture_rate");
            entity.Property(e => e.EvolutionChainId).HasColumnName("evolution_chain_id");
            entity.Property(e => e.EvolvesFromSpeciesId).HasColumnName("evolves_from_species_id");
            entity.Property(e => e.FormsSwitchable)
                .HasColumnType("bool")
                .HasColumnName("forms_switchable");
            entity.Property(e => e.GenderRate).HasColumnName("gender_rate");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");
            entity.Property(e => e.HasGenderDifferences)
                .HasColumnType("bool")
                .HasColumnName("has_gender_differences");
            entity.Property(e => e.HatchCounter).HasColumnName("hatch_counter");
            entity.Property(e => e.IsBaby)
                .HasColumnType("bool")
                .HasColumnName("is_baby");
            entity.Property(e => e.IsLegendary)
                .HasColumnType("bool")
                .HasColumnName("is_legendary");
            entity.Property(e => e.IsMythical)
                .HasColumnType("bool")
                .HasColumnName("is_mythical");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PokemonColorId).HasColumnName("pokemon_color_id");
            entity.Property(e => e.PokemonHabitatId).HasColumnName("pokemon_habitat_id");
            entity.Property(e => e.PokemonShapeId).HasColumnName("pokemon_shape_id");

            entity.HasOne(d => d.EvolutionChain).WithMany(p => p.Pokemonspecies).HasForeignKey(d => d.EvolutionChainId);

            entity.HasOne(d => d.EvolvesFromSpecies).WithMany(p => p.InverseEvolvesFromSpecies).HasForeignKey(d => d.EvolvesFromSpeciesId);

            entity.HasOne(d => d.Generation).WithMany(p => p.Pokemonspecies).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.GrowthRate).WithMany(p => p.Pokemonspecies).HasForeignKey(d => d.GrowthRateId);

            entity.HasOne(d => d.PokemonColor).WithMany(p => p.Pokemonspecies).HasForeignKey(d => d.PokemonColorId);

            entity.HasOne(d => d.PokemonHabitat).WithMany(p => p.Pokemonspecies).HasForeignKey(d => d.PokemonHabitatId);

            entity.HasOne(d => d.PokemonShape).WithMany(p => p.Pokemonspecies).HasForeignKey(d => d.PokemonShapeId);
        });

        modelBuilder.Entity<Pokemonstat>(entity =>
        {
            entity.ToTable("pokemonstat");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonstat_pokemon_id_224bda7f");

            entity.HasIndex(e => e.StatId, "pokemon_v2_pokemonstat_stat_id_ff99830f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseStat).HasColumnName("base_stat");
            entity.Property(e => e.Effort).HasColumnName("effort");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemonstats).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Stat).WithMany(p => p.Pokemonstats).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<Pokemonstatpast>(entity =>
        {
            entity.ToTable("pokemonstatpast");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemonstatpast_generation_id_a799e6a3");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonstatpast_pokemon_id_ec8a0102");

            entity.HasIndex(e => e.StatId, "pokemon_v2_pokemonstatpast_stat_id_055ba550");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseStat).HasColumnName("base_stat");
            entity.Property(e => e.Effort).HasColumnName("effort");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.Pokemonstatpasts).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemonstatpasts).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Stat).WithMany(p => p.Pokemonstatpasts).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<Pokemontype>(entity =>
        {
            entity.ToTable("pokemontype");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemontype_pokemon_id_8cd53409");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_pokemontype_type_id_50c80158");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemontypes).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Type).WithMany(p => p.Pokemontypes).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Pokemontypepast>(entity =>
        {
            entity.ToTable("pokemontypepast");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemontypepast_generation_id_9dbf45f3");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemontypepast_pokemon_id_7c9bb3e4");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_pokemontypepast_type_id_c7a01783");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.Pokemontypepasts).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.Pokemontypepasts).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Type).WithMany(p => p.Pokemontypepasts).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.ToTable("region");

            entity.HasIndex(e => e.Name, "pokemon_v2_region_name_8acf2189");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Regionname>(entity =>
        {
            entity.ToTable("regionname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_regionname_language_id_b977a545");

            entity.HasIndex(e => e.Name, "pokemon_v2_regionname_name_d9c7dec9");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_regionname_region_id_70a321d1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Regionnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Region).WithMany(p => p.Regionnames).HasForeignKey(d => d.RegionId);
        });

        modelBuilder.Entity<Stat>(entity =>
        {
            entity.ToTable("stat");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_stat_move_damage_class_id_0ed19a23");

            entity.HasIndex(e => e.Name, "pokemon_v2_stat_name_abcae9af");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.IsBattleOnly)
                .HasColumnType("bool")
                .HasColumnName("is_battle_only");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.Stats).HasForeignKey(d => d.MoveDamageClassId);
        });

        modelBuilder.Entity<Statname>(entity =>
        {
            entity.ToTable("statname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_statname_language_id_813421dc");

            entity.HasIndex(e => e.Name, "pokemon_v2_statname_name_e6d5a1d2");

            entity.HasIndex(e => e.StatId, "pokemon_v2_statname_stat_id_fadbe40b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Statnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Stat).WithMany(p => p.Statnames).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<Supercontestcombo>(entity =>
        {
            entity.ToTable("supercontestcombo");

            entity.HasIndex(e => e.FirstMoveId, "pokemon_v2_supercontestcombo_first_move_id_b595ebbb");

            entity.HasIndex(e => e.SecondMoveId, "pokemon_v2_supercontestcombo_second_move_id_15fdde61");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstMoveId).HasColumnName("first_move_id");
            entity.Property(e => e.SecondMoveId).HasColumnName("second_move_id");

            entity.HasOne(d => d.FirstMove).WithMany(p => p.SupercontestcomboFirstMoves).HasForeignKey(d => d.FirstMoveId);

            entity.HasOne(d => d.SecondMove).WithMany(p => p.SupercontestcomboSecondMoves).HasForeignKey(d => d.SecondMoveId);
        });

        modelBuilder.Entity<Supercontesteffect>(entity =>
        {
            entity.ToTable("supercontesteffect");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appeal).HasColumnName("appeal");
        });

        modelBuilder.Entity<Supercontesteffectflavortext>(entity =>
        {
            entity.ToTable("supercontesteffectflavortext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_supercontesteffectflavortext_language_id_a8b218a8");

            entity.HasIndex(e => e.SuperContestEffectId, "pokemon_v2_supercontesteffectflavortext_super_contest_effect_id_632d04b4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.SuperContestEffectId).HasColumnName("super_contest_effect_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Supercontesteffectflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.SuperContestEffect).WithMany(p => p.Supercontesteffectflavortexts).HasForeignKey(d => d.SuperContestEffectId);
        });

        modelBuilder.Entity<Models.Type>(entity =>
        {
            entity.ToTable("type");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_type_generation_id_f3988f1c");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_type_move_damage_class_id_5f546a8f");

            entity.HasIndex(e => e.Name, "pokemon_v2_type_name_90172f48");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Generation).WithMany(p => p.Types).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.Types).HasForeignKey(d => d.MoveDamageClassId);
        });

        modelBuilder.Entity<Typeefficacy>(entity =>
        {
            entity.ToTable("typeefficacy");

            entity.HasIndex(e => e.DamageTypeId, "pokemon_v2_typeefficacy_damage_type_id_1b7c2d73");

            entity.HasIndex(e => e.TargetTypeId, "pokemon_v2_typeefficacy_target_type_id_bf2be275");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DamageFactor).HasColumnName("damage_factor");
            entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");
            entity.Property(e => e.TargetTypeId).HasColumnName("target_type_id");

            entity.HasOne(d => d.DamageType).WithMany(p => p.TypeefficacyDamageTypes).HasForeignKey(d => d.DamageTypeId);

            entity.HasOne(d => d.TargetType).WithMany(p => p.TypeefficacyTargetTypes).HasForeignKey(d => d.TargetTypeId);
        });

        modelBuilder.Entity<Typeefficacypast>(entity =>
        {
            entity.ToTable("typeefficacypast");

            entity.HasIndex(e => e.DamageTypeId, "pokemon_v2_typeefficacypast_damage_type_id_b8eae4c9");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_typeefficacypast_generation_id_43b555ea");

            entity.HasIndex(e => e.TargetTypeId, "pokemon_v2_typeefficacypast_target_type_id_2e9e1cb6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DamageFactor).HasColumnName("damage_factor");
            entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.TargetTypeId).HasColumnName("target_type_id");

            entity.HasOne(d => d.DamageType).WithMany(p => p.TypeefficacypastDamageTypes).HasForeignKey(d => d.DamageTypeId);

            entity.HasOne(d => d.Generation).WithMany(p => p.Typeefficacypasts).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.TargetType).WithMany(p => p.TypeefficacypastTargetTypes).HasForeignKey(d => d.TargetTypeId);
        });

        modelBuilder.Entity<Typegameindex>(entity =>
        {
            entity.ToTable("typegameindex");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_typegameindex_generation_id_520a4043");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_typegameindex_type_id_8264662d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.Typegameindices).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Type).WithMany(p => p.Typegameindices).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Typename>(entity =>
        {
            entity.ToTable("typename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_typename_language_id_6b15eb1d");

            entity.HasIndex(e => e.Name, "pokemon_v2_typename_name_95fbeace");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_typename_type_id_3fe2e4d2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Typenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Type).WithMany(p => p.Typenames).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Models.Version>(entity =>
        {
            entity.ToTable("version");

            entity.HasIndex(e => e.Name, "pokemon_v2_version_name_a1b54eaa");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_version_version_group_id_1ab67107");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Versions).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Versiongroup>(entity =>
        {
            entity.ToTable("versiongroup");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_versiongroup_generation_id_f7073699");

            entity.HasIndex(e => e.Name, "pokemon_v2_versiongroup_name_4c396513");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");

            entity.HasOne(d => d.Generation).WithMany(p => p.Versiongroups).HasForeignKey(d => d.GenerationId);
        });

        modelBuilder.Entity<Versiongroupmovelearnmethod>(entity =>
        {
            entity.ToTable("versiongroupmovelearnmethod");

            entity.HasIndex(e => e.MoveLearnMethodId, "pokemon_v2_versiongroupmovelearnmethod_move_learn_method_id_7e827604");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_versiongroupmovelearnmethod_version_group_id_36c973b6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MoveLearnMethodId).HasColumnName("move_learn_method_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.MoveLearnMethod).WithMany(p => p.Versiongroupmovelearnmethods).HasForeignKey(d => d.MoveLearnMethodId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Versiongroupmovelearnmethods).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Versiongroupregion>(entity =>
        {
            entity.ToTable("versiongroupregion");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_versiongroupregion_region_id_8f876d0b");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_versiongroupregion_version_group_id_a3445bcb");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Region).WithMany(p => p.Versiongroupregions).HasForeignKey(d => d.RegionId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.Versiongroupregions).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<Versionname>(entity =>
        {
            entity.ToTable("versionname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_versionname_language_id_890e148a");

            entity.HasIndex(e => e.Name, "pokemon_v2_versionname_name_df504fd7");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_versionname_version_id_84baf0a3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Language).WithMany(p => p.Versionnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Version).WithMany(p => p.Versionnames).HasForeignKey(d => d.VersionId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
