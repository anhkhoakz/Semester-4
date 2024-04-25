using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_Student
    {
        private string StudentID, fullname, hometown, dateofbirth;
        private float GPA;

        public DTO_Student(string StudentID, string fullname, string hometown, string dateofbirth, float GPA)
        {
            this.StudentID = StudentID;
            this.fullname = fullname;
            this.hometown = hometown;
            this.dateofbirth = dateofbirth;
            this. GPA = GPA;
        }

        public string _StudentID
        {
            get {
                return this._StudentID;
            }
            set
            {
                this._StudentID = value;
            }
        }

        public string _fullname
        {
            get
            {
                return this._fullname;
            }
            set
            {
                this._fullname = value; 
            }
        }

        public string _hometown
        {
            get
            {
                return this._hometown;
            }
            set { 
                this._hometown = value;
            }
        }

        public string _dateofbirth
        {
            get
            {
                return this._dateofbirth;
            }
            set
            {
                this._dateofbirth = value;
            }
        }

        public float _GPA
        {
            get
            {
                return this._GPA;
            }
            set {
                this._GPA = value; 
            }
        }
    }
}
