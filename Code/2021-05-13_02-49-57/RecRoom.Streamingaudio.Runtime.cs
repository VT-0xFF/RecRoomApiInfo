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
		[Cpp2IlInjected.Address(RVA = "0x4676F0", Offset = "0x466AF0", VA = "0x1804676F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x408EE0", Offset = "0x4082E0", VA = "0x180408EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OCAIPIMEEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4676E0", Offset = "0x466AE0", VA = "0x1804676E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77D090", Offset = "0x77C490", VA = "0x18077D090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x35D1360", Offset = "0x35D0760", VA = "0x1835D1360")]
	public BMHPPANEFME(int sampleRate, int channels)
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
		[Cpp2IlInjected.Address(RVA = "0x35D1BC0", Offset = "0x35D0FC0", VA = "0x1835D1BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35D1D20", Offset = "0x35D1120", VA = "0x1835D1D20")]
	static PEJPFHPLIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x35D1C30", Offset = "0x35D1030", VA = "0x1835D1C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
			public LNKKJPHHMCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x35D1740", Offset = "0x35D0B40", VA = "0x1835D1740")]
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
			[Cpp2IlInjected.Address(RVA = "0x35D1370", Offset = "0x35D0770", VA = "0x1835D1370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MBLNHDMHJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4C3970", Offset = "0x4C2D70", VA = "0x1804C3970", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x4C3930", Offset = "0x4C2D30", VA = "0x1804C3930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BCKBKNLAFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA8F050", Offset = "0xA8E450", VA = "0x180A8F050", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x35D13F0", Offset = "0x35D07F0", VA = "0x1835D13F0", Slot = "7")]
		public BMHPPANEFME PGDCJOKFJBN(Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x35D1420", Offset = "0x35D0820", VA = "0x1835D1420")]
		private BMHPPANEFME PGDCJOKFJBN(int NANJEHFBLNK, int NMJINOPLKJD, int GMIAOBOKCBA, Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x35D1390", Offset = "0x35D0790", VA = "0x1835D1390", Slot = "8")]
		public void OMDEHIEFHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x35D1700", Offset = "0x35D0B00", VA = "0x1835D1700")]
		public CKEGGDFPNAP(MMDevice device, bool isDefault)
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
		[Cpp2IlInjected.Address(RVA = "0x402F60", Offset = "0x402360", VA = "0x180402F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x35D18C0", Offset = "0x35D0CC0", VA = "0x1835D18C0", Slot = "5")]
	public IReadOnlyList<MIPJPBLEIDM> IJAKONPBODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x35D1B60", Offset = "0x35D0F60", VA = "0x1835D1B60")]
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
