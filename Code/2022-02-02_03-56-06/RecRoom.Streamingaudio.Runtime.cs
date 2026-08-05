using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PDACFOBEDBC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KCMAHPJGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<JBHAHJGIDCP> IOLCGANMGJN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JBHAHJGIDCP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OCMKDADEONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MPGIKEGMAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FFKJMDMKNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LBNHMEFJCPG ANHPJCLPFGO(Action<ArraySegment<float>> MBNIDEHOLID);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFLDPBDOCHA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LBNHMEFJCPG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MOICBLNMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x734800", Offset = "0x733800", VA = "0x180734800")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x797950", Offset = "0x796950", VA = "0x180797950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NGGMEDBMPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7347E0", Offset = "0x7337E0", VA = "0x1807347E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1F86160", Offset = "0x1F85160", VA = "0x181F86160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46C3940", Offset = "0x46C2940", VA = "0x1846C3940")]
	public LBNHMEFJCPG(int JHFAIJPDOPE, int BCLOCAEMEAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CANBPBMJDIG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static PDACFOBEDBC NHFMNMFPGKH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KCMAHPJGANB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x46C2FC0", Offset = "0x46C1FC0", VA = "0x1846C2FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46C3120", Offset = "0x46C2120", VA = "0x1846C3120")]
	static CANBPBMJDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x46C3030", Offset = "0x46C2030", VA = "0x1846C3030")]
	public static IReadOnlyList<JBHAHJGIDCP> IOLCGANMGJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JCNBHCAJMOL : PDACFOBEDBC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JJEJMNCKGFF : JBHAHJGIDCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PMIBLLPAJLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public PMIBLLPAJLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x46C3950", Offset = "0x46C2950", VA = "0x1846C3950")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HIDIFCJIOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture BBKKCBPKHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LEIKCACCLEL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OCMKDADEONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x46C38D0", Offset = "0x46C28D0", VA = "0x1846C38D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MPGIKEGMAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x589D90", Offset = "0x588D90", VA = "0x180589D90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6D68A0", Offset = "0x6D58A0", VA = "0x1806D68A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FFKJMDMKNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6A5F00", Offset = "0x6A4F00", VA = "0x1806A5F00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x46C3820", Offset = "0x46C2820", VA = "0x1846C3820", Slot = "7")]
		public LBNHMEFJCPG ANHPJCLPFGO(Action<ArraySegment<float>> MBNIDEHOLID)
		{
			return default(LBNHMEFJCPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x46C34E0", Offset = "0x46C24E0", VA = "0x1846C34E0")]
		private LBNHMEFJCPG ANHPJCLPFGO(int JHFAIJPDOPE, int DJLCPBIFPAE, int BCLOCAEMEAI, Action<ArraySegment<float>> MBNIDEHOLID)
		{
			return default(LBNHMEFJCPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x46C3850", Offset = "0x46C2850", VA = "0x1846C3850", Slot = "8")]
		public void HFLDPBDOCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x46C38F0", Offset = "0x46C28F0", VA = "0x1846C38F0")]
		public JJEJMNCKGFF(MMDevice HIDIFCJIOIN, bool MIMPHKCMALH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JJEJMNCKGFF> OLFKFGMAFAA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KCMAHPJGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4E3FE0", Offset = "0x4E2FE0", VA = "0x1804E3FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x46C31D0", Offset = "0x46C21D0", VA = "0x1846C31D0", Slot = "5")]
	public IReadOnlyList<JBHAHJGIDCP> IOLCGANMGJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x46C3470", Offset = "0x46C2470", VA = "0x1846C3470")]
	public JCNBHCAJMOL()
	{
	}
}
namespace Cpp2IlInjected;

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
