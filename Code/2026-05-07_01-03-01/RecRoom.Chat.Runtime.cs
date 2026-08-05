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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x96FB960", Offset = "0x96FA360", VA = "0x1896FB960")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
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
		[Cpp2IlInjected.Address(RVA = "0x96FEF00", Offset = "0x96FD900", VA = "0x1896FEF00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29F5EA0", Offset = "0x29F48A0", VA = "0x1829F5EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public TLBQOBCWRUV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x96FC5C0", Offset = "0x96FAFC0", VA = "0x1896FC5C0")]
			internal NXPIPFBMDQY CPGLNPCVXLO(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x96FC7E0", Offset = "0x96FB1E0", VA = "0x1896FC7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public XXFQURQHRJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x96FEB80", Offset = "0x96FD580", VA = "0x1896FEB80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public UONXUWZERAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x96FE330", Offset = "0x96FCD30", VA = "0x1896FE330")]
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
		[Cpp2IlInjected.Address(RVA = "0x96F91F0", Offset = "0x96F7BF0", VA = "0x1896F91F0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] WLLYXJMKWJS accountsClient, [Inject(null)] TEBAORIRPZU chatClient, [Inject(null)] CXQXXTCFPIH clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96F84E0", Offset = "0x96F6EE0", VA = "0x1896F84E0", Slot = "5")]
		public bool CFPQOGRQKRA(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96F8360", Offset = "0x96F6D60", VA = "0x1896F8360", Slot = "6")]
		public ChatMessage BAXUOVRESHW(long a, MGJPJSBRWJJ.TQBFSZUUJBV b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x96F8CC0", Offset = "0x96F76C0", VA = "0x1896F8CC0", Slot = "7")]
		public MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(MGJPJSBRWJJ.TQBFSZUUJBV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x96F8BC0", Offset = "0x96F75C0", VA = "0x1896F8BC0", Slot = "4")]
		public void RTBHCTLSFTO(OSSCMBZERRY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x96F88D0", Offset = "0x96F72D0", VA = "0x1896F88D0", Slot = "8")]
		public void JQPUCTRVBNN(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x96F86D0", Offset = "0x96F70D0", VA = "0x1896F86D0")]
		private MGJPJSBRWJJ.TQBFSZUUJBV HPTUABHAWKN(MGJPJSBRWJJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x96F8E30", Offset = "0x96F7830", VA = "0x1896F8E30")]
		private void YVBJNCRJHBY(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96F89C0", Offset = "0x96F73C0", VA = "0x1896F89C0")]
		private void OVYLKSWSPBX(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x96F9010", Offset = "0x96F7A10", VA = "0x1896F9010")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "10")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x96FBA80", Offset = "0x96FA480", VA = "0x1896FBA80")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x96FB9E0", Offset = "0x96FA3E0", VA = "0x1896FB9E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3C390", Offset = "0xD3AD90", VA = "0x180D3C390", Slot = "10")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string RKIPWBYWASD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xEF2A30", Offset = "0xEF1430", VA = "0x180EF2A30", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long SAPLEQVKYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x96FBC80", Offset = "0x96FA680", VA = "0x1896FBC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x96FBD40", Offset = "0x96FA740", VA = "0x1896FBD40")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x96FBD00", Offset = "0x96FA700", VA = "0x1896FBD00")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MVYYLRVUFRV
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x96FA410", Offset = "0x96F8E10", VA = "0x1896FA410")]
		[ONTQUCAGRJW.Root]
		internal static void YILWKTHVYDZ(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96FA6F0", Offset = "0x96F90F0", VA = "0x1896FA6F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x96F9A40", Offset = "0x96F8440", VA = "0x1896F9A40")]
			internal string MPJDGKPZXKK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] ONEZLJAZOCY;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96FAC90", Offset = "0x96F9690", VA = "0x1896FAC90")]
		public static MPVTAJGPRUT<string> ULTROZBKVQI(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x96FAD60", Offset = "0x96F9760", VA = "0x1896FAD60")]
		public static MPVTAJGPRUT<string> ULTROZBKVQI(MGJPJSBRWJJ.TQBFSZUUJBV a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96FB0B0", Offset = "0x96F9AB0", VA = "0x1896FB0B0")]
		private static string XXWUQIVFBOU(XPUPHVTMDGV a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x96FA920", Offset = "0x96F9320", VA = "0x1896FA920")]
		public static string QFXJFYLJEJQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96FAA30", Offset = "0x96F9430", VA = "0x1896FAA30")]
		public static string SHQNLXFTQVX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x96FA8B0", Offset = "0x96F92B0", VA = "0x1896FA8B0")]
		public static bool NQWOBBZNBDM(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x96FA840", Offset = "0x96F9240", VA = "0x1896FA840")]
		public static bool BRUVOABACKP(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x96FB080", Offset = "0x96F9A80", VA = "0x1896FB080")]
		public static bool WANGXSRGTPK(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x96FAB40", Offset = "0x96F9540", VA = "0x1896FAB40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x96FD890", Offset = "0x96FC290", VA = "0x1896FD890", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x96FD710", Offset = "0x96FC110", VA = "0x1896FD710", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x96FE1A0", Offset = "0x96FCBA0", VA = "0x1896FE1A0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x96FDEC0", Offset = "0x96FC8C0", VA = "0x1896FDEC0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x96FE090", Offset = "0x96FCA90", VA = "0x1896FE090")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x96FD7A0", Offset = "0x96FC1A0", VA = "0x1896FD7A0", Slot = "17")]
		public void SIGFKXXEIQE(NXIJFYECKUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x96FD9D0", Offset = "0x96FC3D0", VA = "0x1896FD9D0", Slot = "16")]
		public NXPIPFBMDQY UVGLGINBEDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x96FDDD0", Offset = "0x96FC7D0", VA = "0x1896FDDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE70C80", Offset = "0xE6F680", VA = "0x180E70C80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCD5F00", Offset = "0xCD4900", VA = "0x180CD5F00", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x96FB700", Offset = "0x96FA100", VA = "0x1896FB700", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long VFNILJNFJXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2F0", Offset = "0xCD9CF0", VA = "0x180CDB2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string IBFJHGJJPHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object QJBBQTCLIRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCDB280", Offset = "0xCD9C80", VA = "0x180CDB280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public NXPIPFBMDQY TOGOJBATGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCD76A0", Offset = "0xCD60A0", VA = "0x180CD76A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x96FB8C0", Offset = "0x96FA2C0", VA = "0x1896FB8C0")]
		protected NXIJFYECKUX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x96FB810", Offset = "0x96FA210", VA = "0x1896FB810")]
		protected NXIJFYECKUX(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x96FB740", Offset = "0x96FA140", VA = "0x1896FB740")]
		protected NXIJFYECKUX(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x96FB520", Offset = "0x96F9F20", VA = "0x1896FB520")]
		protected void CAXRTBNXGHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x96FB570", Offset = "0x96F9F70", VA = "0x1896FB570", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x96FB6D0", Offset = "0x96FA0D0", VA = "0x1896FB6D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x96FB650", Offset = "0x96FA050", VA = "0x1896FB650", Slot = "4")]
		public bool Equals(NXIJFYECKUX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JUUTUQGAYFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6716B10", Offset = "0x6715510", VA = "0x186716B10")]
			internal void WRDUVQHLBND()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a QJBBQTCLIRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1170", Offset = "0x4ECFB70", VA = "0x184ED1170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1150", Offset = "0x4ECFB50", VA = "0x184ED1150")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4ED11C0", Offset = "0x4ECFBC0", VA = "0x184ED11C0")]
		protected BUTGDZOLIPH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1270", Offset = "0x4ECFC70", VA = "0x184ED1270")]
		protected BUTGDZOLIPH(string a, long b, string c, MPVTAJGPRUT<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void WKWOZBUTRZA(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1100", Offset = "0x4ECFB00", VA = "0x184ED1100")]
		private void FRYKDUSXTED(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4ED10E0", Offset = "0x4ECFAE0", VA = "0x184ED10E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3C580", Offset = "0xD3AF80", VA = "0x180D3C580", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x96F99F0", Offset = "0x96F83F0", VA = "0x1896F99F0")]
		public GURNFEUQTZF(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x96F9980", Offset = "0x96F8380", VA = "0x1896F9980")]
		public GURNFEUQTZF(string a, long b, string c, MPVTAJGPRUT<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x96F98B0", Offset = "0x96F82B0", VA = "0x1896F98B0", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x96F9920", Offset = "0x96F8320", VA = "0x1896F9920", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD55EB0", Offset = "0xD548B0", VA = "0x180D55EB0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x96FEC90", Offset = "0x96FD690", VA = "0x1896FEC90")]
		public YZCFSECMXWT(string a, long b, string c, MPVTAJGPRUT<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x96FEBB0", Offset = "0x96FD5B0", VA = "0x1896FEBB0", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x96FEC40", Offset = "0x96FD640", VA = "0x1896FEC40", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3C390", Offset = "0xD3AD90", VA = "0x180D3C390", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x96FC3D0", Offset = "0x96FADD0", VA = "0x1896FC3D0")]
		public QFPMZZAHVFO(string a, long b, string c, MPVTAJGPRUT<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x96FC270", Offset = "0x96FAC70", VA = "0x1896FC270", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x96FC360", Offset = "0x96FAD60", VA = "0x1896FC360", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD401E0", Offset = "0xD3EBE0", VA = "0x180D401E0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x96FED70", Offset = "0x96FD770", VA = "0x1896FED70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x96FEE40", Offset = "0x96FD840", VA = "0x1896FEE40")]
		public ZFWCKFYLNRU(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x96FEE90", Offset = "0x96FD890", VA = "0x1896FEE90")]
		public ZFWCKFYLNRU(string a, long b, string c, MPVTAJGPRUT<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x96FED00", Offset = "0x96FD700", VA = "0x1896FED00", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x96FEDF0", Offset = "0x96FD7F0", VA = "0x1896FEDF0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x96F9540", Offset = "0x96F7F40", VA = "0x1896F9540", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x96F9860", Offset = "0x96F8260", VA = "0x1896F9860")]
		public DIAKXXJWNJY(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x96F97F0", Offset = "0x96F81F0", VA = "0x1896F97F0")]
		public DIAKXXJWNJY(string a, long b, string c, MPVTAJGPRUT<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x96F9480", Offset = "0x96F7E80", VA = "0x1896F9480", Slot = "9")]
		public override string AQVVMRJZATV(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x96F96C0", Offset = "0x96F80C0", VA = "0x1896F96C0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6445010", Offset = "0x6443A10", VA = "0x186445010", Slot = "7")]
		private MGJPJSBRWJJ.TQBFSZUUJBV NUJVJDCFLNQ(MGJPJSBRWJJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6445110", Offset = "0x6443B10", VA = "0x186445110", Slot = "6")]
		private MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> RURBOLYTFAR(MGJPJSBRWJJ.TQBFSZUUJBV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6444EB0", Offset = "0x64438B0", VA = "0x186444EB0", Slot = "10")]
		public virtual a HPTUABHAWKN(MGJPJSBRWJJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6445170", Offset = "0x6443B70", VA = "0x186445170", Slot = "11")]
		public virtual MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "12")]
		protected virtual void MXDXEBXXWYM(a a, MGJPJSBRWJJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6444F90", Offset = "0x6443990", VA = "0x186444F90", Slot = "13")]
		protected virtual MPVTAJGPRUT<string> LHXAAUSDWGK(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		protected GRGLPKWKVXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6445030", Offset = "0x6443A30", VA = "0x186445030")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType MERZPCICCKQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCD36B0", Offset = "0xCD20B0", VA = "0x180CD36B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int GWXOKKXOIDJ
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x1625A70", Offset = "0x1624470", VA = "0x181625A70")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1625A60", Offset = "0x1624460", VA = "0x181625A60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int JULQTQFGZNW
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xCE2550", Offset = "0xCE0F50", VA = "0x180CE2550")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD251B0", Offset = "0xD23BB0", VA = "0x180D251B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string TBNSHEWLQMQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x169DF80", Offset = "0x169C980", VA = "0x18169DF80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x96FA380", Offset = "0x96F8D80", VA = "0x1896FA380")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] NFIQEQJDFAG roomsClient, [Inject(null)] WLLYXJMKWJS accountsClient, [Inject(null)] ULCBNTFYAAG imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x96FA340", Offset = "0x96F8D40", VA = "0x1896FA340", Slot = "11")]
		public override MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x96F9AA0", Offset = "0x96F84A0", VA = "0x1896F9AA0", Slot = "10")]
		public override TextMessageDetails HPTUABHAWKN(MGJPJSBRWJJ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x96F9BC0", Offset = "0x96F85C0", VA = "0x1896F9BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "9")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x96FBA90", Offset = "0x96FA490", VA = "0x1896FBA90")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD3C390", Offset = "0xD3AD90", VA = "0x180D3C390", Slot = "9")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x96FBD50", Offset = "0x96FA750", VA = "0x1896FBD50", Slot = "12")]
		protected override void MXDXEBXXWYM(PhotoMessageDetails a, MGJPJSBRWJJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x96FBEF0", Offset = "0x96FA8F0", VA = "0x1896FBEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public XXFQURQHRJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x96FE3B0", Offset = "0x96FCDB0", VA = "0x1896FE3B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3C390", Offset = "0xD3AD90", VA = "0x180D3C390", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override MGJPJSBRWJJ.MessageContentType JVVYVWBIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "9")]
			get
			{
				return default(MGJPJSBRWJJ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x96FC810", Offset = "0x96FB210", VA = "0x1896FC810", Slot = "14")]
		public void CCKWDJKHDCK(HKUJIUFCBEC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x96FD350", Offset = "0x96FBD50", VA = "0x1896FD350", Slot = "11")]
		public override MPVTAJGPRUT<MGJPJSBRWJJ.QRAYLJSGGHD> SAGZBJEDZCC(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x96FCF20", Offset = "0x96FB920", VA = "0x1896FCF20", Slot = "12")]
		protected override void MXDXEBXXWYM(TextMessageDetails a, MGJPJSBRWJJ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x96FCDE0", Offset = "0x96FB7E0", VA = "0x1896FCDE0")]
		private bool DCMAMYIRYSM(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x96FCBA0", Offset = "0x96FB5A0", VA = "0x1896FCBA0")]
		private static int CYXTZADUDIH(TextMessageDetails a, int b, bool c, HKUJIUFCBEC d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x96FD5F0", Offset = "0x96FBFF0", VA = "0x1896FD5F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x69415E0", Offset = "0x693FFE0", VA = "0x1869415E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x69415C0", Offset = "0x693FFC0", VA = "0x1869415C0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6941F60", Offset = "0x6940960", VA = "0x186941F60")]
		protected LFCCHXIKOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69414C0", Offset = "0x693FEC0", VA = "0x1869414C0")]
		protected string CTZODMLGLDZ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6941300", Offset = "0x693FD00", VA = "0x186941300", Slot = "14")]
		public bool CDBQJAFJOGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6941CD0", Offset = "0x69406D0", VA = "0x186941CD0", Slot = "15")]
		public void VSVKMVCIYMT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a XTRBPNFKLMG(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6941CB0", Offset = "0x69406B0", VA = "0x186941CB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6941A00", Offset = "0x6940400", VA = "0x186941A00")]
		private bool QCFUAEILKBL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6941DF0", Offset = "0x69407F0", VA = "0x186941DF0")]
		private string ZTOADJMDVQH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6941AE0", Offset = "0x69404E0", VA = "0x186941AE0", Slot = "6")]
		private bool QKTKMNDFCVP(string a, [Out] NXIJFYECKUX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x69418B0", Offset = "0x69402B0", VA = "0x1869418B0", Slot = "7")]
		private void MORVTCAIUIM(NXIJFYECKUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6941880", Offset = "0x6940280", VA = "0x186941880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x69416E0", Offset = "0x69400E0", VA = "0x1869416E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6941800", Offset = "0x6940200", VA = "0x186941800", Slot = "9")]
		public bool Equals(HKUJIUFCBEC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x69416B0", Offset = "0x69400B0", VA = "0x1869416B0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3C580", Offset = "0xD3AF80", VA = "0x180D3C580", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA76C0", Offset = "0x1FA60C0", VA = "0x181FA76C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x96F9410", Offset = "0x96F7E10", VA = "0x1896F9410", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x96F9420", Offset = "0x96F7E20", VA = "0x1896F9420")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] CXQXXTCFPIH clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x96F92C0", Offset = "0x96F7CC0", VA = "0x1896F92C0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD55EB0", Offset = "0xD548B0", VA = "0x180D55EB0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAD20", Offset = "0x1FB9720", VA = "0x181FBAD20", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xDE2330", Offset = "0xDE0D30", VA = "0x180DE2330", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x96FBC20", Offset = "0x96FA620", VA = "0x1896FBC20")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] ULCBNTFYAAG imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x96FBAD0", Offset = "0x96FA4D0", VA = "0x1896FBAD0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3C390", Offset = "0xD3AD90", VA = "0x180D3C390", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FF9BB0", Offset = "0x1FF85B0", VA = "0x181FF9BB0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x96FC040", Offset = "0x96FAA40", VA = "0x1896FC040", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x96FC050", Offset = "0x96FAA50", VA = "0x1896FC050")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] WLLYXJMKWJS accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x96FBF30", Offset = "0x96FA930", VA = "0x1896FBF30", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD401E0", Offset = "0xD3EBE0", VA = "0x180D401E0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FA76C0", Offset = "0x1FA60C0", VA = "0x181FA76C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x96FC200", Offset = "0x96FAC00", VA = "0x1896FC200", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x96FC210", Offset = "0x96FAC10", VA = "0x1896FC210")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] FBUIYEYVYCF playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x96FC0B0", Offset = "0x96FAAB0", VA = "0x1896FC0B0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char DMKAZVQLXTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x96FC550", Offset = "0x96FAF50", VA = "0x1896FC550", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char AVODEUKXPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F96870", Offset = "0x1F95270", VA = "0x181F96870", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x96FC560", Offset = "0x96FAF60", VA = "0x1896FC560")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] NFIQEQJDFAG roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x96FC440", Offset = "0x96FAE40", VA = "0x1896FC440", Slot = "19")]
		protected override DIAKXXJWNJY RAMMRIDQARU(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class SVNDZFQUBDH<a> : LFCCHXIKOEP<a> where a : NXIJFYECKUX
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7990F40", Offset = "0x798F940", VA = "0x187990F40", Slot = "16")]
		public override a XTRBPNFKLMG(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7990D80", Offset = "0x798F780", VA = "0x187990D80", Slot = "18")]
		protected override string JJPKGSACKKV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7990E20", Offset = "0x798F820", VA = "0x187990E20", Slot = "17")]
		protected override bool SCYMIRJSLXL(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a RAMMRIDQARU(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7990F80", Offset = "0x798F980", VA = "0x187990F80")]
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
