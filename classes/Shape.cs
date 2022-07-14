using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABXR.classes
{
    internal class Shape
    {
        private static int counter = 0;
        private int _id;
        private float _width;
        private float _height;
        private int _sides;
        private float[,,] _position; 
        private float _scale;
        private float[,,] _rotation;

        public Shape(float width, float height, int sides, float[,,] position, float scale, float[,,] rotation)
        {
            _id = ++counter;
            _width = width;
            _height = height;
            _sides = sides;
            _position = position;
            _scale = scale;
            _rotation = rotation;
        }

        public int Id { get => _id; set => _id = value; }
        public float Width { get => _width; set => _width = value; }
        public float Height { get => _height; set => _height = value; }
        public int Sides { get => _sides; set => _sides = value; }
        public float[,,] Position { get => _position; set => _position = value; }
        public float Scale { get => _scale; set => _scale = value; }
        public float[,,] Rotation { get => _rotation; set => _rotation = value; }

        public override int GetHashCode()
        {
            return _id;
        }

        public override string ToString()
        {
            return $"Shape Information : \n" + 
                $"ID : {_id}\n" + $"Width : {_width}\n" + 
                $"Height : {_height}\n" + $"Sides : {Sides}\n" +
                $"Position [x,y,z]: {_position[0, 0, 0]}\n" + 
                $"Scale : {_scale}\n" + $"Rotation : {_rotation[0, 0, 0]}\n";
        }

        public override bool Equals(object? obj)
        {
            var shape = obj as Shape;
            if (shape == null) return false;
            return shape._id == _id;
        }
    }
}
