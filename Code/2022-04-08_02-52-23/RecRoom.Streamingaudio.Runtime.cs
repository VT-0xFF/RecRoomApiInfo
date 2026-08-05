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
public interface HDMOBCFMCKF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LFFABPBLFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IFHNFBNNDOM> PCOBBMNKPCL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IFHNFBNNDOM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string PKCJAJGPNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MCJKEBONOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JBIKFNIKAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MFOJBPFJIKK NCIDFPBMAAG(Action<ArraySegment<float>> IFOGDLBNNEF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKOHJMHBBDG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MFOJBPFJIKK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JLJOIOPDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C63C0", Offset = "0x5C51C0", VA = "0x1805C63C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB0E550", Offset = "0xB0D350", VA = "0x180B0E550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EGFBOKAHBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B30", Offset = "0x9C1930", VA = "0x1809C2B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAD1B00", Offset = "0xAD0900", VA = "0x180AD1B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x16E4740", Offset = "0x16E3540", VA = "0x1816E4740")]
	public MFOJBPFJIKK(int NHKOMEEEOAP, int IHAIMBPEOIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IAMKJLCIIBK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HDMOBCFMCKF NAAMFCAPDGH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool LFFABPBLFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x16E40D0", Offset = "0x16E2ED0", VA = "0x1816E40D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x16E4230", Offset = "0x16E3030", VA = "0x1816E4230")]
	static IAMKJLCIIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x16E4140", Offset = "0x16E2F40", VA = "0x1816E4140")]
	public static IReadOnlyList<IFHNFBNNDOM> PCOBBMNKPCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OJIDENHDAMM : HDMOBCFMCKF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KLFKMJFCCDP : IFHNFBNNDOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HIKPOEABMJP
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
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public HIKPOEABMJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x16E3F50", Offset = "0x16E2D50", VA = "0x1816E3F50")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FBHMGMDOHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LMFNBEMBHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MHHPGFMAEPC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PKCJAJGPNCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x16E46D0", Offset = "0x16E34D0", VA = "0x1816E46D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MCJKEBONOED
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x62C620", Offset = "0x62B420", VA = "0x18062C620", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76D2B0", VA = "0x18076E4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JBIKFNIKAFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5A1B70", Offset = "0x5A0970", VA = "0x1805A1B70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16E4360", Offset = "0x16E3160", VA = "0x1816E4360", Slot = "7")]
		public MFOJBPFJIKK NCIDFPBMAAG(Action<ArraySegment<float>> IFOGDLBNNEF)
		{
			return default(MFOJBPFJIKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x16E4390", Offset = "0x16E3190", VA = "0x1816E4390")]
		private MFOJBPFJIKK NCIDFPBMAAG(int NHKOMEEEOAP, int HPJPCCEKCIM, int IHAIMBPEOIB, Action<ArraySegment<float>> IFOGDLBNNEF)
		{
			return default(MFOJBPFJIKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x16E42E0", Offset = "0x16E30E0", VA = "0x1816E42E0", Slot = "8")]
		public void EKOHJMHBBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x16E46F0", Offset = "0x16E34F0", VA = "0x1816E46F0")]
		public KLFKMJFCCDP(MMDevice FBHMGMDOHFK, bool FMLFNLLKOHP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KLFKMJFCCDP> OAAEMCJMONP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LFFABPBLFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x522FE0", Offset = "0x521DE0", VA = "0x180522FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x16E4750", Offset = "0x16E3550", VA = "0x1816E4750", Slot = "5")]
	public IReadOnlyList<IFHNFBNNDOM> PCOBBMNKPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x16E49F0", Offset = "0x16E37F0", VA = "0x1816E49F0")]
	public OJIDENHDAMM()
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
