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
public interface NJNAGKCJIIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AGNJFNAHCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<ABNOPDBGADB> MFADLCKDIPO();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ABNOPDBGADB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HMLKANEGOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MNOKOFNBHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LENDBKKDGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HLLPDGKGPLN LAKHHCGDFGF(Action<ArraySegment<float>> POJIJEGMINL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOMGLIHDLFC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HLLPDGKGPLN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LPDPKDEIEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71AFF0", Offset = "0x7195F0", VA = "0x18071AFF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x718B00", Offset = "0x717100", VA = "0x180718B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MOFOHEJKPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8E0", Offset = "0xA1CEE0", VA = "0x180A1E8E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA76FF0", Offset = "0xA755F0", VA = "0x180A76FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x32360A0", Offset = "0x32346A0", VA = "0x1832360A0")]
	public HLLPDGKGPLN(int APKADBJNIFB, int ABKBKHDGBLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BCMNHKJLNPA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NJNAGKCJIIN FEGLHDDDLIF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AGNJFNAHCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3235B80", Offset = "0x3234180", VA = "0x183235B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3235CE0", Offset = "0x32342E0", VA = "0x183235CE0")]
	static BCMNHKJLNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3235BF0", Offset = "0x32341F0", VA = "0x183235BF0")]
	public static IReadOnlyList<ABNOPDBGADB> MFADLCKDIPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FEMHIPOGEAG : NJNAGKCJIIN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PDCPEODDIMN : ABNOPDBGADB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AGNLGHOLCBE
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
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public AGNLGHOLCBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3235A00", Offset = "0x3234000", VA = "0x183235A00")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice OOLMACNPCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GALMCDKBCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NLLAELHIBAL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HMLKANEGOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x32360B0", Offset = "0x32346B0", VA = "0x1832360B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MNOKOFNBHOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6B7390", Offset = "0x6B5990", VA = "0x1806B7390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x97B0A0", Offset = "0x9796A0", VA = "0x18097B0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LENDBKKDGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8C4790", Offset = "0x8C2D90", VA = "0x1808C4790", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3236150", Offset = "0x3234750", VA = "0x183236150", Slot = "7")]
		public HLLPDGKGPLN LAKHHCGDFGF(Action<ArraySegment<float>> POJIJEGMINL)
		{
			return default(HLLPDGKGPLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3236180", Offset = "0x3234780", VA = "0x183236180")]
		private HLLPDGKGPLN LAKHHCGDFGF(int APKADBJNIFB, int LIINNEHFOEM, int ABKBKHDGBLB, Action<ArraySegment<float>> POJIJEGMINL)
		{
			return default(HLLPDGKGPLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x32360D0", Offset = "0x32346D0", VA = "0x1832360D0", Slot = "8")]
		public void IOMGLIHDLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x32364C0", Offset = "0x3234AC0", VA = "0x1832364C0")]
		public PDCPEODDIMN(MMDevice OOLMACNPCCO, bool NJEDBPAEIGD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<PDCPEODDIMN> ADKCBAGKLBH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AGNJFNAHCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x50DF80", Offset = "0x50C580", VA = "0x18050DF80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3235D90", Offset = "0x3234390", VA = "0x183235D90", Slot = "5")]
	public IReadOnlyList<ABNOPDBGADB> MFADLCKDIPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3236030", Offset = "0x3234630", VA = "0x183236030")]
	public FEMHIPOGEAG()
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
