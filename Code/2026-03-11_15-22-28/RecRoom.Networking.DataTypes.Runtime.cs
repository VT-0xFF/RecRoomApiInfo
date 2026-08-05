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
	public interface SMDYNWTJNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CQDALRQTKOQ();

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JQFRNATGWTH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ELKIOKYFVZB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85840B0", Offset = "0x85830B0", VA = "0x1885840B0")]
		public static void HDHCRVBRSOA(this IList<SMDYNWTJNDH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8583F00", Offset = "0x8582F00", VA = "0x188583F00")]
		public static void EMEPUFGCIGR(this IList<SMDYNWTJNDH> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface OVSEBXDBUJS
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int HBXWTXDVAYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool YEPOFYTHJRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool OCXIMFCFZSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Dictionary<object, object> WHZVFONCQRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string GWHAQGXJWXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int GIIZDTBSRCI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool NFIQDNNRDCT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool VAXMMEJLODB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string XQBRPBOGCPL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool YWZWFPRUKES
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IMKMBKMHNWK
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
		bool VMUITGSTKIT(Dictionary<object, object> a, [Optional] Dictionary<object, object> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface HUZGCNRKFDE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		byte BFVEVTWZOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool LTTUKSPCFPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Dictionary<object, object> WHZVFONCQRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool VMUITGSTKIT(Dictionary<object, object> a, [Optional] Dictionary<object, object> b);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool MRQJFGYVIFG(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DefaultMember("Item")]
	public interface VASLQQLLDVS
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		byte CLIBGYYHYLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		int VMRGAQPOMHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object AZWQUNNAXEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DVVDXLGNEBL(byte a, [Out] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AXDXGSIBALV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string ZPBNJRNUSWT;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public AXDXGSIBALV([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8583EB0", Offset = "0x8582EB0", VA = "0x188583EB0", Slot = "3")]
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
