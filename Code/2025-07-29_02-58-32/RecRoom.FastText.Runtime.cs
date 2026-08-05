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
public class IPKIOKMOOOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D KEOENCNDPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig POBLDMBHBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public LKCPMEGPGLE[] JFMPAANKKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public LKCPMEGPGLE PIIDLNFHHDJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static IPKIOKMOOOE EKOMLEEMFNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IPKIOKMOOOE GONEFMMKLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82FA960", Offset = "0x82F9360", VA = "0x1882FA960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IPKIOKMOOOE()
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
		[Cpp2IlInjected.Address(RVA = "0x82FA560", Offset = "0x82F8F60", VA = "0x1882FA560")]
		public GlyphUVConfig(int ADKHMOPOBDH, int BMEHOBLDEGA, int CPAIBDGKDNE, int FBIMHCDCEPN, float CIEICMLGLBL = 0f, [Optional] GlyphPixelInset BMJBBFCLJDB)
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
public readonly struct LKCPMEGPGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char DEBFJKFKBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int CNMLMGOHAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int ENGHHILJDLK;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly LKCPMEGPGLE MOEINCIKJHN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82FAC00", Offset = "0x82F9600", VA = "0x1882FAC00")]
	public LKCPMEGPGLE(char JEJDHKCJJDG, int HACPLGHOOBG, int CKLCMJCFOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82FABE0", Offset = "0x82F95E0", VA = "0x1882FABE0")]
	public LKCPMEGPGLE(GlyphCoordinateWritable LJOALCCLODF)
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
		[Cpp2IlInjected.Address(RVA = "0x82F9B70", Offset = "0x82F8570", VA = "0x1882F9B70")]
		public static LKCPMEGPGLE LHJBCIIELME(GlyphCoordinateWritable HFDMMDBJNBG)
		{
			return default(LKCPMEGPGLE);
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
		private IPKIOKMOOOE configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x82FA460", Offset = "0x82F8E60", VA = "0x1882FA460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x82FA2E0", Offset = "0x82F8CE0", VA = "0x1882FA2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x82FA2D0", Offset = "0x82F8CD0", VA = "0x1882FA2D0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPKIOKMOOOE ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x82F9CC0", Offset = "0x82F86C0", VA = "0x1882F9CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LKCPMEGPGLE FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x82FA140", Offset = "0x82F8B40", VA = "0x1882FA140")]
			get
			{
				return default(LKCPMEGPGLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82F9BB0", Offset = "0x82F85B0", VA = "0x1882F9BB0")]
		internal void JDDELINHENG(IEnumerable<GlyphCoordinateWritable> GHCHPHDILNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82F9C30", Offset = "0x82F8630", VA = "0x1882F9C30")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82F9B90", Offset = "0x82F8590", VA = "0x1882F9B90")]
		[CompilerGenerated]
		private bool JCHLLLJEOEM(GlyphCoordinateWritable HFDMMDBJNBG)
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
		private TextSegmentMeshBufferSource MNJFMILMMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CEMBEIHOKNJ IDHELDIOFHA;

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
		private FPDNIKHHBED NDKDAENFNAK;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82FBC80", Offset = "0x82FA680", VA = "0x1882FBC80")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82FBC30", Offset = "0x82FA630", VA = "0x1882FBC30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82FBA50", Offset = "0x82FA450", VA = "0x1882FBA50")]
		private void EHAIFNJDKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82FBD70", Offset = "0x82FA770", VA = "0x1882FBD70")]
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
		private bool HKLNLMOAKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material KHJIAHIGEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private CEMBEIHOKNJ IDHELDIOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material LCMNKOPNBPH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private IPKIOKMOOOE CFKHLKDNDBA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x82FC600", Offset = "0x82FB000", VA = "0x1882FC600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CEMBEIHOKNJ GHLAIGLECFD
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x82FC880", Offset = "0x82FB280", VA = "0x1882FC880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material PBCHLNKCHGH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x82FC8B0", Offset = "0x82FB2B0", VA = "0x1882FC8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82FC7E0", Offset = "0x82FB1E0", VA = "0x1882FC7E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82FC410", Offset = "0x82FAE10", VA = "0x1882FC410", Slot = "8")]
		protected override void DKBNFBBKPIL(OBEDGFGKDCA KHJONGDFHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82FC7F0", Offset = "0x82FB1F0", VA = "0x1882FC7F0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] LNKBBPHKLOK KIEMLMHCNEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82FC690", Offset = "0x82FB090", VA = "0x1882FC690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82FC0F0", Offset = "0x82FAAF0", VA = "0x1882FC0F0")]
		private void DAKOCAJMMAC(bool FGLPKBNAEFO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAA2540", Offset = "0xAA0F40", VA = "0x180AA2540")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct PEMLHCNBNHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly CEMBEIHOKNJ BMDINCJPKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int DHDGGHEMLDB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82FBA10", Offset = "0x82FA410", VA = "0x1882FBA10")]
	internal DNEJBPGILML FLGAPNHJLJO()
	{
		return default(DNEJBPGILML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EED0", Offset = "0x2A4D8D0", VA = "0x182A4EED0")]
	internal PEMLHCNBNHJ(CEMBEIHOKNJ NKHELPOPPEM, int DEIBDGCHFGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KLGFAMLNHMC
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x82FAB20", Offset = "0x82F9520", VA = "0x1882FAB20")]
	public static bool HHCICOBIDHH(this PEMLHCNBNHJ AAMLMMLMPMF, NIOOAGMCCAN IIHDAKNMEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82FAB70", Offset = "0x82F9570", VA = "0x1882FAB70")]
	internal static bool HHCICOBIDHH(this DNEJBPGILML ONLKCOHCNEA, NIOOAGMCCAN IIHDAKNMEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82FAAE0", Offset = "0x82F94E0", VA = "0x1882FAAE0")]
	public static float GPEANJFPGAE(this PEMLHCNBNHJ AAMLMMLMPMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xADE3F0", Offset = "0xADCDF0", VA = "0x180ADE3F0")]
	internal static float GPEANJFPGAE(this DNEJBPGILML ONLKCOHCNEA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BPHIEMLEPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82F7B70", Offset = "0x82F6570", VA = "0x1882F7B70")]
	public static void DPLBCPJHBJB(this PEMLHCNBNHJ AAMLMMLMPMF, ReadOnlySpan<char> OCPHCEACLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x82F7970", Offset = "0x82F6370", VA = "0x1882F7970")]
	internal static void DPLBCPJHBJB(this DNEJBPGILML ONLKCOHCNEA, ReadOnlySpan<char> OCPHCEACLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x82F7D60", Offset = "0x82F6760", VA = "0x1882F7D60")]
	public static void PEAEEEOFCDK(this PEMLHCNBNHJ PICFDBFCEGF, float2 ADNLOLNGNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82F7DB0", Offset = "0x82F67B0", VA = "0x1882F7DB0")]
	internal static void PEAEEEOFCDK(this DNEJBPGILML ONLKCOHCNEA, float2 ADNLOLNGNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x82F7C10", Offset = "0x82F6610", VA = "0x1882F7C10")]
	public static void FAJPEHJHKMD(this PEMLHCNBNHJ PICFDBFCEGF, float DHHNJBHCADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82F7C80", Offset = "0x82F6680", VA = "0x1882F7C80")]
	internal static void FAJPEHJHKMD(this DNEJBPGILML ONLKCOHCNEA, float DHHNJBHCADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82F7D50", Offset = "0x82F6750", VA = "0x1882F7D50")]
	internal static void NNJLHOKBMCC(this DNEJBPGILML ONLKCOHCNEA, bool ANJHKGDCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82F7DC0", Offset = "0x82F67C0", VA = "0x1882F7DC0")]
	public static void PIMJNPCAIJD(this PEMLHCNBNHJ PICFDBFCEGF, Color32 EDNHAEBPHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82F7E00", Offset = "0x82F6800", VA = "0x1882F7E00")]
	internal static void PIMJNPCAIJD(this DNEJBPGILML ONLKCOHCNEA, Color32 EDNHAEBPHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82F7BD0", Offset = "0x82F65D0", VA = "0x1882F7BD0")]
	public static void EEDPJNOLHGO(this PEMLHCNBNHJ PICFDBFCEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82F7BC0", Offset = "0x82F65C0", VA = "0x1882F7BC0")]
	internal static void EEDPJNOLHGO(this DNEJBPGILML ONLKCOHCNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x82F7CE0", Offset = "0x82F66E0", VA = "0x1882F7CE0")]
	internal static void LGDOGODANFG(this DNEJBPGILML ONLKCOHCNEA, int BOAJDJGONPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82F7CC0", Offset = "0x82F66C0", VA = "0x1882F7CC0")]
	internal static void HNEFJFILLMB(this DNEJBPGILML ONLKCOHCNEA, int PDPCKAFKEHG, NIOOAGMCCAN MBEANEPKEHO = NIOOAGMCCAN.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FPDNIKHHBED : IEquatable<FPDNIKHHBED>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort ANDDPIABPCP = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int JFDLHNKJLAL = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly FPDNIKHHBED ECEANEINLFB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort MJPHJHJOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xDAC5A0", Offset = "0xDAAFA0", VA = "0x180DAC5A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xDAC5B0", Offset = "0xDAAFB0", VA = "0x180DAC5B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CEMBEIHOKNJ BMDINCJPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DKCDJFPCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82EF7D0", Offset = "0x82EE1D0", VA = "0x1882EF7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x82EFA80", Offset = "0x82EE480", VA = "0x1882EFA80")]
	public FPDNIKHHBED(int NJLFCPCDMBO, CEMBEIHOKNJ NKHELPOPPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82F99C0", Offset = "0x82F83C0", VA = "0x1882F99C0")]
	public bool LPCNOBELPMH([Out] PEMLHCNBNHJ AAMLMMLMPMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82F9A90", Offset = "0x82F8490", VA = "0x1882F9A90")]
	public void OEENGNANBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82EF7E0", Offset = "0x82EE1E0", VA = "0x1882EF7E0")]
	internal void DICNOKDNMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82EF810", Offset = "0x82EE210", VA = "0x1882EF810", Slot = "4")]
	public bool Equals(FPDNIKHHBED EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82F9890", Offset = "0x82F8290", VA = "0x1882F9890", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82F9950", Offset = "0x82F8350", VA = "0x1882F9950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class CEMBEIHOKNJ : IDisposable, NFFKDHKKOCO
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string FDOEBNGIAFP = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker ADLGELCAKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string GJENGPALBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly EPLICDHODLD MHEGDPPAPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int ALANGBCJHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal DNEJBPGILML[] GHEKCLMFIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FPDNIKHHBED[] AMKBGGHBBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private IPKIOKMOOOE MMEFOLNGCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AHKKALBJAAA DGAMGIGEAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly OHFDLGONDPH IMFPBOKGFMP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string FLBFBHGDBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82F8B60", Offset = "0x82F7560", VA = "0x1882F8B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IPKIOKMOOOE IJLEHIMBMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82F8E30", Offset = "0x82F7830", VA = "0x1882F8E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JMAFAAMAJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82F7E30", Offset = "0x82F6830", VA = "0x1882F7E30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CFJHKGJKMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82F8F00", Offset = "0x82F7900", VA = "0x1882F8F00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NFFKDHKKOCO.BFMCHOHLNJM MCILCIDNGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA841A0", Offset = "0xA82BA0", VA = "0x180A841A0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82F91C0", Offset = "0x82F7BC0", VA = "0x1882F91C0")]
	public CEMBEIHOKNJ(EPLICDHODLD CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82F9600", Offset = "0x82F8000", VA = "0x1882F9600")]
	public CEMBEIHOKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82F7E50", Offset = "0x82F6850", VA = "0x1882F7E50")]
	public void CEKLAJMLNPO(GlyphMapAsset FENCBIAKJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82F7E90", Offset = "0x82F6890", VA = "0x1882F7E90")]
	public void CEKLAJMLNPO(IPKIOKMOOOE PKNBLBNKJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82F8F20", Offset = "0x82F7920", VA = "0x1882F8F20", Slot = "6")]
	public bool TryGetMeshBuffer([Out] LNKBBPHKLOK KIEMLMHCNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82F88D0", Offset = "0x82F72D0", VA = "0x1882F88D0")]
	public void DBGPKBGGDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82F7FA0", Offset = "0x82F69A0", VA = "0x1882F7FA0")]
	public bool CFKGEOECDII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82F8660", Offset = "0x82F7060", VA = "0x1882F8660")]
	public FPDNIKHHBED CPHDELAJGGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82F7FF0", Offset = "0x82F69F0", VA = "0x1882F7FF0")]
	public void CHIGEKCBHJA(FPDNIKHHBED OOFDIBOEAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82F8E50", Offset = "0x82F7850", VA = "0x1882F8E50")]
	internal bool OJDIEEGBLNG(FPDNIKHHBED OOFDIBOEAID, [Out] PEMLHCNBNHJ AAMLMMLMPMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82F89E0", Offset = "0x82F73E0", VA = "0x1882F89E0")]
	private void HHKKHJKFEGP(DNEJBPGILML ONLKCOHCNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82F8BF0", Offset = "0x82F75F0", VA = "0x1882F8BF0")]
	private void IOFHHPBGABM(int FIAOMPOOHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82F8DD0", Offset = "0x82F77D0", VA = "0x1882F8DD0")]
	private bool JIOJGOGNEPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82F4350", Offset = "0x82F2D50", VA = "0x1882F4350")]
	private static int LPDLDCBMLJE(FPDNIKHHBED OOFDIBOEAID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24EEEC0", Offset = "0x24ED8C0", VA = "0x1824EEEC0")]
	private static ushort BDHLAAGBOKL(int FILGHJLFKAL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82F8350", Offset = "0x82F6D50", VA = "0x1882F8350")]
	private Bounds CMNJOFJBHPI()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82F8930", Offset = "0x82F7330", VA = "0x1882F8930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EPLICDHODLD
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly EPLICDHODLD LJJPINLLJBI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float ALDIJFIABLA = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int MNKMOJDAFBD = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int NAJEMGACDJO = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color DPIBFAKOKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float KLFBALHIFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int IOJPKHHDHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int BJJNCLJCFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int DCFIEGAKJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int KFMAIFJCPDN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82F96B0", Offset = "0x82F80B0", VA = "0x1882F96B0")]
	internal EPLICDHODLD ADJBDCJJJPK()
	{
		return default(EPLICDHODLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82F4DE0", Offset = "0x82F37E0", VA = "0x1882F4DE0")]
	[CompilerGenerated]
	internal static void BKNGBEMCBFP(int PDKJBMPOMNC, int KKCMINIPIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x82F9690", Offset = "0x82F8090", VA = "0x1882F9690")]
	[CompilerGenerated]
	internal static void ABLBIEGHCLM(float PDKJBMPOMNC, float KKCMINIPIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x82F4DD0", Offset = "0x82F37D0", VA = "0x1882F4DD0")]
	[CompilerGenerated]
	internal static void HFAMFPBLHJG(int PDKJBMPOMNC, int LBJAIAGGGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x82F97C0", Offset = "0x82F81C0", VA = "0x1882F97C0")]
	[CompilerGenerated]
	internal static void IBPPMFPJGBE(float PDKJBMPOMNC, float LBJAIAGGGCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HHGMPLKOAFG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82FA7E0", Offset = "0x82F91E0", VA = "0x1882FA7E0")]
	public static float BIGOICHCPIP(this PEMLHCNBNHJ BIGCICIPPLM)
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
		public readonly FPDNIKHHBED textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x82FC080", Offset = "0x82FAA80", VA = "0x1882FC080")]
		public TextSegmentLayout(LayoutRect layoutRect, FPDNIKHHBED textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x82FBE50", Offset = "0x82FA850", VA = "0x1882FBE50")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x82FBEC0", Offset = "0x82FA8C0", VA = "0x1882FBEC0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82FBDF0", Offset = "0x82FA7F0", VA = "0x1882FBDF0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class AHKKALBJAAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig CINOPIBEHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float PFMIKFGPCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float BPGIKFHILLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float JMBABLFIPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float COEGGIAPHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float KMPDIABHNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float AOBOIDJPGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float AFNIEDLLPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float IMCALMGNBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float NBPOAHIEECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float CFJHKGJKMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float AAEBILMACFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float JMAFAAMAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly HOKOHCEOHGI[] DGAOCDFFGEA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int IDLNOMBGAIK = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private CDHDENLGBCM[] OEBIBNMAJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int JAONAEDIAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private LKCPMEGPGLE[] ADFJFKHCNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int JJINFCHBEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public HOKOHCEOHGI CEDJODKGILP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x82F6E90", Offset = "0x82F5890", VA = "0x1882F6E90")]
	public void CEKLAJMLNPO(IPKIOKMOOOE MGOHDAPHFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82F6E10", Offset = "0x82F5810", VA = "0x1882F6E10")]
	public void CEKLAJMLNPO(GlyphUVConfig NINDJBABNJL, IEnumerable<LKCPMEGPGLE> FENCBIAKJKM, LKCPMEGPGLE IEMHIOBFHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x82F6F20", Offset = "0x82F5920", VA = "0x1882F6F20")]
	internal void CLAJDDCJDIP(GlyphUVConfig NINDJBABNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x82F7060", Offset = "0x82F5A60", VA = "0x1882F7060")]
	private void GFFPKJENANB(IEnumerable<LKCPMEGPGLE> FENCBIAKJKM, LKCPMEGPGLE IEMHIOBFHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82F75A0", Offset = "0x82F5FA0", VA = "0x1882F75A0")]
	public void PBNFBBACKKO([In] char JEJDHKCJJDG, [Out] float2[] JILGJAKBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82F4EA0", Offset = "0x82F38A0", VA = "0x1882F4EA0")]
	private HOKOHCEOHGI ILEIJJAOEFN(LKCPMEGPGLE LJOALCCLODF)
	{
		return default(HOKOHCEOHGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82F78D0", Offset = "0x82F62D0", VA = "0x1882F78D0")]
	public AHKKALBJAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HGEEAGBFOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x82FA710", Offset = "0x82F9110", VA = "0x1882FA710")]
	public static void PAJFOMPMPBJ([In] float BMNBILHIHBG, [In] float FCJOLCCGOEE, [In] int ACEDHBAODOF, [In] int LBFJBFNFNLK, [In] float COEGGIAPHPJ, [In] float KMPDIABHNLB, [In] float NIBJODPJJFK, [In] float IPAFEFIGFFA, [In] float KGHPKJGLOPC, [In] float HOOCOJHJEOC, [Out] float EHGFDCMKALH, [Out] float MJODLLCKHDH, [Out] float JIJHEEFBMHM, [Out] float KFMBPOKMKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x82FA6B0", Offset = "0x82F90B0", VA = "0x1882FA6B0")]
	public static void PAJFOMPMPBJ([In] float BMNBILHIHBG, [In] float FCJOLCCGOEE, [In] int ACEDHBAODOF, [In] int LBFJBFNFNLK, [Out] float EHGFDCMKALH, [Out] float MJODLLCKHDH, [Out] float JIJHEEFBMHM, [Out] float KFMBPOKMKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82FA650", Offset = "0x82F9050", VA = "0x1882FA650")]
	public static void HFOKCKKMJJI([In] float COEGGIAPHPJ, [In] float KMPDIABHNLB, [In] float IGBFBICAMCM, [In] float NLAGDOAJJAH, [In] float GMBGHGGIJAB, [In] float DKFHIIBEJIN, [Out] float OHLILCGBFGN, [Out] float CDAHDFPNKLB, [Out] float INFKLDCDMKG, [Out] float JIDENPODFMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct CDHDENLGBCM
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint EHBCFCMDEJG = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char DEBFJKFKBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly HOKOHCEOHGI CJHGFGAJOLC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x82F7E10", Offset = "0x82F6810", VA = "0x1882F7E10")]
	public CDHDENLGBCM(char JEJDHKCJJDG, HOKOHCEOHGI JILGJAKBANK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HOKOHCEOHGI
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint EHBCFCMDEJG = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] JCBKGPNEICG;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82FA870", Offset = "0x82F9270", VA = "0x1882FA870")]
	public HOKOHCEOHGI(float EHGFDCMKALH, float MJODLLCKHDH, float JIJHEEFBMHM, float KFMBPOKMKPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct DNEJBPGILML
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int MKLPDDCHJAE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal NIOOAGMCCAN MBEANEPKEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] GPBGKKDLENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int KBCFFGMOBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 ADNLOLNGNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float EPBJFBLNHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 OJKILBJAJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool ANJHKGDCMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int OKJNOBBLCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int FJFOGFNLBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int EJGCPEGFINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int KHDPNFNACEH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82F9680", Offset = "0x82F8080", VA = "0x1882F9680")]
	public static int OABKBPIIDIE(int JDDLNFIMCDE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum NIOOAGMCCAN : byte
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
public static class HBMKLHEHNGF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82FA590", Offset = "0x82F8F90", VA = "0x1882FA590")]
	internal static float BIGOICHCPIP(this DNEJBPGILML ONLKCOHCNEA, float NPIHGKAGNPH, float EFMBIGNLIME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x82FA5D0", Offset = "0x82F8FD0", VA = "0x1882FA5D0")]
	internal static void MENFFMDEKPK(this DNEJBPGILML ONLKCOHCNEA, float NPIHGKAGNPH, float EFMBIGNLIME, [Out] float2 OIMFMPLNJEN, [Out] float2 HJDOALAIPGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class OHFDLGONDPH : NFFKDHKKOCO
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int MLCCCNEDPNE = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int BHMEGIPCCFF = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string FDOEBNGIAFP = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker LIBOHIKNBGI;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker PBFJOOHABCN;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker BNAJFNBKDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker HLLJJKJCKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly LNKBBPHKLOK KIEMLMHCNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] BBIGEBNGKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] EPMECONLKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int HAKLEIINHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int FGCINBNOKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int JAJGHOKLNJO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string FLBFBHGDBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NFFKDHKKOCO.BFMCHOHLNJM MCILCIDNGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82FB900", Offset = "0x82FA300", VA = "0x1882FB900")]
	public OHFDLGONDPH(LNKBBPHKLOK.EIKEDOIDAIP ACIOGINEBIG, int NJBHMBPNEGP, int AHNLGPNDIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x82FB770", Offset = "0x82FA170", VA = "0x1882FB770", Slot = "5")]
	public bool TryGetMeshBuffer([Out] LNKBBPHKLOK KIEMLMHCNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82FAE20", Offset = "0x82F9820", VA = "0x1882FAE20")]
	public void CKACOFPHEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82FAF90", Offset = "0x82F9990", VA = "0x1882FAF90")]
	public void MENCGBGBCIL(Span<DNEJBPGILML> OBLADACEFJB, AHKKALBJAAA LMFEGNGOLLI, [In] EPLICDHODLD CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x82F57C0", Offset = "0x82F41C0", VA = "0x1882F57C0")]
	private void LDIEDFJODDF([In] NIOOAGMCCAN MBEANEPKEHO, [In] DNEJBPGILML ANBPCDMEPGO, int COAGPKOCOME, [In] float NPIHGKAGNPH, [In] float EFMBIGNLIME, AHKKALBJAAA LMFEGNGOLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82FAE40", Offset = "0x82F9840", VA = "0x1882FAE40")]
	private void GOLMGADEBDO([In] NIOOAGMCCAN MBEANEPKEHO, DNEJBPGILML ANBPCDMEPGO, [In] int JHNGJHAOANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82FAC10", Offset = "0x82F9610", VA = "0x1882FAC10")]
	public static void BJKPLIJEMLA(ReadOnlySpan<DNEJBPGILML> OBLADACEFJB, int FLFOKALEAPE, [Out] int PGLELFNEBOF, [Out] int HLHMJCBAMEI, [Out] int AHJPBIGBEDN)
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
