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
public class ICNLFAMPLNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D JDJOGPMIIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig KGAIFMBDPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public IKCMJMCGACO[] BIFJCFMDLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IKCMJMCGACO DBJKJOOEKIA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static ICNLFAMPLNM CHCMJGNMAPH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ICNLFAMPLNM IMPKJMCAPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D96090", Offset = "0x7D94E90", VA = "0x187D96090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public ICNLFAMPLNM()
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
		[Cpp2IlInjected.Address(RVA = "0x7D95440", Offset = "0x7D94240", VA = "0x187D95440")]
		public GlyphUVConfig(int NGADFEFJFML, int OCKKAEKBKLI, int MCHPKGBMMKE, int NBCPDPPINCN, float IGIHHGBMNLK = 0f, [Optional] GlyphPixelInset ABJAJHCHNAK)
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
public readonly struct IKCMJMCGACO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char BNLAELOFBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int ONCFMCPBPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int NMDBFKJOFEO;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly IKCMJMCGACO BIGLKPPENOH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D96270", Offset = "0x7D95070", VA = "0x187D96270")]
	public IKCMJMCGACO(char MAOKJHAGONN, int COMMJEINOLF, int CFPCJPBIOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D96280", Offset = "0x7D95080", VA = "0x187D96280")]
	public IKCMJMCGACO(GlyphCoordinateWritable IHCEFJBPCFM)
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
		[Cpp2IlInjected.Address(RVA = "0x7D94A50", Offset = "0x7D93850", VA = "0x187D94A50")]
		public static IKCMJMCGACO HEKJAOMNHLJ(GlyphCoordinateWritable KMBJNMDOLGN)
		{
			return default(IKCMJMCGACO);
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
		private ICNLFAMPLNM configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7D95340", Offset = "0x7D94140", VA = "0x187D95340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7D951C0", Offset = "0x7D93FC0", VA = "0x187D951C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7D951B0", Offset = "0x7D93FB0", VA = "0x187D951B0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ICNLFAMPLNM ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7D94BA0", Offset = "0x7D939A0", VA = "0x187D94BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private IKCMJMCGACO FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7D95020", Offset = "0x7D93E20", VA = "0x187D95020")]
			get
			{
				return default(IKCMJMCGACO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D94A70", Offset = "0x7D93870", VA = "0x187D94A70")]
		internal void DFKDNCHJMED(IEnumerable<GlyphCoordinateWritable> EMBDOFNGHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D94B10", Offset = "0x7D93910", VA = "0x187D94B10")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D94AF0", Offset = "0x7D938F0", VA = "0x187D94AF0")]
		[CompilerGenerated]
		private bool KJOJHFJOAJG(GlyphCoordinateWritable KMBJNMDOLGN)
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
		private TextSegmentMeshBufferSource BJMMHKMOKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private EIIEIMHICKH IFMMALDPJLN;

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
		private DKMGNAAIIEI FEMLAKCKFGJ;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D96B30", Offset = "0x7D95930", VA = "0x187D96B30")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D96AE0", Offset = "0x7D958E0", VA = "0x187D96AE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D96900", Offset = "0x7D95700", VA = "0x187D96900")]
		private void CKKMHEMOGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D96C20", Offset = "0x7D95A20", VA = "0x187D96C20")]
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
		private bool EEBBKGBCMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material LLBIBBJCIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private EIIEIMHICKH IFMMALDPJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material FFKBCCGFLPO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private ICNLFAMPLNM NLJAOPBLLKC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7D96FA0", Offset = "0x7D95DA0", VA = "0x187D96FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EIIEIMHICKH ICMJOMHBMHO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7D97730", Offset = "0x7D96530", VA = "0x187D97730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material DJILFKNJGDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7D97760", Offset = "0x7D96560", VA = "0x187D97760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7D97690", Offset = "0x7D96490", VA = "0x187D97690")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7D97180", Offset = "0x7D95F80", VA = "0x187D97180", Slot = "8")]
		protected override void PKCOBBOMKNJ(FECKHDAAOAM PIJGINHOMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7D976A0", Offset = "0x7D964A0", VA = "0x187D976A0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] FMBMJGEAPMN OPBMIIBIDAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D97030", Offset = "0x7D95E30", VA = "0x187D97030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D97370", Offset = "0x7D96170", VA = "0x187D97370")]
		private void PODFGGIAJOB(bool PGBCKJJIOAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA260F0", Offset = "0xA24EF0", VA = "0x180A260F0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct EMPALAADFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly EIIEIMHICKH CNHNLBCFBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int LNAIAGKAFNF;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D94680", Offset = "0x7D93480", VA = "0x187D94680")]
	internal IIEOKOOAPGE NJBNBNJENJI()
	{
		return default(IIEOKOOAPGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2811560", Offset = "0x2810360", VA = "0x182811560")]
	internal EMPALAADFLM(EIIEIMHICKH HBNPNMJNNHB, int KIHJKEKPJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KKLDMPFPJIM
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D96780", Offset = "0x7D95580", VA = "0x187D96780")]
	public static bool GOODICEHJPL(this EMPALAADFLM JLICNKNOLBG, HAFAPFMCMLF IHCCHGEBEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D96760", Offset = "0x7D95560", VA = "0x187D96760")]
	internal static bool GOODICEHJPL(this IIEOKOOAPGE JHPPOBLCJBP, HAFAPFMCMLF IHCCHGEBEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D967D0", Offset = "0x7D955D0", VA = "0x187D967D0")]
	public static float KGJMFLFBECN(this EMPALAADFLM JLICNKNOLBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD6DF10", Offset = "0xD6CD10", VA = "0x180D6DF10")]
	internal static float KGJMFLFBECN(this IIEOKOOAPGE JHPPOBLCJBP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class INOHGPHOAIP
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D96320", Offset = "0x7D95120", VA = "0x187D96320")]
	public static void FELIKBBPEGJ(this EMPALAADFLM JLICNKNOLBG, ReadOnlySpan<char> IGHPBEOANAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D96370", Offset = "0x7D95170", VA = "0x187D96370")]
	internal static void FELIKBBPEGJ(this IIEOKOOAPGE JHPPOBLCJBP, ReadOnlySpan<char> IGHPBEOANAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D962D0", Offset = "0x7D950D0", VA = "0x187D962D0")]
	public static void DOFAGIKMACC(this EMPALAADFLM LLPBIKCKKOM, float2 MGNFNFFHENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D962C0", Offset = "0x7D950C0", VA = "0x187D962C0")]
	internal static void DOFAGIKMACC(this IIEOKOOAPGE JHPPOBLCJBP, float2 MGNFNFFHENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D966C0", Offset = "0x7D954C0", VA = "0x187D966C0")]
	public static void MLAGGLHMNBF(this EMPALAADFLM LLPBIKCKKOM, float PIELHHOLGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D96680", Offset = "0x7D95480", VA = "0x187D96680")]
	internal static void MLAGGLHMNBF(this IIEOKOOAPGE JHPPOBLCJBP, float PIELHHOLGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D96730", Offset = "0x7D95530", VA = "0x187D96730")]
	internal static void PHHIFOMBCMN(this IIEOKOOAPGE JHPPOBLCJBP, bool HMLBDBJCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D965E0", Offset = "0x7D953E0", VA = "0x187D965E0")]
	public static void JOOFGMHLIIK(this EMPALAADFLM LLPBIKCKKOM, Color32 DEJLIDMJHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D96620", Offset = "0x7D95420", VA = "0x187D96620")]
	internal static void JOOFGMHLIIK(this IIEOKOOAPGE JHPPOBLCJBP, Color32 DEJLIDMJHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D96640", Offset = "0x7D95440", VA = "0x187D96640")]
	public static void KBNAGBIMNBG(this EMPALAADFLM LLPBIKCKKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D96630", Offset = "0x7D95430", VA = "0x187D96630")]
	internal static void KBNAGBIMNBG(this IIEOKOOAPGE JHPPOBLCJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D96570", Offset = "0x7D95370", VA = "0x187D96570")]
	internal static void HCHPEHBAIAN(this IIEOKOOAPGE JHPPOBLCJBP, int ABOOMFMDFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D962A0", Offset = "0x7D950A0", VA = "0x187D962A0")]
	internal static void AKEEBOOAJGM(this IIEOKOOAPGE JHPPOBLCJBP, int FHLOJALHELA, HAFAPFMCMLF DIGOKDHFACG = HAFAPFMCMLF.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class DKMGNAAIIEI : IEquatable<DKMGNAAIIEI>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort FJMENFEGLOD = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int EEFHHCFBJFH = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly DKMGNAAIIEI PPPLMIKKDDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort NBNCGFOMHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC5A4D0", Offset = "0xC592D0", VA = "0x180C5A4D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC5A4E0", Offset = "0xC592E0", VA = "0x180C5A4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EIIEIMHICKH CNHNLBCFBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JOCIPIGBAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D89610", Offset = "0x7D88410", VA = "0x187D89610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D89700", Offset = "0x7D88500", VA = "0x187D89700")]
	public DKMGNAAIIEI(int NNIGIGIHPFE, EIIEIMHICKH HBNPNMJNNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D92CD0", Offset = "0x7D91AD0", VA = "0x187D92CD0")]
	public bool PGPLAHDLEIG([Out] EMPALAADFLM JLICNKNOLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D92C80", Offset = "0x7D91A80", VA = "0x187D92C80")]
	public void OJKDNIEEGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D895E0", Offset = "0x7D883E0", VA = "0x187D895E0")]
	internal void IOBEJFHBDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D894A0", Offset = "0x7D882A0", VA = "0x187D894A0", Slot = "4")]
	public bool Equals(DKMGNAAIIEI HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D92B50", Offset = "0x7D91950", VA = "0x187D92B50", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D92C10", Offset = "0x7D91A10", VA = "0x187D92C10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class EIIEIMHICKH : IDisposable, OBKEHGAOGHA
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string INNBHNCCLCL = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker HHAHNPNBOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string DKJHJNGABDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly FGMLABMIJDO NLEDFONIOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int FOPLINGJOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal IIEOKOOAPGE[] EGJJLFLFJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal DKMGNAAIIEI[] CFDCDBHDADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private ICNLFAMPLNM DHIFIGEPLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HBOJKGMCOAK GIKPEAIHKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly CMANCBPOODM DHHHNKPLAHM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string IHGFMOMOADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7D938A0", Offset = "0x7D926A0", VA = "0x187D938A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public ICNLFAMPLNM KOHKBOEBANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7D93C90", Offset = "0x7D92A90", VA = "0x187D93C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float ILHALIHEBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D92EB0", Offset = "0x7D91CB0", VA = "0x187D92EB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float KFPJEHKMLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7D92E30", Offset = "0x7D91C30", VA = "0x187D92E30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OBKEHGAOGHA.MEKDOBBDPAO NINJFINMMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFD0", Offset = "0xA0BDD0", VA = "0x180A0CFD0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D941C0", Offset = "0x7D92FC0", VA = "0x187D941C0")]
	public EIIEIMHICKH(FGMLABMIJDO EKMDFFAGMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D94600", Offset = "0x7D93400", VA = "0x187D94600")]
	public EIIEIMHICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D93510", Offset = "0x7D92310", VA = "0x187D93510")]
	public void HLJFBNEKAGO(GlyphMapAsset IPICOIAELEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D93550", Offset = "0x7D92350", VA = "0x187D93550")]
	public void HLJFBNEKAGO(ICNLFAMPLNM GMDBEFLFKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D93F20", Offset = "0x7D92D20", VA = "0x187D93F20", Slot = "6")]
	public bool TryGetMeshBuffer([Out] FMBMJGEAPMN OPBMIIBIDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D92E50", Offset = "0x7D91C50", VA = "0x187D92E50")]
	public void ANGEICAEJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D93410", Offset = "0x7D92210", VA = "0x187D93410")]
	public bool GEGIHKLEKHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D93CB0", Offset = "0x7D92AB0", VA = "0x187D93CB0")]
	public DKMGNAAIIEI OFFLOBEFMOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D93930", Offset = "0x7D92730", VA = "0x187D93930")]
	public void MLMPHHJDOPK(DKMGNAAIIEI PEMJKCBBPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D93460", Offset = "0x7D92260", VA = "0x187D93460")]
	internal bool GGCKNNJJAKP(DKMGNAAIIEI PEMJKCBBPJD, [Out] EMPALAADFLM JLICNKNOLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D92ED0", Offset = "0x7D91CD0", VA = "0x187D92ED0")]
	private void BGCPNLBFFHM(IIEOKOOAPGE JHPPOBLCJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D936C0", Offset = "0x7D924C0", VA = "0x187D936C0")]
	private void JPPDPBLAABH(int FPIPNFLHKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D93660", Offset = "0x7D92460", VA = "0x187D93660")]
	private bool JLAAHHKCMHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C4A0", Offset = "0x7D8B2A0", VA = "0x187D8C4A0")]
	private static int CJLDMGIGFJB(DKMGNAAIIEI PEMJKCBBPJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2166F40", Offset = "0x2165D40", VA = "0x182166F40")]
	private static ushort NOMLLMPNKLD(int GLAOLHCPLLG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D93050", Offset = "0x7D91E50", VA = "0x187D93050")]
	private Bounds DJAKGOOOHMC()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D93360", Offset = "0x7D92160", VA = "0x187D93360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FGMLABMIJDO
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly FGMLABMIJDO HMLPKGFBOCA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float GPEAOCONFPH = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LKELDFOFPAG = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HJHPCKMEDBA = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color IMFEFOLFJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float PCNHFBLOLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int CJAOFMAFKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int PJCPPBEIAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int KDPLMPKHLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int BJFGIMPOIJJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D94700", Offset = "0x7D93500", VA = "0x187D94700")]
	internal FGMLABMIJDO MCPLKFHNBIJ()
	{
		return default(FGMLABMIJDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D540", Offset = "0x7D8C340", VA = "0x187D8D540")]
	[CompilerGenerated]
	internal static void NMNPAEFEJEM(int OAIIHELJHLG, int LDGCNLHOBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D946C0", Offset = "0x7D934C0", VA = "0x187D946C0")]
	[CompilerGenerated]
	internal static void GOOIJGKBANL(float OAIIHELJHLG, float LDGCNLHOBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D530", Offset = "0x7D8C330", VA = "0x187D8D530")]
	[CompilerGenerated]
	internal static void MCHLPMJBHLM(int OAIIHELJHLG, int ODBPBICHPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D946E0", Offset = "0x7D934E0", VA = "0x187D946E0")]
	[CompilerGenerated]
	internal static void JLACLPGEMID(float OAIIHELJHLG, float ODBPBICHPOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AKCOOOHAKEI
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D91CC0", Offset = "0x7D90AC0", VA = "0x187D91CC0")]
	public static float EJHBOLHKGNC(this EMPALAADFLM LDDIKJDADJB)
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
		public readonly DKMGNAAIIEI textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7D96F30", Offset = "0x7D95D30", VA = "0x187D96F30")]
		public TextSegmentLayout(LayoutRect layoutRect, DKMGNAAIIEI textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7D96D00", Offset = "0x7D95B00", VA = "0x187D96D00")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7D96D70", Offset = "0x7D95B70", VA = "0x187D96D70")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7D96CA0", Offset = "0x7D95AA0", VA = "0x187D96CA0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class HBOJKGMCOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig MPMKOFPALNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float KMHMMPEJFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float IFCJILHAKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float OJINCFBHGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float EECOPIMPDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float LECOMNHGBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float MADKACNPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float AACNDILEMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float ONNCKILBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float LLFNEMMECLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float KFPJEHKMLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float PJIFALKPHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float ILHALIHEBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly POMFDLJMHCO[] BLFFNHIEJJL;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int MNBBJDFMGIP = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private IPCBLMBEOIC[] JJKIAIEMPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int EOKGDHMGAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private IKCMJMCGACO[] AJGMJANBDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int PHJAJBOODMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public POMFDLJMHCO AMFOGCLCPGG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D955B0", Offset = "0x7D943B0", VA = "0x187D955B0")]
	public void HLJFBNEKAGO(ICNLFAMPLNM IIBOHPBDHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D95640", Offset = "0x7D94440", VA = "0x187D95640")]
	public void HLJFBNEKAGO(GlyphUVConfig ACGIPIGNLAB, IEnumerable<IKCMJMCGACO> IPICOIAELEA, IKCMJMCGACO EIMMFGJDDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D95470", Offset = "0x7D94270", VA = "0x187D95470")]
	internal void ANMLECOEMJB(GlyphUVConfig ACGIPIGNLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7D959F0", Offset = "0x7D947F0", VA = "0x187D959F0")]
	private void MAFBJMMIBDN(IEnumerable<IKCMJMCGACO> IPICOIAELEA, IKCMJMCGACO EIMMFGJDDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D956C0", Offset = "0x7D944C0", VA = "0x187D956C0")]
	public void KFLGFMCKDDD([In] char MAOKJHAGONN, [Out] float2[] KJOMPOHFIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D91A10", Offset = "0x7D90810", VA = "0x187D91A10")]
	private POMFDLJMHCO LNGFFMPFBBN(IKCMJMCGACO IHCEFJBPCFM)
	{
		return default(POMFDLJMHCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D95F30", Offset = "0x7D94D30", VA = "0x187D95F30")]
	public HBOJKGMCOAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GOEGPNAENNC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D94920", Offset = "0x7D93720", VA = "0x187D94920")]
	public static void CBLLNOGOLKA([In] float FEKBOOHHFJF, [In] float ONMEEHAOCKA, [In] int DEJDMLDLAAP, [In] int AJALFHDBPHK, [In] float EECOPIMPDNL, [In] float LECOMNHGBJD, [In] float LNNPDAPIEPE, [In] float IPCNIAEIBJA, [In] float MIIAKENFPHE, [In] float LKCAPHEKNAA, [Out] float OMDOBEGOOKJ, [Out] float HJDNNEEOMHB, [Out] float DKGHAICDCPI, [Out] float CECCELENHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D948C0", Offset = "0x7D936C0", VA = "0x187D948C0")]
	public static void CBLLNOGOLKA([In] float FEKBOOHHFJF, [In] float ONMEEHAOCKA, [In] int DEJDMLDLAAP, [In] int AJALFHDBPHK, [Out] float OMDOBEGOOKJ, [Out] float HJDNNEEOMHB, [Out] float DKGHAICDCPI, [Out] float CECCELENHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D949F0", Offset = "0x7D937F0", VA = "0x187D949F0")]
	public static void FDDHGECCLGG([In] float EECOPIMPDNL, [In] float LECOMNHGBJD, [In] float EDGNPOLONAE, [In] float MOAAKJCHPMH, [In] float LMPCFAMHJOP, [In] float FNAOBLLDDCG, [Out] float EFNMMLEPMCA, [Out] float PGJKFPABKDJ, [Out] float CGKGMCNALPF, [Out] float OPNJLKMANEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct IPCBLMBEOIC
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint EDFJGEKELHB = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char BNLAELOFBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly POMFDLJMHCO CACBKAAHNGG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D96740", Offset = "0x7D95540", VA = "0x187D96740")]
	public IPCBLMBEOIC(char MAOKJHAGONN, POMFDLJMHCO KJOMPOHFIPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct POMFDLJMHCO
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint EDFJGEKELHB = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] PJNIHDBBALC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D96810", Offset = "0x7D95610", VA = "0x187D96810")]
	public POMFDLJMHCO(float OMDOBEGOOKJ, float HJDNNEEOMHB, float DKGHAICDCPI, float CECCELENHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct IIEOKOOAPGE
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int DKHKKKFPCIK = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal HAFAPFMCMLF DIGOKDHFACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] NPPFPBPPKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int LNJCEICAPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 MGNFNFFHENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float NKGJEENLJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 JDIMPEHFPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool HMLBDBJCOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int LKOOKHDCDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int FANLMCFIJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int ADPCELIONJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int FDJDGMGPMMH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D96210", Offset = "0x7D95010", VA = "0x187D96210")]
	public static int NALJGKMPAGG(int BAFECCBFOGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum HAFAPFMCMLF : byte
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
public static class HNDEDCKDEMI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D95FD0", Offset = "0x7D94DD0", VA = "0x187D95FD0")]
	internal static float EJHBOLHKGNC(this IIEOKOOAPGE JHPPOBLCJBP, float OAALHEKAOMP, float CIJJPEKEIII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D96010", Offset = "0x7D94E10", VA = "0x187D96010")]
	internal static void HENMMBAMIJD(this IIEOKOOAPGE JHPPOBLCJBP, float OAALHEKAOMP, float CIJJPEKEIII, [Out] float2 JJLOIPCKCEC, [Out] float2 CEDDBAAAIGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class CMANCBPOODM : OBKEHGAOGHA
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int EOECJNAKHOA = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int ONLJJFAMLPL = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string INNBHNCCLCL = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker DBOGDAIDHOH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker IOPFJKJJHHN;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker FJINMMDPDGD;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker EMBPKHAKFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly FMBMJGEAPMN OPBMIIBIDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] KKLOIOLDGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] BPJPILGJOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int IJIMNJNJEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int IAJHEAGODOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int AGHCCLFOGHF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string IHGFMOMOADA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OBKEHGAOGHA.MEKDOBBDPAO NINJFINMMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D92A40", Offset = "0x7D91840", VA = "0x187D92A40")]
	public CMANCBPOODM(FMBMJGEAPMN.NGJFAEDEGKC NKJAIGGEEFH, int JNHEDAEPIFF, int CGBIDHIPALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7D928B0", Offset = "0x7D916B0", VA = "0x187D928B0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] FMBMJGEAPMN OPBMIIBIDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7D92890", Offset = "0x7D91690", VA = "0x187D92890")]
	public void MNMNNNDLGLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D920B0", Offset = "0x7D90EB0", VA = "0x187D920B0")]
	public void IMLHOBJKLII(Span<IIEOKOOAPGE> CPGGHPGGPEE, HBOJKGMCOAK DDGEHFKGGIF, [In] FGMLABMIJDO EKMDFFAGMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FF60", Offset = "0x7D8ED60", VA = "0x187D8FF60")]
	private void AHBOLJABGPN([In] HAFAPFMCMLF DIGOKDHFACG, [In] IIEOKOOAPGE LEJMFBONBKD, int KEDLOFKDLPM, [In] float OAALHEKAOMP, [In] float CIJJPEKEIII, HBOJKGMCOAK DDGEHFKGGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7D91F60", Offset = "0x7D90D60", VA = "0x187D91F60")]
	private void EPFGADEEGLG([In] HAFAPFMCMLF DIGOKDHFACG, IIEOKOOAPGE LEJMFBONBKD, [In] int LJPDBLKBABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D91D50", Offset = "0x7D90B50", VA = "0x187D91D50")]
	public static void ABIJOJBAHHN(ReadOnlySpan<IIEOKOOAPGE> CPGGHPGGPEE, int HHKAPDJFHJN, [Out] int DJEGANEAOEF, [Out] int LLDCEMAFBEL, [Out] int PHAPIFEDMHJ)
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
