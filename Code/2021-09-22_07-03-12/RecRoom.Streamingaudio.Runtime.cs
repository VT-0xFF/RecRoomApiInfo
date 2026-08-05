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
public interface GIGANMKEKEN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BJIPCLFGBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MIPJPBLEIDM> IJAKONPBODL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MIPJPBLEIDM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KENGPMDDCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MBLNHDMHJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BCKBKNLAFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BMHPPANEFME PGDCJOKFJBN(Action<ArraySegment<float>> AFLPGGJMPOE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMDEHIEFHBD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BMHPPANEFME
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GOHLOAHFFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5902D0", Offset = "0x58F0D0", VA = "0x1805902D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B7280", Offset = "0x5B6080", VA = "0x1805B7280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OCAIPIMEEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5902B0", Offset = "0x58F0B0", VA = "0x1805902B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xFC9BE0", Offset = "0xFC89E0", VA = "0x180FC9BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C65C20", Offset = "0x3C64A20", VA = "0x183C65C20")]
	public BMHPPANEFME(int NANJEHFBLNK, int GMIAOBOKCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PEJPFHPLIJP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GIGANMKEKEN ACLPIMGNEMD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BJIPCLFGBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3C66480", Offset = "0x3C65280", VA = "0x183C66480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C665E0", Offset = "0x3C653E0", VA = "0x183C665E0")]
	static PEJPFHPLIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C664F0", Offset = "0x3C652F0", VA = "0x183C664F0")]
	public static IReadOnlyList<MIPJPBLEIDM> IJAKONPBODL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OEDOEBFMAIL : GIGANMKEKEN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CKEGGDFPNAP : MIPJPBLEIDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LNKKJPHHMCH
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
			[Cpp2IlInjected.Address(RVA = "0x4189D0", Offset = "0x4177D0", VA = "0x1804189D0")]
			public LNKKJPHHMCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3C66000", Offset = "0x3C64E00", VA = "0x183C66000")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FCELFDANLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GPIFDGGPABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource FGEGJFOPLBN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KENGPMDDCML
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3C65C30", Offset = "0x3C64A30", VA = "0x183C65C30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MBLNHDMHJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x556D70", Offset = "0x555B70", VA = "0x180556D70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x636B00", Offset = "0x635900", VA = "0x180636B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BCKBKNLAFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7AA990", Offset = "0x7A9790", VA = "0x1807AA990", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C65CB0", Offset = "0x3C64AB0", VA = "0x183C65CB0", Slot = "7")]
		public BMHPPANEFME PGDCJOKFJBN(Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3C65CE0", Offset = "0x3C64AE0", VA = "0x183C65CE0")]
		private BMHPPANEFME PGDCJOKFJBN(int NANJEHFBLNK, int NMJINOPLKJD, int GMIAOBOKCBA, Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C65C50", Offset = "0x3C64A50", VA = "0x183C65C50", Slot = "8")]
		public void OMDEHIEFHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C65FC0", Offset = "0x3C64DC0", VA = "0x183C65FC0")]
		public CKEGGDFPNAP(MMDevice FCELFDANLGL, bool EBBFMHGMLKE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<CKEGGDFPNAP> PLGMBJLOCLO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BJIPCLFGBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x416F60", Offset = "0x415D60", VA = "0x180416F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C66180", Offset = "0x3C64F80", VA = "0x183C66180", Slot = "5")]
	public IReadOnlyList<MIPJPBLEIDM> IJAKONPBODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C66420", Offset = "0x3C65220", VA = "0x183C66420")]
	public OEDOEBFMAIL()
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
