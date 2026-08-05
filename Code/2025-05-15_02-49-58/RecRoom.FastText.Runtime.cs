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
		[Cpp2IlInjected.Address(RVA = "0x7C281E0", Offset = "0x7C267E0", VA = "0x187C281E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C272E0", Offset = "0x7C258E0", VA = "0x187C272E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C274F0", Offset = "0x7C25AF0", VA = "0x187C274F0")]
	public NFJBCJMBBBC(char PPMCKFFJJDP, int BBKEBAAEHIL, int OGHIFCECJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C274D0", Offset = "0x7C25AD0", VA = "0x187C274D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C26900", Offset = "0x7C24F00", VA = "0x187C26900")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C271E0", Offset = "0x7C257E0", VA = "0x187C271E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7C27060", Offset = "0x7C25660", VA = "0x187C27060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7C27050", Offset = "0x7C25650", VA = "0x187C27050")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OIGLFBKKOOL ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7C26A50", Offset = "0x7C25050", VA = "0x187C26A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NFJBCJMBBBC FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7C26EC0", Offset = "0x7C254C0", VA = "0x187C26EC0")]
			get
			{
				return default(NFJBCJMBBBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C26940", Offset = "0x7C24F40", VA = "0x187C26940")]
		internal void ONEJBMEDMAA(IEnumerable<GlyphCoordinateWritable> JIKHFMOAPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C269C0", Offset = "0x7C24FC0", VA = "0x187C269C0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C26920", Offset = "0x7C24F20", VA = "0x187C26920")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2A490", Offset = "0x7C28A90", VA = "0x187C2A490")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A440", Offset = "0x7C28A40", VA = "0x187C2A440")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A260", Offset = "0x7C28860", VA = "0x187C2A260")]
		private void NJAHBFOPOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A580", Offset = "0x7C28B80", VA = "0x187C2A580")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2AC20", Offset = "0x7C29220", VA = "0x187C2AC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PEFFLCIMHDG GLIPKGEJKCP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B090", Offset = "0x7C29690", VA = "0x187C2B090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material MNMBDFJKBOM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2B0C0", Offset = "0x7C296C0", VA = "0x187C2B0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AFF0", Offset = "0x7C295F0", VA = "0x187C2AFF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2ACB0", Offset = "0x7C292B0", VA = "0x187C2ACB0", Slot = "8")]
		protected override void MONPDGAFOHF(CEAHNBAEJOA DPKPFOPKHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B000", Offset = "0x7C29600", VA = "0x187C2B000", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] FAHEMCOEBAF CIHBEAPFOPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AEA0", Offset = "0x7C294A0", VA = "0x187C2AEA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A900", Offset = "0x7C28F00", VA = "0x187C2A900")]
		private void FBKKMFKNKKN(bool ECOALLGHBMI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA072F0", Offset = "0xA058F0", VA = "0x180A072F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C268C0", Offset = "0x7C24EC0", VA = "0x187C268C0")]
	internal DJALJNDNPBJ DNLKJLALKPP()
	{
		return default(DJALJNDNPBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x277ED60", Offset = "0x277D360", VA = "0x18277ED60")]
	internal GGIFIDHOOEA(PEFFLCIMHDG PAKPDHLKNJE, int HHJADMLCOCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BFCNMEKOAAE
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C25520", Offset = "0x7C23B20", VA = "0x187C25520")]
	public static bool AMCBFAFOBOD(this GGIFIDHOOEA BPNOFBAMPIG, HCFKBPKLDFO HBFEHKFDNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C25500", Offset = "0x7C23B00", VA = "0x187C25500")]
	internal static bool AMCBFAFOBOD(this DJALJNDNPBJ ELBLLENNABL, HCFKBPKLDFO HBFEHKFDNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C25570", Offset = "0x7C23B70", VA = "0x187C25570")]
	public static float HPAPMFJDGCC(this GGIFIDHOOEA BPNOFBAMPIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD47950", Offset = "0xD45F50", VA = "0x180D47950")]
	internal static float HPAPMFJDGCC(this DJALJNDNPBJ ELBLLENNABL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PMMMMJBFEOK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C29F40", Offset = "0x7C28540", VA = "0x187C29F40")]
	public static void HKPHEMHFCJA(this GGIFIDHOOEA BPNOFBAMPIG, ReadOnlySpan<char> ELACMCKBEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C29F90", Offset = "0x7C28590", VA = "0x187C29F90")]
	internal static void HKPHEMHFCJA(this DJALJNDNPBJ ELBLLENNABL, ReadOnlySpan<char> ELACMCKBEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A1A0", Offset = "0x7C287A0", VA = "0x187C2A1A0")]
	public static void LFBCHAEPHKL(this GGIFIDHOOEA IMIBILMEOAH, float2 KBCKDFFPKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A190", Offset = "0x7C28790", VA = "0x187C2A190")]
	internal static void LFBCHAEPHKL(this DJALJNDNPBJ ELBLLENNABL, float2 KBCKDFFPKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C29E30", Offset = "0x7C28430", VA = "0x187C29E30")]
	public static void CKCJODOBHGA(this GGIFIDHOOEA IMIBILMEOAH, float KCGHGEMMBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C29DF0", Offset = "0x7C283F0", VA = "0x187C29DF0")]
	internal static void CKCJODOBHGA(this DJALJNDNPBJ ELBLLENNABL, float KCGHGEMMBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C29DC0", Offset = "0x7C283C0", VA = "0x187C29DC0")]
	internal static void BGBLABCFDBL(this DJALJNDNPBJ ELBLLENNABL, bool LMPJONCOFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C29EF0", Offset = "0x7C284F0", VA = "0x187C29EF0")]
	public static void EHAKGAGPGAI(this GGIFIDHOOEA IMIBILMEOAH, Color32 NGGKCKILBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C29F30", Offset = "0x7C28530", VA = "0x187C29F30")]
	internal static void EHAKGAGPGAI(this DJALJNDNPBJ ELBLLENNABL, Color32 NGGKCKILBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C29EA0", Offset = "0x7C284A0", VA = "0x187C29EA0")]
	public static void CPFPEHHIHGP(this GGIFIDHOOEA IMIBILMEOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C29EE0", Offset = "0x7C284E0", VA = "0x187C29EE0")]
	internal static void CPFPEHHIHGP(this DJALJNDNPBJ ELBLLENNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A1F0", Offset = "0x7C287F0", VA = "0x187C2A1F0")]
	internal static void NIDEBKIANBL(this DJALJNDNPBJ ELBLLENNABL, int NKHELGCAJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C29DD0", Offset = "0x7C283D0", VA = "0x187C29DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC43B40", Offset = "0xC42140", VA = "0x180C43B40")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC43B50", Offset = "0xC42150", VA = "0x180C43B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PEFFLCIMHDG NIEKCPFJMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C9D0", Offset = "0x7C1AFD0", VA = "0x187C1C9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CB60", Offset = "0x7C1B160", VA = "0x187C1CB60")]
	public EJKBLMDGOOE(int OPNCELLLELD, PEFFLCIMHDG PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C255C0", Offset = "0x7C23BC0", VA = "0x187C255C0")]
	public bool DOPNGIOHAOC([Out] GGIFIDHOOEA BPNOFBAMPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C257C0", Offset = "0x7C23DC0", VA = "0x187C257C0")]
	public void KKIPOBFIFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CAA0", Offset = "0x7C1B0A0", VA = "0x187C1CAA0")]
	internal void PHDCOBBLCJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C840", Offset = "0x7C1AE40", VA = "0x187C1C840", Slot = "4")]
	public bool Equals(EJKBLMDGOOE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C25690", Offset = "0x7C23C90", VA = "0x187C25690", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C25750", Offset = "0x7C23D50", VA = "0x187C25750", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C29000", Offset = "0x7C27600", VA = "0x187C29000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OIGLFBKKOOL DFNGGEJGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C286B0", Offset = "0x7C26CB0", VA = "0x187C286B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float ECIPFEPKGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C28840", Offset = "0x7C26E40", VA = "0x187C28840")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float IKDCJDAAKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C28820", Offset = "0x7C26E20", VA = "0x187C28820")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BMGOKABNDBN.MMNENOEEBAK AHOOFDJFGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C29980", Offset = "0x7C27F80", VA = "0x187C29980")]
	public PEFFLCIMHDG(PAIINODMHFH NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C29900", Offset = "0x7C27F00", VA = "0x187C29900")]
	public PEFFLCIMHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C286D0", Offset = "0x7C26CD0", VA = "0x187C286D0")]
	public void EEBICEODLFH(GlyphMapAsset PPMJAAALBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C28710", Offset = "0x7C26D10", VA = "0x187C28710")]
	public void EEBICEODLFH(OIGLFBKKOOL GHDIGEKIHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C29630", Offset = "0x7C27C30", VA = "0x187C29630", Slot = "6")]
	public bool TryGetMeshBuffer([Out] FAHEMCOEBAF CIHBEAPFOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C28550", Offset = "0x7C26B50", VA = "0x187C28550")]
	public void AMEAAAFPNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C285B0", Offset = "0x7C26BB0", VA = "0x187C285B0")]
	public bool CPOFHKANGHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C28DA0", Offset = "0x7C273A0", VA = "0x187C28DA0")]
	public EJKBLMDGOOE JMGNGGKGEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C292D0", Offset = "0x7C278D0", VA = "0x187C292D0")]
	public void PKFLNALNHKE(EJKBLMDGOOE OJOIPHOILHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C28CF0", Offset = "0x7C272F0", VA = "0x187C28CF0")]
	internal bool JBGGLKIPEBB(EJKBLMDGOOE OJOIPHOILHN, [Out] GGIFIDHOOEA BPNOFBAMPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C28860", Offset = "0x7C26E60", VA = "0x187C28860")]
	private void GIDFGHNLAHF(DJALJNDNPBJ ELBLLENNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C290F0", Offset = "0x7C276F0", VA = "0x187C290F0")]
	private void OLGGDIKPEPP(int LGBHGDPKOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C29090", Offset = "0x7C27690", VA = "0x187C29090")]
	private bool NLINKDGPKCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FB30", Offset = "0x7C1E130", VA = "0x187C1FB30")]
	private static int GFIHDNIJOEP(EJKBLMDGOOE OJOIPHOILHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20D0AE0", Offset = "0x20CF0E0", VA = "0x1820D0AE0")]
	private static ushort JAMMHHKHNJF(int OHHMJGCBCKD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C289E0", Offset = "0x7C26FE0", VA = "0x187C289E0")]
	private Bounds HNNJBHKDLGF()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C28600", Offset = "0x7C26C00", VA = "0x187C28600", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C28370", Offset = "0x7C26970", VA = "0x187C28370")]
	internal PAIINODMHFH KCIKHHHEPLE()
	{
		return default(PAIINODMHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EB80", Offset = "0x7C1D180", VA = "0x187C1EB80")]
	[CompilerGenerated]
	internal static void CNEPJIABCAB(int OHLIHBDBKCE, int JMMNJNFGHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C28350", Offset = "0x7C26950", VA = "0x187C28350")]
	[CompilerGenerated]
	internal static void GPPDDBACDCG(float OHLIHBDBKCE, float JMMNJNFGHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C1EB90", Offset = "0x7C1D190", VA = "0x187C1EB90")]
	[CompilerGenerated]
	internal static void PFFHAFMCLDB(int OHLIHBDBKCE, int KCAMCHHMDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C28480", Offset = "0x7C26A80", VA = "0x187C28480")]
	[CompilerGenerated]
	internal static void MLMNBFNOPDO(float OHLIHBDBKCE, float KCAMCHHMDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HLBOEONMALC
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C27310", Offset = "0x7C25910", VA = "0x187C27310")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2A890", Offset = "0x7C28E90", VA = "0x187C2A890")]
		public TextSegmentLayout(LayoutRect layoutRect, EJKBLMDGOOE textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A660", Offset = "0x7C28C60", VA = "0x187C2A660")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A6D0", Offset = "0x7C28CD0", VA = "0x187C2A6D0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A600", Offset = "0x7C28C00", VA = "0x187C2A600")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C27A30", Offset = "0x7C26030", VA = "0x187C27A30")]
	public void EEBICEODLFH(OIGLFBKKOOL MBNNCGNOLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C27AC0", Offset = "0x7C260C0", VA = "0x187C27AC0")]
	public void EEBICEODLFH(GlyphUVConfig FNPENNLBGJI, IEnumerable<NFJBCJMBBBC> PPMJAAALBPG, NFJBCJMBBBC GGDIEHILLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C27E70", Offset = "0x7C26470", VA = "0x187C27E70")]
	internal void LBKCPEPNKEF(GlyphUVConfig FNPENNLBGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C27500", Offset = "0x7C25B00", VA = "0x187C27500")]
	private void DMABGHAPLCB(IEnumerable<NFJBCJMBBBC> PPMJAAALBPG, NFJBCJMBBBC GGDIEHILLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C27B40", Offset = "0x7C26140", VA = "0x187C27B40")]
	public void GAPJLOLCLJH([In] char PPMCKFFJJDP, [Out] float2[] BLEMOMJAFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C24F20", Offset = "0x7C23520", VA = "0x187C24F20")]
	private FJLLKFDICEI BMBAODICFIC(NFJBCJMBBBC MFLAFBILFID)
	{
		return default(FJLLKFDICEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C27FB0", Offset = "0x7C265B0", VA = "0x187C27FB0")]
	public NPIDKIFHEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NPONPBHKCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C280B0", Offset = "0x7C266B0", VA = "0x187C280B0")]
	public static void KAJGKDEILLD([In] float NCCMPAJDADB, [In] float PPBFEPDFIFE, [In] int IBOHCMOJLGI, [In] int IEEGLKCJFFI, [In] float MPKACAENMAC, [In] float LNJBKIKMKHH, [In] float FPBJNELPCFA, [In] float IKABBNKMJHG, [In] float DAMPHFCOOFE, [In] float AFHBOKJPMHE, [Out] float LKNCCOLIMOH, [Out] float HIBLCHKAJJG, [Out] float CMCAJOCAOGG, [Out] float NEFHNKNDFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C28180", Offset = "0x7C26780", VA = "0x187C28180")]
	public static void KAJGKDEILLD([In] float NCCMPAJDADB, [In] float PPBFEPDFIFE, [In] int IBOHCMOJLGI, [In] int IEEGLKCJFFI, [Out] float LKNCCOLIMOH, [Out] float HIBLCHKAJJG, [Out] float CMCAJOCAOGG, [Out] float NEFHNKNDFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C28050", Offset = "0x7C26650", VA = "0x187C28050")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C273A0", Offset = "0x7C259A0", VA = "0x187C273A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C267D0", Offset = "0x7C24DD0", VA = "0x187C267D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C255B0", Offset = "0x7C23BB0", VA = "0x187C255B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C27440", Offset = "0x7C25A40", VA = "0x187C27440")]
	internal static float JEAGFLPCDHM(this DJALJNDNPBJ ELBLLENNABL, float OLLOBHNDHFF, float CFIHABOAFLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C273C0", Offset = "0x7C259C0", VA = "0x187C273C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C266C0", Offset = "0x7C24CC0", VA = "0x187C266C0")]
	public FHACFDCMIIC(FAHEMCOEBAF.OJJBNFCPNMO KHLJGMPAICG, int FDAECLMCCKI, int JLDKFICIMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C26540", Offset = "0x7C24B40", VA = "0x187C26540", Slot = "5")]
	public bool TryGetMeshBuffer([Out] FAHEMCOEBAF CIHBEAPFOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C258A0", Offset = "0x7C23EA0", VA = "0x187C258A0")]
	public void AJEJNKMNNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C25AF0", Offset = "0x7C240F0", VA = "0x187C25AF0")]
	public void FHGHDFGPKLA(Span<DJALJNDNPBJ> KFODJCKNFLD, NPIDKIFHEBF CKFOPJIPPGF, [In] PAIINODMHFH NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C237B0", Offset = "0x7C21DB0", VA = "0x187C237B0")]
	private void CINKMCAOCOI([In] HCFKBPKLDFO BEKOIELABAI, [In] DJALJNDNPBJ MKKDOFJKJOI, int OPDOMDGNJLJ, [In] float OLLOBHNDHFF, [In] float CFIHABOAFLE, NPIDKIFHEBF CKFOPJIPPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C263F0", Offset = "0x7C249F0", VA = "0x187C263F0")]
	private void HNKGGNHHLHB([In] HCFKBPKLDFO BEKOIELABAI, DJALJNDNPBJ MKKDOFJKJOI, [In] int MEDNAPGHNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C258C0", Offset = "0x7C23EC0", VA = "0x187C258C0")]
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
