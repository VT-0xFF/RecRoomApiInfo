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
public class MEIIFAMCKMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D EELCOLMJNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig BJKPOBGOAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public GNLKPBBLEME[] EONHKJAOGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public GNLKPBBLEME IBGKMMLCALK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MEIIFAMCKMC HDKFNLEGHDI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MEIIFAMCKMC GAODMPJGGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7904020", Offset = "0x7902A20", VA = "0x187904020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public MEIIFAMCKMC()
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
		[Cpp2IlInjected.Address(RVA = "0x79021A0", Offset = "0x7900BA0", VA = "0x1879021A0")]
		public GlyphUVConfig(int DNIIPKNOEKP, int OOMICEDOOHA, int IKNCHFGPHNK, int HHHNBMDIPFM, float FBJPADDCNHN = 0f, [Optional] GlyphPixelInset IOCIOHMLAJM)
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
public readonly struct GNLKPBBLEME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char OEFMJPOEPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int CCAEDFGFPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int LGAMELPGHFF;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly GNLKPBBLEME CDEDKLMNIDE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7901790", Offset = "0x7900190", VA = "0x187901790")]
	public GNLKPBBLEME(char CJDAKHFKKIL, int MKJCJCCJEAI, int KKFGCIPHEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x79017A0", Offset = "0x79001A0", VA = "0x1879017A0")]
	public GNLKPBBLEME(GlyphCoordinateWritable EHDOIFLMKEH)
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
		[Cpp2IlInjected.Address(RVA = "0x79017C0", Offset = "0x79001C0", VA = "0x1879017C0")]
		public static GNLKPBBLEME MEHFEEABIDG(GlyphCoordinateWritable LHJMDMLADDA)
		{
			return default(GNLKPBBLEME);
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
		private MEIIFAMCKMC configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x79020A0", Offset = "0x7900AA0", VA = "0x1879020A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7901F20", Offset = "0x7900920", VA = "0x187901F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7901F10", Offset = "0x7900910", VA = "0x187901F10")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MEIIFAMCKMC ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7901910", Offset = "0x7900310", VA = "0x187901910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GNLKPBBLEME FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7901D80", Offset = "0x7900780", VA = "0x187901D80")]
			get
			{
				return default(GNLKPBBLEME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79017E0", Offset = "0x79001E0", VA = "0x1879017E0")]
		internal void AFPOGMFDEKA(IEnumerable<GlyphCoordinateWritable> NDOEGGFNGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7901880", Offset = "0x7900280", VA = "0x187901880")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7901860", Offset = "0x7900260", VA = "0x187901860")]
		[CompilerGenerated]
		private bool NIHEKIPNKMG(GlyphCoordinateWritable LHJMDMLADDA)
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
		private TextSegmentMeshBufferSource DBIMMGGOGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private HAKLIJNNGPJ HDKDFFEENED;

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
		private AGPFGKJKBIF EMPMOPGIDFF;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7905790", Offset = "0x7904190", VA = "0x187905790")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7905740", Offset = "0x7904140", VA = "0x187905740")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7905560", Offset = "0x7903F60", VA = "0x187905560")]
		private void KFEHIFKPKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7905880", Offset = "0x7904280", VA = "0x187905880")]
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
		private bool FFMDHMMHBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material LJMOKDHNKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private HAKLIJNNGPJ HDKDFFEENED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material FBDFBJKGBNL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private MEIIFAMCKMC KEDBEPPNMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7905DE0", Offset = "0x79047E0", VA = "0x187905DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HAKLIJNNGPJ BPGLFJDFMPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7906380", Offset = "0x7904D80", VA = "0x187906380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material IIKGCJJGIFD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x79063B0", Offset = "0x7904DB0", VA = "0x1879063B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x79062E0", Offset = "0x7904CE0", VA = "0x1879062E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7905C00", Offset = "0x7904600", VA = "0x187905C00", Slot = "8")]
		protected override void ABEJPAIKOBL(NJEBLCGLALO BMMBIGBBDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x79062F0", Offset = "0x7904CF0", VA = "0x1879062F0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] IEIDGMEGMPK PDLOIIFCKAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7905E70", Offset = "0x7904870", VA = "0x187905E70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7905FC0", Offset = "0x79049C0", VA = "0x187905FC0")]
		private void PHBLLEKJICE(bool JDEIJIAFEMH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9CA070", Offset = "0x9C8A70", VA = "0x1809CA070")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct EGMEJILIADE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly HAKLIJNNGPJ JJANCPFBDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int NEFKMDIPEIM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7900AF0", Offset = "0x78FF4F0", VA = "0x187900AF0")]
	internal AODDFNDKEGG PJHLMAODKMB()
	{
		return default(AODDFNDKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x268C390", Offset = "0x268AD90", VA = "0x18268C390")]
	internal EGMEJILIADE(HAKLIJNNGPJ GIGHOMPCPHH, int LNIHCBBDENI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LABPDIBMHLD
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7903C80", Offset = "0x7902680", VA = "0x187903C80")]
	public static bool ECNFDEMNFKP(this EGMEJILIADE IHBJHPLKKAN, KANDIJPMHGE FIONFLGFADB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7903C60", Offset = "0x7902660", VA = "0x187903C60")]
	internal static bool ECNFDEMNFKP(this AODDFNDKEGG CIHGAPIIGNC, KANDIJPMHGE FIONFLGFADB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7903CD0", Offset = "0x79026D0", VA = "0x187903CD0")]
	public static float NONOOPAMDCM(this EGMEJILIADE IHBJHPLKKAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xCB3DA0", Offset = "0xCB27A0", VA = "0x180CB3DA0")]
	internal static float NONOOPAMDCM(this AODDFNDKEGG CIHGAPIIGNC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OPHGFJCBHFI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7905200", Offset = "0x7903C00", VA = "0x187905200")]
	public static void EGLEMGKFFKB(this EGMEJILIADE IHBJHPLKKAN, ReadOnlySpan<char> OAHKJIFJFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7905250", Offset = "0x7903C50", VA = "0x187905250")]
	internal static void EGLEMGKFFKB(this AODDFNDKEGG CIHGAPIIGNC, ReadOnlySpan<char> OAHKJIFJFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7905450", Offset = "0x7903E50", VA = "0x187905450")]
	public static void GIOEFNJMKHL(this EGMEJILIADE HGBCNADFLNM, float2 APJDMEOJLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x79054A0", Offset = "0x7903EA0", VA = "0x1879054A0")]
	internal static void GIOEFNJMKHL(this AODDFNDKEGG CIHGAPIIGNC, float2 APJDMEOJLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7905190", Offset = "0x7903B90", VA = "0x187905190")]
	public static void EBGNIGFKLNK(this EGMEJILIADE HGBCNADFLNM, float ILGNOPNHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7905150", Offset = "0x7903B50", VA = "0x187905150")]
	internal static void EBGNIGFKLNK(this AODDFNDKEGG CIHGAPIIGNC, float ILGNOPNHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7905500", Offset = "0x7903F00", VA = "0x187905500")]
	internal static void NELEFOBFACO(this AODDFNDKEGG CIHGAPIIGNC, bool MHFAHPKLOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7905510", Offset = "0x7903F10", VA = "0x187905510")]
	public static void PKBGPHLGAGA(this EGMEJILIADE HGBCNADFLNM, Color32 IFFOAMBAJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7905550", Offset = "0x7903F50", VA = "0x187905550")]
	internal static void PKBGPHLGAGA(this AODDFNDKEGG CIHGAPIIGNC, Color32 IFFOAMBAJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x79054B0", Offset = "0x7903EB0", VA = "0x1879054B0")]
	public static void IPFLILBMMPN(this EGMEJILIADE HGBCNADFLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x79054F0", Offset = "0x7903EF0", VA = "0x1879054F0")]
	internal static void IPFLILBMMPN(this AODDFNDKEGG CIHGAPIIGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x79050E0", Offset = "0x7903AE0", VA = "0x1879050E0")]
	internal static void DEEOPPHCENF(this AODDFNDKEGG CIHGAPIIGNC, int HMAOGPPLDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x79050C0", Offset = "0x7903AC0", VA = "0x1879050C0")]
	internal static void CAMBJHOBMKH(this AODDFNDKEGG CIHGAPIIGNC, int GJEACALMKBL, KANDIJPMHGE FFBEKDPDILN = KANDIJPMHGE.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AGPFGKJKBIF : IEquatable<AGPFGKJKBIF>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort KMMNJDKLHEG = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int NMDADIGCMNJ = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly AGPFGKJKBIF MOEALKFFLAG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort MHOIIEDIKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xBD07F0", Offset = "0xBCF1F0", VA = "0x180BD07F0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xBD0800", Offset = "0xBCF200", VA = "0x180BD0800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HAKLIJNNGPJ JJANCPFBDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BFBBKCKIDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x78F7BA0", Offset = "0x78F65A0", VA = "0x1878F7BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x78F7E50", Offset = "0x78F6850", VA = "0x1878F7E50")]
	public AGPFGKJKBIF(int KDCKABHHBBI, HAKLIJNNGPJ GIGHOMPCPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x79008C0", Offset = "0x78FF2C0", VA = "0x1879008C0")]
	public bool FCAMFEMCEGO([Out] EGMEJILIADE IHBJHPLKKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7900A00", Offset = "0x78FF400", VA = "0x187900A00")]
	public void HPODIEKJDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x78F7D90", Offset = "0x78F6790", VA = "0x1878F7D90")]
	internal void MOEKDINNCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x78F7BB0", Offset = "0x78F65B0", VA = "0x1878F7BB0", Slot = "4")]
	public bool Equals(AGPFGKJKBIF OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7900800", Offset = "0x78FF200", VA = "0x187900800", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7900990", Offset = "0x78FF390", VA = "0x187900990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HAKLIJNNGPJ : IDisposable, KIIIKHPFKCF
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string COIEMKDJPHP = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker FBNOMOJDHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string IIMAIEEMOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly JEGHHLAHJEP LEDNJNCCDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int LABNEKPCDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal AODDFNDKEGG[] DMDFLLKJOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal AGPFGKJKBIF[] LHEEBOFFGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MEIIFAMCKMC AGPJJKKFIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GICNPNHKJJJ EIOINMHDNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly OBFJELNJIAP CBMNDNEBBNH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string EMLAIMJKHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7902C90", Offset = "0x7901690", VA = "0x187902C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MEIIFAMCKMC CECOAPHMGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7903290", Offset = "0x7901C90", VA = "0x187903290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float GIJGKINEGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7902C70", Offset = "0x7901670", VA = "0x187902C70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float DLPGKPDDPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7902C50", Offset = "0x7901650", VA = "0x187902C50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KIIIKHPFKCF.NPBHFNMEHOC EAFLHFPFNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4C0", Offset = "0x9AAEC0", VA = "0x1809AC4C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4B0", Offset = "0x9AAEB0", VA = "0x1809AC4B0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7903600", Offset = "0x7902000", VA = "0x187903600")]
	public HAKLIJNNGPJ(JEGHHLAHJEP MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7903580", Offset = "0x7901F80", VA = "0x187903580")]
	public HAKLIJNNGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7903030", Offset = "0x7901A30", VA = "0x187903030")]
	public void JCFABLNPBJM(GlyphMapAsset KGHGBIEANPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7903070", Offset = "0x7901A70", VA = "0x187903070")]
	public void JCFABLNPBJM(MEIIFAMCKMC LHKEBEELHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79032B0", Offset = "0x7901CB0", VA = "0x1879032B0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] IEIDGMEGMPK PDLOIIFCKAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7902BA0", Offset = "0x79015A0", VA = "0x187902BA0")]
	public void FAHEMNMMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7902C00", Offset = "0x7901600", VA = "0x187902C00")]
	public bool FGNMAPNDEBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7902530", Offset = "0x7900F30", VA = "0x187902530")]
	public AGPFGKJKBIF BJKLMKHPCOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79021D0", Offset = "0x7900BD0", VA = "0x1879021D0")]
	public void BBIMAAJAHBM(AGPFGKJKBIF DNGMMMMINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x79031E0", Offset = "0x7901BE0", VA = "0x1879031E0")]
	internal bool OPIMJIBOPDB(AGPFGKJKBIF DNGMMMMINDI, [Out] EGMEJILIADE IHBJHPLKKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7902970", Offset = "0x7901370", VA = "0x187902970")]
	private void CPGIBBFAAOC(AODDFNDKEGG CIHGAPIIGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7902790", Offset = "0x7901190", VA = "0x187902790")]
	private void BNLHPCEEGNM(int NCIHMDICPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7903180", Offset = "0x7901B80", VA = "0x187903180")]
	private bool OEBAKJGIEFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x78FA510", Offset = "0x78F8F10", VA = "0x1878FA510")]
	private static int HEFHNAOBOCD(AGPFGKJKBIF DNGMMMMINDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x200AA60", Offset = "0x2009460", VA = "0x18200AA60")]
	private static ushort GHJDFPMMAEK(int DOAKEFBOPIA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7902D20", Offset = "0x7901720", VA = "0x187902D20")]
	private Bounds IINLFPJLNMN()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7902AF0", Offset = "0x79014F0", VA = "0x187902AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JEGHHLAHJEP
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JEGHHLAHJEP BNPJHAMHLFD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float JDMOPFBBHOE = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LBHOEMCJCCI = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int KKIIJICCJJI = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color NGLIOAEOFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float ILNEONAAFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int PJMEMPOCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int PPGCHMPHGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int KBNCEFFCDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int LHGEOMDNJKJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7903A60", Offset = "0x7902460", VA = "0x187903A60")]
	internal JEGHHLAHJEP CKKEHJPFOIE()
	{
		return default(JEGHHLAHJEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x78F9080", Offset = "0x78F7A80", VA = "0x1878F9080")]
	[CompilerGenerated]
	internal static void JFGONKKMAJC(int PPJFMHBDGNA, int LPJIMLBFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7903B70", Offset = "0x7902570", VA = "0x187903B70")]
	[CompilerGenerated]
	internal static void GDDGPLLBCNA(float PPJFMHBDGNA, float LPJIMLBFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x78F9090", Offset = "0x78F7A90", VA = "0x1878F9090")]
	[CompilerGenerated]
	internal static void DCIODJFIGPJ(int PPJFMHBDGNA, int PAADANEBHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7903B90", Offset = "0x7902590", VA = "0x187903B90")]
	[CompilerGenerated]
	internal static void JKFFLJIEHEN(float PPJFMHBDGNA, float PAADANEBHNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LNMIPJJLHJB
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7903F90", Offset = "0x7902990", VA = "0x187903F90")]
	public static float KGDJHGIIGHM(this EGMEJILIADE EJOGEBIBDOO)
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
		public readonly AGPFGKJKBIF textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7905B90", Offset = "0x7904590", VA = "0x187905B90")]
		public TextSegmentLayout(LayoutRect layoutRect, AGPFGKJKBIF textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7905960", Offset = "0x7904360", VA = "0x187905960")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x79059D0", Offset = "0x79043D0", VA = "0x1879059D0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7905900", Offset = "0x7904300", VA = "0x187905900")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class GICNPNHKJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig FLBEJJEMIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float KNDMMDMJAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float BAMPNHALHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float BCADJIPMMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float FABBCGMLALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float PDONANPBDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float AAAOMIDPOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float BCAAGLLAPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float PMDNKDHIJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float DNGJCHMLNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float DLPGKPDDPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float NMICOEBNMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float GIJGKINEGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LGMHELOLMAI[] HMNKOCOCKND;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int ADJMDPKDBFD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private HEHKLKGDKEH[] KHEOHCFOBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int JNECOOLKHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private GNLKPBBLEME[] GODJMMNPFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int OLNLJEPICJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public LGMHELOLMAI EHAFMIHMIKI;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x79011A0", Offset = "0x78FFBA0", VA = "0x1879011A0")]
	public void JCFABLNPBJM(MEIIFAMCKMC FEKDFFFKDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7901120", Offset = "0x78FFB20", VA = "0x187901120")]
	public void JCFABLNPBJM(GlyphUVConfig NMCHLKHKLBA, IEnumerable<GNLKPBBLEME> KGHGBIEANPH, GNLKPBBLEME NIDIOBCFKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7901230", Offset = "0x78FFC30", VA = "0x187901230")]
	internal void JNDCIDLOJPH(GlyphUVConfig NMCHLKHKLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7900BF0", Offset = "0x78FF5F0", VA = "0x187900BF0")]
	private void CDKADIFKACB(IEnumerable<GNLKPBBLEME> KGHGBIEANPH, GNLKPBBLEME NIDIOBCFKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7901370", Offset = "0x78FFD70", VA = "0x187901370")]
	public void MPFMBHJKPOJ([In] char CJDAKHFKKIL, [Out] float2[] JEFLIFCDNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x78FE880", Offset = "0x78FD280", VA = "0x1878FE880")]
	private LGMHELOLMAI LBGBHDGOGNN(GNLKPBBLEME EHDOIFLMKEH)
	{
		return default(LGMHELOLMAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x79016A0", Offset = "0x79000A0", VA = "0x1879016A0")]
	public GICNPNHKJJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LGLPDEGCKEA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7903DD0", Offset = "0x79027D0", VA = "0x187903DD0")]
	public static void JOFKPBGDGGB([In] float CINAALJJCBD, [In] float HBHIHCLBLMP, [In] int CHCKGMDCOLN, [In] int KIHDNNMJGCE, [In] float FABBCGMLALN, [In] float PDONANPBDHM, [In] float GMMNNOJBOIM, [In] float GKOFJGOPOMM, [In] float MOCNNKPBJJB, [In] float EIJNPFLJPBL, [Out] float MLPGOHKPPKL, [Out] float KDFBBBOAOAD, [Out] float POFPGJPFGGF, [Out] float HKNCHHFAEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7903D70", Offset = "0x7902770", VA = "0x187903D70")]
	public static void JOFKPBGDGGB([In] float CINAALJJCBD, [In] float HBHIHCLBLMP, [In] int CHCKGMDCOLN, [In] int KIHDNNMJGCE, [Out] float MLPGOHKPPKL, [Out] float KDFBBBOAOAD, [Out] float POFPGJPFGGF, [Out] float HKNCHHFAEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7903D10", Offset = "0x7902710", VA = "0x187903D10")]
	public static void CLAIHOMKNFB([In] float FABBCGMLALN, [In] float PDONANPBDHM, [In] float OHCICDKLLCG, [In] float NCFKPNKKCMC, [In] float OBCIJHMBCBB, [In] float DLDFLLNEMIK, [Out] float LOGBJAGPHNE, [Out] float LDDHIFCLDID, [Out] float LAEMEIHNIMO, [Out] float KJEKLMKPFIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct HEHKLKGDKEH
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint JMLEFCLFNFE = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char OEFMJPOEPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly LGMHELOLMAI OOPENLMMCDA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7903A40", Offset = "0x7902440", VA = "0x187903A40")]
	public HEHKLKGDKEH(char CJDAKHFKKIL, LGMHELOLMAI JEFLIFCDNEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LGMHELOLMAI
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint JMLEFCLFNFE = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] NHJIGBAEAPH;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7903EA0", Offset = "0x79028A0", VA = "0x187903EA0")]
	public LGMHELOLMAI(float MLPGOHKPPKL, float KDFBBBOAOAD, float POFPGJPFGGF, float HKNCHHFAEDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct AODDFNDKEGG
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int LIHIOFMLHPD = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal KANDIJPMHGE FFBEKDPDILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] BLGDHIMFGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int INCPECIMFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 APJDMEOJLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float MCGMLOFHOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 AHKIMKBGOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool MHFAHPKLOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int LOPHLJBODLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int KHOLELBPDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int AHOMCBECGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int LBFHKIEAEDC;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7900AE0", Offset = "0x78FF4E0", VA = "0x187900AE0")]
	public static int HCCPMMHHLNL(int AECLOIOPDLG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum KANDIJPMHGE : byte
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
public static class FEKBDOONDDO
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7900BB0", Offset = "0x78FF5B0", VA = "0x187900BB0")]
	internal static float KGDJHGIIGHM(this AODDFNDKEGG CIHGAPIIGNC, float LLLOEILHJFO, float BMBIFONNNCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7900B30", Offset = "0x78FF530", VA = "0x187900B30")]
	internal static void EHDCEDJDELC(this AODDFNDKEGG CIHGAPIIGNC, float LLLOEILHJFO, float BMBIFONNNCG, [Out] float2 ODPANEHCOAE, [Out] float2 AIHFEHEPHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class OBFJELNJIAP : KIIIKHPFKCF
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int NHDOLAPHDAL = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int PMPHOHFBJAB = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string COIEMKDJPHP = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker PCCJLFFOONH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker IGEFKLAIEFE;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker OHALBAKEHBF;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker GJHECFBKPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly IEIDGMEGMPK PDLOIIFCKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] FBBKIBFDCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] FMJFAECEEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int EBKMLNCFOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int LIMOMGBIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int CAJCLPDBAED;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string EMLAIMJKHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public KIIIKHPFKCF.NPBHFNMEHOC EAFLHFPFNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7904FB0", Offset = "0x79039B0", VA = "0x187904FB0")]
	public OBFJELNJIAP(IEIDGMEGMPK.LGDLBKGCIBC ACGEFBEOEPM, int HMHPENKJPEI, int CBOMILODOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7904E30", Offset = "0x7903830", VA = "0x187904E30", Slot = "5")]
	public bool TryGetMeshBuffer([Out] IEIDGMEGMPK PDLOIIFCKAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7904E10", Offset = "0x7903810", VA = "0x187904E10")]
	public void LJEMKCOHEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7904190", Offset = "0x7902B90", VA = "0x187904190")]
	public void GCCGBBINLPL(Span<AODDFNDKEGG> MOFELICOJGM, GICNPNHKJJJ MBNLCEEDILD, [In] JEGHHLAHJEP MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x78FF790", Offset = "0x78FE190", VA = "0x1878FF790")]
	private void HPCCHFDENBE([In] KANDIJPMHGE FFBEKDPDILN, [In] AODDFNDKEGG JODJDLFFBMN, int FIDCGKHKOIH, [In] float LLLOEILHJFO, [In] float BMBIFONNNCG, GICNPNHKJJJ MBNLCEEDILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7904CC0", Offset = "0x79036C0", VA = "0x187904CC0")]
	private void GJGODDEGKPN([In] KANDIJPMHGE FFBEKDPDILN, AODDFNDKEGG JODJDLFFBMN, [In] int ODEKFGMDMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7904A90", Offset = "0x7903490", VA = "0x187904A90")]
	public static void GCDCJMFNFOH(ReadOnlySpan<AODDFNDKEGG> MOFELICOJGM, int OACAFEHOBBB, [Out] int MNGLFHMHOCH, [Out] int PIDLOBBHNOG, [Out] int OGLPIFHCNIA)
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
