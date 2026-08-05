using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.FastText;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FAPJLADNPKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D AJIHKIDAKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig BAOCNJFFODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public IPLHNLDBBHG[] CICPHNJLBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IPLHNLDBBHG JIIFJAKNOKE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FAPJLADNPKF NNPGPLBLPPN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FAPJLADNPKF ELFMHJMOLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D40880", Offset = "0x7D3F280", VA = "0x187D40880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public FAPJLADNPKF()
	{
	}
}
namespace RecRoom.FastText
{
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
		[Cpp2IlInjected.Address(RVA = "0x7D41920", Offset = "0x7D40320", VA = "0x187D41920")]
		public GlyphUVConfig(int LIKIHIABKCH, int FMFLKMNHBPO, int PILHODAKFJH, int PIEGMJJIOHI, float DAGCPPCHELN = 0f, [Optional] GlyphPixelInset BLOCKMMCHHJ)
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
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct IPLHNLDBBHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char FHKHKNAPLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int LOOKBKFICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int FKDAIGGAGEM;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly IPLHNLDBBHG HHOCLGNEACP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D41BA0", Offset = "0x7D405A0", VA = "0x187D41BA0")]
	public IPLHNLDBBHG(char KBFKIJCOJBM, int AECIBLHACGA, int NEIBKEMHHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D41BB0", Offset = "0x7D405B0", VA = "0x187D41BB0")]
	public IPLHNLDBBHG(GlyphCoordinateWritable IPPHBILLLIA)
	{
	}
}
namespace RecRoom.FastText
{
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

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D40F40", Offset = "0x7D3F940", VA = "0x187D40F40")]
		public static IPLHNLDBBHG HNONLACFBHP(GlyphCoordinateWritable CIBCGCDEGFN)
		{
			return default(IPLHNLDBBHG);
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
		[FormerlySerializedAs("glyphColCount")]
		[Space]
		[FormerlySerializedAs("glyphCols")]
		[Min(1f)]
		[SerializeField]
		private int glyphCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[FormerlySerializedAs("glyphRows")]
		[FormerlySerializedAs("glyphRowCount")]
		[Min(1f)]
		[SerializeField]
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
		[SerializeField]
		[Space]
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
		private FAPJLADNPKF configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7D41820", Offset = "0x7D40220", VA = "0x187D41820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7D416A0", Offset = "0x7D400A0", VA = "0x187D416A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7D41690", Offset = "0x7D40090", VA = "0x187D41690")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FAPJLADNPKF ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7D41090", Offset = "0x7D3FA90", VA = "0x187D41090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private IPLHNLDBBHG FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7D41500", Offset = "0x7D3FF00", VA = "0x187D41500")]
			get
			{
				return default(IPLHNLDBBHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D40F60", Offset = "0x7D3F960", VA = "0x187D40F60")]
		internal void BIPNKCFMAGC(IEnumerable<GlyphCoordinateWritable> IKLKKHAEDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D41000", Offset = "0x7D3FA00", VA = "0x187D41000")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D40FE0", Offset = "0x7D3F9E0", VA = "0x187D40FE0")]
		[CompilerGenerated]
		private bool DJOGCEJKKGI(GlyphCoordinateWritable CIBCGCDEGFN)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(TextSegmentMeshBufferSource))]
	public class SimpleTextSegmentSource : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TextSegmentMeshBufferSource EDBOCKLCLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private AHAMHFKAOBC CLANPBAOEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[FormerlySerializedAs("SpanText")]
		public string SegmentText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[FormerlySerializedAs("SpanFontSize")]
		public float SegmentFontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[FormerlySerializedAs("SpanColor")]
		public Color32 SegmentColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[FormerlySerializedAs("SpanAnchor")]
		public float2 SegmentAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private NIKOJCOBMMN MGDAIAHLAIM;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D42440", Offset = "0x7D40E40", VA = "0x187D42440")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D423F0", Offset = "0x7D40DF0", VA = "0x187D423F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D42210", Offset = "0x7D40C10", VA = "0x187D42210")]
		private void MNBNDNAIJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D42530", Offset = "0x7D40F30", VA = "0x187D42530")]
		public SimpleTextSegmentSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	public sealed class TextSegmentMeshBufferSource : MeshBufferSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool KGEFCJEHJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material HBEEINEDMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private AHAMHFKAOBC CLANPBAOEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material NNNFHCGOLJJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private FAPJLADNPKF GOAGGMBIDFI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7D428B0", Offset = "0x7D412B0", VA = "0x187D428B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AHAMHFKAOBC OLHNLJOIDGN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7D43030", Offset = "0x7D41A30", VA = "0x187D43030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material PCBKBCFLJCK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7D43060", Offset = "0x7D41A60", VA = "0x187D43060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7D42F90", Offset = "0x7D41990", VA = "0x187D42F90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7D42940", Offset = "0x7D41340", VA = "0x187D42940", Slot = "8")]
		protected override void LMGONGAJHOO(ACPCGDCEBDP JCOINBNNMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7D42FA0", Offset = "0x7D419A0", VA = "0x187D42FA0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] PIBOPKIJGND NJNHMBFMPFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D42E40", Offset = "0x7D41840", VA = "0x187D42E40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D42B20", Offset = "0x7D41520", VA = "0x187D42B20")]
		private void NIJAOLEGJBG(bool BOOINJJDCOC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA27280", Offset = "0xA25C80", VA = "0x180A27280")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct BCIKBAMBBHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly AHAMHFKAOBC BPNHGKGFCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int CLCCAAFMMOI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EDB0", Offset = "0x7D3D7B0", VA = "0x187D3EDB0")]
	internal BPMLIMAJMPG ELKPDAONPKN()
	{
		return default(BPMLIMAJMPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x28D7850", Offset = "0x28D6250", VA = "0x1828D7850")]
	internal BCIKBAMBBHI(AHAMHFKAOBC BPDOIFAEGPF, int JDBGEMPGPBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FIDHCFNKEAI
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D40A10", Offset = "0x7D3F410", VA = "0x187D40A10")]
	public static bool GNBKLEGJKGM(this BCIKBAMBBHI FJCJJKMKFBC, JKHHKADKBBE OJLICLCNIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D409F0", Offset = "0x7D3F3F0", VA = "0x187D409F0")]
	internal static bool GNBKLEGJKGM(this BPMLIMAJMPG HDPDKNNBGMO, JKHHKADKBBE OJLICLCNIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D40A60", Offset = "0x7D3F460", VA = "0x187D40A60")]
	public static float KFJMLKNPCCD(this BCIKBAMBBHI FJCJJKMKFBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA66560", Offset = "0xA64F60", VA = "0x180A66560")]
	internal static float KFJMLKNPCCD(this BPMLIMAJMPG HDPDKNNBGMO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GMKAKJMKLBI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D40B70", Offset = "0x7D3F570", VA = "0x187D40B70")]
	public static void EAPGMIIEAHL(this BCIKBAMBBHI FJCJJKMKFBC, ReadOnlySpan<char> HDFBJOKPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D40BC0", Offset = "0x7D3F5C0", VA = "0x187D40BC0")]
	internal static void EAPGMIIEAHL(this BPMLIMAJMPG HDPDKNNBGMO, ReadOnlySpan<char> HDFBJOKPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D40DC0", Offset = "0x7D3F7C0", VA = "0x187D40DC0")]
	public static void FDOEDEAJDGC(this BCIKBAMBBHI EPDBINFKJNC, float2 OBACBLCJLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D40E10", Offset = "0x7D3F810", VA = "0x187D40E10")]
	internal static void FDOEDEAJDGC(this BPMLIMAJMPG HDPDKNNBGMO, float2 OBACBLCJLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D40ED0", Offset = "0x7D3F8D0", VA = "0x187D40ED0")]
	public static void MDAOAEPNEKJ(this BCIKBAMBBHI EPDBINFKJNC, float BLMIOBOBEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D40E90", Offset = "0x7D3F890", VA = "0x187D40E90")]
	internal static void MDAOAEPNEKJ(this BPMLIMAJMPG HDPDKNNBGMO, float BLMIOBOBEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D40AA0", Offset = "0x7D3F4A0", VA = "0x187D40AA0")]
	internal static void BAJJEGGDEGF(this BPMLIMAJMPG HDPDKNNBGMO, bool OKOLINMEEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D40AB0", Offset = "0x7D3F4B0", VA = "0x187D40AB0")]
	public static void BHHJHBHEBKL(this BCIKBAMBBHI EPDBINFKJNC, Color32 JJNDBAIEAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D40AF0", Offset = "0x7D3F4F0", VA = "0x187D40AF0")]
	internal static void BHHJHBHEBKL(this BPMLIMAJMPG HDPDKNNBGMO, Color32 JJNDBAIEAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D40E40", Offset = "0x7D3F840", VA = "0x187D40E40")]
	public static void JGEEAEBAJJD(this BCIKBAMBBHI EPDBINFKJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D40E80", Offset = "0x7D3F880", VA = "0x187D40E80")]
	internal static void JGEEAEBAJJD(this BPMLIMAJMPG HDPDKNNBGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D40B00", Offset = "0x7D3F500", VA = "0x187D40B00")]
	internal static void BOBMHILMMOA(this BPMLIMAJMPG HDPDKNNBGMO, int NKNEPDCGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D40E20", Offset = "0x7D3F820", VA = "0x187D40E20")]
	internal static void HDGDBNBMLIL(this BPMLIMAJMPG HDPDKNNBGMO, int IOFNNBJPODE, JKHHKADKBBE PFANMJCNCDI = JKHHKADKBBE.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NIKOJCOBMMN : IEquatable<NIKOJCOBMMN>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort IMKLBACPKJJ = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int AAMDHNACKAL = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly NIKOJCOBMMN GBGOBCIMFMA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort FILJFFBJBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xCC56E0", Offset = "0xCC40E0", VA = "0x180CC56E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCC56F0", Offset = "0xCC40F0", VA = "0x180CC56F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public AHAMHFKAOBC BPNHGKGFCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool HBILGBNKLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D34CF0", Offset = "0x7D336F0", VA = "0x187D34CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D34E30", Offset = "0x7D33830", VA = "0x187D34E30")]
	public NIKOJCOBMMN(int KHAJPPBKJAF, AHAMHFKAOBC BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D41E40", Offset = "0x7D40840", VA = "0x187D41E40")]
	public bool LBIGLEDKHOD([Out] BCIKBAMBBHI FJCJJKMKFBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D41CC0", Offset = "0x7D406C0", VA = "0x187D41CC0")]
	public void DKAGEAADPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D34D70", Offset = "0x7D33770", VA = "0x187D34D70")]
	internal void MBNFEEPNNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D34C20", Offset = "0x7D33620", VA = "0x187D34C20", Slot = "4")]
	public bool Equals(NIKOJCOBMMN NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D41D10", Offset = "0x7D40710", VA = "0x187D41D10", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D41DD0", Offset = "0x7D407D0", VA = "0x187D41DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class AHAMHFKAOBC : IDisposable, EALDJNGEMBA
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string ECDIPLKMDDA = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker CGJCLELLICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string JNFMJAFFAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly IAIGKPKMDKN HGILPDPFLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int DHPLPGJODPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal BPMLIMAJMPG[] KKPECPFFKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal NIKOJCOBMMN[] NEDPGGBPMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private FAPJLADNPKF GMDLMFBDPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly BMIHCGAPEEE GNMBKBHLICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly DPPEGCEGCOG MNKJOOOKLCK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GBCFHNGPBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DC40", Offset = "0x7D3C640", VA = "0x187D3DC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FAPJLADNPKF HEKMLNIJCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7D3E2D0", Offset = "0x7D3CCD0", VA = "0x187D3E2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JJCEOIKFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DCD0", Offset = "0x7D3C6D0", VA = "0x187D3DCD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float MGFOFLEHAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DC20", Offset = "0x7D3C620", VA = "0x187D3DC20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EALDJNGEMBA.LAJGMDGGKEG CEHACCFIFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E860", Offset = "0x7D3D260", VA = "0x187D3E860")]
	public AHAMHFKAOBC(IAIGKPKMDKN DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3ECA0", Offset = "0x7D3D6A0", VA = "0x187D3ECA0")]
	public AHAMHFKAOBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E290", Offset = "0x7D3CC90", VA = "0x187D3E290")]
	public void JBAOHJPBOCM(GlyphMapAsset NMKBAOEGOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E180", Offset = "0x7D3CB80", VA = "0x187D3E180")]
	public void JBAOHJPBOCM(FAPJLADNPKF IHABGLIIKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E590", Offset = "0x7D3CF90", VA = "0x187D3E590", Slot = "6")]
	public bool TryGetMeshBuffer([Out] PIBOPKIJGND NJNHMBFMPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E2F0", Offset = "0x7D3CCF0", VA = "0x187D3E2F0")]
	public void KEOPGGFEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DBD0", Offset = "0x7D3C5D0", VA = "0x187D3DBD0")]
	public bool FIIFJKLNGGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DE70", Offset = "0x7D3C870", VA = "0x187D3DE70")]
	public NIKOJCOBMMN IMPFEDILICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D7C0", Offset = "0x7D3C1C0", VA = "0x187D3D7C0")]
	public void CDKHPGKBJHN(NIKOJCOBMMN LCGFGCCHENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E0D0", Offset = "0x7D3CAD0", VA = "0x187D3E0D0")]
	internal bool JAPDGNMLGKO(NIKOJCOBMMN LCGFGCCHENI, [Out] BCIKBAMBBHI FJCJJKMKFBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DCF0", Offset = "0x7D3C6F0", VA = "0x187D3DCF0")]
	private void HNNCNKCGDIP(BPMLIMAJMPG HDPDKNNBGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E350", Offset = "0x7D3CD50", VA = "0x187D3E350")]
	private void KHMMEKAIICO(int NJIJCACCPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E530", Offset = "0x7D3CF30", VA = "0x187D3E530")]
	private bool LMJFAEHHMNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D390E0", Offset = "0x7D37AE0", VA = "0x187D390E0")]
	private static int FDKCHPNEGCF(NIKOJCOBMMN LCGFGCCHENI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x236CA70", Offset = "0x236B470", VA = "0x18236CA70")]
	private static ushort COICPDGMIKK(int MNFHMLCLFEB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D4B0", Offset = "0x7D3BEB0", VA = "0x187D3D4B0")]
	private Bounds BMKCBDGNLLL()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DB20", Offset = "0x7D3C520", VA = "0x187D3DB20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IAIGKPKMDKN
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IAIGKPKMDKN FOLMENNFEDD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float PDFBDMPJMIJ = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int JCKLDKDLPGC = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int KCMIPDNKBIN = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color OKCKJKAHKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float AHJONFGAPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int AKCJDCIJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int FKANLBIDPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int IFCNFPKFBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int HHPKJBIMPHO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D41970", Offset = "0x7D40370", VA = "0x187D41970")]
	internal IAIGKPKMDKN FMKPLPHMBJK()
	{
		return default(IAIGKPKMDKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D387E0", Offset = "0x7D371E0", VA = "0x187D387E0")]
	[CompilerGenerated]
	internal static void LMCMGHADHJA(int PCDAHJCDHHF, int ALKDPGOIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D41A80", Offset = "0x7D40480", VA = "0x187D41A80")]
	[CompilerGenerated]
	internal static void MGAJDKECMGF(float PCDAHJCDHHF, float ALKDPGOIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D387F0", Offset = "0x7D371F0", VA = "0x187D387F0")]
	[CompilerGenerated]
	internal static void ICNNLKEOPKE(int PCDAHJCDHHF, int AAFPNBCNOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D41950", Offset = "0x7D40350", VA = "0x187D41950")]
	[CompilerGenerated]
	internal static void FJNCNKPBEBM(float PCDAHJCDHHF, float AAFPNBCNOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BAGFGOPFLHD
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D3ED20", Offset = "0x7D3D720", VA = "0x187D3ED20")]
	public static float JGFIIJMOKDG(this BCIKBAMBBHI MNCHCKIBBHL)
	{
		return default(float);
	}
}
namespace RecRoom.FastText.Layout
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
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
		public readonly NIKOJCOBMMN textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7D42840", Offset = "0x7D41240", VA = "0x187D42840")]
		public TextSegmentLayout(LayoutRect layoutRect, NIKOJCOBMMN textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7D42610", Offset = "0x7D41010", VA = "0x187D42610")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7D42680", Offset = "0x7D41080", VA = "0x187D42680")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7D425B0", Offset = "0x7D40FB0", VA = "0x187D425B0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class BMIHCGAPEEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig JMMCNIHPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float BPDMHLMEDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float GHKPBCOGMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float KGMNFMJOIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float PCKKEDNIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float IAMCOEJHIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float GDBEKAFOJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float HFMIAAIEKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float DDCEILMFMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float MLHOGDIAEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float MGFOFLEHAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float KEBMOLOGFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float JJCEOIKFMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly JLLOBMDGFBA[] NBHBBMLMLJF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int GEEFNHKFEKC = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private PEJJLFABPMB[] CBONBGPMNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int GDDBCKECCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private IPLHNLDBBHG[] HEANPEOLGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int COMGHLEMHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public JLLOBMDGFBA IOKMEEBFGAN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F460", Offset = "0x7D3DE60", VA = "0x187D3F460")]
	public void JBAOHJPBOCM(FAPJLADNPKF HCDJDDEDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F4F0", Offset = "0x7D3DEF0", VA = "0x187D3F4F0")]
	public void JBAOHJPBOCM(GlyphUVConfig HINDIFOOBJN, IEnumerable<IPLHNLDBBHG> NMKBAOEGOFL, IPLHNLDBBHG HNDBFAMEOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F320", Offset = "0x7D3DD20", VA = "0x187D3F320")]
	internal void IKEJNCHIHDF(GlyphUVConfig HINDIFOOBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EDF0", Offset = "0x7D3D7F0", VA = "0x187D3EDF0")]
	private void FKEDDOENHOJ(IEnumerable<IPLHNLDBBHG> NMKBAOEGOFL, IPLHNLDBBHG HNDBFAMEOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F570", Offset = "0x7D3DF70", VA = "0x187D3F570")]
	public void MCCEGPKNBCG([In] char KBFKIJCOJBM, [Out] float2[] HPEDHEDMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B400", Offset = "0x7D39E00", VA = "0x187D3B400")]
	private JLLOBMDGFBA LPIPBNLEIKM(IPLHNLDBBHG IPPHBILLLIA)
	{
		return default(JLLOBMDGFBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F8A0", Offset = "0x7D3E2A0", VA = "0x187D3F8A0")]
	public BMIHCGAPEEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OKMIHOICJFN
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D42000", Offset = "0x7D40A00", VA = "0x187D42000")]
	public static void HDEABAHKMDM([In] float MOILOCLHDED, [In] float JEAJBCOPDFI, [In] int ABHBEBMMGOO, [In] int CPIEIEMKKKB, [In] float PCKKEDNIDJI, [In] float IAMCOEJHIME, [In] float KOIGGBGMBHJ, [In] float HAEAGNAPPBL, [In] float JDOIEPIFNCA, [In] float IHNBMKJNDGC, [Out] float MKMANNANOLM, [Out] float JABMDAIPMNG, [Out] float IJGCNKIPIMK, [Out] float CEFEONBNHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D420D0", Offset = "0x7D40AD0", VA = "0x187D420D0")]
	public static void HDEABAHKMDM([In] float MOILOCLHDED, [In] float JEAJBCOPDFI, [In] int ABHBEBMMGOO, [In] int CPIEIEMKKKB, [Out] float MKMANNANOLM, [Out] float JABMDAIPMNG, [Out] float IJGCNKIPIMK, [Out] float CEFEONBNHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D41FA0", Offset = "0x7D409A0", VA = "0x187D41FA0")]
	public static void AOFLNLJDHAN([In] float PCKKEDNIDJI, [In] float IAMCOEJHIME, [In] float MOFDHCJMOHG, [In] float NIBMJAACIOL, [In] float AGGJKLDCHGN, [In] float JKBACFKOOJH, [Out] float IHDJKCEHEBP, [Out] float NCJCEBFJGFP, [Out] float ALKICMDHHBA, [Out] float JAHFKHGBBNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct PEJJLFABPMB
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint CBAGAKCKGBA = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char FHKHKNAPLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly JLLOBMDGFBA FAMHECMHCDF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D421F0", Offset = "0x7D40BF0", VA = "0x187D421F0")]
	public PEJJLFABPMB(char KBFKIJCOJBM, JLLOBMDGFBA HPEDHEDMCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct JLLOBMDGFBA
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint CBAGAKCKGBA = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] HADIHBEKOFO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D41BD0", Offset = "0x7D405D0", VA = "0x187D41BD0")]
	public JLLOBMDGFBA(float MKMANNANOLM, float JABMDAIPMNG, float IJGCNKIPIMK, float CEFEONBNHNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct BPMLIMAJMPG
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int PGMMKEJJFHK = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal JKHHKADKBBE PFANMJCNCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] JDJELHHFPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int DDGBDEBABPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 OBACBLCJLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float IHBCKKPFALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 NNKBJJNKIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool OKOLINMEEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int ABIGHBLFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int MPNALEJEODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int CCKPNABPAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int PEDMAJPDIMB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F940", Offset = "0x7D3E340", VA = "0x187D3F940")]
	public static int IAACJLFJBHL(int MDAFGHPCDNM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum JKHHKADKBBE : byte
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
	Any = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class OLJLJOBDCML
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D421B0", Offset = "0x7D40BB0", VA = "0x187D421B0")]
	internal static float JGFIIJMOKDG(this BPMLIMAJMPG HDPDKNNBGMO, float EIIPKOIHNIL, float ICJHCLOIBJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D42130", Offset = "0x7D40B30", VA = "0x187D42130")]
	internal static void GMHKHBLOOJN(this BPMLIMAJMPG HDPDKNNBGMO, float EIIPKOIHNIL, float ICJHCLOIBJC, [Out] float2 FABCOJIGKOI, [Out] float2 EOFJEGBKIJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class DPPEGCEGCOG : EALDJNGEMBA
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int PNHAOFBOEFH = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int DLMFKCFMCEI = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string ECDIPLKMDDA = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker PKNIGINGHGK;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker MPCGBFDMKMP;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker GNMCJMJJEBB;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker HLMJMPKJBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly PIBOPKIJGND NJNHMBFMPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] NKEGKKFOEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] ANDHNLLEAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int DGJDEBMJFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int DBCMHDBPCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int MIHNMNLMPEJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GBCFHNGPBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EALDJNGEMBA.LAJGMDGGKEG CEHACCFIFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D40770", Offset = "0x7D3F170", VA = "0x187D40770")]
	public DPPEGCEGCOG(PIBOPKIJGND.FCLFKLHKHBD KCNGMEMCEKB, int AIMAJDBDKPF, int IMNCDGOGMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7D405F0", Offset = "0x7D3EFF0", VA = "0x187D405F0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] PIBOPKIJGND NJNHMBFMPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7D403A0", Offset = "0x7D3EDA0", VA = "0x187D403A0")]
	public void DPHOFBNFCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FAA0", Offset = "0x7D3E4A0", VA = "0x187D3FAA0")]
	public void DMHEBLDIKKO(Span<BPMLIMAJMPG> GDCGDDPPGEJ, BMIHCGAPEEE EPACEOIADLG, [In] IAIGKPKMDKN DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C0E0", Offset = "0x7D3AAE0", VA = "0x187D3C0E0")]
	private void KGMMAEDKODL([In] JKHHKADKBBE PFANMJCNCDI, [In] BPMLIMAJMPG OGFMMHMKCHO, int JHGOJFIJMIM, [In] float EIIPKOIHNIL, [In] float ICJHCLOIBJC, BMIHCGAPEEE EPACEOIADLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F950", Offset = "0x7D3E350", VA = "0x187D3F950")]
	private void BCBCFIAPDJN([In] JKHHKADKBBE PFANMJCNCDI, BPMLIMAJMPG OGFMMHMKCHO, [In] int NHOLPCOBNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D403C0", Offset = "0x7D3EDC0", VA = "0x187D403C0")]
	public static void LJHJLDHFFDI(ReadOnlySpan<BPMLIMAJMPG> GDCGDDPPGEJ, int GOIODFAAKCB, [Out] int GEAHOOOBNNC, [Out] int AKEACBAGLGH, [Out] int CGDDJIDGPDF)
	{
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
