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
public interface DEDJCPBLENF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IJFMOHCOHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<FEFCHPPKKJO> OEFNAKNBOIA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FEFCHPPKKJO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GHINAKGEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FIHODPEAEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ABIPOACKOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HKHFDDOICFL NNPIEIHGJNH(Action<ArraySegment<float>> DKDPAFJDNNF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EIMCKHDCJHB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HKHFDDOICFL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OEEMEBFDAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MECNIDFMLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ED10", Offset = "0x2B4D910", VA = "0x182B4ED10")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67DD1D0", Offset = "0x67DBDD0", VA = "0x1867DD1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74FFFD0", Offset = "0x74FEBD0", VA = "0x1874FFFD0")]
	public HKHFDDOICFL(int FNEKNMAENAD, int JFLDOEHJBIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HNNLNDHCKGI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DEDJCPBLENF OBDEMGIJMBP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IJFMOHCOHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F07CD0", Offset = "0x7F068D0", VA = "0x187F07CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F07E30", Offset = "0x7F06A30", VA = "0x187F07E30")]
	static HNNLNDHCKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F07D40", Offset = "0x7F06940", VA = "0x187F07D40")]
	public static IReadOnlyList<FEFCHPPKKJO> OEFNAKNBOIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GFIANOPJCGP : DEDJCPBLENF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JFGNHIAPEGN : FEFCHPPKKJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OJLCAODJLAC
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
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public OJLCAODJLAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F08400", Offset = "0x7F07000", VA = "0x187F08400")]
			internal void FJEIOAIBDGL(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HEJOAANLAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JMGDKHEPIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource PMLFEGGDIOA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GHINAKGEMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7F07FA0", Offset = "0x7F06BA0", VA = "0x187F07FA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FIHODPEAEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC76630", Offset = "0xC75230", VA = "0x180C76630", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC764F0", Offset = "0xC750F0", VA = "0x180C764F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ABIPOACKOAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC1F640", Offset = "0xC1E240", VA = "0x180C1F640", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F08380", Offset = "0x7F06F80", VA = "0x187F08380", Slot = "7")]
		public HKHFDDOICFL NNPIEIHGJNH(Action<ArraySegment<float>> DKDPAFJDNNF)
		{
			return default(HKHFDDOICFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F07FC0", Offset = "0x7F06BC0", VA = "0x187F07FC0")]
		private HKHFDDOICFL NNPIEIHGJNH(int FNEKNMAENAD, int OGGKDFPKMPB, int JFLDOEHJBIK, Action<ArraySegment<float>> DKDPAFJDNNF)
		{
			return default(HKHFDDOICFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F07F20", Offset = "0x7F06B20", VA = "0x187F07F20", Slot = "8")]
		public void EIMCKHDCJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F083B0", Offset = "0x7F06FB0", VA = "0x187F083B0")]
		public JFGNHIAPEGN(MMDevice HEJOAANLAHB, bool IEEADMIMLCL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JFGNHIAPEGN> AEBPGMKMEHF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IJFMOHCOHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F07920", Offset = "0x7F06520", VA = "0x187F07920", Slot = "5")]
	public IReadOnlyList<FEFCHPPKKJO> OEFNAKNBOIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F07C40", Offset = "0x7F06840", VA = "0x187F07C40")]
	public GFIANOPJCGP()
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
