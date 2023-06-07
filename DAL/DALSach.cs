﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSach
    {
        private static DALSach instance;
        public static DALSach Instance
        {
            get
            {
                if (instance == null) instance = new DALSach();
                return instance;
            }
            set { instance = value; }
        }
        public bool UpdAnSach(int id, int data)
        {
            try
            {
                SACH sach = QLTVEntities.Instance.SACHes.Find(id);
                sach.DaAn = data;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public List<SACH> GetAllSach()
        {
            return QLTVEntities.Instance.SACHes.AsNoTracking().ToList();
        }

        public SACH GetSachById(int id)
        {
            return QLTVEntities.Instance.SACHes.Find(id);
        }
        /// <summary>
        /// Lấy sách bằng mã
        /// </summary>
        /// <param name="maSach"></param>
        /// <returns></returns>
        public SACH GetSachByMa(string maSach)
        {
            var res = QLTVEntities.Instance.SACHes.AsNoTracking().Where(s => s.MaSach == maSach);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        /// <summary>
        /// Tìm kiếm sách
        /// </summary>
        /// <param name="tuaSach"></param>
        /// <param name="namXB"></param>
        /// <param name="nhaXB"></param>
        /// <returns></returns>
        public List<SACH> FindSach(TUASACH tuaSach, int? namXB, string nhaXB)
        {
            List<SACH> res = GetAllSach();
            if (tuaSach != null) res = res.Where(s => s.TUASACH == tuaSach).Select(s => s).ToList();
            if (namXB != null) res = res.Where(s => s.NamXB == namXB).Select(s => s).ToList();
            if (nhaXB != null) res = res.Where(s => s.NhaXB == nhaXB).Select(s => s).ToList();
            return res;
        }

        /// <summary>
        /// Thêm sách mới
        /// </summary>
        /// <param name="tuaSach"></param>
        /// <param name="donGia"></param>
        /// <param name="namXB"></param>
        /// <param name="nhaXB"></param>
        /// <returns></returns>
        public int AddSachMoi(TUASACH tuaSach, int donGia, int namXB, string nhaXB)
        {
            try
            {
                SACH sach = new SACH
                {
                    TUASACH = tuaSach,
                    idTuaSach = tuaSach.id,
                    SoLuong = 0,
                    SoLuongConLai = 0,
                    NamXB = namXB,
                    DonGia = donGia,
                    NhaXB = nhaXB
                };
                QLTVEntities.Instance.SACHes.Add(sach);
                QLTVEntities.Instance.SaveChanges();
                return sach.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        // Thêm sách đã có

        /// <summary>
        /// Thay đổi thông tin quyển sách
        /// </summary>
        /// <param name="id"></param>
        /// <param name="namXB"></param>
        /// <param name="nhaXB"></param>
        /// <returns></returns>
        public bool UpdSach(int id, int? namXB, string nhaXB)
        {
            try
            {
                SACH sach = GetSachById(id);
                if (sach == null) return false;
                if (namXB != null) sach.NamXB = (int)namXB;
                if (nhaXB != null) sach.NhaXB = nhaXB;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }


        /// <summary>
        /// Xóa sách
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DelSach(int id)
        {
            try
            {
                SACH sach = GetSachById(id);
                if (sach == null) return false;
                QLTVEntities.Instance.SACHes.Remove(sach);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
