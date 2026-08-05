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
public class IDLNADPAJMP : DCMPMJJBLBE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class FBFDBLGHAHB : DGIDHINBHFE
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class ILLKLMOONCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public ILLKLMOONCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6F6F490", Offset = "0x6F6E690", VA = "0x186F6F490")]
			internal void JCHCEIGEIHM(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice JMGIJDELLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture EPOPHMEHBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource LKAIMELKKCG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string POPEMGEEHOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6F6EC80", Offset = "0x6F6DE80", VA = "0x186F6EC80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NCNOEMKOIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7EB9E0", Offset = "0x7EABE0", VA = "0x1807EB9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NIPMIMKCHIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7ECEF0", Offset = "0x7EC0F0", VA = "0x1807ECEF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F6ED20", Offset = "0x6F6DF20", VA = "0x186F6ED20", Slot = "7")]
		public LAAKALGJNOC EFJEIELFLII(Action<ArraySegment<float>> JHGMNDBGFFP)
		{
			return default(LAAKALGJNOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F6ED50", Offset = "0x6F6DF50", VA = "0x186F6ED50")]
		private LAAKALGJNOC EFJEIELFLII(int JAEGKDFGMFD, int HOKBPKEGIPJ, int PFIEPNKBFHI, Action<ArraySegment<float>> JHGMNDBGFFP)
		{
			return default(LAAKALGJNOC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6ECA0", Offset = "0x6F6DEA0", VA = "0x186F6ECA0", Slot = "8")]
		public void ALCKCOJMFIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F0F0", Offset = "0x6F6E2F0", VA = "0x186F6F0F0")]
		public FBFDBLGHAHB(MMDevice JMGIJDELLCP, bool MKMKNBKAAKI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<FBFDBLGHAHB> HJIHEGFLKMN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KHKEICNEFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F140", Offset = "0x6F6E340", VA = "0x186F6F140", Slot = "5")]
	public IReadOnlyList<DGIDHINBHFE> BNEPDBMGDPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F410", Offset = "0x6F6E610", VA = "0x186F6F410")]
	public IDLNADPAJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DCMPMJJBLBE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KHKEICNEFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DGIDHINBHFE> BNEPDBMGDPD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DGIDHINBHFE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string POPEMGEEHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NCNOEMKOIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NIPMIMKCHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LAAKALGJNOC EFJEIELFLII(Action<ArraySegment<float>> JHGMNDBGFFP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ALCKCOJMFIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LAAKALGJNOC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KOMAHFIMMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PPIALODJNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2454AF0", Offset = "0x2453CF0", VA = "0x182454AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F620", Offset = "0x6F6E820", VA = "0x186F6F620")]
	public LAAKALGJNOC(int JAEGKDFGMFD, int PFIEPNKBFHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EIJOPFPMKJD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static DCMPMJJBLBE FHLHCPACODK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool KHKEICNEFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EB30", Offset = "0x6F6DD30", VA = "0x186F6EB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EBB0", Offset = "0x6F6DDB0", VA = "0x186F6EBB0")]
	static EIJOPFPMKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EA40", Offset = "0x6F6DC40", VA = "0x186F6EA40")]
	public static IReadOnlyList<DGIDHINBHFE> BNEPDBMGDPD()
	{
		return null;
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
