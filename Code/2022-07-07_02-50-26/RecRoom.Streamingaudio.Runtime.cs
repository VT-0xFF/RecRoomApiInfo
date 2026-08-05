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
public interface JDECDBJHNGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DNAAHDBBHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GFNMMGJHGGM> OOMJBKPOLJI();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GFNMMGJHGGM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GOKLOLDMOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ABHCDLBDDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IFBPEFBBFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OGJJHEBBKDJ CCDIOJEOINA(Action<ArraySegment<float>> JNJKIKIBHIN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDBNHEJMMMG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OGJJHEBBKDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BFPHHKODPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x849200", Offset = "0x848400", VA = "0x180849200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C37C0", Offset = "0x8C29C0", VA = "0x1808C37C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LDLJOMBIHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8491E0", Offset = "0x8483E0", VA = "0x1808491E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89CFD0", Offset = "0x89C1D0", VA = "0x18089CFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51EE600", Offset = "0x51ED800", VA = "0x1851EE600")]
	public OGJJHEBBKDJ(int BJNIEDHODHA, int PLLAHMHCKEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AIFHDJEBGGC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JDECDBJHNGH BEDDPMBFIPE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool DNAAHDBBHBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x51EDB00", Offset = "0x51ECD00", VA = "0x1851EDB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x51EDC60", Offset = "0x51ECE60", VA = "0x1851EDC60")]
	static AIFHDJEBGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x51EDB70", Offset = "0x51ECD70", VA = "0x1851EDB70")]
	public static IReadOnlyList<GFNMMGJHGGM> OOMJBKPOLJI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CGBOINIIFGO : JDECDBJHNGH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KFOHODPDGID : GFNMMGJHGGM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KDFMACOAPAE
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
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
			public KDFMACOAPAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x51EE020", Offset = "0x51ED220", VA = "0x1851EE020")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice AKFGGPAAKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture IGLABLBHIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JLCGPFOHCAL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GOKLOLDMOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x51EE510", Offset = "0x51ED710", VA = "0x1851EE510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ABHCDLBDDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x60B990", Offset = "0x60AB90", VA = "0x18060B990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9D8E80", Offset = "0x9D8080", VA = "0x1809D8E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IFBPEFBBFMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6A34F0", Offset = "0x6A26F0", VA = "0x1806A34F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51EE1A0", Offset = "0x51ED3A0", VA = "0x1851EE1A0", Slot = "7")]
		public OGJJHEBBKDJ CCDIOJEOINA(Action<ArraySegment<float>> JNJKIKIBHIN)
		{
			return default(OGJJHEBBKDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x51EE1D0", Offset = "0x51ED3D0", VA = "0x1851EE1D0")]
		private OGJJHEBBKDJ CCDIOJEOINA(int BJNIEDHODHA, int JMFPPMOMJFK, int PLLAHMHCKEP, Action<ArraySegment<float>> JNJKIKIBHIN)
		{
			return default(OGJJHEBBKDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x51EE530", Offset = "0x51ED730", VA = "0x1851EE530", Slot = "8")]
		public void MDBNHEJMMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51EE5B0", Offset = "0x51ED7B0", VA = "0x1851EE5B0")]
		public KFOHODPDGID(MMDevice AKFGGPAAKDL, bool IDBGLMHEGKM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KFOHODPDGID> FMJPOBEBPDO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DNAAHDBBHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x58AFE0", Offset = "0x58A1E0", VA = "0x18058AFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x51EDD10", Offset = "0x51ECF10", VA = "0x1851EDD10", Slot = "5")]
	public IReadOnlyList<GFNMMGJHGGM> OOMJBKPOLJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x51EDFB0", Offset = "0x51ED1B0", VA = "0x1851EDFB0")]
	public CGBOINIIFGO()
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
