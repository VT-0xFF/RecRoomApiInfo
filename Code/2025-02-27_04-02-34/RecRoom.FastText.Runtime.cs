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
		[Cpp2IlInjected.Address(RVA = "0x745F110", Offset = "0x745E510", VA = "0x18745F110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x745C150", Offset = "0x745B550", VA = "0x18745C150")]
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
	[Cpp2IlInjected.Address(RVA = "0x745AA20", Offset = "0x7459E20", VA = "0x18745AA20")]
	public EINOPAGHIDM(char BDOMIECOLDC, int MCCECDOAIDN, int JMEEJPLMOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x745AA30", Offset = "0x7459E30", VA = "0x18745AA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x745B760", Offset = "0x745AB60", VA = "0x18745B760")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x745C050", Offset = "0x745B450", VA = "0x18745C050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x745BED0", Offset = "0x745B2D0", VA = "0x18745BED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x94FD70", Offset = "0x94F170", VA = "0x18094FD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x745BEC0", Offset = "0x745B2C0", VA = "0x18745BEC0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MOEKPCINBOK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x745B8B0", Offset = "0x745ACB0", VA = "0x18745B8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EINOPAGHIDM FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x745BD30", Offset = "0x745B130", VA = "0x18745BD30")]
			get
			{
				return default(EINOPAGHIDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x745B780", Offset = "0x745AB80", VA = "0x18745B780")]
		internal void BOOHNMIPGKL(IEnumerable<GlyphCoordinateWritable> DBFKOCJIBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x745B820", Offset = "0x745AC20", VA = "0x18745B820")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x745B800", Offset = "0x745AC00", VA = "0x18745B800")]
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
		[Cpp2IlInjected.Address(RVA = "0x745F4C0", Offset = "0x745E8C0", VA = "0x18745F4C0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x745F470", Offset = "0x745E870", VA = "0x18745F470")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x745F290", Offset = "0x745E690", VA = "0x18745F290")]
		private void LCONJBEFPAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x745F5B0", Offset = "0x745E9B0", VA = "0x18745F5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x745F930", Offset = "0x745ED30", VA = "0x18745F930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JHFOGMCBEON BBGGFHJJMEC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x74600C0", Offset = "0x745F4C0", VA = "0x1874600C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material CIHHENKAAIG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x74600F0", Offset = "0x745F4F0", VA = "0x1874600F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7460020", Offset = "0x745F420", VA = "0x187460020")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x745FCE0", Offset = "0x745F0E0", VA = "0x18745FCE0", Slot = "8")]
		protected override void NILAIJNOCBB(HFOGIEJFOPC IBNPBKKMILL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7460030", Offset = "0x745F430", VA = "0x187460030", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] DPLJMLJHJME NEIKICMADNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x745FED0", Offset = "0x745F2D0", VA = "0x18745FED0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x745F9C0", Offset = "0x745EDC0", VA = "0x18745F9C0")]
		private void LOKJGKEALKB(bool MHOOEDPKADD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x966FD0", Offset = "0x9663D0", VA = "0x180966FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x745C320", Offset = "0x745B720", VA = "0x18745C320")]
	internal AIAGEENPIDL ICLICLMGJHI()
	{
		return default(AIAGEENPIDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2544A50", Offset = "0x2543E50", VA = "0x182544A50")]
	internal JAOGJFMABNJ(JHFOGMCBEON JEIEGFHFIPA, int HGOAHMFIGKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HOFJBFEDNJD
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x745C270", Offset = "0x745B670", VA = "0x18745C270")]
	public static bool IAAFOFHKKKL(this JAOGJFMABNJ FOCJIGDCLCL, GGNBFIFBGCJ MPNEBCJKGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x745C2C0", Offset = "0x745B6C0", VA = "0x18745C2C0")]
	internal static bool IAAFOFHKKKL(this AIAGEENPIDL FGGHMCNAGAP, GGNBFIFBGCJ MPNEBCJKGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x745C2E0", Offset = "0x745B6E0", VA = "0x18745C2E0")]
	public static float JAENAJKNMKL(this JAOGJFMABNJ FOCJIGDCLCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBDA170", Offset = "0xBD9570", VA = "0x180BDA170")]
	internal static float JAENAJKNMKL(this AIAGEENPIDL FGGHMCNAGAP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LBHOKFFEOCN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x745EE60", Offset = "0x745E260", VA = "0x18745EE60")]
	public static void MEDGAEDAALL(this JAOGJFMABNJ FOCJIGDCLCL, ReadOnlySpan<char> PKDBKAKJCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x745EEB0", Offset = "0x745E2B0", VA = "0x18745EEB0")]
	internal static void MEDGAEDAALL(this AIAGEENPIDL FGGHMCNAGAP, ReadOnlySpan<char> PKDBKAKJCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x745ED00", Offset = "0x745E100", VA = "0x18745ED00")]
	public static void HFMJBBKIDLM(this JAOGJFMABNJ KMMBMMCJFLK, float2 EOLPAKBALHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x745ED50", Offset = "0x745E150", VA = "0x18745ED50")]
	internal static void HFMJBBKIDLM(this AIAGEENPIDL FGGHMCNAGAP, float2 EOLPAKBALHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x745ED60", Offset = "0x745E160", VA = "0x18745ED60")]
	public static void HMKJKMPNPJI(this JAOGJFMABNJ KMMBMMCJFLK, float MOJOJKPNJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x745EDD0", Offset = "0x745E1D0", VA = "0x18745EDD0")]
	internal static void HMKJKMPNPJI(this AIAGEENPIDL FGGHMCNAGAP, float MOJOJKPNJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x745F100", Offset = "0x745E500", VA = "0x18745F100")]
	internal static void PBNPBDBBCBB(this AIAGEENPIDL FGGHMCNAGAP, bool EFAINGIJKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x745EE10", Offset = "0x745E210", VA = "0x18745EE10")]
	public static void KEBKKELILPK(this JAOGJFMABNJ KMMBMMCJFLK, Color32 NHCBHMJDLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x745EE50", Offset = "0x745E250", VA = "0x18745EE50")]
	internal static void KEBKKELILPK(this AIAGEENPIDL FGGHMCNAGAP, Color32 NHCBHMJDLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x745F0C0", Offset = "0x745E4C0", VA = "0x18745F0C0")]
	public static void MEGJHFGCLCI(this JAOGJFMABNJ KMMBMMCJFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x745F0B0", Offset = "0x745E4B0", VA = "0x18745F0B0")]
	internal static void MEGJHFGCLCI(this AIAGEENPIDL FGGHMCNAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x745EC70", Offset = "0x745E070", VA = "0x18745EC70")]
	internal static void BDJDONAICEE(this AIAGEENPIDL FGGHMCNAGAP, int PMMBGAHPBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x745ECE0", Offset = "0x745E0E0", VA = "0x18745ECE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9EA0", Offset = "0xAC92A0", VA = "0x180AC9EA0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAC9EB0", Offset = "0xAC92B0", VA = "0x180AC9EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JHFOGMCBEON JFFJMLJKAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7458360", Offset = "0x7457760", VA = "0x187458360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7458680", Offset = "0x7457A80", VA = "0x187458680")]
	public AKBLOBKGODO(int KOHJMPGEGHH, JHFOGMCBEON JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x745A6B0", Offset = "0x7459AB0", VA = "0x18745A6B0")]
	public bool CJBIMDHAPOE([Out] JAOGJFMABNJ FOCJIGDCLCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x745A660", Offset = "0x7459A60", VA = "0x18745A660")]
	public void BHDLIGCHPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74583C0", Offset = "0x74577C0", VA = "0x1874583C0")]
	internal void EHNMFDMKKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74583F0", Offset = "0x74577F0", VA = "0x1874583F0", Slot = "4")]
	public bool Equals(AKBLOBKGODO OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x745A780", Offset = "0x7459B80", VA = "0x18745A780", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x745A840", Offset = "0x7459C40", VA = "0x18745A840", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x745C480", Offset = "0x745B880", VA = "0x18745C480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MOEKPCINBOK NNDKFLKIILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x745D4F0", Offset = "0x745C8F0", VA = "0x18745D4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float GCNCAIJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x745C510", Offset = "0x745B910", VA = "0x18745C510")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CANLBNFGEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x745D0C0", Offset = "0x745C4C0", VA = "0x18745D0C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GCCILAMBMEM.KFPLJMODBDA KODNKAKGCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x94FD90", Offset = "0x94F190", VA = "0x18094FD90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x94FD10", Offset = "0x94F110", VA = "0x18094FD10", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x745D7B0", Offset = "0x745CBB0", VA = "0x18745D7B0")]
	public JHFOGMCBEON(KOJNPOLGOKK HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x745DBF0", Offset = "0x745CFF0", VA = "0x18745DBF0")]
	public JHFOGMCBEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x745C6F0", Offset = "0x745BAF0", VA = "0x18745C6F0")]
	public void CIDIOEOELJF(GlyphMapAsset BGIJFEBPIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x745C5E0", Offset = "0x745B9E0", VA = "0x18745C5E0")]
	public void CIDIOEOELJF(MOEKPCINBOK CPGFCKFAAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x745D510", Offset = "0x745C910", VA = "0x18745D510", Slot = "6")]
	public bool TryGetMeshBuffer([Out] DPLJMLJHJME NEIKICMADNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x745C420", Offset = "0x745B820", VA = "0x18745C420")]
	public void AONHOHNMJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x745D4A0", Offset = "0x745C8A0", VA = "0x18745D4A0")]
	public bool MBGEIMFKCHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x745CAF0", Offset = "0x745BEF0", VA = "0x18745CAF0")]
	public AKBLOBKGODO FFEFMDJFOEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x745D0E0", Offset = "0x745C4E0", VA = "0x18745D0E0")]
	public void LIECJMGBBMF(AKBLOBKGODO JFBBLJCNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x745C530", Offset = "0x745B930", VA = "0x18745C530")]
	internal bool BNIGFBMCAPL(AKBLOBKGODO JFBBLJCNNCF, [Out] JAOGJFMABNJ FOCJIGDCLCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x745CD60", Offset = "0x745C160", VA = "0x18745CD60")]
	private void FMAHHBCJPIB(AIAGEENPIDL FGGHMCNAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x745CEE0", Offset = "0x745C2E0", VA = "0x18745CEE0")]
	private void IBOKMDLPENM(int EEPEDKIKJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x745D440", Offset = "0x745C840", VA = "0x18745D440")]
	private bool LOGJKNHANHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7452920", Offset = "0x7451D20", VA = "0x187452920")]
	private static int NJIBBOLMBJG(AKBLOBKGODO JFBBLJCNNCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1EA2FA0", Offset = "0x1EA23A0", VA = "0x181EA2FA0")]
	private static ushort PACPHPAIGHC(int EAHKFAJBNDN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x745C730", Offset = "0x745BB30", VA = "0x18745C730")]
	private Bounds DJHNIEMNJKI()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x745CA40", Offset = "0x745BE40", VA = "0x18745CA40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x745EA90", Offset = "0x745DE90", VA = "0x18745EA90")]
	internal KOJNPOLGOKK OPJNPGGHPHE()
	{
		return default(KOJNPOLGOKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74555B0", Offset = "0x74549B0", VA = "0x1874555B0")]
	[CompilerGenerated]
	internal static void AHALGBPJOPA(int KBGCCIOIGBD, int IDJBNLNBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x745EA70", Offset = "0x745DE70", VA = "0x18745EA70")]
	[CompilerGenerated]
	internal static void HHIKEJJMLGA(float KBGCCIOIGBD, float IDJBNLNBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74555A0", Offset = "0x74549A0", VA = "0x1874555A0")]
	[CompilerGenerated]
	internal static void JILLCOOLPJD(int KBGCCIOIGBD, int HDOJMOFDDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x745EBA0", Offset = "0x745DFA0", VA = "0x18745EBA0")]
	[CompilerGenerated]
	internal static void PLOELDHDOJG(float KBGCCIOIGBD, float HDOJMOFDDCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CBKJPCJGEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x745A940", Offset = "0x7459D40", VA = "0x18745A940")]
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
		[Cpp2IlInjected.Address(RVA = "0x745F8C0", Offset = "0x745ECC0", VA = "0x18745F8C0")]
		public TextSegmentLayout(LayoutRect layoutRect, AKBLOBKGODO textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x745F690", Offset = "0x745EA90", VA = "0x18745F690")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x745F700", Offset = "0x745EB00", VA = "0x18745F700")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x745F630", Offset = "0x745EA30", VA = "0x18745F630")]
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
	[Cpp2IlInjected.Address(RVA = "0x745AA50", Offset = "0x7459E50", VA = "0x18745AA50")]
	public void CIDIOEOELJF(MOEKPCINBOK JLFKJIMBPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x745AAE0", Offset = "0x7459EE0", VA = "0x18745AAE0")]
	public void CIDIOEOELJF(GlyphUVConfig CGGIEGAPBPG, IEnumerable<EINOPAGHIDM> BGIJFEBPIEJ, EINOPAGHIDM GLLNNCEODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x745AB60", Offset = "0x7459F60", VA = "0x18745AB60")]
	internal void FDDEBKDAJNN(GlyphUVConfig CGGIEGAPBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x745ACA0", Offset = "0x745A0A0", VA = "0x18745ACA0")]
	private void HHAHBCJHFPN(IEnumerable<EINOPAGHIDM> BGIJFEBPIEJ, EINOPAGHIDM GLLNNCEODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x745B1E0", Offset = "0x745A5E0", VA = "0x18745B1E0")]
	public void ILFCDIGNDFF([In] char BDOMIECOLDC, [Out] float2[] HCDPEHGDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74586E0", Offset = "0x7457AE0", VA = "0x1874586E0")]
	private HNLGKBIPALB GMJJJNLPNDC(EINOPAGHIDM IPCDPDKDJJH)
	{
		return default(HNLGKBIPALB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x745B510", Offset = "0x745A910", VA = "0x18745B510")]
	public ENNFLMLFDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FIMCKDMAFED
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x745B610", Offset = "0x745AA10", VA = "0x18745B610")]
	public static void HKPPBNHMHBA([In] float CCJEHMPCADL, [In] float CFDNNCIGFOC, [In] int OJHHEDLFCCN, [In] int AGEHIOOJEKG, [In] float KFFAKDECMBG, [In] float EKCPIKNPDNO, [In] float PHKFKPIHCDA, [In] float KFLDDMEGODF, [In] float LDDLLOGFOMN, [In] float EFKNBGOEJIM, [Out] float FEDBPJBMDNP, [Out] float FDKNECEICDD, [Out] float ALDCCGHOPHP, [Out] float AGNOEFFKJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x745B6E0", Offset = "0x745AAE0", VA = "0x18745B6E0")]
	public static void HKPPBNHMHBA([In] float CCJEHMPCADL, [In] float CFDNNCIGFOC, [In] int OJHHEDLFCCN, [In] int AGEHIOOJEKG, [Out] float FEDBPJBMDNP, [Out] float FDKNECEICDD, [Out] float ALDCCGHOPHP, [Out] float AGNOEFFKJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x745B5B0", Offset = "0x745A9B0", VA = "0x18745B5B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x745B740", Offset = "0x745AB40", VA = "0x18745B740")]
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
	[Cpp2IlInjected.Address(RVA = "0x745C180", Offset = "0x745B580", VA = "0x18745C180")]
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
	[Cpp2IlInjected.Address(RVA = "0x745A650", Offset = "0x7459A50", VA = "0x18745A650")]
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
	[Cpp2IlInjected.Address(RVA = "0x745C360", Offset = "0x745B760", VA = "0x18745C360")]
	internal static float COIGFMEGLIO(this AIAGEENPIDL FGGHMCNAGAP, float FPDMBBDPGAP, float OELODCPJEAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x745C3A0", Offset = "0x745B7A0", VA = "0x18745C3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x745E960", Offset = "0x745DD60", VA = "0x18745E960")]
	public JNPEJNELMNG(DPLJMLJHJME.OIHDIJPCFLG LCIHIEFOOGM, int MEDGMDFBMLK, int LFINLOAPPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x745E7D0", Offset = "0x745DBD0", VA = "0x18745E7D0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] DPLJMLJHJME NEIKICMADNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x745E660", Offset = "0x745DA60", VA = "0x18745E660")]
	public void NNGIPMDJCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x745DE80", Offset = "0x745D280", VA = "0x18745DE80")]
	public void JNFGBNAEICD(Span<AIAGEENPIDL> JOAJEMCIEEO, ENNFLMLFDEJ CIAGOOEFABB, [In] KOJNPOLGOKK HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7458AC0", Offset = "0x7457EC0", VA = "0x187458AC0")]
	private void DCGIDGNEAPK([In] GGNBFIFBGCJ KBFAGFOEACK, [In] AIAGEENPIDL MFIJNAMKJGP, int CMFFMBKPOCF, [In] float FPDMBBDPGAP, [In] float OELODCPJEAN, ENNFLMLFDEJ CIAGOOEFABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x745E680", Offset = "0x745DA80", VA = "0x18745E680")]
	private void PACHEJDMLHB([In] GGNBFIFBGCJ KBFAGFOEACK, AIAGEENPIDL MFIJNAMKJGP, [In] int HACKIBNIMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x745DC70", Offset = "0x745D070", VA = "0x18745DC70")]
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
