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
		[Cpp2IlInjected.Address(RVA = "0x787DE20", Offset = "0x787D220", VA = "0x18787DE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x787D4B0", Offset = "0x787C8B0", VA = "0x18787D4B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x787F840", Offset = "0x787EC40", VA = "0x18787F840")]
	public PJPOILPJPIK(char EHJOKGBPGOL, int EAHDNMEJHJG, int KAMEHPKHHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x787F850", Offset = "0x787EC50", VA = "0x18787F850")]
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
		[Cpp2IlInjected.Address(RVA = "0x787CAC0", Offset = "0x787BEC0", VA = "0x18787CAC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x787D3B0", Offset = "0x787C7B0", VA = "0x18787D3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x787D230", Offset = "0x787C630", VA = "0x18787D230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x993A70", Offset = "0x992E70", VA = "0x180993A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x787D220", Offset = "0x787C620", VA = "0x18787D220")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OOGBBHCMJIJ ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x787CC10", Offset = "0x787C010", VA = "0x18787CC10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PJPOILPJPIK FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x787D090", Offset = "0x787C490", VA = "0x18787D090")]
			get
			{
				return default(PJPOILPJPIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x787CB00", Offset = "0x787BF00", VA = "0x18787CB00")]
		internal void JIEDHKAGDDK(IEnumerable<GlyphCoordinateWritable> BEEJLOBMKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x787CB80", Offset = "0x787BF80", VA = "0x18787CB80")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x787CAE0", Offset = "0x787BEE0", VA = "0x18787CAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x787FAA0", Offset = "0x787EEA0", VA = "0x18787FAA0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x787FA50", Offset = "0x787EE50", VA = "0x18787FA50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x787F870", Offset = "0x787EC70", VA = "0x18787F870")]
		private void KCOGKMFKOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x787FB90", Offset = "0x787EF90", VA = "0x18787FB90")]
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
			[Cpp2IlInjected.Address(RVA = "0x787FF10", Offset = "0x787F310", VA = "0x18787FF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PEGDHDFJEOE CPHIMOFOKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x78806A0", Offset = "0x787FAA0", VA = "0x1878806A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material AHMCGEDJOBA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x78806D0", Offset = "0x787FAD0", VA = "0x1878806D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7880600", Offset = "0x787FA00", VA = "0x187880600")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x787FFA0", Offset = "0x787F3A0", VA = "0x18787FFA0", Slot = "8")]
		protected override void BKEKLLLINPN(PFJAGJJBHOM EDPGLLNEELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7880610", Offset = "0x787FA10", VA = "0x187880610", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] PGHHODCEFDE COGEHCHHBIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78804B0", Offset = "0x787F8B0", VA = "0x1878804B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7880190", Offset = "0x787F590", VA = "0x187880190")]
		private void FOPNEDKNBLE(bool HLPBIKLHEBD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B1160", Offset = "0x9B0560", VA = "0x1809B1160")]
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
	[Cpp2IlInjected.Address(RVA = "0x787BC70", Offset = "0x787B070", VA = "0x18787BC70")]
	internal OMJHDNDPLNH DIPEAHDGEMD()
	{
		return default(OMJHDNDPLNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2668BD0", Offset = "0x2667FD0", VA = "0x182668BD0")]
	internal DOEJLFJFHKK(PEGDHDFJEOE HEKFIEJNOCO, int PDODKHCOAOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BHGDHNLOBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x787BBE0", Offset = "0x787AFE0", VA = "0x18787BBE0")]
	public static bool GNJLKJGFHOO(this DOEJLFJFHKK GKFIHIFDCIH, PHMILLAHOAA OPGENLKKICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x787BBC0", Offset = "0x787AFC0", VA = "0x18787BBC0")]
	internal static bool GNJLKJGFHOO(this OMJHDNDPLNH HBIDMGFGNHE, PHMILLAHOAA OPGENLKKICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x787BC30", Offset = "0x787B030", VA = "0x18787BC30")]
	public static float LBHIOCDPGJB(this DOEJLFJFHKK GKFIHIFDCIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC85350", Offset = "0xC84750", VA = "0x180C85350")]
	internal static float LBHIOCDPGJB(this OMJHDNDPLNH HBIDMGFGNHE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NGFIKKMJMEE
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x787DA20", Offset = "0x787CE20", VA = "0x18787DA20")]
	public static void CKCCEOHPMEG(this DOEJLFJFHKK GKFIHIFDCIH, ReadOnlySpan<char> CACPHIIDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x787DA70", Offset = "0x787CE70", VA = "0x18787DA70")]
	internal static void CKCCEOHPMEG(this OMJHDNDPLNH HBIDMGFGNHE, ReadOnlySpan<char> CACPHIIDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x787DDB0", Offset = "0x787D1B0", VA = "0x18787DDB0")]
	public static void MKDGDHAOHGI(this DOEJLFJFHKK AKNAKHLGBNH, float2 KCMAPEODNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x787DDA0", Offset = "0x787D1A0", VA = "0x18787DDA0")]
	internal static void MKDGDHAOHGI(this OMJHDNDPLNH HBIDMGFGNHE, float2 KCMAPEODNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x787D9B0", Offset = "0x787CDB0", VA = "0x18787D9B0")]
	public static void CFIAPDMABFA(this DOEJLFJFHKK AKNAKHLGBNH, float LDMDDNPOEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x787D970", Offset = "0x787CD70", VA = "0x18787D970")]
	internal static void CFIAPDMABFA(this OMJHDNDPLNH HBIDMGFGNHE, float LDMDDNPOEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x787DE00", Offset = "0x787D200", VA = "0x18787DE00")]
	internal static void OMAFMCCAOCM(this OMJHDNDPLNH HBIDMGFGNHE, bool DLBGJIGFLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x787DC70", Offset = "0x787D070", VA = "0x18787DC70")]
	public static void DMFBDFFBKIN(this DOEJLFJFHKK AKNAKHLGBNH, Color32 ODFBFMBMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x787DCB0", Offset = "0x787D0B0", VA = "0x18787DCB0")]
	internal static void DMFBDFFBKIN(this OMJHDNDPLNH HBIDMGFGNHE, Color32 ODFBFMBMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x787DD40", Offset = "0x787D140", VA = "0x18787DD40")]
	public static void LCOHFCLEJIM(this DOEJLFJFHKK AKNAKHLGBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x787DD30", Offset = "0x787D130", VA = "0x18787DD30")]
	internal static void LCOHFCLEJIM(this OMJHDNDPLNH HBIDMGFGNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x787DCC0", Offset = "0x787D0C0", VA = "0x18787DCC0")]
	internal static void KACJHEFOKNF(this OMJHDNDPLNH HBIDMGFGNHE, int KGCONEINMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x787DD80", Offset = "0x787D180", VA = "0x18787DD80")]
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
		[Cpp2IlInjected.Address(RVA = "0xB8E440", Offset = "0xB8D840", VA = "0x180B8E440")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB8E450", Offset = "0xB8D850", VA = "0x180B8E450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PEGDHDFJEOE HHDFOEAIKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PNPLPCMDCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7872530", Offset = "0x7871930", VA = "0x187872530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7872670", Offset = "0x7871A70", VA = "0x187872670")]
	public JGPHNPBGJLB(int ABNIIFJMBDG, PEGDHDFJEOE HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x787D810", Offset = "0x787CC10", VA = "0x18787D810")]
	public bool JGGNMKINNDK([Out] DOEJLFJFHKK GKFIHIFDCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x787D750", Offset = "0x787CB50", VA = "0x18787D750")]
	public void FEMKONHLAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x78725B0", Offset = "0x78719B0", VA = "0x1878725B0")]
	internal void NIDGFIKCINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7872410", Offset = "0x7871810", VA = "0x187872410", Slot = "4")]
	public bool Equals(JGPHNPBGJLB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x787D690", Offset = "0x787CA90", VA = "0x18787D690", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x787D7A0", Offset = "0x787CBA0", VA = "0x18787D7A0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x787F000", Offset = "0x787E400", VA = "0x18787F000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OOGBBHCMJIJ DCEMKOEBGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x787DFC0", Offset = "0x787D3C0", VA = "0x18787DFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JDOFFNMLLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x787DFA0", Offset = "0x787D3A0", VA = "0x18787DFA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float DBNCNAAOBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x787EC80", Offset = "0x787E080", VA = "0x18787EC80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HBPFOPEAFLB.ABCMKCFMAFH FBDKNJHMFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x993AB0", Offset = "0x992EB0", VA = "0x180993AB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x993A60", Offset = "0x992E60", VA = "0x180993A60", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x787F3B0", Offset = "0x787E7B0", VA = "0x18787F3B0")]
	public PEGDHDFJEOE(FEKEFKKADCK HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x787F330", Offset = "0x787E730", VA = "0x18787F330")]
	public PEGDHDFJEOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x787E0F0", Offset = "0x787D4F0", VA = "0x18787E0F0")]
	public void BECHPFCMIHE(GlyphMapAsset OLJLHIOKIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x787DFE0", Offset = "0x787D3E0", VA = "0x18787DFE0")]
	public void BECHPFCMIHE(OOGBBHCMJIJ EKJGAENMCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x787F090", Offset = "0x787E490", VA = "0x18787F090", Slot = "6")]
	public bool TryGetMeshBuffer([Out] PGHHODCEFDE COGEHCHHBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x787E440", Offset = "0x787D840", VA = "0x18787E440")]
	public void DMAIFOODLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x787EA50", Offset = "0x787DE50", VA = "0x18787EA50")]
	public bool KGPDMBEFHGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x787E730", Offset = "0x787DB30", VA = "0x18787E730")]
	public JGPHNPBGJLB GJBLIOBGJNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x787ECA0", Offset = "0x787E0A0", VA = "0x18787ECA0")]
	public void NMOEKOPMDCP(JGPHNPBGJLB CMGADFALJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x787E9A0", Offset = "0x787DDA0", VA = "0x18787E9A0")]
	internal bool HOKDFGMOHEI(JGPHNPBGJLB CMGADFALJEB, [Out] DOEJLFJFHKK GKFIHIFDCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x787E5B0", Offset = "0x787D9B0", VA = "0x18787E5B0")]
	private void GENKFFODDKI(OMJHDNDPLNH HBIDMGFGNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x787EAA0", Offset = "0x787DEA0", VA = "0x18787EAA0")]
	private void MCDOPCKHPEO(int GALJEMGIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x787E550", Offset = "0x787D950", VA = "0x18787E550")]
	private bool EFPNEJMOOCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7877D80", Offset = "0x7877180", VA = "0x187877D80")]
	private static int BJMBGEFENEE(JGPHNPBGJLB CMGADFALJEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0E80", Offset = "0x1FB0280", VA = "0x181FB0E80")]
	private static ushort CAGAJCOHCLM(int CJFNAFNJJLB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x787E130", Offset = "0x787D530", VA = "0x18787E130")]
	private Bounds BMKFMNICGBO()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x787E4A0", Offset = "0x787D8A0", VA = "0x18787E4A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x787BD80", Offset = "0x787B180", VA = "0x18787BD80")]
	internal FEKEFKKADCK NLFBCECALFC()
	{
		return default(FEKEFKKADCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7873910", Offset = "0x7872D10", VA = "0x187873910")]
	[CompilerGenerated]
	internal static void JLFDHDBEACD(int FFOEEMKIKJO, int PFCPDJEHNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x787BD60", Offset = "0x787B160", VA = "0x18787BD60")]
	[CompilerGenerated]
	internal static void KDHFGIOPCDA(float FFOEEMKIKJO, float PFCPDJEHNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7873900", Offset = "0x7872D00", VA = "0x187873900")]
	[CompilerGenerated]
	internal static void DOGLFKGEJLD(int FFOEEMKIKJO, int HAKLHFOLEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x787BD40", Offset = "0x787B140", VA = "0x18787BD40")]
	[CompilerGenerated]
	internal static void DLFPJEFFMOA(float FFOEEMKIKJO, float HAKLHFOLEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FEHDABKAFMN
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x787BCB0", Offset = "0x787B0B0", VA = "0x18787BCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x787FEA0", Offset = "0x787F2A0", VA = "0x18787FEA0")]
		public TextSegmentLayout(LayoutRect layoutRect, JGPHNPBGJLB textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x787FC70", Offset = "0x787F070", VA = "0x18787FC70")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x787FCE0", Offset = "0x787F0E0", VA = "0x18787FCE0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x787FC10", Offset = "0x787F010", VA = "0x18787FC10")]
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
	[Cpp2IlInjected.Address(RVA = "0x787BFE0", Offset = "0x787B3E0", VA = "0x18787BFE0")]
	public void BECHPFCMIHE(OOGBBHCMJIJ MJDDHPPLFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x787BF60", Offset = "0x787B360", VA = "0x18787BF60")]
	public void BECHPFCMIHE(GlyphUVConfig APHCJCOBBCH, IEnumerable<PJPOILPJPIK> OLJLHIOKIAE, PJPOILPJPIK KKDAJGCGMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x787C070", Offset = "0x787B470", VA = "0x18787C070")]
	internal void EFMPAFAIKIC(GlyphUVConfig APHCJCOBBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x787C4E0", Offset = "0x787B8E0", VA = "0x18787C4E0")]
	private void PLPICJECEOG(IEnumerable<PJPOILPJPIK> OLJLHIOKIAE, PJPOILPJPIK KKDAJGCGMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x787C1B0", Offset = "0x787B5B0", VA = "0x18787C1B0")]
	public void KCFMCLCJBBB([In] char EHJOKGBPGOL, [Out] float2[] CJJJIOOAIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x787A650", Offset = "0x7879A50", VA = "0x18787A650")]
	private INBKIEIEPDH HLGAKLNEOEF(PJPOILPJPIK ANFAJGEPOPE)
	{
		return default(INBKIEIEPDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x787CA20", Offset = "0x787BE20", VA = "0x18787CA20")]
	public GMIHPEKJHIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class APLPHHCLCEE
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x787BA90", Offset = "0x787AE90", VA = "0x18787BA90")]
	public static void BCKJHFEENGJ([In] float BFOFNBJBCJJ, [In] float LKNDGPAOFIB, [In] int AFHONHHIAFF, [In] int ECDEGOBNOPD, [In] float HPGHKPPAMKK, [In] float EGNOMBAECCG, [In] float JCEMPLAKEFD, [In] float KPMPFMGJKCC, [In] float LGKGADBDBMB, [In] float JHBNFHHJCDO, [Out] float NALOIOFACOC, [Out] float FGOAJNEKNBP, [Out] float LBDALJJEOIG, [Out] float MKCFIMDGBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x787BB60", Offset = "0x787AF60", VA = "0x18787BB60")]
	public static void BCKJHFEENGJ([In] float BFOFNBJBCJJ, [In] float LKNDGPAOFIB, [In] int AFHONHHIAFF, [In] int ECDEGOBNOPD, [Out] float NALOIOFACOC, [Out] float FGOAJNEKNBP, [Out] float LBDALJJEOIG, [Out] float MKCFIMDGBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x787BA30", Offset = "0x787AE30", VA = "0x18787BA30")]
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
	[Cpp2IlInjected.Address(RVA = "0x787BF40", Offset = "0x787B340", VA = "0x18787BF40")]
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
	[Cpp2IlInjected.Address(RVA = "0x787D5A0", Offset = "0x787C9A0", VA = "0x18787D5A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x787DE10", Offset = "0x787D210", VA = "0x18787DE10")]
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
	[Cpp2IlInjected.Address(RVA = "0x787D560", Offset = "0x787C960", VA = "0x18787D560")]
	internal static float OHDFKLPJDEL(this OMJHDNDPLNH HBIDMGFGNHE, float IHOCHKMACLK, float MCOKOHFLOAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x787D4E0", Offset = "0x787C8E0", VA = "0x18787D4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x994360", Offset = "0x993760", VA = "0x180994360", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x787B920", Offset = "0x787AD20", VA = "0x18787B920")]
	public ABGKILBNOIE(PGHHODCEFDE.FENNGPOPABI DFIAFMEMJAM, int MAJBODDKDNJ, int FEMDDNDFMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x787B790", Offset = "0x787AB90", VA = "0x18787B790", Slot = "5")]
	public bool TryGetMeshBuffer([Out] PGHHODCEFDE COGEHCHHBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x787AC30", Offset = "0x787A030", VA = "0x18787AC30")]
	public void FHKICEOLADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x787AFB0", Offset = "0x787A3B0", VA = "0x18787AFB0")]
	public void PCHFMJELJMI(Span<OMJHDNDPLNH> BNLKFEPMEGD, GMIHPEKJHIC PIEFJJGDLAO, [In] FEKEFKKADCK HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7878CC0", Offset = "0x78780C0", VA = "0x187878CC0")]
	private void GLDLOKKIFED([In] PHMILLAHOAA JILNHIENCIC, [In] OMJHDNDPLNH NOBJDHIBKMD, int IBFMPPHAMIF, [In] float IHOCHKMACLK, [In] float MCOKOHFLOAA, GMIHPEKJHIC PIEFJJGDLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x787AC50", Offset = "0x787A050", VA = "0x18787AC50")]
	private void GKCMPIDMGOP([In] PHMILLAHOAA JILNHIENCIC, OMJHDNDPLNH NOBJDHIBKMD, [In] int CKEKHCLOGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x787ADA0", Offset = "0x787A1A0", VA = "0x18787ADA0")]
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
