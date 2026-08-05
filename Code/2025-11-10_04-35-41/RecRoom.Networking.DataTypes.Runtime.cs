using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface VIZYBDZHORL
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		string CLHMIRDUYNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object MURNGIPKTVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
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
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface FZERGMMLSNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JHBOGRLDIAZ();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CTWPMYBCJBY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class GFICIMIZNTK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x836F030", Offset = "0x836E430", VA = "0x18836F030")]
		public static void HTDTZVNKQUJ(this IList<FZERGMMLSNU> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x836F1E0", Offset = "0x836E5E0", VA = "0x18836F1E0")]
		public static void NJXVOPJAHUS(this IList<FZERGMMLSNU> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface JCSDFORPEFX
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int JRKPARUUIDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool GDYUSVBIBZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool XOESREZGSQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Dictionary<object, object> EHYLMOOHJQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string OSCBNFQQUXM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		int LJBAHEEJJST
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool RUNXODOPFLS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool QDQRFQHZMTO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string CLHMIRDUYNC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool SELXGRDRVSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object HABLDYMKHOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool PENZUSGNVZO(Dictionary<object, object> a, [Optional] Dictionary<object, object> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ZPFBQSWCPET
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		byte BMLDBTQEMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool QAHKCLAUBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Dictionary<object, object> EHYLMOOHJQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool PENZUSGNVZO(Dictionary<object, object> a, [Optional] Dictionary<object, object> b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LXXKPLICIZN(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface PTKTLSUVJWP
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		byte LKVKMZDDSZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int GQNZJUUOZCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object ZGGPRZOUJQR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object this[byte key]
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool NCIRIRZXKOC(byte a, [Out] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class UMTYTQWPZHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string MWNBCHVLBRK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public UMTYTQWPZHG([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x836F390", Offset = "0x836E790", VA = "0x18836F390", Slot = "3")]
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
