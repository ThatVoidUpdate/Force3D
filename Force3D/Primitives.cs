using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Force3D
{
    class Primitives
    {
        /// <summary>
        /// List of triangles used to make up a unit cube
        /// </summary>
        public static List<Tri> Cube = new List<Tri>() {new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f)) ,
                                                 new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, -0.5f),   new Vector3(0.5f, -0.5f, -0.5f)) ,
                                                 new Tri(new Vector3(0.5f, 0.5f, -0.5f),  new Vector3(0.5f, -0.5f, -0.5f),  new Vector3(0.5f, -0.5f, 0.5f))  ,
                                                 new Tri(new Vector3(0.5f, 0.5f, -0.5f),  new Vector3(0.5f, 0.5f, 0.5f),    new Vector3(0.5f, -0.5f, 0.5f))  ,
                                                 new Tri(new Vector3(0.5f, 0.5f, 0.5f),   new Vector3(0.5f, -0.5f, 0.5f),   new Vector3(-0.5f, -0.5f, 0.5f)) ,
                                                 new Tri(new Vector3(0.5f, 0.5f, 0.5f),   new Vector3(-0.5f, 0.5f, 0.5f),   new Vector3(-0.5f, -0.5f, 0.5f)) ,
                                                 new Tri(new Vector3(-0.5f, 0.5f, 0.5f),  new Vector3(-0.5f, -0.5f, 0.5f),  new Vector3(-0.5f, -0.5f, -0.5f)),
                                                 new Tri(new Vector3(-0.5f, 0.5f, 0.5f),  new Vector3(-0.5f, 0.5f, -0.5f),  new Vector3(-0.5f, -0.5f, -0.5f)),
                                                 new Tri(new Vector3(0.5f, 0.5f, 0.5f),   new Vector3(-0.5f, 0.5f, 0.5f),   new Vector3(-0.5f, 0.5f, -0.5f)) ,
                                                 new Tri(new Vector3(0.5f, 0.5f, 0.5f),   new Vector3(0.5f, 0.5f, -0.5f),   new Vector3(-0.5f, 0.5f, -0.5f)) ,
                                                 new Tri(new Vector3(0.5f, -0.5f, 0.5f),  new Vector3(-0.5f, -0.5f, 0.5f),  new Vector3(-0.5f, -0.5f, -0.5f)),
                                                 new Tri(new Vector3(0.5f, -0.5f, 0.5f),  new Vector3(0.5f, -0.5f, -0.5f),  new Vector3(-0.5f, -0.5f, -0.5f))};

        /// <summary>
        /// List of triangles used to make up a unit cylinder
        /// </summary>
        public static List<Tri> Cylinder = new List<Tri>(){new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),    new Vector3(0.29389f, -0.499999f, 0.404503f),    new Vector3(0.475525f, -0.499999f, 0.154503f))  ,
                                                    new Tri(new Vector3(-0.475531f, -0.499999f, 0.154503f),  new Vector3(-0.475531f, -0.499999f, -0.154514f), new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f),      new Vector3(-0.293896f, 0.500001f, 0.404503f),   new Vector3(-0.293896f, -0.499999f, 0.404503f)) ,
                                                    new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),   new Vector3(0.475525f, -0.499999f, 0.154503f),   new Vector3(0.475525f, -0.499999f, -0.154514f)) ,
                                                    new Tri(new Vector3(-0.475531f, -0.499999f, -0.154514f), new Vector3(-0.293895f, -0.499999f, -0.404514f), new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),   new Vector3(-0.475531f, 0.500001f, 0.154503f),   new Vector3(-0.475531f, -0.499999f, 0.154503f)) ,
                                                    new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),    new Vector3(0.475525f, -0.499999f, -0.154514f),  new Vector3(0.29389f, -0.499999f, -0.404514f))  ,
                                                    new Tri(new Vector3(-0.293895f, -0.499999f, -0.404514f), new Vector3(-3E-06f, -0.499999f, -0.500005f),    new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),  new Vector3(-3E-06f, 0.500001f, -0.500005f),     new Vector3(-3E-06f, -0.499999f, -0.500005f))   ,
                                                    new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),     new Vector3(0.29389f, -0.499999f, -0.404514f),   new Vector3(-3E-06f, -0.499999f, -0.500005f))   ,
                                                    new Tri(new Vector3(-3E-06f, -0.499999f, -0.500005f),    new Vector3(0.29389f, -0.499999f, -0.404514f),   new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),  new Vector3(-0.293895f, 0.500001f, -0.404514f),  new Vector3(-0.293895f, -0.499999f, -0.404514f)),
                                                    new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f),     new Vector3(-3E-06f, 0.500001f, 0.499995f),      new Vector3(-3E-06f, -0.499999f, 0.499995f))    ,
                                                    new Tri(new Vector3(-0.293896f, -0.499999f, 0.404503f),  new Vector3(-0.475531f, -0.499999f, 0.154503f),  new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f),     new Vector3(-3E-06f, -0.499999f, 0.499995f),     new Vector3(0.29389f, -0.499999f, 0.404503f))   ,
                                                    new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),     new Vector3(0.29389f, 0.500001f, -0.404514f),    new Vector3(0.29389f, -0.499999f, -0.404514f))  ,
                                                    new Tri(new Vector3(-3E-06f, -0.499999f, 0.499995f),     new Vector3(-0.293896f, -0.499999f, 0.404503f),  new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f),      new Vector3(-0.293896f, -0.499999f, 0.404503f),  new Vector3(-3E-06f, -0.499999f, 0.499995f))    ,
                                                    new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),    new Vector3(0.475525f, 0.500001f, -0.154514f),   new Vector3(0.475525f, -0.499999f, -0.154514f)) ,
                                                    new Tri(new Vector3(0.29389f, -0.499999f, 0.404503f),    new Vector3(-3E-06f, -0.499999f, 0.499995f),     new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),   new Vector3(-0.475531f, -0.499999f, 0.154503f),  new Vector3(-0.293896f, -0.499999f, 0.404503f)) ,
                                                    new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),   new Vector3(0.475525f, 0.500001f, 0.154503f),    new Vector3(0.475525f, -0.499999f, 0.154503f))  ,
                                                    new Tri(new Vector3(0.475525f, -0.499999f, 0.154503f),   new Vector3(0.29389f, -0.499999f, 0.404503f),    new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),   new Vector3(-0.475531f, -0.499999f, -0.154514f), new Vector3(-0.475531f, -0.499999f, 0.154503f)) ,
                                                    new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),    new Vector3(0.29389f, 0.500001f, 0.404503f),     new Vector3(0.29389f, -0.499999f, 0.404503f))   ,
                                                    new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f),     new Vector3(0.475525f, 0.500001f, 0.154503f),    new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),  new Vector3(-0.293895f, -0.499999f, -0.404514f), new Vector3(-0.475531f, -0.499999f, -0.154514f)),
                                                    new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),   new Vector3(-0.475531f, 0.500001f, -0.154514f),  new Vector3(-0.475531f, -0.499999f, -0.154514f)),
                                                    new Tri(new Vector3(0.29389f, -0.499999f, -0.404514f),   new Vector3(0.475525f, -0.499999f, -0.154514f),  new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),  new Vector3(-3E-06f, -0.499999f, -0.500005f),    new Vector3(-0.293895f, -0.499999f, -0.404514f)),
                                                    new Tri(new Vector3(0.475525f, -0.499999f, -0.154514f),  new Vector3(0.475525f, -0.499999f, 0.154503f),   new Vector3(-3E-06f, -0.499999f, -5E-06f))      ,
                                                    new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),    new Vector3(0.475525f, 0.500001f, -0.154514f),   new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),   new Vector3(0.29389f, 0.500001f, -0.404514f),    new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),    new Vector3(-3E-06f, 0.500001f, -0.500005f),     new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),     new Vector3(-0.293895f, 0.500001f, -0.404514f),  new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),  new Vector3(-0.475531f, 0.500001f, -0.154514f),  new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),  new Vector3(-0.475531f, 0.500001f, 0.154503f),   new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),   new Vector3(-0.293896f, 0.500001f, 0.404503f),   new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),   new Vector3(-3E-06f, 0.500001f, 0.499995f),      new Vector3(-3E-06f, 0.500001f, -5E-06f))       ,
                                                    new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f),      new Vector3(0.29389f, 0.500001f, 0.404503f),     new Vector3(-3E-06f, 0.500001f, -5E-06f))       };
        
    }
}
