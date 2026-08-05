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
public class DLLAGJDPIJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D KLGAPMLJLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig KIJBCBDJGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public BLLIPCIECHB[] IGGIILAEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public BLLIPCIECHB MIHJGLGANFJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static DLLAGJDPIJA HFDMCLAECJB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DLLAGJDPIJA EOIJCJFLFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7279770", Offset = "0x7278570", VA = "0x187279770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public DLLAGJDPIJA()
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
		[Cpp2IlInjected.Address(RVA = "0x727C740", Offset = "0x727B540", VA = "0x18727C740")]
		public GlyphUVConfig(int AAIHPAECNAC, int FMIMHFNNBHE, int CKLHHDDJOCE, int HCOOEOICACN, float AHPELBGPNFN = 0f, [Optional] GlyphPixelInset MIAEJILDFLJ)
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
public readonly struct BLLIPCIECHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char BMICJKGAMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int IKPOJMIBCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int PPEAIELKAMG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly BLLIPCIECHB IIGNAKLHBOM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7278940", Offset = "0x7277740", VA = "0x187278940")]
	public BLLIPCIECHB(char HPLJNDFHILJ, int HLJGFKIFFBA, int DLALJOHKGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7278920", Offset = "0x7277720", VA = "0x187278920")]
	public BLLIPCIECHB(GlyphCoordinateWritable NIPDGFKLKEO)
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
		[Cpp2IlInjected.Address(RVA = "0x727BD50", Offset = "0x727AB50", VA = "0x18727BD50")]
		public static BLLIPCIECHB JCHCBNMNCNP(GlyphCoordinateWritable MKIHPGLMNDF)
		{
			return default(BLLIPCIECHB);
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
		private DLLAGJDPIJA configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x727C640", Offset = "0x727B440", VA = "0x18727C640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x727C4C0", Offset = "0x727B2C0", VA = "0x18727C4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3030", VA = "0x1808F4230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x727C4B0", Offset = "0x727B2B0", VA = "0x18727C4B0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DLLAGJDPIJA ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x727BEA0", Offset = "0x727ACA0", VA = "0x18727BEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BLLIPCIECHB FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x727C320", Offset = "0x727B120", VA = "0x18727C320")]
			get
			{
				return default(BLLIPCIECHB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x727BD70", Offset = "0x727AB70", VA = "0x18727BD70")]
		internal void CFFBPMCFHOF(IEnumerable<GlyphCoordinateWritable> DGPFJGLPGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x727BE10", Offset = "0x727AC10", VA = "0x18727BE10")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x727BDF0", Offset = "0x727ABF0", VA = "0x18727BDF0")]
		[CompilerGenerated]
		private bool JFDECABJHEE(GlyphCoordinateWritable MKIHPGLMNDF)
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
		private TextSegmentMeshBufferSource DAMOMKMHEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private FKOCNIPMAEG HGHJABBBNPD;

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
		private AGHNDECPEGP MHFLODMFLDL;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x727D140", Offset = "0x727BF40", VA = "0x18727D140")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x727D0F0", Offset = "0x727BEF0", VA = "0x18727D0F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x727CF30", Offset = "0x727BD30", VA = "0x18727CF30")]
		private void FHECOOFKBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x727D230", Offset = "0x727C030", VA = "0x18727D230")]
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
		private bool GGPHPDCPOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material MANGLICCCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private FKOCNIPMAEG HGHJABBBNPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material KJIMIEFDMNI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DLLAGJDPIJA GIKGCBEFLML
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x727D5B0", Offset = "0x727C3B0", VA = "0x18727D5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FKOCNIPMAEG MFMOIJPIKIH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x727DD20", Offset = "0x727CB20", VA = "0x18727DD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material IDIEIGIKADJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x727DD50", Offset = "0x727CB50", VA = "0x18727DD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x727DC80", Offset = "0x727CA80", VA = "0x18727DC80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x727DAB0", Offset = "0x727C8B0", VA = "0x18727DAB0", Slot = "8")]
		protected override void PIHALEFAHNE(FIABBFOOJIP EGMFFFNPKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x727DC90", Offset = "0x727CA90", VA = "0x18727DC90", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] AHEKHBDNPHP GIACAMNHIFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x727D960", Offset = "0x727C760", VA = "0x18727D960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x727D640", Offset = "0x727C440", VA = "0x18727D640")]
		private void DEMBABNLDHK(bool MKKNPGPEIPF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x912AB0", Offset = "0x9118B0", VA = "0x180912AB0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct KKMEOAJCAGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly FKOCNIPMAEG NAGLKAPDIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int HJOKDGFINPO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x727CBB0", Offset = "0x727B9B0", VA = "0x18727CBB0")]
	internal BBJGFNJMHHK JOFHOAIOFAJ()
	{
		return default(BBJGFNJMHHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2523650", Offset = "0x2522450", VA = "0x182523650")]
	internal KKMEOAJCAGH(FKOCNIPMAEG HLDNIAJEGKP, int EFMKBJGBBIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HPJLOCCKEHG
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x727C790", Offset = "0x727B590", VA = "0x18727C790")]
	public static bool BLOLPPMLOND(this KKMEOAJCAGH CICKFBFLHJE, PODINNMCDOD CLPHEMOILDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x727C770", Offset = "0x727B570", VA = "0x18727C770")]
	internal static bool BLOLPPMLOND(this BBJGFNJMHHK APIKBBNNHIA, PODINNMCDOD CLPHEMOILDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x727C7E0", Offset = "0x727B5E0", VA = "0x18727C7E0")]
	public static float HJPJPCGCOFC(this KKMEOAJCAGH CICKFBFLHJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBF1C10", Offset = "0xBF0A10", VA = "0x180BF1C10")]
	internal static float HJPJPCGCOFC(this BBJGFNJMHHK APIKBBNNHIA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PIPGEJKNCAN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7278390", Offset = "0x7277190", VA = "0x187278390")]
	public static void NKCJKAHEGCN(this KKMEOAJCAGH CICKFBFLHJE, ReadOnlySpan<char> OJHMMHIPGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x727CDE0", Offset = "0x727BBE0", VA = "0x18727CDE0")]
	internal static void NKCJKAHEGCN(this BBJGFNJMHHK APIKBBNNHIA, ReadOnlySpan<char> OJHMMHIPGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x727CCD0", Offset = "0x727BAD0", VA = "0x18727CCD0")]
	public static void GLFCHJEPPFJ(this KKMEOAJCAGH JDFINMBAJBO, float2 NMENAJFKOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x727CCC0", Offset = "0x727BAC0", VA = "0x18727CCC0")]
	internal static void GLFCHJEPPFJ(this BBJGFNJMHHK APIKBBNNHIA, float2 NMENAJFKOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x727CDA0", Offset = "0x727BBA0", VA = "0x18727CDA0")]
	public static void LHCBDNGOBFG(this KKMEOAJCAGH JDFINMBAJBO, float OFJJEIFLHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x727CD90", Offset = "0x727BB90", VA = "0x18727CD90")]
	internal static void LHCBDNGOBFG(this BBJGFNJMHHK APIKBBNNHIA, float OFJJEIFLHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x727CCB0", Offset = "0x727BAB0", VA = "0x18727CCB0")]
	internal static void FCPJFJDHFLL(this BBJGFNJMHHK APIKBBNNHIA, bool BEEHKEBCCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x727CD40", Offset = "0x727BB40", VA = "0x18727CD40")]
	public static void KKJLGMEMAKL(this KKMEOAJCAGH JDFINMBAJBO, Color32 EDAHAPFCLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x727CD80", Offset = "0x727BB80", VA = "0x18727CD80")]
	internal static void KKJLGMEMAKL(this BBJGFNJMHHK APIKBBNNHIA, Color32 EDAHAPFCLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x727CC60", Offset = "0x727BA60", VA = "0x18727CC60")]
	public static void EDBJOPMFKDD(this KKMEOAJCAGH JDFINMBAJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x727CCA0", Offset = "0x727BAA0", VA = "0x18727CCA0")]
	internal static void EDBJOPMFKDD(this BBJGFNJMHHK APIKBBNNHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x727CBF0", Offset = "0x727B9F0", VA = "0x18727CBF0")]
	internal static void AIHMOGPEPBH(this BBJGFNJMHHK APIKBBNNHIA, int MFJIIPMCBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x727CD20", Offset = "0x727BB20", VA = "0x18727CD20")]
	internal static void KKCJEHFHBLG(this BBJGFNJMHHK APIKBBNNHIA, int HBFHADBOMCO, PODINNMCDOD DEKFGDOBLNI = PODINNMCDOD.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AGHNDECPEGP : IEquatable<AGHNDECPEGP>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort GGABJFHIBPP = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int HLMKLKGBCHN = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly AGHNDECPEGP BOBNNICBKIC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort CLECDELBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB1CA70", Offset = "0xB1B870", VA = "0x180B1CA70")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB1CA80", Offset = "0xB1B880", VA = "0x180B1CA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FKOCNIPMAEG NAGLKAPDIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72708C0", Offset = "0x726F6C0", VA = "0x1872708C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72709B0", Offset = "0x726F7B0", VA = "0x1872709B0")]
	public AGHNDECPEGP(int LGNNFADIAJF, FKOCNIPMAEG HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7278660", Offset = "0x7277460", VA = "0x187278660")]
	public bool IJCIDHGPJBB([Out] KKMEOAJCAGH CICKFBFLHJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7278730", Offset = "0x7277530", VA = "0x187278730")]
	public void PBAOHHFJIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7270690", Offset = "0x726F490", VA = "0x187270690")]
	internal void AAKLGCKBCJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72706C0", Offset = "0x726F4C0", VA = "0x1872706C0", Slot = "4")]
	public bool Equals(AGHNDECPEGP LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7278530", Offset = "0x7277330", VA = "0x187278530", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72785F0", Offset = "0x72773F0", VA = "0x1872785F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FKOCNIPMAEG : IDisposable, OKLBKOCAMKG
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string EOJIDMGKPDH = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker BJMPHPKOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string FBHHABICODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly IPCACBAANEN NNLFGAPGDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int PLHOFDBOJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal BBJGFNJMHHK[] IGCCHONIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal AGHNDECPEGP[] BPONMEKJFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private DLLAGJDPIJA FMBGMMACPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ELIGPDLFACM NDPHNKAAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly DAMDKKGAGMO HONJMALJLDB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string PPKJBGAOBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x727AF40", Offset = "0x7279D40", VA = "0x18727AF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DLLAGJDPIJA IEMCLKGLGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x727AF20", Offset = "0x7279D20", VA = "0x18727AF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float LABKLOLNJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x727AFD0", Offset = "0x7279DD0", VA = "0x18727AFD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float FLGLOFJCKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x727B5D0", Offset = "0x727A3D0", VA = "0x18727B5D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OKLBKOCAMKG.PKBHBJIHMBO OGBGMIEBHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8F4220", Offset = "0x8F3020", VA = "0x1808F4220", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x727B890", Offset = "0x727A690", VA = "0x18727B890")]
	public FKOCNIPMAEG(IPCACBAANEN LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x727BCD0", Offset = "0x727AAD0", VA = "0x18727BCD0")]
	public FKOCNIPMAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x727AEE0", Offset = "0x7279CE0", VA = "0x18727AEE0")]
	public void EODJIAICOIO(GlyphMapAsset NIKDOHJJEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x727ADD0", Offset = "0x7279BD0", VA = "0x18727ADD0")]
	public void EODJIAICOIO(DLLAGJDPIJA FMOBMCFIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x727B5F0", Offset = "0x727A3F0", VA = "0x18727B5F0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] AHEKHBDNPHP GIACAMNHIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x727B520", Offset = "0x727A320", VA = "0x18727B520")]
	public void MPEGKGFHPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x727B580", Offset = "0x727A380", VA = "0x18727B580")]
	public bool OEMODGHAAFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x727B280", Offset = "0x727A080", VA = "0x18727B280")]
	public AGHNDECPEGP MHMDBDPPKFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x727A900", Offset = "0x7279700", VA = "0x18727A900")]
	public void EELLOEABAGC(AGHNDECPEGP JBLFCDLBNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x727AFF0", Offset = "0x7279DF0", VA = "0x18727AFF0")]
	internal bool KFIFGPBIJCM(AGHNDECPEGP JBLFCDLBNIP, [Out] KKMEOAJCAGH CICKFBFLHJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x727AC80", Offset = "0x7279A80", VA = "0x18727AC80")]
	private void EMPHEHOAEFP(BBJGFNJMHHK APIKBBNNHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x727B0A0", Offset = "0x7279EA0", VA = "0x18727B0A0")]
	private void MAECHABCMFC(int ELGOPMIHIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x727B4C0", Offset = "0x727A2C0", VA = "0x18727B4C0")]
	private bool MILNNCLMBEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7272F60", Offset = "0x7271D60", VA = "0x187272F60")]
	private static int GECGEMCKBMP(AGHNDECPEGP JBLFCDLBNIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3710", Offset = "0x1EB2510", VA = "0x181EB3710")]
	private static ushort DBHHFANNCKH(int KNCPCNBMDNF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x727A540", Offset = "0x7279340", VA = "0x18727A540")]
	private Bounds CEJJILNIHKO()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x727A850", Offset = "0x7279650", VA = "0x18727A850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IPCACBAANEN
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IPCACBAANEN NNOOPIAFJMF;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float CLDEAAFPEAC = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LCHPBCNKCLA = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int APBNLNGOBFG = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color CPIMNPLMDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float PCGDOOHGIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int CHAFMKHLMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int KFNBJLKPFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int MDFMAEBNDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int BNDMJLAJEMJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x727C860", Offset = "0x727B660", VA = "0x18727C860")]
	internal IPCACBAANEN KMEAIBFOEPC()
	{
		return default(IPCACBAANEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7270AC0", Offset = "0x726F8C0", VA = "0x187270AC0")]
	[CompilerGenerated]
	internal static void POAPGANGFLG(int IPHILEOFJLB, int KBHDDKCAINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x727C840", Offset = "0x727B640", VA = "0x18727C840")]
	[CompilerGenerated]
	internal static void GDLGPIGNENI(float IPHILEOFJLB, float KBHDDKCAINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7270A10", Offset = "0x726F810", VA = "0x187270A10")]
	[CompilerGenerated]
	internal static void NNNAEEEPNGO(int IPHILEOFJLB, int BAPOJJKGHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x727C820", Offset = "0x727B620", VA = "0x18727C820")]
	[CompilerGenerated]
	internal static void BGJHOOIHCIM(float IPHILEOFJLB, float BAPOJJKGHML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BLJGECGIBJP
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7278840", Offset = "0x7277640", VA = "0x187278840")]
	public static float OMHDEBCBBOM(this KKMEOAJCAGH HKHCDDIJIBO)
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
		public readonly AGHNDECPEGP textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x727D540", Offset = "0x727C340", VA = "0x18727D540")]
		public TextSegmentLayout(LayoutRect layoutRect, AGHNDECPEGP textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x727D310", Offset = "0x727C110", VA = "0x18727D310")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x727D380", Offset = "0x727C180", VA = "0x18727D380")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x727D2B0", Offset = "0x727C0B0", VA = "0x18727D2B0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class ELIGPDLFACM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig PDKOHAKHCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float FPGEPMAIEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float KJFBIDAPCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float KJGLMBPDIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float OIBGNFPMJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float CNAOIJALICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float ENDDHNLBKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float LACKFMJHBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float JHCOMMFDLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float HOMJNJMCBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float FLGLOFJCKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float CBBAONEEJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float LABKLOLNJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly EMEFNDPPODK[] IOPNODAPPJK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int POKHFONBLIL = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private BABBIINILCC[] IMBBEBGJOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int HBEHEMCEAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private BLLIPCIECHB[] HPFFKFNONPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int DICIABAFKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public EMEFNDPPODK LNCHKNIOPHH;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7279970", Offset = "0x7278770", VA = "0x187279970")]
	public void EODJIAICOIO(DLLAGJDPIJA CFNEMOAEGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72798F0", Offset = "0x72786F0", VA = "0x1872798F0")]
	public void EODJIAICOIO(GlyphUVConfig FIDMEHHHNIO, IEnumerable<BLLIPCIECHB> NIKDOHJJEPO, BLLIPCIECHB BLLOHBMLCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7279A00", Offset = "0x7278800", VA = "0x187279A00")]
	internal void GBPAOOCKPLB(GlyphUVConfig FIDMEHHHNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7279E70", Offset = "0x7278C70", VA = "0x187279E70")]
	private void MHDBKMMMMNL(IEnumerable<BLLIPCIECHB> NIKDOHJJEPO, BLLIPCIECHB BLLOHBMLCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7279B40", Offset = "0x7278940", VA = "0x187279B40")]
	public void LOGMLOHOJGE([In] char HPLJNDFHILJ, [Out] float2[] PHDEOJBKMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72781B0", Offset = "0x7276FB0", VA = "0x1872781B0")]
	private EMEFNDPPODK PLJCDNIKJBC(BLLIPCIECHB NIPDGFKLKEO)
	{
		return default(EMEFNDPPODK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x727A3B0", Offset = "0x72791B0", VA = "0x18727A3B0")]
	public ELIGPDLFACM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KDIIKCLLPDL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x727CA80", Offset = "0x727B880", VA = "0x18727CA80")]
	public static void IOPMGGJOBME([In] float JPDBBNDGJOO, [In] float DMPKPHNMCFL, [In] int IOLBOIIHCBC, [In] int ILOIJBIKMAF, [In] float OIBGNFPMJEM, [In] float CNAOIJALICE, [In] float HKINADMCKGG, [In] float CIGBOACOIAE, [In] float CDFDAKGDODD, [In] float IIAIKDFPJHH, [Out] float BHPENKOCPIM, [Out] float EHNGHDELGPH, [Out] float FBMBOFAMJEJ, [Out] float FLEOEOJNFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x727CA20", Offset = "0x727B820", VA = "0x18727CA20")]
	public static void IOPMGGJOBME([In] float JPDBBNDGJOO, [In] float DMPKPHNMCFL, [In] int IOLBOIIHCBC, [In] int ILOIJBIKMAF, [Out] float BHPENKOCPIM, [Out] float EHNGHDELGPH, [Out] float FBMBOFAMJEJ, [Out] float FLEOEOJNFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x727CB50", Offset = "0x727B950", VA = "0x18727CB50")]
	public static void LCHDGPNHIHF([In] float OIBGNFPMJEM, [In] float CNAOIJALICE, [In] float GHCOFGAGBHN, [In] float HOOLDGMHODL, [In] float HJELOCDEPJJ, [In] float CLMGHFPEGMC, [Out] float BNDIIBAAGPC, [Out] float EMILDMNOHPF, [Out] float ECPHKFHLKKE, [Out] float CGGEMPKEFJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct BABBIINILCC
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint GEBGAPBHOOB = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char BMICJKGAMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly EMEFNDPPODK BADBNJLMPEO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7278810", Offset = "0x7277610", VA = "0x187278810")]
	public BABBIINILCC(char HPLJNDFHILJ, EMEFNDPPODK PHDEOJBKMOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct EMEFNDPPODK
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint GEBGAPBHOOB = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] MKOCDJLBMGN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x727A450", Offset = "0x7279250", VA = "0x18727A450")]
	public EMEFNDPPODK(float BHPENKOCPIM, float EHNGHDELGPH, float FBMBOFAMJEJ, float FLEOEOJNFKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct BBJGFNJMHHK
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int PGAGPEPKAPA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal PODINNMCDOD DEKFGDOBLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] ONAHLHCLECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int GMJDCGPMFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 NMENAJFKOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float LEKNOJMJPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 LKPDLNLDJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool BEEHKEBCCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int FPCGKLNOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int AMLMMFDCPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int ELHOAPOEMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int MFPCHPCHLDP;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7278830", Offset = "0x7277630", VA = "0x187278830")]
	public static int FLBGHFLJEPJ(int APIFIDFJCKI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum PODINNMCDOD : byte
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
public static class CPEBHCLJFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72789D0", Offset = "0x72777D0", VA = "0x1872789D0")]
	internal static float OMHDEBCBBOM(this BBJGFNJMHHK APIKBBNNHIA, float CFJLPPIABJP, float OIKDGFICGPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7278950", Offset = "0x7277750", VA = "0x187278950")]
	internal static void FMJMJNGIHOD(this BBJGFNJMHHK APIKBBNNHIA, float CFJLPPIABJP, float OIKDGFICGPN, [Out] float2 KGJBAAHPLAG, [Out] float2 GAMKMEIMNNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class DAMDKKGAGMO : OKLBKOCAMKG
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int HNKJCINNBIH = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int LPMAPHKIBKJ = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string EOJIDMGKPDH = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static OFPGCFNHODP KNEMAGJKIBL;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static OFPGCFNHODP JJNDPPFAMCB;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static OFPGCFNHODP HIOMMOBHLNA;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static OFPGCFNHODP DGLPADPEPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly AHEKHBDNPHP GIACAMNHIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] GOACPPOGKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] LGFDOOGEEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int EIGDLLNHOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int GAMEJNENFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int MLHDFBKJNDM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PPKJBGAOBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OKLBKOCAMKG.PKBHBJIHMBO OGBGMIEBHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7279660", Offset = "0x7278460", VA = "0x187279660")]
	public DAMDKKGAGMO(AHEKHBDNPHP.PHOHOMANBDI EOLDJFMKCMA, int PBIJNLKKLIK, int BLIKJMBFHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72794D0", Offset = "0x72782D0", VA = "0x1872794D0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] AHEKHBDNPHP GIACAMNHIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7279360", Offset = "0x7278160", VA = "0x187279360")]
	public void EPKJDKKODNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7278A10", Offset = "0x7277810", VA = "0x187278A10")]
	public void AEJDLKBOGDA(Span<BBJGFNJMHHK> MANIBGDLJMJ, ELIGPDLFACM JCBIMCOAHPE, [In] IPCACBAANEN LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7277010", Offset = "0x7275E10", VA = "0x187277010")]
	private void NAKENNPGDME([In] PODINNMCDOD DEKFGDOBLNI, [In] BBJGFNJMHHK NPIGJGPIJHJ, int PBDPHHAIJII, [In] float CFJLPPIABJP, [In] float OIKDGFICGPN, ELIGPDLFACM JCBIMCOAHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7279380", Offset = "0x7278180", VA = "0x187279380")]
	private void OAMHHBEDPBE([In] PODINNMCDOD DEKFGDOBLNI, BBJGFNJMHHK NPIGJGPIJHJ, [In] int GNOEPODBEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7279190", Offset = "0x7277F90", VA = "0x187279190")]
	public static void ELBNEFLHEOE(ReadOnlySpan<BBJGFNJMHHK> MANIBGDLJMJ, int CFJOLMMIAGJ, [Out] int PPENHHPMOEG, [Out] int MLGJBMHLPAC, [Out] int GINABHKOJOF)
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
