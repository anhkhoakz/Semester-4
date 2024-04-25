namespace DTO
{
    public class DTO_Project
    {
        private string SID, PID, internshipPlace;
        private int distance;
        private float result;

        public DTO_Project(string SID, string PID, string internshipPlace, int distance, float result)
        {
            this.SID = SID;
            this.PID = PID;
            this.internshipPlace = internshipPlace;
            this.distance = distance;
            this.result = result;
        }

        public string _SID
        {
            get { return _SID; }
            set { _SID = value; }
        }

        public string _PID
        {
            get { return _PID; }
            set { _PID = value; }
        }

        public string _INTERNSHIPPLACE
        {
            get { return _INTERNSHIPPLACE; }
            set { _INTERNSHIPPLACE = value; }
        }

        public int _DISTANCE
        {
            get { return _DISTANCE; }
            set { _DISTANCE = value; }
        }

        public float _RESULT
        {
            get { return _RESULT; }
            set { _RESULT = value; }
        }
    }
}
