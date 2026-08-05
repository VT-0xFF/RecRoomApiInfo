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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x9877990", Offset = "0x9876990", VA = "0x189877990")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0x987AB90", Offset = "0x9879B90", VA = "0x18987AB90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : MZCPJSWWOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class FEFOLURSPJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage LNXGAYUYPJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public FEFOLURSPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9875540", Offset = "0x9874540", VA = "0x189875540")]
			internal UXDBKRJQXAW HXOOJUBRDIC(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9875760", Offset = "0x9874760", VA = "0x189875760")]
			internal void HXTVHAVOMTL(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KXPJFHIHHEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage LNXGAYUYPJB;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public KXPJFHIHHEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9876F90", Offset = "0x9875F90", VA = "0x189876F90")]
			internal void ODQIRVTGHCT(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class RNIKRFKQYEV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public YSXIWCRGEQJ.MessageContentType IYELYNNBQXJ;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public RNIKRFKQYEV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x98786D0", Offset = "0x98776D0", VA = "0x1898786D0")]
			internal bool PRBOSOEIEFA(VTTRCNBARCA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly YSXIWCRGEQJ.DKSMYDATDUR TAQGUDKTDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int MBCNEIRMKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<VTTRCNBARCA> BAVCIMWBADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly YRAMQFVWPUC BRGGOZQMJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly IJYPISQKVYY BBPVTZHWRUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XCNBAWAZTXP PPOHABRORIY;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98752B0", Offset = "0x98742B0", VA = "0x1898752B0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] YRAMQFVWPUC accountsClient, [Inject(null)] IJYPISQKVYY chatClient, [Inject(null)] XCNBAWAZTXP clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98744F0", Offset = "0x98734F0", VA = "0x1898744F0", Slot = "5")]
		public bool DQGSBUNNTRS(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9874C50", Offset = "0x9873C50", VA = "0x189874C50", Slot = "6")]
		public ChatMessage XAKPJFHRBVM(long a, YSXIWCRGEQJ.DKSMYDATDUR b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98749D0", Offset = "0x98739D0", VA = "0x1898749D0", Slot = "7")]
		public DLXOODTYWKJ<YSXIWCRGEQJ.FQKLMCYZSFN> LOKQXWTQHQU(YSXIWCRGEQJ.DKSMYDATDUR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9874B40", Offset = "0x9873B40", VA = "0x189874B40", Slot = "4")]
		public void WIIYSIPUYCS(VTTRCNBARCA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98746E0", Offset = "0x98736E0", VA = "0x1898746E0", Slot = "8")]
		public void GFMPFWBKQEF(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x98747D0", Offset = "0x98737D0", VA = "0x1898747D0")]
		private YSXIWCRGEQJ.DKSMYDATDUR LAHCRBAUZZN(YSXIWCRGEQJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9874FD0", Offset = "0x9873FD0", VA = "0x189874FD0")]
		private void ZKHHWOXXEJS(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9874DD0", Offset = "0x9873DD0", VA = "0x189874DD0")]
		private void XCOQKLKELTN(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9874410", Offset = "0x9873410", VA = "0x189874410")]
		private VTTRCNBARCA BQTQDQZBXOA(int a, YSXIWCRGEQJ.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface MZCPJSWWOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WIIYSIPUYCS(VTTRCNBARCA a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DQGSBUNNTRS(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage XAKPJFHRBVM(long a, YSXIWCRGEQJ.DKSMYDATDUR b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		DLXOODTYWKJ<YSXIWCRGEQJ.FQKLMCYZSFN> LOKQXWTQHQU(YSXIWCRGEQJ.DKSMYDATDUR a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GFMPFWBKQEF(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IPXZIEFIDED
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		BQFVKUSIMFN<IPXZIEFIDED> QLQUZHFHXBL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool FIGNUTOSVZX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<YRUJTSCRYCJ> JBTEOPCXRNU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string YTUTJGBWUDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		UXDBKRJQXAW XPRMOGOQEXU();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : YSXIWCRGEQJ.DKSMYDATDUR
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override YSXIWCRGEQJ.MessageContentType WGOXOTVNFPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "10")]
			get
			{
				return default(YSXIWCRGEQJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9877AB0", Offset = "0x9876AB0", VA = "0x189877AB0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9877A10", Offset = "0x9876A10", VA = "0x189877A10")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : YSXIWCRGEQJ.DKSMYDATDUR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long EHYUCZMOYUQ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override YSXIWCRGEQJ.MessageContentType WGOXOTVNFPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "10")]
			get
			{
				return default(YSXIWCRGEQJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string PYBQKDGEYRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xEFCFC0", Offset = "0xEFBFC0", VA = "0x180EFCFC0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long LCDWIJSAIAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9877CB0", Offset = "0x9876CB0", VA = "0x189877CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9877D70", Offset = "0x9876D70", VA = "0x189877D70")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9877D30", Offset = "0x9876D30", VA = "0x189877D30")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QHABMAJZUNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98782A0", Offset = "0x98772A0", VA = "0x1898782A0")]
		[GQJUYEPYYUG.Root]
		internal static void VUDEEUUYCGF(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9878580", Offset = "0x9877580", VA = "0x189878580")]
		[UnityEngine.Scripting.Preserve]
		public QHABMAJZUNH([Inject(null)] MZCPJSWWOBE chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] PBNYXJIMOXT textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class JAZJAPEHKQU
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LPQSXGDQTBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IPXZIEFIDED UIJAVYNTNTL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool SZJBQHDADTI;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPQSXGDQTBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9876FC0", Offset = "0x9875FC0", VA = "0x189876FC0")]
			internal string JNPIBWPMJUE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] QWYDTITZEJI;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9876220", Offset = "0x9875220", VA = "0x189876220")]
		public static DLXOODTYWKJ<string> ZTNDBHIYHMO(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98762F0", Offset = "0x98752F0", VA = "0x1898762F0")]
		public static DLXOODTYWKJ<string> ZTNDBHIYHMO(YSXIWCRGEQJ.DKSMYDATDUR a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9875E50", Offset = "0x9874E50", VA = "0x189875E50")]
		private static string SMUYNLQSFSO(IPXZIEFIDED a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9875AE0", Offset = "0x9874AE0", VA = "0x189875AE0")]
		public static string AUWXNJIUTMY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9876110", Offset = "0x9875110", VA = "0x189876110")]
		public static string VXKJIKQQBNZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9875C60", Offset = "0x9874C60", VA = "0x189875C60")]
		public static bool IIVDFZZPIOA(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9875BF0", Offset = "0x9874BF0", VA = "0x189875BF0")]
		public static bool HPNMJPKMZOV(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9875E20", Offset = "0x9874E20", VA = "0x189875E20")]
		public static bool LUYOFYZGQPQ(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9875CD0", Offset = "0x9874CD0", VA = "0x189875CD0")]
		public static string JGOGPUFCVMA(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : YSXIWCRGEQJ.DKSMYDATDUR, IPXZIEFIDED
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BQFVKUSIMFN<IPXZIEFIDED> QLQUZHFHXBL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<YRUJTSCRYCJ> JBTEOPCXRNU
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FIGNUTOSVZX
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9879FD0", Offset = "0x9878FD0", VA = "0x189879FD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool GJGEGYFMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9879960", Offset = "0x9878960", VA = "0x189879960", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x987A3F0", Offset = "0x98793F0", VA = "0x18987A3F0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x987A110", Offset = "0x9879110", VA = "0x18987A110")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x987A2E0", Offset = "0x98792E0", VA = "0x18987A2E0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9879AE0", Offset = "0x9878AE0", VA = "0x189879AE0", Slot = "17")]
		public void WLNTHQIPABI(YRUJTSCRYCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9879BD0", Offset = "0x9878BD0", VA = "0x189879BD0", Slot = "16")]
		public UXDBKRJQXAW XPRMOGOQEXU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98799F0", Offset = "0x98789F0", VA = "0x1898799F0")]
		private void WKLHRDGAHLP(YRUJTSCRYCJ a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class YRUJTSCRYCJ : IEquatable<YRUJTSCRYCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BQFVKUSIMFN<YRUJTSCRYCJ> QLQUZHFHXBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool FIGNUTOSVZX
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCFDEE0", Offset = "0xCFCEE0", VA = "0x180CFDEE0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool GJGEGYFMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x987A750", Offset = "0x9879750", VA = "0x18987A750", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string EUDDFMURQIG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long LUOPSKRRGZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCFCB30", Offset = "0xCFBB30", VA = "0x180CFCB30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string VTZZDBSQMAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object GBPFTVVAQOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UXDBKRJQXAW HIBXLHLDIKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCFC240", Offset = "0xCFB240", VA = "0x180CFC240")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x987AAF0", Offset = "0x9879AF0", VA = "0x18987AAF0")]
		protected YRUJTSCRYCJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x987AA40", Offset = "0x9879A40", VA = "0x18987AA40")]
		protected YRUJTSCRYCJ(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x987A970", Offset = "0x9879970", VA = "0x18987A970")]
		protected YRUJTSCRYCJ(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x987A920", Offset = "0x9879920", VA = "0x18987A920")]
		protected void TZVRACWJNTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x987A790", Offset = "0x9879790", VA = "0x18987A790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x987A8F0", Offset = "0x98798F0", VA = "0x18987A8F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x987A870", Offset = "0x9879870", VA = "0x18987A870", Slot = "4")]
		public bool Equals(YRUJTSCRYCJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string MOSLBBTBSYV(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class OAUWEYVZSZN<a, b> : YRUJTSCRYCJ where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PUKJSNNOUVN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public FEKLLVSOUCL PKWTPZXZBOU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OAUWEYVZSZN<a, b> NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PUKJSNNOUVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7541550", Offset = "0x7540550", VA = "0x187541550")]
			internal void HJMAZAHCSXR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a GBPFTVVAQOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x73E5990", Offset = "0x73E4990", VA = "0x1873E5990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x73E5970", Offset = "0x73E4970", VA = "0x1873E5970")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x73E59E0", Offset = "0x73E49E0", VA = "0x1873E59E0")]
		protected OAUWEYVZSZN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x73E5A90", Offset = "0x73E4A90", VA = "0x1873E5A90")]
		protected OAUWEYVZSZN(string a, long b, string c, DLXOODTYWKJ<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void VGWOJXEFELO(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x73E5900", Offset = "0x73E4900", VA = "0x1873E5900")]
		private void BFNSIQYDPUF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x73E5950", Offset = "0x73E4950", VA = "0x1873E5950")]
		[CompilerGenerated]
		private void JHVVTBQHKKO(string a)
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
	public class SQSAURDUPKR : OAUWEYVZSZN<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD608B0", Offset = "0xD5F8B0", VA = "0x180D608B0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x98789A0", Offset = "0x98779A0", VA = "0x1898789A0")]
		public SQSAURDUPKR(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98789F0", Offset = "0x98779F0", VA = "0x1898789F0")]
		public SQSAURDUPKR(string a, long b, string c, DLXOODTYWKJ<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x98788D0", Offset = "0x98778D0", VA = "0x1898788D0", Slot = "9")]
		public override string MOSLBBTBSYV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9878940", Offset = "0x9877940", VA = "0x189878940", Slot = "10")]
		protected override void VGWOJXEFELO(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class FOOKPTWBOTP : OAUWEYVZSZN<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9875870", Offset = "0x9874870", VA = "0x189875870")]
		public FOOKPTWBOTP(string a, long b, string c, DLXOODTYWKJ<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9875790", Offset = "0x9874790", VA = "0x189875790", Slot = "9")]
		public override string MOSLBBTBSYV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9875820", Offset = "0x9874820", VA = "0x189875820", Slot = "10")]
		protected override void VGWOJXEFELO(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class VOQEASDERCW : OAUWEYVZSZN<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x987A6E0", Offset = "0x98796E0", VA = "0x18987A6E0")]
		public VOQEASDERCW(string a, long b, string c, DLXOODTYWKJ<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x987A580", Offset = "0x9879580", VA = "0x18987A580", Slot = "9")]
		public override string MOSLBBTBSYV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x987A670", Offset = "0x9879670", VA = "0x18987A670", Slot = "10")]
		protected override void VGWOJXEFELO(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class GXVUEOLQUVW : OAUWEYVZSZN<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD64890", Offset = "0xD63890", VA = "0x180D64890", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool GJGEGYFMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x98758E0", Offset = "0x98748E0", VA = "0x1898758E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9875A20", Offset = "0x9874A20", VA = "0x189875A20")]
		public GXVUEOLQUVW(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9875A70", Offset = "0x9874A70", VA = "0x189875A70")]
		public GXVUEOLQUVW(string a, long b, string c, DLXOODTYWKJ<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9875960", Offset = "0x9874960", VA = "0x189875960", Slot = "9")]
		public override string MOSLBBTBSYV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x98759D0", Offset = "0x98749D0", VA = "0x1898759D0", Slot = "10")]
		protected override void VGWOJXEFELO(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class BLTLONYUPWQ : OAUWEYVZSZN<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] NAAUSKPCCGW;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string XMBCKQYPLOW
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF6BC0", VA = "0x180CF7BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool GJGEGYFMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9873FE0", Offset = "0x9872FE0", VA = "0x189873FE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9874350", Offset = "0x9873350", VA = "0x189874350")]
		public BLTLONYUPWQ(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98743A0", Offset = "0x98733A0", VA = "0x1898743A0")]
		public BLTLONYUPWQ(string a, long b, string c, DLXOODTYWKJ<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9874160", Offset = "0x9873160", VA = "0x189874160", Slot = "9")]
		public override string MOSLBBTBSYV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9874220", Offset = "0x9873220", VA = "0x189874220", Slot = "10")]
		protected override void VGWOJXEFELO(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class HKVQXMVPMDN<a> : VTTRCNBARCA where a : YSXIWCRGEQJ.DKSMYDATDUR, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract YSXIWCRGEQJ.MessageContentType WGOXOTVNFPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6515000", Offset = "0x6514000", VA = "0x186515000", Slot = "7")]
		private YSXIWCRGEQJ.DKSMYDATDUR VNVTRGSYLWI(YSXIWCRGEQJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6514FA0", Offset = "0x6513FA0", VA = "0x186514FA0", Slot = "6")]
		private DLXOODTYWKJ<YSXIWCRGEQJ.FQKLMCYZSFN> TPYLEEPSQUD(YSXIWCRGEQJ.DKSMYDATDUR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6514C10", Offset = "0x6513C10", VA = "0x186514C10", Slot = "10")]
		public virtual a LAHCRBAUZZN(YSXIWCRGEQJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6514CF0", Offset = "0x6513CF0", VA = "0x186514CF0", Slot = "11")]
		public virtual DLXOODTYWKJ<YSXIWCRGEQJ.FQKLMCYZSFN> LOKQXWTQHQU(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "12")]
		protected virtual void XPZLAULUZEO(a a, YSXIWCRGEQJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6515020", Offset = "0x6514020", VA = "0x186515020", Slot = "13")]
		protected virtual DLXOODTYWKJ<string> YUZIPPGYUOY(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected HKVQXMVPMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6514EC0", Offset = "0x6513EC0", VA = "0x186514EC0")]
		[CompilerGenerated]
		private YSXIWCRGEQJ.FQKLMCYZSFN MMOYXIVSQTO(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface VTTRCNBARCA
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		YSXIWCRGEQJ.MessageContentType WGOXOTVNFPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DLXOODTYWKJ<YSXIWCRGEQJ.FQKLMCYZSFN> LOKQXWTQHQU(YSXIWCRGEQJ.DKSMYDATDUR a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YSXIWCRGEQJ.DKSMYDATDUR LAHCRBAUZZN(YSXIWCRGEQJ.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface PBNYXJIMOXT : VTTRCNBARCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LYUBZXEGTOY(TXGCNDAFYSI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : HKVQXMVPMDN<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class BPWSOLJVWNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool GJGEGYFMMBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int RCZDDNYZMRL;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string LLRCOFUJAVV
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType AHRPWOVSMCK
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int CKAZUHCJASF
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x162DF80", Offset = "0x162CF80", VA = "0x18162DF80")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x162DF90", Offset = "0x162CF90", VA = "0x18162DF90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int GOXAMEBYYKG
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD4BEA0", Offset = "0xD4AEA0", VA = "0x180D4BEA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string FPLTSHHXAXM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16A9D30", Offset = "0x16A8D30", VA = "0x1816A9D30")]
			public BPWSOLJVWNH()
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
		private readonly BPUGLJCWDRW FMTEBOAMFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly YRAMQFVWPUC BRGGOZQMJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly KDQRWKCJYMM NABIGWWNDRR;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override YSXIWCRGEQJ.MessageContentType WGOXOTVNFPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(YSXIWCRGEQJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9877900", Offset = "0x9876900", VA = "0x189877900")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] BPUGLJCWDRW roomsClient, [Inject(null)] YRAMQFVWPUC accountsClient, [Inject(null)] KDQRWKCJYMM imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x98778C0", Offset = "0x98768C0", VA = "0x1898778C0", Slot = "11")]
		public override DLXOODTYWKJ<YSXIWCRGEQJ.FQKLMCYZSFN> LOKQXWTQHQU(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x98777A0", Offset = "0x98767A0", VA = "0x1898777A0", Slot = "10")]
		public override TextMessageDetails LAHCRBAUZZN(YSXIWCRGEQJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9877020", Offset = "0x9876020", VA = "0x189877020")]
		private void EMSRHLSBITX(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : HKVQXMVPMDN<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override YSXIWCRGEQJ.MessageContentType WGOXOTVNFPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "9")]
			get
			{
				return default(YSXIWCRGEQJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9877AC0", Offset = "0x9876AC0", VA = "0x189877AC0")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : HKVQXMVPMDN<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override YSXIWCRGEQJ.MessageContentType WGOXOTVNFPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "9")]
			get
			{
				return default(YSXIWCRGEQJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9877D80", Offset = "0x9876D80", VA = "0x189877D80", Slot = "12")]
		protected override void XPZLAULUZEO(PhotoMessageDetails a, YSXIWCRGEQJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9877F20", Offset = "0x9876F20", VA = "0x189877F20")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : HKVQXMVPMDN<TextMessageDetails>, PBNYXJIMOXT, VTTRCNBARCA
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class KXPJFHIHHEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails GAODCGZQMGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool KWBPVHOLOKX;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public KXPJFHIHHEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x98767C0", Offset = "0x98757C0", VA = "0x1898767C0")]
			internal YSXIWCRGEQJ.FQKLMCYZSFN ENMUWWBIUKO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int ZMFXQSJEXBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int SZQCLFICKJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, TXGCNDAFYSI> ITLAODCCTWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, TXGCNDAFYSI> LKVHBYJDHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private VLRSVUNJBPF<VOQEASDERCW> FPCFBEKPBLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private VLRSVUNJBPF<BLTLONYUPWQ> RENMTEBKHSU;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override YSXIWCRGEQJ.MessageContentType WGOXOTVNFPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "9")]
			get
			{
				return default(YSXIWCRGEQJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9878D00", Offset = "0x9877D00", VA = "0x189878D00", Slot = "14")]
		public void LYUBZXEGTOY(TXGCNDAFYSI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9878A60", Offset = "0x9877A60", VA = "0x189878A60", Slot = "11")]
		public override DLXOODTYWKJ<YSXIWCRGEQJ.FQKLMCYZSFN> LOKQXWTQHQU(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x98791D0", Offset = "0x98781D0", VA = "0x1898791D0", Slot = "12")]
		protected override void XPZLAULUZEO(TextMessageDetails a, YSXIWCRGEQJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9879090", Offset = "0x9878090", VA = "0x189879090")]
		private bool MGWNNJTTVLQ(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9879600", Offset = "0x9878600", VA = "0x189879600")]
		private static int XWVXKSBDGDX(TextMessageDetails a, int b, bool c, TXGCNDAFYSI d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9879840", Offset = "0x9878840", VA = "0x189879840")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class JKLLSNLJBFT<a> : VLRSVUNJBPF<a>, TXGCNDAFYSI, IEquatable<TXGCNDAFYSI>, IEquatable<ChatTokenType> where a : YRUJTSCRYCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] MSAMRMUGYME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string YRIPRDPTLBJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType NMIHDRKUDTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string YZITBITPRFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x66F8A00", Offset = "0x66F7A00", VA = "0x1866F8A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char LPCJCWPAOEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char RTFVGDLITIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType ULZFBRERLEY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x66F8810", Offset = "0x66F7810", VA = "0x1866F8810", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x66F9330", Offset = "0x66F8330", VA = "0x1866F9330")]
		protected JKLLSNLJBFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x66F8D20", Offset = "0x66F7D20", VA = "0x1866F8D20")]
		protected string OWBFLKPSZIF(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x66F9070", Offset = "0x66F8070", VA = "0x1866F9070", Slot = "14")]
		public bool YDPNNFVXYAC(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x66F8B20", Offset = "0x66F7B20", VA = "0x1866F8B20", Slot = "15")]
		public void KEMLSVROPWV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a MDKHOXRPLMY(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x66F8B00", Offset = "0x66F7B00", VA = "0x1866F8B00", Slot = "8")]
		private YRUJTSCRYCJ IFOINDEVTGT(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool LIWBJBFENWX(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string OWLOOTHWWNN(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x66F8C40", Offset = "0x66F7C40", VA = "0x1866F8C40")]
		private bool MLEHSGRITVB(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x66F8E20", Offset = "0x66F7E20", VA = "0x1866F8E20")]
		private string RMFMWWAENOR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x66F8E90", Offset = "0x66F7E90", VA = "0x1866F8E90", Slot = "6")]
		private bool VTUHDHSVSQX(string a, [Out] YRUJTSCRYCJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x66F86C0", Offset = "0x66F76C0", VA = "0x1866F86C0", Slot = "7")]
		private void DZLUDUCDDNQ(YRUJTSCRYCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x66F8AD0", Offset = "0x66F7AD0", VA = "0x1866F8AD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x66F88E0", Offset = "0x66F78E0", VA = "0x1866F88E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x66F8860", Offset = "0x66F7860", VA = "0x1866F8860", Slot = "9")]
		public bool Equals(TXGCNDAFYSI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x66F8830", Offset = "0x66F7830", VA = "0x1866F8830", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : GQXITSVCWEP<SQSAURDUPKR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly XCNBAWAZTXP PPOHABRORIY;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType NMIHDRKUDTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xD608B0", Offset = "0xD5F8B0", VA = "0x180D608B0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char LPCJCWPAOEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FCA420", Offset = "0x1FC9420", VA = "0x181FCA420", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char RTFVGDLITIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9875380", Offset = "0x9874380", VA = "0x189875380", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x98754E0", Offset = "0x98744E0", VA = "0x1898754E0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] XCNBAWAZTXP clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9875390", Offset = "0x9874390", VA = "0x189875390", Slot = "19")]
		protected override SQSAURDUPKR ZSWKGDRAMVK(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface TXGCNDAFYSI : IEquatable<TXGCNDAFYSI>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType NMIHDRKUDTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string YZITBITPRFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool YDPNNFVXYAC(string a, [Out] YRUJTSCRYCJ b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KEMLSVROPWV(YRUJTSCRYCJ a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YRUJTSCRYCJ MDKHOXRPLMY(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface VLRSVUNJBPF<a> : TXGCNDAFYSI, IEquatable<TXGCNDAFYSI>, IEquatable<ChatTokenType> where a : YRUJTSCRYCJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : GQXITSVCWEP<FOOKPTWBOTP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly KDQRWKCJYMM NABIGWWNDRR;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType NMIHDRKUDTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char LPCJCWPAOEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FBED60", Offset = "0x1FBDD60", VA = "0x181FBED60", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char RTFVGDLITIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE0ED70", Offset = "0xE0DD70", VA = "0x180E0ED70", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9877C50", Offset = "0x9876C50", VA = "0x189877C50")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] KDQRWKCJYMM imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9877B00", Offset = "0x9876B00", VA = "0x189877B00", Slot = "19")]
		protected override FOOKPTWBOTP ZSWKGDRAMVK(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : GQXITSVCWEP<VOQEASDERCW>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly YRAMQFVWPUC BRGGOZQMJEJ;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType NMIHDRKUDTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char LPCJCWPAOEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x200B510", Offset = "0x200A510", VA = "0x18200B510", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char RTFVGDLITIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9877F60", Offset = "0x9876F60", VA = "0x189877F60", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9878080", Offset = "0x9877080", VA = "0x189878080")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] YRAMQFVWPUC accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9877F70", Offset = "0x9876F70", VA = "0x189877F70", Slot = "19")]
		protected override VOQEASDERCW ZSWKGDRAMVK(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : GQXITSVCWEP<GXVUEOLQUVW>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly YTLURGAWRIP AGCMLWYAMRX;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType NMIHDRKUDTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD64890", Offset = "0xD63890", VA = "0x180D64890", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char LPCJCWPAOEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FCA420", Offset = "0x1FC9420", VA = "0x181FCA420", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char RTFVGDLITIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x98780E0", Offset = "0x98770E0", VA = "0x1898780E0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9878240", Offset = "0x9877240", VA = "0x189878240")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] YTLURGAWRIP playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x98780F0", Offset = "0x98770F0", VA = "0x1898780F0", Slot = "19")]
		protected override GXVUEOLQUVW ZSWKGDRAMVK(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : GQXITSVCWEP<BLTLONYUPWQ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly BPUGLJCWDRW FMTEBOAMFBD;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType NMIHDRKUDTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char LPCJCWPAOEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9878750", Offset = "0x9877750", VA = "0x189878750", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char RTFVGDLITIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FAD0A0", Offset = "0x1FAC0A0", VA = "0x181FAD0A0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9878870", Offset = "0x9877870", VA = "0x189878870")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] BPUGLJCWDRW roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9878760", Offset = "0x9877760", VA = "0x189878760", Slot = "19")]
		protected override BLTLONYUPWQ ZSWKGDRAMVK(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class GQXITSVCWEP<a> : JKLLSNLJBFT<a> where a : YRUJTSCRYCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x645E800", Offset = "0x645D800", VA = "0x18645E800", Slot = "16")]
		public override a MDKHOXRPLMY(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x645E840", Offset = "0x645D840", VA = "0x18645E840", Slot = "18")]
		protected override string OWLOOTHWWNN(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x645E6E0", Offset = "0x645D6E0", VA = "0x18645E6E0", Slot = "17")]
		protected override bool LIWBJBFENWX(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a ZSWKGDRAMVK(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x645E8E0", Offset = "0x645D8E0", VA = "0x18645E8E0")]
		protected GQXITSVCWEP()
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
