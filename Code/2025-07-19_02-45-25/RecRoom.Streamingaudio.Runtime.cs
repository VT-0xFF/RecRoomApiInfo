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
public interface BOKLKKEHKPG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NKBKAMMACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GEGFFGBHPEH> KOCOHHJGMBG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GEGFFGBHPEH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FAAHMEOMJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JLOGEBPOMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OAGHJGBLIIE KJLLCNOAKBE(Action<ArraySegment<float>> HCEFPMMOBCM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCHHHPLGCPG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OAGHJGBLIIE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GKFPNKPPELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MKMODEOHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x314D220", Offset = "0x314C220", VA = "0x18314D220")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EC13E0", Offset = "0x6EC03E0", VA = "0x186EC13E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81D2D10", Offset = "0x81D1D10", VA = "0x1881D2D10")]
	public OAGHJGBLIIE(int AELBFPLMDBC, int CNKKHLMNAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PKJOEHMBPND
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BOKLKKEHKPG NIPENPILDOA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NKBKAMMACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB8E0", Offset = "0x8CEA8E0", VA = "0x188CEB8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8CEB960", Offset = "0x8CEA960", VA = "0x188CEB960")]
	static PKJOEHMBPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8CEB7F0", Offset = "0x8CEA7F0", VA = "0x188CEB7F0")]
	public static IReadOnlyList<GEGFFGBHPEH> KOCOHHJGMBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OGEKPBMAEIC : BOKLKKEHKPG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IFGCICDFDNB : GEGFFGBHPEH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ICJNMNNHGEK
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
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public ICJNMNNHGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8CEADF0", Offset = "0x8CE9DF0", VA = "0x188CEADF0")]
			internal void CKGFKPBHEBO(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FNHALEBDDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MFJPLELACMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EIDKHFKGEMN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MDMHNCCIHNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8CEAF70", Offset = "0x8CE9F70", VA = "0x188CEAF70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FAAHMEOMJAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JLOGEBPOMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEAC720", Offset = "0xEAB720", VA = "0x180EAC720", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB3D0", Offset = "0x8CEA3D0", VA = "0x188CEB3D0", Slot = "7")]
		public OAGHJGBLIIE KJLLCNOAKBE(Action<ArraySegment<float>> HCEFPMMOBCM)
		{
			return default(OAGHJGBLIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB010", Offset = "0x8CEA010", VA = "0x188CEB010")]
		private OAGHJGBLIIE KJLLCNOAKBE(int AELBFPLMDBC, int FELGFDPDCKP, int CNKKHLMNAKG, Action<ArraySegment<float>> HCEFPMMOBCM)
		{
			return default(OAGHJGBLIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAF90", Offset = "0x8CE9F90", VA = "0x188CEAF90", Slot = "8")]
		public void BCHHHPLGCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB400", Offset = "0x8CEA400", VA = "0x188CEB400")]
		public IFGCICDFDNB(MMDevice FNHALEBDDGM, bool PKNKAAFIBAI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<IFGCICDFDNB> NFJCKEEJJFG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NKBKAMMACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8CEB450", Offset = "0x8CEA450", VA = "0x188CEB450", Slot = "5")]
	public IReadOnlyList<GEGFFGBHPEH> KOCOHHJGMBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8CEB760", Offset = "0x8CEA760", VA = "0x188CEB760")]
	public OGEKPBMAEIC()
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
