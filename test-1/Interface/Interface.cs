using System;
using System.Collections.Generic;
using Test_1.Modal;
using Test_1.Services;

namespace test.Interface
{
    public interface Interface
    {
        int resgistration(RIM temp);
        List<RIM> getdata();
        void Denatal();
        void General_medican();
        void ortho();
    }
}
