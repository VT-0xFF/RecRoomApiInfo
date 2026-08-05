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
public class IKMPKOEGBPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D PAGLLGMJNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig ONNCDMCLHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public KHODIGFFCJJ[] MGGFAGBIGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public KHODIGFFCJJ ENKOKPNAJMD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static IKMPKOEGBPK IAMEDALHLID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IKMPKOEGBPK NLIFDDJPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DEEF90", Offset = "0x6DED990", VA = "0x186DEEF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public IKMPKOEGBPK()
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
		[Cpp2IlInjected.Address(RVA = "0x6DEEDD0", Offset = "0x6DED7D0", VA = "0x186DEEDD0")]
		public GlyphUVConfig(int KFFGOALIIAK, int PCENLFFJHNF, int HDCNMEEPFKB, int GFMNACEPDDG, float KHHBLDLMKCL = 0f, [Optional] GlyphPixelInset OLNEFKEKKPJ)
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
public readonly struct KHODIGFFCJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char FBGADPIOHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int AJJDEJFNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int NJMENHOBNMH;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly KHODIGFFCJJ AMBMLHJAOND;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF170", Offset = "0x6DEDB70", VA = "0x186DEF170")]
	public KHODIGFFCJJ(char MNIBGEOAEHC, int EPCFJIPAPAE, int FAOCGKMIAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF150", Offset = "0x6DEDB50", VA = "0x186DEF150")]
	public KHODIGFFCJJ(GlyphCoordinateWritable JNFCIAOAGCM)
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
		[Cpp2IlInjected.Address(RVA = "0x6DEE3F0", Offset = "0x6DECDF0", VA = "0x186DEE3F0")]
		public static KHODIGFFCJJ OLKJPEKNNFN(GlyphCoordinateWritable CLNPLAGFLPF)
		{
			return default(KHODIGFFCJJ);
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
		private IKMPKOEGBPK configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6DEECD0", Offset = "0x6DED6D0", VA = "0x186DEECD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6DEEB50", Offset = "0x6DED550", VA = "0x186DEEB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1D0", Offset = "0x8A9BD0", VA = "0x1808AB1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6DEEB40", Offset = "0x6DED540", VA = "0x186DEEB40")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IKMPKOEGBPK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6DEE540", Offset = "0x6DECF40", VA = "0x186DEE540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KHODIGFFCJJ FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6DEE9B0", Offset = "0x6DED3B0", VA = "0x186DEE9B0")]
			get
			{
				return default(KHODIGFFCJJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE410", Offset = "0x6DECE10", VA = "0x186DEE410")]
		internal void BOLCMOFLHAO(IEnumerable<GlyphCoordinateWritable> CDCBKDPAHBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE4B0", Offset = "0x6DECEB0", VA = "0x186DEE4B0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE490", Offset = "0x6DECE90", VA = "0x186DEE490")]
		[CompilerGenerated]
		private bool EFLCBCHDLMA(GlyphCoordinateWritable CLNPLAGFLPF)
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
		private TextSegmentMeshBufferSource BAAEIBBHBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private GDJGIENDFCJ ALKNNAHLBKM;

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
		private BHMFKOEACIF BDHKCAPEGNP;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1240", Offset = "0x6DEFC40", VA = "0x186DF1240")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DF11F0", Offset = "0x6DEFBF0", VA = "0x186DF11F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1030", Offset = "0x6DEFA30", VA = "0x186DF1030")]
		private void DPDCPIKMDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1330", Offset = "0x6DEFD30", VA = "0x186DF1330")]
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
		private bool MPHIBGBBBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material LHMNCFNPHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private GDJGIENDFCJ ALKNNAHLBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material JIFDIAJMJFF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private IKMPKOEGBPK NEIEICHBECO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6DF18A0", Offset = "0x6DF02A0", VA = "0x186DF18A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GDJGIENDFCJ CAGJIJONIKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6DF1E40", Offset = "0x6DF0840", VA = "0x186DF1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material NOBHFKKDLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6DF1E70", Offset = "0x6DF0870", VA = "0x186DF1E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1DA0", Offset = "0x6DF07A0", VA = "0x186DF1DA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF16B0", Offset = "0x6DF00B0", VA = "0x186DF16B0", Slot = "8")]
		protected override void BDKCDOGIFCP(HPCOPBFMBAJ JPJMDFLNIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1DB0", Offset = "0x6DF07B0", VA = "0x186DF1DB0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] FPKKJMNLMMJ EJDIDOALMIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1C50", Offset = "0x6DF0650", VA = "0x186DF1C50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1930", Offset = "0x6DF0330", VA = "0x186DF1930")]
		private void NHGOKLOONAA(bool DEDPJAGPBOL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct PHMLEJKJOHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly GDJGIENDFCJ JFICHIMGFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int EOHCBOKFODI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0CB0", Offset = "0x6DEF6B0", VA = "0x186DF0CB0")]
	internal DAFCAMMNIIM AHBHCMJPBDD()
	{
		return default(DAFCAMMNIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x227C9F0", Offset = "0x227B3F0", VA = "0x18227C9F0")]
	internal PHMLEJKJOHP(GDJGIENDFCJ PLJBPLDMFHL, int BLGGKGOBABE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EMPKFFIODBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DECB00", Offset = "0x6DEB500", VA = "0x186DECB00")]
	public static bool GBOADFFLCBC(this PHMLEJKJOHP INCCADBLEFM, AFNJGOOOLLK DAOCKKINNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DECB50", Offset = "0x6DEB550", VA = "0x186DECB50")]
	internal static bool GBOADFFLCBC(this DAFCAMMNIIM MOKODNCNLNE, AFNJGOOOLLK DAOCKKINNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DECB70", Offset = "0x6DEB570", VA = "0x186DECB70")]
	public static float ILHJBOAFBBP(this PHMLEJKJOHP INCCADBLEFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBF02D0", Offset = "0xBEECD0", VA = "0x180BF02D0")]
	internal static float ILHJBOAFBBP(this DAFCAMMNIIM MOKODNCNLNE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PLFHDPMJGLP
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC380", Offset = "0x6DEAD80", VA = "0x186DEC380")]
	public static void GJANHGKBJDP(this PHMLEJKJOHP INCCADBLEFM, ReadOnlySpan<char> DAPBIEKODIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0D50", Offset = "0x6DEF750", VA = "0x186DF0D50")]
	internal static void GJANHGKBJDP(this DAFCAMMNIIM MOKODNCNLNE, ReadOnlySpan<char> DAPBIEKODIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0F20", Offset = "0x6DEF920", VA = "0x186DF0F20")]
	public static void HONODCPCDNG(this PHMLEJKJOHP HPLLPDIEEKO, float2 IFIGODDHDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0F10", Offset = "0x6DEF910", VA = "0x186DF0F10")]
	internal static void HONODCPCDNG(this DAFCAMMNIIM MOKODNCNLNE, float2 IFIGODDHDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0CF0", Offset = "0x6DEF6F0", VA = "0x186DF0CF0")]
	public static void CAOINIJHFBG(this PHMLEJKJOHP HPLLPDIEEKO, float EJOHHKKNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0D30", Offset = "0x6DEF730", VA = "0x186DF0D30")]
	internal static void CAOINIJHFBG(this DAFCAMMNIIM MOKODNCNLNE, float EJOHHKKNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0D40", Offset = "0x6DEF740", VA = "0x186DF0D40")]
	internal static void DKDBCNOGFPJ(this DAFCAMMNIIM MOKODNCNLNE, bool KCKBIGFHDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0FA0", Offset = "0x6DEF9A0", VA = "0x186DF0FA0")]
	public static void LBIMBOOBGHP(this PHMLEJKJOHP HPLLPDIEEKO, Color32 GNADFIPFMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0F90", Offset = "0x6DEF990", VA = "0x186DF0F90")]
	internal static void LBIMBOOBGHP(this DAFCAMMNIIM MOKODNCNLNE, Color32 GNADFIPFMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0FF0", Offset = "0x6DEF9F0", VA = "0x186DF0FF0")]
	public static void MKJADLHAHCE(this PHMLEJKJOHP HPLLPDIEEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0FE0", Offset = "0x6DEF9E0", VA = "0x186DF0FE0")]
	internal static void MKJADLHAHCE(this DAFCAMMNIIM MOKODNCNLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0EA0", Offset = "0x6DEF8A0", VA = "0x186DF0EA0")]
	internal static void HFCOMJOBIDC(this DAFCAMMNIIM MOKODNCNLNE, int KCKNMHJAKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0F70", Offset = "0x6DEF970", VA = "0x186DF0F70")]
	internal static void KPBAJMGNNPK(this DAFCAMMNIIM MOKODNCNLNE, int HBLPFBACECH, AFNJGOOOLLK DKFLKOCAEDM = AFNJGOOOLLK.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BHMFKOEACIF : IEquatable<BHMFKOEACIF>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort AGPMONGGDDL = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int GAPPEIGGHBL = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly BHMFKOEACIF PJJEDONHPDA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort GFMLHCPEIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x207C950", Offset = "0x207B350", VA = "0x18207C950")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x207C960", Offset = "0x207B360", VA = "0x18207C960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GDJGIENDFCJ JFICHIMGFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MCOKBKCIBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA290", Offset = "0x6DE8C90", VA = "0x186DEA290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA5B0", Offset = "0x6DE8FB0", VA = "0x186DEA5B0")]
	public BHMFKOEACIF(int NINKMEOILON, GDJGIENDFCJ PLJBPLDMFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC520", Offset = "0x6DEAF20", VA = "0x186DEC520")]
	public bool ALBOEFLMFDK([Out] PHMLEJKJOHP INCCADBLEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC720", Offset = "0x6DEB120", VA = "0x186DEC720")]
	public void MMBLFJNKGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA2A0", Offset = "0x6DE8CA0", VA = "0x186DEA2A0")]
	internal void CMCFNGOJFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA2D0", Offset = "0x6DE8CD0", VA = "0x186DEA2D0", Slot = "4")]
	public bool Equals(BHMFKOEACIF GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC5F0", Offset = "0x6DEAFF0", VA = "0x186DEC5F0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC6B0", Offset = "0x6DEB0B0", VA = "0x186DEC6B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GDJGIENDFCJ : IDisposable, FDEIEDGBIPB
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string CNALCACEDFK = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker AHBFPDKHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string ELLCDPEAKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly CIHHGJFEJAO JCHFCBHCKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int CCBILJMBPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal DAFCAMMNIIM[] HBIGCMFNPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal BHMFKOEACIF[] LMGNJOECKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private IKMPKOEGBPK HHIPJOBCGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KPCCPJJLJPF HLGNPMKHEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly KKMGFCLPCKI NOCIFEIHKKL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string JHJFHDOAMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DEDB20", Offset = "0x6DEC520", VA = "0x186DEDB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PIJOKJHGHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8CA8B0", Offset = "0x8C92B0", VA = "0x1808CA8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IKMPKOEGBPK KKNBCKBBIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DEDB00", Offset = "0x6DEC500", VA = "0x186DEDB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float MMCFAPNLMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6DEDAE0", Offset = "0x6DEC4E0", VA = "0x186DEDAE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float KIADJNFGIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DED690", Offset = "0x6DEC090", VA = "0x186DED690")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FDEIEDGBIPB.AOAGBNJPEBC CGAIAEGHCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1C0", Offset = "0x8A9BC0", VA = "0x1808AB1C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8AB210", Offset = "0x8A9C10", VA = "0x1808AB210", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDFB0", Offset = "0x6DEC9B0", VA = "0x186DEDFB0")]
	public GDJGIENDFCJ(CIHHGJFEJAO BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDF30", Offset = "0x6DEC930", VA = "0x186DEDF30")]
	public GDJGIENDFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDA40", Offset = "0x6DEC440", VA = "0x186DEDA40")]
	public void IGMCENCOPJL(GlyphMapAsset GINMPKIFBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DED930", Offset = "0x6DEC330", VA = "0x186DED930")]
	public void IGMCENCOPJL(IKMPKOEGBPK ANHHFAJMJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDC60", Offset = "0x6DEC660", VA = "0x186DEDC60", Slot = "6")]
	public bool TryGetMeshBuffer([Out] FPKKJMNLMMJ EJDIDOALMIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDA80", Offset = "0x6DEC480", VA = "0x186DEDA80")]
	public void JDPADIPAKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DED8E0", Offset = "0x6DEC2E0", VA = "0x186DED8E0")]
	public bool HFBCPPLMMFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DED6B0", Offset = "0x6DEC0B0", VA = "0x186DED6B0")]
	public BHMFKOEACIF GODPIKMJFEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DED2C0", Offset = "0x6DEBCC0", VA = "0x186DED2C0")]
	public void EIDHPPINJBI(BHMFKOEACIF AIOAIBNFDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDBB0", Offset = "0x6DEC5B0", VA = "0x186DEDBB0")]
	internal bool NMHJBDMPAIN(BHMFKOEACIF AIOAIBNFDCF, [Out] PHMLEJKJOHP INCCADBLEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DECBD0", Offset = "0x6DEB5D0", VA = "0x186DECBD0")]
	private void AHHDAGNKCBI(DAFCAMMNIIM MOKODNCNLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DECD20", Offset = "0x6DEB720", VA = "0x186DECD20")]
	private void BBFOMKMJJOC(int KIDGNJKIBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DED630", Offset = "0x6DEC030", VA = "0x186DED630")]
	private bool FDPKFEBLLDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DE95C0", Offset = "0x6DE7FC0", VA = "0x186DE95C0")]
	private static int DGBGHHHHFHD(BHMFKOEACIF AIOAIBNFDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1BEEEF0", Offset = "0x1BED8F0", VA = "0x181BEEEF0")]
	private static ushort MJECICLNLIM(int GCBONJOGHCD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DECF00", Offset = "0x6DEB900", VA = "0x186DECF00")]
	private Bounds BCFEAAGHODO()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6DED210", Offset = "0x6DEBC10", VA = "0x186DED210", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CIHHGJFEJAO
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CIHHGJFEJAO FMIBMCJKLLI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float IGCGOCMGDLI = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int NMCMGFFFKNG = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int ENFFFKJAECP = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color PBMIFIAMBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float BHJBOIMPHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int HOLIJLAANEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int PCJABAMNCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int CCPLMNGLACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int NELIKPNFOHF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC930", Offset = "0x6DEB330", VA = "0x186DEC930")]
	internal CIHHGJFEJAO KBEBHJOPAPK()
	{
		return default(CIHHGJFEJAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3FE0", Offset = "0x6DE29E0", VA = "0x186DE3FE0")]
	[CompilerGenerated]
	internal static void GGJJNOLDEGN(int PKCLPFEIPFH, int PFGHNJEFBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC8F0", Offset = "0x6DEB2F0", VA = "0x186DEC8F0")]
	[CompilerGenerated]
	internal static void AMLFGHIACIA(float PKCLPFEIPFH, float PFGHNJEFBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3FD0", Offset = "0x6DE29D0", VA = "0x186DE3FD0")]
	[CompilerGenerated]
	internal static void NKLOLLKFGEP(int PKCLPFEIPFH, int NIKHABFGNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC910", Offset = "0x6DEB310", VA = "0x186DEC910")]
	[CompilerGenerated]
	internal static void DMJPIOFCJOB(float PKCLPFEIPFH, float NIKHABFGNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LDNKCLDHGEM
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0AB0", Offset = "0x6DEF4B0", VA = "0x186DF0AB0")]
	public static (int, int) IBLNGDGBNOO(this GDJGIENDFCJ LGFNJOFIAIA)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0B60", Offset = "0x6DEF560", VA = "0x186DF0B60")]
	public static float KJJHMMLLDEP(this PHMLEJKJOHP OMLBFDOIIPH)
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
		public readonly BHMFKOEACIF textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1640", Offset = "0x6DF0040", VA = "0x186DF1640")]
		public TextSegmentLayout(LayoutRect layoutRect, BHMFKOEACIF textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1410", Offset = "0x6DEFE10", VA = "0x186DF1410")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1480", Offset = "0x6DEFE80", VA = "0x186DF1480")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DF13B0", Offset = "0x6DEFDB0", VA = "0x186DF13B0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class KPCCPJJLJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig BGGCECCBPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float NKOOLIBGLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float GGKAJMGNEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float IAHDLOHOAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float CGLADPLKGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float NLGIMIHBGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float MJHCMIPKJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float IMCEFDCAIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float MFCIBHJOIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float IFGGLIDGLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float KIADJNFGIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float HPALLLJLGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float MMCFAPNLMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly BMPBHIGABGE[] OGAPHMBCMPL;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int JIFLDFAMHOD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private GAKAPKJMFKD[] HJEBKOLPPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int PINKFGNKIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private KHODIGFFCJJ[] DIPPKBIEPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int KODGLELHDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public BMPBHIGABGE HBPJINLDJBO;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0650", Offset = "0x6DEF050", VA = "0x186DF0650")]
	public void IGMCENCOPJL(IKMPKOEGBPK CNBDAPOEMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF05D0", Offset = "0x6DEEFD0", VA = "0x186DF05D0")]
	public void IGMCENCOPJL(GlyphUVConfig PFIIKKHKIBB, IEnumerable<KHODIGFFCJJ> GINMPKIFBMB, KHODIGFFCJJ DOAFJHMKPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0490", Offset = "0x6DEEE90", VA = "0x186DF0490")]
	internal void DGKHEKNOBAH(GlyphUVConfig PFIIKKHKIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6DEFF60", Offset = "0x6DEE960", VA = "0x186DEFF60")]
	private void DAPNDDNBAJN(IEnumerable<KHODIGFFCJJ> GINMPKIFBMB, KHODIGFFCJJ DOAFJHMKPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF06E0", Offset = "0x6DEF0E0", VA = "0x186DF06E0")]
	public void LMGCFGGNGIG([In] char MNIBGEOAEHC, [Out] float2[] FBHDDBLIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DEBFA0", Offset = "0x6DEA9A0", VA = "0x186DEBFA0")]
	private BMPBHIGABGE FLKKEBIKDHF(KHODIGFFCJJ JNFCIAOAGCM)
	{
		return default(BMPBHIGABGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0A10", Offset = "0x6DEF410", VA = "0x186DF0A10")]
	public KPCCPJJLJPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IBPENJHFFAH
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6DEEE60", Offset = "0x6DED860", VA = "0x186DEEE60")]
	public static void ONFHLJNOHKP([In] float HLJIGGOEHHM, [In] float OADNBBJHOAP, [In] int BDADLLEHMPE, [In] int LBAMLAEHMJD, [In] float CGLADPLKGIP, [In] float NLGIMIHBGML, [In] float LNDJKPMAKFG, [In] float JCNIFKMBOBG, [In] float HPPNOCOMOAA, [In] float GIEJJNFJDAF, [Out] float EDEABFKHJJA, [Out] float PAHGPDECGEN, [Out] float ENJFHIPPOIC, [Out] float PGPFBINIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DEEF30", Offset = "0x6DED930", VA = "0x186DEEF30")]
	public static void ONFHLJNOHKP([In] float HLJIGGOEHHM, [In] float OADNBBJHOAP, [In] int BDADLLEHMPE, [In] int LBAMLAEHMJD, [Out] float EDEABFKHJJA, [Out] float PAHGPDECGEN, [Out] float ENJFHIPPOIC, [Out] float PGPFBINIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6DEEE00", Offset = "0x6DED800", VA = "0x186DEEE00")]
	public static void LEGJAFNBADG([In] float CGLADPLKGIP, [In] float NLGIMIHBGML, [In] float NILNMPCLEKD, [In] float MLKHKOOFAKI, [In] float HCMNHHCJGDL, [In] float AOPBMAMFDAB, [Out] float NMHOJKDLIBK, [Out] float DBGPNBJGNBJ, [Out] float KJPEPOHHGAL, [Out] float GAAOLFEBCML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GAKAPKJMFKD
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint FCLLFCICPNM = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char FBGADPIOHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly BMPBHIGABGE KLJKJMEEOFP;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6DECBB0", Offset = "0x6DEB5B0", VA = "0x186DECBB0")]
	public GAKAPKJMFKD(char MNIBGEOAEHC, BMPBHIGABGE FBHDDBLIDEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BMPBHIGABGE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint FCLLFCICPNM = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] CKGEHNBPCIA;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC800", Offset = "0x6DEB200", VA = "0x186DEC800")]
	public BMPBHIGABGE(float EDEABFKHJJA, float PAHGPDECGEN, float ENJFHIPPOIC, float PGPFBINIFNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct DAFCAMMNIIM
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int HKHOPFBLKIG = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal AFNJGOOOLLK DKFLKOCAEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] ILNMLGCHAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int JGKPHBLOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 IFIGODDHDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float OBGENPDLOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 MPFJJDFALIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool KCKBIGFHDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int LAJMKMBLMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int AOLGAFHPIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int HMDDOEHDLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int JIEACDABENP;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6DECAF0", Offset = "0x6DEB4F0", VA = "0x186DECAF0")]
	public static int HMMCAGEAJDA(int NEOCJIHGLPM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum AFNJGOOOLLK : byte
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
public static class MBODFIKJBMC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0C70", Offset = "0x6DEF670", VA = "0x186DF0C70")]
	internal static float KJJHMMLLDEP(this DAFCAMMNIIM MOKODNCNLNE, float LBDNMLLHAEO, float PNGMIFECLEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0BF0", Offset = "0x6DEF5F0", VA = "0x186DF0BF0")]
	internal static void HAAJPGKGEGG(this DAFCAMMNIIM MOKODNCNLNE, float LBDNMLLHAEO, float PNGMIFECLEP, [Out] float2 LAJFHIPPBIH, [Out] float2 APMEFBMNAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class KKMGFCLPCKI : FDEIEDGBIPB
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int MCLLLDKMMAK = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int BKJKJIAALCD = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string CNALCACEDFK = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static PIGMDEKJDGN OMNPDFBNAPD;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static PIGMDEKJDGN FCJICLJDGCL;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static PIGMDEKJDGN ODIHDIAJPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static PIGMDEKJDGN FAAEJLJOPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly FPKKJMNLMMJ EJDIDOALMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] ACLKBONEOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] NHNMPDHLJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int FIMMDPNFMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int JJIICCKFBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int ECJBMKHICOP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string JHJFHDOAMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public FDEIEDGBIPB.AOAGBNJPEBC CGAIAEGHCDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DEFE50", Offset = "0x6DEE850", VA = "0x186DEFE50")]
	public KKMGFCLPCKI(FPKKJMNLMMJ.BDCKGIGPCPD BOFOEIDFLPH, int CKIEJADBLIN, int FPBHECJNIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DEFCD0", Offset = "0x6DEE6D0", VA = "0x186DEFCD0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] FPKKJMNLMMJ EJDIDOALMIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DEFCB0", Offset = "0x6DEE6B0", VA = "0x186DEFCB0")]
	public void MGBOEHKCGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF350", Offset = "0x6DEDD50", VA = "0x186DEF350")]
	public void FGIJHJNGLCB(Span<DAFCAMMNIIM> HAKJLJEAEJB, KPCCPJJLJPF GBOGLPLGODA, [In] CIHHGJFEJAO BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA750", Offset = "0x6DE9150", VA = "0x186DEA750")]
	private void AOGFJMMNJHD([In] AFNJGOOOLLK DKFLKOCAEDM, [In] DAFCAMMNIIM ELOFHGANCDA, int HFPOCHAMINC, [In] float LBDNMLLHAEO, [In] float PNGMIFECLEP, KPCCPJJLJPF GBOGLPLGODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DEFB60", Offset = "0x6DEE560", VA = "0x186DEFB60")]
	private void IGJHEPOIBLD([In] AFNJGOOOLLK DKFLKOCAEDM, DAFCAMMNIIM ELOFHGANCDA, [In] int OFEEDIFPGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF180", Offset = "0x6DEDB80", VA = "0x186DEF180")]
	public static void CEPLMCGDKCO(ReadOnlySpan<DAFCAMMNIIM> HAKJLJEAEJB, int GIEJHAONPFC, [Out] int CHDFPHGJNEO, [Out] int PFEDENOGKPF, [Out] int ABNJIHNMNMI)
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
