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
public class LLMKOGGELCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D MCIOPCNHIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig KOJPACNKILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public AMJGIEGHLGI[] KNMFKHGFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public AMJGIEGHLGI AHCNALKNFJE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static LLMKOGGELCG MMDELPLKIKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LLMKOGGELCG JBNOHHABKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DE0990", Offset = "0x6DDFD90", VA = "0x186DE0990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public LLMKOGGELCG()
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
		[Cpp2IlInjected.Address(RVA = "0x6DE0560", Offset = "0x6DDF960", VA = "0x186DE0560")]
		public GlyphUVConfig(int PGDOABDDPJI, int IBCKBAFMDMH, int NABEPIECHHC, int CNOAKDLGJEF, float DFMLMKBJGFH = 0f, [Optional] GlyphPixelInset LGDCIOGIHBD)
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
public readonly struct AMJGIEGHLGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char ODHIGFFIIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int MHLHLNBPEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int FAOKAGKNAJN;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly AMJGIEGHLGI KFOLDIOFAEJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE560", Offset = "0x6DDD960", VA = "0x186DDE560")]
	public AMJGIEGHLGI(char EIKDDJPEDLA, int MNFFFFCJOAM, int NEMPHKIIFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE570", Offset = "0x6DDD970", VA = "0x186DDE570")]
	public AMJGIEGHLGI(GlyphCoordinateWritable BJNOIJDPKHI)
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
		[Cpp2IlInjected.Address(RVA = "0x6DDFB80", Offset = "0x6DDEF80", VA = "0x186DDFB80")]
		public static AMJGIEGHLGI ICFKEBCLOFF(GlyphCoordinateWritable HPAGGPJLKCH)
		{
			return default(AMJGIEGHLGI);
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
		private LLMKOGGELCG configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6DE0460", Offset = "0x6DDF860", VA = "0x186DE0460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6DE02E0", Offset = "0x6DDF6E0", VA = "0x186DE02E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8ADBA0", Offset = "0x8ACFA0", VA = "0x1808ADBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6DE02D0", Offset = "0x6DDF6D0", VA = "0x186DE02D0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LLMKOGGELCG ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6DDFCD0", Offset = "0x6DDF0D0", VA = "0x186DDFCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private AMJGIEGHLGI FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6DE0140", Offset = "0x6DDF540", VA = "0x186DE0140")]
			get
			{
				return default(AMJGIEGHLGI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DDFBA0", Offset = "0x6DDEFA0", VA = "0x186DDFBA0")]
		internal void GHHHLODAMEL(IEnumerable<GlyphCoordinateWritable> GEJMKDEMIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DDFC40", Offset = "0x6DDF040", VA = "0x186DDFC40")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DDFC20", Offset = "0x6DDF020", VA = "0x186DDFC20")]
		[CompilerGenerated]
		private bool LBGGNJIPIKL(GlyphCoordinateWritable HPAGGPJLKCH)
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
		private TextSegmentMeshBufferSource OENAFHFKMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PLDMCPGBJEG JOBBHPPFBIN;

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
		private FMGJPBDMNNI CHOGEGFHEKH;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3240", Offset = "0x6DE2640", VA = "0x186DE3240")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DE31F0", Offset = "0x6DE25F0", VA = "0x186DE31F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3030", Offset = "0x6DE2430", VA = "0x186DE3030")]
		private void HPMFKELOIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3330", Offset = "0x6DE2730", VA = "0x186DE3330")]
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
		private bool BMKCNLGIEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material HNMHPHBLJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private PLDMCPGBJEG JOBBHPPFBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material NFFEDGJIBJA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private LLMKOGGELCG KCMLOJOACKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6DE36B0", Offset = "0x6DE2AB0", VA = "0x186DE36B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PLDMCPGBJEG FJPLHENLCNC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6DE3E40", Offset = "0x6DE3240", VA = "0x186DE3E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material FLNGOPACOMD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6DE3E70", Offset = "0x6DE3270", VA = "0x186DE3E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3DA0", Offset = "0x6DE31A0", VA = "0x186DE3DA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3A60", Offset = "0x6DE2E60", VA = "0x186DE3A60", Slot = "8")]
		protected override void NGBLNCJIBCH(GEJIGLEOFAM IJIFJNBPMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3DB0", Offset = "0x6DE31B0", VA = "0x186DE3DB0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] ODPLLGPLIAJ GMLODHKHAAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3C50", Offset = "0x6DE3050", VA = "0x186DE3C50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3740", Offset = "0x6DE2B40", VA = "0x186DE3740")]
		private void ICPHAGLDGBC(bool DPEDJCGKFCE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C7430", Offset = "0x8C6830", VA = "0x1808C7430")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct NFOHBOOCHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly PLDMCPGBJEG BLNPFNKOKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int BIGKLJMBLDN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1670", Offset = "0x6DE0A70", VA = "0x186DE1670")]
	internal NODPIHKBIGM DMECDANFLCP()
	{
		return default(NODPIHKBIGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x221ABF0", Offset = "0x2219FF0", VA = "0x18221ABF0")]
	internal NFOHBOOCHEF(PLDMCPGBJEG HPCAPMNEHGA, int EAHPBLCOJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class COGMIBMOBPC
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE590", Offset = "0x6DDD990", VA = "0x186DDE590")]
	public static bool CFMDIABEPAE(this NFOHBOOCHEF NJANANONHMI, FBJODDFPIKJ PPEANMAGMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE5E0", Offset = "0x6DDD9E0", VA = "0x186DDE5E0")]
	internal static bool CFMDIABEPAE(this NODPIHKBIGM LJKBFAGBJPI, FBJODDFPIKJ PPEANMAGMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE600", Offset = "0x6DDDA00", VA = "0x186DDE600")]
	public static float LCLFIKNBELJ(this NFOHBOOCHEF NJANANONHMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBBF830", Offset = "0xBBEC30", VA = "0x180BBF830")]
	internal static float LCLFIKNBELJ(this NODPIHKBIGM LJKBFAGBJPI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IJALBEGJECK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DDDFB0", Offset = "0x6DDD3B0", VA = "0x186DDDFB0")]
	public static void NAHMJCBFKMO(this NFOHBOOCHEF NJANANONHMI, ReadOnlySpan<char> NICGADOGAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE06D0", Offset = "0x6DDFAD0", VA = "0x186DE06D0")]
	internal static void NAHMJCBFKMO(this NODPIHKBIGM LJKBFAGBJPI, ReadOnlySpan<char> NICGADOGAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0820", Offset = "0x6DDFC20", VA = "0x186DE0820")]
	public static void NPGGKGMDCMP(this NFOHBOOCHEF DGBABHLFLEI, float2 GMCAOLCJNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0870", Offset = "0x6DDFC70", VA = "0x186DE0870")]
	internal static void NPGGKGMDCMP(this NODPIHKBIGM LJKBFAGBJPI, float2 GMCAOLCJNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0680", Offset = "0x6DDFA80", VA = "0x186DE0680")]
	public static void DCNMIHCAHGF(this NFOHBOOCHEF DGBABHLFLEI, float NJIGEADDHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0670", Offset = "0x6DDFA70", VA = "0x186DE0670")]
	internal static void DCNMIHCAHGF(this NODPIHKBIGM LJKBFAGBJPI, float NJIGEADDHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE06C0", Offset = "0x6DDFAC0", VA = "0x186DE06C0")]
	internal static void MGPFOHEJJBF(this NODPIHKBIGM LJKBFAGBJPI, bool OKNECPCPNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0880", Offset = "0x6DDFC80", VA = "0x186DE0880")]
	public static void OCDPFKHMGLA(this NFOHBOOCHEF DGBABHLFLEI, Color32 DFKHKPKCOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DE08C0", Offset = "0x6DDFCC0", VA = "0x186DE08C0")]
	internal static void OCDPFKHMGLA(this NODPIHKBIGM LJKBFAGBJPI, Color32 DFKHKPKCOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0620", Offset = "0x6DDFA20", VA = "0x186DE0620")]
	public static void CBBBGNFJIGA(this NFOHBOOCHEF DGBABHLFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0660", Offset = "0x6DDFA60", VA = "0x186DE0660")]
	internal static void CBBBGNFJIGA(this NODPIHKBIGM LJKBFAGBJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0590", Offset = "0x6DDF990", VA = "0x186DE0590")]
	internal static void ADIDMHOOIEC(this NODPIHKBIGM LJKBFAGBJPI, int IENNNFBLALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0600", Offset = "0x6DDFA00", VA = "0x186DE0600")]
	internal static void BNIALNKOLBD(this NODPIHKBIGM LJKBFAGBJPI, int ABLCDBNMKAL, FBJODDFPIKJ NDLIPLCPCAJ = FBJODDFPIKJ.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FMGJPBDMNNI : IEquatable<FMGJPBDMNNI>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort AAABCHLPFJB = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int IIFMJCBAMDI = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly FMGJPBDMNNI LPJHEJHDPOE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort JNHBMBKCNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBA60", Offset = "0x1FFAE60", VA = "0x181FFBA60")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBA70", Offset = "0x1FFAE70", VA = "0x181FFBA70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PLDMCPGBJEG BLNPFNKOKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OOLCMFGMABL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8000", Offset = "0x6DD7400", VA = "0x186DD8000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD8320", Offset = "0x6DD7720", VA = "0x186DD8320")]
	public FMGJPBDMNNI(int IKAIKPNCDOG, PLDMCPGBJEG HPCAPMNEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF870", Offset = "0x6DDEC70", VA = "0x186DDF870")]
	public bool FPMHFLGADPG([Out] NFOHBOOCHEF NJANANONHMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF9B0", Offset = "0x6DDEDB0", VA = "0x186DDF9B0")]
	public void PHDJEGBOJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD81A0", Offset = "0x6DD75A0", VA = "0x186DD81A0")]
	internal void HMDOHHJCMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD80D0", Offset = "0x6DD74D0", VA = "0x186DD80D0", Slot = "4")]
	public bool Equals(FMGJPBDMNNI OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF7B0", Offset = "0x6DDEBB0", VA = "0x186DDF7B0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF940", Offset = "0x6DDED40", VA = "0x186DDF940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class PLDMCPGBJEG : IDisposable, PCCGAENHOOD
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string ADIAKPDBNII = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker JJELCFGLFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string EDFNEBEONAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly FJNKMKEKAHJ CMKIEOBFAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int IJHAHDIOFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal NODPIHKBIGM[] NHPIMIKHKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FMGJPBDMNNI[] JHOFJICDHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private LLMKOGGELCG DBEPPMDDAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly LNIPGNHEPCD AHFDFPIADPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly ELLNADAECFE LNIJJIKJHJJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string ADANIHOIEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2450", Offset = "0x6DE1850", VA = "0x186DE2450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CHHMCKFPFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8C8A90", Offset = "0x8C7E90", VA = "0x1808C8A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LLMKOGGELCG BHKJPNAPCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2880", Offset = "0x6DE1C80", VA = "0x186DE2880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float OGAGJIKOANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6DE27A0", Offset = "0x6DE1BA0", VA = "0x186DE27A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OLPIHNLJBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DE2780", Offset = "0x6DE1B80", VA = "0x186DE2780")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public PCCGAENHOOD.LHEKNNEEKGE IKBLIHFBPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC00", Offset = "0x8AD000", VA = "0x1808ADC00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB70", Offset = "0x8ACF70", VA = "0x1808ADB70", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2B70", Offset = "0x6DE1F70", VA = "0x186DE2B70")]
	public PLDMCPGBJEG(FJNKMKEKAHJ IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2FB0", Offset = "0x6DE23B0", VA = "0x186DE2FB0")]
	public PLDMCPGBJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE24E0", Offset = "0x6DE18E0", VA = "0x186DE24E0")]
	public void LHMGAKDCLGK(GlyphMapAsset LPFDEBAMALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2520", Offset = "0x6DE1920", VA = "0x186DE2520")]
	public void LHMGAKDCLGK(LLMKOGGELCG DMCPDKIDLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE28A0", Offset = "0x6DE1CA0", VA = "0x186DE28A0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] ODPLLGPLIAJ GMLODHKHAAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2820", Offset = "0x6DE1C20", VA = "0x186DE2820")]
	public void OILBJJMBDID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2400", Offset = "0x6DE1800", VA = "0x186DE2400")]
	public bool JNJPOLKKFFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1800", Offset = "0x6DE0C00", VA = "0x186DE1800")]
	public FMGJPBDMNNI COBDDJLNMFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1AE0", Offset = "0x6DE0EE0", VA = "0x186DE1AE0")]
	public void EBHJIOEPJMA(FMGJPBDMNNI PGEDHJKGAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2350", Offset = "0x6DE1750", VA = "0x186DE2350")]
	internal bool FLKNOEJKIKK(FMGJPBDMNNI PGEDHJKGAIG, [Out] NFOHBOOCHEF NJANANONHMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2630", Offset = "0x6DE1A30", VA = "0x186DE2630")]
	private void LNGCOGGJGOO(NODPIHKBIGM LJKBFAGBJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1E60", Offset = "0x6DE1260", VA = "0x186DE1E60")]
	private void FLBFIHJIJGL(int OCCGANJPJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DE27C0", Offset = "0x6DE1BC0", VA = "0x186DE27C0")]
	private bool OBEALOLDMDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7760", Offset = "0x6DD6B60", VA = "0x186DD7760")]
	private static int NCPNEPKJJBA(FMGJPBDMNNI PGEDHJKGAIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1B87C60", Offset = "0x1B87060", VA = "0x181B87C60")]
	private static ushort JIKDBCBKCKM(int AEAHMAMPNLO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2040", Offset = "0x6DE1440", VA = "0x186DE2040")]
	private Bounds FLFCNMKCHMM()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1A30", Offset = "0x6DE0E30", VA = "0x186DE1A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FJNKMKEKAHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly FJNKMKEKAHJ NEAMLACIDJP;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float GMEMBNNGBHF = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LLJBEMFLLNE = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int FNOIIEGAEHP = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color MIPPELMLNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float DMKOLLNOFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int EHHLGDPFKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int FKKKPDMEDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int AIAFHDKLHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int MIOAOCCDKMA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF5B0", Offset = "0x6DDE9B0", VA = "0x186DDF5B0")]
	internal FJNKMKEKAHJ KIIHFEBOPIM()
	{
		return default(FJNKMKEKAHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6240", Offset = "0x6DD5640", VA = "0x186DD6240")]
	[CompilerGenerated]
	internal static void BCFDOIKGMEO(int LIHHDPOHLDK, int JGBDACMOCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF6E0", Offset = "0x6DDEAE0", VA = "0x186DDF6E0")]
	[CompilerGenerated]
	internal static void MIEIBMEDCMB(float LIHHDPOHLDK, float JGBDACMOCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6190", Offset = "0x6DD5590", VA = "0x186DD6190")]
	[CompilerGenerated]
	internal static void JGBCLNBOPLO(int LIHHDPOHLDK, int JKJCEICIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF6C0", Offset = "0x6DDEAC0", VA = "0x186DDF6C0")]
	[CompilerGenerated]
	internal static void KNBABBIGJEI(float LIHHDPOHLDK, float JKJCEICIPFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NOIGIIFMBJP
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1750", Offset = "0x6DE0B50", VA = "0x186DE1750")]
	public static (int, int) HABJMLPLMIP(this PLDMCPGBJEG DKEPCFIJJOF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DE16C0", Offset = "0x6DE0AC0", VA = "0x186DE16C0")]
	public static float DFPBCKJPENN(this NFOHBOOCHEF DOPNMHOFILG)
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
		public readonly FMGJPBDMNNI textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3640", Offset = "0x6DE2A40", VA = "0x186DE3640")]
		public TextSegmentLayout(LayoutRect layoutRect, FMGJPBDMNNI textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3410", Offset = "0x6DE2810", VA = "0x186DE3410")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3480", Offset = "0x6DE2880", VA = "0x186DE3480")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DE33B0", Offset = "0x6DE27B0", VA = "0x186DE33B0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class LNIPGNHEPCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig MAANFIFGLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float ALEOOKNKAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float GANLNFEBPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float MOAONNNBAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float IGIGHEKMFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float DFNHKLCNBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float OKMGGBIEONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float CNMJONCNOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float GOBHPJDKFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float MFCHIOKKLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float OLPIHNLJBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float MBMKPBDJAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float OGAGJIKOANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly FNBMPLCLIPI[] OBKNACGKPMG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int IAOFEKKIJNI = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private MAGIAKCEBIK[] LMKGNGKHFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int OLAOLKBGNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private AMJGIEGHLGI[] LKKAFEAKFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int GCCKANFKIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FNBMPLCLIPI MGBDEPNDJFN;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6DE14A0", Offset = "0x6DE08A0", VA = "0x186DE14A0")]
	public void LHMGAKDCLGK(LLMKOGGELCG LFCJEGNENDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1530", Offset = "0x6DE0930", VA = "0x186DE1530")]
	public void LHMGAKDCLGK(GlyphUVConfig KLEEFFPMJGM, IEnumerable<AMJGIEGHLGI> LPFDEBAMALP, AMJGIEGHLGI KJDIJLFGKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0B00", Offset = "0x6DDFF00", VA = "0x186DE0B00")]
	internal void DCJLDJJPEMM(GlyphUVConfig KLEEFFPMJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0C40", Offset = "0x6DE0040", VA = "0x186DE0C40")]
	private void IOIOEAHHDCO(IEnumerable<AMJGIEGHLGI> LPFDEBAMALP, AMJGIEGHLGI KJDIJLFGKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1170", Offset = "0x6DE0570", VA = "0x186DE1170")]
	public void KIMDPJNHJNB([In] char EIKDDJPEDLA, [Out] float2[] BJGILMMONOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE130", Offset = "0x6DDD530", VA = "0x186DDE130")]
	private FNBMPLCLIPI BHENOCDLIAI(AMJGIEGHLGI BJNOIJDPKHI)
	{
		return default(FNBMPLCLIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE15B0", Offset = "0x6DE09B0", VA = "0x186DE15B0")]
	public LNIPGNHEPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DMDMNMNHHPP
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE6A0", Offset = "0x6DDDAA0", VA = "0x186DDE6A0")]
	public static void OLFCDFBADLB([In] float HNICFKEFNBG, [In] float JLADKMBANCN, [In] int FPEIEKBEDGN, [In] int LPFIGMNNJNC, [In] float IGIGHEKMFGJ, [In] float DFNHKLCNBLJ, [In] float FBPINCOBMGJ, [In] float GBHNADKGBBN, [In] float HPJGPNDBEEJ, [In] float INFMKBIGGOK, [Out] float GBIMCHOCCLH, [Out] float DAEKGIKPEJH, [Out] float GCFPLDJHPAF, [Out] float OOFIDBDMHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE770", Offset = "0x6DDDB70", VA = "0x186DDE770")]
	public static void OLFCDFBADLB([In] float HNICFKEFNBG, [In] float JLADKMBANCN, [In] int FPEIEKBEDGN, [In] int LPFIGMNNJNC, [Out] float GBIMCHOCCLH, [Out] float DAEKGIKPEJH, [Out] float GCFPLDJHPAF, [Out] float OOFIDBDMHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE640", Offset = "0x6DDDA40", VA = "0x186DDE640")]
	public static void BMBPOKELKHN([In] float IGIGHEKMFGJ, [In] float DFNHKLCNBLJ, [In] float HOIDHOLOPDC, [In] float KJLHJHGDFFO, [In] float ICBOPJFNNJH, [In] float PKIPNJIIAPH, [Out] float IFMDLGACOBG, [Out] float KGBMAECNKFN, [Out] float OEBFOCEEJAM, [Out] float CCCCCLPOFIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct MAGIAKCEBIK
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint OGJBNGDKDHL = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char ODHIGFFIIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly FNBMPLCLIPI NKNMABHEIIE;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1650", Offset = "0x6DE0A50", VA = "0x186DE1650")]
	public MAGIAKCEBIK(char EIKDDJPEDLA, FNBMPLCLIPI BJGILMMONOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FNBMPLCLIPI
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint OGJBNGDKDHL = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] KOBOIFIKHCL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6DDFA90", Offset = "0x6DDEE90", VA = "0x186DDFA90")]
	public FNBMPLCLIPI(float GBIMCHOCCLH, float DAEKGIKPEJH, float GCFPLDJHPAF, float OOFIDBDMHPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct NODPIHKBIGM
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int JLDBHAKIAIB = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal FBJODDFPIKJ NDLIPLCPCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] JGOAMMDDMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int GHFHFHKOJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 GMCAOLCJNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float LMCPLMHOMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 IOFDGGAPBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool OKNECPCPNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int MKLPKCKFBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int CHFCHCOCEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int LOIEAIEPMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int DDMFNPENOPI;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6DE16B0", Offset = "0x6DE0AB0", VA = "0x186DE16B0")]
	public static int JOONLMPCBDO(int PIBCNJIIPDH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum FBJODDFPIKJ : byte
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
public static class JAELMLLIOIO
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0950", Offset = "0x6DDFD50", VA = "0x186DE0950")]
	internal static float DFPBCKJPENN(this NODPIHKBIGM LJKBFAGBJPI, float CHAIPAGNPLF, float MHKLLEOAKAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE08D0", Offset = "0x6DDFCD0", VA = "0x186DE08D0")]
	internal static void BFALPBGCMGO(this NODPIHKBIGM LJKBFAGBJPI, float CHAIPAGNPLF, float MHKLLEOAKAB, [Out] float2 GOCGGGCOOLH, [Out] float2 GGBNJANNJDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class ELLNADAECFE : PCCGAENHOOD
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int AELGOENGEAE = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int KAFDEJIHJDD = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string ADIAKPDBNII = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static CFPJPCANOHC MONPNPHHKGD;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static CFPJPCANOHC LBDEKCBNEHD;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static CFPJPCANOHC IEKNKBFLEMN;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static CFPJPCANOHC NGMPKFGFEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly ODPLLGPLIAJ GMLODHKHAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] NCIENMLGPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] LLNDLHNGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int GKGBABNBDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int LCOHCJFPOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int GPGMDKOMPOA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ADANIHOIEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public PCCGAENHOOD.LHEKNNEEKGE IKBLIHFBPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF4A0", Offset = "0x6DDE8A0", VA = "0x186DDF4A0")]
	public ELLNADAECFE(ODPLLGPLIAJ.MEFEAAAPBKJ PHNGLLGCBFE, int BELPKBLMPNG, int MKMEDHIDAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF320", Offset = "0x6DDE720", VA = "0x186DDF320", Slot = "5")]
	public bool TryGetMeshBuffer([Out] ODPLLGPLIAJ GMLODHKHAAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE9A0", Offset = "0x6DDDDA0", VA = "0x186DDE9A0")]
	public void LDLNLJGNDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE9C0", Offset = "0x6DDDDC0", VA = "0x186DDE9C0")]
	public void NGOOHLLBPCA(Span<NODPIHKBIGM> ANLGEKMHCGN, LNIPGNHEPCD BGNODHBOPNP, [In] FJNKMKEKAHJ IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC7E0", Offset = "0x6DDBBE0", VA = "0x186DDC7E0")]
	private void EJKAPKHJDII([In] FBJODDFPIKJ NDLIPLCPCAJ, [In] NODPIHKBIGM LHFONEIAODN, int JANNIFJJEIC, [In] float CHAIPAGNPLF, [In] float MHKLLEOAKAB, LNIPGNHEPCD BGNODHBOPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF1D0", Offset = "0x6DDE5D0", VA = "0x186DDF1D0")]
	private void POLJIDJLFOE([In] FBJODDFPIKJ NDLIPLCPCAJ, NODPIHKBIGM LHFONEIAODN, [In] int BHJOKKDPLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE7D0", Offset = "0x6DDDBD0", VA = "0x186DDE7D0")]
	public static void CAMJDAJEMIM(ReadOnlySpan<NODPIHKBIGM> ANLGEKMHCGN, int ALBFHDLGAOO, [Out] int AMPGECCAHLD, [Out] int AAPPJJCJFPJ, [Out] int PMACODPPELE)
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
