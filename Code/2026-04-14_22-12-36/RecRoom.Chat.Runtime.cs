using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Events;
using RecNet.Rooms;
using RecRoom.Async;
using RecRoom.Chat.Runtime.MessagePackagers;
using RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers;
using RecRoom.Chat.Runtime.Tokens;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9719290", Offset = "0x9717E90", VA = "0x189719290")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Chat_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x971C730", Offset = "0x971B330", VA = "0x18971C730", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : UCUZNPLHHWA
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class EUKHXKXCZPT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage ETDFDWEGBOV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public EUKHXKXCZPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9717AE0", Offset = "0x97166E0", VA = "0x189717AE0")]
			internal GMTKWIVSBCA NRGGOSTHVPK(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9717D00", Offset = "0x9716900", VA = "0x189717D00")]
			internal void NRLNLZNFFAT(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage ETDFDWEGBOV;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x971A7B0", Offset = "0x97193B0", VA = "0x18971A7B0")]
			internal void IEEBXYFGOVT(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class VIHYUHFKEDV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public GCFUQARSZOP.MessageContentType KPHADDZZBOF;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x971C6B0", Offset = "0x971B2B0", VA = "0x18971C6B0")]
			internal bool EOSTJAUKQTO(HVBYWFNKVTY a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly GCFUQARSZOP.ZTIKSCWBGUX HPRXQAACMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int UGHKPTGFCZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<HVBYWFNKVTY> TZBONWCUOIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly IITRKRQOZFC PIKHWZYFXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CAAGWEJRTBQ SDLMNEYOEXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly HJMLVQHSNAT WCXLHTLALZI;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9717700", Offset = "0x9716300", VA = "0x189717700")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] IITRKRQOZFC accountsClient, [Inject(null)] CAAGWEJRTBQ chatClient, [Inject(null)] HJMLVQHSNAT clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97169F0", Offset = "0x97155F0", VA = "0x1897169F0", Slot = "5")]
		public bool DBFQRKHAYRM(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9716870", Offset = "0x9715470", VA = "0x189716870", Slot = "6")]
		public ChatMessage BEDRCWMUFZK(long a, GCFUQARSZOP.ZTIKSCWBGUX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9717290", Offset = "0x9715E90", VA = "0x189717290", Slot = "7")]
		public IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(GCFUQARSZOP.ZTIKSCWBGUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9716EC0", Offset = "0x9715AC0", VA = "0x189716EC0", Slot = "4")]
		public void MYRFDUNHSSI(HVBYWFNKVTY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x97171A0", Offset = "0x9715DA0", VA = "0x1897171A0", Slot = "8")]
		public void WMZDYTTHGIX(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9716CC0", Offset = "0x97158C0", VA = "0x189716CC0")]
		private GCFUQARSZOP.ZTIKSCWBGUX LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9716FC0", Offset = "0x9715BC0", VA = "0x189716FC0")]
		private void TRJTVIKORHY(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9717400", Offset = "0x9716000", VA = "0x189717400")]
		private void ZPEEEYHLHGB(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9716BE0", Offset = "0x97157E0", VA = "0x189716BE0")]
		private HVBYWFNKVTY JPPDYNXGCLM(int a, GCFUQARSZOP.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface UCUZNPLHHWA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MYRFDUNHSSI(HVBYWFNKVTY a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DBFQRKHAYRM(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage BEDRCWMUFZK(long a, GCFUQARSZOP.ZTIKSCWBGUX b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(GCFUQARSZOP.ZTIKSCWBGUX a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WMZDYTTHGIX(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface CBRADXBFKHT
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		DRWWZAXJWQZ<CBRADXBFKHT> VHOGCKIQIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool TTEIRLMLFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<QKARQFIZQFZ> JISSLXRPQSU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string HBLTVDNEEXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GMTKWIVSBCA LPYZRVAUBDG();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : GCFUQARSZOP.ZTIKSCWBGUX
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "10")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x97193B0", Offset = "0x9717FB0", VA = "0x1897193B0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9719310", Offset = "0x9717F10", VA = "0x189719310")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : GCFUQARSZOP.ZTIKSCWBGUX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long QCTWXXEOYKS;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "10")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string MTHKURUDJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xEF6DE0", Offset = "0xEF59E0", VA = "0x180EF6DE0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long LVUKGTFFKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x97195B0", Offset = "0x97181B0", VA = "0x1897195B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9719670", Offset = "0x9718270", VA = "0x189719670")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9719630", Offset = "0x9718230", VA = "0x189719630")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IJXAGBZRGUP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9717EC0", Offset = "0x9716AC0", VA = "0x189717EC0")]
		[GEPWJNEAFDW.Root]
		internal static void MNJJZJMLTHZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x97181A0", Offset = "0x9716DA0", VA = "0x1897181A0")]
		[UnityEngine.Scripting.Preserve]
		public IJXAGBZRGUP([Inject(null)] UCUZNPLHHWA chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] AGCWXWWGCNZ textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CTLJVTOSLWC
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public CBRADXBFKHT IYKVPFFJFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool HVNRJQUIVPG;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x971C650", Offset = "0x971B250", VA = "0x18971C650")]
			internal string FIXBFQOIJCO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] EKPGGAXIBDW;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9716550", Offset = "0x9715150", VA = "0x189716550")]
		public static IMNXFPWKHPJ<string> OUULLBWXEPS(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9716230", Offset = "0x9714E30", VA = "0x189716230")]
		public static IMNXFPWKHPJ<string> OUULLBWXEPS(GCFUQARSZOP.ZTIKSCWBGUX a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9715F00", Offset = "0x9714B00", VA = "0x189715F00")]
		private static string NWUYMSFZORW(CBRADXBFKHT a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9715B90", Offset = "0x9714790", VA = "0x189715B90")]
		public static string CSRLVOALIDA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9715DF0", Offset = "0x97149F0", VA = "0x189715DF0")]
		public static string IDECBDMYMQF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x97161C0", Offset = "0x9714DC0", VA = "0x1897161C0")]
		public static bool OJCOOCWJMGW(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9716650", Offset = "0x9715250", VA = "0x189716650")]
		public static bool WLIATNGGDFZ(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9716620", Offset = "0x9715220", VA = "0x189716620")]
		public static bool SSODJCFFRPO(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9715CA0", Offset = "0x97148A0", VA = "0x189715CA0")]
		public static string EAMCSLJZCNY(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : GCFUQARSZOP.ZTIKSCWBGUX, CBRADXBFKHT
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public DRWWZAXJWQZ<CBRADXBFKHT> VHOGCKIQIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<QKARQFIZQFZ> JISSLXRPQSU
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool TTEIRLMLFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x971C010", Offset = "0x971AC10", VA = "0x18971C010", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x971C150", Offset = "0x971AD50", VA = "0x18971C150", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x971C4C0", Offset = "0x971B0C0", VA = "0x18971C4C0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x971C1E0", Offset = "0x971ADE0", VA = "0x18971C1E0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x971C3B0", Offset = "0x971AFB0", VA = "0x18971C3B0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x971BF20", Offset = "0x971AB20", VA = "0x18971BF20", Slot = "17")]
		public void NINNDEHJUZO(QKARQFIZQFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x971BB20", Offset = "0x971A720", VA = "0x18971BB20", Slot = "16")]
		public GMTKWIVSBCA LPYZRVAUBDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x971BA30", Offset = "0x971A630", VA = "0x18971BA30")]
		private void JWPLSRWDGOP(QKARQFIZQFZ a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class QKARQFIZQFZ : IEquatable<QKARQFIZQFZ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DRWWZAXJWQZ<QKARQFIZQFZ> VHOGCKIQIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool TTEIRLMLFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2A30", VA = "0x180EA3E30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCFD470", Offset = "0xCFC070", VA = "0x180CFD470", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9719D80", Offset = "0x9718980", VA = "0x189719D80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string THWVJQJGAGM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long VQBMLAULJDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C40", Offset = "0xCF3840", VA = "0x180CF4C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ZIXQMBVKNAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object EAVJJCWRDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2F70", VA = "0x180CF4370")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public GMTKWIVSBCA GHLERORVWIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9719F40", Offset = "0x9718B40", VA = "0x189719F40")]
		protected QKARQFIZQFZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9719DC0", Offset = "0x97189C0", VA = "0x189719DC0")]
		protected QKARQFIZQFZ(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9719E70", Offset = "0x9718A70", VA = "0x189719E70")]
		protected QKARQFIZQFZ(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9719D30", Offset = "0x9718930", VA = "0x189719D30")]
		protected void SCAMOICJUSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9719C20", Offset = "0x9718820", VA = "0x189719C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9719D00", Offset = "0x9718900", VA = "0x189719D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9719BA0", Offset = "0x97187A0", VA = "0x189719BA0", Slot = "4")]
		public bool Equals(QKARQFIZQFZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string RZWSNJDDQYH(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class DYWMTVUQSSV<a, b> : QKARQFIZQFZ where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class WLUGBDBSDJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public YNVUIOBZBUF ZAIUPJORZEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public DYWMTVUQSSV<a, b> DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public WLUGBDBSDJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85D2510", Offset = "0x85D1110", VA = "0x1885D2510")]
			internal void HUQVTKHHWJD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a EAVJJCWRDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x53EF840", Offset = "0x53EE440", VA = "0x1853EF840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x53EF800", Offset = "0x53EE400", VA = "0x1853EF800")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x53EFD00", Offset = "0x53EE900", VA = "0x1853EFD00")]
		protected DYWMTVUQSSV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x53EF8E0", Offset = "0x53EE4E0", VA = "0x1853EF8E0")]
		protected DYWMTVUQSSV(string a, long b, string c, IMNXFPWKHPJ<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void LCDMLVUAINI(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x53EF890", Offset = "0x53EE490", VA = "0x1853EF890")]
		private void UJAUXSGICAD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x53EF820", Offset = "0x53EE420", VA = "0x1853EF820")]
		[CompilerGenerated]
		private void GBWAMHQLGZO(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ChatTokenType
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Photo,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		PlayerEvent,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Club
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class GWOBALHPQUH : DYWMTVUQSSV<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD5A490", Offset = "0xD59090", VA = "0x180D5A490", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9717E00", Offset = "0x9716A00", VA = "0x189717E00")]
		public GWOBALHPQUH(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9717E50", Offset = "0x9716A50", VA = "0x189717E50")]
		public GWOBALHPQUH(string a, long b, string c, IMNXFPWKHPJ<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9717D90", Offset = "0x9716990", VA = "0x189717D90", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9717D30", Offset = "0x9716930", VA = "0x189717D30", Slot = "10")]
		protected override void LCDMLVUAINI(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DNELGTTLFOP : DYWMTVUQSSV<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9717A70", Offset = "0x9716670", VA = "0x189717A70")]
		public DNELGTTLFOP(string a, long b, string c, IMNXFPWKHPJ<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x97179E0", Offset = "0x97165E0", VA = "0x1897179E0", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9717990", Offset = "0x9716590", VA = "0x189717990", Slot = "10")]
		protected override void LCDMLVUAINI(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class RZVBXNOREMI : DYWMTVUQSSV<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x971A940", Offset = "0x9719540", VA = "0x18971A940")]
		public RZVBXNOREMI(string a, long b, string c, IMNXFPWKHPJ<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x971A850", Offset = "0x9719450", VA = "0x18971A850", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x971A7E0", Offset = "0x97193E0", VA = "0x18971A7E0", Slot = "10")]
		protected override void LCDMLVUAINI(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class MYTSRYFGNNA : DYWMTVUQSSV<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CE00", VA = "0x180D5E200", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9719150", Offset = "0x9717D50", VA = "0x189719150", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x97191D0", Offset = "0x9717DD0", VA = "0x1897191D0")]
		public MYTSRYFGNNA(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9719220", Offset = "0x9717E20", VA = "0x189719220")]
		public MYTSRYFGNNA(string a, long b, string c, IMNXFPWKHPJ<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x97190E0", Offset = "0x9717CE0", VA = "0x1897190E0", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9719090", Offset = "0x9717C90", VA = "0x189719090", Slot = "10")]
		protected override void LCDMLVUAINI(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class KJFJZZLCXPI : DYWMTVUQSSV<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] ACWXMMHBZCM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string AWDBDLCOSUI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCEE170", Offset = "0xCECD70", VA = "0x180CEE170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9718430", Offset = "0x9717030", VA = "0x189718430", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9718660", Offset = "0x9717260", VA = "0x189718660")]
		public KJFJZZLCXPI(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x97186B0", Offset = "0x97172B0", VA = "0x1897186B0")]
		public KJFJZZLCXPI(string a, long b, string c, IMNXFPWKHPJ<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9718370", Offset = "0x9716F70", VA = "0x189718370", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x97182F0", Offset = "0x9716EF0", VA = "0x1897182F0", Slot = "10")]
		protected override void LCDMLVUAINI(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class VIMUZIZSRVT<a> : HVBYWFNKVTY where a : GCFUQARSZOP.ZTIKSCWBGUX, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E56EA0", Offset = "0x7E55AA0", VA = "0x187E56EA0", Slot = "7")]
		private GCFUQARSZOP.ZTIKSCWBGUX APNSGGFJOXU(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E57100", Offset = "0x7E55D00", VA = "0x187E57100", Slot = "6")]
		private IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> RCHQFGCJHSJ(GCFUQARSZOP.ZTIKSCWBGUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7E56EC0", Offset = "0x7E55AC0", VA = "0x187E56EC0", Slot = "10")]
		public virtual a LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E57160", Offset = "0x7E55D60", VA = "0x187E57160", Slot = "11")]
		public virtual IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "12")]
		protected virtual void YEWXDFQCGUA(a a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7E56FA0", Offset = "0x7E55BA0", VA = "0x187E56FA0", Slot = "13")]
		protected virtual IMNXFPWKHPJ<string> NUFDRDDZIES(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected VIMUZIZSRVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E57020", Offset = "0x7E55C20", VA = "0x187E57020")]
		[CompilerGenerated]
		private GCFUQARSZOP.ZRKUPDNNISB ORRQAMZRRUO(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface HVBYWFNKVTY
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(GCFUQARSZOP.ZTIKSCWBGUX a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GCFUQARSZOP.ZTIKSCWBGUX LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface AGCWXWWGCNZ : HVBYWFNKVTY
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FDXCWEJSTXM(DBVTIIZGTHI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : VIMUZIZSRVT<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class UICPILMDAIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool BXDMPUECVXA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int XKDQNNXZKED;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string BKDQFJKOXNT
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType XYUHIEMAMOM
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCF8B80", Offset = "0xCF7780", VA = "0x180CF8B80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int CTEWDWFEAYL
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x16230F0", Offset = "0x1621CF0", VA = "0x1816230F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1623100", Offset = "0x1621D00", VA = "0x181623100")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int XIXOCXKTWUQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF270", VA = "0x180D00670")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD45780", Offset = "0xD44380", VA = "0x180D45780")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string LPXUCBLHBPS
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16C0150", Offset = "0x16BED50", VA = "0x1816C0150")]
			public UICPILMDAIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum MarkupReplacementType
		{
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			Invalid,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			Username,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Roomname,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Photo
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly BGFSGAZMMEO FETJMKXWOHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly IITRKRQOZFC PIKHWZYFXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly YOWLVULKBTA DKAPOQHPSIJ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9719000", Offset = "0x9717C00", VA = "0x189719000")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] BGFSGAZMMEO roomsClient, [Inject(null)] IITRKRQOZFC accountsClient, [Inject(null)] YOWLVULKBTA imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9718FC0", Offset = "0x9717BC0", VA = "0x189718FC0", Slot = "11")]
		public override IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9718720", Offset = "0x9717320", VA = "0x189718720", Slot = "10")]
		public override TextMessageDetails LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9718840", Offset = "0x9717440", VA = "0x189718840")]
		private void VZROIWFPKVB(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : VIMUZIZSRVT<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x97193C0", Offset = "0x9717FC0", VA = "0x1897193C0")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : VIMUZIZSRVT<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9719680", Offset = "0x9718280", VA = "0x189719680", Slot = "12")]
		protected override void YEWXDFQCGUA(PhotoMessageDetails a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9719820", Offset = "0x9718420", VA = "0x189719820")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : VIMUZIZSRVT<TextMessageDetails>, AGCWXWWGCNZ, HVBYWFNKVTY
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails JOHJUUXYKDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool DWSNRQRVTRP;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9719FE0", Offset = "0x9718BE0", VA = "0x189719FE0")]
			internal GCFUQARSZOP.ZRKUPDNNISB AJHYKBPGFFS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int RVXHQPWIJYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int FWBUYAILOHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, DBVTIIZGTHI> PGFRZJHABHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, DBVTIIZGTHI> YJPRPUHRWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LIGPDIESOTH<RZVBXNOREMI> AHHWAOGMSFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LIGPDIESOTH<KJFJZZLCXPI> DBHQNTPJOFA;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x971AB30", Offset = "0x9719730", VA = "0x18971AB30", Slot = "14")]
		public void FDXCWEJSTXM(DBVTIIZGTHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x971B000", Offset = "0x9719C00", VA = "0x18971B000", Slot = "11")]
		public override IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x971B2A0", Offset = "0x9719EA0", VA = "0x18971B2A0", Slot = "12")]
		protected override void YEWXDFQCGUA(TextMessageDetails a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x971AEC0", Offset = "0x9719AC0", VA = "0x18971AEC0")]
		private bool PRLUWCNSPOU(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x971B6D0", Offset = "0x971A2D0", VA = "0x18971B6D0")]
		private static int YFJBCTNODBR(TextMessageDetails a, int b, bool c, DBVTIIZGTHI d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x971B910", Offset = "0x971A510", VA = "0x18971B910")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class WVANWXGNUJJ<a> : LIGPDIESOTH<a>, DBVTIIZGTHI, IEquatable<DBVTIIZGTHI>, IEquatable<ChatTokenType> where a : QKARQFIZQFZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] MCWPQYJFRWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string RNNCOFKQZKJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string AEYNWSNGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x85DB320", Offset = "0x85D9F20", VA = "0x1885DB320", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType JAUFLEGFDNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x85DB3F0", Offset = "0x85D9FF0", VA = "0x1885DB3F0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85DB980", Offset = "0x85DA580", VA = "0x1885DB980")]
		protected WVANWXGNUJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85DB780", Offset = "0x85DA380", VA = "0x1885DB780")]
		protected string ZQARZQGZSIP(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85DB4A0", Offset = "0x85DA0A0", VA = "0x1885DB4A0", Slot = "14")]
		public bool VPWDAIBPJGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85DB660", Offset = "0x85DA260", VA = "0x1885DB660", Slot = "15")]
		public void YQFATGTGDKX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a QQOBAYFUDHE(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85DB410", Offset = "0x85DA010", VA = "0x1885DB410", Slot = "8")]
		private QKARQFIZQFZ SVYNXOPZIEN(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool EPQDMOQKZSZ(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string QVQPGNIXRJX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85DB210", Offset = "0x85D9E10", VA = "0x1885DB210")]
		private bool GTGTSVADVWZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85DB430", Offset = "0x85DA030", VA = "0x1885DB430")]
		private string UAXQDYKKYBN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85DADC0", Offset = "0x85D99C0", VA = "0x1885DADC0", Slot = "6")]
		private bool BHXAGPTOTHT(string a, [Out] QKARQFIZQFZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85DAC70", Offset = "0x85D9870", VA = "0x1885DAC70", Slot = "7")]
		private void AQZDVTZPDWQ(QKARQFIZQFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85DB2F0", Offset = "0x85D9EF0", VA = "0x1885DB2F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85DB090", Offset = "0x85D9C90", VA = "0x1885DB090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85DAFC0", Offset = "0x85D9BC0", VA = "0x1885DAFC0", Slot = "9")]
		public bool Equals(DBVTIIZGTHI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85DAF90", Offset = "0x85D9B90", VA = "0x1885DAF90", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : OJPDJOKCFUB<GWOBALHPQUH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly HJMLVQHSNAT WCXLHTLALZI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xD5A490", Offset = "0xD59090", VA = "0x180D5A490", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3C00", Offset = "0x1FC2800", VA = "0x181FC3C00", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x97177D0", Offset = "0x97163D0", VA = "0x1897177D0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9717930", Offset = "0x9716530", VA = "0x189717930")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] HJMLVQHSNAT clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x97177E0", Offset = "0x97163E0", VA = "0x1897177E0", Slot = "19")]
		protected override GWOBALHPQUH OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface DBVTIIZGTHI : IEquatable<DBVTIIZGTHI>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string AEYNWSNGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VPWDAIBPJGY(string a, [Out] QKARQFIZQFZ b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YQFATGTGDKX(QKARQFIZQFZ a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QKARQFIZQFZ QQOBAYFUDHE(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface LIGPDIESOTH<a> : DBVTIIZGTHI, IEquatable<DBVTIIZGTHI>, IEquatable<ChatTokenType> where a : QKARQFIZQFZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : OJPDJOKCFUB<DNELGTTLFOP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly YOWLVULKBTA DKAPOQHPSIJ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9980", Offset = "0x1FB8580", VA = "0x181FB9980", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE03F60", Offset = "0xE02B60", VA = "0x180E03F60", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9719550", Offset = "0x9718150", VA = "0x189719550")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] YOWLVULKBTA imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9719400", Offset = "0x9718000", VA = "0x189719400", Slot = "19")]
		protected override DNELGTTLFOP OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : OJPDJOKCFUB<RZVBXNOREMI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly IITRKRQOZFC PIKHWZYFXEH;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2005B20", Offset = "0x2004720", VA = "0x182005B20", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9719860", Offset = "0x9718460", VA = "0x189719860", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9719980", Offset = "0x9718580", VA = "0x189719980")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] IITRKRQOZFC accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9719870", Offset = "0x9718470", VA = "0x189719870", Slot = "19")]
		protected override RZVBXNOREMI OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : OJPDJOKCFUB<MYTSRYFGNNA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly DSNRGBRIKTX NUNKGGNPSKP;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CE00", VA = "0x180D5E200", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3C00", Offset = "0x1FC2800", VA = "0x181FC3C00", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x97199E0", Offset = "0x97185E0", VA = "0x1897199E0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9719B40", Offset = "0x9718740", VA = "0x189719B40")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] DSNRGBRIKTX playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x97199F0", Offset = "0x97185F0", VA = "0x1897199F0", Slot = "19")]
		protected override MYTSRYFGNNA OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : OJPDJOKCFUB<KJFJZZLCXPI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly BGFSGAZMMEO FETJMKXWOHR;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x971AAC0", Offset = "0x97196C0", VA = "0x18971AAC0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F9F2F0", Offset = "0x1F9DEF0", VA = "0x181F9F2F0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x971AAD0", Offset = "0x97196D0", VA = "0x18971AAD0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] BGFSGAZMMEO roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x971A9B0", Offset = "0x97195B0", VA = "0x18971A9B0", Slot = "19")]
		protected override KJFJZZLCXPI OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class OJPDJOKCFUB<a> : WVANWXGNUJJ<a> where a : QKARQFIZQFZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72ABD00", Offset = "0x72AA900", VA = "0x1872ABD00", Slot = "16")]
		public override a QQOBAYFUDHE(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72ABD40", Offset = "0x72AA940", VA = "0x1872ABD40", Slot = "18")]
		protected override string QVQPGNIXRJX(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72ABBE0", Offset = "0x72AA7E0", VA = "0x1872ABBE0", Slot = "17")]
		protected override bool EPQDMOQKZSZ(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a OPMEZBFXNLI(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x72ABDE0", Offset = "0x72AA9E0", VA = "0x1872ABDE0")]
		protected OJPDJOKCFUB()
		{
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
