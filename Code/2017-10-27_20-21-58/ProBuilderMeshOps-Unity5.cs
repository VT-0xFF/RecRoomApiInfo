using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using KdTree;
using KdTree.Math;
using Poly2Tri;
using ProBuilder2.Common;
using UnityEngine;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace ProBuilder2.MeshOperations
{
	public static class pbMeshOps
	{
		public static void CenterPivot(this pb_Object pb, int[] indices)
		{
			Vector3 vector = Vector3.zero;
			if (indices != null && indices.Length > 0)
			{
				Vector3[] array = pb.VerticesInWorldSpace(indices);
				Vector3[] array2 = array;
				foreach (Vector3 vector2 in array2)
				{
					vector += vector2;
				}
				vector /= (float)array.Length;
			}
			else
			{
				vector = pb.transform.TransformPoint(pb.msh.bounds.center);
			}
			Vector3 offset = pb.transform.position - vector;
			pb.transform.position = vector;
			pb.ToMesh();
			pb.TranslateVertices_World(pb.msh.triangles, offset);
			pb.Refresh();
		}

		public static void CenterPivot(this pb_Object pb, Vector3 worldPosition)
		{
			Vector3 offset = pb.transform.position - worldPosition;
			pb.transform.position = worldPosition;
			pb.ToMesh();
			pb.TranslateVertices_World(pb.msh.triangles, offset);
			pb.Refresh();
		}

		public static void FreezeScaleTransform(this pb_Object pb)
		{
			Vector3[] vertices = pb.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				ref Vector3 reference = ref vertices[i];
				reference = Vector3.Scale(vertices[i], pb.transform.localScale);
			}
			pb.SetVertices(vertices);
			pb.transform.localScale = new Vector3(1f, 1f, 1f);
		}

		[Obsolete("Please use `bool Extrude(this pb_Object pb, pb_Face[] faces, ExtrudeMethod method, float distance)`")]
		public static bool Extrude(this pb_Object pb, pb_Face[] faces, float extrudeDistance)
		{
			pb_Face[] appendedFaces;
			return pb.Extrude(faces, extrudeDistance, extrudeAsGroup: true, out appendedFaces);
		}

		[Obsolete("Please use `bool Extrude(this pb_Object pb, pb_Face[] faces, ExtrudeMethod method, float distance)`")]
		public static bool Extrude(this pb_Object pb, pb_Face[] faces, float extrudeDistance, bool extrudeAsGroup, out pb_Face[] appendedFaces)
		{
			return pb.Extrude(faces, extrudeAsGroup ? ExtrudeMethod.VertexNormal : ExtrudeMethod.IndividualFaces, extrudeDistance, out appendedFaces);
		}

		[Obsolete("Please use `bool Extrude(this pb_Object pb, pb_Face[] faces, ExtrudeMethod method, float distance)`")]
		public static bool Extrude(this pb_Object pb, pb_Face[] faces, ExtrudeMethod method, float extrudeDistance, out pb_Face[] appendedFaces)
		{
			appendedFaces = null;
			if (faces == null || faces.Length < 1)
			{
				return false;
			}
			pb_IntArray[] sharedIndices = pb.GetSharedIndices();
			Dictionary<int, int> dictionary = sharedIndices.ToDictionary();
			int vertexCount = pb.vertexCount;
			Vector3[] vertices = pb.vertices;
			bool flag = method != ExtrudeMethod.IndividualFaces;
			pb_Edge[][] array = ((!flag) ? faces.Select((pb_Face pb_Face6) => pb_Face6.edges).ToArray() : new pb_Edge[1][] { pbMeshUtils.GetPerimeterEdges(dictionary, faces).ToArray() });
			if (array == null || array.Length < 1 || (flag && array[0].Length < 3))
			{
				Debug.LogWarning("No perimeter edges found.  Try deselecting and reselecting this object and trying again.");
				return false;
			}
			pb_Face[][] array2 = new pb_Face[array.Length][];
			int[][] array3 = new int[array.Length][];
			int num = 0;
			for (int num2 = 0; num2 < array.Length; num2++)
			{
				num = 0;
				array3[num2] = new int[array[num2].Length * 2];
				array2[num2] = new pb_Face[array[num2].Length];
				for (int num3 = 0; num3 < array[num2].Length; num3++)
				{
					foreach (pb_Face pb_Face in faces)
					{
						if (pb_Face.edges.Contains(array[num2][num3]))
						{
							array2[num2][num3] = pb_Face;
							break;
						}
					}
					array3[num2][num++] = array[num2][num3].x;
					array3[num2][num++] = array[num2][num3].y;
				}
			}
			List<pb_Edge>[] array4 = new List<pb_Edge>[array.Length];
			Vector3[] normals = pb.msh.normals;
			Vector3[] array5 = new Vector3[vertexCount];
			List<Vector3[]> list = new List<Vector3[]>();
			List<Color[]> list2 = new List<Color[]>();
			List<Vector2[]> list3 = new List<Vector2[]>();
			List<pb_Face> list4 = new List<pb_Face>();
			List<int[]> list5 = new List<int[]>();
			for (int num5 = 0; num5 < array.Length; num5++)
			{
				array4[num5] = new List<pb_Edge>();
				for (int num6 = 0; num6 < array[num5].Length; num6++)
				{
					pb_Edge pb_Edge = array[num5][num6];
					pb_Face pb_Face2 = array2[num5][num6];
					Vector3 vector = pb_Math.Normal(pb, pb_Face2);
					Vector3 to = Vector3.zero;
					Vector3 to2 = Vector3.zero;
					if (Mathf.Abs(extrudeDistance) > Mathf.Epsilon)
					{
						if (!flag)
						{
							to = vector;
							to2 = vector;
						}
						else
						{
							to = Norm(sharedIndices[dictionary[pb_Edge.x]], array3[num5], normals);
							to2 = Norm(sharedIndices[dictionary[pb_Edge.y]], array3[num5], normals);
						}
					}
					int num7 = dictionary[pb_Edge.x];
					int num8 = dictionary[pb_Edge.y];
					float num9 = extrudeDistance;
					float num10 = extrudeDistance;
					if (method == ExtrudeMethod.FaceNormal)
					{
						num9 = pb_Math.Secant(Vector3.Angle(vector, to) * ((float)Math.PI / 180f)) * extrudeDistance;
						num10 = pb_Math.Secant(Vector3.Angle(vector, to2) * ((float)Math.PI / 180f)) * extrudeDistance;
					}
					ref Vector3 reference = ref array5[pb_Edge.x];
					reference = to.normalized * num9;
					ref Vector3 reference2 = ref array5[pb_Edge.y];
					reference2 = to2.normalized * num10;
					list.Add(new Vector3[4]
					{
						vertices[pb_Edge.x],
						vertices[pb_Edge.y],
						vertices[pb_Edge.x] + array5[pb_Edge.x],
						vertices[pb_Edge.y] + array5[pb_Edge.y]
					});
					list2.Add(new Color[4]
					{
						pb.colors[pb_Edge.x],
						pb.colors[pb_Edge.y],
						pb.colors[pb_Edge.x],
						pb.colors[pb_Edge.y]
					});
					list3.Add(new Vector2[4]);
					list4.Add(new pb_Face(new int[6] { 0, 1, 2, 1, 3, 2 }, pb_Face2.material, new pb_UV(pb_Face2.uv), pb_Face2.smoothingGroup, -1, -1, manualUV: false));
					list5.Add(new int[4] { num7, num8, -1, -1 });
					array4[num5].Add(new pb_Edge(num7, -1));
					array4[num5].Add(new pb_Edge(num8, -1));
				}
			}
			appendedFaces = pb.AppendFaces(list.ToArray(), list2.ToArray(), list3.ToArray(), list4.ToArray(), list5.ToArray());
			int num11 = 0;
			int num12 = 0;
			for (; num11 < array4.Length; num11++)
			{
				for (int num13 = 0; num13 < array4[num11].Count; num13 += 2)
				{
					array4[num11][num13].y = appendedFaces[num12].indices[2];
					array4[num11][num13 + 1].y = appendedFaces[num12++].indices[4];
				}
			}
			pb_IntArray[] sharedIndices2 = pb.sharedIndices;
			Dictionary<int, int> dictionary2 = sharedIndices2.ToDictionary();
			for (int num14 = 0; num14 < array4.Length; num14++)
			{
				for (int num15 = 0; num15 < array4[num14].Count - 1; num15++)
				{
					int x = array4[num14][num15].x;
					for (int num16 = num15 + 1; num16 < array4[num14].Count; num16++)
					{
						if (array4[num14][num16].x == x)
						{
							dictionary2[array4[num14][num15].y] = dictionary2[array4[num14][num16].y];
							break;
						}
					}
				}
			}
			vertices = pb.vertices;
			foreach (pb_Face pb_Face3 in faces)
			{
				pb_Face3.smoothingGroup = -1;
				pb_Face3.textureGroup = -1;
			}
			if (flag)
			{
				foreach (pb_Face pb_Face4 in faces)
				{
					int[] distinctIndices = pb_Face4.distinctIndices;
					int[] array6 = distinctIndices;
					foreach (int num20 in array6)
					{
						int num21 = sharedIndices2.IndexOf(num20);
						for (int num22 = 0; num22 < array3.Length; num22++)
						{
							for (int num23 = 0; num23 < array4[num22].Count; num23++)
							{
								if (num21 == array4[num22][num23].x)
								{
									dictionary2[num20] = dictionary2[array4[num22][num23].y];
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				for (int num24 = 0; num24 < array2.Length; num24++)
				{
					int[] array7 = pb_Face.AllTrianglesDistinct(array2[num24]);
					foreach (int key in array7)
					{
						int old_si_index = dictionary[key];
						int num26 = array4[num24].FindIndex((pb_Edge pb_Edge2) => pb_Edge2.x == old_si_index);
						if (num26 >= 0)
						{
							int y = array4[num24][num26].y;
							if (dictionary2.ContainsKey(y))
							{
								dictionary2[key] = dictionary2[y];
							}
						}
					}
				}
			}
			sharedIndices2 = dictionary2.ToSharedIndices();
			pb.SplitUVs(pb_Face.AllTriangles(faces));
			int[] all = pb_Face.AllTrianglesDistinct(faces);
			float num27 = extrudeDistance;
			foreach (pb_Face pb_Face5 in faces)
			{
				Vector3 vector2 = pb_Math.Normal(vertices[pb_Face5.indices[0]], vertices[pb_Face5.indices[1]], vertices[pb_Face5.indices[2]]);
				Vector3 to3 = ((!flag) ? vector2 : Vector3.zero);
				int[] distinctIndices2 = pb_Face5.distinctIndices;
				foreach (int num30 in distinctIndices2)
				{
					if (flag)
					{
						to3 = Norm(sharedIndices[dictionary[num30]], all, normals);
						if (method == ExtrudeMethod.FaceNormal)
						{
							num27 = pb_Math.Secant(Vector3.Angle(vector2, to3) * ((float)Math.PI / 180f)) * extrudeDistance;
						}
					}
					vertices[num30] += to3.normalized * num27;
				}
			}
			pb.SetSharedIndices(sharedIndices2);
			pb.SetVertices(vertices);
			List<pb_Face> list6 = new List<pb_Face>(appendedFaces);
			list6.AddRange(faces);
			HashSet<pb_Face> hashSet = new HashSet<pb_Face>(faces);
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb, list6);
			foreach (pb_WingedEdge item in wingedEdges)
			{
				if (!hashSet.Contains(item.face))
				{
					continue;
				}
				hashSet.Remove(item.face);
				foreach (pb_WingedEdge item2 in item)
				{
					pb_ConformNormals.ConformOppositeNormal(item2);
				}
			}
			return true;
		}

		private static Vector3 Norm(int[] shared, int[] all, Vector3[] norm)
		{
			Vector3 zero = Vector3.zero;
			int num = 0;
			for (int i = 0; i < all.Length; i++)
			{
				if (Array.IndexOf(shared, all[i]) > -1)
				{
					zero += norm[all[i]];
					num++;
				}
			}
			return zero / num;
		}

		public static bool Extrude(this pb_Object pb, pb_Edge[] edges, float extrudeDistance, bool extrudeAsGroup, bool enableManifoldExtrude, out pb_Edge[] extrudedEdges)
		{
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			Dictionary<int, int> dictionary = sharedIndices.ToDictionary();
			List<pb_Edge> list = new List<pb_Edge>();
			List<pb_Face> list2 = new List<pb_Face>();
			foreach (pb_Edge pb_Edge in edges)
			{
				int num = 0;
				pb_Face item = null;
				pb_Face[] faces = pb.faces;
				foreach (pb_Face pb_Face in faces)
				{
					if (pb_Face.edges.IndexOf(pb_Edge, dictionary) > -1)
					{
						item = pb_Face;
						if (++num > 1)
						{
							break;
						}
					}
				}
				if (enableManifoldExtrude || num < 2)
				{
					list.Add(pb_Edge);
					list2.Add(item);
				}
			}
			if (list.Count < 1)
			{
				extrudedEdges = null;
				return false;
			}
			Vector3[] vertices = pb.vertices;
			Vector3[] normals = pb.msh.normals;
			int[] array = new int[list.Count * 2];
			int num2 = 0;
			for (int k = 0; k < list.Count; k++)
			{
				array[num2++] = list[k].x;
				array[num2++] = list[k].y;
			}
			List<pb_Edge> list3 = new List<pb_Edge>();
			List<pb_Edge> list4 = new List<pb_Edge>();
			for (int l = 0; l < list.Count; l++)
			{
				pb_Edge pb_Edge2 = list[l];
				pb_Face pb_Face2 = list2[l];
				Vector3 vector = ((!extrudeAsGroup) ? pb_Math.Normal(pb, pb_Face2) : Norm(sharedIndices[dictionary[pb_Edge2.x]], array, normals));
				Vector3 vector2 = ((!extrudeAsGroup) ? pb_Math.Normal(pb, pb_Face2) : Norm(sharedIndices[dictionary[pb_Edge2.y]], array, normals));
				int num3 = dictionary[pb_Edge2.x];
				int num4 = dictionary[pb_Edge2.y];
				pb_Face pb_Face3 = pb.AppendFace(new Vector3[4]
				{
					vertices[pb_Edge2.x],
					vertices[pb_Edge2.y],
					vertices[pb_Edge2.x] + vector.normalized * extrudeDistance,
					vertices[pb_Edge2.y] + vector2.normalized * extrudeDistance
				}, new Color[4]
				{
					pb.colors[pb_Edge2.x],
					pb.colors[pb_Edge2.y],
					pb.colors[pb_Edge2.x],
					pb.colors[pb_Edge2.y]
				}, new Vector2[4], new pb_Face(new int[6] { 2, 1, 0, 2, 3, 1 }, pb_Face2.material, new pb_UV(), 0, -1, -1, manualUV: false), new int[4] { num3, num4, -1, -1 });
				list4.Add(new pb_Edge(pb_Face3.indices[3], pb_Face3.indices[4]));
				list3.Add(new pb_Edge(num3, pb_Face3.indices[3]));
				list3.Add(new pb_Edge(num4, pb_Face3.indices[4]));
			}
			sharedIndices = pb.sharedIndices;
			if (extrudeAsGroup)
			{
				for (int m = 0; m < list3.Count; m++)
				{
					int x = list3[m].x;
					for (int n = 0; n < list3.Count; n++)
					{
						if (n != m && list3[n].x == x)
						{
							pb_IntArrayUtility.MergeSharedIndices(ref sharedIndices, list3[n].y, list3[m].y);
							break;
						}
					}
				}
			}
			pb.SetSharedIndices(sharedIndices);
			pb_Face[] faces2 = pb.faces;
			foreach (pb_Face pb_Face4 in faces2)
			{
				pb_Face4.RebuildCaches();
			}
			extrudedEdges = list4.ToArray();
			return true;
		}

		public static List<pb_Face> DetachFaces(this pb_Object pb, IEnumerable<pb_Face> faces)
		{
			List<pb_Vertex> list = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			int num = pb.sharedIndices.Length;
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			List<pb_FaceRebuildData> list2 = new List<pb_FaceRebuildData>();
			foreach (pb_Face face in faces)
			{
				pb_FaceRebuildData pb_FaceRebuildData = new pb_FaceRebuildData();
				pb_FaceRebuildData.vertices = new List<pb_Vertex>();
				pb_FaceRebuildData.sharedIndices = new List<int>();
				pb_FaceRebuildData.face = new pb_Face(face);
				Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
				int[] array = new int[face.indices.Length];
				for (int i = 0; i < face.indices.Length; i++)
				{
					if (dictionary2.TryGetValue(face.indices[i], out var value))
					{
						array[i] = value;
						continue;
					}
					value = (array[i] = pb_FaceRebuildData.vertices.Count);
					dictionary2.Add(face.indices[i], value);
					pb_FaceRebuildData.vertices.Add(list[face.indices[i]]);
					pb_FaceRebuildData.sharedIndices.Add(dictionary[face.indices[i]] + num);
				}
				pb_FaceRebuildData.face.SetIndices(array.ToArray());
				list2.Add(pb_FaceRebuildData);
			}
			pb_FaceRebuildData.Apply(list2, pb, list, null, dictionary);
			pb.DeleteFaces(faces);
			pb.ToMesh();
			return list2.Select((pb_FaceRebuildData x) => x.face).ToList();
		}

		public static bool Bridge(this pb_Object pb, pb_Edge a, pb_Edge b, bool enforcePerimiterEdgesOnly = false)
		{
			pb_IntArray[] sharedIndices = pb.GetSharedIndices();
			Dictionary<int, int> lookup = sharedIndices.ToDictionary();
			if (enforcePerimiterEdgesOnly && (pbMeshUtils.GetNeighborFaces(pb, a).Count > 1 || pbMeshUtils.GetNeighborFaces(pb, b).Count > 1))
			{
				return false;
			}
			pb_Face[] faces = pb.faces;
			foreach (pb_Face pb_Face in faces)
			{
				if (pb_Face.edges.IndexOf(a, lookup) >= 0 && pb_Face.edges.IndexOf(b, lookup) >= 0)
				{
					Debug.LogWarning("Face already exists between these two edges!");
					return false;
				}
			}
			Vector3[] vertices = pb.vertices;
			pb_UV u = new pb_UV();
			Material m = pb_Constant.DefaultMaterial;
			pb_Tuple<pb_Face, pb_Edge> validEdge = null;
			if (!pb_Edge.ValidateEdge(pb, a, out validEdge))
			{
				pb_Edge.ValidateEdge(pb, b, out validEdge);
			}
			if (validEdge != null)
			{
				u = new pb_UV(validEdge.Item1.uv);
				m = validEdge.Item1.material;
			}
			Vector3[] array;
			Color[] array2;
			int[] array3;
			if (a.Contains(b.x, sharedIndices) || a.Contains(b.y, sharedIndices))
			{
				array = new Vector3[3];
				array2 = new Color[3];
				array3 = new int[3];
				bool flag = Array.IndexOf(sharedIndices[sharedIndices.IndexOf(a.x)], b.x) > -1;
				bool flag2 = Array.IndexOf(sharedIndices[sharedIndices.IndexOf(a.x)], b.y) > -1;
				bool flag3 = Array.IndexOf(sharedIndices[sharedIndices.IndexOf(a.y)], b.x) > -1;
				bool flag4 = Array.IndexOf(sharedIndices[sharedIndices.IndexOf(a.y)], b.y) > -1;
				if (flag)
				{
					ref Vector3 reference = ref array[0];
					reference = vertices[a.x];
					ref Color reference2 = ref array2[0];
					reference2 = pb.colors[a.x];
					array3[0] = sharedIndices.IndexOf(a.x);
					ref Vector3 reference3 = ref array[1];
					reference3 = vertices[a.y];
					ref Color reference4 = ref array2[1];
					reference4 = pb.colors[a.y];
					array3[1] = sharedIndices.IndexOf(a.y);
					ref Vector3 reference5 = ref array[2];
					reference5 = vertices[b.y];
					ref Color reference6 = ref array2[2];
					reference6 = pb.colors[b.y];
					array3[2] = sharedIndices.IndexOf(b.y);
				}
				else if (flag2)
				{
					ref Vector3 reference7 = ref array[0];
					reference7 = vertices[a.x];
					ref Color reference8 = ref array2[0];
					reference8 = pb.colors[a.x];
					array3[0] = sharedIndices.IndexOf(a.x);
					ref Vector3 reference9 = ref array[1];
					reference9 = vertices[a.y];
					ref Color reference10 = ref array2[1];
					reference10 = pb.colors[a.y];
					array3[1] = sharedIndices.IndexOf(a.y);
					ref Vector3 reference11 = ref array[2];
					reference11 = vertices[b.x];
					ref Color reference12 = ref array2[2];
					reference12 = pb.colors[b.x];
					array3[2] = sharedIndices.IndexOf(b.x);
				}
				else if (flag3)
				{
					ref Vector3 reference13 = ref array[0];
					reference13 = vertices[a.y];
					ref Color reference14 = ref array2[0];
					reference14 = pb.colors[a.y];
					array3[0] = sharedIndices.IndexOf(a.y);
					ref Vector3 reference15 = ref array[1];
					reference15 = vertices[a.x];
					ref Color reference16 = ref array2[1];
					reference16 = pb.colors[a.x];
					array3[1] = sharedIndices.IndexOf(a.x);
					ref Vector3 reference17 = ref array[2];
					reference17 = vertices[b.y];
					ref Color reference18 = ref array2[2];
					reference18 = pb.colors[b.y];
					array3[2] = sharedIndices.IndexOf(b.y);
				}
				else if (flag4)
				{
					ref Vector3 reference19 = ref array[0];
					reference19 = vertices[a.y];
					ref Color reference20 = ref array2[0];
					reference20 = pb.colors[a.y];
					array3[0] = sharedIndices.IndexOf(a.y);
					ref Vector3 reference21 = ref array[1];
					reference21 = vertices[a.x];
					ref Color reference22 = ref array2[1];
					reference22 = pb.colors[a.x];
					array3[1] = sharedIndices.IndexOf(a.x);
					ref Vector3 reference23 = ref array[2];
					reference23 = vertices[b.x];
					ref Color reference24 = ref array2[2];
					reference24 = pb.colors[b.x];
					array3[2] = sharedIndices.IndexOf(b.x);
				}
				pb.AppendFace(array, array2, new Vector2[array.Length], new pb_Face((flag || flag2) ? new int[3] { 2, 1, 0 } : new int[3] { 0, 1, 2 }, m, u, 0, -1, -1, manualUV: false), array3);
				return true;
			}
			array = new Vector3[4];
			array2 = new Color[4];
			array3 = new int[4];
			ref Vector3 reference25 = ref array[0];
			reference25 = vertices[a.x];
			ref Color reference26 = ref array2[0];
			reference26 = pb.colors[a.x];
			array3[0] = sharedIndices.IndexOf(a.x);
			ref Vector3 reference27 = ref array[1];
			reference27 = vertices[a.y];
			ref Color reference28 = ref array2[1];
			reference28 = pb.colors[a.y];
			array3[1] = sharedIndices.IndexOf(a.y);
			Vector3 normalized = Vector3.Cross(vertices[b.x] - vertices[a.x], vertices[a.y] - vertices[a.x]).normalized;
			Vector2[] array4 = pb_Projection.PlanarProject(new Vector3[4]
			{
				vertices[a.x],
				vertices[a.y],
				vertices[b.x],
				vertices[b.y]
			}, normalized);
			Vector2 intersect = Vector2.zero;
			if (!pb_Math.GetLineSegmentIntersect(array4[0], array4[2], array4[1], array4[3], ref intersect))
			{
				ref Vector3 reference29 = ref array[2];
				reference29 = vertices[b.x];
				ref Color reference30 = ref array2[2];
				reference30 = pb.colors[b.x];
				array3[2] = sharedIndices.IndexOf(b.x);
				ref Vector3 reference31 = ref array[3];
				reference31 = vertices[b.y];
				ref Color reference32 = ref array2[3];
				reference32 = pb.colors[b.y];
				array3[3] = sharedIndices.IndexOf(b.y);
			}
			else
			{
				ref Vector3 reference33 = ref array[2];
				reference33 = vertices[b.y];
				ref Color reference34 = ref array2[2];
				reference34 = pb.colors[b.y];
				array3[2] = sharedIndices.IndexOf(b.y);
				ref Vector3 reference35 = ref array[3];
				reference35 = vertices[b.x];
				ref Color reference36 = ref array2[3];
				reference36 = pb.colors[b.x];
				array3[3] = sharedIndices.IndexOf(b.x);
			}
			pb.AppendFace(array, array2, new Vector2[array.Length], new pb_Face(new int[6] { 2, 1, 0, 2, 3, 1 }, m, u, 0, -1, -1, manualUV: false), array3);
			return true;
		}

		public static bool CombineObjects(pb_Object[] pbs, out pb_Object combined)
		{
			combined = null;
			if (pbs.Length < 1)
			{
				return false;
			}
			List<Vector3> list = new List<Vector3>();
			List<Vector2> list2 = new List<Vector2>();
			List<Color> list3 = new List<Color>();
			List<pb_Face> list4 = new List<pb_Face>();
			List<pb_IntArray> list5 = new List<pb_IntArray>();
			List<pb_IntArray> list6 = new List<pb_IntArray>();
			foreach (pb_Object pb_Object in pbs)
			{
				int count = list.Count;
				list.AddRange(pb_Object.VerticesInWorldSpace());
				list2.AddRange(pb_Object.uv);
				list3.AddRange(pb_Object.colors);
				pb_Face[] array = new pb_Face[pb_Object.faces.Length];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = new pb_Face(pb_Object.faces[j]);
					array[j].manualUV = true;
					array[j].ShiftIndices(count);
					array[j].RebuildCaches();
				}
				list4.AddRange(array);
				pb_IntArray[] sharedIndices = pb_Object.GetSharedIndices();
				for (int k = 0; k < sharedIndices.Length; k++)
				{
					for (int l = 0; l < sharedIndices[k].Length; l++)
					{
						sharedIndices[k][l] += count;
					}
				}
				list5.AddRange(sharedIndices);
				pb_IntArray[] sharedIndicesUV = pb_Object.GetSharedIndicesUV();
				for (int m = 0; m < sharedIndicesUV.Length; m++)
				{
					for (int n = 0; n < sharedIndicesUV[m].Length; n++)
					{
						sharedIndicesUV[m][n] += count;
					}
				}
				list6.AddRange(sharedIndicesUV);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(pbs[0].gameObject);
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.identity;
			gameObject.transform.localScale = Vector3.one;
			foreach (Transform item in gameObject.transform)
			{
				UnityEngine.Object.DestroyImmediate(item.gameObject);
			}
			if ((bool)gameObject.GetComponent<pb_Object>())
			{
				UnityEngine.Object.DestroyImmediate(gameObject.GetComponent<pb_Object>());
			}
			if ((bool)gameObject.GetComponent<pb_Entity>())
			{
				UnityEngine.Object.DestroyImmediate(gameObject.GetComponent<pb_Entity>());
			}
			combined = gameObject.AddComponent<pb_Object>();
			combined.SetVertices(list.ToArray());
			combined.SetUV(list2.ToArray());
			combined.SetColors(list3.ToArray());
			combined.SetFaces(list4.ToArray());
			combined.SetSharedIndices(list5.ToArray() ?? pb_IntArrayUtility.ExtractSharedIndices(list.ToArray()));
			combined.SetSharedIndicesUV(list6.ToArray() ?? new pb_IntArray[0]);
			combined.ToMesh();
			combined.GetComponent<pb_Entity>().SetEntity(pbs[0].GetComponent<pb_Entity>().entityType);
			combined.CenterPivot(pbs[0].transform.position);
			combined.Refresh();
			foreach (pb_Object pb_Object2 in pbs)
			{
				pb_Object2.Verify();
			}
			return true;
		}

		public static pb_Object CreatePbObjectWithTransform(Transform t, bool preserveFaces)
		{
			Mesh sharedMesh = t.GetComponent<MeshFilter>().sharedMesh;
			Vector3[] meshAttribute = pb_MeshUtility.GetMeshAttribute(t.gameObject, (Mesh x) => x.vertices);
			Color[] meshAttribute2 = pb_MeshUtility.GetMeshAttribute(t.gameObject, (Mesh x) => x.colors);
			Vector2[] meshAttribute3 = pb_MeshUtility.GetMeshAttribute(t.gameObject, (Mesh x) => x.uv);
			List<Vector3> list = ((!preserveFaces) ? new List<Vector3>() : new List<Vector3>(sharedMesh.vertices));
			List<Color> list2 = ((!preserveFaces) ? new List<Color>() : new List<Color>(sharedMesh.colors));
			List<Vector2> list3 = ((!preserveFaces) ? new List<Vector2>() : new List<Vector2>(sharedMesh.uv));
			List<pb_Face> list4 = new List<pb_Face>();
			for (int num = 0; num < sharedMesh.subMeshCount; num++)
			{
				int[] triangles = sharedMesh.GetTriangles(num);
				for (int num2 = 0; num2 < triangles.Length; num2 += 3)
				{
					int num3 = -1;
					if (preserveFaces)
					{
						for (int num4 = 0; num4 < list4.Count; num4++)
						{
							if (list4[num4].distinctIndices.Contains(triangles[num2]) || list4[num4].distinctIndices.Contains(triangles[num2 + 1]) || list4[num4].distinctIndices.Contains(triangles[num2 + 2]))
							{
								num3 = num4;
								break;
							}
						}
					}
					if (num3 > -1 && preserveFaces)
					{
						int num5 = list4[num3].indices.Length;
						int[] array = new int[num5 + 3];
						Array.Copy(list4[num3].indices, 0, array, 0, num5);
						array[num5] = triangles[num2];
						array[num5 + 1] = triangles[num2 + 1];
						array[num5 + 2] = triangles[num2 + 2];
						list4[num3].SetIndices(array);
						list4[num3].RebuildCaches();
						continue;
					}
					int[] i;
					if (preserveFaces)
					{
						i = new int[3]
						{
							triangles[num2],
							triangles[num2 + 1],
							triangles[num2 + 2]
						};
					}
					else
					{
						list.Add(meshAttribute[triangles[num2]]);
						list.Add(meshAttribute[triangles[num2 + 1]]);
						list.Add(meshAttribute[triangles[num2 + 2]]);
						list2.Add((meshAttribute2 == null) ? Color.white : meshAttribute2[triangles[num2]]);
						list2.Add((meshAttribute2 == null) ? Color.white : meshAttribute2[triangles[num2 + 1]]);
						list2.Add((meshAttribute2 == null) ? Color.white : meshAttribute2[triangles[num2 + 2]]);
						list3.Add(meshAttribute3[triangles[num2]]);
						list3.Add(meshAttribute3[triangles[num2 + 1]]);
						list3.Add(meshAttribute3[triangles[num2 + 2]]);
						i = new int[3]
						{
							num2,
							num2 + 1,
							num2 + 2
						};
					}
					list4.Add(new pb_Face(i, t.GetComponent<MeshRenderer>().sharedMaterials[num], new pb_UV(), 0, -1, -1, manualUV: true));
				}
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(t.gameObject);
			gameObject.GetComponent<MeshFilter>().sharedMesh = null;
			pb_Object pb_Object = gameObject.AddComponent<pb_Object>();
			pb_Object.GeometryWithVerticesFaces(list.ToArray(), list4.ToArray());
			pb_Object.SetColors(list2.ToArray());
			pb_Object.SetUV(list3.ToArray());
			pb_Object.gameObject.name = t.name;
			gameObject.transform.position = t.position;
			gameObject.transform.localRotation = t.localRotation;
			gameObject.transform.localScale = t.localScale;
			pb_Object.CenterPivot(null);
			return pb_Object;
		}

		public static bool ResetPbObjectWithMeshFilter(pb_Object pb, bool preserveFaces)
		{
			MeshFilter component = pb.gameObject.GetComponent<MeshFilter>();
			if (component == null || component.sharedMesh == null)
			{
				pb_Log.Error(pb.name + " does not have a mesh or Mesh Filter component.");
				return false;
			}
			Mesh sharedMesh = component.sharedMesh;
			int vertexCount = sharedMesh.vertexCount;
			Vector3[] meshAttribute = pb_MeshUtility.GetMeshAttribute(pb.gameObject, (Mesh x) => x.vertices);
			Color[] meshAttribute2 = pb_MeshUtility.GetMeshAttribute(pb.gameObject, (Mesh x) => x.colors);
			Vector2[] meshAttribute3 = pb_MeshUtility.GetMeshAttribute(pb.gameObject, (Mesh x) => x.uv);
			List<Vector3> list = ((!preserveFaces) ? new List<Vector3>() : new List<Vector3>(sharedMesh.vertices));
			List<Color> list2 = ((!preserveFaces) ? new List<Color>() : new List<Color>(sharedMesh.colors));
			List<Vector2> list3 = ((!preserveFaces) ? new List<Vector2>() : new List<Vector2>(sharedMesh.uv));
			List<pb_Face> list4 = new List<pb_Face>();
			MeshRenderer meshRenderer = pb.gameObject.GetComponent<MeshRenderer>();
			if (meshRenderer == null)
			{
				meshRenderer = pb.gameObject.AddComponent<MeshRenderer>();
			}
			Material[] sharedMaterials = meshRenderer.sharedMaterials;
			int num = sharedMaterials.Length;
			for (int num2 = 0; num2 < sharedMesh.subMeshCount; num2++)
			{
				int[] triangles = sharedMesh.GetTriangles(num2);
				for (int num3 = 0; num3 < triangles.Length; num3 += 3)
				{
					int num4 = -1;
					if (preserveFaces)
					{
						for (int num5 = 0; num5 < list4.Count; num5++)
						{
							if (list4[num5].distinctIndices.Contains(triangles[num3]) || list4[num5].distinctIndices.Contains(triangles[num3 + 1]) || list4[num5].distinctIndices.Contains(triangles[num3 + 2]))
							{
								num4 = num5;
								break;
							}
						}
					}
					if (num4 > -1 && preserveFaces)
					{
						int num6 = list4[num4].indices.Length;
						int[] array = new int[num6 + 3];
						Array.Copy(list4[num4].indices, 0, array, 0, num6);
						array[num6] = triangles[num3];
						array[num6 + 1] = triangles[num3 + 1];
						array[num6 + 2] = triangles[num3 + 2];
						list4[num4].SetIndices(array);
						list4[num4].RebuildCaches();
						continue;
					}
					int[] i;
					if (preserveFaces)
					{
						i = new int[3]
						{
							triangles[num3],
							triangles[num3 + 1],
							triangles[num3 + 2]
						};
					}
					else
					{
						list.Add(meshAttribute[triangles[num3]]);
						list.Add(meshAttribute[triangles[num3 + 1]]);
						list.Add(meshAttribute[triangles[num3 + 2]]);
						list2.Add((meshAttribute2 == null || meshAttribute2.Length != vertexCount) ? Color.white : meshAttribute2[triangles[num3]]);
						list2.Add((meshAttribute2 == null || meshAttribute2.Length != vertexCount) ? Color.white : meshAttribute2[triangles[num3 + 1]]);
						list2.Add((meshAttribute2 == null || meshAttribute2.Length != vertexCount) ? Color.white : meshAttribute2[triangles[num3 + 2]]);
						list3.Add(meshAttribute3[triangles[num3]]);
						list3.Add(meshAttribute3[triangles[num3 + 1]]);
						list3.Add(meshAttribute3[triangles[num3 + 2]]);
						i = new int[3]
						{
							num3,
							num3 + 1,
							num3 + 2
						};
					}
					list4.Add(new pb_Face(i, sharedMaterials[(num2 < num) ? num2 : (num - 1)], new pb_UV(), 0, -1, -1, manualUV: true));
				}
			}
			pb.SetVertices(list.ToArray());
			pb.SetUV(list3.ToArray());
			pb.SetFaces(list4.ToArray());
			pb.SetSharedIndices(pb_IntArrayUtility.ExtractSharedIndices(list.ToArray()));
			pb.SetColors(list2.ToArray());
			return true;
		}
	}
	public class pbMeshUtils
	{
		public static List<pb_Face> GetNeighborFaces(pb_Object pb, pb_Face originFace, Dictionary<int, int> lookup = null, IEnumerable<pb_Face> mask = null)
		{
			if (lookup == null)
			{
				lookup = pb.sharedIndices.ToDictionary();
			}
			List<pb_Face> list = new List<pb_Face>();
			HashSet<pb_Edge> hashSet = new HashSet<pb_Edge>();
			for (int i = 0; i < originFace.edges.Length; i++)
			{
				hashSet.Add(new pb_Edge(lookup[originFace.edges[i].x], lookup[originFace.edges[i].y]));
			}
			pb_Edge pb_Edge = new pb_Edge(-1, -1);
			for (int j = 0; j < pb.faces.Length; j++)
			{
				pb_Edge[] edges = pb.faces[j].edges;
				foreach (pb_Edge pb_Edge2 in edges)
				{
					pb_Edge.x = lookup[pb_Edge2.x];
					pb_Edge.y = lookup[pb_Edge2.y];
					if (hashSet.Contains(pb_Edge) && (mask == null || !mask.Contains(pb.faces[j])))
					{
						list.Add(pb.faces[j]);
						break;
					}
				}
			}
			return list;
		}

		public static Dictionary<pb_Face, List<pb_Face>> GenerateNeighborLookup(pb_Object pb, IList<pb_Face> InFaces)
		{
			Dictionary<int, int> sharedIndicesLookup = pb.sharedIndices.ToDictionary();
			Dictionary<pb_Face, List<pb_Face>> dictionary = new Dictionary<pb_Face, List<pb_Face>>();
			int num = InFaces.Count();
			HashSet<pb_Edge>[] array = new HashSet<pb_Edge>[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new HashSet<pb_Edge>(pb_Edge.GetUniversalEdges(InFaces[i].edges, sharedIndicesLookup));
			}
			for (int j = 0; j < num - 1; j++)
			{
				if (!dictionary.ContainsKey(InFaces[j]))
				{
					dictionary.Add(InFaces[j], new List<pb_Face>());
				}
				for (int k = j + 1; k < num; k++)
				{
					if (array[j].Overlaps(array[k]))
					{
						dictionary[InFaces[j]].Add(InFaces[k]);
						if (dictionary.TryGetValue(InFaces[k], out var value))
						{
							value.Add(InFaces[j]);
							continue;
						}
						dictionary.Add(InFaces[k], new List<pb_Face> { InFaces[j] });
					}
				}
			}
			return dictionary;
		}

		public static pb_Face[] GetNeighborFaces(pb_Object pb, Dictionary<int, int> sharedIndicesLookup, pb_Face[] selFaces)
		{
			List<pb_Face> list = new List<pb_Face>();
			pb_Edge[] array = GetPerimeterEdges(sharedIndicesLookup, selFaces).ToArray();
			pb_Edge[] array2 = new pb_Edge[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = new pb_Edge(sharedIndicesLookup[array[i].x], sharedIndicesLookup[array[i].y]);
			}
			pb_Edge pb_Edge = new pb_Edge(-1, -1);
			HashSet<pb_Face> hashSet = new HashSet<pb_Face>(selFaces);
			pb_Face[] faces = pb.faces;
			foreach (pb_Face pb_Face in faces)
			{
				if (hashSet.Contains(pb_Face))
				{
					hashSet.Remove(pb_Face);
					continue;
				}
				pb_Edge[] edges = pb_Face.edges;
				foreach (pb_Edge pb_Edge2 in edges)
				{
					pb_Edge.x = sharedIndicesLookup[pb_Edge2.x];
					pb_Edge.y = sharedIndicesLookup[pb_Edge2.y];
					if (array2.Contains(pb_Edge))
					{
						list.Add(pb_Face);
						break;
					}
				}
			}
			return list.ToArray();
		}

		public static List<pb_Tuple<pb_Face, pb_Edge>> GetNeighborFaces(pb_Object pb, pb_Edge edge, Dictionary<int, int> lookup = null)
		{
			if (lookup == null)
			{
				lookup = pb.sharedIndices.ToDictionary();
			}
			List<pb_Tuple<pb_Face, pb_Edge>> list = new List<pb_Tuple<pb_Face, pb_Edge>>();
			pb_Edge pb_Edge = new pb_Edge(lookup[edge.x], lookup[edge.y]);
			pb_Edge pb_Edge2 = new pb_Edge(0, 0);
			for (int i = 0; i < pb.faces.Length; i++)
			{
				pb_Edge[] edges = pb.faces[i].edges;
				for (int j = 0; j < edges.Length; j++)
				{
					pb_Edge2.x = edges[j].x;
					pb_Edge2.y = edges[j].y;
					if ((pb_Edge.x == lookup[pb_Edge2.x] && pb_Edge.y == lookup[pb_Edge2.y]) || (pb_Edge.x == lookup[pb_Edge2.y] && pb_Edge.y == lookup[pb_Edge2.x]))
					{
						list.Add(new pb_Tuple<pb_Face, pb_Edge>(pb.faces[i], new pb_Edge(edges[j])));
						break;
					}
				}
			}
			return list;
		}

		public static pb_Face[] GetNeighborFaces(pb_Object pb, pb_Edge[] edges)
		{
			List<pb_Face> list = new List<pb_Face>();
			Dictionary<int, int> lookup = pb.sharedIndices.ToDictionary();
			pb_Face[] faces = pb.faces;
			foreach (pb_Face pb_Face in faces)
			{
				foreach (pb_Edge edge in edges)
				{
					if (pb_Face.edges.IndexOf(edge, lookup) > -1)
					{
						list.Add(pb_Face);
					}
				}
			}
			return list.Distinct().ToArray();
		}

		internal static List<pb_Face>[][] GetNeighborFacesJagged(pb_Object pb, pb_Edge[][] selEdges)
		{
			int num = selEdges.Length;
			List<pb_Face>[][] array = new List<pb_Face>[num][];
			for (int i = 0; i < num; i++)
			{
				array[i] = new List<pb_Face>[selEdges[i].Length];
				for (int j = 0; j < selEdges[i].Length; j++)
				{
					array[i][j] = new List<pb_Face>();
				}
			}
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			pb_Edge[][] array2 = new pb_Edge[num][];
			for (int k = 0; k < num; k++)
			{
				array2[k] = pb_Edge.GetUniversalEdges(selEdges[k], sharedIndices).Distinct().ToArray();
			}
			for (int l = 0; l < pb.faces.Length; l++)
			{
				pb_Edge[] edges = pb_Edge.GetUniversalEdges(pb.faces[l].edges, sharedIndices).Distinct().ToArray();
				for (int m = 0; m < num; m++)
				{
					int num2 = -1;
					for (int n = 0; n < array2[m].Length; n++)
					{
						if (edges.Contains(array2[m][n]))
						{
							num2 = n;
							break;
						}
					}
					if (num2 > -1)
					{
						array[m][num2].Add(pb.faces[l]);
					}
				}
			}
			return array;
		}

		public static List<pb_Face> GetNeighborFaces(pb_Object pb, int index)
		{
			List<pb_Face> list = new List<pb_Face>();
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			int num = sharedIndices.IndexOf(index);
			pb_Face[] faces = pb.faces;
			foreach (pb_Face pb_Face in faces)
			{
				if (pb_Face.distinctIndices.ContainsMatch(sharedIndices[num]))
				{
					list.Add(pb_Face);
				}
			}
			return list;
		}

		public static IEnumerable<pb_Face> GetNeighborFaces(pb_Object pb, IEnumerable<int> indices)
		{
			List<pb_Face> list = new List<pb_Face>();
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int index in indices)
			{
				hashSet.Add(dictionary[index]);
			}
			for (int i = 0; i < pb.faces.Length; i++)
			{
				int[] distinctIndices = pb.faces[i].distinctIndices;
				for (int j = 0; j < distinctIndices.Length; j++)
				{
					if (hashSet.Contains(dictionary[distinctIndices[j]]))
					{
						list.Add(pb.faces[i]);
						break;
					}
				}
			}
			return list;
		}

		public static pb_Edge[] GetConnectedEdges(pb_Object pb, int[] indices)
		{
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			List<pb_Edge> list = new List<pb_Edge>();
			HashSet<int> hashSet = new HashSet<int>();
			for (int i = 0; i < indices.Length; i++)
			{
				hashSet.Add(dictionary[indices[i]]);
			}
			pb_Edge[] array = pb_Edge.AllEdges(pb.faces);
			HashSet<pb_Edge> hashSet2 = new HashSet<pb_Edge>();
			pb_Edge item = new pb_Edge(0, 0);
			for (int j = 0; j < array.Length; j++)
			{
				pb_Edge pb_Edge = new pb_Edge(dictionary[array[j].x], dictionary[array[j].y]);
				if (hashSet.Contains(pb_Edge.x) || (hashSet.Contains(pb_Edge.y) && !hashSet2.Contains(item)))
				{
					list.Add(array[j]);
					hashSet2.Add(pb_Edge);
				}
			}
			return list.ToArray();
		}

		public static IEnumerable<pb_Edge> GetPerimeterEdges(pb_Object pb, IEnumerable<pb_Face> faces)
		{
			return GetPerimeterEdges(pb.sharedIndices.ToDictionary(), faces);
		}

		public static IEnumerable<pb_Edge> GetPerimeterEdges(Dictionary<int, int> sharedIndicesLookup, IEnumerable<pb_Face> faces)
		{
			List<pb_Edge> list = faces.SelectMany((pb_Face x) => x.edges).ToList();
			int count = list.Count;
			Dictionary<pb_Edge, List<pb_Edge>> dictionary = new Dictionary<pb_Edge, List<pb_Edge>>();
			for (int num = 0; num < count; num++)
			{
				pb_Edge key = new pb_Edge(sharedIndicesLookup[list[num].x], sharedIndicesLookup[list[num].y]);
				if (dictionary.TryGetValue(key, out var value))
				{
					value.Add(list[num]);
					continue;
				}
				dictionary.Add(key, new List<pb_Edge> { list[num] });
			}
			return from x in dictionary
				where x.Value.Count < 2
				select x.Value[0];
		}

		public static int[] GetPerimeterEdges(pb_Object pb, pb_Edge[] edges)
		{
			if (edges.Length == pb_Edge.AllEdges(pb.faces).Length || edges.Length < 3)
			{
				return new int[0];
			}
			pb_Edge[] universalEdges = pb_Edge.GetUniversalEdges(edges, pb.sharedIndices.ToDictionary());
			int[] array = new int[universalEdges.Length];
			for (int i = 0; i < universalEdges.Length - 1; i++)
			{
				for (int j = i + 1; j < universalEdges.Length; j++)
				{
					if (universalEdges[i].x == universalEdges[j].x || universalEdges[i].x == universalEdges[j].y || universalEdges[i].y == universalEdges[j].x || universalEdges[i].y == universalEdges[j].y)
					{
						array[i]++;
						array[j]++;
					}
				}
			}
			int num = pb_Math.Min(array);
			List<int> list = new List<int>();
			for (int k = 0; k < array.Length; k++)
			{
				if (array[k] <= num)
				{
					list.Add(k);
				}
			}
			return (list.Count == edges.Length) ? new int[0] : list.ToArray();
		}

		public static IEnumerable<pb_Face> GetPerimeterFaces(pb_Object pb, IEnumerable<pb_Face> faces)
		{
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			Dictionary<pb_Edge, List<pb_Face>> dictionary2 = new Dictionary<pb_Edge, List<pb_Face>>();
			foreach (pb_Face face in faces)
			{
				pb_Edge[] edges = face.edges;
				foreach (pb_Edge pb_Edge in edges)
				{
					pb_Edge key = new pb_Edge(dictionary[pb_Edge.x], dictionary[pb_Edge.y]);
					if (dictionary2.ContainsKey(key))
					{
						dictionary2[key].Add(face);
						continue;
					}
					dictionary2.Add(key, new List<pb_Face> { face });
				}
			}
			return (from x in dictionary2
				where x.Value.Count < 2
				select x.Value[0]).Distinct();
		}

		public static int[] GetPerimeterVertices(pb_Object pb, int[] indices, pb_Edge[] universal_edges_all)
		{
			int num = indices.Length;
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = sharedIndices.IndexOf(indices[i]);
			}
			int[] array2 = new int[indices.Length];
			for (int j = 0; j < indices.Length - 1; j++)
			{
				for (int k = j + 1; k < indices.Length; k++)
				{
					if (universal_edges_all.Contains(array[j], array[k]))
					{
						array2[j]++;
						array2[k]++;
					}
				}
			}
			int num2 = pb_Math.Min(array2);
			List<int> list = new List<int>();
			for (int l = 0; l < num; l++)
			{
				if (array2[l] <= num2)
				{
					list.Add(l);
				}
			}
			return (list.Count >= num) ? new int[0] : list.ToArray();
		}

		private static pb_WingedEdge EdgeRingNext(pb_WingedEdge edge)
		{
			if (edge == null)
			{
				return null;
			}
			pb_WingedEdge pb_WingedEdge = edge.next;
			pb_WingedEdge previous = edge.previous;
			int num = 0;
			while (pb_WingedEdge != previous && pb_WingedEdge != edge)
			{
				pb_WingedEdge = pb_WingedEdge.next;
				if (pb_WingedEdge == previous)
				{
					return null;
				}
				previous = previous.previous;
				num++;
			}
			if (num % 2 == 0 || pb_WingedEdge == edge)
			{
				pb_WingedEdge = null;
			}
			return pb_WingedEdge;
		}

		public static IEnumerable<pb_Edge> GetEdgeRing(pb_Object pb, pb_Edge[] edges)
		{
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb);
			List<pb_EdgeLookup> list = pb_EdgeLookup.GetEdgeLookup(edges, pb.sharedIndices.ToDictionary()).ToList();
			list.Distinct();
			Dictionary<pb_Edge, pb_WingedEdge> dictionary = new Dictionary<pb_Edge, pb_WingedEdge>();
			for (int i = 0; i < wingedEdges.Count; i++)
			{
				if (!dictionary.ContainsKey(wingedEdges[i].edge.common))
				{
					dictionary.Add(wingedEdges[i].edge.common, wingedEdges[i]);
				}
			}
			HashSet<pb_EdgeLookup> hashSet = new HashSet<pb_EdgeLookup>();
			for (int j = 0; j < list.Count; j++)
			{
				if (!dictionary.TryGetValue(list[j].common, out var value) || hashSet.Contains(value.edge))
				{
					continue;
				}
				pb_WingedEdge pb_WingedEdge = value;
				while (pb_WingedEdge != null && hashSet.Add(pb_WingedEdge.edge))
				{
					pb_WingedEdge = EdgeRingNext(pb_WingedEdge);
					if (pb_WingedEdge != null && pb_WingedEdge.opposite != null)
					{
						pb_WingedEdge = pb_WingedEdge.opposite;
					}
				}
				pb_WingedEdge = EdgeRingNext(value.opposite);
				if (pb_WingedEdge != null && pb_WingedEdge.opposite != null)
				{
					pb_WingedEdge = pb_WingedEdge.opposite;
				}
				while (pb_WingedEdge != null && hashSet.Add(pb_WingedEdge.edge))
				{
					pb_WingedEdge = EdgeRingNext(pb_WingedEdge);
					if (pb_WingedEdge != null && pb_WingedEdge.opposite != null)
					{
						pb_WingedEdge = pb_WingedEdge.opposite;
					}
				}
			}
			return hashSet.Select((pb_EdgeLookup x) => x.local);
		}

		public static bool GetEdgeLoop(pb_Object pb, pb_Edge[] edges, out pb_Edge[] loop)
		{
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb);
			IEnumerable<pb_EdgeLookup> edgeLookup = pb_EdgeLookup.GetEdgeLookup(edges, pb.sharedIndices.ToDictionary());
			HashSet<pb_EdgeLookup> hashSet = new HashSet<pb_EdgeLookup>(edgeLookup);
			HashSet<pb_EdgeLookup> hashSet2 = new HashSet<pb_EdgeLookup>();
			for (int i = 0; i < wingedEdges.Count; i++)
			{
				if (!hashSet2.Contains(wingedEdges[i].edge) && hashSet.Contains(wingedEdges[i].edge) && !GetEdgeLoopInternal(wingedEdges[i], wingedEdges[i].edge.common.y, hashSet2))
				{
					GetEdgeLoopInternal(wingedEdges[i], wingedEdges[i].edge.common.x, hashSet2);
				}
			}
			loop = hashSet2.Select((pb_EdgeLookup x) => x.local).ToArray();
			return true;
		}

		private static bool GetEdgeLoopInternal(pb_WingedEdge start, int startIndex, HashSet<pb_EdgeLookup> used)
		{
			int num = startIndex;
			pb_WingedEdge pb_WingedEdge = start;
			do
			{
				used.Add(pb_WingedEdge.edge);
				List<pb_WingedEdge> list = GetSpokes(pb_WingedEdge, num, allowHoles: true).DistinctBy((pb_WingedEdge x) => x.edge.common).ToList();
				pb_WingedEdge = null;
				if (list != null && list.Count == 4)
				{
					pb_WingedEdge = list[2];
					num = ((pb_WingedEdge.edge.common.x != num) ? pb_WingedEdge.edge.common.x : pb_WingedEdge.edge.common.y);
				}
			}
			while (pb_WingedEdge != null && !used.Contains(pb_WingedEdge.edge));
			return pb_WingedEdge != null;
		}

		private static pb_WingedEdge NextSpoke(pb_WingedEdge wing, int pivot, bool opp)
		{
			if (opp)
			{
				return wing.opposite;
			}
			if (wing.next.edge.common.Contains(pivot))
			{
				return wing.next;
			}
			if (wing.previous.edge.common.Contains(pivot))
			{
				return wing.previous;
			}
			return null;
		}

		public static List<pb_WingedEdge> GetSpokes(pb_WingedEdge wing, int sharedIndex, bool allowHoles = false)
		{
			List<pb_WingedEdge> list = new List<pb_WingedEdge>();
			pb_WingedEdge pb_WingedEdge = wing;
			bool flag = false;
			do
			{
				list.Add(pb_WingedEdge);
				pb_WingedEdge = NextSpoke(pb_WingedEdge, sharedIndex, flag);
				flag = !flag;
				if (pb_WingedEdge != null && pb_WingedEdge.edge.common.Equals(wing.edge.common))
				{
					return list;
				}
			}
			while (pb_WingedEdge != null);
			if (!allowHoles)
			{
				return null;
			}
			pb_WingedEdge = wing.opposite;
			flag = false;
			List<pb_WingedEdge> list2 = new List<pb_WingedEdge>();
			while (pb_WingedEdge != null && !pb_WingedEdge.edge.common.Equals(wing.edge.common))
			{
				list2.Add(pb_WingedEdge);
				pb_WingedEdge = NextSpoke(pb_WingedEdge, sharedIndex, flag);
				flag = !flag;
			}
			list2.Reverse();
			list.AddRange(list2);
			return list;
		}
	}
	public static class pbTriangleOps
	{
		public static void ReverseWindingOrder(this pb_Object pb, pb_Face[] faces)
		{
			for (int i = 0; i < faces.Length; i++)
			{
				faces[i].ReverseIndices();
			}
		}

		public static WindingOrder GetWindingOrder(this pb_Object pb, pb_Face face)
		{
			Vector2[] points = pb_Projection.PlanarProject(pb, face);
			return GetWindingOrder(points);
		}

		public static WindingOrder GetWindingOrder(IList<pb_Vertex> vertices, IList<int> indices)
		{
			Vector2[] points = pb_Projection.PlanarProject(vertices, indices);
			return GetWindingOrder(points);
		}

		public static WindingOrder GetWindingOrder(IList<Vector2> points)
		{
			float num = 0f;
			int count = points.Count;
			for (int i = 0; i < count; i++)
			{
				Vector2 vector = points[i];
				Vector2 vector2 = ((i >= count - 1) ? points[0] : points[i + 1]);
				num += (vector2.x - vector.x) * (vector2.y + vector.y);
			}
			return (num != 0f) ? ((num > 0f) ? WindingOrder.Clockwise : WindingOrder.CounterClockwise) : WindingOrder.Unknown;
		}

		public static bool FlipEdge(this pb_Object pb, pb_Face face)
		{
			int[] indices = face.indices;
			if (indices.Length != 6)
			{
				return false;
			}
			int[] array = pbUtil.FilledArray(1, indices.Length);
			for (int i = 0; i < indices.Length - 1; i++)
			{
				for (int j = i + 1; j < indices.Length; j++)
				{
					if (indices[i] == indices[j])
					{
						array[i]++;
						array[j]++;
					}
				}
			}
			if (array[0] + array[1] + array[2] != 5 || array[3] + array[4] + array[5] != 5)
			{
				return false;
			}
			int num = indices[(array[0] != 1) ? ((array[1] == 1) ? 1 : 2) : 0];
			int num2 = indices[(array[3] == 1) ? 3 : ((array[4] != 1) ? 5 : 4)];
			int num3 = -1;
			if (array[0] == 2)
			{
				num3 = indices[0];
				indices[0] = num2;
			}
			else if (array[1] == 2)
			{
				num3 = indices[1];
				indices[1] = num2;
			}
			else if (array[2] == 2)
			{
				num3 = indices[2];
				indices[2] = num2;
			}
			if (array[3] == 2 && indices[3] != num3)
			{
				indices[3] = num;
			}
			else if (array[4] == 2 && indices[4] != num3)
			{
				indices[4] = num;
			}
			else if (array[5] == 2 && indices[5] != num3)
			{
				indices[5] = num;
			}
			return true;
		}

		public static bool RemoveDegenerateTriangles(this pb_Object pb, out int[] removed)
		{
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			Dictionary<int, int> dictionary2 = ((pb.sharedIndicesUV == null) ? new Dictionary<int, int>() : pb.sharedIndicesUV.ToDictionary());
			Vector3[] vertices = pb.vertices;
			Dictionary<int, int> dictionary3 = new Dictionary<int, int>();
			Dictionary<int, int> dictionary4 = new Dictionary<int, int>();
			List<pb_Face> list = new List<pb_Face>();
			pb_Face[] faces = pb.faces;
			foreach (pb_Face pb_Face in faces)
			{
				List<int> list2 = new List<int>();
				int[] indices = pb_Face.indices;
				for (int j = 0; j < indices.Length; j += 3)
				{
					float num = pb_Math.TriangleArea(vertices[indices[j]], vertices[indices[j + 1]], vertices[indices[j + 2]]);
					if (!(num > Mathf.Epsilon))
					{
						continue;
					}
					int num2 = dictionary[indices[j]];
					int num3 = dictionary[indices[j + 1]];
					int num4 = dictionary[indices[j + 2]];
					if (num2 != num3 && num2 != num4 && num3 != num4)
					{
						list2.Add(indices[j]);
						list2.Add(indices[j + 1]);
						list2.Add(indices[j + 2]);
						if (!dictionary3.ContainsKey(indices[j]))
						{
							dictionary3.Add(indices[j], num2);
						}
						if (!dictionary3.ContainsKey(indices[j + 1]))
						{
							dictionary3.Add(indices[j + 1], num3);
						}
						if (!dictionary3.ContainsKey(indices[j + 2]))
						{
							dictionary3.Add(indices[j + 2], num4);
						}
						if (dictionary2.ContainsKey(indices[j]) && !dictionary4.ContainsKey(indices[j]))
						{
							dictionary4.Add(indices[j], dictionary2[indices[j]]);
						}
						if (dictionary2.ContainsKey(indices[j + 1]) && !dictionary4.ContainsKey(indices[j + 1]))
						{
							dictionary4.Add(indices[j + 1], dictionary2[indices[j + 1]]);
						}
						if (dictionary2.ContainsKey(indices[j + 2]) && !dictionary4.ContainsKey(indices[j + 2]))
						{
							dictionary4.Add(indices[j + 2], dictionary2[indices[j + 2]]);
						}
					}
				}
				if (list2.Count > 0)
				{
					pb_Face.SetIndices(list2.ToArray());
					pb_Face.RebuildCaches();
					list.Add(pb_Face);
				}
			}
			pb.SetFaces(list.ToArray());
			pb.SetSharedIndices(dictionary3);
			pb.SetSharedIndicesUV(dictionary4);
			removed = pb.RemoveUnusedVertices();
			return removed.Length > 0;
		}

		public static pb_Face MergeFaces(this pb_Object pb, pb_Face[] faces)
		{
			List<int> list = new List<int>(faces[0].indices);
			for (int i = 1; i < faces.Length; i++)
			{
				list.AddRange(faces[i].indices);
			}
			pb_Face pb_Face = new pb_Face(list.ToArray(), faces[0].material, faces[0].uv, faces[0].smoothingGroup, faces[0].textureGroup, faces[0].elementGroup, faces[0].manualUV);
			pb_Face[] array = new pb_Face[pb.faces.Length - faces.Length + 1];
			int num = 0;
			pb_Face[] faces2 = pb.faces;
			foreach (pb_Face pb_Face2 in faces2)
			{
				if (Array.IndexOf(faces, pb_Face2) < 0)
				{
					array[num++] = pb_Face2;
				}
			}
			array[num] = pb_Face;
			pb.SetFaces(array);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			for (int k = 0; k < pb_Face.indices.Length; k++)
			{
				int key = pb.sharedIndices.IndexOf(pb_Face.indices[k]);
				if (dictionary.ContainsKey(key))
				{
					pb_Face.indices[k] = dictionary[key];
				}
				else
				{
					dictionary.Add(key, pb_Face.indices[k]);
				}
			}
			pb.RemoveUnusedVertices();
			return pb_Face;
		}
	}
	public static class pbUVOps
	{
		public static bool SewUVs(this pb_Object pb, int[] indices, float delta)
		{
			int[] array = new int[indices.Length];
			Vector2[] array2 = pb.uv;
			if (array2 == null || array2.Length != pb.vertexCount)
			{
				array2 = new Vector2[pb.vertexCount];
			}
			for (int i = 0; i < indices.Length; i++)
			{
				array[i] = -(i + 1);
			}
			pb_IntArray[] sharedIndices = pb.sharedIndicesUV;
			for (int j = 0; j < indices.Length - 1; j++)
			{
				for (int k = j + 1; k < indices.Length; k++)
				{
					if (array[j] != array[k] && Vector2.Distance(array2[indices[j]], array2[indices[k]]) < delta)
					{
						Vector3 vector = (array2[indices[j]] + array2[indices[k]]) / 2f;
						ref Vector2 reference = ref array2[indices[j]];
						reference = vector;
						ref Vector2 reference2 = ref array2[indices[k]];
						reference2 = vector;
						array[k] = (array[j] = pb_IntArrayUtility.MergeSharedIndices(ref sharedIndices, new int[2]
						{
							indices[j],
							indices[k]
						}));
					}
				}
			}
			pb.SetUV(array2);
			pb.SetSharedIndicesUV(sharedIndices);
			return true;
		}

		public static void CollapseUVs(this pb_Object pb, int[] indices)
		{
			Vector2[] uv = pb.uv;
			Vector2 vector = pb_Math.Average(uv.ValuesWithIndices(indices));
			foreach (int num in indices)
			{
				uv[num] = vector;
			}
			pb_IntArray[] sharedIndices = pb.sharedIndicesUV;
			pb_IntArrayUtility.MergeSharedIndices(ref sharedIndices, indices);
			pb.SetUV(uv);
			pb.SetSharedIndicesUV(sharedIndices);
		}

		public static bool SplitUVs(this pb_Object pb, int[] indices)
		{
			pb_IntArray[] sharedIndices = pb.sharedIndicesUV;
			if (sharedIndices == null)
			{
				return false;
			}
			List<int> list = indices.Distinct().ToList();
			for (int i = 0; i < list.Count; i++)
			{
				int num = sharedIndices.IndexOf(list[i]);
				if (num >= 0)
				{
					sharedIndices[num].array = sharedIndices[num].array.Remove(list[i]);
				}
			}
			foreach (int item in list)
			{
				pb_IntArrayUtility.AddValueAtIndex(ref sharedIndices, -1, item);
			}
			pb.SetSharedIndicesUV(sharedIndices);
			return true;
		}

		public static void ProjectFacesAuto(pb_Object pb, pb_Face[] faces)
		{
			int[] array = pb_Face.AllTrianglesDistinct(faces);
			Vector3 zero = Vector3.zero;
			foreach (pb_Face face in faces)
			{
				zero += pb_Math.Normal(pb, face);
			}
			zero /= (float)faces.Length;
			Vector2[] array2 = pb_Projection.PlanarProject(pb.vertices.ValuesWithIndices(array), zero);
			Vector2[] uv = pb.uv;
			for (int j = 0; j < array.Length; j++)
			{
				ref Vector2 reference = ref uv[array[j]];
				reference = array2[j];
			}
			pb.SetUV(uv);
			pb.msh.uv = uv;
			foreach (pb_Face pb_Face in faces)
			{
				pb_Face.elementGroup = -1;
				pb.SplitUVs(pb_Face.distinctIndices);
			}
			pb.SewUVs(pb_Face.AllTrianglesDistinct(faces), 0.001f);
		}

		public static void ProjectFacesBox(pb_Object pb, pb_Face[] faces)
		{
			Vector2[] uv = pb.uv;
			Dictionary<ProjectionAxis, List<pb_Face>> dictionary = new Dictionary<ProjectionAxis, List<pb_Face>>();
			for (int i = 0; i < faces.Length; i++)
			{
				Vector3 plane = pb_Math.Normal(pb, faces[i]);
				ProjectionAxis key = pb_Projection.VectorToProjectionAxis(plane);
				if (dictionary.ContainsKey(key))
				{
					dictionary[key].Add(faces[i]);
				}
				else
				{
					dictionary.Add(key, new List<pb_Face> { faces[i] });
				}
				faces[i].elementGroup = -1;
				faces[i].manualUV = true;
			}
			foreach (KeyValuePair<ProjectionAxis, List<pb_Face>> item in dictionary)
			{
				int[] array = pb_Face.AllTrianglesDistinct(item.Value.ToArray());
				Vector2[] array2 = pb_Projection.PlanarProject(pb.vertices.ValuesWithIndices(array), pb_Projection.ProjectionAxisToVector(item.Key), item.Key);
				for (int j = 0; j < array.Length; j++)
				{
					ref Vector2 reference = ref uv[array[j]];
					reference = array2[j];
				}
				pb.SplitUVs(array);
			}
			pb.SetUV(uv);
		}

		public static void ProjectFacesSphere(pb_Object pb, int[] indices)
		{
			pb_Face[] faces = pb.faces;
			foreach (pb_Face pb_Face in faces)
			{
				if (pb_Face.distinctIndices.ContainsMatch(indices))
				{
					pb_Face.elementGroup = -1;
					pb_Face.manualUV = true;
				}
			}
			pb.SplitUVs(indices);
			Vector2[] array = pb_Projection.SphericalProject(pb.vertices, indices);
			Vector2[] uv = pb.uv;
			for (int j = 0; j < indices.Length; j++)
			{
				ref Vector2 reference = ref uv[indices[j]];
				reference = array[j];
			}
			pb.SetUV(uv);
		}

		public static Vector2[] FitUVs(Vector2[] uvs)
		{
			Vector2 vector = pb_Math.SmallestVector2(uvs);
			for (int i = 0; i < uvs.Length; i++)
			{
				uvs[i] -= vector;
			}
			float num = pb_Math.LargestValue(pb_Math.LargestVector2(uvs));
			for (int i = 0; i < uvs.Length; i++)
			{
				uvs[i] /= num;
			}
			return uvs;
		}

		public static bool AutoStitch(pb_Object pb, pb_Face f1, pb_Face f2)
		{
			Dictionary<int, int> lookup = pb.sharedIndices.ToDictionary();
			for (int i = 0; i < f1.edges.Length; i++)
			{
				int num = f2.edges.IndexOf(f1.edges[i], lookup);
				if (num > -1)
				{
					ProjectFacesAuto(pb, new pb_Face[1] { f2 });
					f1.manualUV = true;
					f2.manualUV = true;
					f1.textureGroup = -1;
					f2.textureGroup = -1;
					AlignEdges(pb, f1, f2, f1.edges[i], f2.edges[num]);
					return true;
				}
			}
			return false;
		}

		private static bool AlignEdges(pb_Object pb, pb_Face f1, pb_Face f2, pb_Edge edge1, pb_Edge edge2)
		{
			Vector2[] uv = pb.uv;
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			pb_IntArray[] sharedIndices2 = pb.sharedIndicesUV;
			int[] array = new int[2] { edge1.x, -1 };
			int[] array2 = new int[2] { edge1.y, -1 };
			int num = sharedIndices.IndexOf(edge1.x);
			if (num < 0)
			{
				return false;
			}
			if (sharedIndices[num].array.Contains(edge2.x))
			{
				array[1] = edge2.x;
				array2[1] = edge2.y;
			}
			else
			{
				array[1] = edge2.y;
				array2[1] = edge2.x;
			}
			float num2 = Vector2.Distance(uv[edge1.x], uv[edge1.y]);
			float num3 = Vector2.Distance(uv[edge2.x], uv[edge2.y]);
			float num4 = num2 / num3;
			int[] distinctIndices = f2.distinctIndices;
			foreach (int num5 in distinctIndices)
			{
				ref Vector2 reference = ref uv[num5];
				reference = uv[num5].ScaleAroundPoint(Vector2.zero, Vector2.one * num4);
			}
			Vector2 vector = (uv[edge1.x] + uv[edge1.y]) / 2f;
			Vector2 vector2 = (uv[edge2.x] + uv[edge2.y]) / 2f;
			Vector2 vector3 = vector - vector2;
			int[] distinctIndices2 = f2.distinctIndices;
			foreach (int num6 in distinctIndices2)
			{
				uv[num6] += vector3;
			}
			Vector2 vector4 = uv[array2[0]] - uv[array[0]];
			Vector2 vector5 = uv[array2[1]] - uv[array[1]];
			float num7 = Vector2.Angle(vector4, vector5);
			if (Vector3.Cross(vector4, vector5).z < 0f)
			{
				num7 = 360f - num7;
			}
			int[] distinctIndices3 = f2.distinctIndices;
			foreach (int num8 in distinctIndices3)
			{
				ref Vector2 reference2 = ref uv[num8];
				reference2 = uv[num8].RotateAroundPoint(vector, num7);
			}
			float num9 = Mathf.Abs(Vector2.Distance(uv[array[0]], uv[array[1]])) + Mathf.Abs(Vector2.Distance(uv[array2[0]], uv[array2[1]]));
			if (num9 > 0.02f)
			{
				int[] distinctIndices4 = f2.distinctIndices;
				foreach (int num10 in distinctIndices4)
				{
					ref Vector2 reference3 = ref uv[num10];
					reference3 = uv[num10].RotateAroundPoint(vector, 180f);
				}
				float num11 = Mathf.Abs(Vector2.Distance(uv[array[0]], uv[array[1]])) + Mathf.Abs(Vector2.Distance(uv[array2[0]], uv[array2[1]]));
				if (num11 < num9)
				{
					num9 = num11;
				}
				else
				{
					int[] distinctIndices5 = f2.distinctIndices;
					foreach (int num12 in distinctIndices5)
					{
						ref Vector2 reference4 = ref uv[num12];
						reference4 = uv[num12].RotateAroundPoint(vector, 180f);
					}
				}
			}
			pb.SplitUVs(f2.distinctIndices);
			pb_IntArrayUtility.MergeSharedIndices(ref sharedIndices2, array);
			pb_IntArrayUtility.MergeSharedIndices(ref sharedIndices2, array2);
			pb_IntArray.RemoveEmptyOrNull(ref sharedIndices2);
			pb.SetSharedIndicesUV(sharedIndices2);
			pb.SetUV(uv);
			return true;
		}

		public static pb_Transform2D MatchCoordinates(Vector2[] points, Vector2[] target)
		{
			int length = ((points.Length >= target.Length) ? target.Length : points.Length);
			pb_Bounds2D pb_Bounds2D = new pb_Bounds2D(target, length);
			Vector2 vector = pb_Bounds2D.center - pb_Bounds2D.Center(points, length);
			Vector2[] array = new Vector2[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				ref Vector2 reference = ref array[i];
				reference = points[i] + vector;
			}
			Vector2 vector2 = target[1] - target[0];
			Vector2 vector3 = array[1] - array[0];
			float num = Vector2.Angle(vector2, vector3);
			float num2 = Vector2.Dot(pb_Math.Perpendicular(vector2), vector3);
			if (num2 < 0f)
			{
				num = 360f - num;
			}
			for (int j = 0; j < points.Length; j++)
			{
				ref Vector2 reference2 = ref array[j];
				reference2 = array[j].RotateAroundPoint(pb_Bounds2D.center, num);
			}
			pb_Bounds2D pb_Bounds2D2 = new pb_Bounds2D(array, length);
			Vector2 scale = pb_Bounds2D.size.DivideBy(pb_Bounds2D2.size);
			return new pb_Transform2D(vector, num, scale);
		}

		public static void SetAutoUV(pb_Object pb, pb_Face[] faces, bool auto)
		{
			if (auto)
			{
				faces = Array.FindAll(faces, (pb_Face x) => x.manualUV).ToArray();
				pb.SplitUVs(pb_Face.AllTriangles(faces));
				Vector2[][] array = new Vector2[faces.Length][];
				for (int num = 0; num < faces.Length; num++)
				{
					array[num] = pb.uv.ValuesWithIndices(faces[num].distinctIndices);
				}
				for (int num2 = 0; num2 < faces.Length; num2++)
				{
					faces[num2].uv.Reset();
					faces[num2].manualUV = !auto;
					faces[num2].elementGroup = -1;
				}
				pb.RefreshUV(faces);
				for (int num3 = 0; num3 < faces.Length; num3++)
				{
					pb_Transform2D pb_Transform2D = MatchCoordinates(pb.uv.ValuesWithIndices(faces[num3].distinctIndices), array[num3]);
					faces[num3].uv.offset = -pb_Transform2D.position;
					faces[num3].uv.rotation = pb_Transform2D.rotation;
					if (Mathf.Abs(pb_Transform2D.scale.sqrMagnitude - 2f) > 0.1f)
					{
						faces[num3].uv.scale = pb_Transform2D.scale;
					}
				}
			}
			else
			{
				pb_Face[] array2 = faces;
				foreach (pb_Face pb_Face in array2)
				{
					pb_Face.textureGroup = -1;
					pb_Face.manualUV = !auto;
				}
			}
		}

		public static Vector2 NearestVector2(Vector2 pos, Vector2[] uvs)
		{
			if (uvs.Length < 1)
			{
				return pos;
			}
			Vector2 vector = uvs[0];
			float num = Vector2.Distance(pos, vector);
			for (int i = 1; i < uvs.Length; i++)
			{
				float num2 = Vector2.Distance(pos, uvs[i]);
				if (num2 < num)
				{
					num = num2;
					vector = uvs[i];
				}
			}
			return vector;
		}
	}
	public static class pbVertexOps
	{
		public static bool MergeVertices(this pb_Object pb, int[] indices, out int collapsedIndex, bool collapseToFirst = false)
		{
			pb_Vertex[] vertices = pb_Vertex.GetVertices(pb);
			pb_Vertex vertex = ((!collapseToFirst) ? pb_Vertex.Average(vertices, indices) : vertices[indices[0]]);
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			pb_IntArray[] sharedIndices2 = pb.sharedIndicesUV;
			int num = pb_IntArrayUtility.MergeSharedIndices(ref sharedIndices, indices);
			pb_IntArrayUtility.MergeSharedIndices(ref sharedIndices2, indices);
			pb.SetSharedIndices(sharedIndices);
			pb.SetSharedIndicesUV(sharedIndices2);
			pb.SetSharedVertexValues(num, vertex);
			int[] array = pb.GetSharedIndices()[num].array;
			pb.RemoveDegenerateTriangles(out var removed);
			int num2 = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (!removed.Contains(array[i]))
				{
					num2 = array[i];
				}
			}
			int num3 = num2;
			for (int j = 0; j < removed.Length; j++)
			{
				if (num2 > removed[j])
				{
					num3--;
				}
			}
			if (num3 > -1)
			{
				collapsedIndex = num3;
				return true;
			}
			collapsedIndex = -1;
			return false;
		}

		public static bool SplitCommonVertices(this pb_Object pb, int[] indices)
		{
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < indices.Length; i++)
			{
				int num = dictionary[indices[i]];
				if (!list.Contains(num))
				{
					list.Add(num);
					list2.AddRange(sharedIndices[num].array);
				}
			}
			pb_IntArrayUtility.RemoveValues(ref sharedIndices, list2.ToArray());
			foreach (int item in list2)
			{
				pb_IntArrayUtility.AddValueAtIndex(ref sharedIndices, -1, item);
			}
			pb.SetSharedIndices(sharedIndices);
			return true;
		}

		public static void SplitVertices(this pb_Object pb, pb_Edge edge)
		{
			pb.SplitVertices(new int[2] { edge.x, edge.y });
		}

		public static void SplitVertices(this pb_Object pb, IEnumerable<int> indices)
		{
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			int num = dictionary.Count();
			foreach (int index in indices)
			{
				num = (dictionary[index] = num + 1);
			}
			pb.SetSharedIndices(dictionary);
		}

		public static bool AppendVerticesToFace(this pb_Object pb, pb_Face face, Vector3[] points, Color[] addColors, out pb_Face newFace)
		{
			if (!face.IsValid())
			{
				newFace = face;
				return false;
			}
			List<pb_Vertex> list = pb_Vertex.GetVertices(pb).ToList();
			List<pb_Face> list2 = new List<pb_Face>(pb.faces);
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			Dictionary<int, int> dictionary2 = ((pb.sharedIndicesUV != null) ? pb.sharedIndicesUV.ToDictionary() : null);
			List<pb_Edge> list3 = pb_WingedEdge.SortEdgesByAdjacency(face);
			List<pb_Vertex> list4 = new List<pb_Vertex>();
			List<int> list5 = new List<int>();
			List<int> list6 = ((dictionary2 == null) ? null : new List<int>());
			for (int i = 0; i < list3.Count; i++)
			{
				list4.Add(list[list3[i].x]);
				list5.Add(dictionary[list3[i].x]);
				if (dictionary2 != null)
				{
					if (dictionary2.TryGetValue(list3[i].x, out var value))
					{
						list6.Add(value);
					}
					else
					{
						list6.Add(-1);
					}
				}
			}
			for (int j = 0; j < points.Length; j++)
			{
				int num = -1;
				float num2 = float.PositiveInfinity;
				Vector3 vector = points[j];
				int count = list4.Count;
				for (int k = 0; k < count; k++)
				{
					Vector3 position = list4[k].position;
					Vector3 position2 = list4[(k + 1) % count].position;
					float num3 = pb_Math.DistancePointLineSegment(vector, position, position2);
					if (num3 < num2)
					{
						num2 = num3;
						num = k;
					}
				}
				pb_Vertex pb_Vertex = list4[num];
				pb_Vertex pb_Vertex2 = list4[(num + 1) % count];
				float sqrMagnitude = (vector - pb_Vertex.position).sqrMagnitude;
				float sqrMagnitude2 = (vector - pb_Vertex2.position).sqrMagnitude;
				pb_Vertex item = pb_Vertex.Mix(pb_Vertex, pb_Vertex2, sqrMagnitude / (sqrMagnitude + sqrMagnitude2));
				list4.Insert((num + 1) % count, item);
				list5.Insert((num + 1) % count, -1);
				list6?.Insert((num + 1) % count, -1);
			}
			List<int> triangles;
			try
			{
				pb_Triangulation.TriangulateVertices(list4, out triangles, unordered: false);
			}
			catch
			{
				Debug.Log("Failed triangulating face after appending vertices.");
				newFace = null;
				return false;
			}
			pb_FaceRebuildData pb_FaceRebuildData = new pb_FaceRebuildData();
			pb_FaceRebuildData.face = new pb_Face(triangles.ToArray(), face.material, new pb_UV(face.uv), face.smoothingGroup, face.textureGroup, -1, face.manualUV);
			pb_FaceRebuildData.vertices = list4;
			pb_FaceRebuildData.sharedIndices = list5;
			pb_FaceRebuildData.sharedIndicesUV = list6;
			List<pb_FaceRebuildData> list7 = new List<pb_FaceRebuildData>();
			list7.Add(pb_FaceRebuildData);
			pb_FaceRebuildData.Apply(list7, list, list2, dictionary, dictionary2);
			newFace = pb_FaceRebuildData.face;
			pb.SetVertices(list);
			pb.SetFaces(list2.ToArray());
			pb.SetSharedIndices(dictionary);
			pb.SetSharedIndicesUV(dictionary2);
			Vector3 lhs = pb_Math.Normal(pb, face);
			Vector3 rhs = pb_Math.Normal(pb, newFace);
			if (Vector3.Dot(lhs, rhs) < 0f)
			{
				newFace.ReverseIndices();
			}
			pb.DeleteFace(face);
			return true;
		}

		public static pb_ActionResult AppendVerticesToEdge(this pb_Object pb, pb_Edge edge, int count, out List<pb_Edge> newEdges)
		{
			return pb.AppendVerticesToEdge(new pb_Edge[1] { edge }, count, out newEdges);
		}

		public static pb_ActionResult AppendVerticesToEdge(this pb_Object pb, IList<pb_Edge> edges, int count, out List<pb_Edge> newEdges)
		{
			newEdges = new List<pb_Edge>();
			if (count < 1 || count > 512)
			{
				return new pb_ActionResult(Status.Failure, "New edge vertex count is less than 1 or greater than 512.");
			}
			List<pb_Vertex> list = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			Dictionary<int, int> dictionary2 = pb.sharedIndicesUV.ToDictionary();
			List<int> list2 = new List<int>();
			pb_Edge[] universalEdges = pb_Edge.GetUniversalEdges(edges.ToArray(), dictionary);
			List<pb_Edge> list3 = universalEdges.Distinct().ToList();
			Dictionary<pb_Face, pb_FaceRebuildData> dictionary3 = new Dictionary<pb_Face, pb_FaceRebuildData>();
			int num = dictionary.Count();
			int num2 = num;
			foreach (pb_Edge item2 in list3)
			{
				pb_Edge localEdgeFast = pb_Edge.GetLocalEdgeFast(item2, pb.sharedIndices);
				List<pb_Vertex> list4 = new List<pb_Vertex>(count);
				for (int i = 0; i < count; i++)
				{
					list4.Add(pb_Vertex.Mix(list[localEdgeFast.x], list[localEdgeFast.y], (float)(i + 1) / ((float)count + 1f)));
				}
				List<pb_Tuple<pb_Face, pb_Edge>> neighborFaces = pbMeshUtils.GetNeighborFaces(pb, localEdgeFast);
				foreach (pb_Tuple<pb_Face, pb_Edge> item3 in neighborFaces)
				{
					pb_Face item = item3.Item1;
					if (!dictionary3.TryGetValue(item, out var value))
					{
						value = new pb_FaceRebuildData();
						value.face = new pb_Face(null, item.material, new pb_UV(item.uv), item.smoothingGroup, item.textureGroup, -1, item.manualUV);
						value.vertices = new List<pb_Vertex>(list.ValuesWithIndices(item.distinctIndices));
						value.sharedIndices = new List<int>();
						value.sharedIndicesUV = new List<int>();
						int[] distinctIndices = item.distinctIndices;
						foreach (int key in distinctIndices)
						{
							if (dictionary.TryGetValue(key, out var value2))
							{
								value.sharedIndices.Add(value2);
							}
							if (dictionary2.TryGetValue(key, out value2))
							{
								value.sharedIndicesUV.Add(value2);
							}
						}
						list2.AddRange(item.distinctIndices);
						dictionary3.Add(item, value);
					}
					value.vertices.AddRange(list4);
					for (int k = 0; k < count; k++)
					{
						value.sharedIndices.Add(num2 + k);
						value.sharedIndicesUV.Add(-1);
					}
				}
				num2 += count;
			}
			List<pb_Face> list5 = dictionary3.Keys.ToList();
			List<pb_FaceRebuildData> list6 = dictionary3.Values.ToList();
			List<pb_EdgeLookup> list7 = new List<pb_EdgeLookup>();
			for (int l = 0; l < list5.Count; l++)
			{
				pb_Face pb_Face = list5[l];
				pb_FaceRebuildData pb_FaceRebuildData = list6[l];
				Vector3 planeNormal = pb_Math.Normal(pb, pb_Face);
				Vector2[] points = pb_Projection.PlanarProject(pb_FaceRebuildData.vertices.Select((pb_Vertex x) => x.position).ToArray(), planeNormal);
				int count2 = list.Count;
				if (!pb_Triangulation.SortAndTriangulate(points, out var indices))
				{
					continue;
				}
				pb_FaceRebuildData.face.SetIndices(indices.ToArray());
				pb_FaceRebuildData.face.ShiftIndices(count2);
				pb_Face.CopyFrom(pb_FaceRebuildData.face);
				for (int num3 = 0; num3 < pb_FaceRebuildData.vertices.Count; num3++)
				{
					dictionary.Add(count2 + num3, pb_FaceRebuildData.sharedIndices[num3]);
				}
				if (pb_FaceRebuildData.sharedIndicesUV.Count == pb_FaceRebuildData.vertices.Count)
				{
					for (int num4 = 0; num4 < pb_FaceRebuildData.vertices.Count; num4++)
					{
						dictionary2.Add(count2 + num4, pb_FaceRebuildData.sharedIndicesUV[num4]);
					}
				}
				list.AddRange(pb_FaceRebuildData.vertices);
				pb_Edge[] edges2 = pb_Face.edges;
				foreach (pb_Edge pb_Edge in edges2)
				{
					pb_EdgeLookup pb_EdgeLookup = new pb_EdgeLookup(new pb_Edge(dictionary[pb_Edge.x], dictionary[pb_Edge.y]), pb_Edge);
					if (pb_EdgeLookup.common.x >= num || pb_EdgeLookup.common.y >= num)
					{
						list7.Add(pb_EdgeLookup);
					}
				}
			}
			list2 = list2.Distinct().ToList();
			int delCount = list2.Count;
			newEdges = (from x in list7.Distinct()
				select x.local - delCount).ToList();
			pb.SetVertices(list);
			pb.SetSharedIndices(dictionary.ToSharedIndices());
			pb.SetSharedIndicesUV(dictionary2.ToSharedIndices());
			pb.DeleteVerticesWithIndices(list2);
			return new pb_ActionResult(Status.Success, "Subdivide Edges");
		}

		public static pb_FaceRebuildData ExplodeVertex(IList<pb_Vertex> vertices, IList<pb_Tuple<pb_WingedEdge, int>> edgeAndCommonIndex, float distance, out Dictionary<int, List<int>> appendedVertices)
		{
			pb_Face face = edgeAndCommonIndex.FirstOrDefault().Item1.face;
			List<pb_Edge> list = pb_WingedEdge.SortEdgesByAdjacency(face);
			appendedVertices = new Dictionary<int, List<int>>();
			Vector3 lhs = pb_Math.Normal(vertices, face.indices);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (pb_Tuple<pb_WingedEdge, int> item3 in edgeAndCommonIndex)
			{
				if (item3.Item2 == item3.Item1.edge.common.x)
				{
					dictionary.Add(item3.Item1.edge.local.x, item3.Item2);
				}
				else
				{
					dictionary.Add(item3.Item1.edge.local.y, item3.Item2);
				}
			}
			int count = list.Count;
			List<pb_Vertex> list2 = new List<pb_Vertex>();
			for (int i = 0; i < count; i++)
			{
				int y = list[i].y;
				if (dictionary.ContainsKey(y))
				{
					pb_Vertex pb_Vertex = vertices[list[i].x];
					pb_Vertex pb_Vertex2 = vertices[list[i].y];
					pb_Vertex pb_Vertex3 = vertices[list[(i + 1) % count].y];
					pb_Vertex pb_Vertex4 = pb_Vertex - pb_Vertex2;
					pb_Vertex pb_Vertex5 = pb_Vertex3 - pb_Vertex2;
					pb_Vertex4.Normalize();
					pb_Vertex5.Normalize();
					pb_Vertex item = vertices[y] + pb_Vertex4 * distance;
					pb_Vertex item2 = vertices[y] + pb_Vertex5 * distance;
					appendedVertices.AddOrAppend(dictionary[y], list2.Count);
					list2.Add(item);
					appendedVertices.AddOrAppend(dictionary[y], list2.Count);
					list2.Add(item2);
				}
				else
				{
					list2.Add(vertices[y]);
				}
			}
			if (pb_Triangulation.TriangulateVertices(list2, out var triangles, unordered: false))
			{
				pb_FaceRebuildData pb_FaceRebuildData = new pb_FaceRebuildData();
				pb_FaceRebuildData.vertices = list2;
				pb_FaceRebuildData.face = new pb_Face(face);
				Vector3 rhs = pb_Math.Normal(list2, triangles);
				if (Vector3.Dot(lhs, rhs) < 0f)
				{
					triangles.Reverse();
				}
				pb_FaceRebuildData.face.SetIndices(triangles.ToArray());
				return pb_FaceRebuildData;
			}
			return null;
		}

		private static pb_Edge AlignEdgeWithDirection(pb_EdgeLookup edge, int commonIndex)
		{
			if (edge.common.x == commonIndex)
			{
				return new pb_Edge(edge.local.x, edge.local.y);
			}
			return new pb_Edge(edge.local.y, edge.local.x);
		}

		public static void Quantize(pb_Object pb, IList<int> indices, Vector3 snap)
		{
			Vector3[] vertices = pb.vertices;
			for (int i = 0; i < indices.Count; i++)
			{
				ref Vector3 reference = ref vertices[indices[i]];
				reference = pb.transform.InverseTransformPoint(pb_Snap.SnapValue(pb.transform.TransformPoint(vertices[indices[i]]), snap));
			}
		}
	}
	public static class pb_AppendDelete
	{
		public static pb_Face AppendFace(this pb_Object pb, Vector3[] v, Color[] c, Vector2[] u, pb_Face face)
		{
			int[] array = new int[v.Length];
			for (int i = 0; i < v.Length; i++)
			{
				array[i] = -1;
			}
			return pb.AppendFace(v, c, u, face, array);
		}

		public static pb_Face AppendFace(this pb_Object pb, Vector3[] v, Color[] c, Vector2[] u, pb_Face face, int[] sharedIndex)
		{
			int vertexCount = pb.vertexCount;
			Vector3[] array = new Vector3[vertexCount + v.Length];
			Color[] array2 = new Color[vertexCount + c.Length];
			Vector2[] array3 = new Vector2[pb.uv.Length + u.Length];
			List<pb_Face> list = new List<pb_Face>(pb.faces);
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			Array.Copy(pb.vertices, 0, array, 0, vertexCount);
			Array.Copy(v, 0, array, vertexCount, v.Length);
			Array.Copy(pb.colors, 0, array2, 0, vertexCount);
			Array.Copy(c, 0, array2, vertexCount, c.Length);
			Array.Copy(pb.uv, 0, array3, 0, pb.uv.Length);
			Array.Copy(u, 0, array3, pb.uv.Length, u.Length);
			face.ShiftIndicesToZero();
			face.ShiftIndices(vertexCount);
			face.RebuildCaches();
			list.Add(face);
			for (int i = 0; i < sharedIndex.Length; i++)
			{
				pb_IntArrayUtility.AddValueAtIndex(ref sharedIndices, sharedIndex[i], i + vertexCount);
			}
			pb.SetVertices(array);
			pb.SetColors(array2);
			pb.SetUV(array3);
			pb.SetSharedIndices(sharedIndices);
			pb.SetFaces(list.ToArray());
			return face;
		}

		public static pb_Face[] AppendFaces(this pb_Object pb, Vector3[][] new_Vertices, Color[][] new_Colors, Vector2[][] new_uvs, pb_Face[] new_Faces, int[][] new_SharedIndices)
		{
			List<Vector3> list = new List<Vector3>(pb.vertices);
			List<Color> list2 = new List<Color>(pb.colors);
			List<Vector2> list3 = new List<Vector2>(pb.uv);
			List<pb_Face> list4 = new List<pb_Face>(pb.faces);
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			int num = pb.vertexCount;
			for (int i = 0; i < new_Faces.Length; i++)
			{
				list.AddRange(new_Vertices[i]);
				list2.AddRange(new_Colors[i]);
				list3.AddRange(new_uvs[i]);
				new_Faces[i].ShiftIndicesToZero();
				new_Faces[i].ShiftIndices(num);
				new_Faces[i].RebuildCaches();
				list4.Add(new_Faces[i]);
				if (new_SharedIndices != null && new_Vertices[i].Length != new_SharedIndices[i].Length)
				{
					Debug.LogError("Append Face failed because sharedIndex array does not match new vertex array.");
					return null;
				}
				if (new_SharedIndices != null)
				{
					for (int j = 0; j < new_SharedIndices[i].Length; j++)
					{
						pb_IntArrayUtility.AddValueAtIndex(ref sharedIndices, new_SharedIndices[i][j], j + num);
					}
				}
				else
				{
					for (int k = 0; k < new_Vertices[i].Length; k++)
					{
						pb_IntArrayUtility.AddValueAtIndex(ref sharedIndices, -1, k + num);
					}
				}
				num = list.Count;
			}
			pb.SetSharedIndices(sharedIndices);
			pb.SetVertices(list.ToArray());
			pb.SetColors(list2.ToArray());
			pb.SetUV(list3.ToArray());
			pb.SetFaces(list4.ToArray());
			return new_Faces;
		}

		public static void DuplicateAndFlip(this pb_Object pb, pb_Face[] faces)
		{
			List<pb_FaceRebuildData> list = new List<pb_FaceRebuildData>();
			List<pb_Vertex> list2 = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			foreach (pb_Face pb_Face in faces)
			{
				pb_FaceRebuildData pb_FaceRebuildData = new pb_FaceRebuildData();
				pb_FaceRebuildData.vertices = new List<pb_Vertex>();
				pb_FaceRebuildData.face = new pb_Face(pb_Face);
				pb_FaceRebuildData.sharedIndices = new List<int>();
				Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
				int num = pb_FaceRebuildData.face.indices.Length;
				for (int j = 0; j < num; j++)
				{
					if (!dictionary2.ContainsKey(pb_Face.indices[j]))
					{
						dictionary2.Add(pb_Face.indices[j], dictionary2.Count);
						pb_FaceRebuildData.vertices.Add(list2[pb_Face.indices[j]]);
						pb_FaceRebuildData.sharedIndices.Add(dictionary[pb_Face.indices[j]]);
					}
				}
				for (int k = 0; k < num; k++)
				{
					pb_FaceRebuildData.face.indices[k] = dictionary2[pb_FaceRebuildData.face.indices[k]];
				}
				pb_FaceRebuildData.face.ReverseIndices();
				list.Add(pb_FaceRebuildData);
			}
			pb_FaceRebuildData.Apply(list, pb, list2, null, dictionary);
		}

		public static int[] DeleteFace(this pb_Object pb, pb_Face face)
		{
			return pb.DeleteFaces(new pb_Face[1] { face });
		}

		public static int[] DeleteFaces(this pb_Object pb, IEnumerable<pb_Face> faces)
		{
			return pb.DeleteFaces(faces.Select((pb_Face x) => Array.IndexOf(pb.faces, x)).ToList());
		}

		public static int[] DeleteFaces(this pb_Object pb, IList<int> faceIndices)
		{
			pb_Face[] array = new pb_Face[faceIndices.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = pb.faces[faceIndices[i]];
			}
			List<int> list = array.SelectMany((pb_Face x) => x.distinctIndices).Distinct().ToList();
			list.Sort();
			int num = pb.vertices.Length;
			Vector3[] vertices = pb.vertices.SortedRemoveAt(list);
			Color[] colors = pb.colors.SortedRemoveAt(list);
			Vector2[] uV = pb.uv.SortedRemoveAt(list);
			pb_Face[] array2 = pb.faces.RemoveAt(faceIndices);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			for (int num2 = 0; num2 < num; num2++)
			{
				dictionary.Add(num2, pbUtil.NearestIndexPriorToValue(list, num2) + 1);
			}
			for (int num3 = 0; num3 < array2.Length; num3++)
			{
				int[] indices = array2[num3].indices;
				for (int num4 = 0; num4 < indices.Length; num4++)
				{
					indices[num4] -= dictionary[indices[num4]];
				}
				array2[num3].SetIndices(indices);
			}
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			pb_IntArray[] sharedIndices2 = pb.sharedIndicesUV;
			pb_IntArrayUtility.RemoveValuesAndShift(ref sharedIndices, list);
			pb_IntArrayUtility.RemoveValuesAndShift(ref sharedIndices2, list);
			pb.SetSharedIndices(sharedIndices);
			pb.SetSharedIndicesUV(sharedIndices2);
			pb.SetVertices(vertices);
			pb.SetColors(colors);
			pb.SetUV(uV);
			pb.SetFaces(array2);
			return list.ToArray();
		}
	}
	public static class pb_AppendPolygon
	{
		private const int MAX_HOLE_ITERATIONS = 2048;

		public static pb_ActionResult CreatePolygon(this pb_Object pb, IList<int> indices, bool unordered, out pb_Face face)
		{
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			Dictionary<int, int> dictionary = sharedIndices.ToDictionary();
			HashSet<int> commonIndices = pb_IntArrayUtility.GetCommonIndices(dictionary, indices);
			List<pb_Vertex> list = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			List<pb_Vertex> list2 = new List<pb_Vertex>();
			foreach (int item in commonIndices)
			{
				int index = sharedIndices[item][0];
				list2.Add(new pb_Vertex(list[index]));
			}
			pb_FaceRebuildData pb_FaceRebuildData = FaceWithVertices(list2, unordered);
			if (pb_FaceRebuildData != null)
			{
				pb_FaceRebuildData.sharedIndices = commonIndices.ToList();
				List<pb_Face> list3 = new List<pb_Face>(pb.faces);
				pb_FaceRebuildData.Apply(new pb_FaceRebuildData[1] { pb_FaceRebuildData }, list, list3, dictionary);
				pb.SetVertices(list);
				pb.SetFaces(list3.ToArray());
				pb.SetSharedIndices(dictionary);
				face = pb_FaceRebuildData.face;
				return new pb_ActionResult(Status.Success, "Create Polygon");
			}
			face = null;
			return new pb_ActionResult(Status.Failure, (!unordered) ? "Points not ordered correctly" : "Too Few Unique Points Selected");
		}

		public static pb_ActionResult CreateShapeFromPolygon(this pb_PolyShape poly)
		{
			return poly.mesh.CreateShapeFromPolygon(poly.points, poly.extrude, poly.flipNormals);
		}

		public static pb_ActionResult CreateShapeFromPolygon(this pb_Object pb, IList<Vector3> points, float extrude, bool flipNormals)
		{
			if (points.Count < 3)
			{
				pb.SetVertices(new Vector3[0]);
				pb.SetFaces(new pb_Face[0]);
				pb.SetSharedIndices(new pb_IntArray[0]);
				return new pb_ActionResult(Status.NoChange, "Too Few Points");
			}
			Vector3[] array = points.ToArray();
			pb_Log.PushLogLevel(pb_LogLevel.Error);
			if (pb_Triangulation.TriangulateVertices(array, out var triangles, unordered: false))
			{
				int[] array2 = triangles.ToArray();
				if (pb_Math.PolygonArea(array, array2) < Mathf.Epsilon)
				{
					pb.SetVertices(new Vector3[0]);
					pb.SetFaces(new pb_Face[0]);
					pb.SetSharedIndices(new pb_IntArray[0]);
					pb_Log.PopLogLevel();
					return new pb_ActionResult(Status.Failure, "Polygon Area < Epsilon");
				}
				pb.GeometryWithVerticesFaces(array, new pb_Face[1]
				{
					new pb_Face(array2)
				});
				Vector3 rhs = pb_Math.Normal(pb, pb.faces[0]);
				if (Vector3.Dot(Vector3.up, rhs) > 0f)
				{
					pb.faces[0].ReverseIndices();
				}
				pb.DuplicateAndFlip(pb.faces);
				pb.Extrude(new pb_Face[1] { pb.faces[1] }, ExtrudeMethod.IndividualFaces, extrude);
				if ((extrude < 0f && !flipNormals) || (extrude > 0f && flipNormals))
				{
					pb.ReverseWindingOrder(pb.faces);
				}
				pb_Log.PopLogLevel();
				pb.ToMesh();
				pb.Refresh();
				return new pb_ActionResult(Status.Success, "Create Polygon Shape");
			}
			pb_Log.PopLogLevel();
			return new pb_ActionResult(Status.Failure, "Failed Triangulating Points");
		}

		public static pb_FaceRebuildData FaceWithVertices(List<pb_Vertex> vertices, bool unordered = true)
		{
			if (pb_Triangulation.TriangulateVertices(vertices, out var triangles, unordered))
			{
				pb_FaceRebuildData pb_FaceRebuildData = new pb_FaceRebuildData();
				pb_FaceRebuildData.vertices = vertices;
				pb_FaceRebuildData.face = new pb_Face(triangles.ToArray());
				return pb_FaceRebuildData;
			}
			return null;
		}

		public static List<pb_FaceRebuildData> TentCapWithVertices(List<pb_Vertex> path)
		{
			int count = path.Count;
			pb_Vertex item = pb_Vertex.Average(path);
			List<pb_FaceRebuildData> list = new List<pb_FaceRebuildData>();
			for (int i = 0; i < count; i++)
			{
				List<pb_Vertex> list2 = new List<pb_Vertex>();
				list2.Add(path[i]);
				list2.Add(item);
				list2.Add(path[(i + 1) % count]);
				List<pb_Vertex> vertices = list2;
				pb_FaceRebuildData pb_FaceRebuildData = new pb_FaceRebuildData();
				pb_FaceRebuildData.vertices = vertices;
				pb_FaceRebuildData.face = new pb_Face(new int[3] { 0, 1, 2 });
				list.Add(pb_FaceRebuildData);
			}
			return list;
		}

		public static List<List<pb_Edge>> FindHoles(pb_Object pb, IList<int> indices)
		{
			Dictionary<int, int> lookup = pb.sharedIndices.ToDictionary();
			HashSet<int> commonIndices = pb_IntArrayUtility.GetCommonIndices(lookup, indices);
			List<List<pb_Edge>> list = new List<List<pb_Edge>>();
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb);
			foreach (List<pb_WingedEdge> item in FindHoles(wingedEdges, commonIndices))
			{
				list.Add(item.Select((pb_WingedEdge x) => x.edge.local).ToList());
			}
			return list;
		}

		public static List<List<pb_WingedEdge>> FindHoles(List<pb_WingedEdge> wings, HashSet<int> common)
		{
			HashSet<pb_WingedEdge> hashSet = new HashSet<pb_WingedEdge>();
			List<List<pb_WingedEdge>> list = new List<List<pb_WingedEdge>>();
			for (int i = 0; i < wings.Count; i++)
			{
				pb_WingedEdge pb_WingedEdge = wings[i];
				if (pb_WingedEdge.opposite != null || hashSet.Contains(pb_WingedEdge) || (!common.Contains(pb_WingedEdge.edge.common.x) && !common.Contains(pb_WingedEdge.edge.common.y)))
				{
					continue;
				}
				List<pb_WingedEdge> list2 = new List<pb_WingedEdge>();
				pb_WingedEdge pb_WingedEdge2 = pb_WingedEdge;
				int num = pb_WingedEdge2.edge.common.x;
				int num2 = 0;
				while (pb_WingedEdge2 != null && num2++ < 2048)
				{
					hashSet.Add(pb_WingedEdge2);
					list2.Add(pb_WingedEdge2);
					num = ((pb_WingedEdge2.edge.common.x != num) ? pb_WingedEdge2.edge.common.x : pb_WingedEdge2.edge.common.y);
					pb_WingedEdge2 = FindNextEdgeInHole(pb_WingedEdge2, num);
					if (pb_WingedEdge2 == pb_WingedEdge)
					{
						break;
					}
				}
				List<pb_Tuple<int, int>> list3 = new List<pb_Tuple<int, int>>();
				for (int j = 0; j < list2.Count; j++)
				{
					pb_WingedEdge pb_WingedEdge3 = list2[j];
					for (int num3 = j - 1; num3 > -1; num3--)
					{
						if (pb_WingedEdge3.edge.common.y == list2[num3].edge.common.x)
						{
							list3.Add(new pb_Tuple<int, int>(num3, j));
							break;
						}
					}
				}
				int count = list3.Count;
				list3.Sort((pb_Tuple<int, int> x, pb_Tuple<int, int> y) => x.Item1.CompareTo(y.Item1));
				int[] array = new int[count];
				for (int num4 = count - 1; num4 > -1; num4--)
				{
					int item = list3[num4].Item1;
					int num5 = list3[num4].Item2 - array[num4];
					int num6 = num5 - item + 1;
					List<pb_WingedEdge> range = list2.GetRange(item, num6);
					list2.RemoveRange(item, num6);
					for (int num7 = num4 - 1; num7 > -1; num7--)
					{
						if (list3[num7].Item2 > list3[num4].Item2)
						{
							array[num7] += num6;
						}
					}
					if (count < 2 || range.Any((pb_WingedEdge w) => common.Contains(w.edge.common.x)) || range.Any((pb_WingedEdge w) => common.Contains(w.edge.common.y)))
					{
						list.Add(range);
					}
				}
			}
			return list;
		}

		private static pb_WingedEdge FindNextEdgeInHole(pb_WingedEdge wing, int common)
		{
			pb_WingedEdge adjacentEdgeWithCommonIndex = wing.GetAdjacentEdgeWithCommonIndex(common);
			int num = 0;
			while (adjacentEdgeWithCommonIndex != null && adjacentEdgeWithCommonIndex != wing && num++ < 2048)
			{
				if (adjacentEdgeWithCommonIndex.opposite == null)
				{
					return adjacentEdgeWithCommonIndex;
				}
				adjacentEdgeWithCommonIndex = adjacentEdgeWithCommonIndex.opposite.GetAdjacentEdgeWithCommonIndex(common);
			}
			return null;
		}
	}
	public static class pb_Bevel
	{
		private static readonly int[] BRIDGE_INDICES_NRM = new int[3] { 2, 1, 0 };

		public static pb_ActionResult BevelEdges(pb_Object pb, IList<pb_Edge> edges, float amount, out List<pb_Face> createdFaces)
		{
			createdFaces = null;
			Dictionary<int, int> lookup = pb.sharedIndices.ToDictionary();
			List<pb_Vertex> list = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			List<pb_EdgeLookup> list2 = pb_EdgeLookup.GetEdgeLookup(edges, lookup).Distinct().ToList();
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb);
			List<pb_FaceRebuildData> list3 = new List<pb_FaceRebuildData>();
			Dictionary<pb_Face, List<int>> ignore = new Dictionary<pb_Face, List<int>>();
			HashSet<int> hashSet = new HashSet<int>();
			int num = 0;
			Dictionary<int, List<pb_Tuple<pb_FaceRebuildData, List<int>>>> dictionary = new Dictionary<int, List<pb_Tuple<pb_FaceRebuildData, List<int>>>>();
			Dictionary<int, List<pb_WingedEdge>> spokes = pb_WingedEdge.GetSpokes(wingedEdges);
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (pb_EdgeLookup item in list2)
			{
				if (hashSet2.Add(item.common.x))
				{
					foreach (pb_WingedEdge item2 in spokes[item.common.x])
					{
						pb_Edge local = item2.edge.local;
						amount = Mathf.Min(Vector3.Distance(list[local.x].position, list[local.y].position) - 0.001f, amount);
					}
				}
				if (!hashSet2.Add(item.common.y))
				{
					continue;
				}
				foreach (pb_WingedEdge item3 in spokes[item.common.y])
				{
					pb_Edge local2 = item3.edge.local;
					amount = Mathf.Min(Vector3.Distance(list[local2.x].position, list[local2.y].position) - 0.001f, amount);
				}
			}
			if (amount < 0.001f)
			{
				return new pb_ActionResult(Status.Canceled, "Bevel Distance > Available Surface");
			}
			foreach (pb_EdgeLookup lup in list2)
			{
				pb_WingedEdge pb_WingedEdge = wingedEdges.FirstOrDefault((pb_WingedEdge x) => x.edge.Equals(lup));
				if (pb_WingedEdge != null && pb_WingedEdge.opposite != null)
				{
					num++;
					ignore.AddOrAppend(pb_WingedEdge.face, pb_WingedEdge.edge.common.x);
					ignore.AddOrAppend(pb_WingedEdge.face, pb_WingedEdge.edge.common.y);
					ignore.AddOrAppend(pb_WingedEdge.opposite.face, pb_WingedEdge.edge.common.x);
					ignore.AddOrAppend(pb_WingedEdge.opposite.face, pb_WingedEdge.edge.common.y);
					hashSet.Add(pb_WingedEdge.edge.common.x);
					hashSet.Add(pb_WingedEdge.edge.common.y);
					SlideEdge(list, pb_WingedEdge, amount);
					SlideEdge(list, pb_WingedEdge.opposite, amount);
					list3.AddRange(GetBridgeFaces(list, pb_WingedEdge, pb_WingedEdge.opposite, dictionary));
				}
			}
			if (num < 1)
			{
				createdFaces = null;
				return new pb_ActionResult(Status.Canceled, "Cannot Bevel Open Edges");
			}
			createdFaces = new List<pb_Face>(list3.Select((pb_FaceRebuildData x) => x.face));
			Dictionary<pb_Face, List<pb_Tuple<pb_WingedEdge, int>>> dictionary2 = new Dictionary<pb_Face, List<pb_Tuple<pb_WingedEdge, int>>>();
			foreach (int c in hashSet)
			{
				IEnumerable<pb_WingedEdge> enumerable = wingedEdges.Where((pb_WingedEdge x) => x.edge.common.Contains(c) && (!ignore.ContainsKey(x.face) || !ignore[x.face].Contains(c)));
				HashSet<pb_Face> hashSet3 = new HashSet<pb_Face>();
				foreach (pb_WingedEdge item4 in enumerable)
				{
					if (hashSet3.Add(item4.face))
					{
						dictionary2.AddOrAppend(item4.face, new pb_Tuple<pb_WingedEdge, int>(item4, c));
					}
				}
			}
			foreach (KeyValuePair<pb_Face, List<pb_Tuple<pb_WingedEdge, int>>> item5 in dictionary2)
			{
				Dictionary<int, List<int>> appendedVertices;
				pb_FaceRebuildData pb_FaceRebuildData = pbVertexOps.ExplodeVertex(list, item5.Value, amount, out appendedVertices);
				if (pb_FaceRebuildData == null)
				{
					continue;
				}
				list3.Add(pb_FaceRebuildData);
				foreach (KeyValuePair<int, List<int>> item6 in appendedVertices)
				{
					dictionary.AddOrAppend(item6.Key, new pb_Tuple<pb_FaceRebuildData, List<int>>(pb_FaceRebuildData, item6.Value));
				}
			}
			pb_FaceRebuildData.Apply(list3, pb, list);
			int num2 = pb.DeleteFaces(dictionary2.Keys).Length;
			pb.SetSharedIndicesUV(new pb_IntArray[0]);
			pb.SetSharedIndices(pb_IntArrayUtility.ExtractSharedIndices(pb.vertices));
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			lookup = sharedIndices.ToDictionary();
			List<HashSet<int>> list4 = new List<HashSet<int>>();
			foreach (KeyValuePair<int, List<pb_Tuple<pb_FaceRebuildData, List<int>>>> item7 in dictionary)
			{
				if (item7.Value.Sum((pb_Tuple<pb_FaceRebuildData, List<int>> x) => x.Item2.Count) < 3)
				{
					continue;
				}
				HashSet<int> hashSet4 = new HashSet<int>();
				foreach (pb_Tuple<pb_FaceRebuildData, List<int>> item8 in item7.Value)
				{
					int num3 = item8.Item1.Offset() - num2;
					for (int num4 = 0; num4 < item8.Item2.Count; num4++)
					{
						hashSet4.Add(lookup[item8.Item2[num4] + num3]);
					}
				}
				list4.Add(hashSet4);
			}
			List<pb_WingedEdge> wingedEdges2 = pb_WingedEdge.GetWingedEdges(pb, list3.Select((pb_FaceRebuildData x) => x.face));
			list = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			List<pb_FaceRebuildData> list5 = new List<pb_FaceRebuildData>();
			foreach (HashSet<int> item9 in list4)
			{
				if (item9.Count < 3)
				{
					continue;
				}
				if (item9.Count < 4)
				{
					List<pb_Vertex> vertices = new List<pb_Vertex>(pb_Vertex.GetVertices(pb, item9.Select((int x) => sharedIndices[x][0]).ToList()));
					list5.Add(pb_AppendPolygon.FaceWithVertices(vertices));
					continue;
				}
				List<int> source = pb_WingedEdge.SortCommonIndicesByAdjacency(wingedEdges2, item9);
				List<pb_Vertex> path = new List<pb_Vertex>(pb_Vertex.GetVertices(pb, source.Select((int x) => sharedIndices[x][0]).ToList()));
				list5.AddRange(pb_AppendPolygon.TentCapWithVertices(path));
			}
			pb_FaceRebuildData.Apply(list5, pb, list);
			pb.SetSharedIndices(pb_IntArrayUtility.ExtractSharedIndices(pb.vertices));
			HashSet<pb_Face> hashSet5 = new HashSet<pb_Face>(list5.Select((pb_FaceRebuildData x) => x.face));
			list3.AddRange(list5);
			List<pb_WingedEdge> wingedEdges3 = pb_WingedEdge.GetWingedEdges(pb, list3.Select((pb_FaceRebuildData x) => x.face));
			for (int num5 = 0; num5 < wingedEdges3.Count; num5++)
			{
				if (hashSet5.Count <= 0)
				{
					break;
				}
				pb_WingedEdge pb_WingedEdge2 = wingedEdges3[num5];
				if (!hashSet5.Contains(pb_WingedEdge2.face))
				{
					continue;
				}
				hashSet5.Remove(pb_WingedEdge2.face);
				foreach (pb_WingedEdge item10 in pb_WingedEdge2)
				{
					if (!hashSet5.Contains(item10.opposite.face))
					{
						item10.face.material = item10.opposite.face.material;
						item10.face.uv = new pb_UV(item10.opposite.face.uv);
						pb_ConformNormals.ConformOppositeNormal(item10.opposite);
						break;
					}
				}
			}
			pb.ToMesh();
			return new pb_ActionResult(Status.Success, "Bevel Edges");
		}

		private static List<pb_FaceRebuildData> GetBridgeFaces(IList<pb_Vertex> vertices, pb_WingedEdge left, pb_WingedEdge right, Dictionary<int, List<pb_Tuple<pb_FaceRebuildData, List<int>>>> holes)
		{
			List<pb_FaceRebuildData> list = new List<pb_FaceRebuildData>();
			pb_FaceRebuildData pb_FaceRebuildData = new pb_FaceRebuildData();
			pb_EdgeLookup edge = left.edge;
			pb_EdgeLookup edge2 = right.edge;
			pb_FaceRebuildData.vertices = new List<pb_Vertex>
			{
				vertices[edge.local.x],
				vertices[edge.local.y],
				vertices[(edge.common.x != edge2.common.x) ? edge2.local.y : edge2.local.x],
				vertices[(edge.common.x != edge2.common.x) ? edge2.local.x : edge2.local.y]
			};
			Vector3 lhs = pb_Math.Normal(vertices, left.face.indices);
			Vector3 rhs = pb_Math.Normal(pb_FaceRebuildData.vertices, BRIDGE_INDICES_NRM);
			int[] array = new int[6] { 2, 1, 0, 2, 3, 1 };
			if (Vector3.Dot(lhs, rhs) < 0f)
			{
				Array.Reverse(array);
			}
			pb_FaceRebuildData.face = new pb_Face(array, left.face.material, new pb_UV(), -1, -1, -1, manualUV: false);
			list.Add(pb_FaceRebuildData);
			holes.AddOrAppend(edge.common.x, new pb_Tuple<pb_FaceRebuildData, List<int>>(pb_FaceRebuildData, new List<int> { 0, 2 }));
			holes.AddOrAppend(edge.common.y, new pb_Tuple<pb_FaceRebuildData, List<int>>(pb_FaceRebuildData, new List<int> { 1, 3 }));
			return list;
		}

		private static void SlideEdge(IList<pb_Vertex> vertices, pb_WingedEdge we, float amount)
		{
			we.face.manualUV = true;
			we.face.textureGroup = -1;
			pb_Edge leadingEdge = GetLeadingEdge(we, we.edge.common.x);
			pb_Edge leadingEdge2 = GetLeadingEdge(we, we.edge.common.y);
			if (leadingEdge != null && leadingEdge2 != null)
			{
				pb_Vertex pb_Vertex = vertices[leadingEdge.x] - vertices[leadingEdge.y];
				pb_Vertex.Normalize();
				pb_Vertex pb_Vertex2 = vertices[leadingEdge2.x] - vertices[leadingEdge2.y];
				pb_Vertex2.Normalize();
				vertices[we.edge.local.x].Add(pb_Vertex * amount);
				vertices[we.edge.local.y].Add(pb_Vertex2 * amount);
			}
		}

		private static pb_Edge GetLeadingEdge(pb_WingedEdge wing, int common)
		{
			if (wing.previous.edge.common.x == common)
			{
				return new pb_Edge(wing.previous.edge.local.y, wing.previous.edge.local.x);
			}
			if (wing.previous.edge.common.y == common)
			{
				return new pb_Edge(wing.previous.edge.local.x, wing.previous.edge.local.y);
			}
			if (wing.next.edge.common.x == common)
			{
				return new pb_Edge(wing.next.edge.local.y, wing.next.edge.local.x);
			}
			if (wing.next.edge.common.y == common)
			{
				return new pb_Edge(wing.next.edge.local.x, wing.next.edge.local.y);
			}
			return null;
		}
	}
	public static class pb_ConformNormals
	{
		public static pb_ActionResult ConformNormals(this pb_Object pb, IList<pb_Face> faces)
		{
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb, faces);
			HashSet<pb_Face> hashSet = new HashSet<pb_Face>();
			int num = 0;
			for (int i = 0; i < wingedEdges.Count; i++)
			{
				if (hashSet.Contains(wingedEdges[i].face))
				{
					continue;
				}
				Dictionary<pb_Face, bool> dictionary = new Dictionary<pb_Face, bool>();
				GetWindingFlags(wingedEdges[i], flag: true, dictionary);
				int num2 = 0;
				foreach (KeyValuePair<pb_Face, bool> item in dictionary)
				{
					num2 += (item.Value ? 1 : (-1));
				}
				bool flag = num2 > 0;
				foreach (KeyValuePair<pb_Face, bool> item2 in dictionary)
				{
					if (flag != item2.Value)
					{
						num++;
						item2.Key.ReverseIndices();
					}
				}
				hashSet.UnionWith(dictionary.Keys);
			}
			if (num > 0)
			{
				return new pb_ActionResult(Status.Success, (num <= 1) ? "Flipped 1 face" : $"Flipped {num} faces");
			}
			return new pb_ActionResult(Status.NoChange, "Faces Uniform");
		}

		private static void GetWindingFlags(pb_WingedEdge edge, bool flag, Dictionary<pb_Face, bool> flags)
		{
			flags.Add(edge.face, flag);
			pb_WingedEdge pb_WingedEdge = edge;
			do
			{
				pb_WingedEdge opposite = pb_WingedEdge.opposite;
				if (opposite != null && !flags.ContainsKey(opposite.face))
				{
					pb_Edge commonEdgeInWindingOrder = GetCommonEdgeInWindingOrder(pb_WingedEdge);
					pb_Edge commonEdgeInWindingOrder2 = GetCommonEdgeInWindingOrder(opposite);
					GetWindingFlags(opposite, (commonEdgeInWindingOrder.x != commonEdgeInWindingOrder2.x) ? flag : (!flag), flags);
				}
				pb_WingedEdge = pb_WingedEdge.next;
			}
			while (pb_WingedEdge != edge);
		}

		public static pb_ActionResult ConformOppositeNormal(pb_WingedEdge source)
		{
			if (source == null || source.opposite == null)
			{
				return new pb_ActionResult(Status.Failure, "Source edge does not share an edge with another face.");
			}
			pb_Edge commonEdgeInWindingOrder = GetCommonEdgeInWindingOrder(source);
			pb_Edge commonEdgeInWindingOrder2 = GetCommonEdgeInWindingOrder(source.opposite);
			if (commonEdgeInWindingOrder.x == commonEdgeInWindingOrder2.x)
			{
				source.opposite.face.ReverseIndices();
				return new pb_ActionResult(Status.Success, "Reversed target face winding order.");
			}
			return new pb_ActionResult(Status.NoChange, "Faces already unified.");
		}

		private static pb_Edge GetCommonEdgeInWindingOrder(pb_WingedEdge wing)
		{
			int[] indices = wing.face.indices;
			int num = indices.Length;
			for (int i = 0; i < num; i += 3)
			{
				pb_Edge local = wing.edge.local;
				int num2 = indices[i];
				int num3 = indices[i + 1];
				int num4 = indices[i + 2];
				if (local.x == num2 && local.y == num3)
				{
					return new pb_Edge(wing.edge.common);
				}
				if (local.x == num3 && local.y == num2)
				{
					return new pb_Edge(wing.edge.common.y, wing.edge.common.x);
				}
				if (local.x == num3 && local.y == num4)
				{
					return new pb_Edge(wing.edge.common);
				}
				if (local.x == num4 && local.y == num3)
				{
					return new pb_Edge(wing.edge.common.y, wing.edge.common.x);
				}
				if (local.x == num4 && local.y == num2)
				{
					return new pb_Edge(wing.edge.common);
				}
				if (local.x == num2 && local.y == num4)
				{
					return new pb_Edge(wing.edge.common.y, wing.edge.common.x);
				}
			}
			return null;
		}

		public static void MatchNormal(pb_Face source, pb_Face target, Dictionary<int, int> lookup)
		{
			List<pb_EdgeLookup> list = pb_EdgeLookup.GetEdgeLookup(source.edges, lookup).ToList();
			List<pb_EdgeLookup> list2 = pb_EdgeLookup.GetEdgeLookup(target.edges, lookup).ToList();
			bool flag = false;
			int num = 0;
			while (!flag && num < list.Count)
			{
				pb_Edge common = list[num].common;
				int num2 = 0;
				while (!flag && num2 < list2.Count)
				{
					pb_Edge common2 = list2[num2].common;
					if (common.Equals(common2))
					{
						if (common.x == common2.x)
						{
							target.ReverseIndices();
						}
						flag = true;
					}
					num2++;
				}
				num++;
			}
		}
	}
	internal class ConnectFaceRebuildData
	{
		public pb_FaceRebuildData faceRebuildData;

		public List<int> newVertexIndices;

		public ConnectFaceRebuildData(pb_FaceRebuildData faceRebuildData, List<int> newVertexIndices)
		{
			this.faceRebuildData = faceRebuildData;
			this.newVertexIndices = newVertexIndices;
		}
	}
	public static class pb_ConnectEdges
	{
		public static pb_ActionResult Connect(this pb_Object pb, IEnumerable<pb_Face> faces, out pb_Face[] subdividedFaces)
		{
			IEnumerable<pb_Edge> edges = faces.SelectMany((pb_Face x) => x.edges);
			HashSet<pb_Face> faceMask = new HashSet<pb_Face>(faces);
			pb_Edge[] connections;
			return pb.Connect(edges, out subdividedFaces, out connections, returnFaces: true, returnEdges: false, faceMask);
		}

		public static pb_ActionResult Connect(this pb_Object pb, IEnumerable<pb_Edge> edges, out pb_Face[] faces)
		{
			pb_Edge[] connections;
			return pb.Connect(edges, out faces, out connections, returnFaces: true);
		}

		public static pb_ActionResult Connect(this pb_Object pb, IEnumerable<pb_Edge> edges, out pb_Edge[] connections)
		{
			pb_Face[] addedFaces;
			return pb.Connect(edges, out addedFaces, out connections, returnFaces: false, returnEdges: true);
		}

		private static pb_ActionResult Connect(this pb_Object pb, IEnumerable<pb_Edge> edges, out pb_Face[] addedFaces, out pb_Edge[] connections, bool returnFaces = false, bool returnEdges = false, HashSet<pb_Face> faceMask = null)
		{
			Dictionary<int, int> lookup = pb.sharedIndices.ToDictionary();
			Dictionary<int, int> lookupUV = ((pb.sharedIndicesUV == null) ? null : pb.sharedIndicesUV.ToDictionary());
			HashSet<pb_EdgeLookup> hashSet = new HashSet<pb_EdgeLookup>(pb_EdgeLookup.GetEdgeLookup(edges, lookup));
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb);
			Dictionary<pb_Face, List<pb_WingedEdge>> dictionary = new Dictionary<pb_Face, List<pb_WingedEdge>>();
			foreach (pb_WingedEdge item in wingedEdges)
			{
				if (hashSet.Contains(item.edge))
				{
					if (dictionary.TryGetValue(item.face, out var value))
					{
						value.Add(item);
						continue;
					}
					dictionary.Add(item.face, new List<pb_WingedEdge> { item });
				}
			}
			Dictionary<pb_Face, List<pb_WingedEdge>> dictionary2 = new Dictionary<pb_Face, List<pb_WingedEdge>>();
			foreach (KeyValuePair<pb_Face, List<pb_WingedEdge>> item2 in dictionary)
			{
				if (item2.Value.Count <= 1)
				{
					pb_WingedEdge opposite = item2.Value[0].opposite;
					if (opposite == null || !dictionary.TryGetValue(opposite.face, out var value2) || value2.Count <= 1)
					{
						continue;
					}
				}
				dictionary2.Add(item2.Key, item2.Value);
			}
			List<pb_Vertex> vertices = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			List<ConnectFaceRebuildData> list = new List<ConnectFaceRebuildData>();
			List<pb_Face> list2 = new List<pb_Face>();
			HashSet<int> hashSet2 = new HashSet<int>(pb.faces.Select((pb_Face x) => x.textureGroup));
			int num = 1;
			foreach (KeyValuePair<pb_Face, List<pb_WingedEdge>> item3 in dictionary2)
			{
				pb_Face key = item3.Key;
				List<pb_WingedEdge> value3 = item3.Value;
				int count = value3.Count;
				Vector3 lhs = pb_Math.Normal(vertices, key.indices);
				if (count == 1 || (faceMask != null && !faceMask.Contains(key)))
				{
					ConnectFaceRebuildData connectFaceRebuildData = InsertVertices(key, value3, vertices);
					Vector3 rhs = pb_Math.Normal(connectFaceRebuildData.faceRebuildData.vertices, connectFaceRebuildData.faceRebuildData.face.indices);
					if (Vector3.Dot(lhs, rhs) < 0f)
					{
						connectFaceRebuildData.faceRebuildData.face.ReverseIndices();
					}
					list.Add(connectFaceRebuildData);
				}
				else
				{
					if (count <= 1)
					{
						continue;
					}
					List<ConnectFaceRebuildData> list3 = ((count != 2) ? ConnectEdgesInFace(key, value3, vertices) : ConnectEdgesInFace(key, value3[0], value3[1], vertices));
					if (key.textureGroup < 0)
					{
						for (; hashSet2.Contains(num); num++)
						{
						}
						hashSet2.Add(num);
					}
					foreach (ConnectFaceRebuildData item4 in list3)
					{
						list2.Add(item4.faceRebuildData.face);
						Vector3 rhs2 = pb_Math.Normal(item4.faceRebuildData.vertices, item4.faceRebuildData.face.indices);
						if (Vector3.Dot(lhs, rhs2) < 0f)
						{
							item4.faceRebuildData.face.ReverseIndices();
						}
						item4.faceRebuildData.face.textureGroup = ((key.textureGroup >= 0) ? key.textureGroup : num);
						item4.faceRebuildData.face.uv = new pb_UV(key.uv);
						item4.faceRebuildData.face.smoothingGroup = key.smoothingGroup;
						item4.faceRebuildData.face.manualUV = key.manualUV;
						item4.faceRebuildData.face.material = key.material;
					}
					list.AddRange(list3);
				}
			}
			pb_FaceRebuildData.Apply(list.Select((ConnectFaceRebuildData x) => x.faceRebuildData), pb, vertices, null, lookup, lookupUV);
			pb.SetSharedIndicesUV(new pb_IntArray[0]);
			int num2 = pb.DeleteFaces(dictionary2.Keys).Length;
			pb.SetSharedIndices(pb_IntArrayUtility.ExtractSharedIndices(pb.vertices));
			pb.ToMesh();
			if (returnEdges)
			{
				HashSet<int> appendedIndices = new HashSet<int>();
				for (int num3 = 0; num3 < list.Count; num3++)
				{
					for (int num4 = 0; num4 < list[num3].newVertexIndices.Count; num4++)
					{
						appendedIndices.Add(list[num3].newVertexIndices[num4] + list[num3].faceRebuildData.Offset() - num2);
					}
				}
				Dictionary<int, int> lookup2 = pb.sharedIndices.ToDictionary();
				IEnumerable<pb_Edge> edges2 = from x in list.SelectMany((ConnectFaceRebuildData x) => x.faceRebuildData.face.edges)
					where appendedIndices.Contains(x.x) && appendedIndices.Contains(x.y)
					select x;
				IEnumerable<pb_EdgeLookup> edgeLookup = pb_EdgeLookup.GetEdgeLookup(edges2, lookup2);
				connections = (from x in edgeLookup.Distinct()
					select x.local).ToArray();
			}
			else
			{
				connections = null;
			}
			if (returnFaces)
			{
				addedFaces = list2.ToArray();
			}
			else
			{
				addedFaces = null;
			}
			return new pb_ActionResult(Status.Success, $"Connected {list.Count} Edges");
		}

		private static List<ConnectFaceRebuildData> ConnectEdgesInFace(pb_Face face, pb_WingedEdge a, pb_WingedEdge b, List<pb_Vertex> vertices)
		{
			List<pb_Edge> list = pb_WingedEdge.SortEdgesByAdjacency(face);
			List<pb_Vertex>[] array = new List<pb_Vertex>[2]
			{
				new List<pb_Vertex>(),
				new List<pb_Vertex>()
			};
			List<int>[] array2 = new List<int>[2]
			{
				new List<int>(),
				new List<int>()
			};
			int num = 0;
			for (int i = 0; i < list.Count; i++)
			{
				array[num % 2].Add(vertices[list[i].x]);
				if (list[i].Equals(a.edge.local) || list[i].Equals(b.edge.local))
				{
					pb_Vertex item = pb_Vertex.Mix(vertices[list[i].x], vertices[list[i].y], 0.5f);
					array2[num % 2].Add(array[num % 2].Count);
					array[num % 2].Add(item);
					num++;
					array2[num % 2].Add(array[num % 2].Count);
					array[num % 2].Add(item);
				}
			}
			List<ConnectFaceRebuildData> list2 = new List<ConnectFaceRebuildData>();
			for (int j = 0; j < array.Length; j++)
			{
				pb_FaceRebuildData faceRebuildData = pb_AppendPolygon.FaceWithVertices(array[j], unordered: false);
				list2.Add(new ConnectFaceRebuildData(faceRebuildData, array2[j]));
			}
			return list2;
		}

		private static List<ConnectFaceRebuildData> ConnectEdgesInFace(pb_Face face, List<pb_WingedEdge> edges, List<pb_Vertex> vertices)
		{
			List<pb_Edge> list = pb_WingedEdge.SortEdgesByAdjacency(face);
			int count = edges.Count;
			pb_Vertex item = pb_Vertex.Average(vertices, face.distinctIndices);
			List<List<pb_Vertex>> list2 = pbUtil.Fill((int x) => new List<pb_Vertex>(), count);
			List<List<int>> list3 = pbUtil.Fill((int x) => new List<int>(), count);
			HashSet<pb_Edge> hashSet = new HashSet<pb_Edge>(edges.Select((pb_WingedEdge x) => x.edge.local));
			int num = 0;
			for (int num2 = 0; num2 < list.Count; num2++)
			{
				list2[num % count].Add(vertices[list[num2].x]);
				if (hashSet.Contains(list[num2]))
				{
					pb_Vertex item2 = pb_Vertex.Mix(vertices[list[num2].x], vertices[list[num2].y], 0.5f);
					list3[num].Add(list2[num].Count);
					list2[num].Add(item2);
					list3[num].Add(list2[num].Count);
					list2[num].Add(item);
					num = (num + 1) % count;
					list2[num].Add(item2);
				}
			}
			List<ConnectFaceRebuildData> list4 = new List<ConnectFaceRebuildData>();
			for (int num3 = 0; num3 < list2.Count; num3++)
			{
				pb_FaceRebuildData faceRebuildData = pb_AppendPolygon.FaceWithVertices(list2[num3], unordered: false);
				list4.Add(new ConnectFaceRebuildData(faceRebuildData, list3[num3]));
			}
			return list4;
		}

		private static ConnectFaceRebuildData InsertVertices(pb_Face face, List<pb_WingedEdge> edges, List<pb_Vertex> vertices)
		{
			List<pb_Edge> list = pb_WingedEdge.SortEdgesByAdjacency(face);
			List<pb_Vertex> list2 = new List<pb_Vertex>();
			List<int> list3 = new List<int>();
			HashSet<pb_Edge> hashSet = new HashSet<pb_Edge>(edges.Select((pb_WingedEdge x) => x.edge.local));
			for (int num = 0; num < list.Count; num++)
			{
				list2.Add(vertices[list[num].x]);
				if (hashSet.Contains(list[num]))
				{
					list3.Add(list2.Count);
					list2.Add(pb_Vertex.Mix(vertices[list[num].x], vertices[list[num].y], 0.5f));
				}
			}
			pb_FaceRebuildData pb_FaceRebuildData = pb_AppendPolygon.FaceWithVertices(list2, unordered: false);
			pb_FaceRebuildData.face.textureGroup = face.textureGroup;
			pb_FaceRebuildData.face.uv = new pb_UV(face.uv);
			pb_FaceRebuildData.face.smoothingGroup = face.smoothingGroup;
			pb_FaceRebuildData.face.manualUV = face.manualUV;
			pb_FaceRebuildData.face.material = face.material;
			return new ConnectFaceRebuildData(pb_FaceRebuildData, list3);
		}
	}
	public static class pb_ConnectVertices
	{
		public static pb_ActionResult Connect(this pb_Object pb, IList<int> indices, out int[] newVertices)
		{
			int num = pb.sharedIndices.Length;
			Dictionary<int, int> lookup = pb.sharedIndices.ToDictionary();
			HashSet<int> hashSet = new HashSet<int>(indices.Select((int x) => lookup[x]));
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (int item in hashSet)
			{
				hashSet2.UnionWith(pb.sharedIndices[item].array);
			}
			Dictionary<pb_Face, List<int>> dictionary = new Dictionary<pb_Face, List<int>>();
			List<pb_Vertex> vertices = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			pb_Face[] faces = pb.faces;
			foreach (pb_Face pb_Face in faces)
			{
				int[] distinctIndices = pb_Face.distinctIndices;
				for (int num3 = 0; num3 < distinctIndices.Length; num3++)
				{
					if (hashSet2.Contains(distinctIndices[num3]))
					{
						dictionary.AddOrAppend(pb_Face, distinctIndices[num3]);
					}
				}
			}
			List<ConnectFaceRebuildData> list = new List<ConnectFaceRebuildData>();
			List<pb_Face> list2 = new List<pb_Face>();
			HashSet<int> hashSet3 = new HashSet<int>(pb.faces.Select((pb_Face x) => x.textureGroup));
			int num4 = 1;
			foreach (KeyValuePair<pb_Face, List<int>> item2 in dictionary)
			{
				pb_Face key = item2.Key;
				List<ConnectFaceRebuildData> list3 = ((item2.Value.Count != 2) ? ConnectIndicesInFace(key, item2.Value, vertices, lookup, num++) : ConnectIndicesInFace(key, item2.Value[0], item2.Value[1], vertices, lookup));
				if (list3 == null)
				{
					continue;
				}
				if (key.textureGroup < 0)
				{
					for (; hashSet3.Contains(num4); num4++)
					{
					}
					hashSet3.Add(num4);
				}
				foreach (ConnectFaceRebuildData item3 in list3)
				{
					item3.faceRebuildData.face.textureGroup = ((key.textureGroup >= 0) ? key.textureGroup : num4);
					item3.faceRebuildData.face.uv = new pb_UV(key.uv);
					item3.faceRebuildData.face.smoothingGroup = key.smoothingGroup;
					item3.faceRebuildData.face.manualUV = key.manualUV;
					item3.faceRebuildData.face.material = key.material;
				}
				list2.Add(key);
				list.AddRange(list3);
			}
			pb_FaceRebuildData.Apply(list.Select((ConnectFaceRebuildData x) => x.faceRebuildData), pb, vertices, null, lookup);
			pb.SetSharedIndices(lookup);
			pb.SetSharedIndicesUV(new pb_IntArray[0]);
			int num5 = pb.DeleteFaces(list2).Length;
			lookup = pb.sharedIndices.ToDictionary();
			HashSet<int> hashSet4 = new HashSet<int>();
			for (int num6 = 0; num6 < list.Count; num6++)
			{
				for (int num7 = 0; num7 < list[num6].newVertexIndices.Count; num7++)
				{
					hashSet4.Add(lookup[list[num6].newVertexIndices[num7] + (list[num6].faceRebuildData.Offset() - num5)]);
				}
			}
			newVertices = hashSet4.Select((int x) => pb.sharedIndices[x][0]).ToArray();
			pb.ToMesh();
			return new pb_ActionResult(Status.Success, $"Connected {hashSet.Count} Vertices");
		}

		private static List<ConnectFaceRebuildData> ConnectIndicesInFace(pb_Face face, int a, int b, List<pb_Vertex> vertices, Dictionary<int, int> lookup)
		{
			List<pb_Edge> list = pb_WingedEdge.SortEdgesByAdjacency(face);
			List<pb_Vertex>[] array = new List<pb_Vertex>[2]
			{
				new List<pb_Vertex>(),
				new List<pb_Vertex>()
			};
			List<int>[] array2 = new List<int>[2]
			{
				new List<int>(),
				new List<int>()
			};
			List<int>[] array3 = new List<int>[2]
			{
				new List<int>(),
				new List<int>()
			};
			int num = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Contains(a) && list[i].Contains(b))
				{
					return null;
				}
				int x = list[i].x;
				array[num].Add(vertices[x]);
				array2[num].Add(lookup[x]);
				if (x == a || x == b)
				{
					num = (num + 1) % 2;
					array3[num].Add(array[num].Count);
					array[num].Add(vertices[x]);
					array2[num].Add(lookup[x]);
				}
			}
			List<ConnectFaceRebuildData> list2 = new List<ConnectFaceRebuildData>();
			Vector3 lhs = pb_Math.Normal(vertices, face.indices);
			for (int j = 0; j < array.Length; j++)
			{
				pb_FaceRebuildData pb_FaceRebuildData = pb_AppendPolygon.FaceWithVertices(array[j], unordered: false);
				pb_FaceRebuildData.sharedIndices = array2[j];
				Vector3 rhs = pb_Math.Normal(array[j], pb_FaceRebuildData.face.indices);
				if (Vector3.Dot(lhs, rhs) < 0f)
				{
					pb_FaceRebuildData.face.ReverseIndices();
				}
				list2.Add(new ConnectFaceRebuildData(pb_FaceRebuildData, array3[j]));
			}
			return list2;
		}

		private static List<ConnectFaceRebuildData> ConnectIndicesInFace(pb_Face face, List<int> indices, List<pb_Vertex> vertices, Dictionary<int, int> lookup, int sharedIndexOffset)
		{
			if (indices.Count < 3)
			{
				return null;
			}
			List<pb_Edge> list = pb_WingedEdge.SortEdgesByAdjacency(face);
			int count = indices.Count;
			List<List<pb_Vertex>> list2 = pbUtil.Fill((int num4) => new List<pb_Vertex>(), count);
			List<List<int>> list3 = pbUtil.Fill((int num4) => new List<int>(), count);
			List<List<int>> list4 = pbUtil.Fill((int num4) => new List<int>(), count);
			pb_Vertex item = pb_Vertex.Average(vertices, indices);
			Vector3 lhs = pb_Math.Normal(vertices, face.indices);
			int num = 0;
			for (int num2 = 0; num2 < list.Count; num2++)
			{
				int x = list[num2].x;
				list2[num].Add(vertices[x]);
				list3[num].Add(lookup[x]);
				if (indices.Contains(x))
				{
					list4[num].Add(list2[num].Count);
					list2[num].Add(item);
					list3[num].Add(sharedIndexOffset);
					num = (num + 1) % count;
					list4[num].Add(list2[num].Count);
					list2[num].Add(vertices[x]);
					list3[num].Add(lookup[x]);
				}
			}
			List<ConnectFaceRebuildData> list5 = new List<ConnectFaceRebuildData>();
			for (int num3 = 0; num3 < list2.Count; num3++)
			{
				if (list2[num3].Count >= 3)
				{
					pb_FaceRebuildData pb_FaceRebuildData = pb_AppendPolygon.FaceWithVertices(list2[num3], unordered: false);
					pb_FaceRebuildData.sharedIndices = list3[num3];
					Vector3 rhs = pb_Math.Normal(list2[num3], pb_FaceRebuildData.face.indices);
					if (Vector3.Dot(lhs, rhs) < 0f)
					{
						pb_FaceRebuildData.face.ReverseIndices();
					}
					list5.Add(new ConnectFaceRebuildData(pb_FaceRebuildData, list4[num3]));
				}
			}
			return list5;
		}
	}
	public static class pb_DeleteVertices
	{
		public static int[] RemoveUnusedVertices(this pb_Object pb)
		{
			List<int> list = new List<int>();
			HashSet<int> hashSet = new HashSet<int>(pb_Face.AllTriangles(pb.faces));
			for (int i = 0; i < pb.vertices.Length; i++)
			{
				if (!hashSet.Contains(i))
				{
					list.Add(i);
				}
			}
			pb.DeleteVerticesWithIndices(list);
			return list.ToArray();
		}

		public static void DeleteVerticesWithIndices(this pb_Object pb, IEnumerable<int> distInd)
		{
			if (distInd == null || distInd.Count() < 1)
			{
				return;
			}
			pb_Vertex[] vertices = pb_Vertex.GetVertices(pb);
			int num = vertices.Length;
			int[] offset = new int[num];
			List<int> sorted = new List<int>(distInd);
			sorted.Sort();
			vertices = vertices.SortedRemoveAt(sorted);
			for (int i = 0; i < num; i++)
			{
				offset[i] = pbUtil.NearestIndexPriorToValue(sorted, i) + 1;
			}
			pb_Face[] faces = pb.faces;
			foreach (pb_Face pb_Face in faces)
			{
				int[] indices = pb_Face.indices;
				for (int k = 0; k < indices.Length; k++)
				{
					indices[k] -= offset[indices[k]];
				}
				pb_Face.RebuildCaches();
			}
			IEnumerable<KeyValuePair<int, int>> sharedIndices = from y in pb.sharedIndices.ToDictionary()
				where sorted.BinarySearch(y.Key) < 0
				select new KeyValuePair<int, int>(y.Key - offset[y.Key], y.Value);
			IEnumerable<KeyValuePair<int, int>> sharedIndicesUV = from y in pb.sharedIndicesUV.ToDictionary()
				where sorted.BinarySearch(y.Key) < 0
				select new KeyValuePair<int, int>(y.Key - offset[y.Key], y.Value);
			pb.SetVertices(vertices);
			pb.SetSharedIndices(sharedIndices);
			pb.SetSharedIndicesUV(sharedIndicesUV);
			pb.ToMesh();
		}
	}
	public static class pb_Extrude
	{
		public static bool Extrude(this pb_Object pb, pb_Face[] faces, ExtrudeMethod method, float distance)
		{
			if (method == ExtrudeMethod.IndividualFaces)
			{
				return ExtrudePerFace(pb, faces, distance);
			}
			return ExtrudeAsGroups(pb, faces, method == ExtrudeMethod.FaceNormal, distance);
		}

		private static bool ExtrudePerFace(pb_Object pb, pb_Face[] faces, float distance)
		{
			if (faces == null || faces.Length < 1)
			{
				return false;
			}
			List<pb_Vertex> list = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			int num = pb.sharedIndices.Length;
			int num2 = 0;
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			Dictionary<int, int> dictionary2 = pb.sharedIndicesUV.ToDictionary();
			List<pb_Face> list2 = new List<pb_Face>(pb.faces);
			Dictionary<int, int> dictionary3 = new Dictionary<int, int>();
			foreach (pb_Face pb_Face in faces)
			{
				pb_Face.smoothingGroup = -1;
				pb_Face.textureGroup = -1;
				Vector3 vector = pb_Math.Normal(pb, pb_Face) * distance;
				pb_Edge[] edges = pb_Face.edges;
				dictionary3.Clear();
				for (int j = 0; j < edges.Length; j++)
				{
					int count = list.Count;
					int x = edges[j].x;
					int y = edges[j].y;
					if (!dictionary3.ContainsKey(x))
					{
						dictionary3.Add(x, dictionary[x]);
						dictionary[x] = num + num2++;
					}
					if (!dictionary3.ContainsKey(y))
					{
						dictionary3.Add(y, dictionary[y]);
						dictionary[y] = num + num2++;
					}
					dictionary.Add(count, dictionary3[x]);
					dictionary.Add(count + 1, dictionary3[y]);
					dictionary.Add(count + 2, dictionary[x]);
					dictionary.Add(count + 3, dictionary[y]);
					pb_Vertex pb_Vertex = new pb_Vertex(list[x]);
					pb_Vertex pb_Vertex2 = new pb_Vertex(list[y]);
					pb_Vertex.position += vector;
					pb_Vertex2.position += vector;
					list.Add(new pb_Vertex(list[x]));
					list.Add(new pb_Vertex(list[y]));
					list.Add(pb_Vertex);
					list.Add(pb_Vertex2);
					pb_Face item = new pb_Face(new int[6]
					{
						count,
						count + 1,
						count + 2,
						count + 1,
						count + 3,
						count + 2
					}, pb_Face.material, new pb_UV(pb_Face.uv), pb_Face.smoothingGroup, -1, -1, manualUV: false);
					list2.Add(item);
				}
				for (int k = 0; k < pb_Face.distinctIndices.Length; k++)
				{
					list[pb_Face.distinctIndices[k]].position.x += vector.x;
					list[pb_Face.distinctIndices[k]].position.y += vector.y;
					list[pb_Face.distinctIndices[k]].position.z += vector.z;
					if (dictionary2 != null && dictionary2.ContainsKey(pb_Face.distinctIndices[k]))
					{
						dictionary2.Remove(pb_Face.distinctIndices[k]);
					}
				}
			}
			pb.SetVertices(list);
			pb.SetFaces(list2.ToArray());
			pb.SetSharedIndices(dictionary);
			pb.SetSharedIndicesUV(dictionary2);
			return true;
		}

		private static bool ExtrudeAsGroups(pb_Object pb, pb_Face[] faces, bool compensateAngleVertexDistance, float distance)
		{
			if (faces == null || faces.Length < 1)
			{
				return false;
			}
			List<pb_Vertex> list = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			int num = pb.sharedIndices.Length;
			int num2 = 0;
			Dictionary<int, int> dictionary = pb.sharedIndices.ToDictionary();
			Dictionary<int, int> dictionary2 = pb.sharedIndicesUV.ToDictionary();
			List<pb_Face> list2 = new List<pb_Face>(pb.faces);
			Dictionary<int, int> dictionary3 = new Dictionary<int, int>();
			Dictionary<int, int> dictionary4 = new Dictionary<int, int>();
			Dictionary<int, int> dictionary5 = new Dictionary<int, int>();
			Dictionary<int, pb_Tuple<Vector3, Vector3, List<int>>> dictionary6 = new Dictionary<int, pb_Tuple<Vector3, Vector3, List<int>>>();
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb, faces, oneWingPerFace: true, dictionary);
			List<HashSet<pb_Face>> faceGroups = GetFaceGroups(wingedEdges);
			foreach (HashSet<pb_Face> item2 in faceGroups)
			{
				Dictionary<pb_EdgeLookup, pb_Face> perimeterEdges = GetPerimeterEdges(item2, dictionary);
				dictionary4.Clear();
				dictionary3.Clear();
				foreach (KeyValuePair<pb_EdgeLookup, pb_Face> item3 in perimeterEdges)
				{
					pb_EdgeLookup key = item3.Key;
					pb_Face value = item3.Value;
					int count = list.Count;
					int x = key.local.x;
					int y = key.local.y;
					if (!dictionary3.ContainsKey(x))
					{
						dictionary3.Add(x, dictionary[x]);
						int value2 = -1;
						if (dictionary4.TryGetValue(dictionary[x], out value2))
						{
							dictionary[x] = value2;
						}
						else
						{
							value2 = num + num2++;
							dictionary4.Add(dictionary[x], value2);
							dictionary[x] = value2;
						}
					}
					if (!dictionary3.ContainsKey(y))
					{
						dictionary3.Add(y, dictionary[y]);
						int value3 = -1;
						if (dictionary4.TryGetValue(dictionary[y], out value3))
						{
							dictionary[y] = value3;
						}
						else
						{
							value3 = num + num2++;
							dictionary4.Add(dictionary[y], value3);
							dictionary[y] = value3;
						}
					}
					dictionary.Add(count, dictionary3[x]);
					dictionary.Add(count + 1, dictionary3[y]);
					dictionary.Add(count + 2, dictionary[x]);
					dictionary.Add(count + 3, dictionary[y]);
					dictionary5.Add(count + 2, x);
					dictionary5.Add(count + 3, y);
					list.Add(new pb_Vertex(list[x]));
					list.Add(new pb_Vertex(list[y]));
					list.Add(null);
					list.Add(null);
					pb_Face item = new pb_Face(new int[6]
					{
						count,
						count + 1,
						count + 2,
						count + 1,
						count + 3,
						count + 2
					}, value.material, new pb_UV(value.uv), value.smoothingGroup, -1, -1, manualUV: false);
					list2.Add(item);
				}
				foreach (pb_Face item4 in item2)
				{
					item4.textureGroup = -1;
					Vector3 vector = pb_Math.Normal(pb, item4);
					for (int i = 0; i < item4.distinctIndices.Length; i++)
					{
						int num3 = item4.distinctIndices[i];
						if (!dictionary3.ContainsKey(num3) && dictionary4.ContainsKey(dictionary[num3]))
						{
							dictionary[num3] = dictionary4[dictionary[num3]];
						}
						int key2 = dictionary[num3];
						if (dictionary2 != null && dictionary2.ContainsKey(item4.distinctIndices[i]))
						{
							dictionary2.Remove(item4.distinctIndices[i]);
						}
						pb_Tuple<Vector3, Vector3, List<int>> value4 = null;
						if (dictionary6.TryGetValue(key2, out value4))
						{
							value4.Item1.x += vector.x;
							value4.Item1.y += vector.y;
							value4.Item1.z += vector.z;
							value4.Item3.Add(num3);
						}
						else
						{
							dictionary6.Add(key2, new pb_Tuple<Vector3, Vector3, List<int>>(vector, vector, new List<int> { num3 }));
						}
					}
				}
			}
			foreach (KeyValuePair<int, pb_Tuple<Vector3, Vector3, List<int>>> item5 in dictionary6)
			{
				Vector3 vector2 = item5.Value.Item1 / item5.Value.Item3.Count;
				vector2.Normalize();
				float num4 = ((!compensateAngleVertexDistance) ? 1f : pb_Math.Secant(Vector3.Angle(vector2, item5.Value.Item2) * ((float)Math.PI / 180f)));
				vector2.x *= distance * num4;
				vector2.y *= distance * num4;
				vector2.z *= distance * num4;
				foreach (int item6 in item5.Value.Item3)
				{
					list[item6].position.x += vector2.x;
					list[item6].position.y += vector2.y;
					list[item6].position.z += vector2.z;
				}
			}
			foreach (KeyValuePair<int, int> item7 in dictionary5)
			{
				list[item7.Key] = new pb_Vertex(list[item7.Value]);
			}
			pb.SetVertices(list);
			pb.SetFaces(list2.ToArray());
			pb.SetSharedIndices(dictionary);
			pb.SetSharedIndicesUV(dictionary2);
			return true;
		}

		private static List<HashSet<pb_Face>> GetFaceGroups(List<pb_WingedEdge> wings)
		{
			HashSet<pb_Face> hashSet = new HashSet<pb_Face>();
			List<HashSet<pb_Face>> list = new List<HashSet<pb_Face>>();
			foreach (pb_WingedEdge wing in wings)
			{
				if (!hashSet.Add(wing.face))
				{
					continue;
				}
				HashSet<pb_Face> hashSet2 = new HashSet<pb_Face>();
				hashSet2.Add(wing.face);
				HashSet<pb_Face> hashSet3 = hashSet2;
				pb_GrowShrink.Flood(wing, hashSet3);
				foreach (pb_Face item in hashSet3)
				{
					hashSet.Add(item);
				}
				list.Add(hashSet3);
			}
			return list;
		}

		private static Dictionary<pb_EdgeLookup, pb_Face> GetPerimeterEdges(HashSet<pb_Face> faces, Dictionary<int, int> lookup)
		{
			Dictionary<pb_EdgeLookup, pb_Face> dictionary = new Dictionary<pb_EdgeLookup, pb_Face>();
			HashSet<pb_EdgeLookup> hashSet = new HashSet<pb_EdgeLookup>();
			foreach (pb_Face face in faces)
			{
				pb_Edge[] edges = face.edges;
				foreach (pb_Edge pb_Edge in edges)
				{
					pb_EdgeLookup pb_EdgeLookup = new pb_EdgeLookup(lookup[pb_Edge.x], lookup[pb_Edge.y], pb_Edge.x, pb_Edge.y);
					if (!hashSet.Add(pb_EdgeLookup))
					{
						if (dictionary.ContainsKey(pb_EdgeLookup))
						{
							dictionary.Remove(pb_EdgeLookup);
						}
					}
					else
					{
						dictionary.Add(pb_EdgeLookup, face);
					}
				}
			}
			return dictionary;
		}
	}
	public static class pb_Facetize
	{
		public static pb_ActionResult Facetize(this pb_Object pb, IList<pb_Face> faces, out pb_Face[] newFaces)
		{
			List<pb_Vertex> vertices = new List<pb_Vertex>(pb_Vertex.GetVertices(pb));
			Dictionary<int, int> lookup = pb.sharedIndices.ToDictionary();
			List<pb_FaceRebuildData> list = new List<pb_FaceRebuildData>();
			foreach (pb_Face face in faces)
			{
				List<pb_FaceRebuildData> collection = BreakFaceIntoTris(face, vertices, lookup);
				list.AddRange(collection);
			}
			pb_FaceRebuildData.Apply(list, pb, vertices, null, lookup);
			pb.DeleteFaces(faces);
			pb.ToMesh();
			newFaces = list.Select((pb_FaceRebuildData x) => x.face).ToArray();
			return new pb_ActionResult(Status.Success, string.Format("Triangulated {0} {1}", faces.Count, (faces.Count >= 2) ? "Faces" : "Face"));
		}

		private static List<pb_FaceRebuildData> BreakFaceIntoTris(pb_Face face, List<pb_Vertex> vertices, Dictionary<int, int> lookup)
		{
			int[] indices = face.indices;
			int num = indices.Length;
			List<pb_FaceRebuildData> list = new List<pb_FaceRebuildData>(num / 3);
			for (int i = 0; i < num; i += 3)
			{
				pb_FaceRebuildData pb_FaceRebuildData = new pb_FaceRebuildData();
				pb_FaceRebuildData.face = new pb_Face(face);
				pb_FaceRebuildData.face.SetIndices(new int[3] { 0, 1, 2 });
				pb_FaceRebuildData.vertices = new List<pb_Vertex>
				{
					vertices[indices[i]],
					vertices[indices[i + 1]],
					vertices[indices[i + 2]]
				};
				pb_FaceRebuildData.sharedIndices = new List<int>
				{
					lookup[indices[i]],
					lookup[indices[i + 1]],
					lookup[indices[i + 2]]
				};
				list.Add(pb_FaceRebuildData);
			}
			return list;
		}
	}
	public static class pb_GrowShrink
	{
		private static readonly Vector3 Vector3_Zero = new Vector3(0f, 0f, 0f);

		public static HashSet<pb_Face> GrowSelection(pb_Object pb, IList<pb_Face> faces, float maxAngleDiff = -1f)
		{
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb, oneWingPerFace: true);
			HashSet<pb_Face> hashSet = new HashSet<pb_Face>(faces);
			HashSet<pb_Face> hashSet2 = new HashSet<pb_Face>();
			Vector3 vector = Vector3.zero;
			bool flag = maxAngleDiff > 0f;
			for (int i = 0; i < wingedEdges.Count; i++)
			{
				if (!hashSet.Contains(wingedEdges[i].face))
				{
					continue;
				}
				if (flag)
				{
					vector = pb_Math.Normal(pb, wingedEdges[i].face);
				}
				foreach (pb_WingedEdge item in wingedEdges[i])
				{
					if (item.opposite == null || hashSet.Contains(item.opposite.face))
					{
						continue;
					}
					if (flag)
					{
						Vector3 to = pb_Math.Normal(pb, item.opposite.face);
						if (Vector3.Angle(vector, to) < maxAngleDiff)
						{
							hashSet2.Add(item.opposite.face);
						}
					}
					else
					{
						hashSet2.Add(item.opposite.face);
					}
				}
			}
			return hashSet2;
		}

		public static void Flood(pb_WingedEdge wing, HashSet<pb_Face> selection)
		{
			Flood(null, wing, Vector3_Zero, -1f, selection);
		}

		public static void Flood(pb_Object pb, pb_WingedEdge wing, Vector3 wingNrm, float maxAngle, HashSet<pb_Face> selection)
		{
			pb_WingedEdge pb_WingedEdge = wing;
			do
			{
				pb_WingedEdge opposite = pb_WingedEdge.opposite;
				if (opposite != null && !selection.Contains(opposite.face))
				{
					if (maxAngle > 0f)
					{
						Vector3 vector = pb_Math.Normal(pb, opposite.face);
						if (Vector3.Angle(wingNrm, vector) < maxAngle && selection.Add(opposite.face))
						{
							Flood(pb, opposite, vector, maxAngle, selection);
						}
					}
					else if (selection.Add(opposite.face))
					{
						Flood(pb, opposite, wingNrm, maxAngle, selection);
					}
				}
				pb_WingedEdge = pb_WingedEdge.next;
			}
			while (pb_WingedEdge != wing);
		}

		public static HashSet<pb_Face> FloodSelection(pb_Object pb, IList<pb_Face> faces, float maxAngleDiff)
		{
			List<pb_WingedEdge> wingedEdges = pb_WingedEdge.GetWingedEdges(pb, oneWingPerFace: true);
			HashSet<pb_Face> hashSet = new HashSet<pb_Face>(faces);
			HashSet<pb_Face> hashSet2 = new HashSet<pb_Face>();
			for (int i = 0; i < wingedEdges.Count; i++)
			{
				if (!hashSet2.Contains(wingedEdges[i].face) && hashSet.Contains(wingedEdges[i].face))
				{
					hashSet2.Add(wingedEdges[i].face);
					Flood(pb, wingedEdges[i], (!(maxAngleDiff > 0f)) ? Vector3_Zero : pb_Math.Normal(pb, wingedEdges[i].face), maxAngleDiff, hashSet2);
				}
			}
			return hashSet2;
		}
	}
	public static class pb_Subdivide
	{
		public static pb_ActionResult Subdivide(this pb_Object pb)
		{
			pb_Face[] subdividedFaces;
			return pb.Subdivide(pb.faces, out subdividedFaces);
		}

		public static pb_ActionResult Subdivide(this pb_Object pb, IList<pb_Face> faces, out pb_Face[] subdividedFaces)
		{
			return pb.Connect(faces, out subdividedFaces);
		}
	}
	public static class pb_Triangulation
	{
		public static bool SortAndTriangulate(IList<Vector2> points, out List<int> indices, bool convex = false)
		{
			IList<Vector2> list = pb_Projection.Sort(points);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			for (int i = 0; i < list.Count; i++)
			{
				dictionary.Add(i, points.IndexOf(list[i]));
			}
			if (!Triangulate(list, out indices, convex))
			{
				return false;
			}
			for (int j = 0; j < indices.Count; j++)
			{
				indices[j] = dictionary[indices[j]];
			}
			return true;
		}

		public static bool TriangulateVertices(IList<pb_Vertex> vertices, out List<int> triangles, bool unordered = true, bool convex = false)
		{
			Vector3[] array = new Vector3[vertices.Count];
			for (int i = 0; i < vertices.Count; i++)
			{
				ref Vector3 reference = ref array[i];
				reference = vertices[i].position;
			}
			return TriangulateVertices(array, out triangles, unordered, convex);
		}

		public static bool TriangulateVertices(Vector3[] vertices, out List<int> triangles, bool unordered = true, bool convex = false)
		{
			triangles = null;
			int num = ((vertices != null) ? vertices.Length : 0);
			if (num < 3)
			{
				return false;
			}
			if (num == 3)
			{
				triangles = new List<int> { 0, 1, 2 };
				return true;
			}
			Vector3 normal = pb_Projection.FindBestPlane(vertices).normal;
			Vector2[] points = pb_Projection.PlanarProject(vertices, normal);
			if (unordered)
			{
				return SortAndTriangulate(points, out triangles, convex);
			}
			return Triangulate(points, out triangles, convex);
		}

		public static bool Triangulate(IList<Vector2> points, out List<int> indices, bool convex = false)
		{
			indices = new List<int>();
			int index = 0;
			object obj;
			if (convex)
			{
				Triangulatable triangulatable = new PointSet(points.Select((Vector2 x) => new TriangulationPoint(x.x, x.y, index++)).ToList());
				obj = triangulatable;
			}
			else
			{
				obj = new Polygon(points.Select((Vector2 x) => new PolygonPoint(x.x, x.y, index++)));
			}
			Triangulatable triangulatable2 = (Triangulatable)obj;
			P2T.Triangulate(TriangulationAlgorithm.DTSweep, triangulatable2);
			foreach (DelaunayTriangle triangle in triangulatable2.Triangles)
			{
				if (triangle.Points[0].Index < 0 || triangle.Points[1].Index < 0 || triangle.Points[2].Index < 0)
				{
					pb_Log.Warning("Triangulation failed - additional vertices were inserted.");
					return false;
				}
				indices.Add(triangle.Points[0].Index);
				indices.Add(triangle.Points[1].Index);
				indices.Add(triangle.Points[2].Index);
			}
			WindingOrder windingOrder = pbTriangleOps.GetWindingOrder(points);
			if (pbTriangleOps.GetWindingOrder(new Vector2[3]
			{
				points[indices[0]],
				points[indices[1]],
				points[indices[2]]
			}) != windingOrder)
			{
				indices.Reverse();
			}
			return true;
		}
	}
	public static class pb_WeldVertices
	{
		public static pb_ActionResult WeldVertices(this pb_Object pb, int[] indices, float neighborRadius, out int[] welds)
		{
			pb_Vertex[] vertices = pb_Vertex.GetVertices(pb);
			pb_IntArray[] sharedIndices = pb.sharedIndices;
			Dictionary<int, int> dictionary = sharedIndices.ToDictionary();
			HashSet<int> commonIndices = pb_IntArrayUtility.GetCommonIndices(dictionary, indices);
			int count = commonIndices.Count;
			int num = Math.Min(32, commonIndices.Count());
			KdTree<float, int> kdTree = new KdTree<float, int>(3, new FloatMath(), AddDuplicateBehavior.Collect);
			foreach (int item in commonIndices)
			{
				Vector3 position = vertices[sharedIndices[item][0]].position;
				kdTree.Add(new float[3] { position.x, position.y, position.z }, item);
			}
			float[] array = new float[3];
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			Dictionary<int, Vector3> dictionary3 = new Dictionary<int, Vector3>();
			int num2 = sharedIndices.Length;
			foreach (int item2 in commonIndices)
			{
				if (dictionary2.ContainsKey(item2))
				{
					continue;
				}
				Vector3 position2 = vertices[sharedIndices[item2][0]].position;
				array[0] = position2.x;
				array[1] = position2.y;
				array[2] = position2.z;
				KdTreeNode<float, int>[] array2 = kdTree.RadialSearch(array, neighborRadius, num);
				if (num < count && array2.Length >= num)
				{
					array2 = kdTree.RadialSearch(array, neighborRadius, count);
					num = Math.Min(count, array2.Length + array2.Length / 2);
				}
				Vector3 zero = Vector3.zero;
				float num3 = 0f;
				for (int i = 0; i < array2.Length; i++)
				{
					int value = array2[i].Value;
					if (dictionary2.ContainsKey(value))
					{
						continue;
					}
					zero.x += array2[i].Point[0];
					zero.y += array2[i].Point[1];
					zero.z += array2[i].Point[2];
					dictionary2.Add(value, num2);
					num3 += 1f;
					if (array2[i].Duplicates != null)
					{
						for (int j = 0; j < array2[i].Duplicates.Count; j++)
						{
							dictionary2.Add(array2[i].Duplicates[j], num2);
						}
					}
				}
				zero.x /= num3;
				zero.y /= num3;
				zero.z /= num3;
				dictionary3.Add(num2, zero);
				num2++;
			}
			welds = new int[dictionary2.Count];
			int num4 = 0;
			foreach (KeyValuePair<int, int> item3 in dictionary2)
			{
				int[] array3 = sharedIndices[item3.Key];
				welds[num4++] = array3[0];
				for (int k = 0; k < array3.Length; k++)
				{
					dictionary[array3[k]] = item3.Value;
					vertices[array3[k]].position = dictionary3[item3.Value];
				}
			}
			pb.SetSharedIndices(dictionary);
			pb.SetVertices(vertices);
			pb.ToMesh();
			return new pb_ActionResult(Status.Success, "Weld Vertices");
		}
	}
}
namespace Parabox.CSG
{
	public class CSG
	{
		public const float EPSILON = 1E-05f;

