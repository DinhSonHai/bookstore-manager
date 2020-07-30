using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNhaSach.BSLayer
{
    class BLInfomation
    {
        #region Login
        public DataTable LayTaiKhoan()
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var lgs =
            from p in qltvEntity.Logins
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Pass");
            foreach (var p in lgs)
            {
                dt.Rows.Add(p.ID, p.Pass);
            }
            return dt;
        }
        public bool ThemTaiKhoan(string ID, string Pass)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();

            Login lg = new Login();
            lg.ID = ID;
            lg.Pass = Pass;
            qltvEntity.Logins.Add(lg);
            qltvEntity.SaveChanges();

            return true;

        }
        public bool XoaTaiKhoan(string ID)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            Login lg = new Login();
            lg.ID = ID;
            qltvEntity.Logins.Attach(lg);
            qltvEntity.Logins.Remove(lg);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool SearchTK(string ID, string Pass)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var lgQuery = (from lg in qltvEntity.Logins
                           where lg.ID == ID && lg.Pass == Pass
                           select lg).SingleOrDefault();
            if (lgQuery != null)
            {
                return true;
            }
            return false;
        }
        public bool CapNhatTaiKhoan(string ID, string Pass)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var lgQuery = (from lg in qltvEntity.Logins
                           where lg.ID == ID
                           select lg).SingleOrDefault();
            if (lgQuery != null)
            {
                lgQuery.Pass = Pass;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        public bool DangNhap(string ID,string MK)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var lgs =
            from p in qltvEntity.Logins
            select p;
            foreach (var p in lgs)
            {
                if(p.ID==ID&&p.Pass==MK)
                {
                    cLogin.isLogin = true;
                    cLogin.isDelete = true;
                }
            }
            return true;
        }
        #endregion
        #region Đầu sách
        public DataTable LayDauSach()
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dss =
            from p in qltvEntity.DauSaches
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tựa");
            dt.Columns.Add("Mã NXB");
            foreach (var p in dss)
            {
                dt.Rows.Add(p.MaSach,p.Tua,p.MaNXB);
            }
            return dt;
        }
        public bool ThemDauSach(string MaSach, string Tua, string MaNXB)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            DauSach ds = new DauSach();
            ds.MaSach = MaSach;
            ds.Tua = Tua;
            ds.MaNXB = MaNXB;
            qltvEntity.DauSaches.Add(ds);
            qltvEntity.SaveChanges();
            return true;

        }
        public bool XoaDauSach(string MaSach)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            DauSach ds = new DauSach();
            ds.MaSach = MaSach;
            qltvEntity.DauSaches.Attach(ds);
            qltvEntity.DauSaches.Remove(ds);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool XoaThacDauSach(string MaSach)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            DauSach ds = new DauSach();
            ds.MaSach = MaSach;
            qltvEntity.DauSaches.Attach(ds);
            qltvEntity.DauSaches.Remove(ds);
            foreach (TacGia tg in qltvEntity.TacGias)
            {
                if (tg.MaSach == MaSach)
                {
                    qltvEntity.TacGias.Attach(tg);
                    qltvEntity.TacGias.Remove(tg);
                }
            }
            foreach (CuonSach cs in qltvEntity.CuonSaches)
            {
                if (cs.MaSach == MaSach)
                {
                    qltvEntity.CuonSaches.Attach(cs);
                    qltvEntity.CuonSaches.Remove(cs);
                    foreach (MuonTra mt in qltvEntity.MuonTras)
                    {
                        if (mt.MaCuon == cs.MaCuon)
                        {
                            qltvEntity.MuonTras.Attach(mt);
                            qltvEntity.MuonTras.Remove(mt);
                        }
                    }
                }
            }
            qltvEntity.SaveChanges();
            return true;
        }
        public bool CapNhatDauSach(string MaSach, string Tua, string MaNXB)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dsQuery = (from ds in qltvEntity.DauSaches
                           where ds.MaSach == MaSach
                           select ds).SingleOrDefault();
            if (dsQuery != null)
            {
                dsQuery.Tua = Tua;
                dsQuery.MaNXB = MaNXB;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        #region Search
        public DataTable SearchDSMaSach(string MaSach)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dss =
            from p in qltvEntity.DauSaches
            where (p.MaSach.Contains(MaSach))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tựa");
            dt.Columns.Add("Mã NXB");
            foreach (var p in dss)
            {
                dt.Rows.Add(p.MaSach, p.Tua, p.MaNXB);
            }
            return dt;
        }
        public DataTable SearchDSTua(string Tua)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dss =
            from p in qltvEntity.DauSaches
            where (p.Tua.Contains(Tua))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tựa");
            dt.Columns.Add("Mã NXB");
            foreach (var p in dss)
            {
                dt.Rows.Add(p.MaSach, p.Tua, p.MaNXB);
            }
            return dt;
        }
        public DataTable SearchDSMaNXB(string MaNXB)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dss =
            from p in qltvEntity.DauSaches
            where (p.MaNXB.Contains(MaNXB))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tựa");
            dt.Columns.Add("Mã NXB");
            foreach (var p in dss)
            {
                dt.Rows.Add(p.MaSach, p.Tua, p.MaNXB);
            }
            return dt;
        }
        #endregion
        #endregion
        #region Tác giả
        public DataTable LayTacGia()
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var tgs =
            from p in qltvEntity.TacGias
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã TG");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tên TG");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Bút Danh");
            foreach (var p in tgs)
            {
                dt.Rows.Add(p.MaTG,p.MaSach,p.TenTG,p.DiaChi,p.ButDanh);
            }
            return dt;
        }
        public bool ThemTacGia(string MaTG, string MaSach, string TenTG, string DiaChi, string ButDanh)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            TacGia tg = new TacGia();
            tg.MaTG = MaTG;
            tg.MaSach = MaSach;
            tg.TenTG = TenTG;
            tg.DiaChi = DiaChi;
            tg.ButDanh = ButDanh;
            qltvEntity.TacGias.Add(tg);
            qltvEntity.SaveChanges();

            return true;

        }
        public bool XoaTacGia(string MaTG, string MaSach)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            TacGia tg = new TacGia();
            tg.MaTG = MaTG;
            tg.MaSach = MaSach;
            qltvEntity.TacGias.Attach(tg);
            qltvEntity.TacGias.Remove(tg);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool CapNhatTacGia(string MaTG, string MaSach, string TenTG, string DiaChi, string ButDanh)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var tgQuery = (from tg in qltvEntity.TacGias
                           where (tg.MaTG == MaTG && tg.MaSach==MaSach)
                           select tg).SingleOrDefault();
            if (tgQuery != null)
            {
                tgQuery.MaSach = MaSach;
                tgQuery.TenTG = TenTG;
                tgQuery.DiaChi = DiaChi;
                tgQuery.ButDanh = ButDanh;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        #region Search
        public DataTable SearchTGMaTG(string MaTG)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var tgs =
            from p in qltvEntity.TacGias
            where (p.MaTG.Contains(MaTG))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã TG");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tên TG");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Bút Danh");
            foreach (var p in tgs)
            {
                dt.Rows.Add(p.MaTG, p.MaSach, p.TenTG, p.DiaChi, p.ButDanh);
            }
            return dt;
        }
        public DataTable SearchTGMaSach(string MaSach)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var tgs =
            from p in qltvEntity.TacGias
            where (p.MaSach.Contains(MaSach))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã TG");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tên TG");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Bút Danh");
            foreach (var p in tgs)
            {
                dt.Rows.Add(p.MaTG, p.MaSach, p.TenTG, p.DiaChi, p.ButDanh);
            }
            return dt;
        }
        public DataTable SearchTGTenTG(string TenTG)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var tgs =
            from p in qltvEntity.TacGias
            where (p.TenTG.Contains(TenTG))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã TG");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tên TG");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Bút Danh");
            foreach (var p in tgs)
            {
                dt.Rows.Add(p.MaTG, p.MaSach, p.TenTG, p.DiaChi, p.ButDanh);
            }
            return dt;
        }
        public DataTable SearchTGDiaChi(string DiaChi)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var tgs =
            from p in qltvEntity.TacGias
            where (p.DiaChi.Contains(DiaChi))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã TG");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tên TG");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Bút Danh");
            foreach (var p in tgs)
            {
                dt.Rows.Add(p.MaTG, p.MaSach, p.TenTG, p.DiaChi, p.ButDanh);
            }
            return dt;
        }
        public DataTable SearchTGButDanh(string ButDanh)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var tgs =
            from p in qltvEntity.TacGias
            where (p.ButDanh.Contains(ButDanh))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã TG");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tên TG");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Bút Danh");
            foreach (var p in tgs)
            {
                dt.Rows.Add(p.MaTG, p.MaSach, p.TenTG, p.DiaChi, p.ButDanh);
            }
            return dt;
        }
        #endregion
        #endregion
        #region NXB
        public DataTable LayNXB()
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nxbs =
            from p in qltvEntity.NXBs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NXB");
            dt.Columns.Add("Tên NXB");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in nxbs)
            {
                dt.Rows.Add(p.MaNXB, p.TenNXB, p.DiaChi);
            }
            return dt;
        }
        public bool ThemNXB(string MaNXB, string TenNXB, string DiaChi)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            NXB nxb = new NXB();
            nxb.MaNXB = MaNXB;
            nxb.TenNXB = TenNXB;
            nxb.DiaChi = DiaChi;
            qltvEntity.NXBs.Add(nxb);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool XoaNXB(string MaNXB)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            NXB nxb = new NXB();
            nxb.MaNXB = MaNXB;
            qltvEntity.NXBs.Attach(nxb);
            qltvEntity.NXBs.Remove(nxb);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool XoaThacNXB(string MaNXB)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            NXB nxb = new NXB();
            nxb.MaNXB = MaNXB;
            qltvEntity.NXBs.Attach(nxb);
            qltvEntity.NXBs.Remove(nxb);
            foreach(DauSach ds in qltvEntity.DauSaches)
            {
                if(ds.MaNXB==MaNXB)
                {
                    qltvEntity.DauSaches.Attach(ds);
                    qltvEntity.DauSaches.Remove(ds);
                }
            }
            qltvEntity.SaveChanges();
            return true;
        }
        public bool CapNhatNXB(string MaNXB, string TenNXB, string DiaChi)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nxbQuery = (from nxb in qltvEntity.NXBs
                            where nxb.MaNXB == MaNXB
                            select nxb).SingleOrDefault();
            if (nxbQuery != null)
            {
                nxbQuery.TenNXB = TenNXB;
                nxbQuery.DiaChi = DiaChi;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        #region Search
        public DataTable SearchNXBMaNXB(string MaNXB)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nxbs =
            from p in qltvEntity.NXBs
            where (p.MaNXB.Contains(MaNXB))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NXB");
            dt.Columns.Add("Tên NXB");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in nxbs)
            {
                dt.Rows.Add(p.MaNXB, p.TenNXB, p.DiaChi);
            }
            return dt;
        }
        public DataTable SearchNXBTenNXB(string TenNXB)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nxbs =
            from p in qltvEntity.NXBs
            where (p.TenNXB.Contains(TenNXB))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NXB");
            dt.Columns.Add("Tên NXB");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in nxbs)
            {
                dt.Rows.Add(p.MaNXB, p.TenNXB, p.DiaChi);
            }
            return dt;
        }
        public DataTable SearchNXBDiaChi(string DiaChi)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nxbs =
            from p in qltvEntity.NXBs
            where (p.DiaChi.Contains(DiaChi))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NXB");
            dt.Columns.Add("Tên NXB");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in nxbs)
            {
                dt.Rows.Add(p.MaNXB, p.TenNXB, p.DiaChi);
            }
            return dt;
        }
        #endregion
        #endregion
        #region Cuốn sách
        public DataTable LayCuonSach()
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var css =
            from p in qltvEntity.CuonSaches
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Vị Trí");
            foreach (var p in css)
            {
                dt.Rows.Add(p.MaSach, p.MaCuon, p.ViTri);
            }
            return dt;
        }
        public bool ThemCuonSach(string MaSach, string MaCuon, string ViTri)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            CuonSach cs = new CuonSach();
            cs.MaSach = MaSach;
            cs.MaCuon = MaCuon;
            cs.ViTri = ViTri;
            qltvEntity.CuonSaches.Add(cs);
            qltvEntity.SaveChanges();
            return true;

        }
        public bool XoaCuonSach(string MaCuon)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            CuonSach cs = new CuonSach();
            cs.MaCuon = MaCuon;
            qltvEntity.CuonSaches.Attach(cs);
            qltvEntity.CuonSaches.Remove(cs);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool XoaThacCuonSach(string MaCuon)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            CuonSach cs = new CuonSach();
            cs.MaCuon = MaCuon;
            qltvEntity.CuonSaches.Attach(cs);
            qltvEntity.CuonSaches.Remove(cs);
            foreach (MuonTra mt in qltvEntity.MuonTras)
            {
                if (mt.MaCuon == MaCuon)
                {
                    qltvEntity.MuonTras.Attach(mt);
                    qltvEntity.MuonTras.Remove(mt);
                }
            }
            qltvEntity.SaveChanges();
            return true;
        }
        public bool CapNhatCuonSach(string MaSach, string MaCuon, string ViTri)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var csQuery = (from cs in qltvEntity.CuonSaches
                           where cs.MaCuon == MaCuon
                           select cs).SingleOrDefault();
            if (csQuery != null)
            {
                csQuery.ViTri = ViTri;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        #region Search
        public DataTable SearchCSMaCuon(string MaCuon)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var css =
            from p in qltvEntity.CuonSaches
            where (p.MaCuon.Contains(MaCuon))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Vị Trí");
            foreach (var p in css)
            {
                dt.Rows.Add(p.MaCuon, p.MaSach, p.ViTri);
            }
            return dt;
        }
        public DataTable SearchCSMaSach(string MaSach)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var css =
            from p in qltvEntity.CuonSaches
            where (p.MaSach.Contains(MaSach))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Vị Trí");
            foreach (var p in css)
            {
                dt.Rows.Add(p.MaCuon, p.MaSach, p.ViTri);
            }
            return dt;
        }
        public DataTable SearchCSViTri(string ViTri)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var css =
            from p in qltvEntity.CuonSaches
            where (p.ViTri.Contains(ViTri))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Vị Trí");
            foreach (var p in css)
            {
                dt.Rows.Add(p.MaCuon, p.MaSach, p.ViTri);
            }
            return dt;
        }
        #endregion
        #endregion
        #region Nhân viên
        public DataTable LayNhanVien()
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Nữ",typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Số ĐT");
            dt.Columns.Add("Ngày Nhận Việc");
            dt.Columns.Add("Lương");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV,p.Hoten,p.Nu,p.DiaChi, p.SoDT, p.NgayNV, p.Luong);
            }
            return dt;
        }
        public DataTable GetStaticticsNV()
        {
            int l3 = 0;
            int f3t5 = 0;
            int f5t10 = 0;
            int h10 = 0;
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số năm");
            dt.Columns.Add("Số nhân viên");
            foreach (var p in nvs)
            {
                if ((DateTime.Today.Year - p.NgayNV.Value.Year) <= 3)
                {
                    l3++;
                }
                else if(3 < (DateTime.Today.Year - p.NgayNV.Value.Year) && (DateTime.Today.Year - p.NgayNV.Value.Year) <= 5)
                {
                    f3t5++;
                }
                else if(5 < (DateTime.Today.Year - p.NgayNV.Value.Year) && (DateTime.Today.Year - p.NgayNV.Value.Year) <=10)
                {
                    f5t10++;
                }
                else
                {
                    h10++;
                }
            }
            DataRow d1 = dt.NewRow();
            d1["Số năm"] = "Dưới 3 năm";
            d1["Số nhân viên"] = l3;
            dt.Rows.Add(d1);
            DataRow d2 = dt.NewRow();
            d2["Số năm"] = "Từ 3 đến 5 năm";
            d2["Số nhân viên"] = f3t5;
            dt.Rows.Add(d2);
            DataRow d3 = dt.NewRow();
            d3["Số năm"] = "Từ 5 đến 10 năm";
            d3["Số nhân viên"] = f5t10;
            dt.Rows.Add(d3);
            DataRow d4 = dt.NewRow();
            d4["Số năm"] = "Trên 10 năm";
            d4["Số nhân viên"] = h10;
            dt.Rows.Add(d4);
            return dt;
        }
        public bool ThemNhanVien(string MaNV, string HoTen, bool Nu, string DiaChi, string SoDT, DateTime NgayNV,int Luong)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.Hoten = HoTen;
            nv.Nu = Nu;
            nv.DiaChi = DiaChi;
            nv.SoDT = SoDT;
            nv.NgayNV = NgayNV;
            nv.Luong = Luong;
            qltvEntity.NhanViens.Add(nv);
            qltvEntity.SaveChanges();
            return true;

        }
        public bool XoaNhanVien(string MaNV)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            qltvEntity.NhanViens.Attach(nv);
            qltvEntity.NhanViens.Remove(nv);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool XoaThacNV(string MaNV)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            qltvEntity.NhanViens.Attach(nv);
            qltvEntity.NhanViens.Remove(nv);
            foreach (MuonTra mt in qltvEntity.MuonTras)
            {
                if (mt.MaNV == nv.MaNV)
                {
                    qltvEntity.MuonTras.Attach(mt);
                    qltvEntity.MuonTras.Remove(mt);
                }
            }
            qltvEntity.SaveChanges();
            return true;
        }
        public bool CapNhatNhanVien(string MaNV, string HoTen, bool Nu, string DiaChi, string SoDT, DateTime NgayNV, int Luong)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvQuery = (from nv in qltvEntity.NhanViens
                           where nv.MaNV == MaNV
                           select nv).SingleOrDefault();
            if (nvQuery != null)
            {
                nvQuery.Hoten = HoTen;
                nvQuery.Nu = Nu;
                nvQuery.DiaChi = DiaChi;
                nvQuery.SoDT = SoDT;
                nvQuery.NgayNV = NgayNV;
                nvQuery.Luong = Luong;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        public DataTable SearchNVMaNV(string MaNV)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            where (p.MaNV.Contains(MaNV))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Nữ", typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Số ĐT");
            dt.Columns.Add("Ngày Nhận Việc");
            dt.Columns.Add("Lương");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.Hoten, p.Nu, p.DiaChi, p.SoDT, p.NgayNV, p.Luong);
            }
            return dt;
        }
        public DataTable SearchNVHoTen(string HoTen)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            where (p.Hoten.Contains(HoTen))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Nữ", typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Số ĐT");
            dt.Columns.Add("Ngày Nhận Việc");
            dt.Columns.Add("Lương");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.Hoten, p.Nu, p.DiaChi, p.SoDT, p.NgayNV, p.Luong);
            }
            return dt;
        }
        public DataTable SearchNVNu(string Nu)
        {
            bool isGirl;
            if (Nu == "Nữ" || Nu=="nữ")
            {
                isGirl = true;
            }
            else isGirl = false;
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            where (p.Nu == isGirl)
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Nữ", typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Số ĐT");
            dt.Columns.Add("Ngày Nhận Việc");
            dt.Columns.Add("Lương");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.Hoten, p.Nu, p.DiaChi, p.SoDT, p.NgayNV, p.Luong);
            }
            return dt;
        }
        public DataTable SearchNVDiaChi(string DiaChi)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            where (p.DiaChi.Contains(DiaChi))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Nữ", typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Số ĐT");
            dt.Columns.Add("Ngày Nhận Việc");
            dt.Columns.Add("Lương");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.Hoten, p.Nu, p.DiaChi, p.SoDT, p.NgayNV, p.Luong);
            }
            return dt;
        }
        public DataTable SearchNVSoDT(string SoDT)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            where (p.SoDT.Contains(SoDT))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Nữ", typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Số ĐT");
            dt.Columns.Add("Ngày Nhận Việc");
            dt.Columns.Add("Lương");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.Hoten, p.Nu, p.DiaChi, p.SoDT, p.NgayNV, p.Luong);
            }
            return dt;
        }
        public DataTable SearchNVNgaySinh(string NgaySinh)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            where (p.NgayNV.Value.Year.ToString() == NgaySinh)
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Nữ", typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Số ĐT");
            dt.Columns.Add("Ngày Nhận Việc");
            dt.Columns.Add("Lương");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.Hoten, p.Nu, p.DiaChi, p.SoDT, p.NgayNV, p.Luong);
            }
            return dt;
        }
        public DataTable SearchNVLuong(string Luong)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.NhanViens
            where (p.Luong.ToString().Contains(Luong))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Nữ", typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Số ĐT");
            dt.Columns.Add("Ngày Nhận Việc");
            dt.Columns.Add("Lương");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaNV, p.Hoten, p.Nu, p.DiaChi, p.SoDT, p.NgayNV, p.Luong);
            }
            return dt;
        }
        #endregion
        #region Mượn trả
        public DataTable LayMuonTra()
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var mts =
            from p in qltvEntity.MuonTras
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Ngày mượn");
            dt.Columns.Add("Ngày trả");
            foreach (var p in mts)
            {
                dt.Rows.Add(p.MaThe,p.MaCuon,p.MaNV,p.NgayMuon,p.NgayTra);
            }
            return dt;
        }
        public bool ThemMuonTra(string MaThe, string MaCuon, string MaNV, DateTime NgayMuon, DateTime NgayTra)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            MuonTra mt = new MuonTra();
            mt.MaThe = MaThe;
            mt.MaCuon = MaCuon;
            mt.MaNV = MaNV;
            mt.NgayMuon = NgayMuon;
            mt.NgayTra = NgayTra;
            qltvEntity.MuonTras.Add(mt);
            qltvEntity.SaveChanges();

            return true;

        }
        public bool XoaMuonTra(string MaThe, string MaCuon, string MaNV)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            MuonTra mt = new MuonTra();
            mt.MaThe = MaThe;
            mt.MaCuon = MaCuon;
            mt.MaNV = MaNV;
            qltvEntity.MuonTras.Attach(mt);
            qltvEntity.MuonTras.Remove(mt);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool CapNhatMuonTra(string MaThe, string MaCuon, string MaNV, DateTime NgayMuon, DateTime NgayTra)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var mtQuery = (from mt in qltvEntity.MuonTras
                           where (mt.MaThe == MaThe && mt.MaCuon == MaCuon && mt.MaNV==MaNV)
                           select mt).SingleOrDefault();
            if (mtQuery != null)
            {
                mtQuery.NgayMuon = NgayMuon;
                mtQuery.NgayTra = NgayTra;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        #region Search
        public DataTable SearchMTMaThe(string MaThe)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.MuonTras
            where (p.MaThe.Contains(MaThe))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Ngày Mượn");
            dt.Columns.Add("Ngày Trả");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaThe, p.MaCuon, p.MaNV, p.NgayMuon, p.NgayTra);
            }
            return dt;
        }
        public DataTable SearchMTMaCuon(string MaCuon)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.MuonTras
            where (p.MaCuon.Contains(MaCuon))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Ngày Mượn");
            dt.Columns.Add("Ngày Trả");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaThe, p.MaCuon, p.MaNV, p.NgayMuon, p.NgayTra);
            }
            return dt;
        }
        public DataTable SearchMTMaNV(string MaNV)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.MuonTras
            where (p.MaNV.Contains(MaNV))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Ngày Mượn");
            dt.Columns.Add("Ngày Trả");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaThe, p.MaCuon, p.MaNV, p.NgayMuon, p.NgayTra);
            }
            return dt;
        }
        public DataTable SearchMTNgayMuon(string NgayMuon)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.MuonTras
            where (p.NgayMuon.Value.Year.ToString() == NgayMuon)
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Ngày Mượn");
            dt.Columns.Add("Ngày Trả");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaThe, p.MaCuon, p.MaNV, p.NgayMuon, p.NgayTra);
            }
            return dt;
        }
        public DataTable SearchMTNgayTra(string NgayTra)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.MuonTras
            where (p.NgayMuon.Value.Year.ToString() == NgayTra)
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Mã Cuốn");
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Ngày Mượn");
            dt.Columns.Add("Ngày Trả");
            foreach (var p in nvs)
            {
                dt.Rows.Add(p.MaThe, p.MaCuon, p.MaNV, p.NgayMuon, p.NgayTra);
            }
            return dt;
        }
        #endregion
        #endregion
        #region Độc giả
        public DataTable LayDocGia()
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dgs =
            from p in qltvEntity.DocGias
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Ngày Cấp");
            dt.Columns.Add("Hạn Dùng");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in dgs)
            {
                dt.Rows.Add(p.MaThe,p.Hoten,p.NgaySinh,p.NgayCap,p.HanDung,p.DiaChi);
            }
            return dt;
        }
        public DataTable GetStaticticsDG()
        {
            double l10 = 0;
            double f10t18 = 0;
            double f18t25 = 0;
            double f25t45 = 0;
            double h45 = 0;
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var nvs =
            from p in qltvEntity.DocGias
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số tuổi");
            dt.Columns.Add("Số độc giả");
            foreach (var p in nvs)
            {
                if ((DateTime.Today.Year - p.NgaySinh.Value.Year) <= 10)
                {
                    l10++;
                }
                else if (10 < (DateTime.Today.Year - p.NgaySinh.Value.Year) && (DateTime.Today.Year - p.NgaySinh.Value.Year) <= 18)
                {
                    f10t18++;
                }
                else if (18 < (DateTime.Today.Year - p.NgaySinh.Value.Year) && (DateTime.Today.Year - p.NgaySinh.Value.Year) <= 25)
                {
                    f18t25++;
                }
                else if(25 < (DateTime.Today.Year - p.NgaySinh.Value.Year) && (DateTime.Today.Year - p.NgaySinh.Value.Year) <= 45)
                {
                    f25t45++;
                }
                else
                {
                    h45++;
                }
            }
            double s = l10 + f10t18 + f18t25 + f25t45 + h45;
            double a = (l10 / s) * 1.0;
            double b = (f10t18 / s) * 1.0;
            double c = (f18t25 / s) * 1.0;
            double d = (f25t45 / s) * 1.0;
            DataRow d1 = dt.NewRow();
            d1["Số tuổi"] = "Dưới 10 tuổi";
            d1["Số độc giả"] = a;
            dt.Rows.Add(d1);
            DataRow d2 = dt.NewRow();
            d2["Số tuổi"] = "Từ 10 đến 18 tuổi";
            d2["Số độc giả"] = b;
            dt.Rows.Add(d2);
            DataRow d3 = dt.NewRow();
            d3["Số tuổi"] = "Từ 18 đến 25 tuổi";
            d3["Số độc giả"] = c;
            dt.Rows.Add(d3);
            DataRow d4 = dt.NewRow();
            d4["Số tuổi"] = "Từ 25 đến 45 tuổi";
            d4["Số độc giả"] = d;
            dt.Rows.Add(d4);
            DataRow d5 = dt.NewRow();
            d5["Số tuổi"] = "Trên 45 tuổi";
            d5["Số độc giả"] = (1 - a - b - c - d);
            dt.Rows.Add(d5);
            return dt;
        }
        public bool ThemDocGia(string MaThe, string HoTen, DateTime NgaySinh, DateTime NgayCap, DateTime HanDung, string DiaChi)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            DocGia dg = new DocGia();
            dg.MaThe = MaThe;
            dg.Hoten = HoTen;
            dg.NgaySinh = NgaySinh;
            dg.NgayCap = NgayCap;
            dg.HanDung = HanDung;
            dg.DiaChi = DiaChi;
            qltvEntity.DocGias.Add(dg);
            qltvEntity.SaveChanges();

            return true;

        }
        public bool XoaDocGia(string MaThe)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            DocGia dg = new DocGia();
            dg.MaThe = MaThe;
            qltvEntity.DocGias.Attach(dg);
            qltvEntity.DocGias.Remove(dg);
            qltvEntity.SaveChanges();
            return true;
        }
        public bool XoaThacDocGia(string MaThe)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            DocGia dg = new DocGia();
            dg.MaThe = MaThe;
            qltvEntity.DocGias.Attach(dg);
            qltvEntity.DocGias.Remove(dg);
            foreach (MuonTra mt in qltvEntity.MuonTras)
            {
                if (mt.MaThe == dg.MaThe)
                {
                    qltvEntity.MuonTras.Attach(mt);
                    qltvEntity.MuonTras.Remove(mt);
                }
            }
            qltvEntity.SaveChanges();
            return true;
        }
        public bool CapNhatDocGia(string MaThe, string HoTen, DateTime NgaySinh, DateTime NgayCap, DateTime HanDung, string DiaChi)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dgQuery = (from dg in qltvEntity.DocGias
                           where dg.MaThe == MaThe
                           select dg).SingleOrDefault();
            if (dgQuery != null)
            {
                dgQuery.Hoten = HoTen;
                dgQuery.NgaySinh = NgaySinh;
                dgQuery.NgayCap = NgayCap;
                dgQuery.HanDung = HanDung;
                dgQuery.DiaChi = DiaChi;
                qltvEntity.SaveChanges();
            }
            return true;
        }
        #region Search
        public DataTable SearchDGMaThe(string MaThe)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dgs =
            from p in qltvEntity.DocGias
            where (p.MaThe.Contains(MaThe))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Ngày Cấp");
            dt.Columns.Add("Hạn Dùng");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in dgs)
            {
                dt.Rows.Add(p.MaThe, p.Hoten, p.NgaySinh, p.NgayCap, p.HanDung, p.DiaChi);
            }
            return dt;
        }
        public DataTable SearchDGHoTen(string HoTen)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dgs =
            from p in qltvEntity.DocGias
            where (p.Hoten.Contains(HoTen))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Ngày Cấp");
            dt.Columns.Add("Hạn Dùng");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in dgs)
            {
                dt.Rows.Add(p.MaThe, p.Hoten, p.NgaySinh, p.NgayCap, p.HanDung, p.DiaChi);
            }
            return dt;
        }
        public DataTable SearchDGNgaySinh(string NgaySinh)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dgs =
            from p in qltvEntity.DocGias
            where (p.NgaySinh.Value.Year.ToString() == NgaySinh)
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Ngày Cấp");
            dt.Columns.Add("Hạn Dùng");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in dgs)
            {
                dt.Rows.Add(p.MaThe, p.Hoten, p.NgaySinh, p.NgayCap, p.HanDung, p.DiaChi);
            }
            return dt;
        }
        public DataTable SearchDGNgayCap(string NgayCap)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dgs =
            from p in qltvEntity.DocGias
            where (p.NgayCap.Value.Year.ToString() == NgayCap)
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Ngày Cấp");
            dt.Columns.Add("Hạn Dùng");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in dgs)
            {
                dt.Rows.Add(p.MaThe, p.Hoten, p.NgaySinh, p.NgayCap, p.HanDung, p.DiaChi);
            }
            return dt;
        }
        public DataTable SearchDGHanDung(string HanDung)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dgs =
            from p in qltvEntity.DocGias
            where (p.HanDung.Value.Year.ToString() == HanDung)
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Ngày Cấp");
            dt.Columns.Add("Hạn Dùng");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in dgs)
            {
                dt.Rows.Add(p.MaThe, p.Hoten, p.NgaySinh, p.NgayCap, p.HanDung, p.DiaChi);
            }
            return dt;
        }
        public DataTable SearchDGDiaChi(string DiaChi)
        {
            QLThuVienEntities qltvEntity = new QLThuVienEntities();
            var dgs =
            from p in qltvEntity.DocGias
            where (p.DiaChi.Contains(DiaChi))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Ngày Cấp");
            dt.Columns.Add("Hạn Dùng");
            dt.Columns.Add("Địa Chỉ");
            foreach (var p in dgs)
            {
                dt.Rows.Add(p.MaThe, p.Hoten, p.NgaySinh, p.NgayCap, p.HanDung, p.DiaChi);
            }
            return dt;
        }
        #endregion
        #endregion

    }
}
