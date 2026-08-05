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
public class MMFOCCMFBKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D LAFOKDOPLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig AIFOHLEDDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public PKFAFKHMEMI[] FBBLFHGNNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public PKFAFKHMEMI AMHKPPNFKLH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MMFOCCMFBKG PNNLAMEKMKE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MMFOCCMFBKG DAKOLKDBAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DD24A0", Offset = "0x6DD18A0", VA = "0x186DD24A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public MMFOCCMFBKG()
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
		[Cpp2IlInjected.Address(RVA = "0x6DCEAE0", Offset = "0x6DCDEE0", VA = "0x186DCEAE0")]
		public GlyphUVConfig(int JMINKOKAKHC, int JDDLNIJHDEE, int KKJBDMKBEOD, int JFGOHHIKDLA, float MPGDIBPGIEJ = 0f, [Optional] GlyphPixelInset KJPFLIFDMPM)
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
public readonly struct PKFAFKHMEMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char IBDMJPFFPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int BIOCPEIBFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int PAFBIMCDHDP;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly PKFAFKHMEMI GOLDJBCBCEG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2660", Offset = "0x6DD1A60", VA = "0x186DD2660")]
	public PKFAFKHMEMI(char EMABGOCMJFL, int GIMOKMLLHAC, int KEIIFBLLHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2670", Offset = "0x6DD1A70", VA = "0x186DD2670")]
	public PKFAFKHMEMI(GlyphCoordinateWritable MAOOCMMDEOH)
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
		[Cpp2IlInjected.Address(RVA = "0x6DCE100", Offset = "0x6DCD500", VA = "0x186DCE100")]
		public static PKFAFKHMEMI EGFECENGKHG(GlyphCoordinateWritable JEGEADOBKMM)
		{
			return default(PKFAFKHMEMI);
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
		private MMFOCCMFBKG configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE9E0", Offset = "0x6DCDDE0", VA = "0x186DCE9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE860", Offset = "0x6DCDC60", VA = "0x186DCE860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE850", Offset = "0x6DCDC50", VA = "0x186DCE850")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MMFOCCMFBKG ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE250", Offset = "0x6DCD650", VA = "0x186DCE250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PKFAFKHMEMI FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE6C0", Offset = "0x6DCDAC0", VA = "0x186DCE6C0")]
			get
			{
				return default(PKFAFKHMEMI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE140", Offset = "0x6DCD540", VA = "0x186DCE140")]
		internal void MMLAFHNNGKK(IEnumerable<GlyphCoordinateWritable> CMKGNCPGGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE1C0", Offset = "0x6DCD5C0", VA = "0x186DCE1C0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE120", Offset = "0x6DCD520", VA = "0x186DCE120")]
		[CompilerGenerated]
		private bool MJLFDIECGBL(GlyphCoordinateWritable JEGEADOBKMM)
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
		private TextSegmentMeshBufferSource FFBBELOHGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private LPKFEHEKMNM MJKNIGKDKDJ;

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
		private KBODNPFINJO LFPDOBBKDEE;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DD28A0", Offset = "0x6DD1CA0", VA = "0x186DD28A0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2850", Offset = "0x6DD1C50", VA = "0x186DD2850")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2690", Offset = "0x6DD1A90", VA = "0x186DD2690")]
		private void FCACLLMJJJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2990", Offset = "0x6DD1D90", VA = "0x186DD2990")]
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
		private bool MEPMOJFOHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material DGLGHIGOKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private LPKFEHEKMNM MJKNIGKDKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material ECIBBPDACEP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private MMFOCCMFBKG MDLJGCPDPDD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6DD3030", Offset = "0x6DD2430", VA = "0x186DD3030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LPKFEHEKMNM EDMNANGDCEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6DD3490", Offset = "0x6DD2890", VA = "0x186DD3490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material DJDEOBIMPLI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6DD34C0", Offset = "0x6DD28C0", VA = "0x186DD34C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD33F0", Offset = "0x6DD27F0", VA = "0x186DD33F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD30C0", Offset = "0x6DD24C0", VA = "0x186DD30C0", Slot = "8")]
		protected override void NPMIMBGHMGB(IBKFBMGPJCG IBLGHCMEHCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3400", Offset = "0x6DD2800", VA = "0x186DD3400", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] HAILIAMPDIP IMDLODJOJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DD32A0", Offset = "0x6DD26A0", VA = "0x186DD32A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2D10", Offset = "0x6DD2110", VA = "0x186DD2D10")]
		private void GLKPFCDMNEB(bool MALABKOONDB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C62D0", Offset = "0x8C56D0", VA = "0x1808C62D0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct MBGFBNKONEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly LPKFEHEKMNM GLLHMGCCLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int KEHEHGKKMHI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DD23B0", Offset = "0x6DD17B0", VA = "0x186DD23B0")]
	internal HAAOADDHCBL NOBIIKCLOMD()
	{
		return default(HAAOADDHCBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x22130A0", Offset = "0x22124A0", VA = "0x1822130A0")]
	internal MBGFBNKONEJ(LPKFEHEKMNM BLMJILKGBHG, int LDEBCPPEHAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MFNONLGJGHO
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2430", Offset = "0x6DD1830", VA = "0x186DD2430")]
	public static bool EGPMAOGBCIO(this MBGFBNKONEJ FLGDDOCOGIM, OJIADIJPDNK PCFFJHHDNKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2480", Offset = "0x6DD1880", VA = "0x186DD2480")]
	internal static bool EGPMAOGBCIO(this HAAOADDHCBL MDPLABDKOBA, OJIADIJPDNK PCFFJHHDNKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DD23F0", Offset = "0x6DD17F0", VA = "0x186DD23F0")]
	public static float BHBEGFLABNG(this MBGFBNKONEJ FLGDDOCOGIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xB846E0", Offset = "0xB83AE0", VA = "0x180B846E0")]
	internal static float BHBEGFLABNG(this HAAOADDHCBL MDPLABDKOBA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KEHENFGHNAO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD4C0", Offset = "0x6DCC8C0", VA = "0x186DCD4C0")]
	public static void FMADDGLLEAP(this MBGFBNKONEJ FLGDDOCOGIM, ReadOnlySpan<char> KKPGLKKIKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFD10", Offset = "0x6DCF110", VA = "0x186DCFD10")]
	internal static void FMADDGLLEAP(this HAAOADDHCBL MDPLABDKOBA, ReadOnlySpan<char> KKPGLKKIKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFF30", Offset = "0x6DCF330", VA = "0x186DCFF30")]
	public static void IHFDCJEFBKD(this MBGFBNKONEJ MMCMBAKNAFE, float2 LJGIKAHALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFF20", Offset = "0x6DCF320", VA = "0x186DCFF20")]
	internal static void IHFDCJEFBKD(this HAAOADDHCBL MDPLABDKOBA, float2 LJGIKAHALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFED0", Offset = "0x6DCF2D0", VA = "0x186DCFED0")]
	public static void GMGDKGEDGDG(this MBGFBNKONEJ MMCMBAKNAFE, float DNEOOCOLLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFF10", Offset = "0x6DCF310", VA = "0x186DCFF10")]
	internal static void GMGDKGEDGDG(this HAAOADDHCBL MDPLABDKOBA, float DNEOOCOLLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFFD0", Offset = "0x6DCF3D0", VA = "0x186DCFFD0")]
	internal static void NCPAIJHECEL(this HAAOADDHCBL MDPLABDKOBA, bool LLGJNNKAIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFF80", Offset = "0x6DCF380", VA = "0x186DCFF80")]
	public static void JMHFGAFFMCM(this MBGFBNKONEJ MMCMBAKNAFE, Color32 KLMDPLMNJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFFC0", Offset = "0x6DCF3C0", VA = "0x186DCFFC0")]
	internal static void JMHFGAFFMCM(this HAAOADDHCBL MDPLABDKOBA, Color32 KLMDPLMNJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFFF0", Offset = "0x6DCF3F0", VA = "0x186DCFFF0")]
	public static void PDHNCMCOJML(this MBGFBNKONEJ MMCMBAKNAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFFE0", Offset = "0x6DCF3E0", VA = "0x186DCFFE0")]
	internal static void PDHNCMCOJML(this HAAOADDHCBL MDPLABDKOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFE60", Offset = "0x6DCF260", VA = "0x186DCFE60")]
	internal static void GDPMAOHIKOF(this HAAOADDHCBL MDPLABDKOBA, int LNOGNJLMKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFCF0", Offset = "0x6DCF0F0", VA = "0x186DCFCF0")]
	internal static void AACDLOMNHCK(this HAAOADDHCBL MDPLABDKOBA, int JBCGDBKPKHA, OJIADIJPDNK NPDPFNEBNOF = OJIADIJPDNK.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KBODNPFINJO : IEquatable<KBODNPFINJO>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort EFCKLELALAA = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int LHEFAFNMAFH = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly KBODNPFINJO DHAMDHDJPBN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort JBJMGELGMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8820", Offset = "0x1FA7C20", VA = "0x181FA8820")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8830", Offset = "0x1FA7C30", VA = "0x181FA8830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LPKFEHEKMNM GLLHMGCCLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CPKPPJFCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB990", Offset = "0x6DCAD90", VA = "0x186DCB990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBAA0", Offset = "0x6DCAEA0", VA = "0x186DCBAA0")]
	public KBODNPFINJO(int MBMFKEPENAG, LPKFEHEKMNM BLMJILKGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFA10", Offset = "0x6DCEE10", VA = "0x186DCFA10")]
	public bool BNKPCIKDOLM([Out] MBGFBNKONEJ FLGDDOCOGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFC10", Offset = "0x6DCF010", VA = "0x186DCFC10")]
	public void HNEMOMPNNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB960", Offset = "0x6DCAD60", VA = "0x186DCB960")]
	internal void NGEDPDCELIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB780", Offset = "0x6DCAB80", VA = "0x186DCB780", Slot = "4")]
	public bool Equals(KBODNPFINJO KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFAE0", Offset = "0x6DCEEE0", VA = "0x186DCFAE0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFBA0", Offset = "0x6DCEFA0", VA = "0x186DCFBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class LPKFEHEKMNM : IDisposable, COLLOIBBCEO
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string AODEGAOHGLE = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker BCINNMIEOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string CENOPFAEPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly BBJCBNIMHLD OBMPJMLGBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int CJPOABFEGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal HAAOADDHCBL[] PKCECOPKKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal KBODNPFINJO[] LGBCJOCFPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MMFOCCMFBKG FGIHHIFHIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly LDCPBJHPGGD HGKPAMFBCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly JILOFPOIOJB MDNIBGKJAPE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string DDDHPCNFCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DD10E0", Offset = "0x6DD04E0", VA = "0x186DD10E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IMBHGFMLOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8C7930", Offset = "0x8C6D30", VA = "0x1808C7930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MMFOCCMFBKG GGLAAOKKOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DD10C0", Offset = "0x6DD04C0", VA = "0x186DD10C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float MENIABJEFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6DD10A0", Offset = "0x6DD04A0", VA = "0x186DD10A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float HBIMDOGAGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DD15D0", Offset = "0x6DD09D0", VA = "0x186DD15D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public COLLOIBBCEO.GBGJIINHPMJ FFMBCAFACHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB00", Offset = "0x8ABF00", VA = "0x1808ACB00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB60", Offset = "0x8ABF60", VA = "0x1808ACB60", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1EF0", Offset = "0x6DD12F0", VA = "0x186DD1EF0")]
	public LPKFEHEKMNM(BBJCBNIMHLD HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2330", Offset = "0x6DD1730", VA = "0x186DD2330")]
	public LPKFEHEKMNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1280", Offset = "0x6DD0680", VA = "0x186DD1280")]
	public void IPNPHEKPPLJ(GlyphMapAsset BIKBCJAAFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1170", Offset = "0x6DD0570", VA = "0x186DD1170")]
	public void IPNPHEKPPLJ(MMFOCCMFBKG CEHGJOALFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1C20", Offset = "0x6DD1020", VA = "0x186DD1C20", Slot = "6")]
	public bool TryGetMeshBuffer([Out] HAILIAMPDIP IMDLODJOJIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1B10", Offset = "0x6DD0F10", VA = "0x186DD1B10")]
	public void ONOBKJPFFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1970", Offset = "0x6DD0D70", VA = "0x186DD1970")]
	public bool MGFLGDKEEHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0D60", Offset = "0x6DD0160", VA = "0x186DD0D60")]
	public KBODNPFINJO BGNJAILLIDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DD15F0", Offset = "0x6DD09F0", VA = "0x186DD15F0")]
	public void LEIOIOGFJCF(KBODNPFINJO COICPICBBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1B70", Offset = "0x6DD0F70", VA = "0x186DD1B70")]
	internal bool PGHPJACMAHO(KBODNPFINJO COICPICBBHM, [Out] MBGFBNKONEJ FLGDDOCOGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DD19C0", Offset = "0x6DD0DC0", VA = "0x186DD19C0")]
	private void OAOHJOFJGLK(HAAOADDHCBL MDPLABDKOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0B80", Offset = "0x6DCFF80", VA = "0x186DD0B80")]
	private void BDLLEJPBOKP(int EDLOAICKGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1040", Offset = "0x6DD0440", VA = "0x186DD1040")]
	private bool GIBHKFLPNMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB3F0", Offset = "0x6DCA7F0", VA = "0x186DCB3F0")]
	private static int MAFJGCOCAMC(KBODNPFINJO COICPICBBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1B64DA0", Offset = "0x1B641A0", VA = "0x181B64DA0")]
	private static ushort NDJMNKDACBA(int HAJICDLBEKC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD12C0", Offset = "0x6DD06C0", VA = "0x186DD12C0")]
	private Bounds JJMFKEOODLJ()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0F90", Offset = "0x6DD0390", VA = "0x186DD0F90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BBJCBNIMHLD
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BBJCBNIMHLD AELOBHCICAC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float DFFLCEKBCMI = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int JONDACAGBMD = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int JFNMOBIINDF = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color OLFDIHHGENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float EHMHHELEJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int IDHAAGBDAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int EJAOOPDPOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int DILBIKNLDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int ENPEAEMOKJA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDB90", Offset = "0x6DCCF90", VA = "0x186DCDB90")]
	internal BBJCBNIMHLD FJKGAPDGNAI()
	{
		return default(BBJCBNIMHLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBB00", Offset = "0x6DCAF00", VA = "0x186DCBB00")]
	[CompilerGenerated]
	internal static void EMNKAOMMELL(int EEPLCHCGAIN, int BMLEAJPEFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDB70", Offset = "0x6DCCF70", VA = "0x186DCDB70")]
	[CompilerGenerated]
	internal static void COIAGOJCEPG(float EEPLCHCGAIN, float BMLEAJPEFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBBB0", Offset = "0x6DCAFB0", VA = "0x186DCBBB0")]
	[CompilerGenerated]
	internal static void POMEBAPCFGJ(int EEPLCHCGAIN, int FELJNLELLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDCA0", Offset = "0x6DCD0A0", VA = "0x186DCDCA0")]
	[CompilerGenerated]
	internal static void GLCMMBIEHNP(float EEPLCHCGAIN, float FELJNLELLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DLDKNJEHDLG
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDE30", Offset = "0x6DCD230", VA = "0x186DCDE30")]
	public static (int, int) MDIDOEMIJEB(this LPKFEHEKMNM MELNJLPNGKF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDEE0", Offset = "0x6DCD2E0", VA = "0x186DCDEE0")]
	public static float MMLDNIKDGPF(this MBGFBNKONEJ LCONDLKCACF)
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
		public readonly KBODNPFINJO textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2CA0", Offset = "0x6DD20A0", VA = "0x186DD2CA0")]
		public TextSegmentLayout(LayoutRect layoutRect, KBODNPFINJO textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2A70", Offset = "0x6DD1E70", VA = "0x186DD2A70")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2AE0", Offset = "0x6DD1EE0", VA = "0x186DD2AE0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2A10", Offset = "0x6DD1E10", VA = "0x186DD2A10")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class LDCPBJHPGGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig LMIEKGNCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float LHGNDNNLJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float BGDCCLJEJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float IBKHNPJNJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float HNDIMBKNHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float OJFBPPAIAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float CAGLLJIMOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float BMBILNPFNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float DGFJMMKHAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float GADBFBADKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float HBIMDOGAGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float IBPOIGAILFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float MENIABJEFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IPLIBAMJBNA[] NDIOJPFMFDF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int GGKNDMIJEIG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private HICJMLMAFLC[] CKDEOKDFBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int AIABDMEAHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private PKFAFKHMEMI[] DMBADEALMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int ONENENJPGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public IPLIBAMJBNA GHCMJJAMCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0560", Offset = "0x6DCF960", VA = "0x186DD0560")]
	public void IPNPHEKPPLJ(MMFOCCMFBKG HAAPHPHNDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD05F0", Offset = "0x6DCF9F0", VA = "0x186DD05F0")]
	public void IPNPHEKPPLJ(GlyphUVConfig PNJEDOPPCKM, IEnumerable<PKFAFKHMEMI> BIKBCJAAFCN, PKFAFKHMEMI FGAGPAGEMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD09A0", Offset = "0x6DCFDA0", VA = "0x186DD09A0")]
	internal void NOOGDNLIKKN(GlyphUVConfig PNJEDOPPCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0030", Offset = "0x6DCF430", VA = "0x186DD0030")]
	private void BFKAFNMEEHI(IEnumerable<PKFAFKHMEMI> BIKBCJAAFCN, PKFAFKHMEMI FGAGPAGEMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0670", Offset = "0x6DCFA70", VA = "0x186DD0670")]
	public void KIOKHPBCFPM([In] char EMABGOCMJFL, [Out] float2[] ONOENHDDMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD790", Offset = "0x6DCCB90", VA = "0x186DCD790")]
	private IPLIBAMJBNA HCAPLBPMJPH(PKFAFKHMEMI MAOOCMMDEOH)
	{
		return default(IPLIBAMJBNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0AE0", Offset = "0x6DCFEE0", VA = "0x186DD0AE0")]
	public LDCPBJHPGGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GJKPKCGCDIO
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDF70", Offset = "0x6DCD370", VA = "0x186DCDF70")]
	public static void BNCJFKHJKEM([In] float HNKNADHKDLG, [In] float DGMDOGDJPAP, [In] int MJOMNCAOLFC, [In] int CFEEPGIODOD, [In] float HNDIMBKNHME, [In] float OJFBPPAIAGK, [In] float INLKAGKNPMG, [In] float MNGIAHKBPCP, [In] float IEPKJFDMABO, [In] float JNMAHKIOJMC, [Out] float AECKJKIPMOE, [Out] float NGMJHHMEOPA, [Out] float LKOMINIBBJG, [Out] float MJNEIALEBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE040", Offset = "0x6DCD440", VA = "0x186DCE040")]
	public static void BNCJFKHJKEM([In] float HNKNADHKDLG, [In] float DGMDOGDJPAP, [In] int MJOMNCAOLFC, [In] int CFEEPGIODOD, [Out] float AECKJKIPMOE, [Out] float NGMJHHMEOPA, [Out] float LKOMINIBBJG, [Out] float MJNEIALEBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE0A0", Offset = "0x6DCD4A0", VA = "0x186DCE0A0")]
	public static void HOMLBDLCPGE([In] float HNDIMBKNHME, [In] float OJFBPPAIAGK, [In] float EHBMDGJKJJM, [In] float IAEGFIJCLEG, [In] float ENCEHAKDFLG, [In] float FIMCIBEKJHC, [Out] float GLFLBKIPFJD, [Out] float MJPOOOKEFLB, [Out] float GCAECAAONMO, [Out] float FICHEFOODIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct HICJMLMAFLC
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint HFGHIKAABNE = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char IBDMJPFFPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly IPLIBAMJBNA NOAMABCMIDH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEB20", Offset = "0x6DCDF20", VA = "0x186DCEB20")]
	public HICJMLMAFLC(char EMABGOCMJFL, IPLIBAMJBNA ONOENHDDMIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct IPLIBAMJBNA
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint HFGHIKAABNE = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] OCHGNCCPOBA;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEB40", Offset = "0x6DCDF40", VA = "0x186DCEB40")]
	public IPLIBAMJBNA(float AECKJKIPMOE, float NGMJHHMEOPA, float LKOMINIBBJG, float MJNEIALEBIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct HAAOADDHCBL
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int OBEEDFGICPL = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal OJIADIJPDNK NPDPFNEBNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] PNIHNNGAOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int NAMMMFCNGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 LJGIKAHALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float KODCIHLIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 CIABCFGACKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool LLGJNNKAIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int JBIFOGCMKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int AIDLEDECMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int LLJGDCFIFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int OLHECMOJDGK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEB10", Offset = "0x6DCDF10", VA = "0x186DCEB10")]
	public static int KJOKEGDEPAH(int EHBABFOIHHF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum OJIADIJPDNK : byte
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
public static class BDAIABCHMAK
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDDF0", Offset = "0x6DCD1F0", VA = "0x186DCDDF0")]
	internal static float MMLDNIKDGPF(this HAAOADDHCBL MDPLABDKOBA, float KMAELNIKLEG, float HBBKBNOMEBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDD70", Offset = "0x6DCD170", VA = "0x186DCDD70")]
	internal static void EMMJMDAGMLH(this HAAOADDHCBL MDPLABDKOBA, float KMAELNIKLEG, float HBBKBNOMEBN, [Out] float2 DBFICLBOEFG, [Out] float2 EGCLLCBPEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class JILOFPOIOJB : COLLOIBBCEO
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int ALPHAGMEMEH = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int ODENKGPHOJO = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string AODEGAOHGLE = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static MJEHGEENAGM PBHKDMOGLBG;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static MJEHGEENAGM LFCDNNAJINN;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static MJEHGEENAGM AKIGNILLPKK;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static MJEHGEENAGM NILDGHEMDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly HAILIAMPDIP IMDLODJOJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] NOJFCMNGFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] LCBCALJGILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CCIKJANKJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int EILEHAOCDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int NNKCKPBADLC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string DDDHPCNFCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public COLLOIBBCEO.GBGJIINHPMJ FFMBCAFACHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF900", Offset = "0x6DCED00", VA = "0x186DCF900")]
	public JILOFPOIOJB(HAILIAMPDIP.BDPELECOCKL EGIKCGECFJG, int ONHEAFMJCHH, int MFMNECGLFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF780", Offset = "0x6DCEB80", VA = "0x186DCF780", Slot = "5")]
	public bool TryGetMeshBuffer([Out] HAILIAMPDIP IMDLODJOJIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF760", Offset = "0x6DCEB60", VA = "0x186DCF760")]
	public void PHOGMOLKKFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEE00", Offset = "0x6DCE200", VA = "0x186DCEE00")]
	public void CNMCFOBEJCJ(Span<HAAOADDHCBL> OBDAFHNFHHB, LDCPBJHPGGD MMNHEDPDMNM, [In] BBJCBNIMHLD HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC650", Offset = "0x6DCBA50", VA = "0x186DCC650")]
	private void LNDJDHICGPI([In] OJIADIJPDNK NPDPFNEBNOF, [In] HAAOADDHCBL AOLNFCJPLIM, int MDIBIJDIFKG, [In] float KMAELNIKLEG, [In] float HBBKBNOMEBN, LDCPBJHPGGD MMNHEDPDMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF610", Offset = "0x6DCEA10", VA = "0x186DCF610")]
	private void JABCLLBOPEI([In] OJIADIJPDNK NPDPFNEBNOF, HAAOADDHCBL AOLNFCJPLIM, [In] int IEKEJLKBPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEC30", Offset = "0x6DCE030", VA = "0x186DCEC30")]
	public static void BALJFCFPEBL(ReadOnlySpan<HAAOADDHCBL> OBDAFHNFHHB, int ELPKELMPIOD, [Out] int MPKMNMBAKDJ, [Out] int FCNCMFBICDJ, [Out] int GFHOFNIJPHG)
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