		public static Mesh Union(GameObject lhs, GameObject rhs)
		{
			CSG_Model cSG_Model = new CSG_Model(lhs);
			CSG_Model cSG_Model2 = new CSG_Model(rhs);
			CSG_Node a = new CSG_Node(cSG_Model.ToPolygons());
			CSG_Node b = new CSG_Node(cSG_Model2.ToPolygons());
			List<CSG_Polygon> list = CSG_Node.Union(a, b).AllPolygons();
			CSG_Model cSG_Model3 = new CSG_Model(list);
			return cSG_Model3.ToMesh();
		}

		public static Mesh Subtract(GameObject lhs, GameObject rhs)
		{
			CSG_Model cSG_Model = new CSG_Model(lhs);
			CSG_Model cSG_Model2 = new CSG_Model(rhs);
			CSG_Node a = new CSG_Node(cSG_Model.ToPolygons());
			CSG_Node b = new CSG_Node(cSG_Model2.ToPolygons());
			List<CSG_Polygon> list = CSG_Node.Subtract(a, b).AllPolygons();
			CSG_Model cSG_Model3 = new CSG_Model(list);
			return cSG_Model3.ToMesh();
		}

		public static Mesh Intersect(GameObject lhs, GameObject rhs)
		{
			CSG_Model cSG_Model = new CSG_Model(lhs);
			CSG_Model cSG_Model2 = new CSG_Model(rhs);
			CSG_Node a = new CSG_Node(cSG_Model.ToPolygons());
			CSG_Node b = new CSG_Node(cSG_Model2.ToPolygons());
			List<CSG_Polygon> list = CSG_Node.Intersect(a, b).AllPolygons();
			CSG_Model cSG_Model3 = new CSG_Model(list);
			return cSG_Model3.ToMesh();
		}
	}
	internal class CSG_Model
	{
		public List<CSG_Vertex> vertices;

