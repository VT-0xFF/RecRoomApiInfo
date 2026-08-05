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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9862D70", Offset = "0x9861770", VA = "0x189862D70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98662A0", Offset = "0x9864CA0", VA = "0x1898662A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : DZFGFVQQZAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class TLBQOBCWRUV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage ETNGFWKQEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> LUFXQDOFBUW;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public TLBQOBCWRUV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x98639D0", Offset = "0x98623D0", VA = "0x1898639D0")]
			internal NXPIPFBMDQY CPGLNPCVXLO(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9863BF0", Offset = "0x98625F0", VA = "0x189863BF0")]
			internal void CPLSKVWTGWX(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XXFQURQHRJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage ETNGFWKQEJP;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public XXFQURQHRJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9865F20", Offset = "0x9864920", VA = "0x189865F20")]
			internal void XSEVSBSSALL(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class UONXUWZERAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public MGJPJSBRWJJ.MessageContentType RKPEXMPTMOV;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public UONXUWZERAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x98656F0", Offset = "0x98640F0", VA = "0x1898656F0")]
			internal bool EINMGMQCRCY(OSSCMBZERRY a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly MGJPJSBRWJJ.TQBFSZUUJBV HMMPRUWEBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int XJVCAHMZIPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<OSSCMBZERRY> DVILLIWGYWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly WLLYXJMKWJS BDUXBDZLYSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly TEBAORIRPZU ZDYNAGWNSIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly CXQXXTCFPIH EILQRWJNMSO;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9860640", Offset = "0x985F040", VA = "0x189860640")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] WLLYXJMKWJS accountsClient, [Inject(null)] TEBAORIRPZU chatClient, [Inject(null)] CXQXXTCFPIH clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x985F930", Offset = "0x985E330", VA = "0x18985F930", Slot = "5")]
		public bool CFPQOGRQKRA(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x985F7B0", Offset = "0x985E1B0", VA = "0x18985F7B0", Slot = "6")]
		public ChatMessage BAXUOVRESHW(long a, MGJPJSBRWJJ.TQBFSZUUJBV b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9860120", Offset = "0x985EB20", VA = "0x189860120", Slot = "7")]
		public MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(MGJPJSBRWJJ.TQBFSZUUJBV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9860010", Offset = "0x985EA10", VA = "0x189860010", Slot = "4")]
		public void RTBHCTLSFTO(OSSCMBZERRY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x985FD20", Offset = "0x985E720", VA = "0x18985FD20", Slot = "8")]
		public void JQPUCTRVBNN(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x985FB20", Offset = "0x985E520", VA = "0x18985FB20")]
		private MGJPJSBRWJJ.TQBFSZUUJBV HPTUABHAWKN(MGJPJSBRWJJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9860290", Offset = "0x985EC90", VA = "0x189860290")]
		private void YVBJNCRJHBY(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x985FE10", Offset = "0x985E810", VA = "0x18985FE10")]
		private void OVYLKSWSPBX(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9860470", Offset = "0x985EE70", VA = "0x189860470")]
		private OSSCMBZERRY ZAKMPWIUMUO(int a, MGJPJSBRWJJ.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface DZFGFVQQZAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RTBHCTLSFTO(OSSCMBZERRY a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CFPQOGRQKRA(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage BAXUOVRESHW(long a, MGJPJSBRWJJ.TQBFSZUUJBV b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(MGJPJSBRWJJ.TQBFSZUUJBV a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JQPUCTRVBNN(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface XPUPHVTMDGV
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		DQCNOGDGYBL<XPUPHVTMDGV> ISBJWURAWRR
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JMBAQMLITVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<NXIJFYECKUX> MBWAREPWOZK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string JYJRJZUXYDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NXPIPFBMDQY UVGLGINBEDG();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : MGJPJSBRWJJ.TQBFSZUUJBV
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD76980", Offset = "0xD75380", VA = "0x180D76980", Slot = "10")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9862E90", Offset = "0x9861890", VA = "0x189862E90")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9862DF0", Offset = "0x98617F0", VA = "0x189862DF0")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : MGJPJSBRWJJ.TQBFSZUUJBV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long JRZEAULDLEW;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD75790", Offset = "0xD74190", VA = "0x180D75790", Slot = "10")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string RKIPWBYWASD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF201E0", Offset = "0xF1EBE0", VA = "0x180F201E0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long SAPLEQVKYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9863090", Offset = "0x9861A90", VA = "0x189863090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9863150", Offset = "0x9861B50", VA = "0x189863150")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9863110", Offset = "0x9861B10", VA = "0x189863110")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MVYYLRVUFRV
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9861840", Offset = "0x9860240", VA = "0x189861840")]
		[ONTQUCAGRJW.Root]
		internal static void YILWKTHVYDZ(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9861B20", Offset = "0x9860520", VA = "0x189861B20")]
		[UnityEngine.Scripting.Preserve]
		public MVYYLRVUFRV([Inject(null)] DZFGFVQQZAI chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] BILXVGJBMGT textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class NBXTKVLSSPA
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JOXUKJQLBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public XPUPHVTMDGV CNFOLJXHFLV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool XZPZXYLVRSU;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9860E70", Offset = "0x985F870", VA = "0x189860E70")]
			internal string MPJDGKPZXKK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] ONEZLJAZOCY;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98620B0", Offset = "0x9860AB0", VA = "0x1898620B0")]
		public static MPVTAJGPRUT<string> ULTROZBKVQI(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9862180", Offset = "0x9860B80", VA = "0x189862180")]
		public static MPVTAJGPRUT<string> ULTROZBKVQI(MGJPJSBRWJJ.TQBFSZUUJBV a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98624D0", Offset = "0x9860ED0", VA = "0x1898624D0")]
		private static string XXWUQIVFBOU(XPUPHVTMDGV a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9861D50", Offset = "0x9860750", VA = "0x189861D50")]
		public static string QFXJFYLJEJQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9861E50", Offset = "0x9860850", VA = "0x189861E50")]
		public static string SHQNLXFTQVX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9861CE0", Offset = "0x98606E0", VA = "0x189861CE0")]
		public static bool NQWOBBZNBDM(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9861C70", Offset = "0x9860670", VA = "0x189861C70")]
		public static bool BRUVOABACKP(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98624A0", Offset = "0x9860EA0", VA = "0x1898624A0")]
		public static bool WANGXSRGTPK(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9861F60", Offset = "0x9860960", VA = "0x189861F60")]
		public static string TVEMNTXQQPA(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : MGJPJSBRWJJ.TQBFSZUUJBV, XPUPHVTMDGV
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public DQCNOGDGYBL<XPUPHVTMDGV> ISBJWURAWRR
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<NXIJFYECKUX> MBWAREPWOZK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCD0", Offset = "0xD0B6D0", VA = "0x180D0CCD0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JMBAQMLITVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9864C90", Offset = "0x9863690", VA = "0x189864C90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9864B10", Offset = "0x9863510", VA = "0x189864B10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9865560", Offset = "0x9863F60", VA = "0x189865560")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9865290", Offset = "0x9863C90", VA = "0x189865290")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9865450", Offset = "0x9863E50", VA = "0x189865450")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9864BA0", Offset = "0x98635A0", VA = "0x189864BA0", Slot = "17")]
		public void SIGFKXXEIQE(NXIJFYECKUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9864DD0", Offset = "0x98637D0", VA = "0x189864DD0", Slot = "16")]
		public NXPIPFBMDQY UVGLGINBEDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98651A0", Offset = "0x9863BA0", VA = "0x1898651A0")]
		private void XQHOJBNUCPB(NXIJFYECKUX a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class NXIJFYECKUX : IEquatable<NXIJFYECKUX>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DQCNOGDGYBL<NXIJFYECKUX> ISBJWURAWRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool JMBAQMLITVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEA8300", Offset = "0xEA6D00", VA = "0x180EA8300", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD0EF00", Offset = "0xD0D900", VA = "0x180D0EF00", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9862B10", Offset = "0x9861510", VA = "0x189862B10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string HTCOJYWNBKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD0B7E0", Offset = "0xD0A1E0", VA = "0x180D0B7E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long VFNILJNFJXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xD142F0", Offset = "0xD12CF0", VA = "0x180D142F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string IBFJHGJJPHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCD0", Offset = "0xD0B6D0", VA = "0x180D0CCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCE0", Offset = "0xD0B6E0", VA = "0x180D0CCE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object QJBBQTCLIRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD14260", Offset = "0xD12C60", VA = "0x180D14260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD14280", Offset = "0xD12C80", VA = "0x180D14280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public NXPIPFBMDQY TOGOJBATGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD106A0", Offset = "0xD0F0A0", VA = "0x180D106A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9862CD0", Offset = "0x98616D0", VA = "0x189862CD0")]
		protected NXIJFYECKUX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9862C20", Offset = "0x9861620", VA = "0x189862C20")]
		protected NXIJFYECKUX(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9862B50", Offset = "0x9861550", VA = "0x189862B50")]
		protected NXIJFYECKUX(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9862930", Offset = "0x9861330", VA = "0x189862930")]
		protected void CAXRTBNXGHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9862980", Offset = "0x9861380", VA = "0x189862980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9862AE0", Offset = "0x98614E0", VA = "0x189862AE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9862A60", Offset = "0x9861460", VA = "0x189862A60", Slot = "4")]
		public bool Equals(NXIJFYECKUX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string AQVVMRJZATV(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class BUTGDZOLIPH<a, b> : NXIJFYECKUX where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class JUUTUQGAYFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public MRDAKWBRKMV IWDXOYFCTYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public BUTGDZOLIPH<a, b> AFKVCRAYCVS;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JUUTUQGAYFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x67C95C0", Offset = "0x67C7FC0", VA = "0x1867C95C0")]
			internal void WRDUVQHLBND()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a QJBBQTCLIRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4F0E690", Offset = "0x4F0D090", VA = "0x184F0E690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4F0E670", Offset = "0x4F0D070", VA = "0x184F0E670")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4F0E6E0", Offset = "0x4F0D0E0", VA = "0x184F0E6E0")]
		protected BUTGDZOLIPH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F0E790", Offset = "0x4F0D190", VA = "0x184F0E790")]
		protected BUTGDZOLIPH(string a, long b, string c, MPVTAJGPRUT<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void WKWOZBUTRZA(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4F0E620", Offset = "0x4F0D020", VA = "0x184F0E620")]
		private void FRYKDUSXTED(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4F0E600", Offset = "0x4F0D000", VA = "0x184F0E600")]
		[CompilerGenerated]
		private void AGVNVWEZAVC(string a)
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
	public class GURNFEUQTZF : BUTGDZOLIPH<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD75980", Offset = "0xD74380", VA = "0x180D75980", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9860E20", Offset = "0x985F820", VA = "0x189860E20")]
		public GURNFEUQTZF(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9860DB0", Offset = "0x985F7B0", VA = "0x189860DB0")]
		public GURNFEUQTZF(string a, long b, string c, MPVTAJGPRUT<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9860CE0", Offset = "0x985F6E0", VA = "0x189860CE0", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9860D50", Offset = "0x985F750", VA = "0x189860D50", Slot = "10")]
		protected override void WKWOZBUTRZA(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class YZCFSECMXWT : BUTGDZOLIPH<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD8F220", Offset = "0xD8DC20", VA = "0x180D8F220", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9866030", Offset = "0x9864A30", VA = "0x189866030")]
		public YZCFSECMXWT(string a, long b, string c, MPVTAJGPRUT<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9865F50", Offset = "0x9864950", VA = "0x189865F50", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9865FE0", Offset = "0x98649E0", VA = "0x189865FE0", Slot = "10")]
		protected override void WKWOZBUTRZA(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class QFPMZZAHVFO : BUTGDZOLIPH<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD75790", Offset = "0xD74190", VA = "0x180D75790", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x98637E0", Offset = "0x98621E0", VA = "0x1898637E0")]
		public QFPMZZAHVFO(string a, long b, string c, MPVTAJGPRUT<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9863680", Offset = "0x9862080", VA = "0x189863680", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9863770", Offset = "0x9862170", VA = "0x189863770", Slot = "10")]
		protected override void WKWOZBUTRZA(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ZFWCKFYLNRU : BUTGDZOLIPH<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD79590", Offset = "0xD77F90", VA = "0x180D79590", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9866110", Offset = "0x9864B10", VA = "0x189866110", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x98661E0", Offset = "0x9864BE0", VA = "0x1898661E0")]
		public ZFWCKFYLNRU(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9866230", Offset = "0x9864C30", VA = "0x189866230")]
		public ZFWCKFYLNRU(string a, long b, string c, MPVTAJGPRUT<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x98660A0", Offset = "0x9864AA0", VA = "0x1898660A0", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9866190", Offset = "0x9864B90", VA = "0x189866190", Slot = "10")]
		protected override void WKWOZBUTRZA(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class DIAKXXJWNJY : BUTGDZOLIPH<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] SJKPNGUBFIM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string VFWNBBLDBLS
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD0E930", Offset = "0xD0D330", VA = "0x180D0E930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD0E910", Offset = "0xD0D310", VA = "0x180D0E910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD76980", Offset = "0xD75380", VA = "0x180D76980", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9860990", Offset = "0x985F390", VA = "0x189860990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9860C90", Offset = "0x985F690", VA = "0x189860C90")]
		public DIAKXXJWNJY(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9860C20", Offset = "0x985F620", VA = "0x189860C20")]
		public DIAKXXJWNJY(string a, long b, string c, MPVTAJGPRUT<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x98608D0", Offset = "0x985F2D0", VA = "0x1898608D0", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9860B00", Offset = "0x985F500", VA = "0x189860B00", Slot = "10")]
		protected override void WKWOZBUTRZA(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class GRGLPKWKVXL<a> : OSSCMBZERRY where a : MGJPJSBRWJJ.TQBFSZUUJBV, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int UYZONXALEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x65036B0", Offset = "0x65020B0", VA = "0x1865036B0", Slot = "7")]
		private MGJPJSBRWJJ.TQBFSZUUJBV NUJVJDCFLNQ(MGJPJSBRWJJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x65037B0", Offset = "0x65021B0", VA = "0x1865037B0", Slot = "6")]
		private MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> RURBOLYTFAR(MGJPJSBRWJJ.TQBFSZUUJBV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6503550", Offset = "0x6501F50", VA = "0x186503550", Slot = "10")]
		public virtual a HPTUABHAWKN(MGJPJSBRWJJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6503810", Offset = "0x6502210", VA = "0x186503810", Slot = "11")]
		public virtual MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "12")]
		protected virtual void MXDXEBXXWYM(a a, MGJPJSBRWJJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6503630", Offset = "0x6502030", VA = "0x186503630", Slot = "13")]
		protected virtual MPVTAJGPRUT<string> LHXAAUSDWGK(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected GRGLPKWKVXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x65036D0", Offset = "0x65020D0", VA = "0x1865036D0")]
		[CompilerGenerated]
		private MGJPJSBRWJJ.QRAYLJSGGHD QVDZMJFXSPQ(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface OSSCMBZERRY
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int UYZONXALEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(MGJPJSBRWJJ.TQBFSZUUJBV a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MGJPJSBRWJJ.TQBFSZUUJBV HPTUABHAWKN(MGJPJSBRWJJ.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface BILXVGJBMGT : OSSCMBZERRY
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CCKWDJKHDCK(HKUJIUFCBEC a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : GRGLPKWKVXL<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class LGWFLJBEQNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool SFWGMFEBQCS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int NSPGBFPVLVB;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string SQFUYFSFYIV
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType MERZPCICCKQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xD0C6B0", Offset = "0xD0B0B0", VA = "0x180D0C6B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int GWXOKKXOIDJ
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x1656000", Offset = "0x1654A00", VA = "0x181656000")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1655FF0", Offset = "0x16549F0", VA = "0x181655FF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int JULQTQFGZNW
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD1B530", Offset = "0xD19F30", VA = "0x180D1B530")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD5E6E0", Offset = "0xD5D0E0", VA = "0x180D5E6E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string TBNSHEWLQMQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xD0CCD0", Offset = "0xD0B6D0", VA = "0x180D0CCD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xD0CCE0", Offset = "0xD0B6E0", VA = "0x180D0CCE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16CE1E0", Offset = "0x16CCBE0", VA = "0x1816CE1E0")]
			public LGWFLJBEQNJ()
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
		private readonly NFIQEQJDFAG EXMEOQYLAXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly WLLYXJMKWJS BDUXBDZLYSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly ULCBNTFYAAG FRNREOKJIUF;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int UYZONXALEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD76980", Offset = "0xD75380", VA = "0x180D76980", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6C0", Offset = "0xD0B0C0", VA = "0x180D0C6C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x98617B0", Offset = "0x98601B0", VA = "0x1898617B0")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] NFIQEQJDFAG roomsClient, [Inject(null)] WLLYXJMKWJS accountsClient, [Inject(null)] ULCBNTFYAAG imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9861770", Offset = "0x9860170", VA = "0x189861770", Slot = "11")]
		public override MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9860ED0", Offset = "0x985F8D0", VA = "0x189860ED0", Slot = "10")]
		public override TextMessageDetails HPTUABHAWKN(MGJPJSBRWJJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9860FF0", Offset = "0x985F9F0", VA = "0x189860FF0")]
		private void NRHMVAQKSLB(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : GRGLPKWKVXL<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int UYZONXALEIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD76980", Offset = "0xD75380", VA = "0x180D76980", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD76980", Offset = "0xD75380", VA = "0x180D76980", Slot = "9")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9862EA0", Offset = "0x98618A0", VA = "0x189862EA0")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : GRGLPKWKVXL<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int UYZONXALEIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD76980", Offset = "0xD75380", VA = "0x180D76980", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD75790", Offset = "0xD74190", VA = "0x180D75790", Slot = "9")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9863160", Offset = "0x9861B60", VA = "0x189863160", Slot = "12")]
		protected override void MXDXEBXXWYM(PhotoMessageDetails a, MGJPJSBRWJJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9863300", Offset = "0x9861D00", VA = "0x189863300")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : GRGLPKWKVXL<TextMessageDetails>, BILXVGJBMGT, OSSCMBZERRY
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class XXFQURQHRJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails CNZDSTBRCGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool TTTMFYVBMIZ;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public XXFQURQHRJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9865770", Offset = "0x9864170", VA = "0x189865770")]
			internal MGJPJSBRWJJ.QRAYLJSGGHD CTLFRIKGTMY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int RLTWTJSBGYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int BKCQNCHVRUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, HKUJIUFCBEC> HERIGFVNTRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, HKUJIUFCBEC> TNKBIXHJFUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private ZZYFQKDXTKJ<QFPMZZAHVFO> YGCXNFAYVOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ZZYFQKDXTKJ<DIAKXXJWNJY> BPZHRDHJSRM;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int UYZONXALEIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD75790", Offset = "0xD74190", VA = "0x180D75790", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "9")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9863C20", Offset = "0x9862620", VA = "0x189863C20", Slot = "14")]
		public void CCKWDJKHDCK(HKUJIUFCBEC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9864750", Offset = "0x9863150", VA = "0x189864750", Slot = "11")]
		public override MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9864330", Offset = "0x9862D30", VA = "0x189864330", Slot = "12")]
		protected override void MXDXEBXXWYM(TextMessageDetails a, MGJPJSBRWJJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x98641F0", Offset = "0x9862BF0", VA = "0x1898641F0")]
		private bool DCMAMYIRYSM(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9863FB0", Offset = "0x98629B0", VA = "0x189863FB0")]
		private static int CYXTZADUDIH(TextMessageDetails a, int b, bool c, HKUJIUFCBEC d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x98649F0", Offset = "0x98633F0", VA = "0x1898649F0")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class LFCCHXIKOEP<a> : ZZYFQKDXTKJ<a>, HKUJIUFCBEC, IEquatable<HKUJIUFCBEC>, IEquatable<ChatTokenType> where a : NXIJFYECKUX
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] XZOVITLLFZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string BSEZVYKPYMF;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType FBZUFKBONWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string IBNTRQMXZCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x69FAE30", Offset = "0x69F9830", VA = "0x1869FAE30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType VFZZDNIJBAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x69FAE10", Offset = "0x69F9810", VA = "0x1869FAE10", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x69FB7C0", Offset = "0x69FA1C0", VA = "0x1869FB7C0")]
		protected LFCCHXIKOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69FAD10", Offset = "0x69F9710", VA = "0x1869FAD10")]
		protected string CTZODMLGLDZ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69FAB50", Offset = "0x69F9550", VA = "0x1869FAB50", Slot = "14")]
		public bool CDBQJAFJOGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69FB530", Offset = "0x69F9F30", VA = "0x1869FB530", Slot = "15")]
		public void VSVKMVCIYMT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a XTRBPNFKLMG(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x69FB510", Offset = "0x69F9F10", VA = "0x1869FB510", Slot = "8")]
		private NXIJFYECKUX ULRFCBGXZBT(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool SCYMIRJSLXL(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string JJPKGSACKKV(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x69FB250", Offset = "0x69F9C50", VA = "0x1869FB250")]
		private bool QCFUAEILKBL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x69FB650", Offset = "0x69FA050", VA = "0x1869FB650")]
		private string ZTOADJMDVQH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x69FB330", Offset = "0x69F9D30", VA = "0x1869FB330", Slot = "6")]
		private bool QKTKMNDFCVP(string a, [Out] NXIJFYECKUX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x69FB100", Offset = "0x69F9B00", VA = "0x1869FB100", Slot = "7")]
		private void MORVTCAIUIM(NXIJFYECKUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x69FB0D0", Offset = "0x69F9AD0", VA = "0x1869FB0D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x69FAF30", Offset = "0x69F9930", VA = "0x1869FAF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69FB050", Offset = "0x69F9A50", VA = "0x1869FB050", Slot = "9")]
		public bool Equals(HKUJIUFCBEC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x69FAF00", Offset = "0x69F9900", VA = "0x1869FAF00", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : SVNDZFQUBDH<GURNFEUQTZF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly CXQXXTCFPIH EILQRWJNMSO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType FBZUFKBONWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xD75980", Offset = "0xD74380", VA = "0x180D75980", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FCF730", Offset = "0x1FCE130", VA = "0x181FCF730", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9860860", Offset = "0x985F260", VA = "0x189860860", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9860870", Offset = "0x985F270", VA = "0x189860870")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] CXQXXTCFPIH clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9860710", Offset = "0x985F110", VA = "0x189860710", Slot = "19")]
		protected override GURNFEUQTZF RAMMRIDQARU(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface HKUJIUFCBEC : IEquatable<HKUJIUFCBEC>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType FBZUFKBONWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string IBNTRQMXZCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CDBQJAFJOGY(string a, [Out] NXIJFYECKUX b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VSVKMVCIYMT(NXIJFYECKUX a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NXIJFYECKUX XTRBPNFKLMG(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface ZZYFQKDXTKJ<a> : HKUJIUFCBEC, IEquatable<HKUJIUFCBEC>, IEquatable<ChatTokenType> where a : NXIJFYECKUX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : SVNDZFQUBDH<YZCFSECMXWT>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly ULCBNTFYAAG FRNREOKJIUF;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType FBZUFKBONWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD8F220", Offset = "0xD8DC20", VA = "0x180D8F220", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2DF0", Offset = "0x1FE17F0", VA = "0x181FE2DF0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE199C0", Offset = "0xE183C0", VA = "0x180E199C0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9863030", Offset = "0x9861A30", VA = "0x189863030")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] ULCBNTFYAAG imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9862EE0", Offset = "0x98618E0", VA = "0x189862EE0", Slot = "19")]
		protected override YZCFSECMXWT RAMMRIDQARU(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : SVNDZFQUBDH<QFPMZZAHVFO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly WLLYXJMKWJS BDUXBDZLYSL;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType FBZUFKBONWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD75790", Offset = "0xD74190", VA = "0x180D75790", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2021C20", Offset = "0x2020620", VA = "0x182021C20", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9863450", Offset = "0x9861E50", VA = "0x189863450", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9863460", Offset = "0x9861E60", VA = "0x189863460")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] WLLYXJMKWJS accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9863340", Offset = "0x9861D40", VA = "0x189863340", Slot = "19")]
		protected override QFPMZZAHVFO RAMMRIDQARU(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : SVNDZFQUBDH<ZFWCKFYLNRU>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly FBUIYEYVYCF MRCRCDPOHQT;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType FBZUFKBONWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD79590", Offset = "0xD77F90", VA = "0x180D79590", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FCF730", Offset = "0x1FCE130", VA = "0x181FCF730", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9863610", Offset = "0x9862010", VA = "0x189863610", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9863620", Offset = "0x9862020", VA = "0x189863620")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] FBUIYEYVYCF playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x98634C0", Offset = "0x9861EC0", VA = "0x1898634C0", Slot = "19")]
		protected override ZFWCKFYLNRU RAMMRIDQARU(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : SVNDZFQUBDH<DIAKXXJWNJY>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly NFIQEQJDFAG EXMEOQYLAXF;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType FBZUFKBONWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD76980", Offset = "0xD75380", VA = "0x180D76980", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9863960", Offset = "0x9862360", VA = "0x189863960", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FBE930", Offset = "0x1FBD330", VA = "0x181FBE930", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9863970", Offset = "0x9862370", VA = "0x189863970")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] NFIQEQJDFAG roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9863850", Offset = "0x9862250", VA = "0x189863850", Slot = "19")]
		protected override DIAKXXJWNJY RAMMRIDQARU(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class SVNDZFQUBDH<a> : LFCCHXIKOEP<a> where a : NXIJFYECKUX
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5AB0", Offset = "0x7AD44B0", VA = "0x187AD5AB0", Slot = "16")]
		public override a XTRBPNFKLMG(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD58F0", Offset = "0x7AD42F0", VA = "0x187AD58F0", Slot = "18")]
		protected override string JJPKGSACKKV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5990", Offset = "0x7AD4390", VA = "0x187AD5990", Slot = "17")]
		protected override bool SCYMIRJSLXL(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a RAMMRIDQARU(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5AF0", Offset = "0x7AD44F0", VA = "0x187AD5AF0")]
		protected SVNDZFQUBDH()
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
