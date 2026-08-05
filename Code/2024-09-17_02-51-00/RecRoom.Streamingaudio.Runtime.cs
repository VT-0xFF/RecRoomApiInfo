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
		[Cpp2IlInjected.Address(RVA = "0x9F6230", Offset = "0x9F4C30", VA = "0x1809F6230")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JGGNALGKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2710A10", Offset = "0x270F410", VA = "0x182710A10")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6025520", Offset = "0x6023F20", VA = "0x186025520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C992C0", Offset = "0x6C97CC0", VA = "0x186C992C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75CE790", Offset = "0x75CD190", VA = "0x1875CE790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75CE8F0", Offset = "0x75CD2F0", VA = "0x1875CE8F0")]
	static IMPDGFOAOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75CE800", Offset = "0x75CD200", VA = "0x1875CE800")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public GHAMBDPGHMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x75CE610", Offset = "0x75CD010", VA = "0x1875CE610")]
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
			[Cpp2IlInjected.Address(RVA = "0x75CE1B0", Offset = "0x75CCBB0", VA = "0x1875CE1B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HODFFEEMDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9C3C00", Offset = "0x9C2600", VA = "0x1809C3C00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xDBB870", Offset = "0xDBA270", VA = "0x180DBB870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DGEHDJPBCFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x10F61A0", Offset = "0x10F4BA0", VA = "0x1810F61A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75CE1D0", Offset = "0x75CCBD0", VA = "0x1875CE1D0", Slot = "7")]
		public EBEBDBMIBGL MCBOAKCIABG(Action<ArraySegment<float>> JMKAJHCEDCI)
		{
			return default(EBEBDBMIBGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75CE200", Offset = "0x75CCC00", VA = "0x1875CE200")]
		private EBEBDBMIBGL MCBOAKCIABG(int FBGCCBOHLPG, int HIKNFGLLODH, int POOAMDPEGHM, Action<ArraySegment<float>> JMKAJHCEDCI)
		{
			return default(EBEBDBMIBGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75CE130", Offset = "0x75CCB30", VA = "0x1875CE130", Slot = "8")]
		public void JEADHFHGBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75CE5C0", Offset = "0x75CCFC0", VA = "0x1875CE5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75CE9E0", Offset = "0x75CD3E0", VA = "0x1875CE9E0", Slot = "5")]
	public IReadOnlyList<IMBMLOIFLFG> MKKOIGLDNJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75CED00", Offset = "0x75CD700", VA = "0x1875CED00")]
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
