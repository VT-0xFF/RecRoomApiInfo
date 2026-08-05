using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.DataLayer;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy.RoomOffer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface AKYEDAOUXEI
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		XOOCNKBZGKP VBTBZHUEWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		WXSKNELZHVC<RecNet.RoomOffer> JCOWWHTCNXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		WXSKNELZHVC<Guid> STVIFLONPGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		WXSKNELZHVC<Guid> RDVTMUWKOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<Result<RecNet.RoomOffer, string>> SNXGFCBCADM(Guid? a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, bool k, UgcPurchasableItemVisibility l, [Optional] Dictionary<Guid, int> m, [Optional] Guid? n, bool o = false);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<Result<RecNet.RoomOffer, string>> KSPOWXNOGAB(Guid a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, bool k, UgcPurchasableItemVisibility l, [Optional] Dictionary<Guid, int> m, [Optional] Guid? n);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<Result<bool, string>> KWDUHYMYEWT(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IEnumerable<RecNet.RoomOffer> CGODEEELIFI();

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<List<RoomOfferLastPurchaseDTO>> PRQJDPEUOPP(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool TWPMMKOUHKH(Guid a, [Out] RecNet.RoomOffer b);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool RIBGTTDNVOZ(string a, [Out] RecNet.RoomOffer b);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool QOSVUGAJBQM(Guid a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void QXTNHUOFCNJ(MNBQIABPYXS a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<int> KARVDOAJSUC(MNBQIABPYXS a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool QNFJOWKJTGN();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool HFBUYMNRJVG(Guid a, [Out] List<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<Result<bool, string>> PHHCDZSBUYL(RecNet.RoomOffer a, long b, int c, [Optional] string d, [Optional] int? e);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool KRNOKTRSVDQ(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool DHRPOIVAFYG(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool ZCCZFBOIDMJ(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetPriceOverrideResult RTYOGXXMEYG(Guid a, int? b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void TAOAJZVHQDC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KNWMNIUSKLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HOCCZBSHUOE(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HAMCDVGRLKW(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OGGEFIVDRLP(Guid a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum SetPriceOverrideResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		SuccessClampedToMax,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		SuccessClampedToMin,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		SuccessCleared,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		FailedToFindRoomOffer,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		FailedBecauseNonDynamicPrice
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