		public List<int> indices;

		public CSG_Model()
		{
			vertices = new List<CSG_Vertex>();
			indices = new List<int>();
		}

		public CSG_Model(GameObject go)
		{
			vertices = new List<CSG_Vertex>();
			Mesh sharedMesh = go.GetComponent<MeshFilter>().sharedMesh;
			Transform component = go.GetComponent<Transform>();
			Vector3[] array = sharedMesh.vertices;
			Vector3[] normals = sharedMesh.normals;
			Vector2[] uv = sharedMesh.uv;
			Color[] colors = sharedMesh.colors;
			for (int i = 0; i < array.Length; i++)
			{
				vertices.Add(new CSG_Vertex(component.TransformPoint(array[i]), component.TransformDirection(normals[i]), uv[i], colors[i]));
			}
			indices = new List<int>(sharedMesh.triangles);
		}

		public CSG_Model(List<CSG_Polygon> list)
		{
			vertices = new List<CSG_Vertex>();
			indices = new List<int>();
			int num = 0;
			for (int i = 0; i < list.Count; i++)
			{
				CSG_Polygon cSG_Polygon = list[i];
				for (int j = 2; j < cSG_Polygon.vertices.Count; j++)
				{
					vertices.Add(cSG_Polygon.vertices[0]);
					indices.Add(num++);
					vertices.Add(cSG_Polygon.vertices[j - 1]);
					indices.Add(num++);
					vertices.Add(cSG_Polygon.vertices[j]);
					indices.Add(num++);
				}
			}
		}

