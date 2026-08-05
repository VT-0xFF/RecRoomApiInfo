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
public interface EKDKLDGMGIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EPMABMHEINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<AJCNPGCCABO> BDMJLJKBNOE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AJCNPGCCABO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HAPNNFMFLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BEHPAPIIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HAKHDINMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NLPDMNHCPIA GPGLGAIJAEJ(Action<ArraySegment<float>> JCDKDANAIEK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMCEEGCPAAP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NLPDMNHCPIA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PAJJILFHKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EACLGKKBHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x30BACB0", Offset = "0x30B9AB0", VA = "0x1830BACB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E47E60", Offset = "0x6E46C60", VA = "0x186E47E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x811AE70", Offset = "0x8119C70", VA = "0x18811AE70")]
	public NLPDMNHCPIA(int OBEFJGIAEHP, int ADMDFBPDHIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LAGMCDEOFCO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static EKDKLDGMGIN CPHMOFIELBH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EPMABMHEINC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C14970", Offset = "0x8C13770", VA = "0x188C14970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8C149F0", Offset = "0x8C137F0", VA = "0x188C149F0")]
	static LAGMCDEOFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8C14880", Offset = "0x8C13680", VA = "0x188C14880")]
	public static IReadOnlyList<AJCNPGCCABO> BDMJLJKBNOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DOGCCGOJPLA : EKDKLDGMGIN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ACGECCNLHNG : AJCNPGCCABO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KEILMIJDEKP
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
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public KEILMIJDEKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8C14700", Offset = "0x8C13500", VA = "0x188C14700")]
			internal void IJFDLEJMIOI(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice OLKGNHFCIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EOKMGLCNCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NHJJLBJCDKP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HAPNNFMFLDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8C142E0", Offset = "0x8C130E0", VA = "0x188C142E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BEHPAPIIFJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xABC540", Offset = "0xABB340", VA = "0x180ABC540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HAKHDINMFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEA6B70", Offset = "0xEA5970", VA = "0x180EA6B70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C13EF0", Offset = "0x8C12CF0", VA = "0x188C13EF0", Slot = "7")]
		public NLPDMNHCPIA GPGLGAIJAEJ(Action<ArraySegment<float>> JCDKDANAIEK)
		{
			return default(NLPDMNHCPIA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C13F20", Offset = "0x8C12D20", VA = "0x188C13F20")]
		private NLPDMNHCPIA GPGLGAIJAEJ(int OBEFJGIAEHP, int HJLGJOCMOMN, int ADMDFBPDHIB, Action<ArraySegment<float>> JCDKDANAIEK)
		{
			return default(NLPDMNHCPIA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C13E70", Offset = "0x8C12C70", VA = "0x188C13E70", Slot = "8")]
		public void AMCEEGCPAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C14300", Offset = "0x8C13100", VA = "0x188C14300")]
		public ACGECCNLHNG(MMDevice OLKGNHFCIMF, bool IFCOCIGGIMH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ACGECCNLHNG> JNBIMIKFMMP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EPMABMHEINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8C14350", Offset = "0x8C13150", VA = "0x188C14350", Slot = "5")]
	public IReadOnlyList<AJCNPGCCABO> BDMJLJKBNOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8C14670", Offset = "0x8C13470", VA = "0x188C14670")]
	public DOGCCGOJPLA()
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
