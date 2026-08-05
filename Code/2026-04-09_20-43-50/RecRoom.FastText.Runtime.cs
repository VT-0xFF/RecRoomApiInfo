using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.FastText.Core;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FastText
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AGJWIGSWMFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Texture2D TNPLRHDOMEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GlyphUVConfig QNCDHPVFROP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public GlyphCoordinate[] RCAYIIRTXWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public GlyphCoordinate SFXHTMUKZDI;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static AGJWIGSWMFE UZWTUPALJUT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AGJWIGSWMFE WPUEHDPMKEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x99F4C70", Offset = "0x99F3C70", VA = "0x1899F4C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public AGJWIGSWMFE()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct GlyphUVConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int TexturePixelWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int TexturePixelHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int GlyphCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int GlyphCountVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public GlyphPixelInset GlyphPixelInset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public float GlyphPixelKerning;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly GlyphUVConfig DefaultUVConfig;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99F5BD0", Offset = "0x99F4BD0", VA = "0x1899F5BD0")]
		public GlyphUVConfig(int texturePixelWidth, int texturePixelHeight, int glyphCountHorizontal, int glyphCountVertical, float glyphPixelKerning = 0f, [Optional] GlyphPixelInset glyphPixelInset)
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct GlyphPixelInset
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const int BYTE_SIZE = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Min(0f)]
		public float Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Min(0f)]
		public float Right;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public floatMinMax X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Min(0f)]
		public float Bottom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Min(0f)]
		public float Top;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public floatMinMax Y;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct GlyphCoordinate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly char Glyph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly int IndexHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly int IndexVertical;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly GlyphCoordinate DefaultCoordinate;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99F51D0", Offset = "0x99F41D0", VA = "0x1899F51D0")]
		public GlyphCoordinate(char glyph, int indexHorizontal, int indexVertical)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99F51E0", Offset = "0x99F41E0", VA = "0x1899F51E0")]
		public GlyphCoordinate(GlyphCoordinateWritable glyphCoordinate)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct GlyphCoordinateWritable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public char Glyph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int Col;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int Row;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99F5160", Offset = "0x99F4160", VA = "0x1899F5160")]
		public static implicit operator GlyphCoordinate(GlyphCoordinateWritable c)
		{
			return default(GlyphCoordinate);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CreateAssetMenu(menuName = "RecRoom/Config/New GlyphMapAsset", fileName = "GlyphMap", order = 0)]
	public class GlyphMapAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public const string FallbackMaterialShaderPath = "UI/Unlit/Text";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Texture2D glyphTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Shader shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Material _glyphMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Space]
		[FormerlySerializedAs("glyphColCount")]
		[FormerlySerializedAs("glyphCols")]
		[SerializeField]
		[Min(1f)]
		private int glyphCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[FormerlySerializedAs("glyphRowCount")]
		[FormerlySerializedAs("glyphRows")]
		[SerializeField]
		[Min(1f)]
		private int glyphCountVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Space]
		[SerializeField]
		private GlyphPixelInset glyphPixelInset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private float glyphPixelKerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Space]
		[SerializeField]
		private char fallbackGlyph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[HideInInspector]
		private List<GlyphCoordinateWritable> glyphCoordinates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool isConfigDirty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private AGJWIGSWMFE configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D TNPLRHDOMEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader SUCOUWSXPGR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x99F5200", Offset = "0x99F4200", VA = "0x1899F5200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material XLXIHKPASIL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99F59D0", Offset = "0x99F49D0", VA = "0x1899F59D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> RCAYIIRTXWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char GFFIETSQYNS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x99F59C0", Offset = "0x99F49C0", VA = "0x1899F59C0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AGJWIGSWMFE YCYHHGIWMQO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x99F5550", Offset = "0x99F4550", VA = "0x1899F5550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GlyphCoordinate ECIBMOOGTLO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x99F5330", Offset = "0x99F4330", VA = "0x1899F5330")]
			get
			{
				return default(GlyphCoordinate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99F52B0", Offset = "0x99F42B0", VA = "0x1899F52B0")]
		internal void VYNSSOFJTXP(IEnumerable<GlyphCoordinateWritable> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99F54C0", Offset = "0x99F44C0", VA = "0x1899F54C0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99F5290", Offset = "0x99F4290", VA = "0x1899F5290")]
		[CompilerGenerated]
		private bool QIDMSFONRGJ(GlyphCoordinateWritable a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(TextSegmentMeshBufferSource))]
	public class SimpleTextSegmentSource : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TextSegmentMeshBufferSource RGQMLAWEECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TextSegmentManager ASTLVGYEJRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[FormerlySerializedAs("SpanText")]
		public string SegmentText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[FormerlySerializedAs("SpanFontSize")]
		public float SegmentFontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[FormerlySerializedAs("SpanColor")]
		public Color32 SegmentColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[FormerlySerializedAs("SpanAnchor")]
		public float2 SegmentAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private BDFEKZYYHNQ DWSEUIEGLMN;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99F6FF0", Offset = "0x99F5FF0", VA = "0x1899F6FF0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99F6FA0", Offset = "0x99F5FA0", VA = "0x1899F6FA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99F6DC0", Offset = "0x99F5DC0", VA = "0x1899F6DC0")]
		private void JUKHDATCANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99F7120", Offset = "0x99F6120", VA = "0x1899F7120")]
		public SimpleTextSegmentSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	public sealed class TextSegmentMeshBufferSource : MeshBufferSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool RVDBULYNGWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material AWMWVTGPHNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TextSegmentManager ASTLVGYEJRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material LHKEQQJBBYM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private AGJWIGSWMFE ZTLUZUMJUOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x99F9520", Offset = "0x99F8520", VA = "0x1899F9520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TextSegmentManager GPJFOUMPSOS
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x99F95B0", Offset = "0x99F85B0", VA = "0x1899F95B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material LFKVZYIGYIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x99F9610", Offset = "0x99F8610", VA = "0x1899F9610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99F9120", Offset = "0x99F8120", VA = "0x1899F9120")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99F8F10", Offset = "0x99F7F10", VA = "0x1899F8F10", Slot = "8")]
		protected override void PHDYFDAUCJO(BAUGUWBYXAD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99F9130", Offset = "0x99F8130", VA = "0x1899F9130", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99F8DC0", Offset = "0x99F7DC0", VA = "0x1899F8DC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99F9200", Offset = "0x99F8200", VA = "0x1899F9200")]
		private void UTIVSDBFQCA(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly ref struct TextSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal readonly TextSegmentManager Manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly int _segmentIdx;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99FA430", Offset = "0x99F9430", VA = "0x1899FA430")]
		internal TextSegmentData KKYGGPOTCKA()
		{
			return default(TextSegmentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D880", Offset = "0x2B7C880", VA = "0x182B7D880")]
		internal TextSegment(TextSegmentManager manager, int segmentIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class UDRBSVRIQHY
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99FA600", Offset = "0x99F9600", VA = "0x1899FA600")]
		public static bool BJPNROXPXBH(this TextSegment a, TextSegmentDirtyStates b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99FA5E0", Offset = "0x99F95E0", VA = "0x1899FA5E0")]
		internal static bool BJPNROXPXBH(this TextSegmentData a, TextSegmentDirtyStates b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99FA650", Offset = "0x99F9650", VA = "0x1899FA650")]
		public static float HSSHUHIHNLU(this TextSegment a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD63240", Offset = "0xD62240", VA = "0x180D63240")]
		internal static float HSSHUHIHNLU(this TextSegmentData a)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class JQYBQLLZFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99F5E50", Offset = "0x99F4E50", VA = "0x1899F5E50")]
		public static void VLIIRKLSLTN(this TextSegment a, ReadOnlySpan<char> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99F5EA0", Offset = "0x99F4EA0", VA = "0x1899F5EA0")]
		internal static void VLIIRKLSLTN(this TextSegmentData a, ReadOnlySpan<char> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99F5DA0", Offset = "0x99F4DA0", VA = "0x1899F5DA0")]
		public static void RBPBATFPFCR(this TextSegment a, float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99F5D90", Offset = "0x99F4D90", VA = "0x1899F5D90")]
		internal static void RBPBATFPFCR(this TextSegmentData a, float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99F5CE0", Offset = "0x99F4CE0", VA = "0x1899F5CE0")]
		public static void QDTSFQOMJZG(this TextSegment a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99F5D50", Offset = "0x99F4D50", VA = "0x1899F5D50")]
		internal static void QDTSFQOMJZG(this TextSegmentData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99F5DF0", Offset = "0x99F4DF0", VA = "0x1899F5DF0")]
		internal static void TATKXYTCAYY(this TextSegmentData a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99F5C80", Offset = "0x99F4C80", VA = "0x1899F5C80")]
		public static void IEEQCUQYPXV(this TextSegment a, Color32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99F5C70", Offset = "0x99F4C70", VA = "0x1899F5C70")]
		internal static void IEEQCUQYPXV(this TextSegmentData a, Color32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99F5E00", Offset = "0x99F4E00", VA = "0x1899F5E00")]
		public static void UELNAPUZINP(this TextSegment a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99F5E40", Offset = "0x99F4E40", VA = "0x1899F5E40")]
		internal static void UELNAPUZINP(this TextSegmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99F5C00", Offset = "0x99F4C00", VA = "0x1899F5C00")]
		internal static void GRRDEYUXHPK(this TextSegmentData a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99F5CC0", Offset = "0x99F4CC0", VA = "0x1899F5CC0")]
		internal static void KALSOKQQAYM(this TextSegmentData a, int b, TextSegmentDirtyStates c = TextSegmentDirtyStates.DirtyAllNoAlloc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class BDFEKZYYHNQ : IEquatable<BDFEKZYYHNQ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const ushort SDJMTDIJDYH = 0;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const int TWPDBEEVUYK = 65534;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly BDFEKZYYHNQ QDPYCZUKUCW;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ushort TMQZSJMSHGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xDDD000", Offset = "0xDDC000", VA = "0x180DDD000")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xDDD010", Offset = "0xDDC010", VA = "0x180DDD010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TextSegmentManager ZQKIMNEXRDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x99F2BC0", Offset = "0x99F1BC0", VA = "0x1899F2BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99F2CC0", Offset = "0x99F1CC0", VA = "0x1899F2CC0")]
		public BDFEKZYYHNQ(int a, TextSegmentManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99F4F80", Offset = "0x99F3F80", VA = "0x1899F4F80")]
		public bool WBEGLHIHAPG([Out] TextSegment a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99F4F30", Offset = "0x99F3F30", VA = "0x1899F4F30")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99F29B0", Offset = "0x99F19B0", VA = "0x1899F29B0")]
		internal void CETDDZYVLHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99F29E0", Offset = "0x99F19E0", VA = "0x1899F29E0", Slot = "4")]
		public bool Equals(BDFEKZYYHNQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99F4E00", Offset = "0x99F3E00", VA = "0x1899F4E00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99F4EC0", Offset = "0x99F3EC0", VA = "0x1899F4EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class TextSegmentManager : IDisposable, HJKZCTGYVUR
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string JSAKREHHAWO = "FastText";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static ProfilerMarker CXGVHILKQYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string NDGODUADIQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly TextSegmentManagerConfig FLRQZHWTRZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal int CGTCBTNCHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal TextSegmentData[] VBVBKABMZTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal BDFEKZYYHNQ[] XYAQDAADQCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private AGJWIGSWMFE BWGTDDUCIAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly MIQKZVEBKKY QWKRPCAPIRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal readonly TextSegmentMeshWriter OXKFNNEHBGX;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string ACBKEEQTANZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x99F8280", Offset = "0x99F7280", VA = "0x1899F8280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AGJWIGSWMFE YDKVPGTGVHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x99F7AA0", Offset = "0x99F6AA0", VA = "0x1899F7AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float FACGIOSQQIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x99F8310", Offset = "0x99F7310", VA = "0x1899F8310")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ONKDQMKPMON
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x99F7980", Offset = "0x99F6980", VA = "0x1899F7980")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public HJKZCTGYVUR.GetMeshBufferDelegate TGFBIBFGPWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD09750", Offset = "0xD08750", VA = "0x180D09750", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD09760", Offset = "0xD08760", VA = "0x180D09760", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99F8910", Offset = "0x99F7910", VA = "0x1899F8910")]
		public TextSegmentManager(TextSegmentManagerConfig config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99F8D40", Offset = "0x99F7D40", VA = "0x1899F8D40")]
		public TextSegmentManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99F8870", Offset = "0x99F7870", VA = "0x1899F8870")]
		public void WNCQWZWPKZY(GlyphMapAsset a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99F8760", Offset = "0x99F7760", VA = "0x1899F8760")]
		public void WNCQWZWPKZY(AGJWIGSWMFE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99F84F0", Offset = "0x99F74F0", VA = "0x1899F84F0", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99F7E60", Offset = "0x99F6E60", VA = "0x1899F7E60")]
		public void NVQRKAXHAFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99F79A0", Offset = "0x99F69A0", VA = "0x1899F79A0")]
		public bool BWNSENLWHSG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99F8020", Offset = "0x99F7020", VA = "0x1899F8020")]
		public BDFEKZYYHNQ PQLMSKPNQLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99F7AC0", Offset = "0x99F6AC0", VA = "0x1899F7AC0")]
		public void FWSCEIABCXL(BDFEKZYYHNQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99F7DB0", Offset = "0x99F6DB0", VA = "0x1899F7DB0")]
		internal bool JLTCTNPPMOB(BDFEKZYYHNQ a, [Out] TextSegment b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99F7EC0", Offset = "0x99F6EC0", VA = "0x1899F7EC0")]
		private void PFAWJCLYROT(TextSegmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99F8330", Offset = "0x99F7330", VA = "0x1899F8330")]
		private void TUXTHPUFADZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99F86F0", Offset = "0x99F76F0", VA = "0x1899F86F0")]
		private bool URROHQTPJKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99F1950", Offset = "0x99F0950", VA = "0x1899F1950")]
		private static int CQUHNXHXIVH(BDFEKZYYHNQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x25F4450", Offset = "0x25F3450", VA = "0x1825F4450")]
		private static ushort ADUYTQMRNLJ(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99F76B0", Offset = "0x99F66B0", VA = "0x1899F76B0")]
		private Bounds AFJPCRUOTEZ()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x99F79F0", Offset = "0x99F69F0", VA = "0x1899F79F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct TextSegmentManagerConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly TextSegmentManagerConfig DefaultConfig;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const float MAX_FONT_SIZE = 65535f;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const int MAX_SEGMENT_LIMIT = 65534;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private const int MAX_VERTEX_LIMIT = 65535;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Color DefaultFontColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float DefaultFontHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int InitialSegmentCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int InitialSegmentGlyphCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int TotalVertexLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int TotalSegmentsLimit;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x99F74B0", Offset = "0x99F64B0", VA = "0x1899F74B0")]
		internal TextSegmentManagerConfig RVIMMEWXCDI()
		{
			return default(TextSegmentManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99F1890", Offset = "0x99F0890", VA = "0x1899F1890")]
		[CompilerGenerated]
		internal static void CNTUSFIFJEV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x99F75E0", Offset = "0x99F65E0", VA = "0x1899F75E0")]
		[CompilerGenerated]
		internal static void VUXBOXHXNYN(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99F17E0", Offset = "0x99F07E0", VA = "0x1899F17E0")]
		[CompilerGenerated]
		internal static void BLQHIDAKDXL(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99F75C0", Offset = "0x99F65C0", VA = "0x1899F75C0")]
		[CompilerGenerated]
		internal static void UNPXTLIIVDZ(float a, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class FUWORHKLQAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99F50D0", Offset = "0x99F40D0", VA = "0x1899F50D0")]
		public static float LOFUBCBADQS(this TextSegment a)
		{
			return default(float);
		}
	}
}
namespace RecRoom.FastText.Layout
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Obfuscation(Exclude = true)]
	public class TextSegmentLayout
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly LayoutRect layoutRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int layoutVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private float layoutAlignment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly BDFEKZYYHNQ textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99F7440", Offset = "0x99F6440", VA = "0x1899F7440")]
		public TextSegmentLayout(LayoutRect layoutRect, BDFEKZYYHNQ textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99F7210", Offset = "0x99F6210", VA = "0x1899F7210")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99F7280", Offset = "0x99F6280", VA = "0x1899F7280")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99F71B0", Offset = "0x99F61B0", VA = "0x1899F71B0")]
		public void Cleanup()
		{
		}
	}
}
namespace RecRoom.FastText.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal sealed class MIQKZVEBKKY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GlyphUVConfig YWANAJRPKAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float OPMPBLPUEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float PNDKUMNXGUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float IAWIWYZXAUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private float YPJILMYGLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private float SHIBPEXZQNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public float RMPEAFJOHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float TBKMNLQMSDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float HVQJCNDFNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float RFAHDXFBWCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float ONKDQMKPMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public float ZIBXIIFXNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float FACGIOSQQIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly QuadUVs[] GEWRPUFAULZ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const int ZJUYKOOEFXV = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GlyphQuadUVs[] KJWSCXEYIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int YFLLDTKJGZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GlyphCoordinate[] TSCTCXDRYZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int CFTTJVETPUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public QuadUVs IWFKWBJGBPQ;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99F6AE0", Offset = "0x99F5AE0", VA = "0x1899F6AE0")]
		public void WNCQWZWPKZY(AGJWIGSWMFE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x99F6A60", Offset = "0x99F5A60", VA = "0x1899F6A60")]
		public void WNCQWZWPKZY(GlyphUVConfig a, IEnumerable<GlyphCoordinate> b, GlyphCoordinate c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99F6920", Offset = "0x99F5920", VA = "0x1899F6920")]
		internal void QAMDGIGTBAZ(GlyphUVConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99F60A0", Offset = "0x99F50A0", VA = "0x1899F60A0")]
		private void NVULUOXGRKB(IEnumerable<GlyphCoordinate> a, GlyphCoordinate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99F65D0", Offset = "0x99F55D0", VA = "0x1899F65D0")]
		public void ONKINEKDENP([In] char glyph, [Out] float2[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99F3270", Offset = "0x99F2270", VA = "0x1899F3270")]
		private QuadUVs PRPZLPWHHFQ(GlyphCoordinate a)
		{
			return default(QuadUVs);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99F6B70", Offset = "0x99F5B70", VA = "0x1899F6B70")]
		public MIQKZVEBKKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class WOGAPILMTZY
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99FA6F0", Offset = "0x99F96F0", VA = "0x1899FA6F0")]
		public static void SQAWAJSJVPT([In] float glyphUVWidth, [In] float glyphUVHeight, [In] int glyphIndexHorizontal, [In] int glyphIndexVertical, [In] float glyphUVPixelWidth, [In] float glyphUVPixelHeight, [In] float glyphPixelInsetLeft, [In] float glyphPixelInsetRight, [In] float glyphPixelInsetTop, [In] float glyphPixelInsetBottom, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x99FA7C0", Offset = "0x99F97C0", VA = "0x1899FA7C0")]
		public static void SQAWAJSJVPT([In] float glyphUVWidth, [In] float glyphUVHeight, [In] int glyphIndexHorizontal, [In] int glyphIndexVertical, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x99FA690", Offset = "0x99F9690", VA = "0x1899FA690")]
		public static void GWVRWHHAJPU([In] float glyphUVPixelWidth, [In] float glyphUVPixelHeight, [In] float pixelInsetLeft, [In] float pixelInsetRight, [In] float pixelInsetTop, [In] float pixelInsetBottom, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct GlyphQuadUVs
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public const uint BYTE_SIZE = 34u;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly char Glyph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly QuadUVs QuadUVs;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x99F5B40", Offset = "0x99F4B40", VA = "0x1899F5B40")]
		public GlyphQuadUVs(char glyph, QuadUVs quadUVs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct QuadUVs
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public const uint BYTE_SIZE = 32u;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly float2[] UVs;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x99F6CD0", Offset = "0x99F5CD0", VA = "0x1899F6CD0")]
		public QuadUVs(float uMin, float uMax, float vMin, float vMax)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal struct TextSegmentData
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal const int GLYPH_ALLOCATION_FACTOR = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal TextSegmentDirtyStates dirtyFlag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		internal char[] textGlyphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal int textLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		internal float2 textAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal float fontHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		internal Color32 textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		internal int cachedMeshVertexCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal int cachedMeshIndexCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal int cachedMeshIndexLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal int cachedMeshIndexLengthLastWrite;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99F71A0", Offset = "0x99F61A0", VA = "0x1899F71A0")]
		public static int JAJVIPWBJUK(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Flags]
	public enum TextSegmentDirtyStates : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Clean = 0,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		DirtyPos = 1,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		DirtyColor = 2,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		DirtyUVs = 4,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		DirtyPosColors = 3,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		DirtyPosColorUVs = 7,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		DirtyTextCapacity = 8,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		DirtyMoreGlyphs = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		DirtyLessGlyphs = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		DirtyGlyphCount = 0x30,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		DirtyAllNoAlloc = 0x37,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		DirtyAllWithAlloc = 0x3F,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		UtilDirtyLayout = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Any = 0xFF
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class OEFPWWMSFXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99F6C90", Offset = "0x99F5C90", VA = "0x1899F6C90")]
		internal static float LOFUBCBADQS(this TextSegmentData a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99F6C10", Offset = "0x99F5C10", VA = "0x1899F6C10")]
		internal static void FIBXQHPZILQ(this TextSegmentData a, float b, float c, [Out] float2 d, [Out] float2 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal sealed class TextSegmentMeshWriter : HJKZCTGYVUR
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private const int TZBBOBUEHHS = 65535;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private const int CBOYYWSWDUW = 16383;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const string JSAKREHHAWO = "TextSegmentMeshWriter";

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static ProfilerMarker VHFRMWJRXLG;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static ProfilerMarker LKDJBEDYJAY;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static ProfilerMarker DOZASJYJYYZ;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static ProfilerMarker WFLISXYJAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal readonly MeshBuffer JGUCMLTZAFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly float3[] WJPBPYASHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float2[] MXZAXPBVMXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int AKCGTIAMLWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int ZKGVXCYRQXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int OZMZYHNKHNC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string ACBKEEQTANZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public HJKZCTGYVUR.GetMeshBufferDelegate TGFBIBFGPWD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99FA320", Offset = "0x99F9320", VA = "0x1899FA320")]
		public TextSegmentMeshWriter(MeshBuffer.BoundsGetterDelegate boundsGetter, int initialGlyphCapacity, int vertexCountLimit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99FA190", Offset = "0x99F9190", VA = "0x1899FA190", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99F9670", Offset = "0x99F8670", VA = "0x1899F9670")]
		public void JDDGJAZEUMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99F99D0", Offset = "0x99F89D0", VA = "0x1899F99D0")]
		public void SLHAWBQLNHA(Span<TextSegmentData> a, MIQKZVEBKKY b, [In] TextSegmentManagerConfig config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99F3450", Offset = "0x99F2450", VA = "0x1899F3450")]
		private void JMDSPHEATIX([In] TextSegmentDirtyStates dirtyFlag, [In] TextSegmentData textSegmentData, int a, [In] float glyphAspectRatio, [In] float glyphKerningFactor, MIQKZVEBKKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99F9880", Offset = "0x99F8880", VA = "0x1899F9880")]
		private void SGSOYMJVCOC([In] TextSegmentDirtyStates dirtyFlag, TextSegmentData a, [In] int segmentIndexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99F9690", Offset = "0x99F8690", VA = "0x1899F9690")]
		public static void JRASDGOVQTK(ReadOnlySpan<TextSegmentData> a, int b, [Out] int c, [Out] int d, [Out] int e)
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
