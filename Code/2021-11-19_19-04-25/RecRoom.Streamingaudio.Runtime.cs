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
public interface ONCCNDEPEID
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AILNGEPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IMLALALELHD> HJEGDKIKNMG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IMLALALELHD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HIJKMMPDOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GJMOFBEDJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MPBEDCJFMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KHLMMJAJFJK OLPLAGECKIG(Action<ArraySegment<float>> PBCLPMFCHNG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLBKLFEEKAB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KHLMMJAJFJK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AEHJMHOEALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x669F80", Offset = "0x668F80", VA = "0x180669F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FA0", Offset = "0x6A6FA0", VA = "0x1806A7FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GOILEOCFKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x669F60", Offset = "0x668F60", VA = "0x180669F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1EDF370", Offset = "0x1EDE370", VA = "0x181EDF370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D99680", Offset = "0x3D98680", VA = "0x183D99680")]
	public KHLMMJAJFJK(int KOGAGDGFLJP, int LLLFJBHMPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LMOOBAAEPDB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ONCCNDEPEID KGBCBNFHDIK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AILNGEPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D99690", Offset = "0x3D98690", VA = "0x183D99690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D997F0", Offset = "0x3D987F0", VA = "0x183D997F0")]
	static LMOOBAAEPDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D99700", Offset = "0x3D98700", VA = "0x183D99700")]
	public static IReadOnlyList<IMLALALELHD> HJEGDKIKNMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OEFGCHLCFJJ : ONCCNDEPEID
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FDBBJIICPHG : IMLALALELHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IIPILJAAJIJ
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
			[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
			public IIPILJAAJIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3D99500", Offset = "0x3D98500", VA = "0x183D99500")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HACNIAPKLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture IGCKIIPFLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ONPOMJNKDLN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HIJKMMPDOJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3D99190", Offset = "0x3D98190", VA = "0x183D99190", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GJMOFBEDJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4EBA20", Offset = "0x4EAA20", VA = "0x1804EBA20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x626AD0", Offset = "0x625AD0", VA = "0x180626AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MPBEDCJFMMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9954B0", Offset = "0x9944B0", VA = "0x1809954B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D99490", Offset = "0x3D98490", VA = "0x183D99490", Slot = "7")]
		public KHLMMJAJFJK OLPLAGECKIG(Action<ArraySegment<float>> PBCLPMFCHNG)
		{
			return default(KHLMMJAJFJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D991B0", Offset = "0x3D981B0", VA = "0x183D991B0")]
		private KHLMMJAJFJK OLPLAGECKIG(int KOGAGDGFLJP, int BOIIPDPCNOA, int LLLFJBHMPMA, Action<ArraySegment<float>> PBCLPMFCHNG)
		{
			return default(KHLMMJAJFJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D99130", Offset = "0x3D98130", VA = "0x183D99130", Slot = "8")]
		public void HLBKLFEEKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D994C0", Offset = "0x3D984C0", VA = "0x183D994C0")]
		public FDBBJIICPHG(MMDevice HACNIAPKLDB, bool MIEDEPMOPBJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FDBBJIICPHG> KENIPDPEADP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AILNGEPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x428F60", Offset = "0x427F60", VA = "0x180428F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D99890", Offset = "0x3D98890", VA = "0x183D99890", Slot = "5")]
	public IReadOnlyList<IMLALALELHD> HJEGDKIKNMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D99B30", Offset = "0x3D98B30", VA = "0x183D99B30")]
	public OEFGCHLCFJJ()
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
