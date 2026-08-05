using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy.RoomOffer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface YZSHYMBDDDI
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		AQWXMNIFQIV VEGXZAASIYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x3B6A0E8D8563B8", Offset = "0x0", VA = "0x3B6A100D8563B8", Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD855586803B6A7A", Offset = "0x0", VA = "0xD855588003B6A7A", Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		HWNZTWGRXOC<RecNet.RoomOffer> JMJAYOATYYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x3B6AA5803B6A80", Offset = "0x0", VA = "0x3B6AA7003B6A80", Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3B6AAE8D8555A0", Offset = "0x0", VA = "0x3B6AB00D8555A0", Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HWNZTWGRXOC<Guid> IDXJKUFLTLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD85559E803B6AD7", Offset = "0x0", VA = "0xD8555A0003B6AD7", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3B6B05803B6AE0", Offset = "0x0", VA = "0x3B6B07003B6AE0", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3B6B0E8D8555A0", Offset = "0x0", VA = "0x3B6B100D8555A0", Slot = "6")]
		Task<Result<RecNet.RoomOffer, string>> TTMCHDMLEBC(Guid? a, long b, string c, string d, string e, int f, RoomOfferType g, [Optional] Dictionary<Guid, int> h, [Optional] Guid? i, bool j = false);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD85559E803B6B37", Offset = "0x0", VA = "0xD8555A0003B6B37", Slot = "7")]
		Task<Result<RecNet.RoomOffer, string>> CZMRIYGPDCD(Guid a, long b, string c, string d, string e, int f, RoomOfferType g, [Optional] Dictionary<Guid, int> h, [Optional] Guid? i);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BA8803B6B40", Offset = "0x0", VA = "0x3B6BAA003B6B40", Slot = "8")]
		Task<Result<bool, string>> HIABLAUJNKJ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BAE8D855588", Offset = "0x0", VA = "0x3B6BB00D855588", Slot = "9")]
		IEnumerable<RecNet.RoomOffer> QETRGEXTQQU();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD855586803B6C1A", Offset = "0x0", VA = "0xD855588003B6C1A", Slot = "10")]
		Task<List<RoomOfferLastPurchaseDTO>> TLABZOLVINF(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C55803B6C20", Offset = "0x0", VA = "0x3B6C57003B6C20", Slot = "11")]
		bool PKJIRLIYTAJ(Guid a, [Out] RecNet.RoomOffer b);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C5E8D855598", Offset = "0x0", VA = "0x3B6C600D855598", Slot = "12")]
		bool YHOGQCNKKTV(string a, [Out] RecNet.RoomOffer b);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD855586803B6CCA", Offset = "0x0", VA = "0xD855588003B6CCA", Slot = "13")]
		bool UIOZAPJYXDM(Guid a, int b);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B6CF5803B6CD0", Offset = "0x0", VA = "0x3B6CF7003B6CD0", Slot = "14")]
		void JGSORYEKLDL(WJBKOLNRRJE a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B6CFE8D8555A0", Offset = "0x0", VA = "0x3B6D000D8555A0", Slot = "15")]
		Task<int> GFZMWNTBQBC(WJBKOLNRRJE a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD855586803B6D6A", Offset = "0x0", VA = "0xD855588003B6D6A", Slot = "16")]
		bool OAPBJEIAACX();

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D95803B6D70", Offset = "0x0", VA = "0x3B6D97003B6D70", Slot = "17")]
		bool RNNJNTWEDZI(Guid a, [Out] List<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D9E8D8555A0", Offset = "0x0", VA = "0x3B6DA00D8555A0", Slot = "18")]
		Task<Result<bool, string>> WJEAGVDEXNT(RecNet.RoomOffer a, long b, int c, [Optional] string d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface RAZQFXNASGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD855586803B6E0A", Offset = "0x0", VA = "0xD855588003B6E0A", Slot = "0")]
		void MDTBSFWMHFE(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E78803B6E10", Offset = "0x0", VA = "0x3B6E7A003B6E10", Slot = "1")]
		void QCUKSEAXAGM(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E7E8D855588", Offset = "0x0", VA = "0x3B6E800D855588", Slot = "2")]
		void IWYZRPVRZIT(Guid a, int b);
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
