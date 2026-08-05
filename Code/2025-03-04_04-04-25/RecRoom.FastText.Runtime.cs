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
public class MOEKPCINBOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D KHPJGNNPJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig FMMNFHKMBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public EINOPAGHIDM[] KPECJDEPIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public EINOPAGHIDM OCGLIEDBMMB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static MOEKPCINBOK HJNBELFOFKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MOEKPCINBOK CFMJNIHGEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74FD3F0", Offset = "0x74FB9F0", VA = "0x1874FD3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public MOEKPCINBOK()
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
		[Cpp2IlInjected.Address(RVA = "0x74FA430", Offset = "0x74F8A30", VA = "0x1874FA430")]
		public GlyphUVConfig(int CHFJDOGLILP, int JNPKAIHJJGB, int AMKOENCGOLH, int GMJMMMCABBA, float GKCBDOKNMOB = 0f, [Optional] GlyphPixelInset IHNFAGMOBJG)
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
public readonly struct EINOPAGHIDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char IIBDLBCOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int PMELBONAOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int OJGKBACILDB;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly EINOPAGHIDM OCHLMNPAMIE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74F8D00", Offset = "0x74F7300", VA = "0x1874F8D00")]
	public EINOPAGHIDM(char BDOMIECOLDC, int MCCECDOAIDN, int JMEEJPLMOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74F8D10", Offset = "0x74F7310", VA = "0x1874F8D10")]
	public EINOPAGHIDM(GlyphCoordinateWritable IPCDPDKDJJH)
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
		[Cpp2IlInjected.Address(RVA = "0x74F9A40", Offset = "0x74F8040", VA = "0x1874F9A40")]
		public static EINOPAGHIDM HEGJABMHLEC(GlyphCoordinateWritable OPLPABIPAJI)
		{
			return default(EINOPAGHIDM);
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
		private MOEKPCINBOK configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x74FA330", Offset = "0x74F8930", VA = "0x1874FA330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x74FA1B0", Offset = "0x74F87B0", VA = "0x1874FA1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x74FA1A0", Offset = "0x74F87A0", VA = "0x1874FA1A0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MOEKPCINBOK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x74F9B90", Offset = "0x74F8190", VA = "0x1874F9B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EINOPAGHIDM FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x74FA010", Offset = "0x74F8610", VA = "0x1874FA010")]
			get
			{
				return default(EINOPAGHIDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74F9A60", Offset = "0x74F8060", VA = "0x1874F9A60")]
		internal void BOOHNMIPGKL(IEnumerable<GlyphCoordinateWritable> DBFKOCJIBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74F9B00", Offset = "0x74F8100", VA = "0x1874F9B00")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74F9AE0", Offset = "0x74F80E0", VA = "0x1874F9AE0")]
		[CompilerGenerated]
		private bool LLNKHKMACHF(GlyphCoordinateWritable OPLPABIPAJI)
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
		private TextSegmentMeshBufferSource LAOJEHCMKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private JHFOGMCBEON GNAHGGCPDLM;

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
		private AKBLOBKGODO DDNNGCOILJJ;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74FD7A0", Offset = "0x74FBDA0", VA = "0x1874FD7A0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74FD750", Offset = "0x74FBD50", VA = "0x1874FD750")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74FD570", Offset = "0x74FBB70", VA = "0x1874FD570")]
		private void LCONJBEFPAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74FD890", Offset = "0x74FBE90", VA = "0x1874FD890")]
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
		private bool NIDCBNPBKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material PDLICOAFIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private JHFOGMCBEON GNAHGGCPDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material OGLFEGLCOFB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private MOEKPCINBOK HJACFADDFHA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x74FDC10", Offset = "0x74FC210", VA = "0x1874FDC10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JHFOGMCBEON BBGGFHJJMEC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x74FE3A0", Offset = "0x74FC9A0", VA = "0x1874FE3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material CIHHENKAAIG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x74FE3D0", Offset = "0x74FC9D0", VA = "0x1874FE3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x74FE300", Offset = "0x74FC900", VA = "0x1874FE300")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74FDFC0", Offset = "0x74FC5C0", VA = "0x1874FDFC0", Slot = "8")]
		protected override void NILAIJNOCBB(HFOGIEJFOPC IBNPBKKMILL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74FE310", Offset = "0x74FC910", VA = "0x1874FE310", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] DPLJMLJHJME NEIKICMADNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74FE1B0", Offset = "0x74FC7B0", VA = "0x1874FE1B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74FDCA0", Offset = "0x74FC2A0", VA = "0x1874FDCA0")]
		private void LOKJGKEALKB(bool MHOOEDPKADD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x96E010", Offset = "0x96C610", VA = "0x18096E010")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct JAOGJFMABNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly JHFOGMCBEON JFFJMLJKAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int APEHELKDAII;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74FA600", Offset = "0x74F8C00", VA = "0x1874FA600")]
	internal AIAGEENPIDL ICLICLMGJHI()
	{
		return default(AIAGEENPIDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25777D0", Offset = "0x2575DD0", VA = "0x1825777D0")]
	internal JAOGJFMABNJ(JHFOGMCBEON JEIEGFHFIPA, int HGOAHMFIGKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HOFJBFEDNJD
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74FA550", Offset = "0x74F8B50", VA = "0x1874FA550")]
	public static bool IAAFOFHKKKL(this JAOGJFMABNJ FOCJIGDCLCL, GGNBFIFBGCJ MPNEBCJKGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74FA5A0", Offset = "0x74F8BA0", VA = "0x1874FA5A0")]
	internal static bool IAAFOFHKKKL(this AIAGEENPIDL FGGHMCNAGAP, GGNBFIFBGCJ MPNEBCJKGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74FA5C0", Offset = "0x74F8BC0", VA = "0x1874FA5C0")]
	public static float JAENAJKNMKL(this JAOGJFMABNJ FOCJIGDCLCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBDFEB0", VA = "0x180BE18B0")]
	internal static float JAENAJKNMKL(this AIAGEENPIDL FGGHMCNAGAP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LBHOKFFEOCN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74FD140", Offset = "0x74FB740", VA = "0x1874FD140")]
	public static void MEDGAEDAALL(this JAOGJFMABNJ FOCJIGDCLCL, ReadOnlySpan<char> PKDBKAKJCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74FD190", Offset = "0x74FB790", VA = "0x1874FD190")]
	internal static void MEDGAEDAALL(this AIAGEENPIDL FGGHMCNAGAP, ReadOnlySpan<char> PKDBKAKJCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74FCFE0", Offset = "0x74FB5E0", VA = "0x1874FCFE0")]
	public static void HFMJBBKIDLM(this JAOGJFMABNJ KMMBMMCJFLK, float2 EOLPAKBALHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74FD030", Offset = "0x74FB630", VA = "0x1874FD030")]
	internal static void HFMJBBKIDLM(this AIAGEENPIDL FGGHMCNAGAP, float2 EOLPAKBALHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74FD040", Offset = "0x74FB640", VA = "0x1874FD040")]
	public static void HMKJKMPNPJI(this JAOGJFMABNJ KMMBMMCJFLK, float MOJOJKPNJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74FD0B0", Offset = "0x74FB6B0", VA = "0x1874FD0B0")]
	internal static void HMKJKMPNPJI(this AIAGEENPIDL FGGHMCNAGAP, float MOJOJKPNJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74FD3E0", Offset = "0x74FB9E0", VA = "0x1874FD3E0")]
	internal static void PBNPBDBBCBB(this AIAGEENPIDL FGGHMCNAGAP, bool EFAINGIJKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74FD0F0", Offset = "0x74FB6F0", VA = "0x1874FD0F0")]
	public static void KEBKKELILPK(this JAOGJFMABNJ KMMBMMCJFLK, Color32 NHCBHMJDLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74FD130", Offset = "0x74FB730", VA = "0x1874FD130")]
	internal static void KEBKKELILPK(this AIAGEENPIDL FGGHMCNAGAP, Color32 NHCBHMJDLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74FD3A0", Offset = "0x74FB9A0", VA = "0x1874FD3A0")]
	public static void MEGJHFGCLCI(this JAOGJFMABNJ KMMBMMCJFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74FD390", Offset = "0x74FB990", VA = "0x1874FD390")]
	internal static void MEGJHFGCLCI(this AIAGEENPIDL FGGHMCNAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74FCF50", Offset = "0x74FB550", VA = "0x1874FCF50")]
	internal static void BDJDONAICEE(this AIAGEENPIDL FGGHMCNAGAP, int PMMBGAHPBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74FCFC0", Offset = "0x74FB5C0", VA = "0x1874FCFC0")]
	internal static void CJDFJIAFOII(this AIAGEENPIDL FGGHMCNAGAP, int JFOMNJPCBOF, GGNBFIFBGCJ KBFAGFOEACK = GGNBFIFBGCJ.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AKBLOBKGODO : IEquatable<AKBLOBKGODO>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort JIOOGGHIJOD = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int MPLBNMCMEHH = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly AKBLOBKGODO GDOMIEPPNAF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort OLELAAFOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAD1DF0", Offset = "0xAD03F0", VA = "0x180AD1DF0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAD1E00", Offset = "0xAD0400", VA = "0x180AD1E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JHFOGMCBEON JFFJMLJKAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74F6640", Offset = "0x74F4C40", VA = "0x1874F6640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74F6960", Offset = "0x74F4F60", VA = "0x1874F6960")]
	public AKBLOBKGODO(int KOHJMPGEGHH, JHFOGMCBEON JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x74F8990", Offset = "0x74F6F90", VA = "0x1874F8990")]
	public bool CJBIMDHAPOE([Out] JAOGJFMABNJ FOCJIGDCLCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74F8940", Offset = "0x74F6F40", VA = "0x1874F8940")]
	public void BHDLIGCHPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74F66A0", Offset = "0x74F4CA0", VA = "0x1874F66A0")]
	internal void EHNMFDMKKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74F66D0", Offset = "0x74F4CD0", VA = "0x1874F66D0", Slot = "4")]
	public bool Equals(AKBLOBKGODO OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74F8A60", Offset = "0x74F7060", VA = "0x1874F8A60", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74F8B20", Offset = "0x74F7120", VA = "0x1874F8B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class JHFOGMCBEON : IDisposable, GCCILAMBMEM
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string GKEJPNOHMKJ = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker JFACODDHCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string OAACCKDDDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly KOJNPOLGOKK OFABDIKCLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int IPHJBHGMKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal AIAGEENPIDL[] OEGKFFKPKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal AKBLOBKGODO[] EIHKCKIGLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MOEKPCINBOK BILLHENACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ENNFLMLFDEJ DFEKNEFKNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly JNPEJNELMNG HPHMOAMNGMB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string OMOOEGOLALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74FA760", Offset = "0x74F8D60", VA = "0x1874FA760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MOEKPCINBOK NNDKFLKIILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74FB7D0", Offset = "0x74F9DD0", VA = "0x1874FB7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float GCNCAIJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74FA7F0", Offset = "0x74F8DF0", VA = "0x1874FA7F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CANLBNFGEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74FB3A0", Offset = "0x74F99A0", VA = "0x1874FB3A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GCCILAMBMEM.KFPLJMODBDA KODNKAKGCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x956D90", Offset = "0x955390", VA = "0x180956D90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x956D10", Offset = "0x955310", VA = "0x180956D10", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74FBA90", Offset = "0x74FA090", VA = "0x1874FBA90")]
	public JHFOGMCBEON(KOJNPOLGOKK HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74FBED0", Offset = "0x74FA4D0", VA = "0x1874FBED0")]
	public JHFOGMCBEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74FA9D0", Offset = "0x74F8FD0", VA = "0x1874FA9D0")]
	public void CIDIOEOELJF(GlyphMapAsset BGIJFEBPIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x74FA8C0", Offset = "0x74F8EC0", VA = "0x1874FA8C0")]
	public void CIDIOEOELJF(MOEKPCINBOK CPGFCKFAAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x74FB7F0", Offset = "0x74F9DF0", VA = "0x1874FB7F0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] DPLJMLJHJME NEIKICMADNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74FA700", Offset = "0x74F8D00", VA = "0x1874FA700")]
	public void AONHOHNMJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74FB780", Offset = "0x74F9D80", VA = "0x1874FB780")]
	public bool MBGEIMFKCHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74FADD0", Offset = "0x74F93D0", VA = "0x1874FADD0")]
	public AKBLOBKGODO FFEFMDJFOEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x74FB3C0", Offset = "0x74F99C0", VA = "0x1874FB3C0")]
	public void LIECJMGBBMF(AKBLOBKGODO JFBBLJCNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74FA810", Offset = "0x74F8E10", VA = "0x1874FA810")]
	internal bool BNIGFBMCAPL(AKBLOBKGODO JFBBLJCNNCF, [Out] JAOGJFMABNJ FOCJIGDCLCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74FB040", Offset = "0x74F9640", VA = "0x1874FB040")]
	private void FMAHHBCJPIB(AIAGEENPIDL FGGHMCNAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74FB1C0", Offset = "0x74F97C0", VA = "0x1874FB1C0")]
	private void IBOKMDLPENM(int EEPEDKIKJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74FB720", Offset = "0x74F9D20", VA = "0x1874FB720")]
	private bool LOGJKNHANHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74F0C00", Offset = "0x74EF200", VA = "0x1874F0C00")]
	private static int NJIBBOLMBJG(AKBLOBKGODO JFBBLJCNNCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4720", Offset = "0x1EC2D20", VA = "0x181EC4720")]
	private static ushort PACPHPAIGHC(int EAHKFAJBNDN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x74FAA10", Offset = "0x74F9010", VA = "0x1874FAA10")]
	private Bounds DJHNIEMNJKI()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74FAD20", Offset = "0x74F9320", VA = "0x1874FAD20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KOJNPOLGOKK
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KOJNPOLGOKK EFKNNKFCEPE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float AKIALBPODMG = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int GKBMODCGMLH = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int KACLPDANHLL = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color GGKBLIHPHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float HHKJCKFNFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int AOJMFKLMHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int INILFDPFDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int APDIKFIMODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int IDGDDMDIEGC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x74FCD70", Offset = "0x74FB370", VA = "0x1874FCD70")]
	internal KOJNPOLGOKK OPJNPGGHPHE()
	{
		return default(KOJNPOLGOKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74F3890", Offset = "0x74F1E90", VA = "0x1874F3890")]
	[CompilerGenerated]
	internal static void AHALGBPJOPA(int KBGCCIOIGBD, int IDJBNLNBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74FCD50", Offset = "0x74FB350", VA = "0x1874FCD50")]
	[CompilerGenerated]
	internal static void HHIKEJJMLGA(float KBGCCIOIGBD, float IDJBNLNBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74F3880", Offset = "0x74F1E80", VA = "0x1874F3880")]
	[CompilerGenerated]
	internal static void JILLCOOLPJD(int KBGCCIOIGBD, int HDOJMOFDDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74FCE80", Offset = "0x74FB480", VA = "0x1874FCE80")]
	[CompilerGenerated]
	internal static void PLOELDHDOJG(float KBGCCIOIGBD, float HDOJMOFDDCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CBKJPCJGEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74F8C20", Offset = "0x74F7220", VA = "0x1874F8C20")]
	public static float COIGFMEGLIO(this JAOGJFMABNJ OFCNHHFEJKJ)
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
		public readonly AKBLOBKGODO textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74FDBA0", Offset = "0x74FC1A0", VA = "0x1874FDBA0")]
		public TextSegmentLayout(LayoutRect layoutRect, AKBLOBKGODO textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x74FD970", Offset = "0x74FBF70", VA = "0x1874FD970")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74FD9E0", Offset = "0x74FBFE0", VA = "0x1874FD9E0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x74FD910", Offset = "0x74FBF10", VA = "0x1874FD910")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class ENNFLMLFDEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig LJPBNJELCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float LANMIFFCOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float MMONBCNJOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float AHHFFECLDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float KFFAKDECMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float EKCPIKNPDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float MJCHLNECCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float APJDBCHFLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float CDMLDAGBMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float LEAIIDNHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float CANLBNFGEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float LJNFCPBPGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float GCNCAIJKHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly HNLGKBIPALB[] BCDKAEANHGA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int MJEMAGNKLCN = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private FPIKAMCJOKA[] EHFIBJMOMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int BJLBEJPFNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private EINOPAGHIDM[] IMACNKFOIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int LHJOANCINCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public HNLGKBIPALB PBFPDDPPDNG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74F8D30", Offset = "0x74F7330", VA = "0x1874F8D30")]
	public void CIDIOEOELJF(MOEKPCINBOK JLFKJIMBPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74F8DC0", Offset = "0x74F73C0", VA = "0x1874F8DC0")]
	public void CIDIOEOELJF(GlyphUVConfig CGGIEGAPBPG, IEnumerable<EINOPAGHIDM> BGIJFEBPIEJ, EINOPAGHIDM GLLNNCEODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74F8E40", Offset = "0x74F7440", VA = "0x1874F8E40")]
	internal void FDDEBKDAJNN(GlyphUVConfig CGGIEGAPBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74F8F80", Offset = "0x74F7580", VA = "0x1874F8F80")]
	private void HHAHBCJHFPN(IEnumerable<EINOPAGHIDM> BGIJFEBPIEJ, EINOPAGHIDM GLLNNCEODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74F94C0", Offset = "0x74F7AC0", VA = "0x1874F94C0")]
	public void ILFCDIGNDFF([In] char BDOMIECOLDC, [Out] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74F69C0", Offset = "0x74F4FC0", VA = "0x1874F69C0")]
	private HNLGKBIPALB GMJJJNLPNDC(EINOPAGHIDM IPCDPDKDJJH)
	{
		return default(HNLGKBIPALB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74F97F0", Offset = "0x74F7DF0", VA = "0x1874F97F0")]
	public ENNFLMLFDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FIMCKDMAFED
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74F98F0", Offset = "0x74F7EF0", VA = "0x1874F98F0")]
	public static void HKPPBNHMHBA([In] float CCJEHMPCADL, [In] float CFDNNCIGFOC, [In] int OJHHEDLFCCN, [In] int AGEHIOOJEKG, [In] float KFFAKDECMBG, [In] float EKCPIKNPDNO, [In] float PHKFKPIHCDA, [In] float KFLDDMEGODF, [In] float LDDLLOGFOMN, [In] float EFKNBGOEJIM, [Out] float FEDBPJBMDNP, [Out] float FDKNECEICDD, [Out] float ALDCCGHOPHP, [Out] float AGNOEFFKJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74F99C0", Offset = "0x74F7FC0", VA = "0x1874F99C0")]
	public static void HKPPBNHMHBA([In] float CCJEHMPCADL, [In] float CFDNNCIGFOC, [In] int OJHHEDLFCCN, [In] int AGEHIOOJEKG, [Out] float FEDBPJBMDNP, [Out] float FDKNECEICDD, [Out] float ALDCCGHOPHP, [Out] float AGNOEFFKJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x74F9890", Offset = "0x74F7E90", VA = "0x1874F9890")]
	public static void DKBKLCOPNBO([In] float KFFAKDECMBG, [In] float EKCPIKNPDNO, [In] float EDABJLNNNDH, [In] float IKMKCFLJHJG, [In] float FMAMKPLMGBC, [In] float DNBMNKGLPPB, [Out] float AMAFMKFCIMA, [Out] float OPNJLFNIDGM, [Out] float MDPPFGNBOCE, [Out] float GEPLBJKGOGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct FPIKAMCJOKA
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint FABPDGEMJGO = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char IIBDLBCOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly HNLGKBIPALB MPBJDHOIEFF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74F9A20", Offset = "0x74F8020", VA = "0x1874F9A20")]
	public FPIKAMCJOKA(char BDOMIECOLDC, HNLGKBIPALB HCDPEHGDABI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HNLGKBIPALB
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint FABPDGEMJGO = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] KHGMOPNBFIO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74FA460", Offset = "0x74F8A60", VA = "0x1874FA460")]
	public HNLGKBIPALB(float FEDBPJBMDNP, float FDKNECEICDD, float ALDCCGHOPHP, float AGNOEFFKJLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct AIAGEENPIDL
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int KJFKAKFKBGM = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal GGNBFIFBGCJ KBFAGFOEACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] DKDDMCKNHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int IPJPMMABOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 EOLPAKBALHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float AGFGCEFLBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 GJDEDJEABGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool EFAINGIJKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int CPCJOABHFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int FLGJCFEGJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int CNFEPEGDKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int CKEDEAMCNIG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74F8930", Offset = "0x74F6F30", VA = "0x1874F8930")]
	public static int EFDPIONEPOA(int OLMMDBKFHBG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum GGNBFIFBGCJ : byte
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
public static class JEBNKOHAPJM
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74FA640", Offset = "0x74F8C40", VA = "0x1874FA640")]
	internal static float COIGFMEGLIO(this AIAGEENPIDL FGGHMCNAGAP, float FPDMBBDPGAP, float OELODCPJEAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74FA680", Offset = "0x74F8C80", VA = "0x1874FA680")]
	internal static void KDFDNBOENPE(this AIAGEENPIDL FGGHMCNAGAP, float FPDMBBDPGAP, float OELODCPJEAN, [Out] float2 CDIPILBCKFB, [Out] float2 HCEBABCAMLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class JNPEJNELMNG : GCCILAMBMEM
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int MPBLEMPCKGJ = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int GMAHFOBDHIJ = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string GKEJPNOHMKJ = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker APDGDGHNKMC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker EAHFAHJBKHF;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker KFHMJJPGBGM;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker APHGAGGIENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly DPLJMLJHJME NEIKICMADNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] OMKJCIEOIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] LOOMDLFCKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BHAMOHDEGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int OKHMAFBAPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int GCMJLDIGINJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string OMOOEGOLALI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GCCILAMBMEM.KFPLJMODBDA KODNKAKGCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x950FD0", VA = "0x1809529D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74FCC40", Offset = "0x74FB240", VA = "0x1874FCC40")]
	public JNPEJNELMNG(DPLJMLJHJME.OIHDIJPCFLG LCIHIEFOOGM, int MEDGMDFBMLK, int LFINLOAPPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74FCAB0", Offset = "0x74FB0B0", VA = "0x1874FCAB0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] DPLJMLJHJME NEIKICMADNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x74FC940", Offset = "0x74FAF40", VA = "0x1874FC940")]
	public void NNGIPMDJCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74FC160", Offset = "0x74FA760", VA = "0x1874FC160")]
	public void JNFGBNAEICD(Span<AIAGEENPIDL> JOAJEMCIEEO, ENNFLMLFDEJ CIAGOOEFABB, [In] KOJNPOLGOKK HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x74F6DA0", Offset = "0x74F53A0", VA = "0x1874F6DA0")]
	private void DCGIDGNEAPK([In] GGNBFIFBGCJ KBFAGFOEACK, [In] AIAGEENPIDL MFIJNAMKJGP, int CMFFMBKPOCF, [In] float FPDMBBDPGAP, [In] float OELODCPJEAN, ENNFLMLFDEJ CIAGOOEFABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74FC960", Offset = "0x74FAF60", VA = "0x1874FC960")]
	private void PACHEJDMLHB([In] GGNBFIFBGCJ KBFAGFOEACK, AIAGEENPIDL MFIJNAMKJGP, [In] int HACKIBNIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74FBF50", Offset = "0x74FA550", VA = "0x1874FBF50")]
	public static void ENKLKDNPDMO(ReadOnlySpan<AIAGEENPIDL> JOAJEMCIEEO, int PNPJCHBNLJG, [Out] int OKDDMPAAHAH, [Out] int NAMKAKCJGLB, [Out] int ENCGIEGEMDL)
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
