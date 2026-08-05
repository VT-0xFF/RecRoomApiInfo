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
public class LOJCIBEGDLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D LEOGFGBLKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig LPPLHJDIOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public COOEKIKEPDJ[] BLDBJHDMHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public COOEKIKEPDJ KFHDAKOPBFI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static LOJCIBEGDLK HIPBJNHMKOL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LOJCIBEGDLK NOBNKBHJPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C42610", Offset = "0x6C41210", VA = "0x186C42610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public LOJCIBEGDLK()
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
		[Cpp2IlInjected.Address(RVA = "0x6C421F0", Offset = "0x6C40DF0", VA = "0x186C421F0")]
		public GlyphUVConfig(int EGAENOOFPPE, int BFEGAFHIMML, int BPPDLKCIIMK, int OBAEOCNCHNC, float AAGOEAGMNBK = 0f, [Optional] GlyphPixelInset IPODKLBCDBJ)
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
public readonly struct COOEKIKEPDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char BFDMHCAHHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int JADNKNKDDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int JAAHGENJMJD;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly COOEKIKEPDJ DEOGIHNDKNP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C407B0", Offset = "0x6C3F3B0", VA = "0x186C407B0")]
	public COOEKIKEPDJ(char FELKFCLNBFI, int FFPLGBNHAOM, int ADMOOCHHECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C40790", Offset = "0x6C3F390", VA = "0x186C40790")]
	public COOEKIKEPDJ(GlyphCoordinateWritable HPDFHPBDIFD)
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
		[Cpp2IlInjected.Address(RVA = "0x6C41810", Offset = "0x6C40410", VA = "0x186C41810")]
		public static COOEKIKEPDJ FGDKAMMLLCN(GlyphCoordinateWritable NPAFKDGAFPE)
		{
			return default(COOEKIKEPDJ);
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
		private LOJCIBEGDLK configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6C420F0", Offset = "0x6C40CF0", VA = "0x186C420F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6C41F70", Offset = "0x6C40B70", VA = "0x186C41F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x88C740", Offset = "0x88B340", VA = "0x18088C740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C41F60", Offset = "0x6C40B60", VA = "0x186C41F60")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LOJCIBEGDLK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6C41960", Offset = "0x6C40560", VA = "0x186C41960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private COOEKIKEPDJ FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6C41DD0", Offset = "0x6C409D0", VA = "0x186C41DD0")]
			get
			{
				return default(COOEKIKEPDJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C41850", Offset = "0x6C40450", VA = "0x186C41850")]
		internal void PPJMPPCPCEM(IEnumerable<GlyphCoordinateWritable> EDPCBFLIOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C418D0", Offset = "0x6C404D0", VA = "0x186C418D0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C41830", Offset = "0x6C40430", VA = "0x186C41830")]
		[CompilerGenerated]
		private bool NNCLBGPICIH(GlyphCoordinateWritable NPAFKDGAFPE)
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
		private TextSegmentMeshBufferSource LLOCCGDPAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private OKHLPEJPAJE EFGCJECGNKH;

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
		private HNHEBFLEHHA FKAMHFBMMAI;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C452D0", Offset = "0x6C43ED0", VA = "0x186C452D0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C45280", Offset = "0x6C43E80", VA = "0x186C45280")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C450C0", Offset = "0x6C43CC0", VA = "0x186C450C0")]
		private void AOMCLLGKENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C453C0", Offset = "0x6C43FC0", VA = "0x186C453C0")]
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
		private bool BDMGCMIEKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material KAKAIEEGKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private OKHLPEJPAJE EFGCJECGNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material IEEOMOKDDBK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private LOJCIBEGDLK FOOOEEMBFHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6C45C50", Offset = "0x6C44850", VA = "0x186C45C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OKHLPEJPAJE CPCDEHKCMGI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6C45ED0", Offset = "0x6C44AD0", VA = "0x186C45ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material IEMDIGDOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C45F00", Offset = "0x6C44B00", VA = "0x186C45F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C45E30", Offset = "0x6C44A30", VA = "0x186C45E30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C45A60", Offset = "0x6C44660", VA = "0x186C45A60", Slot = "8")]
		protected override void IPDICNEHLNH(JEBCAJJBJML NODFOKPMDNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C45E40", Offset = "0x6C44A40", VA = "0x186C45E40", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] LJPJJCHLAEA MPIFONPHODM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C45CE0", Offset = "0x6C448E0", VA = "0x186C45CE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C45740", Offset = "0x6C44340", VA = "0x186C45740")]
		private void ACLHNNAGOHP(bool KHODILEOPHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E10", Offset = "0x8A3A10", VA = "0x1808A4E10")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct KKIIMJGFGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly OKHLPEJPAJE EBFFHCBNEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int AEMBJNOJPMM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C42500", Offset = "0x6C41100", VA = "0x186C42500")]
	internal FGMODLNCGGL CCAPOKJDGIA()
	{
		return default(FGMODLNCGGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2151A10", Offset = "0x2150610", VA = "0x182151A10")]
	internal KKIIMJGFGLJ(OKHLPEJPAJE IGEADGIGICG, int CCJKEEKAJEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KLAOFIBLAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C42560", Offset = "0x6C41160", VA = "0x186C42560")]
	public static bool IIKNLHPAFLJ(this KKIIMJGFGLJ PHKDKADEGJF, KNFJLCFKECC JNAMAOFLFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C42540", Offset = "0x6C41140", VA = "0x186C42540")]
	internal static bool IIKNLHPAFLJ(this FGMODLNCGGL DGHEBOBGPDI, KNFJLCFKECC JNAMAOFLFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C425B0", Offset = "0x6C411B0", VA = "0x186C425B0")]
	public static float OKDIPNBCDCO(this KKIIMJGFGLJ PHKDKADEGJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA622D0", Offset = "0xA60ED0", VA = "0x180A622D0")]
	internal static float OKDIPNBCDCO(this FGMODLNCGGL DGHEBOBGPDI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MCLHMPIFPFC
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C3ED10", Offset = "0x6C3D910", VA = "0x186C3ED10")]
	public static void PEMBNJNAOHL(this KKIIMJGFGLJ PHKDKADEGJF, ReadOnlySpan<char> KADHDLGKNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C42960", Offset = "0x6C41560", VA = "0x186C42960")]
	internal static void PEMBNJNAOHL(this FGMODLNCGGL DGHEBOBGPDI, ReadOnlySpan<char> KADHDLGKNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C427F0", Offset = "0x6C413F0", VA = "0x186C427F0")]
	public static void DIKOEFAAIMJ(this KKIIMJGFGLJ BNFJLIEJPBL, float2 LBAGEEGAOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C42840", Offset = "0x6C41440", VA = "0x186C42840")]
	internal static void DIKOEFAAIMJ(this FGMODLNCGGL DGHEBOBGPDI, float2 LBAGEEGAOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C42850", Offset = "0x6C41450", VA = "0x186C42850")]
	public static void HAGDBBHEADP(this KKIIMJGFGLJ BNFJLIEJPBL, float GIDCFPAJCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C42890", Offset = "0x6C41490", VA = "0x186C42890")]
	internal static void HAGDBBHEADP(this FGMODLNCGGL DGHEBOBGPDI, float GIDCFPAJCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C42AB0", Offset = "0x6C416B0", VA = "0x186C42AB0")]
	internal static void PKNLPHJPJHF(this FGMODLNCGGL DGHEBOBGPDI, bool EHLKKODGCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C428B0", Offset = "0x6C414B0", VA = "0x186C428B0")]
	public static void HKBEOFBOMCA(this KKIIMJGFGLJ BNFJLIEJPBL, Color32 NKKLIFIFGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C428A0", Offset = "0x6C414A0", VA = "0x186C428A0")]
	internal static void HKBEOFBOMCA(this FGMODLNCGGL DGHEBOBGPDI, Color32 NKKLIFIFGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C42920", Offset = "0x6C41520", VA = "0x186C42920")]
	public static void OINNDOCBNHL(this KKIIMJGFGLJ BNFJLIEJPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C42910", Offset = "0x6C41510", VA = "0x186C42910")]
	internal static void OINNDOCBNHL(this FGMODLNCGGL DGHEBOBGPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C42780", Offset = "0x6C41380", VA = "0x186C42780")]
	internal static void CKEBLMFJJDC(this FGMODLNCGGL DGHEBOBGPDI, int LEPJFMHGPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C428F0", Offset = "0x6C414F0", VA = "0x186C428F0")]
	internal static void IFIBIBIPCGC(this FGMODLNCGGL DGHEBOBGPDI, int CGNHMLOGJEB, KNFJLCFKECC FKJIFCODFLK = KNFJLCFKECC.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HNHEBFLEHHA : IEquatable<HNHEBFLEHHA>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort OAJDMNIHGJP = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int IPDFJCHNAGI = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly HNHEBFLEHHA GNHHBNNLKMA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort HFLDMFHKPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF080", Offset = "0x1DDDC80", VA = "0x181DDF080")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF090", Offset = "0x1DDDC90", VA = "0x181DDF090")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OKHLPEJPAJE EBFFHCBNEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OFMFOLKKKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C39950", Offset = "0x6C38550", VA = "0x186C39950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C39C20", Offset = "0x6C38820", VA = "0x186C39C20")]
	public HNHEBFLEHHA(int HLLLDBHONEE, OKHLPEJPAJE IGEADGIGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C42270", Offset = "0x6C40E70", VA = "0x186C42270")]
	public bool CFNOLIDBHBN([Out] KKIIMJGFGLJ PHKDKADEGJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C42220", Offset = "0x6C40E20", VA = "0x186C42220")]
	public void BIODNPDBBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C39B60", Offset = "0x6C38760", VA = "0x186C39B60")]
	internal void OLDOPHLBJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C39A90", Offset = "0x6C38690", VA = "0x186C39A90", Slot = "4")]
	public bool Equals(HNHEBFLEHHA FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C42340", Offset = "0x6C40F40", VA = "0x186C42340", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C42400", Offset = "0x6C41000", VA = "0x186C42400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class OKHLPEJPAJE : IDisposable, DKNOFLOHJEI
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string EOGLGMDIHIF = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker GKHPCFPKDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string HFCJMBKPKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly CPLFBHGFHKM PFJNMPPFGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int GGKMIJFFMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal FGMODLNCGGL[] CMODNJOJDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HNHEBFLEHHA[] KFGFDEDMCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private LOJCIBEGDLK DICNPMIJJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FADAPJFHDIC OLILHPBIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly PHGIMOLJHPG CNNALBIEBCC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GMBAACDNNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C43050", Offset = "0x6C41C50", VA = "0x186C43050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EAMGCPMAJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A6470", Offset = "0x8A5070", VA = "0x1808A6470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LOJCIBEGDLK OIGGCGOFGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C43430", Offset = "0x6C42030", VA = "0x186C43430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CALKLIOFPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C432C0", Offset = "0x6C41EC0", VA = "0x186C432C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float BNJCDEMIKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C434B0", Offset = "0x6C420B0", VA = "0x186C434B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DKNOFLOHJEI.DBGAHHKCBOE BHJMHOGOCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x88C610", Offset = "0x88B210", VA = "0x18088C610", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88C750", Offset = "0x88B350", VA = "0x18088C750", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C43EA0", Offset = "0x6C42AA0", VA = "0x186C43EA0")]
	public OKHLPEJPAJE(CPLFBHGFHKM NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C43E20", Offset = "0x6C42A20", VA = "0x186C43E20")]
	public OKHLPEJPAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C42E00", Offset = "0x6C41A00", VA = "0x186C42E00")]
	public void CIBOHFMOAPI(GlyphMapAsset PBNHPDEGNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C42E40", Offset = "0x6C41A40", VA = "0x186C42E40")]
	public void CIBOHFMOAPI(LOJCIBEGDLK FFCBBGOKAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C43B50", Offset = "0x6C42750", VA = "0x186C43B50", Slot = "6")]
	public bool TryGetMeshBuffer([Out] LJPJJCHLAEA MPIFONPHODM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C43450", Offset = "0x6C42050", VA = "0x186C43450")]
	public void KJNABKJGDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C42F50", Offset = "0x6C41B50", VA = "0x186C42F50")]
	public bool CJPGCBPKCDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C42BD0", Offset = "0x6C417D0", VA = "0x186C42BD0")]
	public HNHEBFLEHHA BGBPHJALCGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C437E0", Offset = "0x6C423E0", VA = "0x186C437E0")]
	public void MKFPHKPNMPE(HNHEBFLEHHA GPEHCBOJBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C42AC0", Offset = "0x6C416C0", VA = "0x186C42AC0")]
	internal bool ACPCKCGLJLE(HNHEBFLEHHA GPEHCBOJBGP, [Out] KKIIMJGFGLJ PHKDKADEGJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C432E0", Offset = "0x6C41EE0", VA = "0x186C432E0")]
	private void JJMDMMAACIN(FGMODLNCGGL DGHEBOBGPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C430E0", Offset = "0x6C41CE0", VA = "0x186C430E0")]
	private void HMAHJADKJHM(int GJNJGOOJLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C42B70", Offset = "0x6C41770", VA = "0x186C42B70")]
	private bool AIKCGOKFAPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C38190", Offset = "0x6C36D90", VA = "0x186C38190")]
	private static int ADFNJKBLDJL(HNHEBFLEHHA GPEHCBOJBGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1AA9E20", Offset = "0x1AA8A20", VA = "0x181AA9E20")]
	private static ushort NHKMAHEPFAE(int MFJLAMOCOBC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C434D0", Offset = "0x6C420D0", VA = "0x186C434D0")]
	private Bounds LKCMALNGBNC()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C42FA0", Offset = "0x6C41BA0", VA = "0x186C42FA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CPLFBHGFHKM
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CPLFBHGFHKM KHAJLBMCNEJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float PDNAPAOIOJH = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int JMKPFNDHCHL = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int IFLFKJBMMDM = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color GLOCOEOKFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float LPILKPHANJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int IABMPGCFFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int LEAELNCFPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int IMCLOFPBOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int EIMAHMKHPCF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C407E0", Offset = "0x6C3F3E0", VA = "0x186C407E0")]
	internal CPLFBHGFHKM JFLPJJDIFOB()
	{
		return default(CPLFBHGFHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E5F0", Offset = "0x6C3D1F0", VA = "0x186C3E5F0")]
	[CompilerGenerated]
	internal static void JKLHFIKGHKL(int CABLCDOIFFL, int IEDAFAANJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C408F0", Offset = "0x6C3F4F0", VA = "0x186C408F0")]
	[CompilerGenerated]
	internal static void PLAJDBEHCGE(float CABLCDOIFFL, float IEDAFAANJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E540", Offset = "0x6C3D140", VA = "0x186C3E540")]
	[CompilerGenerated]
	internal static void JEONOEHAHBK(int CABLCDOIFFL, int NHAAPKIKFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C407C0", Offset = "0x6C3F3C0", VA = "0x186C407C0")]
	[CompilerGenerated]
	internal static void GFIMAPDFMAP(float CABLCDOIFFL, float NHAAPKIKFGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GJJCOCBNOOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C41760", Offset = "0x6C40360", VA = "0x186C41760")]
	public static (int, int) NHOGCEFJOJO(this OKHLPEJPAJE LBCPHNFGDOE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C416D0", Offset = "0x6C402D0", VA = "0x186C416D0")]
	public static float MPIODAEHBFH(this KKIIMJGFGLJ OLLMCKINAGC)
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
		public readonly HNHEBFLEHHA textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C456D0", Offset = "0x6C442D0", VA = "0x186C456D0")]
		public TextSegmentLayout(LayoutRect layoutRect, HNHEBFLEHHA textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C454A0", Offset = "0x6C440A0", VA = "0x186C454A0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C45510", Offset = "0x6C44110", VA = "0x186C45510")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C45440", Offset = "0x6C44040", VA = "0x186C45440")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class FADAPJFHDIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig MMKCKFBIHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float ALMIAHJNGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float EJFDOFEFOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float CMJEBPDPNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float ICDNJKKCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float KMFGIJGMEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float KMCAMNNCMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float GKANEJNJNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float IADLCGDJCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float KIPLOAPGJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float BNJCDEMIKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float CDOABNGKNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float CALKLIOFPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CPPCOPPHDKO[] LCCANJKEICG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int GFIOGAEBFLL = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private KLGNMCHMPHF[] LPNIKPCDIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int DIMFJCOAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private COOEKIKEPDJ[] DFCLNGFHJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int DCLOHPHEPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public CPPCOPPHDKO DMCNKCOKGHE;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C40B70", Offset = "0x6C3F770", VA = "0x186C40B70")]
	public void CIBOHFMOAPI(LOJCIBEGDLK OBLONGMKFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C40C00", Offset = "0x6C3F800", VA = "0x186C40C00")]
	public void CIBOHFMOAPI(GlyphUVConfig AFMANNCNENL, IEnumerable<COOEKIKEPDJ> PBNHPDEGNGG, COOEKIKEPDJ LHMKDDHALBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C40C80", Offset = "0x6C3F880", VA = "0x186C40C80")]
	internal void HODCGMLGHKK(GlyphUVConfig AFMANNCNENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C40DC0", Offset = "0x6C3F9C0", VA = "0x186C40DC0")]
	private void NEBMJEEMOEK(IEnumerable<COOEKIKEPDJ> PBNHPDEGNGG, COOEKIKEPDJ LHMKDDHALBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C412F0", Offset = "0x6C3FEF0", VA = "0x186C412F0")]
	public void PMBJLACNNAK([In] char FELKFCLNBFI, [Out] float2[] KAEGLEBCHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E7E0", Offset = "0x6C3D3E0", VA = "0x186C3E7E0")]
	private CPPCOPPHDKO OKLOMFPKMFM(COOEKIKEPDJ HPDFHPBDIFD)
	{
		return default(CPPCOPPHDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C41620", Offset = "0x6C40220", VA = "0x186C41620")]
	public FADAPJFHDIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ADOFIHMLNPP
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C40610", Offset = "0x6C3F210", VA = "0x186C40610")]
	public static void EMNGMAGKHCB([In] float GDNKCHLIEHO, [In] float IJBBNDOHCNI, [In] int EJDDFOBJIAH, [In] int OLMJHCMMFCJ, [In] float ICDNJKKCGLN, [In] float KMFGIJGMEKG, [In] float OBFJGKLDKFP, [In] float OMDFFBLEKLL, [In] float ABNFJIOMJKO, [In] float LIAACDJJNNB, [Out] float IBJGENKOINK, [Out] float DOGJPHBDMPD, [Out] float GAGAJNANFPM, [Out] float CMAMLBPBCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C406E0", Offset = "0x6C3F2E0", VA = "0x186C406E0")]
	public static void EMNGMAGKHCB([In] float GDNKCHLIEHO, [In] float IJBBNDOHCNI, [In] int EJDDFOBJIAH, [In] int OLMJHCMMFCJ, [Out] float IBJGENKOINK, [Out] float DOGJPHBDMPD, [Out] float GAGAJNANFPM, [Out] float CMAMLBPBCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C405B0", Offset = "0x6C3F1B0", VA = "0x186C405B0")]
	public static void DDHMAFECJHP([In] float ICDNJKKCGLN, [In] float KMFGIJGMEKG, [In] float ECCMHPIFHNJ, [In] float FEDLJOKLPFI, [In] float KOCLHDFDJPN, [In] float JKOONDEHIJN, [Out] float IFNEDPHIEAM, [Out] float JKFJDBMFIOM, [Out] float AJIMIOCMFAA, [Out] float NINBIBILFJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct KLGNMCHMPHF
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint OKJILBCMMMC = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char BFDMHCAHHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly CPPCOPPHDKO JDJAFDBBMGL;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C425F0", Offset = "0x6C411F0", VA = "0x186C425F0")]
	public KLGNMCHMPHF(char FELKFCLNBFI, CPPCOPPHDKO KAEGLEBCHIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CPPCOPPHDKO
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint OKJILBCMMMC = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] NEFEMIALDEE;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C409C0", Offset = "0x6C3F5C0", VA = "0x186C409C0")]
	public CPPCOPPHDKO(float IBJGENKOINK, float DOGJPHBDMPD, float GAGAJNANFPM, float CMAMLBPBCMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct FGMODLNCGGL
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int AFEOKLIPEBP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal KNFJLCFKECC FKJIFCODFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] AHNKPHGKEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int OICBPCFENIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 LBAGEEGAOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float FGAJJAHJEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 JLELJPGLKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool EHLKKODGCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int LAKNKHNJLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int NDGBIBPDEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int DIGFFEKOMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int AGMBLNBKLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C416C0", Offset = "0x6C402C0", VA = "0x186C416C0")]
	public static int BLMNDECIJDE(int EHENNABILPO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum KNFJLCFKECC : byte
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
public static class DHCDKBDOCHH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C40B30", Offset = "0x6C3F730", VA = "0x186C40B30")]
	internal static float MPIODAEHBFH(this FGMODLNCGGL DGHEBOBGPDI, float MIMFLKBAJCN, float CABMHLJKBCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C40AB0", Offset = "0x6C3F6B0", VA = "0x186C40AB0")]
	internal static void HEHIKHMLHAP(this FGMODLNCGGL DGHEBOBGPDI, float MIMFLKBAJCN, float CABMHLJKBCD, [Out] float2 FDBDHJDBKGA, [Out] float2 CAIIHNDCIIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class PHGIMOLJHPG : DKNOFLOHJEI
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int BHGIMOCIOKP = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int AMCHECBAKJG = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string EOGLGMDIHIF = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static PGKCFHHEBHO AOIOEIAFIBB;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static PGKCFHHEBHO GACKGHLDNFI;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static PGKCFHHEBHO LPNJIHCAKJM;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static PGKCFHHEBHO MEEBCECPOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly LJPJJCHLAEA MPIFONPHODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] PBODBAFEAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] HNPAKECAODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int JGOCICPDCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int DDHOBFIDNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int CBNNCBIBIPD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GMBAACDNNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DKNOFLOHJEI.DBGAHHKCBOE BHJMHOGOCML
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C44FB0", Offset = "0x6C43BB0", VA = "0x186C44FB0")]
	public PHGIMOLJHPG(LJPJJCHLAEA.MNPCIOFHKGJ OOJLEEGBBME, int FDLNJMBLHGE, int EMAMIJMBANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C44E30", Offset = "0x6C43A30", VA = "0x186C44E30", Slot = "5")]
	public bool TryGetMeshBuffer([Out] LJPJJCHLAEA MPIFONPHODM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C444B0", Offset = "0x6C430B0", VA = "0x186C444B0")]
	public void KEKHMPKJGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C444D0", Offset = "0x6C430D0", VA = "0x186C444D0")]
	public void NIKKJHHKFNG(Span<FGMODLNCGGL> NDLNAEMHCGP, FADAPJFHDIC ADBJENDJPAE, [In] CPLFBHGFHKM NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C3ED60", Offset = "0x6C3D960", VA = "0x186C3ED60")]
	private void FBJPIAPLCOB([In] KNFJLCFKECC FKJIFCODFLK, [In] FGMODLNCGGL JGNDDBPHHFF, int NEIANMGPEAK, [In] float MIMFLKBAJCN, [In] float CABMHLJKBCD, FADAPJFHDIC ADBJENDJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C44CE0", Offset = "0x6C438E0", VA = "0x186C44CE0")]
	private void NINMKCPDPDA([In] KNFJLCFKECC FKJIFCODFLK, FGMODLNCGGL JGNDDBPHHFF, [In] int KFIFOLBHJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C442E0", Offset = "0x6C42EE0", VA = "0x186C442E0")]
	public static void GDEOBEHDBLD(ReadOnlySpan<FGMODLNCGGL> NDLNAEMHCGP, int PGDLJOCFCIC, [Out] int MNEHBBLPMGH, [Out] int KFBEFMFEDPA, [Out] int OIFNGCIFGFL)
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
