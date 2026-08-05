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
public class FNGPNEODCPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D DPEEHEFLNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig CFKAOAECMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public BHNKMBFJPHP[] JCBALCMPPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public BHNKMBFJPHP FLOKLAMICFD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FNGPNEODCPE KAFMPNKMPIB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FNGPNEODCPE DIKKOLDCHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7AF3A60", Offset = "0x7AF2E60", VA = "0x187AF3A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public FNGPNEODCPE()
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
		[Cpp2IlInjected.Address(RVA = "0x7AF45D0", Offset = "0x7AF39D0", VA = "0x187AF45D0")]
		public GlyphUVConfig(int BDLBEJKEBKP, int EAADKLAPJDH, int LGLHJKIALGA, int CBNFNHOPDMN, float NMDBJBFHNJE = 0f, [Optional] GlyphPixelInset LHFMGGAGGAP)
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
public readonly struct BHNKMBFJPHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char LONFAGDECFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int PKDOGGHJPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int JDEOLOPAKDE;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly BHNKMBFJPHP INGAEMBGPMD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3140", Offset = "0x7AF2540", VA = "0x187AF3140")]
	public BHNKMBFJPHP(char JAMONCOAOGB, int NCJLDOKKOBE, int HEOENAFKMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3120", Offset = "0x7AF2520", VA = "0x187AF3120")]
	public BHNKMBFJPHP(GlyphCoordinateWritable HMKNEFHNPDG)
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
		[Cpp2IlInjected.Address(RVA = "0x7AF3BE0", Offset = "0x7AF2FE0", VA = "0x187AF3BE0")]
		public static BHNKMBFJPHP HIHFKEJHDAH(GlyphCoordinateWritable NEIELBLPLNK)
		{
			return default(BHNKMBFJPHP);
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
		private FNGPNEODCPE configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7AF44D0", Offset = "0x7AF38D0", VA = "0x187AF44D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7AF4350", Offset = "0x7AF3750", VA = "0x187AF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7AF4340", Offset = "0x7AF3740", VA = "0x187AF4340")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FNGPNEODCPE ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7AF3D30", Offset = "0x7AF3130", VA = "0x187AF3D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BHNKMBFJPHP FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7AF41B0", Offset = "0x7AF35B0", VA = "0x187AF41B0")]
			get
			{
				return default(BHNKMBFJPHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AF3C00", Offset = "0x7AF3000", VA = "0x187AF3C00")]
		internal void JKLCEKLGHJE(IEnumerable<GlyphCoordinateWritable> JBIKGKICKCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7AF3CA0", Offset = "0x7AF30A0", VA = "0x187AF3CA0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7AF3C80", Offset = "0x7AF3080", VA = "0x187AF3C80")]
		[CompilerGenerated]
		private bool KKKMPGFCMNB(GlyphCoordinateWritable NEIELBLPLNK)
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
		private TextSegmentMeshBufferSource KNAAMOCNDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private HDCOEEHMINI CBHBLHCAGLD;

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
		private JIGEAEDOIAB BLHDEFPBNND;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7F40", Offset = "0x7AF7340", VA = "0x187AF7F40")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7EF0", Offset = "0x7AF72F0", VA = "0x187AF7EF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7D10", Offset = "0x7AF7110", VA = "0x187AF7D10")]
		private void KLMKFAKPPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8030", Offset = "0x7AF7430", VA = "0x187AF8030")]
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
		private bool AJJAHBBECEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material PJNHKNAHALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private HDCOEEHMINI CBHBLHCAGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material IJEGDAADGFH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private FNGPNEODCPE MMKAEDBDJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7AF88C0", Offset = "0x7AF7CC0", VA = "0x187AF88C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HDCOEEHMINI CKHMNBKNMOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7AF8B40", Offset = "0x7AF7F40", VA = "0x187AF8B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material HAHNBHGCILK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7AF8B70", Offset = "0x7AF7F70", VA = "0x187AF8B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8AA0", Offset = "0x7AF7EA0", VA = "0x187AF8AA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF83B0", Offset = "0x7AF77B0", VA = "0x187AF83B0", Slot = "8")]
		protected override void FIHMMOFJFKP(BBCFOAABFHH IIMBHKLPEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8AB0", Offset = "0x7AF7EB0", VA = "0x187AF8AB0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] GPENADMOHBF HIGDCKPKNFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8950", Offset = "0x7AF7D50", VA = "0x187AF8950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7AF85A0", Offset = "0x7AF79A0", VA = "0x187AF85A0")]
		private void LDCHBEEFPCC(bool IMJBLFBLNHJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9E6F80", Offset = "0x9E6380", VA = "0x1809E6F80")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct OAONECNJCHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly HDCOEEHMINI OFLKFNNMOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int OFOBFHNLNBE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7170", Offset = "0x7AF6570", VA = "0x187AF7170")]
	internal CPPKLECJPKP BONEKPDLCAG()
	{
		return default(CPPKLECJPKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26ED2A0", Offset = "0x26EC6A0", VA = "0x1826ED2A0")]
	internal OAONECNJCHA(HDCOEEHMINI BIGODBDFGBM, int NCOAGHNKOLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FEFDLKLKOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7AF39F0", Offset = "0x7AF2DF0", VA = "0x187AF39F0")]
	public static bool GBLMHMBOKNJ(this OAONECNJCHA FNEBLPMGKDJ, GMAOAOHKAEA CECOHCJLEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3A40", Offset = "0x7AF2E40", VA = "0x187AF3A40")]
	internal static bool GBLMHMBOKNJ(this CPPKLECJPKP NHNGPBAJKKC, GMAOAOHKAEA CECOHCJLEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7AF39B0", Offset = "0x7AF2DB0", VA = "0x187AF39B0")]
	public static float FKAMGFGHEOH(this OAONECNJCHA FNEBLPMGKDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xCF3E70", Offset = "0xCF3270", VA = "0x180CF3E70")]
	internal static float FKAMGFGHEOH(this CPPKLECJPKP NHNGPBAJKKC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BKPCIIPKGIE
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3530", Offset = "0x7AF2930", VA = "0x187AF3530")]
	public static void MBFCEDEHDEK(this OAONECNJCHA FNEBLPMGKDJ, ReadOnlySpan<char> DBEBCJLCBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3330", Offset = "0x7AF2730", VA = "0x187AF3330")]
	internal static void MBFCEDEHDEK(this CPPKLECJPKP NHNGPBAJKKC, ReadOnlySpan<char> DBEBCJLCBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3590", Offset = "0x7AF2990", VA = "0x187AF3590")]
	public static void OCIFGGBIOBN(this OAONECNJCHA LOCBKININKE, float2 CGLFFBCAJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF35E0", Offset = "0x7AF29E0", VA = "0x187AF35E0")]
	internal static void OCIFGGBIOBN(this CPPKLECJPKP NHNGPBAJKKC, float2 CGLFFBCAJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3280", Offset = "0x7AF2680", VA = "0x187AF3280")]
	public static void LGCIGBPMOBI(this OAONECNJCHA LOCBKININKE, float OOAFALIFNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7AF32F0", Offset = "0x7AF26F0", VA = "0x187AF32F0")]
	internal static void LGCIGBPMOBI(this CPPKLECJPKP NHNGPBAJKKC, float OOAFALIFNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3580", Offset = "0x7AF2980", VA = "0x187AF3580")]
	internal static void NHNCCIDNICK(this CPPKLECJPKP NHNGPBAJKKC, bool MDMOJBMJELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7AF31D0", Offset = "0x7AF25D0", VA = "0x187AF31D0")]
	public static void IHPFFBBGFFL(this OAONECNJCHA LOCBKININKE, Color32 JLFKDHGAEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7AF31C0", Offset = "0x7AF25C0", VA = "0x187AF31C0")]
	internal static void IHPFFBBGFFL(this CPPKLECJPKP NHNGPBAJKKC, Color32 JLFKDHGAEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3230", Offset = "0x7AF2630", VA = "0x187AF3230")]
	public static void LALFOKFDLAN(this OAONECNJCHA LOCBKININKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3270", Offset = "0x7AF2670", VA = "0x187AF3270")]
	internal static void LALFOKFDLAN(this CPPKLECJPKP NHNGPBAJKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3150", Offset = "0x7AF2550", VA = "0x187AF3150")]
	internal static void BGIPOELHMOL(this CPPKLECJPKP NHNGPBAJKKC, int FDHENCPCBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3210", Offset = "0x7AF2610", VA = "0x187AF3210")]
	internal static void KCAJDJHJJAH(this CPPKLECJPKP NHNGPBAJKKC, int KAACHPDFMBM, GMAOAOHKAEA GOFEGKGPKOC = GMAOAOHKAEA.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class JIGEAEDOIAB : IEquatable<JIGEAEDOIAB>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort BEPKKIKBBBK = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int DEMEPGKCJAM = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly JIGEAEDOIAB COELEANAKAO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort AAIPGBLOBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC16D40", Offset = "0xC16140", VA = "0x180C16D40")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC16D50", Offset = "0xC16150", VA = "0x180C16D50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HDCOEEHMINI OFLKFNNMOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CMMDKLGDPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AED5A0", Offset = "0x7AEC9A0", VA = "0x187AED5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7AED640", Offset = "0x7AECA40", VA = "0x187AED640")]
	public JIGEAEDOIAB(int BGOMJMEGMDI, HDCOEEHMINI BIGODBDFGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5FD0", Offset = "0x7AF53D0", VA = "0x187AF5FD0")]
	public bool KONLNEGDPJM([Out] OAONECNJCHA FNEBLPMGKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5E50", Offset = "0x7AF5250", VA = "0x187AF5E50")]
	public void AOLPCAOCNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7AED370", Offset = "0x7AEC770", VA = "0x187AED370")]
	internal void BDGFNHINFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7AED3A0", Offset = "0x7AEC7A0", VA = "0x187AED3A0", Slot = "4")]
	public bool Equals(JIGEAEDOIAB DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5EA0", Offset = "0x7AF52A0", VA = "0x187AF5EA0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5F60", Offset = "0x7AF5360", VA = "0x187AF5F60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HDCOEEHMINI : IDisposable, LODJPNFDKOD
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string JMPLLLFGFOI = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker FCKINGKJBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string ICKGLOLEKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly DAIEGDEBACE FGJADDOICBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int CONICPNODHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal CPPKLECJPKP[] FNFKMDKPLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal JIGEAEDOIAB[] GFBIDMMKBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private FNGPNEODCPE PIHCCHOCAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PJAMOAFAFNN KKNBFMEGNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly MGOIAFADCNB KJIIOOLMMMO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string KCCMEIDBNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4B90", Offset = "0x7AF3F90", VA = "0x187AF4B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FNGPNEODCPE HGLKNPNKHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7AF48E0", Offset = "0x7AF3CE0", VA = "0x187AF48E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float PMOAKMLDJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4900", Offset = "0x7AF3D00", VA = "0x187AF4900")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float GOJFPGOHPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4860", Offset = "0x7AF3C60", VA = "0x187AF4860")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LODJPNFDKOD.DHONADNDFEF DBJLNMLEHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7D0", Offset = "0x9CCBD0", VA = "0x1809CD7D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9CD850", Offset = "0x9CCC50", VA = "0x1809CD850", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5990", Offset = "0x7AF4D90", VA = "0x187AF5990")]
	public HDCOEEHMINI(DAIEGDEBACE ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5DD0", Offset = "0x7AF51D0", VA = "0x187AF5DD0")]
	public HDCOEEHMINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4710", Offset = "0x7AF3B10", VA = "0x187AF4710")]
	public void HGEPFBBIJLL(GlyphMapAsset JNGIMJLCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4750", Offset = "0x7AF3B50", VA = "0x187AF4750")]
	public void HGEPFBBIJLL(FNGPNEODCPE HNBEEEEFKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AF56F0", Offset = "0x7AF4AF0", VA = "0x187AF56F0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] GPENADMOHBF HIGDCKPKNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF46B0", Offset = "0x7AF3AB0", VA = "0x187AF46B0")]
	public void EBFFGAJDDMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4E00", Offset = "0x7AF4200", VA = "0x187AF4E00")]
	public bool MMNMKCKJLBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4920", Offset = "0x7AF3D20", VA = "0x187AF4920")]
	public JIGEAEDOIAB LDEJFFDMMAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5160", Offset = "0x7AF4560", VA = "0x187AF5160")]
	public void NOPACLOKBDL(JIGEAEDOIAB KGJPOCMMOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5640", Offset = "0x7AF4A40", VA = "0x187AF5640")]
	internal bool PONECGCLCLG(JIGEAEDOIAB KGJPOCMMOEF, [Out] OAONECNJCHA FNEBLPMGKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7AF54C0", Offset = "0x7AF48C0", VA = "0x187AF54C0")]
	private void OPIJBHOPIPO(CPPKLECJPKP NHNGPBAJKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4C20", Offset = "0x7AF4020", VA = "0x187AF4C20")]
	private void MJIDEEDOPND(int BJFKGPENLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4880", Offset = "0x7AF3C80", VA = "0x187AF4880")]
	private bool ICAHBLOGEGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA7D0", Offset = "0x7AE9BD0", VA = "0x187AEA7D0")]
	private static int ANLGDPFFLFO(JIGEAEDOIAB KGJPOCMMOEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x206FEE0", Offset = "0x206F2E0", VA = "0x18206FEE0")]
	private static ushort OPIOKFGJGJB(int COPLIEINKOF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4E50", Offset = "0x7AF4250", VA = "0x187AF4E50")]
	private Bounds NBNPHHFBNLJ()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4600", Offset = "0x7AF3A00", VA = "0x187AF4600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DAIEGDEBACE
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DAIEGDEBACE JDLNJNCJEFN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float DBGMEPNNPDB = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int ABAPPBNGPIE = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int IBEEFNGEGIO = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color MJNNLPPLKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float FMAOEBPBGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int EDDMKAANAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int KKGJOKJEEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int HAHECCAOBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int KGJDOBDFMFP;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3640", Offset = "0x7AF2A40", VA = "0x187AF3640")]
	internal DAIEGDEBACE ICBLABFHIFI()
	{
		return default(DAIEGDEBACE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBC50", Offset = "0x7AEB050", VA = "0x187AEBC50")]
	[CompilerGenerated]
	internal static void HDOKNHMEHCL(int OOEMJLHLIHJ, int JMBBJHIBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3750", Offset = "0x7AF2B50", VA = "0x187AF3750")]
	[CompilerGenerated]
	internal static void OBCJIHMFBKO(float OOEMJLHLIHJ, float JMBBJHIBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBD00", Offset = "0x7AEB100", VA = "0x187AEBD00")]
	[CompilerGenerated]
	internal static void LDNDOEJBHAN(int OOEMJLHLIHJ, int ELFANKLFNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3620", Offset = "0x7AF2A20", VA = "0x187AF3620")]
	[CompilerGenerated]
	internal static void HGHNGBKPIPD(float OOEMJLHLIHJ, float ELFANKLFNEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JLMMAKKCCGM
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6130", Offset = "0x7AF5530", VA = "0x187AF6130")]
	public static float NHALJJGNOCJ(this OAONECNJCHA KFGOHOHODEK)
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
		public readonly JIGEAEDOIAB textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8340", Offset = "0x7AF7740", VA = "0x187AF8340")]
		public TextSegmentLayout(LayoutRect layoutRect, JIGEAEDOIAB textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8110", Offset = "0x7AF7510", VA = "0x187AF8110")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8180", Offset = "0x7AF7580", VA = "0x187AF8180")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7AF80B0", Offset = "0x7AF74B0", VA = "0x187AF80B0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class PJAMOAFAFNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig DGBBPGIPMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float PPDKJIIACAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float JNANFOOHMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float ALJNAMANPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float KLOEIBOBNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float EDIBKHNFALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float HMOKJKKOBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float LNILNFHFPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float LMILNJINKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float PFDDCBNOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float GOJFPGOHPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float PGCHHKCMAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float PMOAKMLDJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MKIHCBDOJMG[] BKFBPFMMCIN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int JHBJDNMGIAO = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private CGHGKLMILIE[] OLACPIKKGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int NJBNELFGEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private BHNKMBFJPHP[] PKFPIGKGDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int MPIIBFHIBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MKIHCBDOJMG PEDAGPAOOJM;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7AF76F0", Offset = "0x7AF6AF0", VA = "0x187AF76F0")]
	public void HGEPFBBIJLL(FNGPNEODCPE LBOCGJAFGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7780", Offset = "0x7AF6B80", VA = "0x187AF7780")]
	public void HGEPFBBIJLL(GlyphUVConfig HOJGOPCPABM, IEnumerable<BHNKMBFJPHP> JNGIMJLCIKK, BHNKMBFJPHP HJJKAPFJOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7800", Offset = "0x7AF6C00", VA = "0x187AF7800")]
	internal void KEIEONKGMFC(GlyphUVConfig HOJGOPCPABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF71B0", Offset = "0x7AF65B0", VA = "0x187AF71B0")]
	private void FOGPNAFHDDH(IEnumerable<BHNKMBFJPHP> JNGIMJLCIKK, BHNKMBFJPHP HJJKAPFJOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7940", Offset = "0x7AF6D40", VA = "0x187AF7940")]
	public void OGNGGFBICAE([In] char JAMONCOAOGB, [Out] float2[] DGKKKOEKKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3020", Offset = "0x7AF2420", VA = "0x187AF3020")]
	private MKIHCBDOJMG PCFLOLIFHMF(BHNKMBFJPHP HMKNEFHNPDG)
	{
		return default(MKIHCBDOJMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7C70", Offset = "0x7AF7070", VA = "0x187AF7C70")]
	public PJAMOAFAFNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EIAPFLLCIFK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3820", Offset = "0x7AF2C20", VA = "0x187AF3820")]
	public static void CPIOPLMCECH([In] float EAKENHOFPPO, [In] float MAOMKNNBOGJ, [In] int ODPPKMNGLAK, [In] int KAMJOAIPFDD, [In] float KLOEIBOBNLI, [In] float EDIBKHNFALA, [In] float AGHKBAACBBL, [In] float HIAFMHGJHLE, [In] float LMFLHFPMNAK, [In] float NMLBBIJIGGO, [Out] float CEMDFJBOGBH, [Out] float LOKLHPHMCML, [Out] float NJDIEKIAODK, [Out] float CJNPGAGIIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7AF38F0", Offset = "0x7AF2CF0", VA = "0x187AF38F0")]
	public static void CPIOPLMCECH([In] float EAKENHOFPPO, [In] float MAOMKNNBOGJ, [In] int ODPPKMNGLAK, [In] int KAMJOAIPFDD, [Out] float CEMDFJBOGBH, [Out] float LOKLHPHMCML, [Out] float NJDIEKIAODK, [Out] float CJNPGAGIIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3950", Offset = "0x7AF2D50", VA = "0x187AF3950")]
	public static void DFKMBNBMDCC([In] float KLOEIBOBNLI, [In] float EDIBKHNFALA, [In] float IEPKHLOHDMH, [In] float FMLFJBJKPDG, [In] float IDNJPIIEOLH, [In] float IPACOBPBMCJ, [Out] float LJJBAJBCBPC, [Out] float MGAIHOLKOAN, [Out] float ENCHNBHNKIE, [Out] float NCJBPDCCKBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct CGHGKLMILIE
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint IGGPDDDNLJI = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char LONFAGDECFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly MKIHCBDOJMG NIHLLEACDOA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7AF35F0", Offset = "0x7AF29F0", VA = "0x187AF35F0")]
	public CGHGKLMILIE(char JAMONCOAOGB, MKIHCBDOJMG DGKKKOEKKIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MKIHCBDOJMG
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint IGGPDDDNLJI = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] JLBLEIJACDB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6FC0", Offset = "0x7AF63C0", VA = "0x187AF6FC0")]
	public MKIHCBDOJMG(float CEMDFJBOGBH, float LOKLHPHMCML, float NJDIEKIAODK, float CJNPGAGIIEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct CPPKLECJPKP
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int CFHAHHKNPCP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal GMAOAOHKAEA GOFEGKGPKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] GLCPHBEJNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int PNHDBGLFFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 CGLFFBCAJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float CEHNDCPGCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 OGNCECPDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool MDMOJBMJELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int CPBDOIGKODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int NCHPIADJIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int LNPHBFHLBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int LEDNDCPGNHL;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3610", Offset = "0x7AF2A10", VA = "0x187AF3610")]
	public static int MIHKDHEPAOG(int MLJOKIKMIIO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum GMAOAOHKAEA : byte
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
public static class MOIJHNNKDJM
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7AF70B0", Offset = "0x7AF64B0", VA = "0x187AF70B0")]
	internal static float NHALJJGNOCJ(this CPPKLECJPKP NHNGPBAJKKC, float NFOGAGGGBFJ, float EFBELKHPCHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7AF70F0", Offset = "0x7AF64F0", VA = "0x187AF70F0")]
	internal static void OKFKCDPNPMJ(this CPPKLECJPKP NHNGPBAJKKC, float NFOGAGGGBFJ, float EFBELKHPCHM, [Out] float2 JLCBKIPFKML, [Out] float2 CBHAMKJGEOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class MGOIAFADCNB : LODJPNFDKOD
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int ACACJCGMPEL = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int DPJBKGCACBA = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string JMPLLLFGFOI = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker AFFJLIPMOOH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker AMONNIIOJMO;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker EPMOKIBIFDB;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker OCADHICMJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly GPENADMOHBF HIGDCKPKNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] FGMBPLPLBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] PDCABNMKCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int DLNLLDINIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HDEGNBIKHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int NFHIDJBFCPK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string KCCMEIDBNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LODJPNFDKOD.DHONADNDFEF DBJLNMLEHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6EB0", Offset = "0x7AF62B0", VA = "0x187AF6EB0")]
	public MGOIAFADCNB(GPENADMOHBF.JPKMDDGKGOE PJODDFIPGLO, int JNMKAJPMKGK, int NINAFMCIFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6D20", Offset = "0x7AF6120", VA = "0x187AF6D20", Slot = "5")]
	public bool TryGetMeshBuffer([Out] GPENADMOHBF HIGDCKPKNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6D00", Offset = "0x7AF6100", VA = "0x187AF6D00")]
	public void KMHCNJOMAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6520", Offset = "0x7AF5920", VA = "0x187AF6520")]
	public void KKMHPNGCFLN(Span<CPPKLECJPKP> ONNOFNIECMC, PJAMOAFAFNN ECLDNBGGCHP, [In] DAIEGDEBACE ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7AF16A0", Offset = "0x7AF0AA0", VA = "0x187AF16A0")]
	private void DJBLAOMLGNF([In] GMAOAOHKAEA GOFEGKGPKOC, [In] CPPKLECJPKP PGFOJJHOHLP, int POAGDDKOJJP, [In] float NFOGAGGGBFJ, [In] float EFBELKHPCHM, PJAMOAFAFNN ECLDNBGGCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7AF61C0", Offset = "0x7AF55C0", VA = "0x187AF61C0")]
	private void AMLKGENFFPG([In] GMAOAOHKAEA GOFEGKGPKOC, CPPKLECJPKP PGFOJJHOHLP, [In] int HHHHCNDHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6310", Offset = "0x7AF5710", VA = "0x187AF6310")]
	public static void DHPJCNOABEO(ReadOnlySpan<CPPKLECJPKP> ONNOFNIECMC, int LOILEHDGHEF, [Out] int DECIEOPLBIM, [Out] int ICFFJHJIAKL, [Out] int PDNCGAEBEBJ)
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
