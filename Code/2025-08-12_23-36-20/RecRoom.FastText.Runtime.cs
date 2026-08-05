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
public class EMFMGLAHIPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D CPHEICFDOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig DGGMBADNECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ALOIPEMOIID[] IILPIGCKOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ALOIPEMOIID ALCNIBGACPB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static EMFMGLAHIPK MEDKAIGIDHA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EMFMGLAHIPK DNLCIECDMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x837DD10", Offset = "0x837CB10", VA = "0x18837DD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EMFMGLAHIPK()
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
		[Cpp2IlInjected.Address(RVA = "0x837E880", Offset = "0x837D680", VA = "0x18837E880")]
		public GlyphUVConfig(int DIJHLCIGJOC, int POMGNMNEKAF, int HEFBDNPDDOF, int NGEKABHGOGB, float PCJPFMADMEI = 0f, [Optional] GlyphPixelInset GFMPPDHGHIA)
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
public readonly struct ALOIPEMOIID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char JHDFMCHICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int OEKPBJOBIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int ENPBBLJCLIN;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly ALOIPEMOIID CIOMGJHOEGE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x837C4C0", Offset = "0x837B2C0", VA = "0x18837C4C0")]
	public ALOIPEMOIID(char NCIDACLJJDK, int MIFHGKNEOML, int HPEAEDDJGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x837C4A0", Offset = "0x837B2A0", VA = "0x18837C4A0")]
	public ALOIPEMOIID(GlyphCoordinateWritable LNEJPPBKDLK)
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
		[Cpp2IlInjected.Address(RVA = "0x837DEA0", Offset = "0x837CCA0", VA = "0x18837DEA0")]
		public static ALOIPEMOIID MIDAFINGFAP(GlyphCoordinateWritable JMOOEAFLFLP)
		{
			return default(ALOIPEMOIID);
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
		private EMFMGLAHIPK configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x837E780", Offset = "0x837D580", VA = "0x18837E780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x837E600", Offset = "0x837D400", VA = "0x18837E600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x837E5F0", Offset = "0x837D3F0", VA = "0x18837E5F0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EMFMGLAHIPK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x837DFF0", Offset = "0x837CDF0", VA = "0x18837DFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ALOIPEMOIID FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x837E460", Offset = "0x837D260", VA = "0x18837E460")]
			get
			{
				return default(ALOIPEMOIID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x837DEE0", Offset = "0x837CCE0", VA = "0x18837DEE0")]
		internal void LJEHCPAEEIL(IEnumerable<GlyphCoordinateWritable> ODCLJCEOADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x837DF60", Offset = "0x837CD60", VA = "0x18837DF60")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x837DEC0", Offset = "0x837CCC0", VA = "0x18837DEC0")]
		[CompilerGenerated]
		private bool KMLDEIEHPAM(GlyphCoordinateWritable JMOOEAFLFLP)
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
		private TextSegmentMeshBufferSource EBMGNALKNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KMGGGLJCGHP KKGGBKGBOHO;

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
		private CKADPIAMEDP HAJPOHCJLMA;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83813E0", Offset = "0x83801E0", VA = "0x1883813E0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8381390", Offset = "0x8380190", VA = "0x188381390")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83811B0", Offset = "0x837FFB0", VA = "0x1883811B0")]
		private void HPCIGPAMBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83814D0", Offset = "0x83802D0", VA = "0x1883814D0")]
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
		private bool PKLPLLBHLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material NHDCBPFPIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private KMGGGLJCGHP KKGGBKGBOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material KBLGGGOMOFB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private EMFMGLAHIPK MAOGMKNLGBC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8381850", Offset = "0x8380650", VA = "0x188381850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KMGGGLJCGHP EALMIBKJDCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8381FE0", Offset = "0x8380DE0", VA = "0x188381FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material DADBHGJABKG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8382010", Offset = "0x8380E10", VA = "0x188382010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8381F40", Offset = "0x8380D40", VA = "0x188381F40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83818E0", Offset = "0x83806E0", VA = "0x1883818E0", Slot = "8")]
		protected override void IJKLECCEHHO(AEJEHFGJCCO PCMGOIMBOBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8381F50", Offset = "0x8380D50", VA = "0x188381F50", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] HAKLLLIFKND MDGDENGIIDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8381AD0", Offset = "0x83808D0", VA = "0x188381AD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8381C20", Offset = "0x8380A20", VA = "0x188381C20")]
		private void PEGPHPFIGNB(bool PPPGPLMAHNI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAB1400", Offset = "0xAB0200", VA = "0x180AB1400")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct HHIDNAHNNKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly KMGGGLJCGHP OOMBBMANKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int IJKEAMCIDOM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x837E8B0", Offset = "0x837D6B0", VA = "0x18837E8B0")]
	internal MLPCLIBLHKF LBMOJOGNIOM()
	{
		return default(MLPCLIBLHKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA390", Offset = "0x2AB9190", VA = "0x182ABA390")]
	internal HHIDNAHNNKA(KMGGGLJCGHP EKOKCFOMOOD, int LFINPDHDFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NEFPOHGEHLM
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8380F50", Offset = "0x837FD50", VA = "0x188380F50")]
	public static bool DDMFGBPFPGC(this HHIDNAHNNKA BGMOBGFDNIG, OJLFNHLPABF OPLDBGBIJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8380FA0", Offset = "0x837FDA0", VA = "0x188380FA0")]
	internal static bool DDMFGBPFPGC(this MLPCLIBLHKF ACHAFDMKGBO, OJLFNHLPABF OPLDBGBIJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8380FC0", Offset = "0x837FDC0", VA = "0x188380FC0")]
	public static float OHNNDALPKJP(this HHIDNAHNNKA BGMOBGFDNIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAE79E0", Offset = "0xAE67E0", VA = "0x180AE79E0")]
	internal static float OHNNDALPKJP(this MLPCLIBLHKF ACHAFDMKGBO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DBMHFADIMDA
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x837CB80", Offset = "0x837B980", VA = "0x18837CB80")]
	public static void LKBHJDCHDKP(this HHIDNAHNNKA BGMOBGFDNIG, ReadOnlySpan<char> JBCKGOCMFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x837C980", Offset = "0x837B780", VA = "0x18837C980")]
	internal static void LKBHJDCHDKP(this MLPCLIBLHKF ACHAFDMKGBO, ReadOnlySpan<char> JBCKGOCMFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x837C920", Offset = "0x837B720", VA = "0x18837C920")]
	public static void IKKBCOOOFMB(this HHIDNAHNNKA AINFFKIJBCC, float2 PMMKDGMEPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x837C970", Offset = "0x837B770", VA = "0x18837C970")]
	internal static void IKKBCOOOFMB(this MLPCLIBLHKF ACHAFDMKGBO, float2 PMMKDGMEPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x837C870", Offset = "0x837B670", VA = "0x18837C870")]
	public static void FNAFLDENJHA(this HHIDNAHNNKA AINFFKIJBCC, float JFLGKNMNHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x837C8E0", Offset = "0x837B6E0", VA = "0x18837C8E0")]
	internal static void FNAFLDENJHA(this MLPCLIBLHKF ACHAFDMKGBO, float JFLGKNMNHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x837CBD0", Offset = "0x837B9D0", VA = "0x18837CBD0")]
	internal static void MGGOCIGFDFH(this MLPCLIBLHKF ACHAFDMKGBO, bool APLOKKGJCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x837C7B0", Offset = "0x837B5B0", VA = "0x18837C7B0")]
	public static void AHNBALNGMMI(this HHIDNAHNNKA AINFFKIJBCC, Color32 BGBIPHDMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x837C7F0", Offset = "0x837B5F0", VA = "0x18837C7F0")]
	internal static void AHNBALNGMMI(this MLPCLIBLHKF ACHAFDMKGBO, Color32 BGBIPHDMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x837CC00", Offset = "0x837BA00", VA = "0x18837CC00")]
	public static void OIEODEOAJIH(this HHIDNAHNNKA AINFFKIJBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x837CC40", Offset = "0x837BA40", VA = "0x18837CC40")]
	internal static void OIEODEOAJIH(this MLPCLIBLHKF ACHAFDMKGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x837C800", Offset = "0x837B600", VA = "0x18837C800")]
	internal static void DDAFJMPHNDP(this MLPCLIBLHKF ACHAFDMKGBO, int KOLHMKDNGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x837CBE0", Offset = "0x837B9E0", VA = "0x18837CBE0")]
	internal static void OGLINGPGKPP(this MLPCLIBLHKF ACHAFDMKGBO, int NICKNEPMJDL, OJLFNHLPABF BJOMNHFLDHP = OJLFNHLPABF.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CKADPIAMEDP : IEquatable<CKADPIAMEDP>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort HJAGGDDPIOB = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int JJBMNCLPBKP = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly CKADPIAMEDP IENBDFLHEBC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort EOMIHDLKCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xDC91E0", Offset = "0xDC7FE0", VA = "0x180DC91E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xDC91F0", Offset = "0xDC7FF0", VA = "0x180DC91F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public KMGGGLJCGHP OOMBBMANKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool HCIMLNOEIII
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8375C30", Offset = "0x8374A30", VA = "0x188375C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8375CD0", Offset = "0x8374AD0", VA = "0x188375CD0")]
	public CKADPIAMEDP(int GKHMPCENPAI, KMGGGLJCGHP EKOKCFOMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x837C600", Offset = "0x837B400", VA = "0x18837C600")]
	public bool NCBGGPNHNLB([Out] HHIDNAHNNKA BGMOBGFDNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x837C6D0", Offset = "0x837B4D0", VA = "0x18837C6D0")]
	public void OJNCHOHBCNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8375BB0", Offset = "0x83749B0", VA = "0x188375BB0")]
	internal void OFOMJMPOGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8375A20", Offset = "0x8374820", VA = "0x188375A20", Slot = "4")]
	public bool Equals(CKADPIAMEDP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x837C4D0", Offset = "0x837B2D0", VA = "0x18837C4D0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x837C590", Offset = "0x837B390", VA = "0x18837C590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class KMGGGLJCGHP : IDisposable, BKKIHLNOJLJ
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string ELKFDOGNCIG = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker NMCGEJKGHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string FBGMEKFLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly MCAGEJMGKLB NCGJILFJDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int DDOPDPOJNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal MLPCLIBLHKF[] BLOACMOGENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal CKADPIAMEDP[] KOMGGBKBGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EMFMGLAHIPK DPGBGPLFAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HOAJMEEBHAE LPDCGGHGOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly DCKGAKALGPA KHCHEHOGJHI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string PFLDDMDPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8380440", Offset = "0x837F240", VA = "0x188380440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EMFMGLAHIPK FPMEBJILOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8380150", Offset = "0x837EF50", VA = "0x188380150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float DEDJODJCECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8380130", Offset = "0x837EF30", VA = "0x188380130")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float CMBFHKCMCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x837F4A0", Offset = "0x837E2A0", VA = "0x18837F4A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BKKIHLNOJLJ.CBNOPAJOAGG EIJOODHHGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA93200", Offset = "0xA92000", VA = "0x180A93200", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x83807F0", Offset = "0x837F5F0", VA = "0x1883807F0")]
	public KMGGGLJCGHP(MCAGEJMGKLB AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8380C30", Offset = "0x837FA30", VA = "0x188380C30")]
	public KMGGGLJCGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8380280", Offset = "0x837F080", VA = "0x188380280")]
	public void MHDKBDCHLCM(GlyphMapAsset KNKDEECBCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8380170", Offset = "0x837EF70", VA = "0x188380170")]
	public void MHDKBDCHLCM(EMFMGLAHIPK PEKGCMBPODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8380520", Offset = "0x837F320", VA = "0x188380520", Slot = "6")]
	public bool TryGetMeshBuffer([Out] HAKLLLIFKND MDGDENGIIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x837FA60", Offset = "0x837E860", VA = "0x18837FA60")]
	public void GGMMDJGAOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83804D0", Offset = "0x837F2D0", VA = "0x1883804D0")]
	public bool OMJFMNKBDOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x837FED0", Offset = "0x837ECD0", VA = "0x18837FED0")]
	public CKADPIAMEDP JLIDNCAJNAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x837FAC0", Offset = "0x837E8C0", VA = "0x18837FAC0")]
	public void GHELGAJHJBH(CKADPIAMEDP LEAFBIGDJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x837FE20", Offset = "0x837EC20", VA = "0x18837FE20")]
	internal bool JAHBCBGLEFN(CKADPIAMEDP LEAFBIGDJKN, [Out] HHIDNAHNNKA BGMOBGFDNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x83802C0", Offset = "0x837F0C0", VA = "0x1883802C0")]
	private void NEDNNHLGJKA(MLPCLIBLHKF ACHAFDMKGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x837F7D0", Offset = "0x837E5D0", VA = "0x18837F7D0")]
	private void DMAMKFDCNEE(int ILJAJDIKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x837F440", Offset = "0x837E240", VA = "0x18837F440")]
	private bool BAIPCEOKENE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8373AB0", Offset = "0x83728B0", VA = "0x188373AB0")]
	private static int KDKJPIBHBFI(CKADPIAMEDP LEAFBIGDJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x251B530", Offset = "0x251A330", VA = "0x18251B530")]
	private static ushort LBBDPFPDNOE(int JJJJBEGKNIN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x837F4C0", Offset = "0x837E2C0", VA = "0x18837F4C0")]
	private Bounds CGCCJMLNNCA()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x837F9B0", Offset = "0x837E7B0", VA = "0x18837F9B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MCAGEJMGKLB
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MCAGEJMGKLB FNDLKFJJNCO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float JDBCKMJPCLB = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LHIFFHPEGFO = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int DGMAJEKFFKH = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color DCIMJIAHGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float JMAOLDILFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int DAHMDCLMLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int PAOOLJNNOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int AONHMHKKCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int PLEBBMOGOMJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8380D80", Offset = "0x837FB80", VA = "0x188380D80")]
	internal MCAGEJMGKLB NOENAKIMFMI()
	{
		return default(MCAGEJMGKLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8374940", Offset = "0x8373740", VA = "0x188374940")]
	[CompilerGenerated]
	internal static void FHEHFIJPOAP(int HGMAIPELJHM, int PGFMONBPOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8380D40", Offset = "0x837FB40", VA = "0x188380D40")]
	[CompilerGenerated]
	internal static void BFKOEKMNDKO(float HGMAIPELJHM, float PGFMONBPOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8374890", Offset = "0x8373690", VA = "0x188374890")]
	[CompilerGenerated]
	internal static void HIFGMCKJPBN(int HGMAIPELJHM, int INENONEKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8380D60", Offset = "0x837FB60", VA = "0x188380D60")]
	[CompilerGenerated]
	internal static void CNOIFJOHCCM(float HGMAIPELJHM, float INENONEKCLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LKNECPLNJOK
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8380CB0", Offset = "0x837FAB0", VA = "0x188380CB0")]
	public static float DANNPNIGOCH(this HHIDNAHNNKA JJHKKJFGHCI)
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
		public readonly CKADPIAMEDP textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x83817E0", Offset = "0x83805E0", VA = "0x1883817E0")]
		public TextSegmentLayout(LayoutRect layoutRect, CKADPIAMEDP textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83815B0", Offset = "0x83803B0", VA = "0x1883815B0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8381620", Offset = "0x8380420", VA = "0x188381620")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8381550", Offset = "0x8380350", VA = "0x188381550")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class HOAJMEEBHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig CBFNJJLAHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float CFAMDGKCOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float FJPFDIOKIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float OLDJBPDPNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float IIDBNPNMIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float MIAFFKAFCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float OODFKAANNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float OOEIABFDLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float NKCDLLBNCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float IIPLMLGNHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float CMBFHKCMCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float IFDNFJNCEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float DEDJODJCECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NPNPPJHNGJG[] NDJKNEPIFGM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int HGGBALBCKMG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private FGFDIAJKJDG[] KKHJMKHJKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int PDCOBCGBIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private ALOIPEMOIID[] NIJAKBIMODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int OKOCNPAPPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NPNPPJHNGJG HGIKKMMLCJD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x837F310", Offset = "0x837E110", VA = "0x18837F310")]
	public void MHDKBDCHLCM(EMFMGLAHIPK PLEBJPPHNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x837F290", Offset = "0x837E090", VA = "0x18837F290")]
	public void MHDKBDCHLCM(GlyphUVConfig HMIBNLOJPOG, IEnumerable<ALOIPEMOIID> KNKDEECBCNA, ALOIPEMOIID LCANBFNKMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x837F150", Offset = "0x837DF50", VA = "0x18837F150")]
	internal void FAAPHAHDALH(GlyphUVConfig HMIBNLOJPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x837EC20", Offset = "0x837DA20", VA = "0x18837EC20")]
	private void BCJPFNBOLIL(IEnumerable<ALOIPEMOIID> KNKDEECBCNA, ALOIPEMOIID LCANBFNKMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x837E8F0", Offset = "0x837D6F0", VA = "0x18837E8F0")]
	public void AIOMHGHDLEA([In] char NCIDACLJJDK, [Out] float2[] HDDMABCEGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x837C270", Offset = "0x837B070", VA = "0x18837C270")]
	private NPNPPJHNGJG MJKJPEIJOOL(ALOIPEMOIID LNEJPPBKDLK)
	{
		return default(NPNPPJHNGJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x837F3A0", Offset = "0x837E1A0", VA = "0x18837F3A0")]
	public HOAJMEEBHAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ELFEMFLENJP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x837DC40", Offset = "0x837CA40", VA = "0x18837DC40")]
	public static void KBHLEJIBIAC([In] float NPAIODIMEDD, [In] float PEGIHPHIAPN, [In] int MBHFBPJKHOP, [In] int ICAALAFGOAM, [In] float IIDBNPNMIPL, [In] float MIAFFKAFCJE, [In] float JOJKHDJNDKB, [In] float LMIODHMMHOO, [In] float GEGEFIADGPE, [In] float HPHBKFLOKAM, [Out] float HPKLAMGAMKD, [Out] float MEHBNNBCDMD, [Out] float OKGMPDMDIPF, [Out] float AKAGDAJNJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x837DBE0", Offset = "0x837C9E0", VA = "0x18837DBE0")]
	public static void KBHLEJIBIAC([In] float NPAIODIMEDD, [In] float PEGIHPHIAPN, [In] int MBHFBPJKHOP, [In] int ICAALAFGOAM, [Out] float HPKLAMGAMKD, [Out] float MEHBNNBCDMD, [Out] float OKGMPDMDIPF, [Out] float AKAGDAJNJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x837DB80", Offset = "0x837C980", VA = "0x18837DB80")]
	public static void DJBDEDFKNFD([In] float IIDBNPNMIPL, [In] float MIAFFKAFCJE, [In] float NCJGKDCFPIM, [In] float CABKOHENHMI, [In] float ENDJGBALFNP, [In] float MPCJCBNAFCO, [Out] float BMFNCLBICAP, [Out] float JGLLJHFIPMD, [Out] float NECEIDAJBKE, [Out] float DBLDPIOGLOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct FGFDIAJKJDG
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint LDOKKDCCOPD = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char JHDFMCHICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly NPNPPJHNGJG CKBBEJOLMAD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x837DE80", Offset = "0x837CC80", VA = "0x18837DE80")]
	public FGFDIAJKJDG(char NCIDACLJJDK, NPNPPJHNGJG HDDMABCEGJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct NPNPPJHNGJG
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint LDOKKDCCOPD = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] ACDIGENOFIK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8381000", Offset = "0x837FE00", VA = "0x188381000")]
	public NPNPPJHNGJG(float HPKLAMGAMKD, float MEHBNNBCDMD, float OKGMPDMDIPF, float AKAGDAJNJPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct MLPCLIBLHKF
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int EMMHFKGJGCI = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal OJLFNHLPABF BJOMNHFLDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] AKOGPEKOHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int OPEIHDIJOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 PMMKDGMEPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float LNCCOIKFPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 COMGEEECOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool APLOKKGJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int OINBLGKLLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int JNEHCMFMDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int LAHMPKCPIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int AIKOGMNEDDA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8380F40", Offset = "0x837FD40", VA = "0x188380F40")]
	public static int FKBDDBNLPKO(int BFHNHCDNMHA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum OJLFNHLPABF : byte
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
public static class OLFBJBFJNPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x83810F0", Offset = "0x837FEF0", VA = "0x1883810F0")]
	internal static float DANNPNIGOCH(this MLPCLIBLHKF ACHAFDMKGBO, float IFADAEDNIKO, float LNFFEHHEGLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8381130", Offset = "0x837FF30", VA = "0x188381130")]
	internal static void DKNDKOALOHM(this MLPCLIBLHKF ACHAFDMKGBO, float IFADAEDNIKO, float LNFFEHHEGLC, [Out] float2 OLBFNPPONEB, [Out] float2 ANDCPDPHMGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class DCKGAKALGPA : BKKIHLNOJLJ
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int PAPMJOLGOAE = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int GLPANPBLMCE = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string ELKFDOGNCIG = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker PDLNNIAAHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker HBIMEHEKMKK;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker NDGMOBGBLKG;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker IAHHHFDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly HAKLLLIFKND MDGDENGIIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] JEBIOEPLPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] LAOBDJGPEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int PLEFJHJNAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HDDKLBIDNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int CEOBGFOHONH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PFLDDMDPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BKKIHLNOJLJ.CBNOPAJOAGG EIJOODHHGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x837DA70", Offset = "0x837C870", VA = "0x18837DA70")]
	public DCKGAKALGPA(HAKLLLIFKND.MCIIABPCGGL PKJGGJGMBBL, int IEMEMKIIDOL, int MJEJKABMFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x837D8F0", Offset = "0x837C6F0", VA = "0x18837D8F0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] HAKLLLIFKND MDGDENGIIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x837D8D0", Offset = "0x837C6D0", VA = "0x18837D8D0")]
	public void LEPIOOCFDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x837CC50", Offset = "0x837BA50", VA = "0x18837CC50")]
	public void ADKJCKNJIPF(Span<MLPCLIBLHKF> AMABLENDHGG, HOAJMEEBHAE BBDLADBFHKD, [In] MCAGEJMGKLB AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x837B0D0", Offset = "0x8379ED0", VA = "0x18837B0D0")]
	private void DMBHCIDKIPD([In] OJLFNHLPABF BJOMNHFLDHP, [In] MLPCLIBLHKF APMGIAKACLK, int NOLAPPEAOJF, [In] float IFADAEDNIKO, [In] float LNFFEHHEGLC, HOAJMEEBHAE BBDLADBFHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x837D780", Offset = "0x837C580", VA = "0x18837D780")]
	private void EGCHFLFGCPF([In] OJLFNHLPABF BJOMNHFLDHP, MLPCLIBLHKF APMGIAKACLK, [In] int DGONGBOHNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x837D550", Offset = "0x837C350", VA = "0x18837D550")]
	public static void BAHDLCIDJEG(ReadOnlySpan<MLPCLIBLHKF> AMABLENDHGG, int EAPNEPNEAGL, [Out] int GPHAACLLIGO, [Out] int ANIBBKKCHCI, [Out] int LHMNNFMEEFJ)
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
