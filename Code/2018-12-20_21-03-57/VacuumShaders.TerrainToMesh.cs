using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("1.0.0.0")]
namespace VacuumShaders.TerrainToMesh
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CompressedMeshLoader : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private enum SIDE
		{
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			Right,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			Top,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			Bottom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[HideInInspector]
		public int chunkCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[HideInInspector]
		public int chunkCountVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[HideInInspector]
		public int vertexCountHoriznontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[HideInInspector]
		public int vertexCountVertical;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2278EE0", Offset = "0x22782E0", VA = "0x182278EE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2278530", Offset = "0x2277930", VA = "0x182278530")]
		private void Fix(MeshFilter[] _childMeshFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2278920", Offset = "0x2277D20", VA = "0x182278920")]
		private void GetMeshData(Mesh _mesh, SIDE _side, out Vector3[] vertices, out Vector2[] uv, out Vector2[] uv2, out Vector3[] normal, out Vector4[] tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2278720", Offset = "0x2277B20", VA = "0x182278720")]
		private int[] GetIndexies(SIDE _side)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x22780D0", Offset = "0x22774D0", VA = "0x1822780D0")]
		private void Combine(Mesh _meshBottom, Mesh _meshTop, bool bottomTop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC4E80", Offset = "0xC4280", VA = "0x1800C4E80")]
		public CompressedMeshLoader()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class TerrainConvertInfo
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const int maxVertexCount = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int chunkCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int chunkCountVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int vertexCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int vertexCountVertical;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22794A0", Offset = "0x22788A0", VA = "0x1822794A0")]
		public TerrainConvertInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2279480", Offset = "0x2278880", VA = "0x182279480")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2279470", Offset = "0x2278870", VA = "0x182279470")]
		public int GetVertexCountPerChunk()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TerrainToMeshConverter
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public delegate void ProgressFunction(string _name, float _value);

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static Terrain terrain;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static TerrainConvertInfo terrainConvertInfo;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static ProgressFunction callback;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22794E0", Offset = "0x22788E0", VA = "0x1822794E0")]
		public static Mesh[] Convert(Terrain _terrain, TerrainConvertInfo _terrainConvertInfo, [Optional] ProgressFunction _callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x227ADC0", Offset = "0x227A1C0", VA = "0x18227ADC0")]
		public static Texture2D[] ExtractSplatmaps(Terrain _terrain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2279EE0", Offset = "0x22792E0", VA = "0x182279EE0")]
		public static void ExtractBasemap(Terrain _terrain, out Texture2D _diffuseMap, out Texture2D _normalMap, int _width, int _height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x227AEA0", Offset = "0x227A2A0", VA = "0x18227AEA0")]
		public static int ExtractTexturesInfo(Terrain _terrain, out Texture2D[] _diffuseTextures, out Texture2D[] _normalTextures, out Vector2[] _uvScale, out Vector2[] _uvOffset, out float[] _metalic, out float[] _smoothness)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x227CAD0", Offset = "0x227BED0", VA = "0x18227CAD0")]
		private static void GenerateTerrainBaseChunks(ref PreMesh[] _preMeshes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x227D520", Offset = "0x227C920", VA = "0x18227D520")]
		private static Mesh GenerateTerrainMainChunks(ref PreMesh _preMesh, float _chunkH_Width, float _chunkH_StartOffset, float _chunkV_Length, float _chunkV_StartOffset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x227E0E0", Offset = "0x227D4E0", VA = "0x18227E0E0")]
		private static Mesh GenerateTerrain()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x227B960", Offset = "0x227AD60", VA = "0x18227B960")]
		private static void GenerateNormals(Vector3[] _vertices, int[] _trinagles, out Vector3[] _normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x227C010", Offset = "0x227B410", VA = "0x18227C010")]
		private static void GenerateTangents(Vector3[] _vertices, int[] _triangles, Vector3[] _normals, Vector2[] _texcoords, out Vector4[] _tangents)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class PreMesh
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Vector3[] vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int[] triangles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Vector2[] uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Vector2[] uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Vector3[] normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Vector4[] tangents;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2279370", Offset = "0x2278770", VA = "0x182279370")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2279390", Offset = "0x2278790", VA = "0x182279390")]
		public PreMesh()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
