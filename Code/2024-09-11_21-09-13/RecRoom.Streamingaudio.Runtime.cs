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
public interface HPJFDFAPFDL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KHBJKPODHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IMBMLOIFLFG> MKKOIGLDNJL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IMBMLOIFLFG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string IGLNGGCKCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HODFFEEMDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DGEHDJPBCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EBEBDBMIBGL MCBOAKCIABG(Action<ArraySegment<float>> JMKAJHCEDCI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JEADHFHGBFN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EBEBDBMIBGL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MDNLOEEOINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JGGNALGKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2669630", Offset = "0x2667C30", VA = "0x182669630")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F41DD0", Offset = "0x5F403D0", VA = "0x185F41DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2030", Offset = "0x6BB0630", VA = "0x186BB2030")]
	public EBEBDBMIBGL(int FBGCCBOHLPG, int POOAMDPEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IMPDGFOAOLC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HPJFDFAPFDL FGLFHMNJOBP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KHBJKPODHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74E2B80", Offset = "0x74E1180", VA = "0x1874E2B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74E2CE0", Offset = "0x74E12E0", VA = "0x1874E2CE0")]
	static IMPDGFOAOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74E2BF0", Offset = "0x74E11F0", VA = "0x1874E2BF0")]
	public static IReadOnlyList<IMBMLOIFLFG> MKKOIGLDNJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LBIJNKKHCDH : HPJFDFAPFDL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GDBPEKHGDDB : IMBMLOIFLFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GHAMBDPGHMM
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public GHAMBDPGHMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x74E2A00", Offset = "0x74E1000", VA = "0x1874E2A00")]
			internal void CGEJHKPJDAP(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HAEFHGKGDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture IAMEEBKHLIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BICNBMACCNB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IGLNGGCKCNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x74E25A0", Offset = "0x74E0BA0", VA = "0x1874E25A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HODFFEEMDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x901400", Offset = "0x8FFA00", VA = "0x180901400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCE9A00", Offset = "0xCE8000", VA = "0x180CE9A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DGEHDJPBCFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1041470", Offset = "0x103FA70", VA = "0x181041470", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74E25C0", Offset = "0x74E0BC0", VA = "0x1874E25C0", Slot = "7")]
		public EBEBDBMIBGL MCBOAKCIABG(Action<ArraySegment<float>> JMKAJHCEDCI)
		{
			return default(EBEBDBMIBGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74E25F0", Offset = "0x74E0BF0", VA = "0x1874E25F0")]
		private EBEBDBMIBGL MCBOAKCIABG(int FBGCCBOHLPG, int HIKNFGLLODH, int POOAMDPEGHM, Action<ArraySegment<float>> JMKAJHCEDCI)
		{
			return default(EBEBDBMIBGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74E2520", Offset = "0x74E0B20", VA = "0x1874E2520", Slot = "8")]
		public void JEADHFHGBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74E29B0", Offset = "0x74E0FB0", VA = "0x1874E29B0")]
		public GDBPEKHGDDB(MMDevice HAEFHGKGDKG, bool HBDPACDNPIB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GDBPEKHGDDB> IBCAOEIMLDE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KHBJKPODHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74E2DD0", Offset = "0x74E13D0", VA = "0x1874E2DD0", Slot = "5")]
	public IReadOnlyList<IMBMLOIFLFG> MKKOIGLDNJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74E30F0", Offset = "0x74E16F0", VA = "0x1874E30F0")]
	public LBIJNKKHCDH()
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
