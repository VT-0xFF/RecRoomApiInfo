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
public class GBNENIIMPAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D PMIBJBDBHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig ECPKBPLMBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public HJGGHNLCGME[] PEABFHHLFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public HJGGHNLCGME LLONLJCFLLH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static GBNENIIMPAL DNCOFLHNOLE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GBNENIIMPAL BACOPFGIMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C64530", Offset = "0x6C63730", VA = "0x186C64530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public GBNENIIMPAL()
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
		[Cpp2IlInjected.Address(RVA = "0x6C65080", Offset = "0x6C64280", VA = "0x186C65080")]
		public GlyphUVConfig(int CEFNCOHLKGL, int MAIKDEFJCPM, int ABBCDOEDCJP, int FFBIKBKENGE, float JDAACIHLHOC = 0f, [Optional] GlyphPixelInset KGPKNJIBEFK)
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
public readonly struct HJGGHNLCGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char BJLGEJOAHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int LHHOEIMNMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int IGMAHEPOOFE;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly HJGGHNLCGME CCLGLMFILGA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C651D0", Offset = "0x6C643D0", VA = "0x186C651D0")]
	public HJGGHNLCGME(char PPCFPOFDCMI, int COJDMMLJJEC, int CHHPLONJEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C651B0", Offset = "0x6C643B0", VA = "0x186C651B0")]
	public HJGGHNLCGME(GlyphCoordinateWritable EMCJONOKBOM)
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
		[Cpp2IlInjected.Address(RVA = "0x6C646A0", Offset = "0x6C638A0", VA = "0x186C646A0")]
		public static HJGGHNLCGME CFMDMKLGJEH(GlyphCoordinateWritable GPOLJDKBMJM)
		{
			return default(HJGGHNLCGME);
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
		private GBNENIIMPAL configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6C64F80", Offset = "0x6C64180", VA = "0x186C64F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6C64E00", Offset = "0x6C64000", VA = "0x186C64E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x894480", Offset = "0x893680", VA = "0x180894480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C64DF0", Offset = "0x6C63FF0", VA = "0x186C64DF0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GBNENIIMPAL ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6C647F0", Offset = "0x6C639F0", VA = "0x186C647F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HJGGHNLCGME FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6C64C60", Offset = "0x6C63E60", VA = "0x186C64C60")]
			get
			{
				return default(HJGGHNLCGME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C646C0", Offset = "0x6C638C0", VA = "0x186C646C0")]
		internal void HKLKFOHNCJK(IEnumerable<GlyphCoordinateWritable> BCKOPIJBKBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C64760", Offset = "0x6C63960", VA = "0x186C64760")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C64740", Offset = "0x6C63940", VA = "0x186C64740")]
		[CompilerGenerated]
		private bool NFEHKBGOKAG(GlyphCoordinateWritable GPOLJDKBMJM)
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
		private TextSegmentMeshBufferSource DJFEDFNPPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DDAHCBIGLMB INLIGIMCDHG;

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
		private IJGPJCGGACM FGIIGOFHLPL;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C667C0", Offset = "0x6C659C0", VA = "0x186C667C0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C66770", Offset = "0x6C65970", VA = "0x186C66770")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C665B0", Offset = "0x6C657B0", VA = "0x186C665B0")]
		private void KEBCABOKBMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C668B0", Offset = "0x6C65AB0", VA = "0x186C668B0")]
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
		private bool JKCPPHCKHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material DOKPIFNPNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private DDAHCBIGLMB INLIGIMCDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material NOEHGAHNDME;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private GBNENIIMPAL GILDIOMLAKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6C66C30", Offset = "0x6C65E30", VA = "0x186C66C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DDAHCBIGLMB KFDEEAMAHJA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6C673B0", Offset = "0x6C665B0", VA = "0x186C673B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material LGFFHDNIMMI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C673E0", Offset = "0x6C665E0", VA = "0x186C673E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C67310", Offset = "0x6C66510", VA = "0x186C67310")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C66CC0", Offset = "0x6C65EC0", VA = "0x186C66CC0", Slot = "8")]
		protected override void KMLHLAELDFA(JLIJGCDDOOO NHMJKINMDGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C67320", Offset = "0x6C66520", VA = "0x186C67320", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MMIKEJAKCLC EPALPNPMNDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C66EA0", Offset = "0x6C660A0", VA = "0x186C66EA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C66FF0", Offset = "0x6C661F0", VA = "0x186C66FF0")]
		private void PADMEGNMCAB(bool PLHFEDHICDP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F50", Offset = "0x8B1150", VA = "0x1808B1F50")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct KPKDCNPNPEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly DDAHCBIGLMB KBBKBOOPBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int LDMDMJCDHCM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C65620", Offset = "0x6C64820", VA = "0x186C65620")]
	internal FBNKOJANEGC JNLFDOLGELN()
	{
		return default(FBNKOJANEGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x21E8950", Offset = "0x21E7B50", VA = "0x1821E8950")]
	internal KPKDCNPNPEG(DDAHCBIGLMB CAKLHAFGFAN, int AALOHKFHGJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HGJBGEONINN
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C650B0", Offset = "0x6C642B0", VA = "0x186C650B0")]
	public static bool CKDOEHDOPDE(this KPKDCNPNPEG MEDPIBNDFAO, JKENOMODNHD EIEGPMGEPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C65100", Offset = "0x6C64300", VA = "0x186C65100")]
	internal static bool CKDOEHDOPDE(this FBNKOJANEGC GPPLIJGJFDP, JKENOMODNHD EIEGPMGEPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C65120", Offset = "0x6C64320", VA = "0x186C65120")]
	public static float OIKPGLJKDEP(this KPKDCNPNPEG MEDPIBNDFAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xB6EBF0", Offset = "0xB6DDF0", VA = "0x180B6EBF0")]
	internal static float OIKPGLJKDEP(this FBNKOJANEGC GPPLIJGJFDP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OKNFNDFECCF
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C61920", Offset = "0x6C60B20", VA = "0x186C61920")]
	public static void MIALBACEHJC(this KPKDCNPNPEG MEDPIBNDFAO, ReadOnlySpan<char> JAGKIKJDJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C66460", Offset = "0x6C65660", VA = "0x186C66460")]
	internal static void MIALBACEHJC(this FBNKOJANEGC GPPLIJGJFDP, ReadOnlySpan<char> JAGKIKJDJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C66270", Offset = "0x6C65470", VA = "0x186C66270")]
	public static void CFIDOBBCOEL(this KPKDCNPNPEG NDMFJEKFMID, float2 CNMMBECAEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C662C0", Offset = "0x6C654C0", VA = "0x186C662C0")]
	internal static void CFIDOBBCOEL(this FBNKOJANEGC GPPLIJGJFDP, float2 CNMMBECAEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C66400", Offset = "0x6C65600", VA = "0x186C66400")]
	public static void HFIABGPJEKA(this KPKDCNPNPEG NDMFJEKFMID, float NBOCDIEJPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C663F0", Offset = "0x6C655F0", VA = "0x186C663F0")]
	internal static void HFIABGPJEKA(this FBNKOJANEGC GPPLIJGJFDP, float NBOCDIEJPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C662D0", Offset = "0x6C654D0", VA = "0x186C662D0")]
	internal static void CHBEDFKADKP(this FBNKOJANEGC GPPLIJGJFDP, bool MHGCGKCHCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C66350", Offset = "0x6C65550", VA = "0x186C66350")]
	public static void FAKMKKCJAEG(this KPKDCNPNPEG NDMFJEKFMID, Color32 CIHDHJMCJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C66390", Offset = "0x6C65590", VA = "0x186C66390")]
	internal static void FAKMKKCJAEG(this FBNKOJANEGC GPPLIJGJFDP, Color32 CIHDHJMCJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C663B0", Offset = "0x6C655B0", VA = "0x186C663B0")]
	public static void HCCPPIOGIKP(this KPKDCNPNPEG NDMFJEKFMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C663A0", Offset = "0x6C655A0", VA = "0x186C663A0")]
	internal static void HCCPPIOGIKP(this FBNKOJANEGC GPPLIJGJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C662E0", Offset = "0x6C654E0", VA = "0x186C662E0")]
	internal static void CJNFDHOBFGE(this FBNKOJANEGC GPPLIJGJFDP, int CLGNJLBEOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C66440", Offset = "0x6C65640", VA = "0x186C66440")]
	internal static void KBEPHAADLIB(this FBNKOJANEGC GPPLIJGJFDP, int GIPEOOKIOAK, JKENOMODNHD NKHGPIOIBDG = JKENOMODNHD.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IJGPJCGGACM : IEquatable<IJGPJCGGACM>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort PNLLBEMEMDE = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int AHMONHLPMNL = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly IJGPJCGGACM IPMAEEJCAMF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort KKNGPDPJINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F7E910", Offset = "0x1F7DB10", VA = "0x181F7E910")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1F7E920", Offset = "0x1F7DB20", VA = "0x181F7E920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DDAHCBIGLMB KBBKBOOPBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LHNMCLPFALC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A160", Offset = "0x6C59360", VA = "0x186C5A160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A200", Offset = "0x6C59400", VA = "0x186C5A200")]
	public IJGPJCGGACM(int GAPINFOLDMP, DDAHCBIGLMB CAKLHAFGFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C651E0", Offset = "0x6C643E0", VA = "0x186C651E0")]
	public bool EEOKOGKPMJC([Out] KPKDCNPNPEG MEDPIBNDFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C653E0", Offset = "0x6C645E0", VA = "0x186C653E0")]
	public void IMHGPOENCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A070", Offset = "0x6C59270", VA = "0x186C5A070")]
	internal void HAJIHNJPKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C59EE0", Offset = "0x6C590E0", VA = "0x186C59EE0", Slot = "4")]
	public bool Equals(IJGPJCGGACM KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C652B0", Offset = "0x6C644B0", VA = "0x186C652B0", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C65370", Offset = "0x6C64570", VA = "0x186C65370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DDAHCBIGLMB : IDisposable, PGODDAECKEI
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string LIBPEFOFEAG = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker AGMHPOFECMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string OAEBAMOHDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly BKPOLDBMAGK AAKNBOJCOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int JHEDCDIIOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal FBNKOJANEGC[] IOKFFHDBFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal IJGPJCGGACM[] JLFKBHPMPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private GBNENIIMPAL IFFBLCNLHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly OCELPGDPIGH DGJJHDEJBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly BKNGHFMPAOJ BHEMJAGPEIF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string EPPPGDEIJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C62FD0", Offset = "0x6C621D0", VA = "0x186C62FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JEJJEMHIPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B35B0", Offset = "0x8B27B0", VA = "0x1808B35B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public GBNENIIMPAL OBCAGMIBAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C634A0", Offset = "0x6C626A0", VA = "0x186C634A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float NLOABPHAAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C63110", Offset = "0x6C62310", VA = "0x186C63110")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JPCACFINAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C62D60", Offset = "0x6C61F60", VA = "0x186C62D60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public PGODDAECKEI.LCOAHNIOHPH IANAAIFBOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8942B0", Offset = "0x8934B0", VA = "0x1808942B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8941C0", Offset = "0x8933C0", VA = "0x1808941C0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C63F70", Offset = "0x6C63170", VA = "0x186C63F70")]
	public DDAHCBIGLMB(BKPOLDBMAGK MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C643B0", Offset = "0x6C635B0", VA = "0x186C643B0")]
	public DDAHCBIGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C62D80", Offset = "0x6C61F80", VA = "0x186C62D80")]
	public void BPKFIOLMIPE(GlyphMapAsset ONCKLBEODFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C62DC0", Offset = "0x6C61FC0", VA = "0x186C62DC0")]
	public void BPKFIOLMIPE(GBNENIIMPAL GACDBDOMMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C63CA0", Offset = "0x6C62EA0", VA = "0x186C63CA0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] MMIKEJAKCLC EPALPNPMNDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C636A0", Offset = "0x6C628A0", VA = "0x186C636A0")]
	public void JEFONMBNHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C62F80", Offset = "0x6C62180", VA = "0x186C62F80")]
	public bool CEAPAJLJFFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C63700", Offset = "0x6C62900", VA = "0x186C63700")]
	public IJGPJCGGACM JEGDHOEKJOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C63130", Offset = "0x6C62330", VA = "0x186C63130")]
	public void EIFOGFEJKGI(IJGPJCGGACM KOMHMNIAJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C62ED0", Offset = "0x6C620D0", VA = "0x186C62ED0")]
	internal bool CBMFJDEOOHA(IJGPJCGGACM KOMHMNIAJKA, [Out] KPKDCNPNPEG MEDPIBNDFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C62C10", Offset = "0x6C61E10", VA = "0x186C62C10")]
	private void ANPADJAKNOG(FBNKOJANEGC GPPLIJGJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C634C0", Offset = "0x6C626C0", VA = "0x186C634C0")]
	private void GAMNOMGECGI(int JJKIPDDEIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C63930", Offset = "0x6C62B30", VA = "0x186C63930")]
	private bool LCFNAMNBGGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F880", Offset = "0x6C5EA80", VA = "0x186C5F880")]
	private static int PIOLDCHHJFD(IJGPJCGGACM KOMHMNIAJKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1B45120", Offset = "0x1B44320", VA = "0x181B45120")]
	private static ushort IDAILHBLLJH(int KINMHNEMPOD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C63990", Offset = "0x6C62B90", VA = "0x186C63990")]
	private Bounds PGMPJEGBKOK()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C63060", Offset = "0x6C62260", VA = "0x186C63060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BKPOLDBMAGK
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BKPOLDBMAGK PADBHEGBLFC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float EKMHCFHLKGG = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int OAHJIEABMOG = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int PAEGMMHHMOJ = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color BNKLGFBIDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float FGNGAACJADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int GFGDBLGIJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int GPKDCNCPBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int IALEACJGCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int OLKEODPKJAA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C62A10", Offset = "0x6C61C10", VA = "0x186C62A10")]
	internal BKPOLDBMAGK FFEIDHHMNDB()
	{
		return default(BKPOLDBMAGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A260", Offset = "0x6C59460", VA = "0x186C5A260")]
	[CompilerGenerated]
	internal static void IHDALKAHPOA(int JECHHBGMFLN, int IIGPKDCCLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C62B40", Offset = "0x6C61D40", VA = "0x186C62B40")]
	[CompilerGenerated]
	internal static void JBBDOLKPOFO(float JECHHBGMFLN, float IIGPKDCCLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A310", Offset = "0x6C59510", VA = "0x186C5A310")]
	[CompilerGenerated]
	internal static void MPGCCDMGEMD(int JECHHBGMFLN, int FNGODGHMJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C62B20", Offset = "0x6C61D20", VA = "0x186C62B20")]
	[CompilerGenerated]
	internal static void HCLKEMEOBPJ(float JECHHBGMFLN, float FNGODGHMJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JAJBIEBGBMM
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C65570", Offset = "0x6C64770", VA = "0x186C65570")]
	public static (int, int) OEDFFLBICOG(this DDAHCBIGLMB PCCMFONEBND)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C654E0", Offset = "0x6C646E0", VA = "0x186C654E0")]
	public static float HIDLIOPKBLK(this KPKDCNPNPEG LAPLHBONIGI)
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
		public readonly IJGPJCGGACM textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C66BC0", Offset = "0x6C65DC0", VA = "0x186C66BC0")]
		public TextSegmentLayout(LayoutRect layoutRect, IJGPJCGGACM textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C66990", Offset = "0x6C65B90", VA = "0x186C66990")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C66A00", Offset = "0x6C65C00", VA = "0x186C66A00")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C66930", Offset = "0x6C65B30", VA = "0x186C66930")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class OCELPGDPIGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig KOPMOIDHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float NJDEMELLJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float AGMONDNMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float HAOGBLCJENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float EDNFKLHKLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float MKBLPIMEGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float LDLDNIMBMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float FADLFKACIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float CPDFGBDEHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float ONJMJFDEKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float JPCACFINAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float POIKBKINJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float NLOABPHAAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly DFKMNNLENCG[] EPMBGKLLDLI;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int EAKMMMHGIFJ = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private ILHDHDCFGPI[] PCIJLLHDPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int OBDHLMBDAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private HJGGHNLCGME[] MPADLHIAFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int DEKKDOMKPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public DFKMNNLENCG LJIAFOFIFKP;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C65CD0", Offset = "0x6C64ED0", VA = "0x186C65CD0")]
	public void BPKFIOLMIPE(GBNENIIMPAL IBCNDJPNJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C65D60", Offset = "0x6C64F60", VA = "0x186C65D60")]
	public void BPKFIOLMIPE(GlyphUVConfig IJDDPKPOGHH, IEnumerable<HJGGHNLCGME> ONCKLBEODFP, HJGGHNLCGME HHAEJPPJJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C65B90", Offset = "0x6C64D90", VA = "0x186C65B90")]
	internal void BDAHEPIKEEP(GlyphUVConfig IJDDPKPOGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C65660", Offset = "0x6C64860", VA = "0x186C65660")]
	private void APCIFECJLOM(IEnumerable<HJGGHNLCGME> ONCKLBEODFP, HJGGHNLCGME HHAEJPPJJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C65DE0", Offset = "0x6C64FE0", VA = "0x186C65DE0")]
	public void IOOOALIDPJJ([In] char PPCFPOFDCMI, [Out] float2[] KMOMHENFCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C613F0", Offset = "0x6C605F0", VA = "0x186C613F0")]
	private DFKMNNLENCG HHKHHBLICED(HJGGHNLCGME EMCJONOKBOM)
	{
		return default(DFKMNNLENCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C66110", Offset = "0x6C65310", VA = "0x186C66110")]
	public OCELPGDPIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BHBEKNEAOHA
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C61B60", Offset = "0x6C60D60", VA = "0x186C61B60")]
	public static void NMFKDIKNNFA([In] float CPCONEBBPLA, [In] float CBELMCJCLCP, [In] int DGNKPMCCLKA, [In] int PNLALBGBMJM, [In] float EDNFKLHKLBM, [In] float MKBLPIMEGKB, [In] float GDCIIJJIEDP, [In] float DNMPKJLNFNG, [In] float FKOMHOLNIPN, [In] float IEGPOLGBBEF, [Out] float ANFHKLLKGBC, [Out] float HBLIMDIMHNB, [Out] float ENNNDOHJGML, [Out] float FHLADPNNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C61B00", Offset = "0x6C60D00", VA = "0x186C61B00")]
	public static void NMFKDIKNNFA([In] float CPCONEBBPLA, [In] float CBELMCJCLCP, [In] int DGNKPMCCLKA, [In] int PNLALBGBMJM, [Out] float ANFHKLLKGBC, [Out] float HBLIMDIMHNB, [Out] float ENNNDOHJGML, [Out] float FHLADPNNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C61AA0", Offset = "0x6C60CA0", VA = "0x186C61AA0")]
	public static void BLIFJPBPCME([In] float EDNFKLHKLBM, [In] float MKBLPIMEGKB, [In] float BOPIIDHLEPE, [In] float NIBAOEDFMEB, [In] float CGGMMFOIGDO, [In] float EJKECLIHDKH, [Out] float NDGCCLFPABI, [Out] float BBMFJBAJNFA, [Out] float HNDOGFILAPO, [Out] float OPCJEENJLOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct ILHDHDCFGPI
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint NIELLNNOEFB = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char BJLGEJOAHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly DFKMNNLENCG DJLGLMOEMJG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C654C0", Offset = "0x6C646C0", VA = "0x186C654C0")]
	public ILHDHDCFGPI(char PPCFPOFDCMI, DFKMNNLENCG KMOMHENFCNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DFKMNNLENCG
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint NIELLNNOEFB = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] BGNCKLOKLGA;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C64430", Offset = "0x6C63630", VA = "0x186C64430")]
	public DFKMNNLENCG(float ANFHKLLKGBC, float HBLIMDIMHNB, float ENNNDOHJGML, float FHLADPNNIOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct FBNKOJANEGC
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int GEANNJPKECJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal JKENOMODNHD NKHGPIOIBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] PCBFBGLJINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int APDIENGKMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 CNMMBECAEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float DIJNIKMOPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 HEDJJILNGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool MHGCGKCHCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int CGCJJOBPNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int NILPLOPMNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int JOILIHBHEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int ABBLMGBJMGH;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C64520", Offset = "0x6C63720", VA = "0x186C64520")]
	public static int GFFNABAIMGG(int EJJDGFIKEKP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum JKENOMODNHD : byte
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
public static class OCFKBCIFEGA
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C661B0", Offset = "0x6C653B0", VA = "0x186C661B0")]
	internal static float HIDLIOPKBLK(this FBNKOJANEGC GPPLIJGJFDP, float KBCBIICCJKO, float JGBKAOIMJOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C661F0", Offset = "0x6C653F0", VA = "0x186C661F0")]
	internal static void JIBOMDBJAAO(this FBNKOJANEGC GPPLIJGJFDP, float KBCBIICCJKO, float JGBKAOIMJOK, [Out] float2 LGOHHHLPLHB, [Out] float2 KBKIMKNFKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class BKNGHFMPAOJ : PGODDAECKEI
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int KACNDADICJC = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int GJPNMKLAFMB = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string LIBPEFOFEAG = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static PPLFOIHMFIP CBEBMNAIDIO;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static PPLFOIHMFIP DNNNGOMGDIM;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static PPLFOIHMFIP LCAKMGHJIJB;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static PPLFOIHMFIP FPJFEOINMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly MMIKEJAKCLC EPALPNPMNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] ENGAJMIEHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] CGKBILDBOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int MKBEAKHNAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int ODHOAMJCAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int DLBPHKGBHBK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string EPPPGDEIJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public PGODDAECKEI.LCOAHNIOHPH IANAAIFBOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C62900", Offset = "0x6C61B00", VA = "0x186C62900")]
	public BKNGHFMPAOJ(MMIKEJAKCLC.AKOGNGABCNJ KHGGKCOIOBA, int LJIMMCJEJPB, int AEHLGDMPNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C62780", Offset = "0x6C61980", VA = "0x186C62780", Slot = "5")]
	public bool TryGetMeshBuffer([Out] MMIKEJAKCLC EPALPNPMNDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C62760", Offset = "0x6C61960", VA = "0x186C62760")]
	public void PPMAHILFMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C61D80", Offset = "0x6C60F80", VA = "0x186C61D80")]
	public void EBJDDLPICBL(Span<FBNKOJANEGC> OKCDANNNJPB, OCELPGDPIGH BIOCKJGCBLA, [In] BKPOLDBMAGK MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FBA0", Offset = "0x6C5EDA0", VA = "0x186C5FBA0")]
	private void DJDCHNDIEGI([In] JKENOMODNHD NKHGPIOIBDG, [In] FBNKOJANEGC IEBJBOAKEPK, int KGOAEKFPGCG, [In] float KBCBIICCJKO, [In] float JGBKAOIMJOK, OCELPGDPIGH BIOCKJGCBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C61C30", Offset = "0x6C60E30", VA = "0x186C61C30")]
	private void BKPGOHIOGGF([In] JKENOMODNHD NKHGPIOIBDG, FBNKOJANEGC IEBJBOAKEPK, [In] int DGDKAEJIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C62590", Offset = "0x6C61790", VA = "0x186C62590")]
	public static void OONPCBJMLHA(ReadOnlySpan<FBNKOJANEGC> OKCDANNNJPB, int OHINDLAPJFK, [Out] int NIACDIADBPK, [Out] int LJLGGCPEGMM, [Out] int CDAKEKDNKIH)
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
