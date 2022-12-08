using System;
using System.Collections.Generic;
using UnityEngine;

namespace SMF
{
    public static class GJK2D
    {
        private enum EvolveResult
        {
            NoIntersection,
            FoundIntersection,
            StillEvolving
        }

        private static Vector2 TripleProduct(Vector2 a, Vector2 b, Vector2 c)
        {
            var A = new Vector3(a.x, a.y, 0);
            var B = new Vector3(b.x, b.y, 0);
            var C = new Vector3(c.x, c.y, 0);

            var first = Vector3.Cross(A, B);
            var second = Vector3.Cross(first, C);

            return new Vector2(second.x, second.y);
        }

        public static (bool colliding, int iterations) IsColliding(IConvexShape2D a, IConvexShape2D b)
        {
            List<Vector2> vertices = new List<Vector2>();
            Vector2 direction = Vector2.up;

            int iterations = 0;
            var result = EvolveResult.StillEvolving;
            while (result == EvolveResult.StillEvolving)
            {
                result = EvolveSimplex();
                iterations++;
            }
            return (result == EvolveResult.FoundIntersection, iterations);

            EvolveResult EvolveSimplex()
            {
                switch (vertices.Count)
                {
                    case 0:
                        {
                            direction = Vector2.up;
                            break;
                        }
                    case 1:
                        {
                            // flip the direction
                            direction *= -1;
                            break;
                        }
                    case 2:
                        {
                            var b = vertices[1];
                            var c = vertices[0];

                            // line cb is the line formed by the first two vertices
                            var cb = b - c;
                            // line c0 is the line from the first vertex to the origin
                            var c0 = c * -1;

                            // use the triple-cross-product to calculate a direction perpendicular
                            // to line cb in the direction of the origin
                            direction = TripleProduct(cb, c0, cb);
                            break;
                        }
                    case 3:
                        {
                            // calculate if the simplex contains the origin
                            var a = vertices[2];
                            var b = vertices[1];
                            var c = vertices[0];

                            var a0 = a * -1; // v2 to the origin
                            var ab = b - a; // v2 to v1
                            var ac = c - a; // v2 to v0

                            var abPerp = TripleProduct(ac, ab, ab);
                            var acPerp = TripleProduct(ab, ac, ac);

                            if (Vector2.Dot(abPerp, a0) > 0.0f)
                            {
                                // the origin is outside line ab
                                // get rid of c and add a new support in the direction of abPerp
                                vertices.Remove(c);
                                direction = abPerp;
                            }
                            else if (Vector2.Dot(acPerp, a0) > 0.0f)
                            {
                                // the origin is outside line ac
                                // get rid of b and add a new support in the direction of acPerp
                                vertices.Remove(b);
                                direction = acPerp;
                            }
                            else
                            {
                                // the origin is inside both ab and ac,
                                // so it must be inside the triangle!
                                return EvolveResult.FoundIntersection;
                            }

                            break;
                        }
                    default: throw new Exception($"Can\'t have simplex with {vertices.Count} verts!");
                }

                var newVertex = a.SupportPoint(direction) - b.SupportPoint(-1 * direction);
                vertices.Add(newVertex);

                return Vector2.Dot(direction, newVertex) >= 0.0f - Mathf.Epsilon
                    ? EvolveResult.StillEvolving
                    : EvolveResult.NoIntersection;
            }
        }
    }
}
