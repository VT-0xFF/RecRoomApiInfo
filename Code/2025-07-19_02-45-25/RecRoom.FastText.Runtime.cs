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
public class MMCDEELEPMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D JFNAFNGHFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig FFEOLJOAOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public DCNCOBBKLJB[] JJKPAHKDFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public DCNCOBBKLJB EPHPBGGIDOP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MMCDEELEPMK PEJKFPLLDOC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MMCDEELEPMK BBENPCNBHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81675B0", Offset = "0x81665B0", VA = "0x1881675B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MMCDEELEPMK()
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
		[Cpp2IlInjected.Address(RVA = "0x81671D0", Offset = "0x81661D0", VA = "0x1881671D0")]
		public GlyphUVConfig(int CJGEOCJKACL, int JMDEBNLJLGP, int KHIPMAMDGFF, int AOLICMKKAAA, float ABMMDOEBDFF = 0f, [Optional] GlyphPixelInset FNNMEEFHDIG)
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
public readonly struct DCNCOBBKLJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char NBJPHIABGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int HGIKKDKJJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int EBKDHAJLEPC;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly DCNCOBBKLJB ILKDCBKLIGD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8166270", Offset = "0x8165270", VA = "0x188166270")]
	public DCNCOBBKLJB(char IJFECLKHMMP, int AKBPHANNGDH, int MDKJJMHCNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8166250", Offset = "0x8165250", VA = "0x188166250")]
	public DCNCOBBKLJB(GlyphCoordinateWritable BOJGMDJHPMN)
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
		[Cpp2IlInjected.Address(RVA = "0x81667E0", Offset = "0x81657E0", VA = "0x1881667E0")]
		public static DCNCOBBKLJB MJOOONLKLLN(GlyphCoordinateWritable JKODNDABGFB)
		{
			return default(DCNCOBBKLJB);
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
		private MMCDEELEPMK configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x81670D0", Offset = "0x81660D0", VA = "0x1881670D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8166F50", Offset = "0x8165F50", VA = "0x188166F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8166F40", Offset = "0x8165F40", VA = "0x188166F40")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MMCDEELEPMK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8166930", Offset = "0x8165930", VA = "0x188166930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private DCNCOBBKLJB FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8166DB0", Offset = "0x8165DB0", VA = "0x188166DB0")]
			get
			{
				return default(DCNCOBBKLJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8166800", Offset = "0x8165800", VA = "0x188166800")]
		internal void LABJANKLPHD(IEnumerable<GlyphCoordinateWritable> GAMPBEFGLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81668A0", Offset = "0x81658A0", VA = "0x1881668A0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8166880", Offset = "0x8165880", VA = "0x188166880")]
		[CompilerGenerated]
		private bool NIMOAHELFOE(GlyphCoordinateWritable JKODNDABGFB)
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
		private TextSegmentMeshBufferSource JKEAODOMHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PNMLBNOOEII CIBDJNIPCDF;

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
		private BBGBODCIKAH NFGOACHILNK;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81692B0", Offset = "0x81682B0", VA = "0x1881692B0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8169260", Offset = "0x8168260", VA = "0x188169260")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8169080", Offset = "0x8168080", VA = "0x188169080")]
		private void HAKLOHOHEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81693A0", Offset = "0x81683A0", VA = "0x1881693A0")]
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
		private bool MDICLKKJMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material LFHHOPIIOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private PNMLBNOOEII CIBDJNIPCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material GMKDJMPFJCH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private MMCDEELEPMK NJGDHLFCEFG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8169720", Offset = "0x8168720", VA = "0x188169720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PNMLBNOOEII AMDBHKFJCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8169EB0", Offset = "0x8168EB0", VA = "0x188169EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material KKDKAJPAMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8169EE0", Offset = "0x8168EE0", VA = "0x188169EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8169E10", Offset = "0x8168E10", VA = "0x188169E10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81697B0", Offset = "0x81687B0", VA = "0x1881697B0", Slot = "8")]
		protected override void FGACNCHLPPO(JPPEJJOGHMN IEHJFIDJBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8169E20", Offset = "0x8168E20", VA = "0x188169E20", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] HHGECPNCMCC MHCLKHJGDKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8169CC0", Offset = "0x8168CC0", VA = "0x188169CC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81699A0", Offset = "0x81689A0", VA = "0x1881699A0")]
		private void MJJBEEKOEKM(bool HOJOMGEINAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA7CF30", Offset = "0xA7BF30", VA = "0x180A7CF30")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct PDCNNFPHEBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly PNMLBNOOEII HNLPFMEENCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int BMBBHFHLOAK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81677F0", Offset = "0x81667F0", VA = "0x1881677F0")]
	internal ELCAHCODHJN IHNIMHLAHMG()
	{
		return default(ELCAHCODHJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2A22480", Offset = "0x2A21480", VA = "0x182A22480")]
	internal PDCNNFPHEBJ(PNMLBNOOEII PAOKFDJPALE, int JODPNAOFFOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GEDDGLAOEAF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8166770", Offset = "0x8165770", VA = "0x188166770")]
	public static bool IEIJIEBIDBN(this PDCNNFPHEBJ MDFHODFKIMK, OKMPJANEMMH LBBKDMAKGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81667C0", Offset = "0x81657C0", VA = "0x1881667C0")]
	internal static bool IEIJIEBIDBN(this ELCAHCODHJN HJEILCDOKGB, OKMPJANEMMH LBBKDMAKGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8166730", Offset = "0x8165730", VA = "0x188166730")]
	public static float EGNJFHPAKBE(this PDCNNFPHEBJ MDFHODFKIMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xABF200", Offset = "0xABE200", VA = "0x180ABF200")]
	internal static float EGNJFHPAKBE(this ELCAHCODHJN HJEILCDOKGB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FOFHDNIBOLB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8166490", Offset = "0x8165490", VA = "0x188166490")]
	public static void BCFHGPNNPCF(this PDCNNFPHEBJ MDFHODFKIMK, ReadOnlySpan<char> KMHECINEGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8166290", Offset = "0x8165290", VA = "0x188166290")]
	internal static void BCFHGPNNPCF(this ELCAHCODHJN HJEILCDOKGB, ReadOnlySpan<char> KMHECINEGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x81664E0", Offset = "0x81654E0", VA = "0x1881664E0")]
	public static void BHHPNKNKICL(this PDCNNFPHEBJ BINCINDINMB, float2 FOHPFMEEMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8166530", Offset = "0x8165530", VA = "0x188166530")]
	internal static void BHHPNKNKICL(this ELCAHCODHJN HJEILCDOKGB, float2 FOHPFMEEMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81665B0", Offset = "0x81655B0", VA = "0x1881665B0")]
	public static void GAFBCMOCNOO(this PDCNNFPHEBJ BINCINDINMB, float BHNODEEEOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8166570", Offset = "0x8165570", VA = "0x188166570")]
	internal static void GAFBCMOCNOO(this ELCAHCODHJN HJEILCDOKGB, float BHNODEEEOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8166560", Offset = "0x8165560", VA = "0x188166560")]
	internal static void CKCOOMLKFKH(this ELCAHCODHJN HJEILCDOKGB, bool LCNBBOBKGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81666E0", Offset = "0x81656E0", VA = "0x1881666E0")]
	public static void LACEALEKEFI(this PDCNNFPHEBJ BINCINDINMB, Color32 AHIICABHHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8166720", Offset = "0x8165720", VA = "0x188166720")]
	internal static void LACEALEKEFI(this ELCAHCODHJN HJEILCDOKGB, Color32 AHIICABHHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8166630", Offset = "0x8165630", VA = "0x188166630")]
	public static void JAGOCBGLLKF(this PDCNNFPHEBJ BINCINDINMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8166620", Offset = "0x8165620", VA = "0x188166620")]
	internal static void JAGOCBGLLKF(this ELCAHCODHJN HJEILCDOKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8166670", Offset = "0x8165670", VA = "0x188166670")]
	internal static void JFPLCNAPOAE(this ELCAHCODHJN HJEILCDOKGB, int HAEEGCEPKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8166540", Offset = "0x8165540", VA = "0x188166540")]
	internal static void BKHBAPNPOLB(this ELCAHCODHJN HJEILCDOKGB, int HOCDHPDNCDJ, OKMPJANEMMH KIEOIOJLKMI = OKMPJANEMMH.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BBGBODCIKAH : IEquatable<BBGBODCIKAH>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort NNPEBJNLDGA = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int OAMEPBLOMFH = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly BBGBODCIKAH OGEBOJIIDFJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort EGOHOKMHAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xD67BB0", Offset = "0xD66BB0", VA = "0x180D67BB0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD67BC0", Offset = "0xD66BC0", VA = "0x180D67BC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PNMLBNOOEII HNLPFMEENCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KJIKLILMPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x815BBC0", Offset = "0x815ABC0", VA = "0x18815BBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x815BEE0", Offset = "0x815AEE0", VA = "0x18815BEE0")]
	public BBGBODCIKAH(int FCOPFFEGHHH, PNMLBNOOEII PAOKFDJPALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8165F20", Offset = "0x8164F20", VA = "0x188165F20")]
	public bool DIMGHBCDHHF([Out] PDCNNFPHEBJ MDFHODFKIMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8165FF0", Offset = "0x8164FF0", VA = "0x188165FF0")]
	public void ECPMCGAOIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x815BC90", Offset = "0x815AC90", VA = "0x18815BC90")]
	internal void EIOIHELFFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x815BCC0", Offset = "0x815ACC0", VA = "0x18815BCC0", Slot = "4")]
	public bool Equals(BBGBODCIKAH EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8166040", Offset = "0x8165040", VA = "0x188166040", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8166100", Offset = "0x8165100", VA = "0x188166100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class PNMLBNOOEII : IDisposable, OCMHEPHCGKM
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string HGKGFIHEIHG = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker CPPKOLPNMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string OFFBGMGPCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly LPGFKGIHKIC FCJNCLGCKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int KAMIJOJOHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal ELCAHCODHJN[] GDBOHCFKNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal BBGBODCIKAH[] IDGGMCJCBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MMCDEELEPMK MACCCLCBBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ABENFKLFMAP JNIPJHMKNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly AECGGLEDNEF OFHLJBOEJFM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string HJLBILHBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8167E20", Offset = "0x8166E20", VA = "0x188167E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MMCDEELEPMK BGLFCNBHPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8167B00", Offset = "0x8166B00", VA = "0x188167B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float GFBKOLKGBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81685F0", Offset = "0x81675F0", VA = "0x1881685F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float LAAJBKIOIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8167CA0", Offset = "0x8166CA0", VA = "0x188167CA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OCMHEPHCGKM.PEEJHGBGHPH FONLGBLHJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA631C0", Offset = "0xA621C0", VA = "0x180A631C0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8168C40", Offset = "0x8167C40", VA = "0x188168C40")]
	public PNMLBNOOEII(LPGFKGIHKIC ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8168BC0", Offset = "0x8167BC0", VA = "0x188168BC0")]
	public PNMLBNOOEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8168500", Offset = "0x8167500", VA = "0x188168500")]
	public void LMCEEELLBNF(GlyphMapAsset AAGNFIIGMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81683F0", Offset = "0x81673F0", VA = "0x1881683F0")]
	public void LMCEEELLBNF(MMCDEELEPMK AEKAINJKFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8168920", Offset = "0x8167920", VA = "0x188168920", Slot = "6")]
	public bool TryGetMeshBuffer([Out] HHGECPNCMCC MHCLKHJGDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8168540", Offset = "0x8167540", VA = "0x188168540")]
	public void MHEPPCMODLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81685A0", Offset = "0x81675A0", VA = "0x1881685A0")]
	public bool NIHKNHNNPKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8167830", Offset = "0x8166830", VA = "0x188167830")]
	public BBGBODCIKAH BOEBDOEPBCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8168090", Offset = "0x8167090", VA = "0x188168090")]
	public void GIMLCEGIGLE(BBGBODCIKAH OLMJFEJOAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8167D70", Offset = "0x8166D70", VA = "0x188167D70")]
	internal bool FGHBGIIHKAG(BBGBODCIKAH OLMJFEJOAAD, [Out] PDCNNFPHEBJ MDFHODFKIMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8167B20", Offset = "0x8166B20", VA = "0x188167B20")]
	private void DNLGOAJAMGH(ELCAHCODHJN HJEILCDOKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8167EB0", Offset = "0x8166EB0", VA = "0x188167EB0")]
	private void GICCFNMLAND(int ICDBHMKDOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8167AA0", Offset = "0x8166AA0", VA = "0x188167AA0")]
	private bool CKNLDDCIJBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81621B0", Offset = "0x81611B0", VA = "0x1881621B0")]
	private static int MLBPGAHPBGP(BBGBODCIKAH OLMJFEJOAAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24B4730", Offset = "0x24B3730", VA = "0x1824B4730")]
	private static ushort FAHNHPBAMJL(int HLGKMAPOEBE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8168610", Offset = "0x8167610", VA = "0x188168610")]
	private Bounds PCIGABDNDEK()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8167CC0", Offset = "0x8166CC0", VA = "0x188167CC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LPGFKGIHKIC
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly LPGFKGIHKIC JJGPGHOJCDA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float IIJNKAIEBMN = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int ALEPKHOHFNE = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HCPFNGOOMDL = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color JCIALHEAKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float HLFLHNPFNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int PEBAFFNPMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int FKGAGGGIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int IIMDFDGHPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int OEOCGJECGID;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x81673B0", Offset = "0x81663B0", VA = "0x1881673B0")]
	internal LPGFKGIHKIC MKALHPNJAJN()
	{
		return default(LPGFKGIHKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x815E8C0", Offset = "0x815D8C0", VA = "0x18815E8C0")]
	[CompilerGenerated]
	internal static void LFMIMPIIDPF(int IOALKPFEKEK, int CAILINJCNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x81674C0", Offset = "0x81664C0", VA = "0x1881674C0")]
	[CompilerGenerated]
	internal static void PHIAKDBCDKO(float IOALKPFEKEK, float CAILINJCNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x815E8B0", Offset = "0x815D8B0", VA = "0x18815E8B0")]
	[CompilerGenerated]
	internal static void LEHCCDHKJGG(int IOALKPFEKEK, int MNHABCIHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8167390", Offset = "0x8166390", VA = "0x188167390")]
	[CompilerGenerated]
	internal static void IELIOCGFDBE(float IOALKPFEKEK, float MNHABCIHNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BAFACIAONLG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8165E90", Offset = "0x8164E90", VA = "0x188165E90")]
	public static float IGMKEFOLAFM(this PDCNNFPHEBJ LGEOCLHKELN)
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
		public readonly BBGBODCIKAH textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x81696B0", Offset = "0x81686B0", VA = "0x1881696B0")]
		public TextSegmentLayout(LayoutRect layoutRect, BBGBODCIKAH textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8169480", Offset = "0x8168480", VA = "0x188169480")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x81694F0", Offset = "0x81684F0", VA = "0x1881694F0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8169420", Offset = "0x8168420", VA = "0x188169420")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class ABENFKLFMAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig NNMFILBKAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float CLMOMLDBMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float HOJLGODOFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float COOFNAHFNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float JCAAFCIMOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float FEAOJIFHDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float ENINNCOJNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float PKGBFLLBHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float JPJPLFGLLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float PFFNHPEHGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float LAAJBKIOIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float NJADHNDLCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float GFBKOLKGBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AAIELLANHPD[] DOGECFGIFNN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int BCPIMKLFCLL = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private MFLOOJDFBNB[] DCJMCLOACLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int KFKODOCGNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private DCNCOBBKLJB[] OOLKJKJDGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int FILJPCJPBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public AAIELLANHPD DINCEJCABCF;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8164EE0", Offset = "0x8163EE0", VA = "0x188164EE0")]
	public void LMCEEELLBNF(MMCDEELEPMK LMAPKIOHPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8164F70", Offset = "0x8163F70", VA = "0x188164F70")]
	public void LMCEEELLBNF(GlyphUVConfig LFBKOAIANBA, IEnumerable<DCNCOBBKLJB> AAGNFIIGMLI, DCNCOBBKLJB AFGDKAEIMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8164A70", Offset = "0x8163A70", VA = "0x188164A70")]
	internal void EMNHPEOBLGP(GlyphUVConfig LFBKOAIANBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8164530", Offset = "0x8163530", VA = "0x188164530")]
	private void CJKCCDGEGJN(IEnumerable<DCNCOBBKLJB> AAGNFIIGMLI, DCNCOBBKLJB AFGDKAEIMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8164BB0", Offset = "0x8163BB0", VA = "0x188164BB0")]
	public void GDHDMPEHIHF([In] char IJFECLKHMMP, [Out] float2[] IBPBPKFPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8162800", Offset = "0x8161800", VA = "0x188162800")]
	private AAIELLANHPD OJODOBFGOIF(DCNCOBBKLJB BOJGMDJHPMN)
	{
		return default(AAIELLANHPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8164FF0", Offset = "0x8163FF0", VA = "0x188164FF0")]
	public ABENFKLFMAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LNAJDDHBKKI
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8167200", Offset = "0x8166200", VA = "0x188167200")]
	public static void AONPNACGGKK([In] float HHMFDIBMGGM, [In] float PCOHIMBAKOI, [In] int IKGEHNNGJJK, [In] int EDFJIEFPPBG, [In] float JCAAFCIMOOD, [In] float FEAOJIFHDCO, [In] float LOCEGFGLJLD, [In] float NJEABMHJLHD, [In] float CFACJLNAJAB, [In] float MGHHPFKDBDB, [Out] float HJBCGLFELOF, [Out] float CBOIHPIOGJC, [Out] float NMMAFLHGBMJ, [Out] float HKBIAKLODAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x81672D0", Offset = "0x81662D0", VA = "0x1881672D0")]
	public static void AONPNACGGKK([In] float HHMFDIBMGGM, [In] float PCOHIMBAKOI, [In] int IKGEHNNGJJK, [In] int EDFJIEFPPBG, [Out] float HJBCGLFELOF, [Out] float CBOIHPIOGJC, [Out] float NMMAFLHGBMJ, [Out] float HKBIAKLODAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8167330", Offset = "0x8166330", VA = "0x188167330")]
	public static void BLDLEHGGDDI([In] float JCAAFCIMOOD, [In] float FEAOJIFHDCO, [In] float CCGKEBIKHKC, [In] float JLBGBJOOPDG, [In] float KDAABMGFEMN, [In] float GEMHNDOKBFP, [Out] float HLOCDAGIPCB, [Out] float LCDKAHACNPB, [Out] float EEINHNEIJAK, [Out] float AHEPFEIHDEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct MFLOOJDFBNB
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint CFGHINNHCDC = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char NBJPHIABGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly AAIELLANHPD JMODECHHOJF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8167590", Offset = "0x8166590", VA = "0x188167590")]
	public MFLOOJDFBNB(char IJFECLKHMMP, AAIELLANHPD IBPBPKFPDAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct AAIELLANHPD
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint CFGHINNHCDC = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] LMDBPDJJKIN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8164440", Offset = "0x8163440", VA = "0x188164440")]
	public AAIELLANHPD(float HJBCGLFELOF, float CBOIHPIOGJC, float NMMAFLHGBMJ, float HKBIAKLODAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct ELCAHCODHJN
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int NEEGJHKNHEN = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal OKMPJANEMMH KIEOIOJLKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] PPJNJIAKAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int GPFDIPFBNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 FOHPFMEEMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float FGBLDDBOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 LFIGFNNLHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool LCNBBOBKGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int AHNANPCHMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int JFKALJJBLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int CPJOHALNOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int HHFNJOHJOKM;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8166280", Offset = "0x8165280", VA = "0x188166280")]
	public static int ECGEKGIEBJE(int IPBAHOGPLMD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum OKMPJANEMMH : byte
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
public static class MPDDPKGMHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8167730", Offset = "0x8166730", VA = "0x188167730")]
	internal static float IGMKEFOLAFM(this ELCAHCODHJN HJEILCDOKGB, float OFNMICOKIBF, float MFLKGKLELDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8167770", Offset = "0x8166770", VA = "0x188167770")]
	internal static void INOINBKEPEG(this ELCAHCODHJN HJEILCDOKGB, float OFNMICOKIBF, float MFLKGKLELDJ, [Out] float2 IEGNAFDKBMI, [Out] float2 EOMGFLMBKFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class AECGGLEDNEF : OCMHEPHCGKM
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int FBDDEPHKCHO = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int NGMMLIDKDBG = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string HGKGFIHEIHG = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker ANOKMAAHJKP;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker HHAFDGFJFDA;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker DCKJOKANDCO;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker PJIFDMFFIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly HHGECPNCMCC MHCLKHJGDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] KKOFCLEGFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] NPJNACOABFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BGIECAEOIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int OKECIBGCMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int FLAODJBIFMN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string HJLBILHBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OCMHEPHCGKM.PEEJHGBGHPH FONLGBLHJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8165D80", Offset = "0x8164D80", VA = "0x188165D80")]
	public AECGGLEDNEF(HHGECPNCMCC.DIKEJBDEIHD MCANOBJNBHN, int MLMBPDHGNMF, int KCDNELCMCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8165BF0", Offset = "0x8164BF0", VA = "0x188165BF0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] HHGECPNCMCC MHCLKHJGDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8165BD0", Offset = "0x8164BD0", VA = "0x188165BD0")]
	public void OKNPAGHKNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x81652A0", Offset = "0x81642A0", VA = "0x1881652A0")]
	public void HOCIPEFJLID(Span<ELCAHCODHJN> ECCJCLAJNMI, ABENFKLFMAP FKICOCCFCKJ, [In] LPGFKGIHKIC ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x81632A0", Offset = "0x81622A0", VA = "0x1881632A0")]
	private void OOGEHBENNCO([In] OKMPJANEMMH KIEOIOJLKMI, [In] ELCAHCODHJN AKFFKGNNAHF, int PEFNJJEHNEI, [In] float OFNMICOKIBF, [In] float MFLKGKLELDJ, ABENFKLFMAP FKICOCCFCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8165A80", Offset = "0x8164A80", VA = "0x188165A80")]
	private void KIPIOJFNCEK([In] OKMPJANEMMH KIEOIOJLKMI, ELCAHCODHJN AKFFKGNNAHF, [In] int CGLPCJIGOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8165090", Offset = "0x8164090", VA = "0x188165090")]
	public static void CCHOAPODIPI(ReadOnlySpan<ELCAHCODHJN> ECCJCLAJNMI, int FHLGMJJPMNL, [Out] int BEPLJLOEDIC, [Out] int FOLPNHJPIMA, [Out] int IDLKKBMMEHA)
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
