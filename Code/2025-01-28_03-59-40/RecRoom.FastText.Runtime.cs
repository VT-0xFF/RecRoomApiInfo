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
public class CEDDKCMNEMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D IIEKKHKNNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig GLLBNEACIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public CBGLBBEDGJG[] OCDNJPILPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public CBGLBBEDGJG JJKBBIEALPP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static CEDDKCMNEMD JGCIDOEAGOL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CEDDKCMNEMD KHMPBGOHCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7219B20", Offset = "0x7218D20", VA = "0x187219B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public CEDDKCMNEMD()
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
		[Cpp2IlInjected.Address(RVA = "0x721C510", Offset = "0x721B710", VA = "0x18721C510")]
		public GlyphUVConfig(int JCDJKPBMLIK, int EKFIELJHHOL, int LMBIOOFOFAH, int FMNPIFPNEKD, float DHEAJBILMHB = 0f, [Optional] GlyphPixelInset ENGFDIBHFIM)
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
public readonly struct CBGLBBEDGJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char NBBBJKJNCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int JDKJHMPJOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int KANBMOHIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly CBGLBBEDGJG FPEFLPJHLFK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7219B10", Offset = "0x7218D10", VA = "0x187219B10")]
	public CBGLBBEDGJG(char EBGPFGGEJAA, int BDPFNHHJKLJ, int GJNCBIPAGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7219AF0", Offset = "0x7218CF0", VA = "0x187219AF0")]
	public CBGLBBEDGJG(GlyphCoordinateWritable DGFFBDOMFPF)
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
		[Cpp2IlInjected.Address(RVA = "0x721BB20", Offset = "0x721AD20", VA = "0x18721BB20")]
		public static CBGLBBEDGJG KEDBNOKLEHE(GlyphCoordinateWritable FDEJAKKFLHE)
		{
			return default(CBGLBBEDGJG);
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
		private CEDDKCMNEMD configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x721C410", Offset = "0x721B610", VA = "0x18721C410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x721C290", Offset = "0x721B490", VA = "0x18721C290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x721C280", Offset = "0x721B480", VA = "0x18721C280")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CEDDKCMNEMD ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x721BC70", Offset = "0x721AE70", VA = "0x18721BC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CBGLBBEDGJG FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x721C0F0", Offset = "0x721B2F0", VA = "0x18721C0F0")]
			get
			{
				return default(CBGLBBEDGJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x721BB60", Offset = "0x721AD60", VA = "0x18721BB60")]
		internal void MPDFKCINCJD(IEnumerable<GlyphCoordinateWritable> MEDLDJJCAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x721BBE0", Offset = "0x721ADE0", VA = "0x18721BBE0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x721BB40", Offset = "0x721AD40", VA = "0x18721BB40")]
		[CompilerGenerated]
		private bool MMNMELIFNHF(GlyphCoordinateWritable FDEJAKKFLHE)
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
		private TextSegmentMeshBufferSource KBIHNOFPBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DKIEIDEMIME JCEPAKELEJL;

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
		private PHHENJEBABO AIDDAJJMPDN;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x721E6A0", Offset = "0x721D8A0", VA = "0x18721E6A0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x721E650", Offset = "0x721D850", VA = "0x18721E650")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x721E490", Offset = "0x721D690", VA = "0x18721E490")]
		private void EAFJDIKKJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x721E790", Offset = "0x721D990", VA = "0x18721E790")]
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
		private bool INBDCPCEGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material MNBPJPLPKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private DKIEIDEMIME JCEPAKELEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material MOJLFPBNAAK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private CEDDKCMNEMD EDLPJLGJCAE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x721EE30", Offset = "0x721E030", VA = "0x18721EE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DKIEIDEMIME ONACFFFPAGL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x721F280", Offset = "0x721E480", VA = "0x18721F280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material DGCGMJFBAPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x721F2B0", Offset = "0x721E4B0", VA = "0x18721F2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x721F1E0", Offset = "0x721E3E0", VA = "0x18721F1E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x721EEC0", Offset = "0x721E0C0", VA = "0x18721EEC0", Slot = "8")]
		protected override void IIDFCIHJGKM(BHODPMLBBNM BNHHBNKBFLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x721F1F0", Offset = "0x721E3F0", VA = "0x18721F1F0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] CHOKIGCPKKG ELEJMEELIOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x721F090", Offset = "0x721E290", VA = "0x18721F090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x721EB10", Offset = "0x721DD10", VA = "0x18721EB10")]
		private void ACJFOEIJONF(bool DCOODACAFGM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x90FE00", Offset = "0x90F000", VA = "0x18090FE00")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct EGAHBMBIDAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly DKIEIDEMIME HKNEEBIIEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int MJFJMJLPJLO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x721B6E0", Offset = "0x721A8E0", VA = "0x18721B6E0")]
	internal JFFKOENLDBH BIBJFJIOLMA()
	{
		return default(JFFKOENLDBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2505820", Offset = "0x2504A20", VA = "0x182505820")]
	internal EGAHBMBIDAB(DKIEIDEMIME ODPBGAGOMOC, int BOIOODHOPDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class COPFNGCAOHF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7219D00", Offset = "0x7218F00", VA = "0x187219D00")]
	public static bool NGBFLOICNGC(this EGAHBMBIDAB IOJJDKDBPKO, LDOKHBKAMDC DILCNGBOOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7219CE0", Offset = "0x7218EE0", VA = "0x187219CE0")]
	internal static bool NGBFLOICNGC(this JFFKOENLDBH JKGDNNCLOFM, LDOKHBKAMDC DILCNGBOOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7219CA0", Offset = "0x7218EA0", VA = "0x187219CA0")]
	public static float EOJDLCIDNDP(this EGAHBMBIDAB IOJJDKDBPKO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBCFDE0", Offset = "0xBCEFE0", VA = "0x180BCFDE0")]
	internal static float EOJDLCIDNDP(this JFFKOENLDBH JKGDNNCLOFM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EMLJHAGCIDO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7217C30", Offset = "0x7216E30", VA = "0x187217C30")]
	public static void FMCONNMBFHJ(this EGAHBMBIDAB IOJJDKDBPKO, ReadOnlySpan<char> FEFAFPHDPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x721B800", Offset = "0x721AA00", VA = "0x18721B800")]
	internal static void FMCONNMBFHJ(this JFFKOENLDBH JKGDNNCLOFM, ReadOnlySpan<char> FEFAFPHDPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x721B9A0", Offset = "0x721ABA0", VA = "0x18721B9A0")]
	public static void JMJAHDOPINH(this EGAHBMBIDAB CHBDJAIOLMG, float2 BONCOICAIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x721B9F0", Offset = "0x721ABF0", VA = "0x18721B9F0")]
	internal static void JMJAHDOPINH(this JFFKOENLDBH JKGDNNCLOFM, float2 BONCOICAIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x721B950", Offset = "0x721AB50", VA = "0x18721B950")]
	public static void IMGGFPFJHFA(this EGAHBMBIDAB CHBDJAIOLMG, float CKIHIFFKFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x721B990", Offset = "0x721AB90", VA = "0x18721B990")]
	internal static void IMGGFPFJHFA(this JFFKOENLDBH JKGDNNCLOFM, float CKIHIFFKFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x721BA00", Offset = "0x721AC00", VA = "0x18721BA00")]
	internal static void KHALAHMCHPO(this JFFKOENLDBH JKGDNNCLOFM, bool BPPBNACLBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x721BA10", Offset = "0x721AC10", VA = "0x18721BA10")]
	public static void ODKFIKLPJFB(this EGAHBMBIDAB CHBDJAIOLMG, Color32 HCHFCFNLIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x721BA50", Offset = "0x721AC50", VA = "0x18721BA50")]
	internal static void ODKFIKLPJFB(this JFFKOENLDBH JKGDNNCLOFM, Color32 HCHFCFNLIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x721B730", Offset = "0x721A930", VA = "0x18721B730")]
	public static void CGKBMIGDFAN(this EGAHBMBIDAB CHBDJAIOLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x721B720", Offset = "0x721A920", VA = "0x18721B720")]
	internal static void CGKBMIGDFAN(this JFFKOENLDBH JKGDNNCLOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x721B770", Offset = "0x721A970", VA = "0x18721B770")]
	internal static void EEGAENEAALL(this JFFKOENLDBH JKGDNNCLOFM, int HBNACLOFIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x721B7E0", Offset = "0x721A9E0", VA = "0x18721B7E0")]
	internal static void EODOFGIMNCM(this JFFKOENLDBH JKGDNNCLOFM, int PEKBMFIPJDB, LDOKHBKAMDC IFDALMDPGEO = LDOKHBKAMDC.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PHHENJEBABO : IEquatable<PHHENJEBABO>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort KMBPJBIIMDN = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int FIMOLEBIKOA = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly PHHENJEBABO PECELMAPCIN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort HBBDBNJAMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAFB220", Offset = "0xAFA420", VA = "0x180AFB220")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAFB230", Offset = "0xAFA430", VA = "0x180AFB230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DKIEIDEMIME HKNEEBIIEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CLGLGAODANF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7211D50", Offset = "0x7210F50", VA = "0x187211D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7212070", Offset = "0x7211270", VA = "0x187212070")]
	public PHHENJEBABO(int BLHCJLCNADA, DKIEIDEMIME ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x721D780", Offset = "0x721C980", VA = "0x18721D780")]
	public bool KJIELHGGAPF([Out] EGAHBMBIDAB IOJJDKDBPKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x721D850", Offset = "0x721CA50", VA = "0x18721D850")]
	public void OIHANPNKAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7211EF0", Offset = "0x72110F0", VA = "0x187211EF0")]
	internal void NAHOMJAALLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7211E20", Offset = "0x7211020", VA = "0x187211E20", Slot = "4")]
	public bool Equals(PHHENJEBABO JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x721D650", Offset = "0x721C850", VA = "0x18721D650", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x721D710", Offset = "0x721C910", VA = "0x18721D710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DKIEIDEMIME : IDisposable, GMCIEAGOLMI
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string PMLLDBHKNAC = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker HGOIIHPJIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string DKGFFMOHGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly OGNNFNBAKDI BPOBBBJPLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int GKHEOOPOBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal JFFKOENLDBH[] DGKBLOEIMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal PHHENJEBABO[] ALPBIEJNPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private CEDDKCMNEMD KIHILIFLGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PJENMGFKOGD BKKLELFIIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly KJHHKOEEKAB CHJNJCDPDCL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string LMOANCJLHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x721A300", Offset = "0x7219500", VA = "0x18721A300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public CEDDKCMNEMD HEMDACBCNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x721A7F0", Offset = "0x72199F0", VA = "0x18721A7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float PPIGMEKJHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x721A9C0", Offset = "0x7219BC0", VA = "0x18721A9C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float GFIGJNKOJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7219EE0", Offset = "0x72190E0", VA = "0x187219EE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GMCIEAGOLMI.PMAIPDCGJGC JFDGMOCMIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8F2210", Offset = "0x8F1410", VA = "0x1808F2210", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8F2240", Offset = "0x8F1440", VA = "0x1808F2240", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x721B2A0", Offset = "0x721A4A0", VA = "0x18721B2A0")]
	public DKIEIDEMIME(OGNNFNBAKDI LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x721B220", Offset = "0x721A420", VA = "0x18721B220")]
	public DKIEIDEMIME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x721A390", Offset = "0x7219590", VA = "0x18721A390")]
	public void MDPAGNEJHAM(GlyphMapAsset KLNKKAHOCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x721A3D0", Offset = "0x72195D0", VA = "0x18721A3D0")]
	public void MDPAGNEJHAM(CEDDKCMNEMD IJOPOJOLDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x721AF80", Offset = "0x721A180", VA = "0x18721AF80", Slot = "6")]
	public bool TryGetMeshBuffer([Out] CHOKIGCPKKG ELEJMEELIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x721A2A0", Offset = "0x72194A0", VA = "0x18721A2A0")]
	public void FENBJLDJACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x721A9E0", Offset = "0x7219BE0", VA = "0x18721A9E0")]
	public bool PBAKDIADHHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7219F00", Offset = "0x7219100", VA = "0x187219F00")]
	public PHHENJEBABO ALDGCEHGBEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x721AC10", Offset = "0x7219E10", VA = "0x18721AC10")]
	public void PLGGKFKGBDN(PHHENJEBABO KPMNDLLLJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x721A140", Offset = "0x7219340", VA = "0x18721A140")]
	internal bool CNNIIAOPAMD(PHHENJEBABO KPMNDLLLJNJ, [Out] EGAHBMBIDAB IOJJDKDBPKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x721A870", Offset = "0x7219A70", VA = "0x18721A870")]
	private void NNGKIJHKDBK(JFFKOENLDBH JKGDNNCLOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x721AA30", Offset = "0x7219C30", VA = "0x18721AA30")]
	private void PJEPIALFGFK(int HMLBKIOHDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x721A810", Offset = "0x7219A10", VA = "0x18721A810")]
	private bool NKMHDMLOLHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7216A60", Offset = "0x7215C60", VA = "0x187216A60")]
	private static int FIAODPKGOGG(PHHENJEBABO KPMNDLLLJNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E835F0", Offset = "0x1E827F0", VA = "0x181E835F0")]
	private static ushort MKOKJPMDOPA(int CPLNODNGKGB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x721A4E0", Offset = "0x72196E0", VA = "0x18721A4E0")]
	private Bounds NBNBFNOPCCJ()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x721A1F0", Offset = "0x72193F0", VA = "0x18721A1F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OGNNFNBAKDI
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly OGNNFNBAKDI IANOBKBCECM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float AHIMIJHNFEF = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int HOAEAJPHNPP = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int NJJELOEKMAD = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color HOOOEKHNENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float HFEOLDFEPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int CLLEDKODMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int KDCMOHKODLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int LEGMDNJLJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int BOBIFJPOFEM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x721D470", Offset = "0x721C670", VA = "0x18721D470")]
	internal OGNNFNBAKDI GBGAFBGBPPP()
	{
		return default(OGNNFNBAKDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7212B60", Offset = "0x7211D60", VA = "0x187212B60")]
	[CompilerGenerated]
	internal static void GNOBEHOEMMA(int OMEFCJCOLII, int JEBHMGJFPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x721D580", Offset = "0x721C780", VA = "0x18721D580")]
	[CompilerGenerated]
	internal static void PPIGNAPCKKI(float OMEFCJCOLII, float JEBHMGJFPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7212B50", Offset = "0x7211D50", VA = "0x187212B50")]
	[CompilerGenerated]
	internal static void FKCJIIDNMAC(int OMEFCJCOLII, int MFJGHLPNBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x721D450", Offset = "0x721C650", VA = "0x18721D450")]
	[CompilerGenerated]
	internal static void DGLCFEEPGKL(float OMEFCJCOLII, float MFJGHLPNBFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KKPGKBPMBLK
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x721D2B0", Offset = "0x721C4B0", VA = "0x18721D2B0")]
	public static float PEBEBLNPMBJ(this EGAHBMBIDAB ICAEBBLAGIL)
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
		public readonly PHHENJEBABO textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x721EAA0", Offset = "0x721DCA0", VA = "0x18721EAA0")]
		public TextSegmentLayout(LayoutRect layoutRect, PHHENJEBABO textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x721E870", Offset = "0x721DA70", VA = "0x18721E870")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x721E8E0", Offset = "0x721DAE0", VA = "0x18721E8E0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x721E810", Offset = "0x721DA10", VA = "0x18721E810")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class PJENMGFKOGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig BDCFDLBGCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float AFCJBIHBJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float LJGPDJAHIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float ICHBEFOKGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float IINFFMGADCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float PHFNALLBJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float AGNNAACKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float BOKHNHKKAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float HMKOBGJCLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float AOMAPNOBMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float GFIGJNKOJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float MFLOLKIIPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float PPIGMEKJHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LEECEIFBDMA[] DAAOAJHIMCE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int DBKKEHEAMJK = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private LFEGDIFOMEH[] FBAJOLCGKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int BMKKKBHMDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private CBGLBBEDGJG[] IHLGAMEMIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int EBLJNIOPCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public LEECEIFBDMA NPFGJAINMDN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x721E220", Offset = "0x721D420", VA = "0x18721E220")]
	public void MDPAGNEJHAM(CEDDKCMNEMD DOBCFFCPIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x721E1A0", Offset = "0x721D3A0", VA = "0x18721E1A0")]
	public void MDPAGNEJHAM(GlyphUVConfig JNHCCABGBOH, IEnumerable<CBGLBBEDGJG> KLNKKAHOCAI, CBGLBBEDGJG MLHMHHLHOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x721E2B0", Offset = "0x721D4B0", VA = "0x18721E2B0")]
	internal void MFEDCAPEENN(GlyphUVConfig JNHCCABGBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x721D930", Offset = "0x721CB30", VA = "0x18721D930")]
	private void AANGEHFNCMN(IEnumerable<CBGLBBEDGJG> KLNKKAHOCAI, CBGLBBEDGJG MLHMHHLHOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x721DE70", Offset = "0x721D070", VA = "0x18721DE70")]
	public void ADIJPLAKJAN([In] char EBGPFGGEJAA, [Out] float2[] JBMFLMAJIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72199F0", Offset = "0x7218BF0", VA = "0x1872199F0")]
	private LEECEIFBDMA PDAMIHBLAID(CBGLBBEDGJG DGFFBDOMFPF)
	{
		return default(LEECEIFBDMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x721E3F0", Offset = "0x721D5F0", VA = "0x18721E3F0")]
	public PJENMGFKOGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DJMKHGACALM
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7219DB0", Offset = "0x7218FB0", VA = "0x187219DB0")]
	public static void OGMBDMFEKEG([In] float JNOHMNIOOEH, [In] float ENGNFDDHKCC, [In] int LGDCPEKFCDD, [In] int GLAEOGNLIGF, [In] float IINFFMGADCI, [In] float PHFNALLBJBN, [In] float OOHALGKJKNN, [In] float FBADEHPAMDE, [In] float APFNCGACJLI, [In] float DDGOCPHLIMD, [Out] float NEOBJAONOGB, [Out] float KNCEBDOPBOM, [Out] float PBJPPKFMLLB, [Out] float JPIJCNEIOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7219E80", Offset = "0x7219080", VA = "0x187219E80")]
	public static void OGMBDMFEKEG([In] float JNOHMNIOOEH, [In] float ENGNFDDHKCC, [In] int LGDCPEKFCDD, [In] int GLAEOGNLIGF, [Out] float NEOBJAONOGB, [Out] float KNCEBDOPBOM, [Out] float PBJPPKFMLLB, [Out] float JPIJCNEIOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7219D50", Offset = "0x7218F50", VA = "0x187219D50")]
	public static void BINJHJBDKLH([In] float IINFFMGADCI, [In] float PHFNALLBJBN, [In] float LMDDLCKNNMF, [In] float BAKLAGFPBMD, [In] float HIMOAEJEPIN, [In] float DGKIFDMGHNC, [Out] float OHADMFEBKBC, [Out] float EDAGCEOIHNB, [Out] float ALPLDMPDJGL, [Out] float DINOMMHEBPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct LFEGDIFOMEH
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint CBPJODJKLBM = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char NBBBJKJNCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly LEECEIFBDMA LKDPIJCJEGP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x721D430", Offset = "0x721C630", VA = "0x18721D430")]
	public LFEGDIFOMEH(char EBGPFGGEJAA, LEECEIFBDMA JBMFLMAJIFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LEECEIFBDMA
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint CBPJODJKLBM = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] JJEGLJGFAIC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x721D340", Offset = "0x721C540", VA = "0x18721D340")]
	public LEECEIFBDMA(float NEOBJAONOGB, float KNCEBDOPBOM, float PBJPPKFMLLB, float JPIJCNEIOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct JFFKOENLDBH
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int ENOGACNBJKG = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal LDOKHBKAMDC IFDALMDPGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] OANILAFEPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int DDENKGBEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 BONCOICAIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float DJOHJKDPECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 HICAFOANJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool BPPBNACLBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int CKFNLAMLAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int HJDJMOAJKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int GBKEPNELGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int PBICJIEGBNL;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x721C540", Offset = "0x721B740", VA = "0x18721C540")]
	public static int DBOBGFDFANG(int DODJEFMOHGC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum LDOKHBKAMDC : byte
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
public static class FHNCMJCNHFM
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x721BAE0", Offset = "0x721ACE0", VA = "0x18721BAE0")]
	internal static float PEBEBLNPMBJ(this JFFKOENLDBH JKGDNNCLOFM, float LPFHGODIMPO, float NMEHKGNHNBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x721BA60", Offset = "0x721AC60", VA = "0x18721BA60")]
	internal static void ADHOLPCJLFL(this JFFKOENLDBH JKGDNNCLOFM, float LPFHGODIMPO, float NMEHKGNHNBD, [Out] float2 KKNLKEIKANG, [Out] float2 HEMGJLGOHMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class KJHHKOEEKAB : GMCIEAGOLMI
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int KBABGAAEGNP = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int OGIECHMCEEB = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string PMLLDBHKNAC = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static NHMMMDNJCLE CNBGKJLMDFO;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static NHMMMDNJCLE NDIIJNEDGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static NHMMMDNJCLE IGLGFCPPDIA;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static NHMMMDNJCLE FBFOPPBCBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly CHOKIGCPKKG ELEJMEELIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] MFIFFOBOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] PEAKDJJODMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int IDAMDNIPBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int CFIMDBJOGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int FHNEHAGMKLE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string LMOANCJLHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GMCIEAGOLMI.PMAIPDCGJGC JFDGMOCMIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x721D1A0", Offset = "0x721C3A0", VA = "0x18721D1A0")]
	public KJHHKOEEKAB(CHOKIGCPKKG.OBHBGKCDKAC GPDGDGGFFCJ, int OBENNEOBICD, int MHBBKDOFMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x721D010", Offset = "0x721C210", VA = "0x18721D010", Slot = "5")]
	public bool TryGetMeshBuffer([Out] CHOKIGCPKKG ELEJMEELIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x721CCD0", Offset = "0x721BED0", VA = "0x18721CCD0")]
	public void KKIJBFDCOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x721C550", Offset = "0x721B750", VA = "0x18721C550")]
	public void JGADFMIHFPO(Span<JFFKOENLDBH> FOHBLNLPKMI, PJENMGFKOGD NINGJJICIHO, [In] OGNNFNBAKDI LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7217DD0", Offset = "0x7216FD0", VA = "0x187217DD0")]
	private void FLPGMEAJENL([In] LDOKHBKAMDC IFDALMDPGEO, [In] JFFKOENLDBH OPLMFJJMMHI, int OGELAJKHKPJ, [In] float LPFHGODIMPO, [In] float NMEHKGNHNBD, PJENMGFKOGD NINGJJICIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x721CEC0", Offset = "0x721C0C0", VA = "0x18721CEC0")]
	private void NFOMMPJDHAM([In] LDOKHBKAMDC IFDALMDPGEO, JFFKOENLDBH OPLMFJJMMHI, [In] int NEMLHEDAGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x721CCF0", Offset = "0x721BEF0", VA = "0x18721CCF0")]
	public static void MCCJEHJDDNJ(ReadOnlySpan<JFFKOENLDBH> FOHBLNLPKMI, int JHKKLCCCLEK, [Out] int BGHIAIMNFLM, [Out] int KGKPHCEFEMM, [Out] int BHJHNAFPOBG)
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