		public List<CSG_Polygon> ToPolygons()
		{
			List<CSG_Polygon> list = new List<CSG_Polygon>();
			for (int i = 0; i < indices.Count; i += 3)
			{
				List<CSG_Vertex> list2 = new List<CSG_Vertex>();
				list2.Add(vertices[indices[i]]);
				list2.Add(vertices[indices[i + 1]]);
				list2.Add(vertices[indices[i + 2]]);
				List<CSG_Vertex> list3 = list2;
				list.Add(new CSG_Polygon(list3));
			}
			return list;
		}

		public Mesh ToMesh()
		{
			Mesh mesh = new Mesh();
			int count = vertices.Count;
			Vector3[] array = new Vector3[count];
			Vector3[] array2 = new Vector3[count];
			Vector2[] array3 = new Vector2[count];
			Color[] array4 = new Color[count];
			for (int i = 0; i < count; i++)
			{
				ref Vector3 reference = ref array[i];
				reference = vertices[i].position;
				ref Vector3 reference2 = ref array2[i];
				reference2 = vertices[i].normal;
				ref Vector2 reference3 = ref array3[i];
				reference3 = vertices[i].uv;
				ref Color reference4 = ref array4[i];
				reference4 = vertices[i].color;
			}
			mesh.vertices = array;
			mesh.normals = array2;
			mesh.colors = array4;
			mesh.uv = array3;
			mesh.triangles = indices.ToArray();
			return mesh;
		}
	}
	internal class CSG_Node
	{
		public List<CSG_Polygon> polygons;

