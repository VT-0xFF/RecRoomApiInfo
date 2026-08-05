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
public class CNEOLGAEFGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D DGOBONKILAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig IOHONFAGKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MNFEDBDFNIF[] LCLOEMIOFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public MNFEDBDFNIF HEFPBMIEFJK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static CNEOLGAEFGE BBKNOPJGKMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CNEOLGAEFGE LFIBLGGAGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8456E90", Offset = "0x8455490", VA = "0x188456E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CNEOLGAEFGE()
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
		[Cpp2IlInjected.Address(RVA = "0x8458810", Offset = "0x8456E10", VA = "0x188458810")]
		public GlyphUVConfig(int GHOHJIAIDPJ, int OGLEFNFBDMJ, int ENNEFFBNNBN, int HGOIIPCBHJE, float HBCMEGPEONF = 0f, [Optional] GlyphPixelInset JBBGDKEGCDF)
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
public readonly struct MNFEDBDFNIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char GOEPFKEFNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int KMONBNILENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int MFMFPKPPGMH;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly MNFEDBDFNIF CMCPGABNFMF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84597E0", Offset = "0x8457DE0", VA = "0x1884597E0")]
	public MNFEDBDFNIF(char KELNKOMNEIN, int BBDFNJEGEFH, int IACGJGBEPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84597C0", Offset = "0x8457DC0", VA = "0x1884597C0")]
	public MNFEDBDFNIF(GlyphCoordinateWritable JOIFHKBKJIF)
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
		[Cpp2IlInjected.Address(RVA = "0x8457E20", Offset = "0x8456420", VA = "0x188457E20")]
		public static MNFEDBDFNIF HPNBGLLBBBG(GlyphCoordinateWritable JNNOBIJIOOK)
		{
			return default(MNFEDBDFNIF);
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
		private CNEOLGAEFGE configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8458710", Offset = "0x8456D10", VA = "0x188458710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8458590", Offset = "0x8456B90", VA = "0x188458590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8458580", Offset = "0x8456B80", VA = "0x188458580")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CNEOLGAEFGE ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8457F70", Offset = "0x8456570", VA = "0x188457F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MNFEDBDFNIF FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x84583F0", Offset = "0x84569F0", VA = "0x1884583F0")]
			get
			{
				return default(MNFEDBDFNIF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8457E60", Offset = "0x8456460", VA = "0x188457E60")]
		internal void IHLNCFLAIGB(IEnumerable<GlyphCoordinateWritable> OPKJIDLACNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8457EE0", Offset = "0x84564E0", VA = "0x188457EE0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8457E40", Offset = "0x8456440", VA = "0x188457E40")]
		[CompilerGenerated]
		private bool HLAJPBMMEKO(GlyphCoordinateWritable JNNOBIJIOOK)
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
		private TextSegmentMeshBufferSource ENHJMDMFFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private BOKAHJFFMHP OMJFMGGCKBD;

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
		private CGMDOCOMADM MLMPIIIFLIN;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8459EE0", Offset = "0x84584E0", VA = "0x188459EE0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8459E90", Offset = "0x8458490", VA = "0x188459E90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8459CB0", Offset = "0x84582B0", VA = "0x188459CB0")]
		private void LDCPALLMKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8459FD0", Offset = "0x84585D0", VA = "0x188459FD0")]
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
		private bool DHNMJFGAMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material GHPFPCHEDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BOKAHJFFMHP OMJFMGGCKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material PLJBJPENGGH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private CNEOLGAEFGE ABDLEDGAINF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x845A350", Offset = "0x8458950", VA = "0x18845A350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BOKAHJFFMHP JHEKHIBLPNI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x845AAD0", Offset = "0x84590D0", VA = "0x18845AAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material AOIFGILFLBL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x845AB00", Offset = "0x8459100", VA = "0x18845AB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x845AA30", Offset = "0x8459030", VA = "0x18845AA30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x845A700", Offset = "0x8458D00", VA = "0x18845A700", Slot = "8")]
		protected override void MLHLECBDCKE(CMPDFKDPGDO EEGAAOLALGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x845AA40", Offset = "0x8459040", VA = "0x18845AA40", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] PNIDNFGJMCB ONEEOMNNOFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x845A8E0", Offset = "0x8458EE0", VA = "0x18845A8E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x845A3E0", Offset = "0x84589E0", VA = "0x18845A3E0")]
		private void MCEOCEIIDFM(bool MKJGBAFLMBJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct CDJMJNNEJII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly BOKAHJFFMHP KPJLJJPLCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int OMJOKCGLAPF;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8456B70", Offset = "0x8455170", VA = "0x188456B70")]
	internal FPAGPECFJIN NLIAGHHLGHG()
	{
		return default(FPAGPECFJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2ADAD20", Offset = "0x2AD9320", VA = "0x182ADAD20")]
	internal CDJMJNNEJII(BOKAHJFFMHP BIAJFLEJGFD, int GELKJGNHKFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BNBPECNDKJB
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84552B0", Offset = "0x84538B0", VA = "0x1884552B0")]
	public static bool MLGMCGJFCOK(this CDJMJNNEJII FGLNIGMPEEK, CNAALMOLLDD FCDOCPDACJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8455300", Offset = "0x8453900", VA = "0x188455300")]
	internal static bool MLGMCGJFCOK(this FPAGPECFJIN NIPBPHHFIFM, CNAALMOLLDD FCDOCPDACJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8455270", Offset = "0x8453870", VA = "0x188455270")]
	public static float FOHKILKAMEF(this CDJMJNNEJII FGLNIGMPEEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0")]
	internal static float FOHKILKAMEF(this FPAGPECFJIN NIPBPHHFIFM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PDCKCHDLHIO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8459B40", Offset = "0x8458140", VA = "0x188459B40")]
	public static void MNCADFEJPHF(this CDJMJNNEJII FGLNIGMPEEK, ReadOnlySpan<char> GBNFDOPKJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8459940", Offset = "0x8457F40", VA = "0x188459940")]
	internal static void MNCADFEJPHF(this FPAGPECFJIN NIPBPHHFIFM, ReadOnlySpan<char> GBNFDOPKJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8459870", Offset = "0x8457E70", VA = "0x188459870")]
	public static void DCPBKKKHGCJ(this CDJMJNNEJII GAPPELIECGC, float2 FKDCEGFHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84598C0", Offset = "0x8457EC0", VA = "0x1884598C0")]
	internal static void DCPBKKKHGCJ(this FPAGPECFJIN NIPBPHHFIFM, float2 FKDCEGFHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8459C40", Offset = "0x8458240", VA = "0x188459C40")]
	public static void OFICKCHFBCF(this CDJMJNNEJII GAPPELIECGC, float PCCOKKHMFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8459C00", Offset = "0x8458200", VA = "0x188459C00")]
	internal static void OFICKCHFBCF(this FPAGPECFJIN NIPBPHHFIFM, float PCCOKKHMFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8459810", Offset = "0x8457E10", VA = "0x188459810")]
	internal static void BICFDOPNKPP(this FPAGPECFJIN NIPBPHHFIFM, bool JOBNPNIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84598E0", Offset = "0x8457EE0", VA = "0x1884598E0")]
	public static void DFHFIDMMMIF(this CDJMJNNEJII GAPPELIECGC, Color32 ONDGBPEOGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84598D0", Offset = "0x8457ED0", VA = "0x1884598D0")]
	internal static void DFHFIDMMMIF(this FPAGPECFJIN NIPBPHHFIFM, Color32 ONDGBPEOGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8459830", Offset = "0x8457E30", VA = "0x188459830")]
	public static void DBEEOCOBPNB(this CDJMJNNEJII GAPPELIECGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8459820", Offset = "0x8457E20", VA = "0x188459820")]
	internal static void DBEEOCOBPNB(this FPAGPECFJIN NIPBPHHFIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8459B90", Offset = "0x8458190", VA = "0x188459B90")]
	internal static void NOGPFNOFCJM(this FPAGPECFJIN NIPBPHHFIFM, int ELCCCHIEMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8459920", Offset = "0x8457F20", VA = "0x188459920")]
	internal static void EICCKABOALB(this FPAGPECFJIN NIPBPHHFIFM, int EOBLAFPOOHC, CNAALMOLLDD JPEHENEDELH = CNAALMOLLDD.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CGMDOCOMADM : IEquatable<CGMDOCOMADM>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort IJFFDGJHPNO = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int DPNCDKIBGNN = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly CGMDOCOMADM GNELOBLMMLK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort FEKJLKOFDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xDD1150", Offset = "0xDCF750", VA = "0x180DD1150")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xDD1160", Offset = "0xDCF760", VA = "0x180DD1160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BOKAHJFFMHP KPJLJJPLCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EJBELALFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x844D770", Offset = "0x844BD70", VA = "0x18844D770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x844D890", Offset = "0x844BE90", VA = "0x18844D890")]
	public CGMDOCOMADM(int MOCEBFLKPEC, BOKAHJFFMHP BIAJFLEJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8456CE0", Offset = "0x84552E0", VA = "0x188456CE0")]
	public bool MGLEPCDMBGP([Out] CDJMJNNEJII FGLNIGMPEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8456DB0", Offset = "0x84553B0", VA = "0x188456DB0")]
	public void PILMPNHBFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x844D780", Offset = "0x844BD80", VA = "0x18844D780")]
	internal void OOEFGFKALPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x844D570", Offset = "0x844BB70", VA = "0x18844D570", Slot = "4")]
	public bool Equals(CGMDOCOMADM IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8456BB0", Offset = "0x84551B0", VA = "0x188456BB0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8456C70", Offset = "0x8455270", VA = "0x188456C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class BOKAHJFFMHP : IDisposable, IBOHKBJANCO
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string BHCOIJOBEAK = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker ONIOPAMPOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string KHEFOKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly BFPKFLCECOO MJOLOMDFKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int NNMEBKIDGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal FPAGPECFJIN[] LDJPPONNNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal CGMDOCOMADM[] DJNGOMPHAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private CNEOLGAEFGE GKOKCFHLKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MIBIIIHEJNE KPPJMKDHEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly GAAJNEGKEHI MBDBHOELPDL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string DJFMCHMDHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8455A10", Offset = "0x8454010", VA = "0x188455A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public CNEOLGAEFGE NAACHGEALHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84559D0", Offset = "0x8453FD0", VA = "0x1884559D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float HKLJGDLHEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84554F0", Offset = "0x8453AF0", VA = "0x1884554F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float LCAFBKDPBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84559F0", Offset = "0x8453FF0", VA = "0x1884559F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IBOHKBJANCO.LHLEDHGLGDL FBHPKCPDLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA962E0", Offset = "0xA948E0", VA = "0x180A962E0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8456730", Offset = "0x8454D30", VA = "0x188456730")]
	public BOKAHJFFMHP(BFPKFLCECOO CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84566B0", Offset = "0x8454CB0", VA = "0x1884566B0")]
	public BOKAHJFFMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84562C0", Offset = "0x84548C0", VA = "0x1884562C0")]
	public void PNHKIAJGEDI(GlyphMapAsset KGBOPNPANJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8456300", Offset = "0x8454900", VA = "0x188456300")]
	public void PNHKIAJGEDI(CNEOLGAEFGE PBGOOAKMMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8456410", Offset = "0x8454A10", VA = "0x188456410", Slot = "6")]
	public bool TryGetMeshBuffer([Out] PNIDNFGJMCB ONEEOMNNOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8455AA0", Offset = "0x84540A0", VA = "0x188455AA0")]
	public void LCCBDBNBLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8455320", Offset = "0x8453920", VA = "0x188455320")]
	public bool ACGKCKIJBKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8455D40", Offset = "0x8454340", VA = "0x188455D40")]
	public CGMDOCOMADM MGABDMFFDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84555C0", Offset = "0x8453BC0", VA = "0x1884555C0")]
	public void FCGINHCENIP(CGMDOCOMADM HCJMIFMGIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8455920", Offset = "0x8453F20", VA = "0x188455920")]
	internal bool GBHBPEGPPHB(CGMDOCOMADM HCJMIFMGIHK, [Out] CDJMJNNEJII FGLNIGMPEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8455370", Offset = "0x8453970", VA = "0x188455370")]
	private void AIMGEDJMKEB(FPAGPECFJIN NIPBPHHFIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8455B60", Offset = "0x8454160", VA = "0x188455B60")]
	private void MCIJKGBEDIJ(int HKEMKAGMCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8455B00", Offset = "0x8454100", VA = "0x188455B00")]
	private bool LEOONOMILOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x844F5C0", Offset = "0x844DBC0", VA = "0x18844F5C0")]
	private static int IAMMEJPMAEJ(CGMDOCOMADM HCJMIFMGIHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2535B90", Offset = "0x2534190", VA = "0x182535B90")]
	private static ushort DDFJEPCFBKE(int LEPAEEGOBDO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8455FB0", Offset = "0x84545B0", VA = "0x188455FB0")]
	private Bounds PIJBBJODEHL()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8455510", Offset = "0x8453B10", VA = "0x188455510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BFPKFLCECOO
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BFPKFLCECOO OIKJFNGOMJI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float OAMCPODAOMG = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int CJNEHCNNABK = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HACCELJBIGL = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color NBLHBEMAPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float ENOIANAFFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int NGGGABHAGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int NNNPBIJFJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int DDDELCEPFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int NOGFGNJHCHC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8455090", Offset = "0x8453690", VA = "0x188455090")]
	internal BFPKFLCECOO FEBEIMLMLHM()
	{
		return default(BFPKFLCECOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x844CC20", Offset = "0x844B220", VA = "0x18844CC20")]
	[CompilerGenerated]
	internal static void BAPGMODIBAP(int FKMNCAKIOFK, int DAKPJNHJLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84551A0", Offset = "0x84537A0", VA = "0x1884551A0")]
	[CompilerGenerated]
	internal static void KMFAIKMHKKM(float FKMNCAKIOFK, float DAKPJNHJLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x844CB70", Offset = "0x844B170", VA = "0x18844CB70")]
	[CompilerGenerated]
	internal static void BNDBONEFHFA(int FKMNCAKIOFK, int NELFANACIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8455070", Offset = "0x8453670", VA = "0x188455070")]
	[CompilerGenerated]
	internal static void DAMPCDCBGJK(float FKMNCAKIOFK, float NELFANACIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LBEMDGDNCMI
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8458900", Offset = "0x8456F00", VA = "0x188458900")]
	public static float HCGLFFEDEFL(this CDJMJNNEJII DJFJPHEFCOC)
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
		public readonly CGMDOCOMADM textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x845A2E0", Offset = "0x84588E0", VA = "0x18845A2E0")]
		public TextSegmentLayout(LayoutRect layoutRect, CGMDOCOMADM textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x845A0B0", Offset = "0x84586B0", VA = "0x18845A0B0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x845A120", Offset = "0x8458720", VA = "0x18845A120")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x845A050", Offset = "0x8458650", VA = "0x18845A050")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class MIBIIIHEJNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig PDMHIMGBGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float LJEPDHHODOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float LCONDGBCGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float GHOBBMKDHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float HPNMJADFHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float NGJNKNDAHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float IGJOPBKCJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float ILEHGJKKGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float AJGGKMONDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float HHFFABLBAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float LCAFBKDPBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float FFKLKKINECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float HKLJGDLHEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MFDKAMPCFFE[] NDHNFIPDOLG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int HDKBLFNCLOD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NOLCNNFLOOJ[] PINNLFIAGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int PHHKFFKAHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private MNFEDBDFNIF[] MOCAFILDACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int MBHOPJFCNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MFDKAMPCFFE FEPFFJLKLPI;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8459640", Offset = "0x8457C40", VA = "0x188459640")]
	public void PNHKIAJGEDI(CNEOLGAEFGE ICMFPIADMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84595C0", Offset = "0x8457BC0", VA = "0x1884595C0")]
	public void PNHKIAJGEDI(GlyphUVConfig ANEFPEOCPIA, IEnumerable<MNFEDBDFNIF> KGBOPNPANJP, MNFEDBDFNIF HIBDMGOKCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8459150", Offset = "0x8457750", VA = "0x188459150")]
	internal void NEANLKCNLFM(GlyphUVConfig ANEFPEOCPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8458C10", Offset = "0x8457210", VA = "0x188458C10")]
	private void LKMIBEDOJAN(IEnumerable<MNFEDBDFNIF> KGBOPNPANJP, MNFEDBDFNIF HIBDMGOKCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8459290", Offset = "0x8457890", VA = "0x188459290")]
	public void OCABFPOOLJH([In] char KELNKOMNEIN, [Out] float2[] IEJFKHMNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8454A90", Offset = "0x8453090", VA = "0x188454A90")]
	private MFDKAMPCFFE BHHIFLJFMFK(MNFEDBDFNIF JOIFHKBKJIF)
	{
		return default(MFDKAMPCFFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84596D0", Offset = "0x8457CD0", VA = "0x1884596D0")]
	public MIBIIIHEJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MDMOFOAOGFM
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8458A50", Offset = "0x8457050", VA = "0x188458A50")]
	public static void NCCLGMENGIN([In] float KCBONDJEKHE, [In] float JBPFHKDEGJL, [In] int DENIJNBILEG, [In] int GMLMPFNMMID, [In] float HPNMJADFHII, [In] float NGJNKNDAHLC, [In] float LLJICNMPGMF, [In] float JJPDCCGDNMN, [In] float FJIEJCDHODP, [In] float GKJNHNAIEAD, [Out] float GMLKINEHNPH, [Out] float ELMGDAHMDNM, [Out] float IGEOLGPIFJJ, [Out] float HOFHALEFHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84589F0", Offset = "0x8456FF0", VA = "0x1884589F0")]
	public static void NCCLGMENGIN([In] float KCBONDJEKHE, [In] float JBPFHKDEGJL, [In] int DENIJNBILEG, [In] int GMLMPFNMMID, [Out] float GMLKINEHNPH, [Out] float ELMGDAHMDNM, [Out] float IGEOLGPIFJJ, [Out] float HOFHALEFHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8458990", Offset = "0x8456F90", VA = "0x188458990")]
	public static void GHNKMPLKBCE([In] float HPNMJADFHII, [In] float NGJNKNDAHLC, [In] float GNEGCOBIGCF, [In] float CDMCNILKLCN, [In] float IBCHAEJABHC, [In] float HCAIJHKLPLN, [Out] float DIDHHIFFEFA, [Out] float ALMEEKHDHPF, [Out] float HBPAHLJGBKA, [Out] float BOCEEHFPKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct NOLCNNFLOOJ
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint OFEMGBNKOLB = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char GOEPFKEFNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly MFDKAMPCFFE DEGMCMPCODD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84597F0", Offset = "0x8457DF0", VA = "0x1884597F0")]
	public NOLCNNFLOOJ(char KELNKOMNEIN, MFDKAMPCFFE IEJFKHMNJIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MFDKAMPCFFE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint OFEMGBNKOLB = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] BBBDHIHCGKO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8458B20", Offset = "0x8457120", VA = "0x188458B20")]
	public MFDKAMPCFFE(float GMLKINEHNPH, float ELMGDAHMDNM, float IGEOLGPIFJJ, float HOFHALEFHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct FPAGPECFJIN
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int MFCIJBGIJOO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal CNAALMOLLDD JPEHENEDELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] IFDPHHHDFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int FNNNHJFPFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 FKDCEGFHKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float MNNOLAGGELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 ENHEECOJAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool JOBNPNIBFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int MIHDLMOHJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int IIECEAFAFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int IIKDDLCOCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int JEAGNKEEOJA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8457010", Offset = "0x8455610", VA = "0x188457010")]
	public static int HBALDGNPBIB(int NPDEDHJCDNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum CNAALMOLLDD : byte
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
public static class JOIINCHJJKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8458840", Offset = "0x8456E40", VA = "0x188458840")]
	internal static float HCGLFFEDEFL(this FPAGPECFJIN NIPBPHHFIFM, float BEILFDDFEIH, float GGKLKELIENP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8458880", Offset = "0x8456E80", VA = "0x188458880")]
	internal static void PLDHIKBJLIN(this FPAGPECFJIN NIPBPHHFIFM, float BEILFDDFEIH, float GGKLKELIENP, [Out] float2 AJNNFOKDGKA, [Out] float2 BHCLOJJFNGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class GAAJNEGKEHI : IBOHKBJANCO
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int MOLJPMCADKC = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int BMPLDLDHONE = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string BHCOIJOBEAK = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker GJIKMNPFBJC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker MHIOMPOAJNC;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker DGHLFBDKAKE;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker OLHCMBFAJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly PNIDNFGJMCB ONEEOMNNOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] LBDJKFKFJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] GHDNBPNIMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BAADPFPCNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int JELBMFGODIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int AJMPLKLIODC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string DJFMCHMDHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IBOHKBJANCO.LHLEDHGLGDL FBHPKCPDLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8457D10", Offset = "0x8456310", VA = "0x188457D10")]
	public GAAJNEGKEHI(PNIDNFGJMCB.NPNCPIIPGKI NELGEBJPPLO, int KLDDIHPCJAA, int BCGAFGGPMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8457B80", Offset = "0x8456180", VA = "0x188457B80", Slot = "5")]
	public bool TryGetMeshBuffer([Out] PNIDNFGJMCB ONEEOMNNOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8457A10", Offset = "0x8456010", VA = "0x188457A10")]
	public void LIGOPIIDGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8457020", Offset = "0x8455620", VA = "0x188457020")]
	public void GOJGJGFDHGH(Span<FPAGPECFJIN> GNJHDGCJDDB, MIBIIIHEJNE BAJAPOMJJBL, [In] BFPKFLCECOO CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8453100", Offset = "0x8451700", VA = "0x188453100")]
	private void AGBMHAMOKIA([In] CNAALMOLLDD JPEHENEDELH, [In] FPAGPECFJIN DKJNLJMBFFE, int CLEIIGJEKKB, [In] float BEILFDDFEIH, [In] float GGKLKELIENP, MIBIIIHEJNE BAJAPOMJJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8457A30", Offset = "0x8456030", VA = "0x188457A30")]
	private void MGHBGNJMBNP([In] CNAALMOLLDD JPEHENEDELH, FPAGPECFJIN DKJNLJMBFFE, [In] int NNGBLOOFKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8457800", Offset = "0x8455E00", VA = "0x188457800")]
	public static void KODJLGBGDFP(ReadOnlySpan<FPAGPECFJIN> GNJHDGCJDDB, int KDAECICHDIJ, [Out] int GLNIGJAJFNF, [Out] int EABJPADKIFC, [Out] int KFDBPHLOPCA)
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
