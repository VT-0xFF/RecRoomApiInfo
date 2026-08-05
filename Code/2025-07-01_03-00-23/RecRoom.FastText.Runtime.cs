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
public class JEIKIEKHCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D KNPGDKLGDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig MHKNHHPKEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public OGPKJJAMFBM[] LCKKBKOPHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public OGPKJJAMFBM IGFGBFEDLHI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static JEIKIEKHCOH OGIOHEAOJBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JEIKIEKHCOH OEIKCGKKMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0800", Offset = "0x7F9EE00", VA = "0x187FA0800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JEIKIEKHCOH()
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
		[Cpp2IlInjected.Address(RVA = "0x7F9EF80", Offset = "0x7F9D580", VA = "0x187F9EF80")]
		public GlyphUVConfig(int GNKELOICEDJ, int OGIMBIOBEPE, int KPHGOAPNNLL, int IHCKJNHFMGI, float PGKHPJADLLG = 0f, [Optional] GlyphPixelInset LKMIKHGMLKN)
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
public readonly struct OGPKJJAMFBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char BFNEDEKFAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int LAPHFFDAEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int DKPEOEMMAEI;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly OGPKJJAMFBM LNMEKFMMHIC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1C40", Offset = "0x7FA0240", VA = "0x187FA1C40")]
	public OGPKJJAMFBM(char EPCDAEEAJOE, int MJBNJPBAGKJ, int NMCJGAEADLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1C20", Offset = "0x7FA0220", VA = "0x187FA1C20")]
	public OGPKJJAMFBM(GlyphCoordinateWritable BKKJKGFAFAE)
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
		[Cpp2IlInjected.Address(RVA = "0x7F9E590", Offset = "0x7F9CB90", VA = "0x187F9E590")]
		public static OGPKJJAMFBM EIMKEBEILPD(GlyphCoordinateWritable HJGAGGHDFHM)
		{
			return default(OGPKJJAMFBM);
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
		private JEIKIEKHCOH configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7F9EE80", Offset = "0x7F9D480", VA = "0x187F9EE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F9ED00", Offset = "0x7F9D300", VA = "0x187F9ED00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7F9ECF0", Offset = "0x7F9D2F0", VA = "0x187F9ECF0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JEIKIEKHCOH ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F9E6E0", Offset = "0x7F9CCE0", VA = "0x187F9E6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OGPKJJAMFBM FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F9EB60", Offset = "0x7F9D160", VA = "0x187F9EB60")]
			get
			{
				return default(OGPKJJAMFBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E5B0", Offset = "0x7F9CBB0", VA = "0x187F9E5B0")]
		internal void BDBFLIEGFKK(IEnumerable<GlyphCoordinateWritable> GPDOFFMGJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E650", Offset = "0x7F9CC50", VA = "0x187F9E650")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E630", Offset = "0x7F9CC30", VA = "0x187F9E630")]
		[CompilerGenerated]
		private bool FGOOMGFNOJP(GlyphCoordinateWritable HJGAGGHDFHM)
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
		private TextSegmentMeshBufferSource HPDOMNLGMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private HLDLLFCIJLO JGFOAOCPDPF;

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
		private NBMGDIDLKFG BMGOFIANLIM;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2C80", Offset = "0x7FA1280", VA = "0x187FA2C80")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2C30", Offset = "0x7FA1230", VA = "0x187FA2C30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2A50", Offset = "0x7FA1050", VA = "0x187FA2A50")]
		private void ANJPOGKGHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2D70", Offset = "0x7FA1370", VA = "0x187FA2D70")]
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
		private bool CDBDAHCNOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material GMBKFDDIHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private HLDLLFCIJLO JGFOAOCPDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material GHHLPBMHFJG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private JEIKIEKHCOH KCHDHDOIBKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7FA32D0", Offset = "0x7FA18D0", VA = "0x187FA32D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HLDLLFCIJLO IMIOEOMCOJN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA3870", Offset = "0x7FA1E70", VA = "0x187FA3870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material CLDGJFBPAIM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA38A0", Offset = "0x7FA1EA0", VA = "0x187FA38A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA37D0", Offset = "0x7FA1DD0", VA = "0x187FA37D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA30F0", Offset = "0x7FA16F0", VA = "0x187FA30F0", Slot = "8")]
		protected override void MABJJLBPFNH(JMAIHGAAKBA OKDBLNAJAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA37E0", Offset = "0x7FA1DE0", VA = "0x187FA37E0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] CAMDHFPPJIE OJMEGFOPGJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3360", Offset = "0x7FA1960", VA = "0x187FA3360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7FA34B0", Offset = "0x7FA1AB0", VA = "0x187FA34B0")]
		private void PKIBEPCMFLA(bool KKBNDFNEENM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA61FB0", Offset = "0xA605B0", VA = "0x180A61FB0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct MPJLMLECBLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly HLDLLFCIJLO LOCBBCHKLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int KJHICJEKPKB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FA16B0", Offset = "0x7F9FCB0", VA = "0x187FA16B0")]
	internal AHGOEHHPAAB EAILPDHMEJD()
	{
		return default(AHGOEHHPAAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x296EC20", Offset = "0x296D220", VA = "0x18296EC20")]
	internal MPJLMLECBLO(HLDLLFCIJLO MIPDPIDNIBN, int IHPIBPMAGBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GKJDJIDLPPE
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E520", Offset = "0x7F9CB20", VA = "0x187F9E520")]
	public static bool NEPNKCKJELH(this MPJLMLECBLO OPOKDPDIKFK, MJMPONAKBGH CMNHEPMJODO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E570", Offset = "0x7F9CB70", VA = "0x187F9E570")]
	internal static bool NEPNKCKJELH(this AHGOEHHPAAB JNAHDCAHCNM, MJMPONAKBGH CMNHEPMJODO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E4E0", Offset = "0x7F9CAE0", VA = "0x187F9E4E0")]
	public static float JBBNGFAFOND(this MPJLMLECBLO OPOKDPDIKFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAA7C90", Offset = "0xAA6290", VA = "0x180AA7C90")]
	internal static float JBBNGFAFOND(this AHGOEHHPAAB JNAHDCAHCNM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FNNBJKDEKCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E040", Offset = "0x7F9C640", VA = "0x187F9E040")]
	public static void CALNKHKHBPO(this MPJLMLECBLO OPOKDPDIKFK, ReadOnlySpan<char> FCNMPDIGICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E090", Offset = "0x7F9C690", VA = "0x187F9E090")]
	internal static void CALNKHKHBPO(this AHGOEHHPAAB JNAHDCAHCNM, ReadOnlySpan<char> FCNMPDIGICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E480", Offset = "0x7F9CA80", VA = "0x187F9E480")]
	public static void NFBBOOMCBKH(this MPJLMLECBLO ALFIPAOACNC, float2 GFPIHKFDMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E4D0", Offset = "0x7F9CAD0", VA = "0x187F9E4D0")]
	internal static void NFBBOOMCBKH(this AHGOEHHPAAB JNAHDCAHCNM, float2 GFPIHKFDMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E2D0", Offset = "0x7F9C8D0", VA = "0x187F9E2D0")]
	public static void DDHBKHHAGPG(this MPJLMLECBLO ALFIPAOACNC, float MMHLECICBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E290", Offset = "0x7F9C890", VA = "0x187F9E290")]
	internal static void DDHBKHHAGPG(this AHGOEHHPAAB JNAHDCAHCNM, float MMHLECICBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E3D0", Offset = "0x7F9C9D0", VA = "0x187F9E3D0")]
	internal static void HFLOAFBDGKD(this AHGOEHHPAAB JNAHDCAHCNM, bool ANOKJLFPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E440", Offset = "0x7F9CA40", VA = "0x187F9E440")]
	public static void IMFGGCLPHDH(this MPJLMLECBLO ALFIPAOACNC, Color32 HFIMNHFKOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E430", Offset = "0x7F9CA30", VA = "0x187F9E430")]
	internal static void IMFGGCLPHDH(this AHGOEHHPAAB JNAHDCAHCNM, Color32 HFIMNHFKOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E3E0", Offset = "0x7F9C9E0", VA = "0x187F9E3E0")]
	public static void HMLCAFNGBLK(this MPJLMLECBLO ALFIPAOACNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E420", Offset = "0x7F9CA20", VA = "0x187F9E420")]
	internal static void HMLCAFNGBLK(this AHGOEHHPAAB JNAHDCAHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E340", Offset = "0x7F9C940", VA = "0x187F9E340")]
	internal static void DFPGKMFCIMF(this AHGOEHHPAAB JNAHDCAHCNM, int MLKGMONFHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E3B0", Offset = "0x7F9C9B0", VA = "0x187F9E3B0")]
	internal static void ELKABJDHEDJ(this AHGOEHHPAAB JNAHDCAHCNM, int MAEFOPEAENN, MJMPONAKBGH LKKJKCHDABJ = MJMPONAKBGH.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NBMGDIDLKFG : IEquatable<NBMGDIDLKFG>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort BJGICPNHGKF = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int JKEBJDHLCPC = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly NBMGDIDLKFG GEKMDKHOOEK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort JHOEDKCDEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xCEB760", Offset = "0xCE9D60", VA = "0x180CEB760")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCEB770", Offset = "0xCE9D70", VA = "0x180CEB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HLDLLFCIJLO LOCBBCHKLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LAPKEHOOABF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F97E90", Offset = "0x7F96490", VA = "0x187F97E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F98180", Offset = "0x7F96780", VA = "0x187F98180")]
	public NBMGDIDLKFG(int JGHLFPJMDBL, HLDLLFCIJLO MIPDPIDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1870", Offset = "0x7F9FE70", VA = "0x187FA1870")]
	public bool OMMKEPHKAIP([Out] MPJLMLECBLO OPOKDPDIKFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1820", Offset = "0x7F9FE20", VA = "0x187FA1820")]
	public void MFOHPABGFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F97E60", Offset = "0x7F96460", VA = "0x187F97E60")]
	internal void BGDINOJHLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F97F60", Offset = "0x7F96560", VA = "0x187F97F60", Slot = "4")]
	public bool Equals(NBMGDIDLKFG HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FA16F0", Offset = "0x7F9FCF0", VA = "0x187FA16F0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FA17B0", Offset = "0x7F9FDB0", VA = "0x187FA17B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HLDLLFCIJLO : IDisposable, FFNJEDMMIBG
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string OJGDILGBCOK = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker NJJHAFEGOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string KGIPJNIHCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly OABNKLOMCDP HIHDKLNGDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int IMAAIJBMHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal AHGOEHHPAAB[] JFJBGPGEPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal NBMGDIDLKFG[] BFFOBDLLFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private JEIKIEKHCOH OIFPJBCOKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MHFDAKPLADH KIDPEFFFGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly OPGKPCFBFID OAJAJGNHPIJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string IEDAJGLJHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F9FC50", Offset = "0x7F9E250", VA = "0x187F9FC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JEIKIEKHCOH EEHPDLNAIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F440", Offset = "0x7F9DA40", VA = "0x187F9F440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float EGIMMNLOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F310", Offset = "0x7F9D910", VA = "0x187F9F310")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float FOIBHEKHPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F460", Offset = "0x7F9DA60", VA = "0x187F9F460")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FFNJEDMMIBG.AJLDDGKHNMH GPALABDPMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA42F80", VA = "0x180A44980", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0340", Offset = "0x7F9E940", VA = "0x187FA0340")]
	public HLDLLFCIJLO(OABNKLOMCDP HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0780", Offset = "0x7F9ED80", VA = "0x187FA0780")]
	public HLDLLFCIJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FF50", Offset = "0x7F9E550", VA = "0x187F9FF50")]
	public void PNLBMDNIIGG(GlyphMapAsset DGJPKBCHLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FF90", Offset = "0x7F9E590", VA = "0x187F9FF90")]
	public void PNLBMDNIIGG(JEIKIEKHCOH KOIEDKJJCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA00A0", Offset = "0x7F9E6A0", VA = "0x187FA00A0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] CAMDHFPPJIE OJMEGFOPGJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F3E0", Offset = "0x7F9D9E0", VA = "0x187F9F3E0")]
	public void GEJCECMPHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EFB0", Offset = "0x7F9D5B0", VA = "0x187F9EFB0")]
	public bool BHFPPCLLIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FCE0", Offset = "0x7F9E2E0", VA = "0x187F9FCE0")]
	public NBMGDIDLKFG OIAFGOBJBCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F660", Offset = "0x7F9DC60", VA = "0x187F9F660")]
	public void HGPKJIFCHAE(NBMGDIDLKFG OPDPKEJIJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FBA0", Offset = "0x7F9E1A0", VA = "0x187F9FBA0")]
	internal bool LOOJABPBCCJ(NBMGDIDLKFG OPDPKEJIJLE, [Out] MPJLMLECBLO OPOKDPDIKFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F4E0", Offset = "0x7F9DAE0", VA = "0x187F9F4E0")]
	private void HBIOAGOOFOP(AHGOEHHPAAB JNAHDCAHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F9C0", Offset = "0x7F9DFC0", VA = "0x187F9F9C0")]
	private void HPBKDIKIAFB(int NOENOMJFEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F480", Offset = "0x7F9DA80", VA = "0x187F9F480")]
	private bool GOCGCKKJDFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B6B0", Offset = "0x7F99CB0", VA = "0x187F9B6B0")]
	private static int ICPAGDFLHOM(NBMGDIDLKFG OPDPKEJIJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x22A99C0", Offset = "0x22A7FC0", VA = "0x1822A99C0")]
	private static ushort NOKEIGAEEMG(int KHMHPNKMLMD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F000", Offset = "0x7F9D600", VA = "0x187F9F000")]
	private Bounds CONEMFHEJJB()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F330", Offset = "0x7F9D930", VA = "0x187F9F330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OABNKLOMCDP
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly OABNKLOMCDP PLJICOCADOA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float HAAHOHKLGHD = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int CDHDEKLCLHI = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HCGGHPCNDOF = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color PGBCEKNIPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float LKDCKOFPPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int ILEEOFJEONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int PKOHDDBCMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int IAFJEGBEGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int COMCPMNCLFJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA19D0", Offset = "0x7F9FFD0", VA = "0x187FA19D0")]
	internal OABNKLOMCDP DJKBDHNHNNG()
	{
		return default(OABNKLOMCDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F97DA0", Offset = "0x7F963A0", VA = "0x187F97DA0")]
	[CompilerGenerated]
	internal static void NKKAHLACAFB(int KKGBKLFKCPO, int COMAGLLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1B00", Offset = "0x7FA0100", VA = "0x187FA1B00")]
	[CompilerGenerated]
	internal static void HNIMAOACBFA(float KKGBKLFKCPO, float COMAGLLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F97CF0", Offset = "0x7F962F0", VA = "0x187F97CF0")]
	[CompilerGenerated]
	internal static void EFGDGMCFNNK(int KKGBKLFKCPO, int NODDFODMAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1AE0", Offset = "0x7FA00E0", VA = "0x187FA1AE0")]
	[CompilerGenerated]
	internal static void HLGHKKIBHDE(float KKGBKLFKCPO, float NODDFODMAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ACPAJJHMDHO
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DE10", Offset = "0x7F9C410", VA = "0x187F9DE10")]
	public static float DCIHGKACAJA(this MPJLMLECBLO OCEDCONPNNN)
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
		public readonly NBMGDIDLKFG textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3080", Offset = "0x7FA1680", VA = "0x187FA3080")]
		public TextSegmentLayout(LayoutRect layoutRect, NBMGDIDLKFG textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2E50", Offset = "0x7FA1450", VA = "0x187FA2E50")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2EC0", Offset = "0x7FA14C0", VA = "0x187FA2EC0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2DF0", Offset = "0x7FA13F0", VA = "0x187FA2DF0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class MHFDAKPLADH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig COFGPOJHKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float KJPIHBKNMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float HBBPBGEPFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float GHKNFFCHFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float BDNEIDBKDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float EBBAFCNFEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float IACJOEEJKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float ICKNLDAGAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float CMPKNIPMHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float KKKOFMPKOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float FOIBHEKHPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float NIALLLMAKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float EGIMMNLOKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly JJPECJLNEAA[] BHHCCKOFGOE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int KKFKEMLBCLP = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private JPCMPKBMLGN[] NCHKHFOGFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int IDMJKJKAMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private OGPKJJAMFBM[] FHFOHKEEEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int OBHBDPKEMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public JJPECJLNEAA BEOBAELMBGO;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1500", Offset = "0x7F9FB00", VA = "0x187FA1500")]
	public void PNLBMDNIIGG(JEIKIEKHCOH MPOEFBFPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1590", Offset = "0x7F9FB90", VA = "0x187FA1590")]
	public void PNLBMDNIIGG(GlyphUVConfig KHHNEKMAHCJ, IEnumerable<OGPKJJAMFBM> DGJPKBCHLIA, OGPKJJAMFBM CGDCMEAOIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FA13C0", Offset = "0x7F9F9C0", VA = "0x187FA13C0")]
	internal void NIAJPCADAKN(GlyphUVConfig KHHNEKMAHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0B50", Offset = "0x7F9F150", VA = "0x187FA0B50")]
	private void APHDAIIANLL(IEnumerable<OGPKJJAMFBM> DGJPKBCHLIA, OGPKJJAMFBM CGDCMEAOIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1090", Offset = "0x7F9F690", VA = "0x187FA1090")]
	public void JGHIBMOLFMN([In] char EPCDAEEAJOE, [Out] float2[] KBAIMLEGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C1D0", Offset = "0x7F9A7D0", VA = "0x187F9C1D0")]
	private JJPECJLNEAA HPNCIGIDDDA(OGPKJJAMFBM BKKJKGFAFAE)
	{
		return default(JJPECJLNEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1610", Offset = "0x7F9FC10", VA = "0x187FA1610")]
	public MHFDAKPLADH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EPBFBMIHHNP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DF10", Offset = "0x7F9C510", VA = "0x187F9DF10")]
	public static void BKELCICCMJP([In] float ABODBAOBACK, [In] float OMBOMEKGKNL, [In] int AHGMLMCHGBA, [In] int HDNDAAHPNFI, [In] float BDNEIDBKDDB, [In] float EBBAFCNFEDJ, [In] float DDMPMGGNJIE, [In] float OAAOCCOPBKE, [In] float MHDFEMINHEG, [In] float KAPMEJCAEIC, [Out] float FBFPEIKHGPC, [Out] float NCELEIELKOP, [Out] float MHIHFMMHKGL, [Out] float EIFCNKADIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DEB0", Offset = "0x7F9C4B0", VA = "0x187F9DEB0")]
	public static void BKELCICCMJP([In] float ABODBAOBACK, [In] float OMBOMEKGKNL, [In] int AHGMLMCHGBA, [In] int HDNDAAHPNFI, [Out] float FBFPEIKHGPC, [Out] float NCELEIELKOP, [Out] float MHIHFMMHKGL, [Out] float EIFCNKADIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DFE0", Offset = "0x7F9C5E0", VA = "0x187F9DFE0")]
	public static void JDMNBONEMFM([In] float BDNEIDBKDDB, [In] float EBBAFCNFEDJ, [In] float CNNDGLKIKHI, [In] float DOBAOJBNIGA, [In] float CJKBEDFBPJJ, [In] float OJFGGKOHKLD, [Out] float GLHJJGBAMAE, [Out] float EGAPMFBBCFC, [Out] float BGOKBBMEMNJ, [Out] float CFNGFDAGGHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct JPCMPKBMLGN
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint KCIDDCCNEBI = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char BFNEDEKFAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly JJPECJLNEAA FAMMMGPHBKI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0A70", Offset = "0x7F9F070", VA = "0x187FA0A70")]
	public JPCMPKBMLGN(char EPCDAEEAJOE, JJPECJLNEAA KBAIMLEGJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct JJPECJLNEAA
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint KCIDDCCNEBI = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] CAMKOJIMJJL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0980", Offset = "0x7F9EF80", VA = "0x187FA0980")]
	public JJPECJLNEAA(float FBFPEIKHGPC, float NCELEIELKOP, float MHIHFMMHKGL, float EIFCNKADIBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct AHGOEHHPAAB
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int CPOBGFPIBAE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal MJMPONAKBGH LKKJKCHDABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] OCMLGKIFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int EDBJNNDNPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 GFPIHKFDMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float MKDKKKJHBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 MCBGJDFMHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool ANOKJLFPHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int PIKJGPMCGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int NAPEOBKBGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int OIGBIHEELEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int GJBGHJJIBDL;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DEA0", Offset = "0x7F9C4A0", VA = "0x187F9DEA0")]
	public static int HDPFOOMILPJ(int MDBONPOOBHK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum MJMPONAKBGH : byte
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
public static class MDAOCDIIIAE
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0B10", Offset = "0x7F9F110", VA = "0x187FA0B10")]
	internal static float DCIHGKACAJA(this AHGOEHHPAAB JNAHDCAHCNM, float KMBAHPLNAJP, float GLFOLKNBCCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0A90", Offset = "0x7F9F090", VA = "0x187FA0A90")]
	internal static void AJPKPPFIAKP(this AHGOEHHPAAB JNAHDCAHCNM, float KMBAHPLNAJP, float GLFOLKNBCCF, [Out] float2 LPAMMAPPJAO, [Out] float2 CMGDLKAFPEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class OPGKPCFBFID : FFNJEDMMIBG
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int OCLFEKHJPGB = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int GGFFKPMHGBO = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string OJGDILGBCOK = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker IIAIHKJKEDD;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker FHPPKHGMDCB;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker AGGFLNNDDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker FMOCNHGFFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly CAMDHFPPJIE OJMEGFOPGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] GAMLMAGPMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] NCGLKMNGMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int EDNDIGMABNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int IAIELOEOBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int DFONPJICOID;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string IEDAJGLJHNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FFNJEDMMIBG.AJLDDGKHNMH GPALABDPMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2940", Offset = "0x7FA0F40", VA = "0x187FA2940")]
	public OPGKPCFBFID(CAMDHFPPJIE.HOJKFBPOAFL ELEFMBGHFPO, int CBECOOIMODG, int EFLBMPDNIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA27B0", Offset = "0x7FA0DB0", VA = "0x187FA27B0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] CAMDHFPPJIE OJMEGFOPGJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1E60", Offset = "0x7FA0460", VA = "0x187FA1E60")]
	public void DKLMAIGGKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1FD0", Offset = "0x7FA05D0", VA = "0x187FA1FD0")]
	public void POGDNHJACBN(Span<AHGOEHHPAAB> JDELPFGBKBC, MHFDAKPLADH KLIOFNEDNGG, [In] OABNKLOMCDP HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C7C0", Offset = "0x7F9ADC0", VA = "0x187F9C7C0")]
	private void NHEGIDMCBCF([In] MJMPONAKBGH LKKJKCHDABJ, [In] AHGOEHHPAAB ECAIDNACFON, int AFPOLMFJOFB, [In] float KMBAHPLNAJP, [In] float GLFOLKNBCCF, MHFDAKPLADH KLIOFNEDNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1E80", Offset = "0x7FA0480", VA = "0x187FA1E80")]
	private void NLKPPLIMHPB([In] MJMPONAKBGH LKKJKCHDABJ, AHGOEHHPAAB ECAIDNACFON, [In] int OEJFDHPPOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1C50", Offset = "0x7FA0250", VA = "0x187FA1C50")]
	public static void BGDFCNDDHOD(ReadOnlySpan<AHGOEHHPAAB> JDELPFGBKBC, int FPBKODLDFLG, [Out] int BLFDDHDFPPF, [Out] int MEILBLENDNF, [Out] int JDEJMGBMCJA)
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
