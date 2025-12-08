using System.Diagnostics;

namespace AoC
{
    record Point ( Int64 x, Int64 y, Int64 z );
    record Dist ( Point p1, Point p2, double d );

    public static class Day08
    {
        private static double dist(Point point1, Point point2)
        {
            var dx = point1.x - point2.x;
            var dy = point1.y - point2.y;
            var dz = point1.z - point2.z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }


        public static Int64 Day08a(string[] input, int iter = 1000)
        {
            var boxes = new List<Point>();
            foreach (var i in input)
            {
                var coords = i.Split(',').Select(c => Int64.Parse(c)).ToList();
                boxes.Add(new Point(coords[0], coords[1], coords[2]));
            }

            var distances = new List<Dist>();
            for (var i = 0; i != boxes.Count - 1; ++i) {
                for (var j = i+1; j != boxes.Count; ++j) {
                    distances.Add(new Dist(boxes[i], boxes[j], dist(boxes[i], boxes[j])));
                }
            }
            distances.Sort((p1, p2) => { return p1.d.CompareTo(p2.d); });

            var circuts = new List<List<Point>>();
            foreach (var b in boxes)
            {
                circuts.Add(new List<Point>() { b });
            }

            while (iter > 0)
            {
                var toJoin = distances.First();
                distances.RemoveAt(0);

                var c1 = circuts.Find(l => l.Contains(toJoin.p1));
                var c2 = circuts.Find(l => l.Contains(toJoin.p2));
                if (c1 != c2 && c1 != null && c2 != null)
                {
                    c1.AddRange(c2);
                    circuts.Remove(c2);
                }

                iter--;
            }

            circuts.Sort((c1, c2) => { return c2.Count().CompareTo(c1.Count()); });


            return circuts[0].Count() * circuts[1].Count() * circuts[2].Count();
        }

        public static Int64 Day08b(string[] input)
        {
            return 0;
        }


        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Day08.txt");
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Day08a : {0}   Time: {1}", Day08a(lines), sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Day08b : {0}   Time: {1}", Day08b(lines), sw.ElapsedMilliseconds);
        }
    }
}
