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
public interface NKBCIADHGGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KLNKFFINGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OFHIIOPMCGB> JLELIBMEICG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OFHIIOPMCGB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NDGMEGMCDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EJHLMLBELPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CFICMPHDPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EDNFCDFAJEE JIPGGDLGNBN(Action<ArraySegment<float>> AIBILCAOCLG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDMMKGIHEBI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EDNFCDFAJEE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KILJFKKIILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EEHKBAPALDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5220E10", Offset = "0x5220210", VA = "0x185220E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63855E0", Offset = "0x63849E0", VA = "0x1863855E0")]
	public EDNFCDFAJEE(int JNFKMHIGCOM, int HNJGBHMAGGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ODJCIEKFNHD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NKBCIADHGGO BCDOOCCLCDD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KLNKFFINGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6385B20", Offset = "0x6384F20", VA = "0x186385B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6385C90", Offset = "0x6385090", VA = "0x186385C90")]
	static ODJCIEKFNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6385BA0", Offset = "0x6384FA0", VA = "0x186385BA0")]
	public static IReadOnlyList<OFHIIOPMCGB> JLELIBMEICG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ICKCAAJOHDJ : NKBCIADHGGO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OLOABMFBANB : OFHIIOPMCGB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GMJCMLMCEHJ
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
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public GMJCMLMCEHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x63855F0", Offset = "0x63849F0", VA = "0x1863855F0")]
			internal void LOCICENPBDB(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice AAHHACFHNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JEHNOCKMKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JAJALEAJCDC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NDGMEGMCDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6385D80", Offset = "0x6385180", VA = "0x186385D80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EJHLMLBELPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7E06E0", Offset = "0x7DFAE0", VA = "0x1807E06E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8520D0", Offset = "0x8514D0", VA = "0x1808520D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CFICMPHDPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB642A0", Offset = "0xB636A0", VA = "0x180B642A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6385DA0", Offset = "0x63851A0", VA = "0x186385DA0", Slot = "7")]
		public EDNFCDFAJEE JIPGGDLGNBN(Action<ArraySegment<float>> AIBILCAOCLG)
		{
			return default(EDNFCDFAJEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6385DD0", Offset = "0x63851D0", VA = "0x186385DD0")]
		private EDNFCDFAJEE JIPGGDLGNBN(int JNFKMHIGCOM, int NFFLCAOLBIM, int HNJGBHMAGGB, Action<ArraySegment<float>> AIBILCAOCLG)
		{
			return default(EDNFCDFAJEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6386190", Offset = "0x6385590", VA = "0x186386190", Slot = "8")]
		public void MDMMKGIHEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6386210", Offset = "0x6385610", VA = "0x186386210")]
		public OLOABMFBANB(MMDevice AAHHACFHNFD, bool IOPPNAJAJPK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OLOABMFBANB> JJNCLNGEBDI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KLNKFFINGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6385770", Offset = "0x6384B70", VA = "0x186385770", Slot = "5")]
	public IReadOnlyList<OFHIIOPMCGB> JLELIBMEICG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6385A90", Offset = "0x6384E90", VA = "0x186385A90")]
	public ICKCAAJOHDJ()
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
