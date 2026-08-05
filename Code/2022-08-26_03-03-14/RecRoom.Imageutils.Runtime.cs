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
		[Cpp2IlInjected.Address(RVA = "0x587E7F0", Offset = "0x587D3F0", VA = "0x18587E7F0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PJKOIKFCOIO
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
public interface EAPBKOKDJND
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PJKOIKFCOIO COIMCDJDAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HPNGPFPHAIK
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
			[Cpp2IlInjected.Address(RVA = "0x587FF10", Offset = "0x587EB10", VA = "0x18587FF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x587FF00", Offset = "0x587EB00", VA = "0x18587FF00")]
		public Resolution(uint FEMNKHHBNAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x775D30", Offset = "0x774930", VA = "0x180775D30")]
		public Resolution(uint FEMNKHHBNAG, uint FAKOIENNMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x587FDB0", Offset = "0x587E9B0", VA = "0x18587FDB0")]
		public static Resolution CNBAOMALMMJ(Resolution[] NMCLAMODNNE, Resolution GPEJPEACECF, int MEFJLBLJHBE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BLMIBEJBDEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution IPIJPIHBJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? ALPKNAJNOCI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FEMNKHHBNAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x587E250", Offset = "0x587CE50", VA = "0x18587E250")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint FAKOIENNMNA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x587E260", Offset = "0x587CE60", VA = "0x18587E260")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution ONFDDMMLDNN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x587E280", Offset = "0x587CE80", VA = "0x18587E280")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1A857D0", Offset = "0x1A843D0", VA = "0x181A857D0")]
		public BLMIBEJBDEI(Resolution IPIJPIHBJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x587E080", Offset = "0x587CC80", VA = "0x18587E080")]
		private static Resolution GBMBONPCAOA(Resolution ALPKNAJNOCI, PJKOIKFCOIO ABJAIPIMPHP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OKBKOOAPHKG
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HPKIDGPLLAF;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution IIOEHEPPIEG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution CEPGOFGBOFI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution MJMCOLBDNBA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DDFGMLAEMFG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution GHPLFKEBPIB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] GFMJNNPHPEN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BOACGKIHKCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution JLHHFGPFLCB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution EMLFEABPEDN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution DGBCFPHOOOG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution CGCBBDIPEPC;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution ECJBHDIBCON;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] GFMJNNPHPEN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x587E450", Offset = "0x587D050", VA = "0x18587E450")]
		public static Resolution MJEINIGFKKD(uint ODJKCOFMAJL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution HEHLNKFCKOL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x587E8A0", Offset = "0x587D4A0", VA = "0x18587E8A0")]
	public static bool IINFPEIICNO(uint PLJNAGMCIGH)
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
		public enum NBCNIGONEDE : byte
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
		private class HPBPBLAOOOP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string FHNLBBBEDLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D EOLBPHJPHFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NBCNIGONEDE IAEAMKMENPO;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x587E850", Offset = "0x587D450", VA = "0x18587E850")]
			public HPBPBLAOOOP(string FHNLBBBEDLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x93F160", Offset = "0x93DD60", VA = "0x18093F160")]
			public HPBPBLAOOOP(string FHNLBBBEDLN, Texture2D EGOOJODLFLB, NBCNIGONEDE IKCDANOCGDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x587E810", Offset = "0x587D410", VA = "0x18587E810", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BMDPAIFCFOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NBCNIGONEDE textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public BMDPAIFCFOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x587E410", Offset = "0x587D010", VA = "0x18587E410")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PGNIICNLGNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public PGNIICNLGNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x587FD00", Offset = "0x587E900", VA = "0x18587FD00")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PHMCFHMHGFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public PHMCFHMHGFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x587FD20", Offset = "0x587E920", VA = "0x18587FD20")]
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
		private global::FCECEOPAAFH<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HPBPBLAOOOP _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::FCECEOPAAFH<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::FCECEOPAAFH<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6177B0", Offset = "0x6163B0", VA = "0x1806177B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HPBPBLAOOOP memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x587F9F0", Offset = "0x587E5F0", VA = "0x18587F9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x587F940", Offset = "0x587E540", VA = "0x18587F940")]
		public ManagedTexture(string FHNLBBBEDLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x587F990", Offset = "0x587E590", VA = "0x18587F990")]
		public ManagedTexture(string FHNLBBBEDLN, bool KCNIOGIFKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x587F5E0", Offset = "0x587E1E0", VA = "0x18587F5E0")]
		public void NCIOJAADEME(RenderTexture MMEAEJPMENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x587EE60", Offset = "0x587DA60", VA = "0x18587EE60")]
		public global::FCECEOPAAFH<byte[]> FJABIIPLJDA(bool CENMLAMBPJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x587F6B0", Offset = "0x587E2B0", VA = "0x18587F6B0")]
		public global::FCECEOPAAFH<Texture2D> PGJNNDNHCII(NBCNIGONEDE IKCDANOCGDB, bool LFNFBFMFMMB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x587F430", Offset = "0x587E030", VA = "0x18587F430")]
		public global::FCECEOPAAFH<byte[]> LDOAKLCDAME(bool LFNFBFMFMMB = false, int AGNCJCNJLEF = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x587ECC0", Offset = "0x587D8C0", VA = "0x18587ECC0")]
		public global::FCECEOPAAFH<byte[]> CBNHPCLIPJF(bool LFNFBFMFMMB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x587EF40", Offset = "0x587DB40", VA = "0x18587EF40")]
		private static global::FCECEOPAAFH<Texture2D> JOCPKJOANIK(string FHNLBBBEDLN, RenderTexture MMEAEJPMENN, ref Texture2D PIBLNJHKMFK, bool LFNFBFMFMMB, NBCNIGONEDE OLBEJGDMENK = NBCNIGONEDE.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x587EE80", Offset = "0x587DA80", VA = "0x18587EE80")]
		public void FNLFLOOPHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x587EE50", Offset = "0x587DA50", VA = "0x18587EE50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x587F610", Offset = "0x587E210", VA = "0x18587F610")]
		[CompilerGenerated]
		private global::FCECEOPAAFH<byte[]> NFOEDIDBAGL(Texture2D EPNHIEKHNBA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KBCKNMLPIAD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x587EAE0", Offset = "0x587D6E0", VA = "0x18587EAE0")]
	public static RenderTexture ANEMBIBNACC(int ODJKCOFMAJL, int HEHBEAHJOKL, int IPPGOEACPIL, Camera MNLCHGOAGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x587EC50", Offset = "0x587D850", VA = "0x18587EC50")]
	public static void LALKHJDDMIH(RenderTexture MMEAEJPMENN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AHEBCEBLAFI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CCFFHBIBJJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int HGAEFGJCCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int OFINKJCDEMA;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x685350", Offset = "0x683F50", VA = "0x180685350")]
		public CCFFHBIBJJG(int PIIGCEIAAFL, int PKPFAHAEBCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum OAEKEDNFBEC
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] PCLMLJBJNGH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] AHHLPJJHPNH;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int LLGIACMDDKP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float LGLBOJCCPHH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float HPFANPEPHJO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int INKJMBCJFLJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int EMLMDLIGOPB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex OFIJFHPFKLO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x587D200", Offset = "0x587BE00", VA = "0x18587D200")]
	public static void JBJMCNPDCNF(Texture2D BFFIBGCHCJO, int DNILLGPDLOB, int GDFALEHIEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x587D5C0", Offset = "0x587C1C0", VA = "0x18587D5C0")]
	private static void PGKDNDJFNLD(Texture2D BFFIBGCHCJO, int DNILLGPDLOB, int GDFALEHIEAP, OAEKEDNFBEC OOBFNBMGGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x587DA70", Offset = "0x587C670", VA = "0x18587DA70")]
	public static void PIEOFKIFMIM(object EBMPLNBFAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x587D220", Offset = "0x587BE20", VA = "0x18587D220")]
	public static void LMIHEPFHANO(object EBMPLNBFAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x587D400", Offset = "0x587C000", VA = "0x18587D400")]
	private static Color NAOEFCPEGJI(int FEMNKHHBNAG, int FAKOIENNMNA, float LGLBOJCCPHH, float HPFANPEPHJO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x587D020", Offset = "0x587BC20", VA = "0x18587D020")]
	public static void FLFEFFFKMPA(object EBMPLNBFAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x587DF90", Offset = "0x587CB90", VA = "0x18587DF90")]
	private static Color PKNFEANKFGH(Color DFCEONLKPOP, Color BNIOOCBPMEP, float KGJOJGIPNPH)
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
