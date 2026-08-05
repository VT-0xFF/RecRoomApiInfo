using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("VacuumShaders.TerrainToMesh")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("VacuumShaders.TerrainToMesh")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("67a857b2-7c34-4000-8bed-14944860fcb7")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace VacuumShaders.TerrainToMesh;

public class CompressedMeshLoader : MonoBehaviour
{
	private enum SIDE
	{
		Left,
		Right,
		Top,
		Bottom
	}

	[HideInInspector]
	public int chunkCountHorizontal;

	[HideInInspector]
	public int chunkCountVertical;

	[HideInInspector]
	public int vertexCountHoriznontal;

	[HideInInspector]
	public int vertexCountVertical;

	private void Start()
	{
		MeshFilter[] componentsInChildren = base.transform.GetComponentsInChildren<MeshFilter>();
		int num = 0;
		if (componentsInChildren == null || componentsInChildren.Length < 1)
		{
			Debug.LogError("CompressedMeshLoader: '" + base.transform.name + "' has no compressed mesh data to load\n", this);
			base.enabled = false;
			return;
		}
		if (componentsInChildren[0] == null || componentsInChildren[0].sharedMesh == null || componentsInChildren[0].sharedMesh.vertexCount < 4)
		{
			Debug.LogError("CompressedMeshLoader: '" + base.transform.name + "' failed to load some of compressed meshes\n", this);
			base.enabled = false;
			return;
		}
		num = componentsInChildren[0].sharedMesh.vertexCount;
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == null || componentsInChildren[i].sharedMesh == null || componentsInChildren[i].sharedMesh.vertexCount != num)
			{
				Debug.LogError("CompressedMeshLoader: '" + base.transform.name + "' failed to load some of compressed meshes\n", this);
				base.enabled = false;
				return;
			}
		}
		if (chunkCountHorizontal < 1)
		{
			chunkCountHorizontal = 1;
		}
		if (chunkCountVertical < 1)
		{
			chunkCountVertical = 1;
		}
		if (base.transform.childCount != chunkCountHorizontal * chunkCountVertical)
		{
			Debug.LogError("CompressedMeshLoader: Total chunk count is not correct.\n", this);
			base.enabled = false;
			return;
		}
		if (vertexCountHoriznontal < 2)
		{
			vertexCountHoriznontal = 2;
		}
		if (vertexCountVertical < 2)
		{
			vertexCountVertical = 2;
		}
		if (num != vertexCountHoriznontal * vertexCountVertical)
		{
			Debug.LogError("CompressedMeshLoader: Total vertex count is not correct.\n", this);
			base.enabled = false;
		}
		else
		{
			Fix(componentsInChildren);
		}
	}

	private void Fix(MeshFilter[] _childMeshFilter)
	{
		int num = 0;
		for (int i = 0; i < chunkCountHorizontal; i++)
		{
			for (int j = 0; j < chunkCountVertical - 1; j++)
			{
				Combine(_childMeshFilter[num + j].sharedMesh, _childMeshFilter[num + j + 1].sharedMesh, bottomTop: true);
			}
			num += chunkCountVertical;
		}
		num = 0;
		for (int k = 0; k < chunkCountHorizontal - 1; k++)
		{
			for (int l = 0; l < chunkCountVertical; l++)
			{
				Combine(_childMeshFilter[num + l].sharedMesh, _childMeshFilter[num + l + chunkCountVertical].sharedMesh, bottomTop: false);
			}
			num += chunkCountVertical;
		}
	}

	private void GetMeshData(Mesh _mesh, SIDE _side, out Vector3[] vertices, out Vector2[] uv, out Vector2[] uv2, out Vector3[] normal, out Vector4[] tangent)
	{
		int[] indexies = GetIndexies(_side);
		Vector3[] vertices2 = _mesh.vertices;
		Vector2[] uv3 = _mesh.uv;
		Vector2[] uv4 = _mesh.uv2;
		Vector3[] normals = _mesh.normals;
		Vector4[] tangents = _mesh.tangents;
		bool flag = ((_mesh.uv != null && _mesh.uv.Length == _mesh.vertices.Length) ? true : false);
		bool flag2 = ((_mesh.uv2 != null && _mesh.uv2.Length == _mesh.vertices.Length) ? true : false);
		bool flag3 = ((_mesh.normals != null && _mesh.normals.Length == _mesh.vertices.Length) ? true : false);
		bool flag4 = ((_mesh.tangents != null && _mesh.tangents.Length == _mesh.vertices.Length) ? true : false);
		vertices = new Vector3[indexies.Length];
		uv = (flag ? new Vector2[indexies.Length] : null);
		uv2 = (flag2 ? new Vector2[indexies.Length] : null);
		normal = (flag3 ? new Vector3[indexies.Length] : null);
		tangent = (flag4 ? new Vector4[indexies.Length] : null);
		for (int i = 0; i < indexies.Length; i++)
		{
			int num = indexies[i];
			vertices[i] = vertices2[num];
			if (flag)
			{
				uv[i] = uv3[num];
			}
			if (flag2)
			{
				uv2[i] = uv4[num];
			}
			if (flag3)
			{
				normal[i] = normals[num];
			}
			if (flag4)
			{
				tangent[i] = tangents[num];
			}
		}
	}

	private int[] GetIndexies(SIDE _side)
	{
		int[] array = new int[(_side == SIDE.Left || _side == SIDE.Right) ? vertexCountVertical : vertexCountHoriznontal];
		switch (_side)
		{
		case SIDE.Bottom:
		{
			for (int j = 0; j < vertexCountHoriznontal; j++)
			{
				array[j] = j;
			}
			break;
		}
		case SIDE.Top:
		{
			int num2 = vertexCountHoriznontal * (vertexCountVertical - 1);
			for (int l = 0; l < vertexCountHoriznontal; l++)
			{
				array[l] = num2 + l;
			}
			break;
		}
		case SIDE.Left:
		{
			int num3 = 0;
			for (int m = 0; m < vertexCountVertical; m++)
			{
				array[m] = num3;
				num3 += vertexCountHoriznontal;
			}
			break;
		}
		case SIDE.Right:
		{
			int num = vertexCountHoriznontal - 1;
			for (int k = 0; k < vertexCountVertical; k++)
			{
				array[k] = num;
				num += vertexCountHoriznontal;
			}
			break;
		}
		default:
		{
			for (int i = 0; i < vertexCountHoriznontal; i++)
			{
				array[i] = 0;
			}
			break;
		}
		}
		return array;
	}

	private void Combine(Mesh _meshBottom, Mesh _meshTop, bool bottomTop)
	{
		GetMeshData(_meshBottom, (!bottomTop) ? SIDE.Right : SIDE.Top, out var vertices, out var uv, out var uv2, out var normal, out var tangent);
		int[] indexies = GetIndexies(bottomTop ? SIDE.Bottom : SIDE.Left);
		Vector3[] vertices2 = _meshTop.vertices;
		Vector2[] uv3 = _meshTop.uv;
		Vector2[] uv4 = _meshTop.uv2;
		Vector3[] normals = _meshTop.normals;
		Vector4[] tangents = _meshTop.tangents;
		for (int i = 0; i < vertices.Length; i++)
		{
			vertices2[indexies[i]] = vertices[i];
			if (uv != null)
			{
				uv3[indexies[i]] = uv[i];
			}
			if (uv2 != null)
			{
				uv4[indexies[i]] = uv2[i];
			}
			if (normal != null)
			{
				normals[indexies[i]] = normal[i];
			}
			if (tangent != null)
			{
				tangents[indexies[i]] = tangent[i];
			}
		}
		_meshTop.vertices = vertices2;
		if (uv != null)
		{
			_meshTop.uv = uv3;
		}
		if (uv2 != null)
		{
			_meshTop.uv2 = uv4;
		}
		if (normal != null)
		{
			_meshTop.normals = normals;
		}
		if (tangent != null)
		{
			_meshTop.tangents = tangents;
		}
	}
}
[Serializable]
public class TerrainConvertInfo
{
	public const int maxVertexCount = 65000;

