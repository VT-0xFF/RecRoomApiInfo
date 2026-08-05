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
public class FEPAICIBGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D NCDADGMKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig ONFFONDCLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MGDNKHHEGAK[] OGDNOKLEBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public MGDNKHHEGAK HHGDGNADCDL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FEPAICIBGPL AMHEPFLLBGL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FEPAICIBGPL KMAIBPMLHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF700", Offset = "0x6FEEB00", VA = "0x186FEF700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FEPAICIBGPL()
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
		[Cpp2IlInjected.Address(RVA = "0x6FF0320", Offset = "0x6FEF720", VA = "0x186FF0320")]
		public GlyphUVConfig(int FLGHLNHNJII, int GAPKOMAIMCG, int MJCKPJEOLGF, int BOFAIKPBBBG, float AACOCLBHKCO = 0f, [Optional] GlyphPixelInset HPOCPNMPFEO)
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
public readonly struct MGDNKHHEGAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char DKBMLIEJOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int FODODIPDJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int JFGNKFPDPIE;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly MGDNKHHEGAK JMFONJMCLCO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FF16C0", Offset = "0x6FF0AC0", VA = "0x186FF16C0")]
	public MGDNKHHEGAK(char CNBHDFHDELH, int MFGMCOOPGKK, int PMBLLJFPNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FF16D0", Offset = "0x6FF0AD0", VA = "0x186FF16D0")]
	public MGDNKHHEGAK(GlyphCoordinateWritable NNBGHNHCKOD)
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
		[Cpp2IlInjected.Address(RVA = "0x6FEF940", Offset = "0x6FEED40", VA = "0x186FEF940")]
		public static MGDNKHHEGAK IDKOEJANABA(GlyphCoordinateWritable DGDCPDOCKCI)
		{
			return default(MGDNKHHEGAK);
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
		private FEPAICIBGPL configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0220", Offset = "0x6FEF620", VA = "0x186FF0220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF00A0", Offset = "0x6FEF4A0", VA = "0x186FF00A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0090", Offset = "0x6FEF490", VA = "0x186FF0090")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FEPAICIBGPL ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFA90", Offset = "0x6FEEE90", VA = "0x186FEFA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MGDNKHHEGAK FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6FEFF00", Offset = "0x6FEF300", VA = "0x186FEFF00")]
			get
			{
				return default(MGDNKHHEGAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF960", Offset = "0x6FEED60", VA = "0x186FEF960")]
		internal void BECLJECDHCH(IEnumerable<GlyphCoordinateWritable> DKJFOABCIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFA00", Offset = "0x6FEEE00", VA = "0x186FEFA00")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF9E0", Offset = "0x6FEEDE0", VA = "0x186FEF9E0")]
		[CompilerGenerated]
		private bool LJHOKBIJIOO(GlyphCoordinateWritable DGDCPDOCKCI)
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
		private TextSegmentMeshBufferSource OCIPDKOHPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private OKFEGJJDBED CJKNIAACBBJ;

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
		private KILAMJECCMN KACMALMEAFI;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FF31C0", Offset = "0x6FF25C0", VA = "0x186FF31C0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3170", Offset = "0x6FF2570", VA = "0x186FF3170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2FB0", Offset = "0x6FF23B0", VA = "0x186FF2FB0")]
		private void EHKCIPOACEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FF32B0", Offset = "0x6FF26B0", VA = "0x186FF32B0")]
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
		private bool FPBFPIKINAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material JDACIIEKLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private OKFEGJJDBED CJKNIAACBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material DKLEMAGFINP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private FEPAICIBGPL CCLOFCJFJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3630", Offset = "0x6FF2A30", VA = "0x186FF3630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OKFEGJJDBED FBMINNAJONG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3DA0", Offset = "0x6FF31A0", VA = "0x186FF3DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material LLOOKFADFND
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3DD0", Offset = "0x6FF31D0", VA = "0x186FF3DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3D00", Offset = "0x6FF3100", VA = "0x186FF3D00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF39E0", Offset = "0x6FF2DE0", VA = "0x186FF39E0", Slot = "8")]
		protected override void NKOCJOKGFPM(AJAMNDKPMCF CICDGHAMIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3D10", Offset = "0x6FF3110", VA = "0x186FF3D10", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] AOFHFNCIAGP MPPCBAMKGJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3BB0", Offset = "0x6FF2FB0", VA = "0x186FF3BB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FF36C0", Offset = "0x6FF2AC0", VA = "0x186FF36C0")]
		private void KKEDBADFPOM(bool MKNFMGNFODH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E3600", Offset = "0x8E2A00", VA = "0x1808E3600")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct EFIMIBFLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly OKFEGJJDBED HMHHGOALJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int FGIHNLIIMGD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF6C0", Offset = "0x6FEEAC0", VA = "0x186FEF6C0")]
	internal GFPKBMFCHPH BDNDMEDLAAG()
	{
		return default(GFPKBMFCHPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x231A600", Offset = "0x2319A00", VA = "0x18231A600")]
	internal EFIMIBFLNDM(OKFEGJJDBED KCLPDCIIPCH, int FEGFJOLIEGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NPMAALMJOGN
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6FF16F0", Offset = "0x6FF0AF0", VA = "0x186FF16F0")]
	public static bool IJHOLOPLIDP(this EFIMIBFLNDM NCLKGNGIHDJ, MPOEBJOAGEI LBHBMHAEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1740", Offset = "0x6FF0B40", VA = "0x186FF1740")]
	internal static bool IJHOLOPLIDP(this GFPKBMFCHPH MPPCMNFFKJN, MPOEBJOAGEI LBHBMHAEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1760", Offset = "0x6FF0B60", VA = "0x186FF1760")]
	public static float MJABAGBIKEK(this EFIMIBFLNDM NCLKGNGIHDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x97B440", Offset = "0x97A840", VA = "0x18097B440")]
	internal static float MJABAGBIKEK(this GFPKBMFCHPH MPPCMNFFKJN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AHDCGMPFLDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC780", Offset = "0x6FEBB80", VA = "0x186FEC780")]
	public static void JCJFBNANFGF(this EFIMIBFLNDM NCLKGNGIHDJ, ReadOnlySpan<char> CBLEOHLEJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE970", Offset = "0x6FEDD70", VA = "0x186FEE970")]
	internal static void JCJFBNANFGF(this GFPKBMFCHPH MPPCMNFFKJN, ReadOnlySpan<char> CBLEOHLEJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE860", Offset = "0x6FEDC60", VA = "0x186FEE860")]
	public static void BBPPFNEICCA(this EFIMIBFLNDM LBPNCLPDJOB, float2 ALFDBMDKFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE8B0", Offset = "0x6FEDCB0", VA = "0x186FEE8B0")]
	internal static void BBPPFNEICCA(this GFPKBMFCHPH MPPCMNFFKJN, float2 ALFDBMDKFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE930", Offset = "0x6FEDD30", VA = "0x186FEE930")]
	public static void ENCJBDEJFOH(this EFIMIBFLNDM LBPNCLPDJOB, float CKKLDLEONBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE920", Offset = "0x6FEDD20", VA = "0x186FEE920")]
	internal static void ENCJBDEJFOH(this GFPKBMFCHPH MPPCMNFFKJN, float CKKLDLEONBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE910", Offset = "0x6FEDD10", VA = "0x186FEE910")]
	internal static void DOHAGBOGHBD(this GFPKBMFCHPH MPPCMNFFKJN, bool JJFCBJBCBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE8D0", Offset = "0x6FEDCD0", VA = "0x186FEE8D0")]
	public static void CANPFNGNKKF(this EFIMIBFLNDM LBPNCLPDJOB, Color32 IGJDLCJEHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE8C0", Offset = "0x6FEDCC0", VA = "0x186FEE8C0")]
	internal static void CANPFNGNKKF(this GFPKBMFCHPH MPPCMNFFKJN, Color32 IGJDLCJEHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE820", Offset = "0x6FEDC20", VA = "0x186FEE820")]
	public static void AKGOIGGHEDK(this EFIMIBFLNDM LBPNCLPDJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE810", Offset = "0x6FEDC10", VA = "0x186FEE810")]
	internal static void AKGOIGGHEDK(this GFPKBMFCHPH MPPCMNFFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEAC0", Offset = "0x6FEDEC0", VA = "0x186FEEAC0")]
	internal static void NDDPNFMDDAB(this GFPKBMFCHPH MPPCMNFFKJN, int GLCPACCBKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEB30", Offset = "0x6FEDF30", VA = "0x186FEEB30")]
	internal static void NLLLNCMCEEG(this GFPKBMFCHPH MPPCMNFFKJN, int JKLGMFBNGIF, MPOEBJOAGEI FLKMPEFJLCF = MPOEBJOAGEI.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KILAMJECCMN : IEquatable<KILAMJECCMN>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort ACPKOJGGEHO = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int NCBCJLHBOIG = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly KILAMJECCMN ELCBOALPPGE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort LJEGDABOLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x216CAB0", Offset = "0x216BEB0", VA = "0x18216CAB0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x216CAC0", Offset = "0x216BEC0", VA = "0x18216CAC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OKFEGJJDBED HMHHGOALJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BDPCGJLEFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBEF0", Offset = "0x6FEB2F0", VA = "0x186FEBEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC080", Offset = "0x6FEB480", VA = "0x186FEC080")]
	public KILAMJECCMN(int CFEEFAMCMOD, OKFEGJJDBED KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0680", Offset = "0x6FEFA80", VA = "0x186FF0680")]
	public bool JNFDFHNGKAH([Out] EFIMIBFLNDM NCLKGNGIHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0750", Offset = "0x6FEFB50", VA = "0x186FF0750")]
	public void OLENLPMJDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBFC0", Offset = "0x6FEB3C0", VA = "0x186FEBFC0")]
	internal void PPLDGHEBHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBE20", Offset = "0x6FEB220", VA = "0x186FEBE20", Slot = "4")]
	public bool Equals(KILAMJECCMN BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0550", Offset = "0x6FEF950", VA = "0x186FF0550", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0610", Offset = "0x6FEFA10", VA = "0x186FF0610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class OKFEGJJDBED : IDisposable, ILMNFFLLLCP
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string NDHNKHKHMDD = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker KKAOHGEOEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string MPPFDEMFAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly HPOEOAFHJEF NGMCCIGDJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int DJKKBGKIDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal GFPKBMFCHPH[] KMKCJLDGHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal KILAMJECCMN[] HEGCOIOPGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private FEPAICIBGPL PLPLDBAKODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CBCKNHLGGPC NNLOGNOJCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly KLCDPFOIMHN NDIDPNLGPCG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string LJAGHAHCFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1A20", Offset = "0x6FF0E20", VA = "0x186FF1A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FEPAICIBGPL HJMKHFGJHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FF21D0", Offset = "0x6FF15D0", VA = "0x186FF21D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float FLELOGKEPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AD0", Offset = "0x6FF0ED0", VA = "0x186FF1AD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float EKNMGAPOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AB0", Offset = "0x6FF0EB0", VA = "0x186FF1AB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ILMNFFLLLCP.NPPOAOINBFF AOAIOOGLGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF00", Offset = "0x8CA300", VA = "0x1808CAF00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF40", Offset = "0x8CA340", VA = "0x1808CAF40", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2B80", Offset = "0x6FF1F80", VA = "0x186FF2B80")]
	public OKFEGJJDBED(HPOEOAFHJEF JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2B00", Offset = "0x6FF1F00", VA = "0x186FF2B00")]
	public OKFEGJJDBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2130", Offset = "0x6FF1530", VA = "0x186FF2130")]
	public void LKOIGPCFEMK(GlyphMapAsset OCFKDDMEBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2020", Offset = "0x6FF1420", VA = "0x186FF2020")]
	public void LKOIGPCFEMK(FEPAICIBGPL MFHLPNFABOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2830", Offset = "0x6FF1C30", VA = "0x186FF2830", Slot = "6")]
	public bool TryGetMeshBuffer([Out] AOFHFNCIAGP MPPCBAMKGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2170", Offset = "0x6FF1570", VA = "0x186FF2170")]
	public void MJIDLJPPHLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6FF17A0", Offset = "0x6FF0BA0", VA = "0x186FF17A0")]
	public bool AFDHLDGJCOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6FF17F0", Offset = "0x6FF0BF0", VA = "0x186FF17F0")]
	public KILAMJECCMN BJILJGLHPFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1C50", Offset = "0x6FF1050", VA = "0x186FF1C50")]
	public void JEFGAKDAKCG(KILAMJECCMN PLDJNHLJBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1BA0", Offset = "0x6FF0FA0", VA = "0x186FF1BA0")]
	internal bool HGBCMCOGFOP(KILAMJECCMN PLDJNHLJBHI, [Out] EFIMIBFLNDM NCLKGNGIHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6FF26E0", Offset = "0x6FF1AE0", VA = "0x186FF26E0")]
	private void ONDMOFNKAFE(GFPKBMFCHPH MPPCMNFFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6FF21F0", Offset = "0x6FF15F0", VA = "0x186FF21F0")]
	private void NEBHAOPACKD(int AIJDEJHCNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1FC0", Offset = "0x6FF13C0", VA = "0x186FF1FC0")]
	private bool JMDCCHINNLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6FE79B0", Offset = "0x6FE6DB0", VA = "0x186FE79B0")]
	private static int OBEKLNKPJII(KILAMJECCMN PLDJNHLJBHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C59000", Offset = "0x1C58400", VA = "0x181C59000")]
	private static ushort CKGLGNAPBJD(int IIACLAMOIEE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6FF23D0", Offset = "0x6FF17D0", VA = "0x186FF23D0")]
	private Bounds NLNLCNEKJJP()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1AF0", Offset = "0x6FF0EF0", VA = "0x186FF1AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HPOEOAFHJEF
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly HPOEOAFHJEF CGHIGHCDGHB;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float GMDGAFJGDFE = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int CPPPCLEAJDE = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int APEHOPAOKKN = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color INAMECKODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float MLJFCFGDIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int CKIGEDMJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int BGLKFKBDCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int GEGMNCHPEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int JBBENKLCJMN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0350", Offset = "0x6FEF750", VA = "0x186FF0350")]
	internal HPOEOAFHJEF EDNMHMPNAKH()
	{
		return default(HPOEOAFHJEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6150", Offset = "0x6FE5550", VA = "0x186FE6150")]
	[CompilerGenerated]
	internal static void DEJFGKDKCDD(int HCPAOILCJCB, int EKFBHIJFHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0460", Offset = "0x6FEF860", VA = "0x186FF0460")]
	[CompilerGenerated]
	internal static void IPDBHCOPLEM(float HCPAOILCJCB, float EKFBHIJFHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6160", Offset = "0x6FE5560", VA = "0x186FE6160")]
	[CompilerGenerated]
	internal static void PEKADGGHKOG(int HCPAOILCJCB, int MDPIACPCIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0480", Offset = "0x6FEF880", VA = "0x186FF0480")]
	[CompilerGenerated]
	internal static void MMOJPNKHEJP(float HCPAOILCJCB, float MDPIACPCIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ADONDIJNHPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE780", Offset = "0x6FEDB80", VA = "0x186FEE780")]
	public static float ODDPKDFKLPE(this EFIMIBFLNDM IMNDKKGKFFA)
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
		public readonly KILAMJECCMN textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FF35C0", Offset = "0x6FF29C0", VA = "0x186FF35C0")]
		public TextSegmentLayout(LayoutRect layoutRect, KILAMJECCMN textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3390", Offset = "0x6FF2790", VA = "0x186FF3390")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3400", Offset = "0x6FF2800", VA = "0x186FF3400")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3330", Offset = "0x6FF2730", VA = "0x186FF3330")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class CBCKNHLGGPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig DBMJHMEGNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float FAGGLABBHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float JLHGCKMKPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float FIPHECHIOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float KCCABLGBDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float GNMLHOOBJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float MAOCAMAGOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float DLFBLHNBHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float JGEEELMHJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float AODHGDIHAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float EKNMGAPOOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float IBCDAGFDGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float FLELOGKEPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LDHPJECBNNO[] KHOOEJOJOCG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int ALLAAKFGILD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private BOCGIDHOHGH[] FKNGGDDLBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int AEPFMEMLPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private MGDNKHHEGAK[] EKJELEOGLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int HILCLCFNLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public LDHPJECBNNO LJNANEPBOJB;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF3D0", Offset = "0x6FEE7D0", VA = "0x186FEF3D0")]
	public void LKOIGPCFEMK(FEPAICIBGPL PGGPCBAOEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF460", Offset = "0x6FEE860", VA = "0x186FEF460")]
	public void LKOIGPCFEMK(GlyphUVConfig PDJHEIEFKAH, IEnumerable<MGDNKHHEGAK> OCFKDDMEBHK, MGDNKHHEGAK EDLAEEDOLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF4E0", Offset = "0x6FEE8E0", VA = "0x186FEF4E0")]
	internal void PHAILLPKFBD(GlyphUVConfig PDJHEIEFKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEB70", Offset = "0x6FEDF70", VA = "0x186FEEB70")]
	private void ANMGLIPMMMJ(IEnumerable<MGDNKHHEGAK> OCFKDDMEBHK, MGDNKHHEGAK EDLAEEDOLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF0A0", Offset = "0x6FEE4A0", VA = "0x186FEF0A0")]
	public void FNPPKEFHFLF([In] char CNBHDFHDELH, [Out] float2[] POHDKHENFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6FECD80", Offset = "0x6FEC180", VA = "0x186FECD80")]
	private LDHPJECBNNO OCGGMKFAJNC(MGDNKHHEGAK NNBGHNHCKOD)
	{
		return default(LDHPJECBNNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF620", Offset = "0x6FEEA20", VA = "0x186FEF620")]
	public CBCKNHLGGPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ABPJCPAFDLG
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE6B0", Offset = "0x6FEDAB0", VA = "0x186FEE6B0")]
	public static void KFFGBLFFCCG([In] float BBLLBDJODPK, [In] float JIEFMEKEJII, [In] int HLKMDPNFPNN, [In] int MAEEBOLOKLP, [In] float KCCABLGBDMD, [In] float GNMLHOOBJOH, [In] float IFDLPCOADJB, [In] float PAEOADANPKI, [In] float OMJFLHCAJPD, [In] float EAKLPIHCLFI, [Out] float EDPBPPEBABA, [Out] float NBGOIFGFEPK, [Out] float MBLLFPLKPHN, [Out] float FFDEOLPCMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE650", Offset = "0x6FEDA50", VA = "0x186FEE650")]
	public static void KFFGBLFFCCG([In] float BBLLBDJODPK, [In] float JIEFMEKEJII, [In] int HLKMDPNFPNN, [In] int MAEEBOLOKLP, [Out] float EDPBPPEBABA, [Out] float NBGOIFGFEPK, [Out] float MBLLFPLKPHN, [Out] float FFDEOLPCMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE5F0", Offset = "0x6FED9F0", VA = "0x186FEE5F0")]
	public static void FPHMAENBKDK([In] float KCCABLGBDMD, [In] float GNMLHOOBJOH, [In] float EACLNEHGHCD, [In] float HHIPIGAMDJJ, [In] float MDHPJNPPJIM, [In] float CCNKCCKDNHL, [Out] float FBFOLJFFIBA, [Out] float AKHJBCHLEFK, [Out] float KFGHAHPPELL, [Out] float MGCKJDIIECD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct BOCGIDHOHGH
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint MJOJNBFJNIA = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char DKBMLIEJOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly LDHPJECBNNO OLKACPHMPIC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEB50", Offset = "0x6FEDF50", VA = "0x186FEEB50")]
	public BOCGIDHOHGH(char CNBHDFHDELH, LDHPJECBNNO POHDKHENFHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LDHPJECBNNO
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint MJOJNBFJNIA = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] JKOHCBDFIMP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1580", Offset = "0x6FF0980", VA = "0x186FF1580")]
	public LDHPJECBNNO(float EDPBPPEBABA, float NBGOIFGFEPK, float MBLLFPLKPHN, float FFDEOLPCMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct GFPKBMFCHPH
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int BBECFFDBDOE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal MPOEBJOAGEI FLKMPEFJLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] OBABOKPKHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int NCJMLNPNNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 ALFDBMDKFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float FHOKLJBJGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 MBHICGKGEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool JJFCBJBCBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int MGMKHOODJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int DMPMDCFKNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int KKFNHDBFOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int JFNFGGBMACI;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF930", Offset = "0x6FEED30", VA = "0x186FEF930")]
	public static int IIIDJANGNEO(int KBPNPAPMKOI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum MPOEBJOAGEI : byte
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
public static class GEGOAOKHIPE
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF8F0", Offset = "0x6FEECF0", VA = "0x186FEF8F0")]
	internal static float ODDPKDFKLPE(this GFPKBMFCHPH MPPCMNFFKJN, float EOKPGBPNPKP, float HHLKPMBHKEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF870", Offset = "0x6FEEC70", VA = "0x186FEF870")]
	internal static void LFKFPLBCKJM(this GFPKBMFCHPH MPPCMNFFKJN, float EOKPGBPNPKP, float HHLKPMBHKEM, [Out] float2 OHMCJFFPFMB, [Out] float2 CDDAELCNAGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class KLCDPFOIMHN : ILMNFFLLLCP
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int NKHMLKDDILI = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int FNJLBLKLCEB = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string NDHNKHKHMDD = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static KGJMNAKOGFH OIJDBKOLCBH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static KGJMNAKOGFH FPKMKDGOJCP;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static KGJMNAKOGFH DNDGNDJMNCM;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static KGJMNAKOGFH BOBPMCPBEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly AOFHFNCIAGP MPPCBAMKGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] IPHAALFLDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] GHJICDFOMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int DBBHCLOBMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int MENNEFIJCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int CBGMLDDADNL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string LJAGHAHCFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ILMNFFLLLCP.NPPOAOINBFF AOAIOOGLGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1470", Offset = "0x6FF0870", VA = "0x186FF1470")]
	public KLCDPFOIMHN(AOFHFNCIAGP.NDDPEKLHPAP PCFBKOPLJKJ, int MNLICGAMFKO, int CPOGBEJLHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF12F0", Offset = "0x6FF06F0", VA = "0x186FF12F0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] AOFHFNCIAGP MPPCBAMKGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0830", Offset = "0x6FEFC30", VA = "0x186FF0830")]
	public void CEACGGDAOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0A20", Offset = "0x6FEFE20", VA = "0x186FF0A20")]
	public void OALPICEJPNA(Span<GFPKBMFCHPH> PFJCGKAMCEK, CBCKNHLGGPC GPFKPPOCJKG, [In] HPOEOAFHJEF JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6FECE30", Offset = "0x6FEC230", VA = "0x186FECE30")]
	private void GAHCANJOMCP([In] MPOEBJOAGEI FLKMPEFJLCF, [In] GFPKBMFCHPH LHACNIMDJMF, int KLHMMMDJODJ, [In] float EOKPGBPNPKP, [In] float HHLKPMBHKEM, CBCKNHLGGPC GPFKPPOCJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6FF11A0", Offset = "0x6FF05A0", VA = "0x186FF11A0")]
	private void OBDBJLCEECA([In] MPOEBJOAGEI FLKMPEFJLCF, GFPKBMFCHPH LHACNIMDJMF, [In] int FPHEGICDFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0850", Offset = "0x6FEFC50", VA = "0x186FF0850")]
	public static void MFDALKKPGOM(ReadOnlySpan<GFPKBMFCHPH> PFJCGKAMCEK, int BPBAFDCPANC, [Out] int HFGFHDPKMAO, [Out] int BNEOHAJIAGJ, [Out] int EOKKCKPHGOH)
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
