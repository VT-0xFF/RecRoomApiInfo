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
public class AJLMOAGFEFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D FGANABPJPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig FHLPFMMKNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public CAEMBDLKGPP[] KLIONEJMPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public CAEMBDLKGPP CGDHDGAGOJK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static AJLMOAGFEFM OPEEGEIAPFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AJLMOAGFEFM KMECMBHBDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80AFBB0", Offset = "0x80AE9B0", VA = "0x1880AFBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public AJLMOAGFEFM()
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
		[Cpp2IlInjected.Address(RVA = "0x80B26A0", Offset = "0x80B14A0", VA = "0x1880B26A0")]
		public GlyphUVConfig(int JLFGILEICAK, int LIMLJIHKEJG, int CCAKLNCFKBM, int EEGMCIMINMA, float LKCBAOMDMKA = 0f, [Optional] GlyphPixelInset EAJCCCNEHFA)
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
public readonly struct CAEMBDLKGPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char CLHKKGFIHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int IEMGHCCBOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int MEGFCFKJINL;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly CAEMBDLKGPP HFCLOAEDGGD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80AFF20", Offset = "0x80AED20", VA = "0x1880AFF20")]
	public CAEMBDLKGPP(char DLGLELGMDCE, int NNPPFNKJHNJ, int IPDIBLCELEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80AFF00", Offset = "0x80AED00", VA = "0x1880AFF00")]
	public CAEMBDLKGPP(GlyphCoordinateWritable NEKPGKEOIPH)
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
		[Cpp2IlInjected.Address(RVA = "0x80B1CB0", Offset = "0x80B0AB0", VA = "0x1880B1CB0")]
		public static CAEMBDLKGPP JGGBAIGHKJA(GlyphCoordinateWritable BEIDDJJHBIM)
		{
			return default(CAEMBDLKGPP);
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
		private AJLMOAGFEFM configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x80B25A0", Offset = "0x80B13A0", VA = "0x1880B25A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x80B2420", Offset = "0x80B1220", VA = "0x1880B2420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x80B2410", Offset = "0x80B1210", VA = "0x1880B2410")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AJLMOAGFEFM ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E00", Offset = "0x80B0C00", VA = "0x1880B1E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CAEMBDLKGPP FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x80B2280", Offset = "0x80B1080", VA = "0x1880B2280")]
			get
			{
				return default(CAEMBDLKGPP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80B1CD0", Offset = "0x80B0AD0", VA = "0x1880B1CD0")]
		internal void IAGFIIINOLO(IEnumerable<GlyphCoordinateWritable> EGNFFBKNFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80B1D70", Offset = "0x80B0B70", VA = "0x1880B1D70")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80B1D50", Offset = "0x80B0B50", VA = "0x1880B1D50")]
		[CompilerGenerated]
		private bool JHJGDPKPJIA(GlyphCoordinateWritable BEIDDJJHBIM)
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
		private TextSegmentMeshBufferSource NNGPGDCKLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private GLKBFFAALKJ MGPBPEAFEHP;

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
		private FKLNFCDFJDE OLFBMHMGMCG;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80B3EC0", Offset = "0x80B2CC0", VA = "0x1880B3EC0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80B3E70", Offset = "0x80B2C70", VA = "0x1880B3E70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80B3C90", Offset = "0x80B2A90", VA = "0x1880B3C90")]
		private void KMEJLIMKOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80B3FB0", Offset = "0x80B2DB0", VA = "0x1880B3FB0")]
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
		private bool PECFPIDMBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material JHHKPFLKKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private GLKBFFAALKJ MGPBPEAFEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material CJAPPJLCICK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private AJLMOAGFEFM PMAJMDJADNK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x80B4510", Offset = "0x80B3310", VA = "0x1880B4510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GLKBFFAALKJ PNEEDHKJNOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x80B4AB0", Offset = "0x80B38B0", VA = "0x1880B4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material HJPLLJLKNMP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x80B4AE0", Offset = "0x80B38E0", VA = "0x1880B4AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80B4A10", Offset = "0x80B3810", VA = "0x1880B4A10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80B4330", Offset = "0x80B3130", VA = "0x1880B4330", Slot = "8")]
		protected override void KFDPBMLFCEM(KIHOMMLGKNM BMCOLGLONCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80B4A20", Offset = "0x80B3820", VA = "0x1880B4A20", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] DLJKCCLLCJL BGKGJGFEGIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80B45A0", Offset = "0x80B33A0", VA = "0x1880B45A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80B46F0", Offset = "0x80B34F0", VA = "0x1880B46F0")]
		private void PODNGBFHKNP(bool ADJOPEHJOFG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA75160", Offset = "0xA73F60", VA = "0x180A75160")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct IONAKJPGJEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly GLKBFFAALKJ JNCLDAJADEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int JPDENMDIGFL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80B28D0", Offset = "0x80B16D0", VA = "0x1880B28D0")]
	internal NOHJOLDMIFM DIFEIDPNBFJ()
	{
		return default(NOHJOLDMIFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29B0B60", Offset = "0x29AF960", VA = "0x1829B0B60")]
	internal IONAKJPGJEH(GLKBFFAALKJ HEJIJKOGOJP, int GJAOOHPLMLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JOBPFBPJLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80B2930", Offset = "0x80B1730", VA = "0x1880B2930")]
	public static bool BMFOMMHABMJ(this IONAKJPGJEH EKAIIOHNAOG, HFJKMODIDFN GHPMONDJILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80B2910", Offset = "0x80B1710", VA = "0x1880B2910")]
	internal static bool BMFOMMHABMJ(this NOHJOLDMIFM BLJOCGJONAD, HFJKMODIDFN GHPMONDJILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80B2980", Offset = "0x80B1780", VA = "0x1880B2980")]
	public static float JCODHNNJMLB(this IONAKJPGJEH EKAIIOHNAOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAB30B0", Offset = "0xAB1EB0", VA = "0x180AB30B0")]
	internal static float JCODHNNJMLB(this NOHJOLDMIFM BLJOCGJONAD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PBKDEDNCPBD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80B2B40", Offset = "0x80B1940", VA = "0x1880B2B40")]
	public static void OCBFCOGMFAD(this IONAKJPGJEH EKAIIOHNAOG, ReadOnlySpan<char> CDLBJHOMOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80B2B90", Offset = "0x80B1990", VA = "0x1880B2B90")]
	internal static void OCBFCOGMFAD(this NOHJOLDMIFM BLJOCGJONAD, ReadOnlySpan<char> CDLBJHOMOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80B2AF0", Offset = "0x80B18F0", VA = "0x1880B2AF0")]
	public static void NJPNLAKPBLE(this IONAKJPGJEH FHFGNMEIAIB, float2 DABCIEIGEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80B2AE0", Offset = "0x80B18E0", VA = "0x1880B2AE0")]
	internal static void NJPNLAKPBLE(this NOHJOLDMIFM BLJOCGJONAD, float2 DABCIEIGEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80B2A60", Offset = "0x80B1860", VA = "0x1880B2A60")]
	public static void EKLMOOOMCLN(this IONAKJPGJEH FHFGNMEIAIB, float GLJKDHFIGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80B2A20", Offset = "0x80B1820", VA = "0x1880B2A20")]
	internal static void EKLMOOOMCLN(this NOHJOLDMIFM BLJOCGJONAD, float GLJKDHFIGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80B2AD0", Offset = "0x80B18D0", VA = "0x1880B2AD0")]
	internal static void FOAFBKNBBAG(this NOHJOLDMIFM BLJOCGJONAD, bool INONAFLHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80B29E0", Offset = "0x80B17E0", VA = "0x1880B29E0")]
	public static void CHBNBLJKGLE(this IONAKJPGJEH FHFGNMEIAIB, Color32 PFKMCINIKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80B29D0", Offset = "0x80B17D0", VA = "0x1880B29D0")]
	internal static void CHBNBLJKGLE(this NOHJOLDMIFM BLJOCGJONAD, Color32 PFKMCINIKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80B2DA0", Offset = "0x80B1BA0", VA = "0x1880B2DA0")]
	public static void OHHACDOBDLB(this IONAKJPGJEH FHFGNMEIAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80B2D90", Offset = "0x80B1B90", VA = "0x1880B2D90")]
	internal static void OHHACDOBDLB(this NOHJOLDMIFM BLJOCGJONAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80B2DE0", Offset = "0x80B1BE0", VA = "0x1880B2DE0")]
	internal static void PFFDMPNMOIO(this NOHJOLDMIFM BLJOCGJONAD, int NBNAAAGDBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80B2E50", Offset = "0x80B1C50", VA = "0x1880B2E50")]
	internal static void PNFEPCMPDCP(this NOHJOLDMIFM BLJOCGJONAD, int ELJIKLELDEC, HFJKMODIDFN MMKDFFDBCNE = HFJKMODIDFN.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FKLNFCDFJDE : IEquatable<FKLNFCDFJDE>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort PEAACNGDBPP = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int KNNBFOELAEA = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly FKLNFCDFJDE AOBDAFOCAKK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort EGOFHBKBMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xD42AF0", Offset = "0xD418F0", VA = "0x180D42AF0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD42B00", Offset = "0xD41900", VA = "0x180D42B00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GLKBFFAALKJ JNCLDAJADEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IHBLCGMONJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80AC900", Offset = "0x80AB700", VA = "0x1880AC900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80AC9F0", Offset = "0x80AB7F0", VA = "0x1880AC9F0")]
	public FKLNFCDFJDE(int AIFGHGOPOEJ, GLKBFFAALKJ HEJIJKOGOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80B0180", Offset = "0x80AEF80", VA = "0x1880B0180")]
	public bool CEOIEHBAFHC([Out] IONAKJPGJEH EKAIIOHNAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80B0380", Offset = "0x80AF180", VA = "0x1880B0380")]
	public void NIADOCPAAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80AC860", Offset = "0x80AB660", VA = "0x1880AC860")]
	internal void FBCDLBAIKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80AC800", Offset = "0x80AB600", VA = "0x1880AC800", Slot = "4")]
	public bool Equals(FKLNFCDFJDE LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80B0250", Offset = "0x80AF050", VA = "0x1880B0250", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80B0310", Offset = "0x80AF110", VA = "0x1880B0310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GLKBFFAALKJ : IDisposable, DKFPGHEIIOM
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string MELAPBIFJEI = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker OLFBICKIEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string BJLKJAIHIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly IENAADADKOO ADDIDOJALPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int ABGOAKBJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal NOHJOLDMIFM[] NCJBAAENLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FKLNFCDFJDE[] OECEEFCDMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private AJLMOAGFEFM MEIMIFGELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AGKNLLFIAFL KKDHNIMGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly POFHBMBEKFD PBLEFDCDANN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GGDFKFACHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80B0510", Offset = "0x80AF310", VA = "0x1880B0510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AJLMOAGFEFM IJPKJOKNFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80B0D70", Offset = "0x80AFB70", VA = "0x1880B0D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float HJEPCGOPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80B1530", Offset = "0x80B0330", VA = "0x1880B1530")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CFDPEHECEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80B0D90", Offset = "0x80AFB90", VA = "0x1880B0D90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DKFPGHEIIOM.CHDFBIKOCJD IMJMBPJJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA5F320", Offset = "0xA5E120", VA = "0x180A5F320", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA5F340", Offset = "0xA5E140", VA = "0x180A5F340", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80B1870", Offset = "0x80B0670", VA = "0x1880B1870")]
	public GLKBFFAALKJ(IENAADADKOO FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80B17F0", Offset = "0x80B05F0", VA = "0x1880B17F0")]
	public GLKBFFAALKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80B14F0", Offset = "0x80B02F0", VA = "0x1880B14F0")]
	public void ONJHMMKMDOB(GlyphMapAsset KJGEJDAPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80B13E0", Offset = "0x80B01E0", VA = "0x1880B13E0")]
	public void ONJHMMKMDOB(AJLMOAGFEFM GCJFGPIMCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80B1550", Offset = "0x80B0350", VA = "0x1880B1550", Slot = "6")]
	public bool TryGetMeshBuffer([Out] DLJKCCLLCJL BGKGJGFEGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80B0DB0", Offset = "0x80AFBB0", VA = "0x1880B0DB0")]
	public void JFBFDCAAKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80B0E10", Offset = "0x80AFC10", VA = "0x1880B0E10")]
	public bool JKENADKHDEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80B0E60", Offset = "0x80AFC60", VA = "0x1880B0E60")]
	public FKLNFCDFJDE LAEGMGNMLGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80B0650", Offset = "0x80AF450", VA = "0x1880B0650")]
	public void EJKMBHPHKDH(FKLNFCDFJDE GCKGCIJAMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80B0460", Offset = "0x80AF260", VA = "0x1880B0460")]
	internal bool ALLFKKEMOGH(FKLNFCDFJDE GCKGCIJAMAP, [Out] IONAKJPGJEH EKAIIOHNAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x80B0BF0", Offset = "0x80AF9F0", VA = "0x1880B0BF0")]
	private void IJMDONCDEGN(NOHJOLDMIFM BLJOCGJONAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80B0A10", Offset = "0x80AF810", VA = "0x1880B0A10")]
	private void HMIDFBFIIIL(int BCKHEOGAPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80B09B0", Offset = "0x80AF7B0", VA = "0x1880B09B0")]
	private bool GGIHNNKNLAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80ABA20", Offset = "0x80AA820", VA = "0x1880ABA20")]
	private static int CKCEOJAAGKL(FKLNFCDFJDE GCKGCIJAMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x232E290", Offset = "0x232D090", VA = "0x18232E290")]
	private static ushort ONNALCOGLCF(int CKFKPOAGPKN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80B10D0", Offset = "0x80AFED0", VA = "0x1880B10D0")]
	private Bounds LBONPJOOGOI()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80B05A0", Offset = "0x80AF3A0", VA = "0x1880B05A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IENAADADKOO
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IENAADADKOO FIPMALIAMDN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float DHEMBLDCBGK = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int MLGLIGJAEGP = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int OAOGONLFEDD = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color GGLKNIFHIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float NCLGFLMIBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int ALPMCOIEHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int IJHCABOKCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int ONFGFDELBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int ABFEDIHPJAH;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80B26D0", Offset = "0x80B14D0", VA = "0x1880B26D0")]
	internal IENAADADKOO BDMOBADBABB()
	{
		return default(IENAADADKOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80AD010", Offset = "0x80ABE10", VA = "0x1880AD010")]
	[CompilerGenerated]
	internal static void NJGEEICCJKN(int BNECONOIKOE, int JILABBLHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80B27E0", Offset = "0x80B15E0", VA = "0x1880B27E0")]
	[CompilerGenerated]
	internal static void DHHMFIJGIMD(float BNECONOIKOE, float JILABBLHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80AD020", Offset = "0x80ABE20", VA = "0x1880AD020")]
	[CompilerGenerated]
	internal static void HNMPGBMBOKF(int BNECONOIKOE, int HNNOFIMAJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80B2800", Offset = "0x80B1600", VA = "0x1880B2800")]
	[CompilerGenerated]
	internal static void PJOPCGJKGPB(float BNECONOIKOE, float HNNOFIMAJGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BIKHHCBKDIO
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80AFE20", Offset = "0x80AEC20", VA = "0x1880AFE20")]
	public static float CMAFPKCCFJF(this IONAKJPGJEH JEMFAINBGFC)
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
		public readonly FKLNFCDFJDE textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x80B42C0", Offset = "0x80B30C0", VA = "0x1880B42C0")]
		public TextSegmentLayout(LayoutRect layoutRect, FKLNFCDFJDE textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x80B4090", Offset = "0x80B2E90", VA = "0x1880B4090")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x80B4100", Offset = "0x80B2F00", VA = "0x1880B4100")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80B4030", Offset = "0x80B2E30", VA = "0x1880B4030")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class AGKNLLFIAFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig BDFHKOBDLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float EHDILNLAIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float HOGBCKGHJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float MBLNLNLGPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float KINPBEOEMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float MHAIHAPPKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float ADEEKHFOGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float DHGCNIIGMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float IMCGIIGNIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float LKIJMFNPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float CFDPEHECEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float CODHFHLKDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float HJEPCGOPLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly BECFMGJJEJO[] HEMBAMCIEPB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int PGEFPCEECGG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private PMPACJNAPEP[] OFBONFMKFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int HIAAAKNPINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private CAEMBDLKGPP[] EMIKAHGPAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int CPLGNMPHDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public BECFMGJJEJO DCKCLNECFKD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80AFA80", Offset = "0x80AE880", VA = "0x1880AFA80")]
	public void ONJHMMKMDOB(AJLMOAGFEFM JDMFNCECMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80AFA00", Offset = "0x80AE800", VA = "0x1880AFA00")]
	public void ONJHMMKMDOB(GlyphUVConfig GJFBGLLEPOL, IEnumerable<CAEMBDLKGPP> KJGEJDAPPDP, CAEMBDLKGPP JJAMINIMNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80AF8C0", Offset = "0x80AE6C0", VA = "0x1880AF8C0")]
	internal void NOJANHAOFDP(GlyphUVConfig GJFBGLLEPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x80AF380", Offset = "0x80AE180", VA = "0x1880AF380")]
	private void DCPEBMPMOAP(IEnumerable<CAEMBDLKGPP> KJGEJDAPPDP, CAEMBDLKGPP JJAMINIMNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x80AF050", Offset = "0x80ADE50", VA = "0x1880AF050")]
	public void ANGFGDKBFHD([In] char DLGLELGMDCE, [Out] float2[] BGJDOIIMGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x80AD410", Offset = "0x80AC210", VA = "0x1880AD410")]
	private BECFMGJJEJO KGECCFLCMEJ(CAEMBDLKGPP NEKPGKEOIPH)
	{
		return default(BECFMGJJEJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x80AFB10", Offset = "0x80AE910", VA = "0x1880AFB10")]
	public AGKNLLFIAFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ELKLNENGLIC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80B0050", Offset = "0x80AEE50", VA = "0x1880B0050")]
	public static void BHLFANNDNIJ([In] float CBDLEGPIINI, [In] float OGOGIEDBCLF, [In] int NHMFHJKLCDN, [In] int GHBPEBCNKBP, [In] float KINPBEOEMGO, [In] float MHAIHAPPKGA, [In] float IFJLHMAOPDO, [In] float ICKECAOHHKM, [In] float BAJHOGGDHLO, [In] float FCNGCCIPOFF, [Out] float MINNPBHEIAI, [Out] float ADIGMJBNJPG, [Out] float GCNHFGKOGJD, [Out] float LCAEODEMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x80AFFF0", Offset = "0x80AEDF0", VA = "0x1880AFFF0")]
	public static void BHLFANNDNIJ([In] float CBDLEGPIINI, [In] float OGOGIEDBCLF, [In] int NHMFHJKLCDN, [In] int GHBPEBCNKBP, [Out] float MINNPBHEIAI, [Out] float ADIGMJBNJPG, [Out] float GCNHFGKOGJD, [Out] float LCAEODEMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x80B0120", Offset = "0x80AEF20", VA = "0x1880B0120")]
	public static void OODFLEILLKI([In] float KINPBEOEMGO, [In] float MHAIHAPPKGA, [In] float GPIKHBDMBGN, [In] float MDIKBPOPODF, [In] float BMHFKGHOOLH, [In] float AIIELJOHJAP, [Out] float PGAFKPCCGIF, [Out] float PEPFMOBCAKD, [Out] float IOIGJDFPEAB, [Out] float DFIEGJANKLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct PMPACJNAPEP
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint DFDOJKBBCBE = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char CLHKKGFIHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly BECFMGJJEJO KIJDEGALKHG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x80B2E70", Offset = "0x80B1C70", VA = "0x1880B2E70")]
	public PMPACJNAPEP(char DLGLELGMDCE, BECFMGJJEJO BGJDOIIMGDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BECFMGJJEJO
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint DFDOJKBBCBE = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] HCNCDBOMFDB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x80AFD30", Offset = "0x80AEB30", VA = "0x1880AFD30")]
	public BECFMGJJEJO(float MINNPBHEIAI, float ADIGMJBNJPG, float GCNHFGKOGJD, float LCAEODEMOLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct NOHJOLDMIFM
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int HBDGMJIOHDI = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal HFJKMODIDFN MMKDFFDBCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] HLIAJANIEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int LEBLDOEKPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 DABCIEIGEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float MKFFDNKPICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 MHHHNCDJCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool INONAFLHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int MLEDHGMKBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int CDPBPPKEPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int INDEECNLDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int DHGOBKGCAON;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x80B29C0", Offset = "0x80B17C0", VA = "0x1880B29C0")]
	public static int FIMKMHIDHGF(int JFJKKAHLOLO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum HFJKMODIDFN : byte
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
public static class EIPBKNCIPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x80AFFB0", Offset = "0x80AEDB0", VA = "0x1880AFFB0")]
	internal static float CMAFPKCCFJF(this NOHJOLDMIFM BLJOCGJONAD, float PHMMLPFDKPF, float FMPBHJCKCAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80AFF30", Offset = "0x80AED30", VA = "0x1880AFF30")]
	internal static void CHHEKDFKNOC(this NOHJOLDMIFM BLJOCGJONAD, float PHMMLPFDKPF, float FMPBHJCKCAK, [Out] float2 IIEOAHPEFEA, [Out] float2 PFNOCLOHBOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class POFHBMBEKFD : DKFPGHEIIOM
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int DADGIBPBDIK = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int AIPGPJNMCFC = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string MELAPBIFJEI = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker AADLBKFOHFK;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker FBJDLJGMKFP;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker IAPKPPBENAL;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker ECJKILEBOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly DLJKCCLLCJL BGKGJGFEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] IPIHIHHGGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] MKBKLMDACCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int HJANCEAAOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HBGIIECBEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int KGFIJFPOLCD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GGDFKFACHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DKFPGHEIIOM.CHDFBIKOCJD IMJMBPJJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x80B3B80", Offset = "0x80B2980", VA = "0x1880B3B80")]
	public POFHBMBEKFD(DLJKCCLLCJL.EPEKJHHFBCD JAFDCCBGGLD, int DKHGNNMPCFF, int BJHCEGGCIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x80B39F0", Offset = "0x80B27F0", VA = "0x1880B39F0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] DLJKCCLLCJL BGKGJGFEGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x80B39D0", Offset = "0x80B27D0", VA = "0x1880B39D0")]
	public void OBBPFDMLFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x80B2FE0", Offset = "0x80B1DE0", VA = "0x1880B2FE0")]
	public void IALKDODJIJJ(Span<NOHJOLDMIFM> NEONJDGDDJL, AGKNLLFIAFL OPJGGGLPEEH, [In] IENAADADKOO FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80AD7F0", Offset = "0x80AC5F0", VA = "0x1880AD7F0")]
	private void EMENIBPCDAM([In] HFJKMODIDFN MMKDFFDBCNE, [In] NOHJOLDMIFM JGAILAFFJND, int DNFICLGODDD, [In] float PHMMLPFDKPF, [In] float FMPBHJCKCAK, AGKNLLFIAFL OPJGGGLPEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x80B2E90", Offset = "0x80B1C90", VA = "0x1880B2E90")]
	private void AILCFPIHKOM([In] HFJKMODIDFN MMKDFFDBCNE, NOHJOLDMIFM JGAILAFFJND, [In] int BFHOPGIKDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80B37C0", Offset = "0x80B25C0", VA = "0x1880B37C0")]
	public static void KKAJHMGMALD(ReadOnlySpan<NOHJOLDMIFM> NEONJDGDDJL, int CHCPOOFDIHM, [Out] int MKAMOFKECDA, [Out] int BDLAHNNCJOF, [Out] int MGLIIAIGBMI)
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
