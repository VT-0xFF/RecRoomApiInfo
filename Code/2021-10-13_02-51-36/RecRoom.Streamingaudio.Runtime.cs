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
public interface KFDMCJILALF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PLFHAJKAOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HPHKGBPFMKJ> KJPNHCAAOJM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HPHKGBPFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OLGNFAHJIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LGHHMDPCAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FCLBFOKICAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BNHOAPBCLKO CGPHDPNHBCO(Action<ArraySegment<float>> MCNIGODLGGL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MMIEBBDFFNH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BNHOAPBCLKO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HJPGDEILKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD40", Offset = "0x4DF140", VA = "0x1804DFD40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x502C70", Offset = "0x502070", VA = "0x180502C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OEPAKCFPOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD30", Offset = "0x4DF130", VA = "0x1804DFD30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x502C80", Offset = "0x502080", VA = "0x180502C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x40894C0", Offset = "0x40888C0", VA = "0x1840894C0")]
	public BNHOAPBCLKO(int NLINPMDKGAD, int BMILOCCLOAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AHOHIFHPNGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KFDMCJILALF JHKIBCKJPNH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PLFHAJKAOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x40892C0", Offset = "0x40886C0", VA = "0x1840892C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4089420", Offset = "0x4088820", VA = "0x184089420")]
	static AHOHIFHPNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4089330", Offset = "0x4088730", VA = "0x184089330")]
	public static IReadOnlyList<HPHKGBPFMKJ> KJPNHCAAOJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KOMGPABPOGC : KFDMCJILALF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KKDPEILEMFF : HPHKGBPFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MLIMDKMMIFF
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
			[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
			public MLIMDKMMIFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4089BA0", Offset = "0x4088FA0", VA = "0x184089BA0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice GAMPMBMNJHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JLKDPPOOFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HEEMLFKBPHI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OLGNFAHJIKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x40897E0", Offset = "0x4088BE0", VA = "0x1840897E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LGHHMDPCAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x518400", Offset = "0x517800", VA = "0x180518400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5185B0", Offset = "0x5179B0", VA = "0x1805185B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FCLBFOKICAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xBCBFD0", Offset = "0xBCB3D0", VA = "0x180BCBFD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x40894D0", Offset = "0x40888D0", VA = "0x1840894D0", Slot = "7")]
		public BNHOAPBCLKO CGPHDPNHBCO(Action<ArraySegment<float>> MCNIGODLGGL)
		{
			return default(BNHOAPBCLKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4089500", Offset = "0x4088900", VA = "0x184089500")]
		private BNHOAPBCLKO CGPHDPNHBCO(int NLINPMDKGAD, int FELOFMNKLGJ, int BMILOCCLOAO, Action<ArraySegment<float>> MCNIGODLGGL)
		{
			return default(BNHOAPBCLKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4089800", Offset = "0x4088C00", VA = "0x184089800", Slot = "8")]
		public void MMIEBBDFFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4089860", Offset = "0x4088C60", VA = "0x184089860")]
		public KKDPEILEMFF(MMDevice GAMPMBMNJHO, bool PAFNONOCAFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KKDPEILEMFF> BLLOFBECMNH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PLFHAJKAOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x44EB90", Offset = "0x44DF90", VA = "0x18044EB90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x40898A0", Offset = "0x4088CA0", VA = "0x1840898A0", Slot = "5")]
	public IReadOnlyList<HPHKGBPFMKJ> KJPNHCAAOJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4089B40", Offset = "0x4088F40", VA = "0x184089B40")]
	public KOMGPABPOGC()
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
