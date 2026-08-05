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
public interface BJPNLNODPBM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EIPLLJCEOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IDLNJLEDNIB> LJMJOCCPFMH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IDLNJLEDNIB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string JGEMJBEIMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PIEAKEODEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NLJDGLPIHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LHFHALFFIMO MNKCMBENLLM(Action<ArraySegment<float>> PKPGAEOFIGD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NMMGOPBDKOD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LHFHALFFIMO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MDOBKEPCGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x695E20", Offset = "0x694C20", VA = "0x180695E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PPINKMKDCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8F0", Offset = "0x6CE6F0", VA = "0x1806CF8F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6CF900", Offset = "0x6CE700", VA = "0x1806CF900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6860", Offset = "0x5EB5660", VA = "0x185EB6860")]
	public LHFHALFFIMO(int NCACHHIKMFK, int PNAAEENHDLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EOGHJHEKBLB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BJPNLNODPBM ABLAIFJNIGI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EIPLLJCEOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6480", Offset = "0x5EB5280", VA = "0x185EB6480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6600", Offset = "0x5EB5400", VA = "0x185EB6600")]
	static EOGHJHEKBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6500", Offset = "0x5EB5300", VA = "0x185EB6500")]
	public static IReadOnlyList<IDLNJLEDNIB> LJMJOCCPFMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OHINIKABOJC : BJPNLNODPBM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MLHGHNCBMAO : IDLNJLEDNIB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JKAEALEBPII
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public JKAEALEBPII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5EB66D0", Offset = "0x5EB54D0", VA = "0x185EB66D0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice MIJBCCNENFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EOMPMCACFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource CJOADNMPLCA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JGEMJBEIMOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5EB6870", Offset = "0x5EB5670", VA = "0x185EB6870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PIEAKEODEBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x77EBA0", Offset = "0x77D9A0", VA = "0x18077EBA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x77EC20", Offset = "0x77DA20", VA = "0x18077EC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NLJDGLPIHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x78C640", Offset = "0x78B440", VA = "0x18078C640", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6C30", Offset = "0x5EB5A30", VA = "0x185EB6C30", Slot = "7")]
		public LHFHALFFIMO MNKCMBENLLM(Action<ArraySegment<float>> PKPGAEOFIGD)
		{
			return default(LHFHALFFIMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6890", Offset = "0x5EB5690", VA = "0x185EB6890")]
		private LHFHALFFIMO MNKCMBENLLM(int NCACHHIKMFK, int JAFLMPAEHIA, int PNAAEENHDLJ, Action<ArraySegment<float>> PKPGAEOFIGD)
		{
			return default(LHFHALFFIMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6C60", Offset = "0x5EB5A60", VA = "0x185EB6C60", Slot = "8")]
		public void NMMGOPBDKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6CE0", Offset = "0x5EB5AE0", VA = "0x185EB6CE0")]
		public MLHGHNCBMAO(MMDevice MIJBCCNENFB, bool GIEJFBIHCKC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MLHGHNCBMAO> LAOGBEBJBNA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EIPLLJCEOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6D30", Offset = "0x5EB5B30", VA = "0x185EB6D30", Slot = "5")]
	public IReadOnlyList<IDLNJLEDNIB> LJMJOCCPFMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7010", Offset = "0x5EB5E10", VA = "0x185EB7010")]
	public OHINIKABOJC()
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
