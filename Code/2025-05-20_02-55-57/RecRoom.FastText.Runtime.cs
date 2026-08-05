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
public class JEECCIDPEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D IMLKLPBLLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig CPCAEAMFCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public DFKDMCDAMIO[] FKPINJPECDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public DFKDMCDAMIO FJDEBNIKHDE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static JEECCIDPEBG DLJGBNJCPAJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JEECCIDPEBG AOMJNOBMMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C900D0", Offset = "0x7C8F2D0", VA = "0x187C900D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JEECCIDPEBG()
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
		[Cpp2IlInjected.Address(RVA = "0x7C8E630", Offset = "0x7C8D830", VA = "0x187C8E630")]
		public GlyphUVConfig(int FDOGMJNMFHL, int IFLCGCLGJPH, int JJCPOEAMHHA, int JMOGAJMLDNJ, float GCDEFHKEMJN = 0f, [Optional] GlyphPixelInset MPGGAECEOHP)
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
public readonly struct DFKDMCDAMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char FDDKOLGJNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int JDOECMMEFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int ACLHPOFIPDF;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly DFKDMCDAMIO PLKJJDCPKNG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DA80", Offset = "0x7C8CC80", VA = "0x187C8DA80")]
	public DFKDMCDAMIO(char JNEHFDHAOPJ, int NEPEOAKNHDE, int JGNBJMIDJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DA90", Offset = "0x7C8CC90", VA = "0x187C8DA90")]
	public DFKDMCDAMIO(GlyphCoordinateWritable PPKAHIOAAJN)
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
		[Cpp2IlInjected.Address(RVA = "0x7C8DC50", Offset = "0x7C8CE50", VA = "0x187C8DC50")]
		public static DFKDMCDAMIO NEKLFDMHCNA(GlyphCoordinateWritable FLCLDMGPCKH)
		{
			return default(DFKDMCDAMIO);
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
		private JEECCIDPEBG configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C8E530", Offset = "0x7C8D730", VA = "0x187C8E530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7C8E3B0", Offset = "0x7C8D5B0", VA = "0x187C8E3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7C8E3A0", Offset = "0x7C8D5A0", VA = "0x187C8E3A0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JEECCIDPEBG ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7C8DDA0", Offset = "0x7C8CFA0", VA = "0x187C8DDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private DFKDMCDAMIO FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7C8E210", Offset = "0x7C8D410", VA = "0x187C8E210")]
			get
			{
				return default(DFKDMCDAMIO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DC70", Offset = "0x7C8CE70", VA = "0x187C8DC70")]
		internal void ECECLCOJCJC(IEnumerable<GlyphCoordinateWritable> FBEADBDCGPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DD10", Offset = "0x7C8CF10", VA = "0x187C8DD10")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DCF0", Offset = "0x7C8CEF0", VA = "0x187C8DCF0")]
		[CompilerGenerated]
		private bool OLFKBAKJOEA(GlyphCoordinateWritable FLCLDMGPCKH)
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
		private TextSegmentMeshBufferSource CJOIBNDCOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private HCIMPPNFFOB NOJOJBPFFEB;

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
		private LEJEBEOEKHO FFIBOHBIKLD;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C91C80", Offset = "0x7C90E80", VA = "0x187C91C80")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C91C30", Offset = "0x7C90E30", VA = "0x187C91C30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C91A50", Offset = "0x7C90C50", VA = "0x187C91A50")]
		private void NGOPAMICEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C91D70", Offset = "0x7C90F70", VA = "0x187C91D70")]
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
		private bool OKHOHOPHAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material MLPJINGMKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private HCIMPPNFFOB NOJOJBPFFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material FMGGFMLEFPI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private JEECCIDPEBG CKCNNIIGNNH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7C920F0", Offset = "0x7C912F0", VA = "0x187C920F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HCIMPPNFFOB MMFNICANBGN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C92880", Offset = "0x7C91A80", VA = "0x187C92880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material AAGKFBEDCGI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C928B0", Offset = "0x7C91AB0", VA = "0x187C928B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C927E0", Offset = "0x7C919E0", VA = "0x187C927E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C92180", Offset = "0x7C91380", VA = "0x187C92180", Slot = "8")]
		protected override void GNNLOMDPCHM(EFFHNGCOIDC HPAIMANAFLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C927F0", Offset = "0x7C919F0", VA = "0x187C927F0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] HPOJPFLIOPO IMPGIGHAFJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C92690", Offset = "0x7C91890", VA = "0x187C92690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C92370", Offset = "0x7C91570", VA = "0x187C92370")]
		private void NEPBJEJHGMM(bool LIEHHNOLAGC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA0D1C0", Offset = "0xA0C3C0", VA = "0x180A0D1C0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct AMCIEBHHAMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly HCIMPPNFFOB JFOEEHDJIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int FJLCLICBINL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C8CEA0", Offset = "0x7C8C0A0", VA = "0x187C8CEA0")]
	internal ECMKJJICHHA JJFNGMGOKLL()
	{
		return default(ECMKJJICHHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27B00F0", Offset = "0x27AF2F0", VA = "0x1827B00F0")]
	internal AMCIEBHHAMJ(HCIMPPNFFOB MHGFNMBGACA, int PAELAOCIMBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LAJOICIFMCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C91190", Offset = "0x7C90390", VA = "0x187C91190")]
	public static bool MJAGMLNNKJF(this AMCIEBHHAMJ PLDJGENNIJM, FNEHKMPIAFO CAHNALCBIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C91170", Offset = "0x7C90370", VA = "0x187C91170")]
	internal static bool MJAGMLNNKJF(this ECMKJJICHHA FPCPJHJOAKD, FNEHKMPIAFO CAHNALCBIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C911E0", Offset = "0x7C903E0", VA = "0x187C911E0")]
	public static float OKBLPCJPDPO(this AMCIEBHHAMJ PLDJGENNIJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD407C0", Offset = "0xD3F9C0", VA = "0x180D407C0")]
	internal static float OKBLPCJPDPO(this ECMKJJICHHA FPCPJHJOAKD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LJLIJMKCGGP
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C91500", Offset = "0x7C90700", VA = "0x187C91500")]
	public static void EKHHPPJJDAC(this AMCIEBHHAMJ PLDJGENNIJM, ReadOnlySpan<char> BOOBIKLMHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C91550", Offset = "0x7C90750", VA = "0x187C91550")]
	internal static void EKHHPPJJDAC(this ECMKJJICHHA FPCPJHJOAKD, ReadOnlySpan<char> BOOBIKLMHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C91890", Offset = "0x7C90A90", VA = "0x187C91890")]
	public static void NOKJJMJCEON(this AMCIEBHHAMJ HKCALCBGILO, float2 OKFPMLFPLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C918E0", Offset = "0x7C90AE0", VA = "0x187C918E0")]
	internal static void NOKJJMJCEON(this ECMKJJICHHA FPCPJHJOAKD, float2 OKFPMLFPLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C91930", Offset = "0x7C90B30", VA = "0x187C91930")]
	public static void OLOKMAACAPF(this AMCIEBHHAMJ HKCALCBGILO, float PMHMJFJKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C918F0", Offset = "0x7C90AF0", VA = "0x187C918F0")]
	internal static void OLOKMAACAPF(this ECMKJJICHHA FPCPJHJOAKD, float PMHMJFJKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C91770", Offset = "0x7C90970", VA = "0x187C91770")]
	internal static void HEBJGOLKGLF(this ECMKJJICHHA FPCPJHJOAKD, bool HLDEJBLHFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C91790", Offset = "0x7C90990", VA = "0x187C91790")]
	public static void INAKPNOAHGH(this AMCIEBHHAMJ HKCALCBGILO, Color32 EKKMKLFENBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C91780", Offset = "0x7C90980", VA = "0x187C91780")]
	internal static void INAKPNOAHGH(this ECMKJJICHHA FPCPJHJOAKD, Color32 EKKMKLFENBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C91850", Offset = "0x7C90A50", VA = "0x187C91850")]
	public static void NMBGBFBNIKK(this AMCIEBHHAMJ HKCALCBGILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C91840", Offset = "0x7C90A40", VA = "0x187C91840")]
	internal static void NMBGBFBNIKK(this ECMKJJICHHA FPCPJHJOAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C917D0", Offset = "0x7C909D0", VA = "0x187C917D0")]
	internal static void NEACGOBPDBE(this ECMKJJICHHA FPCPJHJOAKD, int KIMEAJLHKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C91750", Offset = "0x7C90950", VA = "0x187C91750")]
	internal static void FCFHNKGJGLF(this ECMKJJICHHA FPCPJHJOAKD, int OECGMHCFFIN, FNEHKMPIAFO DGCKECCNDNB = FNEHKMPIAFO.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LEJEBEOEKHO : IEquatable<LEJEBEOEKHO>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort EEJNMDNBFPF = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int LFOIILGCBFG = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly LEJEBEOEKHO NCJBPFMPBJM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort KKKHJMCJLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC40D10", Offset = "0xC3FF10", VA = "0x180C40D10")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC40D20", Offset = "0xC3FF20", VA = "0x180C40D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HCIMPPNFFOB JFOEEHDJIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KJALJJOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C86A60", Offset = "0x7C85C60", VA = "0x187C86A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C86D80", Offset = "0x7C85F80", VA = "0x187C86D80")]
	public LEJEBEOEKHO(int EAPCODILALI, HCIMPPNFFOB MHGFNMBGACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C91220", Offset = "0x7C90420", VA = "0x187C91220")]
	public bool ALJDENHEMME([Out] AMCIEBHHAMJ PLDJGENNIJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C912F0", Offset = "0x7C904F0", VA = "0x187C912F0")]
	public void EFCGIOJACBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C86C50", Offset = "0x7C85E50", VA = "0x187C86C50")]
	internal void OMODDOBHGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C86AC0", Offset = "0x7C85CC0", VA = "0x187C86AC0", Slot = "4")]
	public bool Equals(LEJEBEOEKHO FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C91340", Offset = "0x7C90540", VA = "0x187C91340", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C91400", Offset = "0x7C90600", VA = "0x187C91400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HCIMPPNFFOB : IDisposable, BPNALIHLJJG
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string CIDHCJALIAE = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker IFGFMBJMHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string BHGCKKFEJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly ICGEEBMHHHH HLIEPEFDHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int EHHCJLEGPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal ECMKJJICHHA[] KAIAMEMNLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal LEJEBEOEKHO[] PKKKOHJOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private JEECCIDPEBG KLFDGHEKGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CFPNKNCCJLI ENOCHBEAILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly LACBHCBLOCK DJEEMCHMDCJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string DGIAFBEDPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F650", Offset = "0x7C8E850", VA = "0x187C8F650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JEECCIDPEBG FLIGFFDCLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E960", Offset = "0x7C8DB60", VA = "0x187C8E960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float LCPLODGFLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E660", Offset = "0x7C8D860", VA = "0x187C8E660")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float JPJCEIBHLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C8EE70", Offset = "0x7C8E070", VA = "0x187C8EE70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BPNALIHLJJG.LKDILELELMA IBCANNFOEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FA90", Offset = "0x7C8EC90", VA = "0x187C8FA90")]
	public HCIMPPNFFOB(ICGEEBMHHHH EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FA10", Offset = "0x7C8EC10", VA = "0x187C8FA10")]
	public HCIMPPNFFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F000", Offset = "0x7C8E200", VA = "0x187C8F000")]
	public void MNFKMEBPDCG(GlyphMapAsset LJNGBHBANDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8EEF0", Offset = "0x7C8E0F0", VA = "0x187C8EEF0")]
	public void MNFKMEBPDCG(JEECCIDPEBG JJBICEGPACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F740", Offset = "0x7C8E940", VA = "0x187C8F740", Slot = "6")]
	public bool TryGetMeshBuffer([Out] HPOJPFLIOPO IMPGIGHAFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F6E0", Offset = "0x7C8E8E0", VA = "0x187C8F6E0")]
	public void POBOJPDLAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F600", Offset = "0x7C8E800", VA = "0x187C8F600")]
	public bool OCIHCCJMFMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F040", Offset = "0x7C8E240", VA = "0x187C8F040")]
	public LEJEBEOEKHO MPHDBHKBIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F2A0", Offset = "0x7C8E4A0", VA = "0x187C8F2A0")]
	public void OADHFOLAMIM(LEJEBEOEKHO JHOEANEPCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E800", Offset = "0x7C8DA00", VA = "0x187C8E800")]
	internal bool DEPGAICHBFL(LEJEBEOEKHO JHOEANEPCAL, [Out] AMCIEBHHAMJ PLDJGENNIJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E680", Offset = "0x7C8D880", VA = "0x187C8E680")]
	private void BCEPEEIGKJB(ECMKJJICHHA FPCPJHJOAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E980", Offset = "0x7C8DB80", VA = "0x187C8E980")]
	private void FCENIPAJNEK(int MEFCCKCDJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C8EE90", Offset = "0x7C8E090", VA = "0x187C8EE90")]
	private bool JNJOAMBPPFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C863A0", Offset = "0x7C855A0", VA = "0x187C863A0")]
	private static int NPCCNPEJOPB(LEJEBEOEKHO JHOEANEPCAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x210C8B0", Offset = "0x210BAB0", VA = "0x18210C8B0")]
	private static ushort KKGMEBHJGHB(int NIBICIJAIGM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C8EB60", Offset = "0x7C8DD60", VA = "0x187C8EB60")]
	private Bounds JLBFIJBOENN()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E8B0", Offset = "0x7C8DAB0", VA = "0x187C8E8B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ICGEEBMHHHH
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly ICGEEBMHHHH NFPAEELIHKH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float OKIPFGMPEEH = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LDMFCJMLKHF = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int OAOCIPKAHPI = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color CBEBKBNFOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float JJLACCIDMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int IDLAMIENBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int MEDIDHJFKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int BFCFEIFDLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int JOKAGHHAOBB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FF10", Offset = "0x7C8F110", VA = "0x187C8FF10")]
	internal ICGEEBMHHHH OCMKKAMDGKM()
	{
		return default(ICGEEBMHHHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C86DE0", Offset = "0x7C85FE0", VA = "0x187C86DE0")]
	[CompilerGenerated]
	internal static void DJLMADOIPCK(int MLCDCHNOCFI, int FAGKKFIFNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FED0", Offset = "0x7C8F0D0", VA = "0x187C8FED0")]
	[CompilerGenerated]
	internal static void BAKDGDPNGND(float MLCDCHNOCFI, float FAGKKFIFNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C86DF0", Offset = "0x7C85FF0", VA = "0x187C86DF0")]
	[CompilerGenerated]
	internal static void FEFDMPABLFG(int MLCDCHNOCFI, int LJDPFCIHJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FEF0", Offset = "0x7C8F0F0", VA = "0x187C8FEF0")]
	[CompilerGenerated]
	internal static void CMOFIEKANKM(float MLCDCHNOCFI, float LJDPFCIHJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NGAPILPPAJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C919C0", Offset = "0x7C90BC0", VA = "0x187C919C0")]
	public static float MPEKJEOOJBL(this AMCIEBHHAMJ IIFKJPDOGNM)
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
		public readonly LEJEBEOEKHO textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C92080", Offset = "0x7C91280", VA = "0x187C92080")]
		public TextSegmentLayout(LayoutRect layoutRect, LEJEBEOEKHO textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C91E50", Offset = "0x7C91050", VA = "0x187C91E50")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C91EC0", Offset = "0x7C910C0", VA = "0x187C91EC0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C91DF0", Offset = "0x7C90FF0", VA = "0x187C91DF0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class CFPNKNCCJLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig OBBNIKEFHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float BBCPNHODMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float GLFLGDCLFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float HHNEKLDDLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float EMMOFGBBDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float DOIKGPLLDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float HFICOEGPBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float DNALFKOONIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float ANAPJIKCHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float PKCNEJBOELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float JPJCEIBHLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float HLEKEMBOGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float LCPLODGFLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AGKEPJPLDCD[] MMFBGKKFDKG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int GGONNAIEAJA = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private LJPNBKDPDCO[] DFJKPMNBPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int BPNCJMJILMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private DFKDMCDAMIO[] LPEJHALLLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int NHMOLGLEMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public AGKEPJPLDCD NHOEAOLHBLG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D350", Offset = "0x7C8C550", VA = "0x187C8D350")]
	public void MNFKMEBPDCG(JEECCIDPEBG HIOONPMLBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D3E0", Offset = "0x7C8C5E0", VA = "0x187C8D3E0")]
	public void MNFKMEBPDCG(GlyphUVConfig BJOPHENKBOE, IEnumerable<DFKDMCDAMIO> LJNGBHBANDN, DFKDMCDAMIO GPGPNJEDCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D210", Offset = "0x7C8C410", VA = "0x187C8D210")]
	internal void KHOGIPABCDJ(GlyphUVConfig BJOPHENKBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D460", Offset = "0x7C8C660", VA = "0x187C8D460")]
	private void NPEKELBCBLC(IEnumerable<DFKDMCDAMIO> LJNGBHBANDN, DFKDMCDAMIO GPGPNJEDCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8CEE0", Offset = "0x7C8C0E0", VA = "0x187C8CEE0")]
	public void CNNNODBEIKP([In] char JNEHFDHAOPJ, [Out] float2[] IMKNHCAPABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AC40", Offset = "0x7C89E40", VA = "0x187C8AC40")]
	private AGKEPJPLDCD BBBHLAEGAKB(DFKDMCDAMIO PPKAHIOAAJN)
	{
		return default(AGKEPJPLDCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D990", Offset = "0x7C8CB90", VA = "0x187C8D990")]
	public CFPNKNCCJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EOMNPCPKABC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DB80", Offset = "0x7C8CD80", VA = "0x187C8DB80")]
	public static void HKGMKIBOEKK([In] float IIAGILHDICJ, [In] float GPKMLKNDCGC, [In] int JGMLOOPNEIE, [In] int KJEDLDFCKND, [In] float EMMOFGBBDLN, [In] float DOIKGPLLDDG, [In] float POGLHHIAJDG, [In] float ILKKOCKLGEI, [In] float EDBOLMGKOLN, [In] float KDGDJMLDMEL, [Out] float MJMIOBAEBOD, [Out] float LCMDJLNFKGD, [Out] float GACIHPKMBEI, [Out] float DPPOMBPJCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DB20", Offset = "0x7C8CD20", VA = "0x187C8DB20")]
	public static void HKGMKIBOEKK([In] float IIAGILHDICJ, [In] float GPKMLKNDCGC, [In] int JGMLOOPNEIE, [In] int KJEDLDFCKND, [Out] float MJMIOBAEBOD, [Out] float LCMDJLNFKGD, [Out] float GACIHPKMBEI, [Out] float DPPOMBPJCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DAC0", Offset = "0x7C8CCC0", VA = "0x187C8DAC0")]
	public static void HEAHCLHKLAK([In] float EMMOFGBBDLN, [In] float DOIKGPLLDDG, [In] float BPCAPMKJLGJ, [In] float LJIGLOALLIO, [In] float HKPEECFMCHI, [In] float HOPJCAOHBCB, [Out] float HGEHCILDMLL, [Out] float INLABGBNCFF, [Out] float KHDPPMGHOME, [Out] float JFPPCJHGPOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct LJPNBKDPDCO
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint IAJOFLFBMCL = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char FDDKOLGJNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly AGKEPJPLDCD CKFFFPBFIKC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C919A0", Offset = "0x7C90BA0", VA = "0x187C919A0")]
	public LJPNBKDPDCO(char JNEHFDHAOPJ, AGKEPJPLDCD IMKNHCAPABC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct AGKEPJPLDCD
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint IAJOFLFBMCL = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] BOPICDKMMCM;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C8CDB0", Offset = "0x7C8BFB0", VA = "0x187C8CDB0")]
	public AGKEPJPLDCD(float MJMIOBAEBOD, float LCMDJLNFKGD, float GACIHPKMBEI, float DPPOMBPJCIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct ECMKJJICHHA
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int PHHLCJONKDC = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal FNEHKMPIAFO DGCKECCNDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] CKINMOJHAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int GFNLFHBJAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 OKFPMLFPLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float HFEIBOKPOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 JBIIJDHJCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool HLDEJBLHFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int ADPMDGILAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int HAOJGDALGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int MDLBMGEOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int JBEPGJKJGFE;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DAB0", Offset = "0x7C8CCB0", VA = "0x187C8DAB0")]
	public static int KNNCGKIOKKK(int FNGLKHBHGKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum FNEHKMPIAFO : byte
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
public static class AFJIKNNNMOK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C8CD70", Offset = "0x7C8BF70", VA = "0x187C8CD70")]
	internal static float MPEKJEOOJBL(this ECMKJJICHHA FPCPJHJOAKD, float MGELEBMMGOP, float KHGOOINENGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C8CCF0", Offset = "0x7C8BEF0", VA = "0x187C8CCF0")]
	internal static void EPBKAKADMPF(this ECMKJJICHHA FPCPJHJOAKD, float MGELEBMMGOP, float KHGOOINENGN, [Out] float2 BCBBNNPFNAH, [Out] float2 IMCPMFMKKOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class LACBHCBLOCK : BPNALIHLJJG
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int LACLBKPGLPJ = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int IGONCDAJOGH = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string CIDHCJALIAE = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker EKHBMIAIBDB;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker NKMKLOPEABP;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker HGFNHJDOKOL;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker PIBPPJBDGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly HPOJPFLIOPO IMPGIGHAFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] JKFBMBDEHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] AEECNKNIOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CCFPPMEHJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int AJMPDNNCNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int MGIDOFIDIKF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string DGIAFBEDPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BPNALIHLJJG.LKDILELELMA IBCANNFOEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C91060", Offset = "0x7C90260", VA = "0x187C91060")]
	public LACBHCBLOCK(HPOJPFLIOPO.CKBOGLNLEHH HDEEFNOJMJC, int HOCJAEJFEDI, int FMOPAFNOBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C90EE0", Offset = "0x7C900E0", VA = "0x187C90EE0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] HPOJPFLIOPO IMPGIGHAFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C90D70", Offset = "0x7C8FF70", VA = "0x187C90D70")]
	public void IIBEHFKJFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C90470", Offset = "0x7C8F670", VA = "0x187C90470")]
	public void IHECICJAJFP(Span<ECMKJJICHHA> KJPGKJBOLOA, CFPNKNCCJLI KGJBFADAANC, [In] ICGEEBMHHHH EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B020", Offset = "0x7C8A220", VA = "0x187C8B020")]
	private void COBJJADKALF([In] FNEHKMPIAFO DGCKECCNDNB, [In] ECMKJJICHHA LFIGMLJABKK, int AMLJIOFKNIK, [In] float MGELEBMMGOP, [In] float KHGOOINENGN, CFPNKNCCJLI KGJBFADAANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C90D90", Offset = "0x7C8FF90", VA = "0x187C90D90")]
	private void KLLKHIGFPKB([In] FNEHKMPIAFO DGCKECCNDNB, ECMKJJICHHA LFIGMLJABKK, [In] int GLBLAAKFJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C90240", Offset = "0x7C8F440", VA = "0x187C90240")]
	public static void DOIMBNJEBIP(ReadOnlySpan<ECMKJJICHHA> KJPGKJBOLOA, int CKINAHFPGDA, [Out] int BKMPPBAADNB, [Out] int MHAMGFJBNPI, [Out] int NEPENKKEFAC)
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
