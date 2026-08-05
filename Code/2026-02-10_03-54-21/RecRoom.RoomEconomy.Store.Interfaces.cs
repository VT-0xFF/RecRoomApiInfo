using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Async;
using RecRoom.Core;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class NSLKPFEZXFO
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Vector3? YXDTVKDCPWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xCAA5E0", Offset = "0xCA97E0", VA = "0x180CAA5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCAA600", Offset = "0xCA9800", VA = "0x180CAA600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Quaternion? YUATHBUJRCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD87BC0", Offset = "0xD86DC0", VA = "0x180D87BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86DA0", VA = "0x180D87BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float? TTUVWVJRWNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xBD4480", Offset = "0xBD3680", VA = "0x180BD4480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBD44C0", Offset = "0xBD36C0", VA = "0x180BD44C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public NSLKPFEZXFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface UWQOTZRVAJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public delegate void GiftConsumedCallback(bool successful);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XAVLACBBSNT();

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XYDTRVAOCMA(List<GiftPackage> a, bool b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QRAWUXPYVCR();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VETQYDKAYTX();

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IEnumerator<GVXKGQILIBM> FYCSVYIIMEX(GiftPackage a, GiftConsumedCallback b, bool c = false, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PTRFPYSSDLD(GiftPackage a, [Optional] GiftConsumedCallback b);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XPNEOFCQCUP(long a, NSLKPFEZXFO b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface NEZRXXGMGWL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NATDARTTXHB(IEnumerable<GFSJLZOAABN> a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LWYGXQPIMLZ ELMQAREMSRE(GFSJLZOAABN a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GFSJLZOAABN AKNWFDSSHUQ(UnifiedItemId a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<GFSJLZOAABN>> FOTIBLZYRRT(string a, bool? b, bool? c, IEnumerable<int> d, bool e, bool f);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<List<GFSJLZOAABN>> ZBKHQJZWWVK(IReadOnlyList<UnifiedItemId> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		YUBVFZQANJB<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> VOLHDMMZAND(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		YUBVFZQANJB<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> LJSUVWUYNHF(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		YUBVFZQANJB<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> YVFFTQCANHQ(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		YUBVFZQANJB<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> NLSKQNFDVLQ(StorefrontTypes a, CurrencyType b, int c, long d, long? e, IReadOnlyCollection<int> f, string g, bool h, GiftContext i, int j);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		YUBVFZQANJB<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> RSAVOZXRHTC(StorefrontTypes a, CurrencyType b, IReadOnlyList<UnifiedItemId> c, IReadOnlyList<long> d, [Optional] long? e, [Optional] GiftItemDTO f, [Optional] Guid? g);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<List<GFSJLZOAABN>> MOGHFZWMAKU(List<CustomAvatarItem> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface YJDRSGOQEUV
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool KZESZLZWPIK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JJQIAPKMIYG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LSXIDTPYKXP(StoreItemFilters a, RoomieStoreItemFilters b, GFSJLZOAABN c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<GFSJLZOAABN> ZCVPJOFYHAX(StoreItemFilters a, RoomieStoreItemFilters b, IReadOnlyList<GFSJLZOAABN> c);
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
