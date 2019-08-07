﻿using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class ProvinceService:IProvinceService
    {
        bool status = false;
        private readonly IProvinceRepository _provinceRepository;
        public ProvinceService(IProvinceRepository provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }
        public ProvinceService() { }

        public List<Province> Get()
        {
            var result = _provinceRepository.Get();
            return result;
        }

        public Province Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _provinceRepository.Get(id);
                return result;
            }
        }

        public bool Insert(ProvinceVM provinceVM)
        {
            if (string.IsNullOrWhiteSpace(provinceVM.Name))
            {
                return status;
            }
            else
            {
                var result = _provinceRepository.Insert(provinceVM);
                return result;
            }
        }
    }
}
