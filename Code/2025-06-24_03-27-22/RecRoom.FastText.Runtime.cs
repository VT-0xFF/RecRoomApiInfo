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
public class JDHKOHJDAAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D KOOPAMOEIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig FGOAMFJEHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public LEKJINIHCMI[] GKGAALPBMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public LEKJINIHCMI BLHGBPIPJFE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static JDHKOHJDAAE KLNKFEBGFHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JDHKOHJDAAE COJFEBHGGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCB30", Offset = "0x7DBB730", VA = "0x187DBCB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public JDHKOHJDAAE()
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
		[Cpp2IlInjected.Address(RVA = "0x7DBCA70", Offset = "0x7DBB670", VA = "0x187DBCA70")]
		public GlyphUVConfig(int PEEFMFEAHCB, int KPLIKDAMNHP, int LDELEIIBCNH, int BPFPIGKJPDP, float MIILHAEMBKM = 0f, [Optional] GlyphPixelInset GNOBKCFELEF)
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
public readonly struct LEKJINIHCMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char OHMNKHLOHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int NEPFMHPIKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int BEBLCFAECNI;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly LEKJINIHCMI KMEEMJOJDHM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEEB0", Offset = "0x7DBDAB0", VA = "0x187DBEEB0")]
	public LEKJINIHCMI(char MBKPHDCIILC, int MFNHCDMINHD, int EEMKOBAMNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEEC0", Offset = "0x7DBDAC0", VA = "0x187DBEEC0")]
	public LEKJINIHCMI(GlyphCoordinateWritable KALPALKECPJ)
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
		[Cpp2IlInjected.Address(RVA = "0x7DBC090", Offset = "0x7DBAC90", VA = "0x187DBC090")]
		public static LEKJINIHCMI GHOKLFELACP(GlyphCoordinateWritable OFHHGNENJGM)
		{
			return default(LEKJINIHCMI);
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
		private JDHKOHJDAAE configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7DBC970", Offset = "0x7DBB570", VA = "0x187DBC970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7DBC7F0", Offset = "0x7DBB3F0", VA = "0x187DBC7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7DBC7E0", Offset = "0x7DBB3E0", VA = "0x187DBC7E0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JDHKOHJDAAE ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7DBC1E0", Offset = "0x7DBADE0", VA = "0x187DBC1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LEKJINIHCMI FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7DBC650", Offset = "0x7DBB250", VA = "0x187DBC650")]
			get
			{
				return default(LEKJINIHCMI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC0B0", Offset = "0x7DBACB0", VA = "0x187DBC0B0")]
		internal void BLPMJMIODEC(IEnumerable<GlyphCoordinateWritable> COEDBBHJLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC150", Offset = "0x7DBAD50", VA = "0x187DBC150")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC130", Offset = "0x7DBAD30", VA = "0x187DBC130")]
		[CompilerGenerated]
		private bool FBEDKJNGMNC(GlyphCoordinateWritable OFHHGNENJGM)
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
		private TextSegmentMeshBufferSource EHLNFOELIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private MBEHDOBMBBA GPGOMCCPLEO;

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
		private PKMIJJFCLMH KBHJBCOIKIG;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0F50", Offset = "0x7DBFB50", VA = "0x187DC0F50")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0F00", Offset = "0x7DBFB00", VA = "0x187DC0F00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0D20", Offset = "0x7DBF920", VA = "0x187DC0D20")]
		private void FEHNJGKCCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1040", Offset = "0x7DBFC40", VA = "0x187DC1040")]
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
		private bool PBBILNNHMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material BOJHGHMKDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private MBEHDOBMBBA GPGOMCCPLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material ENCHNJGHOPB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private JDHKOHJDAAE BPKPNHDMNEM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7DC1700", Offset = "0x7DC0300", VA = "0x187DC1700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MBEHDOBMBBA FEBJDOEHEPN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7DC1B50", Offset = "0x7DC0750", VA = "0x187DC1B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material NAGCHELAKEP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7DC1B80", Offset = "0x7DC0780", VA = "0x187DC1B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1AB0", Offset = "0x7DC06B0", VA = "0x187DC1AB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC13C0", Offset = "0x7DBFFC0", VA = "0x187DC13C0", Slot = "8")]
		protected override void ECCMCOJIDKO(FHMIBHPCENP ELMOFEGIFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1AC0", Offset = "0x7DC06C0", VA = "0x187DC1AC0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] OGFLEDBIBDL KDDMGEPCIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7DC15B0", Offset = "0x7DC01B0", VA = "0x187DC15B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1790", Offset = "0x7DC0390", VA = "0x187DC1790")]
		private void PLADODLOEAC(bool JMDCPKFBLOI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA39F20", Offset = "0xA38B20", VA = "0x180A39F20")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct KOMKBJEFJAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly MBEHDOBMBBA FNPIOKKNLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int DABCADFFFBA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE980", Offset = "0x7DBD580", VA = "0x187DBE980")]
	internal KHPDACFEPJL HJIECDPCCAC()
	{
		return default(KHPDACFEPJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x290F750", Offset = "0x290E350", VA = "0x18290F750")]
	internal KOMKBJEFJAD(MBEHDOBMBBA GMBCCEAGHDM, int FPIOMOBADEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DADNEOMOEJE
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC020", Offset = "0x7DBAC20", VA = "0x187DBC020")]
	public static bool NNHHFMMKEBL(this KOMKBJEFJAD OACPAFBLHJL, OHKKDACMLBE HBKHDGLLMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC000", Offset = "0x7DBAC00", VA = "0x187DBC000")]
	internal static bool NNHHFMMKEBL(this KHPDACFEPJL FPGIKJPLNBO, OHKKDACMLBE HBKHDGLLMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBFC0", Offset = "0x7DBABC0", VA = "0x187DBBFC0")]
	public static float MOGEGLDIPMC(this KOMKBJEFJAD OACPAFBLHJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA70940", Offset = "0xA6F540", VA = "0x180A70940")]
	internal static float MOGEGLDIPMC(this KHPDACFEPJL FPGIKJPLNBO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LBNCOCEBHON
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEAD0", Offset = "0x7DBD6D0", VA = "0x187DBEAD0")]
	public static void EBGCFCNDBKC(this KOMKBJEFJAD OACPAFBLHJL, ReadOnlySpan<char> GKFGOMPJPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEB20", Offset = "0x7DBD720", VA = "0x187DBEB20")]
	internal static void EBGCFCNDBKC(this KHPDACFEPJL FPGIKJPLNBO, ReadOnlySpan<char> GKFGOMPJPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEA80", Offset = "0x7DBD680", VA = "0x187DBEA80")]
	public static void CPDHAPLONHM(this KOMKBJEFJAD OPPNFJOLBJG, float2 ILJFPCILIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEA70", Offset = "0x7DBD670", VA = "0x187DBEA70")]
	internal static void CPDHAPLONHM(this KHPDACFEPJL FPGIKJPLNBO, float2 ILJFPCILIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEA00", Offset = "0x7DBD600", VA = "0x187DBEA00")]
	public static void CBICMBPLNJE(this KOMKBJEFJAD OPPNFJOLBJG, float EHAEEOFAINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE9C0", Offset = "0x7DBD5C0", VA = "0x187DBE9C0")]
	internal static void CBICMBPLNJE(this KHPDACFEPJL FPGIKJPLNBO, float EHAEEOFAINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DBED20", Offset = "0x7DBD920", VA = "0x187DBED20")]
	internal static void GCANFLKAHLF(this KHPDACFEPJL FPGIKJPLNBO, bool BAHLLMHFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEDD0", Offset = "0x7DBD9D0", VA = "0x187DBEDD0")]
	public static void NGHGJCAJBOD(this KOMKBJEFJAD OPPNFJOLBJG, Color32 GCKOLKABAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEDC0", Offset = "0x7DBD9C0", VA = "0x187DBEDC0")]
	internal static void NGHGJCAJBOD(this KHPDACFEPJL FPGIKJPLNBO, Color32 GCKOLKABAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEE20", Offset = "0x7DBDA20", VA = "0x187DBEE20")]
	public static void NINLHNDEACG(this KOMKBJEFJAD OPPNFJOLBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEE10", Offset = "0x7DBDA10", VA = "0x187DBEE10")]
	internal static void NINLHNDEACG(this KHPDACFEPJL FPGIKJPLNBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7DBED30", Offset = "0x7DBD930", VA = "0x187DBED30")]
	internal static void JIFOLAEBPAI(this KHPDACFEPJL FPGIKJPLNBO, int GFGHFIKDNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEDA0", Offset = "0x7DBD9A0", VA = "0x187DBEDA0")]
	internal static void LOCMNLANJAI(this KHPDACFEPJL FPGIKJPLNBO, int LCFDGMNFNKH, OHKKDACMLBE OGMGJPOHPPO = OHKKDACMLBE.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PKMIJJFCLMH : IEquatable<PKMIJJFCLMH>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort CHBGGPHCEJM = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int KIHDEIMNCPB = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly PKMIJJFCLMH GPLOBGACKJH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort BMDONCAFMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xCDA700", Offset = "0xCD9300", VA = "0x180CDA700")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCDA710", Offset = "0xCD9310", VA = "0x180CDA710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MBEHDOBMBBA FNPIOKKNLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JICHDGIBAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB60F0", Offset = "0x7DB4CF0", VA = "0x187DB60F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6200", Offset = "0x7DB4E00", VA = "0x187DB6200")]
	public PKMIJJFCLMH(int FCCHAJHFENI, MBEHDOBMBBA GMBCCEAGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0BC0", Offset = "0x7DBF7C0", VA = "0x187DC0BC0")]
	public bool LGOKDDFDKCM([Out] KOMKBJEFJAD OACPAFBLHJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0B00", Offset = "0x7DBF700", VA = "0x187DC0B00")]
	public void FLLBKAADJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6070", Offset = "0x7DB4C70", VA = "0x187DB6070")]
	internal void FHNACCGGBMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5F50", Offset = "0x7DB4B50", VA = "0x187DB5F50", Slot = "4")]
	public bool Equals(PKMIJJFCLMH GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0A40", Offset = "0x7DBF640", VA = "0x187DC0A40", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0B50", Offset = "0x7DBF750", VA = "0x187DC0B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MBEHDOBMBBA : IDisposable, MKAFIIICDOL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string FEDDHALCPKA = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker DBFBEKHJECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string MHEEHOPGFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly PAKBDGFAFIJ NCFEGMDHGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int DPPGCFHNOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal KHPDACFEPJL[] FLJEONMGOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal PKMIJJFCLMH[] HEICDADCIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private JDHKOHJDAAE BAKGCCDAAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JHFMBHFGIJH FIACLENOCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly KMKHENJIAPM GCPLMNGJNHC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string LAOCJKNALFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF8A0", Offset = "0x7DBE4A0", VA = "0x187DBF8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JDHKOHJDAAE BMHBLPLFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0090", Offset = "0x7DBEC90", VA = "0x187DC0090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float AAHPMDBEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF080", Offset = "0x7DBDC80", VA = "0x187DBF080")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float IECFCABAJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFE10", Offset = "0x7DBEA10", VA = "0x187DBFE10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MKAFIIICDOL.ONHOKKLMBCG DKCKDBPPJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA1C700", Offset = "0xA1B300", VA = "0x180A1C700", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6B0", Offset = "0xA1B2B0", VA = "0x180A1C6B0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0400", Offset = "0x7DBF000", VA = "0x187DC0400")]
	public MBEHDOBMBBA(PAKBDGFAFIJ JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0380", Offset = "0x7DBEF80", VA = "0x187DC0380")]
	public MBEHDOBMBBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF4C0", Offset = "0x7DBE0C0", VA = "0x187DBF4C0")]
	public void GFFHNKPMBNJ(GlyphMapAsset HJJFEPBLIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF500", Offset = "0x7DBE100", VA = "0x187DBF500")]
	public void GFFHNKPMBNJ(JDHKOHJDAAE AHIBPIAFKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC00B0", Offset = "0x7DBECB0", VA = "0x187DC00B0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] OGFLEDBIBDL KDDMGEPCIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF610", Offset = "0x7DBE210", VA = "0x187DBF610")]
	public void HPFLDHCMINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF850", Offset = "0x7DBE450", VA = "0x187DBF850")]
	public bool JFGBOBKDGOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DBFE30", Offset = "0x7DBEA30", VA = "0x187DBFE30")]
	public PKMIJJFCLMH NJGGHMIINJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DBFAB0", Offset = "0x7DBE6B0", VA = "0x187DBFAB0")]
	public void LOJJEHCGFIA(PKMIJJFCLMH EKPPLJOLBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEFD0", Offset = "0x7DBDBD0", VA = "0x187DBEFD0")]
	internal bool CLJFILNKGAD(PKMIJJFCLMH EKPPLJOLBHE, [Out] KOMKBJEFJAD OACPAFBLHJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF930", Offset = "0x7DBE530", VA = "0x187DBF930")]
	private void LIHECFJPKAI(KHPDACFEPJL FPGIKJPLNBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF670", Offset = "0x7DBE270", VA = "0x187DBF670")]
	private void IIDHKGMLLMM(int KBDENKHHBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF460", Offset = "0x7DBE060", VA = "0x187DBF460")]
	private bool EOOEELPPDIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7DB51A0", Offset = "0x7DB3DA0", VA = "0x187DB51A0")]
	private static int ELCEAONPDMA(PKMIJJFCLMH EKPPLJOLBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x23AC4F0", Offset = "0x23AB0F0", VA = "0x1823AC4F0")]
	private static ushort IAFLFLOEEAC(int EMMACFPOKFB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF150", Offset = "0x7DBDD50", VA = "0x187DBF150")]
	private Bounds ECFMCPIKLMB()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF0A0", Offset = "0x7DBDCA0", VA = "0x187DBF0A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PAKBDGFAFIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly PAKBDGFAFIJ IKDKBHFMIPC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float AIIKGDABHLC = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int BKGOJCOKIAC = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int IKBBPKIOHLF = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color OFFCNHBAOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float MDBCNMHBKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int NPPONFFFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int NBIJDAGBABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int PBHLMMFAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int PNDEBJBPLOG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0880", Offset = "0x7DBF480", VA = "0x187DC0880")]
	internal PAKBDGFAFIJ LMINAFIOGDL()
	{
		return default(PAKBDGFAFIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9830", Offset = "0x7DB8430", VA = "0x187DB9830")]
	[CompilerGenerated]
	internal static void FDNGMEMBKEH(int OOHGFGHCOAJ, int IPOLOHBNCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0860", Offset = "0x7DBF460", VA = "0x187DC0860")]
	[CompilerGenerated]
	internal static void LHHNMJHDBHN(float OOHGFGHCOAJ, float IPOLOHBNCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9820", Offset = "0x7DB8420", VA = "0x187DB9820")]
	[CompilerGenerated]
	internal static void DCMAMHIMIIE(int OOHGFGHCOAJ, int MABMAHLAECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0840", Offset = "0x7DBF440", VA = "0x187DC0840")]
	[CompilerGenerated]
	internal static void EDCPLJMKJPJ(float OOHGFGHCOAJ, float MABMAHLAECP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HJAMCJJFKMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCAA0", Offset = "0x7DBB6A0", VA = "0x187DBCAA0")]
	public static float IKALIKCELHC(this KOMKBJEFJAD NJFIIGHEENN)
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
		public readonly PKMIJJFCLMH textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1350", Offset = "0x7DBFF50", VA = "0x187DC1350")]
		public TextSegmentLayout(LayoutRect layoutRect, PKMIJJFCLMH textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1120", Offset = "0x7DBFD20", VA = "0x187DC1120")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1190", Offset = "0x7DBFD90", VA = "0x187DC1190")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7DC10C0", Offset = "0x7DBFCC0", VA = "0x187DC10C0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class JHFMBHFGIJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig BLFGDBKOCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float BNLFIPACGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float DLNIDFHOOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float MKNOMLFCEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float AAJOKGPAMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float CFJIAGLBHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float ECOHJLBIBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float OHNBOKPGJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float HIAOKKNLMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float BGJGMPANNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float IECFCABAJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float IOELKJINOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float AAHPMDBEKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MAACHELOGDO[] PFAACBHPAPH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int OMGJGGKAMFA = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private FAFDJCENGPI[] IPFODCCEBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int CANIEGJNNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private LEKJINIHCMI[] CIBOLCMNBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int HPFJJJEFNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MAACHELOGDO PDOEIIEDGEL;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCE60", Offset = "0x7DBBA60", VA = "0x187DBCE60")]
	public void GFFHNKPMBNJ(JDHKOHJDAAE CAHECGDPIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCDE0", Offset = "0x7DBB9E0", VA = "0x187DBCDE0")]
	public void GFFHNKPMBNJ(GlyphUVConfig IKDOFNJFNFJ, IEnumerable<LEKJINIHCMI> HJJFEPBLIIE, LEKJINIHCMI DHLIGPLNJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCCA0", Offset = "0x7DBB8A0", VA = "0x187DBCCA0")]
	internal void CENFJKOKDPJ(GlyphUVConfig IKDOFNJFNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCEF0", Offset = "0x7DBBAF0", VA = "0x187DBCEF0")]
	private void LNOPMLLOBDD(IEnumerable<LEKJINIHCMI> HJJFEPBLIIE, LEKJINIHCMI DHLIGPLNJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD420", Offset = "0x7DBC020", VA = "0x187DBD420")]
	public void ONIAILNEHKK([In] char MBKPHDCIILC, [Out] float2[] GNPCKIPNNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBA370", Offset = "0x7DB8F70", VA = "0x187DBA370")]
	private MAACHELOGDO PKGNGMFKMEO(LEKJINIHCMI KALPALKECPJ)
	{
		return default(MAACHELOGDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD750", Offset = "0x7DBC350", VA = "0x187DBD750")]
	public JHFMBHFGIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JKMFJBILODD
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD8B0", Offset = "0x7DBC4B0", VA = "0x187DBD8B0")]
	public static void JGHMDBNFFLK([In] float AOKDCCHLBEN, [In] float KINAIMNNOGM, [In] int FDEDEKLLLHB, [In] int IBBMCHIFEAH, [In] float AAJOKGPAMAM, [In] float CFJIAGLBHFG, [In] float PKMPPIBHHOF, [In] float OBILHINMPMF, [In] float PBMIFOOIPGI, [In] float KGKMGAOIDOE, [Out] float ENKBIPENGNM, [Out] float LMDOEIAEDMC, [Out] float OAKMPJDMMGI, [Out] float PELPNMLPAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD850", Offset = "0x7DBC450", VA = "0x187DBD850")]
	public static void JGHMDBNFFLK([In] float AOKDCCHLBEN, [In] float KINAIMNNOGM, [In] int FDEDEKLLLHB, [In] int IBBMCHIFEAH, [Out] float ENKBIPENGNM, [Out] float LMDOEIAEDMC, [Out] float OAKMPJDMMGI, [Out] float PELPNMLPAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD7F0", Offset = "0x7DBC3F0", VA = "0x187DBD7F0")]
	public static void ECDAEJKONAA([In] float AAJOKGPAMAM, [In] float CFJIAGLBHFG, [In] float EAGNIGNFJCB, [In] float BHNLEDHOGJN, [In] float GLEAICOPLDJ, [In] float IFLNLFHEONJ, [Out] float NEIFJMEFNBA, [Out] float GPEDGJAJGAM, [Out] float PILIAHLAFJL, [Out] float JEBKMOKFOEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct FAFDJCENGPI
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint CEDEFFFODDH = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char OHMNKHLOHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly MAACHELOGDO PBBKPDPAOOL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC070", Offset = "0x7DBAC70", VA = "0x187DBC070")]
	public FAFDJCENGPI(char MBKPHDCIILC, MAACHELOGDO GNPCKIPNNJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MAACHELOGDO
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint CEDEFFFODDH = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] KPBDEKJJJMA;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEEE0", Offset = "0x7DBDAE0", VA = "0x187DBEEE0")]
	public MAACHELOGDO(float ENKBIPENGNM, float LMDOEIAEDMC, float OAKMPJDMMGI, float PELPNMLPAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct KHPDACFEPJL
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int CMLDKHEBAEJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal OHKKDACMLBE OGMGJPOHPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] AIFFHBPINJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int EBGFIIOPAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 ILJFPCILIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float EGICMIAEEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 MCACLHGHDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool BAHLLMHFHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int MIAKEKCLPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int FNHJEPLIMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int CKCFHPNMOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int AIGOIJOJBEC;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDA40", Offset = "0x7DBC640", VA = "0x187DBDA40")]
	public static int MBLOJFIIOHE(int OJODMLGCAEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum OHKKDACMLBE : byte
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
public static class KALJIMMEHHK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDA00", Offset = "0x7DBC600", VA = "0x187DBDA00")]
	internal static float IKALIKCELHC(this KHPDACFEPJL FPGIKJPLNBO, float BNDJDHONEEL, float HJNJNLIDPDL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD980", Offset = "0x7DBC580", VA = "0x187DBD980")]
	internal static void CCBPDEIMEOP(this KHPDACFEPJL FPGIKJPLNBO, float BNDJDHONEEL, float HJNJNLIDPDL, [Out] float2 PNMBBJAACMD, [Out] float2 LMOAHCJOHNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class KMKHENJIAPM : MKAFIIICDOL
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int FBOCGOBMMFC = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int ELJKOKBFDGJ = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string FEDDHALCPKA = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker AOICDKGELFJ;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker ILLJKFPOMAP;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker EJPDAEIIACE;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker IHEOGFBMLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly OGFLEDBIBDL KDDMGEPCIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] CEANPOFMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] BPDJGGGHIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int EFAPONNJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int MFHNOJKDJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int LOFOACHPKJH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string LAOCJKNALFF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MKAFIIICDOL.ONHOKKLMBCG DKCKDBPPJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE870", Offset = "0x7DBD470", VA = "0x187DBE870")]
	public KMKHENJIAPM(OGFLEDBIBDL.CKKLHCKFLAK OCAABNJNNJC, int KLHMCLHKOGA, int PODIJCJPKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE6F0", Offset = "0x7DBD2F0", VA = "0x187DBE6F0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] OGFLEDBIBDL KDDMGEPCIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE580", Offset = "0x7DBD180", VA = "0x187DBE580")]
	public void KEAPAPEEHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDC80", Offset = "0x7DBC880", VA = "0x187DBDC80")]
	public void BOEBJEMCFAG(Span<KHPDACFEPJL> DKGMNCEHNHK, JHFMBHFGIJH GGHJGDKBFAC, [In] PAKBDGFAFIJ JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7DBA650", Offset = "0x7DB9250", VA = "0x187DBA650")]
	private void BNFNBEJEHJF([In] OHKKDACMLBE OGMGJPOHPPO, [In] KHPDACFEPJL JNJEGJKFPAM, int OMAAIMOPHKN, [In] float BNDJDHONEEL, [In] float HJNJNLIDPDL, JHFMBHFGIJH GGHJGDKBFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE5A0", Offset = "0x7DBD1A0", VA = "0x187DBE5A0")]
	private void NBDOGBPEEDC([In] OHKKDACMLBE OGMGJPOHPPO, KHPDACFEPJL JNJEGJKFPAM, [In] int NJHOAPKGEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDA50", Offset = "0x7DBC650", VA = "0x187DBDA50")]
	public static void APEHJDCNGDO(ReadOnlySpan<KHPDACFEPJL> DKGMNCEHNHK, int FOOMPELBLMI, [Out] int ANNKINIAKDO, [Out] int NBLLNMLAFMH, [Out] int PENOIDMOEON)
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
