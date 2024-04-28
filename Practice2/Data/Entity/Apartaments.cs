using System;

namespace Practice2.Data.Entity
{
    public struct Apartments
    {
        private string _name;
        private int _floor;
        private string _owner;
        private double _area;
        private int _publicutilities;

        public Guid _id;
        public Guid Id
        {
            get { return _id; }
            set
            {
                if (_id == Guid.Empty)
                {
                    _id = value;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == null)
                {
                    _name = value;
                }
                else if (_name != null)
                {
                    _name = value;
                    OnUpdate();
                }

            }
        }

        public int Floor
        {
            get { return _floor; }
            set
            {
                if (_floor == 0)
                {
                    _floor = value;
                }
                else if (_floor != 0)
                {
                    _floor = value;
                    OnUpdate();
                }
            }
        }

        public string Owner
        {
            get { return _owner; }
            set
            {
                if (_owner == null)
                {
                    _owner = value;
                }
                else if (_owner != null)
                {
                    _owner = value;
                    OnUpdate();
                }
            }
        }
        public double Area
        {
            get { return _area; }
            set
            {
                if (_area == 0.0)
                {
                    _area = value;
                }
                else if (_area != 0.0)
                {
                    _area = value;
                    OnUpdate();
                }
            }
        }
        public int PublicUtilities
        {
            get { return _publicutilities; }
            set
            {
                _publicutilities = value;
                OnUpdate();
            }
        }


        public Apartments(string name, int floor, string owner, double area, int publicutilities)
        {
            _id = Guid.NewGuid();
            _name = name;
            _floor = floor;
            _owner = owner;
            _area = area;
            _publicutilities = publicutilities;
        }
        public void OnUpdate()
        {
            Guid id = Id;
        }
    }
}
