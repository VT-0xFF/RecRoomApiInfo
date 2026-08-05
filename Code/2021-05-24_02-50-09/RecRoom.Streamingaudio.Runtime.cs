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
		[Cpp2IlInjected.Address(RVA = "0x3FA5B0", Offset = "0x3F97B0", VA = "0x1803FA5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3FA570", Offset = "0x3F9770", VA = "0x1803FA570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OCAIPIMEEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2A0", Offset = "0x4BA4A0", VA = "0x1804BB2A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8CC0", Offset = "0x7F7EC0", VA = "0x1807F8CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3603440", Offset = "0x3602640", VA = "0x183603440")]
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
		[Cpp2IlInjected.Address(RVA = "0x3603CA0", Offset = "0x3602EA0", VA = "0x183603CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3603E00", Offset = "0x3603000", VA = "0x183603E00")]
	static PEJPFHPLIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3603D10", Offset = "0x3602F10", VA = "0x183603D10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E0B10", Offset = "0x3DFD10", VA = "0x1803E0B10")]
			public LNKKJPHHMCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3603820", Offset = "0x3602A20", VA = "0x183603820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3603450", Offset = "0x3602650", VA = "0x183603450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MBLNHDMHJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x603AC0", Offset = "0x602CC0", VA = "0x180603AC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x618D70", Offset = "0x617F70", VA = "0x180618D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BCKBKNLAFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC3A1D0", Offset = "0xC393D0", VA = "0x180C3A1D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x36034D0", Offset = "0x36026D0", VA = "0x1836034D0", Slot = "7")]
		public BMHPPANEFME PGDCJOKFJBN(Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3603500", Offset = "0x3602700", VA = "0x183603500")]
		private BMHPPANEFME PGDCJOKFJBN(int NANJEHFBLNK, int NMJINOPLKJD, int GMIAOBOKCBA, Action<ArraySegment<float>> AFLPGGJMPOE)
		{
			return default(BMHPPANEFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3603470", Offset = "0x3602670", VA = "0x183603470", Slot = "8")]
		public void OMDEHIEFHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x36037E0", Offset = "0x36029E0", VA = "0x1836037E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DA010", Offset = "0x3D9210", VA = "0x1803DA010", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36039A0", Offset = "0x3602BA0", VA = "0x1836039A0", Slot = "5")]
	public IReadOnlyList<MIPJPBLEIDM> IJAKONPBODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3603C40", Offset = "0x3602E40", VA = "0x183603C40")]
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
