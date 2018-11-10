﻿using System;
using System.Collections.Generic;
using System.Text;

namespace builder.two
{
    public class OrdenacionDirector
    {
        private OrdenacionBuilder builder;

        public OrdenacionDirector(OrdenacionBuilder builder)
        {
            this.builder = builder;
        }

        public void build(String[] datos)
        {
            builder.ordenar(datos);
        }
    }
}
