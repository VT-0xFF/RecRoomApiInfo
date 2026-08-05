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
public class HIGOEFKKILB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D OCLMNMAHLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig MJIJNOOPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public BPPDFGDCOHG[] CAOLFILANDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public BPPDFGDCOHG KALLAKHJPLL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static HIGOEFKKILB AAMMBMBHFIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HIGOEFKKILB JHEFGOKNFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80F2D50", Offset = "0x80F1950", VA = "0x1880F2D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public HIGOEFKKILB()
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
		[Cpp2IlInjected.Address(RVA = "0x80F2880", Offset = "0x80F1480", VA = "0x1880F2880")]
		public GlyphUVConfig(int NJGJBGNHBMO, int ECIFGKDAOCJ, int IOPNEHADIGH, int LBICOKBCHJG, float IJJDCOFPDKH = 0f, [Optional] GlyphPixelInset FPMMGDIPFNH)
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
public readonly struct BPPDFGDCOHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char BFAJJBJGABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int ALIKGLCBIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int KDKFDIANHBO;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly BPPDFGDCOHG IPLPHCJHMBM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80F0F00", Offset = "0x80EFB00", VA = "0x1880F0F00")]
	public BPPDFGDCOHG(char CPNEHCHHKLL, int OMFPEEEGJPP, int GMGLHGGLDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80F0EE0", Offset = "0x80EFAE0", VA = "0x1880F0EE0")]
	public BPPDFGDCOHG(GlyphCoordinateWritable APDJNFIPNBI)
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
		[Cpp2IlInjected.Address(RVA = "0x80F1E90", Offset = "0x80F0A90", VA = "0x1880F1E90")]
		public static BPPDFGDCOHG KDDDGPNBGLG(GlyphCoordinateWritable FBNAMAEDFNA)
		{
			return default(BPPDFGDCOHG);
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
		private HIGOEFKKILB configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x80F2780", Offset = "0x80F1380", VA = "0x1880F2780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x80F2600", Offset = "0x80F1200", VA = "0x1880F2600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x80F25F0", Offset = "0x80F11F0", VA = "0x1880F25F0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HIGOEFKKILB ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x80F1FE0", Offset = "0x80F0BE0", VA = "0x1880F1FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BPPDFGDCOHG FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x80F2460", Offset = "0x80F1060", VA = "0x1880F2460")]
			get
			{
				return default(BPPDFGDCOHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80F1ED0", Offset = "0x80F0AD0", VA = "0x1880F1ED0")]
		internal void NGELEPCIHNP(IEnumerable<GlyphCoordinateWritable> PINCFAJPJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80F1F50", Offset = "0x80F0B50", VA = "0x1880F1F50")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80F1EB0", Offset = "0x80F0AB0", VA = "0x1880F1EB0")]
		[CompilerGenerated]
		private bool MOHHAMFLEFA(GlyphCoordinateWritable FBNAMAEDFNA)
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
		private TextSegmentMeshBufferSource GNCLCNHHCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private OHMKEHFIPMC FFMCGCNBOMB;

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
		private EEPPLKNNICN INCCLLHONHK;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80F5D00", Offset = "0x80F4900", VA = "0x1880F5D00")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80F5CB0", Offset = "0x80F48B0", VA = "0x1880F5CB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80F5AD0", Offset = "0x80F46D0", VA = "0x1880F5AD0")]
		private void BCLECCKCMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80F5DF0", Offset = "0x80F49F0", VA = "0x1880F5DF0")]
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
		private bool BPPEDHPDLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material ACNCOPCHOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private OHMKEHFIPMC FFMCGCNBOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material HDDDEFIOFFE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private HIGOEFKKILB DNMFNEPADEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x80F6680", Offset = "0x80F5280", VA = "0x1880F6680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OHMKEHFIPMC FNJPFCLNILB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x80F6900", Offset = "0x80F5500", VA = "0x1880F6900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material IHCNDGCKKAL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x80F6930", Offset = "0x80F5530", VA = "0x1880F6930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80F6860", Offset = "0x80F5460", VA = "0x1880F6860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80F6490", Offset = "0x80F5090", VA = "0x1880F6490", Slot = "8")]
		protected override void NFIBOKLNAOK(DIDDLEGGPLM PFOHGOLJDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80F6870", Offset = "0x80F5470", VA = "0x1880F6870", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] AOLDCIDBJDH ADLCAGHONEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80F6710", Offset = "0x80F5310", VA = "0x1880F6710")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80F6170", Offset = "0x80F4D70", VA = "0x1880F6170")]
		private void FALEPMEJDAN(bool GPAPPOJDLEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA79B20", Offset = "0xA78720", VA = "0x180A79B20")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct HMGEICCHPPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly OHMKEHFIPMC FMGKDFGLDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int LGFNALBLEBE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80F2ED0", Offset = "0x80F1AD0", VA = "0x1880F2ED0")]
	internal KKINOHPFMNC MNHLGFCLHJH()
	{
		return default(KKINOHPFMNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29FCD20", Offset = "0x29FB920", VA = "0x1829FCD20")]
	internal HMGEICCHPPJ(OHMKEHFIPMC GHKGDJLGKOB, int BKPPOKDGGOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DGKBJFIMBIA
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80F1A70", Offset = "0x80F0670", VA = "0x1880F1A70")]
	public static bool CIANCNIIIAK(this HMGEICCHPPJ BCGOLBEALCA, BMJLBIGOAFC IBFKOIPBKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80F1AC0", Offset = "0x80F06C0", VA = "0x1880F1AC0")]
	internal static bool CIANCNIIIAK(this KKINOHPFMNC BAFHADMNOIG, BMJLBIGOAFC IBFKOIPBKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80F1AE0", Offset = "0x80F06E0", VA = "0x1880F1AE0")]
	public static float JPJBLCNJAEG(this HMGEICCHPPJ BCGOLBEALCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAB56A0", Offset = "0xAB42A0", VA = "0x180AB56A0")]
	internal static float JPJBLCNJAEG(this KKINOHPFMNC BAFHADMNOIG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HFJEDEGBNFK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80F2920", Offset = "0x80F1520", VA = "0x1880F2920")]
	public static void BOMCCIGFAOG(this HMGEICCHPPJ BCGOLBEALCA, ReadOnlySpan<char> PEJJGJIMOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80F2970", Offset = "0x80F1570", VA = "0x1880F2970")]
	internal static void BOMCCIGFAOG(this KKINOHPFMNC BAFHADMNOIG, ReadOnlySpan<char> PEJJGJIMOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80F2D00", Offset = "0x80F1900", VA = "0x1880F2D00")]
	public static void GHGKJDKMBBL(this HMGEICCHPPJ BEOLJKIFDBF, float2 IMOKKNNGBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80F2CF0", Offset = "0x80F18F0", VA = "0x1880F2CF0")]
	internal static void GHGKJDKMBBL(this KKINOHPFMNC BAFHADMNOIG, float2 IMOKKNNGBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80F2BE0", Offset = "0x80F17E0", VA = "0x1880F2BE0")]
	public static void FABLGGAEEMA(this HMGEICCHPPJ BEOLJKIFDBF, float GKIDLCDIFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80F2BA0", Offset = "0x80F17A0", VA = "0x1880F2BA0")]
	internal static void FABLGGAEEMA(this KKINOHPFMNC BAFHADMNOIG, float GKIDLCDIFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80F2B90", Offset = "0x80F1790", VA = "0x1880F2B90")]
	internal static void DNFDJPEKFLF(this KKINOHPFMNC BAFHADMNOIG, bool AKEPBFMAFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80F2CA0", Offset = "0x80F18A0", VA = "0x1880F2CA0")]
	public static void GFGHMNGGOEK(this HMGEICCHPPJ BEOLJKIFDBF, Color32 MGBNCENPLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80F2CE0", Offset = "0x80F18E0", VA = "0x1880F2CE0")]
	internal static void GFGHMNGGOEK(this KKINOHPFMNC BAFHADMNOIG, Color32 MGBNCENPLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80F2C60", Offset = "0x80F1860", VA = "0x1880F2C60")]
	public static void FPIPNHJGGMG(this HMGEICCHPPJ BEOLJKIFDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80F2C50", Offset = "0x80F1850", VA = "0x1880F2C50")]
	internal static void FPIPNHJGGMG(this KKINOHPFMNC BAFHADMNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80F28B0", Offset = "0x80F14B0", VA = "0x1880F28B0")]
	internal static void AEBJHNDIPJN(this KKINOHPFMNC BAFHADMNOIG, int ACPCNKNHJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80F2B70", Offset = "0x80F1770", VA = "0x1880F2B70")]
	internal static void CGCNBDNHIFA(this KKINOHPFMNC BAFHADMNOIG, int DBNMOKKMFKI, BMJLBIGOAFC AOOOONFNKFK = BMJLBIGOAFC.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EEPPLKNNICN : IEquatable<EEPPLKNNICN>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort MKLFDJMNFIJ = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int INCPODOJJLF = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly EEPPLKNNICN FGCGMGADDLF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort JFDCDENAOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xD53480", Offset = "0xD52080", VA = "0x180D53480")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD53490", Offset = "0xD52090", VA = "0x180D53490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OHMKEHFIPMC FMGKDFGLDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BGMCAGMEELL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80E9D70", Offset = "0x80E8970", VA = "0x1880E9D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80EA090", Offset = "0x80E8C90", VA = "0x1880EA090")]
	public EEPPLKNNICN(int EPEJNNGICNF, OHMKEHFIPMC GHKGDJLGKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80F1C50", Offset = "0x80F0850", VA = "0x1880F1C50")]
	public bool IBAICLFMJDG([Out] HMGEICCHPPJ BCGOLBEALCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80F1D20", Offset = "0x80F0920", VA = "0x1880F1D20")]
	public void NCHKMOJJHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80E9FD0", Offset = "0x80E8BD0", VA = "0x1880E9FD0")]
	internal void PMCBMAPCIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80E9D80", Offset = "0x80E8980", VA = "0x1880E9D80", Slot = "4")]
	public bool Equals(EEPPLKNNICN IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80F1B20", Offset = "0x80F0720", VA = "0x1880F1B20", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80F1BE0", Offset = "0x80F07E0", VA = "0x1880F1BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class OHMKEHFIPMC : IDisposable, NEOMIGFJGAA
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string FACNBKMDKDL = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker LNKLOPMJLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string MNLKMFKOOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly PMHKOEHNIFK HKKDLEFMHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int GCABOELJCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal KKINOHPFMNC[] KBIHOOCKPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal EEPPLKNNICN[] ONCFIMMAJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private HIGOEFKKILB FJFNKOEMAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CAKOBFNOMFD EFIEFCELCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly IEFEKOJOCEG HEJLHEIHLEA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string BKILENEPEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80F45B0", Offset = "0x80F31B0", VA = "0x1880F45B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HIGOEFKKILB DILMNOOMKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80F41B0", Offset = "0x80F2DB0", VA = "0x1880F41B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float FNCPDDDLFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80F4870", Offset = "0x80F3470", VA = "0x1880F4870")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float FFCFHCNBANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80F4590", Offset = "0x80F3190", VA = "0x1880F4590")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NEOMIGFJGAA.JHMFDFAEPJJ MGLPMMCPGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA5B760", Offset = "0xA5A360", VA = "0x180A5B760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA5B620", Offset = "0xA5A220", VA = "0x180A5B620", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80F5470", Offset = "0x80F4070", VA = "0x1880F5470")]
	public OHMKEHFIPMC(PMHKOEHNIFK IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80F53F0", Offset = "0x80F3FF0", VA = "0x1880F53F0")]
	public OHMKEHFIPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80F4060", Offset = "0x80F2C60", VA = "0x1880F4060")]
	public void CBACPPGGEHG(GlyphMapAsset ANOCBADIOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80F40A0", Offset = "0x80F2CA0", VA = "0x1880F40A0")]
	public void CBACPPGGEHG(HIGOEFKKILB BGHDNGFOMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80F5150", Offset = "0x80F3D50", VA = "0x1880F5150", Slot = "6")]
	public bool TryGetMeshBuffer([Out] AOLDCIDBJDH ADLCAGHONEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80F4A70", Offset = "0x80F3670", VA = "0x1880F4A70")]
	public void LLIIPOGAGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80F4E30", Offset = "0x80F3A30", VA = "0x1880F4E30")]
	public bool NLFEFPLHHIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80F4E80", Offset = "0x80F3A80", VA = "0x1880F4E80")]
	public EEPPLKNNICN NOJPDDIKIGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80F4AD0", Offset = "0x80F36D0", VA = "0x1880F4AD0")]
	public void MHJENELOPKJ(EEPPLKNNICN IJBOGAAENCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80F4640", Offset = "0x80F3240", VA = "0x1880F4640")]
	internal bool IHCDGEDEJMD(EEPPLKNNICN IJBOGAAENCF, [Out] HMGEICCHPPJ BCGOLBEALCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x80F46F0", Offset = "0x80F32F0", VA = "0x1880F46F0")]
	private void JIBIGEGLHMO(KKINOHPFMNC BAFHADMNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80F4890", Offset = "0x80F3490", VA = "0x1880F4890")]
	private void LJFNLNAANJM(int DDGLCMNCJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80F50F0", Offset = "0x80F3CF0", VA = "0x1880F50F0")]
	private bool OFFNPDIHEBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80E9780", Offset = "0x80E8380", VA = "0x1880E9780")]
	private static int KLEKHLKGKKD(EEPPLKNNICN IJBOGAAENCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x236AF80", Offset = "0x2369B80", VA = "0x18236AF80")]
	private static ushort MFLILCBJDFG(int LCCBBMBENOH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80F41D0", Offset = "0x80F2DD0", VA = "0x1880F41D0")]
	private Bounds DMLDOHOPHEA()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80F44E0", Offset = "0x80F30E0", VA = "0x1880F44E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PMHKOEHNIFK
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly PMHKOEHNIFK AAPJHIBFKKO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float DFMPJLKFPGC = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int FNLEPLOEHFM = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int IJEDMCLNKHB = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color LLMPJHNIGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float PHEOAKNHKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int EMOMJMPLHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int NLDAGFFMOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int BKHEGKLMEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int LCJGFFJBJPC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80F5910", Offset = "0x80F4510", VA = "0x1880F5910")]
	internal PMHKOEHNIFK PHGGFOICIOJ()
	{
		return default(PMHKOEHNIFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80EEDC0", Offset = "0x80ED9C0", VA = "0x1880EEDC0")]
	[CompilerGenerated]
	internal static void DEBJGBDEHME(int BKMPCFIAHIG, int PLEDLJICBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80F58D0", Offset = "0x80F44D0", VA = "0x1880F58D0")]
	[CompilerGenerated]
	internal static void HHMGGACOJLE(float BKMPCFIAHIG, float PLEDLJICBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80EEDB0", Offset = "0x80ED9B0", VA = "0x1880EEDB0")]
	[CompilerGenerated]
	internal static void MLPEBIDIKOD(int BKMPCFIAHIG, int KEOAKMLJLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80F58F0", Offset = "0x80F44F0", VA = "0x1880F58F0")]
	[CompilerGenerated]
	internal static void LLNOKMHPHIF(float BKMPCFIAHIG, float KEOAKMLJLLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EFCDHJMNCMP
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80F1E00", Offset = "0x80F0A00", VA = "0x1880F1E00")]
	public static float HMMCHCMHGOC(this HMGEICCHPPJ JOKEIDCOFBC)
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
		public readonly EEPPLKNNICN textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x80F6100", Offset = "0x80F4D00", VA = "0x1880F6100")]
		public TextSegmentLayout(LayoutRect layoutRect, EEPPLKNNICN textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x80F5ED0", Offset = "0x80F4AD0", VA = "0x1880F5ED0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x80F5F40", Offset = "0x80F4B40", VA = "0x1880F5F40")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80F5E70", Offset = "0x80F4A70", VA = "0x1880F5E70")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class CAKOBFNOMFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig BHCBAFLBBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float PJGPJLCOEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float IPLNMDGAOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float NDPEBLFFBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float FEBCHCILDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float KKJHAJNPNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float MIJAJKKHAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float NCBNNILOJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float EHKHHMGAAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float MDCDIDCFDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float FFCFHCNBANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float AFGHIEFFIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float FNCPDDDLFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KHPJJOMALJK[] CNEBAHOLMAN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int EKDDMPCLIJG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private PJGFDEMAKJM[] JGHEGHGMAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int IEMJKHPGPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private BPPDFGDCOHG[] FCKDBABIENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int FEADHHMPAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public KHPJJOMALJK KDPDJLJHFMD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80F1050", Offset = "0x80EFC50", VA = "0x1880F1050")]
	public void CBACPPGGEHG(HIGOEFKKILB DJEONPDFGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80F10E0", Offset = "0x80EFCE0", VA = "0x1880F10E0")]
	public void CBACPPGGEHG(GlyphUVConfig MLGFKCGILCF, IEnumerable<BPPDFGDCOHG> ANOCBADIOEA, BPPDFGDCOHG DNGMOBFADEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80F0F10", Offset = "0x80EFB10", VA = "0x1880F0F10")]
	internal void AOFEBIEHHNK(GlyphUVConfig MLGFKCGILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x80F1490", Offset = "0x80F0090", VA = "0x1880F1490")]
	private void EDIIIPBDBFF(IEnumerable<BPPDFGDCOHG> ANOCBADIOEA, BPPDFGDCOHG DNGMOBFADEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x80F1160", Offset = "0x80EFD60", VA = "0x1880F1160")]
	public void CMGNNBNCPHJ([In] char CPNEHCHHKLL, [Out] float2[] GCKHLANONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x80EF250", Offset = "0x80EDE50", VA = "0x1880EF250")]
	private KHPJJOMALJK JGBMMBAKCLF(BPPDFGDCOHG APDJNFIPNBI)
	{
		return default(KHPJJOMALJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x80F19D0", Offset = "0x80F05D0", VA = "0x1880F19D0")]
	public CAKOBFNOMFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LCLNPKBKPDK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80F3E10", Offset = "0x80F2A10", VA = "0x1880F3E10")]
	public static void FGKBLPPCNDG([In] float FDICKHMCKGG, [In] float FOHAHLGJMNI, [In] int OPFIDFAPLKD, [In] int FGJOBIPLALC, [In] float FEBCHCILDID, [In] float KKJHAJNPNJN, [In] float KHJIJNMINHE, [In] float PCOMDDCCDFD, [In] float GDBMOHMADPH, [In] float HENJPFLKCDM, [Out] float KHJCDJBNGOB, [Out] float DDPJMEKNCPP, [Out] float KLMEKJJOMML, [Out] float DACMEFPHOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x80F3EE0", Offset = "0x80F2AE0", VA = "0x1880F3EE0")]
	public static void FGKBLPPCNDG([In] float FDICKHMCKGG, [In] float FOHAHLGJMNI, [In] int OPFIDFAPLKD, [In] int FGJOBIPLALC, [Out] float KHJCDJBNGOB, [Out] float DDPJMEKNCPP, [Out] float KLMEKJJOMML, [Out] float DACMEFPHOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x80F3F40", Offset = "0x80F2B40", VA = "0x1880F3F40")]
	public static void LDDMKPLICDG([In] float FEBCHCILDID, [In] float KKJHAJNPNJN, [In] float OAKPPNPGGNL, [In] float ELBDACLPKKK, [In] float OFMMKNHCKKM, [In] float CBAMNLKGJLF, [Out] float OJNPPLFDBFN, [Out] float BPAIEOMEDEO, [Out] float JDCKMGPOIEG, [Out] float CFEOACKCLAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct PJGFDEMAKJM
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint FBAJDIFJLHK = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char BFAJJBJGABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly KHPJJOMALJK LKBNMCLECDK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x80F58B0", Offset = "0x80F44B0", VA = "0x1880F58B0")]
	public PJGFDEMAKJM(char CPNEHCHHKLL, KHPJJOMALJK GCKHLANONNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KHPJJOMALJK
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint FBAJDIFJLHK = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] OLDGMHJGMCN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x80F3D10", Offset = "0x80F2910", VA = "0x1880F3D10")]
	public KHPJJOMALJK(float KHJCDJBNGOB, float DDPJMEKNCPP, float KLMEKJJOMML, float DACMEFPHOBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct KKINOHPFMNC
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int MFNPGIDPOMH = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal BMJLBIGOAFC AOOOONFNKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] EJODHJGENOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int IKEOEEGNNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 IMOKKNNGBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float COBGKJPKAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 IEAJBLMPLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool AKEPBFMAFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int ACCACCAOJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int ENFEICCABAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int MHFCLPOAOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int BBPAPMGACEG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x80F3E00", Offset = "0x80F2A00", VA = "0x1880F3E00")]
	public static int IDLMJGAEKMG(int KJFAKBGDHLP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum BMJLBIGOAFC : byte
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
public static class NIONGNIBEJC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x80F3FA0", Offset = "0x80F2BA0", VA = "0x1880F3FA0")]
	internal static float HMMCHCMHGOC(this KKINOHPFMNC BAFHADMNOIG, float ADLHFIKADAC, float CFMJCAONJCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80F3FE0", Offset = "0x80F2BE0", VA = "0x1880F3FE0")]
	internal static void PADMKNBGEJC(this KKINOHPFMNC BAFHADMNOIG, float ADLHFIKADAC, float CFMJCAONJCI, [Out] float2 MPPPNIHIBJF, [Out] float2 ENBPGBPHHMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class IEFEKOJOCEG : NEOMIGFJGAA
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int HCMKNEFADIL = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int PHINDOKJPLA = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string FACNBKMDKDL = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker OCAMFPBMFLL;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker IKDBLBHILIB;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker LLHNCNAGKFA;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker IICDAJDKFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly AOLDCIDBJDH ADLCAGHONEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] INAFIFFHHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] EDGAONDNJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int NLBGGNGHHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HICCPPDDBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int HJBOJJPJPPF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string BKILENEPEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NEOMIGFJGAA.JHMFDFAEPJJ MGLPMMCPGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x80F3C00", Offset = "0x80F2800", VA = "0x1880F3C00")]
	public IEFEKOJOCEG(AOLDCIDBJDH.IBJFMBHCPPB KKPJLGJHIOM, int LIDFMOLBBKH, int FDIMONNOFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x80F3A70", Offset = "0x80F2670", VA = "0x1880F3A70", Slot = "5")]
	public bool TryGetMeshBuffer([Out] AOLDCIDBJDH ADLCAGHONEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x80F3120", Offset = "0x80F1D20", VA = "0x1880F3120")]
	public void FJBCKOOPFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x80F3290", Offset = "0x80F1E90", VA = "0x1880F3290")]
	public void JCJGEEMMLOI(Span<KKINOHPFMNC> NCDNCLHOLJN, CAKOBFNOMFD FPLPHGFNFAL, [In] PMHKOEHNIFK IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80EF630", Offset = "0x80EE230", VA = "0x1880EF630")]
	private void ANAIOPMKGMB([In] BMJLBIGOAFC AOOOONFNKFK, [In] KKINOHPFMNC KKGJJOALLAG, int NABJANOMCNA, [In] float ADLHFIKADAC, [In] float CFMJCAONJCI, CAKOBFNOMFD FPLPHGFNFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x80F3140", Offset = "0x80F1D40", VA = "0x1880F3140")]
	private void GMHKLOIPLHI([In] BMJLBIGOAFC AOOOONFNKFK, KKINOHPFMNC KKGJJOALLAG, [In] int PLPGGNFGCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80F2F10", Offset = "0x80F1B10", VA = "0x1880F2F10")]
	public static void EPNOMOHCFAF(ReadOnlySpan<KKINOHPFMNC> NCDNCLHOLJN, int LMLAAPGGLEJ, [Out] int LDDOFFGELJD, [Out] int GCAEPNIEADE, [Out] int LEGGCCDJPBF)
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
