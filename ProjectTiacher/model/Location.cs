namespace api_model
{
    public class Location

    {

        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LocationTo { get; set; }

��������//"city":�"Jerusalem",
��������//"startDate":�"2020.05.05�12:00:22",
��������//"endDate":�"2020.05.05�12:00:22",
��������//"location":�"central�station�

    }

    public class Skad
    {

        public Location Location { get; set; }
        public string misleStatrt { get; set; }



        //        o ����� ���
        //        o   ���� ���
        //o ���� ������ �� ������
        //o   ���� �� ������ ��� �����(�� �� ���)



    }
}