namespace AdventOfCode.Core.Day9; 
 
internal static partial class Day9 { 
 
    internal static class Part2 { 

        /// <summary>
        /// A --- B
        /// |     |
        /// |     |
        /// D --- C
        /// </summary>

         private readonly record struct Area {

            internal readonly long Base;
            internal readonly long Height;
            internal readonly long AreaValue;
            internal readonly long MinX;
            internal readonly long MaxX;
            internal readonly long MinY;
            internal readonly long MaxY;

            internal readonly (long x, long y) PointA;
            internal readonly (long x, long y) PointB;
            internal readonly (long x, long y) PointC;
            internal readonly (long x, long y) PointD;
            internal Area(long x1, long y1, long x2, long y2) {
           
                Base = Math.Abs(x1 - x2) + 1;
                Height = Math.Abs(y1 - y2) + 1;
                AreaValue = Base * Height;
                MinX = Math.Min(x1, x2);
                MaxX = Math.Max(x1, x2);
                MinY = Math.Min(y1, y2);
                MaxY = Math.Max(y1, y2);
                PointA = (MinX, MinY);
                PointB = (MinX, MaxY);
                PointC = (MaxX, MaxY);
                PointD = (MaxX, MinY);
            }

            internal bool IsCutByAnySegment(List<Segment> segments) {

                foreach(var segment in segments) {

                    if(segment.IsVertical) {

                        if(segment.From.y <= PointA.y || segment.From.y >= PointB.y) continue;
                        if(segment.To.x <= PointA.x || segment.From.x >= PointC.x) continue;

                        return true;
                    }

                    if(segment.From.x <= PointA.x || segment.From.x >= PointC.x) continue;
                    if(segment.To.y <= PointA.y || segment.From.y >= PointB.y) continue;

                    return true;

                }   

                return false;                
            }
        }

        private readonly record struct Segment {

            internal readonly (long x, long y) From;
            internal readonly (long x, long y) To;
            internal readonly long Length;
            internal readonly bool IsVertical;

            /// <summary>
            /// always from --> to 
            /// or 
            /// from
            /// |
            /// v
            /// to
            /// </summary>
            /// <param name="from"></param>
            /// <param name="to"></param>
            internal Segment((long x, long y) from, (long x, long y) to) {
                From = from;
                To = to;
                IsVertical = from.y == to.y;
                if(IsVertical && to.x < from.x) (From, To) = (To, From);
                else if (!IsVertical && to.y < from.y) (From, To) = (To, From);
                Length = IsVertical ? Math.Abs(from.x - to.x) : Math.Abs(from.y - to.y);
            }
        }


        internal static long FindLargestAreaInscripted(string rawText) {

            // X,Y inverted
            (long x, long y)[] redTiles = [.. rawText
            .Split(Environment.NewLine)
            .Select(l => l.Split(','))
            .Select(parts => (x: long.Parse(parts[1]), y: long.Parse(parts[0])))];

            int n = redTiles.Length;

            List<Segment> segments = [];

            for(int i = 0; i < n; i++){
                (long x, long y) from = redTiles[i];
                (long x, long y) to = redTiles[(i + 1) % n]; // circular

                Segment segment = new(from, to);
                segments.Add(segment);
            }
            
            PriorityQueue<Area, long> allPossibleAreas = new();
            for(int i = 0; i < n; i++){
               for(int j = i + 1; j < n; j++) {
                    Area area = new(redTiles[i].x, redTiles[i].y, redTiles[j].x, redTiles[j].y);
                    allPossibleAreas.Enqueue(area, -area.AreaValue);
                }
            }

            while(allPossibleAreas.Count > 0){

                Area area = allPossibleAreas.Dequeue();
                if(area.IsCutByAnySegment(segments)) continue;

                return area.AreaValue;
            }
           

            throw new Exception("No solution found.");
            
        } 
 
    } 
} 