		public CSG_Node front;

		public CSG_Node back;

		public CSG_Plane plane;

		public CSG_Node()
		{
			front = null;
			back = null;
		}

		public CSG_Node(List<CSG_Polygon> list)
		{
			Build(list);
		}

		public CSG_Node(List<CSG_Polygon> list, CSG_Plane plane, CSG_Node front, CSG_Node back)
		{
			polygons = list;
			this.plane = plane;
			this.front = front;
			this.back = back;
		}

		public CSG_Node Clone()
		{
			return new CSG_Node(polygons, plane, front, back);
		}

		public void ClipTo(CSG_Node other)
		{
			polygons = other.ClipPolygons(polygons);
			if (front != null)
			{
				front.ClipTo(other);
			}
			if (back != null)
			{
				back.ClipTo(other);
			}
		}

		public void Invert()
		{
			for (int i = 0; i < polygons.Count; i++)
			{
				polygons[i].Flip();
			}
			plane.Flip();
			if (front != null)
			{
				front.Invert();
			}
			if (back != null)
			{
				back.Invert();
			}
			CSG_Node cSG_Node = front;
			front = back;
			back = cSG_Node;
		}

		public void Build(List<CSG_Polygon> list)
		{
			if (list.Count < 1)
			{
				return;
			}
			if (plane == null || !plane.Valid())
			{
				plane = new CSG_Plane();
				plane.normal = list[0].plane.normal;
				plane.w = list[0].plane.w;
			}
			if (polygons == null)
			{
				polygons = new List<CSG_Polygon>();
			}
			List<CSG_Polygon> list2 = new List<CSG_Polygon>();
			List<CSG_Polygon> list3 = new List<CSG_Polygon>();
			for (int i = 0; i < list.Count; i++)
			{
				plane.SplitPolygon(list[i], polygons, polygons, list2, list3);
			}
			if (list2.Count > 0)
			{
				if (front == null)
				{
					front = new CSG_Node();
				}
				front.Build(list2);
			}
			if (list3.Count > 0)
			{
				if (back == null)
				{
					back = new CSG_Node();
				}
				back.Build(list3);
			}
		}

