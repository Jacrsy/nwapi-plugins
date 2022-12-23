﻿using System.Runtime.Serialization;
using UnityEngine;
using YamlDotNet.Serialization;

namespace Padoru.API.Structs
{
    public struct SerializedVector3
    {
        [IgnoreDataMember]
        [YamlIgnore]
        public Vector3 Get => new(X, Y, Z);

        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        public SerializedVector3(Vector3 vector)
        {
            X = vector.x;
            Y = vector.y;
            Z = vector.z;
        }

        public SerializedVector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}