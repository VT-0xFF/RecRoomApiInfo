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
public interface CLLOHADNMBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GGDKNKPBMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HFCHPKOLOJD> DCGDMOIBHBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HFCHPKOLOJD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HBEBJIJFJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PFKCFKGHBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ENPEKDKMFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CPDANHDLAKI KOCFNPIGOBJ(Action<ArraySegment<float>> AGNPCLIMAAG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIFLAAKKOAK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CPDANHDLAKI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GMJMMIBBMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D34F0", Offset = "0x7D26F0", VA = "0x1807D34F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8834C0", Offset = "0x8826C0", VA = "0x1808834C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FDKADFKOFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D34D0", Offset = "0x7D26D0", VA = "0x1807D34D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85CD70", Offset = "0x85BF70", VA = "0x18085CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C26830", Offset = "0x4C25A30", VA = "0x184C26830")]
	public CPDANHDLAKI(int BHNKHBJIDAK, int JNKNJJIHELD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AKHEKOIHMAO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CLLOHADNMBH BMCJBNCPCGN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GGDKNKPBMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4C26710", Offset = "0x4C25910", VA = "0x184C26710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C26780", Offset = "0x4C25980", VA = "0x184C26780")]
	static AKHEKOIHMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4C26620", Offset = "0x4C25820", VA = "0x184C26620")]
	public static IReadOnlyList<HFCHPKOLOJD> DCGDMOIBHBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IIINAAEPLIL : CLLOHADNMBH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LNDOEIFPEHN : HFCHPKOLOJD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GNGPGJBOOJO
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
			[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
			public GNGPGJBOOJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4C26840", Offset = "0x4C25A40", VA = "0x184C26840")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FHACCKNIFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture CLEDBBGDLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BKKHDPDGKCB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HBEBJIJFJNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4C26D50", Offset = "0x4C25F50", VA = "0x184C26D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PFKCFKGHBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5A8990", Offset = "0x5A7B90", VA = "0x1805A8990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E8EB0", Offset = "0x6E80B0", VA = "0x1806E8EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ENPEKDKMFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6402C0", Offset = "0x63F4C0", VA = "0x1806402C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4C26D70", Offset = "0x4C25F70", VA = "0x184C26D70", Slot = "7")]
		public CPDANHDLAKI KOCFNPIGOBJ(Action<ArraySegment<float>> AGNPCLIMAAG)
		{
			return default(CPDANHDLAKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4C26DA0", Offset = "0x4C25FA0", VA = "0x184C26DA0")]
		private CPDANHDLAKI KOCFNPIGOBJ(int BHNKHBJIDAK, int INMJHGGABCB, int JNKNJJIHELD, Action<ArraySegment<float>> AGNPCLIMAAG)
		{
			return default(CPDANHDLAKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4C26CD0", Offset = "0x4C25ED0", VA = "0x184C26CD0", Slot = "8")]
		public void DIFLAAKKOAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4C270E0", Offset = "0x4C262E0", VA = "0x184C270E0")]
		public LNDOEIFPEHN(MMDevice FHACCKNIFMK, bool JLLCLLCHEHJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<LNDOEIFPEHN> GGHMFBHFGOB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GGDKNKPBMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x527FE0", Offset = "0x5271E0", VA = "0x180527FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4C269C0", Offset = "0x4C25BC0", VA = "0x184C269C0", Slot = "5")]
	public IReadOnlyList<HFCHPKOLOJD> DCGDMOIBHBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4C26C60", Offset = "0x4C25E60", VA = "0x184C26C60")]
	public IIINAAEPLIL()
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
