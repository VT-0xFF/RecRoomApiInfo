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
public class KGMMFFIBLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D IMMBMDKINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig ILCEAMFBPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public BONBPBEFGNE[] ICELIINPHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public BONBPBEFGNE NHPGOICFICG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static KGMMFFIBLOC LGCNHDINMGF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KGMMFFIBLOC KBPJCNMOADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75E29C0", Offset = "0x75E1DC0", VA = "0x1875E29C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public KGMMFFIBLOC()
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
		[Cpp2IlInjected.Address(RVA = "0x75E1120", Offset = "0x75E0520", VA = "0x1875E1120")]
		public GlyphUVConfig(int NFGGMONIOJP, int NIDMDBDKBAA, int MMJNGBAGGIJ, int CHDIHIKJIKH, float JNIALBNBOIE = 0f, [Optional] GlyphPixelInset LOEINHPILMH)
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
public readonly struct BONBPBEFGNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char FNIMIFDLMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int GFGCMHLGODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int LENLGGJCCGC;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly BONBPBEFGNE JPJIIDGLKHG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75DF390", Offset = "0x75DE790", VA = "0x1875DF390")]
	public BONBPBEFGNE(char CCFCNFIANHA, int HGJNJCINBAF, int FDGEIJCMMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75DF370", Offset = "0x75DE770", VA = "0x1875DF370")]
	public BONBPBEFGNE(GlyphCoordinateWritable ILCIBKMBLFL)
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
		[Cpp2IlInjected.Address(RVA = "0x75E0740", Offset = "0x75DFB40", VA = "0x1875E0740")]
		public static BONBPBEFGNE JKGHIELMIOO(GlyphCoordinateWritable FBGCPEAGLNC)
		{
			return default(BONBPBEFGNE);
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
		private KGMMFFIBLOC configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x75E1020", Offset = "0x75E0420", VA = "0x1875E1020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x75E0EA0", Offset = "0x75E02A0", VA = "0x1875E0EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x75E0E90", Offset = "0x75E0290", VA = "0x1875E0E90")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public KGMMFFIBLOC ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x75E0890", Offset = "0x75DFC90", VA = "0x1875E0890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BONBPBEFGNE FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x75E0D00", Offset = "0x75E0100", VA = "0x1875E0D00")]
			get
			{
				return default(BONBPBEFGNE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75E0760", Offset = "0x75DFB60", VA = "0x1875E0760")]
		internal void OCHAHMBCABI(IEnumerable<GlyphCoordinateWritable> OJFHDMFJGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75E0800", Offset = "0x75DFC00", VA = "0x1875E0800")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75E07E0", Offset = "0x75DFBE0", VA = "0x1875E07E0")]
		[CompilerGenerated]
		private bool OHAGBCFIFBO(GlyphCoordinateWritable FBGCPEAGLNC)
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
		private TextSegmentMeshBufferSource GNJILLMPCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private IAAFAKHGOKF GJHBJGKPALD;

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
		private BMCOJINPHNG KHOGKJGOCIL;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75E3F00", Offset = "0x75E3300", VA = "0x1875E3F00")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75E3EB0", Offset = "0x75E32B0", VA = "0x1875E3EB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75E3CD0", Offset = "0x75E30D0", VA = "0x1875E3CD0")]
		private void CDPCIJOJEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75E3FF0", Offset = "0x75E33F0", VA = "0x1875E3FF0")]
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
		private bool MPDIPAAJLDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material LOGLIOGEFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IAAFAKHGOKF GJHBJGKPALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material GIOCDDLBDJM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private KGMMFFIBLOC NICACFAJFHO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x75E4550", Offset = "0x75E3950", VA = "0x1875E4550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IAAFAKHGOKF IFGAFAECIHK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x75E4AF0", Offset = "0x75E3EF0", VA = "0x1875E4AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material HGNBLEJOHPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x75E4B20", Offset = "0x75E3F20", VA = "0x1875E4B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x75E4A50", Offset = "0x75E3E50", VA = "0x1875E4A50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75E4370", Offset = "0x75E3770", VA = "0x1875E4370", Slot = "8")]
		protected override void DOAFGMMGEEF(EJLBCKLAEPP BIEJJBFKEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75E4A60", Offset = "0x75E3E60", VA = "0x1875E4A60", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] CIHOENGMDKI OAEGBKMAFCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75E4900", Offset = "0x75E3D00", VA = "0x1875E4900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x75E45E0", Offset = "0x75E39E0", VA = "0x1875E45E0")]
		private void OLOGDFPLCNB(bool JLJMBNIAGMB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x982780", Offset = "0x981B80", VA = "0x180982780")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct NPMLJGPALHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly IAAFAKHGOKF ECFGMLBKGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int CINNCIHOKHA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75E2CB0", Offset = "0x75E20B0", VA = "0x1875E2CB0")]
	internal AIBNPIEBMKI JGPJOCJJAGE()
	{
		return default(AIBNPIEBMKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25AA4F0", Offset = "0x25A98F0", VA = "0x1825AA4F0")]
	internal NPMLJGPALHE(IAAFAKHGOKF FDIJEKJEAKE, int GKLCAAFBFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PHPEMIFHEOH
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75E3C60", Offset = "0x75E3060", VA = "0x1875E3C60")]
	public static bool GLHLOLNLCNN(this NPMLJGPALHE BNJENKKIPML, HHDJKLOCEJP EAJOBPAIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75E3CB0", Offset = "0x75E30B0", VA = "0x1875E3CB0")]
	internal static bool GLHLOLNLCNN(this AIBNPIEBMKI INFHPDCEBLC, HHDJKLOCEJP EAJOBPAIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75E3C20", Offset = "0x75E3020", VA = "0x1875E3C20")]
	public static float FDPHFMMHACD(this NPMLJGPALHE BNJENKKIPML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC30870", Offset = "0xC2FC70", VA = "0x180C30870")]
	internal static float FDPHFMMHACD(this AIBNPIEBMKI INFHPDCEBLC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GDLOMKDKACM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75DFA10", Offset = "0x75DEE10", VA = "0x1875DFA10")]
	public static void JCCFDKIHJJF(this NPMLJGPALHE BNJENKKIPML, ReadOnlySpan<char> DMJIGACOPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75DF810", Offset = "0x75DEC10", VA = "0x1875DF810")]
	internal static void JCCFDKIHJJF(this AIBNPIEBMKI INFHPDCEBLC, ReadOnlySpan<char> DMJIGACOPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75DFB70", Offset = "0x75DEF70", VA = "0x1875DFB70")]
	public static void OCPKBMDHHJO(this NPMLJGPALHE NBCDHBHONND, float2 HACFNABHKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x75DFB60", Offset = "0x75DEF60", VA = "0x1875DFB60")]
	internal static void OCPKBMDHHJO(this AIBNPIEBMKI INFHPDCEBLC, float2 HACFNABHKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75DFAA0", Offset = "0x75DEEA0", VA = "0x1875DFAA0")]
	public static void NCMGCHHNMPP(this NPMLJGPALHE NBCDHBHONND, float MCNPKBNEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75DFA60", Offset = "0x75DEE60", VA = "0x1875DFA60")]
	internal static void NCMGCHHNMPP(this AIBNPIEBMKI INFHPDCEBLC, float MCNPKBNEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75DFBC0", Offset = "0x75DEFC0", VA = "0x1875DFBC0")]
	internal static void PKMMCLOFCMI(this AIBNPIEBMKI INFHPDCEBLC, bool BCDCHNBEMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x75DFB20", Offset = "0x75DEF20", VA = "0x1875DFB20")]
	public static void NJNHHICIILD(this NPMLJGPALHE NBCDHBHONND, Color32 MLLLJKFOPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75DFB10", Offset = "0x75DEF10", VA = "0x1875DFB10")]
	internal static void NJNHHICIILD(this AIBNPIEBMKI INFHPDCEBLC, Color32 MLLLJKFOPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75DF740", Offset = "0x75DEB40", VA = "0x1875DF740")]
	public static void CJAOPBHKDGK(this NPMLJGPALHE NBCDHBHONND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x75DF730", Offset = "0x75DEB30", VA = "0x1875DF730")]
	internal static void CJAOPBHKDGK(this AIBNPIEBMKI INFHPDCEBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75DF7A0", Offset = "0x75DEBA0", VA = "0x1875DF7A0")]
	internal static void HEIOGPHMDME(this AIBNPIEBMKI INFHPDCEBLC, int IPGHODHEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x75DF780", Offset = "0x75DEB80", VA = "0x1875DF780")]
	internal static void CPNPOBGCLJG(this AIBNPIEBMKI INFHPDCEBLC, int GDGACEKLJFH, HHDJKLOCEJP IICECOKLAHH = HHDJKLOCEJP.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BMCOJINPHNG : IEquatable<BMCOJINPHNG>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort PHDNBAPKAAA = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int AOEGPEFKEKN = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly BMCOJINPHNG KNLJPCJIMFG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort BFOPMHAACBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB3FEA0", Offset = "0xB3F2A0", VA = "0x180B3FEA0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB3FEB0", Offset = "0xB3F2B0", VA = "0x180B3FEB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IAAFAKHGOKF ECFGMLBKGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DAHIKGIHLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75D8AA0", Offset = "0x75D7EA0", VA = "0x1875D8AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x75D8B40", Offset = "0x75D7F40", VA = "0x1875D8B40")]
	public BMCOJINPHNG(int KBHOALLEGDJ, IAAFAKHGOKF FDIJEKJEAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x75DF040", Offset = "0x75DE440", VA = "0x1875DF040")]
	public bool ADMOLHNDADP([Out] NPMLJGPALHE BNJENKKIPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x75DF110", Offset = "0x75DE510", VA = "0x1875DF110")]
	public void BOJBCJAFPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75D8820", Offset = "0x75D7C20", VA = "0x1875D8820")]
	internal void AKEOJLAKAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x75D89D0", Offset = "0x75D7DD0", VA = "0x1875D89D0", Slot = "4")]
	public bool Equals(BMCOJINPHNG MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x75DF160", Offset = "0x75DE560", VA = "0x1875DF160", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x75DF220", Offset = "0x75DE620", VA = "0x1875DF220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class IAAFAKHGOKF : IDisposable, JOOHLKLABLN
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string PHNIIFMBGGC = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker OJEHOKGAOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string FNDJMLKJIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly EBGEDMPJJAN KFJKKEKKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int LCLJHHBKGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal AIBNPIEBMKI[] OHMBHPAKCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal BMCOJINPHNG[] FHLABDOBFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private KGMMFFIBLOC AFOOMFMLBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GFOAIBFKNIE HDICGJANMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly ONKFLAEFHGM ABOBFFEEILM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string OGOCCCFKJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75E17E0", Offset = "0x75E0BE0", VA = "0x1875E17E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public KGMMFFIBLOC ELINDPONFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x75E1D00", Offset = "0x75E1100", VA = "0x1875E1D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float IKBJGLEFPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75E13B0", Offset = "0x75E07B0", VA = "0x1875E13B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float LIEJOFCIJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75E2030", Offset = "0x75E1430", VA = "0x1875E2030")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JOOHLKLABLN.BIADPFCNNNE DIHONCGAJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9650B0", Offset = "0x9644B0", VA = "0x1809650B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9650C0", Offset = "0x9644C0", VA = "0x1809650C0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x75E2500", Offset = "0x75E1900", VA = "0x1875E2500")]
	public IAAFAKHGOKF(EBGEDMPJJAN FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75E2940", Offset = "0x75E1D40", VA = "0x1875E2940")]
	public IAAFAKHGOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75E1DD0", Offset = "0x75E11D0", VA = "0x1875E1DD0")]
	public void MEKFCHHLHOB(GlyphMapAsset ANGLPJABFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x75E1E10", Offset = "0x75E1210", VA = "0x1875E1E10")]
	public void MEKFCHHLHOB(KGMMFFIBLOC KJFFIGCPHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x75E2230", Offset = "0x75E1630", VA = "0x1875E2230", Slot = "6")]
	public bool TryGetMeshBuffer([Out] CIHOENGMDKI OAEGBKMAFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x75E1D20", Offset = "0x75E1120", VA = "0x1875E1D20")]
	public void IFDKLGOKICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75E1D80", Offset = "0x75E1180", VA = "0x1875E1D80")]
	public bool JBAJBLEICPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75E1150", Offset = "0x75E0550", VA = "0x1875E1150")]
	public BMCOJINPHNG ACPJPAOABNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75E1480", Offset = "0x75E0880", VA = "0x1875E1480")]
	public void HENKFKDJPGH(BMCOJINPHNG AOACPEPIPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x75E1F20", Offset = "0x75E1320", VA = "0x1875E1F20")]
	internal bool MPEAACLGKJG(BMCOJINPHNG AOACPEPIPID, [Out] NPMLJGPALHE BNJENKKIPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x75E1B80", Offset = "0x75E0F80", VA = "0x1875E1B80")]
	private void HJEILNMHJNF(AIBNPIEBMKI INFHPDCEBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x75E2050", Offset = "0x75E1450", VA = "0x1875E2050")]
	private void PONODNDJEIP(int DANHEMCNLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x75E1FD0", Offset = "0x75E13D0", VA = "0x1875E1FD0")]
	private bool NGOBHKBMBAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75D62F0", Offset = "0x75D56F0", VA = "0x1875D62F0")]
	private static int DLLMBKNAJMF(BMCOJINPHNG AOACPEPIPID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F0BE90", Offset = "0x1F0B290", VA = "0x181F0BE90")]
	private static ushort HBAEILFDLME(int FFCBHHABFJN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x75E1870", Offset = "0x75E0C70", VA = "0x1875E1870")]
	private Bounds HFNDLLPIFHM()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x75E13D0", Offset = "0x75E07D0", VA = "0x1875E13D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EBGEDMPJJAN
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly EBGEDMPJJAN BNICHKLBNLG;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float CLFAJCIPOCC = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LPIKIEPLDCL = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int GFCDCAJNMDF = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color AKFEAJFPODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float BDJELCEAMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int EOMPJJHNCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int KDDCDPPENBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int FGLLBNJEIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int DKKPEDNINFN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75DF530", Offset = "0x75DE930", VA = "0x1875DF530")]
	internal EBGEDMPJJAN CFCIBPDICGO()
	{
		return default(EBGEDMPJJAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75DCD50", Offset = "0x75DC150", VA = "0x1875DCD50")]
	[CompilerGenerated]
	internal static void APCEEJNNKOF(int PEBNJNGMMHE, int CIKOELCEFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75DF660", Offset = "0x75DEA60", VA = "0x1875DF660")]
	[CompilerGenerated]
	internal static void NFNBOBMFCCA(float PEBNJNGMMHE, float CIKOELCEFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x75DCE00", Offset = "0x75DC200", VA = "0x1875DCE00")]
	[CompilerGenerated]
	internal static void MJIMEKMKJLD(int PEBNJNGMMHE, int APKBIIBABID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x75DF640", Offset = "0x75DEA40", VA = "0x1875DF640")]
	[CompilerGenerated]
	internal static void EGPJOMHHBPI(float PEBNJNGMMHE, float APKBIIBABID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LPDGJFFOJGF
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75E2B30", Offset = "0x75E1F30", VA = "0x1875E2B30")]
	public static float ENMKNFGLJNO(this NPMLJGPALHE MCHCCGKGADH)
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
		public readonly BMCOJINPHNG textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75E4300", Offset = "0x75E3700", VA = "0x1875E4300")]
		public TextSegmentLayout(LayoutRect layoutRect, BMCOJINPHNG textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x75E40D0", Offset = "0x75E34D0", VA = "0x1875E40D0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75E4140", Offset = "0x75E3540", VA = "0x1875E4140")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x75E4070", Offset = "0x75E3470", VA = "0x1875E4070")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class GFOAIBFKNIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig LGEBFOJMAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float EHHHAOHOJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float MLCADAACNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float IJJGIEIMKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float MCGINPFJLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float KKKFHIDIGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float OFIOKMIAKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float PJFHBBJDPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float JAOFNAFJANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float LEHHBLGBBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float LIEJOFCIJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float HAHHOJBKDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float IKBJGLEFPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MBELMNCGEMN[] FKBHJJADGPM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int LFHEJKLEDLB = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private GHHHEPPMFAJ[] PDHFAMJKECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int OOMCDACMANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private BONBPBEFGNE[] INMLNMGGJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int MPFBIEHHOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MBELMNCGEMN HFBLJKHELGE;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x75E0040", Offset = "0x75DF440", VA = "0x1875E0040")]
	public void MEKFCHHLHOB(KGMMFFIBLOC CMNGLELOFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75E00D0", Offset = "0x75DF4D0", VA = "0x1875E00D0")]
	public void MEKFCHHLHOB(GlyphUVConfig JHGNCPLJNON, IEnumerable<BONBPBEFGNE> ANGLPJABFNF, BONBPBEFGNE POIAHNMIIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x75DFF00", Offset = "0x75DF300", VA = "0x1875DFF00")]
	internal void FOJGEIFAEKK(GlyphUVConfig JHGNCPLJNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x75E0150", Offset = "0x75DF550", VA = "0x1875E0150")]
	private void NPBOGLEMGHG(IEnumerable<BONBPBEFGNE> ANGLPJABFNF, BONBPBEFGNE POIAHNMIIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x75DFBD0", Offset = "0x75DEFD0", VA = "0x1875DFBD0")]
	public void AGIADPJEFIN([In] char CCFCNFIANHA, [Out] float2[] MEKJPCEGDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75DD520", Offset = "0x75DC920", VA = "0x1875DD520")]
	private MBELMNCGEMN DMAALPKEMKB(BONBPBEFGNE ILCIBKMBLFL)
	{
		return default(MBELMNCGEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75E0680", Offset = "0x75DFA80", VA = "0x1875E0680")]
	public GFOAIBFKNIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BPFOAPBAMDA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75DF400", Offset = "0x75DE800", VA = "0x1875DF400")]
	public static void LKLFCNEKGBE([In] float EAHNPIMMFMM, [In] float FNFJKNGCJBI, [In] int FBCNFLPOAPD, [In] int PGMANEPIOLI, [In] float MCGINPFJLIF, [In] float KKKFHIDIGLN, [In] float CLOLCGBJECE, [In] float GIIBGCEIMPA, [In] float IGMMFGJINIM, [In] float KFHEKMBBMPJ, [Out] float BFLFEAKCKHL, [Out] float JIDLGKJCDNN, [Out] float BIBBNIKPCLE, [Out] float JEOCOIPKJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x75DF4D0", Offset = "0x75DE8D0", VA = "0x1875DF4D0")]
	public static void LKLFCNEKGBE([In] float EAHNPIMMFMM, [In] float FNFJKNGCJBI, [In] int FBCNFLPOAPD, [In] int PGMANEPIOLI, [Out] float BFLFEAKCKHL, [Out] float JIDLGKJCDNN, [Out] float BIBBNIKPCLE, [Out] float JEOCOIPKJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x75DF3A0", Offset = "0x75DE7A0", VA = "0x1875DF3A0")]
	public static void EFELNAHFOHJ([In] float MCGINPFJLIF, [In] float KKKFHIDIGLN, [In] float HKPOPKHGEOD, [In] float NNPLLNNGONM, [In] float CDOEEIOOOIP, [In] float FMLHNKCKLKB, [Out] float IHPHLMIHNKB, [Out] float CMDHHGHKPGN, [Out] float NNDOPIHHOGG, [Out] float AEHCHAACEHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GHHHEPPMFAJ
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint DLIOBJHHLPE = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char FNIMIFDLMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly MBELMNCGEMN DHDECHJNPAC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x75E0720", Offset = "0x75DFB20", VA = "0x1875E0720")]
	public GHHHEPPMFAJ(char CCFCNFIANHA, MBELMNCGEMN MEKJPCEGDGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MBELMNCGEMN
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint DLIOBJHHLPE = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] JDJJHLPMONP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75E2BC0", Offset = "0x75E1FC0", VA = "0x1875E2BC0")]
	public MBELMNCGEMN(float BFLFEAKCKHL, float JIDLGKJCDNN, float BIBBNIKPCLE, float JEOCOIPKJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct AIBNPIEBMKI
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int KFNJKFCJGJG = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal HHDJKLOCEJP IICECOKLAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] NPPICAGPOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int IAFIIMFFNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 HACFNABHKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float NHJJPMLDKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 LIAEFNLPDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool BCDCHNBEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int HECDHHEHFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int MBIOFGEALJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int KEPFDLFMGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int HKDFGEJDHOJ;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x75DF030", Offset = "0x75DE430", VA = "0x1875DF030")]
	public static int DCCHPJPINIA(int IINIHOGEGCH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum HHDJKLOCEJP : byte
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
public static class AFLABCEIEHG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x75DEF70", Offset = "0x75DE370", VA = "0x1875DEF70")]
	internal static float ENMKNFGLJNO(this AIBNPIEBMKI INFHPDCEBLC, float GKLMGCKLCEM, float CKADDACHIAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x75DEFB0", Offset = "0x75DE3B0", VA = "0x1875DEFB0")]
	internal static void FAOOMAFHBBE(this AIBNPIEBMKI INFHPDCEBLC, float GKLMGCKLCEM, float CKADDACHIAB, [Out] float2 IKENCPHIKGM, [Out] float2 MNJHKANCBHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class ONKFLAEFHGM : JOOHLKLABLN
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int EFDAOPDGFEM = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int BGDNJDPEINC = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string PHNIIFMBGGC = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker NKJCJJHJGNF;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker MEMMFLHCAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker BNNJEOBFEKI;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker PHDBOJJOBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly CIHOENGMDKI OAEGBKMAFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] JMKMEJFJOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] HFFBCJFJEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int ONMODOMJDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int BFNAOPBBEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int ANKFECFOKFG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string OGOCCCFKJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public JOOHLKLABLN.BIADPFCNNNE DIHONCGAJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x75E3B10", Offset = "0x75E2F10", VA = "0x1875E3B10")]
	public ONKFLAEFHGM(CIHOENGMDKI.NGGHHEBIHCH DKPAFLEBKOH, int NPNDJEKOBDH, int BPBCEBIEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x75E3990", Offset = "0x75E2D90", VA = "0x1875E3990", Slot = "5")]
	public bool TryGetMeshBuffer([Out] CIHOENGMDKI OAEGBKMAFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x75E3820", Offset = "0x75E2C20", VA = "0x1875E3820")]
	public void GCMFJDLGLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x75E2CF0", Offset = "0x75E20F0", VA = "0x1875E2CF0")]
	public void EMCMCOHBNBI(Span<AIBNPIEBMKI> FDJHENIGLNB, GFOAIBFKNIE LICJGECDGFH, [In] EBGEDMPJJAN FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x75DE100", Offset = "0x75DD500", VA = "0x1875DE100")]
	private void PIMJMNKLKJG([In] HHDJKLOCEJP IICECOKLAHH, [In] AIBNPIEBMKI ACGDBAMHBJM, int NHABFBCKGJF, [In] float GKLMGCKLCEM, [In] float CKADDACHIAB, GFOAIBFKNIE LICJGECDGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x75E3840", Offset = "0x75E2C40", VA = "0x1875E3840")]
	private void JCEPGHPJEAL([In] HHDJKLOCEJP IICECOKLAHH, AIBNPIEBMKI ACGDBAMHBJM, [In] int PEHIFBJLDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x75E35F0", Offset = "0x75E29F0", VA = "0x1875E35F0")]
	public static void GANKMBPJNFC(ReadOnlySpan<AIBNPIEBMKI> FDJHENIGLNB, int CAEBKIAEHHK, [Out] int LIBLDKPIGDI, [Out] int NJAEIHHHCAP, [Out] int FNFNFHBPAFC)
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
