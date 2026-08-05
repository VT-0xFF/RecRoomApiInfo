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
public interface JHOLGLODDGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OAIDKHJLCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GHNMJJBGDME> IDCHONHCMMP();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GHNMJJBGDME
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BJGHKOAJBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MNDHFMLBJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FHCOEPJJDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AHOEEGGNFMB KGFCENPAMOL(Action<ArraySegment<float>> CMMPHMKBCDC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLHFIKHKBBL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AHOEEGGNFMB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KPAIJHIPNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KMCALFEALNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2335DF0", Offset = "0x2334FF0", VA = "0x182335DF0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5587230", Offset = "0x5586430", VA = "0x185587230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69F8CB0", Offset = "0x69F7EB0", VA = "0x1869F8CB0")]
	public AHOEEGGNFMB(int KFHHDLLLOOA, int IFIPOMPOFIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAHIDCPGDJM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JHOLGLODDGH JMOPCLGEBFB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OAIDKHJLCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69F96C0", Offset = "0x69F88C0", VA = "0x1869F96C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69F9820", Offset = "0x69F8A20", VA = "0x1869F9820")]
	static NAHIDCPGDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69F9730", Offset = "0x69F8930", VA = "0x1869F9730")]
	public static IReadOnlyList<GHNMJJBGDME> IDCHONHCMMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IPFGOCAJJGK : JHOLGLODDGH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EFOLIAEOCDJ : GHNMJJBGDME
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GJCJLHJKKDJ
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
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public GJCJLHJKKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69F91A0", Offset = "0x69F83A0", VA = "0x1869F91A0")]
			internal void IDANBJJLLIP(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FLECOOMIJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MIINGCNJMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NOPPEEINMBP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BJGHKOAJBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x69F8CC0", Offset = "0x69F7EC0", VA = "0x1869F8CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MNDHFMLBJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9EA2D0", Offset = "0x9E94D0", VA = "0x1809EA2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FHCOEPJJDMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCFDCF0", Offset = "0xCFCEF0", VA = "0x180CFDCF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69F8CE0", Offset = "0x69F7EE0", VA = "0x1869F8CE0", Slot = "7")]
		public AHOEEGGNFMB KGFCENPAMOL(Action<ArraySegment<float>> CMMPHMKBCDC)
		{
			return default(AHOEEGGNFMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69F8D10", Offset = "0x69F7F10", VA = "0x1869F8D10")]
		private AHOEEGGNFMB KGFCENPAMOL(int KFHHDLLLOOA, int JJLOHCGNPCB, int IFIPOMPOFIN, Action<ArraySegment<float>> CMMPHMKBCDC)
		{
			return default(AHOEEGGNFMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69F90D0", Offset = "0x69F82D0", VA = "0x1869F90D0", Slot = "8")]
		public void LLHFIKHKBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69F9150", Offset = "0x69F8350", VA = "0x1869F9150")]
		public EFOLIAEOCDJ(MMDevice FLECOOMIJPB, bool CMGPNMBGINP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<EFOLIAEOCDJ> HPMMGHLILHO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OAIDKHJLCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69F9320", Offset = "0x69F8520", VA = "0x1869F9320", Slot = "5")]
	public IReadOnlyList<GHNMJJBGDME> IDCHONHCMMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69F9630", Offset = "0x69F8830", VA = "0x1869F9630")]
	public IPFGOCAJJGK()
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
