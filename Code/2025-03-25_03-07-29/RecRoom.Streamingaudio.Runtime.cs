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
public interface JDFJLKHOJKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BFFILGJAMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IJHMFECABLO> PFODPJAGNDN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IJHMFECABLO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ELJBCFEHELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NEJDPHIPPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LAEJPANILBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GHAJNIFOEPI EPNBCGKBLHC(Action<ArraySegment<float>> FJLFOAFFGHE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IILLGMFEHBN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GHAJNIFOEPI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MGKPNMHOMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MMCCDAMGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A510", Offset = "0x2C89910", VA = "0x182C8A510")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A94680", Offset = "0x6A93A80", VA = "0x186A94680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7871AC0", Offset = "0x7870EC0", VA = "0x187871AC0")]
	public GHAJNIFOEPI(int AALENIBFPNP, int HPEBBDHCJPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IEIMFDMDLAF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JDFJLKHOJKJ DNFLNJBKIOM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BFFILGJAMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x829E520", Offset = "0x829D920", VA = "0x18829E520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x829E680", Offset = "0x829DA80", VA = "0x18829E680")]
	static IEIMFDMDLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x829E590", Offset = "0x829D990", VA = "0x18829E590")]
	public static IReadOnlyList<IJHMFECABLO> PFODPJAGNDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FKFCMKEINFF : JDFJLKHOJKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OMEGHEKDPEB : IJHMFECABLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CJFGJOIEBOO
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
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public CJFGJOIEBOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x829DFF0", Offset = "0x829D3F0", VA = "0x18829DFF0")]
			internal void BKGNBFFDKLG(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DBIGKPCBAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture FFAOLMBPBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ABPCPFJDILC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ELJBCFEHELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x829EB60", Offset = "0x829DF60", VA = "0x18829EB60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NEJDPHIPPGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD13190", Offset = "0xD12590", VA = "0x180D13190", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9FD930", Offset = "0x9FCD30", VA = "0x1809FD930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LAEJPANILBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCE7810", Offset = "0xCE6C10", VA = "0x180CE7810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x829EB30", Offset = "0x829DF30", VA = "0x18829EB30", Slot = "7")]
		public GHAJNIFOEPI EPNBCGKBLHC(Action<ArraySegment<float>> FJLFOAFFGHE)
		{
			return default(GHAJNIFOEPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x829E770", Offset = "0x829DB70", VA = "0x18829E770")]
		private GHAJNIFOEPI EPNBCGKBLHC(int AALENIBFPNP, int LMPAMGHLGDP, int HPEBBDHCJPM, Action<ArraySegment<float>> FJLFOAFFGHE)
		{
			return default(GHAJNIFOEPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x829EB80", Offset = "0x829DF80", VA = "0x18829EB80", Slot = "8")]
		public void IILLGMFEHBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x829EC00", Offset = "0x829E000", VA = "0x18829EC00")]
		public OMEGHEKDPEB(MMDevice DBIGKPCBAJB, bool JPIMECCCAGN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OMEGHEKDPEB> LPPMIAOAJHI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BFFILGJAMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x829E170", Offset = "0x829D570", VA = "0x18829E170", Slot = "5")]
	public IReadOnlyList<IJHMFECABLO> PFODPJAGNDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x829E490", Offset = "0x829D890", VA = "0x18829E490")]
	public FKFCMKEINFF()
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
