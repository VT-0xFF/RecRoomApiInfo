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
public interface OJLEIGHLEGP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NBIPGINPLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<EFJCOIIBMLD> LIMOPIBALOD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EFJCOIIBMLD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DGFFOJPABFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JJBNAJPHCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IJENDGAJIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJIMAJEFLIJ ENOJDEEMCLO(Action<ArraySegment<float>> NELMOECDPJP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BECMAHBCBLG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CJIMAJEFLIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LAJAOKBNHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IHGGDLBLNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0CE0", Offset = "0x2DAF4E0", VA = "0x182DB0CE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D588B0", Offset = "0x6D570B0", VA = "0x186D588B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B83AA0", Offset = "0x7B822A0", VA = "0x187B83AA0")]
	public CJIMAJEFLIJ(int LIGHDOHECOJ, int IBFLIHKGGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HMGJKNLNOAA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OJLEIGHLEGP CDBLFAPBJNI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NBIPGINPLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85CDE70", Offset = "0x85CC670", VA = "0x1885CDE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85CDEE0", Offset = "0x85CC6E0", VA = "0x1885CDEE0")]
	static HMGJKNLNOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85CDD80", Offset = "0x85CC580", VA = "0x1885CDD80")]
	public static IReadOnlyList<EFJCOIIBMLD> LIMOPIBALOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GKNJIKCDILB : OJLEIGHLEGP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FCNAJCIBPNO : EFJCOIIBMLD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KDCJOOECJNJ
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
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public KDCJOOECJNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85CDFD0", Offset = "0x85CC7D0", VA = "0x1885CDFD0")]
			internal void BFHIHKIPBCP(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice OJCGFDALBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DODGOGHOPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource INEKOHALMMN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DGFFOJPABFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x85CD960", Offset = "0x85CC160", VA = "0x1885CD960", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JJBNAJPHCAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA82330", Offset = "0xA80B30", VA = "0x180A82330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IJENDGAJIIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD6AE30", Offset = "0xD69630", VA = "0x180D6AE30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85CD930", Offset = "0x85CC130", VA = "0x1885CD930", Slot = "7")]
		public CJIMAJEFLIJ ENOJDEEMCLO(Action<ArraySegment<float>> NELMOECDPJP)
		{
			return default(CJIMAJEFLIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85CD570", Offset = "0x85CBD70", VA = "0x1885CD570")]
		private CJIMAJEFLIJ ENOJDEEMCLO(int LIGHDOHECOJ, int DOECDECMBII, int IBFLIHKGGBI, Action<ArraySegment<float>> NELMOECDPJP)
		{
			return default(CJIMAJEFLIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85CD4F0", Offset = "0x85CBCF0", VA = "0x1885CD4F0", Slot = "8")]
		public void BECMAHBCBLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85CD980", Offset = "0x85CC180", VA = "0x1885CD980")]
		public FCNAJCIBPNO(MMDevice OJCGFDALBBD, bool BHHCJKMHHEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FCNAJCIBPNO> IBOBFBBFDPP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NBIPGINPLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85CD9D0", Offset = "0x85CC1D0", VA = "0x1885CD9D0", Slot = "5")]
	public IReadOnlyList<EFJCOIIBMLD> LIMOPIBALOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85CDCF0", Offset = "0x85CC4F0", VA = "0x1885CDCF0")]
	public GKNJIKCDILB()
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
