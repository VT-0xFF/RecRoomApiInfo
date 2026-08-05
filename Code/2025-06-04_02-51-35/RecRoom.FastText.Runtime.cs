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
public class HPHMOICDMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D LFMCANGLGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig NMLFMIJEIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ACHHBJLBAOD[] JOMJNPPMNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ACHHBJLBAOD DHACNINKNHF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static HPHMOICDMCE FPJCMKPLCDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HPHMOICDMCE LLCLJEFFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F97A20", Offset = "0x7F96220", VA = "0x187F97A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HPHMOICDMCE()
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
		[Cpp2IlInjected.Address(RVA = "0x7F979F0", Offset = "0x7F961F0", VA = "0x187F979F0")]
		public GlyphUVConfig(int BKKNFECAGMO, int BIDFMKFPBHD, int FLDAFGHDPFD, int EACBEKEMGJD, float AHDIAKPGGIK = 0f, [Optional] GlyphPixelInset MOBDOKACIDD)
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
public readonly struct ACHHBJLBAOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char KIONHAAIPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int EBNHPFNJNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int KBKFGIJHBFJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly ACHHBJLBAOD AAFEIFFJCFI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F95660", Offset = "0x7F93E60", VA = "0x187F95660")]
	public ACHHBJLBAOD(char MPMEIFBBFOD, int FFFJNOKAKFA, int FLCFBNHKLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F95670", Offset = "0x7F93E70", VA = "0x187F95670")]
	public ACHHBJLBAOD(GlyphCoordinateWritable NNIICJLNAMI)
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
		[Cpp2IlInjected.Address(RVA = "0x7F97010", Offset = "0x7F95810", VA = "0x187F97010")]
		public static ACHHBJLBAOD KEINEINMKGA(GlyphCoordinateWritable GJJIDOPGHFC)
		{
			return default(ACHHBJLBAOD);
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
		private HPHMOICDMCE configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7F978F0", Offset = "0x7F960F0", VA = "0x187F978F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F97770", Offset = "0x7F95F70", VA = "0x187F97770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7F97760", Offset = "0x7F95F60", VA = "0x187F97760")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HPHMOICDMCE ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F97160", Offset = "0x7F95960", VA = "0x187F97160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ACHHBJLBAOD FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F975D0", Offset = "0x7F95DD0", VA = "0x187F975D0")]
			get
			{
				return default(ACHHBJLBAOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F97050", Offset = "0x7F95850", VA = "0x187F97050")]
		internal void PPIJEDILCBK(IEnumerable<GlyphCoordinateWritable> GBOBCOLMPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F970D0", Offset = "0x7F958D0", VA = "0x187F970D0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F97030", Offset = "0x7F95830", VA = "0x187F97030")]
		[CompilerGenerated]
		private bool INHGBKBPELB(GlyphCoordinateWritable GJJIDOPGHFC)
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
		private TextSegmentMeshBufferSource OFIFMJAEPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private FKBFPHGCEMH NLMEBIMIMMC;

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
		private KFCKCJJLEGN FNOAGHOBDFB;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A5A0", Offset = "0x7F98DA0", VA = "0x187F9A5A0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A550", Offset = "0x7F98D50", VA = "0x187F9A550")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A370", Offset = "0x7F98B70", VA = "0x187F9A370")]
		private void IABFGKEHCNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A690", Offset = "0x7F98E90", VA = "0x187F9A690")]
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
		private bool KPIEOKBACHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material GALMCJCIHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private FKBFPHGCEMH NLMEBIMIMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material PEPOGFFIEPH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private HPHMOICDMCE LAEPGJGBMOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7F9AA10", Offset = "0x7F99210", VA = "0x187F9AA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FKBFPHGCEMH AKCDMGDNNFH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7F9B180", Offset = "0x7F99980", VA = "0x187F9B180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material ENDDMGHILNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F9B1B0", Offset = "0x7F999B0", VA = "0x187F9B1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B0E0", Offset = "0x7F998E0", VA = "0x187F9B0E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F9AAA0", Offset = "0x7F992A0", VA = "0x187F9AAA0", Slot = "8")]
		protected override void CCOMPBKIEGG(MEJGKDDGJBC BNMEJFOCEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B0F0", Offset = "0x7F998F0", VA = "0x187F9B0F0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] CDHAEKAEOPK LLOAFJJGBGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F9AF90", Offset = "0x7F99790", VA = "0x187F9AF90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F9AC70", Offset = "0x7F99470", VA = "0x187F9AC70")]
		private void GOFPFMHCMCA(bool IBCIAMDAPFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA45940", Offset = "0xA44140", VA = "0x180A45940")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct KLKCMGLOCDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly FKBFPHGCEMH EKLGCNIGLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int CHJGKNADECL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F99BB0", Offset = "0x7F983B0", VA = "0x187F99BB0")]
	internal PJJOBFFNJLE KKPGKCKLGCD()
	{
		return default(PJJOBFFNJLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2870710", Offset = "0x286EF10", VA = "0x182870710")]
	internal KLKCMGLOCDO(FKBFPHGCEMH EGOJLGMOLFK, int CGNHJFAIKAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MJLBOENKKOL
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A180", Offset = "0x7F98980", VA = "0x187F9A180")]
	public static bool MLKIKMFGLMC(this KLKCMGLOCDO HOLBPJLGONI, FEKHCMGPLHP CMJCPGBPHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A160", Offset = "0x7F98960", VA = "0x187F9A160")]
	internal static bool MLKIKMFGLMC(this PJJOBFFNJLE JBODACPIOEI, FEKHCMGPLHP CMJCPGBPHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A120", Offset = "0x7F98920", VA = "0x187F9A120")]
	public static float ACIEIDGLHHK(this KLKCMGLOCDO HOLBPJLGONI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xDD27A0", Offset = "0xDD0FA0", VA = "0x180DD27A0")]
	internal static float ACIEIDGLHHK(this PJJOBFFNJLE JBODACPIOEI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LAMOANCJNPD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F99D00", Offset = "0x7F98500", VA = "0x187F99D00")]
	public static void IBCOIKGOLCK(this KLKCMGLOCDO HOLBPJLGONI, ReadOnlySpan<char> BGFKDPNLPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F99D50", Offset = "0x7F98550", VA = "0x187F99D50")]
	internal static void IBCOIKGOLCK(this PJJOBFFNJLE JBODACPIOEI, ReadOnlySpan<char> BGFKDPNLPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F99CB0", Offset = "0x7F984B0", VA = "0x187F99CB0")]
	public static void GHOBABLHKAO(this KLKCMGLOCDO HHHCBLPPLCK, float2 PDKCDGNAGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F99CA0", Offset = "0x7F984A0", VA = "0x187F99CA0")]
	internal static void GHOBABLHKAO(this PJJOBFFNJLE JBODACPIOEI, float2 PDKCDGNAGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F99F70", Offset = "0x7F98770", VA = "0x187F99F70")]
	public static void KBNMGCHMGLJ(this KLKCMGLOCDO HHHCBLPPLCK, float OHIAFEEACMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F99FE0", Offset = "0x7F987E0", VA = "0x187F99FE0")]
	internal static void KBNMGCHMGLJ(this PJJOBFFNJLE JBODACPIOEI, float OHIAFEEACMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F99BF0", Offset = "0x7F983F0", VA = "0x187F99BF0")]
	internal static void AFGEFJMAJOG(this PJJOBFFNJLE JBODACPIOEI, bool GCMAFHACNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F99C60", Offset = "0x7F98460", VA = "0x187F99C60")]
	public static void COPEJGMAPIM(this KLKCMGLOCDO HHHCBLPPLCK, Color32 BIKIHAKPCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F99C50", Offset = "0x7F98450", VA = "0x187F99C50")]
	internal static void COPEJGMAPIM(this PJJOBFFNJLE JBODACPIOEI, Color32 BIKIHAKPCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F99C00", Offset = "0x7F98400", VA = "0x187F99C00")]
	public static void BMNJLBPONPD(this KLKCMGLOCDO HHHCBLPPLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F99C40", Offset = "0x7F98440", VA = "0x187F99C40")]
	internal static void BMNJLBPONPD(this PJJOBFFNJLE JBODACPIOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A020", Offset = "0x7F98820", VA = "0x187F9A020")]
	internal static void MIEHIBAHCEB(this PJJOBFFNJLE JBODACPIOEI, int FDKEBALIAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F99F50", Offset = "0x7F98750", VA = "0x187F99F50")]
	internal static void KBFEILKFFKI(this PJJOBFFNJLE JBODACPIOEI, int DJCBLLLDCDN, FEKHCMGPLHP AAAPPCFDJJD = FEKHCMGPLHP.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KFCKCJJLEGN : IEquatable<KFCKCJJLEGN>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort LGIHHNGGLLN = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int JPIDEONPNGP = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly KFCKCJJLEGN HHJBHJGPFKL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort HOHGKJENMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xCBE090", Offset = "0xCBC890", VA = "0x180CBE090")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCBE0A0", Offset = "0xCBC8A0", VA = "0x180CBE0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FKBFPHGCEMH EKLGCNIGLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KBFIABEIPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8FDD0", Offset = "0x7F8E5D0", VA = "0x187F8FDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FF30", Offset = "0x7F8E730", VA = "0x187F8FF30")]
	public KFCKCJJLEGN(int NNBGBGGGAAO, FKBFPHGCEMH EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F99A50", Offset = "0x7F98250", VA = "0x187F99A50")]
	public bool OOJOMIPHPDI([Out] KLKCMGLOCDO HOLBPJLGONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F99A00", Offset = "0x7F98200", VA = "0x187F99A00")]
	public void NJIHLBBHOIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FDA0", Offset = "0x7F8E5A0", VA = "0x187F8FDA0")]
	internal void IKNFOJGCJKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FCD0", Offset = "0x7F8E4D0", VA = "0x187F8FCD0", Slot = "4")]
	public bool Equals(KFCKCJJLEGN KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F998D0", Offset = "0x7F980D0", VA = "0x187F998D0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F99990", Offset = "0x7F98190", VA = "0x187F99990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FKBFPHGCEMH : IDisposable, IEMNGFHJIPG
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string FPEKFAMIHEA = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker JLACDGGHCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string IFCDCCBLLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly JGONAHAONCC OKMIOCDLGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int HCPPAJNLABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal PJJOBFFNJLE[] GMDAIIPKNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal KFCKCJJLEGN[] DLOBLMMFAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private HPHMOICDMCE FOHEMIODNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly IGJFPMLEDOP HODEIPHALGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly IMBANJECMOK NEPJIMMHCEG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string HPANEBBHGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F96040", Offset = "0x7F94840", VA = "0x187F96040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HPHMOICDMCE FADHFFJNMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F96800", Offset = "0x7F95000", VA = "0x187F96800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float KPAEKKOOKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F967C0", Offset = "0x7F94FC0", VA = "0x187F967C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float FJJHMBCOMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7F967E0", Offset = "0x7F94FE0", VA = "0x187F967E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IEMNGFHJIPG.HEMIDDNHCBI NAHOEBCIBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA274A0", Offset = "0xA25CA0", VA = "0x180A274A0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F96B50", Offset = "0x7F95350", VA = "0x187F96B50")]
	public FKBFPHGCEMH(JGONAHAONCC LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F96F90", Offset = "0x7F95790", VA = "0x187F96F90")]
	public FKBFPHGCEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F961E0", Offset = "0x7F949E0", VA = "0x187F961E0")]
	public void HNPKBJNJFKN(GlyphMapAsset OBODLLAOLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F960D0", Offset = "0x7F948D0", VA = "0x187F960D0")]
	public void HNPKBJNJFKN(HPHMOICDMCE CLDCCHIABHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F96880", Offset = "0x7F95080", VA = "0x187F96880", Slot = "6")]
	public bool TryGetMeshBuffer([Out] CDHAEKAEOPK LLOAFJJGBGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F96820", Offset = "0x7F95020", VA = "0x187F96820")]
	public void PDJDPEENCDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F95CE0", Offset = "0x7F944E0", VA = "0x187F95CE0")]
	public bool CPBIAOKKNLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F95D30", Offset = "0x7F94530", VA = "0x187F95D30")]
	public KFCKCJJLEGN DHDHOAABJMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F96280", Offset = "0x7F94A80", VA = "0x187F96280")]
	public void JAHHPFPNLNG(KFCKCJJLEGN CFOPPCHFMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F95C30", Offset = "0x7F94430", VA = "0x187F95C30")]
	internal bool CCDODFHIFGD(KFCKCJJLEGN CFOPPCHFMFE, [Out] KLKCMGLOCDO HOLBPJLGONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F957A0", Offset = "0x7F93FA0", VA = "0x187F957A0")]
	private void BANOLGIFPGO(PJJOBFFNJLE JBODACPIOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F965E0", Offset = "0x7F94DE0", VA = "0x187F965E0")]
	private void JOINNBNKHNM(int NCFKFPILLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F96220", Offset = "0x7F94A20", VA = "0x187F96220")]
	private bool IHDPGDMLLNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F400", Offset = "0x7F8DC00", VA = "0x187F8F400")]
	private static int ECHIEKDDBAI(KFCKCJJLEGN CFOPPCHFMFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x231C990", Offset = "0x231B190", VA = "0x18231C990")]
	private static ushort GIENABNLIAE(int PNJCJGEIDHG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F95920", Offset = "0x7F94120", VA = "0x187F95920")]
	private Bounds BBKCLIBLLAG()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F95F90", Offset = "0x7F94790", VA = "0x187F95F90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JGONAHAONCC
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JGONAHAONCC AFHGPFHCIKP;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float KFJJLONIJDF = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int OABFPCNCBBI = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int ELMGEMMJAOB = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color PKOANLEAJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float JBFNAMBEHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int AFMABOMOOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int KLEMPLIEGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int OLBAANMOELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int MGDNJBMKEPF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F996D0", Offset = "0x7F97ED0", VA = "0x187F996D0")]
	internal JGONAHAONCC ANEPIKINAPO()
	{
		return default(JGONAHAONCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F934A0", Offset = "0x7F91CA0", VA = "0x187F934A0")]
	[CompilerGenerated]
	internal static void CMKOIBBPLMN(int MGONBEDEDON, int GJPLADDCFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F997E0", Offset = "0x7F97FE0", VA = "0x187F997E0")]
	[CompilerGenerated]
	internal static void HFJFCNLCINI(float MGONBEDEDON, float GJPLADDCFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F933F0", Offset = "0x7F91BF0", VA = "0x187F933F0")]
	[CompilerGenerated]
	internal static void LBHLJOMKFDC(int MGONBEDEDON, int IKJKPKIILMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F99800", Offset = "0x7F98000", VA = "0x187F99800")]
	[CompilerGenerated]
	internal static void JOFHNACFEAK(float MGONBEDEDON, float IKJKPKIILMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MIDNFLHDEKG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A090", Offset = "0x7F98890", VA = "0x187F9A090")]
	public static float KIMMFPFOPHN(this KLKCMGLOCDO MMCBANBENAB)
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
		public readonly KFCKCJJLEGN textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A9A0", Offset = "0x7F991A0", VA = "0x187F9A9A0")]
		public TextSegmentLayout(LayoutRect layoutRect, KFCKCJJLEGN textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A770", Offset = "0x7F98F70", VA = "0x187F9A770")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A7E0", Offset = "0x7F98FE0", VA = "0x187F9A7E0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A710", Offset = "0x7F98F10", VA = "0x187F9A710")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class IGJFPMLEDOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig LHNJJKMCPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float EBEONDHMCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float POHIHGPAMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float HFGINPENCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float OONMFJANOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float AJHCGBMMOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float NMPALCFIPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float GKAOJILICCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float BHIDAJAGCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float KKBEONCIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float FJJHMBCOMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float JOMECEFBGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float KPAEKKOOKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ANEIPIMHLFE[] KDDBFJIMCNK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int JFOFBFHBJGN = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private EMCAFBBDHKD[] MOFKHJFGOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int JGCBPKBEGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private ACHHBJLBAOD[] CJDDFAGKHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int JFPGKBHALJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public ANEIPIMHLFE ADEFENOMEDJ;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F985B0", Offset = "0x7F96DB0", VA = "0x187F985B0")]
	public void HNPKBJNJFKN(HPHMOICDMCE HICEFHPJDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F98530", Offset = "0x7F96D30", VA = "0x187F98530")]
	public void HNPKBJNJFKN(GlyphUVConfig PHNFGMOCDBN, IEnumerable<ACHHBJLBAOD> OBODLLAOLOB, ACHHBJLBAOD IMDIGDBJEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F97EC0", Offset = "0x7F966C0", VA = "0x187F97EC0")]
	internal void BMNPNNHOFBL(GlyphUVConfig PHNFGMOCDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F98000", Offset = "0x7F96800", VA = "0x187F98000")]
	private void DCMBCFAEPKI(IEnumerable<ACHHBJLBAOD> OBODLLAOLOB, ACHHBJLBAOD IMDIGDBJEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F97B90", Offset = "0x7F96390", VA = "0x187F97B90")]
	public void AMDAOJPGJMA([In] char MPMEIFBBFOD, [Out] float2[] HEKNKNMGNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F939C0", Offset = "0x7F921C0", VA = "0x187F939C0")]
	private ANEIPIMHLFE CFCCNAMICBK(ACHHBJLBAOD NNIICJLNAMI)
	{
		return default(ANEIPIMHLFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F98640", Offset = "0x7F96E40", VA = "0x187F98640")]
	public IGJFPMLEDOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NBDNAGLLMPG
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A230", Offset = "0x7F98A30", VA = "0x187F9A230")]
	public static void ICCAHEHCDGK([In] float GJANMFOLKDH, [In] float LLKLCONADCM, [In] int ICGIJDLHKGH, [In] int FCALNMFAMDE, [In] float OONMFJANOGN, [In] float AJHCGBMMOKF, [In] float ALHCHGGDCFB, [In] float MEAJNPHIJPH, [In] float JOCNLBNPBHF, [In] float IHENPGMNINN, [Out] float EDIKOKIPFIB, [Out] float GBGMOPAEKJJ, [Out] float GHOLJMOCAEE, [Out] float DOONJALHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A1D0", Offset = "0x7F989D0", VA = "0x187F9A1D0")]
	public static void ICCAHEHCDGK([In] float GJANMFOLKDH, [In] float LLKLCONADCM, [In] int ICGIJDLHKGH, [In] int FCALNMFAMDE, [Out] float EDIKOKIPFIB, [Out] float GBGMOPAEKJJ, [Out] float GHOLJMOCAEE, [Out] float DOONJALHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A300", Offset = "0x7F98B00", VA = "0x187F9A300")]
	public static void IIDOBMJMKOE([In] float OONMFJANOGN, [In] float AJHCGBMMOKF, [In] float HFBIBKINKHO, [In] float OILEHIPHKEI, [In] float PAEBJJOFJNC, [In] float JFOAKOEEOIO, [Out] float KALCNMNHOBD, [Out] float GJBJLGLEHML, [Out] float EHBHFCIHNLF, [Out] float OCHNDKMFLIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct EMCAFBBDHKD
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint NNNLLBBCBAA = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char KIONHAAIPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly ANEIPIMHLFE HEKOOIFNFGO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7F95780", Offset = "0x7F93F80", VA = "0x187F95780")]
	public EMCAFBBDHKD(char MPMEIFBBFOD, ANEIPIMHLFE HEKNKNMGNBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct ANEIPIMHLFE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint NNNLLBBCBAA = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] ALBHBIKMHNB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F95690", Offset = "0x7F93E90", VA = "0x187F95690")]
	public ANEIPIMHLFE(float EDIKOKIPFIB, float GBGMOPAEKJJ, float GHOLJMOCAEE, float DOONJALHONK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct PJJOBFFNJLE
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int LCBOEIOBFLB = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal FEKHCMGPLHP AAAPPCFDJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] DFECFOODFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int BDPLGEGCMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 PDKCDGNAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float GKADJHDKBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 HOCMBOIACNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool GCMAFHACNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int FBKMIKJABEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int MIKLIPEEJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int ONAJOIOBKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int GAMOACECBIJ;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A360", Offset = "0x7F98B60", VA = "0x187F9A360")]
	public static int FLHOHPKMNFM(int CKEPBOGHBPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum FEKHCMGPLHP : byte
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
public static class IPPEPKLNEAD
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F99690", Offset = "0x7F97E90", VA = "0x187F99690")]
	internal static float KIMMFPFOPHN(this PJJOBFFNJLE JBODACPIOEI, float DNKMCFAKMPJ, float OKHBFAHMFCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F99610", Offset = "0x7F97E10", VA = "0x187F99610")]
	internal static void FHEOGLHGHGK(this PJJOBFFNJLE JBODACPIOEI, float DNKMCFAKMPJ, float OKHBFAHMFCB, [Out] float2 EDBIKCGPICF, [Out] float2 PIMEBNLNKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class IMBANJECMOK : IEMNGFHJIPG
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int HCDACDEKELG = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int OAAHEMNMCAM = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string FPEKFAMIHEA = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker DJIMALPBKJF;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker LJHELKIKHOM;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker DODIHOAGHDD;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker GNDDBEBPHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly CDHAEKAEOPK LLOAFJJGBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] GMPNPBDJOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] CHIEFFOIHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int LACEFPADPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int OGAPELIJFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int DIIDKDKDCHK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string HPANEBBHGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IEMNGFHJIPG.HEMIDDNHCBI NAHOEBCIBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F99500", Offset = "0x7F97D00", VA = "0x187F99500")]
	public IMBANJECMOK(CDHAEKAEOPK.EEFGFFOELEN GFLLFJEDPOJ, int DMJLNGKPBPK, int OGOHKKEEGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F99380", Offset = "0x7F97B80", VA = "0x187F99380", Slot = "5")]
	public bool TryGetMeshBuffer([Out] CDHAEKAEOPK LLOAFJJGBGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F99360", Offset = "0x7F97B60", VA = "0x187F99360")]
	public void OEIEMACOEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F986E0", Offset = "0x7F96EE0", VA = "0x187F986E0")]
	public void BDHHBLDAGOM(Span<PJJOBFFNJLE> GFCHIIKNCDG, IGJFPMLEDOP EKODPNMNJNC, [In] JGONAHAONCC LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F945A0", Offset = "0x7F92DA0", VA = "0x187F945A0")]
	private void KPIJIHCLOGD([In] FEKHCMGPLHP AAAPPCFDJJD, [In] PJJOBFFNJLE EPJHMIAJJEL, int LHPFBMKHKEO, [In] float DNKMCFAKMPJ, [In] float OKHBFAHMFCB, IGJFPMLEDOP EKODPNMNJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F99210", Offset = "0x7F97A10", VA = "0x187F99210")]
	private void EFLILHANOHK([In] FEKHCMGPLHP AAAPPCFDJJD, PJJOBFFNJLE EPJHMIAJJEL, [In] int GBGEGFGNBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F98FE0", Offset = "0x7F977E0", VA = "0x187F98FE0")]
	public static void BPIFEJPGEIL(ReadOnlySpan<PJJOBFFNJLE> GFCHIIKNCDG, int MHNCMNIIBMN, [Out] int DEDKIDPDDAM, [Out] int MPGFFCGLMOJ, [Out] int NEGOEMOPNPG)
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
