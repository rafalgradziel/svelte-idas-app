﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UIPflege.DB;

#nullable disable

namespace Gandalan.IDAS.IDASWebApp.Migrations
{
    [DbContext(typeof(UIPflegeContext))]
    [Migration("20221117125225_DatatypeChanges")]
    partial class DatatypeChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UIPflege.DB.KonfigSatz", b =>
                {
                    b.Property<long>("KonfigSatzId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("KonfigSatzId"));

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<Guid>("KonfigSatzGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Version")
                        .HasColumnType("bigint");

                    b.HasKey("KonfigSatzId");

                    b.ToTable("KonfigSaetze");
                });

            modelBuilder.Entity("UIPflege.DB.KonfigSatzEintrag", b =>
                {
                    b.Property<long>("KonfigSatzEintragId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("KonfigSatzEintragId"));

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DatenTyp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<string>("KonfigName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("KonfigSatzEintragGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("KonfigSatzId")
                        .HasColumnType("bigint");

                    b.Property<string>("UnterkomponenteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Version")
                        .HasColumnType("bigint");

                    b.Property<string>("Wert")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KonfigSatzEintragId");

                    b.HasIndex("KonfigSatzId");

                    b.ToTable("KonfigSatzEintraege");
                });

            modelBuilder.Entity("UIPflege.DB.UIDefinition", b =>
                {
                    b.Property<long>("UIDefinitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UIDefinitionId"));

                    b.Property<string>("BezeichnungKurz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BezeichnungLang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bild3D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BildHorizontal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BildVertikal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<string>("Kategorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UIDefinitionGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Version")
                        .HasColumnType("bigint");

                    b.HasKey("UIDefinitionId");

                    b.ToTable("UIDefinitionen");
                });

            modelBuilder.Entity("UIPflege.DB.UIEingabeFeld", b =>
                {
                    b.Property<long>("UIEingabeFeldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UIEingabeFeldId"));

                    b.Property<string>("AngebotsText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BelegBlattText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EingabeLevel")
                        .HasColumnType("int");

                    b.Property<string>("FehlerText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GehoertZuZusatzFeldGruppeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GueltigAb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GueltigBis")
                        .HasColumnType("datetime2");

                    b.Property<string>("HilfeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<bool>("IstKonfiguratorFeld")
                        .HasColumnType("bit");

                    b.Property<double>("MaxWert")
                        .HasColumnType("float");

                    b.Property<bool>("MaxWertWeichPruefen")
                        .HasColumnType("bit");

                    b.Property<double>("MinWert")
                        .HasColumnType("float");

                    b.Property<bool>("MinWertWeichPruefen")
                        .HasColumnType("bit");

                    b.Property<int>("MindestBreite")
                        .HasColumnType("int");

                    b.Property<bool>("PreisFeldAnzeigen")
                        .HasColumnType("bit");

                    b.Property<int>("Reihenfolge")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UIDefinitionId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UIEingabeFeldGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Version")
                        .HasColumnType("bigint");

                    b.Property<string>("VorgabeWert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarnText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WerteListeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZusatzFeldGruppeId")
                        .HasColumnType("int");

                    b.HasKey("UIEingabeFeldId");

                    b.HasIndex("UIDefinitionId");

                    b.ToTable("EingabeFelder");
                });

            modelBuilder.Entity("UIPflege.DB.UIKonfiguratorFeld", b =>
                {
                    b.Property<long>("UIKonfiguratorFeldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UIKonfiguratorFeldId"));

                    b.Property<string>("AngebotsText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BelegBlattText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EingabeLevel")
                        .HasColumnType("int");

                    b.Property<int?>("GehoertZuProfilId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GueltigAb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GueltigBis")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<string>("Kuerzel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfilId")
                        .HasColumnType("int");

                    b.Property<int>("Reihenfolge")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UIDefinitionId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UIKonfiguratorFeldGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Version")
                        .HasColumnType("bigint");

                    b.Property<string>("VorgabeWert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WerteListeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UIKonfiguratorFeldId");

                    b.HasIndex("UIDefinitionId");

                    b.ToTable("KonfiguratorFelder");
                });

            modelBuilder.Entity("UIPflege.DB.Variante", b =>
                {
                    b.Property<long>("VarianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("VarianteId"));

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<Guid>("KonfigSatzGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("KonfigSatzId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UIDefinitionGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UIDefinitionId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("VarianteGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("VarianteId");

                    b.HasIndex("KonfigSatzId");

                    b.HasIndex("UIDefinitionId");

                    b.ToTable("Varianten");
                });

            modelBuilder.Entity("UIPflege.DB.WerteListe", b =>
                {
                    b.Property<long>("WerteListeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("WerteListeId"));

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GueltigAb")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Version")
                        .HasColumnType("bigint");

                    b.Property<Guid>("WerteListeGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WerteListeId");

                    b.ToTable("WerteListe");
                });

            modelBuilder.Entity("UIPflege.DB.WerteListeItem", b =>
                {
                    b.Property<long>("WerteListeItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("WerteListeItemId"));

                    b.Property<string>("AngebotsText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BelegBlattText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beschreibung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GueltigAb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GueltigBis")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<string>("Kuerzel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reihenfolge")
                        .HasColumnType("int");

                    b.Property<long>("Version")
                        .HasColumnType("bigint");

                    b.Property<long>("WerteListeId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("WerteListeItemGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WerteListeItemId");

                    b.HasIndex("WerteListeId");

                    b.ToTable("WerteListeItem");
                });

            modelBuilder.Entity("UIPflege.DB.KonfigSatzEintrag", b =>
                {
                    b.HasOne("UIPflege.DB.KonfigSatz", null)
                        .WithMany("Eintraege")
                        .HasForeignKey("KonfigSatzId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UIPflege.DB.UIEingabeFeld", b =>
                {
                    b.HasOne("UIPflege.DB.UIDefinition", "UIDefinition")
                        .WithMany("EingabeFelder")
                        .HasForeignKey("UIDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UIDefinition");
                });

            modelBuilder.Entity("UIPflege.DB.UIKonfiguratorFeld", b =>
                {
                    b.HasOne("UIPflege.DB.UIDefinition", "UIDefinition")
                        .WithMany("KonfiguratorFelder")
                        .HasForeignKey("UIDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UIDefinition");
                });

            modelBuilder.Entity("UIPflege.DB.Variante", b =>
                {
                    b.HasOne("UIPflege.DB.KonfigSatz", "KonfigSatz")
                        .WithMany()
                        .HasForeignKey("KonfigSatzId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UIPflege.DB.UIDefinition", "UIDefinition")
                        .WithMany("Varianten")
                        .HasForeignKey("UIDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KonfigSatz");

                    b.Navigation("UIDefinition");
                });

            modelBuilder.Entity("UIPflege.DB.WerteListeItem", b =>
                {
                    b.HasOne("UIPflege.DB.WerteListe", "WerteListe")
                        .WithMany("Items")
                        .HasForeignKey("WerteListeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WerteListe");
                });

            modelBuilder.Entity("UIPflege.DB.KonfigSatz", b =>
                {
                    b.Navigation("Eintraege");
                });

            modelBuilder.Entity("UIPflege.DB.UIDefinition", b =>
                {
                    b.Navigation("EingabeFelder");

                    b.Navigation("KonfiguratorFelder");

                    b.Navigation("Varianten");
                });

            modelBuilder.Entity("UIPflege.DB.WerteListe", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
