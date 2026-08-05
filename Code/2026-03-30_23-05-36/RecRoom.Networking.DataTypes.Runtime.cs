using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum RpcTarget
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		MasterClient,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		AllBuffered,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		OthersBuffered,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		AllViaServer,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		AllBufferedViaServer
	}
}
namespace RecRoom.Networking.DataTypes
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface RMTUHOHHKTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LWKFWKESHXF();

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZHDCDOSDQUQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class BEXVFUWDTEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x860EC90", Offset = "0x860DA90", VA = "0x18860EC90")]
		public static void LYATTTMKGRF(this IList<RMTUHOHHKTK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x860EE40", Offset = "0x860DC40", VA = "0x18860EE40")]
		public static void QQNHLWYIKVG(this IList<RMTUHOHHKTK> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface VPDKWOIWOKH
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int GMAIZQDIIWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool DFMFLANESXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool HHPXDDRRDWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Dictionary<object, object> HQJCFSEUYUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string MGYYYQFGFLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int LAGWBUYLKPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool RLHFCRUQJRM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool CQJJIFNDAMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string FKAJEIGOFNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool LELVYIZXHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object WPMIZWJEFNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool TSLUFQOVAUK(Dictionary<object, object> a, [Optional] Dictionary<object, object> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface KGEHLOHZDIF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		byte ELAWKGOOFXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool QYTOMUGDUCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Dictionary<object, object> HQJCFSEUYUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TSLUFQOVAUK(Dictionary<object, object> a, [Optional] Dictionary<object, object> b);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool VTGQCUVMQRL(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DefaultMember("Item")]
	public interface XQAWTLZFHQF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		byte JRVMTAFMXQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		int LOUVYGZEAQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object MWSRDIETTKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KJZUPXKVGOU(byte a, [Out] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class XVNGLZRBWKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string TIRWMCLGOLI;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public XVNGLZRBWKC([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x860EFF0", Offset = "0x860DDF0", VA = "0x18860EFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Cpp2IlInjected
{
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
}
