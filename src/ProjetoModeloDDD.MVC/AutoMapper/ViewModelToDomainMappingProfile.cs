﻿using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {      
            public override string ProfileName
            {
                get { return "ViewModelToDomainMappings"; }
            }
            protected void Configure()
            {
               // Mapper.CreateMap<ClienteViewModel, Cliente>();
               // Mapper.CreateMap<ProdutoViewModel, Produto>();
           
            Mapper.Initialize(x =>
            {
             
                x.CreateMap<ClienteViewModel, Cliente>();
               x.CreateMap<ProdutoViewModel, Produto>();

            });
        }
        }
    }