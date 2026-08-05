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
public interface CNFGCKINEOF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FGIGENACLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<AKIDNFAPJGC> KANFJJKKHGA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AKIDNFAPJGC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HGHLBCLFGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CJIFHILHFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DANKELKBOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JJNPMEAOEDG HJJKLGKNLDJ(Action<ArraySegment<float>> ONAFALABHKI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPOACDKBGCC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JJNPMEAOEDG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DPBKOGJOFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HKMIFDJHAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x18C79E0", Offset = "0x18C6BE0", VA = "0x1818C79E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x18C7A20", Offset = "0x18C6C20", VA = "0x1818C7A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6805320", Offset = "0x6804520", VA = "0x186805320")]
	public JJNPMEAOEDG(int AKPLFIBLHPE, int IPCNJDBKKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JPNJLLNMMLM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CNFGCKINEOF HIJBENKAEJP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FGIGENACLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6805330", Offset = "0x6804530", VA = "0x186805330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68054B0", Offset = "0x68046B0", VA = "0x1868054B0")]
	static JPNJLLNMMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68053B0", Offset = "0x68045B0", VA = "0x1868053B0")]
	public static IReadOnlyList<AKIDNFAPJGC> KANFJJKKHGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OJOBJPLDFEB : CNFGCKINEOF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IPAKHENAOFE : AKIDNFAPJGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IMDELNBFLPN
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
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public IMDELNBFLPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6804CD0", Offset = "0x6803ED0", VA = "0x186804CD0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EJKFCKKGKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture PHGJBKIJAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MBFMENHALLA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HGHLBCLFGAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6804E60", Offset = "0x6804060", VA = "0x186804E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CJIFHILHFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7B00", VA = "0x180AD8900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DANKELKBOCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7E0150", Offset = "0x7DF350", VA = "0x1807E0150", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6805220", Offset = "0x6804420", VA = "0x186805220", Slot = "7")]
		public JJNPMEAOEDG HJJKLGKNLDJ(Action<ArraySegment<float>> ONAFALABHKI)
		{
			return default(JJNPMEAOEDG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6804E80", Offset = "0x6804080", VA = "0x186804E80")]
		private JJNPMEAOEDG HJJKLGKNLDJ(int AKPLFIBLHPE, int DFLMOPOGPOK, int IPCNJDBKKDB, Action<ArraySegment<float>> ONAFALABHKI)
		{
			return default(JJNPMEAOEDG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6805250", Offset = "0x6804450", VA = "0x186805250", Slot = "8")]
		public void OPOACDKBGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68052D0", Offset = "0x68044D0", VA = "0x1868052D0")]
		public IPAKHENAOFE(MMDevice EJKFCKKGKCD, bool DJLAABLGJEG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<IPAKHENAOFE> GHKLJPKBMNO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FGIGENACLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6805580", Offset = "0x6804780", VA = "0x186805580", Slot = "5")]
	public IReadOnlyList<AKIDNFAPJGC> KANFJJKKHGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6805860", Offset = "0x6804A60", VA = "0x186805860")]
	public OJOBJPLDFEB()
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