		public List<CSG_Polygon> ClipPolygons(List<CSG_Polygon> list)
		{
			if (!plane.Valid())
			{
				return list;
			}
			List<CSG_Polygon> list2 = new List<CSG_Polygon>();
			List<CSG_Polygon> list3 = new List<CSG_Polygon>();
			for (int i = 0; i < list.Count; i++)
			{
				plane.SplitPolygon(list[i], list2, list3, list2, list3);
			}
			if (front != null)
			{
				list2 = front.ClipPolygons(list2);
			}
			if (back != null)
			{
				list3 = back.ClipPolygons(list3);
			}
			else
			{
				list3.Clear();
			}
			list2.AddRange(list3);
			return list2;
		}

		public List<CSG_Polygon> AllPolygons()
		{
			List<CSG_Polygon> list = polygons;
			List<CSG_Polygon> collection = new List<CSG_Polygon>();
			List<CSG_Polygon> collection2 = new List<CSG_Polygon>();
			if (front != null)
			{
				collection = front.AllPolygons();
			}
			if (back != null)
			{
				collection2 = back.AllPolygons();
			}
			list.AddRange(collection);
			list.AddRange(collection2);
			return list;
		}

		public static CSG_Node Union(CSG_Node a1, CSG_Node b1)
		{
			CSG_Node cSG_Node = a1.Clone();
			CSG_Node cSG_Node2 = b1.Clone();
			cSG_Node.ClipTo(cSG_Node2);
			cSG_Node2.ClipTo(cSG_Node);
			cSG_Node2.Invert();
			cSG_Node2.ClipTo(cSG_Node);
			cSG_Node2.Invert();
			cSG_Node.Build(cSG_Node2.AllPolygons());
			return new CSG_Node(cSG_Node.AllPolygons());
		}

