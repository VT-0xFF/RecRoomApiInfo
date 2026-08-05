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
		[Cpp2IlInjected.Address(RVA = "0x400200", Offset = "0x3FF400", VA = "0x180400200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x46F6C0", Offset = "0x46E8C0", VA = "0x18046F6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OCAIPIMEEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4001F0", Offset = "0x3FF3F0", VA = "0x1804001F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C7000", Offset = "0x9C6200", VA = "0x1809C7000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3861060", Offset = "0x3860260", VA = "0x183861060")]
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
		[Cpp2IlInjected.Address(RVA = "0x38618C0", Offset = "0x3860AC0", VA = "0x1838618C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3861A20", Offset = "0x3860C20", VA = "0x183861A20")]
	static PEJPFHPLIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3861930", Offset = "0x3860B30", VA = "0x183861930")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F02B0", Offset = "0x3EF4B0", VA = "0x1803F02B0")]
			public LNKKJPHHMCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3861440", Offset = "0x3860640", VA = "0x183861440")]
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
			[Cpp2IlInjected.Address(RVA = "0x3861070", Offset = "0x3860270", VA = "0x183861070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MBLNHDMHJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x494BD0", Offset = "0x493DD0", VA = "0x180494BD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x494AE0", Offset = "0x493CE0", VA = "0x180494AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BCKBKNLAFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x117D0C0", Offset = "0x117C2C0", VA = "0x18117D0C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38610F0", Offset = "0x38602F0", VA = "0x1838610F0", Slot = "7")]
		public BMHPPANEFME PGDCJOKFJBN(Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3861120", Offset = "0x3860320", VA = "0x183861120")]
		private BMHPPANEFME PGDCJOKFJBN(int NANJEHFBLNK, int NMJINOPLKJD, int GMIAOBOKCBA, Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3861090", Offset = "0x3860290", VA = "0x183861090", Slot = "8")]
		public void OMDEHIEFHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3861400", Offset = "0x3860600", VA = "0x183861400")]
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
		[Cpp2IlInjected.Address(RVA = "0x404E70", Offset = "0x404070", VA = "0x180404E70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38615C0", Offset = "0x38607C0", VA = "0x1838615C0", Slot = "5")]
	public IReadOnlyList<MIPJPBLEIDM> IJAKONPBODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3861860", Offset = "0x3860A60", VA = "0x183861860")]
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
