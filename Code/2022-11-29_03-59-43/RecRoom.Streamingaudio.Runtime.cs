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
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727990", VA = "0x180728D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PPINKMKDCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4760", VA = "0x1808B5B60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEC96C0", Offset = "0xEC82C0", VA = "0x180EC96C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x608CC70", Offset = "0x608B870", VA = "0x18608CC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x608C890", Offset = "0x608B490", VA = "0x18608C890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x608CA10", Offset = "0x608B610", VA = "0x18608CA10")]
	static EOGHJHEKBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x608C910", Offset = "0x608B510", VA = "0x18608C910")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public JKAEALEBPII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x608CAE0", Offset = "0x608B6E0", VA = "0x18608CAE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x608CC80", Offset = "0x608B880", VA = "0x18608CC80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PIEAKEODEBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766B80", VA = "0x180767F80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FD70", VA = "0x180731170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NLJDGLPIHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6B8C60", Offset = "0x6B7860", VA = "0x1806B8C60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x608D040", Offset = "0x608BC40", VA = "0x18608D040", Slot = "7")]
		public LHFHALFFIMO MNKCMBENLLM(Action<ArraySegment<float>> PKPGAEOFIGD)
		{
			return default(LHFHALFFIMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x608CCA0", Offset = "0x608B8A0", VA = "0x18608CCA0")]
		private LHFHALFFIMO MNKCMBENLLM(int NCACHHIKMFK, int JAFLMPAEHIA, int PNAAEENHDLJ, Action<ArraySegment<float>> PKPGAEOFIGD)
		{
			return default(LHFHALFFIMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x608D070", Offset = "0x608BC70", VA = "0x18608D070", Slot = "8")]
		public void NMMGOPBDKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x608D0F0", Offset = "0x608BCF0", VA = "0x18608D0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696C20", VA = "0x180698020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x608D140", Offset = "0x608BD40", VA = "0x18608D140", Slot = "5")]
	public IReadOnlyList<IDLNJLEDNIB> LJMJOCCPFMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x608D420", Offset = "0x608C020", VA = "0x18608D420")]
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
