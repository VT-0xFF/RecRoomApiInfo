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
public class OIGLFBKKOOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D NGMHKGFDKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig CBCFPMCGOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public NFJBCJMBBBC[] FFEFCILPCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public NFJBCJMBBBC GNGFLELGDCN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static OIGLFBKKOOL CMDGFKCCOND;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OIGLFBKKOOL EMNJOFPHPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C820", Offset = "0x7C5B820", VA = "0x187C5C820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OIGLFBKKOOL()
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
		[Cpp2IlInjected.Address(RVA = "0x7C5B910", Offset = "0x7C5A910", VA = "0x187C5B910")]
		public GlyphUVConfig(int JDEPMPBOPOB, int OFPKKEIFGMN, int DPNIAKECNEC, int EECNCADODDC, float NDDOIOGJIJE = 0f, [Optional] GlyphPixelInset EEDKOMOFJDI)
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
public readonly struct NFJBCJMBBBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char PMKOHKHEAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int MPHGGEAMBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int CPJMMCLMDLJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly NFJBCJMBBBC MBGILHPMJOO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BB20", Offset = "0x7C5AB20", VA = "0x187C5BB20")]
	public NFJBCJMBBBC(char PPMCKFFJJDP, int BBKEBAAEHIL, int OGHIFCECJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BB00", Offset = "0x7C5AB00", VA = "0x187C5BB00")]
	public NFJBCJMBBBC(GlyphCoordinateWritable MFLAFBILFID)
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
		[Cpp2IlInjected.Address(RVA = "0x7C5AF20", Offset = "0x7C59F20", VA = "0x187C5AF20")]
		public static NFJBCJMBBBC OIFHDJNIHDL(GlyphCoordinateWritable JKIBOICMIDJ)
		{
			return default(NFJBCJMBBBC);
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
		private OIGLFBKKOOL configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B810", Offset = "0x7C5A810", VA = "0x187C5B810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B690", Offset = "0x7C5A690", VA = "0x187C5B690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B680", Offset = "0x7C5A680", VA = "0x187C5B680")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OIGLFBKKOOL ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B070", Offset = "0x7C5A070", VA = "0x187C5B070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NFJBCJMBBBC FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B4F0", Offset = "0x7C5A4F0", VA = "0x187C5B4F0")]
			get
			{
				return default(NFJBCJMBBBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AF60", Offset = "0x7C59F60", VA = "0x187C5AF60")]
		internal void ONEJBMEDMAA(IEnumerable<GlyphCoordinateWritable> JIKHFMOAPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AFE0", Offset = "0x7C59FE0", VA = "0x187C5AFE0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AF40", Offset = "0x7C59F40", VA = "0x187C5AF40")]
		[CompilerGenerated]
		private bool FOGFJNHADJH(GlyphCoordinateWritable JKIBOICMIDJ)
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
		private TextSegmentMeshBufferSource OPNLGJGHDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PEFFLCIMHDG HJIPFIHLJMG;

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
		private EJKBLMDGOOE FABFFCDIEKN;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EAC0", Offset = "0x7C5DAC0", VA = "0x187C5EAC0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EA70", Offset = "0x7C5DA70", VA = "0x187C5EA70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E890", Offset = "0x7C5D890", VA = "0x187C5E890")]
		private void NJAHBFOPOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EBB0", Offset = "0x7C5DBB0", VA = "0x187C5EBB0")]
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
		private bool CDCHADLEAJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material HCHCEOPAGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private PEFFLCIMHDG HJIPFIHLJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material APHLPCGOFEL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private OIGLFBKKOOL AFKPNPBIDNC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F250", Offset = "0x7C5E250", VA = "0x187C5F250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PEFFLCIMHDG GLIPKGEJKCP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F6C0", Offset = "0x7C5E6C0", VA = "0x187C5F6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material MNMBDFJKBOM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F6F0", Offset = "0x7C5E6F0", VA = "0x187C5F6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F620", Offset = "0x7C5E620", VA = "0x187C5F620")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F2E0", Offset = "0x7C5E2E0", VA = "0x187C5F2E0", Slot = "8")]
		protected override void MONPDGAFOHF(CEAHNBAEJOA DPKPFOPKHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F630", Offset = "0x7C5E630", VA = "0x187C5F630", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] FAHEMCOEBAF CIHBEAPFOPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F4D0", Offset = "0x7C5E4D0", VA = "0x187C5F4D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EF30", Offset = "0x7C5DF30", VA = "0x187C5EF30")]
		private void FBKKMFKNKKN(bool ECOALLGHBMI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA0D160", Offset = "0xA0C160", VA = "0x180A0D160")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct GGIFIDHOOEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly PEFFLCIMHDG NIEKCPFJMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int HAKEMGPPCAE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AEE0", Offset = "0x7C59EE0", VA = "0x187C5AEE0")]
	internal DJALJNDNPBJ DNLKJLALKPP()
	{
		return default(DJALJNDNPBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x277DE00", Offset = "0x277CE00", VA = "0x18277DE00")]
	internal GGIFIDHOOEA(PEFFLCIMHDG PAKPDHLKNJE, int HHJADMLCOCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BFCNMEKOAAE
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C59C70", Offset = "0x7C58C70", VA = "0x187C59C70")]
	public static bool AMCBFAFOBOD(this GGIFIDHOOEA BPNOFBAMPIG, HCFKBPKLDFO HBFEHKFDNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C59C50", Offset = "0x7C58C50", VA = "0x187C59C50")]
	internal static bool AMCBFAFOBOD(this DJALJNDNPBJ ELBLLENNABL, HCFKBPKLDFO HBFEHKFDNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C59CC0", Offset = "0x7C58CC0", VA = "0x187C59CC0")]
	public static float HPAPMFJDGCC(this GGIFIDHOOEA BPNOFBAMPIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17E40", VA = "0x180D18E40")]
	internal static float HPAPMFJDGCC(this DJALJNDNPBJ ELBLLENNABL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PMMMMJBFEOK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E570", Offset = "0x7C5D570", VA = "0x187C5E570")]
	public static void HKPHEMHFCJA(this GGIFIDHOOEA BPNOFBAMPIG, ReadOnlySpan<char> ELACMCKBEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E5C0", Offset = "0x7C5D5C0", VA = "0x187C5E5C0")]
	internal static void HKPHEMHFCJA(this DJALJNDNPBJ ELBLLENNABL, ReadOnlySpan<char> ELACMCKBEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E7D0", Offset = "0x7C5D7D0", VA = "0x187C5E7D0")]
	public static void LFBCHAEPHKL(this GGIFIDHOOEA IMIBILMEOAH, float2 KBCKDFFPKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E7C0", Offset = "0x7C5D7C0", VA = "0x187C5E7C0")]
	internal static void LFBCHAEPHKL(this DJALJNDNPBJ ELBLLENNABL, float2 KBCKDFFPKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E460", Offset = "0x7C5D460", VA = "0x187C5E460")]
	public static void CKCJODOBHGA(this GGIFIDHOOEA IMIBILMEOAH, float KCGHGEMMBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E420", Offset = "0x7C5D420", VA = "0x187C5E420")]
	internal static void CKCJODOBHGA(this DJALJNDNPBJ ELBLLENNABL, float KCGHGEMMBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E3F0", Offset = "0x7C5D3F0", VA = "0x187C5E3F0")]
	internal static void BGBLABCFDBL(this DJALJNDNPBJ ELBLLENNABL, bool LMPJONCOFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E520", Offset = "0x7C5D520", VA = "0x187C5E520")]
	public static void EHAKGAGPGAI(this GGIFIDHOOEA IMIBILMEOAH, Color32 NGGKCKILBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E560", Offset = "0x7C5D560", VA = "0x187C5E560")]
	internal static void EHAKGAGPGAI(this DJALJNDNPBJ ELBLLENNABL, Color32 NGGKCKILBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E4D0", Offset = "0x7C5D4D0", VA = "0x187C5E4D0")]
	public static void CPFPEHHIHGP(this GGIFIDHOOEA IMIBILMEOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E510", Offset = "0x7C5D510", VA = "0x187C5E510")]
	internal static void CPFPEHHIHGP(this DJALJNDNPBJ ELBLLENNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E820", Offset = "0x7C5D820", VA = "0x187C5E820")]
	internal static void NIDEBKIANBL(this DJALJNDNPBJ ELBLLENNABL, int NKHELGCAJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E400", Offset = "0x7C5D400", VA = "0x187C5E400")]
	internal static void BGLEDPHAFKI(this DJALJNDNPBJ ELBLLENNABL, int KGBKLHICLBB, HCFKBPKLDFO BEKOIELABAI = HCFKBPKLDFO.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EJKBLMDGOOE : IEquatable<EJKBLMDGOOE>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort DCMCGABCAIA = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int PMAEJPMANJE = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly EJKBLMDGOOE DIOEKOOOAAG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort DDHMIOPJPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC3D180", Offset = "0xC3C180", VA = "0x180C3D180")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC3D190", Offset = "0xC3C190", VA = "0x180C3D190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PEFFLCIMHDG NIEKCPFJMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C514E0", Offset = "0x7C504E0", VA = "0x187C514E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C51670", Offset = "0x7C50670", VA = "0x187C51670")]
	public EJKBLMDGOOE(int OPNCELLLELD, PEFFLCIMHDG PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C59D10", Offset = "0x7C58D10", VA = "0x187C59D10")]
	public bool DOPNGIOHAOC([Out] GGIFIDHOOEA BPNOFBAMPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C59F10", Offset = "0x7C58F10", VA = "0x187C59F10")]
	public void KKIPOBFIFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C515B0", Offset = "0x7C505B0", VA = "0x187C515B0")]
	internal void PHDCOBBLCJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C51350", Offset = "0x7C50350", VA = "0x187C51350", Slot = "4")]
	public bool Equals(EJKBLMDGOOE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C59DE0", Offset = "0x7C58DE0", VA = "0x187C59DE0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C59EA0", Offset = "0x7C58EA0", VA = "0x187C59EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class PEFFLCIMHDG : IDisposable, BMGOKABNDBN
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string DMACMPDOPPL = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker DBDCMILFMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string JGPIPNPJJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly PAIINODMHFH FMEEPCKJBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int LKMBGMIPADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal DJALJNDNPBJ[] ADNNLLJOIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal EJKBLMDGOOE[] FGELALMGIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private OIGLFBKKOOL FPONPPGDACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NPIDKIFHEBF NOKOOFKGGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly FHACFDCMIIC LDJBGHOLAJN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string NFHOBPDKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D660", Offset = "0x7C5C660", VA = "0x187C5D660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OIGLFBKKOOL DFNGGEJGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CD00", Offset = "0x7C5BD00", VA = "0x187C5CD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float ECIPFEPKGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CE90", Offset = "0x7C5BE90", VA = "0x187C5CE90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float IKDCJDAAKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CE70", Offset = "0x7C5BE70", VA = "0x187C5CE70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BMGOKABNDBN.MMNENOEEBAK AHOOFDJFGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DFB0", Offset = "0x7C5CFB0", VA = "0x187C5DFB0")]
	public PEFFLCIMHDG(PAIINODMHFH NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DF30", Offset = "0x7C5CF30", VA = "0x187C5DF30")]
	public PEFFLCIMHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CD20", Offset = "0x7C5BD20", VA = "0x187C5CD20")]
	public void EEBICEODLFH(GlyphMapAsset PPMJAAALBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CD60", Offset = "0x7C5BD60", VA = "0x187C5CD60")]
	public void EEBICEODLFH(OIGLFBKKOOL GHDIGEKIHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DC90", Offset = "0x7C5CC90", VA = "0x187C5DC90", Slot = "6")]
	public bool TryGetMeshBuffer([Out] FAHEMCOEBAF CIHBEAPFOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CBA0", Offset = "0x7C5BBA0", VA = "0x187C5CBA0")]
	public void AMEAAAFPNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CC00", Offset = "0x7C5BC00", VA = "0x187C5CC00")]
	public bool CPOFHKANGHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D3F0", Offset = "0x7C5C3F0", VA = "0x187C5D3F0")]
	public EJKBLMDGOOE JMGNGGKGEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D930", Offset = "0x7C5C930", VA = "0x187C5D930")]
	public void PKFLNALNHKE(EJKBLMDGOOE OJOIPHOILHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D340", Offset = "0x7C5C340", VA = "0x187C5D340")]
	internal bool JBGGLKIPEBB(EJKBLMDGOOE OJOIPHOILHN, [Out] GGIFIDHOOEA BPNOFBAMPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CEB0", Offset = "0x7C5BEB0", VA = "0x187C5CEB0")]
	private void GIDFGHNLAHF(DJALJNDNPBJ ELBLLENNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D750", Offset = "0x7C5C750", VA = "0x187C5D750")]
	private void OLGGDIKPEPP(int LGBHGDPKOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D6F0", Offset = "0x7C5C6F0", VA = "0x187C5D6F0")]
	private bool NLINKDGPKCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C545A0", Offset = "0x7C535A0", VA = "0x187C545A0")]
	private static int GFIHDNIJOEP(EJKBLMDGOOE OJOIPHOILHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20BCF30", Offset = "0x20BBF30", VA = "0x1820BCF30")]
	private static ushort JAMMHHKHNJF(int OHHMJGCBCKD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D030", Offset = "0x7C5C030", VA = "0x187C5D030")]
	private Bounds HNNJBHKDLGF()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CC50", Offset = "0x7C5BC50", VA = "0x187C5CC50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PAIINODMHFH
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly PAIINODMHFH JLMJDFCPMOE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float HJIJHMNGAFJ = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LCCNEDADGFN = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int CEMPGPPBBNP = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color BBNHJPIHOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float IKOGBIDMPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int EHDJOGCGOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int JADDLCBLKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int FFLJDIIOPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int IDHLBOLKMMD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C9C0", Offset = "0x7C5B9C0", VA = "0x187C5C9C0")]
	internal PAIINODMHFH KCIKHHHEPLE()
	{
		return default(PAIINODMHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C535E0", Offset = "0x7C525E0", VA = "0x187C535E0")]
	[CompilerGenerated]
	internal static void CNEPJIABCAB(int OHLIHBDBKCE, int JMMNJNFGHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C9A0", Offset = "0x7C5B9A0", VA = "0x187C5C9A0")]
	[CompilerGenerated]
	internal static void GPPDDBACDCG(float OHLIHBDBKCE, float JMMNJNFGHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C535F0", Offset = "0x7C525F0", VA = "0x187C535F0")]
	[CompilerGenerated]
	internal static void PFFHAFMCLDB(int OHLIHBDBKCE, int KCAMCHHMDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CAD0", Offset = "0x7C5BAD0", VA = "0x187C5CAD0")]
	[CompilerGenerated]
	internal static void MLMNBFNOPDO(float OHLIHBDBKCE, float KCAMCHHMDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HLBOEONMALC
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B940", Offset = "0x7C5A940", VA = "0x187C5B940")]
	public static float JEAGFLPCDHM(this GGIFIDHOOEA JDFLCPMEMJN)
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
		public readonly EJKBLMDGOOE textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EEC0", Offset = "0x7C5DEC0", VA = "0x187C5EEC0")]
		public TextSegmentLayout(LayoutRect layoutRect, EJKBLMDGOOE textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EC90", Offset = "0x7C5DC90", VA = "0x187C5EC90")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C5ED00", Offset = "0x7C5DD00", VA = "0x187C5ED00")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EC30", Offset = "0x7C5DC30", VA = "0x187C5EC30")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class NPIDKIFHEBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig OLPPAEGNFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float HKGICAEBEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float HDPBELCDAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float ENHMOKLENIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float MPKACAENMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float LNJBKIKMKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float DLEEODHBPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float PNHMKKINEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float PFKDGAKLFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float ANPPFCMCEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float IKDCJDAAKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float BHOFLMOIBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float ECIPFEPKGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly FJLLKFDICEI[] FMIOPLGOINM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int GBGCHPBDKMP = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private MOMJECJJBLN[] LABKNDMCMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int LEOEDDFJLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NFJBCJMBBBC[] PHKDDIFLJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int KCEOLAMPCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FJLLKFDICEI FHFFOCBMMJG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C070", Offset = "0x7C5B070", VA = "0x187C5C070")]
	public void EEBICEODLFH(OIGLFBKKOOL MBNNCGNOLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C100", Offset = "0x7C5B100", VA = "0x187C5C100")]
	public void EEBICEODLFH(GlyphUVConfig FNPENNLBGJI, IEnumerable<NFJBCJMBBBC> PPMJAAALBPG, NFJBCJMBBBC GGDIEHILLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C4B0", Offset = "0x7C5B4B0", VA = "0x187C5C4B0")]
	internal void LBKCPEPNKEF(GlyphUVConfig FNPENNLBGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BB30", Offset = "0x7C5AB30", VA = "0x187C5BB30")]
	private void DMABGHAPLCB(IEnumerable<NFJBCJMBBBC> PPMJAAALBPG, NFJBCJMBBBC GGDIEHILLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C180", Offset = "0x7C5B180", VA = "0x187C5C180")]
	public void GAPJLOLCLJH([In] char PPMCKFFJJDP, [Out] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C59670", Offset = "0x7C58670", VA = "0x187C59670")]
	private FJLLKFDICEI BMBAODICFIC(NFJBCJMBBBC MFLAFBILFID)
	{
		return default(FJLLKFDICEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C5F0", Offset = "0x7C5B5F0", VA = "0x187C5C5F0")]
	public NPIDKIFHEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NPONPBHKCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C6F0", Offset = "0x7C5B6F0", VA = "0x187C5C6F0")]
	public static void KAJGKDEILLD([In] float NCCMPAJDADB, [In] float PPBFEPDFIFE, [In] int IBOHCMOJLGI, [In] int IEEGLKCJFFI, [In] float MPKACAENMAC, [In] float LNJBKIKMKHH, [In] float FPBJNELPCFA, [In] float IKABBNKMJHG, [In] float DAMPHFCOOFE, [In] float AFHBOKJPMHE, [Out] float LKNCCOLIMOH, [Out] float HIBLCHKAJJG, [Out] float CMCAJOCAOGG, [Out] float NEFHNKNDFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C7C0", Offset = "0x7C5B7C0", VA = "0x187C5C7C0")]
	public static void KAJGKDEILLD([In] float NCCMPAJDADB, [In] float PPBFEPDFIFE, [In] int IBOHCMOJLGI, [In] int IEEGLKCJFFI, [Out] float LKNCCOLIMOH, [Out] float HIBLCHKAJJG, [Out] float CMCAJOCAOGG, [Out] float NEFHNKNDFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C690", Offset = "0x7C5B690", VA = "0x187C5C690")]
	public static void AEJGOIMBOCG([In] float MPKACAENMAC, [In] float LNJBKIKMKHH, [In] float EPLHACHINOL, [In] float GOGDBDJPHNP, [In] float MPEDOOLKGIB, [In] float DICFJHNPHBI, [Out] float DGMJAKGPKGP, [Out] float JFPOJNJJOML, [Out] float PDFHLOJJOJD, [Out] float LEANJMDFCCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct MOMJECJJBLN
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint HGCPKFGDLKO = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char PMKOHKHEAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly FJLLKFDICEI DDDPEHCFCKI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B9D0", Offset = "0x7C5A9D0", VA = "0x187C5B9D0")]
	public MOMJECJJBLN(char PPMCKFFJJDP, FJLLKFDICEI BLEMOMJAFJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FJLLKFDICEI
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint HGCPKFGDLKO = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] GNBJGLIKPOA;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C5ADF0", Offset = "0x7C59DF0", VA = "0x187C5ADF0")]
	public FJLLKFDICEI(float LKNCCOLIMOH, float HIBLCHKAJJG, float CMCAJOCAOGG, float NEFHNKNDFLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct DJALJNDNPBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int FKNFDPGEICA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal HCFKBPKLDFO BEKOIELABAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] KNCNKPHGOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int LKPIELEIDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 KBCKDFFPKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float LCNJMONAENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 NAPPHDMBELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool LMPJONCOFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int BHIBNLIPJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int BMFOJBAJOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int NLBHKGDFNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int FLEICJHLGDL;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C59D00", Offset = "0x7C58D00", VA = "0x187C59D00")]
	public static int CAGNIALLEIB(int FICEDIOADKB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum HCFKBPKLDFO : byte
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
public static class NDGLEMMAKHG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BA70", Offset = "0x7C5AA70", VA = "0x187C5BA70")]
	internal static float JEAGFLPCDHM(this DJALJNDNPBJ ELBLLENNABL, float OLLOBHNDHFF, float CFIHABOAFLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C5B9F0", Offset = "0x7C5A9F0", VA = "0x187C5B9F0")]
	internal static void HGKLIGEENFM(this DJALJNDNPBJ ELBLLENNABL, float OLLOBHNDHFF, float CFIHABOAFLE, [Out] float2 COJGDIKBGKB, [Out] float2 JNIBMOMFMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class FHACFDCMIIC : BMGOKABNDBN
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int LOLNEJEDGGA = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int GFFHKEJGAEM = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string DMACMPDOPPL = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker HAIEMBBNANE;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker IJMBKLKEDNB;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker KIIKMOEFCLB;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker LKHPKIJKMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly FAHEMCOEBAF CIHBEAPFOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] CEMDFEECHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] KNBENIPPCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int LADHPJAICPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int DONIPDDKKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int DNGPHCGHNMJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string NFHOBPDKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BMGOKABNDBN.MMNENOEEBAK AHOOFDJFGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5ACE0", Offset = "0x7C59CE0", VA = "0x187C5ACE0")]
	public FHACFDCMIIC(FAHEMCOEBAF.OJJBNFCPNMO KHLJGMPAICG, int FDAECLMCCKI, int JLDKFICIMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AB50", Offset = "0x7C59B50", VA = "0x187C5AB50", Slot = "5")]
	public bool TryGetMeshBuffer([Out] FAHEMCOEBAF CIHBEAPFOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C59FF0", Offset = "0x7C58FF0", VA = "0x187C59FF0")]
	public void AJEJNKMNNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A220", Offset = "0x7C59220", VA = "0x187C5A220")]
	public void FHGHDFGPKLA(Span<DJALJNDNPBJ> KFODJCKNFLD, NPIDKIFHEBF CKFOPJIPPGF, [In] PAIINODMHFH NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C58020", Offset = "0x7C57020", VA = "0x187C58020")]
	private void CINKMCAOCOI([In] HCFKBPKLDFO BEKOIELABAI, [In] DJALJNDNPBJ MKKDOFJKJOI, int OPDOMDGNJLJ, [In] float OLLOBHNDHFF, [In] float CFIHABOAFLE, NPIDKIFHEBF CKFOPJIPPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C5AA00", Offset = "0x7C59A00", VA = "0x187C5AA00")]
	private void HNKGGNHHLHB([In] HCFKBPKLDFO BEKOIELABAI, DJALJNDNPBJ MKKDOFJKJOI, [In] int MEDNAPGHNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A010", Offset = "0x7C59010", VA = "0x187C5A010")]
	public static void CFFIHAPKBHI(ReadOnlySpan<DJALJNDNPBJ> KFODJCKNFLD, int CPHGILPKKEK, [Out] int ECHEHGPJGPO, [Out] int LHEAAPFOGHO, [Out] int KPJDOFDDGNJ)
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
