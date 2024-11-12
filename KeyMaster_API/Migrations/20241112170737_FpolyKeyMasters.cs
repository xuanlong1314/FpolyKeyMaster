using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KeyMaster_API.Migrations
{
    public partial class FpolyKeyMasters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hangs",
                columns: table => new
                {
                    IdHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hangs", x => x.IdHang);
                });

            migrationBuilder.CreateTable(
                name: "HinhAnhs",
                columns: table => new
                {
                    IdHinhAnh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhAnhs", x => x.IdHinhAnh);
                });

            migrationBuilder.CreateTable(
                name: "KeyCaps",
                columns: table => new
                {
                    IdKeyCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKeyCap = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyCaps", x => x.IdKeyCap);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMais",
                columns: table => new
                {
                    IdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKhuyenMai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MucGiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMais", x => x.IdKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "KieuGiamGias",
                columns: table => new
                {
                    IdKieuGiamGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKieuGiamGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaTriGiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuGiamGias", x => x.IdKieuGiamGia);
                });

            migrationBuilder.CreateTable(
                name: "Leds",
                columns: table => new
                {
                    IdLed = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leds", x => x.IdLed);
                });

            migrationBuilder.CreateTable(
                name: "LoaiKNs",
                columns: table => new
                {
                    IdLoaiKN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiKN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiKNs", x => x.IdLoaiKN);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSPs",
                columns: table => new
                {
                    IdLoaiSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSPs", x => x.IdLoaiSP);
                });

            migrationBuilder.CreateTable(
                name: "Maus",
                columns: table => new
                {
                    IdMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maus", x => x.IdMau);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToans",
                columns: table => new
                {
                    IdPhuongThucThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenPhuongThucThanhToan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToans", x => x.IdPhuongThucThanhToan);
                });

            migrationBuilder.CreateTable(
                name: "VaiTros",
                columns: table => new
                {
                    IDVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenVaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTros", x => x.IDVaiTro);
                });

            migrationBuilder.CreateTable(
                name: "PhieuGiamGias",
                columns: table => new
                {
                    IdPhieuGiamGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenGiamGia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MucGiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DieuKien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    IdKieuGiamGia = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuGiamGias", x => x.IdPhieuGiamGia);
                    table.ForeignKey(
                        name: "FK_PhieuGiamGias_KieuGiamGias_IdKieuGiamGia",
                        column: x => x.IdKieuGiamGia,
                        principalTable: "KieuGiamGias",
                        principalColumn: "IdKieuGiamGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdLoaiSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHinhAnh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiSPIdLoaiSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HinhAnhIdHinhAnh = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.IdSanPham);
                    table.ForeignKey(
                        name: "FK_SanPhams_HinhAnhs_HinhAnhIdHinhAnh",
                        column: x => x.HinhAnhIdHinhAnh,
                        principalTable: "HinhAnhs",
                        principalColumn: "IdHinhAnh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhams_LoaiSPs_LoaiSPIdLoaiSP",
                        column: x => x.LoaiSPIdLoaiSP,
                        principalTable: "LoaiSPs",
                        principalColumn: "IdLoaiSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    IDNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNguoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDVaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.IDNguoiDung);
                    table.ForeignKey(
                        name: "FK_NguoiDungs_VaiTros_IDVaiTro",
                        column: x => x.IDVaiTro,
                        principalTable: "VaiTros",
                        principalColumn: "IDVaiTro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamCTs",
                columns: table => new
                {
                    IdSPChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLed = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoaiKN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKeycap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ThongTinThem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanPhamIdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MauIdMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LedIdLed = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiKNIdLoaiKN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KeyCapIdKeyCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HangIdHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamCTs", x => x.IdSPChiTiet);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_Hangs_HangIdHang",
                        column: x => x.HangIdHang,
                        principalTable: "Hangs",
                        principalColumn: "IdHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_KeyCaps_KeyCapIdKeyCap",
                        column: x => x.KeyCapIdKeyCap,
                        principalTable: "KeyCaps",
                        principalColumn: "IdKeyCap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_Leds_LedIdLed",
                        column: x => x.LedIdLed,
                        principalTable: "Leds",
                        principalColumn: "IdLed",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_LoaiKNs_LoaiKNIdLoaiKN",
                        column: x => x.LoaiKNIdLoaiKN,
                        principalTable: "LoaiKNs",
                        principalColumn: "IdLoaiKN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_Maus_MauIdMau",
                        column: x => x.MauIdMau,
                        principalTable: "Maus",
                        principalColumn: "IdMau",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_SanPhams_SanPhamIdSanPham",
                        column: x => x.SanPhamIdSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "IdSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamKMs",
                columns: table => new
                {
                    IdSanPhamKM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamIdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhuyenMaiIdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamKMs", x => x.IdSanPhamKM);
                    table.ForeignKey(
                        name: "FK_SanPhamKMs_KhuyenMais_KhuyenMaiIdKhuyenMai",
                        column: x => x.KhuyenMaiIdKhuyenMai,
                        principalTable: "KhuyenMais",
                        principalColumn: "IdKhuyenMai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamKMs_SanPhams_SanPhamIdSanPham",
                        column: x => x.SanPhamIdSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "IdSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiaChis",
                columns: table => new
                {
                    IdDiaChi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaChiCT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NguoiDungIDNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChis", x => x.IdDiaChi);
                    table.ForeignKey(
                        name: "FK_DiaChis_NguoiDungs_NguoiDungIDNguoiDung",
                        column: x => x.NguoiDungIDNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "IDNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.IdGioHang);
                    table.ForeignKey(
                        name: "FK_GioHangs_NguoiDungs_IdNguoiDung",
                        column: x => x.IdNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "IDNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhuongThucThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayVanChuyen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayGiaoHangDuKien = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayNhanHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhiVanChuyen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDiaChi = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPhieuGiamGia = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhuongThucThanhToanIdPhuongThucThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaChiIdDiaChi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhieuGiamGiaIdPhieuGiamGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.IdHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDons_DiaChis_DiaChiIdDiaChi",
                        column: x => x.DiaChiIdDiaChi,
                        principalTable: "DiaChis",
                        principalColumn: "IdDiaChi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_NguoiDungs_IdPhieuGiamGia",
                        column: x => x.IdPhieuGiamGia,
                        principalTable: "NguoiDungs",
                        principalColumn: "IDNguoiDung");
                    table.ForeignKey(
                        name: "FK_HoaDons_PhieuGiamGias_PhieuGiamGiaIdPhieuGiamGia",
                        column: x => x.PhieuGiamGiaIdPhieuGiamGia,
                        principalTable: "PhieuGiamGias",
                        principalColumn: "IdPhieuGiamGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_PhuongThucThanhToans_PhuongThucThanhToanIdPhuongThucThanhToan",
                        column: x => x.PhuongThucThanhToanIdPhuongThucThanhToan,
                        principalTable: "PhuongThucThanhToans",
                        principalColumn: "IdPhuongThucThanhToan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangCTs",
                columns: table => new
                {
                    IdGioHangCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPhamCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GioHangIdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamCTIdSPChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangCTs", x => x.IdGioHangCT);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_GioHangs_GioHangIdGioHang",
                        column: x => x.GioHangIdGioHang,
                        principalTable: "GioHangs",
                        principalColumn: "IdGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangCTs_SanPhamCTs_SanPhamCTIdSPChiTiet",
                        column: x => x.SanPhamCTIdSPChiTiet,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSPChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCTs",
                columns: table => new
                {
                    IdHoaDonCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPhamCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamCTIdSPChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCTs", x => x.IdHoaDonCT);
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_HoaDons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_SanPhamCTs_SanPhamCTIdSPChiTiet",
                        column: x => x.SanPhamCTIdSPChiTiet,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSPChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichSuHoaDons",
                columns: table => new
                {
                    IdLichSuHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayDatHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNhanHang = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuHoaDons", x => x.IdLichSuHoaDon);
                    table.ForeignKey(
                        name: "FK_LichSuHoaDons_HoaDons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiaChis_NguoiDungIDNguoiDung",
                table: "DiaChis",
                column: "NguoiDungIDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCTs_GioHangIdGioHang",
                table: "GioHangCTs",
                column: "GioHangIdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCTs_SanPhamCTIdSPChiTiet",
                table: "GioHangCTs",
                column: "SanPhamCTIdSPChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_IdNguoiDung",
                table: "GioHangs",
                column: "IdNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCTs_IdHoaDon",
                table: "HoaDonCTs",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCTs_SanPhamCTIdSPChiTiet",
                table: "HoaDonCTs",
                column: "SanPhamCTIdSPChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_DiaChiIdDiaChi",
                table: "HoaDons",
                column: "DiaChiIdDiaChi");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdPhieuGiamGia",
                table: "HoaDons",
                column: "IdPhieuGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_PhieuGiamGiaIdPhieuGiamGia",
                table: "HoaDons",
                column: "PhieuGiamGiaIdPhieuGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_PhuongThucThanhToanIdPhuongThucThanhToan",
                table: "HoaDons",
                column: "PhuongThucThanhToanIdPhuongThucThanhToan");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuHoaDons_IdHoaDon",
                table: "LichSuHoaDons",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungs_IDVaiTro",
                table: "NguoiDungs",
                column: "IDVaiTro");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuGiamGias_IdKieuGiamGia",
                table: "PhieuGiamGias",
                column: "IdKieuGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_HangIdHang",
                table: "SanPhamCTs",
                column: "HangIdHang");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_KeyCapIdKeyCap",
                table: "SanPhamCTs",
                column: "KeyCapIdKeyCap");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_LedIdLed",
                table: "SanPhamCTs",
                column: "LedIdLed");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_LoaiKNIdLoaiKN",
                table: "SanPhamCTs",
                column: "LoaiKNIdLoaiKN");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_MauIdMau",
                table: "SanPhamCTs",
                column: "MauIdMau");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_SanPhamIdSanPham",
                table: "SanPhamCTs",
                column: "SanPhamIdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamKMs_KhuyenMaiIdKhuyenMai",
                table: "SanPhamKMs",
                column: "KhuyenMaiIdKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamKMs_SanPhamIdSanPham",
                table: "SanPhamKMs",
                column: "SanPhamIdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_HinhAnhIdHinhAnh",
                table: "SanPhams",
                column: "HinhAnhIdHinhAnh");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_LoaiSPIdLoaiSP",
                table: "SanPhams",
                column: "LoaiSPIdLoaiSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangCTs");

            migrationBuilder.DropTable(
                name: "HoaDonCTs");

            migrationBuilder.DropTable(
                name: "LichSuHoaDons");

            migrationBuilder.DropTable(
                name: "SanPhamKMs");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "SanPhamCTs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "KhuyenMais");

            migrationBuilder.DropTable(
                name: "Hangs");

            migrationBuilder.DropTable(
                name: "KeyCaps");

            migrationBuilder.DropTable(
                name: "Leds");

            migrationBuilder.DropTable(
                name: "LoaiKNs");

            migrationBuilder.DropTable(
                name: "Maus");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "DiaChis");

            migrationBuilder.DropTable(
                name: "PhieuGiamGias");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToans");

            migrationBuilder.DropTable(
                name: "HinhAnhs");

            migrationBuilder.DropTable(
                name: "LoaiSPs");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "KieuGiamGias");

            migrationBuilder.DropTable(
                name: "VaiTros");
        }
    }
}