		public static CSG_Node Subtract(CSG_Node a1, CSG_Node b1)
		{
			CSG_Node cSG_Node = a1.Clone();
			CSG_Node cSG_Node2 = b1.Clone();
			cSG_Node.Invert();
			cSG_Node.ClipTo(cSG_Node2);
			cSG_Node2.ClipTo(cSG_Node);
			cSG_Node2.Invert();
			cSG_Node2.ClipTo(cSG_Node);
			cSG_Node2.Invert();
			cSG_Node.Build(cSG_Node2.AllPolygons());
			cSG_Node.Invert();
			return new CSG_Node(cSG_Node.AllPolygons());
		}

		public static CSG_Node Intersect(CSG_Node a1, CSG_Node b1)
		{
			CSG_Node cSG_Node = a1.Clone();
			CSG_Node cSG_Node2 = b1.Clone();
			cSG_Node.Invert();
			cSG_Node2.ClipTo(cSG_Node);
			cSG_Node2.Invert();
			cSG_Node.ClipTo(cSG_Node2);
			cSG_Node2.ClipTo(cSG_Node);
			cSG_Node.Build(cSG_Node2.AllPolygons());
			cSG_Node.Invert();
			return new CSG_Node(cSG_Node.AllPolygons());
		}
	}
	internal class CSG_Plane
	{
		[Flags]
		private enum EPolygonType
		{
			Coplanar = 0,
			Front = 1,
			Back = 2,
			Spanning = 3
		}