	public int chunkCountHorizontal;

	public int chunkCountVertical;

	public int vertexCountHorizontal;

	public int vertexCountVertical;

	public TerrainConvertInfo()
	{
		Reset();
	}

	public TerrainConvertInfo(TerrainConvertInfo _right)
	{
		chunkCountHorizontal = _right.chunkCountHorizontal;
		chunkCountVertical = _right.chunkCountVertical;
		vertexCountHorizontal = _right.vertexCountHorizontal;
		vertexCountVertical = _right.vertexCountVertical;
	}

	public void Reset()
	{
		chunkCountHorizontal = 1;
		chunkCountVertical = 1;
		vertexCountHorizontal = 25;
		vertexCountVertical = 25;
	}

	public int GetChunkCount()
	{
		if (chunkCountHorizontal < 1)
		{
			chunkCountHorizontal = 1;
		}
		if (chunkCountVertical < 1)
		{
			chunkCountVertical = 1;
		}
		return chunkCountHorizontal * chunkCountVertical;
	}

	public int GetVertexCountPerChunk()
	{
		return vertexCountHorizontal * vertexCountVertical;
	}

	public int GetVertexCountTotal()
	{
		return GetChunkCount() * GetVertexCountPerChunk();
	}

	public int GetTriangleCountPerChunk()
	{
		return (vertexCountHorizontal - 1) * (vertexCountVertical - 1) * 2;
	}

	public int GetTriangleCountTotal()
	{
		return GetChunkCount() * GetTriangleCountPerChunk();
	}
}
public static class TerrainToMeshConverter
{
	public delegate void ProgressFunction(string _name, float _value);

	private static Terrain terrain;

	private static TerrainConvertInfo terrainConvertInfo;

	public static ProgressFunction callback;

