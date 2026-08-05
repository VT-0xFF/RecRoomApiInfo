using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B72EA0", Offset = "0x2B71EA0", VA = "0x182B72EA0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.RecRoom.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum CircuitsDestinationTargetType
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		SubRoom,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		WelcomeMat
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum CircuitsRoomHUDElementType
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Title,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Subtitle,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		ProgressWheel,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Bar1,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Bar2,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		InventorySlot1,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		InventorySlot2,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		InventorySlot3
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CircuitsRoomHUDInventoryData : IEquatable<CircuitsRoomHUDInventoryData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CircuitsRoomHUDElementType Slot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CircuitsRoomInventoryType InventoryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Guid ItemId;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B72E00", Offset = "0x2B71E00", VA = "0x182B72E00", Slot = "4")]
		public bool Equals(CircuitsRoomHUDInventoryData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B72D20", Offset = "0x2B71D20", VA = "0x182B72D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B72E60", Offset = "0x2B71E60", VA = "0x182B72E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class XVHVVOGABTC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly CircuitsRoomInventoryType RZVYCWJXNRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly Guid LEGBUSUKZOX;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B73030", Offset = "0x2B72030", VA = "0x182B73030")]
		public XVHVVOGABTC(CircuitsRoomInventoryType a, Guid b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CircuitsRoomInventoryType
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Currency,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Consumable,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		RoomInventoryItem
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface WHIAOEXSATK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		CircuitsDestinationTargetType VCECYSHGBMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string NZRCKJWTACL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool HHIXMUUQEHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool NCAYTMEWFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		RoomDoorData.PGFUJMMTYOK.RoomDoorInviteMode KVTELLYMWLW
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		string BNMSFSQMAHH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string BHRKPZPCMSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string KUDBQMMAULC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface KTWAABBDCDA
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string BNMSFSQMAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		string GERFGXNTDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		List<string> LZPUNNJXGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int QADLLWTYUNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int OBTFKTPJVHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int JUEENSRCAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		int HBJIREHLCXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		ONRWHMVRCKQ ZTRHVHZHNOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface SYFUDICJKVX
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int IGTERQWWZEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool RTRBOCAIELS
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string LPMQZOFBKKV
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		string LVNERMMHCKF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool TFQCGWPNMDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool HYPTOQLXMNO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float YMZOUEBXMLV
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ObjectiveMarkerDestroyingHandler OQQHYIZMILJ;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ONRWHMVRCKQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int DMXEZVXUGIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string WVDFBDBTGAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string UMLQJDKTKQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string UVVXWGZHEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		string PNGMCBDHCPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int ZODUWXNDRUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface WCGZAJDTJTN
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		string NZRCKJWTACL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		string WAYCQOLGWLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		long SVJWPFBXVVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ZWVAXNGBMGX
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Guid HGJTEJGBOEM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		IReadOnlyList<string> ZRVUVLFVOTP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface BYIRJWQEUTX
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int XITOLPEAHSX
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int PBZEIIEFUSM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		int EUMIHDOEVKF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		int KHABPCFCUNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DABTXIJQQDS();

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PWFHMAUZNML();

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JSVOUNLMAIM();

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LTMCCQWTVXG();

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UIYRIMOYPXS();

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void HMTFCEDDEJB();

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void EOBHIIZSWQY();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void XNZFFIFHVQI();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void BTRIBQACJIY(CircuitsRoomHUDInventoryData a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void GJMPRPAPOWW(CircuitsRoomHUDInventoryData a);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		XVHVVOGABTC CIJACXQMSTN(CircuitsRoomHUDElementType a);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IReadOnlyDictionary<CircuitsRoomHUDElementType, XVHVVOGABTC> JNNVLIWXHQG(CircuitsRoomInventoryType a, [In] Guid itemId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface OZPEAZUXJHE
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int YJGOQOTFZDO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int LPBQZQCHBDE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface FUKKPIWWLDE
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		string RSSIAIHFEGD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface EGFYEMKSOVU
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WHIAOEXSATK? OXMSZFMONOX(string? a, string? b, string? c, RoomDoorData.PGFUJMMTYOK.RoomDoorInviteMode d, bool e);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KTWAABBDCDA SFPEYVFNAQX(string a, string b, List<string> c, int d, int e, int f, int g, ONRWHMVRCKQ h);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ONRWHMVRCKQ XHMXLKUAZID(int a, string b, string c, string d, string e, int f);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Obsolete("Do not add events to Circuits!")]
	public delegate void ObjectiveMarkerDestroyingHandler(SYFUDICJKVX source);
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
