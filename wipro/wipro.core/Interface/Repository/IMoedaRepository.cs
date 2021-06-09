﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.Model;

namespace wipro.core.Interface.Repository
{
    public interface IMoedaRepository
    {
        List<Moeda> GetAllRegisters();
        Moeda GetMoedaBySimbolo(string SimboloMoeda);
        Moeda GetMoedaById(int IdMoeda);
        Moeda Create(Moeda moeda);
    }
}