	public static Mesh[] Convert(Terrain _terrain, TerrainConvertInfo _terrainConvertInfo, ProgressFunction _callback = null)
	{
		if (_terrain == null)
		{
			Debug.LogWarning("Terrain To Mesh: Can not convert 'Terrain' is null.\n");
			return null;
		}
		if (_terrainConvertInfo == null)
		{
			_terrainConvertInfo = new TerrainConvertInfo();
		}
		if (_terrainConvertInfo.chunkCountHorizontal < 1)
		{
			_terrainConvertInfo.chunkCountHorizontal = 1;
		}
		if (_terrainConvertInfo.chunkCountVertical < 1)
		{
			_terrainConvertInfo.chunkCountVertical = 1;
		}
		if (_terrainConvertInfo.vertexCountHorizontal < 2)
		{
			_terrainConvertInfo.vertexCountHorizontal = 2;
		}
		if (_terrainConvertInfo.vertexCountVertical < 2)
		{
			_terrainConvertInfo.vertexCountVertical = 2;
		}
		if (_terrainConvertInfo.GetVertexCountPerChunk() > 65000)
		{
			Debug.LogWarning("Terrain To Mesh: Mesh vertex count limit exceeded.\nUnity mesh can have maximum 65.000 vertices.\n");
			return null;
		}
		callback = _callback;
		Vector3 position = _terrain.transform.position;
		Quaternion rotation = _terrain.transform.rotation;
		Vector3 localScale = _terrain.transform.localScale;
		terrain = _terrain;
		terrain.transform.position = Vector3.zero;
		terrain.transform.rotation = Quaternion.identity;
		terrain.transform.localScale = Vector3.one;
		terrainConvertInfo = _terrainConvertInfo;
		Mesh[] array = null;
		if (terrainConvertInfo.chunkCountHorizontal * terrainConvertInfo.chunkCountVertical == 1)
		{
			array = new Mesh[1] { GenerateTerrain() };
		}
		else
		{
			PreMesh[] _preMeshes = null;
			GenerateTerrainBaseChunks(ref _preMeshes);
			array = new Mesh[_preMeshes.Length];
			int num = -1;
			for (int i = 0; i < terrainConvertInfo.chunkCountHorizontal; i++)
			{
				for (int j = 0; j < terrainConvertInfo.chunkCountVertical; j++)
				{
					float num2 = terrain.terrainData.size.x / (float)terrainConvertInfo.chunkCountHorizontal;
					float chunkH_StartOffset = (float)i * num2;
					float num3 = terrain.terrainData.size.z / (float)terrainConvertInfo.chunkCountVertical;
					float chunkV_StartOffset = (float)j * num3;
					if (callback != null)
					{
						callback("Chunk [" + (num + 1) + " of " + array.Length + "]  ", (1f + (float)num) / (float)(terrainConvertInfo.chunkCountHorizontal * terrainConvertInfo.chunkCountVertical));
					}
					num++;
					array[num] = GenerateTerrainMainChunks(ref _preMeshes[num], num2, chunkH_StartOffset, num3, chunkV_StartOffset);
					array[num].RecalculateBounds();
				}
			}
		}
		_terrain.transform.position = position;
		_terrain.transform.rotation = rotation;
		_terrain.transform.localScale = localScale;
		return array;
	}

	public static Texture2D[] ExtractSplatmaps(Terrain _terrain)
	{
		if (_terrain != null && _terrain.terrainData != null)
		{
			return _terrain.terrainData.alphamapTextures;
		}
		return null;
	}

