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
public class NNEJHENEMPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D DFOGLDOFKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig PMBBPFIGJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ELDCPHKBEEL[] JBMAPMJLLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ELDCPHKBEEL PJFONCPEPPC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static NNEJHENEMPM BIPKKKGMNPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NNEJHENEMPM FCEFDBDGOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E550", Offset = "0x7C4D750", VA = "0x187C4E550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NNEJHENEMPM()
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
		[Cpp2IlInjected.Address(RVA = "0x7C4CBB0", Offset = "0x7C4BDB0", VA = "0x187C4CBB0")]
		public GlyphUVConfig(int HEDGGHBNIJE, int JAHMOLLGNEC, int PBAAMOAHDDI, int EHHGMBEBHKA, float IMBHJICIGPF = 0f, [Optional] GlyphPixelInset OCHOHJHABJI)
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
public readonly struct ELDCPHKBEEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char LDCHNMGBMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int JNOHIICMEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int HHGPHLEKBEA;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly ELDCPHKBEEL JCPFEFOLFCE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B660", Offset = "0x7C4A860", VA = "0x187C4B660")]
	public ELDCPHKBEEL(char FOKKCEHPBEF, int ANGMODGBFPG, int KFKKEOJLHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B640", Offset = "0x7C4A840", VA = "0x187C4B640")]
	public ELDCPHKBEEL(GlyphCoordinateWritable HOPLFPCIJGM)
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
		[Cpp2IlInjected.Address(RVA = "0x7C4C1D0", Offset = "0x7C4B3D0", VA = "0x187C4C1D0")]
		public static ELDCPHKBEEL PDHAGBEBCNG(GlyphCoordinateWritable NAGHCPKAEOP)
		{
			return default(ELDCPHKBEEL);
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
		private NNEJHENEMPM configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C4CAB0", Offset = "0x7C4BCB0", VA = "0x187C4CAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7C4C930", Offset = "0x7C4BB30", VA = "0x187C4C930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7C4C920", Offset = "0x7C4BB20", VA = "0x187C4C920")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NNEJHENEMPM ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7C4C320", Offset = "0x7C4B520", VA = "0x187C4C320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ELDCPHKBEEL FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7C4C790", Offset = "0x7C4B990", VA = "0x187C4C790")]
			get
			{
				return default(ELDCPHKBEEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C1F0", Offset = "0x7C4B3F0", VA = "0x187C4C1F0")]
		internal void EFJNCKEMHOI(IEnumerable<GlyphCoordinateWritable> MMHBLNJGGIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C290", Offset = "0x7C4B490", VA = "0x187C4C290")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C270", Offset = "0x7C4B470", VA = "0x187C4C270")]
		[CompilerGenerated]
		private bool MMALOCDICDI(GlyphCoordinateWritable NAGHCPKAEOP)
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
		private TextSegmentMeshBufferSource ALEJPNGJKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DHOFCFFMODF LEKPAFJNEOM;

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
		private HGBPNJJFKKI DPPKOOKJMLP;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E9E0", Offset = "0x7C4DBE0", VA = "0x187C4E9E0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E990", Offset = "0x7C4DB90", VA = "0x187C4E990")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E7B0", Offset = "0x7C4D9B0", VA = "0x187C4E7B0")]
		private void CJDCMOJPMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EAD0", Offset = "0x7C4DCD0", VA = "0x187C4EAD0")]
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
		private bool OFDLLKPACEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material BADDIAHBLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private DHOFCFFMODF LEKPAFJNEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material OEPMMJHHNFM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private NNEJHENEMPM MGCGDFIJOGL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7C4F360", Offset = "0x7C4E560", VA = "0x187C4F360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DHOFCFFMODF CLPAGAHFGJO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C4F5E0", Offset = "0x7C4E7E0", VA = "0x187C4F5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material BPBEPCACMIA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C4F610", Offset = "0x7C4E810", VA = "0x187C4F610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F540", Offset = "0x7C4E740", VA = "0x187C4F540")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EE50", Offset = "0x7C4E050", VA = "0x187C4EE50", Slot = "8")]
		protected override void GHHEGICNOFG(JLGPFMKNGAB EDJMJHPPKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F550", Offset = "0x7C4E750", VA = "0x187C4F550", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] INCMEHFOMFK JALBNGKJKLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F3F0", Offset = "0x7C4E5F0", VA = "0x187C4F3F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F040", Offset = "0x7C4E240", VA = "0x187C4F040")]
		private void HHONDPOLFMH(bool IKLDNLEDLAC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA1E1A0", Offset = "0xA1D3A0", VA = "0x180A1E1A0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct AHMGHDNNAHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly DHOFCFFMODF MPIOOIDIFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int LEHFAIIOCCM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C49B00", Offset = "0x7C48D00", VA = "0x187C49B00")]
	internal GKIKJBCIEKG ODKPLLHOMGL()
	{
		return default(GKIKJBCIEKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x288BE40", Offset = "0x288B040", VA = "0x18288BE40")]
	internal AHMGHDNNAHK(DHOFCFFMODF OBHJPIMFHEM, int CGODAJFALDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AGHLEODJJGG
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C49AB0", Offset = "0x7C48CB0", VA = "0x187C49AB0")]
	public static bool IKEBIMEPBPO(this AHMGHDNNAHK HKJNIGIGOPA, NCBLPDFINKN LBFOLKLKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C49A90", Offset = "0x7C48C90", VA = "0x187C49A90")]
	internal static bool IKEBIMEPBPO(this GKIKJBCIEKG MCDKOCJBFKC, NCBLPDFINKN LBFOLKLKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C49A50", Offset = "0x7C48C50", VA = "0x187C49A50")]
	public static float FEDCIPEKPLB(this AHMGHDNNAHK HKJNIGIGOPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xDAC160", Offset = "0xDAB360", VA = "0x180DAC160")]
	internal static float FEDCIPEKPLB(this GKIKJBCIEKG MCDKOCJBFKC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NFOIDBJHKHN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E0B0", Offset = "0x7C4D2B0", VA = "0x187C4E0B0")]
	public static void BMJKPBJPFLL(this AHMGHDNNAHK HKJNIGIGOPA, ReadOnlySpan<char> MNPPPAJGBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E100", Offset = "0x7C4D300", VA = "0x187C4E100")]
	internal static void BMJKPBJPFLL(this GKIKJBCIEKG MCDKOCJBFKC, ReadOnlySpan<char> MNPPPAJGBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E3B0", Offset = "0x7C4D5B0", VA = "0x187C4E3B0")]
	public static void HJHKDOCHMPJ(this AHMGHDNNAHK FJCMFOAAADB, float2 CPPJLLDGJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E400", Offset = "0x7C4D600", VA = "0x187C4E400")]
	internal static void HJHKDOCHMPJ(this GKIKJBCIEKG MCDKOCJBFKC, float2 CPPJLLDGJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E300", Offset = "0x7C4D500", VA = "0x187C4E300")]
	public static void DODEDGEDFGM(this AHMGHDNNAHK FJCMFOAAADB, float CMBFDGJHMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E370", Offset = "0x7C4D570", VA = "0x187C4E370")]
	internal static void DODEDGEDFGM(this GKIKJBCIEKG MCDKOCJBFKC, float CMBFDGJHMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E4D0", Offset = "0x7C4D6D0", VA = "0x187C4E4D0")]
	internal static void OMEFBNHMCLE(this GKIKJBCIEKG MCDKOCJBFKC, bool JNIFMOIGHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E410", Offset = "0x7C4D610", VA = "0x187C4E410")]
	public static void LINPJBKGDNE(this AHMGHDNNAHK FJCMFOAAADB, Color32 NEMIFEKMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E450", Offset = "0x7C4D650", VA = "0x187C4E450")]
	internal static void LINPJBKGDNE(this GKIKJBCIEKG MCDKOCJBFKC, Color32 NEMIFEKMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E480", Offset = "0x7C4D680", VA = "0x187C4E480")]
	public static void OGEPJDJBLPH(this AHMGHDNNAHK FJCMFOAAADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E4C0", Offset = "0x7C4D6C0", VA = "0x187C4E4C0")]
	internal static void OGEPJDJBLPH(this GKIKJBCIEKG MCDKOCJBFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E4E0", Offset = "0x7C4D6E0", VA = "0x187C4E4E0")]
	internal static void PEKCPFMFEBP(this GKIKJBCIEKG MCDKOCJBFKC, int NJPPGEMKJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E460", Offset = "0x7C4D660", VA = "0x187C4E460")]
	internal static void MLBNCJCFKFM(this GKIKJBCIEKG MCDKOCJBFKC, int BENEONNGAND, NCBLPDFINKN JGIAFPKBPMC = NCBLPDFINKN.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HGBPNJJFKKI : IEquatable<HGBPNJJFKKI>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort PKFIMLIIHDI = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int LFLDFJKJBKN = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly HGBPNJJFKKI MOFDBOPEAGL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort AHPADICGDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC9BC90", Offset = "0xC9AE90", VA = "0x180C9BC90")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC9BCA0", Offset = "0xC9AEA0", VA = "0x180C9BCA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DHOFCFFMODF MPIOOIDIFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool APFGOMCKPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C42800", Offset = "0x7C41A00", VA = "0x187C42800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C42B20", Offset = "0x7C41D20", VA = "0x187C42B20")]
	public HGBPNJJFKKI(int CGBFBCCHLKD, DHOFCFFMODF OBHJPIMFHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CD60", Offset = "0x7C4BF60", VA = "0x187C4CD60")]
	public bool OGOGCHDMLAI([Out] AHMGHDNNAHK HKJNIGIGOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CD10", Offset = "0x7C4BF10", VA = "0x187C4CD10")]
	public void NCGHJFCANHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C42810", Offset = "0x7C41A10", VA = "0x187C42810")]
	internal void DOKMHJLGIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C428B0", Offset = "0x7C41AB0", VA = "0x187C428B0", Slot = "4")]
	public bool Equals(HGBPNJJFKKI CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CBE0", Offset = "0x7C4BDE0", VA = "0x187C4CBE0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CCA0", Offset = "0x7C4BEA0", VA = "0x187C4CCA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DHOFCFFMODF : IDisposable, GKENILLPBOI
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string DBGEEPNCBAA = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker DOBAAJHLKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string NMMEJKENFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly JEIOOIDPCAN DGOIGJBIBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int NOAHFNPGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal GKIKJBCIEKG[] FFNHBFDACEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HGBPNJJFKKI[] HFNDBAFFDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NNEJHENEMPM EINGNILLEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FMHFCEFCIFG FPGCAFPPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly LLGBFIEBKNN BHDBBKDIOPH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GBOCGPJOEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A750", Offset = "0x7C49950", VA = "0x187C4A750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NNEJHENEMPM AMFAHNEFGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A730", Offset = "0x7C49930", VA = "0x187C4A730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float NEOCCFFKJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A7E0", Offset = "0x7C499E0", VA = "0x187C4A7E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float MHOPJCPKEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C4ACC0", Offset = "0x7C49EC0", VA = "0x187C4ACC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GKENILLPBOI.JGJPOMJNDAF MMCPDFPOIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF570", VA = "0x180A00370", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA00380", Offset = "0x9FF580", VA = "0x180A00380", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B130", Offset = "0x7C4A330", VA = "0x187C4B130")]
	public DHOFCFFMODF(JEIOOIDPCAN HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B570", Offset = "0x7C4A770", VA = "0x187C4B570")]
	public DHOFCFFMODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A910", Offset = "0x7C49B10", VA = "0x187C4A910")]
	public void IJDFNMPLFGP(GlyphMapAsset JHAGHACKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A800", Offset = "0x7C49A00", VA = "0x187C4A800")]
	public void IJDFNMPLFGP(NNEJHENEMPM KFNDNHHBCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AE60", Offset = "0x7C4A060", VA = "0x187C4AE60", Slot = "6")]
	public bool TryGetMeshBuffer([Out] INCMEHFOMFK JALBNGKJKLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AC10", Offset = "0x7C49E10", VA = "0x187C4AC10")]
	public void KGFLOEMCKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AC70", Offset = "0x7C49E70", VA = "0x187C4AC70")]
	public bool MNELKFBENFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A9B0", Offset = "0x7C49BB0", VA = "0x187C4A9B0")]
	public HGBPNJJFKKI JMILJCHGIOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C49D80", Offset = "0x7C48F80", VA = "0x187C49D80")]
	public void AKNFFNMDFMI(HGBPNJJFKKI GEIOMCGANEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A2C0", Offset = "0x7C494C0", VA = "0x187C4A2C0")]
	internal bool CPDLIHGBNCN(HGBPNJJFKKI GEIOMCGANEL, [Out] AHMGHDNNAHK HKJNIGIGOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C4ACE0", Offset = "0x7C49EE0", VA = "0x187C4ACE0")]
	private void OMKBGGBMBKE(GKIKJBCIEKG MCDKOCJBFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A0E0", Offset = "0x7C492E0", VA = "0x187C4A0E0")]
	private void BBJDCEHDBIE(int OOGBGMOJPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A950", Offset = "0x7C49B50", VA = "0x187C4A950")]
	private bool IPHHLGNBOEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C419F0", Offset = "0x7C40BF0", VA = "0x187C419F0")]
	private static int NMAEIIJGHBA(HGBPNJJFKKI GEIOMCGANEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x21F1D70", Offset = "0x21F0F70", VA = "0x1821F1D70")]
	private static ushort FJEOGGMCDND(int CMDFFDAPDIB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A370", Offset = "0x7C49570", VA = "0x187C4A370")]
	private Bounds DKEIGELPJKM()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A680", Offset = "0x7C49880", VA = "0x187C4A680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JEIOOIDPCAN
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JEIOOIDPCAN JDJELPPMJPJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float MGFPLBDDJGG = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int PDKNAJDCJCE = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int DNBMKGCHHMO = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color ELLLKGKIFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float EACODAPJBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int IFMOJPPKHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int NNIANKBLDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int DPEHKDDPBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int ENDIMAPJJOB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CEC0", Offset = "0x7C4C0C0", VA = "0x187C4CEC0")]
	internal JEIOOIDPCAN GKFIFGJKAKN()
	{
		return default(JEIOOIDPCAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C40D50", Offset = "0x7C3FF50", VA = "0x187C40D50")]
	[CompilerGenerated]
	internal static void JDFLMKGMHFF(int KJIOHKMJAPE, int FEOJADDJKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CFF0", Offset = "0x7C4C1F0", VA = "0x187C4CFF0")]
	[CompilerGenerated]
	internal static void JGAOPFIIOGL(float KJIOHKMJAPE, float FEOJADDJKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C40D60", Offset = "0x7C3FF60", VA = "0x187C40D60")]
	[CompilerGenerated]
	internal static void GMFCAEHPEOO(int KJIOHKMJAPE, int PKDELGAJNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CFD0", Offset = "0x7C4C1D0", VA = "0x187C4CFD0")]
	[CompilerGenerated]
	internal static void HOOBDBIMEPC(float KJIOHKMJAPE, float PKDELGAJNEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AIIECBKFDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C49B40", Offset = "0x7C48D40", VA = "0x187C49B40")]
	public static float EMIAKFOPPKP(this AHMGHDNNAHK AGIIMLNBHAC)
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
		public readonly HGBPNJJFKKI textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EDE0", Offset = "0x7C4DFE0", VA = "0x187C4EDE0")]
		public TextSegmentLayout(LayoutRect layoutRect, HGBPNJJFKKI textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EBB0", Offset = "0x7C4DDB0", VA = "0x187C4EBB0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EC20", Offset = "0x7C4DE20", VA = "0x187C4EC20")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EB50", Offset = "0x7C4DD50", VA = "0x187C4EB50")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class FMHFCEFCIFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig AEBCJJDNFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float LEBMABKMDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float KJMELEPEKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float NENDIHHKEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float NCNGLNEHAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float DDHCNPPKCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float GOOMAEGGJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float LODHMBKGDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float GOHGHKOCGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float KCOIHNEILMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float MHOPJCPKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float HDCEKIHJEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float NEOCCFFKJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly OBPGIACDLKF[] GFFGOCLBDGA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int JKININEEMAJ = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private CHAOEANDBPP[] DHJBNLKOGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int INNOKMDPDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private ELDCPHKBEEL[] DFMHACJLBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int DEFBNEEOPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public OBPGIACDLKF OBDLDCCCDGD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B830", Offset = "0x7C4AA30", VA = "0x187C4B830")]
	public void IJDFNMPLFGP(NNEJHENEMPM HGEHANMEJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B7B0", Offset = "0x7C4A9B0", VA = "0x187C4B7B0")]
	public void IJDFNMPLFGP(GlyphUVConfig CPNDFDKLECF, IEnumerable<ELDCPHKBEEL> JHAGHACKECC, ELDCPHKBEEL GDPLMLGOMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B670", Offset = "0x7C4A870", VA = "0x187C4B670")]
	internal void GBIAKOHDFBL(GlyphUVConfig CPNDFDKLECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BBF0", Offset = "0x7C4ADF0", VA = "0x187C4BBF0")]
	private void PPIJDNLDPMA(IEnumerable<ELDCPHKBEEL> JHAGHACKECC, ELDCPHKBEEL GDPLMLGOMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B8C0", Offset = "0x7C4AAC0", VA = "0x187C4B8C0")]
	public void OEFPLLMDDDC([In] char FOKKCEHPBEF, [Out] float2[] HIJKEMNADFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C479A0", Offset = "0x7C46BA0", VA = "0x187C479A0")]
	private OBPGIACDLKF GIJNBEGLBMI(ELDCPHKBEEL HOPLFPCIJGM)
	{
		return default(OBPGIACDLKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C120", Offset = "0x7C4B320", VA = "0x187C4C120")]
	public FMHFCEFCIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class AKHDKGHNCEM
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C49C30", Offset = "0x7C48E30", VA = "0x187C49C30")]
	public static void EKFEHDCLKGC([In] float LDFNGAACIOL, [In] float FCKMLBNBDOB, [In] int BFBCGOKGKBG, [In] int AEKNNBLKFNG, [In] float NCNGLNEHAKC, [In] float DDHCNPPKCED, [In] float KDDMPCHKLNG, [In] float HEEAHGCMGON, [In] float DGJJEBGBLIM, [In] float IFLOMNEEKGB, [Out] float LFPHAGCIKLF, [Out] float KNDMKDCHMAN, [Out] float PKDGMNOLPGO, [Out] float MPDIBNAADJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C49BD0", Offset = "0x7C48DD0", VA = "0x187C49BD0")]
	public static void EKFEHDCLKGC([In] float LDFNGAACIOL, [In] float FCKMLBNBDOB, [In] int BFBCGOKGKBG, [In] int AEKNNBLKFNG, [Out] float LFPHAGCIKLF, [Out] float KNDMKDCHMAN, [Out] float PKDGMNOLPGO, [Out] float MPDIBNAADJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C49D00", Offset = "0x7C48F00", VA = "0x187C49D00")]
	public static void JFGNOMFGJHP([In] float NCNGLNEHAKC, [In] float DDHCNPPKCED, [In] float MPHBHLDOMKI, [In] float PHGOIAKKECF, [In] float NFFHEHMKGBN, [In] float LHJKCIDLHNC, [Out] float FKIGOLLGDGG, [Out] float ICJPHGGDJOO, [Out] float BGDDGPOJGAC, [Out] float NFINFEICNDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct CHAOEANDBPP
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint AIPDBLCAKHK = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char LDCHNMGBMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly OBPGIACDLKF MHKNIFPODGE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C49D60", Offset = "0x7C48F60", VA = "0x187C49D60")]
	public CHAOEANDBPP(char FOKKCEHPBEF, OBPGIACDLKF HIJKEMNADFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct OBPGIACDLKF
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint AIPDBLCAKHK = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] CCJODAFAHPL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E6C0", Offset = "0x7C4D8C0", VA = "0x187C4E6C0")]
	public OBPGIACDLKF(float LFPHAGCIKLF, float KNDMKDCHMAN, float PKDGMNOLPGO, float MPDIBNAADJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct GKIKJBCIEKG
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int KOENKDEOIDP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal NCBLPDFINKN JGIAFPKBPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] AGLJCAGNHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int BINBADJNMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 CPPJLLDGJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float IMEKHEHAFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 MIAKNKLEAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool JNIFMOIGHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int MAGNNEJGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int IFADAKBCJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int OLEAEAHFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int LMHJJDDFHJA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C1C0", Offset = "0x7C4B3C0", VA = "0x187C4C1C0")]
	public static int BCEECFCOOEJ(int FICEOIDKJAM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum NCBLPDFINKN : byte
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
public static class MMOOONMHDGG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DFF0", Offset = "0x7C4D1F0", VA = "0x187C4DFF0")]
	internal static float EMIAKFOPPKP(this GKIKJBCIEKG MCDKOCJBFKC, float BADLEBKKKGM, float HAMKIGMENIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E030", Offset = "0x7C4D230", VA = "0x187C4E030")]
	internal static void PCDEBMBCGNF(this GKIKJBCIEKG MCDKOCJBFKC, float BADLEBKKKGM, float HAMKIGMENIA, [Out] float2 FHHDCGHGHIP, [Out] float2 AFOBMPBBEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class LLGBFIEBKNN : GKENILLPBOI
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int HHFEHHKKLKG = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int FNGBJPGCGGP = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string DBGEEPNCBAA = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker DOCLPJNNCLH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker BFGOFGJIBIG;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker EIPMDAMNPKE;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker JLGOKKHNPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly INCMEHFOMFK JALBNGKJKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] HGKKHPMBPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] MMLIMELKHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int NFHNBMEBGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int JBPLAJLOGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int IEMKJJDPHFO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GBOCGPJOEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GKENILLPBOI.JGJPOMJNDAF MMCPDFPOIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DEE0", Offset = "0x7C4D0E0", VA = "0x187C4DEE0")]
	public LLGBFIEBKNN(INCMEHFOMFK.IJAPPGCPJLI DNGIOPILPMI, int KHPILHMCCAE, int BBPMHGGGILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DD60", Offset = "0x7C4CF60", VA = "0x187C4DD60", Slot = "5")]
	public bool TryGetMeshBuffer([Out] INCMEHFOMFK JALBNGKJKLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DB10", Offset = "0x7C4CD10", VA = "0x187C4DB10")]
	public void GFFPHBAKGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D210", Offset = "0x7C4C410", VA = "0x187C4D210")]
	public void BBOPOOGMBNG(Span<GKIKJBCIEKG> BLOANAGALBE, FMHFCEFCIFG CHKFAGJMODN, [In] JEIOOIDPCAN HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C487B0", Offset = "0x7C479B0", VA = "0x187C487B0")]
	private void GPONICLJCDD([In] NCBLPDFINKN JGIAFPKBPMC, [In] GKIKJBCIEKG LMNKBOLGJBK, int OADDCAALMLD, [In] float BADLEBKKKGM, [In] float HAMKIGMENIA, FMHFCEFCIFG CHKFAGJMODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D0C0", Offset = "0x7C4C2C0", VA = "0x187C4D0C0")]
	private void ALKLIIAFODJ([In] NCBLPDFINKN JGIAFPKBPMC, GKIKJBCIEKG LMNKBOLGJBK, [In] int LACAANAHKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DB30", Offset = "0x7C4CD30", VA = "0x187C4DB30")]
	public static void KNKJJFHNJIP(ReadOnlySpan<GKIKJBCIEKG> BLOANAGALBE, int OMGFGICHHKB, [Out] int JDLAMOKFAEA, [Out] int OAGHCJFKODC, [Out] int EFMCKGNALBC)
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
