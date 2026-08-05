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
public interface CDANHDPMLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HPEEHHBDGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GKGLMPLABIL> ENPHKKOEELA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GKGLMPLABIL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string CFJGBOECNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HDPBPKPGKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HJBHLCLKHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LELPBDPEBJI GJCBCADLGIE(Action<ArraySegment<float>> JOIALDGLEAK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLLECJMABCE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LELPBDPEBJI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JAIGIIILCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JEMJHELFCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88A590", Offset = "0x888F90", VA = "0x18088A590")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEA60A0", Offset = "0xEA4AA0", VA = "0x180EA60A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64A4630", Offset = "0x64A3030", VA = "0x1864A4630")]
	public LELPBDPEBJI(int DNMLOAAGLHE, int CBLKLFBNNCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CKIIFCNKFIF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CDANHDPMLEN BJOCKKDEENH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HPEEHHBDGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64A4020", Offset = "0x64A2A20", VA = "0x1864A4020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64A40A0", Offset = "0x64A2AA0", VA = "0x1864A40A0")]
	static CKIIFCNKFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64A3F20", Offset = "0x64A2920", VA = "0x1864A3F20")]
	public static IReadOnlyList<GKGLMPLABIL> ENPHKKOEELA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BAGNGHMDNIO : CDANHDPMLEN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GCBEBLFCENE : GKGLMPLABIL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LJCMBBIPODG
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
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public LJCMBBIPODG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x64A4640", Offset = "0x64A3040", VA = "0x1864A4640")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice KDEOKALCEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GBHFIPCOIDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource DMBCGPNIOKP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string CFJGBOECNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x64A45C0", Offset = "0x64A2FC0", VA = "0x1864A45C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HDPBPKPGKAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x77B170", Offset = "0x779B70", VA = "0x18077B170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HJBHLCLKHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x702C60", Offset = "0x701660", VA = "0x180702C60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64A4170", Offset = "0x64A2B70", VA = "0x1864A4170", Slot = "7")]
		public LELPBDPEBJI GJCBCADLGIE(Action<ArraySegment<float>> JOIALDGLEAK)
		{
			return default(LELPBDPEBJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x64A41A0", Offset = "0x64A2BA0", VA = "0x1864A41A0")]
		private LELPBDPEBJI GJCBCADLGIE(int DNMLOAAGLHE, int HNKMHNDGFIO, int CBLKLFBNNCD, Action<ArraySegment<float>> JOIALDGLEAK)
		{
			return default(LELPBDPEBJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x64A4540", Offset = "0x64A2F40", VA = "0x1864A4540", Slot = "8")]
		public void HLLECJMABCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x64A45E0", Offset = "0x64A2FE0", VA = "0x1864A45E0")]
		public GCBEBLFCENE(MMDevice KDEOKALCEFL, bool NPNKOEPBAOL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GCBEBLFCENE> DDOMDNCHGPH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HPEEHHBDGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64A3BC0", Offset = "0x64A25C0", VA = "0x1864A3BC0", Slot = "5")]
	public IReadOnlyList<GKGLMPLABIL> ENPHKKOEELA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64A3EA0", Offset = "0x64A28A0", VA = "0x1864A3EA0")]
	public BAGNGHMDNIO()
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
