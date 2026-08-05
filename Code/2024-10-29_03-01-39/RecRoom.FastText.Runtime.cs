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
public class EGDBBACHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D GFKAKCJLHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig GPIHNIAGJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public OJHPFBCGMJF[] PLAPMBIPBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public OJHPFBCGMJF FLIINIMGAKM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static EGDBBACHDNF LBLGMNEGGBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EGDBBACHDNF CIGDGOEDACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5B60", Offset = "0x6EA4B60", VA = "0x186EA5B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public EGDBBACHDNF()
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
		[Cpp2IlInjected.Address(RVA = "0x6EA7FE0", Offset = "0x6EA6FE0", VA = "0x186EA7FE0")]
		public GlyphUVConfig(int NGKEEBIDIKB, int CJDGHCGGMHJ, int DKANACCBHIN, int AJKECNFJFDA, float HLECAODHDIG = 0f, [Optional] GlyphPixelInset OFIIJADKKOP)
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
public readonly struct OJHPFBCGMJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char EFLOOKBHNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int MILFAKFKNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int INGIKHHHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly OJHPFBCGMJF PBGJMMDLOBL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9C30", Offset = "0x6EA8C30", VA = "0x186EA9C30")]
	public OJHPFBCGMJF(char BHMPCIPMMDI, int HBBPHPGPIMH, int KCKGIIBNHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9C40", Offset = "0x6EA8C40", VA = "0x186EA9C40")]
	public OJHPFBCGMJF(GlyphCoordinateWritable PMIJKNJOAOL)
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
		[Cpp2IlInjected.Address(RVA = "0x6EA7600", Offset = "0x6EA6600", VA = "0x186EA7600")]
		public static OJHPFBCGMJF ILBKFABDDDI(GlyphCoordinateWritable JGODMBGCENL)
		{
			return default(OJHPFBCGMJF);
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
		private EGDBBACHDNF configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6EA7EE0", Offset = "0x6EA6EE0", VA = "0x186EA7EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6EA7D60", Offset = "0x6EA6D60", VA = "0x186EA7D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6EA7D50", Offset = "0x6EA6D50", VA = "0x186EA7D50")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EGDBBACHDNF ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6EA7750", Offset = "0x6EA6750", VA = "0x186EA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OJHPFBCGMJF FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6EA7BC0", Offset = "0x6EA6BC0", VA = "0x186EA7BC0")]
			get
			{
				return default(OJHPFBCGMJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7620", Offset = "0x6EA6620", VA = "0x186EA7620")]
		internal void JEEFGEOIOAD(IEnumerable<GlyphCoordinateWritable> LENJGFACBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EA76C0", Offset = "0x6EA66C0", VA = "0x186EA76C0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EA76A0", Offset = "0x6EA66A0", VA = "0x186EA76A0")]
		[CompilerGenerated]
		private bool MFPKKKMMDMD(GlyphCoordinateWritable JGODMBGCENL)
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
		private TextSegmentMeshBufferSource PEFFOBABHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private MOFDMDCPFGL BGGCPNOMCAI;

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
		private OPLFGCBHFFG CNJDBBMJGPI;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA320", Offset = "0x6EA9320", VA = "0x186EAA320")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA2D0", Offset = "0x6EA92D0", VA = "0x186EAA2D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA110", Offset = "0x6EA9110", VA = "0x186EAA110")]
		private void DKPEKHABKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA410", Offset = "0x6EA9410", VA = "0x186EAA410")]
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
		private bool ENDEHOICMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material IHDLMNDEFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private MOFDMDCPFGL BGGCPNOMCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material PCFOFPKAOMC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private EGDBBACHDNF HOLKKKKGJBA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6EAA790", Offset = "0x6EA9790", VA = "0x186EAA790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MOFDMDCPFGL ONIEEDEDKPL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6EAAF20", Offset = "0x6EA9F20", VA = "0x186EAAF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material PDJJGDKMIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6EAAF50", Offset = "0x6EA9F50", VA = "0x186EAAF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAE80", Offset = "0x6EA9E80", VA = "0x186EAAE80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAB40", Offset = "0x6EA9B40", VA = "0x186EAAB40", Slot = "8")]
		protected override void IHBIDPPGOGO(OGHOEFGKBJC DHLLFIPKFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAE90", Offset = "0x6EA9E90", VA = "0x186EAAE90", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] GIIMCMACFJL LIAHNBMJMJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAD30", Offset = "0x6EA9D30", VA = "0x186EAAD30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA820", Offset = "0x6EA9820", VA = "0x186EAA820")]
		private void FNMMGCFGIKB(bool OCPABOGIINL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D20A0", Offset = "0x8D10A0", VA = "0x1808D20A0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct POCDEOBEMOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly MOFDMDCPFGL GHCJFEIKICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int KMGPAHDKKNE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA0D0", Offset = "0x6EA90D0", VA = "0x186EAA0D0")]
	internal MIKMDFOAGLI EEPNGEOKHCI()
	{
		return default(MIKMDFOAGLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x22E7910", Offset = "0x22E6910", VA = "0x1822E7910")]
	internal POCDEOBEMOL(MOFDMDCPFGL PMNMDCCMPDH, int FLMKKIBEHIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OAMJLOAANLM
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9B90", Offset = "0x6EA8B90", VA = "0x186EA9B90")]
	public static bool EPKAFGDPKKC(this POCDEOBEMOL MMNBDONBOFN, BMKJNLLAJLA IMGFKMKPNNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9B70", Offset = "0x6EA8B70", VA = "0x186EA9B70")]
	internal static bool EPKAFGDPKKC(this MIKMDFOAGLI CBPDJDMEIKD, BMKJNLLAJLA IMGFKMKPNNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9B30", Offset = "0x6EA8B30", VA = "0x186EA9B30")]
	public static float BCJJHAEFGMB(this POCDEOBEMOL MMNBDONBOFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9A7610", Offset = "0x9A6610", VA = "0x1809A7610")]
	internal static float BCJJHAEFGMB(this MIKMDFOAGLI CBPDJDMEIKD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BKDIBNNINLK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3700", Offset = "0x6EA2700", VA = "0x186EA3700")]
	public static void ALNMBJJOGFF(this POCDEOBEMOL MMNBDONBOFN, ReadOnlySpan<char> OKFPLLNEKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5790", Offset = "0x6EA4790", VA = "0x186EA5790")]
	internal static void ALNMBJJOGFF(this MIKMDFOAGLI CBPDJDMEIKD, ReadOnlySpan<char> OKFPLLNEKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5930", Offset = "0x6EA4930", VA = "0x186EA5930")]
	public static void CGEMIJECNJG(this POCDEOBEMOL DOMBAEBPPMF, float2 GHGLDJOHACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5980", Offset = "0x6EA4980", VA = "0x186EA5980")]
	internal static void CGEMIJECNJG(this MIKMDFOAGLI CBPDJDMEIKD, float2 GHGLDJOHACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5740", Offset = "0x6EA4740", VA = "0x186EA5740")]
	public static void ABMDJBHIOOK(this POCDEOBEMOL DOMBAEBPPMF, float PKAJEADMCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5780", Offset = "0x6EA4780", VA = "0x186EA5780")]
	internal static void ABMDJBHIOOK(this MIKMDFOAGLI CBPDJDMEIKD, float PKAJEADMCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5A70", Offset = "0x6EA4A70", VA = "0x186EA5A70")]
	internal static void IGKLEODBPBD(this MIKMDFOAGLI CBPDJDMEIKD, bool PMDAELCLKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EA58F0", Offset = "0x6EA48F0", VA = "0x186EA58F0")]
	public static void BLADOCPAFKK(this POCDEOBEMOL DOMBAEBPPMF, Color32 DANHKIEIFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EA58E0", Offset = "0x6EA48E0", VA = "0x186EA58E0")]
	internal static void BLADOCPAFKK(this MIKMDFOAGLI CBPDJDMEIKD, Color32 DANHKIEIFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EA59C0", Offset = "0x6EA49C0", VA = "0x186EA59C0")]
	public static void EOHAPOMCIAB(this POCDEOBEMOL DOMBAEBPPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EA59B0", Offset = "0x6EA49B0", VA = "0x186EA59B0")]
	internal static void EOHAPOMCIAB(this MIKMDFOAGLI CBPDJDMEIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5A00", Offset = "0x6EA4A00", VA = "0x186EA5A00")]
	internal static void IGEKIOLGPLN(this MIKMDFOAGLI CBPDJDMEIKD, int LCALCLBHKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5990", Offset = "0x6EA4990", VA = "0x186EA5990")]
	internal static void EECDGODAIJL(this MIKMDFOAGLI CBPDJDMEIKD, int GHHPOCJDLBD, BMKJNLLAJLA PMKHBEKPOHO = BMKJNLLAJLA.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OPLFGCBHFFG : IEquatable<OPLFGCBHFFG>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort CBBJJDBHENL = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int JPLDILPHHFB = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly OPLFGCBHFFG EBIFMBPCDML;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort JENDIHIMEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21808B0", Offset = "0x217F8B0", VA = "0x1821808B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x21808C0", Offset = "0x217F8C0", VA = "0x1821808C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MOFDMDCPFGL GHCJFEIKICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MNCIMEONHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9D6A0", Offset = "0x6E9C6A0", VA = "0x186E9D6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D970", Offset = "0x6E9C970", VA = "0x186E9D970")]
	public OPLFGCBHFFG(int JKCNLFJJKPM, MOFDMDCPFGL PMNMDCCMPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9D70", Offset = "0x6EA8D70", VA = "0x186EA9D70")]
	public bool FIHPCKANPIO([Out] POCDEOBEMOL MMNBDONBOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9C60", Offset = "0x6EA8C60", VA = "0x186EA9C60")]
	public void DIPKALJLHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D8B0", Offset = "0x6E9C8B0", VA = "0x186E9D8B0")]
	internal void LJDICEJFHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D770", Offset = "0x6E9C770", VA = "0x186E9D770", Slot = "4")]
	public bool Equals(OPLFGCBHFFG DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9CB0", Offset = "0x6EA8CB0", VA = "0x186EA9CB0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9E40", Offset = "0x6EA8E40", VA = "0x186EA9E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MOFDMDCPFGL : IDisposable, NCLKEKIBLDL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string LDPKOJFFLAH = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker FPCKGPOGPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string IGOJDAFKCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly JNAOMJGLKIE AIIPGOFCKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int HPKAEBAHKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal MIKMDFOAGLI[] ENEBCLFLJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal OPLFGCBHFFG[] BLGHIMAOIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EGDBBACHDNF BHAOJJLFJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GCBDKKJMDJE EANDAOGNEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly FOFAHPNPFOJ LDKBJEPEBFM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string DMCFPOLFNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EA88C0", Offset = "0x6EA78C0", VA = "0x186EA88C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IKPCEACGPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D3700", Offset = "0x8D2700", VA = "0x1808D3700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public EGDBBACHDNF JEGIAKHCDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6EA88A0", Offset = "0x6EA78A0", VA = "0x186EA88A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float DDMKIOMJAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8310", Offset = "0x6EA7310", VA = "0x186EA8310")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MFIIAEMDANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8F40", Offset = "0x6EA7F40", VA = "0x186EA8F40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NCLKEKIBLDL.CIMFJNJKOEE IABFIBEGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B4270", Offset = "0x8B3270", VA = "0x1808B4270", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B42C0", Offset = "0x8B32C0", VA = "0x1808B42C0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA96F0", Offset = "0x6EA86F0", VA = "0x186EA96F0")]
	public MOFDMDCPFGL(JNAOMJGLKIE CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9670", Offset = "0x6EA8670", VA = "0x186EA9670")]
	public MOFDMDCPFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA87B0", Offset = "0x6EA77B0", VA = "0x186EA87B0")]
	public void BCCFFCEEHAG(GlyphMapAsset JEIKHIPHBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA86A0", Offset = "0x6EA76A0", VA = "0x186EA86A0")]
	public void BCCFFCEEHAG(EGDBBACHDNF DAJOKKGBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA93A0", Offset = "0x6EA83A0", VA = "0x186EA93A0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] GIIMCMACFJL LIAHNBMJMJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9340", Offset = "0x6EA8340", VA = "0x186EA9340")]
	public void MMKHDPHLPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8C60", Offset = "0x6EA7C60", VA = "0x186EA8C60")]
	public bool GMHHPBCGOIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9110", Offset = "0x6EA8110", VA = "0x186EA9110")]
	public OPLFGCBHFFG LJKHDCOGDNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8330", Offset = "0x6EA7330", VA = "0x186EA8330")]
	public void ANFGIOAFMJB(OPLFGCBHFFG BFPBEFOHFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8CB0", Offset = "0x6EA7CB0", VA = "0x186EA8CB0")]
	internal bool HBOJAOILEDO(OPLFGCBHFFG BFPBEFOHFHA, [Out] POCDEOBEMOL MMNBDONBOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8FC0", Offset = "0x6EA7FC0", VA = "0x186EA8FC0")]
	private void LDCHGPGJCOC(MIKMDFOAGLI CBPDJDMEIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8D60", Offset = "0x6EA7D60", VA = "0x186EA8D60")]
	private void IBIMDDFENCM(int EPOGFPCAPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8F60", Offset = "0x6EA7F60", VA = "0x186EA8F60")]
	private bool KMCGGCJCLAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FCA0", Offset = "0x6E9ECA0", VA = "0x186E9FCA0")]
	private static int JHEICBGDIDJ(OPLFGCBHFFG BFPBEFOHFHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1C61000", Offset = "0x1C60000", VA = "0x181C61000")]
	private static ushort HAMEPKPGNDL(int KHAIDMGPIED)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8950", Offset = "0x6EA7950", VA = "0x186EA8950")]
	private Bounds GBFINIFNGGB()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA87F0", Offset = "0x6EA77F0", VA = "0x186EA87F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JNAOMJGLKIE
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JNAOMJGLKIE MKGODKCOIKC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float OMCGHLMEMKL = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int OCLBKECIOFK = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int ANCHLGFKGNF = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color AEGPLAKDGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float PDOGBPHLCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int EEDEPLLFGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int OALALLGIPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int KPFHJEFKFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int NJPKMBNGOBL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8100", Offset = "0x6EA7100", VA = "0x186EA8100")]
	internal JNAOMJGLKIE AGABGHBEIGB()
	{
		return default(JNAOMJGLKIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DA70", Offset = "0x6E9CA70", VA = "0x186E9DA70")]
	[CompilerGenerated]
	internal static void PGDOLHAAGLE(int BJDKOHEGDOK, int MJBMFFMBOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8230", Offset = "0x6EA7230", VA = "0x186EA8230")]
	[CompilerGenerated]
	internal static void DNJCADEMKNC(float BJDKOHEGDOK, float MJBMFFMBOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DA80", Offset = "0x6E9CA80", VA = "0x186E9DA80")]
	[CompilerGenerated]
	internal static void DOEAOCOBNKF(int BJDKOHEGDOK, int GGHJJDDFDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8210", Offset = "0x6EA7210", VA = "0x186EA8210")]
	[CompilerGenerated]
	internal static void CBEGEKELIMO(float BJDKOHEGDOK, float GGHJJDDFDGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BEHCHCHLFDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5690", Offset = "0x6EA4690", VA = "0x186EA5690")]
	public static (int, int) LEAOPFIKGPF(this MOFDMDCPFGL CPNFFLPAMOE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5600", Offset = "0x6EA4600", VA = "0x186EA5600")]
	public static float GKKNPIEBADL(this POCDEOBEMOL GMBEOPNOBDO)
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
		public readonly OPLFGCBHFFG textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA720", Offset = "0x6EA9720", VA = "0x186EAA720")]
		public TextSegmentLayout(LayoutRect layoutRect, OPLFGCBHFFG textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA4F0", Offset = "0x6EA94F0", VA = "0x186EAA4F0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA560", Offset = "0x6EA9560", VA = "0x186EAA560")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA490", Offset = "0x6EA9490", VA = "0x186EAA490")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class GCBDKKJMDJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig FDNNGEPFPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float FOMFEFJNODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float NEAHLCGCOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float POHDCNCEBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float BHOELOBHIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float PGOAAECDBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float BCNEBLJHEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float LDFOOEAELKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float MCBKMNBJAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float BCMPNBPPKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float MFIIAEMDANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float HMMFBKHGNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float DDMKIOMJAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ICIKAALCOHJ[] NHDJHABJCNO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int AAOFENHMBAM = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private CHIAFFLOLFH[] BMFBMBIFOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int DIAANNHLLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private OJHPFBCGMJF[] EIKJMPNAEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int OLFMGNDEGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public ICIKAALCOHJ GIBHNMFBPNO;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6DE0", Offset = "0x6EA5DE0", VA = "0x186EA6DE0")]
	public void BCCFFCEEHAG(EGDBBACHDNF NJHNPELFDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6E70", Offset = "0x6EA5E70", VA = "0x186EA6E70")]
	public void BCCFFCEEHAG(GlyphUVConfig FNCOODNPPFB, IEnumerable<OJHPFBCGMJF> JEIKHIPHBBH, OJHPFBCGMJF JPLBAEOAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6EF0", Offset = "0x6EA5EF0", VA = "0x186EA6EF0")]
	internal void HOGDHLFMKGJ(GlyphUVConfig FNCOODNPPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7030", Offset = "0x6EA6030", VA = "0x186EA7030")]
	private void POGIGIMKHHK(IEnumerable<OJHPFBCGMJF> JEIKHIPHBBH, OJHPFBCGMJF JPLBAEOAJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6AB0", Offset = "0x6EA5AB0", VA = "0x186EA6AB0")]
	public void AFOBMFEJOPF([In] char BHMPCIPMMDI, [Out] float2[] KPKFAJLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5420", Offset = "0x6EA4420", VA = "0x186EA5420")]
	private ICIKAALCOHJ OKBGFHINMLH(OJHPFBCGMJF PMIJKNJOAOL)
	{
		return default(ICIKAALCOHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7560", Offset = "0x6EA6560", VA = "0x186EA7560")]
	public GCBDKKJMDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PKJMJIOGANG
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9FA0", Offset = "0x6EA8FA0", VA = "0x186EA9FA0")]
	public static void FBIEBPMDLEP([In] float ENEIMAMPGHG, [In] float DEDOHOLBGJM, [In] int GBHAPHFGMLC, [In] int ADCJONAIPDP, [In] float BHOELOBHIGH, [In] float PGOAAECDBLB, [In] float ONJDGBOOBLN, [In] float PFCAJCPJCKF, [In] float FGFNBAPELED, [In] float HGEPFKKBMKJ, [Out] float GMBFPCABHNO, [Out] float DBDOFECINAK, [Out] float CPDNBECILLA, [Out] float PPNEMIHAPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9F40", Offset = "0x6EA8F40", VA = "0x186EA9F40")]
	public static void FBIEBPMDLEP([In] float ENEIMAMPGHG, [In] float DEDOHOLBGJM, [In] int GBHAPHFGMLC, [In] int ADCJONAIPDP, [Out] float GMBFPCABHNO, [Out] float DBDOFECINAK, [Out] float CPDNBECILLA, [Out] float PPNEMIHAPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA070", Offset = "0x6EA9070", VA = "0x186EAA070")]
	public static void LJCHCMJEDMA([In] float BHOELOBHIGH, [In] float PGOAAECDBLB, [In] float DHHGODLJJFL, [In] float FIFCGDPJMDO, [In] float COPPOMCLHBE, [In] float LLIIECIBAHA, [Out] float FPLMPCNNPEC, [Out] float AKDOJDHLACA, [Out] float INMAIHIHMIC, [Out] float OJLJILKPMNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct CHIAFFLOLFH
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint PFGCDMJPPBL = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char EFLOOKBHNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly ICIKAALCOHJ BHKOJBKAFBB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5A80", Offset = "0x6EA4A80", VA = "0x186EA5A80")]
	public CHIAFFLOLFH(char BHMPCIPMMDI, ICIKAALCOHJ KPKFAJLBJOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct ICIKAALCOHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint PFGCDMJPPBL = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] KPBBNHCKHNB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8010", Offset = "0x6EA7010", VA = "0x186EA8010")]
	public ICIKAALCOHJ(float GMBFPCABHNO, float DBDOFECINAK, float CPDNBECILLA, float PPNEMIHAPLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct MIKMDFOAGLI
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int NMIDJMMDOLA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal BMKJNLLAJLA PMKHBEKPOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] AAMAMIBKOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int FLODOMBKDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 GHGLDJOHACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float OFICPKEOMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 MKMMFKNIADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool PMDAELCLKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int BMEMEALBOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int BDLJNIBLCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int EBOGBOJDBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int IHHHEOJILLF;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8300", Offset = "0x6EA7300", VA = "0x186EA8300")]
	public static int AICPALFHBEM(int DLCBKBKNCDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum BMKJNLLAJLA : byte
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
public static class DMILGDONKEP
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5AA0", Offset = "0x6EA4AA0", VA = "0x186EA5AA0")]
	internal static float GKKNPIEBADL(this MIKMDFOAGLI CBPDJDMEIKD, float MBONLCMPIKE, float DBHHIHGGEJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5AE0", Offset = "0x6EA4AE0", VA = "0x186EA5AE0")]
	internal static void GPDLLOPOKCH(this MIKMDFOAGLI CBPDJDMEIKD, float MBONLCMPIKE, float DBHHIHGGEJL, [Out] float2 JCGGLMFLBCP, [Out] float2 PLFLOPDIPGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class FOFAHPNPFOJ : NCLKEKIBLDL
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int FJNEIIPCNON = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int EJDKCAJBOFP = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string LDPKOJFFLAH = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static NDPGBHBCKEF ONFBIIEALLO;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static NDPGBHBCKEF OCCIHOLMBCD;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static NDPGBHBCKEF IEDCCICLMCM;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static NDPGBHBCKEF KPCFAHGDFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly GIIMCMACFJL LIAHNBMJMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] CEELJFIJPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] KNIENOLJMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int LMCMHIIHBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int KGMNIMFCFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int IJPOAKNCEIN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string DMCFPOLFNCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public NCLKEKIBLDL.CIMFJNJKOEE IABFIBEGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA69A0", Offset = "0x6EA59A0", VA = "0x186EA69A0")]
	public FOFAHPNPFOJ(GIIMCMACFJL.NPGFGNIHAIO JIIHIKBJFIG, int HGOJMJCFNMK, int NPCANPAEHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6820", Offset = "0x6EA5820", VA = "0x186EA6820", Slot = "5")]
	public bool TryGetMeshBuffer([Out] GIIMCMACFJL LIAHNBMJMJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5CD0", Offset = "0x6EA4CD0", VA = "0x186EA5CD0")]
	public void DOOKJDOLEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6010", Offset = "0x6EA5010", VA = "0x186EA6010")]
	public void LLIEIAGMLCA(Span<MIKMDFOAGLI> DNGGDIEODJH, GCBDKKJMDJE GMCOCHEKHPN, [In] JNAOMJGLKIE CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3A70", Offset = "0x6EA2A70", VA = "0x186EA3A70")]
	private void LFBFCHKNCCM([In] BMKJNLLAJLA PMKHBEKPOHO, [In] MIKMDFOAGLI JNBBMHFECGG, int OMEEGPOFCAG, [In] float MBONLCMPIKE, [In] float DBHHIHGGEJL, GCBDKKJMDJE GMCOCHEKHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5EC0", Offset = "0x6EA4EC0", VA = "0x186EA5EC0")]
	private void JGIEMCOHOEC([In] BMKJNLLAJLA PMKHBEKPOHO, MIKMDFOAGLI JNBBMHFECGG, [In] int FLLLNFPAMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5CF0", Offset = "0x6EA4CF0", VA = "0x186EA5CF0")]
	public static void ELGDKHIHENM(ReadOnlySpan<MIKMDFOAGLI> DNGGDIEODJH, int DMDEMJDBAAK, [Out] int HFOHJFBJNLC, [Out] int JAEBAHMIKON, [Out] int MOFOGJMNKAI)
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
