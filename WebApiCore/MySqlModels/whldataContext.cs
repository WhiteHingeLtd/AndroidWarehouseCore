using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace WebApiCore.MySqlModels
{
    public partial class whldataContext : DbContext
    {
        public virtual DbSet<BoxOwnership> BoxOwnership { get; set; }
        public virtual DbSet<Deliverydata> Deliverydata { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Envelopes> Envelopes { get; set; }
        public virtual DbSet<Feesandsurcharges> Feesandsurcharges { get; set; }
        public virtual DbSet<Gs1list> Gs1list { get; set; }
        public virtual DbSet<ImageNeeded> ImageNeeded { get; set; }
        public virtual DbSet<ImageRedo> ImageRedo { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryBoxes> InventoryBoxes { get; set; }
        public virtual DbSet<Itemsunderconstruction> Itemsunderconstruction { get; set; }
        public virtual DbSet<Labourcosts> Labourcosts { get; set; }
        public virtual DbSet<Linnworksguid> Linnworksguid { get; set; }
        public virtual DbSet<Listinglist> Listinglist { get; set; }
        public virtual DbSet<Locationaudit> Locationaudit { get; set; }
        public virtual DbSet<Locationreference> Locationreference { get; set; }
        public virtual DbSet<LocationRouting> LocationRouting { get; set; }
        public virtual DbSet<LogClockcard> LogClockcard { get; set; }
        public virtual DbSet<LogLoginout> LogLoginout { get; set; }
        public virtual DbSet<LogPrepack> LogPrepack { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<MessengerMessages> MessengerMessages { get; set; }
        public virtual DbSet<MessengerThreads> MessengerThreads { get; set; }
        public virtual DbSet<Newamazonlistings> Newamazonlistings { get; set; }
        public virtual DbSet<NewsalesDailysourcetotals> NewsalesDailysourcetotals { get; set; }
        public virtual DbSet<NewsalesFinancials> NewsalesFinancials { get; set; }
        public virtual DbSet<NewsalesItems> NewsalesItems { get; set; }
        public virtual DbSet<NewsalesRaw> NewsalesRaw { get; set; }
        public virtual DbSet<OrderwiseData> OrderwiseData { get; set; }
        public virtual DbSet<Oversoldorders> Oversoldorders { get; set; }
        public virtual DbSet<Postagecosts> Postagecosts { get; set; }
        public virtual DbSet<PostagePrices> PostagePrices { get; set; }
        public virtual DbSet<PrepackCleared> PrepackCleared { get; set; }
        public virtual DbSet<Prepacklist> Prepacklist { get; set; }
        public virtual DbSet<PrepackTest> PrepackTest { get; set; }
        public virtual DbSet<PrepackType> PrepackType { get; set; }
        public virtual DbSet<Processed> Processed { get; set; }
        public virtual DbSet<ReorderOrderitems> ReorderOrderitems { get; set; }
        public virtual DbSet<ReorderOrders> ReorderOrders { get; set; }
        public virtual DbSet<ReorderSupplierdata> ReorderSupplierdata { get; set; }
        public virtual DbSet<Salesdata> Salesdata { get; set; }
        public virtual DbSet<SalesdataWeirddays> SalesdataWeirddays { get; set; }
        public virtual DbSet<ShortskuLocations> ShortskuLocations { get; set; }
        public virtual DbSet<SkuCategories> SkuCategories { get; set; }
        public virtual DbSet<SkuChangelog> SkuChangelog { get; set; }
        public virtual DbSet<SkuComposition> SkuComposition { get; set; }
        public virtual DbSet<SkuDates> SkuDates { get; set; }
        public virtual DbSet<SkuImages> SkuImages { get; set; }
        public virtual DbSet<SkuLocations> SkuLocations { get; set; }
        public virtual DbSet<SkuSupplierdata> SkuSupplierdata { get; set; }
        public virtual DbSet<SkuWebsaleinfo> SkuWebsaleinfo { get; set; }
        public virtual DbSet<StockHistory> StockHistory { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<UserNotifications> UserNotifications { get; set; }
        public virtual DbSet<VncClients> VncClients { get; set; }
        public virtual DbSet<WarehouseIssueLog> WarehouseIssueLog { get; set; }
        public virtual DbSet<WarehousePcReference> WarehousePcReference { get; set; }
        public virtual DbSet<Warehousereference> Warehousereference { get; set; }
        public virtual DbSet<Whlnew> Whlnew { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Database=whldata;Data Source=sql.ad.whitehinge.com;User Id=appuser;Password=apppassword;ConnectionTimeout=4;SslMode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoxOwnership>(entity =>
            {
                entity.ToTable("box_ownership");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BoxNumber)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Deliverydata>(entity =>
            {
                entity.HasKey(e => e.DevId);

                entity.ToTable("deliverydata");

                entity.Property(e => e.DevId)
                    .HasColumnName("DevID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Barcode).HasMaxLength(45);

                entity.Property(e => e.Page).HasMaxLength(45);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.PayrollNo);

                entity.ToTable("employees");

                entity.HasIndex(e => e.PayrollNo)
                    .HasName("idemployees_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.PayrollNo)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveDirectoryUser).HasMaxLength(45);

                entity.Property(e => e.AuthCodes).HasMaxLength(45);

                entity.Property(e => e.FirstName).HasMaxLength(45);

                entity.Property(e => e.HashedPin).HasMaxLength(45);

                entity.Property(e => e.LoginPin).HasMaxLength(8);

                entity.Property(e => e.LoginTimeout).HasColumnType("int(11)");

                entity.Property(e => e.NotShowOnTable).HasMaxLength(45);

                entity.Property(e => e.ProtAuthCode).HasMaxLength(45);

                entity.Property(e => e.StartDate).HasMaxLength(45);

                entity.Property(e => e.Surname).HasMaxLength(45);

                entity.Property(e => e.WarehouseAreaFinish).HasMaxLength(45);

                entity.Property(e => e.WarehouseAreaStart).HasMaxLength(45);
            });

            modelBuilder.Entity<Envelopes>(entity =>
            {
                entity.HasKey(e => e.EnvCode);

                entity.ToTable("envelopes");

                entity.HasIndex(e => e.EnvCode)
                    .HasName("envCode_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.EnvCode)
                    .HasColumnName("envCode")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.EnvBoxNet).HasColumnName("envBoxNet");

                entity.Property(e => e.EnvBoxQuan)
                    .HasColumnName("envBoxQuan")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnvFrom)
                    .HasColumnName("envFrom")
                    .HasMaxLength(45);

                entity.Property(e => e.EnvIndCost).HasColumnName("envIndCost");

                entity.Property(e => e.EnvName)
                    .HasColumnName("envName")
                    .HasMaxLength(100);

                entity.Property(e => e.EnvNewName)
                    .HasColumnName("envNewName")
                    .HasMaxLength(100);

                entity.Property(e => e.EnvSize)
                    .HasColumnName("envSize")
                    .HasMaxLength(100);

                entity.Property(e => e.EnvWeight)
                    .HasColumnName("envWeight")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsHidden)
                    .HasColumnName("isHidden")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NeedsBox)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Feesandsurcharges>(entity =>
            {
                entity.HasKey(e => e.FeesId);

                entity.ToTable("feesandsurcharges");

                entity.Property(e => e.FeesId)
                    .HasColumnName("feesID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(45);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Gs1list>(entity =>
            {
                entity.HasKey(e => e.Gs1);

                entity.ToTable("gs1list");

                entity.HasIndex(e => e.Gs1)
                    .HasName("gs1_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Gs1)
                    .HasColumnName("gs1")
                    .HasMaxLength(15)
                    .ValueGeneratedNever();

                entity.Property(e => e.Usedby)
                    .HasColumnName("usedby")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("None");
            });

            modelBuilder.Entity<ImageNeeded>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("image_needed");

                entity.Property(e => e.Sku)
                    .HasMaxLength(13)
                    .ValueGeneratedNever();

                entity.Property(e => e.Needed)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("False");
            });

            modelBuilder.Entity<ImageRedo>(entity =>
            {
                entity.HasKey(e => e.Filename);

                entity.ToTable("image_redo");

                entity.HasIndex(e => e.Filename)
                    .HasName("filename_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Redo)
                    .IsRequired()
                    .HasColumnName("redo")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("False");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("inventory");

                entity.HasIndex(e => e.Sku)
                    .HasName("SKU_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasMaxLength(45);

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(110);

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Defaultpacking)
                    .HasColumnName("defaultpacking")
                    .HasMaxLength(45);

                entity.Property(e => e.Defaultpost)
                    .HasColumnName("defaultpost")
                    .HasMaxLength(45);

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(45);

                entity.Property(e => e.Pack)
                    .HasColumnName("pack")
                    .HasMaxLength(45);

                entity.Property(e => e.ShortDesc).HasMaxLength(100);

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stockavailable)
                    .HasColumnName("stockavailable")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stockdue)
                    .HasColumnName("stockdue")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stockminimum)
                    .HasColumnName("stockminimum")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stockorder)
                    .HasColumnName("stockorder")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stockvalue)
                    .HasColumnName("stockvalue")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Taxrate)
                    .HasColumnName("taxrate")
                    .HasMaxLength(45);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Variant)
                    .HasColumnName("variant")
                    .HasMaxLength(45);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<InventoryBoxes>(entity =>
            {
                entity.HasKey(e => e.BoxId);

                entity.ToTable("inventory_boxes");

                entity.Property(e => e.BoxId)
                    .HasColumnName("BoxID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BoxDisplayName).HasMaxLength(60);
            });

            modelBuilder.Entity<Itemsunderconstruction>(entity =>
            {
                entity.HasKey(e => e.ItemTempId);

                entity.ToTable("itemsunderconstruction");

                entity.HasIndex(e => e.ItemTempId)
                    .HasName("ItemTempID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ItemTempId)
                    .HasColumnName("ItemTempID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Batch).HasColumnType("int(11)");

                entity.Property(e => e.Box).HasMaxLength(45);

                entity.Property(e => e.Brand).HasMaxLength(45);

                entity.Property(e => e.Category).HasMaxLength(45);

                entity.Property(e => e.CheckedBy).HasMaxLength(45);

                entity.Property(e => e.Code).HasMaxLength(45);

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.Distinguish).HasMaxLength(45);

                entity.Property(e => e.EntryDate).HasMaxLength(45);

                entity.Property(e => e.EntryUser).HasMaxLength(45);

                entity.Property(e => e.Exported).HasMaxLength(45);

                entity.Property(e => e.Finish).HasMaxLength(45);

                entity.Property(e => e.InnerBarcode).HasMaxLength(45);

                entity.Property(e => e.InnerCarton).HasMaxLength(45);

                entity.Property(e => e.ItemBarcode).HasMaxLength(45);

                entity.Property(e => e.Notes).HasMaxLength(300);

                entity.Property(e => e.OuterBarcode).HasMaxLength(45);

                entity.Property(e => e.Oversized).HasMaxLength(45);

                entity.Property(e => e.Pair).HasMaxLength(45);

                entity.Property(e => e.Parts).HasMaxLength(45);

                entity.Property(e => e.Pc).HasMaxLength(45);

                entity.Property(e => e.Screws).HasMaxLength(45);

                entity.Property(e => e.ShelfLocation).HasMaxLength(45);

                entity.Property(e => e.Size).HasMaxLength(45);

                entity.Property(e => e.StockLevel).HasMaxLength(45);

                entity.Property(e => e.Supplier).HasMaxLength(45);

                entity.Property(e => e.Weight).HasMaxLength(45);
            });

            modelBuilder.Entity<Labourcosts>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("labourcosts");

                entity.HasIndex(e => e.Code)
                    .HasName("idlabourcosts_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Linnworksguid>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("linnworksguid");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(45)
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Listinglist>(entity =>
            {
                entity.HasKey(e => e.EBayListing);

                entity.ToTable("listinglist");

                entity.Property(e => e.EBayListing)
                    .HasColumnName("eBayListing")
                    .HasMaxLength(45)
                    .ValueGeneratedNever();

                entity.Property(e => e.LinnworksGuid)
                    .HasColumnName("LinnworksGUID")
                    .HasMaxLength(45);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Locationaudit>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.ToTable("locationaudit");

                entity.Property(e => e.AuditId)
                    .HasColumnName("AuditID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Additional).HasColumnType("int(11)");

                entity.Property(e => e.AuditEvent).HasColumnType("int(11)");

                entity.Property(e => e.AuditUserId)
                    .HasColumnName("AuditUserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateOfEvent).HasColumnType("datetime");

                entity.Property(e => e.EventSource)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasDefaultValueSql("Unknown");

                entity.Property(e => e.FriendlyString).HasMaxLength(1000);

                entity.Property(e => e.LocationId)
                    .IsRequired()
                    .HasColumnName("LocationID")
                    .HasMaxLength(45);

                entity.Property(e => e.LocationText).HasMaxLength(45);

                entity.Property(e => e.ShortSku)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TotalAtTime)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Locationreference>(entity =>
            {
                entity.HasKey(e => e.LocId);

                entity.ToTable("locationreference");

                entity.HasIndex(e => e.LocWarehouse)
                    .HasName("WarehouseKey_idx");

                entity.Property(e => e.LocId)
                    .HasColumnName("locID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LocText)
                    .IsRequired()
                    .HasColumnName("locText")
                    .HasMaxLength(9);

                entity.Property(e => e.LocType)
                    .HasColumnName("locType")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocWarehouse)
                    .HasColumnName("locWarehouse")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OwZone)
                    .IsRequired()
                    .HasColumnName("ow_zone")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("Standard");

                entity.Property(e => e.PickOrReplenish).HasColumnType("int(11)");

                entity.Property(e => e.RouteId)
                    .HasColumnName("RouteID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.HasOne(d => d.LocWarehouseNavigation)
                    .WithMany(p => p.Locationreference)
                    .HasForeignKey(d => d.LocWarehouse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WarehouseKey");
            });

            modelBuilder.Entity<LocationRouting>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.ToTable("location_routing");

                entity.HasIndex(e => e.RouteId)
                    .HasName("﻿RouteID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.RouteId)
                    .HasColumnName("RouteID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RouteBlockName).HasColumnType("text");

                entity.Property(e => e.RouteIndex).HasColumnType("int(11)");

                entity.Property(e => e.WarehouseId)
                    .HasColumnName("WarehouseID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("ZoneID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LogClockcard>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("log_clockcard");

                entity.HasIndex(e => e.UserId)
                    .HasName("empid_idx");

                entity.Property(e => e.Logid)
                    .HasColumnName("logid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Unit).HasMaxLength(45);

                entity.Property(e => e.UsedCard).HasMaxLength(45);

                entity.Property(e => e.UserFullName).HasMaxLength(45);

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.UserName).HasMaxLength(45);

                entity.Property(e => e.UserReason).HasMaxLength(45);

                entity.Property(e => e.UserStatus).HasMaxLength(45);

                entity.Property(e => e.UserTime).HasMaxLength(45);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogClockcard)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("empid");
            });

            modelBuilder.Entity<LogLoginout>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("log_loginout");

                entity.HasIndex(e => e.Logid)
                    .HasName("logid_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("empid_idx");

                entity.Property(e => e.Logid)
                    .HasColumnName("logid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Action).HasMaxLength(45);

                entity.Property(e => e.Time).HasMaxLength(45);

                entity.Property(e => e.UserFullName).HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkstationName).HasMaxLength(45);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogLoginout)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("loginout");
            });

            modelBuilder.Entity<LogPrepack>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("log_prepack");

                entity.HasIndex(e => e.Logid)
                    .HasName("logid_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("prepacklog_idx");

                entity.Property(e => e.Logid)
                    .HasColumnName("logid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateA).HasMaxLength(45);

                entity.Property(e => e.PpBinrack)
                    .HasColumnName("PP_Binrack")
                    .HasMaxLength(45);

                entity.Property(e => e.PpLabel)
                    .HasColumnName("PP_Label")
                    .HasMaxLength(45);

                entity.Property(e => e.PpQuantity)
                    .HasColumnName("PP_Quantity")
                    .HasMaxLength(45);

                entity.Property(e => e.PpShorttitle)
                    .HasColumnName("PP_Shorttitle")
                    .HasMaxLength(300);

                entity.Property(e => e.PpSku)
                    .HasColumnName("PP_Sku")
                    .HasMaxLength(45);

                entity.Property(e => e.Time).HasMaxLength(45);

                entity.Property(e => e.UserFullName).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.WorkstationName).HasMaxLength(45);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogPrepack)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("prepacklog");
            });

            modelBuilder.Entity<Machines>(entity =>
            {
                entity.HasKey(e => e.IdMachines);

                entity.ToTable("machines");

                entity.Property(e => e.IdMachines)
                    .HasColumnName("idMachines")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(45);

                entity.Property(e => e.MachineName).HasMaxLength(45);

                entity.Property(e => e.MachineType).HasMaxLength(45);

                entity.Property(e => e.Site).HasMaxLength(45);
            });

            modelBuilder.Entity<MessengerMessages>(entity =>
            {
                entity.HasKey(e => e.Messageid);

                entity.ToTable("messenger_messages");

                entity.Property(e => e.Messageid)
                    .HasColumnName("messageid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Messagecontent)
                    .HasColumnName("messagecontent")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Participantid)
                    .HasColumnName("participantid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Threadid)
                    .HasColumnName("threadid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MessengerThreads>(entity =>
            {
                entity.HasKey(e => e.IdmessengerThreads);

                entity.ToTable("messenger_threads");

                entity.Property(e => e.IdmessengerThreads)
                    .HasColumnName("idmessenger_threads")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Notified)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Participantid)
                    .HasColumnName("participantid")
                    .HasMaxLength(45);

                entity.Property(e => e.ThreadId)
                    .HasColumnName("ThreadID")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Newamazonlistings>(entity =>
            {
                entity.HasKey(e => e.IdnewAmazonListings);

                entity.ToTable("newamazonlistings");

                entity.Property(e => e.IdnewAmazonListings)
                    .HasColumnName("idnewAmazonListings")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChannelTitle)
                    .HasColumnName("channelTitle")
                    .HasColumnType("varchar(9000)");

                entity.Property(e => e.LinnworksSku).HasMaxLength(45);
            });

            modelBuilder.Entity<NewsalesDailysourcetotals>(entity =>
            {
                entity.HasKey(e => e.TotalId);

                entity.ToTable("newsales_dailysourcetotals");

                entity.Property(e => e.TotalId)
                    .HasColumnName("totalID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SubsourceText)
                    .HasColumnName("subsourceText")
                    .HasMaxLength(45);

                entity.Property(e => e.Tlsource)
                    .HasColumnName("TLSource")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("DEFAULT");

                entity.Property(e => e.TotalDate)
                    .HasColumnName("totalDate")
                    .HasMaxLength(45);

                entity.Property(e => e.TotalDayOfWeek)
                    .HasColumnName("totalDayOfWeek")
                    .HasMaxLength(45);

                entity.Property(e => e.TotalValue)
                    .HasColumnName("totalValue")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewsalesFinancials>(entity =>
            {
                entity.HasKey(e => e.FinancialId);

                entity.ToTable("newsales_financials");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.FinancialId)
                    .HasColumnName("financialID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CombinedPost)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CostEnvelope).HasColumnName("Cost_Envelope");

                entity.Property(e => e.CostFees).HasColumnName("Cost_Fees");

                entity.Property(e => e.CostLabel).HasColumnName("Cost_Label");

                entity.Property(e => e.CostLabour).HasColumnName("Cost_Labour");

                entity.Property(e => e.CostNet).HasColumnName("Cost_Net");

                entity.Property(e => e.CostPostage).HasColumnName("Cost_Postage");

                entity.Property(e => e.CostSurcharge).HasColumnName("Cost_Surcharge");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("OrderID")
                    .HasMaxLength(45);

                entity.Property(e => e.OrderWeight).HasColumnType("int(11)");

                entity.Property(e => e.PickType).HasMaxLength(45);

                entity.Property(e => e.PostClass).HasColumnType("int(2)");

                entity.Property(e => e.PostagePaid).HasDefaultValueSql("0");

                entity.Property(e => e.PostageType).HasMaxLength(45);

                entity.Property(e => e.PostageTypeDecision).HasMaxLength(45);

                entity.Property(e => e.Source).HasMaxLength(45);

                entity.Property(e => e.SubSource).HasMaxLength(45);

                entity.Property(e => e.TotalProfit).HasColumnName("Total_Profit");
                entity.Property(e => e.OrderDate).ForMySQLHasColumnType("date");
            });

            modelBuilder.Entity<NewsalesItems>(entity =>
            {
                entity.HasKey(e => e.Itemfinancial);

                entity.ToTable("newsales_items");

                entity.Property(e => e.Itemfinancial)
                    .HasColumnName("itemfinancial")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(15);

                entity.Property(e => e.PickType).HasMaxLength(45);

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Sku).HasMaxLength(15);

                entity.Property(e => e.OrderDate).ForMySQLHasColumnType("date");
            });

            modelBuilder.Entity<NewsalesRaw>(entity =>
            {
                entity.HasKey(e => e.SaleId);

                entity.ToTable("newsales_raw");

                entity.Property(e => e.SaleId)
                    .HasColumnName("saleId")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChannelTitle)
                    .HasColumnName("channelTitle")
                    .HasMaxLength(300);

                entity.Property(e => e.CustomLabel).HasMaxLength(45);

                entity.Property(e => e.IsMixedOrder)
                    .HasColumnName("isMixedOrder")
                    .HasMaxLength(5);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("orderDate")
                    .HasMaxLength(45);

                entity.Property(e => e.OrderDateTime).HasMaxLength(45);

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("orderId")
                    .HasMaxLength(45);

                entity.Property(e => e.PostagePaid)
                    .HasColumnName("postagePaid")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.SalePrice)
                    .HasColumnName("salePrice")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.SaleQuantity)
                    .HasColumnName("saleQuantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(11);

                entity.Property(e => e.Subsource)
                    .HasColumnName("subsource")
                    .HasMaxLength(45);

                entity.Property(e => e.Tlsource)
                    .HasColumnName("TLSource")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("DEFAULT");
            });

            modelBuilder.Entity<OrderwiseData>(entity =>
            {
                entity.HasKey(e => new { e.Sku, e.OwPacknote });

                entity.ToTable("orderwise_data");

                entity.HasIndex(e => e.Sku)
                    .HasName("SKU_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(11);

                entity.Property(e => e.OwPacknote)
                    .HasColumnName("ow_packnote")
                    .HasMaxLength(1000);

                entity.Property(e => e.AlternativeVariantCode)
                    .HasColumnName("alternative_variant_code")
                    .HasMaxLength(45);

                entity.Property(e => e.AmazonId)
                    .HasColumnName("amazon_id")
                    .HasMaxLength(45);

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(45);

                entity.Property(e => e.CategoryPath)
                    .HasColumnName("category_path")
                    .HasMaxLength(500);

                entity.Property(e => e.DefaultStockBinNumber)
                    .HasColumnName("default_stock_bin_number")
                    .HasMaxLength(45);

                entity.Property(e => e.EanCode)
                    .HasColumnName("ean_code")
                    .HasMaxLength(45);

                entity.Property(e => e.EstimatedCost)
                    .HasColumnName("estimated_cost")
                    .HasMaxLength(45);

                entity.Property(e => e.Guideprice)
                    .HasColumnName("guideprice")
                    .HasMaxLength(45);

                entity.Property(e => e.ItemTitle)
                    .HasColumnName("item_title")
                    .HasMaxLength(60);

                entity.Property(e => e.ItemtitlePackof)
                    .HasColumnName("itemtitle_packof")
                    .HasMaxLength(100);

                entity.Property(e => e.MainCategory)
                    .HasColumnName("main_category")
                    .HasMaxLength(45);

                entity.Property(e => e.NumberOfBaseUnits)
                    .HasColumnName("number_of_base_units")
                    .HasMaxLength(45);

                entity.Property(e => e.Ourean)
                    .HasColumnName("ourean")
                    .HasMaxLength(20);

                entity.Property(e => e.OwDeliverynote)
                    .HasColumnName("ow_deliverynote")
                    .HasMaxLength(1000);

                entity.Property(e => e.OwEnvelope)
                    .HasColumnName("ow_envelope")
                    .HasMaxLength(45);

                entity.Property(e => e.OwIsPrepack)
                    .IsRequired()
                    .HasColumnName("OW_IsPrepack")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.OwIsprepackfinalfinal)
                    .IsRequired()
                    .HasColumnName("ow_isprepackfinalfinal")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("True");

                entity.Property(e => e.OwItemexpires)
                    .HasColumnName("ow_itemexpires")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("FALSE");

                entity.Property(e => e.OwPackdescription)
                    .HasColumnName("ow_packdescription")
                    .HasMaxLength(100);

                entity.Property(e => e.OwPackingtype)
                    .HasColumnName("ow_packingtype")
                    .HasMaxLength(45);

                entity.Property(e => e.OwPackof)
                    .HasColumnName("ow_packof")
                    .HasMaxLength(45);

                entity.Property(e => e.OwPicknote)
                    .HasColumnName("ow_picknote")
                    .HasMaxLength(1000);

                entity.Property(e => e.OwPostaltype)
                    .HasColumnName("ow_postaltype")
                    .HasMaxLength(45);

                entity.Property(e => e.OwPrepacknote)
                    .HasColumnName("ow_prepacknote")
                    .HasMaxLength(1000);

                entity.Property(e => e.OwPurchaseVariant)
                    .HasColumnName("ow_purchase_variant")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.OwReqexpiry)
                    .HasColumnName("ow_reqexpiry")
                    .HasMaxLength(5);

                entity.Property(e => e.OwTraining)
                    .IsRequired()
                    .HasColumnName("ow_training")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("FALSE");

                entity.Property(e => e.OwWeight)
                    .HasColumnName("ow_weight")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StockLocation)
                    .HasColumnName("stock_location")
                    .HasMaxLength(45);

                entity.Property(e => e.Sys2IsPrepack)
                    .HasColumnName("sys2_IsPrepack")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<Oversoldorders>(entity =>
            {
                entity.ToTable("oversoldorders");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AwaitingStock).HasMaxLength(45);

                entity.Property(e => e.CompletedState).HasMaxLength(45);

                entity.Property(e => e.DateOfOversold).HasMaxLength(45);

                entity.Property(e => e.ExtraInfo)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("Enter extra info here");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(45);

                entity.Property(e => e.OversoldSku).HasMaxLength(45);
            });

            modelBuilder.Entity<Postagecosts>(entity =>
            {
                entity.ToTable("postagecosts");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasMaxLength(45);

                entity.Property(e => e.Type).HasMaxLength(45);

                entity.Property(e => e.Weight).HasColumnType("int(11)");
            });

            modelBuilder.Entity<PostagePrices>(entity =>
            {
                entity.ToTable("postage_prices");

                entity.HasIndex(e => e.Id)
                    .HasName("ID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Class).HasColumnType("int(1)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Weight).HasColumnType("int(11)");
            });

            modelBuilder.Entity<PrepackCleared>(entity =>
            {
                entity.HasKey(e => e.Orderid);

                entity.ToTable("prepack_cleared");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(45);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.UserCleared).HasMaxLength(45);
            });

            modelBuilder.Entity<Prepacklist>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("prepacklist");

                entity.HasIndex(e => e.Sku)
                    .HasName("Sku_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Sku)
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bag).HasColumnType("text");

                entity.Property(e => e.Notes).HasColumnType("text");
            });

            modelBuilder.Entity<PrepackTest>(entity =>
            {
                entity.HasKey(e => e.Orderid);

                entity.ToTable("prepack_test");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCleared).HasMaxLength(50);

                entity.Property(e => e.Iscomplete)
                    .HasColumnName("iscomplete")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Pplocationid)
                    .HasColumnName("pplocationid")
                    .HasMaxLength(45);

                entity.Property(e => e.Pplocationname)
                    .HasColumnName("pplocationname")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<PrepackType>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("prepack_type");

                entity.Property(e => e.Sku)
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).HasMaxLength(45);
            });

            modelBuilder.Entity<Processed>(entity =>
            {
                entity.HasKey(e => e.Orderkey);

                entity.ToTable("processed");

                entity.HasIndex(e => e.Orderkey)
                    .HasName("DbID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Orderkey)
                    .HasColumnName("orderkey")
                    .HasMaxLength(250)
                    .ValueGeneratedNever();

                entity.Property(e => e.BillCustAddr1).HasMaxLength(300);

                entity.Property(e => e.BillCustAddr2).HasMaxLength(100);

                entity.Property(e => e.BillCustAddr3).HasMaxLength(100);

                entity.Property(e => e.BillCustCompany).HasMaxLength(45);

                entity.Property(e => e.BillCustCountry).HasMaxLength(45);

                entity.Property(e => e.BillCustName).HasMaxLength(100);

                entity.Property(e => e.BillCustPhone).HasMaxLength(45);

                entity.Property(e => e.BillCustPostcode).HasMaxLength(45);

                entity.Property(e => e.BillCustRegion).HasMaxLength(100);

                entity.Property(e => e.BillCustTown).HasMaxLength(100);

                entity.Property(e => e.CompParentOrderItemNo).HasMaxLength(45);

                entity.Property(e => e.CompParentSku)
                    .HasColumnName("CompParentSKU")
                    .HasMaxLength(45);

                entity.Property(e => e.Currency).HasMaxLength(5);

                entity.Property(e => e.CustChannelBuyerName).HasMaxLength(60);

                entity.Property(e => e.CustCompany).HasMaxLength(45);

                entity.Property(e => e.CustEmail).HasMaxLength(100);

                entity.Property(e => e.CustPhone).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasMaxLength(45);

                entity.Property(e => e.DateDispatchby).HasMaxLength(45);

                entity.Property(e => e.DateProcessed).HasMaxLength(45);

                entity.Property(e => e.DateRecieved).HasMaxLength(45);

                entity.Property(e => e.ExternalReference).HasMaxLength(45);

                entity.Property(e => e.Hasemailed)
                    .HasColumnName("hasemailed")
                    .HasMaxLength(45);

                entity.Property(e => e.Marker).HasMaxLength(45);

                entity.Property(e => e.OrderChannelSku)
                    .HasColumnName("OrderChannelSKU")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderFullfillmentLocation).HasMaxLength(45);

                entity.Property(e => e.OrderIsService).HasMaxLength(45);

                entity.Property(e => e.OrderItemNumber).HasMaxLength(45);

                entity.Property(e => e.OrderLineDiscount)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderLineTax)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderLineTotal)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderLineTotalNoTax)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderOnHold).HasMaxLength(45);

                entity.Property(e => e.OrderOrigTitle).HasMaxLength(460);

                entity.Property(e => e.OrderPaidStat).HasMaxLength(10);

                entity.Property(e => e.OrderPaymentMethod).HasMaxLength(45);

                entity.Property(e => e.OrderQuantity)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderSku)
                    .HasColumnName("OrderSKU")
                    .HasMaxLength(45);

                entity.Property(e => e.OrderSource).HasMaxLength(45);

                entity.Property(e => e.OrderStatus).HasMaxLength(10);

                entity.Property(e => e.OrderSubSrc).HasMaxLength(45);

                entity.Property(e => e.OrderTax).HasDefaultValueSql("0");

                entity.Property(e => e.OrderTaxRate)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderTitle).HasMaxLength(200);

                entity.Property(e => e.OrderTotal).HasDefaultValueSql("0");

                entity.Property(e => e.OrderUnitCost)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(200);

                entity.Property(e => e.ReferenceNumber).HasMaxLength(45);

                entity.Property(e => e.SecReference).HasMaxLength(45);

                entity.Property(e => e.ShipCost).HasDefaultValueSql("0");

                entity.Property(e => e.ShipCustAddr1).HasMaxLength(300);

                entity.Property(e => e.ShipCustAddr2).HasMaxLength(300);

                entity.Property(e => e.ShipCustAddr3).HasMaxLength(100);

                entity.Property(e => e.ShipCustCountry).HasMaxLength(45);

                entity.Property(e => e.ShipCustCountryCode).HasMaxLength(4);

                entity.Property(e => e.ShipCustName).HasMaxLength(300);

                entity.Property(e => e.ShipCustPostcode).HasMaxLength(45);

                entity.Property(e => e.ShipCustRegion).HasMaxLength(100);

                entity.Property(e => e.ShipCustTown).HasMaxLength(100);

                entity.Property(e => e.ShipPackingGroup).HasMaxLength(45);

                entity.Property(e => e.ShipServiceCode).HasMaxLength(45);

                entity.Property(e => e.ShipServiceName).HasMaxLength(45);

                entity.Property(e => e.ShipServiceTag).HasMaxLength(45);

                entity.Property(e => e.ShipServiceVendor).HasMaxLength(45);

                entity.Property(e => e.ShipTrackingNumber).HasMaxLength(45);
            });

            modelBuilder.Entity<ReorderOrderitems>(entity =>
            {
                entity.HasKey(e => e.IdreorderOrderitems);

                entity.ToTable("reorder_orderitems");

                entity.Property(e => e.IdreorderOrderitems)
                    .HasColumnName("idreorder_orderitems")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmountOrdered).HasColumnType("int(10)");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(15,2)");

                entity.Property(e => e.OrderGuid)
                    .HasColumnName("OrderGUID")
                    .HasMaxLength(100);

                entity.Property(e => e.Shortsku).HasMaxLength(45);
            });

            modelBuilder.Entity<ReorderOrders>(entity =>
            {
                entity.ToTable("reorder_orders");

                entity.Property(e => e.ReorderOrdersId)
                    .HasColumnName("Reorder_OrdersId")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomDeliveryNote).HasMaxLength(500);

                entity.Property(e => e.CustomOrderId).HasMaxLength(45);

                entity.Property(e => e.CustomOrderNote).HasMaxLength(500);

                entity.Property(e => e.LinesOfStock).HasColumnType("int(11)");

                entity.Property(e => e.NetValue).HasColumnType("decimal(19,2)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDelivered).HasColumnType("datetime");

                entity.Property(e => e.OrderGuid)
                    .HasColumnName("OrderGUID")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderInvoiced).HasColumnType("datetime");

                entity.Property(e => e.OrderState)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SupplierCode).HasMaxLength(45);
            });

            modelBuilder.Entity<ReorderSupplierdata>(entity =>
            {
                entity.HasKey(e => e.IdreorderSupplierdata);

                entity.ToTable("reorder_supplierdata");

                entity.Property(e => e.IdreorderSupplierdata)
                    .HasColumnName("idreorder_supplierdata")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CartonDiscount)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastOrder).HasColumnType("datetime");

                entity.Property(e => e.LastOrderGuid).HasMaxLength(40);

                entity.Property(e => e.LeadDays)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.MinimumOrder).HasDefaultValueSql("0");

                entity.Property(e => e.ReorderPercentage).HasDefaultValueSql("15");

                entity.Property(e => e.SupplierCode)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.SupplierFullName)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Salesdata>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("salesdata");

                entity.HasIndex(e => e.Sku)
                    .HasName("Sku_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Sku)
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.Avg1Week).HasColumnType("int(11)");

                entity.Property(e => e.Avg4Week).HasColumnType("int(11)");

                entity.Property(e => e.Avg8Week).HasColumnType("int(11)");

                entity.Property(e => e.Raw1WeekTotal).HasColumnType("int(11)");

                entity.Property(e => e.Raw4WeekTotal).HasColumnType("int(11)");

                entity.Property(e => e.Raw8WeekTotal).HasColumnType("int(11)");

                entity.Property(e => e.ShortSku).HasMaxLength(45);

                entity.Property(e => e.Weighted8Week).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SalesdataWeirddays>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("salesdata_weirddays");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(15)
                    .ValueGeneratedNever();

                entity.Property(e => e.Weird)
                    .HasColumnName("weird")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<ShortskuLocations>(entity =>
            {
                entity.ToTable("shortsku_locations");

                entity.HasIndex(e => e.Id)
                    .HasName("id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(19)
                    .ValueGeneratedNever();

                entity.Property(e => e.LocationId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Shelfname).HasMaxLength(45);

                entity.Property(e => e.Shortsku).HasMaxLength(7);
            });

            modelBuilder.Entity<SkuCategories>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("sku_categories");

                entity.Property(e => e.CatId)
                    .HasColumnName("CatID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmazonNode).HasMaxLength(45);

                entity.Property(e => e.CategoryName).HasMaxLength(200);
            });

            modelBuilder.Entity<SkuChangelog>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("sku_changelog");

                entity.Property(e => e.Logid)
                    .HasColumnName("logid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datetimechanged)
                    .HasColumnName("datetimechanged")
                    .HasMaxLength(45);

                entity.Property(e => e.PayrollId)
                    .HasColumnName("payrollId")
                    .HasMaxLength(45);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(2000);

                entity.Property(e => e.Shortsku)
                    .HasColumnName("shortsku")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<SkuComposition>(entity =>
            {
                entity.HasKey(e => e.CompositionId);

                entity.ToTable("sku_composition");

                entity.Property(e => e.CompositionId)
                    .HasColumnName("compositionId")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BundleSku)
                    .IsRequired()
                    .HasColumnName("bundleSku")
                    .HasMaxLength(45);

                entity.Property(e => e.ChildSku)
                    .HasColumnName("childSku")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<SkuDates>(entity =>
            {
                entity.HasKey(e => e.ShortSku);

                entity.ToTable("sku_dates");

                entity.HasIndex(e => e.ShortSku)
                    .HasName("ShortSku_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ShortSku)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddedToLinnworks).HasMaxLength(45);

                entity.Property(e => e.FirstListed).HasMaxLength(45);

                entity.Property(e => e.FirstPhoto).HasMaxLength(45);

                entity.Property(e => e.FirstPriced).HasMaxLength(45);

                entity.Property(e => e.FirstRecorded).HasMaxLength(45);
            });

            modelBuilder.Entity<SkuImages>(entity =>
            {
                entity.HasKey(e => e.Filename);

                entity.ToTable("sku_images");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(256)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsPrimary)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(256);

                entity.Property(e => e.Shortsku)
                    .HasColumnName("shortsku")
                    .HasMaxLength(45);

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<SkuLocations>(entity =>
            {
                entity.ToTable("sku_locations");

                entity.HasIndex(e => e.LocationRefId)
                    .HasName("LoctionREference_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(45)
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalInfo)
                    .HasColumnName("additionalInfo")
                    .HasColumnType("int(15)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocationRefId)
                    .HasColumnName("LocationRefID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShelfName)
                    .HasColumnName("shelfName")
                    .HasMaxLength(45);

                entity.Property(e => e.Sku).HasMaxLength(45);

                entity.HasOne(d => d.LocationRef)
                    .WithMany(p => p.SkuLocations)
                    .HasForeignKey(d => d.LocationRefId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LocRefKey");
            });

            modelBuilder.Entity<SkuSupplierdata>(entity =>
            {
                entity.HasKey(e => new { e.SkuSuppKey, e.SupplierCaseBarcode });

                entity.ToTable("sku_supplierdata");

                entity.HasIndex(e => e.SkuSuppKey)
                    .HasName("SkuSuppKey_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.SkuSuppKey).HasMaxLength(45);

                entity.Property(e => e.SupplierCaseBarcode)
                    .HasMaxLength(45)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.DateModified)
                    .HasMaxLength(45)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.Invisible)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.IsDiscontinued)
                    .HasColumnName("isDiscontinued")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.IsOutOfStock)
                    .HasColumnName("isOutOfStock")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.IsPrimary)
                    .HasColumnName("isPrimary")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.LeadTimeNew)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LeadTimeWeeks)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("4");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(45);

                entity.Property(e => e.SupplierBarcode)
                    .HasMaxLength(45)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.SupplierBoxCode)
                    .HasMaxLength(45)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.SupplierCaseInnerBarcode)
                    .HasMaxLength(45)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.SupplierCaseQuantity)
                    .HasMaxLength(45)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.SupplierPricePer)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<SkuWebsaleinfo>(entity =>
            {
                entity.ToTable("sku_websaleinfo");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedUser).HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasMaxLength(40);

                entity.Property(e => e.ListingTitle).HasMaxLength(300);

                entity.Property(e => e.Sku).HasMaxLength(11);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<StockHistory>(entity =>
            {
                entity.HasKey(e => e.StohistId);

                entity.ToTable("stock_history");

                entity.Property(e => e.StohistId)
                    .HasColumnName("stohistID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnvelopeCost).HasDefaultValueSql("-1");

                entity.Property(e => e.LabourCost).HasDefaultValueSql("-1");

                entity.Property(e => e.NetPrice).HasDefaultValueSql("-1");

                entity.Property(e => e.PostageCost).HasDefaultValueSql("-1");

                entity.Property(e => e.ShortSku)
                    .IsRequired()
                    .HasColumnName("shortSku")
                    .HasMaxLength(15);

                entity.Property(e => e.StockDate)
                    .IsRequired()
                    .HasColumnName("stockDate")
                    .HasMaxLength(20);

                entity.Property(e => e.StockLevel)
                    .HasColumnName("stockLevel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StockMinimum)
                    .HasColumnName("stockMinimum")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.Suppid);

                entity.ToTable("suppliers");

                entity.Property(e => e.Suppid)
                    .HasColumnName("suppid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasMaxLength(45);

                entity.Property(e => e.RealName).HasMaxLength(45);

                entity.Property(e => e.SageSupp).HasMaxLength(45);

                entity.Property(e => e.Suppname)
                    .HasColumnName("suppname")
                    .HasMaxLength(45);

                entity.Property(e => e.WebSearchQuery).HasMaxLength(200);

                entity.Property(e => e.Website).HasMaxLength(45);
            });

            modelBuilder.Entity<UserNotifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.ToTable("user_notifications");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("notificationId")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NotExpiryDateTime)
                    .HasColumnName("notExpiryDateTime")
                    .HasMaxLength(45);

                entity.Property(e => e.NotImgLink)
                    .HasColumnName("notImgLink")
                    .HasMaxLength(150);

                entity.Property(e => e.NotIsRead)
                    .HasColumnName("notIsRead")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("True");

                entity.Property(e => e.NotificationBody)
                    .HasColumnName("notificationBody")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.NotificationStyle)
                    .HasColumnName("notificationStyle")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("Message");

                entity.Property(e => e.NotificationTitle)
                    .HasColumnName("notificationTitle")
                    .HasMaxLength(100);

                entity.Property(e => e.PayrollId)
                    .HasColumnName("payrollId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserFromId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<VncClients>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.ToTable("vnc_clients");

                entity.Property(e => e.ClientId)
                    .HasColumnName("clientID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientHostname)
                    .HasColumnName("clientHostname")
                    .HasMaxLength(45);

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupId")
                    .HasMaxLength(45);

                entity.Property(e => e.GroupName)
                    .HasColumnName("groupName")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<WarehouseIssueLog>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("warehouse_issue_log");

                entity.Property(e => e.IssueId)
                    .HasColumnName("issueID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateReported).HasMaxLength(45);

                entity.Property(e => e.IssueReason).HasMaxLength(45);

                entity.Property(e => e.IssueType).HasMaxLength(15);

                entity.Property(e => e.OrderType).HasMaxLength(45);

                entity.Property(e => e.ReportingUser).HasColumnType("int(4)");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<WarehousePcReference>(entity =>
            {
                entity.HasKey(e => e.Pcid);

                entity.ToTable("warehouse_pc_reference");

                entity.Property(e => e.Pcid)
                    .HasColumnName("pcid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MachineName).HasMaxLength(45);

                entity.Property(e => e.WarehouseId)
                    .HasColumnName("WarehouseID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WarehouseNumber).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Warehousereference>(entity =>
            {
                entity.HasKey(e => e.WarehouseId);

                entity.ToTable("warehousereference");

                entity.Property(e => e.WarehouseId)
                    .HasColumnName("WarehouseID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.WarehouseName).HasMaxLength(45);

                entity.Property(e => e.WarehouseReferencecol).HasMaxLength(45);
            });

            modelBuilder.Entity<Whlnew>(entity =>
            {
                entity.HasKey(e => e.Sku);

                entity.ToTable("whlnew");

                entity.HasIndex(e => e.Sku)
                    .HasName("sku_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.A1wk)
                    .HasColumnName("a1wk")
                    .HasMaxLength(45);

                entity.Property(e => e.A4wk)
                    .HasColumnName("a4wk")
                    .HasMaxLength(45);

                entity.Property(e => e.A8wk)
                    .HasColumnName("a8wk")
                    .HasMaxLength(45);

                entity.Property(e => e.Aavg)
                    .HasColumnName("aavg")
                    .HasMaxLength(45);

                entity.Property(e => e.Alist)
                    .HasColumnName("alist")
                    .HasMaxLength(10);

                entity.Property(e => e.Allocatebarcode)
                    .HasColumnName("allocatebarcode")
                    .HasMaxLength(45);

                entity.Property(e => e.AltSuppNet).HasMaxLength(45);

                entity.Property(e => e.Altsuppbarcode)
                    .HasColumnName("altsuppbarcode")
                    .HasMaxLength(45);

                entity.Property(e => e.Altsuppcase)
                    .HasColumnName("altsuppcase")
                    .HasMaxLength(45);

                entity.Property(e => e.Altsuppcode)
                    .HasColumnName("altsuppcode")
                    .HasMaxLength(45);

                entity.Property(e => e.Altsuppname)
                    .HasColumnName("altsuppname")
                    .HasMaxLength(45);

                entity.Property(e => e.AmznCategoryId)
                    .HasColumnName("AmznCategoryID")
                    .HasMaxLength(45);

                entity.Property(e => e.Astatus)
                    .HasColumnName("astatus")
                    .HasMaxLength(45);

                entity.Property(e => e.Avp2)
                    .HasColumnName("avp2")
                    .HasMaxLength(45);

                entity.Property(e => e.Avp3)
                    .HasColumnName("avp3")
                    .HasMaxLength(45);

                entity.Property(e => e.Avp4)
                    .HasColumnName("avp4")
                    .HasMaxLength(45);

                entity.Property(e => e.Avp5)
                    .HasColumnName("avp5")
                    .HasMaxLength(45);

                entity.Property(e => e.Binrack)
                    .HasColumnName("binrack")
                    .HasMaxLength(45);

                entity.Property(e => e.BundlePacks).HasMaxLength(150);

                entity.Property(e => e.Courier)
                    .HasColumnName("courier")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasMaxLength(45);

                entity.Property(e => e.Deliverynote)
                    .HasColumnName("deliverynote")
                    .HasMaxLength(1000);

                entity.Property(e => e.Dormant)
                    .HasColumnName("dormant")
                    .HasMaxLength(45);

                entity.Property(e => e.EbayDesc).HasColumnName("Ebay_Desc");

                entity.Property(e => e.Ebaytitle1)
                    .HasColumnName("ebaytitle1")
                    .HasMaxLength(200);

                entity.Property(e => e.Ebaytitle2)
                    .HasColumnName("ebaytitle2")
                    .HasMaxLength(200);

                entity.Property(e => e.Ebaytitle3)
                    .HasColumnName("ebaytitle3")
                    .HasMaxLength(200);

                entity.Property(e => e.Envcost)
                    .HasColumnName("envcost")
                    .HasMaxLength(45);

                entity.Property(e => e.Envelope)
                    .HasColumnName("envelope")
                    .HasMaxLength(45);

                entity.Property(e => e.Ext30)
                    .HasColumnName("ext30")
                    .HasMaxLength(45);

                entity.Property(e => e.Ext33)
                    .HasColumnName("ext33")
                    .HasMaxLength(45);

                entity.Property(e => e.Ext35)
                    .HasColumnName("ext35")
                    .HasMaxLength(100);

                entity.Property(e => e.Ext37)
                    .HasColumnName("ext37")
                    .HasMaxLength(45);

                entity.Property(e => e.Ext38)
                    .HasColumnName("ext38")
                    .HasMaxLength(45);

                entity.Property(e => e.Feescost)
                    .HasColumnName("feescost")
                    .HasMaxLength(45);

                entity.Property(e => e.FullyDiscontinued)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gross).HasColumnName("gross");

                entity.Property(e => e.Gs1)
                    .HasColumnName("gs1")
                    .HasMaxLength(45);

                entity.Property(e => e.HasBeenListed)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("True");

                entity.Property(e => e.Image1)
                    .HasColumnName("image1")
                    .HasMaxLength(300);

                entity.Property(e => e.Image2)
                    .HasColumnName("image2")
                    .HasMaxLength(300);

                entity.Property(e => e.Image3)
                    .HasColumnName("image3")
                    .HasMaxLength(300);

                entity.Property(e => e.InitMinimum).HasMaxLength(45);

                entity.Property(e => e.Initiallevel)
                    .HasColumnName("initiallevel")
                    .HasMaxLength(45);

                entity.Property(e => e.Initialquantity)
                    .HasColumnName("initialquantity")
                    .HasMaxLength(45);

                entity.Property(e => e.Initialvalue)
                    .HasColumnName("initialvalue")
                    .HasMaxLength(45);

                entity.Property(e => e.IsBundle)
                    .IsRequired()
                    .HasColumnName("isBundle")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.IsListed)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("True");

                entity.Property(e => e.IsPair).HasMaxLength(15);

                entity.Property(e => e.Itemtitle)
                    .HasColumnName("itemtitle")
                    .HasMaxLength(300);

                entity.Property(e => e.KnowledgeNote)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.Labelshort)
                    .HasColumnName("labelshort")
                    .HasMaxLength(200);

                entity.Property(e => e.Labour)
                    .HasColumnName("labour")
                    .HasMaxLength(4);

                entity.Property(e => e.Labourcost)
                    .HasColumnName("labourcost")
                    .HasMaxLength(45);

                entity.Property(e => e.Leadtime)
                    .HasColumnName("leadtime")
                    .HasMaxLength(45);

                entity.Property(e => e.Linnshort)
                    .HasColumnName("linnshort")
                    .HasMaxLength(200);

                entity.Property(e => e.ListPriority)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Margin)
                    .HasColumnName("margin")
                    .HasMaxLength(30);

                entity.Property(e => e.Min)
                    .HasColumnName("min")
                    .HasMaxLength(11);

                entity.Property(e => e.Minorder)
                    .HasColumnName("minorder")
                    .HasMaxLength(45);

                entity.Property(e => e.More10)
                    .HasColumnName("more10")
                    .HasMaxLength(45);

                entity.Property(e => e.More15)
                    .HasColumnName("more15")
                    .HasMaxLength(200);

                entity.Property(e => e.More16)
                    .HasColumnName("more16")
                    .HasMaxLength(45);

                entity.Property(e => e.More17)
                    .HasColumnName("more17")
                    .HasMaxLength(45);

                entity.Property(e => e.Mpn)
                    .HasColumnName("mpn")
                    .HasMaxLength(200);

                entity.Property(e => e.Mpn2)
                    .HasColumnName("mpn2")
                    .HasMaxLength(200);

                entity.Property(e => e.Net).HasColumnName("net");

                entity.Property(e => e.NewBrand)
                    .HasColumnName("New_Brand")
                    .HasMaxLength(45);

                entity.Property(e => e.NewCode)
                    .HasColumnName("New_Code")
                    .HasMaxLength(45);

                entity.Property(e => e.NewDescription)
                    .HasColumnName("New_Description")
                    .HasMaxLength(100);

                entity.Property(e => e.NewFinish)
                    .HasColumnName("New_Finish")
                    .HasMaxLength(45);

                entity.Property(e => e.NewImages)
                    .HasColumnName("New_Images")
                    .HasMaxLength(45);

                entity.Property(e => e.NewInner)
                    .HasColumnName("New_Inner")
                    .HasMaxLength(45);

                entity.Property(e => e.NewNote)
                    .HasColumnName("New_Note")
                    .HasMaxLength(5000);

                entity.Property(e => e.NewPacksizes).HasMaxLength(100);

                entity.Property(e => e.NewRegistration).HasMaxLength(45);

                entity.Property(e => e.NewSize)
                    .HasColumnName("New_Size")
                    .HasMaxLength(45);

                entity.Property(e => e.NewStatus)
                    .HasColumnName("New_Status")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("Active");

                entity.Property(e => e.NewTransferBox)
                    .HasColumnName("New_TransferBox")
                    .HasMaxLength(45);

                entity.Property(e => e.NewWeight)
                    .HasColumnName("New_Weight")
                    .HasMaxLength(45);

                entity.Property(e => e.Oldprice)
                    .HasColumnName("oldprice")
                    .HasMaxLength(45);

                entity.Property(e => e.Oldsku)
                    .HasColumnName("oldsku")
                    .HasMaxLength(45);

                entity.Property(e => e.OversizedItem)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.OwTraining)
                    .HasColumnName("ow_training")
                    .HasMaxLength(45)
                    .HasDefaultValueSql("FALSE");

                entity.Property(e => e.Pack)
                    .HasColumnName("pack")
                    .HasMaxLength(45);

                entity.Property(e => e.PackNote)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.Packedbarcodes)
                    .HasColumnName("packedbarcodes")
                    .HasMaxLength(100);

                entity.Property(e => e.Packingcost)
                    .HasColumnName("packingcost")
                    .HasMaxLength(100);

                entity.Property(e => e.Packlinksku)
                    .HasColumnName("packlinksku")
                    .HasMaxLength(45);

                entity.Property(e => e.Packprice1)
                    .HasColumnName("packprice1")
                    .HasMaxLength(45);

                entity.Property(e => e.Packprice2)
                    .HasColumnName("packprice2")
                    .HasMaxLength(45);

                entity.Property(e => e.Packprice3)
                    .HasColumnName("packprice3")
                    .HasMaxLength(45);

                entity.Property(e => e.Packprice4)
                    .HasColumnName("packprice4")
                    .HasMaxLength(45);

                entity.Property(e => e.Packprice5)
                    .HasColumnName("packprice5")
                    .HasMaxLength(45);

                entity.Property(e => e.Packsize)
                    .HasColumnName("packsize")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Parts)
                    .HasColumnName("parts")
                    .HasMaxLength(45);

                entity.Property(e => e.Pc)
                    .HasColumnName("pc")
                    .HasMaxLength(45);

                entity.Property(e => e.PickNote)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql(" ");

                entity.Property(e => e.Pieces)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Postagecost)
                    .HasColumnName("postagecost")
                    .HasMaxLength(45);

                entity.Property(e => e.Pp1)
                    .HasColumnName("pp1")
                    .HasMaxLength(45);

                entity.Property(e => e.Pp2)
                    .HasColumnName("pp2")
                    .HasMaxLength(45);

                entity.Property(e => e.Pp3)
                    .HasColumnName("pp3")
                    .HasMaxLength(45);

                entity.Property(e => e.Pp4)
                    .HasColumnName("pp4")
                    .HasMaxLength(45);

                entity.Property(e => e.Pp5)
                    .HasColumnName("pp5")
                    .HasMaxLength(45);

                entity.Property(e => e.PpBag)
                    .HasColumnName("PP_Bag")
                    .HasMaxLength(45);

                entity.Property(e => e.Prepack)
                    .HasColumnName("prepack")
                    .HasMaxLength(45);

                entity.Property(e => e.PrimarySuppNet).HasMaxLength(45);

                entity.Property(e => e.Primarysuppbarcode)
                    .HasColumnName("primarysuppbarcode")
                    .HasMaxLength(45);

                entity.Property(e => e.Primarysuppcase)
                    .HasColumnName("primarysuppcase")
                    .HasMaxLength(45);

                entity.Property(e => e.Primarysuppcode)
                    .HasColumnName("primarysuppcode")
                    .HasMaxLength(200);

                entity.Property(e => e.Primarysuppname)
                    .HasColumnName("primarysuppname")
                    .HasMaxLength(45);

                entity.Property(e => e.Profit)
                    .HasColumnName("profit")
                    .HasMaxLength(30);

                entity.Property(e => e.Retail).HasColumnName("retail");

                entity.Property(e => e.Screws)
                    .HasColumnName("screws")
                    .HasMaxLength(45);

                entity.Property(e => e.Short)
                    .HasColumnName("short")
                    .HasMaxLength(200);

                entity.Property(e => e.Short126)
                    .HasColumnName("short126")
                    .HasMaxLength(100);

                entity.Property(e => e.Shortsku)
                    .HasColumnName("shortsku")
                    .HasMaxLength(45);

                entity.Property(e => e.Shorttitle)
                    .HasColumnName("shorttitle")
                    .HasMaxLength(200);

                entity.Property(e => e.Singleprice)
                    .HasColumnName("singleprice")
                    .HasMaxLength(45);

                entity.Property(e => e.Slevel)
                    .HasColumnName("slevel")
                    .HasMaxLength(11);

                entity.Property(e => e.Soldavgprice)
                    .HasColumnName("soldavgprice")
                    .HasMaxLength(45);

                entity.Property(e => e.SplitBundle)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("False");

                entity.Property(e => e.Supp3Net).HasMaxLength(45);

                entity.Property(e => e.Supp3barcode)
                    .HasColumnName("supp3barcode")
                    .HasMaxLength(45);

                entity.Property(e => e.Supp3case)
                    .HasColumnName("supp3case")
                    .HasMaxLength(45);

                entity.Property(e => e.Supp3code)
                    .HasColumnName("supp3code")
                    .HasMaxLength(200);

                entity.Property(e => e.Supp3name)
                    .HasColumnName("supp3name")
                    .HasMaxLength(45);

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasMaxLength(11);

                entity.Property(e => e.Totalcost)
                    .HasColumnName("totalcost")
                    .HasMaxLength(45);

                entity.Property(e => e.Vatcost)
                    .HasColumnName("vatcost")
                    .HasMaxLength(45);

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Withscrews)
                    .HasColumnName("withscrews")
                    .HasMaxLength(45);
            });
        }
    }
}