	public static void ExtractBasemap(Terrain _terrain, out Texture2D _diffuseMap, out Texture2D _normalMap, int _width, int _height)
	{
		if (_width < 4)
		{
			_width = 4;
		}
		if (_height < 4)
		{
			_height = 4;
		}
		_diffuseMap = null;
		_normalMap = null;
		if (_terrain == null || _terrain.terrainData == null || _terrain.terrainData.alphamapTextures == null || _terrain.terrainData.alphamapTextures.Length == 0)
		{
			Debug.LogWarning("Can not create basemap, terrain has no splatmaps\n");
			return;
		}
		Shader shader = Shader.Find("Hidden/VacuumShaders/Terrain To Mesh/Basemap");
		if (shader == null)
		{
			Debug.LogWarning("'Hidden/VacuumShaders/Terrain To Mesh/Basemap' shader not found\n");
			return;
		}
		Material material = new Material(shader);
		Texture2D[] alphamapTextures = _terrain.terrainData.alphamapTextures;
		Texture2D[] _diffuseTextures;
		Texture2D[] _normalTextures;
		Vector2[] _uvScale;
		Vector2[] _uvOffset;
		float[] _metalic;
		float[] _smoothness;
		int num = ExtractTexturesInfo(_terrain, out _diffuseTextures, out _normalTextures, out _uvScale, out _uvOffset, out _metalic, out _smoothness);
		if (num == 0)
		{
			Debug.LogWarning("Terrain has no enough data for Basemap generating\n");
			return;
		}
		Texture2D texture2D = new Texture2D(2, 2, TextureFormat.ARGB32, mipmap: false);
		texture2D.SetPixels(new Color[4]
		{
			Color.clear,
			Color.clear,
			Color.clear,
			Color.clear
		});
		texture2D.Apply();
		RenderTexture active = RenderTexture.active;
		RenderTexture temporary = RenderTexture.GetTemporary(_width, _height, 24);
		RenderTexture temporary2 = RenderTexture.GetTemporary(_width, _height, 24);
		if (_diffuseTextures != null)
		{
			temporary.DiscardContents();
			Graphics.Blit(texture2D, temporary);
			for (int i = 0; i < num; i++)
			{
				if (i % 4 == 0)
				{
					material.SetTexture("_V_T2M_Control", alphamapTextures[i / 4]);
				}
				material.SetFloat("_V_T2M_ChannelIndex", 0.5f + (float)(i % 4));
				if (_diffuseTextures[i] == null)
				{
					Debug.LogWarning("Terrain '" + _terrain.name + "' is missing diffuse texture " + i);
					material.SetTexture("_V_T2M_Splat_D", null);
				}
				else
				{
					material.SetTexture("_V_T2M_Splat_D", _diffuseTextures[i]);
					material.SetVector("_V_T2M_Splat_uvScale", new Vector4(_uvScale[i].x, _uvScale[i].y, _uvOffset[i].x, _uvOffset[i].y));
				}
				temporary2.DiscardContents();
				Graphics.Blit(temporary, temporary2, material, 0);
				temporary.DiscardContents();
				Graphics.Blit(temporary2, temporary);
			}
			RenderTexture.active = temporary;
			_diffuseMap = new Texture2D(_width, _height, TextureFormat.ARGB32, mipmap: true);
			_diffuseMap.ReadPixels(new Rect(0f, 0f, _width, _height), 0, 0);
			_diffuseMap.Apply();
		}
		if (_normalTextures != null)
		{
			temporary.DiscardContents();
			Graphics.Blit(texture2D, temporary);
			for (int j = 0; j < num; j++)
			{
				if (j % 4 == 0)
				{
					material.SetTexture("_V_T2M_Control", alphamapTextures[j / 4]);
				}
				material.SetFloat("_V_T2M_ChannelIndex", 0.5f + (float)(j % 4));
				if (_normalTextures[j] == null)
				{
					Debug.LogWarning("Terrain '" + _terrain.name + "' is missing normal texture " + j);
					material.SetTexture("_V_T2M_Splat_N", null);
					material.SetVector("_V_T2M_Splat_uvScale", Vector4.zero);
				}
				else
				{
					material.SetTexture("_V_T2M_Splat_N", _normalTextures[j]);
					material.SetVector("_V_T2M_Splat_uvScale", new Vector4(_uvScale[j].x, _uvScale[j].y, _uvOffset[j].x, _uvOffset[j].y));
				}
				temporary2.DiscardContents();
				Graphics.Blit(temporary, temporary2, material, 1);
				temporary.DiscardContents();
				Graphics.Blit(temporary2, temporary);
			}
			RenderTexture.active = temporary;
			_normalMap = new Texture2D(_width, _height, TextureFormat.ARGB32, mipmap: true);
			_normalMap.ReadPixels(new Rect(0f, 0f, _width, _height), 0, 0);
			_normalMap.Apply();
		}
		RenderTexture.active = null;
		if (Application.isPlaying)
		{
			RenderTexture.active = active;
		}
		UnityEngine.Object.DestroyImmediate(material);
		UnityEngine.Object.DestroyImmediate(texture2D);
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
	}

