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
	public class JMTGWGUVTXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Texture2D FBSPNULKWJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GlyphUVConfig PXNMDIJASSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public GlyphCoordinate[] QQUXVFWGBCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public GlyphCoordinate XBMAMXTHFRX;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static JMTGWGUVTXB MRGTGMXSGPC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JMTGWGUVTXB VVXLEJMDQLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x89F30B0", Offset = "0x89F1CB0", VA = "0x1889F30B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public JMTGWGUVTXB()
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
		[Cpp2IlInjected.Address(RVA = "0x89F3080", Offset = "0x89F1C80", VA = "0x1889F3080")]
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
		[Cpp2IlInjected.Address(RVA = "0x89F2680", Offset = "0x89F1280", VA = "0x1889F2680")]
		public GlyphCoordinate(char glyph, int indexHorizontal, int indexVertical)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89F2690", Offset = "0x89F1290", VA = "0x1889F2690")]
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
		[Cpp2IlInjected.Address(RVA = "0x89F2610", Offset = "0x89F1210", VA = "0x1889F2610")]
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
		private JMTGWGUVTXB configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D FBSPNULKWJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader YYOTVXOQIMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x89F2840", Offset = "0x89F1440", VA = "0x1889F2840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material AYVQFCPPRMM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x89F2E80", Offset = "0x89F1A80", VA = "0x1889F2E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> QQUXVFWGBCQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char RTNJQKBIRLR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x89F2E70", Offset = "0x89F1A70", VA = "0x1889F2E70")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JMTGWGUVTXB ICMGPZFKKOL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x89F2A00", Offset = "0x89F1600", VA = "0x1889F2A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GlyphCoordinate NAMETCRABVX
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x89F26B0", Offset = "0x89F12B0", VA = "0x1889F26B0")]
			get
			{
				return default(GlyphCoordinate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89F28D0", Offset = "0x89F14D0", VA = "0x1889F28D0")]
		internal void YXNMJOLCNMO(IEnumerable<GlyphCoordinateWritable> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89F2970", Offset = "0x89F1570", VA = "0x1889F2970")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89F2950", Offset = "0x89F1550", VA = "0x1889F2950")]
		[CompilerGenerated]
		private bool ZFTNWJDTPDY(GlyphCoordinateWritable a)
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
		private TextSegmentMeshBufferSource QZPQNRWHUIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TextSegmentManager QHYYMIAXTAQ;

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
		private BGRDOWNYWAR HQIJNRQKDME;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x89F3C40", Offset = "0x89F2840", VA = "0x1889F3C40")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x89F3BF0", Offset = "0x89F27F0", VA = "0x1889F3BF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89F3A10", Offset = "0x89F2610", VA = "0x1889F3A10")]
		private void GVHRJJZEYYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D70", Offset = "0x89F2970", VA = "0x1889F3D70")]
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
		private bool HLTLCVRQUII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material QLQLCKRELQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TextSegmentManager QHYYMIAXTAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material VYDYZCFGZZF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private JMTGWGUVTXB KTYEMJOJRHB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x89F5A10", Offset = "0x89F4610", VA = "0x1889F5A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TextSegmentManager KYQBWOQPSHH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89F6210", Offset = "0x89F4E10", VA = "0x1889F6210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material RDJNWZOALBK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x89F6270", Offset = "0x89F4E70", VA = "0x1889F6270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x89F6130", Offset = "0x89F4D30", VA = "0x1889F6130")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89F5DC0", Offset = "0x89F49C0", VA = "0x1889F5DC0", Slot = "8")]
		protected override void KVVEMENQSJX(EPJKKPDQUJW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89F6140", Offset = "0x89F4D40", VA = "0x1889F6140", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89F5FE0", Offset = "0x89F4BE0", VA = "0x1889F5FE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89F5AA0", Offset = "0x89F46A0", VA = "0x1889F5AA0")]
		private void IUMSPNMNZRL(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB30690", Offset = "0xB2F290", VA = "0x180B30690")]
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
		[Cpp2IlInjected.Address(RVA = "0x89F7090", Offset = "0x89F5C90", VA = "0x1889F7090")]
		internal TextSegmentData OQOBKVTWHNB()
		{
			return default(TextSegmentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF770", Offset = "0x2DBE370", VA = "0x182DBF770")]
		internal TextSegment(TextSegmentManager manager, int segmentIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class SLMNLMAYTXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89F3960", Offset = "0x89F2560", VA = "0x1889F3960")]
		public static bool FEHWPAEGMQM(this TextSegment a, TextSegmentDirtyStates b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x89F39B0", Offset = "0x89F25B0", VA = "0x1889F39B0")]
		internal static bool FEHWPAEGMQM(this TextSegmentData a, TextSegmentDirtyStates b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89F39D0", Offset = "0x89F25D0", VA = "0x1889F39D0")]
		public static float LPFSIZIPKXP(this TextSegment a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB77A50", Offset = "0xB76650", VA = "0x180B77A50")]
		internal static float LPFSIZIPKXP(this TextSegmentData a)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class REGBJDONLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89F38C0", Offset = "0x89F24C0", VA = "0x1889F38C0")]
		public static void WBHHBGORYBS(this TextSegment a, ReadOnlySpan<char> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89F36C0", Offset = "0x89F22C0", VA = "0x1889F36C0")]
		internal static void WBHHBGORYBS(this TextSegmentData a, ReadOnlySpan<char> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89F3630", Offset = "0x89F2230", VA = "0x1889F3630")]
		public static void MIVOMRIUKDU(this TextSegment a, float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x89F3680", Offset = "0x89F2280", VA = "0x1889F3680")]
		internal static void MIVOMRIUKDU(this TextSegmentData a, float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x89F3580", Offset = "0x89F2180", VA = "0x1889F3580")]
		public static void JSETFKRHASH(this TextSegment a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89F35F0", Offset = "0x89F21F0", VA = "0x1889F35F0")]
		internal static void JSETFKRHASH(this TextSegmentData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89F36B0", Offset = "0x89F22B0", VA = "0x1889F36B0")]
		internal static void UJKBRIUEHZV(this TextSegmentData a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89F3530", Offset = "0x89F2130", VA = "0x1889F3530")]
		public static void IYTLBXBFPYO(this TextSegment a, Color32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89F3570", Offset = "0x89F2170", VA = "0x1889F3570")]
		internal static void IYTLBXBFPYO(this TextSegmentData a, Color32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89F3920", Offset = "0x89F2520", VA = "0x1889F3920")]
		public static void WDSQQUMQNZI(this TextSegment a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x89F3910", Offset = "0x89F2510", VA = "0x1889F3910")]
		internal static void WDSQQUMQNZI(this TextSegmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89F34C0", Offset = "0x89F20C0", VA = "0x1889F34C0")]
		internal static void AQHDJPOHPUH(this TextSegmentData a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89F3690", Offset = "0x89F2290", VA = "0x1889F3690")]
		internal static void SBINEQUYJWX(this TextSegmentData a, int b, TextSegmentDirtyStates c = TextSegmentDirtyStates.DirtyAllNoAlloc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class BGRDOWNYWAR : IEquatable<BGRDOWNYWAR>
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const ushort HUTFJSHSFMU = 0;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const int AYDQBWPZBTL = 65534;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly BGRDOWNYWAR ZTXKXNLFPNJ;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ushort PJTRUCDRDGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xE3F2C0", Offset = "0xE3DEC0", VA = "0x180E3F2C0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xE3F2D0", Offset = "0xE3DED0", VA = "0x180E3F2D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TextSegmentManager BDMDAGZRNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x89EFFA0", Offset = "0x89EEBA0", VA = "0x1889EFFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89F0240", Offset = "0x89EEE40", VA = "0x1889F0240")]
		public BGRDOWNYWAR(int a, TextSegmentManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x89F2320", Offset = "0x89F0F20", VA = "0x1889F2320")]
		public bool RAOGEWYSRPR([Out] TextSegment a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89F23F0", Offset = "0x89F0FF0", VA = "0x1889F23F0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x89F0140", Offset = "0x89EED40", VA = "0x1889F0140")]
		internal void RQOHHSINXYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89F0070", Offset = "0x89EEC70", VA = "0x1889F0070", Slot = "4")]
		public bool Equals(BGRDOWNYWAR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89F21F0", Offset = "0x89F0DF0", VA = "0x1889F21F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89F22B0", Offset = "0x89F0EB0", VA = "0x1889F22B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class TextSegmentManager : IDisposable, IGUCKTFSKHM
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string ZVCSQYWTOMN = "FastText";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static ProfilerMarker OLHGBUHLVVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string YRAOTLCSPLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly TextSegmentManagerConfig JLJDOZDIUIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal int XZAJBDLLZIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal TextSegmentData[] VANSWQLOSIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal BGRDOWNYWAR[] XGTVODYJCYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JMTGWGUVTXB TOWIEYEJHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly WYSIITUWMAV PGUBPUKVPMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal readonly TextSegmentMeshWriter ENHDUKWFKTS;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string CFFWKEOMCTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x89F4480", Offset = "0x89F3080", VA = "0x1889F4480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JMTGWGUVTXB QQGTUOGVNZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x89F4300", Offset = "0x89F2F00", VA = "0x1889F4300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float SSRXPHOXCSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x89F4F10", Offset = "0x89F3B10", VA = "0x1889F4F10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ZZPVZFSFPXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89F4510", Offset = "0x89F3110", VA = "0x1889F4510")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IGUCKTFSKHM.GetMeshBufferDelegate LUQOJHYBNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB13B50", Offset = "0xB12750", VA = "0x180B13B50", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89F5560", Offset = "0x89F4160", VA = "0x1889F5560")]
		public TextSegmentManager(TextSegmentManagerConfig config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89F5990", Offset = "0x89F4590", VA = "0x1889F5990")]
		public TextSegmentManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89F4A60", Offset = "0x89F3660", VA = "0x1889F4A60")]
		public void HRTIXRMSTIX(GlyphMapAsset a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89F4AA0", Offset = "0x89F36A0", VA = "0x1889F4AA0")]
		public void HRTIXRMSTIX(JMTGWGUVTXB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x89F5140", Offset = "0x89F3D40", VA = "0x1889F5140", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89F4F30", Offset = "0x89F3B30", VA = "0x1889F4F30")]
		public void NORAMJULWCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x89F4F90", Offset = "0x89F3B90", VA = "0x1889F4F90")]
		public bool NPGTXJWIMAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x89F4800", Offset = "0x89F3400", VA = "0x1889F4800")]
		public BGRDOWNYWAR GQRJRHHJTWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x89F4C20", Offset = "0x89F3820", VA = "0x1889F4C20")]
		public void KYRQUVQVTDG(BGRDOWNYWAR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x89F4320", Offset = "0x89F2F20", VA = "0x1889F4320")]
		internal bool CHSJWOYFODM(BGRDOWNYWAR a, [Out] TextSegment b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x89F4FE0", Offset = "0x89F3BE0", VA = "0x1889F4FE0")]
		private void PLDVJTCFNIA(TextSegmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x89F5340", Offset = "0x89F3F40", VA = "0x1889F5340")]
		private void XQMVWHHTFMK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x89F4BB0", Offset = "0x89F37B0", VA = "0x1889F4BB0")]
		private bool IVPKMTRZFPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x89EF9A0", Offset = "0x89EE5A0", VA = "0x1889EF9A0")]
		private static int VHIHUVYASKG(BGRDOWNYWAR a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x281E540", Offset = "0x281D140", VA = "0x18281E540")]
		private static ushort TCLUDLJSHWY(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x89F4530", Offset = "0x89F3130", VA = "0x1889F4530")]
		private Bounds GGILBDBGQWG()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x89F43D0", Offset = "0x89F2FD0", VA = "0x1889F43D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x89F4140", Offset = "0x89F2D40", VA = "0x1889F4140")]
		internal TextSegmentManagerConfig XHUBSMRQBKD()
		{
			return default(TextSegmentManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x89EEE80", Offset = "0x89EDA80", VA = "0x1889EEE80")]
		[CompilerGenerated]
		internal static void YRKYSQHDEKA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x89F4100", Offset = "0x89F2D00", VA = "0x1889F4100")]
		[CompilerGenerated]
		internal static void BVPWGJLPSDS(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89EEE90", Offset = "0x89EDA90", VA = "0x1889EEE90")]
		[CompilerGenerated]
		internal static void RXOFQKACHBA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x89F4120", Offset = "0x89F2D20", VA = "0x1889F4120")]
		[CompilerGenerated]
		internal static void WFYVFBKEKYE(float a, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class FAXEGRRWELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x89F2580", Offset = "0x89F1180", VA = "0x1889F2580")]
		public static float JDTOZDMJHHT(this TextSegment a)
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
		public readonly BGRDOWNYWAR textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x89F4090", Offset = "0x89F2C90", VA = "0x1889F4090")]
		public TextSegmentLayout(LayoutRect layoutRect, BGRDOWNYWAR textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89F3E60", Offset = "0x89F2A60", VA = "0x1889F3E60")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89F3ED0", Offset = "0x89F2AD0", VA = "0x1889F3ED0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x89F3E00", Offset = "0x89F2A00", VA = "0x1889F3E00")]
		public void Cleanup()
		{
		}
	}
}
namespace RecRoom.FastText.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal sealed class WYSIITUWMAV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GlyphUVConfig WMIDPEJVVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float HZVDRNPWLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float KICYKFEHMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float FSFDBLZBBVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private float VKMWWFESAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private float ZDYYSWGBMRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public float PTWWNGNLLGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float LENKEZAMWLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float MSTAZPCRXEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float FTGEMIJESWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float ZZPVZFSFPXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public float WMYQFTYDUIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float SSRXPHOXCSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly QuadUVs[] LAQOXXFWZMI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const int NNHJXMTKLNK = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GlyphQuadUVs[] LIPKIFXYTNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int AEGWYOADXAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GlyphCoordinate[] EROJOQOARAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int DNODJCNAZCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public QuadUVs ABYSTMSAICB;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x89F72C0", Offset = "0x89F5EC0", VA = "0x1889F72C0")]
		public void HRTIXRMSTIX(JMTGWGUVTXB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x89F7240", Offset = "0x89F5E40", VA = "0x1889F7240")]
		public void HRTIXRMSTIX(GlyphUVConfig a, IEnumerable<GlyphCoordinate> b, GlyphCoordinate c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x89F7350", Offset = "0x89F5F50", VA = "0x1889F7350")]
		internal void ITESYCNAKSU(GlyphUVConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x89F7490", Offset = "0x89F6090", VA = "0x1889F7490")]
		private void JPBIJBBFPDU(IEnumerable<GlyphCoordinate> a, GlyphCoordinate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x89F79C0", Offset = "0x89F65C0", VA = "0x1889F79C0")]
		public void RBUJHGEJEIW([In] char glyph, [Out] float2[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x89F1DF0", Offset = "0x89F09F0", VA = "0x1889F1DF0")]
		private QuadUVs KIMUWJLUHWB(GlyphCoordinate a)
		{
			return default(QuadUVs);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x89F7D10", Offset = "0x89F6910", VA = "0x1889F7D10")]
		public WYSIITUWMAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class QKWSJMVDRTV
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89F32A0", Offset = "0x89F1EA0", VA = "0x1889F32A0")]
		public static void RCKILAAENIM([In] float glyphUVWidth, [In] float glyphUVHeight, [In] int glyphIndexHorizontal, [In] int glyphIndexVertical, [In] float glyphUVPixelWidth, [In] float glyphUVPixelHeight, [In] float glyphPixelInsetLeft, [In] float glyphPixelInsetRight, [In] float glyphPixelInsetTop, [In] float glyphPixelInsetBottom, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x89F3370", Offset = "0x89F1F70", VA = "0x1889F3370")]
		public static void RCKILAAENIM([In] float glyphUVWidth, [In] float glyphUVHeight, [In] int glyphIndexHorizontal, [In] int glyphIndexVertical, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x89F3240", Offset = "0x89F1E40", VA = "0x1889F3240")]
		public static void OLORXGMOXZB([In] float glyphUVPixelWidth, [In] float glyphUVPixelHeight, [In] float pixelInsetLeft, [In] float pixelInsetRight, [In] float pixelInsetTop, [In] float pixelInsetBottom, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
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
		[Cpp2IlInjected.Address(RVA = "0x89F2FF0", Offset = "0x89F1BF0", VA = "0x1889F2FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89F33D0", Offset = "0x89F1FD0", VA = "0x1889F33D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89F3DF0", Offset = "0x89F29F0", VA = "0x1889F3DF0")]
		public static int LYTHOWDZECB(int a)
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
	public static class CGYQIZGNBRV
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x89F2540", Offset = "0x89F1140", VA = "0x1889F2540")]
		internal static float JDTOZDMJHHT(this TextSegmentData a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x89F24C0", Offset = "0x89F10C0", VA = "0x1889F24C0")]
		internal static void GWLJJSIZLPH(this TextSegmentData a, float b, float c, [Out] float2 d, [Out] float2 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal sealed class TextSegmentMeshWriter : IGUCKTFSKHM
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private const int EISBIXVUTVP = 65535;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private const int KJZKPHNBBYR = 16383;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const string ZVCSQYWTOMN = "TextSegmentMeshWriter";

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static ProfilerMarker DLLBAFFTQXR;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static ProfilerMarker JCYWPGAVIBP;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static ProfilerMarker DBMDSFVLTDK;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static ProfilerMarker MVOFJHHKCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal readonly MeshBuffer HLKHSYWBPOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly float3[] OOSFCPGJUEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float2[] GZAYSMHLJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int FHISQWMMMXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int FAEBIYTOZNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int FGTSVCTXBLF;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string CFFWKEOMCTA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IGUCKTFSKHM.GetMeshBufferDelegate LUQOJHYBNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89F6F80", Offset = "0x89F5B80", VA = "0x1889F6F80")]
		public TextSegmentMeshWriter(MeshBuffer.BoundsGetterDelegate boundsGetter, int initialGlyphCapacity, int vertexCountLimit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89F6DF0", Offset = "0x89F59F0", VA = "0x1889F6DF0", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89F6DD0", Offset = "0x89F59D0", VA = "0x1889F6DD0")]
		public void SQNTOZDYKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89F6610", Offset = "0x89F5210", VA = "0x1889F6610")]
		public void NDMJILQMXRH(Span<TextSegmentData> a, WYSIITUWMAV b, [In] TextSegmentManagerConfig config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89F07C0", Offset = "0x89EF3C0", VA = "0x1889F07C0")]
		private void BQUZHWQGCKS([In] TextSegmentDirtyStates dirtyFlag, [In] TextSegmentData textSegmentData, int a, [In] float glyphAspectRatio, [In] float glyphKerningFactor, WYSIITUWMAV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89F64C0", Offset = "0x89F50C0", VA = "0x1889F64C0")]
		private void IUQUTBEXXHH([In] TextSegmentDirtyStates dirtyFlag, TextSegmentData a, [In] int segmentIndexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89F62D0", Offset = "0x89F4ED0", VA = "0x1889F62D0")]
		public static void BLFTVURJHER(ReadOnlySpan<TextSegmentData> a, int b, [Out] int c, [Out] int d, [Out] int e)
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
