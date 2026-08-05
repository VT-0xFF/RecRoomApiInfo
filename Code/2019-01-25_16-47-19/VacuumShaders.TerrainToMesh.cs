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
		[Cpp2IlInjected.Address(RVA = "0x2264CC0", Offset = "0x22640C0", VA = "0x182264CC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2264310", Offset = "0x2263710", VA = "0x182264310")]
		private void Fix(MeshFilter[] _childMeshFilter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2264700", Offset = "0x2263B00", VA = "0x182264700")]
		private void GetMeshData(Mesh _mesh, SIDE _side, out Vector3[] vertices, out Vector2[] uv, out Vector2[] uv2, out Vector3[] normal, out Vector4[] tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2264500", Offset = "0x2263900", VA = "0x182264500")]
		private int[] GetIndexies(SIDE _side)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2263EB0", Offset = "0x22632B0", VA = "0x182263EB0")]
		private void Combine(Mesh _meshBottom, Mesh _meshTop, bool bottomTop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x647C0", Offset = "0x63BC0", VA = "0x1800647C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2265280", Offset = "0x2264680", VA = "0x182265280")]
		public TerrainConvertInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2265260", Offset = "0x2264660", VA = "0x182265260")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2265250", Offset = "0x2264650", VA = "0x182265250")]
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
		[Cpp2IlInjected.Address(RVA = "0x22652C0", Offset = "0x22646C0", VA = "0x1822652C0")]
		public static Mesh[] Convert(Terrain _terrain, TerrainConvertInfo _terrainConvertInfo, [Optional] ProgressFunction _callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2266BA0", Offset = "0x2265FA0", VA = "0x182266BA0")]
		public static Texture2D[] ExtractSplatmaps(Terrain _terrain)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2265CC0", Offset = "0x22650C0", VA = "0x182265CC0")]
		public static void ExtractBasemap(Terrain _terrain, out Texture2D _diffuseMap, out Texture2D _normalMap, int _width, int _height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2266C80", Offset = "0x2266080", VA = "0x182266C80")]
		public static int ExtractTexturesInfo(Terrain _terrain, out Texture2D[] _diffuseTextures, out Texture2D[] _normalTextures, out Vector2[] _uvScale, out Vector2[] _uvOffset, out float[] _metalic, out float[] _smoothness)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x22688B0", Offset = "0x2267CB0", VA = "0x1822688B0")]
		private static void GenerateTerrainBaseChunks(ref PreMesh[] _preMeshes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2269300", Offset = "0x2268700", VA = "0x182269300")]
		private static Mesh GenerateTerrainMainChunks(ref PreMesh _preMesh, float _chunkH_Width, float _chunkH_StartOffset, float _chunkV_Length, float _chunkV_StartOffset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2269EC0", Offset = "0x22692C0", VA = "0x182269EC0")]
		private static Mesh GenerateTerrain()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2267740", Offset = "0x2266B40", VA = "0x182267740")]
		private static void GenerateNormals(Vector3[] _vertices, int[] _trinagles, out Vector3[] _normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2267DF0", Offset = "0x22671F0", VA = "0x182267DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2265150", Offset = "0x2264550", VA = "0x182265150")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2265170", Offset = "0x2264570", VA = "0x182265170")]
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
