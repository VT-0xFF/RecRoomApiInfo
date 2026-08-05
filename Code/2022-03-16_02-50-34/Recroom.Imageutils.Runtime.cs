using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4ABFF60", Offset = "0x4ABED60", VA = "0x184ABFF60")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PJGPHMNGBGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ELFOBKAIBBL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PJGPHMNGBGJ ONCPFJOMMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KJHCFAMIIEF
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x4AC19D0", Offset = "0x4AC07D0", VA = "0x184AC19D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4AC19C0", Offset = "0x4AC07C0", VA = "0x184AC19C0")]
		public Resolution(uint ACPFKFODNNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A59F0", Offset = "0x6A47F0", VA = "0x1806A59F0")]
		public Resolution(uint ACPFKFODNNE, uint FFHJLCNGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4AC1870", Offset = "0x4AC0670", VA = "0x184AC1870")]
		public static Resolution NMJNCBLMJPM(Resolution[] PGOJIIEDDFG, Resolution ONOLODNNHFF, int DJAILHPFBPC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CHJJPMDMIDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution BDMMIJDNKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? PNJFCDKEPJE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint ACPFKFODNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4ABFB60", Offset = "0x4ABE960", VA = "0x184ABFB60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint FFHJLCNGNED
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4ABFF40", Offset = "0x4ABED40", VA = "0x184ABFF40")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution MKHKCFIIDEG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4ABFD40", Offset = "0x4ABEB40", VA = "0x184ABFD40")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x19A0900", Offset = "0x199F700", VA = "0x1819A0900")]
		public CHJJPMDMIDD(Resolution BDMMIJDNKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4ABFB70", Offset = "0x4ABE970", VA = "0x184ABFB70")]
		private static Resolution BHBHNPBNKMC(Resolution PNJFCDKEPJE, PJGPHMNGBGJ KFFMNBPPJIH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ODEHALDOHKM
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution JAIPKDMKKCD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OMBNENNGKKB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution MNGIOMOFOCJ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OMBCBJMHLMC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution JIOJOBNGEMB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution OLJILCKGIMF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] OMNKNIDCOEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EKKKILHHEOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution MHLPBCOLJJE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution LEBKHCEKKAC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution DCEJLCMEIKJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution MKIECKBEHPC;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution KMHDJPKANNG;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] OMNKNIDCOEL;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4ABFF80", Offset = "0x4ABED80", VA = "0x184ABFF80")]
		public static Resolution CBJDPHJFFKG(uint HALPAOLACGJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution GHHBCCONCJL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4AC0500", Offset = "0x4ABF300", VA = "0x184AC0500")]
	public static bool EDHBHAMGDDF(uint KBGFKOIACLM)
	{
		return default(bool);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[Flags]
		public enum JONOGDBGPHB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class OODFLAPHEDC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string HPAMGGFODJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D OCOLOLOJOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JONOGDBGPHB LGOLIJJCADD;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4AC1800", Offset = "0x4AC0600", VA = "0x184AC1800")]
			public OODFLAPHEDC(string HPAMGGFODJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x88C9C0", Offset = "0x88B7C0", VA = "0x18088C9C0")]
			public OODFLAPHEDC(string HPAMGGFODJL, Texture2D IMJHKNFFICK, JONOGDBGPHB DBIOOFJDPNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4AC17C0", Offset = "0x4AC05C0", VA = "0x184AC17C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NEJMKEBIJJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JONOGDBGPHB textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public NEJMKEBIJJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4AC1510", Offset = "0x4AC0310", VA = "0x184AC1510")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PKINLCBMCIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public PKINLCBMCIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4AC1850", Offset = "0x4AC0650", VA = "0x184AC1850")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BLILGENBIFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public BLILGENBIFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4ABFAD0", Offset = "0x4ABE8D0", VA = "0x184ABFAD0")]
			internal void <RenderTextureToTexture2D>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private global::BKHPMHDEEIP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OODFLAPHEDC _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::BKHPMHDEEIP<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::BKHPMHDEEIP<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5477B0", Offset = "0x5465B0", VA = "0x1805477B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x18051EDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x546D70", Offset = "0x545B70", VA = "0x180546D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OODFLAPHEDC memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4AC1470", Offset = "0x4AC0270", VA = "0x184AC1470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4AC1420", Offset = "0x4AC0220", VA = "0x184AC1420")]
		public ManagedTexture(string HPAMGGFODJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4AC13C0", Offset = "0x4AC01C0", VA = "0x184AC13C0")]
		public ManagedTexture(string HPAMGGFODJL, bool EDBIEKPLGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0750", Offset = "0x4ABF550", VA = "0x184AC0750")]
		public void FHNEHDHJNEB(RenderTexture GHKOBLGBEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0780", Offset = "0x4ABF580", VA = "0x184AC0780")]
		public global::BKHPMHDEEIP<byte[]> FHONKBKCEBG(bool BHIJCGGCILI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0E40", Offset = "0x4ABFC40", VA = "0x184AC0E40")]
		public global::BKHPMHDEEIP<Texture2D> MGBJEDINGMB(JONOGDBGPHB DBIOOFJDPNI, bool AICHOJLPGPB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0C90", Offset = "0x4ABFA90", VA = "0x184AC0C90")]
		public global::BKHPMHDEEIP<byte[]> KIGJPOHMJDB(bool AICHOJLPGPB = false, int DAPCCAKIEEN = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4AC10D0", Offset = "0x4ABFED0", VA = "0x184AC10D0")]
		public global::BKHPMHDEEIP<byte[]> NPDGIMDBNPJ(bool AICHOJLPGPB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4AC07A0", Offset = "0x4ABF5A0", VA = "0x184AC07A0")]
		private static global::BKHPMHDEEIP<Texture2D> GFEDOGLNKMF(string HPAMGGFODJL, RenderTexture GHKOBLGBEOA, ref Texture2D DHDFDJNINDK, bool AICHOJLPGPB, JONOGDBGPHB HBNHHEIEDMH = JONOGDBGPHB.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4AC1260", Offset = "0x4AC0060", VA = "0x184AC1260")]
		public void OMAPDNCCFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0740", Offset = "0x4ABF540", VA = "0x184AC0740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4AC1320", Offset = "0x4AC0120", VA = "0x184AC1320")]
		[CompilerGenerated]
		private global::BKHPMHDEEIP<byte[]> PDBNFELGIGJ(Texture2D OPNNBLDKJKB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FKFLBDLBJKG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4AC0390", Offset = "0x4ABF190", VA = "0x184AC0390")]
	public static RenderTexture ECEEILJGEAH(int HALPAOLACGJ, int GJLNADLHOLD, int GPPJEGMCOIN, Camera GPKFAHLACMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4AC0320", Offset = "0x4ABF120", VA = "0x184AC0320")]
	public static void APDIHOBJLJK(RenderTexture GHKOBLGBEOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AICNGNHILGI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LJKPGGCJJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int CDNJHFLFOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int ICLHCKDDPDG;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5B5350", Offset = "0x5B4150", VA = "0x1805B5350")]
		public LJKPGGCJJFP(int FAJPLDJFIPA, int OGCHFBMNBDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum APEPAFELDED
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] ECLINOLKHNA;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] OKMGKAAEPNG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int AOLMKHAFJHD;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float BBKPDPIEBND;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float CIKIHHMKGCE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int ELGACEPCCJD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int HLIJFKBFFDB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex PEDLKOALDOJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4ABF590", Offset = "0x4ABE390", VA = "0x184ABF590")]
	public static void OLCLMHNILHJ(Texture2D BEPEMIMBLGF, int HAPHHLDJDJJ, int HHKBAGHBKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4ABED40", Offset = "0x4ABDB40", VA = "0x184ABED40")]
	private static void IDDKCDMGDJA(Texture2D BEPEMIMBLGF, int HAPHHLDJDJJ, int HHKBAGHBKCD, APEPAFELDED HIGIPMCLDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4ABF5B0", Offset = "0x4ABE3B0", VA = "0x184ABF5B0")]
	public static void PMNDDAPJFGN(object PJNABAALNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4ABEB60", Offset = "0x4ABD960", VA = "0x184ABEB60")]
	public static void HLFAOAEKHAO(object PJNABAALNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4ABF3D0", Offset = "0x4ABE1D0", VA = "0x184ABF3D0")]
	private static Color ODDMJILCFBD(int ACPFKFODNNE, int FFHJLCNGNED, float BBKPDPIEBND, float CIKIHHMKGCE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4ABF1F0", Offset = "0x4ABDFF0", VA = "0x184ABF1F0")]
	public static void KMLKKFBGLCF(object PJNABAALNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4ABEA70", Offset = "0x4ABD870", VA = "0x184ABEA70")]
	private static Color CEMOPICKFKK(Color PBNOLFHJIJM, Color JJEKFGOLMJD, float KCFMHIDCDCO)
	{
		return default(Color);
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
