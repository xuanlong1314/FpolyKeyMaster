﻿// <auto-generated />
using System;
using KeyMaster_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KeyMaster_API.Migrations
{
    [DbContext(typeof(AppDBcontexts))]
    partial class AppDBcontextsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KeyMaster_Data.Models.DiaChi", b =>
                {
                    b.Property<Guid>("IdDiaChi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiCT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Huyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NguoiDungIDNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiNhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDiaChi");

                    b.HasIndex("NguoiDungIDNguoiDung");

                    b.ToTable("DiaChis");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.GioHang", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdGioHang");

                    b.HasIndex("IdNguoiDung");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.GioHangCT", b =>
                {
                    b.Property<Guid>("IdGioHangCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GioHangIdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPhamCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamCTIdSPChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdGioHangCT");

                    b.HasIndex("GioHangIdGioHang");

                    b.HasIndex("SanPhamCTIdSPChiTiet");

                    b.ToTable("GioHangCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.Hang", b =>
                {
                    b.Property<Guid>("IdHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHang");

                    b.ToTable("Hangs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.HinhAnh", b =>
                {
                    b.Property<Guid>("IdHinhAnh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHinhAnh");

                    b.ToTable("HinhAnhs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.HoaDon", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DiaChiIdDiaChi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IdDiaChi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhieuGiamGia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPhuongThucThanhToan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayGiaoHangDuKien")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayNhanHang")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayVanChuyen")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PhiVanChuyen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("PhieuGiamGiaIdPhieuGiamGia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhuongThucThanhToanIdPhuongThucThanhToan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("DiaChiIdDiaChi");

                    b.HasIndex("IdPhieuGiamGia");

                    b.HasIndex("PhieuGiamGiaIdPhieuGiamGia");

                    b.HasIndex("PhuongThucThanhToanIdPhuongThucThanhToan");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.HoaDonCT", b =>
                {
                    b.Property<Guid>("IdHoaDonCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPhamCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamCTIdSPChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdHoaDonCT");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("SanPhamCTIdSPChiTiet");

                    b.ToTable("HoaDonCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.KeyCap", b =>
                {
                    b.Property<Guid>("IdKeyCap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenKeyCap")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdKeyCap");

                    b.ToTable("KeyCaps");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.KhuyenMai", b =>
                {
                    b.Property<Guid>("IdKhuyenMai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("MucGiamGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("NgayBatDau")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayKetThuc")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKhuyenMai")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdKhuyenMai");

                    b.ToTable("KhuyenMais");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.KieuGiamGia", b =>
                {
                    b.Property<Guid>("IdKieuGiamGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTriGiamGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TenKieuGiamGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdKieuGiamGia");

                    b.ToTable("KieuGiamGias");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.Led", b =>
                {
                    b.Property<Guid>("IdLed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdLed");

                    b.ToTable("Leds");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.LichSuHoaDon", b =>
                {
                    b.Property<Guid>("IdLichSuHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayDatHang")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNhanHang")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdLichSuHoaDon");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("LichSuHoaDons");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.LoaiKN", b =>
                {
                    b.Property<Guid>("IdLoaiKN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLoaiKN")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdLoaiKN");

                    b.ToTable("LoaiKNs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.LoaiSP", b =>
                {
                    b.Property<Guid>("IdLoaiSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLoaiSP")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdLoaiSP");

                    b.ToTable("LoaiSPs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.Mau", b =>
                {
                    b.Property<Guid>("IdMau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenMau")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMau");

                    b.ToTable("Maus");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.NguoiDung", b =>
                {
                    b.Property<Guid>("IDNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IDVaiTro")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenNguoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDNguoiDung");

                    b.HasIndex("IDVaiTro");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.PhieuGiamGia", b =>
                {
                    b.Property<Guid>("IdPhieuGiamGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DieuKien")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("IdKieuGiamGia")
                        .HasMaxLength(50)
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("MucGiamGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenGiamGia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdPhieuGiamGia");

                    b.HasIndex("IdKieuGiamGia");

                    b.ToTable("PhieuGiamGias");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.PhuongThucThanhToan", b =>
                {
                    b.Property<Guid>("IdPhuongThucThanhToan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenPhuongThucThanhToan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdPhuongThucThanhToan");

                    b.ToTable("PhuongThucThanhToans");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.SanPham", b =>
                {
                    b.Property<Guid>("IdSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HinhAnhIdHinhAnh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHinhAnh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLoaiSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LoaiSPIdLoaiSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSanPham");

                    b.HasIndex("HinhAnhIdHinhAnh");

                    b.HasIndex("LoaiSPIdLoaiSP");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.SanPhamCT", b =>
                {
                    b.Property<Guid>("IdSPChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("HangIdHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKeycap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLed")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLoaiKN")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMau")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KeyCapIdKeyCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LedIdLed")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LoaiKNIdLoaiKN")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MauIdMau")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamIdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("ThongTinThem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSPChiTiet");

                    b.HasIndex("HangIdHang");

                    b.HasIndex("KeyCapIdKeyCap");

                    b.HasIndex("LedIdLed");

                    b.HasIndex("LoaiKNIdLoaiKN");

                    b.HasIndex("MauIdMau");

                    b.HasIndex("SanPhamIdSanPham");

                    b.ToTable("SanPhamCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.SanPhamKM", b =>
                {
                    b.Property<Guid>("IdSanPhamKM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhuyenMai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhuyenMaiIdKhuyenMai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamIdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdSanPhamKM");

                    b.HasIndex("KhuyenMaiIdKhuyenMai");

                    b.HasIndex("SanPhamIdSanPham");

                    b.ToTable("SanPhamKMs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.VaiTro", b =>
                {
                    b.Property<Guid>("IDVaiTro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDVaiTro");

                    b.ToTable("VaiTros");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.DiaChi", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.NguoiDung", "NguoiDung")
                        .WithMany()
                        .HasForeignKey("NguoiDungIDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.GioHang", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.NguoiDung", "NguoiDung")
                        .WithMany()
                        .HasForeignKey("IdNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.GioHangCT", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.GioHang", "GioHang")
                        .WithMany("GioHangCTs")
                        .HasForeignKey("GioHangIdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.SanPhamCT", "SanPhamCT")
                        .WithMany()
                        .HasForeignKey("SanPhamCTIdSPChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");

                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.HoaDon", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.DiaChi", "DiaChi")
                        .WithMany("HoaDons")
                        .HasForeignKey("DiaChiIdDiaChi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.NguoiDung", "NguoiDung")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdPhieuGiamGia");

                    b.HasOne("KeyMaster_Data.Models.PhieuGiamGia", "PhieuGiamGia")
                        .WithMany()
                        .HasForeignKey("PhieuGiamGiaIdPhieuGiamGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.PhuongThucThanhToan", "PhuongThucThanhToan")
                        .WithMany("HoaDons")
                        .HasForeignKey("PhuongThucThanhToanIdPhuongThucThanhToan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiaChi");

                    b.Navigation("NguoiDung");

                    b.Navigation("PhieuGiamGia");

                    b.Navigation("PhuongThucThanhToan");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.HoaDonCT", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.SanPhamCT", "SanPhamCT")
                        .WithMany()
                        .HasForeignKey("SanPhamCTIdSPChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.LichSuHoaDon", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.HoaDon", "HoaDon")
                        .WithMany("LichSuHoaDons")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.NguoiDung", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.VaiTro", "VaiTro")
                        .WithMany("NguoiDungs")
                        .HasForeignKey("IDVaiTro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.PhieuGiamGia", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.KieuGiamGia", "KieuGiamGia")
                        .WithMany("PhieuGiamGias")
                        .HasForeignKey("IdKieuGiamGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KieuGiamGia");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.SanPham", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.HinhAnh", "HinhAnh")
                        .WithMany("SanPhams")
                        .HasForeignKey("HinhAnhIdHinhAnh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.LoaiSP", "LoaiSP")
                        .WithMany("SanPhams")
                        .HasForeignKey("LoaiSPIdLoaiSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HinhAnh");

                    b.Navigation("LoaiSP");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.SanPhamCT", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.Hang", "Hang")
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("HangIdHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.KeyCap", "KeyCap")
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("KeyCapIdKeyCap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.Led", "Led")
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("LedIdLed")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.LoaiKN", "LoaiKN")
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("LoaiKNIdLoaiKN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.Mau", "Mau")
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("MauIdMau")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.SanPham", "SanPham")
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("SanPhamIdSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hang");

                    b.Navigation("KeyCap");

                    b.Navigation("Led");

                    b.Navigation("LoaiKN");

                    b.Navigation("Mau");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.SanPhamKM", b =>
                {
                    b.HasOne("KeyMaster_Data.Models.KhuyenMai", "KhuyenMai")
                        .WithMany("SanPhamKMs")
                        .HasForeignKey("KhuyenMaiIdKhuyenMai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeyMaster_Data.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamIdSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhuyenMai");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.DiaChi", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.GioHang", b =>
                {
                    b.Navigation("GioHangCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.Hang", b =>
                {
                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.HinhAnh", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonCTs");

                    b.Navigation("LichSuHoaDons");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.KeyCap", b =>
                {
                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.KhuyenMai", b =>
                {
                    b.Navigation("SanPhamKMs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.KieuGiamGia", b =>
                {
                    b.Navigation("PhieuGiamGias");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.Led", b =>
                {
                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.LoaiKN", b =>
                {
                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.LoaiSP", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.Mau", b =>
                {
                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.NguoiDung", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.PhuongThucThanhToan", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.SanPham", b =>
                {
                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("KeyMaster_Data.Models.VaiTro", b =>
                {
                    b.Navigation("NguoiDungs");
                });
#pragma warning restore 612, 618
        }
    }
}
