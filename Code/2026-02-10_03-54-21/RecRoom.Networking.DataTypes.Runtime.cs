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
	public interface JSKFFZQLBTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QNRGMGQGWIT();

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SDCPIWXGRHC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class GRGIZNRAAXY
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8519BA0", Offset = "0x8518DA0", VA = "0x188519BA0")]
		public static void QAQCHIDSDZF(this IList<JSKFFZQLBTK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85199F0", Offset = "0x8518BF0", VA = "0x1885199F0")]
		public static void OYNQTTBGHUI(this IList<JSKFFZQLBTK> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HJIMNRPSBJR
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int NDBTCLMJJGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool ILGWFGJRNRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool SREIDMNKVUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Dictionary<object, object> ZZFLDYGBTMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string MOBNANQPPFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int ZSUAZWPNANP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool XUVHCKPCAJU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool WMEKIKROBVI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string SGBIATIOCRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool ZIKOBXOFEZT
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object ZTTFILQAOSH
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
		bool HMIOXWORGXA(Dictionary<object, object> a, [Optional] Dictionary<object, object> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface TSGUKOIFCBT
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		byte XVJYJUFXPZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool EHTQDJALBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Dictionary<object, object> ZZFLDYGBTMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool HMIOXWORGXA(Dictionary<object, object> a, [Optional] Dictionary<object, object> b);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool EICPTWSMJSJ(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DefaultMember("Item")]
	public interface QVRCDNFGMQF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		byte LYZGIQDGMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		int KXODMYZKDVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object HKKESJZASNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GDGJFTLPVBG(byte a, [Out] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class STHVWJOAUBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string VYCQNQIKDCS;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public STHVWJOAUBA([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8519D50", Offset = "0x8518F50", VA = "0x188519D50", Slot = "3")]
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
