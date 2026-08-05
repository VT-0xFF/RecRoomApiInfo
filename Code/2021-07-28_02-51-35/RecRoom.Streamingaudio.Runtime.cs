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
		[Cpp2IlInjected.Address(RVA = "0x547350", Offset = "0x546150", VA = "0x180547350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x547370", Offset = "0x546170", VA = "0x180547370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OCAIPIMEEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C30B0", Offset = "0x7C1EB0", VA = "0x1807C30B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3100", Offset = "0x7C1F00", VA = "0x1807C3100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x12899B0", Offset = "0x12887B0", VA = "0x1812899B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x128A210", Offset = "0x1289010", VA = "0x18128A210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x128A370", Offset = "0x1289170", VA = "0x18128A370")]
	static PEJPFHPLIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x128A280", Offset = "0x1289080", VA = "0x18128A280")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6370", Offset = "0x3F5170", VA = "0x1803F6370")]
			public LNKKJPHHMCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1289D90", Offset = "0x1288B90", VA = "0x181289D90")]
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
			[Cpp2IlInjected.Address(RVA = "0x12899C0", Offset = "0x12887C0", VA = "0x1812899C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MBLNHDMHJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4D6D90", Offset = "0x4D5B90", VA = "0x1804D6D90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x4D6DE0", Offset = "0x4D5BE0", VA = "0x1804D6DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BCKBKNLAFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x575C50", Offset = "0x574A50", VA = "0x180575C50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1289A40", Offset = "0x1288840", VA = "0x181289A40", Slot = "7")]
		public BMHPPANEFME PGDCJOKFJBN(Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1289A70", Offset = "0x1288870", VA = "0x181289A70")]
		private BMHPPANEFME PGDCJOKFJBN(int NANJEHFBLNK, int NMJINOPLKJD, int GMIAOBOKCBA, Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x12899E0", Offset = "0x12887E0", VA = "0x1812899E0", Slot = "8")]
		public void OMDEHIEFHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1289D50", Offset = "0x1288B50", VA = "0x181289D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x4086A0", Offset = "0x4074A0", VA = "0x1804086A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1289F10", Offset = "0x1288D10", VA = "0x181289F10", Slot = "5")]
	public IReadOnlyList<MIPJPBLEIDM> IJAKONPBODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x128A1B0", Offset = "0x1288FB0", VA = "0x18128A1B0")]
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
