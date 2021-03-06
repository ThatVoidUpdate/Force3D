﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Force3D
{
    /// <summary>
    /// Example lists of triangles that can be used for instantiating GameObjects
    /// </summary>
    public class Primitives
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

        /// <summary>
        /// List of triangles used to make a low-poly sphere
        /// </summary>
        public static List<Tri> Sphere = new List<Tri>(){ new Tri(new Vector3(0f, -1f, 0f), new Vector3(0.425323f, -0.850654f, 0.309011f), new Vector3(-0.162456f, -0.850654f, 0.499995f)),
new Tri(new Vector3(0.723607f, -0.44722f, 0.525725f), new Vector3(0.425323f, -0.850654f, 0.309011f), new Vector3(0.850648f, -0.525736f, 0f)),
new Tri(new Vector3(0f, -1f, 0f), new Vector3(-0.162456f, -0.850654f, 0.499995f), new Vector3(-0.52573f, -0.850652f, 0f)),
new Tri(new Vector3(0f, -1f, 0f), new Vector3(-0.52573f, -0.850652f, 0f), new Vector3(-0.162456f, -0.850654f, -0.499995f)),
new Tri(new Vector3(0f, -1f, 0f), new Vector3(-0.162456f, -0.850654f, -0.499995f), new Vector3(0.425323f, -0.850654f, -0.309011f)),
new Tri(new Vector3(0.723607f, -0.44722f, 0.525725f), new Vector3(0.850648f, -0.525736f, 0f), new Vector3(0.951058f, 0f, 0.309013f)),
new Tri(new Vector3(-0.276388f, -0.44722f, 0.850649f), new Vector3(0.262869f, -0.525738f, 0.809012f), new Vector3(0f, 0f, 1f)),
new Tri(new Vector3(-0.894426f, -0.447216f, 0f), new Vector3(-0.688189f, -0.525736f, 0.499997f), new Vector3(-0.951058f, 0f, 0.309013f)),
new Tri(new Vector3(-0.276388f, -0.44722f, -0.850649f), new Vector3(-0.688189f, -0.525736f, -0.499997f), new Vector3(-0.587786f, 0f, -0.809017f)),
new Tri(new Vector3(0.723607f, -0.44722f, -0.525725f), new Vector3(0.262869f, -0.525738f, -0.809012f), new Vector3(0.587786f, 0f, -0.809017f)),
new Tri(new Vector3(0.723607f, -0.44722f, 0.525725f), new Vector3(0.951058f, 0f, 0.309013f), new Vector3(0.587786f, 0f, 0.809017f)),
new Tri(new Vector3(-0.276388f, -0.44722f, 0.850649f), new Vector3(0f, 0f, 1f), new Vector3(-0.587786f, 0f, 0.809017f)),
new Tri(new Vector3(-0.894426f, -0.447216f, 0f), new Vector3(-0.951058f, 0f, 0.309013f), new Vector3(-0.951058f, 0f, -0.309013f)),
new Tri(new Vector3(-0.276388f, -0.44722f, -0.850649f), new Vector3(-0.587786f, 0f, -0.809017f), new Vector3(0f, 0f, -1f)),
new Tri(new Vector3(0.723607f, -0.44722f, -0.525725f), new Vector3(0.587786f, 0f, -0.809017f), new Vector3(0.951058f, 0f, -0.309013f)),
new Tri(new Vector3(0.276388f, 0.44722f, 0.850649f), new Vector3(0.688189f, 0.525736f, 0.499997f), new Vector3(0.162456f, 0.850654f, 0.499995f)),
new Tri(new Vector3(-0.723607f, 0.44722f, 0.525725f), new Vector3(-0.262869f, 0.525738f, 0.809012f), new Vector3(-0.425323f, 0.850654f, 0.309011f)),
new Tri(new Vector3(-0.723607f, 0.44722f, -0.525725f), new Vector3(-0.850648f, 0.525736f, 0f), new Vector3(-0.425323f, 0.850654f, -0.309011f)),
new Tri(new Vector3(0.276388f, 0.44722f, -0.850649f), new Vector3(-0.262869f, 0.525738f, -0.809012f), new Vector3(0.162456f, 0.850654f, -0.499995f)),
new Tri(new Vector3(0.894426f, 0.447216f, 0f), new Vector3(0.688189f, 0.525736f, -0.499997f), new Vector3(0.52573f, 0.850652f, 0f)),
new Tri(new Vector3(0.52573f, 0.850652f, 0f), new Vector3(0.162456f, 0.850654f, -0.499995f), new Vector3(0f, 1f, 0f)),
new Tri(new Vector3(0.52573f, 0.850652f, 0f), new Vector3(0.688189f, 0.525736f, -0.499997f), new Vector3(0.162456f, 0.850654f, -0.499995f)),
new Tri(new Vector3(0.688189f, 0.525736f, -0.499997f), new Vector3(0.276388f, 0.44722f, -0.850649f), new Vector3(0.162456f, 0.850654f, -0.499995f)),
new Tri(new Vector3(0.162456f, 0.850654f, -0.499995f), new Vector3(-0.425323f, 0.850654f, -0.309011f), new Vector3(0f, 1f, 0f)),
new Tri(new Vector3(0.162456f, 0.850654f, -0.499995f), new Vector3(-0.262869f, 0.525738f, -0.809012f), new Vector3(-0.425323f, 0.850654f, -0.309011f)),
new Tri(new Vector3(-0.262869f, 0.525738f, -0.809012f), new Vector3(-0.723607f, 0.44722f, -0.525725f), new Vector3(-0.425323f, 0.850654f, -0.309011f)),
new Tri(new Vector3(-0.425323f, 0.850654f, -0.309011f), new Vector3(-0.425323f, 0.850654f, 0.309011f), new Vector3(0f, 1f, 0f)),
new Tri(new Vector3(-0.425323f, 0.850654f, -0.309011f), new Vector3(-0.850648f, 0.525736f, 0f), new Vector3(-0.425323f, 0.850654f, 0.309011f)),
new Tri(new Vector3(-0.850648f, 0.525736f, 0f), new Vector3(-0.723607f, 0.44722f, 0.525725f), new Vector3(-0.425323f, 0.850654f, 0.309011f)),
new Tri(new Vector3(-0.425323f, 0.850654f, 0.309011f), new Vector3(0.162456f, 0.850654f, 0.499995f), new Vector3(0f, 1f, 0f)),
new Tri(new Vector3(-0.425323f, 0.850654f, 0.309011f), new Vector3(-0.262869f, 0.525738f, 0.809012f), new Vector3(0.162456f, 0.850654f, 0.499995f)),
new Tri(new Vector3(-0.262869f, 0.525738f, 0.809012f), new Vector3(0.276388f, 0.44722f, 0.850649f), new Vector3(0.162456f, 0.850654f, 0.499995f)),
new Tri(new Vector3(0.162456f, 0.850654f, 0.499995f), new Vector3(0.52573f, 0.850652f, 0f), new Vector3(0f, 1f, 0f)),
new Tri(new Vector3(0.162456f, 0.850654f, 0.499995f), new Vector3(0.688189f, 0.525736f, 0.499997f), new Vector3(0.52573f, 0.850652f, 0f)),
new Tri(new Vector3(0.688189f, 0.525736f, 0.499997f), new Vector3(0.894426f, 0.447216f, 0f), new Vector3(0.52573f, 0.850652f, 0f)),
new Tri(new Vector3(0.951058f, 0f, -0.309013f), new Vector3(0.688189f, 0.525736f, -0.499997f), new Vector3(0.894426f, 0.447216f, 0f)),
new Tri(new Vector3(0.951058f, 0f, -0.309013f), new Vector3(0.587786f, 0f, -0.809017f), new Vector3(0.688189f, 0.525736f, -0.499997f)),
new Tri(new Vector3(0.587786f, 0f, -0.809017f), new Vector3(0.276388f, 0.44722f, -0.850649f), new Vector3(0.688189f, 0.525736f, -0.499997f)),
new Tri(new Vector3(0f, 0f, -1f), new Vector3(-0.262869f, 0.525738f, -0.809012f), new Vector3(0.276388f, 0.44722f, -0.850649f)),
new Tri(new Vector3(0f, 0f, -1f), new Vector3(-0.587786f, 0f, -0.809017f), new Vector3(-0.262869f, 0.525738f, -0.809012f)),
new Tri(new Vector3(-0.587786f, 0f, -0.809017f), new Vector3(-0.723607f, 0.44722f, -0.525725f), new Vector3(-0.262869f, 0.525738f, -0.809012f)),
new Tri(new Vector3(-0.951058f, 0f, -0.309013f), new Vector3(-0.850648f, 0.525736f, 0f), new Vector3(-0.723607f, 0.44722f, -0.525725f)),
new Tri(new Vector3(-0.951058f, 0f, -0.309013f), new Vector3(-0.951058f, 0f, 0.309013f), new Vector3(-0.850648f, 0.525736f, 0f)),
new Tri(new Vector3(-0.951058f, 0f, 0.309013f), new Vector3(-0.723607f, 0.44722f, 0.525725f), new Vector3(-0.850648f, 0.525736f, 0f)),
new Tri(new Vector3(-0.587786f, 0f, 0.809017f), new Vector3(-0.262869f, 0.525738f, 0.809012f), new Vector3(-0.723607f, 0.44722f, 0.525725f)),
new Tri(new Vector3(-0.587786f, 0f, 0.809017f), new Vector3(0f, 0f, 1f), new Vector3(-0.262869f, 0.525738f, 0.809012f)),
new Tri(new Vector3(0f, 0f, 1f), new Vector3(0.276388f, 0.44722f, 0.850649f), new Vector3(-0.262869f, 0.525738f, 0.809012f)),
new Tri(new Vector3(0.587786f, 0f, 0.809017f), new Vector3(0.688189f, 0.525736f, 0.499997f), new Vector3(0.276388f, 0.44722f, 0.850649f)),
new Tri(new Vector3(0.587786f, 0f, 0.809017f), new Vector3(0.951058f, 0f, 0.309013f), new Vector3(0.688189f, 0.525736f, 0.499997f)),
new Tri(new Vector3(0.951058f, 0f, 0.309013f), new Vector3(0.894426f, 0.447216f, 0f), new Vector3(0.688189f, 0.525736f, 0.499997f)),
new Tri(new Vector3(0.587786f, 0f, -0.809017f), new Vector3(0f, 0f, -1f), new Vector3(0.276388f, 0.44722f, -0.850649f)),
new Tri(new Vector3(0.587786f, 0f, -0.809017f), new Vector3(0.262869f, -0.525738f, -0.809012f), new Vector3(0f, 0f, -1f)),
new Tri(new Vector3(0.262869f, -0.525738f, -0.809012f), new Vector3(-0.276388f, -0.44722f, -0.850649f), new Vector3(0f, 0f, -1f)),
new Tri(new Vector3(-0.587786f, 0f, -0.809017f), new Vector3(-0.951058f, 0f, -0.309013f), new Vector3(-0.723607f, 0.44722f, -0.525725f)),
new Tri(new Vector3(-0.587786f, 0f, -0.809017f), new Vector3(-0.688189f, -0.525736f, -0.499997f), new Vector3(-0.951058f, 0f, -0.309013f)),
new Tri(new Vector3(-0.688189f, -0.525736f, -0.499997f), new Vector3(-0.894426f, -0.447216f, 0f), new Vector3(-0.951058f, 0f, -0.309013f)),
new Tri(new Vector3(-0.951058f, 0f, 0.309013f), new Vector3(-0.587786f, 0f, 0.809017f), new Vector3(-0.723607f, 0.44722f, 0.525725f)),
new Tri(new Vector3(-0.951058f, 0f, 0.309013f), new Vector3(-0.688189f, -0.525736f, 0.499997f), new Vector3(-0.587786f, 0f, 0.809017f)),
new Tri(new Vector3(-0.688189f, -0.525736f, 0.499997f), new Vector3(-0.276388f, -0.44722f, 0.850649f), new Vector3(-0.587786f, 0f, 0.809017f)),
new Tri(new Vector3(0f, 0f, 1f), new Vector3(0.587786f, 0f, 0.809017f), new Vector3(0.276388f, 0.44722f, 0.850649f)),
new Tri(new Vector3(0f, 0f, 1f), new Vector3(0.262869f, -0.525738f, 0.809012f), new Vector3(0.587786f, 0f, 0.809017f)),
new Tri(new Vector3(0.262869f, -0.525738f, 0.809012f), new Vector3(0.723607f, -0.44722f, 0.525725f), new Vector3(0.587786f, 0f, 0.809017f)),
new Tri(new Vector3(0.951058f, 0f, 0.309013f), new Vector3(0.951058f, 0f, -0.309013f), new Vector3(0.894426f, 0.447216f, 0f)),
new Tri(new Vector3(0.951058f, 0f, 0.309013f), new Vector3(0.850648f, -0.525736f, 0f), new Vector3(0.951058f, 0f, -0.309013f)),
new Tri(new Vector3(0.850648f, -0.525736f, 0f), new Vector3(0.723607f, -0.44722f, -0.525725f), new Vector3(0.951058f, 0f, -0.309013f)),
new Tri(new Vector3(0.425323f, -0.850654f, -0.309011f), new Vector3(0.262869f, -0.525738f, -0.809012f), new Vector3(0.723607f, -0.44722f, -0.525725f)),
new Tri(new Vector3(0.425323f, -0.850654f, -0.309011f), new Vector3(-0.162456f, -0.850654f, -0.499995f), new Vector3(0.262869f, -0.525738f, -0.809012f)),
new Tri(new Vector3(-0.162456f, -0.850654f, -0.499995f), new Vector3(-0.276388f, -0.44722f, -0.850649f), new Vector3(0.262869f, -0.525738f, -0.809012f)),
new Tri(new Vector3(-0.162456f, -0.850654f, -0.499995f), new Vector3(-0.688189f, -0.525736f, -0.499997f), new Vector3(-0.276388f, -0.44722f, -0.850649f)),
new Tri(new Vector3(-0.162456f, -0.850654f, -0.499995f), new Vector3(-0.52573f, -0.850652f, 0f), new Vector3(-0.688189f, -0.525736f, -0.499997f)),
new Tri(new Vector3(-0.52573f, -0.850652f, 0f), new Vector3(-0.894426f, -0.447216f, 0f), new Vector3(-0.688189f, -0.525736f, -0.499997f)),
new Tri(new Vector3(-0.52573f, -0.850652f, 0f), new Vector3(-0.688189f, -0.525736f, 0.499997f), new Vector3(-0.894426f, -0.447216f, 0f)),
new Tri(new Vector3(-0.52573f, -0.850652f, 0f), new Vector3(-0.162456f, -0.850654f, 0.499995f), new Vector3(-0.688189f, -0.525736f, 0.499997f)),
new Tri(new Vector3(-0.162456f, -0.850654f, 0.499995f), new Vector3(-0.276388f, -0.44722f, 0.850649f), new Vector3(-0.688189f, -0.525736f, 0.499997f)),
new Tri(new Vector3(0.850648f, -0.525736f, 0f), new Vector3(0.425323f, -0.850654f, -0.309011f), new Vector3(0.723607f, -0.44722f, -0.525725f)),
new Tri(new Vector3(0.850648f, -0.525736f, 0f), new Vector3(0.425323f, -0.850654f, 0.309011f), new Vector3(0.425323f, -0.850654f, -0.309011f)),
new Tri(new Vector3(0.425323f, -0.850654f, 0.309011f), new Vector3(0f, -1f, 0f), new Vector3(0.425323f, -0.850654f, -0.309011f)),
new Tri(new Vector3(-0.162456f, -0.850654f, 0.499995f), new Vector3(0.262869f, -0.525738f, 0.809012f), new Vector3(-0.276388f, -0.44722f, 0.850649f)),
new Tri(new Vector3(-0.162456f, -0.850654f, 0.499995f), new Vector3(0.425323f, -0.850654f, 0.309011f), new Vector3(0.262869f, -0.525738f, 0.809012f)),
new Tri(new Vector3(0.425323f, -0.850654f, 0.309011f), new Vector3(0.723607f, -0.44722f, 0.525725f), new Vector3(0.262869f, -0.525738f, 0.809012f)),
};

    }
}
