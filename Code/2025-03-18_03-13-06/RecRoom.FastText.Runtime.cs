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
public class EBENIMANGEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D KJBPFBDPHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig PKFJHDBCBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public CANJKMBOODP[] NENPBEPKCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public CANJKMBOODP NAHEECDAIIH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static EBENIMANGEP DIMLLLMEKBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EBENIMANGEP MEBJJEOECFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75F23F0", Offset = "0x75F15F0", VA = "0x1875F23F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EBENIMANGEP()
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
		[Cpp2IlInjected.Address(RVA = "0x75F3240", Offset = "0x75F2440", VA = "0x1875F3240")]
		public GlyphUVConfig(int NLDPHLFDHBE, int PPJHLHMJJKM, int GMMBKIAHDHJ, int POADAGPLNGK, float COBMCMALLPD = 0f, [Optional] GlyphPixelInset GDJIIBBFOLG)
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
public readonly struct CANJKMBOODP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char BLLOKEICAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int NEDNHGDLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int NNPACKAEHFG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly CANJKMBOODP GOHJOLLNOGK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75F23C0", Offset = "0x75F15C0", VA = "0x1875F23C0")]
	public CANJKMBOODP(char LOMMHOJPADL, int EJKCJNIFEHN, int LMBNGEHDLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75F23D0", Offset = "0x75F15D0", VA = "0x1875F23D0")]
	public CANJKMBOODP(GlyphCoordinateWritable DMNJAFCBOIL)
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
		[Cpp2IlInjected.Address(RVA = "0x75F2860", Offset = "0x75F1A60", VA = "0x1875F2860")]
		public static CANJKMBOODP AJAOLMPMCKD(GlyphCoordinateWritable CPCFIJBFPJB)
		{
			return default(CANJKMBOODP);
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
		private EBENIMANGEP configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x75F3140", Offset = "0x75F2340", VA = "0x1875F3140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x75F2FC0", Offset = "0x75F21C0", VA = "0x1875F2FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x75F2FB0", Offset = "0x75F21B0", VA = "0x1875F2FB0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EBENIMANGEP ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x75F29B0", Offset = "0x75F1BB0", VA = "0x1875F29B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CANJKMBOODP FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x75F2E20", Offset = "0x75F2020", VA = "0x1875F2E20")]
			get
			{
				return default(CANJKMBOODP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75F28A0", Offset = "0x75F1AA0", VA = "0x1875F28A0")]
		internal void NJHFBBOPDCL(IEnumerable<GlyphCoordinateWritable> AOAOEDKEGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75F2920", Offset = "0x75F1B20", VA = "0x1875F2920")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75F2880", Offset = "0x75F1A80", VA = "0x1875F2880")]
		[CompilerGenerated]
		private bool FELGBLMBMEH(GlyphCoordinateWritable CPCFIJBFPJB)
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
		private TextSegmentMeshBufferSource CMGNENIKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private MDLIACLACEL PGPIMMLLGBE;

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
		private GPEBFPEAKFL OJOPCDPLONI;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75F6110", Offset = "0x75F5310", VA = "0x1875F6110")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75F60C0", Offset = "0x75F52C0", VA = "0x1875F60C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75F5EE0", Offset = "0x75F50E0", VA = "0x1875F5EE0")]
		private void ABMKOPEGIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75F6200", Offset = "0x75F5400", VA = "0x1875F6200")]
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
		private bool OHGOIDFAAIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material IAOGGCKJJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private MDLIACLACEL PGPIMMLLGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material DFDBHJJNHMN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private EBENIMANGEP IEONGJHPCHO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x75F6580", Offset = "0x75F5780", VA = "0x1875F6580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MDLIACLACEL MMIBJFJOECB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x75F6D10", Offset = "0x75F5F10", VA = "0x1875F6D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material DKFHLJDFNPH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x75F6D40", Offset = "0x75F5F40", VA = "0x1875F6D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x75F6C70", Offset = "0x75F5E70", VA = "0x1875F6C70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75F6610", Offset = "0x75F5810", VA = "0x1875F6610", Slot = "8")]
		protected override void HEKICPGDNEF(ONMLHJNKMOO GPGNPJMMLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75F6C80", Offset = "0x75F5E80", VA = "0x1875F6C80", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] BNJBNFLHPKO IPHKHAHPAHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75F6B20", Offset = "0x75F5D20", VA = "0x1875F6B20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x75F6800", Offset = "0x75F5A00", VA = "0x1875F6800")]
		private void HEOGOMCJCNM(bool CPGNGBBHKKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x97F1E0", Offset = "0x97E3E0", VA = "0x18097F1E0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct MAPCIAMMEND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly MDLIACLACEL JDPHDLJMMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int CNGOOLKICLD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75F3850", Offset = "0x75F2A50", VA = "0x1875F3850")]
	internal NMHIDCFDCMF JAPFEAOGCMO()
	{
		return default(NMHIDCFDCMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25AD490", Offset = "0x25AC690", VA = "0x1825AD490")]
	internal MAPCIAMMEND(MDLIACLACEL CKLPHBNMNHA, int CCDCPLDJNEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HCODIMGDKMP
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75F3270", Offset = "0x75F2470", VA = "0x1875F3270")]
	public static bool BDBCFEPDCIB(this MAPCIAMMEND JEGCJIJPAHE, CBCDGGAGECK GBBPOPBJDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75F32C0", Offset = "0x75F24C0", VA = "0x1875F32C0")]
	internal static bool BDBCFEPDCIB(this NMHIDCFDCMF FHMFCENELNC, CBCDGGAGECK GBBPOPBJDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75F32E0", Offset = "0x75F24E0", VA = "0x1875F32E0")]
	public static float JPJIOFEDHGH(this MAPCIAMMEND JEGCJIJPAHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC30C00", Offset = "0xC2FE00", VA = "0x180C30C00")]
	internal static float JPJIOFEDHGH(this NMHIDCFDCMF FHMFCENELNC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KPIGBCCPNKK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75F3730", Offset = "0x75F2930", VA = "0x1875F3730")]
	public static void LGCJGGOIGMP(this MAPCIAMMEND JEGCJIJPAHE, ReadOnlySpan<char> PMHMHPCKJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75F3530", Offset = "0x75F2730", VA = "0x1875F3530")]
	internal static void LGCJGGOIGMP(this NMHIDCFDCMF FHMFCENELNC, ReadOnlySpan<char> PMHMHPCKJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75F3800", Offset = "0x75F2A00", VA = "0x1875F3800")]
	public static void PDAJDGNMELK(this MAPCIAMMEND FJJCHNOPDLC, float2 ANACJKJCJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x75F37F0", Offset = "0x75F29F0", VA = "0x1875F37F0")]
	internal static void PDAJDGNMELK(this NMHIDCFDCMF FHMFCENELNC, float2 ANACJKJCJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75F3410", Offset = "0x75F2610", VA = "0x1875F3410")]
	public static void EBNOAIKBHNM(this MAPCIAMMEND FJJCHNOPDLC, float DLOPFJNBDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75F33D0", Offset = "0x75F25D0", VA = "0x1875F33D0")]
	internal static void EBNOAIKBHNM(this NMHIDCFDCMF FHMFCENELNC, float DLOPFJNBDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75F34D0", Offset = "0x75F26D0", VA = "0x1875F34D0")]
	internal static void HLBPKPGCDFD(this NMHIDCFDCMF FHMFCENELNC, bool DFKOPNGODPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x75F3480", Offset = "0x75F2680", VA = "0x1875F3480")]
	public static void FHIMPCCCGHA(this MAPCIAMMEND FJJCHNOPDLC, Color32 JLNFDAODDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75F34C0", Offset = "0x75F26C0", VA = "0x1875F34C0")]
	internal static void FHIMPCCCGHA(this NMHIDCFDCMF FHMFCENELNC, Color32 JLNFDAODDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75F34F0", Offset = "0x75F26F0", VA = "0x1875F34F0")]
	public static void HLFKOLGCBGK(this MAPCIAMMEND FJJCHNOPDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x75F34E0", Offset = "0x75F26E0", VA = "0x1875F34E0")]
	internal static void HLFKOLGCBGK(this NMHIDCFDCMF FHMFCENELNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75F3780", Offset = "0x75F2980", VA = "0x1875F3780")]
	internal static void MBFFJBNAGFE(this NMHIDCFDCMF FHMFCENELNC, int LIICGKMNJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x75F33B0", Offset = "0x75F25B0", VA = "0x1875F33B0")]
	internal static void CHJCBJJBACD(this NMHIDCFDCMF FHMFCENELNC, int OCKEOAAGKKC, CBCDGGAGECK OBJLNADEMDI = CBCDGGAGECK.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class GPEBFPEAKFL : IEquatable<GPEBFPEAKFL>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort FEGNFGNDJBO = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int IIBDCPPIOLF = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly GPEBFPEAKFL IHELDCCHEBI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort AHFPHBNFDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB44720", Offset = "0xB43920", VA = "0x180B44720")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB44730", Offset = "0xB43930", VA = "0x180B44730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MDLIACLACEL JDPHDLJMMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IEIFJCLJNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75EA090", Offset = "0x75E9290", VA = "0x1875EA090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x75EA160", Offset = "0x75E9360", VA = "0x1875EA160")]
	public GPEBFPEAKFL(int GEOGJONCLKK, MDLIACLACEL CKLPHBNMNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x75F2700", Offset = "0x75F1900", VA = "0x1875F2700")]
	public bool KFKIFFJAHHP([Out] MAPCIAMMEND JEGCJIJPAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x75F2640", Offset = "0x75F1840", VA = "0x1875F2640")]
	public void FANKGHIJBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75EA0A0", Offset = "0x75E92A0", VA = "0x1875EA0A0")]
	internal void NGHJHCJGFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x75E9EB0", Offset = "0x75E90B0", VA = "0x1875E9EB0", Slot = "4")]
	public bool Equals(GPEBFPEAKFL LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x75F2580", Offset = "0x75F1780", VA = "0x1875F2580", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x75F2690", Offset = "0x75F1890", VA = "0x1875F2690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MDLIACLACEL : IDisposable, EBDPFAGCKKD
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string ANPKMIHHNEP = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker CIDKBBGAGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string LODLBDGAKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly BEJIPFAMCAF IPBKLKAAJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int MCDPNNPIJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal NMHIDCFDCMF[] NACIIOFAGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal GPEBFPEAKFL[] DOBLFLLFKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EBENIMANGEP BPOOGFMLKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NDLHAMNPOCB JEBKHACBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly BNMJEBGEHAL OEKPEGIJGIO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string MBDFMCIDAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75F40D0", Offset = "0x75F32D0", VA = "0x1875F40D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EBENIMANGEP BLLBBCIHJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x75F40B0", Offset = "0x75F32B0", VA = "0x1875F40B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float KPLBPAIFJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75F4160", Offset = "0x75F3360", VA = "0x1875F4160")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float OBMPDGDMEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75F4490", Offset = "0x75F3690", VA = "0x1875F4490")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EBDPFAGCKKD.CBHFKFBGPDO MJEANBNHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960870", VA = "0x180961670", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x961650", Offset = "0x960850", VA = "0x180961650", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x75F4C40", Offset = "0x75F3E40", VA = "0x1875F4C40")]
	public MDLIACLACEL(BEJIPFAMCAF PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75F5080", Offset = "0x75F4280", VA = "0x1875F5080")]
	public MDLIACLACEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75F3C30", Offset = "0x75F2E30", VA = "0x1875F3C30")]
	public void EMBIHAFPMPJ(GlyphMapAsset LLFGFGEBMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x75F3B20", Offset = "0x75F2D20", VA = "0x1875F3B20")]
	public void EMBIHAFPMPJ(EBENIMANGEP MHPNJAFMOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x75F4970", Offset = "0x75F3B70", VA = "0x1875F4970", Slot = "6")]
	public bool TryGetMeshBuffer([Out] BNJBNFLHPKO IPHKHAHPAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x75F3DF0", Offset = "0x75F2FF0", VA = "0x1875F3DF0")]
	public void EPPDCBIFFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75F4810", Offset = "0x75F3A10", VA = "0x1875F4810")]
	public bool PFGLHMNOEPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75F3E50", Offset = "0x75F3050", VA = "0x1875F3E50")]
	public GPEBFPEAKFL FDFNMFDIAFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75F44B0", Offset = "0x75F36B0", VA = "0x1875F44B0")]
	public void NKLGOBBHMNG(GPEBFPEAKFL IMCLBHKMCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x75F4860", Offset = "0x75F3A60", VA = "0x1875F4860")]
	internal bool PJBDJEKDCBE(GPEBFPEAKFL IMCLBHKMCHA, [Out] MAPCIAMMEND JEGCJIJPAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x75F3C70", Offset = "0x75F2E70", VA = "0x1875F3C70")]
	private void ENFOBIEABAG(NMHIDCFDCMF FHMFCENELNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x75F3890", Offset = "0x75F2A90", VA = "0x1875F3890")]
	private void AGBONGNIAKM(int ACBNCINMJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x75F4910", Offset = "0x75F3B10", VA = "0x1875F4910")]
	private bool PJILAFPBCNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75EE200", Offset = "0x75ED400", VA = "0x1875EE200")]
	private static int CMCOBIGDJKH(GPEBFPEAKFL IMCLBHKMCHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F27930", Offset = "0x1F26B30", VA = "0x181F27930")]
	private static ushort HKLFOGENJOC(int KOOLKCPAFBB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x75F4180", Offset = "0x75F3380", VA = "0x1875F4180")]
	private Bounds IJLLOKJBEDD()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x75F3A70", Offset = "0x75F2C70", VA = "0x1875F3A70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BEJIPFAMCAF
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BEJIPFAMCAF EPCLFKMBLNA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float KDIDOJMAKNH = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int GFAODHKBHCB = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int BHFNHALFFOM = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color FGNJIBANJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float KHLKCFOOAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int HHBHMDPGMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int MGLOAJHGIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int JNKPGIAGBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int CNHNOGEKBAN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75F1260", Offset = "0x75F0460", VA = "0x1875F1260")]
	internal BEJIPFAMCAF IFJONPANLAA()
	{
		return default(BEJIPFAMCAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75E9D70", Offset = "0x75E8F70", VA = "0x1875E9D70")]
	[CompilerGenerated]
	internal static void EEKMCFMPDAB(int OMFJNFBDJCA, int OGPHJJMKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75F1240", Offset = "0x75F0440", VA = "0x1875F1240")]
	[CompilerGenerated]
	internal static void BBIHHBLOJOI(float OMFJNFBDJCA, float OGPHJJMKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x75E9D80", Offset = "0x75E8F80", VA = "0x1875E9D80")]
	[CompilerGenerated]
	internal static void OMDFKJDDCOJ(int OMFJNFBDJCA, int ANHHLNGMFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x75F1370", Offset = "0x75F0570", VA = "0x1875F1370")]
	[CompilerGenerated]
	internal static void MFEPIONBDKA(float OMFJNFBDJCA, float ANHHLNGMFIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IKKBNCHGIKD
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75F3320", Offset = "0x75F2520", VA = "0x1875F3320")]
	public static float DAODADCKEDH(this MAPCIAMMEND DDKPLLBCMOO)
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
		public readonly GPEBFPEAKFL textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75F6510", Offset = "0x75F5710", VA = "0x1875F6510")]
		public TextSegmentLayout(LayoutRect layoutRect, GPEBFPEAKFL textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x75F62E0", Offset = "0x75F54E0", VA = "0x1875F62E0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75F6350", Offset = "0x75F5550", VA = "0x1875F6350")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x75F6280", Offset = "0x75F5480", VA = "0x1875F6280")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class NDLHAMNPOCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig KHGLKDDGADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float ONCCIANKJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float BKMILOICDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float LLKNCCNLCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float PKAOICEMBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float NLJPMAIKGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float BNAGGBFDFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float NCNFGBIFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float KGJMFHKABMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float PJLNJCLMFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float OBMPDGDMEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float HGHOHJMPKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float KPLBPAIFJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly POOGKADFALH[] KIPMIFDDGOA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int KFDKMFGDFGG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private GMDFMGJPNNJ[] MOBJBNNCKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int PACNKAFOGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private CANJKMBOODP[] BEAPEPLMDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int PJJGPNODIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public POOGKADFALH DKOEPDCOAKP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x75F5900", Offset = "0x75F4B00", VA = "0x1875F5900")]
	public void EMBIHAFPMPJ(EBENIMANGEP DNEPALINONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75F5990", Offset = "0x75F4B90", VA = "0x1875F5990")]
	public void EMBIHAFPMPJ(GlyphUVConfig IPJLMAJMHPH, IEnumerable<CANJKMBOODP> LLFGFGEBMIL, CANJKMBOODP IOPLHHBIFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x75F57C0", Offset = "0x75F49C0", VA = "0x1875F57C0")]
	internal void EEEIHAIHBFE(GlyphUVConfig IPJLMAJMHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x75F5290", Offset = "0x75F4490", VA = "0x1875F5290")]
	private void AIAIPHIKJNM(IEnumerable<CANJKMBOODP> LLFGFGEBMIL, CANJKMBOODP IOPLHHBIFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x75F5A10", Offset = "0x75F4C10", VA = "0x1875F5A10")]
	public void OINBJENOADF([In] char LOMMHOJPADL, [Out] float2[] JNLIDKHHCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75F0DA0", Offset = "0x75EFFA0", VA = "0x1875F0DA0")]
	private POOGKADFALH OCOAGHFJFMH(CANJKMBOODP DMNJAFCBOIL)
	{
		return default(POOGKADFALH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75F5D40", Offset = "0x75F4F40", VA = "0x1875F5D40")]
	public NDLHAMNPOCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MEGDFGJHLBO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75F51C0", Offset = "0x75F43C0", VA = "0x1875F51C0")]
	public static void IJGJCBNMDJF([In] float LPMBPHGCBNC, [In] float JDEDMPADNLF, [In] int OCDCIPEFMHP, [In] int DGILLIHAPFH, [In] float PKAOICEMBCO, [In] float NLJPMAIKGDD, [In] float KMLKBFMDOPE, [In] float IMJIPLGNECC, [In] float KDILOEFAKGD, [In] float MFAKLOMFKLF, [Out] float IHAGDEKIKDN, [Out] float LFOCKLDFPIL, [Out] float OPMAINPGAMB, [Out] float OABMHOFDBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x75F5160", Offset = "0x75F4360", VA = "0x1875F5160")]
	public static void IJGJCBNMDJF([In] float LPMBPHGCBNC, [In] float JDEDMPADNLF, [In] int OCDCIPEFMHP, [In] int DGILLIHAPFH, [Out] float IHAGDEKIKDN, [Out] float LFOCKLDFPIL, [Out] float OPMAINPGAMB, [Out] float OABMHOFDBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x75F5100", Offset = "0x75F4300", VA = "0x1875F5100")]
	public static void BHHACKBDHPA([In] float PKAOICEMBCO, [In] float NLJPMAIKGDD, [In] float DHHLCDOIMEP, [In] float LBOMFJCPEMH, [In] float KDPDMNDNLOM, [In] float CFEEIDOHALB, [Out] float IDGDOGFDLNB, [Out] float NMCGIMCFONB, [Out] float IOEBHOOMLED, [Out] float KFPBJILCOEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GMDFMGJPNNJ
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint LLEBKONMIFA = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char BLLOKEICAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly POOGKADFALH PJGOAHCDKCO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x75F2560", Offset = "0x75F1760", VA = "0x1875F2560")]
	public GMDFMGJPNNJ(char LOMMHOJPADL, POOGKADFALH JNLIDKHHCMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct POOGKADFALH
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint LLEBKONMIFA = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] JLKIKBPBGJE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75F5DF0", Offset = "0x75F4FF0", VA = "0x1875F5DF0")]
	public POOGKADFALH(float IHAGDEKIKDN, float LFOCKLDFPIL, float OPMAINPGAMB, float OABMHOFDBED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct NMHIDCFDCMF
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int FJFBKEDBIJA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal CBCDGGAGECK OBJLNADEMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] OMKCENKCNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int OJPJHIAKEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 ANACJKJCJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float IBDDLOBIMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 IEFDKKJBAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool DFKOPNGODPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int IEBIDHDLEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int LHFDMEIOLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int BAKKKEEHJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int BBEAIKBCDPE;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x75F5DE0", Offset = "0x75F4FE0", VA = "0x1875F5DE0")]
	public static int AJGJDCOCHPH(int FBLOEALPGKL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum CBCDGGAGECK : byte
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
public static class AEMIJHFDNFD
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x75F1180", Offset = "0x75F0380", VA = "0x1875F1180")]
	internal static float DAODADCKEDH(this NMHIDCFDCMF FHMFCENELNC, float EOICNNEFCMH, float DANECLFLJHI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x75F11C0", Offset = "0x75F03C0", VA = "0x1875F11C0")]
	internal static void DDJDCKOILJL(this NMHIDCFDCMF FHMFCENELNC, float EOICNNEFCMH, float DANECLFLJHI, [Out] float2 CDNAEODPMGJ, [Out] float2 PLIBGNKHNME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class BNMJEBGEHAL : EBDPFAGCKKD
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int PFNIHOCEGAJ = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int AAEFHKDANAN = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string ANPKMIHHNEP = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker GOGGEAMMNHG;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker EIBIGEJMFAG;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker JDHCNIILBDH;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker NKNJJIKFCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly BNJBNFLHPKO IPHKHAHPAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] FPMDEPLCEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] KEBLOCBPLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int HIKFGAIPPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int PGEMJBGELLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int IMJOLGOBPBM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string MBDFMCIDAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EBDPFAGCKKD.CBHFKFBGPDO MJEANBNHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x75F2260", Offset = "0x75F1460", VA = "0x1875F2260")]
	public BNMJEBGEHAL(BNJBNFLHPKO.PDBKACEMIHM MABEOJADOCB, int LCENHFIAOKC, int NOGOPHCBHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x75F20E0", Offset = "0x75F12E0", VA = "0x1875F20E0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] BNJBNFLHPKO IPHKHAHPAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x75F1E90", Offset = "0x75F1090", VA = "0x1875F1E90")]
	public void DECEPLPMGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x75F1590", Offset = "0x75F0790", VA = "0x1875F1590")]
	public void DDNOOJDEDOJ(Span<NMHIDCFDCMF> DBBPAGEAOFC, NDLHAMNPOCB PLNBCPOGDAM, [In] BEJIPFAMCAF PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x75EFD30", Offset = "0x75EEF30", VA = "0x1875EFD30")]
	private void MFNJAPMMBBL([In] CBCDGGAGECK OBJLNADEMDI, [In] NMHIDCFDCMF GJHIEFDOJJI, int GGEGAPBBDHK, [In] float EOICNNEFCMH, [In] float DANECLFLJHI, NDLHAMNPOCB PLNBCPOGDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x75F1440", Offset = "0x75F0640", VA = "0x1875F1440")]
	private void CMJGLAJPODD([In] CBCDGGAGECK OBJLNADEMDI, NMHIDCFDCMF GJHIEFDOJJI, [In] int FNCLCACLGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x75F1EB0", Offset = "0x75F10B0", VA = "0x1875F1EB0")]
	public static void HHEABAHOOMA(ReadOnlySpan<NMHIDCFDCMF> DBBPAGEAOFC, int NLKPIOBFIAB, [Out] int ECJEECCGJJF, [Out] int NPNOKDLEPOE, [Out] int OGBHBBONLAG)
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