	public static Texture2D ExtractHeightmap(Terrain _terrain, bool _remap)
	{
		if (_terrain == null || _terrain.terrainData == null)
		{
			return null;
		}
		int heightmapWidth = _terrain.terrainData.heightmapWidth;
		int heightmapHeight = _terrain.terrainData.heightmapHeight;
		Texture2D texture2D = new Texture2D(heightmapWidth, heightmapHeight, TextureFormat.ARGB32, mipmap: true);
		float[,] heights = _terrain.terrainData.GetHeights(0, 0, heightmapWidth, heightmapHeight);
		float num = 1f;
		float num2 = 0f;
		if (_remap)
		{
			for (int i = 0; i < texture2D.height; i++)
			{
				for (int j = 0; j < texture2D.width; j++)
				{
					float num3 = heights[i, j];
					if (num3 < num)
					{
						num = num3;
					}
					if (num3 > num2)
					{
						num2 = num3;
					}
				}
			}
		}
		for (int k = 0; k < texture2D.height; k++)
		{
			for (int l = 0; l < texture2D.width; l++)
			{
				float num4 = heights[k, l];
				if (_remap)
				{
					num4 = Remap(num4, num, num2, 0f, 1f);
				}
				Color color = new Color(num4, num4, num4, 1f);
				texture2D.SetPixel(l, k, color);
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	public static int ExtractTexturesInfo(Terrain _terrain, out Texture2D[] _diffuseTextures, out Texture2D[] _normalTextures, out Vector2[] _uvScale, out Vector2[] _uvOffset, out float[] _metalic, out float[] _smoothness)
	{
		_diffuseTextures = null;
		_normalTextures = null;
		_uvScale = null;
		_uvOffset = null;
		_metalic = null;
		_smoothness = null;
		if (_terrain == null || _terrain.terrainData == null || _terrain.terrainData.splatPrototypes == null || _terrain.terrainData.splatPrototypes.Length == 0)
		{
			return 0;
		}
		int num = _terrain.terrainData.splatPrototypes.Length;
		_diffuseTextures = new Texture2D[num];
		_normalTextures = new Texture2D[num];
		_uvScale = new Vector2[num];
		_uvOffset = new Vector2[num];
		_metalic = new float[num];
		_smoothness = new float[num];
		for (int i = 0; i < num; i++)
		{
			SplatPrototype splatPrototype = _terrain.terrainData.splatPrototypes[i];
			if (splatPrototype == null)
			{
				_diffuseTextures[i] = null;
				_normalTextures[i] = null;
				_uvScale[i] = Vector2.one;
				_uvOffset[i] = Vector2.zero;
				_metalic[i] = 0f;
				_smoothness[i] = 0f;
				continue;
			}
			if (splatPrototype.texture == null)
			{
				_diffuseTextures[i] = null;
			}
			else
			{
				_diffuseTextures[i] = splatPrototype.texture;
			}
			if (splatPrototype.normalMap == null)
			{
				_normalTextures[i] = null;
			}
			else
			{
				_normalTextures[i] = splatPrototype.normalMap;
			}
			float x = ((splatPrototype.tileSize.x == 0f) ? 0f : (_terrain.terrainData.size.x / splatPrototype.tileSize.x));
			float y = ((splatPrototype.tileSize.y == 0f) ? 0f : (_terrain.terrainData.size.z / splatPrototype.tileSize.y));
			float x2 = ((splatPrototype.tileSize.x == 0f) ? 0f : (splatPrototype.tileOffset.x / splatPrototype.tileSize.x));
			float y2 = ((splatPrototype.tileSize.y == 0f) ? 0f : (splatPrototype.tileOffset.y / splatPrototype.tileSize.y));
			_uvScale[i] = new Vector2(x, y);
			_uvOffset[i] = new Vector2(x2, y2);
			_metalic[i] = splatPrototype.metallic;
			_smoothness[i] = splatPrototype.smoothness;
		}
		bool flag = false;
		for (int j = 0; j < _diffuseTextures.Length; j++)
		{
			if (_diffuseTextures[j] != null)
			{
				flag = true;
			}
		}
		if (!flag)
		{
			_diffuseTextures = null;
		}
		bool flag2 = false;
		for (int k = 0; k < _normalTextures.Length; k++)
		{
			if (_normalTextures[k] != null)
			{
				flag2 = true;
			}
		}
		if (!flag2)
		{
			_normalTextures = null;
		}
		if (!flag && !flag2)
		{
			_uvScale = null;
			_uvOffset = null;
			num = 0;
		}
		return num;
	}

	public static GameObject ExtractTrees(Terrain _terrain)
	{
		if (_terrain == null || _terrain.terrainData == null || _terrain.terrainData.treePrototypes == null)
		{
			return null;
		}
		TerrainData terrainData = _terrain.terrainData;
		GameObject gameObject = new GameObject(_terrain.name + "_Trees");
		gameObject.transform.position = Vector3.zero;
		gameObject.transform.rotation = Quaternion.identity;
		GameObject[] array = new GameObject[terrainData.treePrototypes.Length];
		for (int i = 0; i < terrainData.treePrototypes.Length; i++)
		{
			if (terrainData.treePrototypes[i] != null && !(terrainData.treePrototypes[i].prefab == null))
			{
				array[i] = new GameObject(terrainData.treePrototypes[i].prefab.name);
				array[i].transform.position = Vector3.zero;
				array[i].transform.rotation = Quaternion.identity;
				array[i].transform.parent = gameObject.transform;
			}
		}
		for (int j = 0; j < terrainData.treeInstances.Length; j++)
		{
			TreeInstance treeInstance = terrainData.treeInstances[j];
			if (terrainData.treePrototypes[treeInstance.prototypeIndex] != null && !(terrainData.treePrototypes[treeInstance.prototypeIndex].prefab == null))
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(terrainData.treePrototypes[treeInstance.prototypeIndex].prefab, Vector3.zero, Quaternion.identity);
				gameObject2.name = gameObject2.name.Replace("(Clone)", string.Empty);
				Vector3 position = treeInstance.position;
				position.x *= terrainData.size.x;
				position.y *= terrainData.size.y;
				position.z *= terrainData.size.z;
				gameObject2.transform.position = position;
				gameObject2.transform.localRotation = Quaternion.AngleAxis(57.29578f * treeInstance.rotation, Vector3.up);
				Vector3 localScale = terrainData.treePrototypes[treeInstance.prototypeIndex].prefab.transform.localScale;
				Vector3 one = Vector3.one;
				one.x *= treeInstance.widthScale * localScale.x;
				one.y *= treeInstance.heightScale * localScale.y;
				one.z *= treeInstance.widthScale * localScale.z;
				gameObject2.transform.localScale = one;
				gameObject2.transform.parent = array[treeInstance.prototypeIndex].transform;
			}
		}
		int num = 0;
		GameObject gameObject3;
		for (int num2 = array.Length - 1; num2 >= 0; num2--)
		{
			if (array[num2] != null)
			{
				int childCount = array[num2].transform.childCount;
				if (childCount == 0)
				{
					UnityEngine.Object.DestroyImmediate(array[num2]);
				}
				else
				{
					gameObject3 = array[num2];
					gameObject3.name = gameObject3.name + " (" + childCount + ")";
					num += childCount;
				}
			}
		}
		gameObject3 = gameObject;
		gameObject3.name = gameObject3.name + " (" + num + ")";
		return gameObject;
	}

	private static void GenerateTerrainBaseChunks(ref PreMesh[] _preMeshes)
	{
		_preMeshes = new PreMesh[terrainConvertInfo.chunkCountHorizontal * terrainConvertInfo.chunkCountVertical];
		TerrainData terrainData = terrain.terrainData;
		int num = terrainConvertInfo.vertexCountVertical - 1;
		int num2 = terrainConvertInfo.vertexCountHorizontal - 1;
		if (num < 1)
		{
			num = 1;
		}
		if (num2 < 1)
		{
			num2 = 1;
		}
		int num3 = -1;
		for (int i = 0; i < terrainConvertInfo.chunkCountHorizontal; i++)
		{
			for (int j = 0; j < terrainConvertInfo.chunkCountVertical; j++)
			{
				float num4 = terrain.terrainData.size.x / (float)terrainConvertInfo.chunkCountHorizontal;
				float num5 = (float)i * num4;
				float num6 = terrain.terrainData.size.z / (float)terrainConvertInfo.chunkCountVertical;
				float num7 = (float)j * num6;
				float num8 = num4 / (float)num2;
				float num9 = num6 / (float)num;
				int num10 = num + 1 + 2;
				int num11 = num2 + 1 + 2;
				List<Vector3> list = new List<Vector3>(num11 * num10);
				List<int> list2 = new List<int>((num + 2) * (num2 + 2) * 2 * 3);
				Vector2[] array = new Vector2[num11 * num10];
				int num12 = -1;
				for (int k = 0; k < num10; k++)
				{
					for (int l = 0; l < num11; l++)
					{
						Vector3 vector = new Vector3(num5 + (float)l * num8 - num8, 0f, num7 + (float)k * num9 - num9);
						vector.y = terrain.SampleHeight(vector);
						num12++;
						list.Add(vector);
						array[num12] = new Vector2(Mathf.Clamp01(vector.x / terrainData.size.x), Mathf.Clamp01(vector.z / terrainData.size.z));
					}
				}
				int num13 = 0;
				int num14 = 0;
				num12 = -1;
				for (int m = 0; m < num + 2; m++)
				{
					num13 = m * num11;
					num14 += num11;
					for (int n = 0; n < num2 + 2; n++)
					{
						list2.Add(num13 + n);
						list2.Add(num14 + n);
						list2.Add(num14 + n + 1);
						list2.Add(num13 + n + 1);
						list2.Add(num13 + n);
						list2.Add(num14 + n + 1);
						num12 += 6;
					}
				}
				_preMeshes[++num3] = new PreMesh();
				_preMeshes[num3].name = terrain.gameObject.name + $"_x{i}_y{j}";
				_preMeshes[num3].vertices = list.ToArray();
				_preMeshes[num3].triangles = list2.ToArray();
				_preMeshes[num3].uv = array;
				_preMeshes[num3].uv2 = array;
				GenerateNormals(_preMeshes[num3].vertices, _preMeshes[num3].triangles, out _preMeshes[num3].normals);
				GenerateTangents(_preMeshes[num3].vertices, _preMeshes[num3].triangles, _preMeshes[num3].normals, _preMeshes[num3].uv, out _preMeshes[num3].tangents);
			}
		}
	}

	private static Mesh GenerateTerrainMainChunks(ref PreMesh _preMesh, float _chunkH_Width, float _chunkH_StartOffset, float _chunkV_Length, float _chunkV_StartOffset)
	{
		_ = terrainConvertInfo.vertexCountVertical - 1;
		int num = terrainConvertInfo.vertexCountHorizontal - 1;
		_ = 1;
		if (num < 1)
		{
			num = 1;
		}
		List<Vector3> list = new List<Vector3>(_preMesh.vertices);
		List<int> list2 = new List<int>();
		list2 = new List<int>(_preMesh.triangles);
		list = new List<Vector3>(_preMesh.vertices);
		int[] array = null;
		int[] array2 = null;
		array = new int[2 * terrainConvertInfo.vertexCountHorizontal + 2 * terrainConvertInfo.vertexCountVertical + 4];
		int num2 = 0;
		for (int i = 0; i < terrainConvertInfo.vertexCountHorizontal + 2; i++)
		{
			array[num2++] = i;
		}
		int num3 = terrainConvertInfo.vertexCountHorizontal + 1;
		for (int j = 0; j < terrainConvertInfo.vertexCountVertical; j++)
		{
			num3++;
			array[num2++] = num3;
			num3 += terrainConvertInfo.vertexCountHorizontal + 1;
			array[num2++] = num3;
		}
		for (int k = 1; k < terrainConvertInfo.vertexCountHorizontal + 3; k++)
		{
			array[num2++] = num3 + k;
		}
		array2 = new int[4 * (terrainConvertInfo.vertexCountHorizontal - 1) + 4 * (terrainConvertInfo.vertexCountVertical - 1) + 8];
		num2 = 0;
		num3 = 0;
		for (int l = 0; l < terrainConvertInfo.vertexCountHorizontal + 1; l++)
		{
			array2[num2++] = num3++;
			array2[num2++] = num3++;
		}
		for (int m = 0; m < terrainConvertInfo.vertexCountVertical - 1; m++)
		{
			array2[num2++] = num3++;
			array2[num2++] = num3++;
			num3 += 2 * (terrainConvertInfo.vertexCountHorizontal - 1);
			array2[num2++] = num3++;
			array2[num2++] = num3++;
		}
		for (int n = 0; n < terrainConvertInfo.vertexCountHorizontal + 1; n++)
		{
			array2[num2++] = num3++;
			array2[num2++] = num3++;
		}
		for (int num4 = array2.Length - 1; num4 >= 0; num4--)
		{
			int num5 = array2[num4];
			list2.RemoveAt(num5 * 3 + 2);
			list2.RemoveAt(num5 * 3 + 1);
			list2.RemoveAt(num5 * 3);
		}
		int num6 = terrainConvertInfo.vertexCountHorizontal + 3;
		int num7 = -1;
		for (int num8 = 0; num8 < terrainConvertInfo.vertexCountVertical - 1; num8++)
		{
			for (int num9 = 0; num9 < terrainConvertInfo.vertexCountHorizontal - 1; num9++)
			{
				list2[++num7] -= num6;
				int num10 = list2[num7];
				list2[++num7] = num10 + terrainConvertInfo.vertexCountHorizontal;
				list2[++num7] = num10 + terrainConvertInfo.vertexCountHorizontal + 1;
				list2[++num7] = num10 + 1;
				list2[++num7] = num10;
				list2[++num7] = num10 + terrainConvertInfo.vertexCountHorizontal + 1;
			}
			num6 += 2;
		}
		List<Vector2> list3 = new List<Vector2>(_preMesh.uv);
		List<Vector2> list4 = new List<Vector2>(_preMesh.uv2);
		List<Vector3> list5 = new List<Vector3>(_preMesh.normals);
		List<Vector4> list6 = new List<Vector4>(_preMesh.tangents);
		for (int num11 = array.Length - 1; num11 >= 0; num11--)
		{
			list.RemoveAt(array[num11]);
		}
		for (int num12 = array.Length - 1; num12 >= 0; num12--)
		{
			list3.RemoveAt(array[num12]);
		}
		for (int num13 = array.Length - 1; num13 >= 0; num13--)
		{
			list4.RemoveAt(array[num13]);
		}
		for (int num14 = array.Length - 1; num14 >= 0; num14--)
		{
			list5.RemoveAt(array[num14]);
		}
		for (int num15 = array.Length - 1; num15 >= 0; num15--)
		{
			list6.RemoveAt(array[num15]);
		}
		_preMesh.Clear();
		return new Mesh
		{
			name = _preMesh.name,
			vertices = list.ToArray(),
			triangles = list2.ToArray(),
			uv = list3.ToArray(),
			uv2 = list4.ToArray(),
			normals = list5.ToArray(),
			tangents = list6.ToArray()
		};
	}

	private static Mesh GenerateTerrain()
	{
		TerrainData terrainData = terrain.terrainData;
		int num = terrainConvertInfo.vertexCountVertical - 1;
		int num2 = terrainConvertInfo.vertexCountHorizontal - 1;
		if (num < 1)
		{
			num = 1;
		}
		if (num2 < 1)
		{
			num2 = 1;
		}
		float x = terrainData.size.x;
		float z = terrainData.size.z;
		float num3 = x / (float)num2;
		float num4 = z / (float)num;
		int num5 = num + 1;
		int num6 = num2 + 1;
		Vector3[] array = new Vector3[num6 * num5];
		int[] array2 = new int[num * num2 * 2 * 3];
		Vector2[] array3 = new Vector2[num6 * num5];
		int num7 = -1;
		for (int i = 0; i < num5; i++)
		{
			for (int j = 0; j < num6; j++)
			{
				Vector3 vector = new Vector3((float)j * num3, 0f, (float)i * num4);
				vector.y = terrain.SampleHeight(vector);
				array[++num7] = vector;
				array3[num7] = new Vector2(Mathf.Clamp01(vector.x / terrainData.size.x), Mathf.Clamp01(vector.z / terrainData.size.z));
			}
		}
		int num8 = 0;
		int num9 = 0;
		num7 = -1;
		for (int k = 0; k < num; k++)
		{
			num8 = k * num6;
			num9 += num6;
			for (int l = 0; l < num2; l++)
			{
				array2[++num7] = num8 + l;
				array2[++num7] = num9 + l;
				array2[++num7] = num9 + l + 1;
				array2[++num7] = num8 + l + 1;
				array2[++num7] = num8 + l;
				array2[++num7] = num9 + l + 1;
			}
		}
		Mesh mesh = new Mesh();
		mesh.name = terrain.gameObject.name;
		mesh.hideFlags = HideFlags.HideAndDontSave;
		mesh.vertices = array;
		mesh.triangles = array2;
		mesh.RecalculateBounds();
		mesh.uv = array3;
		mesh.uv2 = array3;
		mesh.RecalculateNormals();
		Vector3[] normals = mesh.normals;
		Vector4[] _tangents = null;
		GenerateTangents(array, array2, normals, array3, out _tangents);
		mesh.tangents = _tangents;
		return mesh;
	}

	private static void GenerateNormals(Vector3[] _vertices, int[] _trinagles, out Vector3[] _normals)
	{
		_normals = new Vector3[_vertices.Length];
		List<List<Vector3>> list = new List<List<Vector3>>();
		for (int i = 0; i < _vertices.Length; i++)
		{
			list.Add(new List<Vector3>());
		}
		for (int j = 0; j < _trinagles.Length; j += 3)
		{
			Vector3 vector = _vertices[_trinagles[j]];
			Vector3 vector2 = _vertices[_trinagles[j + 1]];
			Vector3 vector3 = _vertices[_trinagles[j + 2]];
			Vector3 lhs = vector2 - vector;
			Vector3 rhs = vector3 - vector;
			Vector3 item = Vector3.Cross(lhs, rhs);
			item.Normalize();
			list[_trinagles[j]].Add(item);
			list[_trinagles[j + 1]].Add(item);
			list[_trinagles[j + 2]].Add(item);
		}
		for (int k = 0; k < _vertices.Length; k++)
		{
			Vector3 zero = Vector3.zero;
			for (int l = 0; l < list[k].Count; l++)
			{
				zero += list[k][l];
			}
			_normals[k] = zero / list[k].Count;
		}
	}

	private static void GenerateTangents(Vector3[] _vertices, int[] _triangles, Vector3[] _normals, Vector2[] _texcoords, out Vector4[] _tangents)
	{
		int num = _vertices.Length;
		int num2 = _triangles.Length / 3;
		_tangents = new Vector4[num];
		Vector3[] array = new Vector3[num];
		Vector3[] array2 = new Vector3[num];
		int num3 = 0;
		for (int i = 0; i < num2; i++)
		{
			int num4 = _triangles[num3];
			int num5 = _triangles[num3 + 1];
			int num6 = _triangles[num3 + 2];
			Vector3 vector = _vertices[num4];
			Vector3 vector2 = _vertices[num5];
			Vector3 vector3 = _vertices[num6];
			Vector2 vector4 = _texcoords[num4];
			Vector2 vector5 = _texcoords[num5];
			Vector2 vector6 = _texcoords[num6];
			float num7 = vector2.x - vector.x;
			float num8 = vector3.x - vector.x;
			float num9 = vector2.y - vector.y;
			float num10 = vector3.y - vector.y;
			float num11 = vector2.z - vector.z;
			float num12 = vector3.z - vector.z;
			float num13 = vector5.x - vector4.x;
			float num14 = vector6.x - vector4.x;
			float num15 = vector5.y - vector4.y;
			float num16 = vector6.y - vector4.y;
			float num17 = 0.0001f;
			if (num13 * num16 - num14 * num15 != 0f)
			{
				num17 = 1f / (num13 * num16 - num14 * num15);
			}
			Vector3 vector7 = new Vector3((num16 * num7 - num15 * num8) * num17, (num16 * num9 - num15 * num10) * num17, (num16 * num11 - num15 * num12) * num17);
			Vector3 vector8 = new Vector3((num13 * num8 - num14 * num7) * num17, (num13 * num10 - num14 * num9) * num17, (num13 * num12 - num14 * num11) * num17);
			array[num4] += vector7;
			array[num5] += vector7;
			array[num6] += vector7;
			array2[num4] += vector8;
			array2[num5] += vector8;
			array2[num6] += vector8;
			num3 += 3;
		}
		for (int j = 0; j < num; j++)
		{
			Vector3 normal = _normals[j];
			Vector3 tangent = array[j];
			Vector3.OrthoNormalize(ref normal, ref tangent);
			_tangents[j].x = tangent.x;
			_tangents[j].y = tangent.y;
			_tangents[j].z = tangent.z;
			_tangents[j].w = ((Vector3.Dot(Vector3.Cross(normal, tangent), array2[j]) < 0f) ? (-1f) : 1f);
		}
	}

	private static float Remap(float value, float from1, float to1, float from2, float to2)
	{
		return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
	}
}
internal class PreMesh
{
	public string name = string.Empty;

	public Vector3[] vertices;

	public int[] triangles;

	public Vector2[] uv;

	public Vector2[] uv2;

	public Vector3[] normals;

	public Vector4[] tangents;

	public void Clear()
	{
		vertices = null;
		triangles = null;
		uv = null;
		uv2 = null;
		normals = null;
		tangents = null;
	}
}
