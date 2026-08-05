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
public class OOGBBHCMJIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D EJINMCOCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig KJJJNGGJOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public PJPOILPJPIK[] JJGFNCHCODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public PJPOILPJPIK MDPEFACKIDN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static OOGBBHCMJIJ LFMFLMLKJFE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OOGBBHCMJIJ OIDMEDECOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78CB530", Offset = "0x78CA930", VA = "0x1878CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public OOGBBHCMJIJ()
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
		[Cpp2IlInjected.Address(RVA = "0x78CABC0", Offset = "0x78C9FC0", VA = "0x1878CABC0")]
		public GlyphUVConfig(int HNLHKOOLNDF, int NPEDMKBLCAA, int OFLOKMFIHNA, int LMEFDCFBGEN, float BIOBLBBJAAD = 0f, [Optional] GlyphPixelInset DOMJNDKMCME)
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
public readonly struct PJPOILPJPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char FLPABGFNIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int JOOEHIGPEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int JIDFGGHBIAG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly PJPOILPJPIK GCOJACDPMLM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78CCF60", Offset = "0x78CC360", VA = "0x1878CCF60")]
	public PJPOILPJPIK(char EHJOKGBPGOL, int EAHDNMEJHJG, int KAMEHPKHHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78CCF70", Offset = "0x78CC370", VA = "0x1878CCF70")]
	public PJPOILPJPIK(GlyphCoordinateWritable ANFAJGEPOPE)
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
		[Cpp2IlInjected.Address(RVA = "0x78CA1E0", Offset = "0x78C95E0", VA = "0x1878CA1E0")]
		public static PJPOILPJPIK CLMIANKGGAM(GlyphCoordinateWritable NOBKOCLLFNE)
		{
			return default(PJPOILPJPIK);
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
		private OOGBBHCMJIJ configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x78CAAC0", Offset = "0x78C9EC0", VA = "0x1878CAAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x78CA940", Offset = "0x78C9D40", VA = "0x1878CA940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A60", Offset = "0x9A8E60", VA = "0x1809A9A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x78CA930", Offset = "0x78C9D30", VA = "0x1878CA930")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OOGBBHCMJIJ ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x78CA330", Offset = "0x78C9730", VA = "0x1878CA330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PJPOILPJPIK FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x78CA7A0", Offset = "0x78C9BA0", VA = "0x1878CA7A0")]
			get
			{
				return default(PJPOILPJPIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78CA220", Offset = "0x78C9620", VA = "0x1878CA220")]
		internal void JIEDHKAGDDK(IEnumerable<GlyphCoordinateWritable> BEEJLOBMKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78CA2A0", Offset = "0x78C96A0", VA = "0x1878CA2A0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78CA200", Offset = "0x78C9600", VA = "0x1878CA200")]
		[CompilerGenerated]
		private bool HMOAIHFJCIL(GlyphCoordinateWritable NOBKOCLLFNE)
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
		private TextSegmentMeshBufferSource EPMEEHOGLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PEGDHDFJEOE JKPJGCDBNMF;

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
		private JGPHNPBGJLB EHNABAPBNCC;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78CD1C0", Offset = "0x78CC5C0", VA = "0x1878CD1C0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78CD170", Offset = "0x78CC570", VA = "0x1878CD170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78CCF90", Offset = "0x78CC390", VA = "0x1878CCF90")]
		private void KCOGKMFKOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78CD2B0", Offset = "0x78CC6B0", VA = "0x1878CD2B0")]
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
		private bool AJMFFJEKPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material EPFHGOCCDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private PEGDHDFJEOE JKPJGCDBNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material GFGACOLOBPK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private OOGBBHCMJIJ MNBLBCPJBDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x78CD630", Offset = "0x78CCA30", VA = "0x1878CD630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PEGDHDFJEOE CPHIMOFOKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x78CDDB0", Offset = "0x78CD1B0", VA = "0x1878CDDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material AHMCGEDJOBA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x78CDDE0", Offset = "0x78CD1E0", VA = "0x1878CDDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78CDD10", Offset = "0x78CD110", VA = "0x1878CDD10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78CD6C0", Offset = "0x78CCAC0", VA = "0x1878CD6C0", Slot = "8")]
		protected override void BKEKLLLINPN(PFJAGJJBHOM EDPGLLNEELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78CDD20", Offset = "0x78CD120", VA = "0x1878CDD20", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] PGHHODCEFDE COGEHCHHBIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78CDBC0", Offset = "0x78CCFC0", VA = "0x1878CDBC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78CD8A0", Offset = "0x78CCCA0", VA = "0x1878CD8A0")]
		private void FOPNEDKNBLE(bool HLPBIKLHEBD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C70B0", Offset = "0x9C64B0", VA = "0x1809C70B0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct DOEJLFJFHKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly PEGDHDFJEOE HHDFOEAIKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int DDCCGIFDNLN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78C93A0", Offset = "0x78C87A0", VA = "0x1878C93A0")]
	internal OMJHDNDPLNH DIPEAHDGEMD()
	{
		return default(OMJHDNDPLNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x266C510", Offset = "0x266B910", VA = "0x18266C510")]
	internal DOEJLFJFHKK(PEGDHDFJEOE HEKFIEJNOCO, int PDODKHCOAOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BHGDHNLOBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x78C9310", Offset = "0x78C8710", VA = "0x1878C9310")]
	public static bool GNJLKJGFHOO(this DOEJLFJFHKK GKFIHIFDCIH, PHMILLAHOAA OPGENLKKICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x78C92F0", Offset = "0x78C86F0", VA = "0x1878C92F0")]
	internal static bool GNJLKJGFHOO(this OMJHDNDPLNH HBIDMGFGNHE, PHMILLAHOAA OPGENLKKICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x78C9360", Offset = "0x78C8760", VA = "0x1878C9360")]
	public static float LBHIOCDPGJB(this DOEJLFJFHKK GKFIHIFDCIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC8B0A0", Offset = "0xC8A4A0", VA = "0x180C8B0A0")]
	internal static float LBHIOCDPGJB(this OMJHDNDPLNH HBIDMGFGNHE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NGFIKKMJMEE
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x78CB130", Offset = "0x78CA530", VA = "0x1878CB130")]
	public static void CKCCEOHPMEG(this DOEJLFJFHKK GKFIHIFDCIH, ReadOnlySpan<char> CACPHIIDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x78CB180", Offset = "0x78CA580", VA = "0x1878CB180")]
	internal static void CKCCEOHPMEG(this OMJHDNDPLNH HBIDMGFGNHE, ReadOnlySpan<char> CACPHIIDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x78CB4C0", Offset = "0x78CA8C0", VA = "0x1878CB4C0")]
	public static void MKDGDHAOHGI(this DOEJLFJFHKK AKNAKHLGBNH, float2 KCMAPEODNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x78CB4B0", Offset = "0x78CA8B0", VA = "0x1878CB4B0")]
	internal static void MKDGDHAOHGI(this OMJHDNDPLNH HBIDMGFGNHE, float2 KCMAPEODNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x78CB0C0", Offset = "0x78CA4C0", VA = "0x1878CB0C0")]
	public static void CFIAPDMABFA(this DOEJLFJFHKK AKNAKHLGBNH, float LDMDDNPOEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x78CB080", Offset = "0x78CA480", VA = "0x1878CB080")]
	internal static void CFIAPDMABFA(this OMJHDNDPLNH HBIDMGFGNHE, float LDMDDNPOEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x78CB510", Offset = "0x78CA910", VA = "0x1878CB510")]
	internal static void OMAFMCCAOCM(this OMJHDNDPLNH HBIDMGFGNHE, bool DLBGJIGFLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x78CB380", Offset = "0x78CA780", VA = "0x1878CB380")]
	public static void DMFBDFFBKIN(this DOEJLFJFHKK AKNAKHLGBNH, Color32 ODFBFMBMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78CB3C0", Offset = "0x78CA7C0", VA = "0x1878CB3C0")]
	internal static void DMFBDFFBKIN(this OMJHDNDPLNH HBIDMGFGNHE, Color32 ODFBFMBMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x78CB450", Offset = "0x78CA850", VA = "0x1878CB450")]
	public static void LCOHFCLEJIM(this DOEJLFJFHKK AKNAKHLGBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x78CB440", Offset = "0x78CA840", VA = "0x1878CB440")]
	internal static void LCOHFCLEJIM(this OMJHDNDPLNH HBIDMGFGNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x78CB3D0", Offset = "0x78CA7D0", VA = "0x1878CB3D0")]
	internal static void KACJHEFOKNF(this OMJHDNDPLNH HBIDMGFGNHE, int KGCONEINMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x78CB490", Offset = "0x78CA890", VA = "0x1878CB490")]
	internal static void MALNFHPPOBJ(this OMJHDNDPLNH HBIDMGFGNHE, int HHIKEMEHFOJ, PHMILLAHOAA JILNHIENCIC = PHMILLAHOAA.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class JGPHNPBGJLB : IEquatable<JGPHNPBGJLB>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort PKDICANOLDN = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int LBFGJFJEPEC = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly JGPHNPBGJLB AOAGOOOOGFB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort GLGJGKLKJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB95710", Offset = "0xB94B10", VA = "0x180B95710")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB95720", Offset = "0xB94B20", VA = "0x180B95720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PEGDHDFJEOE HHDFOEAIKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PNPLPCMDCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x78BF740", Offset = "0x78BEB40", VA = "0x1878BF740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x78BF880", Offset = "0x78BEC80", VA = "0x1878BF880")]
	public JGPHNPBGJLB(int ABNIIFJMBDG, PEGDHDFJEOE HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x78CAF20", Offset = "0x78CA320", VA = "0x1878CAF20")]
	public bool JGGNMKINNDK([Out] DOEJLFJFHKK GKFIHIFDCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x78CAE60", Offset = "0x78CA260", VA = "0x1878CAE60")]
	public void FEMKONHLAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x78BF7C0", Offset = "0x78BEBC0", VA = "0x1878BF7C0")]
	internal void NIDGFIKCINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x78BF620", Offset = "0x78BEA20", VA = "0x1878BF620", Slot = "4")]
	public bool Equals(JGPHNPBGJLB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x78CADA0", Offset = "0x78CA1A0", VA = "0x1878CADA0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x78CAEB0", Offset = "0x78CA2B0", VA = "0x1878CAEB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class PEGDHDFJEOE : IDisposable, HBPFOPEAFLB
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string NHCMIJHKHKN = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker EGDGKLNOHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string KDOCJFNPGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly FEKEFKKADCK EGIALEKFNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int IBOMDNMABOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal OMJHDNDPLNH[] DMEKLOMJFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal JGPHNPBGJLB[] GELAPMDLKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private OOGBBHCMJIJ LFEMAHAPMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GMIHPEKJHIC IAGFKPKLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly ABGKILBNOIE BGNNHEIJLAI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string IGEPDAOOLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x78CC6F0", Offset = "0x78CBAF0", VA = "0x1878CC6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OOGBBHCMJIJ DCEMKOEBGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x78CB6C0", Offset = "0x78CAAC0", VA = "0x1878CB6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JDOFFNMLLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x78CB6A0", Offset = "0x78CAAA0", VA = "0x1878CB6A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float DBNCNAAOBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x78CC370", Offset = "0x78CB770", VA = "0x1878CC370")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HBPFOPEAFLB.ABCMKCFMAFH FBDKNJHMFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AA0", Offset = "0x9A8EA0", VA = "0x1809A9AA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A50", Offset = "0x9A8E50", VA = "0x1809A9A50", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x78CCAD0", Offset = "0x78CBED0", VA = "0x1878CCAD0")]
	public PEGDHDFJEOE(FEKEFKKADCK HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x78CCA50", Offset = "0x78CBE50", VA = "0x1878CCA50")]
	public PEGDHDFJEOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x78CB7F0", Offset = "0x78CABF0", VA = "0x1878CB7F0")]
	public void BECHPFCMIHE(GlyphMapAsset OLJLHIOKIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x78CB6E0", Offset = "0x78CAAE0", VA = "0x1878CB6E0")]
	public void BECHPFCMIHE(OOGBBHCMJIJ EKJGAENMCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x78CC780", Offset = "0x78CBB80", VA = "0x1878CC780", Slot = "6")]
	public bool TryGetMeshBuffer([Out] PGHHODCEFDE COGEHCHHBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x78CBB40", Offset = "0x78CAF40", VA = "0x1878CBB40")]
	public void DMAIFOODLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x78CC140", Offset = "0x78CB540", VA = "0x1878CC140")]
	public bool KGPDMBEFHGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x78CBE30", Offset = "0x78CB230", VA = "0x1878CBE30")]
	public JGPHNPBGJLB GJBLIOBGJNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x78CC390", Offset = "0x78CB790", VA = "0x1878CC390")]
	public void NMOEKOPMDCP(JGPHNPBGJLB CMGADFALJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x78CC090", Offset = "0x78CB490", VA = "0x1878CC090")]
	internal bool HOKDFGMOHEI(JGPHNPBGJLB CMGADFALJEB, [Out] DOEJLFJFHKK GKFIHIFDCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x78CBCB0", Offset = "0x78CB0B0", VA = "0x1878CBCB0")]
	private void GENKFFODDKI(OMJHDNDPLNH HBIDMGFGNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x78CC190", Offset = "0x78CB590", VA = "0x1878CC190")]
	private void MCDOPCKHPEO(int GALJEMGIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x78CBC50", Offset = "0x78CB050", VA = "0x1878CBC50")]
	private bool EFPNEJMOOCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x78C5260", Offset = "0x78C4660", VA = "0x1878C5260")]
	private static int BJMBGEFENEE(JGPHNPBGJLB CMGADFALJEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE150", Offset = "0x1FBD550", VA = "0x181FBE150")]
	private static ushort CAGAJCOHCLM(int CJFNAFNJJLB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x78CB830", Offset = "0x78CAC30", VA = "0x1878CB830")]
	private Bounds BMKFMNICGBO()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x78CBBA0", Offset = "0x78CAFA0", VA = "0x1878CBBA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FEKEFKKADCK
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly FEKEFKKADCK ONDMNMILBDC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float FKFCEDOAIAI = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int JFHLDDAIHAM = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int NKNKOPDGIKH = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color KIFIOOHIKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float KLCFLGKPKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int LLABLHFBNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int MMEDEAEOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int MMEIMCHGNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int OCLBAMJOFPD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x78C94B0", Offset = "0x78C88B0", VA = "0x1878C94B0")]
	internal FEKEFKKADCK NLFBCECALFC()
	{
		return default(FEKEFKKADCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x78C0BE0", Offset = "0x78BFFE0", VA = "0x1878C0BE0")]
	[CompilerGenerated]
	internal static void JLFDHDBEACD(int FFOEEMKIKJO, int PFCPDJEHNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x78C9490", Offset = "0x78C8890", VA = "0x1878C9490")]
	[CompilerGenerated]
	internal static void KDHFGIOPCDA(float FFOEEMKIKJO, float PFCPDJEHNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x78C0BD0", Offset = "0x78BFFD0", VA = "0x1878C0BD0")]
	[CompilerGenerated]
	internal static void DOGLFKGEJLD(int FFOEEMKIKJO, int HAKLHFOLEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x78C9470", Offset = "0x78C8870", VA = "0x1878C9470")]
	[CompilerGenerated]
	internal static void DLFPJEFFMOA(float FFOEEMKIKJO, float HAKLHFOLEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FEHDABKAFMN
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x78C93E0", Offset = "0x78C87E0", VA = "0x1878C93E0")]
	public static float OHDFKLPJDEL(this DOEJLFJFHKK IGILADLLPKA)
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
		public readonly JGPHNPBGJLB textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x78CD5C0", Offset = "0x78CC9C0", VA = "0x1878CD5C0")]
		public TextSegmentLayout(LayoutRect layoutRect, JGPHNPBGJLB textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x78CD390", Offset = "0x78CC790", VA = "0x1878CD390")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x78CD400", Offset = "0x78CC800", VA = "0x1878CD400")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x78CD330", Offset = "0x78CC730", VA = "0x1878CD330")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class GMIHPEKJHIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig ONFJKJAICEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float BIGLNEOOMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float FBHCDMFEAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float DDAOCIILPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float HPGHKPPAMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float EGNOMBAECCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float DHIIPDLPKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float MGCCMDEINIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float EHPOBENKMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float LDDCMEJAEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float DBNCNAAOBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float LKOJAMDIEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float JDOFFNMLLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly INBKIEIEPDH[] DDAMENBBONH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int CEBBLJJPBEN = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private FPNNCINPOBE[] FFKCACEHGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int PMDLGGEOCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private PJPOILPJPIK[] GIHBCOACAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int CBKCJOACLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public INBKIEIEPDH LJACGFPAEKG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x78C9710", Offset = "0x78C8B10", VA = "0x1878C9710")]
	public void BECHPFCMIHE(OOGBBHCMJIJ MJDDHPPLFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x78C9690", Offset = "0x78C8A90", VA = "0x1878C9690")]
	public void BECHPFCMIHE(GlyphUVConfig APHCJCOBBCH, IEnumerable<PJPOILPJPIK> OLJLHIOKIAE, PJPOILPJPIK KKDAJGCGMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x78C97A0", Offset = "0x78C8BA0", VA = "0x1878C97A0")]
	internal void EFMPAFAIKIC(GlyphUVConfig APHCJCOBBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x78C9C10", Offset = "0x78C9010", VA = "0x1878C9C10")]
	private void PLPICJECEOG(IEnumerable<PJPOILPJPIK> OLJLHIOKIAE, PJPOILPJPIK KKDAJGCGMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x78C98E0", Offset = "0x78C8CE0", VA = "0x1878C98E0")]
	public void KCFMCLCJBBB([In] char EHJOKGBPGOL, [Out] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x78C7C50", Offset = "0x78C7050", VA = "0x1878C7C50")]
	private INBKIEIEPDH HLGAKLNEOEF(PJPOILPJPIK ANFAJGEPOPE)
	{
		return default(INBKIEIEPDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x78CA140", Offset = "0x78C9540", VA = "0x1878CA140")]
	public GMIHPEKJHIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class APLPHHCLCEE
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x78C91C0", Offset = "0x78C85C0", VA = "0x1878C91C0")]
	public static void BCKJHFEENGJ([In] float BFOFNBJBCJJ, [In] float LKNDGPAOFIB, [In] int AFHONHHIAFF, [In] int ECDEGOBNOPD, [In] float HPGHKPPAMKK, [In] float EGNOMBAECCG, [In] float JCEMPLAKEFD, [In] float KPMPFMGJKCC, [In] float LGKGADBDBMB, [In] float JHBNFHHJCDO, [Out] float NALOIOFACOC, [Out] float FGOAJNEKNBP, [Out] float LBDALJJEOIG, [Out] float MKCFIMDGBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x78C9290", Offset = "0x78C8690", VA = "0x1878C9290")]
	public static void BCKJHFEENGJ([In] float BFOFNBJBCJJ, [In] float LKNDGPAOFIB, [In] int AFHONHHIAFF, [In] int ECDEGOBNOPD, [Out] float NALOIOFACOC, [Out] float FGOAJNEKNBP, [Out] float LBDALJJEOIG, [Out] float MKCFIMDGBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x78C9160", Offset = "0x78C8560", VA = "0x1878C9160")]
	public static void ADFOONCJDAI([In] float HPGHKPPAMKK, [In] float EGNOMBAECCG, [In] float BLBDPOEGNII, [In] float OEHHOGDIBGF, [In] float LPBJCICMKFD, [In] float BNJKIOILPGG, [Out] float AAMGJDHJMIM, [Out] float NCNDLOJFLHK, [Out] float PCPBELKIKNE, [Out] float FNOBPEANJKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct FPNNCINPOBE
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint CIGALGFEIAM = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char FLPABGFNIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly INBKIEIEPDH AFALGDAEAOG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x78C9670", Offset = "0x78C8A70", VA = "0x1878C9670")]
	public FPNNCINPOBE(char EHJOKGBPGOL, INBKIEIEPDH CJJJIOOAIOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct INBKIEIEPDH
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint CIGALGFEIAM = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] HIHCPAHEDJL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x78CACB0", Offset = "0x78CA0B0", VA = "0x1878CACB0")]
	public INBKIEIEPDH(float NALOIOFACOC, float FGOAJNEKNBP, float LBDALJJEOIG, float MKCFIMDGBFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct OMJHDNDPLNH
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int GGMBNPDPJGC = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal PHMILLAHOAA JILNHIENCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] EINIAKMOLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int ABIDGLOMAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 KCMAPEODNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float ABPMJIEKGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 PFDAFBJDKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool DLBGJIGFLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int DILPHEBNEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int CMIFJJJBLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int FMLBOGNBPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int AIHEFFDJHCK;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x78CB520", Offset = "0x78CA920", VA = "0x1878CB520")]
	public static int EDKEENHNJBM(int PFFFIKAPIKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum PHMILLAHOAA : byte
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
public static class HNNLIPDGJEF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x78CAC70", Offset = "0x78CA070", VA = "0x1878CAC70")]
	internal static float OHDFKLPJDEL(this OMJHDNDPLNH HBIDMGFGNHE, float IHOCHKMACLK, float MCOKOHFLOAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x78CABF0", Offset = "0x78C9FF0", VA = "0x1878CABF0")]
	internal static void MBOCDEEGBMD(this OMJHDNDPLNH HBIDMGFGNHE, float IHOCHKMACLK, float MCOKOHFLOAA, [Out] float2 GCDIMBKCOPF, [Out] float2 IPOFNNMKDAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class ABGKILBNOIE : HBPFOPEAFLB
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int HBJIFKMOEEL = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int NNBIGAOMJNB = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string NHCMIJHKHKN = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker DADGHAPCEJC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker LNHDDDLKADF;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker MMAGGBCHGFL;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker BAOPAJMNDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly PGHHODCEFDE COGEHCHHBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] EFAFPAKMGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] LPONIANEADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int HBOAGLNCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int IOJDOHHKDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int KFHPCKJKPDK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string IGEPDAOOLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public HBPFOPEAFLB.ABCMKCFMAFH FBDKNJHMFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA330", Offset = "0x9A9730", VA = "0x1809AA330", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x78C9050", Offset = "0x78C8450", VA = "0x1878C9050")]
	public ABGKILBNOIE(PGHHODCEFDE.FENNGPOPABI DFIAFMEMJAM, int MAJBODDKDNJ, int FEMDDNDFMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x78C8ED0", Offset = "0x78C82D0", VA = "0x1878C8ED0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] PGHHODCEFDE COGEHCHHBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x78C8230", Offset = "0x78C7630", VA = "0x1878C8230")]
	public void FHKICEOLADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x78C85D0", Offset = "0x78C79D0", VA = "0x1878C85D0")]
	public void PCHFMJELJMI(Span<OMJHDNDPLNH> BNLKFEPMEGD, GMIHPEKJHIC PIEFJJGDLAO, [In] FEKEFKKADCK HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x78C6180", Offset = "0x78C5580", VA = "0x1878C6180")]
	private void GLDLOKKIFED([In] PHMILLAHOAA JILNHIENCIC, [In] OMJHDNDPLNH NOBJDHIBKMD, int IBFMPPHAMIF, [In] float IHOCHKMACLK, [In] float MCOKOHFLOAA, GMIHPEKJHIC PIEFJJGDLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x78C8250", Offset = "0x78C7650", VA = "0x1878C8250")]
	private void GKCMPIDMGOP([In] PHMILLAHOAA JILNHIENCIC, OMJHDNDPLNH NOBJDHIBKMD, [In] int CKEKHCLOGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x78C83A0", Offset = "0x78C77A0", VA = "0x1878C83A0")]
	public static void IMKGCHJNGJP(ReadOnlySpan<OMJHDNDPLNH> BNLKFEPMEGD, int EOONBIDKOHJ, [Out] int FFKEFKLJMDJ, [Out] int FFIOOELOOOC, [Out] int BOOEFFKJBMP)
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
