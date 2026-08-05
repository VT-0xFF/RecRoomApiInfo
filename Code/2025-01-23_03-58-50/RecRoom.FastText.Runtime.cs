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
public class HGCDCNJLPOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D NLNBJMEGDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig NIFJEJEFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ILKGGKBCFKJ[] AFFAPCFIFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ILKGGKBCFKJ OBGKHMMAPPO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static HGCDCNJLPOM KMDGJGLLHEO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HGCDCNJLPOM GNFIOGGLMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F47DC0", Offset = "0x6F465C0", VA = "0x186F47DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public HGCDCNJLPOM()
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
		[Cpp2IlInjected.Address(RVA = "0x6F47A90", Offset = "0x6F46290", VA = "0x186F47A90")]
		public GlyphUVConfig(int KKJBDFLJACF, int GBLGMJCKIKE, int JJEIPDOCODF, int FEPBGDABBGI, float EKCDECCFALE = 0f, [Optional] GlyphPixelInset MFPEDKPELBM)
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
public readonly struct ILKGGKBCFKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char LMAOAPHNJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int EGIKMLOLPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int JAIAOFOEJCN;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly ILKGGKBCFKJ OCBFPFMNDKC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F48190", Offset = "0x6F46990", VA = "0x186F48190")]
	public ILKGGKBCFKJ(char CJLILDHECJD, int JJJJDKLPCLI, int CAHCPDIJGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F481A0", Offset = "0x6F469A0", VA = "0x186F481A0")]
	public ILKGGKBCFKJ(GlyphCoordinateWritable CNOIECBFNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x6F470A0", Offset = "0x6F458A0", VA = "0x186F470A0")]
		public static ILKGGKBCFKJ FMEIMHFCNHG(GlyphCoordinateWritable HPEMNIMCDDO)
		{
			return default(ILKGGKBCFKJ);
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
		private HGCDCNJLPOM configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6F47990", Offset = "0x6F46190", VA = "0x186F47990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6F47810", Offset = "0x6F46010", VA = "0x186F47810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8B7500", Offset = "0x8B5D00", VA = "0x1808B7500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6F47800", Offset = "0x6F46000", VA = "0x186F47800")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HGCDCNJLPOM ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F471F0", Offset = "0x6F459F0", VA = "0x186F471F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ILKGGKBCFKJ FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F47670", Offset = "0x6F45E70", VA = "0x186F47670")]
			get
			{
				return default(ILKGGKBCFKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F470E0", Offset = "0x6F458E0", VA = "0x186F470E0")]
		internal void JDPAFFHLHMG(IEnumerable<GlyphCoordinateWritable> KFCFJNMLBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F47160", Offset = "0x6F45960", VA = "0x186F47160")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F470C0", Offset = "0x6F458C0", VA = "0x186F470C0")]
		[CompilerGenerated]
		private bool BPMHLDEGBGG(GlyphCoordinateWritable HPEMNIMCDDO)
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
		private TextSegmentMeshBufferSource IHBDHGIGLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PMAPFGKHBBP NFBDJCBBHNH;

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
		private HEJOCJDBJNF ABHLHPFAECO;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A940", Offset = "0x6F49140", VA = "0x186F4A940")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A8F0", Offset = "0x6F490F0", VA = "0x186F4A8F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AA30", Offset = "0x6F49230", VA = "0x186F4AA30")]
		private void PKEABLEADGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F4ABF0", Offset = "0x6F493F0", VA = "0x186F4ABF0")]
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
		private bool DIDJKDKLDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material CFIDNCDLOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private PMAPFGKHBBP NFBDJCBBHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material MFLFFCFJMMO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private HGCDCNJLPOM ENMGDKDMICL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F4B460", Offset = "0x6F49C60", VA = "0x186F4B460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PMAPFGKHBBP GMIKBDOPEDA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F4B6E0", Offset = "0x6F49EE0", VA = "0x186F4B6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material HBFJPJKLJKF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4B710", Offset = "0x6F49F10", VA = "0x186F4B710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B640", Offset = "0x6F49E40", VA = "0x186F4B640")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AF70", Offset = "0x6F49770", VA = "0x186F4AF70", Slot = "8")]
		protected override void AAADHPADMFC(NDEKLFKFBLK EPBHGAJFGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B650", Offset = "0x6F49E50", VA = "0x186F4B650", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] BINONGFCNFD AFBHIDLEOBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B4F0", Offset = "0x6F49CF0", VA = "0x186F4B4F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B140", Offset = "0x6F49940", VA = "0x186F4B140")]
		private void JPOMAJFOOAG(bool KHDIFEIJFDB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FE0", Offset = "0x8D17E0", VA = "0x1808D2FE0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct NKLJGOAEBJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly PMAPFGKHBBP GGNKCEAABDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int CLMGLGMLMOD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F490B0", Offset = "0x6F478B0", VA = "0x186F490B0")]
	internal BBIBGKCDBBH DFPHLDKKCGG()
	{
		return default(BBIBGKCDBBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x230E2C0", Offset = "0x230CAC0", VA = "0x18230E2C0")]
	internal NKLJGOAEBJC(PMAPFGKHBBP JIPBFCNFKIF, int IHFFLBMAMFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NBICPGDMFMF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F49060", Offset = "0x6F47860", VA = "0x186F49060")]
	public static bool JNBCNNHBMID(this NKLJGOAEBJC GPILFHBJAHJ, GNKLGPFGJLH FCBFAPBJIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F49040", Offset = "0x6F47840", VA = "0x186F49040")]
	internal static bool JNBCNNHBMID(this BBIBGKCDBBH CPFIBEOJPJC, GNKLGPFGJLH FCBFAPBJIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F49000", Offset = "0x6F47800", VA = "0x186F49000")]
	public static float BLHJOAEIEFL(this NKLJGOAEBJC GPILFHBJAHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x96C580", Offset = "0x96AD80", VA = "0x18096C580")]
	internal static float BLHJOAEIEFL(this BBIBGKCDBBH CPFIBEOJPJC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GMPHBPBHPOD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F45850", Offset = "0x6F44050", VA = "0x186F45850")]
	public static void KNCOHJAECNC(this NKLJGOAEBJC GPILFHBJAHJ, ReadOnlySpan<char> ECNHBJEFLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F46E50", Offset = "0x6F45650", VA = "0x186F46E50")]
	internal static void KNCOHJAECNC(this BBIBGKCDBBH CPFIBEOJPJC, ReadOnlySpan<char> ECNHBJEFLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F46FB0", Offset = "0x6F457B0", VA = "0x186F46FB0")]
	public static void LDMOJCHBDEH(this NKLJGOAEBJC CBKFNAPLHOB, float2 HGFJAGIJIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F46FA0", Offset = "0x6F457A0", VA = "0x186F46FA0")]
	internal static void LDMOJCHBDEH(this BBIBGKCDBBH CPFIBEOJPJC, float2 HGFJAGIJIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F47000", Offset = "0x6F45800", VA = "0x186F47000")]
	public static void NLOHJCKBJAC(this NKLJGOAEBJC CBKFNAPLHOB, float GPGMANJHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F47040", Offset = "0x6F45840", VA = "0x186F47040")]
	internal static void NLOHJCKBJAC(this BBIBGKCDBBH CPFIBEOJPJC, float GPGMANJHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F46E40", Offset = "0x6F45640", VA = "0x186F46E40")]
	internal static void IDAIEGKIDEE(this BBIBGKCDBBH CPFIBEOJPJC, bool EDLAPGJLOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F47060", Offset = "0x6F45860", VA = "0x186F47060")]
	public static void OEOFOHDLNHN(this NKLJGOAEBJC CBKFNAPLHOB, Color32 LCDEMOPFJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F47050", Offset = "0x6F45850", VA = "0x186F47050")]
	internal static void OEOFOHDLNHN(this BBIBGKCDBBH CPFIBEOJPJC, Color32 LCDEMOPFJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F46DF0", Offset = "0x6F455F0", VA = "0x186F46DF0")]
	public static void HBLHEIAHEHF(this NKLJGOAEBJC CBKFNAPLHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F46E30", Offset = "0x6F45630", VA = "0x186F46E30")]
	internal static void HBLHEIAHEHF(this BBIBGKCDBBH CPFIBEOJPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F46D80", Offset = "0x6F45580", VA = "0x186F46D80")]
	internal static void GOHCMFFOOEH(this BBIBGKCDBBH CPFIBEOJPJC, int CKIJNKMEBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F46D60", Offset = "0x6F45560", VA = "0x186F46D60")]
	internal static void FGCKFFPKFOL(this BBIBGKCDBBH CPFIBEOJPJC, int EMBAOCMFNIO, GNKLGPFGJLH PMKCFBOELJP = GNKLGPFGJLH.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HEJOCJDBJNF : IEquatable<HEJOCJDBJNF>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort COOMNPNILIK = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int BLABNHMDOHJ = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly HEJOCJDBJNF JEDKANOONMK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort EFIGOACLPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2161C90", Offset = "0x2160490", VA = "0x182161C90")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2161CA0", Offset = "0x21604A0", VA = "0x182161CA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PMAPFGKHBBP GGNKCEAABDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LNCHMIOPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6F415A0", Offset = "0x6F3FDA0", VA = "0x186F415A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F41690", Offset = "0x6F3FE90", VA = "0x186F41690")]
	public HEJOCJDBJNF(int PFDAJIMMNFL, PMAPFGKHBBP JIPBFCNFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F47C60", Offset = "0x6F46460", VA = "0x186F47C60")]
	public bool NOAFFAEIJIF([Out] NKLJGOAEBJC GPILFHBJAHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F47C10", Offset = "0x6F46410", VA = "0x186F47C10")]
	public void JGKHHIOHILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F41500", Offset = "0x6F3FD00", VA = "0x186F41500")]
	internal void FHEHDHDKNPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F413E0", Offset = "0x6F3FBE0", VA = "0x186F413E0", Slot = "4")]
	public bool Equals(HEJOCJDBJNF LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F47AE0", Offset = "0x6F462E0", VA = "0x186F47AE0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F47BA0", Offset = "0x6F463A0", VA = "0x186F47BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class PMAPFGKHBBP : IDisposable, EBHJNILHBLH
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string KEKNJNHHGDN = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker PFENBIEDKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string KLLAMAJHALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly IKIAEEOIJJH CANEKAOHJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int PJONOIDNCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal BBIBGKCDBBH[] HKKBBKEMCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HEJOCJDBJNF[] KELKIJGGFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private HGCDCNJLPOM GGIPOPIDHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MDOMHGDIEEE CCGOCOEEDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly CBKPCCCNHAE OOEGNOMOBBL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string IKMKCMDHFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6F49C20", Offset = "0x6F48420", VA = "0x186F49C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HGCDCNJLPOM PENNHKIKGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F49E00", Offset = "0x6F48600", VA = "0x186F49E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float NCCGGMCBMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F49730", Offset = "0x6F47F30", VA = "0x186F49730")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CGGAIMILKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F49330", Offset = "0x6F47B30", VA = "0x186F49330")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EBHJNILHBLH.NJIMHGEBFKF CKIJGOFIDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B7530", Offset = "0x8B5D30", VA = "0x1808B7530", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B74F0", Offset = "0x8B5CF0", VA = "0x1808B74F0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A430", Offset = "0x6F48C30", VA = "0x186F4A430")]
	public PMAPFGKHBBP(IKIAEEOIJJH MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A870", Offset = "0x6F49070", VA = "0x186F4A870")]
	public PMAPFGKHBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F49CB0", Offset = "0x6F484B0", VA = "0x186F49CB0")]
	public void LDJJIOLOFEI(GlyphMapAsset DJEBNKPGJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F49CF0", Offset = "0x6F484F0", VA = "0x186F49CF0")]
	public void LDJJIOLOFEI(HGCDCNJLPOM MBJPBFMOFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A190", Offset = "0x6F48990", VA = "0x186F4A190", Slot = "6")]
	public bool TryGetMeshBuffer([Out] BINONGFCNFD AFBHIDLEOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A130", Offset = "0x6F48930", VA = "0x186F4A130")]
	public void OCHCAABDHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F49800", Offset = "0x6F48000", VA = "0x186F49800")]
	public bool FPPLNJOAHCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F490F0", Offset = "0x6F478F0", VA = "0x186F490F0")]
	public HEJOCJDBJNF AEFDPEONALE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F49850", Offset = "0x6F48050", VA = "0x186F49850")]
	public void HEDKMAGEEHG(HEJOCJDBJNF LHKAFIDPJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F49350", Offset = "0x6F47B50", VA = "0x186F49350")]
	internal bool BEOGHHCDLPM(HEJOCJDBJNF LHKAFIDPJLG, [Out] NKLJGOAEBJC GPILFHBJAHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F49400", Offset = "0x6F47C00", VA = "0x186F49400")]
	private void BGMCKEHDCFA(BBIBGKCDBBH CPFIBEOJPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F49550", Offset = "0x6F47D50", VA = "0x186F49550")]
	private void CCDONBPANFA(int MJCCPFOGLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F49BC0", Offset = "0x6F483C0", VA = "0x186F49BC0")]
	private bool JMOHODACABJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F40A90", Offset = "0x6F3F290", VA = "0x186F40A90")]
	private static int JHHLMJFMOCI(HEJOCJDBJNF LHKAFIDPJLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F0D0", Offset = "0x1C5D8D0", VA = "0x181C5F0D0")]
	private static ushort LIJIAOJNLCN(int ECDOOAABOPD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F49E20", Offset = "0x6F48620", VA = "0x186F49E20")]
	private Bounds NGHHFFJNHPL()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F49750", Offset = "0x6F47F50", VA = "0x186F49750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IKIAEEOIJJH
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IKIAEEOIJJH MGEIPAAHDNB;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float MCENMLFKFHD = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int OCGABFADKPA = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int OKPBFFCBBHP = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color PLMOMDMBJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float KHCABDDANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int HJBHOAEIBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int EFFKAFJKGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int BPNDFACINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int BCHMNNMFJLF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F47F40", Offset = "0x6F46740", VA = "0x186F47F40")]
	internal IKIAEEOIJJH JLOKGEDKACK()
	{
		return default(IKIAEEOIJJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F41210", Offset = "0x6F3FA10", VA = "0x186F41210")]
	[CompilerGenerated]
	internal static void CJFAHNKPKAJ(int INDENPJBLHO, int DFEJJOPGBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F48050", Offset = "0x6F46850", VA = "0x186F48050")]
	[CompilerGenerated]
	internal static void OAMBLBACLIN(float INDENPJBLHO, float DFEJJOPGBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F41200", Offset = "0x6F3FA00", VA = "0x186F41200")]
	[CompilerGenerated]
	internal static void JBHACJHNEDL(int INDENPJBLHO, int EGPKMMFHCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F48070", Offset = "0x6F46870", VA = "0x186F48070")]
	[CompilerGenerated]
	internal static void OMILJKBIJFN(float INDENPJBLHO, float EGPKMMFHCMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LMGNADDANNG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F48410", Offset = "0x6F46C10", VA = "0x186F48410")]
	public static float AHPLGLFHPJN(this NKLJGOAEBJC PBEOMPDNOKD)
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
		public readonly HEJOCJDBJNF textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AF00", Offset = "0x6F49700", VA = "0x186F4AF00")]
		public TextSegmentLayout(LayoutRect layoutRect, HEJOCJDBJNF textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F4ACD0", Offset = "0x6F494D0", VA = "0x186F4ACD0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AD40", Offset = "0x6F49540", VA = "0x186F4AD40")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AC70", Offset = "0x6F49470", VA = "0x186F4AC70")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class MDOMHGDIEEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig DIAMCJBBHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float KLPCDEKCANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float IMENEINIJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float PFEECDKHMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float KFCBDHOGNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float JIFDDPMAPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float BCBKDGIIMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float IDGCHIDLHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float CLFIAJDGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float DOANOIBGEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float CGGAIMILKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float BJILEPMFLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float NCCGGMCBMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CBIEBADKNJC[] IDLAKGFFOLD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int OHJBFNMHCBD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private HCPLIOLJLNK[] OGFGBMOFGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int FICDDIBJHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private ILKGGKBCFKJ[] EGEIFMNJGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int LHIIMLGAJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public CBIEBADKNJC GMCEKPJOAAA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F48BA0", Offset = "0x6F473A0", VA = "0x186F48BA0")]
	public void LDJJIOLOFEI(HGCDCNJLPOM DOPHNFDGMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6F48B20", Offset = "0x6F47320", VA = "0x186F48B20")]
	public void LDJJIOLOFEI(GlyphUVConfig BAOOFGPKGJO, IEnumerable<ILKGGKBCFKJ> DJEBNKPGJME, ILKGGKBCFKJ LBLDJBKBOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F484A0", Offset = "0x6F46CA0", VA = "0x186F484A0")]
	internal void FBEFBDOLOLF(GlyphUVConfig BAOOFGPKGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F485E0", Offset = "0x6F46DE0", VA = "0x186F485E0")]
	private void JHKDDHMNLNI(IEnumerable<ILKGGKBCFKJ> DJEBNKPGJME, ILKGGKBCFKJ LBLDJBKBOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F48C30", Offset = "0x6F47430", VA = "0x186F48C30")]
	public void MLKCNBPPONL([In] char CJLILDHECJD, [Out] float2[] NDJEPEMMDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F459F0", Offset = "0x6F441F0", VA = "0x186F459F0")]
	private CBIEBADKNJC HCOIMGEKJJO(ILKGGKBCFKJ CNOIECBFNBP)
	{
		return default(CBIEBADKNJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F48F60", Offset = "0x6F47760", VA = "0x186F48F60")]
	public MDOMHGDIEEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LBIFCBLMHCL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F48220", Offset = "0x6F46A20", VA = "0x186F48220")]
	public static void KEOOCKENADH([In] float MPFKICJMFKD, [In] float FIJBLEHCPAM, [In] int GIFBAAEIOHE, [In] int FBJNCCKLMCJ, [In] float KFCBDHOGNDO, [In] float JIFDDPMAPOH, [In] float OMCEGBNGHKB, [In] float FEOFOOOOEPO, [In] float LEIHENGBILA, [In] float ALIFMEPNPPD, [Out] float AIALJCPFJNP, [Out] float OMGFOMNPKNC, [Out] float BAGGCKIACMJ, [Out] float FIIOLBMACPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F482F0", Offset = "0x6F46AF0", VA = "0x186F482F0")]
	public static void KEOOCKENADH([In] float MPFKICJMFKD, [In] float FIJBLEHCPAM, [In] int GIFBAAEIOHE, [In] int FBJNCCKLMCJ, [Out] float AIALJCPFJNP, [Out] float OMGFOMNPKNC, [Out] float BAGGCKIACMJ, [Out] float FIIOLBMACPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F481C0", Offset = "0x6F469C0", VA = "0x186F481C0")]
	public static void FIHCKJGBHGL([In] float KFCBDHOGNDO, [In] float JIFDDPMAPOH, [In] float HGPCGPOJLIA, [In] float KGEEBEPHOPM, [In] float GBNCCILPGFO, [In] float AEMJBKLNNPM, [Out] float OJBIFDCMHIF, [Out] float HMNKIIGNLII, [Out] float GADBDBLHIPB, [Out] float HFNMKPGJCDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct HCPLIOLJLNK
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint MBFNIJDKBNE = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char LMAOAPHNJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly CBIEBADKNJC FHDAHFDPBOD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F47AC0", Offset = "0x6F462C0", VA = "0x186F47AC0")]
	public HCPLIOLJLNK(char CJLILDHECJD, CBIEBADKNJC NDJEPEMMDIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CBIEBADKNJC
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint MBFNIJDKBNE = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] AGOJFDJLLKI;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F45F10", Offset = "0x6F44710", VA = "0x186F45F10")]
	public CBIEBADKNJC(float AIALJCPFJNP, float OMGFOMNPKNC, float BAGGCKIACMJ, float FIIOLBMACPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct BBIBGKCDBBH
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int CEOHJCNHEEJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal GNKLGPFGJLH PMKCFBOELJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] CFDBFKHOAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int FJDKJHLCDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 HGFJAGIJIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float MDEMOKEECAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 PBDLMMFJIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool EDLAPGJLOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int CEBDOCNHFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int JFNPNNEOPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int ABHPGCADMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int GMKELAJOJHB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F45F00", Offset = "0x6F44700", VA = "0x186F45F00")]
	public static int GKCCMGJMNNL(int MHLLACKFALN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum GNKLGPFGJLH : byte
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
public static class LGGAMDCMHAG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F48350", Offset = "0x6F46B50", VA = "0x186F48350")]
	internal static float AHPLGLFHPJN(this BBIBGKCDBBH CPFIBEOJPJC, float AJGENDNGAFL, float BLFOBBBFLKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F48390", Offset = "0x6F46B90", VA = "0x186F48390")]
	internal static void PGFAPIPINLN(this BBIBGKCDBBH CPFIBEOJPJC, float AJGENDNGAFL, float BLFOBBBFLKL, [Out] float2 GMIGPGIEBMN, [Out] float2 KMLOFEFLFLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class CBKPCCCNHAE : EBHJNILHBLH
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int DCOMAIPFOGA = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int PMGEKPDIBMF = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string KEKNJNHHGDN = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static BAHDNLOHNON OEHKBJPEIGF;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static BAHDNLOHNON CLJGOFPCACL;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static BAHDNLOHNON DBNBPKPMBGP;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static BAHDNLOHNON IBNDEMGADMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly BINONGFCNFD AFBHIDLEOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] ENDNKLHGONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] FCFCMPGHLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int MCJPAKKABMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int CHLDAKNJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int LMLCPHFHEHE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string IKMKCMDHFDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EBHJNILHBLH.NJIMHGEBFKF CKIJGOFIDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F46C50", Offset = "0x6F45450", VA = "0x186F46C50")]
	public CBKPCCCNHAE(BINONGFCNFD.AANLOHOMNPE GGFFLCBLIKL, int OAIFADGANHF, int CFEPADKCPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F46AC0", Offset = "0x6F452C0", VA = "0x186F46AC0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] BINONGFCNFD AFBHIDLEOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F46AA0", Offset = "0x6F452A0", VA = "0x186F46AA0")]
	public void LCMJHHEKMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F46000", Offset = "0x6F44800", VA = "0x186F46000")]
	public void DDNIGGGAPON(Span<BBIBGKCDBBH> BIMDBMLFHOI, MDOMHGDIEEE FFJNBDMCDDG, [In] IKIAEEOIJJH MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F449E0", Offset = "0x6F431E0", VA = "0x186F449E0")]
	private void LIHLGDECLIH([In] GNKLGPFGJLH PMKCFBOELJP, [In] BBIBGKCDBBH KGCJBIDCLBK, int AMOJODPDEDI, [In] float AJGENDNGAFL, [In] float BLFOBBBFLKL, MDOMHGDIEEE FFJNBDMCDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F46780", Offset = "0x6F44F80", VA = "0x186F46780")]
	private void GCBDHCGOHMN([In] GNKLGPFGJLH PMKCFBOELJP, BBIBGKCDBBH KGCJBIDCLBK, [In] int ALIAEPEHKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F468D0", Offset = "0x6F450D0", VA = "0x186F468D0")]
	public static void GICGKMIDBHP(ReadOnlySpan<BBIBGKCDBBH> BIMDBMLFHOI, int ONFDHICFBDN, [Out] int BHOIANBJNOH, [Out] int MPHAFMMGACE, [Out] int CKFIODBFNMD)
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
