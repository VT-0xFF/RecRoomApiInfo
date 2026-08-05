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
public class NIPPEPHEDAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D EIGINNADFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig JFGNIIPEFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public CGAGIAOMOBD[] HCJOGIPOIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public CGAGIAOMOBD PEIFJHGAHAO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static NIPPEPHEDAK LPHIPPJCLDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NIPPEPHEDAK GHKIBJCNJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CB00", Offset = "0x6D4BF00", VA = "0x186D4CB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public NIPPEPHEDAK()
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
		[Cpp2IlInjected.Address(RVA = "0x6D4C3B0", Offset = "0x6D4B7B0", VA = "0x186D4C3B0")]
		public GlyphUVConfig(int DHJBIFMPMEF, int AKPALDCLEEP, int KHIOIKHDOIJ, int KDJHJDGEFNB, float BOCALCEBOBN = 0f, [Optional] GlyphPixelInset LGCBKDPKGPP)
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
public readonly struct CGAGIAOMOBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char MNGKFJLEPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int PGCGHOPKLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int JMFNDBKNCLI;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly CGAGIAOMOBD IHEBKPMKNDI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D483B0", Offset = "0x6D477B0", VA = "0x186D483B0")]
	public CGAGIAOMOBD(char KCCMBOFEFPE, int LLOAFHOPJMC, int PKIDLLFBIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D48390", Offset = "0x6D47790", VA = "0x186D48390")]
	public CGAGIAOMOBD(GlyphCoordinateWritable ANNMGKJPJOH)
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
		[Cpp2IlInjected.Address(RVA = "0x6D4B9C0", Offset = "0x6D4ADC0", VA = "0x186D4B9C0")]
		public static CGAGIAOMOBD NMFIIIJGOAJ(GlyphCoordinateWritable JPCJICGNBND)
		{
			return default(CGAGIAOMOBD);
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
		private NIPPEPHEDAK configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6D4C2B0", Offset = "0x6D4B6B0", VA = "0x186D4C2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6D4C130", Offset = "0x6D4B530", VA = "0x186D4C130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x89D950", Offset = "0x89CD50", VA = "0x18089D950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6D4C120", Offset = "0x6D4B520", VA = "0x186D4C120")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NIPPEPHEDAK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6D4BB10", Offset = "0x6D4AF10", VA = "0x186D4BB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CGAGIAOMOBD FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D4BF90", Offset = "0x6D4B390", VA = "0x186D4BF90")]
			get
			{
				return default(CGAGIAOMOBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D4BA00", Offset = "0x6D4AE00", VA = "0x186D4BA00")]
		internal void JMKDDGAPGIN(IEnumerable<GlyphCoordinateWritable> GELAIEJOOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D4BA80", Offset = "0x6D4AE80", VA = "0x186D4BA80")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D4B9E0", Offset = "0x6D4ADE0", VA = "0x186D4B9E0")]
		[CompilerGenerated]
		private bool FEJMCGPJMAG(GlyphCoordinateWritable JPCJICGNBND)
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
		private TextSegmentMeshBufferSource DDLJEGBFLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private GEIIMOHGFPH OEJPJKFEDDF;

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
		private FGHHLCFNDAG JEBKMLCALFJ;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE90", Offset = "0x6D4C290", VA = "0x186D4CE90")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE40", Offset = "0x6D4C240", VA = "0x186D4CE40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CC80", Offset = "0x6D4C080", VA = "0x186D4CC80")]
		private void DIFMHNMNJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CF80", Offset = "0x6D4C380", VA = "0x186D4CF80")]
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
		private bool BBODFKMBMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material HDONEMEAKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private GEIIMOHGFPH OEJPJKFEDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material EBODIECPAFN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private NIPPEPHEDAK JLFHADKINJA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6D4D300", Offset = "0x6D4C700", VA = "0x186D4D300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GEIIMOHGFPH GLLNAGEMBFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6D4DA80", Offset = "0x6D4CE80", VA = "0x186D4DA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material AFFNIAFCNIM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6D4DAB0", Offset = "0x6D4CEB0", VA = "0x186D4DAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D9E0", Offset = "0x6D4CDE0", VA = "0x186D4D9E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D6B0", Offset = "0x6D4CAB0", VA = "0x186D4D6B0", Slot = "8")]
		protected override void JGNFJFPOKKK(LALFALEIMHN GIHLBJLMPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D9F0", Offset = "0x6D4CDF0", VA = "0x186D4D9F0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] GJNLCOPHDFI MMLFCJKOJIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D890", Offset = "0x6D4CC90", VA = "0x186D4D890")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D390", Offset = "0x6D4C790", VA = "0x186D4D390")]
		private void JABEGHKIANO(bool DLFLBGAHCIJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FD0", Offset = "0x8B73D0", VA = "0x1808B7FD0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct HOPBBBMDCNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly GEIIMOHGFPH DNBHLHJMBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int POEOJBOEMII;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C3E0", Offset = "0x6D4B7E0", VA = "0x186D4C3E0")]
	internal EHDNHKKBMJA JOPDJKCDCNB()
	{
		return default(EHDNHKKBMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2261EC0", Offset = "0x22612C0", VA = "0x182261EC0")]
	internal HOPBBBMDCNP(GEIIMOHGFPH EGAKDMHOMDJ, int KMEEAEAKHJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LGONBIOBEAK
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C870", Offset = "0x6D4BC70", VA = "0x186D4C870")]
	public static bool DJMEOOBEEPN(this HOPBBBMDCNP LIHCCJHEDIA, GOKAJENKIIP PKEMOKHBOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C850", Offset = "0x6D4BC50", VA = "0x186D4C850")]
	internal static bool DJMEOOBEEPN(this EHDNHKKBMJA KDNIEKHICNM, GOKAJENKIIP PKEMOKHBOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C8C0", Offset = "0x6D4BCC0", VA = "0x186D4C8C0")]
	public static float EPEENKMAAOC(this HOPBBBMDCNP LIHCCJHEDIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBD2900", Offset = "0xBD1D00", VA = "0x180BD2900")]
	internal static float EPEENKMAAOC(this EHDNHKKBMJA KDNIEKHICNM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JCHADPNBAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D47FA0", Offset = "0x6D473A0", VA = "0x186D47FA0")]
	public static void GNMJJFDBPHG(this HOPBBBMDCNP LIHCCJHEDIA, ReadOnlySpan<char> OHHJNHHMOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C630", Offset = "0x6D4BA30", VA = "0x186D4C630")]
	internal static void GNMJJFDBPHG(this EHDNHKKBMJA KDNIEKHICNM, ReadOnlySpan<char> OHHJNHHMOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C590", Offset = "0x6D4B990", VA = "0x186D4C590")]
	public static void BLNHGLOHMCK(this HOPBBBMDCNP FOLDJDLOICN, float2 LBNJPIHINGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C580", Offset = "0x6D4B980", VA = "0x186D4C580")]
	internal static void BLNHGLOHMCK(this EHDNHKKBMJA KDNIEKHICNM, float2 LBNJPIHINGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C780", Offset = "0x6D4BB80", VA = "0x186D4C780")]
	public static void HBBGONFNJKD(this HOPBBBMDCNP FOLDJDLOICN, float LNKDOIMPOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C7C0", Offset = "0x6D4BBC0", VA = "0x186D4C7C0")]
	internal static void HBBGONFNJKD(this EHDNHKKBMJA KDNIEKHICNM, float LNKDOIMPOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C7D0", Offset = "0x6D4BBD0", VA = "0x186D4C7D0")]
	internal static void LGLLGLOMKAJ(this EHDNHKKBMJA KDNIEKHICNM, bool BJEBIGCHCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C800", Offset = "0x6D4BC00", VA = "0x186D4C800")]
	public static void NJNHHHAKPIM(this HOPBBBMDCNP FOLDJDLOICN, Color32 FKCCOIADMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C840", Offset = "0x6D4BC40", VA = "0x186D4C840")]
	internal static void NJNHHHAKPIM(this EHDNHKKBMJA KDNIEKHICNM, Color32 FKCCOIADMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C5F0", Offset = "0x6D4B9F0", VA = "0x186D4C5F0")]
	public static void CDAJALGKBFG(this HOPBBBMDCNP FOLDJDLOICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C5E0", Offset = "0x6D4B9E0", VA = "0x186D4C5E0")]
	internal static void CDAJALGKBFG(this EHDNHKKBMJA KDNIEKHICNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C510", Offset = "0x6D4B910", VA = "0x186D4C510")]
	internal static void BBCNLBKJPMM(this EHDNHKKBMJA KDNIEKHICNM, int GIMBJFFICPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C7E0", Offset = "0x6D4BBE0", VA = "0x186D4C7E0")]
	internal static void MLFBBNLLAJO(this EHDNHKKBMJA KDNIEKHICNM, int CKCHPNNAELO, GOKAJENKIIP KBFHDKGGKHB = GOKAJENKIIP.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FGHHLCFNDAG : IEquatable<FGHHLCFNDAG>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort MPMNEGAGFCL = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int BOLNPIGHPKG = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly FGHHLCFNDAG BFKENMJANNP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort EFDMPABAPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2061550", Offset = "0x2060950", VA = "0x182061550")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2061560", Offset = "0x2060960", VA = "0x182061560")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GEIIMOHGFPH DNBHLHJMBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KIGAEJLFEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3FD70", Offset = "0x6D3F170", VA = "0x186D3FD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3FE40", Offset = "0x6D3F240", VA = "0x186D3FE40")]
	public FGHHLCFNDAG(int GAPHHMDACIP, GEIIMOHGFPH EGAKDMHOMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D490B0", Offset = "0x6D484B0", VA = "0x186D490B0")]
	public bool MOBPGMPHCHM([Out] HOPBBBMDCNP LIHCCJHEDIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D48F30", Offset = "0x6D48330", VA = "0x186D48F30")]
	public void AFNCKMDLBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3FD80", Offset = "0x6D3F180", VA = "0x186D3FD80")]
	internal void LPAHKLGCMKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3FC30", Offset = "0x6D3F030", VA = "0x186D3FC30", Slot = "4")]
	public bool Equals(FGHHLCFNDAG OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D48F80", Offset = "0x6D48380", VA = "0x186D48F80", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D49040", Offset = "0x6D48440", VA = "0x186D49040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GEIIMOHGFPH : IDisposable, BGAGFHIJMOD
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string AGFFMBGHIBJ = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker MNAECOKINKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string IMHMDEMEMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly BJAGKBEKNLC FGCJKMEBGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int OIMLJPCIGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal EHDNHKKBMJA[] AKECGCGILEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FGHHLCFNDAG[] IJJFHBKMFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NIPPEPHEDAK APKHKABEAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ELFMPEICEPJ IOFGNPGANHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly GHFEFLPBJIH BGDCNOHGCAF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string ACDGEPBIBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D49E00", Offset = "0x6D49200", VA = "0x186D49E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MGBLJDDBMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B9630", Offset = "0x8B8A30", VA = "0x1808B9630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NIPPEPHEDAK PGKANDMGKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A270", Offset = "0x6D49670", VA = "0x186D4A270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float KPEBFCDNMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D49870", Offset = "0x6D48C70", VA = "0x186D49870")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JECLHNPELLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D4A290", Offset = "0x6D49690", VA = "0x186D4A290")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public BGAGFHIJMOD.JGPPNPDKIOH EMJOJFBFPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89D980", Offset = "0x89CD80", VA = "0x18089D980", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89D9B0", Offset = "0x89CDB0", VA = "0x18089D9B0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A550", Offset = "0x6D49950", VA = "0x186D4A550")]
	public GEIIMOHGFPH(BJAGKBEKNLC CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A990", Offset = "0x6D49D90", VA = "0x186D4A990")]
	public GEIIMOHGFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A120", Offset = "0x6D49520", VA = "0x186D4A120")]
	public void MABFCCPGADF(GlyphMapAsset DDKHMEAEOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A160", Offset = "0x6D49560", VA = "0x186D4A160")]
	public void MABFCCPGADF(NIPPEPHEDAK COHLFFLOABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A2B0", Offset = "0x6D496B0", VA = "0x186D4A2B0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] GJNLCOPHDFI MMLFCJKOJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D49520", Offset = "0x6D48920", VA = "0x186D49520")]
	public void AIOAPBHOFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6D49E90", Offset = "0x6D49290", VA = "0x186D49E90")]
	public bool LEHGFNMGHDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D49EE0", Offset = "0x6D492E0", VA = "0x186D49EE0")]
	public FGHHLCFNDAG LJPPGOHAJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D49890", Offset = "0x6D48C90", VA = "0x186D49890")]
	public void JBPLIABCEGK(FGHHLCFNDAG NAOFJHANECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D49D50", Offset = "0x6D49150", VA = "0x186D49D50")]
	internal bool KBMGINAENBL(FGHHLCFNDAG NAOFJHANECN, [Out] HOPBBBMDCNP LIHCCJHEDIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D49C00", Offset = "0x6D49000", VA = "0x186D49C00")]
	private void JHKPBMNGAFM(EHDNHKKBMJA KDNIEKHICNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D49580", Offset = "0x6D48980", VA = "0x186D49580")]
	private void DCCPGNHCCEF(int MBGMDHDKJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D49810", Offset = "0x6D48C10", VA = "0x186D49810")]
	private bool EIFDKPCFKOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D42CD0", Offset = "0x6D420D0", VA = "0x186D42CD0")]
	private static int GNEMBPBAKMG(FGHHLCFNDAG NAOFJHANECN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1BDF710", Offset = "0x1BDEB10", VA = "0x181BDF710")]
	private static ushort PKEOFELJLKJ(int OBFJPFHENMC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D49210", Offset = "0x6D48610", VA = "0x186D49210")]
	private Bounds AFPHEFOCHJP()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D49760", Offset = "0x6D48B60", VA = "0x186D49760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BJAGKBEKNLC
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BJAGKBEKNLC DJPIGEDFBIO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float DEOMHICPHBA = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int EKCPICBLLEA = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int CGDGODEDAFJ = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color OFOFIPPKLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float KIBJABFENBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int JJGEKKBKHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int DDGCJDHHIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int BNGLLKGBPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int ICOMNJCFBKK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D48180", Offset = "0x6D47580", VA = "0x186D48180")]
	internal BJAGKBEKNLC PEFBMHFCJCF()
	{
		return default(BJAGKBEKNLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D403D0", Offset = "0x6D3F7D0", VA = "0x186D403D0")]
	[CompilerGenerated]
	internal static void POHEJCOLDFG(int PFKKDHPJFEH, int POOOEFHFGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D48140", Offset = "0x6D47540", VA = "0x186D48140")]
	[CompilerGenerated]
	internal static void GCLFJABJOFE(float PFKKDHPJFEH, float POOOEFHFGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D403C0", Offset = "0x6D3F7C0", VA = "0x186D403C0")]
	[CompilerGenerated]
	internal static void NJNPDEBOCGN(int PFKKDHPJFEH, int BJLMKLHPCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D48160", Offset = "0x6D47560", VA = "0x186D48160")]
	[CompilerGenerated]
	internal static void OKALKHJLGOG(float PFKKDHPJFEH, float BJLMKLHPCCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NCKJBGFLDDB
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CA50", Offset = "0x6D4BE50", VA = "0x186D4CA50")]
	public static (int, int) NMFNKMEDFMB(this GEIIMOHGFPH GBKDIHAJEMI)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C9C0", Offset = "0x6D4BDC0", VA = "0x186D4C9C0")]
	public static float CIIBGDLADBF(this HOPBBBMDCNP FPEKHKNKKBM)
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
		public readonly FGHHLCFNDAG textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D290", Offset = "0x6D4C690", VA = "0x186D4D290")]
		public TextSegmentLayout(LayoutRect layoutRect, FGHHLCFNDAG textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D060", Offset = "0x6D4C460", VA = "0x186D4D060")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D0D0", Offset = "0x6D4C4D0", VA = "0x186D4D0D0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D4D000", Offset = "0x6D4C400", VA = "0x186D4D000")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class ELFMPEICEPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig JOOCDKIMCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float HBBDNAPEPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float PFHLJGAHNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float ACHLHGJFIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float KIGAKKNMMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float LIGAAFDJPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float BNEGGCBLKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float GHKEHBDLIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float PLBOHONGLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float EAPKBOLLAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float JECLHNPELLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float JKELLBOFCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float KPEBFCDNMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IGEDEOMCINN[] HKBBOBCPIFB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int ELJCDOBNPFL = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private GMNKBHEJACK[] MHBPBKCAKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int BPELPKBEKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private CGAGIAOMOBD[] IAPJKNOAJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int HEKDDJEKNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public IGEDEOMCINN PHKGIKAIACL;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D48840", Offset = "0x6D47C40", VA = "0x186D48840")]
	public void MABFCCPGADF(NIPPEPHEDAK OJBEDAEOBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D488D0", Offset = "0x6D47CD0", VA = "0x186D488D0")]
	public void MABFCCPGADF(GlyphUVConfig KHLLCGMIDIK, IEnumerable<CGAGIAOMOBD> DDKHMEAEOHH, CGAGIAOMOBD GKJMICJADDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D48700", Offset = "0x6D47B00", VA = "0x186D48700")]
	internal void JHDALFBFLBE(GlyphUVConfig KHLLCGMIDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D48950", Offset = "0x6D47D50", VA = "0x186D48950")]
	private void MHABGEKLDKL(IEnumerable<CGAGIAOMOBD> DDKHMEAEOHH, CGAGIAOMOBD GKJMICJADDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D483D0", Offset = "0x6D477D0", VA = "0x186D483D0")]
	public void HHHAFOLIIAJ([In] char KCCMBOFEFPE, [Out] float2[] BNGEIHPJMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D46230", Offset = "0x6D45630", VA = "0x186D46230")]
	private IGEDEOMCINN ECLFNHDIKOA(CGAGIAOMOBD ANNMGKJPJOH)
	{
		return default(IGEDEOMCINN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D48E90", Offset = "0x6D48290", VA = "0x186D48E90")]
	public ELFMPEICEPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GPLBEFKDEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B890", Offset = "0x6D4AC90", VA = "0x186D4B890")]
	public static void GHFMFMIFDID([In] float OPCLAEIOBMD, [In] float ANPCLIKCMOL, [In] int GKCOMMFLNBD, [In] int EEOAINGELOL, [In] float KIGAKKNMMJH, [In] float LIGAAFDJPEJ, [In] float FKAJGHAEGPC, [In] float PNMFLOGIDOM, [In] float KIPCONICMEO, [In] float CPHPIJGMBDH, [Out] float EECIONINPLN, [Out] float PNLGLMNIHCO, [Out] float EPLMHMAGJOM, [Out] float NIBCHNILDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B830", Offset = "0x6D4AC30", VA = "0x186D4B830")]
	public static void GHFMFMIFDID([In] float OPCLAEIOBMD, [In] float ANPCLIKCMOL, [In] int GKCOMMFLNBD, [In] int EEOAINGELOL, [Out] float EECIONINPLN, [Out] float PNLGLMNIHCO, [Out] float EPLMHMAGJOM, [Out] float NIBCHNILDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B960", Offset = "0x6D4AD60", VA = "0x186D4B960")]
	public static void LDFABNDGKHH([In] float KIGAKKNMMJH, [In] float LIGAAFDJPEJ, [In] float NDHEAINJMNH, [In] float LDNLECOBMOO, [In] float ABIEPKLBGHL, [In] float BLCLMHGHOCD, [Out] float BLCGEFJMONL, [Out] float MJJDJAMJAAA, [Out] float OIOEOILKDKD, [Out] float IBKLNHADHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GMNKBHEJACK
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint NJFCIEDMKCI = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char MNGKFJLEPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly IGEDEOMCINN AKEJEOGONKJ;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B810", Offset = "0x6D4AC10", VA = "0x186D4B810")]
	public GMNKBHEJACK(char KCCMBOFEFPE, IGEDEOMCINN BNGEIHPJMEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct IGEDEOMCINN
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint NJFCIEDMKCI = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] KCIHACHEDPL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C420", Offset = "0x6D4B820", VA = "0x186D4C420")]
	public IGEDEOMCINN(float EECIONINPLN, float PNLGLMNIHCO, float EPLMHMAGJOM, float NIBCHNILDGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct EHDNHKKBMJA
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int OMNNLEADONK = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal GOKAJENKIIP KBFHDKGGKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] JJFLEMMFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int HGOBHHDGADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 LBNJPIHINGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float JJIEECLHAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 KECDAPPKAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool BJEBIGCHCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int KHFGMHKLNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int CHIGANHBNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int HOILGPJDNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int KPNCPMNAGOL;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D483C0", Offset = "0x6D477C0", VA = "0x186D483C0")]
	public static int LFLNHMBEEGN(int LLNBIPIINEI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum GOKAJENKIIP : byte
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
public static class MDLABIFALPP
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C900", Offset = "0x6D4BD00", VA = "0x186D4C900")]
	internal static float CIIBGDLADBF(this EHDNHKKBMJA KDNIEKHICNM, float NMBEKBMHIOD, float KBLHDLKPKLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C940", Offset = "0x6D4BD40", VA = "0x186D4C940")]
	internal static void CJPAPCCCKKK(this EHDNHKKBMJA KDNIEKHICNM, float NMBEKBMHIOD, float KBLHDLKPKLP, [Out] float2 AOFEGKJKMDG, [Out] float2 FBENJJMLPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class GHFEFLPBJIH : BGAGFHIJMOD
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int CJPOKPGCCPI = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int PLPOBDKMBFI = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string AGFFMBGHIBJ = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static NLBEPKHEEPL EJFBHOHNMIL;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static NLBEPKHEEPL FIBPPHADPAN;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static NLBEPKHEEPL PAJNILCAOGP;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static NLBEPKHEEPL HGFOCLPKFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly GJNLCOPHDFI MMLFCJKOJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] JHLOGEBBILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] ALLBKHGICHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BKMJMBEMBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int PDAKOFIKOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int BKMGDEKJJHO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ACDGEPBIBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BGAGFHIJMOD.JGPPNPDKIOH EMJOJFBFPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B700", Offset = "0x6D4AB00", VA = "0x186D4B700")]
	public GHFEFLPBJIH(GJNLCOPHDFI.LCIDINKIPPB NMBDNMHACOJ, int IAGHKPFPCPD, int IPADAPECKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B570", Offset = "0x6D4A970", VA = "0x186D4B570", Slot = "5")]
	public bool TryGetMeshBuffer([Out] GJNLCOPHDFI MMLFCJKOJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D4AA10", Offset = "0x6D49E10", VA = "0x186D4AA10")]
	public void DKLMBOMGHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D4AB80", Offset = "0x6D49F80", VA = "0x186D4AB80")]
	public void OMJEDGDPIKP(Span<EHDNHKKBMJA> FPHIKDKKPEE, ELFMPEICEPJ AOGPMDNAIOF, [In] BJAGKBEKNLC CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D46610", Offset = "0x6D45A10", VA = "0x186D46610")]
	private void JPPACLIBOJL([In] GOKAJENKIIP KBFHDKGGKHB, [In] EHDNHKKBMJA HOPPHDCFOBP, int OIPBOCKKDKG, [In] float NMBEKBMHIOD, [In] float KBLHDLKPKLP, ELFMPEICEPJ AOGPMDNAIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D4AA30", Offset = "0x6D49E30", VA = "0x186D4AA30")]
	private void HCEEPECKMKN([In] GOKAJENKIIP KBFHDKGGKHB, EHDNHKKBMJA HOPPHDCFOBP, [In] int MOCFOPCJFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B3A0", Offset = "0x6D4A7A0", VA = "0x186D4B3A0")]
	public static void OONMIOKLCGG(ReadOnlySpan<EHDNHKKBMJA> FPHIKDKKPEE, int JPNADDJJNMF, [Out] int EEKKGMAFFFP, [Out] int KMLJEJKJLEM, [Out] int HOBJEMMFAEH)
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