		public Vector3 normal;

		public float w;

		public CSG_Plane()
		{
			normal = Vector3.zero;
			w = 0f;
		}

		public CSG_Plane(Vector3 a, Vector3 b, Vector3 c)
		{
			normal = Vector3.Cross(b - a, c - a);
			w = Vector3.Dot(normal, a);
		}

		public bool Valid()
		{
			return normal.magnitude > 0f;
		}

		public void Flip()
		{
			normal *= -1f;
			w *= -1f;
		}

		public void SplitPolygon(CSG_Polygon polygon, List<CSG_Polygon> coplanarFront, List<CSG_Polygon> coplanarBack, List<CSG_Polygon> front, List<CSG_Polygon> back)
		{
			EPolygonType ePolygonType = EPolygonType.Coplanar;
			List<EPolygonType> list = new List<EPolygonType>();
			for (int i = 0; i < polygon.vertices.Count; i++)
			{
				float num = Vector3.Dot(normal, polygon.vertices[i].position) - w;
				EPolygonType ePolygonType2 = ((!(num < -1E-05f)) ? ((num > 1E-05f) ? EPolygonType.Front : EPolygonType.Coplanar) : EPolygonType.Back);
				ePolygonType |= ePolygonType2;
				list.Add(ePolygonType2);
			}
			switch (ePolygonType)
			{
			case EPolygonType.Coplanar:
				if (Vector3.Dot(normal, polygon.plane.normal) > 0f)
				{
					coplanarFront.Add(polygon);
				}
				else
				{
					coplanarBack.Add(polygon);
				}
				break;
			case EPolygonType.Front:
				front.Add(polygon);
				break;
			case EPolygonType.Back:
				back.Add(polygon);
				break;
			case EPolygonType.Spanning:
			{
				List<CSG_Vertex> list2 = new List<CSG_Vertex>();
				List<CSG_Vertex> list3 = new List<CSG_Vertex>();
				for (int j = 0; j < polygon.vertices.Count; j++)
				{
					int index = (j + 1) % polygon.vertices.Count;
					EPolygonType ePolygonType3 = list[j];
					EPolygonType ePolygonType4 = list[index];
					CSG_Vertex cSG_Vertex = polygon.vertices[j];
					CSG_Vertex b = polygon.vertices[index];
					if (ePolygonType3 != EPolygonType.Back)
					{
						list2.Add(cSG_Vertex);
					}
					if (ePolygonType3 != EPolygonType.Front)
					{
						list3.Add(cSG_Vertex);
					}
					if ((ePolygonType3 | ePolygonType4) == EPolygonType.Spanning)
					{
						float t = (w - Vector3.Dot(normal, cSG_Vertex.position)) / Vector3.Dot(normal, b.position - cSG_Vertex.position);
						CSG_Vertex item = CSG_Vertex.Interpolate(cSG_Vertex, b, t);
						list2.Add(item);
						list3.Add(item);
					}
				}
				if (list2.Count >= 3)
				{
					front.Add(new CSG_Polygon(list2));
				}
				if (list3.Count >= 3)
				{
					back.Add(new CSG_Polygon(list3));
				}
				break;
			}
			}
		}
	}
	internal class CSG_Polygon
	{
		public List<CSG_Vertex> vertices;

		public CSG_Plane plane;

		public CSG_Polygon(List<CSG_Vertex> list)
		{
			vertices = list;
			plane = new CSG_Plane(list[0].position, list[1].position, list[2].position);
		}

		public void Flip()
		{
			vertices.Reverse();
			for (int i = 0; i < vertices.Count; i++)
			{
				vertices[i].Flip();
			}
			plane.Flip();
		}

		public override string ToString()
		{
			return "N: " + plane.normal;
		}
	}
	internal struct CSG_Vertex
	{
		public Vector3 position;

		public Color color;

		public Vector3 normal;

		public Vector2 uv;

		public CSG_Vertex(Vector3 position, Vector3 normal, Vector2 uv, Color color)
		{
			this.position = position;
			this.normal = normal;
			this.uv = uv;
			this.color = color;
		}

		public void Flip()
		{
			normal *= -1f;
		}

		public static CSG_Vertex Interpolate(CSG_Vertex a, CSG_Vertex b, float t)
		{
			return new CSG_Vertex
			{
				position = Vector3.Lerp(a.position, b.position, t),
				normal = Vector3.Lerp(a.normal, b.normal, t),
				uv = Vector2.Lerp(a.uv, b.uv, t),
				color = (a.color + b.color) / 2f
			};
		}
	}
}
