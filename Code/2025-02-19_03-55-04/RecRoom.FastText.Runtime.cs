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
public class FKFFNAIOFAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D LJJLHJHFKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig APLBGEDFGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public NFFDFJFOFFK[] MLHDPNJIOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public NFFDFJFOFFK PKCNCPKPMPJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FKFFNAIOFAL JABIEKLOADM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FKFFNAIOFAL AHEHEKDNJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74A4190", Offset = "0x74A2D90", VA = "0x1874A4190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public FKFFNAIOFAL()
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
		[Cpp2IlInjected.Address(RVA = "0x74A4DA0", Offset = "0x74A39A0", VA = "0x1874A4DA0")]
		public GlyphUVConfig(int GODEAAEKMCA, int FNLMNNGFCJP, int DDNKAHLKHAP, int MGKPCFLIPCP, float PCBDOGEGDPF = 0f, [Optional] GlyphPixelInset ICEHKFJFHBI)
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
public readonly struct NFFDFJFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char EILKCIDFIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int DAHOIODOJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int BPCEDBGMPKK;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly NFFDFJFOFFK JDGBIGMMKDF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74A8550", Offset = "0x74A7150", VA = "0x1874A8550")]
	public NFFDFJFOFFK(char FJADGLNCEPP, int KDJGAPLHACF, int ODECFDHJEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74A8530", Offset = "0x74A7130", VA = "0x1874A8530")]
	public NFFDFJFOFFK(GlyphCoordinateWritable LINCDKMOBDD)
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
		[Cpp2IlInjected.Address(RVA = "0x74A43C0", Offset = "0x74A2FC0", VA = "0x1874A43C0")]
		public static NFFDFJFOFFK NIBCGLOMJGK(GlyphCoordinateWritable NFEBCHCLBIA)
		{
			return default(NFFDFJFOFFK);
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
		private FKFFNAIOFAL configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x74A4CA0", Offset = "0x74A38A0", VA = "0x1874A4CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x74A4B20", Offset = "0x74A3720", VA = "0x1874A4B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x95F000", Offset = "0x95DC00", VA = "0x18095F000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x74A4B10", Offset = "0x74A3710", VA = "0x1874A4B10")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FKFFNAIOFAL ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x74A4510", Offset = "0x74A3110", VA = "0x1874A4510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NFFDFJFOFFK FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x74A4980", Offset = "0x74A3580", VA = "0x1874A4980")]
			get
			{
				return default(NFFDFJFOFFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74A4400", Offset = "0x74A3000", VA = "0x1874A4400")]
		internal void OEDMEEJLCCO(IEnumerable<GlyphCoordinateWritable> JCNJEBJAGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74A4480", Offset = "0x74A3080", VA = "0x1874A4480")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74A43E0", Offset = "0x74A2FE0", VA = "0x1874A43E0")]
		[CompilerGenerated]
		private bool FIGMEIDMHJD(GlyphCoordinateWritable NFEBCHCLBIA)
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
		private TextSegmentMeshBufferSource OAALICOGACH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private MEGNCIGFIBN NMCNLNCJNPL;

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
		private CCLMMDMADMG OOEEHHDDIBA;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74A8990", Offset = "0x74A7590", VA = "0x1874A8990")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74A8940", Offset = "0x74A7540", VA = "0x1874A8940")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74A8780", Offset = "0x74A7380", VA = "0x1874A8780")]
		private void EIJFKCOMBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74A8A80", Offset = "0x74A7680", VA = "0x1874A8A80")]
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
		private bool HMKANHABODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material AHEDILKLENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private MEGNCIGFIBN NMCNLNCJNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material LMIDDJOHIMJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private FKFFNAIOFAL LFOFGFLFJIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x74A9120", Offset = "0x74A7D20", VA = "0x1874A9120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MEGNCIGFIBN ONLFAGGEKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x74A9590", Offset = "0x74A8190", VA = "0x1874A9590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material FFPNJLBDIDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x74A95C0", Offset = "0x74A81C0", VA = "0x1874A95C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x74A94F0", Offset = "0x74A80F0", VA = "0x1874A94F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74A9300", Offset = "0x74A7F00", VA = "0x1874A9300", Slot = "8")]
		protected override void PEIHBFHAIJC(NLOFMOGCLHG JIECMGILDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74A9500", Offset = "0x74A8100", VA = "0x1874A9500", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] CJCGJBPDDKN JBPDOFGCNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74A91B0", Offset = "0x74A7DB0", VA = "0x1874A91B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74A8E00", Offset = "0x74A7A00", VA = "0x1874A8E00")]
		private void BDJKLGBPDFN(bool NBNIPGNLIMD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x975080", Offset = "0x973C80", VA = "0x180975080")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct KEPIIBANLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly MEGNCIGFIBN HBCGMCKCJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int MEDNAAKICPN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74A5E60", Offset = "0x74A4A60", VA = "0x1874A5E60")]
	internal GIGOBJIJMOD HLBCDPABHAN()
	{
		return default(GIGOBJIJMOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25280F0", Offset = "0x2526CF0", VA = "0x1825280F0")]
	internal KEPIIBANLCD(MEGNCIGFIBN JHBOJJACLJB, int NBMBBGEFCPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GGJDBDNJCNP
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74A4340", Offset = "0x74A2F40", VA = "0x1874A4340")]
	public static bool OKBFFLOCKHP(this KEPIIBANLCD PBMECKPMDAI, NPCPKEFMLCH JNCAENNNDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74A4390", Offset = "0x74A2F90", VA = "0x1874A4390")]
	internal static bool OKBFFLOCKHP(this GIGOBJIJMOD OHFCCBAGILL, NPCPKEFMLCH JNCAENNNDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74A4300", Offset = "0x74A2F00", VA = "0x1874A4300")]
	public static float AECFOABAIJB(this KEPIIBANLCD PBMECKPMDAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBE6C40", Offset = "0xBE5840", VA = "0x180BE6C40")]
	internal static float AECFOABAIJB(this GIGOBJIJMOD OHFCCBAGILL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HHAKMJHIIGP
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74A2060", Offset = "0x74A0C60", VA = "0x1874A2060")]
	public static void LLENPIEOEPO(this KEPIIBANLCD PBMECKPMDAI, ReadOnlySpan<char> PMBPDMCBFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74A4F60", Offset = "0x74A3B60", VA = "0x1874A4F60")]
	internal static void LLENPIEOEPO(this GIGOBJIJMOD OHFCCBAGILL, ReadOnlySpan<char> PMBPDMCBFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74A50B0", Offset = "0x74A3CB0", VA = "0x1874A50B0")]
	public static void PLLLIININFO(this KEPIIBANLCD BIOLMHIMEOH, float2 PLPIGDNDMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74A5100", Offset = "0x74A3D00", VA = "0x1874A5100")]
	internal static void PLLLIININFO(this GIGOBJIJMOD OHFCCBAGILL, float2 PLPIGDNDMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74A4EC0", Offset = "0x74A3AC0", VA = "0x1874A4EC0")]
	public static void HFNNDDNJBHI(this KEPIIBANLCD BIOLMHIMEOH, float ECMLLKFOIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74A4F00", Offset = "0x74A3B00", VA = "0x1874A4F00")]
	internal static void HFNNDDNJBHI(this GIGOBJIJMOD OHFCCBAGILL, float ECMLLKFOIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74A4DD0", Offset = "0x74A39D0", VA = "0x1874A4DD0")]
	internal static void EGGKACNJDCF(this GIGOBJIJMOD OHFCCBAGILL, bool PJDGKIDOHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74A4DF0", Offset = "0x74A39F0", VA = "0x1874A4DF0")]
	public static void EIDEKJGGHAJ(this KEPIIBANLCD BIOLMHIMEOH, Color32 PFOKHHCFPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74A4DE0", Offset = "0x74A39E0", VA = "0x1874A4DE0")]
	internal static void EIDEKJGGHAJ(this GIGOBJIJMOD OHFCCBAGILL, Color32 PFOKHHCFPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74A4F10", Offset = "0x74A3B10", VA = "0x1874A4F10")]
	public static void JGGNPLEAEDL(this KEPIIBANLCD BIOLMHIMEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74A4F50", Offset = "0x74A3B50", VA = "0x1874A4F50")]
	internal static void JGGNPLEAEDL(this GIGOBJIJMOD OHFCCBAGILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E30", Offset = "0x74A3A30", VA = "0x1874A4E30")]
	internal static void EIEDNIAIDGM(this GIGOBJIJMOD OHFCCBAGILL, int NHNKPGGEDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74A4EA0", Offset = "0x74A3AA0", VA = "0x1874A4EA0")]
	internal static void FBCMJPJAGFP(this GIGOBJIJMOD OHFCCBAGILL, int NNGFNCAEBFJ, NPCPKEFMLCH LMLAMLGBLFM = NPCPKEFMLCH.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CCLMMDMADMG : IEquatable<CCLMMDMADMG>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort LCMMNNFKJOI = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int BLJIGDENPOI = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly CCLMMDMADMG MLGBNKECKBA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort ODGBKBNCMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAD67B0", Offset = "0xAD53B0", VA = "0x180AD67B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAD67C0", Offset = "0xAD53C0", VA = "0x180AD67C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MEGNCIGFIBN HBCGMCKCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KBPDDCJKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74A13C0", Offset = "0x749FFC0", VA = "0x1874A13C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74A14D0", Offset = "0x74A00D0", VA = "0x1874A14D0")]
	public CCLMMDMADMG(int LLPPIJACNEL, MEGNCIGFIBN JHBOJJACLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x74A3F20", Offset = "0x74A2B20", VA = "0x1874A3F20")]
	public bool OCGOBNOFCBD([Out] KEPIIBANLCD PBMECKPMDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74A3E60", Offset = "0x74A2A60", VA = "0x1874A3E60")]
	public void GFEMBPJJFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74A1390", Offset = "0x749FF90", VA = "0x1874A1390")]
	internal void JMLKMFOMBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74A1270", Offset = "0x749FE70", VA = "0x1874A1270", Slot = "4")]
	public bool Equals(CCLMMDMADMG PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74A3DA0", Offset = "0x74A29A0", VA = "0x1874A3DA0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74A3EB0", Offset = "0x74A2AB0", VA = "0x1874A3EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MEGNCIGFIBN : IDisposable, DMLEJMKBAGP
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string NKHPBAEGKBO = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker FGCHNGOMBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string LMEKHBENJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly MNAKBDNPPCA PKJJMPLJKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int NHDNNHLMBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal GIGOBJIJMOD[] IPEBBELBOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal CCLMMDMADMG[] IPKIBNJEGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private FKFFNAIOFAL MEGAHHGEHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MDLPPBPEBMM MOOLMEBHOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly JIECHIOIBMF HJHANIPMILH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string BGKKCEGMOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74A6C20", Offset = "0x74A5820", VA = "0x1874A6C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FKFFNAIOFAL HLAGHIHHIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74A7A20", Offset = "0x74A6620", VA = "0x1874A7A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float PDIEMBAHBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74A6D60", Offset = "0x74A5960", VA = "0x1874A6D60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float MOPIONAAPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74A6E30", Offset = "0x74A5A30", VA = "0x1874A6E30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DMLEJMKBAGP.IEHKHAFHLKE BIDKLLBNAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x960120", VA = "0x180961520", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x961530", Offset = "0x960130", VA = "0x180961530", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74A7D60", Offset = "0x74A6960", VA = "0x1874A7D60")]
	public MEGNCIGFIBN(MNAKBDNPPCA BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74A81A0", Offset = "0x74A6DA0", VA = "0x1874A81A0")]
	public MEGNCIGFIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74A7630", Offset = "0x74A6230", VA = "0x1874A7630")]
	public void HGFFJCPBDPD(GlyphMapAsset FBEHMGFIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x74A7670", Offset = "0x74A6270", VA = "0x1874A7670")]
	public void HGFFJCPBDPD(FKFFNAIOFAL DLGPLGMIHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x74A7A90", Offset = "0x74A6690", VA = "0x1874A7A90", Slot = "6")]
	public bool TryGetMeshBuffer([Out] CJCGJBPDDKN JBPDOFGCNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74A79C0", Offset = "0x74A65C0", VA = "0x1874A79C0")]
	public void NBOKOMGFIOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74A7A40", Offset = "0x74A6640", VA = "0x1874A7A40")]
	public bool PKAGPNIILNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74A69F0", Offset = "0x74A55F0", VA = "0x1874A69F0")]
	public CCLMMDMADMG AAHOKGBBMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x74A7160", Offset = "0x74A5D60", VA = "0x1874A7160")]
	public void GOKEOACNNEA(CCLMMDMADMG IMIBINOOLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74A6CB0", Offset = "0x74A58B0", VA = "0x1874A6CB0")]
	internal bool DIHEEDGBAAC(CCLMMDMADMG IMIBINOOLGM, [Out] KEPIIBANLCD PBMECKPMDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74A74E0", Offset = "0x74A60E0", VA = "0x1874A74E0")]
	private void HFLGOLKMNNK(GIGOBJIJMOD OHFCCBAGILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74A77E0", Offset = "0x74A63E0", VA = "0x1874A77E0")]
	private void INBLNMAPLOK(int JDFBAHDBCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74A7780", Offset = "0x74A6380", VA = "0x1874A7780")]
	private bool HIBFNLMLMAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x749B8A0", Offset = "0x749A4A0", VA = "0x18749B8A0")]
	private static int CKFMOFFCFNF(CCLMMDMADMG IMIBINOOLGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0690", Offset = "0x1E9F290", VA = "0x181EA0690")]
	private static ushort KGCNFLKIKIL(int BIEEMEKMINN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x74A6E50", Offset = "0x74A5A50", VA = "0x1874A6E50")]
	private Bounds FHNIAGKBJPG()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74A6D80", Offset = "0x74A5980", VA = "0x1874A6D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MNAKBDNPPCA
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MNAKBDNPPCA ICMNLPKMEBP;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float EBKCKHOKHFM = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int PEEBLNIFEEM = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int IGCPILCMFBN = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color JFLMHDBLMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float KADBADGPIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int KIFIBJIKJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int MBDJEBABEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int PGBBNKHMCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int JEMHGOGKNEI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x74A8320", Offset = "0x74A6F20", VA = "0x1874A8320")]
	internal MNAKBDNPPCA KNOBFMJGMOI()
	{
		return default(MNAKBDNPPCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74A17D0", Offset = "0x74A03D0", VA = "0x1874A17D0")]
	[CompilerGenerated]
	internal static void JMJGEOGDGMF(int MPDLOLIOGJL, int NBKBMLNEBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74A82E0", Offset = "0x74A6EE0", VA = "0x1874A82E0")]
	[CompilerGenerated]
	internal static void APIOIOECANL(float MPDLOLIOGJL, float NBKBMLNEBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74A1720", Offset = "0x74A0320", VA = "0x1874A1720")]
	[CompilerGenerated]
	internal static void KMJFGLCLHCK(int MPDLOLIOGJL, int HCKBDPLKBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74A8300", Offset = "0x74A6F00", VA = "0x1874A8300")]
	[CompilerGenerated]
	internal static void FJEAKONGNCE(float MPDLOLIOGJL, float HCKBDPLKBAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PGIKJKFJKBC
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74A86F0", Offset = "0x74A72F0", VA = "0x1874A86F0")]
	public static float IKJBIENAMNF(this KEPIIBANLCD HCEKALJHAON)
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
		public readonly CCLMMDMADMG textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74A8D90", Offset = "0x74A7990", VA = "0x1874A8D90")]
		public TextSegmentLayout(LayoutRect layoutRect, CCLMMDMADMG textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x74A8B60", Offset = "0x74A7760", VA = "0x1874A8B60")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74A8BD0", Offset = "0x74A77D0", VA = "0x1874A8BD0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x74A8B00", Offset = "0x74A7700", VA = "0x1874A8B00")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class MDLPPBPEBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig IMDIJDIPPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float NCOHHNIGNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float CANGKIIGDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float FHOPJKJBBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float CLDNKNBFBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float KOENHMCAPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float KCLKIDKEJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float DEPBPOMDDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float IEOFFIKNGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float JOKMAEMOOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float MOPIONAAPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float KPNEOCAJFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float PDIEMBAHBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly DJBGEMKOCGC[] FEBJACJDGEK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int CMFFNFNGJMC = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private CNNGAKINPCJ[] LNNAOMGLJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int CDIJOLAKEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NFFDFJFOFFK[] EEFDOAMEMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int LBNOCKEPMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public DJBGEMKOCGC HCHFLIEIJEE;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74A6840", Offset = "0x74A5440", VA = "0x1874A6840")]
	public void HGFFJCPBDPD(FKFFNAIOFAL GBNJGAFOKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74A68D0", Offset = "0x74A54D0", VA = "0x1874A68D0")]
	public void HGFFJCPBDPD(GlyphUVConfig ANEEELMDGGK, IEnumerable<NFFDFJFOFFK> FBEHMGFIELH, NFFDFJFOFFK FNGIMOGDJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74A5EA0", Offset = "0x74A4AA0", VA = "0x1874A5EA0")]
	internal void APJEAIBDCHC(GlyphUVConfig ANEEELMDGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74A6310", Offset = "0x74A4F10", VA = "0x1874A6310")]
	private void GMGANJLENDH(IEnumerable<NFFDFJFOFFK> FBEHMGFIELH, NFFDFJFOFFK FNGIMOGDJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74A5FE0", Offset = "0x74A4BE0", VA = "0x1874A5FE0")]
	public void EIHIKMJLEPD([In] char FJADGLNCEPP, [Out] float2[] LPJBAKIJALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74A3CF0", Offset = "0x74A28F0", VA = "0x1874A3CF0")]
	private DJBGEMKOCGC MKPAHIAIALP(NFFDFJFOFFK LINCDKMOBDD)
	{
		return default(DJBGEMKOCGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74A6950", Offset = "0x74A5550", VA = "0x1874A6950")]
	public MDLPPBPEBMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OFBGPNNJHGM
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74A8560", Offset = "0x74A7160", VA = "0x1874A8560")]
	public static void CHMNMLCFFPE([In] float JHBLICGCEPK, [In] float JCCDFEHHIIL, [In] int NGBCAEHHBME, [In] int GDHPLKIPKIC, [In] float CLDNKNBFBCA, [In] float KOENHMCAPEM, [In] float ANECEEFLNMO, [In] float IFICLCBJLCI, [In] float ONEJJENDAJM, [In] float NFDABEAMJKM, [Out] float KKPKABKHMII, [Out] float NPKDKILPNEO, [Out] float KGAMJKKNNNP, [Out] float HMFCNBMOEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74A8630", Offset = "0x74A7230", VA = "0x1874A8630")]
	public static void CHMNMLCFFPE([In] float JHBLICGCEPK, [In] float JCCDFEHHIIL, [In] int NGBCAEHHBME, [In] int GDHPLKIPKIC, [Out] float KKPKABKHMII, [Out] float NPKDKILPNEO, [Out] float KGAMJKKNNNP, [Out] float HMFCNBMOEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x74A8690", Offset = "0x74A7290", VA = "0x1874A8690")]
	public static void JFAFLCKPCEC([In] float CLDNKNBFBCA, [In] float KOENHMCAPEM, [In] float DEIIEPEKJGO, [In] float OFKOCGGBFBN, [In] float PHCNGNHHPGE, [In] float GDLKGPFFKFD, [Out] float NPGOABCFOLP, [Out] float GCPPMPHLPNH, [Out] float EAOENBOOIGJ, [Out] float CLMEANAMPML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct CNNGAKINPCJ
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint IODFPNCAFEE = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char EILKCIDFIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly DJBGEMKOCGC FIPDJEPDJPL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74A4080", Offset = "0x74A2C80", VA = "0x1874A4080")]
	public CNNGAKINPCJ(char FJADGLNCEPP, DJBGEMKOCGC LPJBAKIJALD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DJBGEMKOCGC
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint IODFPNCAFEE = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] MEADJLEFPOI;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74A40A0", Offset = "0x74A2CA0", VA = "0x1874A40A0")]
	public DJBGEMKOCGC(float KKPKABKHMII, float NPKDKILPNEO, float KGAMJKKNNNP, float HMFCNBMOEGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct GIGOBJIJMOD
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int IFANDNGGCLP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal NPCPKEFMLCH LMLAMLGBLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] KJACMCJLJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int JINKCIFGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 PLPIGDNDMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float OPMNLEKMGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 EMAFKBEDFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool PJDGKIDOHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int NHLDOBPJIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int ILGGFBINHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int MPACCIHGGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int LBFMEOPBDGK;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74A43B0", Offset = "0x74A2FB0", VA = "0x1874A43B0")]
	public static int MGMPDJDEEMN(int MIPMDEBPJJF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum NPCPKEFMLCH : byte
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
public static class MJMKOMBFFCB
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74A8220", Offset = "0x74A6E20", VA = "0x1874A8220")]
	internal static float IKJBIENAMNF(this GIGOBJIJMOD OHFCCBAGILL, float PGOMPAFCMJP, float PFKMAIKEHFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74A8260", Offset = "0x74A6E60", VA = "0x1874A8260")]
	internal static void LPOEBFFDHPN(this GIGOBJIJMOD OHFCCBAGILL, float PGOMPAFCMJP, float PFKMAIKEHFL, [Out] float2 DMOKGKPBDAL, [Out] float2 IBGGHDAOBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class JIECHIOIBMF : DMLEJMKBAGP
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int FMFHEJKPILF = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int FOACLKKMNAB = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string NKHPBAEGKBO = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static NGDNLODCCFH JKIGCEHABAN;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static NGDNLODCCFH BDEPEJNMFJN;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static NGDNLODCCFH CDBJBJDNOJH;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static NGDNLODCCFH EMIAILMBFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly CJCGJBPDDKN JBPDOFGCNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] DCDAKJLDLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] OAADFOFKGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int AIBKHFLHGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int LAKLBLKMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int NCNHNCGJDIF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string BGKKCEGMOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DMLEJMKBAGP.IEHKHAFHLKE BIDKLLBNAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74A5D50", Offset = "0x74A4950", VA = "0x1874A5D50")]
	public JIECHIOIBMF(CJCGJBPDDKN.EJKEDDMOGAB OEHGGPOMMNB, int DILIEDIFFPN, int CDAOLIHEDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74A5BD0", Offset = "0x74A47D0", VA = "0x1874A5BD0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] CJCGJBPDDKN JBPDOFGCNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x74A5BB0", Offset = "0x74A47B0", VA = "0x1874A5BB0")]
	public void PPAJALHFPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74A5430", Offset = "0x74A4030", VA = "0x1874A5430")]
	public void KMBMIEFDBCP(Span<GIGOBJIJMOD> NAJAFCPCHFA, MDLPPBPEBMM BBIECNJJIOD, [In] MNAKBDNPPCA BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x74A23D0", Offset = "0x74A0FD0", VA = "0x1874A23D0")]
	private void IOONIPHBBBB([In] NPCPKEFMLCH LMLAMLGBLFM, [In] GIGOBJIJMOD HKIJGGNAEGO, int BDEIDEPNPDI, [In] float PGOMPAFCMJP, [In] float PFKMAIKEHFL, MDLPPBPEBMM BBIECNJJIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74A5110", Offset = "0x74A3D10", VA = "0x1874A5110")]
	private void DILOLBFIMKN([In] NPCPKEFMLCH LMLAMLGBLFM, GIGOBJIJMOD HKIJGGNAEGO, [In] int PPOEJHIMHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74A5260", Offset = "0x74A3E60", VA = "0x1874A5260")]
	public static void EMBDHBMOGGI(ReadOnlySpan<GIGOBJIJMOD> NAJAFCPCHFA, int JPJKLIPMBLC, [Out] int PFKHLLDNJCO, [Out] int EPLIBPEKFPP, [Out] int GIHEAKGAKJM)
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
