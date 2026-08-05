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
public class POPPFNKKALK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D AGNKBJNHOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig IACANLOBAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public KMIBHNBFNNE[] OPLLFBBCBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public KMIBHNBFNNE JNFGCDDALFI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static POPPFNKKALK OJMJLMBAPGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static POPPFNKKALK LDMFMHCMFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B22B50", Offset = "0x7B21350", VA = "0x187B22B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public POPPFNKKALK()
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
		[Cpp2IlInjected.Address(RVA = "0x7B1FB20", Offset = "0x7B1E320", VA = "0x187B1FB20")]
		public GlyphUVConfig(int BPHMGEHCAAK, int GNIJMIGECBG, int ELNLLGJMAMC, int GNBCJGLFFIC, float LNKMNDFHGIE = 0f, [Optional] GlyphPixelInset BGBOKGKCEBE)
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
public readonly struct KMIBHNBFNNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char KJJNMHGNPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int ELEJDNIBPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int GBAIGKNJLBH;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly KMIBHNBFNNE PGKMNHJEJGM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B21C60", Offset = "0x7B20460", VA = "0x187B21C60")]
	public KMIBHNBFNNE(char BJFCLMNBLLK, int DAPKNGNMBAB, int CFLAIEPNCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B21C40", Offset = "0x7B20440", VA = "0x187B21C40")]
	public KMIBHNBFNNE(GlyphCoordinateWritable GIBDPCEPNAK)
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
		[Cpp2IlInjected.Address(RVA = "0x7B1F140", Offset = "0x7B1D940", VA = "0x187B1F140")]
		public static KMIBHNBFNNE FGIKKMMHFBO(GlyphCoordinateWritable JDLOGJMLBHP)
		{
			return default(KMIBHNBFNNE);
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
		private POPPFNKKALK configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7B1FA20", Offset = "0x7B1E220", VA = "0x187B1FA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F8A0", Offset = "0x7B1E0A0", VA = "0x187B1F8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F890", Offset = "0x7B1E090", VA = "0x187B1F890")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public POPPFNKKALK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F290", Offset = "0x7B1DA90", VA = "0x187B1F290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KMIBHNBFNNE FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F700", Offset = "0x7B1DF00", VA = "0x187B1F700")]
			get
			{
				return default(KMIBHNBFNNE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F160", Offset = "0x7B1D960", VA = "0x187B1F160")]
		internal void DGBHNBJJOIL(IEnumerable<GlyphCoordinateWritable> DBKJCBBHLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F200", Offset = "0x7B1DA00", VA = "0x187B1F200")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F1E0", Offset = "0x7B1D9E0", VA = "0x187B1F1E0")]
		[CompilerGenerated]
		private bool IKMGJGLABBL(GlyphCoordinateWritable JDLOGJMLBHP)
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
		private TextSegmentMeshBufferSource HFDHPOFDDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private HMKENKMGCKF JDGAGNAJFND;

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
		private HJJFGPFIDCO INFLNKEMIAF;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B22EF0", Offset = "0x7B216F0", VA = "0x187B22EF0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B22EA0", Offset = "0x7B216A0", VA = "0x187B22EA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B22CC0", Offset = "0x7B214C0", VA = "0x187B22CC0")]
		private void NDAOILHDONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B22FE0", Offset = "0x7B217E0", VA = "0x187B22FE0")]
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
		private bool FMFODNFGBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material JFCIPGEKKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private HMKENKMGCKF JDGAGNAJFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material LPADMKFPFJA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private POPPFNKKALK LMEFCGOFNFH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7B23360", Offset = "0x7B21B60", VA = "0x187B23360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HMKENKMGCKF DCDKFOADJKM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7B23AF0", Offset = "0x7B222F0", VA = "0x187B23AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material BEOMMICKAOF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7B23B20", Offset = "0x7B22320", VA = "0x187B23B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B23A50", Offset = "0x7B22250", VA = "0x187B23A50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B23710", Offset = "0x7B21F10", VA = "0x187B23710", Slot = "8")]
		protected override void KPBINKEJLFH(NOBAMOALMNP GNLJHOFLOPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B23A60", Offset = "0x7B22260", VA = "0x187B23A60", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] EMKKKPODNDP PPHMBDIMPNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B23900", Offset = "0x7B22100", VA = "0x187B23900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B233F0", Offset = "0x7B21BF0", VA = "0x187B233F0")]
		private void FDPKBBMBFJE(bool IOHDICMKADP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct GKOOOGPAODF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly HMKENKMGCKF HONJAIEALBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int IFAHGECMMLE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F070", Offset = "0x7B1D870", VA = "0x187B1F070")]
	internal CICOLENINDJ BNHIKHPLAPD()
	{
		return default(CICOLENINDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x274AE20", Offset = "0x2749620", VA = "0x18274AE20")]
	internal GKOOOGPAODF(HMKENKMGCKF IPKPNIAEJDE, int CBCEKMANAHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JFDAGEHAOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7B21B60", Offset = "0x7B20360", VA = "0x187B21B60")]
	public static bool ADNCPBOOKMC(this GKOOOGPAODF IPHKFFAEKEP, CMDHDPDALGM JNEJEBBEKPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B21B40", Offset = "0x7B20340", VA = "0x187B21B40")]
	internal static bool ADNCPBOOKMC(this CICOLENINDJ JNCGHJLJDOF, CMDHDPDALGM JNEJEBBEKPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B21BB0", Offset = "0x7B203B0", VA = "0x187B21BB0")]
	public static float NMPGFDDNONG(this GKOOOGPAODF IPHKFFAEKEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD03120", Offset = "0xD01920", VA = "0x180D03120")]
	internal static float NMPGFDDNONG(this CICOLENINDJ JNCGHJLJDOF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HGJJCOADDEC
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FE10", Offset = "0x7B1E610", VA = "0x187B1FE10")]
	public static void GHBFKCECCCM(this GKOOOGPAODF IPHKFFAEKEP, ReadOnlySpan<char> NBCMPNCOBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FC10", Offset = "0x7B1E410", VA = "0x187B1FC10")]
	internal static void GHBFKCECCCM(this CICOLENINDJ JNCGHJLJDOF, ReadOnlySpan<char> NBCMPNCOBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FF10", Offset = "0x7B1E710", VA = "0x187B1FF10")]
	public static void NDNEPACHBDK(this GKOOOGPAODF PFKHGPDFOKG, float2 CPMPFJLOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FF00", Offset = "0x7B1E700", VA = "0x187B1FF00")]
	internal static void NDNEPACHBDK(this CICOLENINDJ JNCGHJLJDOF, float2 CPMPFJLOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FBA0", Offset = "0x7B1E3A0", VA = "0x187B1FBA0")]
	public static void EOCNNHOHDCP(this GKOOOGPAODF PFKHGPDFOKG, float ELHENHPDCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FB60", Offset = "0x7B1E360", VA = "0x187B1FB60")]
	internal static void EOCNNHOHDCP(this CICOLENINDJ JNCGHJLJDOF, float ELHENHPDCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FB50", Offset = "0x7B1E350", VA = "0x187B1FB50")]
	internal static void BFANHMFODKB(this CICOLENINDJ JNCGHJLJDOF, bool CNLKOBHFPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FE60", Offset = "0x7B1E660", VA = "0x187B1FE60")]
	public static void GNHKIJLCOIB(this GKOOOGPAODF PFKHGPDFOKG, Color32 AGNHOOELDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FEA0", Offset = "0x7B1E6A0", VA = "0x187B1FEA0")]
	internal static void GNHKIJLCOIB(this CICOLENINDJ JNCGHJLJDOF, Color32 AGNHOOELDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FEB0", Offset = "0x7B1E6B0", VA = "0x187B1FEB0")]
	public static void IHJHONOFBKJ(this GKOOOGPAODF PFKHGPDFOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FEF0", Offset = "0x7B1E6F0", VA = "0x187B1FEF0")]
	internal static void IHJHONOFBKJ(this CICOLENINDJ JNCGHJLJDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FF80", Offset = "0x7B1E780", VA = "0x187B1FF80")]
	internal static void PNMHPEPHDDJ(this CICOLENINDJ JNCGHJLJDOF, int HOGIPPOJOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FF60", Offset = "0x7B1E760", VA = "0x187B1FF60")]
	internal static void PDJPHPHDLHD(this CICOLENINDJ JNCGHJLJDOF, int IBPOIOFHJLP, CMDHDPDALGM EEDAPMICKOA = CMDHDPDALGM.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HJJFGPFIDCO : IEquatable<HJJFGPFIDCO>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort JOKCCEJCIJH = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int NFGODFKIAJB = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly HJJFGPFIDCO EKCFCNBECGC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort KJIOGPCPDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC1E9B0", Offset = "0xC1D1B0", VA = "0x180C1E9B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC1E9C0", Offset = "0xC1D1C0", VA = "0x180C1E9C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HMKENKMGCKF HONJAIEALBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FFFKLPKJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B19430", Offset = "0x7B17C30", VA = "0x187B19430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B19630", Offset = "0x7B17E30", VA = "0x187B19630")]
	public HJJFGPFIDCO(int OJMEDDFMECA, HMKENKMGCKF IPKPNIAEJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B1FFF0", Offset = "0x7B1E7F0", VA = "0x187B1FFF0")]
	public bool BGGNCDNPOMF([Out] GKOOOGPAODF IPHKFFAEKEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B201F0", Offset = "0x7B1E9F0", VA = "0x187B201F0")]
	public void IHLFGIKCBJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B17CB0", VA = "0x187B194B0")]
	internal void IGJMCPDFGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B193D0", Offset = "0x7B17BD0", VA = "0x187B193D0", Slot = "4")]
	public bool Equals(HJJFGPFIDCO PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7B200C0", Offset = "0x7B1E8C0", VA = "0x187B200C0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B20180", Offset = "0x7B1E980", VA = "0x187B20180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HMKENKMGCKF : IDisposable, ODMKKNDLMMG
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string FHMMBADLFEN = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker ONMKFHKHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string CAMPMBKDEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly MBDDGGIEGJD MFJHBAICAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int CPABPHCIPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal CICOLENINDJ[] MBMNOOMLKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HJJFGPFIDCO[] PILJNNGPMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private POPPFNKKALK EFLBBJFGOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PKONPENNPBH OAEBOAIFKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly DJAIIMPLLOG AHMGCGOHMMA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GLGOHIJMLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B20930", Offset = "0x7B1F130", VA = "0x187B20930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public POPPFNKKALK GPKIHGHPKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B20D10", Offset = "0x7B1F510", VA = "0x187B20D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float LDOGPLDDJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B209C0", Offset = "0x7B1F1C0", VA = "0x187B209C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float DAKGLGBDANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7B209E0", Offset = "0x7B1F1E0", VA = "0x187B209E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ODMKKNDLMMG.AGDAEMGELGF MAPFGEMOACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1B0", Offset = "0x9DB9B0", VA = "0x1809DD1B0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B21680", Offset = "0x7B1FE80", VA = "0x187B21680")]
	public HMKENKMGCKF(MBDDGGIEGJD PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B21AC0", Offset = "0x7B202C0", VA = "0x187B21AC0")]
	public HMKENKMGCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B20D30", Offset = "0x7B1F530", VA = "0x187B20D30")]
	public void ILJHHMHPGDK(GlyphMapAsset HHBAEDMPANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B20D70", Offset = "0x7B1F570", VA = "0x187B20D70")]
	public void ILJHHMHPGDK(POPPFNKKALK PMOLHNABPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B213B0", Offset = "0x7B1FBB0", VA = "0x187B213B0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] EMKKKPODNDP PPHMBDIMPNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B207C0", Offset = "0x7B1EFC0", VA = "0x187B207C0")]
	public void FAHGKOHKEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B21360", Offset = "0x7B1FB60", VA = "0x187B21360")]
	public bool ONPMFKJOPLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B204B0", Offset = "0x7B1ECB0", VA = "0x187B204B0")]
	public HJJFGPFIDCO DEOGLJNKEBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B21000", Offset = "0x7B1F800", VA = "0x187B21000")]
	public void MGOBKGPHDAA(HJJFGPFIDCO HDOHMHFPHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B20820", Offset = "0x7B1F020", VA = "0x187B20820")]
	internal bool FDCPOHCIIEH(HJJFGPFIDCO HDOHMHFPHAE, [Out] GKOOOGPAODF IPHKFFAEKEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7B20E80", Offset = "0x7B1F680", VA = "0x187B20E80")]
	private void MBPNEHPNOOG(CICOLENINDJ JNCGHJLJDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B202D0", Offset = "0x7B1EAD0", VA = "0x187B202D0")]
	private void AJKGEMCMBKP(int LPHFAHCAMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B208D0", Offset = "0x7B1F0D0", VA = "0x187B208D0")]
	private bool FICHIKKHPPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B18390", Offset = "0x7B16B90", VA = "0x187B18390")]
	private static int DDFIEBEGOGM(HJJFGPFIDCO HDOHMHFPHAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20ACA90", Offset = "0x20AB290", VA = "0x1820ACA90")]
	private static ushort IPMPLOOBJAD(int FPEOONOJHML)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B20A00", Offset = "0x7B1F200", VA = "0x187B20A00")]
	private Bounds HPJCEKGDFDL()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B20710", Offset = "0x7B1EF10", VA = "0x187B20710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MBDDGGIEGJD
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MBDDGGIEGJD CPBDLGLLCKH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float DHFCNDHCKFD = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int DMPHJCKIHEO = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int EKLGAAICMCF = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color PJPHIGPJNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float DLHOIDPLCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int PPKEMANOKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int CPMFBABNHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int HNCDEOGLCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int AMBFCANLBHE;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B21CB0", Offset = "0x7B204B0", VA = "0x187B21CB0")]
	internal MBDDGGIEGJD MMHMJFIDDCH()
	{
		return default(MBDDGGIEGJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B152A0", Offset = "0x7B13AA0", VA = "0x187B152A0")]
	[CompilerGenerated]
	internal static void FOMMGOODKNE(int OPMIAMEJKDH, int LHCNPHOLELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B21C90", Offset = "0x7B20490", VA = "0x187B21C90")]
	[CompilerGenerated]
	internal static void MIKADBFINDO(float OPMIAMEJKDH, float LHCNPHOLELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B152B0", Offset = "0x7B13AB0", VA = "0x187B152B0")]
	[CompilerGenerated]
	internal static void ENIEMDOKDFN(int OPMIAMEJKDH, int DBGIFMFOLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B21C70", Offset = "0x7B20470", VA = "0x187B21C70")]
	[CompilerGenerated]
	internal static void DKBFFFABFCA(float OPMIAMEJKDH, float DBGIFMFOLPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GOMJEAGHPOI
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F0B0", Offset = "0x7B1D8B0", VA = "0x187B1F0B0")]
	public static float KPKFCLGBPHD(this GKOOOGPAODF KIGDCDAIACO)
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
		public readonly HJJFGPFIDCO textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B232F0", Offset = "0x7B21AF0", VA = "0x187B232F0")]
		public TextSegmentLayout(LayoutRect layoutRect, HJJFGPFIDCO textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B230C0", Offset = "0x7B218C0", VA = "0x187B230C0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7B23130", Offset = "0x7B21930", VA = "0x187B23130")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B23060", Offset = "0x7B21860", VA = "0x187B23060")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class PKONPENNPBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig LFIPHMPCKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float HFLLJOLGBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float BDPBAEAFCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float NKCEEKNBNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float AHLHAPGLOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float KHCHPPDKNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float HJGGBOBECJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float BCKHFIGGLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float MEJNMJBPEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float AGINJGPOMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float DAKGLGBDANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float NHOAKBBHALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float LDOGPLDDJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CDCJFKHPEJG[] AMIFONEEBBN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int DPJFPAJNDJD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private EFGNDGGPEAK[] CENPKILFHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int PIKFJCGKEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private KMIBHNBFNNE[] ALELMFFGOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int NEJFNJDHOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public CDCJFKHPEJG KCJKHLMAFJO;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B223B0", Offset = "0x7B20BB0", VA = "0x187B223B0")]
	public void ILJHHMHPGDK(POPPFNKKALK GPCBCOGDDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B22330", Offset = "0x7B20B30", VA = "0x187B22330")]
	public void ILJHHMHPGDK(GlyphUVConfig ABKDMHGCFOD, IEnumerable<KMIBHNBFNNE> HHBAEDMPANO, KMIBHNBFNNE KIPLOMECIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B22970", Offset = "0x7B21170", VA = "0x187B22970")]
	internal void MHEMKCNGLKI(GlyphUVConfig ABKDMHGCFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B22440", Offset = "0x7B20C40", VA = "0x187B22440")]
	private void KPCBJBODAKD(IEnumerable<KMIBHNBFNNE> HHBAEDMPANO, KMIBHNBFNNE KIPLOMECIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B22000", Offset = "0x7B20800", VA = "0x187B22000")]
	public void FNNIGGEAIOP([In] char BJFCLMNBLLK, [Out] float2[] MGJIDPJJPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7B1DD80", Offset = "0x7B1C580", VA = "0x187B1DD80")]
	private CDCJFKHPEJG KMNHMNCDEAG(KMIBHNBFNNE GIBDPCEPNAK)
	{
		return default(CDCJFKHPEJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B22AB0", Offset = "0x7B212B0", VA = "0x187B22AB0")]
	public PKONPENNPBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OKHBOHDGHAO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B21E70", Offset = "0x7B20670", VA = "0x187B21E70")]
	public static void CNMMHGEGMHB([In] float KCIGHFOACBF, [In] float BIMCBIBJEAL, [In] int PGJCEOGJIJJ, [In] int LDHLAGNBFGJ, [In] float AHLHAPGLOFD, [In] float KHCHPPDKNFC, [In] float LGKCCFPDBLI, [In] float DHNNGBMFOAD, [In] float OPFFAEFBCMI, [In] float GMMMCMFEBHD, [Out] float LEJDNPGKHKK, [Out] float MEOJLHPBIGA, [Out] float BKPGCBOEMJG, [Out] float OICNBGHFKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B21F40", Offset = "0x7B20740", VA = "0x187B21F40")]
	public static void CNMMHGEGMHB([In] float KCIGHFOACBF, [In] float BIMCBIBJEAL, [In] int PGJCEOGJIJJ, [In] int LDHLAGNBFGJ, [Out] float LEJDNPGKHKK, [Out] float MEOJLHPBIGA, [Out] float BKPGCBOEMJG, [Out] float OICNBGHFKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B21FA0", Offset = "0x7B207A0", VA = "0x187B21FA0")]
	public static void IKFPLOOGPND([In] float AHLHAPGLOFD, [In] float KHCHPPDKNFC, [In] float DICEJKGEPMJ, [In] float OOHJEDOHGNM, [In] float NJIGGIAMHKB, [In] float KBHILNNGAFI, [Out] float DPGGJLFNDGG, [Out] float FHBODHGLKGN, [Out] float GLNNECIEGGF, [Out] float LKEHHFFNIEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct EFGNDGGPEAK
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint MMCIOJMBDDJ = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char KJJNMHGNPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly CDCJFKHPEJG FFJCGJGAFAO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F050", Offset = "0x7B1D850", VA = "0x187B1F050")]
	public EFGNDGGPEAK(char BJFCLMNBLLK, CDCJFKHPEJG MGJIDPJJPLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CDCJFKHPEJG
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint MMCIOJMBDDJ = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] MHJBKADOJDB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B1DF60", Offset = "0x7B1C760", VA = "0x187B1DF60")]
	public CDCJFKHPEJG(float LEJDNPGKHKK, float MEOJLHPBIGA, float BKPGCBOEMJG, float OICNBGHFKPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct CICOLENINDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int EKHMFCNDJKB = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal CMDHDPDALGM EEDAPMICKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] FMOCIPEHKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int OMCHIEEDACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 CPMPFJLOLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float PLPAAPGMOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 AAJCHEKALLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool CNLKOBHFPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int GPACJJJPHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int GDFBIBMLOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int NCMFBDJJJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int MEEBCOGBELP;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B1E110", Offset = "0x7B1C910", VA = "0x187B1E110")]
	public static int NHFCKEIFGDE(int LPKLEBHACCD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum CMDHDPDALGM : byte
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
public static class CHAELKOMNEP
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B1E0D0", Offset = "0x7B1C8D0", VA = "0x187B1E0D0")]
	internal static float KPKFCLGBPHD(this CICOLENINDJ JNCGHJLJDOF, float KDDBGJFNJCG, float AOKGDNKKOBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B1E050", Offset = "0x7B1C850", VA = "0x187B1E050")]
	internal static void EIMCPGKNIPJ(this CICOLENINDJ JNCGHJLJDOF, float KDDBGJFNJCG, float AOKGDNKKOBA, [Out] float2 EDGENFDJJHO, [Out] float2 FGNFJAMALCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class DJAIIMPLLOG : ODMKKNDLMMG
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int FPFJLJIHFHD = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int DEMHHLPMFON = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string FHMMBADLFEN = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker NJBNOKBHOEI;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker AMAGBJCOILI;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker JCIGCMAJHNO;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker GEOMHFAAGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly EMKKKPODNDP PPHMBDIMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] DFPNMJIJDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] DEHABGDIBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int MFCLKBLALMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int FPDOCLMNMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int IBAADJNBFII;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GLGOHIJMLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ODMKKNDLMMG.AGDAEMGELGF MAPFGEMOACE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B1EF40", Offset = "0x7B1D740", VA = "0x187B1EF40")]
	public DJAIIMPLLOG(EMKKKPODNDP.KPALNFECOCI AHJDLPLGINC, int LDFHEGIJDFL, int OBMPFNKNAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B1EDC0", Offset = "0x7B1D5C0", VA = "0x187B1EDC0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] EMKKKPODNDP PPHMBDIMPNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B1E120", Offset = "0x7B1C920", VA = "0x187B1E120")]
	public void HMHLADLPJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1E290", Offset = "0x7B1CA90", VA = "0x187B1E290")]
	public void OPNJOLGIFFN(Span<CICOLENINDJ> DLEMABJFHDF, PKONPENNPBH EIDJJPHGHIE, [In] MBDDGGIEGJD PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B1BEB0", Offset = "0x7B1A6B0", VA = "0x187B1BEB0")]
	private void KJAJCPNOHIA([In] CMDHDPDALGM EEDAPMICKOA, [In] CICOLENINDJ IJAPFLFCJNB, int NKJHKECNJNI, [In] float KDDBGJFNJCG, [In] float AOKGDNKKOBA, PKONPENNPBH EIDJJPHGHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B1E140", Offset = "0x7B1C940", VA = "0x187B1E140")]
	private void NNNAFCLLMNG([In] CMDHDPDALGM EEDAPMICKOA, CICOLENINDJ IJAPFLFCJNB, [In] int HKDCDHGAJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7B1EB90", Offset = "0x7B1D390", VA = "0x187B1EB90")]
	public static void PBEGCKBAEFH(ReadOnlySpan<CICOLENINDJ> DLEMABJFHDF, int JPFNAKDPONO, [Out] int IKMKBLAMLDE, [Out] int EGMGLOGBJFO, [Out] int ECDGPHLFNHD)
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
